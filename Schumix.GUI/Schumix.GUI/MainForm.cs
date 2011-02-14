using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schumix.GUI
{
    public partial class MainForm : Form
    {
        public string ToTheIRC { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Log.form = this;
        }

        /*public string TextOnTextBox_Log
        {
            get { return textBox_Log.Text; }
            set
            {
                textBox_Log.Text = value;
            }
        }*/

        /// <summary>
        /// Ha erre kattint vki akkor az ablak eltűnik és egy kis "tray icon"
        /// for megjelenni a tálca jobb oldalán.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        /// <summary>
        /// Ha erre kattint vki akkor a program bezárul.
        /// alapból csak egy sima Environment.Exit van benne de 
        /// ha akarod akkor te átírhatod a sajátodra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        /// <summary>
        /// mikor megvan hívva a MainForm class, akkor ez a függvény automatikusan elindul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void showWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void AddTabPage(string title)
        {
            TabPage newTabPage = new TabPage(title);
            tabControl.TabPages.Add(newTabPage);
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            Log.Notice("teszt", "teszt");

            textBox_Cmd.Text = "";
        }

        private void textBox_Cmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                textBox_Cmd.Text = ToTheIRC;

                // az enter lenyomva a parancssor textboxban, tehát a parancs feldolgozásra kerül,
                // ugyanúgy mintha a Küldés gombra kattintott volna
                Log.Notice("teszt", "teszt");

                textBox_Cmd.Text = "";
            }
        }
    }
}
