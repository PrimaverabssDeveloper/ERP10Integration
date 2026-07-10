using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Primavera.PlatformSamples.Models;
using Primavera.PlatformSamples.Services;

namespace Primavera.PlatformSamples.UserInterface
{
    public partial class frmPromptFunctionCRM : Form
    {
        // ── Services ──────────────────────────────────────────────────────────
        private readonly PrimaveraService _service = new PrimaveraService();

        // ── Controls ──────────────────────────────────────────────────────────
        private Panel _topBar;
        private Panel _sidePanel;
        private Panel _mainArea;
        private ListBox _listClientes;
        private Label _lblCount;
        private TextBox _txtSearch;
        private WebBrowser _webBrowser;
        private Panel _statusBar;
        private Label _lblStatus;
        private Button _btnRefresh;
        private Button _btnExport;
        private Panel _loadingOverlay;
        private Label _lblLoading;
        private System.Windows.Forms.Timer _dotTimer;

        // ── State ─────────────────────────────────────────────────────────────
        private List<Cliente> _allClientes = new List<Cliente>();
        private Cliente _selectedCliente;
        private string _currentMarkdown = string.Empty;
        private int _dotCount = 0;
        private int _hoveredIndex = -1;

        public frmPromptFunctionCRM()
        {
            InitializeComponent();
            BuildUI();
            LoadAppIcon();
            this.Load += MainForm_Load;
        }

        private void LoadAppIcon()
        {
            try
            {
                // Icon is embedded as a byte array — works from any working directory
                this.Icon = Resources.AppIcon.Load();
            }
            catch { /* icon is cosmetic — ignore errors */ }
        }

        // ─────────────────────────────────────────────────────────────────────
        // UI Construction
        // ─────────────────────────────────────────────────────────────────────
        private void BuildUI()
        {
            this.SuspendLayout();

            // ── 1. Top bar (Dock=Top — add first so it claims the top strip) ──
            _topBar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 52,
                BackColor = Color.FromArgb(15, 23, 42)
            };
            var lblBrand = new Label
            {
                Text = "⬡  CRM Primavera",
                ForeColor = Color.FromArgb(148, 163, 184),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 16)
            };
            var lblSep = new Label
            {
                Text = "›",
                ForeColor = Color.FromArgb(51, 65, 85),
                Font = new Font("Segoe UI", 12F),
                AutoSize = true,
                Location = new Point(148, 13)
            };
            var lblTitle = new Label
            {
                Text = "Credit Risk Analysis",
                ForeColor = Color.FromArgb(241, 245, 249),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(165, 15)
            };
            _topBar.Controls.AddRange(new Control[] { lblBrand, lblSep, lblTitle });

            // ── 2. Main area (Dock=Fill — MUST be added before Left panels) ───
            _mainArea = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(240, 242, 247)
            };

            // Status bar inside main area
            _statusBar = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 32,
                BackColor = Color.FromArgb(248, 250, 252)
            };
            var statusLine = new Panel
            {
                Dock = DockStyle.Top,
                Height = 1,
                BackColor = Color.FromArgb(226, 232, 240)
            };
            _lblStatus = new Label
            {
                Text = "Ready · Select a customer to generate the risk report.",
                ForeColor = Color.FromArgb(100, 116, 139),
                Font = new Font("Segoe UI", 8.5F),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(8, 0, 0, 0)
            };
            _btnExport = new Button
            {
                Text = "⬇  Export HTML",
                Dock = DockStyle.Right,
                Width = 140,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(248, 250, 252),
                ForeColor = Color.FromArgb(37, 99, 235),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Enabled = false
            };
            _btnExport.FlatAppearance.BorderSize = 0;
            _btnExport.Click += BtnExport_Click;
            _statusBar.Controls.AddRange(new Control[] { statusLine, _btnExport, _lblStatus });

            // WebBrowser
            _webBrowser = new WebBrowser
            {
                Dock = DockStyle.Fill,
                ScrollBarsEnabled = true,
                WebBrowserShortcutsEnabled = false,
                IsWebBrowserContextMenuEnabled = false,
                ScriptErrorsSuppressed = true   // ← suppress IE script errors
            };

            // Loading overlay (no Dock — sized manually)
            _loadingOverlay = new Panel
            {
                BackColor = Color.FromArgb(210, 240, 242, 247),
                Visible = false
            };
            _lblLoading = new Label
            {
                Text = "Generating report...",
                ForeColor = Color.FromArgb(37, 99, 235),
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            _loadingOverlay.Controls.Add(_lblLoading);

            // Add to main area (order matters for Dock)
            _mainArea.Controls.Add(_loadingOverlay);   // non-docked, sits on top
            _mainArea.Controls.Add(_webBrowser);       // Fill
            _mainArea.Controls.Add(_statusBar);        // Bottom

            // ── 3. Separator (Dock=Left) ──────────────────────────────────────
            var sideSep = new Panel
            {
                Dock = DockStyle.Left,
                Width = 1,
                BackColor = Color.FromArgb(226, 232, 240)
            };

            // ── 4. Side panel (Dock=Left) ─────────────────────────────────────
            _sidePanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 300,
                BackColor = Color.FromArgb(248, 250, 252)
            };

            // Side header
            var sideHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 56,
                BackColor = Color.FromArgb(30, 41, 59)
            };
            var lblSideTitle = new Label
            {
                Text = "Customers",
                ForeColor = Color.FromArgb(226, 232, 240),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(16, 10)
            };
            _lblCount = new Label
            {
                Text = "0 customers",
                ForeColor = Color.FromArgb(100, 116, 139),
                Font = new Font("Segoe UI", 8F),
                AutoSize = true,
                Location = new Point(16, 32)
            };
            sideHeader.Controls.AddRange(new Control[] { lblSideTitle, _lblCount });

            // Search strip
            // Search strip — fixed height, vertically centred textbox
            var searchStrip = new Panel
            {
                Dock = DockStyle.Top,
                Height = 48,
                BackColor = Color.FromArgb(30, 41, 59)   // same as side header
            };
            // Border panel — manually sized in Layout event so it tracks width
            var searchBorder = new Panel
            {
                BackColor = Color.FromArgb(248, 250, 252),
                Height = 32
            };
            searchBorder.Paint += (s2, ev) =>
            {
                var p = (Panel)s2;
                using (var pen = new Pen(Color.FromArgb(71, 85, 105)))
                    ev.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
            };
            // Keep searchBorder centred inside searchStrip when form resizes
            searchStrip.Layout += (s2, ev) =>
            {
                int margin = 12;
                searchBorder.SetBounds(margin, (searchStrip.Height - searchBorder.Height) / 2,
                                       searchStrip.Width - margin * 2, searchBorder.Height);
            };

            var lblSearchIco = new Label
            {
                Text = "🔍",
                AutoSize = false,
                Size = new Size(26, 30),
                Location = new Point(2, 1),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9F)
            };
            _txtSearch = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(248, 250, 252),
                ForeColor = Color.FromArgb(160, 174, 192),
                Font = new Font("Segoe UI", 9.5F),
                Text = "Search customer...",
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            };
            // Position textbox: leave room for icon on left, small margin on right
            searchBorder.Layout += (s2, ev) =>
            {
                var tb = _txtSearch;
                int iconW = lblSearchIco.Width;
                int tbH = tb.PreferredHeight;
                int tbY = (searchBorder.Height - tbH) / 2;
                tb.SetBounds(iconW + 2, tbY, searchBorder.Width - iconW - 8, tbH);
            };

            // Simulate placeholder for .NET 4.7.1
            _txtSearch.GotFocus += TxtSearch_GotFocus;
            _txtSearch.LostFocus += TxtSearch_LostFocus;
            _txtSearch.TextChanged += TxtSearch_TextChanged;
            searchBorder.Controls.AddRange(new Control[] { lblSearchIco, _txtSearch });
            searchStrip.Controls.Add(searchBorder);

            // Refresh button
            _btnRefresh = new Button
            {
                Text = "↺  Refresh list",
                Dock = DockStyle.Bottom,
                Height = 38,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            _btnRefresh.FlatAppearance.BorderSize = 0;
            _btnRefresh.Click += BtnRefresh_Click;

            // Client listbox
            _listClientes = new ListBox
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(248, 250, 252),
                Font = new Font("Segoe UI", 9.5F),
                ItemHeight = 52,
                DrawMode = DrawMode.OwnerDrawFixed,
                SelectionMode = SelectionMode.One,
                ScrollAlwaysVisible = false
            };
            _listClientes.DrawItem += ListClientes_DrawItem;
            _listClientes.MouseMove += ListClientes_MouseMove;
            _listClientes.SelectedIndexChanged += ListClientes_SelectedIndexChanged;

            // Add to side panel (order: header Top, search Top, refresh Bottom, list Fill)
            _sidePanel.Controls.Add(_listClientes);   // Fill
            _sidePanel.Controls.Add(_btnRefresh);     // Bottom
            _sidePanel.Controls.Add(searchStrip);     // Top (added after Fill so it stacks)
            _sidePanel.Controls.Add(sideHeader);      // Top

            // ── 5. Add everything to Form ─────────────────────────────────────
            // With WinForms Dock layout, add in this order:
            //   Top → Fill → Left (right-to-left within Left panels)
            this.Controls.Add(_mainArea);    // Fill
            this.Controls.Add(sideSep);      // Left
            this.Controls.Add(_sidePanel);   // Left
            this.Controls.Add(_topBar);      // Top

            // Dot timer for loading animation
            _dotTimer = new System.Windows.Forms.Timer { Interval = 400 };
            _dotTimer.Tick += DotTimer_Tick;

            this.ResumeLayout(false);

            ShowWelcomePage();
        }

        // ─────────────────────────────────────────────────────────────────────
        // Resize — keep loading overlay sized to main area
        // ─────────────────────────────────────────────────────────────────────
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_loadingOverlay != null && _mainArea != null)
            {
                _loadingOverlay.Size = _mainArea.ClientSize;
                _loadingOverlay.Location = Point.Empty;
            }
        }

        // ─────────────────────────────────────────────────────────────────────
        // Event Handlers
        // ─────────────────────────────────────────────────────────────────────
        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadClientesAsync();
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await LoadClientesAsync();
        }

        private bool _searchHasPlaceholder = true;

        private void TxtSearch_GotFocus(object sender, EventArgs e)
        {
            if (_searchHasPlaceholder)
            {
                _txtSearch.Text = "";
                _txtSearch.ForeColor = Color.FromArgb(55, 65, 81);
                _searchHasPlaceholder = false;
            }
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_txtSearch.Text))
            {
                _searchHasPlaceholder = true;
                _txtSearch.ForeColor = Color.FromArgb(160, 174, 192);
                _txtSearch.Text = "Search customer...";
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_searchHasPlaceholder) return;
            FilterClientes(_txtSearch.Text);
        }

        private async void ListClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_listClientes.SelectedItem is Cliente c)
            {
                _selectedCliente = c;
                await GenerateReportAsync(c);
            }
        }

        private void ListClientes_MouseMove(object sender, MouseEventArgs e)
        {
            int idx = _listClientes.IndexFromPoint(e.Location);
            if (idx != _hoveredIndex)
            {
                _hoveredIndex = idx;
                _listClientes.Invalidate();
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (_selectedCliente == null || string.IsNullOrEmpty(_currentMarkdown)) return;
            using (var dlg = new SaveFileDialog())
            {
                dlg.Title = "Export Report";
                dlg.Filter = "HTML File (*.html)|*.html";
                dlg.FileName = $"CreditRisk_{_selectedCliente.Codigo}_{DateTime.Now:yyyyMMdd}";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string body = MarkdownConverter.ToHtml(_currentMarkdown);
                    string page = ReportTemplate.BuildPage(_selectedCliente.Nome, _selectedCliente.Codigo, body);
                    File.WriteAllText(dlg.FileName, page, System.Text.Encoding.UTF8);
                    SetStatus($"✔  Report exported: {Path.GetFileName(dlg.FileName)}");

                    // Open in Windows default browser
                    System.Diagnostics.Process.Start(dlg.FileName);
                }
            }
        }

        private void DotTimer_Tick(object sender, EventArgs e)
        {
            _dotCount = (_dotCount % 3) + 1;
            string name = _selectedCliente?.Nome ?? "customer";
            if (_lblLoading.InvokeRequired)
                _lblLoading.Invoke(new Action(() => _lblLoading.Text = $"Generating report for {name}{new string('.', _dotCount)}"));
            else
                _lblLoading.Text = $"Generating report for {name}{new string('.', _dotCount)}";
        }

        // ─────────────────────────────────────────────────────────────────────
        // Data
        // ─────────────────────────────────────────────────────────────────────
        private async Task LoadClientesAsync()
        {
            SetStatus("Loading customers from ERP...");
            _btnRefresh.Enabled = false;
            _listClientes.Items.Clear();
            try
            {
                var list = await Task.Run(() => _service.ObterClientes());
                _allClientes = list ?? new List<Cliente>();
                PopulateList(_allClientes);
                SetStatus($"✔  {_allClientes.Count} customers loaded.");
            }
            catch (Exception ex)
            {
                SetStatus($"✖  Error loading customers: {ex.Message}");
                MessageBox.Show($"Unable to load customers.\n\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _btnRefresh.Enabled = true;
            }
        }

        private void PopulateList(List<Cliente> list)
        {
            _listClientes.Items.Clear();
            foreach (var c in list)
                _listClientes.Items.Add(c);
            _lblCount.Text = $"{list.Count} customer{(list.Count != 1 ? "s" : "")}";
        }

        private void FilterClientes(string query)
        {
            if (string.IsNullOrWhiteSpace(query)) { PopulateList(_allClientes); return; }
            query = query.ToLowerInvariant();
            var filtered = _allClientes.FindAll(c =>
                c.Nome.ToLowerInvariant().Contains(query) ||
                c.Codigo.ToLowerInvariant().Contains(query) ||
                (c.Nif != null && c.Nif.Contains(query)));
            PopulateList(filtered);
        }

        private async Task GenerateReportAsync(Cliente cliente)
        {
            ShowLoading(true);
            SetStatus($"Generating risk analysis for {cliente.Nome}...");
            _btnExport.Enabled = false;
            try
            {
                string markdown = await Task.Run(() => _service.ExecutarPrompt(cliente.Codigo));
                if (string.IsNullOrWhiteSpace(markdown))
                {
                    SetStatus("✖  No result for this customer.");
                    ShowWelcomePage();
                    return;
                }
                _currentMarkdown = markdown;
                string body = MarkdownConverter.ToHtml(markdown);
                string page = ReportTemplate.BuildPage(cliente.Nome, cliente.Codigo, body);
                _webBrowser.DocumentText = page;
                SetStatus($"✔  Report generated — {cliente.Nome}  ({cliente.Codigo})");
                _btnExport.Enabled = true;
            }
            catch (Exception ex)
            {
                SetStatus($"✖  Error: {ex.Message}");
                ShowErrorPage(ex.Message);
            }
            finally
            {
                ShowLoading(false);
            }
        }

        // ─────────────────────────────────────────────────────────────────────
        // Helpers
        // ─────────────────────────────────────────────────────────────────────
        private void SetStatus(string text)
        {
            if (_lblStatus.InvokeRequired)
                _lblStatus.Invoke(new Action(() => _lblStatus.Text = text));
            else
                _lblStatus.Text = text;
        }

        private void ShowLoading(bool visible)
        {
            if (_loadingOverlay.InvokeRequired)
            {
                _loadingOverlay.Invoke(new Action(() => ShowLoading(visible)));
                return;
            }
            _loadingOverlay.Size = _mainArea.ClientSize;
            _loadingOverlay.Location = Point.Empty;
            _loadingOverlay.Visible = visible;
            _loadingOverlay.BringToFront();
            if (visible) _dotTimer.Start();
            else _dotTimer.Stop();
        }

        private void ShowWelcomePage()
        {
            _webBrowser.DocumentText = @"<!DOCTYPE html>
<html lang='en'><head><meta charset='UTF-8'/>
<style>
  body{font-family:'Segoe UI',sans-serif;background:#f0f2f7;margin:0;
       display:flex;align-items:center;justify-content:center;height:100vh;}
  .c{text-align:center;color:#94a3b8;}
  .c .i{font-size:54px;margin-bottom:16px;}
  .c h2{font-size:17px;color:#475569;margin-bottom:8px;}
  .c p{font-size:13px;max-width:300px;margin:0 auto;line-height:1.6;}
</style></head><body>
<div class='c'><div class='i'>📊</div>
<h2>Select a customer</h2>
<p>Choose a customer from the list to generate the credit risk diagnosis.</p>
</div></body></html>";
        }

        private void ShowErrorPage(string message)
        {
            string safe = System.Web.HttpUtility.HtmlEncode(message);
            _webBrowser.DocumentText = $@"<!DOCTYPE html>
<html lang='en'><head><meta charset='UTF-8'/>
<style>
  body{{font-family:'Segoe UI',sans-serif;background:#f0f2f7;margin:0;
       display:flex;align-items:center;justify-content:center;height:100vh;}}
  .c{{text-align:center;}}
  .c .i{{font-size:46px;margin-bottom:14px;}}
  .c h2{{font-size:15px;color:#991b1b;margin-bottom:10px;}}
  .c p{{font-size:12px;color:#6b7280;background:#fee2e2;padding:12px 16px;
        border-radius:6px;max-width:380px;text-align:left;}}
</style></head><body>
<div class='c'><div class='i'>⚠️</div>
<h2>Error generating report</h2><p>{safe}</p>
</div></body></html>";
        }

        // ─────────────────────────────────────────────────────────────────────
        // Owner-draw list
        // ─────────────────────────────────────────────────────────────────────
        private void ListClientes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= _listClientes.Items.Count) return;

            var c = (Cliente)_listClientes.Items[e.Index];
            bool sel = (e.State & DrawItemState.Selected) != 0;
            bool hovered = e.Index == _hoveredIndex;

            Color bg = sel ? Color.FromArgb(37, 99, 235)
                     : hovered ? Color.FromArgb(241, 245, 249)
                               : Color.FromArgb(248, 250, 252);

            using (var b = new SolidBrush(bg))
                e.Graphics.FillRectangle(b, e.Bounds);

            if (sel)
                using (var b = new SolidBrush(Color.FromArgb(147, 197, 253)))
                    e.Graphics.FillRectangle(b, new Rectangle(e.Bounds.X, e.Bounds.Y, 3, e.Bounds.Height));

            // Avatar
            var av = new Rectangle(e.Bounds.X + 12, e.Bounds.Y + 10, 32, 32);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var b = new SolidBrush(sel ? Color.FromArgb(147, 197, 253) : Color.FromArgb(219, 234, 254)))
                e.Graphics.FillEllipse(b, av);

            string init = GetInitials(c.Nome);
            Color initColor = sel ? Color.FromArgb(30, 58, 138) : Color.FromArgb(37, 99, 235);
            using (var f = new Font("Segoe UI", 9F, FontStyle.Bold))
            using (var b = new SolidBrush(initColor))
            {
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                e.Graphics.DrawString(init, f, b, av, sf);
            }

            int tx = e.Bounds.X + 54;
            // Name
            Color nameCol = sel ? Color.White : Color.FromArgb(26, 29, 35);
            using (var f = new Font("Segoe UI", 9.5F, FontStyle.Bold))
            using (var b = new SolidBrush(nameCol))
            {
                var r = new Rectangle(tx, e.Bounds.Y + 8, e.Bounds.Width - tx - 10, 20);
                var sf = new StringFormat { Trimming = StringTrimming.EllipsisCharacter };
                e.Graphics.DrawString(c.Nome, f, b, r, sf);
            }

            // Code / NIF
            Color metaCol = sel ? Color.FromArgb(186, 230, 253) : Color.FromArgb(100, 116, 139);
            string meta = string.IsNullOrEmpty(c.Nif)
                ? $"Code {c.Codigo}"
                : $"Code {c.Codigo}  ·  Tax ID {c.Nif}";
            using (var f = new Font("Segoe UI", 8F))
            using (var b = new SolidBrush(metaCol))
            {
                var r = new Rectangle(tx, e.Bounds.Y + 28, e.Bounds.Width - tx - 10, 16);
                var sf = new StringFormat { Trimming = StringTrimming.EllipsisCharacter };
                e.Graphics.DrawString(meta, f, b, r, sf);
            }

            // Divider
            if (!sel)
                using (var p = new Pen(Color.FromArgb(226, 232, 240)))
                    e.Graphics.DrawLine(p, e.Bounds.X + 12, e.Bounds.Bottom - 1,
                                           e.Bounds.Right - 12, e.Bounds.Bottom - 1);
        }

        private static string GetInitials(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "?";
            var parts = name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return parts.Length == 1
                ? parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpper()
                : $"{parts[0][0]}{parts[parts.Length - 1][0]}".ToUpper();
        }
    }
}
