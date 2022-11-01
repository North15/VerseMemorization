using BibleVerseCard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleVerseCard.Services
{
    public class BibleServices
    {
        public Book GetBook()
        {
            Book book = new Book();

            return book;
        }

        public Chapter GetChapter()
        {
            Chapter chapter = new Chapter();

            return chapter;
        }

        public Verse GetVerse()
        {
            Verse verse = new Verse();

            return verse;
        }


    }
}
