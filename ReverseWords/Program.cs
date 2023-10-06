class Program
{
    static void Main()
    {
        int count = 0;

        string str = "Logical Interview Program";
       // str = str.Remove('.');
        char[] ch = str.ToCharArray();
        for(int i =ch.Length -1; i>=0; i--)
        {
            if (ch[i] != ' ')
            {
                count++;
            }
            else if (ch[i] == ' ')
            {
                for(int j=i+1;count>0; j++,count--)
                {
                    Console.Write(ch[j]);
                }
            }
        }
        for(int j = 0; j <= count; j++)
        {
            Console.Write(ch[j]);
        }
        Console.ReadLine();
    }
}