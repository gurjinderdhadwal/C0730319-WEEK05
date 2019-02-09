using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weeko51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
        }
    }
    class Node
    {
        public Node() { }
        public Node floor;
        public Node elevatorUp;
        public string FloorNumber;
    }

    class Department
    {
        public Department aDepartment;

    }

    class Elevator
    {
//@@ -51,13 +56,12 @@ public void TraverseList()
            temp = Head;

            // where am I going to start?
            Console.WriteLine("The first floor is " + Head.FloorNumber);

            while (temp != null)
            {
                // NOW GET TO THE SECOND FLOOR!!!!
                temp = temp.elevatorUp;
                Console.WriteLine(temp.FloorNumber);

                temp = temp.elevatorUp;

            }

}
