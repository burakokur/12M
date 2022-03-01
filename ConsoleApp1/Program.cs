using Business.Concrete;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            STIManager sTIManager = new STIManager();
            var result =sTIManager.GetAll("10086 SİEMENS", 0, 1600000);
            foreach (var item in result)
            {
                Console.WriteLine(item.SiraNo+" "+item.StokMiktari );
            }
        }
    }
}
