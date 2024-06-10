using System;
using System.Collections;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            var r = new RecursiveAndIteration();
            

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n5. Recursive"
                    + "\n6. Iterative"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        Recursion();
                        break;
                    case '6':
                        Iteration();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> myList = new List<string>();
            bool continuedLoop = true;

            while (continuedLoop)
            {
                Console.WriteLine("Enter '+name' to add or '-name' to remove from the list. Type 'exit' to return to main menu.");
                string input = Console.ReadLine()!;

                if (input.ToLower() == "exit")
                {
                    continuedLoop = false;
                    continue;
                }

                if (input.Length > 1)
                {
                    char operation = input[0];
                    string name = input.Substring(1);

                    switch (operation)
                    {
                        case '+':
                            myList.Add(name);
                            Console.WriteLine($"Added {name}");
                            break;
                        case '-':
                            if (myList.Contains(name))
                            {
                                myList.Remove(name);
                                Console.WriteLine($"Removed {name}");
                            }
                            else
                            {
                                Console.WriteLine($"{name} not found in the list");
                            }
                            break;
                        default:
                            Console.WriteLine("Please use only '+' or '-' followed by a name.");
                            break;
                    }

                    Console.WriteLine($"Count: {myList.Count}, Capacity: {myList.Capacity}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please use '+' or '-' followed by a name.");
                }
            }


            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
             * 
            */
            Queue<string> myQ = new Queue<string>();
            bool continuedLoop = true;

            while (continuedLoop)
            {
                Console.WriteLine("Enter '+name' to add to cashier queue or '-' to remove from queue" +
                    ". Type 'exit' to return to main menu.");
                string input = Console.ReadLine()!;

                if (input.ToLower() == "exit")
                {
                    continuedLoop = false;
                    continue;
                }

                if (input.Length > 0)
                {
                    char operation = input[0];
                    string name = input.Substring(1);

                    switch (operation)
                    {
                        case '+':
                            myQ.Enqueue(name);
                            Console.WriteLine($"{name} added to the queue");
                            break;
                        case '-':
                            if (myQ.Count > 0)
                            {
                                var str = myQ.Dequeue();
                                Console.WriteLine($"{str} Removed from queue");
                            }
                            else
                            {
                                Console.WriteLine($"Queue is empty");
                            }
                            break;
                    }
                    if(myQ.Count > 0)
                        Console.WriteLine($"Count: {myQ.Count}, first on queue: {myQ.Peek()}");
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            Stack<string> myStack = new Stack<string>();
            bool continuedLoop = true;

            while (continuedLoop)
            {
                Console.WriteLine("Enter '+name' to add to stack or '-' to remove from stack" +
                    ". Type 'exit' to return to main menu.");
                string input = Console.ReadLine()!;

                if (input.ToLower() == "exit")
                {
                    continuedLoop = false;
                    continue;
                }

                if (input.Length > 0)
                {
                    char operation = input[0];
                    string name = input.Substring(1);

                    switch (operation)
                    {
                        case '+':
                            myStack.Push(name);
                            Console.WriteLine($"{name} added to the queue");
                            break;
                        case '-':
                            if (myStack.Count > 0)
                            {
                                var str = myStack.Pop();
                                Console.WriteLine($"{str} Removed from queue");
                            }
                            else
                            {
                                Console.WriteLine($"stack is empty");
                            }
                            break;
                    }
                    if (myStack.Count > 0)
                        Console.WriteLine($"Count: {myStack.Count}, last on stack: {myStack.Peek()}");
                }
            }
        }

        static void CheckParanthesis()
        {
            
            bool continuedLoop = true;

            while (continuedLoop)
            {
                Stack<char> stack = new Stack<char>();
                Console.WriteLine("Enter paranthesis to check or type exit to return to main menu");
                string input = Console.ReadLine()!;

                if (input.ToLower() == "exit")
                {
                    continuedLoop = false;
                    continue;
                }
                foreach (var item in input)
                {
                    if (item == '{' || item == '[' || item == '(')
                    {
                        stack.Push(item);
                    }
                    else if ((item == '}' && stack.Count > 0 && stack.Peek() == '{') ||
                       (item == ']' && stack.Count > 0 && stack.Peek() == '[') ||
                       (item == ')' && stack.Count > 0 && stack.Peek() == '('))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Wrong paranthesis closing");
                    }
                }

                
                Console.WriteLine(stack.Count == 0 ? "Rightparanthesis closing" 
                                                     : "Wrong paranthesis closing");
  

            }
        }
        static void Recursion()
        {
            var rec = new RecursiveAndIteration();
            bool continuedLoop = true;
            while (continuedLoop)
            {
                Console.WriteLine("""
                    Please select the type of recursion (1, 2, 3) of your choice 
                    followed by the number you want to as input 
                    for example "1 9" means case 1 (recursive odd) with input 9
                    """
                                    
                    + "\n1. Recursive Odd"
                    + "\n2. Recursive Even"
                    + "\n3. Recursive Fibonacci"
                    + "\nType exit to get back to the Main menu");

                string input = Console.ReadLine()!.Replace(" ", "");
                if (input.Length > 1)
                {
                    char sel = input[0];
                    int.TryParse(input.Substring(1), out int n);
                    switch (sel)
                    {
                        case '1':
                            Console.WriteLine(rec.RecursiveOdd(n));
                            break;
                        case '2':
                            Console.WriteLine(rec.RecursiveEven(n));
                            break;
                        case '3':
                            Console.WriteLine(rec.Fibonacci(n));
                            break;
                        default:
                            Console.WriteLine("Please enter some valid input (0, 1, 2, 3)");
                            break;
                    }
                }
                if (input.ToLower() == "exit")
                {
                    continuedLoop = false;
                    continue;
                }

            }
        }
        static void Iteration()
        {
            var rec = new RecursiveAndIteration();
            bool continuedLoop = true;
            while (continuedLoop)
            {
                Console.WriteLine("""
                    Please select the type of Iteration (1, 2, 3) of your choice 
                    followed by the number you want to as input 
                    for example "1 9" means case 1 (iterative odd) with input 9
                    """

                    + "\n1. Iterative Odd"
                    + "\n2. Iterative Even"
                    + "\n3. Iterative Fibonacci"
                    + "\nType exit to get back to the Main menu");

                string input = Console.ReadLine()!.Replace(" ", "");
                if (input.Length > 1)
                {
                    char sel = input[0];
                    int.TryParse(input.Substring(1), out int n);
                    switch (sel)
                    {
                        case '1':
                            Console.WriteLine(rec.IterativeOdd(n));
                            break;
                        case '2':
                            Console.WriteLine(rec.IterativeEven(n));
                            break;
                        case '3':
                            Console.WriteLine(rec.IterativeFibonacci(n));
                            break;
                        default:
                            Console.WriteLine("Please enter some valid input (0, 1, 2, 3)");
                            break;
                    }
                }
                if (input.ToLower() == "exit")
                {
                    continuedLoop = false;
                    continue;
                }

            }
        }

    }
}


