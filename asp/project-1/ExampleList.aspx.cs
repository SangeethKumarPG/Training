using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace project_1
{
    public partial class ExampleList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> listItems = new Dictionary<string, string>();
            listItems.Add("Item Key", "Item Value");
            listItems.Add("Item key1", "Item Value 1");
            foreach (var item in listItems) {
                ListBox1.Items.Add(new ListItem(item.Key, item.Value));
            }

            Dictionary<int,string> bulletedListItems = new Dictionary<int,string>();
            bulletedListItems.Add(1, "Apple");
            bulletedListItems.Add(2, "Mango");
            bulletedListItems.Add(3, "Banana");
            foreach(var item in bulletedListItems)
            {
                BulletedList1.Items.Add(new ListItem( item.Value, item.Key.ToString()));
            }
        }
    }
}