using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5
{
    class Program
    {
        static void Main(string[] args)
        {
            elevator e = new elevator();
            e.run();
            e.traverseList();
            Console.ReadKey();


        }

    }

    class node
    {
        public node() { }
        public node floor;
        public node elevatorup;
        public string floornumber;
    }

    class department
    {
        public department(string dept_name)
        {
            departmentDescription = dept_name;
        }
        public department nextdepartment;
        public department previousdepartment;
        public string departmentDescription;
    }
    class departmentstore
    {
        public void InitializeDepartments()
        {
            department kitchenware = new department("Kitchenware");
            kitchenware.nextdepartment = book;
            department book = new department("books");
        }
    }
    class elevator
    {
        public node head;
        public node firstfloor;
        public node secondfloor;
        public node thirdfloor;
        public node fourthfloor;

        public void run()
        {
            firstfloor = new node();
            secondfloor = new node();
            thirdfloor = new node();
            fourthfloor = new node();

            head = firstfloor;
            firstfloor.floornumber = "First Floor";
            Console.WriteLine("The floor number is {0}", firstfloor.floornumber);
            firstfloor.elevatorup = secondfloor;
            secondfloor.floornumber = "Second Floor";
            Console.WriteLine("The floor number is {0}", secondfloor.floornumber);
            secondfloor.elevatorup = thirdfloor;
            thirdfloor.floornumber = "Third Floor";
            Console.WriteLine("The floor number is {0}", thirdfloor.floornumber);
            thirdfloor.elevatorup = fourthfloor;
            fourthfloor.floornumber = "Fourth Floor";
            Console.WriteLine("The floor number is {0}", fourthfloor.floornumber);
            fourthfloor.elevatorup = null;



        }


        public void traverseList()
        {
            node temp = head;

            Console.WriteLine("The first floor is " + head.floornumber);
            while (temp != null)
            {
                Console.WriteLine(temp.floornumber);
                temp = temp.elevatorup;

            }
        }
    }
}