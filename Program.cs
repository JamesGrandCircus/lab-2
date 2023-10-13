namespace Random_Dice_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int number = rng.Next();

            Console.WriteLine(number);
        }
    }
}