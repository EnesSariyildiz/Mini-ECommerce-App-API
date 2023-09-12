using ETicaretAPI.Domain.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        //public DateTime CreatedDate { get; set; }
        public ICollection<Order> Orders { get; set; }
        //Çoka çok ilişki için hem Product hem de Order entitylerinde ICollection nesnesiyle ilişkilerini bildiriyoruz.

    }
}
