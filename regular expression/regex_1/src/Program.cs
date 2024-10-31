// Lấy ra tất cả các số trong chuỗi

using System;
using System.Text.RegularExpressions;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"\d");
            
            #region do - while
            // Match result = reg.Match("-honin 01032002-");
            // do
            // {
            //     Console.WriteLine(result.ToString());
            //     result = result.NextMatch();
            // } while(result != Match.Empty);
            #endregion
        
            #region foreach
            foreach (Match item in reg.Matches("-honin 01032002-"))
            {
                Console.WriteLine(item.ToString());
            }
            #endregion
        }
    }
}