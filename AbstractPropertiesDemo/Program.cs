using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPropertiesDemo
{
    abstract class Person                                  //abstract class
    {
        public  abstract int Id { get; set; }                //abstract properties
        public abstract string  Name { get; set; }
    }

    class Student:Person                                     //derived class
    {
        int StudentId;                                       //initalizing the members of base class
        string StudentName;

        public override int Id                                //overriding the properties of abstract class
        {
           
            set
            {
                if(value<=0)
                {
                   Console.WriteLine("Id cannot be zero or negative");
                }
                else
                {
                      this.StudentId = value;                                  //setting the value from user to StudentId
                }
            }
            get
            {
                return this.StudentId;                        //returning the value present in StudentId
            }
        }

        public override string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty");
                }
                else
                {
                    this.StudentName = value;                    //setting the value from user to StudentName
                }
                
            }
            get
            {
                return this.StudentName;                      //returning the value present in StudentName
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();                                   //creating object of the base class as object of abstract class cannnot  be created
            s.Id = 21;                                                   //setting the values
            s.Name = "Priya";
            Console.WriteLine(s.Id);                                     //getting the values
            Console.WriteLine(s.Name);
            Console.ReadLine();
        }
    }
}
