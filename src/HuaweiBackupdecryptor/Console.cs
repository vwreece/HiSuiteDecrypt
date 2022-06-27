using System;
using System.Windows.Forms;

namespace HuaweiBackupdecryptor
{
    public static class Console
    {
        public static TextBox? TxtBoxOut { get; set; }
        public static int WindowWidth => TxtBoxOut?.Width ?? 0;
        public static void WriteLine(string line)
        {
            TxtBoxOut.Text += line + Environment.NewLine;
        }

        public static void Write(string text)
        {
            TxtBoxOut.Text += text;
        }
    }
}