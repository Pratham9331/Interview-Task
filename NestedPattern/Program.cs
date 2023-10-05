class Program
{
    static void Main()
    {
        int n = 5;

        // Will Print Pattern
        //        
        //        *
        //      * *
        //    * * * 
        //  * * * * 
        //* * * * * 
        //for(int i = 0; i <= n; i++)
        //{
        //    for(int j = i; j <= n; j++)
        //    {
        //        Console.Write("  ");
        //    }
        //    for(int j = 1; j <= i; j++)
        //    {
        //        Console.Write("* ");
        //    }

        //    Console.WriteLine();
        //}

        #region Pattern 2
        // Will Print Pattern
        //        
        //* * * * * 
        //  * * * *
        //    * * *
        //      * *    
        //        *   

        //for(int i = 1; i <= n; i++) 
        //{
        //    for(int j = 1; j <= i; j++)
        //    {
        //        Console.Write("  ");
        //    }
        //    for(int j=i; j<=n; j++)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}


        #endregion

        #region Pattern 3
        //1
        //* 3 
        //* 5 *
        //7 * 9 *
        //
        int p = 4;
        int temp = 1;
        for (int i = 1; i <= p; i++) {
            for(int j=1;j<=i; j++)
            {
                if(temp % 2 == 0)
                {
                    Console.Write($"* ");
                    temp++;
                }
                else
                {
                    Console.Write($"{temp} ");
                    temp++;
                }
            }
            Console.WriteLine();
        }


        #endregion
        #region Pattern 4
        //1
        //* 3 
        //# 5 #
        //7 * 9 *
        //
        int k = 4;
        int temp1 = 1;
        for (int i = 1; i <= k; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (temp1 % 2 == 0)
                {
                    if (temp1 >= 4 && temp1 <= 6)
                    { Console.Write("# "); }
                    else { Console.Write($"* "); }
                    temp1++;
                }
                else
                {
                    Console.Write($"{temp1} ");
                    temp1++;
                }
            }
            Console.WriteLine();
        }
        #endregion
        #region Pattern 5
       
        int a = 4;
        for (int i = 1; i <= a; i++)
        {
            for (int j = i; j <= a; j++)
            {
                Console.Write("  ");
            }
            for(int j=1; j < i ; j++)
            {
                Console.Write($"* ");
            }
            for(int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }


        #endregion
        Console.WriteLine("New Pattern");
        #region Pattern 6

        int b = 4;
        for (int i = 1; i <= b; i++)
        {
          for(int j = 1; j <= i; j++)
            {
                Console.Write("  ");
            }
          for(int j= i; j < b; j++)
            {
                Console.Write("* ");
            }
            for (int j = i; j <= b; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }


        #endregion
        Console.WriteLine("New Pattern");
        #region Pattern 7

        int c = 4;
        for (int i = 1; i < c; i++)
        {
            for (int j = i; j <= c; j++)
            {
                Console.Write("  ");
            }
            for (int j = 1; j < i; j++)
            {
                Console.Write($"* ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        for (int i = 1; i <= c; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("  ");
            }
            for (int j = i; j < c; j++)
            {
                Console.Write("* ");
            }
            for (int j = i; j <= c; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }


        #endregion
        Console.ReadLine();
    }
}