using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class StringCheck
    {
        private string _wordToCount;
        private string _paragraphToScan;
        private string[] _arrayFromParagraph;
        private int _counter = 0;

        /**
         * Class constructor
         */
        public StringCheck()
        {

        }
        public StringCheck(string searchFor, string searchIn)
        {
            _wordToCount = searchFor;
            _paragraphToScan = searchIn;
        }

        public string GetWordToCount()
        {
            return _wordToCount;
        }
        public void SetWordToCount(string newWord)
        {
            _wordToCount = newWord;
        }
        public void SetParagraph(string stringIn)
        {
            _paragraphToScan = stringIn;
        }
        public string GetParaGraph()
        {
            return _paragraphToScan;
        }

        /**
         * This method takes in a string sentence/paragraph and splits it into a string array.
         */
        public string[] StringToArray()
        {
            this._arrayFromParagraph = this._paragraphToScan.Split(' ');
            return this._arrayFromParagraph;
        }

        /**
         * This method searches through a given string array and counts occurences of a specified string
         */
        public int GetResults()
        {
            int count = 0;
            for(int i=0; i < this._arrayFromParagraph.Length; i++)
            {
                if(this._arrayFromParagraph[i] == this._wordToCount)
                {
                    count += 1;
                }
                else
                {
                    count += 0;
                }
            }
            this._counter = count;
            return this._counter;
        }
    }

    /**
     * Main method
     * Searches for the number of times a word appears in a sentence or paragraph
     */
    // public class Program
    // {
    //     public static void Main()
    //     {
    //         int count = 0;
    //
    //         StringCheck stringCheckObject = new StringCheck("cat", "cat cat cat");
    //         stringCheckObject.StringToArray();
    //         count = stringCheckObject.ArrayLoopCounter();
    //         Console.WriteLine(count); //output: 3
    //
    //         StringCheck stringCheckObject2 = new StringCheck("cat", "cat dog cat");
    //         stringCheckObject2.StringToArray();
    //         count = stringCheckObject2.ArrayLoopCounter();
    //         Console.WriteLine(count); //output: 2
    //
    //         StringCheck stringCheckObject3 = new StringCheck("cat", "cat dog cat");
    //         stringCheckObject3.StringToArray();
    //         stringCheckObject3.SetWordToCount("taste");
    //         stringCheckObject3.SetParagraph("The cow is big, the cow taste great");
    //         count = stringCheckObject3.ArrayLoopCounter();
    //         Console.WriteLine(count); //output: 1
    //     }
    // }
}
