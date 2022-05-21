using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Collections;
using System.IO;

namespace ArrayFileAndExceptionHandling
{
    public class Person
    {
        public int iAge; 
        private string strName; //Property
        public string GetName() //Method
        {
            return strName;
        }
        public void SetName(string Name)
        {
            strName = Name;
        }
        public virtual void Play()
        {
            System.Console.WriteLine("Playing Nothing");
        }
    };
    class ArrayFileAndExceptionHandling
    {
        [DllImport("msvcrt")]
        static extern int _getch();
        static void Main(string[] args)
        {
            //Create a person Array
            Person[] PersonArray = new Person[3];  //Creating an array of 3 person
            PersonArray[0] = new Person();   //Creating the person 1
            PersonArray[0].SetName("Krishna");
            PersonArray[1] = new Person();
            PersonArray[1].SetName("Mihir");
            PersonArray[2] = new Person();
            PersonArray[2].SetName("Foram");
            System.Console.WriteLine("Using Arrays");
            //iterate through each element in the array using the foreach loop

            foreach(Person i in PersonArray)
            {
                System.Console.WriteLine(i.GetName());
            }

            //Using Arraylist Collection Class
            ArrayList PersonList = new ArrayList();
            Person Person1 = new Person();
            Person1.SetName("Vidhi \n");
            PersonList.Add(Person1);
            Person Person2 = new Person();
            Person2.SetName("Mansi");
            PersonList.Add(Person2);
            System.Console.WriteLine("Using ArrayList");

            foreach( Person List in PersonList)
            {
                System.Console.WriteLine(List.GetName());
            }

            //save these details to the file
            try //Exception handler
            {
                System.Console.WriteLine("Saving these details to the file");
                using (FileStream fs = File.Create("PersonDetails.txt"))
                {
                    foreach ( Person List in PersonList)
                    {
                        byte[] bValues = new UTF8Encoding(true).GetBytes(List.GetName());
                        fs.Write(bValues, 0, bValues.Length);
                    }
                }
            }
            catch( Exception ex)
            {
                System.Console.WriteLine("Sorry!! Some Error occur while saving: " + ex.Message); 
            }
            _getch();
        }
    }
}
