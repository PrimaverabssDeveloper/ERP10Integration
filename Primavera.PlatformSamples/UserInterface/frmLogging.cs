using Primavera.Platform.Helpers;
using System;
using System.IO;
using System.Windows.Forms;

namespace Primavera.PlatformSamples.UserInterface
{
    public partial class frmLogging : Form
    {
        public frmLogging()
        {
            InitializeComponent();
        }                

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbIsActive_CheckedChanged(object sender, EventArgs e)
        {
            linkActivate.Enabled = !ckbIsActive.Checked;
            linkDeactivate.Enabled = ckbIsActive.Checked;

            if (ckbIsActive.Checked)
            {
                txtLogFile.Text = StdLoggingHandler.GetActiveLogFile();
            }
            else
            {
                txtLogFile.ResetText();
                txtPreview.ResetText();
            }
        }

        private void frmLogging_Load(object sender, EventArgs e)
        {
            ckbIsActive.Checked = StdLoggingHandler.LogIsActive;
            cbbLogType.SelectedIndex = 0;
        }

        private void linkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StdLoggingHandler.ClearLogFile();
            btReload_Click(sender, EventArgs.Empty);
        }

        private void linkDeactivate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StdLoggingHandler.DeactivateLog();
        }

        private void linkActivate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StdLoggingHandler.ActivateLog();
            btReload_Click(sender, EventArgs.Empty);
        }

        private string GetMessage()
        {
            if (string.IsNullOrEmpty(txtMessage.Text)) return "Empty message to log!!";
            return txtMessage.Text;
        }

        private void SimulateException()
        {
            try
            {
                File.ReadAllLines("notexistingfile");
            }
            catch (Exception ex)
            {
                StdLoggingHandler.FileTrace(ex);
            }
        }

        private void SimulateExceptionIgnored()
        {
            try
            {
                File.ReadAllLines("notexistingfile");
            }
            catch (Exception ex)
            {
                StdLoggingHandler.FileTraceIgnoredException(ex);
            }
        }

        private void SimulateExceptionThrowed()
        {
            try
            {
                File.ReadAllLines("notexistingfile");
            }
            catch (Exception ex)
            {
                StdLoggingHandler.FileTraceWithThrow(ex);
            }
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            txtPreview.ResetText();
            txtPreview.AppendText(StdLoggingHandler.GetActiveLogTail(50));
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            switch (cbbLogType.SelectedIndex)
            {
                case 0:
                    StdLoggingHandler.FileTrace(GetMessage());
                    break;

                case 1:
                    StdLoggingHandler.Indent();
                    StdLoggingHandler.FileTrace(GetMessage());
                    StdLoggingHandler.Outdent();
                    break;

                case 2:
                    StdLoggingHandler.FileTrace("Enter method can be called with or withou message");
                    StdLoggingHandler.FileTraceEnterMethod();
                    StdLoggingHandler.FileTraceEnterMethod(GetMessage());
                    break;

                case 3:
                    StdLoggingHandler.FileTrace("Exit method can be called with or withou message");
                    StdLoggingHandler.FileTraceExitMethod(GetMessage());
                    StdLoggingHandler.FileTraceExitMethod();
                    break;

                case 4:
                    SimulateException();
                    break;

                default:
                    break;
            }

            btReload_Click(sender, EventArgs.Empty);
        }

        private void btTraceIgnored_Click(object sender, EventArgs e)
        {
            SimulateExceptionIgnored();
            btReload_Click(sender, EventArgs.Empty);
        }

        private void btTraceThrow_Click(object sender, EventArgs e)
        {
            SimulateExceptionThrowed();
            btReload_Click(sender, EventArgs.Empty);
        }

        private void btTraceVerbosed_Click(object sender, EventArgs e)
        {
            StdLoggingHandler.FileTrace("Following trace is verbosed!");
            StdLoggingHandler.FileTraceVerbose(txtMessage.Text);
            btReload_Click(sender, EventArgs.Empty);
        }
    }
}
