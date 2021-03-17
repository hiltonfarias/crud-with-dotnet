using System;

namespace CrudSeries
{
    class Program
    {
        static Classes.SeriesRepository seriesRepository = new Classes.SeriesRepository();
        static void Main(string[] args)
        {
            string userOption = GetUserOption();
            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        InsertSeries();
                        break;
                    case "3":
                        UpdateSeries();
                        break;
                    case "4":
                        DeleteSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                userOption = GetUserOption();
            }
            Console.WriteLine("Thank you for using our services");
            Console.ReadLine();
        }

        private static void DeleteSeries()
        {
            Console.WriteLine("Enter the series Id to be updated: ");
            int seriesId = int.Parse(Console.ReadLine());

            seriesRepository.Delete(seriesId);
        }

        private static void UpdateSeries()
        {
            Console.WriteLine("Enter the series Id to be updated: ");
            int seriesId = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
            }

            Console.WriteLine("Enter the genre between the options above: ");
            int genderEntry = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the title of series: ");
            string titleEntry = Console.ReadLine();

            Console.WriteLine("Enter the year of the start of the series: ");
            int yearEntry = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the description of series: ");
            string descriptionEntry = Console.ReadLine();

            Series updateSeries = new Series(
                id: seriesId, 
                genre: (Genre)genderEntry, 
                title: titleEntry, 
                description: descriptionEntry,
                year: yearEntry
            );
            seriesRepository.Update(seriesId, updateSeries);
        }

        private static void InsertSeries()
        {
            Console.WriteLine("Insert new Series");
            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
            }

            Console.WriteLine("Enter the genre between the options above: ");
            int genderEntry = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the title of series: ");
            string titleEntry = Console.ReadLine();

            Console.WriteLine("Enter the year of the start of the series: ");
            int yearEntry = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the description of series: ");
            string descriptionEntry = Console.ReadLine();

            Series newSeries = new Series(
                id: seriesRepository.NextId(),
                genre: (Genre)genderEntry, 
                title: titleEntry, 
                description: descriptionEntry,
                year: yearEntry
            );
            
            seriesRepository.Insert(newSeries);
        }

        private static void ListSeries()
        {
            Console.WriteLine("List Series");
            var list = seriesRepository.List();
            if (list.Count == 0)
            {
                Console.WriteLine("No series registered");
                return;
            }
            foreach (var series in list)
            {
                Console.WriteLine("#ID {0}: - {1}", series.returnId(), series.returnTitle());
            }
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("DIO series at your service");
            Console.WriteLine("Enter the desired option");

            Console.WriteLine("1 - List series");
            Console.WriteLine("2 - Insert new series");
            Console.WriteLine("3 - Update series");
            Console.WriteLine("4 - Delete series");
            Console.WriteLine("5 - View series");
            Console.WriteLine("C - Clear screen");
            Console.WriteLine("X - Get out");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}
