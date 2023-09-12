using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities.Comman
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        //Id değerlerini bir bir artarak olmasını istemediğimiz için, uniq identity olarak id değerleri tutuyoruz.
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
