using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCord
{
    public static class FileOperate
    {
        /// <summary>
        /// 文件写入内容
        /// </summary>
        /// <param name="list"></param>
        /// <param name="path"></param>
        public static void FileWrite(List<string> list, string path)
        {
            using (System.IO.FileStream myfs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter mySw = new StreamWriter(myfs))
                {
                    foreach (string row in list)
                    {
                        mySw.WriteLine(row);
                    }
                }
            }
        }

        /// <summary>
        /// 追加List
        /// </summary>
        /// <param name="list"></param>
        /// <param name="path"></param>
        public static void WriteAppendList(List<string> list, string path)
        {
            StreamWriter sw = File.AppendText(path);
            foreach (string row in list)
            {
                sw.WriteLine(row);
            }
            sw.Flush();
            sw.Close();
        }

        /// <summary>
        /// 追加str
        /// </summary>
        /// <param name="fileDate"></param>
        /// <param name="fileName"></param>
        public static void WriteAppendStr(string fileDate,string fileName)
        {
            StreamWriter sw = File.AppendText(fileName);
            sw.Write(fileDate);
            sw.Flush();
            sw.Close();
        }
        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string FileReader(string path)
        {
            string content = "";
            using (FileStream myfs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader mySr = new StreamReader(myfs))
                {
                    content = mySr.ReadToEnd();
                }

            }

            return content;
        }

        public static string SqlTypeTope(string type)
        {
            string cType = "";
            switch (type)
            {
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "character varying":
                case "text":
                case "character(size)":
                case "bpchar":
                case "citext":
                case "json":
                case "jsonb":
                case "name":
                case "xml":
                    cType = "string";
                    break;
                case "integer":
                case "int":
                case "tinyint":
                case "smallint":
                case "bigint":
                case "int4":
                    cType = "int";
                    break;
                case "decimal":
                case "money":
                case "float":
                    cType = "double";
                    break;
                case "datetime":
                case "date":
                    cType = "DateTime";
                    break;
                case "bool":
                case "bit(1)":
                    cType = "bool";
                    break;
                case "int2":
                    cType = "short";
                    break;
                case "int8":
                    cType = "long";
                    break;
                case "float4":
                    cType = "float";
                    break;
                case "float8":
                    cType = "double";
                    break;
                case "numeric":
                    cType = "decimal";
                    break;
                case "point":
                    cType = "NpgsqlPoint";
                    break;
                case "lseg":
                    cType = "NpgsqlLSeg";
                    break;
                case "path":
                    cType = "NpgsqlPath";
                    break;
                case "polygon":
                    cType = "NpgsqlPolygon";
                    break;
                case "line":
                    cType = "NpgsqlLine";
                    break;
                case "circle":
                    cType = "NpgsqlCircle";
                    break;
                case "box":
                    cType = "NpgsqlBox";
                    break;
                case "oid":
                case "xid":
                case "cid":
                    cType = "uint";
                    break;
                case "range subtypes":
                    cType = "NpgsqlRange";
                    break;
                case "enum types":
                    cType = "TEnum";
                    break;
                case "geometry ":
                    cType = "PostgisGeometry";
                    break;
                case "varbit":
                case "bit(n)":
                    cType = "BitArray";
                    break;
                case "hstore":
                    cType = "IDictionary<string, string>";
                    break;
            }
            return cType;
        }

    }
}
