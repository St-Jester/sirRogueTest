using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class Item
    {
        public Item(string _itname)
        {
            ItemName = _itname;

        }

        public string ItemName { get; set; }
    }
}
