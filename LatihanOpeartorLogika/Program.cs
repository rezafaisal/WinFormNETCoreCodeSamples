using System;

namespace LatihanOperatorLogika
{
    class Program
    {
        static void Main(string[] args)
        {
            // negasi -- start
            bool passed = false;
            Console.WriteLine(!passed);  // output: True
            Console.WriteLine(!true);    // output: False
            // negasi -- end

            // operator &
            bool SecondOperand()
            {
                Console.WriteLine("Second operand is evaluated.");
                return true;
            }

            bool a = false & SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second operand is evaluated.
            // False

            bool b = true & SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated.
            // True

            // operator &&
            a = false && SecondOperand();
            Console.WriteLine(a);
            // Output:
            // False

            b = true && SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated.
            // True

            // operator ^
            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False

            // operator |

            a = true | SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second operand is evaluated.
            // True

            b = false | SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated.
            // True

            // operator ||
            a = true || SecondOperand();
            Console.WriteLine(a);
            // Output:
            // True

            b = false || SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated.
            // True
        }
    }
}
