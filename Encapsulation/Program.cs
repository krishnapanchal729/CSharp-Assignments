using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Encapsulation
{
    public class Person
    {
        public int iAge;
        private string strName;
        public string GetName()
        {
            return strName;
        }
        public void SetName(string Name)
        {
            strName = Name;
        }
    };
    class Program
    {
        [DllImport("msvcrt")]
        static extern int _getch();
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.iAge = 20;
            person1.SetName("Krishu");
            System.Console.WriteLine(person1.GetName());
            _getch();
        }
    }
}
