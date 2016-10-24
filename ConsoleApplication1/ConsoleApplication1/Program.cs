using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using ConsoleApplication1.ServiceReference1;




namespace ConsoleApplication1
{
    
    class Program
    {
        

        static void Main(string[] args)
        {
            ConsoleWriter writer = new ConsoleWriter();
            Service1Client client = new Service1Client();

            try
            {
                writer.Write("Проверка соединения с сервисом... ");
                if (!string.Equals(client.TestConnection(), "OK", StringComparison.InvariantCultureIgnoreCase))
                    {
                        throw new Exception("Проверка соединения не удалась");
                    }
                writer.WriteLineSuccess();
                writer.WriteLine();

                Console.Write("Введите логин и нажмите Enter: ");
                string log = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Введите пароль и нажмите Enter: ");
                string pas = Console.ReadLine();


                try
                {
                    writer.Write("Проверка входа: ");
                    if (!string.Equals(client.Auten(log, pas), "OK", StringComparison.InvariantCultureIgnoreCase))
                    {
                        throw new Exception("Неверно указан логин или пароль");
                    }
                    writer.WriteLineSuccess();
                    writer.WriteLine();

                    Console.Write("Введите имя и нажмите Enter: ");
                    string name = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine(client.GetData(string.Format(name)));

                    Console.WriteLine();
                    Console.Write("Введите сообщение и нажмите Enter: ");
                    string otv = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine(client.Message1(string.Format(otv)));


                }
                catch (Exception ex)
                {

                    client.Abort();


                    writer.WriteLine();
                    writer.WriteLineError("Ошибка: {0}", ex.Message);

                }
        
            }
            catch (Exception ex)
            {
                
                client.Abort();

              
                writer.WriteLine();
                writer.WriteLineError("Ошибка: {0}", ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
