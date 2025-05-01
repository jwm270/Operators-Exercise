namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"17/4 is {quotient} remainder {remainder}");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k); //i = ++3 so 4, j = 4++ after is disregarded so 4*4=16
        }

        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

    }
    
}
