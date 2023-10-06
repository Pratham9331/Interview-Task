class Program
{
    static void Main()
    {
        string input = "I know what to Do, so Don't Tell Me";
        string rev = string.Empty;
        //Reversing the String
        for(int i = input.Length-1; i >=0 ; i--)
        {
            rev = rev +input[i];
        }
        Console.WriteLine(rev);
        Console.ReadLine();
    }
}