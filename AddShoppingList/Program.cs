internal class Program
{
    static void Main(string[] args)
    {
        string fileLocation = @"D:\OneDrive\TKTK\Programmeerimise algkursus (RKE132) -\Samples\ShoppingList";
        string fileName = @"\\MyShoppingList.txt";

        string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
        List<string> myShoppingList = arrayFromFile.ToList<string>();

        bool loopActive = true;
        while (loopActive)
        {
            Console.WriteLine("Kas sa soovid lisada kaupu poe nimekirja? Y/N:");
            char userInput = Convert.ToChar(Console.ReadLine().ToLower());

            if (userInput == 'y')
            {
                Console.WriteLine("Sisesta mis sa poest tuua tahad:");
                string userItem = Console.ReadLine();
                myShoppingList.Add(userItem);
            }
            else
            {
                loopActive = false;
                Console.WriteLine("Mine poodi");

            }
        }

        Console.Clear();
        foreach (string item in myShoppingList)
        {
            Console.WriteLine($"Osta: {item}");
        }
        File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);

    }
}