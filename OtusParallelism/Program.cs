using System.Diagnostics;

class Program
{
    static async Task Main()
    {
        var stopwatch = new Stopwatch();

        //First step of home work
        string[] files = new[] { @"D:\Temp\OtusParallelism\1.txt", @"D:\Temp\OtusParallelism\2.txt", @"D:\Temp\OtusParallelism\3.txt" };
        Console.WriteLine("");
        Console.WriteLine("First step of home work");
        stopwatch.Start();
        await GetWhiteSpacesAmountFromFilesAsync(files);
        stopwatch.Stop();
        Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms");
        stopwatch.Reset();
        Console.WriteLine("");
        Console.WriteLine("");


        //Second step of home work
        string folderPath = @"D:\Temp\OtusParallelism";
        Console.WriteLine("");
        Console.WriteLine("Second step of home work");
        stopwatch.Start();
        await GetWhiteSpacesAmountFromDirectoryAsync(folderPath);
        stopwatch.Stop();
        Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms");
        stopwatch.Reset();
        Console.WriteLine("");
        Console.WriteLine("");



        static async Task GetWhiteSpacesAmountFromDirectoryAsync(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                var filePaths = Directory.GetFiles(folderPath);
                await GetWhiteSpacesAmountFromFilesAsync(filePaths);
            }
            else
            {
                Console.WriteLine($"Where is no folder with this path: {folderPath}");
            }
        }


        static async Task GetWhiteSpacesAmountFromFilesAsync(string[] filePaths)
        {
            var tasks = filePaths.Select(ReadFileAndCountWhiteSpaces);
            await Task.WhenAll(tasks);
        }


        static async Task ReadFileAndCountWhiteSpaces(string filePath)
        {
            try
            {
                string content = await ReadFileAsync(filePath);
                int countWhiteSpaces = CountWhiteSpaces(content);
                Console.WriteLine($"The file: {filePath} has white spaces amount: {countWhiteSpaces}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There is an error while reading {filePath}. \n{ex.Message}");
            }
        }


        static async Task<string> ReadFileAsync(string filePath)
        {
            string content = string.Empty;
            using (StreamReader reader = new(filePath))
            {
                content = await reader.ReadToEndAsync();
            }
            return content;
        }

        static int CountWhiteSpaces(string content)
        {
            int count = 0;
            foreach (char c in content)
            {
                if (char.IsWhiteSpace(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}





