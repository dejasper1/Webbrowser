using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            listBox1.Items.Clear();
            foreach (var item in items)
            {
                listBox1.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String searchQuery = textBoxSearch.Text;
            listBox1.Items.Clear();
            var items = HistoryManager.GetItems();
            foreach (var item in items)
            {
                if (item.URL.ToString().ToLower().Contains(textBoxSearch.Text.ToLower()))
                {
                    listBox1.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));

                }
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string itemRemove = listBox1.GetItemText(listBox1.SelectedItem);
            HistoryManager.RemoveHistoryManager(itemRemove);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            HistoryManager.RemoveAllHistory();
            listBox1.Items.Clear();
            listBox1.EndUpdate();
            listBox1.Refresh();
        }
    }
}
