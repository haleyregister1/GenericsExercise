using System;
using System.Collections.Generic;
using System.Collections;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Complete the TODOs in the ListExercise.cs
            // Create List that contains 3 strings 
            // Call the static ProcessToKill method, pass in your list of strings
            List<string> killList = new List<string>(3);

            killList.Add("Kill 1");
            killList.Add("Kill 2");
            killList.Add("Kill 3");

            ListExercise.ProcessToKill(killList);


            // Complete the TODOs in the DictionaryExercise.cs
            // Create a List of type Employee
            // Populate the List
            // Call the static GetEmployeesByAge method and pass in your list 
            var employee = new List<Employee>();


            // Complete the TODOs in the StackExercise method
            // Call the StackExercise method

            StackExercise();

            // Complete the TODOs in the QueueExercise method
            // Call the the QueueExercise method

            QueueExercise();

        }

        public static void StackExercise()
        {
            // Create and initialize a new Stack object called myStack.
            //TODO Create a Stack collection of type string called myStack

            Stack myStack = new Stack();

            // Call the push method off of myStack and pass in "Hello,", then " World", then "!".

            myStack.Push("Hello,");
            myStack.Push(" World");
            myStack.Push("!");

            // Displays the properties and values of the Stack.
            //**Uncomment the lines below**

            Console.WriteLine("\tCount:    {0}", myStack.Count);
            Console.Write("\tValues:");
            foreach (var item in myStack)
            {
                Console.Write("    {0}", item);
            }
        }

        public static void QueueExercise()
        {
            // Create and initialize a new Queue object called myQ.
            //  Create new Queue of type string named myQ

            Queue myQ = new Queue();

            //  Call the Enqueue method off of myQ and pass in "Hello,", then " World", then "!".

            myQ.Enqueue("Hello");
            myQ.Enqueue(" World");
            myQ.Enqueue("!");

            // Displays the properties and values of the Queue.
            Console.WriteLine("\tCount:    {0}", myQ.Count);
            Console.Write("\tValues:");
            foreach (var item in myQ)
            {
                Console.Write("    {0}", item);
            }
        }
    }
}
