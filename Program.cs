using System;

namespace InheritanceDemo
{

     class Student
    {
        public string firstname;
        public string identity;
        public  Student(string firstname, string identity)
        {
            this.firstname = firstname;
            this.identity = identity;

        }
        ~Student()
        { 
        
        }
    }
   
    class Hostelstudent : Student
    {
         private int roomno;
        public Hostelstudent(string firstname,string identity, int roomno): base(firstname, identity)
        {
            this.roomno = roomno;
            this.firstname = firstname;
            this.identity = identity;
        }
        public void PrintDetails()
        {
            Console.WriteLine("First Name: " + firstname);
            Console.WriteLine("Identity: " + identity);
            Console.WriteLine("room No.: " + roomno);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hostelstudent hostelstudent = new Hostelstudent("jana","E12",56);
            hostelstudent.PrintDetails();
        }
    }
}
