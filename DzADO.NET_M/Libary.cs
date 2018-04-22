using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzADO.NET_M
{
    public class Libary
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public string Address { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
