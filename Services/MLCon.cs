using static System.Formats.Asn1.AsnWriter;

namespace MLModel_ConsoleApp1.Services
{
    public class MLCon
    {
        public static void MakePrediction(string input)
        {
            var sampleData = new MLModel.ModelInput()
            {
                Name = input
            };

            PrintResult(sampleData);
        }

        static void PrintResult(MLModel.ModelInput data)
        {
            Console.WriteLine("Using model to make single prediction...");

            Console.WriteLine($"\nName: {data.Name}");

            var results = MLModel.PredictAllLabels(data);

            Console.WriteLine("\nResults:");
            foreach (var score in results)
            {
                Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
            }
            if (results.ToList()[0].Key == "M")
            {
                Console.WriteLine($"\nConclusion:\n{data.Name} is a Male");
            } else
            {
                Console.WriteLine($"\nConclusion:\n{data.Name} is a Female");
            }
        }
    }
}

