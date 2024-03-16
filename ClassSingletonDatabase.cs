using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_study
{
    internal class SingletonDatabase
    {
        private static string adress;
        private static SingletonDatabase instance;
        private SingletonDatabase(string Adress)
        {
            adress = Adress;
        }
        public static SingletonDatabase getInstance(string Adress)
        {
            if (instance == null)
            {
                instance = new SingletonDatabase(Adress);
            }
            return instance;
        }
        public void getDataFromAdress()
        {
            Console.WriteLine($"data taken from {adress}");
        }
    }

}
