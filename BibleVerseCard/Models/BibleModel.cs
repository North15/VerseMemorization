﻿using System.Collections.Generic;

namespace BibleVerseCard.Models
{
    public class BooksOTBible
    {
        public List<Book> Books { get; set; }
    }
    public class Book
    {
        public int Book_Id { get; set; }
        public string BookName { get; set; }
        public List<VersesByChapter> VersesByChapter { get; set; }
    }

    public class VersesByChapter
    {
        public int chapter { get; set; }

        public int verseCount { get; set; }
    }
    public class Verses
    {
        public string Book_Id { get; set; }
        public string Book_Name { get; set; }
        public string Chapter { get; set; }
        public string Text { get; set; }
    }

}
