Описание/Пошаговая инструкция выполнения домашнего задания:

    1. Прочитать 3 файла параллельно и вычислить количество пробелов в них (через Task).
            Program.cs -> static async Task GetWhiteSpacesAmountFromFilesAsync(string[] filePaths)
    2. Написать функцию, принимающую в качестве аргумента путь к папке. Из этой папки параллельно прочитать все файлы и вычислить количество пробелов в них.
            Program.cs -> static async Task GetWhiteSpacesAmountFromDirectoryAsync(string folderPath)
    3. Замерьте время выполнения кода (класс Stopwatch).
            Program.cs ->       var stopwatch = new Stopwatch();
                                ...
                                Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms");
                                ...