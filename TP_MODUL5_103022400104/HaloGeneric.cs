using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL5_103022400104
{
    public class HaloGeneric<T>
    {
        public void SapaUser(T user)    
        {
        Console.WriteLine($"Halo user {user}");
    }
    }
}
