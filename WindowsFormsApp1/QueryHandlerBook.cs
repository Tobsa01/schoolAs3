using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class QueryHandlerBook
    {
        
        public static void getBooksWhere(Book book)
        {
            string query = QueryBuilder.buildquery("Books", book);
            List<string[]> list = QueryExecuter.getQueryAsList(query);
            foreach(string[] l in list)
            {
            }
        }
    }
}
