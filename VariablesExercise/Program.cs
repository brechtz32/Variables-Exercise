namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string petName;
            petName = "Charlie";

            int petAge = 6;

            char middleInitial = 'E';

            bool isBig = true;

            double petWeight = 110.5;

            decimal petHeight = 32.5m;

            Console.WriteLine($"Hello! I have a dog and his name is {petName}. {petName} {middleInitial} Porkchop. He is {petAge} years old.");
            Console.WriteLine($"{petName} weighs {petWeight} lbs. and is {petHeight} inches tall. Is {petName} big? {isBig}!");

        }
    }
}
