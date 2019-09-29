using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarksDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {

        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();

            adapter.Insert( item.URL, item.Title);
        }

        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();

            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.Title = row.Title;
                item.URL = row.URL;
                item.Id = row.Id;

                results.Add(item);
            }

            return results;


        }



        public static void RemoveItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Delete(item.Id);
        }

        public static void RemoveBookmarkManager(string item)
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                string bookMarkEntry = string.Format("{0} ({1})", row.Title, row.URL);
                if (bookMarkEntry == item)
                {
                    adapter.Delete(row.Id);
                }
            }


        }

    }
}
