using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var newAuthor = new Author(
                "Pepe", 19, "Exists", true, new DateTime(2015,10,15)
                );

            List<Author> authorList = new List<Author>
            {
                new Author("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET", true, new DateTime(2003, 7, 10)),
                new Author("Neel Beniwal", 18, "Graphics Development with C#", false, new DateTime(2010, 2, 22)),
                new Author("Praveen Kumar", 28, "Mastering WCF", true, new DateTime(2012, 01, 01)),
                new Author("Mahesh Chand", 35, "Graphics Programming with GDI+", true, new DateTime(2008, 01, 20)),
                new Author("Raj Kumar", 30, "Building Creative Systems", false, new DateTime(2011, 6, 3))
            };

            authorList.Add(newAuthor);


            foreach (var author in authorList)
            {
                Console.WriteLine("Author: {0},{1},{2},{3},{4}", author.Name, author.Age, author.BookTitle, author.IsMvp, author.PublishedDate);
            }

            LinqToSql consulta = new LinqToSql();
        }
    }
}
