internal class Program
{
    private static void Main(string[] args)
    {
        string fileLocation = @"D:\OneDrive\TKTK\Programmeerimise algkursus (RKE132) -\Samples\wishList";
        string fileName = @"\wishlist.txt";

        string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");

        List<string> myWishList = arrayFromFile.ToList<string>();

        bool loopActive = true;
        while (loopActive)
        {
            Console.WriteLine("Would you like to add a wish? Y/N:");
            char userInput = Convert.ToChar(Console.ReadLine().ToLower());


            if (userInput == 'y')
            {
                Console.WriteLine("Enter your wish:");
                string userWish = Console.ReadLine();
                myWishList.Add(userWish);
            }
            else
            {
                loopActive = false;
                Console.WriteLine("Take care!");
            }
        }

        Console.Clear();
        foreach (string wish in myWishList)
        {
            Console.WriteLine($"Your wish {wish}");
        }
        File.WriteAllLines($"{fileLocation}{fileName}", myWishList);
    }
}