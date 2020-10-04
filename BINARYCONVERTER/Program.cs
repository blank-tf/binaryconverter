// this tool isn't very good and it could probably be done better but i didn't
// want to have to translate characters to binary by hand so I just wrote this tool

using System;
using System.Text;

namespace BINARYCONVERTER
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string binStr;
            int binStrLength;
            
            Console.WriteLine("ENTER YOUR STRING");
            binStr = Console.ReadLine();
            binStr = binStr.ToLower();
            binStrLength = binStr.Length;
            Console.WriteLine(binStrLength);
            while (true)
            {
                Console.WriteLine("DECODE or ENCODE?");
                string answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "encode")
                {
                    binStr = binStr.Replace("a", "00001");
                    binStr = binStr.Replace("b", "00010");
                    binStr = binStr.Replace("c", "00011");
                    binStr = binStr.Replace("d", "00100");
                    binStr = binStr.Replace("e", "00101");
                    binStr = binStr.Replace("f", "00110");
                    binStr = binStr.Replace("g", "00111");
                    binStr = binStr.Replace("h", "01000");
                    binStr = binStr.Replace("i", "01001");
                    binStr = binStr.Replace("j", "01010");
                    binStr = binStr.Replace("k", "01011");
                    binStr = binStr.Replace("l", "01100");
                    binStr = binStr.Replace("m", "01101");
                    binStr = binStr.Replace("n", "01110");
                    binStr = binStr.Replace("o", "01111");
                    binStr = binStr.Replace("p", "10000");
                    binStr = binStr.Replace("q", "10001");
                    binStr = binStr.Replace("r", "10010");
                    binStr = binStr.Replace("s", "10011"); 
                    binStr = binStr.Replace("t", "10100");
                    binStr = binStr.Replace("u", "10101");
                    binStr = binStr.Replace("v", "10110");
                    binStr = binStr.Replace("w", "10111");
                    binStr = binStr.Replace("x", "11000");
                    binStr = binStr.Replace("y", "11001");
                    binStr = binStr.Replace("z", "11010");
                    binStr = binStr.Replace(" ", "00000");
                    Console.WriteLine(binStr);
                    break;
                }
                else if (answer == "decode")
                {
                    string test = binStr;
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < test.Length; i++)
                    {
                        if (i % 5 == 0)
                            sb.Append('_');
                        sb.Append(test[i]);
                    }
                    string formatted = sb.ToString();
                    formatted = formatted.Replace("00001", "a");
                    formatted = formatted.Replace("00010", "b");
                    formatted = formatted.Replace("00011", "c");
                    formatted = formatted.Replace("00100", "d");
                    formatted = formatted.Replace("00101", "e");
                    formatted = formatted.Replace("00110", "f");
                    formatted = formatted.Replace("00111", "g");
                    formatted = formatted.Replace("01000", "h");
                    formatted = formatted.Replace("01001", "i");
                    formatted = formatted.Replace("01010", "j");
                    formatted = formatted.Replace("01011", "k");
                    formatted = formatted.Replace("01100", "l");
                    formatted = formatted.Replace("01101", "m");
                    formatted = formatted.Replace("01110", "n");
                    formatted = formatted.Replace("01111", "o");
                    formatted = formatted.Replace("10000", "p");
                    formatted = formatted.Replace("10001", "q");
                    formatted = formatted.Replace("10010", "r");
                    formatted = formatted.Replace("10011", "s"); 
                    formatted = formatted.Replace("10100", "t");
                    formatted = formatted.Replace("10101", "u");
                    formatted = formatted.Replace("10110", "v");
                    formatted = formatted.Replace("10111", "w");
                    formatted = formatted.Replace("11000", "x");
                    formatted = formatted.Replace("11001", "y");
                    formatted = formatted.Replace("11010", "z");
                    formatted = formatted.Replace("00000", " ");
                    Console.WriteLine(formatted);
                    break;
                }
                else
                {
                    Console.WriteLine("please type encode or decode");
                }
            }
            
            
        }
        
    }

    
}