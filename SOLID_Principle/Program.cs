using System;

namespace SOLID_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            Logger logger = new Logger();

            while (true)
            {
                Console.WriteLine("Seleccione el tipo de notificación:");
                Console.WriteLine("1. Email");
                Console.WriteLine("2. SMS");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                int option = int.Parse(Console.ReadLine());

                if (option == 1 || option == 2)
                {
                    // Solicitar mensaje
                    Console.Write("Ingrese el mensaje: ");
                    string message = Console.ReadLine();

                    if (option == 1)
                    {
                        // Enviar correo electrónico
                        Console.Write("Ingrese el correo electrónico: ");
                        string email = Console.ReadLine();
                        emailService.SendEmail(email, message);
                    }
                    else if (option == 2)
                    {
                        // Enviar SMS
                        Console.Write("Ingrese el número de teléfono: ");
                        string phoneNumber = Console.ReadLine();
                        smsService.SendSMS(phoneNumber, message);
                    }

                    // Registrar la notificación en logs
                    logger.LogNotification($"Notificación enviada: {message}");
                }
                else if (option == 3)
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                }
            }
        }
    }

    // Clase para enviar correos electrónicos
    public class EmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Enviando Email a {email}: {message}");
        }
    }

    // Clase para enviar SMS
    public class SMSService
    {
        public void SendSMS(string phoneNumber, string message)
        {
            Console.WriteLine($"Enviando SMS a {phoneNumber}: {message}");
        }
    }

    // Clase para registrar logs
    public class Logger
    {
        public void LogNotification(string message)
        {
            Console.WriteLine($"Registrando en logs: {message}");
        }
    }
}
