using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL5_103022400104
{

    class DataGeneric<T>
    {
        public T Data;

        public DataGeneric(T data)
        {
            Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
        }
    }
}
