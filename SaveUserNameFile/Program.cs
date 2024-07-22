namespace SaveUserNameFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a username:");
            string username = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(username))
            {
                SaveUsername(username);
                Console.WriteLine($"Username '{username}' saved successfully.");
            }
            else
                Console.WriteLine("Username cannot be empty.");
        }


        static void SaveUsername(string username)
        {
            string path = @"C:\Users\sreerag.babu\source\repos\SaveUserNameFile\Views\Username.txt";

            string[] existingUsernames = File.ReadAllText(path).Split(',');

            using (StreamWriter sw = new StreamWriter(path))
            {
               
                foreach (string existingUsername in existingUsernames)
                {
                    if (!string.IsNullOrWhiteSpace(existingUsername))
                    {
                        sw.Write(existingUsername + ",");
                    }
                }

                // Write the new username at the end
                sw.Write(username + ",");
            }
        }
    }
}
