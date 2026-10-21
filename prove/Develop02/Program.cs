using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();

        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                    myJournal.CreateEntry();
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("What would you like to name this journal?");
                    string saveFileName = Console.ReadLine();
                    string appendedName = myJournal.FileHelper(saveFileName);
                    myJournal.WriteToFile(appendedName);
                    break;
                case 4:
                    Console.Write("What's the Journal name?");
                    string loadFileName = Console.ReadLine();
                    string fixedFileName = myJournal.FileHelper(loadFileName);
                    myJournal.ReadFromFile(fixedFileName);
                    break;
            }

        }
            


    }
}