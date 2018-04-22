using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzADO.NET_M
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Libary")]
        public int LibaryId { get; set; }
        public Libary Libary { get; set; }
    }
}
