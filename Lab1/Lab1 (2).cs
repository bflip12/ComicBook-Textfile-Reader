//I, Bobby Filippopoulos, student number 000338236, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.
// The programs purpose is to be able to read a text file that contains a list of comicbook, each comicbook contains details
// the program will be to display the list of comicbook in a sorted format that is decided by the user
// Date created: 1/22/2017
// Last Date Modified: 2/3/2017
//
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    ///  Function calls resides in main method, reading, sorting and output format are all contained within the lab1 class 
    ///  reading, sorting and output makes use of the ComicBook class which contain the format for a comicbook object
    /// </summary>
    class Lab1
    {
        /// <summary>
        /// Most functionality resides in this class, reading, sorting and output format are all contained within methods and called in the main class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            ComicBook[] comicBookCollection;
            int num;
            Lab1.Read(out comicBookCollection,out num);
            bool moreFunctions = true;

            while (moreFunctions) //If the user enters '7' the flag will be set to false and the program will quit.
            {
                
                string choice = menu(); //set sort selection to the return string from menu, request input and display menu
                int choiceParsed;
                if (Int32.TryParse(choice, out choiceParsed)) //convert the string to an integer, check for appropriate input
                {
                    switch (choiceParsed)
                    {
                        case 1:
                            selectionSort(comicBookCollection, num, choiceParsed);
                            break;
                        case 2:
                            selectionSort(comicBookCollection, num, choiceParsed);
                            break;
                        case 3:
                            selectionSort(comicBookCollection, num, choiceParsed);
                            break;
                        case 4:
                            selectionSort(comicBookCollection, num, choiceParsed);
                            break;
                        case 5:
                            selectionSort(comicBookCollection, num, choiceParsed);
                            break;
                        case 6:
                            selectionSort(comicBookCollection, num, choiceParsed);
                            break;
                        case 7:
                            moreFunctions = false;
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("Invalid choice, please try again.");
                            Console.WriteLine("");
                            break;
                    }
                    if (choiceParsed >= 1 && choiceParsed <= 6)
                    {
                        Console.Clear();
                        DisplayComicTable(comicBookCollection, num);
                        
                    }
                }
                
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid choice, please try again.");
                    Console.WriteLine("");
                }
            }
            
        }

        /// <summary>
        /// This method prompts the user to choose which parameter to sort by
        /// </summary>
        /// <returns>returns the users choice bound within 1-7</returns>
        private static string menu()
        {
            Console.WriteLine("1. Sort by Publisher Name");
            Console.WriteLine("2. Sort by Comic Title");
            Console.WriteLine("3. Sort by Issue Number");
            Console.WriteLine("4. Sort by Cover Date");
            Console.WriteLine("5. Sort by Cover Value");
            Console.WriteLine("6. Sort by Market Value");
            Console.WriteLine();
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// This sorting method is a selection sort. With an average case of O(n2) it is suitable for this data set.
        /// This sort will move through the array setting the minimum value to most left index. After each round
        /// The pointer will move to the right by one index and move through the array finding the minimum value.
        /// This will repeat until the end of the array.
        /// </summary>
        /// <param name="comicBookCollection">object array to sort</param>
        /// <param name="size">size of the array</param>
        /// <param name="choice">gathered from the call to menu, decides which parameter to sort by</param>
        private static void selectionSort(ComicBook[] comicBookCollection, int size, int choice)
        {
            int startScan;
            int index;
            int minIndex;
            ComicBook minValue; //create object that will contain the temporary information awaiting switches

            for (startScan = 0; startScan < size; startScan++)
            {
                minIndex = startScan;
                minValue = comicBookCollection[startScan];

                for (index = startScan + 1; index < size; index++)
                {
                    switch (choice)
                    {
                        case 1:
                            //implement case structure to dictate the pull from object e.g getissue
                            if (minValue.GetPublisher().CompareTo(comicBookCollection[index].GetPublisher()) > 0)
                            {
                                minValue = comicBookCollection[index];
                                minIndex = index;
                            }
                            break;
                        case 2:
                            if (minValue.GetTitle().CompareTo(comicBookCollection[index].GetTitle()) > 0)
                            {
                                minValue = comicBookCollection[index];
                                minIndex = index;
                            }
                            break;
                        case 3:
                            if (comicBookCollection[index].GetIssue() < minValue.GetIssue())
                            {
                                minValue = comicBookCollection[index];
                                minIndex = index;
                            }
                            break;
                        case 4:
                            
                            if (DateTime.Parse(minValue.GetDate()) > (DateTime.Parse(comicBookCollection[index].GetDate())))
                            {
                                minValue = comicBookCollection[index];
                                minIndex = index;
                            }
                            break;
                        case 5:
                            if (comicBookCollection[index].GetBookValue() > minValue.GetBookValue())
                            {
                                minValue = comicBookCollection[index];
                                minIndex = index;
                            }
                            break;
                        case 6:
                            if (comicBookCollection[index].GetMarketValue() > minValue.GetMarketValue())
                            {
                                minValue = comicBookCollection[index];
                                minIndex = index;
                            }
                            break;
                    }
                }
                comicBookCollection[minIndex] = comicBookCollection[startScan];
                comicBookCollection[startScan] = minValue;
            }
            
        }

        /// <summary>
        /// this read method goes through the text file line by line, over writing an array with each line
        /// after the array is set, a new comic will be created with the contents of the array
        /// </summary>
        /// <param name="comicBookCollection">sets the objects data</param>
        /// <param name="num">sets the size of the array, needed to display and sort</param>
        private static void Read(out ComicBook[] comicBookCollection, out int num)
        {
            num = 0;
            comicBookCollection = new ComicBook[100];
            try
            {
                string filename = "comics.txt";
                string fullFileName = Path.Combine(Directory.GetCurrentDirectory(), filename); //this creates the absolute path of the file
                FileStream file = new FileStream(fullFileName, FileMode.Open);
                StreamReader data = new StreamReader(file);

                string comicLine;
                while ((comicLine = data.ReadLine()) != null) //read until the end of file
                {
                    string[] comicLineSplit = comicLine.Split(',');
                    comicBookCollection[num] = new ComicBook(comicLineSplit[0].Trim(), comicLineSplit[1].Trim(), Convert.ToInt32(comicLineSplit[2]), comicLineSplit[3].Trim(), Convert.ToDecimal(comicLineSplit[4]), Convert.ToDecimal(comicLineSplit[5]));
                    
                    num++;
                }
                data.Close();
                file.Close();
            }
            catch
            {
                Console.WriteLine("error");
            }
        }

        /// <summary>
        /// This method outputs the content of the comicBookCollect
        /// </summary>
        /// <param name="comicBookCollection">the comicbook array to display</param>
        /// <param name="num">the amount of comics that will be displayed</param>
        private static void DisplayComicTable(ComicBook[] comicBookCollection,int num)
        {
            Console.WriteLine("{0,-10}  {1,-25}  {2,-5}  {3,-15}  {4,-10}  {5,-10}", "Publisher", "Title", "Issue", "Date", "Book Value", "Market Value");
            Console.WriteLine("{0,-10}  {1,-25}  {2,-5}  {3,-15}  {4,-10}  {5,-10}", "==========", "======================", "=====", "========", "==========", "============");
            for (int i = 0; i < num; i++)
            {
                comicBookCollection[i].displayComic();
            }
            Console.WriteLine("");
        }
    }
}