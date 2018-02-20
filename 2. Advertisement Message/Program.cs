using System;

namespace _2._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int messagesNumber = int.Parse(Console.ReadLine());
            string[] phrases = new string[] {
                "Excellent product.","Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            string[] events = new string[] {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] authors = new string[] {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            string[] towns = new string[] {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };
            Random number = new Random();
            for (int message = 0; message < messagesNumber; message++)
            {
                int phraseIndex = number.Next(0, phrases.Length);
                int eventIndex = number.Next(0, events.Length);
                int authorIndex = number.Next(0, authors.Length);
                int townIndex = number.Next(0, towns.Length);

                Console.WriteLine(phrases[phraseIndex] + " " + events[eventIndex] + " " + authors[authorIndex] + " - " + towns[townIndex]);
            }
        }
    }
}
