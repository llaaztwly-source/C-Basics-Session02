using System.Linq.Expressions;

namespace First_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Book book = new Book();
            //object obj = book;
            // Console.WriteLine(obj);
            #endregion
            #region Q2
            //Book book = new Book();
            //book.Title = "Clean code";
            //book.Pages = 1;
            //Console.WriteLine(book);
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion
            #region Q3
            //compile-time error
            //int Page=464;
            #endregion
            #region Q4
            //try
            //{
            //    int x = 10;
            //    int y = 0;
            //    int res = x / y;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally { Console.WriteLine("Done"); }
            #endregion
            #region Q5
            //int Pages = 300;
            //double Pages2 = pages;
            #endregion
            #region Q6
            //double Price = 49.99;
            //int Price2 = (int)Price;
            #endregion
            #region Q7
            //string Pages = "464";
            //int Pages2=Convert.ToInt32(Pages);
            #endregion
            #region Q8
            //string Yeartext = "2023";
            //int Yeartext2=int.Parse(Yeartext);
            //string Badtext = "abc";
            //bool Badtext2=int.TryParse(Badtext,out Int32 result);
            //if (Badtext2)
            //{
            //    Console.WriteLine("Sucessed");
            //}
            //else Console.WriteLine("Invalid number");
            #endregion
            #region Q9
            //int Pages = 464;
            //string Pages2 = Pages.ToString();
            //Console.WriteLine(Pages2.GetType());
            #endregion
            #region Q10
            //int Copies = 100;
            //object obj = Copies;//Boxing
            //Console.WriteLine(obj);
            //int Copies2 = (int)obj;
            //Console.WriteLine(Copies2);//Unboxing
            #endregion
        }
    }
}
