��������/��������� ���������� ���������� ��������� �������:

    1. ��������� 3 ����� ����������� � ��������� ���������� �������� � ��� (����� Task).
            Program.cs -> static async Task GetWhiteSpacesAmountFromFilesAsync(string[] filePaths)
    2. �������� �������, ����������� � �������� ��������� ���� � �����. �� ���� ����� ����������� ��������� ��� ����� � ��������� ���������� �������� � ���.
            Program.cs -> static async Task GetWhiteSpacesAmountFromDirectoryAsync(string folderPath)
    3. �������� ����� ���������� ���� (����� Stopwatch).
            Program.cs ->       var stopwatch = new Stopwatch();
                                ...
                                Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms");
                                ...