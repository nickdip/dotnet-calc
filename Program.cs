class Calculator
{
    public static double DoOperation(double num1, double num2, string op) // public means that this method an be accessesed from other classes. Static means that it belongs to class itself. We can call this method without creating an instance 
    {
        double result = double.NaN; //Not a Number is a feault return

        switch (op)
        {
            case "+":
                Console.WriteLine($"Your result is: {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Your result is: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Your result is: {num1 * num2}");
                break;
            case "/":
                while (num2 == 0)
                {
                    Console.WriteLine("Please choose a non-zero divisor:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine($"Your result is: {num1 / num2}");
                break;
        }

        return result;
    }

}


class CalcProgram
{
    static void Main(string[] args) //why string[] args?
    {
        bool endApp = false;

        while (!endApp)
        {
            string[] inputs = { "", "" }; // initalize arrays with curly brackets

            double[] nums = { 0, 0 };

            string operand;

            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Type a number and then press enter");

                inputs[i] = Console.ReadLine();

                while (!double.TryParse(inputs[i], out nums[i]))
                { //out implies it's memory location has been modified by the method 
                    Console.WriteLine("You must write a number rather than a string");
                    inputs[i] = Console.ReadLine();
                }

                Console.WriteLine("+ - Add");
                Console.WriteLine("- Subtract");
                Console.WriteLine("* - Muliply");
                Console.WriteLine("/ - Divide");
                Console.WriteLine("Please choose an operand:");

                string[] operands = { "+", "-", "*", "/" };

                operand = Console.ReadLine();

                while (!Array.Exists(operands, element => element == operand))
                {
                    Console.WriteLine("Please write one of the available operands");
                    operand = Console.ReadLine();
                        
                }
            }

            //try
            //{
            //    double result = Calculator.DoOperation(nums[0], nums[1], operand);
            //}





            }









    }
}
