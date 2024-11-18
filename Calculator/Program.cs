using System.Runtime.ConstrainedExecution;

public class Program()
{
    static void Main()
    {
        int num1;
        int num2;
        int equals;

        bool bl = true;

        while (bl) {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Do you want to [S]ubtract, [A]dd, [M]ultiplicate or [D]ivide?");
            Console.Write("S, A, M, D :> ");
                string userinput = Console.ReadLine();
                    string mathtype = userinput;    

                userinput = "";
                Console.WriteLine("Give me the first number;");
                Console.Write(":> ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                userinput = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                num1 = Int32.Parse(userinput);

                userinput = "";
                Console.WriteLine("Give me the second number;");
                Console.Write(":> ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                userinput = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                num2 = Int32.Parse(userinput);
                userinput = "";

                switch (mathtype.ToLower())
                {
                    case "s":

                        equals = num1 - num2;

                        Console.Write("The Number one " + num1 + " subtracted from the Number two " + num2 + " equals: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(equals);
                        Console.ForegroundColor = ConsoleColor.White;

                        bl = false;

                        break;
                    case "a":

                        equals = num1 + num2;

                        Console.Write("The Number one " + num1 + " added to the Number two " + num2 + " equals: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(equals);
                        Console.ForegroundColor = ConsoleColor.White;
                            
                        bl = false;

                        break;
                case "m":

                    equals = num1 * num2;

                    Console.Write("The Number one " + num1 + " multiplied with the Number two " + num2 + " equals: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(equals);
                    Console.ForegroundColor = ConsoleColor.White;

                    bl = false;

                    break;
                case "d":

                    equals = num1 / num2;

                    Console.Write("The Number one " + num1 + " divided by the Number two " + num2 + " equals: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(equals);
                    Console.ForegroundColor = ConsoleColor.White;

                    bl = false;

                    break;
                default:
                    Console.Write("Please enter a valid number combination!");
                    break;

            }
        }
    }
}
