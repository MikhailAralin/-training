using System.Text.RegularExpressions;

namespace Input_Output
{
    public static class Check
    {
        public static string Checking(string toCheck)
        {
            string toReturn;
            do
            {
                Console.Write($"Введите {toCheck}:");
            } while (!Regex.IsMatch(toReturn = Console.ReadLine(), @"^[a-zA-Zа-яА-ЯёЁ]+$"));
            return toReturn;
        }
    }
}
