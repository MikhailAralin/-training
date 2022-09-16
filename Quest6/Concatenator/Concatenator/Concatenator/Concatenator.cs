using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenator
{
    public static class Concatenator
    {
        private static string _Path;
        private static string _File;

        public static async void Concat()
        {
            GetPath();

            Console.WriteLine("Введите название файла:");
            _File = $"{Console.ReadLine()}.txt";

            var files = Directory.GetFiles(_Path);

            foreach (var file in files)
            {
                await WriteAsync(Read(file));
            }

            Console.WriteLine("Выполнено");
        }

        private static void GetPath()
        {
            while (true)
            {
                Console.WriteLine("Введите путь к файлу:");
                _Path = Console.ReadLine();

                if (Directory.Exists(_Path)) break;
                else Console.WriteLine("Данный путь неверен");
            }
        }

        private static string Read(string path)
        {
            using (var streamReader = new StreamReader(path))
            {
                return streamReader.ReadToEnd();
            }
        }

        private static async Task WriteAsync(string str)
        {
            using (var streamWriter = new StreamWriter($@"{_Path}\{_File}", true))
            {
                await streamWriter.WriteLineAsync(str);
            }
        }
    }
}
