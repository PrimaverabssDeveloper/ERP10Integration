using Primavera.Platform.Helpers;
using System;
using System.Windows.Forms;

namespace Primavera.PlatformSamples.Helpers
{
    public static class ExceptionHelper
    {
        /// <summary>
        /// Shows the error message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="title">The title.</param>
        /// <param name="frm">The FRM.</param>
        public static void ShowErrorMessage(string message, string title, Form frm)
        {
            if (PriEngine.Platform == null)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PriEngine.Platform.AlertNotificationManager.ShowCustomAlert(title, message, Properties.Resources.error, frm);
            }

            StdLoggingHandler.FileTrace($"ERROR: {title} | {message}");
        }

        /// <summary>
        /// Shows the error message.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <param name="title">The title.</param>
        /// <param name="frm">The FRM.</param>
        public static void ShowErrorMessage(Exception ex, string title, Form frm)
        {
            if (PriEngine.Platform == null)
            {
                MessageBox.Show(StdLoggingHandler.FullMessageFromException(ex), title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PriEngine.Platform.AlertNotificationManager.ShowCustomAlert(title, ex.Message, Properties.Resources.error, frm);
            }

            StdLoggingHandler.FileTraceIgnoredException(ex);
        }

    }
}
