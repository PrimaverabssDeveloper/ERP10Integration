using System.Text;
using System.Text.RegularExpressions;

namespace Primavera.PlatformSamples.Services
{
    /// <summary>
    /// Lightweight Markdown → HTML converter (subset needed for credit risk reports).
    /// Handles: headings, bold, italic, tables, unordered/ordered lists, blockquotes,
    /// horizontal rules and inline code. No external dependencies required.
    /// </summary>
    public static class MarkdownConverter
    {
        public static string ToHtml(string markdown)
        {
            if (string.IsNullOrWhiteSpace(markdown))
                return string.Empty;

            // Normalise line endings
            string md = markdown.Replace("\r\n", "\n").Replace("\r", "\n");

            // Split into blocks separated by blank lines
            string[] lines = md.Split('\n');
            StringBuilder html = new StringBuilder();
            int i = 0;

            while (i < lines.Length)
            {
                string line = lines[i];

                // ── Fenced code block (```) ──────────────────────────────────────
                if (line.TrimStart().StartsWith("```"))
                {
                    html.Append("<pre><code>");
                    i++;
                    while (i < lines.Length && !lines[i].TrimStart().StartsWith("```"))
                    {
                        html.AppendLine(EscapeHtml(lines[i]));
                        i++;
                    }
                    html.AppendLine("</code></pre>");
                    i++;
                    continue;
                }

                // ── Headings ─────────────────────────────────────────────────────
                var headingMatch = Regex.Match(line, @"^(#{1,6})\s+(.+)$");
                if (headingMatch.Success)
                {
                    int level = headingMatch.Groups[1].Length;
                    string text = InlineFormat(headingMatch.Groups[2].Value);
                    html.AppendLine($"<h{level}>{text}</h{level}>");
                    i++;
                    continue;
                }

                // ── Horizontal rule ──────────────────────────────────────────────
                if (Regex.IsMatch(line, @"^(\*{3,}|-{3,}|_{3,})\s*$"))
                {
                    html.AppendLine("<hr/>");
                    i++;
                    continue;
                }

                // ── Blockquote ───────────────────────────────────────────────────
                if (line.StartsWith(">"))
                {
                    html.Append("<blockquote>");
                    while (i < lines.Length && lines[i].StartsWith(">"))
                    {
                        html.Append(InlineFormat(lines[i].TrimStart('>', ' ')));
                        html.Append(" ");
                        i++;
                    }
                    html.AppendLine("</blockquote>");
                    continue;
                }

                // ── Table ─────────────────────────────────────────────────────────
                if (line.Contains("|") && i + 1 < lines.Length && lines[i + 1].Contains("|") &&
                    Regex.IsMatch(lines[i + 1], @"^\|?[\s\-|:]+\|?\s*$"))
                {
                    html.AppendLine("<table>");
                    // Header row
                    html.AppendLine("<thead><tr>");
                    foreach (string cell in SplitTableRow(line))
                        html.AppendLine($"<th>{InlineFormat(cell)}</th>");
                    html.AppendLine("</tr></thead>");
                    i += 2; // skip separator row
                    html.AppendLine("<tbody>");
                    while (i < lines.Length && lines[i].Contains("|") &&
                           !string.IsNullOrWhiteSpace(lines[i]))
                    {
                        html.AppendLine("<tr>");
                        foreach (string cell in SplitTableRow(lines[i]))
                            html.AppendLine($"<td>{InlineFormat(cell)}</td>");
                        html.AppendLine("</tr>");
                        i++;
                    }
                    html.AppendLine("</tbody></table>");
                    continue;
                }

                // ── Unordered list ───────────────────────────────────────────────
                if (Regex.IsMatch(line, @"^(\s*)[-*+]\s+"))
                {
                    html.AppendLine("<ul>");
                    while (i < lines.Length && Regex.IsMatch(lines[i], @"^(\s*)[-*+]\s+"))
                    {
                        string itemText = Regex.Replace(lines[i], @"^(\s*)[-*+]\s+", "");
                        html.AppendLine($"<li>{InlineFormat(itemText)}</li>");
                        i++;
                    }
                    html.AppendLine("</ul>");
                    continue;
                }

                // ── Ordered list ─────────────────────────────────────────────────
                if (Regex.IsMatch(line, @"^\d+\.\s+"))
                {
                    html.AppendLine("<ol>");
                    while (i < lines.Length && Regex.IsMatch(lines[i], @"^\d+\.\s+"))
                    {
                        string itemText = Regex.Replace(lines[i], @"^\d+\.\s+", "");
                        html.AppendLine($"<li>{InlineFormat(itemText)}</li>");
                        i++;
                    }
                    html.AppendLine("</ol>");
                    continue;
                }

                // ── Blank line ────────────────────────────────────────────────────
                if (string.IsNullOrWhiteSpace(line))
                {
                    i++;
                    continue;
                }

                // ── Paragraph ─────────────────────────────────────────────────────
                {
                    StringBuilder para = new StringBuilder();
                    while (i < lines.Length && !string.IsNullOrWhiteSpace(lines[i]) &&
                           !lines[i].StartsWith("#") && !lines[i].StartsWith(">") &&
                           !lines[i].Contains("|") &&
                           !Regex.IsMatch(lines[i], @"^(\s*)[-*+]\s+") &&
                           !Regex.IsMatch(lines[i], @"^\d+\.\s+") &&
                           !Regex.IsMatch(lines[i], @"^(\*{3,}|-{3,}|_{3,})\s*$"))
                    {
                        if (para.Length > 0) para.Append(" ");
                        para.Append(lines[i]);
                        i++;
                    }
                    if (para.Length > 0)
                        html.AppendLine($"<p>{InlineFormat(para.ToString())}</p>");
                }
            }

            return html.ToString();
        }

        // ── Inline formatting: bold, italic, inline code, links ────────────────
        private static string InlineFormat(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            // Escape HTML first
            text = EscapeHtml(text);

            // Bold + italic
            text = Regex.Replace(text, @"\*\*\*(.+?)\*\*\*", "<strong><em>$1</em></strong>");
            text = Regex.Replace(text, @"___(.+?)___", "<strong><em>$1</em></strong>");
            // Bold
            text = Regex.Replace(text, @"\*\*(.+?)\*\*", "<strong>$1</strong>");
            text = Regex.Replace(text, @"__(.+?)__", "<strong>$1</strong>");
            // Italic
            text = Regex.Replace(text, @"\*(.+?)\*", "<em>$1</em>");
            text = Regex.Replace(text, @"_(.+?)_", "<em>$1</em>");
            // Inline code
            text = Regex.Replace(text, @"`(.+?)`", "<code>$1</code>");
            // Links [text](url)
            text = Regex.Replace(text, @"\[(.+?)\]\((.+?)\)", "<a href=\"$2\">$1</a>");

            return text;
        }

        private static string EscapeHtml(string text)
        {
            return text
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;");
        }

        private static string[] SplitTableRow(string row)
        {
            // Remove leading/trailing pipes then split
            row = row.Trim().Trim('|');
            return row.Split('|');
        }
    }
}
