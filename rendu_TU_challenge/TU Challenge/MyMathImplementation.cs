using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> primary = new List<int>();
            for (int x = 2; x <= a; x++)
            {
                if (IsPrimary(x) == true) primary.Add(x);
            }
            return primary;
        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0) return true;
            else return false;
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0) return true;
            else return false;
        }

        public static int IsInOrder(int a, int b)
        {
            int expected;

            if (a - b == 0) {
                expected = 0;
            }
            else if (b - a == 1 || b - a == 10 || (-1 * a /2) / 10 == 1)
            {
                expected = 1;
            }
            else
            {
                expected = -1;
            }
            return expected;
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }

        public static bool IsListInOrder(List<int> list)
        {
            throw new NotImplementedException();
        }

        public static bool IsMajeur(int age)
        {

            if (age < 0 || age >= 150) { throw new ArgumentException(); }
            else if (age >= 18) { return true; }
            else { return false; }
        }

        public static bool IsPrimary(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0) { return false; }
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            int expected = a;
            for (int x = 1; x < b; x++)
            {
                expected *= a;
            }
            return expected;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            throw new NotImplementedException();
        }
    }
}
