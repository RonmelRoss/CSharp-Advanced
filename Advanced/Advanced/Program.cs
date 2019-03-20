using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Demonstration on Properties (Ref: Properties.cs)
            Console.WriteLine("DEMONSTRATION ON PROPERTIES");
            // Create a new Student object:
            Student s = new Student();

            // Setting code, name and the age of the student
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;
            Console.WriteLine("Student Info: {0}", s); //ToString() method was automatically called

            //let us increase age
            s.Age += 1;
            Console.WriteLine("Student Info: {0}", s);
            #endregion

            #region Demonstration on Collections (ArrayList Class)
            Console.WriteLine("\nDEMONSTRATION ON COLLECTIONS - ARRAYLIST CLASS");
            ArrayList al = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion

            #region Demonstration on Collections (Hashtable Class)
            Console.WriteLine("\nDEMONSTRATION ON COLLECTIONS - HASHTABLE CLASS");
            Hashtable ht = new Hashtable();

            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");
            //ht.Add("008", "Nuha Ali");

            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Nuha Ali");
            }

            // Get a collection of the keys.
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            #endregion

            #region Demonstration on Collections (Stack Class)
            Console.WriteLine("\nDEMONSTRATION ON COLLECTIONS - STACK CLASS");
            Stack st = new Stack();

            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");

            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            #endregion

            #region Day18: Queues and Stacks
            //Description: Tests if a string is a palindrome or not
            Console.WriteLine("\n\nDEMONSTRATION ON STACKS AND QUEUES\nInput String: ");
            // read the string strPal
            string strPal = Console.ReadLine();

            // create the Solution class object p.
            StacksQueues obj = new StacksQueues();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in strPal)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < strPal.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a PALINDROME.", strPal);
            }
            else
            {
                Console.Write("The word, {0}, is NOT a palindrome.", strPal);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
