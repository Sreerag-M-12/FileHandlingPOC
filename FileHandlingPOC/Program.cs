namespace FileHandlingPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readTextFile = @"C:\Users\sreerag.babu\source\repos\FileHandlingPOC\Assets\ReadFile.txt";

            Console.WriteLine("Reading File using File.ReadAllText()");

            // To read the entire file at once 
            if (File.Exists(readTextFile))
            {
                string str = File.ReadAllText(readTextFile);
                Console.WriteLine(str);
            }
            Console.WriteLine();

            string writeTextFile = @"C:\Users\sreerag.babu\source\repos\FileHandlingPOC\Assets\WriteFile.txt";
            string text = "This is written on C#";
            File.WriteAllText(writeTextFile, text);

            string text2 = "This is text to be appended";
            File.AppendAllText(writeTextFile, text2);

            Console.WriteLine(File.ReadAllText(writeTextFile));


            //read write html file
            string writeHtmlFile = @"C:\Users\sreerag.babu\source\repos\FileHandlingPOC\Assets\writeName.html";
            using (StreamWriter sw = new StreamWriter(writeHtmlFile)) 
            {
                    string textHtml = "<html lang=\"en\">\r\n" +
                    "<head>\r\n   " +
                    " <title>WriteHtmlFile</title>\r\n" +
                    "</head>\r\n<body>\r\n   " +
                    " <h1>Hello World</h1>\r\n    " +
                    "<b>Bold heading</b>\r\n    " +
                    "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. " +
                    "Animi consectetur perferendis excepturi quos similique et libero " +
                    "consequatur consequuntur molestiae possimus tenetur, " +
                    "eum recusandae non! Quisquam, officiis. Ducimus asperiores quae sint.</p>\r\n" +
                    "</body>\r\n" +
                    "</html>";
                    sw.WriteLine(textHtml, true);
            }



            string readHtml = File.ReadAllText(writeHtmlFile);
            Console.WriteLine("HTML file has following content");
            Console.WriteLine(readHtml);


        }
    }
}
