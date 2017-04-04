/*! \file Lab2 */

using System;
using System.Text.RegularExpressions;

namespace CouldBuildNamespace {
    class CouldBuildClass {
        static string longWord = "привет";
        static string smallWord = "итев";

        /*!
         * \brief Check if the word smallWord could be composed
         *        from the letters of longWord string.
         * \param [in] longWord
         * \param [in] smallWord
         * \return True if longWord contains all the letters of smallWord
        */
        public static bool CouldBuild(string longWord, string smallWord) {
            int occur;

            if (smallWord.Length > longWord.Length) {
                return false;
            }
            longWord = longWord.ToLower();
            longWord = Regex.Replace(longWord, @"\s+", string.Empty);
            smallWord = smallWord.ToLower();
            smallWord = Regex.Replace(smallWord, @"\s+", string.Empty);
            foreach (char sym in smallWord) {
                if ((occur = longWord.IndexOf(sym)) < 0) {
                    return false;
                }
                longWord = longWord.Remove(occur, 1);
            }
            return true;
        }

        static void Main()
        {
            Console.WriteLine("Your longWord is {0}", longWord);
            Console.WriteLine("Your smallWord is {0}", smallWord);
            Console.WriteLine("Result {0}", CouldBuild(longWord, smallWord).ToString());
        }
    }
}
