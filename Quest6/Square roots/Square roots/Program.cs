using System.Collections.Generic;

namespace Square_roots
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите первое значение: ");
            int First = int.Parse(Console.ReadLine());
            Console.Write("Введите второе значение: ");
            int Second = int.Parse(Console.ReadLine());
            var MinNumber = Math.Min(First, Second);
            var MaxNumber = Math.Max(First, Second);
            var count = MaxNumber - MinNumber + 1;
            var range = Enumerable.Range(MinNumber, count);
            var massive = range.AsParallel().Select(num => new { Number = num, Root = Math.Sqrt(num) });

            foreach (var n in massive.OrderBy(num => num.Number))
                Console.WriteLine($"Значение = {n.Number}; Квадратный корень = {n.Root}");
        }
    }
}