using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryISMPrakt04
{
    public class Class1
    {
        public static int ForConsole1(int a, int b)
        {
            int res = 1;
            for (int x = a; x <= b; ++x)
            {
                res *= x;
            }

            return res;
        }
        public static double ForConsole2(int n)
        {
            double res = 0;
            if (n > 0)
            {
                for (int x = 1; x <= n; ++x)
                {
                    res = res + (1.0 / x);
                }
            }
            return res;
        }
        public static double ForConsole3(double a, int n)
        {
            double res = 1;
            if (n > 0)
            {
                for (int x = 1; x <= n; ++x)
                    res = res * a;
            }
            else if (n == 0)
            {
                res = 0;
            }
            return res;
        }
        public static int ForConsole4(int a, int b)
        {
            int res = 0;
            for (int i = a; i <= b; ++i)
            {
                res += (i * i);
            }
            return res;
        }
        public static int ForConsole5(int n)
        {
            int res = 0, f = 1;
            if (n > 0)
            {
                for (int i = 1; i <= n; ++i)
                {
                    for (int j = 1; j <= i; ++j)
                    {
                        f = f * j;
                    }
                    res = res + f;
                    f = 1;
                }
            }
            return res;
        }
        public static double WhileConsole1(int n)
        {
            double res = 0;
            int i = 1;
            if (n > 0)
            {
                while (i <= n)
                {
                    res = res + Math.Pow(i, (n - i));
                    ++i;
                }   
            }
        return res;
        }
        public static int WhileConsole2(int n)
        {
            int k = 1,res=0;
            if (n > 1)
            {
                while (k <= n)
                {
                    if (Math.Pow(3, k) > n)
                    {
                        res = k;
                        
                        k = n;
                    }
                    ++k;
                }
            }
            return res;
        }
        public static double WhileConsole3 (int p)
        {
            double z = 10, s = 0, res = 0;
            int day = 1;
            while (day <= 20)
            {
                z = z + (z * p / 100);
                s = s + z;
                if (s > 200)
                {
                    res = s; 
                    //Console.WriteLine($"Day={day}");
                    day = 21;
                }
                ++day;
            }
            return res;
        }
        public static double WhileConsole31(int p)
        {
            double z = 10, s = 0, res = 0;
            int day = 1;
            while (day <= 20)
            {
                z = z + (z * p / 100);
                s = s + z;
                if (s > 200)
                {
                    res = day;
                    
                    day = 21;
                }
                ++day;
            }
            return res;
        }
        
    }
}


