class Program
{
    static void Main()
    {

        string input = "This is a Demo";
        string[] inp = input.Split(' ');

        string output = reverse(inp);
        Console.WriteLine(output);
        Console.ReadLine();
    }

    static string reverse(string[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            char[] f = input[i].ToCharArray();
            Array.Reverse(f, 1, f.Length - 1);
            input[i] = new string(f);
        }
        return string.Join(" ", input);
    }
}