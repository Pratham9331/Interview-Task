
class Program
{
     static void Main()
    {
        int temp, sum = 0, rem;
        Console.WriteLine("Please Enter a Number :");
        int num = int.Parse(Console.ReadLine());
        temp = num;

        while (num > 0)
        {
            rem = num % 10;
            sum = sum + rem * rem * rem;
            num= num/10;
        }
        if (temp == sum)
        {
            Console.WriteLine("Given Number Armstrong Number.");
            Console.WriteLine("Thank You");
        }
        else
        {
            Console.WriteLine("Not A Armstrong Number.");


        }

        Console.ReadLine();
    }
}