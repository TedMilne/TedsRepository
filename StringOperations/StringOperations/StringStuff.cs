using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringOperations
{
    public class StringStuff
    {
        //addition of pointless comment so I can commit, push
        //and test my build server
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
