using UserCommon;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в консольный клиент");

            string result = ApiUtility.GetApiResponseAsync(Console.ReadLine()).Result;

            Console.WriteLine(result);

            Console.ReadKey();
        }
        
    }


}