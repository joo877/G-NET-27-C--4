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


            #region Q2
            // int age = 1;
            // int day = 1;
            // string studentID = "";
            // double totalPrice = 0;
            // try
            // {
            //     Console.Write("Enter your age: ");
            //     age = Convert.ToInt32(Console.ReadLine());
            //     Console.Write("please Enter the Day : ");
            //     day = Convert.ToInt32(Console.ReadLine());
            //     Console.Write("have you a student ID...?! :  ");
            //     studentID = Console.ReadLine().ToLower();

            // }
            // catch { Console.WriteLine("invalid data"); }

            //  if (age < 5)
            // {
            //     Console.WriteLine("Total price : 0 EGP\n ticket price : free");
            // }
            //else if (age >= 5 && age <= 12)
            // {
            //     if (day == 6 && day == 7)
            //     {
            //         if (studentID == "yes") {

            //             totalPrice += 40 * .2;
            //             Console.WriteLine($"Total price : {totalPrice} EGP\n ticket price : 30 EGP  20% discount (applied after weekend surcharge (10 EGP)) ");


            //         }
            //         else {

            //             totalPrice += 40;
            //             Console.WriteLine($"Total price : {totalPrice} EGP\n ticket price : 30 EGP  Add 10 EGP (to any non-free ticket in weekend) ");
            //         }

            //     }

            //     else if (studentID == "yes")
            //     {
            //         totalPrice += 30 * .2;
            //         Console.WriteLine($"Total price : {totalPrice} EGP\n ticket price : 30 EGP  20% discount  ");

            //     }



            //     else
            //     {
            //         totalPrice += 30;
            //         Console.WriteLine($"Total price : {totalPrice} EGP\n ticket price : 30 EGP");



            //     }







            // }

            // else if (age >= 13 && age <= 59)
            // {

            //     if (day == 6 || day == 7)
            //     {
            //         if (studentID == "yes")
            //         {

            //             totalPrice += 60 * .2;
            //             Console.WriteLine($"Total price : {totalPrice} EGP\n ticket price : 50 EGP     20% discount (applied after weekend surcharge (10 EGP) ) ");


            //         }
            //         else
            //         {

            //             totalPrice += 60;
            //             Console.WriteLine($"Total price : {totalPrice} EGP\n ticket price : 50 EGP  Add 10 EGP (to any non-free ticket in weekend) ");
            //         }



            //     }
            //     else if (studentID == "yes")
            //     {
            //         totalPrice += 50 * .2;
            //         Console.WriteLine($"Total price : {totalPrice} EGP\n ticket price : 50 EGP  20% discount ");

            //     }
            //     else
            //     {
            //         totalPrice += 50;
            //         Console.WriteLine($"Total price : {totalPrice} EGP\n ticket price : 50 EGP");



            //     }






            // }

            // else if (age >= 60)
            // {


            //     if (day == 6 || day == 7)
            //     {
            //         totalPrice += 35;
            //         Console.WriteLine($"Total price : {totalPrice} EGP\n ticket price : 25 EGP  Add 10 EGP (to any non-free ticket in weekend) ");

            //     }

            //     else
            //     {
            //         totalPrice += 25;
            //         Console.WriteLine($"Total price : {totalPrice} EGP\n ticket price : 25 EGP");



            //     }

            // }


            #endregion










            #region Q3
            #region switch clasic
            //string fileExtension = ".pdf";
            //string fileType;

            //switch (fileExtension)
            //{
            //    case ".pdf":
            //       fileType = "PDF Document";
            //        break;
            //    case ".docx":
            //    case ".doc":
            //        fileType = "Word Document";
            //        break;
            //        case ".xlsx":
            //        case ".xls":
            //        fileType = "Excel Spreadsheet";
            //        break;  
            //     case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        break;
            //        default:
            //        fileType = "Unknown File Type";
            //        break;
            //}

            #endregion

            #region switch expression 
            //string fileExtension = ".pdf";
            //string fileType;

            //fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".docx" or ".doc" => "Word Document",
            //    ".xlsx" or ".xls" => "Excel Spreadsheet",
            //    ".jpg" or ".png" or ".gif" => "Image File",
            //    _ => "Unknown File Type"
            //};

            #endregion
            #endregion


        }





    }
    }

