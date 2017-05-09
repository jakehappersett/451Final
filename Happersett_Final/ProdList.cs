using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Happersett_Final
{
    public class ProdList
    {
        public List<Prod> Items { get; set; }

        public ProdList()
        {
            Items = new List<Prod>();
        }

        private int ItemIndexOf(int ProductID)
        {
            foreach (Prod item in Items)
            {
                if (item.ProductID == ProductID)
                {
                    return Items.IndexOf(item);
                }
            }
            return -1;
        }

        public void Insert(Prod item)
        {
            int index = ItemIndexOf(item.ProductID);
            if (index == -1)
            {
                Items.Add(item);
            }
        }

        public void Delete(int rowID)
        {
            Items.RemoveAt(rowID);
        }

    }
}