using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class QueryObject
    {

        public static List<T> getWhere<T>(T obj, string tableName)
        {
            List<T> result = new List<T>(); 
            string query = QueryBuilder.buildquery(tableName, obj);
            List<string[]> list = QueryExecuter.getQueryAsList(query);
            foreach (string[] l in list)
            {
                T t = (T)Activator.CreateInstance(typeof(T));
                Type prop = typeof(T);
                PropertyInfo[] propInfos = prop.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                for(int i = 0; i < propInfos.Length; i++)
                {
                    propInfos[i].SetValue(t, l[i]);
                }
                result.Add(t);
            };
            return result;
        }
        public static void insertObject<T>(T obj, string tableName)
        {
            string query = QueryBuilder.insertquery(tableName, obj);
            QueryExecuter.insertQuery(query);
        }
    }
}
