using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Polymorphism_Example
{
    //Create a Person class
    public class Person //Base Class
    {
        public int iAge;           //Attributes
        private string strName;    
        public string GetName()   //Methods
        {
            return strName;
        }
        public void SetName( string Name)
        {
            strName = Name;
        }
        public virtual void Play()  // virtual function which can override in derived class (Polymorphism feature)
        {
            System.Console.WriteLine("I can play any game");
        }
    };

    //Create a class CricketPlayer derived class from base class
    public class CricketPlayer : Person  //derived class
    {
        public string strNationality;  //Attribute
        public string GetNationality()
        {
            return strNationality;
        }
        public override void Play()  //Override method of base class
        {
            System.Console.WriteLine("I can play Cricket");
        }
    };  
    class Program
    {
        [DllImport("msvcrt")]
        static extern int _getch();
        static void Main(string[] args)
        {
            CricketPlayer Player; //derived class  object
            Player = new CricketPlayer();
            Player.iAge = 23;
            Player.SetName("Krishna Panchal");
            Player.strNationality = "Indian";
            System.Console.WriteLine("Polymorphism Example");
            System.Console.WriteLine();

            Player.Play();  //calling derived class play directly
            System.Console.WriteLine();

            Person Person1 = new Person();
            Person1.Play(); //calling base class play directly
            System.Console.WriteLine();

            CricketPlayer CrickPlayer = new CricketPlayer();
            Person Person2 = CrickPlayer;
            Person2.Play(); //calling derived class play from base class through polymorphism
            System.Console.WriteLine();

            _getch();
        }
    }
}
