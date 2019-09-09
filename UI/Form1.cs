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

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void AddressBox_Click(object sender, EventArgs e)
        {
            addressBox.Text = "";
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(addressBox.Text.ToString());

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                webBrowser1.Navigate(addressBox.Text.ToString());


            }
        }

       

    }
}
