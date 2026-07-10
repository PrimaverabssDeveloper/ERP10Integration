using System;

namespace Primavera.PlatformSamples.Services
{
    public static class ReportTemplate
    {
        public static string BuildPage(string clienteNome, string clienteCodigo, string bodyHtml)
        {
            return $@"<!DOCTYPE html>
<html lang=""pt"">
<head>
<meta charset=""UTF-8""/>
<meta http-equiv=""X-UA-Compatible"" content=""IE=edge""/>
<title>Risco de Crédito</title>
<style>
*{{box-sizing:border-box;margin:0;padding:0;}}
body{{font-family:'Segoe UI',Tahoma,sans-serif;font-size:13.5px;line-height:1.65;
     color:#1a1d23;background:#f0f2f7;padding:0;}}

.top-bar{{background:#0f172a;color:#fff;padding:0 28px;height:52px;
          display:table;width:100%;}}
.top-bar-inner{{display:table-cell;vertical-align:middle;}}
.brand{{font-size:12px;font-weight:700;color:#94a3b8;letter-spacing:.05em;}}
.brand-sep{{color:#334155;margin:0 8px;}}
.client-name{{font-size:14px;font-weight:700;color:#f1f5f9;}}
.client-code{{font-size:12px;color:#64748b;margin-left:6px;}}

.page-wrap{{max-width:940px;margin:28px auto;padding:0 16px 48px;}}

.report-card{{background:#fff;border:1px solid #e2e8f0;
              -webkit-border-radius:8px;border-radius:8px;overflow:hidden;}}

.report-header{{background:#1e3a5f;color:#fff;padding:24px 32px 20px;}}
.rh-title{{font-size:17px;font-weight:700;color:#f8fafc;margin-bottom:4px;}}
.rh-sub{{font-size:12px;color:#94a3b8;}}

.report-body{{padding:28px 32px 32px;}}

.report-body h1{{font-size:19px;font-weight:700;color:#0f172a;
                 margin:0 0 18px;padding-bottom:8px;
                 border-bottom:2px solid #e2e8f0;}}
.report-body h2{{font-size:14px;font-weight:700;color:#1e3a5f;
                 margin:26px 0 10px;border-left:4px solid #2563eb;
                 padding-left:10px;}}
.report-body h3{{font-size:13px;font-weight:600;color:#334155;margin:16px 0 6px;}}

.report-body p{{margin:0 0 12px;color:#374151;}}

.report-body table{{width:100%;border-collapse:collapse;margin:10px 0 18px;
                    font-size:13px;}}
.report-body thead th{{background:#f1f5f9;color:#475569;font-weight:600;
                        font-size:11px;text-transform:uppercase;
                        letter-spacing:.04em;padding:8px 10px;text-align:left;
                        border-bottom:2px solid #e2e8f0;}}
.report-body tbody tr{{border-bottom:1px solid #f1f5f9;}}
.report-body tbody td{{padding:8px 10px;color:#374151;vertical-align:top;}}

.report-body ul,.report-body ol{{padding-left:20px;margin:6px 0 12px;}}
.report-body li{{margin-bottom:5px;color:#374151;}}

.report-body blockquote{{margin:10px 0 14px;padding:12px 16px;
                          background:#eff6ff;border-left:4px solid #2563eb;
                          color:#1e3a5f;font-weight:500;font-size:13.5px;}}

.report-body hr{{border:none;border-top:1px solid #e2e8f0;margin:20px 0;}}

.report-body strong{{font-weight:700;}}
.report-body em{{font-style:italic;}}
.report-body code{{font-family:Consolas,monospace;font-size:12px;
                   background:#f1f5f9;color:#be185d;padding:1px 4px;}}

/* Risk badges — applied server-side via C# */
.badge{{display:inline-block;padding:2px 8px;font-size:11px;font-weight:700;
        letter-spacing:.03em;text-transform:uppercase;}}
.badge-low     {{background:#dcfce7;color:#166534;}}
.badge-medium  {{background:#fef9c3;color:#854d0e;}}
.badge-high    {{background:#ffedd5;color:#9a3412;}}
.badge-critical{{background:#fee2e2;color:#991b1b;}}

.report-footer{{padding:12px 32px;background:#f8fafc;
                border-top:1px solid #e2e8f0;font-size:11px;color:#94a3b8;}}
</style>
</head>
<body>

<div class=""top-bar"">
  <div class=""top-bar-inner"">
    <span class=""brand"">CRM Primavera</span>
    <span class=""brand-sep"">›</span>
    <span class=""client-name"">{clienteNome}</span>
    <span class=""client-code"">({clienteCodigo})</span>
  </div>
</div>

<div class=""page-wrap"">
  <div class=""report-card"">
    <div class=""report-header"">
      <div class=""rh-title"">&#128202; Diagn&#243;stico de Risco de Cr&#233;dito</div>
      <div class=""rh-sub"">An&#225;lise gerada automaticamente &middot; {System.DateTime.Now:dd/MM/yyyy HH:mm}</div>
    </div>
    <div class=""report-body"">
      {bodyHtml}
    </div>
    <div class=""report-footer"">
      Cliente: <strong>{clienteCodigo}</strong> &mdash; {clienteNome} &nbsp;&nbsp;|&nbsp;&nbsp; Gerado em {System.DateTime.Now:dd MMM yyyy, HH:mm}
    </div>
  </div>
</div>

</body>
</html>";
        }
    }
}
