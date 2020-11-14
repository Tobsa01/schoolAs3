using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class QueryBuilder
    {
        public static string buildquery<T>(string tableName, T obj) {
            Type t = typeof(T);
            PropertyInfo[] propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            return buildSelect(propInfos, tableName) + addWildCards(propInfos, obj);
        }
        public static string insertquery<T>(string tableName, T obj)
        {
            Type t = typeof(T);
            PropertyInfo[] propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            return $"INSERT INTO {tableName}({buildInsertParameter(propInfos)}) VALUES ({addInsertValues(propInfos, obj)})"; 
        }
        public static string deleteQuery<T>(string tableName, T obj)
        {
            Type t = typeof(T);
            PropertyInfo[] propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            return $"DELETE FROM {tableName}{addCards(propInfos, obj)}";
        }
        public static string updateQuery<T>(string tableName, T oldObj, T newObj)
        {
            Type t = typeof(T);
            PropertyInfo[] propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            return $"UPDATE {tableName} SET{setCards(propInfos, newObj)}{addCards(propInfos, oldObj)}";
        }

        private static string buildInsertParameter(PropertyInfo[] propInfos)
        {
            string result = "";
            foreach (var propinfo in propInfos)
            {
                result += $"{propinfo.Name},";
            }
            result = result.Remove(result.Length - 1);
            return result;
        }
        private static string addInsertValues<T>(PropertyInfo[] propInfos, T obj)
        {
            string result = "";
            foreach (var propinfo in propInfos)
            {
                result += $"'{propinfo.GetValue(obj).ToString()}',";
            }
            result = result.Remove(result.Length - 1);
            return result;
        }
        private static string addWildCards<T>(PropertyInfo[] propInfos, T obj)
        {
            string result = " WHERE 1 = 1";
            foreach (var propinfo in propInfos)
            {
                if (propinfo.GetValue(obj) != null && propinfo.GetValue(obj).ToString().Replace(" ", "") != "")
                {
                    result += $" AND {propinfo.Name} LIKE '%{propinfo.GetValue(obj).ToString()}%'";
                }
            }
            return result;
        }

        private static string buildSelect(PropertyInfo[] propInfos, string tableName)
        {
            string result = "SELECT ";
            foreach (var propinfo in propInfos)
            {
                result += $"{propinfo.Name},";
            }
            result = result.Remove(result.Length - 1);
            result += $" FROM {tableName}";
            return result;
        }
        private static string addCards<T>(PropertyInfo[] propInfos, T obj)
        {
            string result = " WHERE 1 = 1";
            foreach (var propinfo in propInfos)
            {
                if (propinfo.GetValue(obj) != null && propinfo.GetValue(obj).ToString().Replace(" ", "") != "")
                {
                    result += $" AND {propinfo.Name} = '{propinfo.GetValue(obj).ToString()}'";
                }
            }
            return result;
        }
        private static string setCards<T>(PropertyInfo[] propInfos, T obj)
        {
            string result = "";
            foreach (var propinfo in propInfos)
            {
                result += $" {propinfo.Name} = '{propinfo.GetValue(obj).ToString()}',";
            }
            result = result.Remove(result.Length - 1);
            return result;
        }
    }
}
