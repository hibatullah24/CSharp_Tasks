using System;

namespace Function_task_UserDefined
{
    internal class Program
    {
        static void DisplayMenu()
        {
            Console.WriteLine("\n========= MENU =========");
            Console.WriteLine("1. Print Daily Greeting");
            Console.WriteLine("2. Star Border");
            Console.WriteLine("3. Random Motivational Quote");
            Console.WriteLine("4. Personalised Invoice Header");
            Console.WriteLine("5. Number Pattern Printer");
            Console.WriteLine("6. Word Frequency Analyser");
            Console.WriteLine("7. Temperature Converter");
            Console.WriteLine("8. Password Strength Checker");
            Console.WriteLine("9. Simple Statistics Calculator");
            Console.WriteLine("10. Session Timer");
            Console.WriteLine("11. Magic Number Generator");
            Console.WriteLine("12. Inspirational Day Message");
            Console.WriteLine("13. Flexible Discount Calculator");
            Console.WriteLine("14. Configurable Report Header");
            Console.WriteLine("15. Smart Product Search");
            Console.WriteLine("16. Exit");
            Console.Write("Choose an option: ");
        }

        static void PrintDailyGreeting()
        {
            Console.WriteLine("Good morning, Trainee!");

            DateTime now = DateTime.Now;

            Console.WriteLine("Date: " + now.ToString("dd/MM/yyyy"));
            Console.WriteLine("Time: " + now.ToString("hh:mm tt"));

            Console.WriteLine("Let's code something great today!");
        }

        static void PrintInvoiceHeader(string customerName, string invoiceDate)
        {
            string[] words = customerName.ToLower().Split(' ');
            string formatName = ""; 

            for (int i=0; i <words.Length; i++)
            {
                if (words[i] !="")
                {
                    string word = words[i];
                    string capitalized = char.ToUpper(word[0]) + word.Substring(1);
                    formatName += capitalized + " ";
                }
            }

            formatName = formatName.Trim();

            if(string.IsNullOrWhiteSpace(invoiceDate))
            {
                invoiceDate = " Date not provided";
            }

            Console.WriteLine("===============================");
            Console.WriteLine("INVOICE");
            Console.WriteLine("customer: " + formatName);
            Console.WriteLine("Date: " + invoiceDate);
            Console.WriteLine("===============================");


        }


        static void Main(string[] args)
        {
            bool exit = false;

            while (exit == false)
            {
                DisplayMenu();

                int choice = 0;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        PrintDailyGreeting();
                        break;

                    case 2:
                        Console.WriteLine("Star Border not implemented yet");
                        break;

                    case 3:
                        Console.WriteLine("Random Motivational Quote not implemented yet");
                        break;

                    case 4:
                        Console.WriteLine("Enter Customer Name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter invoice date: ");
                        string date = Console.ReadLine();

                        PrintInvoiceHeader(name, date);
                           


                        break;

                    case 5:
                        Console.WriteLine("Number Pattern Printer not implemented yet");
                        break;

                    case 6:
                        Console.WriteLine("Word Frequency Analyser not implemented yet");
                        break;

                    case 7:
                        Console.WriteLine("Temperature Converter not implemented yet");
                        break;

                    case 8:
                        Console.WriteLine("Password Strength Checker not implemented yet");
                        break;

                    case 9:
                        Console.WriteLine("Simple Statistics Calculator not implemented yet");
                        break;

                    case 10:
                        Console.WriteLine("Session Timer not implemented yet");
                        break;

                    case 11:
                        Console.WriteLine("Magic Number Generator not implemented yet");
                        break;

                    case 12:
                        Console.WriteLine("Inspirational Day Message not implemented yet");
                        break;

                    case 13:
                        Console.WriteLine("Flexible Discount Calculator not implemented yet");
                        break;

                    case 14:
                        Console.WriteLine("Configurable Report Header not implemented yet");
                        break;

                    case 15:
                        Console.WriteLine("Smart Product Search not implemented yet");
                        break;

                    case 16:
                        Console.Write("Are you sure you want to exit? (yes/no): ");
                        string exitInput = Console.ReadLine().ToLower();

                        if (exitInput == "yes")
                        {
                            Console.WriteLine("Exiting system...");
                            Console.WriteLine("Thank you for using our System");
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Exit cancelled. Returning to main menu...");

                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine("Press any key continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}