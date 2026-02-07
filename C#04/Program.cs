using System.Diagnostics;
using System.Text;

namespace C_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            #region Task a
            /*
             string is imutable, 
            which means that once a string is created,
            it cannot be changed. When you modify a string,
            a new string is created in memory, and the original string remains unchanged.
            
             this case will created 5000 object in memory (heap memory) ,
             
             */
            #endregion

            #region Task b
            //StringBuilder productList = new StringBuilder("") ;
            //for (int i = 1; i <= 5000; i++)
            //{

            //    productList.Append("PROD-").Append(i).Append(",");
            //}

            #endregion

            #region Task c
            //var watch01=Stopwatch.StartNew();
            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList += "PROD-" + i + ",";
            //}
            //watch01.Stop();

            //var watch02 = Stopwatch.StartNew();
            //StringBuilder productList01 = new StringBuilder("");
            //for (int i = 1; i <= 5000; i++)
            //{

            //    productList01.Append("PROD-").Append(i).Append(",");
            //}
            //watch02.Stop();
            //Console.WriteLine($"Time of string : {watch01.ElapsedMilliseconds}");
            //Console.WriteLine($"Time of stringBuilder : {watch02.ElapsedMilliseconds}");


            #endregion
            #endregion
        }
    }
}
