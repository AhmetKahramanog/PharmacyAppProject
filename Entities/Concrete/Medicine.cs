using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Medicine:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string MedicineName { get; set; }
        public string Description { get; set; }
        public decimal MedicinePrice { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
