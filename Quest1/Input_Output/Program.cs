namespace Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите имя:");
            var name = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            var surname = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            var vr = string.Empty;
            bool ok;
            do
            {
                
                vr = Console.ReadLine();

                ok = int.TryParse(vr, out int age) && age >= 0 && age <= 150;

                if (!ok) Console.WriteLine("Пожалуйста, введите действительный возраст. Это должно быть число");
            }
            while (!ok);

            Console.WriteLine("Введите хобби:");
            var hobby = Console.ReadLine();

            Console.WriteLine($"{Environment.NewLine}Name: {name}");
            Console.WriteLine($"{Environment.NewLine}Surname: {surname}");
            Console.WriteLine($"{Environment.NewLine}Age: {vr}");
            Console.WriteLine($"{Environment.NewLine}Hobby: {hobby}");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}