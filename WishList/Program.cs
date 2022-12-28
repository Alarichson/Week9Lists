internal class Program
{
    private static void Main(string[] args)
    {
        List<string> myWishlist = new List<string>();

        Console.WriteLine(myWishlist.Count);

        myWishlist.Add("coffe machine");
        myWishlist.Add("new pair of socks");
        myWishlist.Add("box of chocolates");
        myWishlist.Add("new pillow");

        Console.WriteLine(myWishlist.Count);

        Console.WriteLine(myWishlist[0]);
        foreach (string wish in myWishlist)
        {
            Console.WriteLine(wish);
        }

    }
}