using ConsoleTextToTxtFile;

Logger.WriteLine("Program beginning... @ " + DateTime.Now.ToString());
Logger.WriteLine("");
Thread.Sleep(3000);

string[] wordsToWrite = {"This", "is", "a", "test", "to", "see", "if", "this", "works" };
SpamToConsole.Main(wordsToWrite);

Thread.Sleep(3000);
Logger.WriteLine("");
Logger.WriteLine("Program completed... @ " + DateTime.Now.ToString());

// Now, create a seperate class that will write each line to a specified text file.
Logger.SaveLog();