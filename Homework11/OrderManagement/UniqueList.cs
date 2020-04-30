using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class UniqueList<T>:List<T>
    {
        public new void Add(T item)
        {
            if (!this.Contains(item))
            {
                base.Add(item);
            }else
            {
                throw new Exception("The item already exists.");
            }
        }

        public new void Insert(int index,T item)
        {
            if (!this.Contains(item))
            {
                base.Insert(index,item);
            }
            else
            {
                throw new Exception("The item already exists.");
            }
        }

        public new void AddRange(IEnumerable<T> items)
        {
            foreach(T item in items)
            {
                if (!this.Contains(item)){
                    base.Add(item);
                }
                else
                {
                    throw new Exception("The item already exists.");
                }
            }
        }
        public new void InsertRange(int index, IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                if (!this.Contains(item))
                {
                    base.Insert(index,item);
                }
                else
                {
                    throw new Exception("The item already exists.");
                }
            }
        }
    }
}
