using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void ExitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a fully functioning web browser application built in Software Construction Fundamentals, 2019.");
        }



        private void MenuStrip1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // webBrowser1.Navigate(addressBox.Text.ToString());


            }
        }

        private void BrowserUserControl1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;

        }

        private void NewTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BrowserUserControl browserControl = new BrowserUserControl();

            string title = "TabPage " + (this.tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            myTabPage.Controls.Add(browserControl);
            this.tabControl1.TabPages.Add(myTabPage);

        }

        private void CloseCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
    

           this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
