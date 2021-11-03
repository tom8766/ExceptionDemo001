using System;

namespace ExceptionDemo001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Demonstration ");
            Divide(6, 3, "Answer");
            int[] numbers = new int[2];

            try
            {
                numbers[0] = 0;
                numbers[1] = 1;
                numbers[2] = 2;

                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                }
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An IndexOutOfRangeException was thrown");
            }

            catch (Exception e)
            {
                Console.WriteLine("An General Exception was thrown ");
            }

            finally
            {
                Console.WriteLine("Finished process,exception thrown, have closed all issues");
            }

            try
            {
                Divide(6, 3, "Answer");
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("An DivideByZeroException was thrown");
            }

            catch(Exception ex)
            {

            }

            finally
            {

            }

            try
            {
                Show(null, 59);
            }

            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {

            }
        }

            private static void Divide(int a,int b,string s)
            {
                int result = a / b;

                Console.WriteLine($"{s.ToUpper()}: {result}");
            }

            private static void Show(string fname,int age)
            {
                if(fname is null)
                {
                throw new ArgumentException("Parameter fname cannot be null","Fname");
                }
                Console.WriteLine($"{fname} is {age} years old");
            }
        }
    }

