using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzADO.NET_M
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LibaryContext())
            {
                context.Libaries.ToList();
            }
        }
    }
}
