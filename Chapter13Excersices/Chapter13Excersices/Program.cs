using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;

namespace Chapter13Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            PringBetweenDates("3.03.2006", "3.03.2006");
        }

        static string RevurseString(string text)
        {
            StringBuilder revurse = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                revurse = revurse.Append(text[i]);
            }
            return revurse.ToString();
        }

        static void CheckBrakets(string text)
        {
            StringBuilder brakets = new StringBuilder();
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    count += 1;
                    brakets = brakets.Append(text[i] + " ");
                    continue;
                }
                if (text[i] == ')')
                {
                    count -= 1;
                    brakets = brakets.Append(text[i] + " ");
                    continue;
                }
                if (count < 0)
                {
                    Console.WriteLine($"Wrong braket at posision {text}[{i}]");
                    break;
                }
            }
            if (count != 0)
            {
                Console.WriteLine($"Wrong braket at posision");
                return;

            }
            Console.WriteLine(brakets);
            Console.WriteLine("Correct Positioning");

        }

        static void GetIndex(string text, string key)
        {
            StringBuilder indexes = new StringBuilder();
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                int index = text.IndexOf(key, i);
                if (index == -1)
                {
                    break;
                }
                indexes = indexes.Append(index + " ");
                i = index;
            }
            Console.WriteLine(indexes);
        }

        // crazy 
        static void UpperLetters(string text)
        {
            StringBuilder tagIndexes = new StringBuilder();
            string upcase = "<upcase>";
            string endCase = "</upcase>";
            for (int i = 0; i < text.Length; i++)
            {

                int index = text.IndexOf(upcase, i);
                if (index == -1)
                {
                    break;
                }
                tagIndexes = tagIndexes.Append(index + " ");
                i = index;
            }
            for (int i = 0; i < text.Length; i++)
            {
                int index = text.IndexOf(endCase, i);
                if (index == -1)
                {
                    break;
                }
                tagIndexes = tagIndexes.Append(index + " ");
                i = index;
            }
            string indexes = tagIndexes.ToString();
            string[] separators = { "", " " };
            string[] arrIndexes = indexes.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] intArrIndexes = new int[arrIndexes.Length];
            for (int i = 0; i < arrIndexes.Length; i++)
            {
                intArrIndexes[i] = int.Parse(arrIndexes[i]);
            }
            for (int i = 0; i < intArrIndexes.Length - 1; i++)
            {
                for (int j = i + 1; j < arrIndexes.Length; j++)
                {
                    if (intArrIndexes[j] < intArrIndexes[i])
                    {
                        int swap = intArrIndexes[i];
                        intArrIndexes[i] = intArrIndexes[j];
                        intArrIndexes[j] = swap;
                    }
                }
            }
            int[] indexesChange = new int[2];
            string newText = text;
            string old;
            for (int i = 0; i < intArrIndexes.Length - 1; i++)
            {
                string change = text.Substring(intArrIndexes[i], intArrIndexes[i + 1] - intArrIndexes[i] + 9);
                old = change;
                change = change.ToUpper();
                indexesChange[0] = change.IndexOf("<UPCASE>");
                indexesChange[1] = change.IndexOf("</UPCASE>");
                change = change.Substring(indexesChange[0] + 8);
                change = change.Substring(0, change.Length - 9); ;
                newText = newText.Replace(old, change);
                i++;
            }

            Console.WriteLine(newText);

        }

        static string ReturnTo20(string text)
        {
            if (text.Length > 21)
            {
                Console.WriteLine("String Over 20 Char!");
            }
            StringBuilder newText = new StringBuilder();
            for (int i = 0; i < 20; i++)
            {
                if (text.Length - 1 < i)
                {
                    newText = newText.Append("*");
                    continue;
                }
                newText = newText.Append(text[i]);

            }
            return newText.ToString();
        }

        static void PringUniCodes(string text)
        {
            string character = "";
            for (int i = 0; i < text.Length; i++)
            {
                character += String.Format("\\u{0:X} ", text[i]);
            }
            Console.WriteLine(character);
        }

        // GodLine
        static void PringSentancesWithWord(string text, string word)
        {
            int startIndex = 0;
            int endIndex = 0;
            string newText = "";
            bool contains = false;
            StringBuilder swapText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    endIndex = i;
                    // Sentance
                    for (int j = startIndex; j <= endIndex; j++)
                    {
                        swapText.Append(text[j]);
                    }
                    // 
                    string surched = "";
                    foreach (char part in swapText.ToString())
                    {
                        if (part != ' ')
                        {
                            surched += part;
                        }
                        else
                        {
                            if (surched == word)
                            {
                                contains = true;
                            }
                            surched = "";
                        }
                    }
                    if (endIndex == i && endIndex != 0)
                    {
                        startIndex = i + 1;
                    }

                    if (contains)
                    {
                        newText += swapText.ToString();
                        contains = false;
                    }
                    swapText = swapText.Clear();
                }

            }
            Console.WriteLine(newText);
        }

        static void PrintSentances(string text, string word)
        {
            var sentances = text.Split(new[] { ".", "!", "?" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var sentance in sentances)
            {
                var words = sentance.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (words.Contains(word))
                {
                    Console.WriteLine(sentance);
                }
            }
        }

        static void CensurateText(string text, string[] keyWords)
        {
            string newText = "";
            var sentances = text.Split(".", StringSplitOptions.RemoveEmptyEntries);
            foreach (var sentance in sentances)
            {
                var words = sentance.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = 0; j < keyWords.Length; j++)
                    {
                        if (words[i] == keyWords[j])
                        {
                            int index = words[i].Length;
                            words[i] = "";
                            for (int l = 0; l < index; l++)
                            {
                                words[i] += "*";
                            }
                        }
                    }
                    newText += words[i] + " ";
                    text += sentances;
                }
            }
            Console.WriteLine(newText);
        }

        static void PringPathComponents(string link)
        {
            string[] separators = { ":/", "/" };
            string[] parts = link.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string resources = "";
            int number = (parts.Length - 1);
            for (int i = 0; i < parts.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"[protocol] = \"{parts[i]}\"");
                        break;
                    case 1:
                        Console.WriteLine($"[server]=\"{parts[i]}\"");
                        break;
                    default:
                        break;
                }
                if (i != 0 && i != 1)
                {
                    resources += "/" + parts[i];
                }
                if (i == parts.Length - 1)
                {
                    Console.WriteLine($"[resource]=\"{resources}\"");
                }

            }

        }

        static void PrintWhatYodaWouldSay(string text)
        {
            string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string yodaText = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i] != "." || words[i] != "," || words[i] != "!" || words[i] != "?")
                {
                    yodaText += words[i] + " ";
                }
                else
                {
                    yodaText += words[i];
                }
            }
            Console.WriteLine(yodaText);
        }

        static void Dictionari(string[] difinitions)
        {
            bool loop = true;
            bool found;
            string[] words = new string[difinitions.Length];
            string[] keyWords = new string[difinitions.Length];
            for (int i = 0; i < difinitions.Length; i++)
            {
                words = difinitions[i].Split(" – ", StringSplitOptions.RemoveEmptyEntries);
                keyWords[i] = words[0];
            }
            while(loop == true)
            {
                found = false;
                string word = Console.ReadLine();
                if (word == "Exit")
                {
                    Console.WriteLine("You Exited the dictionary");
                    return;
                }
                for (int i = 0; i < difinitions.Length; i++)
                {
                    if (word == keyWords[i])
                    {
                        Console.WriteLine(difinitions[i]);
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("Unknown Word!");
                }
            }
            
        }

        static void PringBetweenDates(string dateOne, string dateTwo)
        {
            string[] dayMontYearOne = dateOne.Split(".", StringSplitOptions.RemoveEmptyEntries);
            string[] dayMontYearTwo = dateTwo.Split(".", StringSplitOptions.RemoveEmptyEntries);
            int[] dateOneInt = new int[dayMontYearOne.Length];
            int[] dateTwoInt = new int[dayMontYearTwo.Length];
            int distance = 0;
            string distanceText = "":

            for (int i = 0; i < dayMontYearOne.Length - 1; i++)
            {
                dateOneInt[i] = int.Parse(dayMontYearOne[i]);
            }
            for (int i = 0; i < dayMontYearTwo.Length - 1; i++)
            {
                dateTwoInt[i] = int.Parse(dayMontYearTwo[i]);
            }
            if (dateOneInt[0] > dateTwoInt[0])
            {
                if (dateOneInt[1] > dateTwoInt[1])
                {

                    if(dateOneInt[2] > dateTwoInt[2])
                    {

                    }
                }
            }
        }
    }
}
