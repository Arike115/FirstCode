using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    //access modifiers
    // private
    //public
    //internal
    //protected

    //Static and Nonstatic class

   public class Student
    {
        //property
        public int Id { get; set; }

        //field
        public string Name;
        public int Age;
        public string Gender;
        

        //Constructor
        //public Student(string name, int age, string gender) 
        //{
        //    Name = name;
        //    Age = age;
        //    Gender = gender;
        //}



        public void GetList()
        {
            
            Console.WriteLine("{0}-----{1}-----{2}", Name, Age, Gender);
        }
    }
}
