using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD5_1302210044
{
    internal class SimpleDataBase<T>
    {
        List<T> storedData { get; set; }

        List<DateTime> inputDates { get; set; }

        public SimpleDataBase() 
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void addNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);

        }
        public void printAllData()
        {
            for(int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + " berisi" + storedData.ElementAt(i)+ "yang disimpan pada waktu" + inputDates.ElementAt(i));  
            }
        }
    }
}

