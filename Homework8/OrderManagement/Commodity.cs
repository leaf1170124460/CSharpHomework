using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class Commodity:ICloneable
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public object Clone()
        {
            Commodity newCommodity = new Commodity();
            newCommodity.Code = this.Code;
            newCommodity.Name = this.Name;
            newCommodity.Price = this.Price;
            return newCommodity;
        }

        public override string ToString()
        {
            return $"{Code}\t{Name}\t${Price}";
        }
    }
}
