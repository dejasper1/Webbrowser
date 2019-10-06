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
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            bookmarkListBox1.Items.Clear();

            foreach (var item in items)
            {
                bookmarkListBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearchBookmark.Text;
            bookmarkListBox1.Items.Clear();
            var items = BookmarkManager.GetItems();
            foreach (var item in items)
            {
                if (item.URL.ToString().ToLower().Contains(searchQuery.ToLower()))
                {
                    bookmarkListBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));

                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string item = bookmarkListBox1.GetItemText(bookmarkListBox1.SelectedItem);
            BookmarkManager.RemoveBookmarkManager(item);
            bookmarkListBox1.Items.RemoveAt(bookmarkListBox1.SelectedIndex);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
