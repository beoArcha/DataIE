using System;
using System.Data;
using System.Globalization;

namespace DataIE
{
    class NewTableSQL
    {
        private DataTable dt;
        public NewTableSQL(DataSet ds)
        {
            dt = ds.Tables[0];
        }
        public string CreateTable()
        {
            string sql = "CREATE TABLE " + dt.TableName.ToString() + " ( ";
            foreach (DataColumn column in dt.Columns)
            {
                sql += " " + column.ColumnName + " " + GetSqlType(column.DataType, column.MaxLength, 10, 2) + ", ";
            }
            sql = sql.TrimEnd(new char[] { ',', ' ' }) + " ";

            if (dt.PrimaryKey.Length > 0)
            {
                sql += "CONSTRAINT[PK_" + dt.TableName + "] PRIMARY KEY CLUSTERED(";
                foreach (DataColumn column in dt.PrimaryKey)
                {
                    sql += "[" + column.ColumnName + "],{";
                }
                sql = sql.TrimEnd(new char[] { ',' }) + ")) ";
            }
            else
                sql += ")";
            return sql;            
        }
        private static string GetSqlType(object type, int columnSize, int numericPrecision, int numericScale)
        {
            switch (type.ToString())
            {
                case "System.Byte[]":
                    return "VARBINARY(6553)";
                    
                case "System.Boolean":
                    return "BIT";
                    
                case "System.DateTime":
                    return "DATETIME";
                    
                case "System.DateTimeOffset":
                    return "DATETIMEOFFSET";
                    
                case "System.Decimal":
                    if (numericPrecision != -1 && numericScale != -1)
                        return "DECIMAL(" +numericPrecision + "," +numericScale + ")";
                    else
                        return "DECIMAL";
                    
                case "System.Double":
                    return "FLOAT";
                    
                case "System.Single":
                    return "REAL";
                    
                case "System.Int64":
                    return "BIGINT";
                    
                case "System.Int32":
                    return "INT";
                    
                case "System.Int16":
                    return "SMALLINT";
                    
                case "System.String":                  
                     return  ((columnSize == -1 || columnSize > 8000) ? "Text" : "VARCHAR(" + columnSize.ToString() + ")");                    
                    
                case "System.Byte":
                    return "TINYINT";
                    
                case "System.Guid":
                    return "UNIQUEIDENTIFIER";
                    
                default:
                    throw new Exception(type.ToString() + " not implemented.");
            }
        }
    }
    class NeedQuotation
    {
        private DataColumn col;
        public NeedQuotation(DataColumn col)
        {
            this.col = col;
        }
        public static int IsQuotation(Type col)
        {
            switch (col.ToString())
            {
                case "System.Byte[]":
                    return 0;

                case "System.Boolean":
                    return 0;

                case "System.DateTime":
                    return 2;

                case "System.DateTimeOffset":
                    return 2;

                case "System.Decimal":
                    return 0;

                case "System.Double":
                    return 0;

                case "System.Single":
                    return 0;

                case "System.Int64":
                    return 0;

                case "System.Int32":
                    return 0;

                case "System.Int16":
                    return 0;

                case "System.String":
                    return 1;

                case "System.Byte":
                    return 0;

                case "System.Guid":
                    return 1;

                default:
                    throw new Exception(col.GetType().ToString() + " not implemented.");
            }
        }
    }
    class DateService
    {
        public static string Service(string date)
        {
            return Service(date, 1);
        }    
        public static string Service(string date, int outupType)
        {
            switch(outupType)
            {
                case 1:
                    {
                        string outputD;
                        DateTime dt = new DateTime();
                        dt = DateTime.Parse(date);
                        outputD = dt.ToString("yyyy-MM-dd");
                        return outputD;
                    }
                case 2:
                    {
                        string outputD;
                        DateTime dt = new DateTime();
                        dt = DateTime.Parse(date);
                        outputD = dt.ToString("hh:mm:ss");
                        return outputD;
                    }
                case 3:
                    {
                        string outputD;
                        DateTime dt = new DateTime();
                        dt = DateTime.Parse(date);
                        outputD = dt.ToString("yyyy-MM-dd hh:mm:ss");
                        return outputD;
                    }
                default:
                    throw new Exception(string.Format("This type:{0} is not implemented.", outupType));
            }            
        }        
    }
}
