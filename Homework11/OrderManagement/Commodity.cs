using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class Commodity:ICloneable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }

        public object Clone()
        {
            Commodity newCommodity = new Commodity();
            newCommodity.Id = this.Id;
            newCommodity.Name = this.Name;
            newCommodity.Price = this.Price;
            return newCommodity;
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t${Price}";
        }

        public override bool Equals(object obj)
        {
            Commodity commodity = obj as Commodity;
            return this.Id == commodity.Id;
        }

        public override int GetHashCode()
        {
            return (int)Id;
        }
    }
}
