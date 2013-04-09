using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringOperations
{
    public class StringStuff
    {
        //Comment
        public int StringNoSpaceCount(string stringToAnalyze_)
        {
            int counter = 0;
            foreach (char currentChar in stringToAnalyze_)
            {
                if (!currentChar.Equals(' '))
                    counter++;
            }

            return counter;
        }
    }
}
