using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schumix.GUI
{
    public sealed class Log
    {
        private static readonly object WriteLock = new object();

        public static MainForm form;

        /// <returns>
        /// A visszat�r�si �rt�k az aktu�lis d�tum.
        /// </returns>
        private static string GetTime()
        {
            return String.Format("{0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

        /// <summary>
        /// D�tummal logolja a sz�veget meghat�rozva honnan sz�rmazik.
        /// Lehet ez egy�nileg meghat�rozott f�ggv�ny vagy class n�vvel ell�tva.
        /// Logol a Console-ra.
        /// </summary>
        /// <param name="source">
        /// Meghat�rozza honnan sz�rmazik a log.
        /// <example>
        /// 17:28 N <c>Config:</c> Config file bet�lt�se...
        /// </example>
        /// </param>
        /// <param name="format">
        /// A sz�veg amit ki�runk.
        /// <example>
        /// 17:28 N Config: <c>Config file bet�lt�se...</c>
        /// </example>
        /// </param>
        public static void Notice(string source, string format)
        {
            lock (WriteLock)
            {
                if (form != null)
                {
                    //form.TextOnTextBox_Log = "";
                    form.textBox_Log.ForeColor = System.Drawing.Color.Gray;
                    form.textBox_Log.Text += GetTime();
                    form.textBox_Log.ForeColor = System.Drawing.Color.White;
                    form.textBox_Log.Text += String.Format(" N {0}: ", source);
                    form.textBox_Log.ForeColor = System.Drawing.Color.Gray;
                    form.textBox_Log.Text += String.Format("{0}\n", format);
                }
            }
        }

        public static void Success(string source, string format)
        {
            lock (WriteLock)
            {
                
            }
        }

        public static void Warning(string source, string format)
        {
            lock (WriteLock)
            {

            }
        }

        public static void Error(string source, string format)
        {
            lock (WriteLock)
            {

            }
        }

        public static void Debug(string source, string format)
        {
            lock (WriteLock)
            {
                
            }
        }

        public static void Notice(string source, string format, params object[] args)
        {
            lock (WriteLock)
            {
                Notice(source, String.Format(format, args));
            }
        }

        public static void Success(string source, string format, params object[] args)
        {
            lock (WriteLock)
            {
                Success(source, String.Format(format, args));
            }
        }

        public static void Warning(string source, string format, params object[] args)
        {
            lock (WriteLock)
            {
                Warning(source, String.Format(format, args));
            }
        }

        public static void Error(string source, string format, params object[] args)
        {
            lock (WriteLock)
            {
                Error(source, String.Format(format, args));
            }
        }

        public static void Debug(string source, string format, params object[] args)
        {
            lock (WriteLock)
            {
                Debug(source, String.Format(format, args));
            }
        } 
    }
}
