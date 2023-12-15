using System;

namespace Main
{
    class Math
    {
        public static float round(float f, int x)
        {
            string fString = f.ToString(); char[] fChar = fString.ToCharArray();
            int decimalLocation = 0;
            for (int i = 0; i < fChar.Length; i++)
            {
                if (fChar[i] != '.')
                {
                    decimalLocation++;
                }
                else if (fChar[i] == '.')
                {
                    break;    
                }
            }
            char[] fCharNext = new char[x + 1];
            for (int i = 0; i <= x; i++)
            {
                fCharNext[i] = fChar[i];
            }
            
            return f;
        }
    }
    class initialStatMain
    {
        public static string round(float f, int x) // Initial method attempt for one round
        {
            string fString = f.ToString(); char[] fChar = fString.ToCharArray(); string fRound = "";
            if (fChar[x + 1] >= 5)
            {
                
            }
            for (int i = 0; i <= x; i++)
            {
                fRound = String.Concat(fRound, fChar[i].ToString());
            }
            return fRound;
        }
        public static void Main(string[] args)
        {
            float roundingNum = 7.59431248723091f; int x = 4;

            Console.WriteLine(Math.round(roundingNum, x));
        }
    }
}