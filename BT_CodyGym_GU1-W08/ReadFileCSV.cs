class ReadFileCSV
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter file to read: ");
        string nameFile = Console.ReadLine();
        System.Console.WriteLine("Input file is: " + nameFile);
        System.Console.WriteLine("Content inside file is: ");
        ReadFileCSV readFileCSV = new ReadFileCSV();
        readFileCSV.ReadFile(nameFile);
    }

    void ReadFile(string fileName)
    {
        try
        {
            FileInfo fileInfo = new FileInfo(fileName);
            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException();
            }

            StreamReader streamReader = new StreamReader(fileName);
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] splitText = line.Split(" ,");
                foreach (string a in splitText)
                {
                    System.Console.WriteLine(a);
                }
            }
            streamReader.Close();
            streamReader.Dispose();
        }
        catch (FileNotFoundException)
        {
            System.Console.Error.WriteLine("File can not be found");
        }
        catch (Exception)
        {
            System.Console.Error.WriteLine("Can not read this file");
        }
    }
}