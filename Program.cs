using MLModel_ConsoleApp1.Services;

while (true)
{
    Console.WriteLine("\nInput a name to guess their gender.");
    string input = Console.ReadLine() ?? "John";
    if (input == string.Empty || input.ToLower() == "quit")
    {
        break;
    }
    Console.Clear();
    MLCon.MakePrediction(input);
}

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

