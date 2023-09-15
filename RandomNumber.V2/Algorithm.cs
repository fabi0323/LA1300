using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber.V2
{
    public class Algorithm
    {
        
        public static int Algorythmus(int[] lastGuesses)
        {

            double temp1, temp2, temp3, temp4, temp5, temp6, temp7, temp8, temp9, temp10, temp11, temp12, temp13, temp14, temp15, temp16, temp17, temp18, temp19, temp20, temp21;
            int x;
            int number1 = lastGuesses[0];
            int number2 = lastGuesses[1];
            int number3 = lastGuesses[2];
            int number4 = lastGuesses[3];
            int number5 = lastGuesses[4];
            int number6 = lastGuesses[5];
            int number7 = lastGuesses[6];
            int number8 = lastGuesses[7];
            int number9 = lastGuesses[8];
            int number10 = lastGuesses[9];

            try
            {
                temp1 = number1 * number4 + number9;

                try
                {
                    temp2 = number4 / number2 - number3;
                }
                catch (DivideByZeroException)
                {
                    temp2 = number4 + number2 - number3;
                }

                temp3 = number5 - number6 * number10;
                temp4 = number8 + number7;
                temp5 = temp1 * temp2 + temp3;
                temp6 = temp4 + temp5 + temp2 * temp1;
                temp7 = temp6 - number10;

                if (temp3 > temp4)
                {
                    temp8 = temp3 / temp4;
                }
                else
                {
                    temp8 = temp4 / temp3;
                }

                temp9 = temp1 + temp2 - temp3;
                temp10 = temp5 * temp6 + temp7 / temp8;

                try
                {
                    temp11 = number1 / temp1 - temp2 + temp3;
                }
                catch (DivideByZeroException)
                {
                    temp11 = number1 + temp2 - temp3;
                }

                temp12 = number4 + temp4 - temp5 / temp6;
                temp13 = number7 - temp7 - temp8;
                temp14 = number2 * temp9 - temp10 / number3;

                if (temp6 > temp7)
                {
                    temp15 = temp6 / temp7;
                }
                else
                {
                    temp15 = temp7 / temp6;
                }

                temp16 = number5 * temp1 + temp2 - temp3 / number6;

                try
                {
                    temp17 = temp11 / temp12 + temp13;
                }
                catch (DivideByZeroException)
                {
                    temp17 = temp11 * temp12 - temp13;
                }
                temp18 = temp15 * number9 - number6 * temp6;
                if (temp16 > temp17)
                {
                    temp19 = temp16 / temp17;
                }
                else
                {
                    temp19 = temp17 / temp16;
                }

                temp20 = number8 + temp18 + temp19 / temp15;
                temp21 = (temp20 + temp19 -temp18 * temp17
                    /temp16 - temp15 - temp14 + temp13 * temp12 + temp11 
                    - temp10 + temp9 + temp8 / temp7 * temp8 * temp7 * temp6
                    -temp5 + temp4 * temp3 - temp2 + temp1) /100000000 *-1;
                if(temp21 > 2147483647)
                {
                    throw new Exception();
                }
                 x = (int)Math.Round(temp21);
            }
            catch
            {
                Console.WriteLine("X went over the 32bit integer limit, game will continue with regular random numbers");
                 x = new Random().Next(1, 101);
            }
            switch (x)
            {
                case int when x < -100000:
                    Console.WriteLine("X is less than -100,000");
                    break;
                case int when x < -10000:
                    Console.WriteLine("X is less than -10'000");
                    break;
                case int when x < -1000:
                    Console.WriteLine("X is less than -1,000 but not less than -100,000");
                    break;
                case int when x < -100:
                    Console.WriteLine("X is less than -100 but not less than -1,000");
                    break;
                case int when x < 0:
                    Console.WriteLine("X is less than 0 but not less than -100");
                    break;
                case int when x < 100:
                    Console.WriteLine("X is less than 100 but not less than 0");
                    break;
                case int when x < 1000:
                    Console.WriteLine("X is less than 1,000 but not less than 100");
                    break;
                case int when x < 10000:
                    Console.WriteLine("X is less than 10,000 but not less than 1,000");
                    break;
                case int when x < 100000:
                    Console.WriteLine("X is less than 100,000 but not less than 10,000");
                    break;
                default:
                    Console.WriteLine("X is greater than or equal to 100,000");
                    break;
            }

            return x;
        }
    }
}
