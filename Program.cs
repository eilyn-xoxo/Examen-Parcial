using System;


namespace PROGPARCIAL
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba lo que desea encriptar y desencriptar: ");
            string variable1 = string.Empty;
            variable1 = Console.ReadLine();
            Console.WriteLine(Rot13(variable1));
        }


        }

        static class Rot13
        {
           
            public static string Transform(string value)
            {


                char[] array = value.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    int number = (int)array[i];

                    if (number >= 'A' && number <= 'Z')
                    {
                        if (number > 'M')
                        {
                            number -= 13;
                        }
                        else
                        {
                            number += 13;
                        }
                    }
                    
                    array[i] = (char)number;
                }
                return new string(array);
            }
        }
    }
}
        