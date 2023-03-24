using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD5_1302210044
{
    public class Penjumlahan
    {
        private dynamic data;
        public Penjumlahan() { }
        public void PenjumlahanTigaAngka<T>(T a, T b, T c)
        {
            dynamic aa= a;  
            dynamic bb= b;
            dynamic cc= c;

            data = aa+ bb + cc;   
        }

        public void Print()
        {
            Console.WriteLine($"Hasil Penjumlahan: {this.data}");
        }
    }

}
