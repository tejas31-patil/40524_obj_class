using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2) A record contains name of cricketer, his age, number of test matches that he has played and
//the average runs that he has scored in each test match. 
//Create an array of objects of cricketer to hold records of 10 such cricketers and
//then write a program to read these records and arrange them in ascending order by average runs.

//3) There is a class called employee that holds information like employee code, name and date
//of joining. Write a program to create an array of employee objects and enter some data into it.
//Then ask the user to enter current date. Display the names of those employees
//whose tenure is greater than equal to 3 years. 

//(4) Create a class called library to hold accession number, title of

//the book, author name, price of the book, and flag indicating

//whether book is issued or not. Write a menu-driven program that

//implements the working of a library. The menu options should be:

//1.Add book information 
//2. Display book information

//3. List all books of given author

//4. List the title of specified book

//5. List the count of books in the library

//6. List the books in the order of accession number

//7. Exit
namespace _40524_obj_class
{
    internal class Cricketer
    {
        public string cname;
        public int age;
        public int  testmatches;
        public int average_run;

        public void Cricketer1()
        {
            Console.WriteLine("\nenter the records cricketer name,age,testmatches and average run : ");
            for(int i = 0; i < 3; i++)
            {
                cname=Convert.ToString(Console.ReadLine());  
                age = Convert.ToInt32(Console.ReadLine());
                testmatches = Convert.ToInt32(Console.ReadLine());
                
            }
            for(int i = 0;i < 3; i++)
            {
                Console.WriteLine(cname+"\n"+age+"\n"+ testmatches+"\n"+ testmatches);
            }

        }
    }
}
