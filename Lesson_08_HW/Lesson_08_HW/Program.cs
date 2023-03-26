namespace Lesson_08_HW
{
    internal class Program
    {

        static void checkAge(int age)
        {
            if (age  < 10)
            {
                throw new ArithmeticException("Access is denided!");
            }

            else if (age < 18) 
            {
                throw new ArithmeticException("Access is denided!");    
            }

            else
            {
                Console.WriteLine("Access gained - you're old enought!");
            }

        }

        static void try_catch_Test ()
        {
            try
            {
                int[] ints = { 1, 2, 3 };
                Console.WriteLine(ints[10]);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("You have some errors");
            }
        }

        static void Main(string[] args)
        {
            checkAge(16);
            Console.WriteLine();
            Console.WriteLine("You have some errors" + try_catch_Test);
        }
    }
}