using System;
using System.Threading;
using functions;

namespace rcloneapp3
{
    public class Program
    {
        static void Main(string[] args)
        {

            functions.functions.command("color 0a");
            Startup();

        }
        public static void Startup()
        {
            Console.WriteLine("What operation would you like to execute?");
            Console.WriteLine(
@"1. Default mount
2. Stop mount
3. Mount
4. End program
");

            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    defaultMount();
                    break;
                case "2":
                    kill();
                    break;
                case "3":
                    Console.WriteLine("What config would you like to mount?");
                    functions.functions.command("rclone listremotes");
                    string config = Console.ReadLine();

                    Console.WriteLine("What letter would you like to mount?");
                    string letter = Console.ReadLine();

                    functions.functions.Mount(config, letter);
                    break;
                case "4":
                    Console.WriteLine("Killing rclone...");
                    functions.functions.command("taskkill /f /im rclone.exe");
                    Thread.Sleep(1000);
                    Console.WriteLine("You can close this window now.");

                    return;
                default:
                    Console.WriteLine("Invalid selection.");
                    Startup();
                    break;
            }
        }
        static void defaultMount()
        {
            Console.WriteLine("Are you sure you want to mount");

            functions.functions.configs();

            Console.WriteLine("Y/n");
            string confirmation = Console.ReadLine();

            confirmation = confirmation.ToLower();


            if (confirmation == "")
            {
                confirmation = "y";
            }

            switch (confirmation)
            {
                case "y":
                    Console.WriteLine("Running default mount...");

                    Run.Default.Mount();

                    Startup();
                    break;
                case "n":
                    Console.WriteLine("Ok cancelled");

                    Startup();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    defaultMount();
                    break;

            }
        }
        static void kill()
        {
            Console.WriteLine("Are you sure you want to kill rclone?");
            Console.WriteLine("Y/n");
            string confirmation = Console.ReadLine();

            if (confirmation == "")
            {
                confirmation = "y";
            }

            switch (confirmation)
            {
                case "y":
                    Console.WriteLine("Killing rclone...");

                    functions.functions.command("taskkill /f /im rclone.exe");

                    Thread.Sleep(2000);

                    Console.WriteLine("\nOk finished\n");

                    Startup();
                    break;
                case "n":
                    Console.WriteLine("Ok cancelled");

                    Startup();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    kill();
                    break;

            }
        }
    }
}
