using System;

namespace LavelScale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0-High: Level of security High >> RED
            //1-Warning:Level of security Warning >> ORANGE
            //2-Info:Level of security Info >> WHITE
            //3-Debug:Level of security Debug >> SILVER

            int securityLavel = ReadNumber("Please enter security lavel:"); 
            while (securityLavel <0 ) 
            {
                securityLavel = ReadNumber("Please enter security lavel:");
            }
            Console.WriteLine("Security lavel:" + securityLavel);

            string securityMsg = CheckString();

            switch (securityLavel)
            { 
                 case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Security message:" + securityMsg);
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Security message:" + securityMsg);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Security message:" + securityMsg);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Security message:" + securityMsg);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Security message:" + securityMsg);
                    break;

            }


        }


        static int ReadNumber(string message) 
        {
            //bool fNumar = false;
            Console.Write(message);
            string txtRead = Console.ReadLine();
            bool fNumar = int.TryParse(txtRead, out int result);

            while (!fNumar)
            {
                if (fNumar)
                {
                    return result;
                }

                else
                {
                    Console.WriteLine("The entered value '" + txtRead + "' is not a number! ");
                    return -1;
                }

            }

            while (result < 0 || result > 3)
            {
                Console.WriteLine("The entered value '" + txtRead + "' for the security lavel must be between 0 and 3! ");
                return -1;
            }
            return result;
        }

        static string CheckString() //verific daca stringul este null ----
        {
            Console.Write("Please enter a message:");
            string strText = Console.ReadLine();
            bool isValidString = string.IsNullOrWhiteSpace(strText);
            while (isValidString)
            {
                if (string.IsNullOrWhiteSpace(strText))
                {
                    Console.WriteLine("Please enter a message not null:");
                    strText = Console.ReadLine();
                    isValidString = string.IsNullOrWhiteSpace(strText);

                }
                else
                {
                    isValidString = string.IsNullOrWhiteSpace(strText);

                }
            }
            return strText;

        }

    }
}