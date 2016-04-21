using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class LinqToSql
    {
        

        

        public bool IsValidUser(string nombreGrafico, string polen)
        {
            DataClasses1DataContext myDb = new DataClasses1DataContext();

            var polenes = from u in myDb.nombre_polenes
                              where u.nombre_grafico == nombreGrafico
                              && u.polen == polen
                              select u;
            return Enumerable.Count(polenes) > 0;
        }

        public void PollensValues(string polen)
        {
            DataClasses1DataContext myDb = new DataClasses1DataContext();

            var polenes = from u in myDb.nombre_polenes
                select new {u.polen, u.nombre_grafico, u.alto, u.bajo, u.medio, u.nulo};

            StringBuilder sb = new StringBuilder();
            foreach (var item in polenes)
            {
                sb.Append(item.nombre_grafico);
                sb.Append(" ");
                sb.Append(item.polen);
                sb.Append(" ");
                sb.Append(item.alto);
                sb.Append("\n");
            }
            Console.WriteLine(sb);

        }
    }

}
