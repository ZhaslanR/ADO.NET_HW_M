namespace DzADO.NET_M
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibaryContext : DbContext
    {
        public LibaryContext()
            : base("name=LibaryContext")
        {
        }
        public DbSet<Libary> Libaries { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}