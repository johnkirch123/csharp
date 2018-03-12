using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is a fantastically long text and I am not really sure how I am going to shorten it";
            Console.WriteLine(StringUtility.SummarizeText(sentence));
        }

        
    }
}
