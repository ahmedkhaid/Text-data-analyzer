namespace Text_data_analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //creating text data analyzer
            //the user story first then the uml
            //stream reader
            //System.IO.StreamReader sr = new StreamReader(@"D:\fileInput.txt");//creating the object and give the file path
            //string line;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}
            //string[] a = File.ReadAllLines(@"D:\fileInput.txt");
            //foreach (string s in a) { 
            //    Console.WriteLine(s);
            //}
            //StreamWriter Writer = new StreamWriter(@"D:\fileInput.txt");
            //Writer.WriteLine("AHMED");
            //Writer.Close();
            //File.WriteAllText(@"D:\fileInput.txt", "AHMED KHALID");
            //File.AppendAllText(@"D:\fileInput.txt", "ahmed khalid with small characters");
            //if (File.Exists(@"D:\fileInput.txt")) {
            //    Console.WriteLine("the file exitst");
            //}
            //////////////////////////////////////////////
            //strat of the project
            Console.WriteLine("welcome to the text analyzer");
            Console.WriteLine("pleaze enter the folder path");
            string foulderInput=Console.ReadLine();
            DirectoryInfo dierectFiles = new DirectoryInfo(foulderInput);
           
            if (dierectFiles.Exists==false)
            {
                Console.WriteLine("folder not found");
                return;
            }
            //need to check if its exist first before accessing its folders or ot will cause errors
            var filles = dierectFiles.GetFiles();
            IfileAnalyzer ifileAnalyzer = null;
            foreach (var fille in filles)
            {
                
                if (fille.IsTextFille())
                {
                    ifileAnalyzer = new TxtFileAnalyzer();
                    ifileAnalyzer.AnalysisFile(fille);
                    var result = ((FileAnalyzer)ifileAnalyzer).getResult();
                    Console.WriteLine($"Name : {fille.Name}\n ");
                    Console.WriteLine($"Words : {result.WordCount}");
                    Console.WriteLine($"Lines : {result.LineCount}");
                    Console.WriteLine($"characters : {result.CaracterCount}");
                }
                else
                {
                    ifileAnalyzer = new CsvFileAnalyzer();
                    ifileAnalyzer.AnalysisFile(fille);
                    var result = ((FileAnalyzer)ifileAnalyzer).getResult();
                    Console.WriteLine($"Name : {fille.Name}\n ");
                    Console.WriteLine($"Column Number: {result.FieldCount}");
                }
              
            }
        }
    }
}
