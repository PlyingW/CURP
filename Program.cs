using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string curpPattern = @"^[A-Z0-9]{15}$";
        string emailPattern = @"^[\w.%+-]+@gmail\.com$";

        string curp = string.Empty;
        string email = string.Empty;

        do
        {
            Console.WriteLine("Ingrese su CURP (debe ser un conjunto de 15 digitos:");
            curp = Console.ReadLine();

            Console.WriteLine("Ingrese su correo electrónico (Gmail):");
            email = Console.ReadLine();

            if (!Regex.IsMatch(curp, curpPattern))
            {
                Console.WriteLine("El CURP ingresado no es válido. Por favor, inténtelo de nuevo.");
            }

            if (!Regex.IsMatch(email, emailPattern))
            {
                Console.WriteLine("El correo electrónico ingresado no es válido. Por favor, inténtelo de nuevo.");
            }

        } while (!Regex.IsMatch(curp, curpPattern) || !Regex.IsMatch(email, emailPattern));

        Console.WriteLine($"su CURP es: {curp}");
        Console.WriteLine($"Su correo electronico es: {email}");
    }
}
