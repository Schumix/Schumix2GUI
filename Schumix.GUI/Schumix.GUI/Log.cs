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

        private static string GetTime()
        {
            return String.Format("{0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

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
                    form.textBox_Log.Text += String.Format("{0}{1}", format, 
                        Environment.NewLine);
                }
            }
        }

        public static void Success(string source, string format)
        {
            lock (WriteLock)
            {
                form.textBox_Log.ForeColor = System.Drawing.Color.Gray;
                form.textBox_Log.Text += GetTime();
                form.textBox_Log.ForeColor = System.Drawing.Color.Green;
                form.textBox_Log.Text += String.Format(" S");
                form.textBox_Log.ForeColor = System.Drawing.Color.White;
                form.textBox_Log.Text += String.Format(" {0}: ", source);
                form.textBox_Log.Text += String.Format("{0}{1}", format,
                    Environment.NewLine);
            }
        }

        public static void Warning(string source, string format)
        {
            lock (WriteLock)
            {
                form.textBox_Log.ForeColor = System.Drawing.Color.Gray;
                form.textBox_Log.Text += GetTime();
                form.textBox_Log.ForeColor = System.Drawing.Color.Yellow;
                form.textBox_Log.Text += String.Format(" W");
                form.textBox_Log.ForeColor = System.Drawing.Color.White;
                form.textBox_Log.Text += String.Format(" {0}: ", source);
                form.textBox_Log.ForeColor = System.Drawing.Color.Yellow;
                form.textBox_Log.Text += String.Format("{0}{1}", format,
                    Environment.NewLine);
                form.textBox_Log.ForeColor = System.Drawing.Color.Gray;
            }
        }

        public static void Error(string source, string format)
        {
            lock (WriteLock)
            {
                form.textBox_Log.ForeColor = System.Drawing.Color.Gray;
                form.textBox_Log.Text += GetTime();
                form.textBox_Log.ForeColor = System.Drawing.Color.Red;
                form.textBox_Log.Text += String.Format(" E");
                form.textBox_Log.ForeColor = System.Drawing.Color.White;
                form.textBox_Log.Text += String.Format(" {0}: ", source);
                form.textBox_Log.ForeColor = System.Drawing.Color.Red;
                form.textBox_Log.Text += String.Format("{0}{1}", format,
                    Environment.NewLine);
                form.textBox_Log.ForeColor = System.Drawing.Color.Gray;
            }
        }

        public static void Debug(string source, string format)
        {
            lock (WriteLock)
            {
                form.textBox_Log.ForeColor = System.Drawing.Color.Gray;
                form.textBox_Log.Text += GetTime();
                form.textBox_Log.ForeColor = System.Drawing.Color.Blue;
                form.textBox_Log.Text += String.Format(" D");
                form.textBox_Log.ForeColor = System.Drawing.Color.White;
                form.textBox_Log.Text += String.Format(" {0}: ", source);
                form.textBox_Log.ForeColor = System.Drawing.Color.Blue;
                form.textBox_Log.Text += String.Format("{0}{1}", format,
                    Environment.NewLine);
                form.textBox_Log.ForeColor = System.Drawing.Color.Gray;
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
