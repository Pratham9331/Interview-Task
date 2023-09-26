
class Program
{
    static void Main()
{
        string str = "this world is interesting";
        string substring1 = "int";
        string substring2 = "pro";
        bool found1 = IsBiggerString(str, substring1);
        bool found2 = IsBiggerString(str, substring2);
        Console.WriteLine($"substring – { substring1} found – { found1 }");
        Console.WriteLine($"substring – { substring2} found – { found2 }");
        Console.ReadLine();
    }
    static bool IsBiggerString(string str, string substring)
{
        int inplen = substring.Length;
        int strlen = str.Length;
        for(int i = 0; i < strlen - inplen; i++)
{
            bool isMatch = true;
            for(int j = 0; j < inplen; j++)
{
                if(str[i + j] != substring[j])
{
                    isMatch = false;
                    break;
                }
            }
            if(isMatch)
{
                return true;
            }
        }
        return false;
    }
}
