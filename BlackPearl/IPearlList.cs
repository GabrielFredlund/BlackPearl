using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BlackPearl
{
    public interface IPearlList
    {
        [Key]
        public Guid NecklaceID { get; set; }
        public int Count();
        public int totalPrice { get;}
        public void Sort();
    }
}
