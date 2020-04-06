using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class Commodity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        
        public override string ToString()
        {
            return $"{Code}\t{Name}\t${Price}";
        }
    }
}
