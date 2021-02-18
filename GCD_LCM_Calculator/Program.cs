using System;
using System.Collections.Generic;

namespace GCD_LCM_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            long number,num1Gcd,num2Gcd,num3Gcd,num1Lcm,num2Lcm,num3Lcm,x1,x2,Lcm; 
            int a=1,b=1,c=1;
            var listOfNumber = new List<long>();
            while (true)
            {
                Console.Write("\nEnter a positive integer (or 0 if no more): ");
                if (!long.TryParse(Console.ReadLine(), out number) || number < 0)
                    Console.WriteLine("Invalid number");
                    else if(number>0)
                {
                    listOfNumber.Add(number);
                }
                    else
                {
                    num1Gcd = listOfNumber[0];
                    num2Gcd = listOfNumber[a];
                    num3Gcd = num1Gcd % num2Gcd;
                    num1Lcm = listOfNumber[0];
                    num2Lcm = listOfNumber[b];
                    num3Lcm = num1Lcm % num2Lcm;
                    x1      = listOfNumber[0];
                    x2      = listOfNumber[c];
                    
                    for (int i = 1; i <listOfNumber.Count;i++) {
                        while (num3Gcd != 0) {
                            num1Gcd = num2Gcd;
                            num2Gcd = num3Gcd;
                            num3Gcd = num1Gcd % num2Gcd;
                        }
                            num1Gcd = num2Gcd;
                        while (a < listOfNumber.Count-1)
                        {
                            a++;
                            num2Gcd = listOfNumber[a];
                            num3Gcd = num1Gcd % num2Gcd;
                        }
                      }
                    for (int j = 1; j < listOfNumber.Count; j++) {
                        while (num3Lcm != 0) {
                            num1Lcm = num2Lcm;
                            num2Lcm = num3Lcm;
                            num3Lcm = num1Lcm % num2Lcm;
                        }
                        Lcm = (x1 * x2) / num2Lcm;
                        x1 = Lcm;
                        if (c < listOfNumber.Count - 1)
                        {
                            c++;
                            x1 = Lcm;
                            x2 = listOfNumber[c];
                            b++;
                            num1Lcm = x1;
                            num2Lcm = listOfNumber[b];
                            num3Lcm = num1Lcm % num2Lcm;
                        }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"GCD = {num1Gcd}");
                        Console.WriteLine($"LCM = {x1}");
                        break;
                }
               }
            }
        }
    }
