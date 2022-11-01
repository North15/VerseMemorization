using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleVerseCard
{
    public  class Randomizer
    {
        public int GetRandomIntBelowMax(int maxInt)
        {
            Random random = new Random();
            return random.Next(0,maxInt);
        }
    }
}
