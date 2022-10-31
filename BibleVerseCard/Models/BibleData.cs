using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleVerseCard.Models
{
    public class Bible
    {
        public BooksOTBible BookOTBible = new BooksOTBible
        {
            Books = new List<Book>
            {
                new Book
                {
                    Book_Id = 0,
                    BookName = "Genesis",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 67
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 46
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 55
                        },
                        new VersesByChapter
                        {
                            chapter = 32,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 33,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 34,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 35,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 36,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 37,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 38,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 39,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 40,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 41,
                            verseCount = 57
                        },
                        new VersesByChapter
                        {
                            chapter = 42,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 43,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 44,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 45,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 46,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 47,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 48,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 49,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 50,
                            verseCount = 26
                        },
                    }
                },

                new Book
                {
                    Book_Id = 1,
                    BookName = "Exodus",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 51
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 46
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 32,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 33,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 34,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 35,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 36,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 37,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 38,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 39,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 40,
                            verseCount = 38
                        },
                    }
                },

                new Book
                {
                    Book_Id = 2,
                    BookName = "Leviticus",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 47
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 59
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 57
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 44
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 55
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 46
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 34
                        },
                    }
                },

                new Book
                {
                    Book_Id = 3,
                    BookName = "Numbers",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 54
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 51
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 49
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 89
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 45
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 41
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 50
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 41
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 65
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 54
                        },
                        new VersesByChapter
                        {
                            chapter = 32,
                            verseCount = 42
                        },
                        new VersesByChapter
                        {
                            chapter = 33,
                            verseCount = 56
                        },
                        new VersesByChapter
                        {
                            chapter = 34,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 35,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 36,
                            verseCount = 13
                        },
                    }
                },

                new Book
                {
                    Book_Id = 4,
                    BookName = "Deuteronomy",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 46
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 49
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 68
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 32,
                            verseCount = 52
                        },
                        new VersesByChapter
                        {
                            chapter = 33,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 34,
                            verseCount = 12
                        },
                    }
                },

                new Book
                {
                    Book_Id = 5,
                    BookName = "Joshua",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 63
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 51
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 45
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 33
                        },
                    }
                },

                new Book
                {
                    Book_Id = 6,
                    BookName = "Judges",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 57
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 48
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 25
                        },
                    }
                },

                new Book
                {
                    Book_Id = 7,
                    BookName = "Ruth",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 22
                        },
                    }
                },

                new Book
                {
                    Book_Id = 8,
                    BookName = "1 Samuel",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 52
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 58
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 42
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 44
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 13
                        },
                    }
                },

                new Book
                {
                    Book_Id = 9,
                    BookName = "2 Samuel",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 39
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 39
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 51
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 39
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 25
                        },
                    }
                },

                new Book
                {
                    Book_Id = 10,
                    BookName = "1 Kings",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 53
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 46
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 51
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 66
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 46
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 53
                        },
                    }
                },

                new Book
                {
                    Book_Id = 11,
                    BookName = "2 Kings",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 44
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 41
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 30
                        },
                    }
                },

                new Book
                {
                    Book_Id = 12,
                    BookName = "1 Chronicles",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 54
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 55
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 81
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 44
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 47
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 30
                        },
                    }
                },

                new Book
                {
                    Book_Id = 13,
                    BookName = "2 Chronicles",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 42
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 32,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 33,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 34,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 35,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 36,
                            verseCount = 23
                        },
                    }
                },

                new Book
                {
                    Book_Id = 14,
                    BookName = "Ezra",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 70
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 44
                        },
                    }
                },

                new Book
                {
                    Book_Id = 15,
                    BookName = "Nehemiah",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 73
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 39
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 47
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 31
                        },
                    }
                },

                new Book
                {
                    Book_Id = 16,
                    BookName = "Esther",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 3
                        },
                    }
                },

                new Book
                {
                    Book_Id = 17,
                    BookName = "Job",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 6
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 32,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 33,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 34,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 35,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 36,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 37,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 38,
                            verseCount = 41
                        },
                        new VersesByChapter
                        {
                            chapter = 39,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 40,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 41,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 42,
                            verseCount = 17
                        },
                    }
                },

                new Book
                {
                    Book_Id = 18,
                    BookName = "Psalms",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 6
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 7
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 6
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 7
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 5
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 50
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 6
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 32,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 33,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 34,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 35,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 36,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 37,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 38,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 39,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 40,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 41,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 42,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 43,
                            verseCount = 5
                        },
                        new VersesByChapter
                        {
                            chapter = 44,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 45,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 46,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 47,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 48,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 49,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 50,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 51,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 52,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 53,
                            verseCount = 6
                        },
                        new VersesByChapter
                        {
                            chapter = 54,
                            verseCount = 7
                        },
                        new VersesByChapter
                        {
                            chapter = 55,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 56,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 57,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 58,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 59,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 60,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 61,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 62,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 63,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 64,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 65,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 66,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 67,
                            verseCount = 7
                        },
                        new VersesByChapter
                        {
                            chapter = 68,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 69,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 70,
                            verseCount = 5
                        },
                        new VersesByChapter
                        {
                            chapter = 71,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 72,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 73,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 74,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 75,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 76,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 77,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 78,
                            verseCount = 72
                        },
                        new VersesByChapter
                        {
                            chapter = 79,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 80,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 81,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 82,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 83,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 84,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 85,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 86,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 87,
                            verseCount = 7
                        },
                        new VersesByChapter
                        {
                            chapter = 88,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 89,
                            verseCount = 52
                        },
                        new VersesByChapter
                        {
                            chapter = 90,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 91,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 92,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 93,
                            verseCount = 5
                        },
                        new VersesByChapter
                        {
                            chapter = 94,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 95,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 96,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 97,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 98,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 99,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 100,
                            verseCount = 5
                        },
                        new VersesByChapter
                        {
                            chapter = 101,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 102,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 103,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 104,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 105,
                            verseCount = 45
                        },
                        new VersesByChapter
                        {
                            chapter = 106,
                            verseCount = 48
                        },
                        new VersesByChapter
                        {
                            chapter = 107,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 108,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 109,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 110,
                            verseCount = 7
                        },
                        new VersesByChapter
                        {
                            chapter = 111,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 112,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 113,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 114,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 115,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 116,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 117,
                            verseCount = 2
                        },
                        new VersesByChapter
                        {
                            chapter = 118,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 119,
                            verseCount = 176
                        },
                        new VersesByChapter
                        {
                            chapter = 120,
                            verseCount = 7
                        },
                        new VersesByChapter
                        {
                            chapter = 121,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 122,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 123,
                            verseCount = 4
                        },
                        new VersesByChapter
                        {
                            chapter = 124,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 125,
                            verseCount = 5
                        },
                        new VersesByChapter
                        {
                            chapter = 126,
                            verseCount = 6
                        },
                        new VersesByChapter
                        {
                            chapter = 127,
                            verseCount = 5
                        },
                        new VersesByChapter
                        {
                            chapter = 128,
                            verseCount = 6
                        },
                        new VersesByChapter
                        {
                            chapter = 129,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 130,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 131,
                            verseCount = 3
                        },
                        new VersesByChapter
                        {
                            chapter = 132,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 133,
                            verseCount = 3
                        },
                        new VersesByChapter
                        {
                            chapter = 134,
                            verseCount = 3
                        },
                        new VersesByChapter
                        {
                            chapter = 135,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 136,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 137,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 138,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 139,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 140,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 141,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 142,
                            verseCount = 7
                        },
                        new VersesByChapter
                        {
                            chapter = 143,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 144,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 145,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 146,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 147,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 148,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 149,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 150,
                            verseCount = 6
                        },
                    }
                },

                new Book
                {
                    Book_Id = 19,
                    BookName = "Proverbs",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 31
                        },
                    }
                },

                new Book
                {
                    Book_Id = 20,
                    BookName = "Ecclesiastes",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 14
                        },
                    }
                },

                new Book
                {
                    Book_Id = 21,
                    BookName = "Song of Solomon",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 14
                        },
                    }
                },

                new Book
                {
                    Book_Id = 22,
                    BookName = "Isaiah",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 6
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 6
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 7
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 6
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 32,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 33,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 34,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 35,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 36,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 37,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 38,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 39,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 40,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 41,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 42,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 43,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 44,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 45,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 46,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 47,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 48,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 49,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 50,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 51,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 52,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 53,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 54,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 55,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 56,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 57,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 58,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 59,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 60,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 61,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 62,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 63,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 64,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 65,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 66,
                            verseCount = 24
                        },
                    }
                },

                new Book
                {
                    Book_Id = 23,
                    BookName = "Jeremiah",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 32,
                            verseCount = 44
                        },
                        new VersesByChapter
                        {
                            chapter = 33,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 34,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 35,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 36,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 37,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 38,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 39,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 40,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 41,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 42,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 43,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 44,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 45,
                            verseCount = 5
                        },
                        new VersesByChapter
                        {
                            chapter = 46,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 47,
                            verseCount = 7
                        },
                        new VersesByChapter
                        {
                            chapter = 48,
                            verseCount = 47
                        },
                        new VersesByChapter
                        {
                            chapter = 49,
                            verseCount = 39
                        },
                        new VersesByChapter
                        {
                            chapter = 50,
                            verseCount = 46
                        },
                        new VersesByChapter
                        {
                            chapter = 51,
                            verseCount = 64
                        },
                        new VersesByChapter
                        {
                            chapter = 52,
                            verseCount = 34
                        },
                    }
                },

                new Book
                {
                    Book_Id = 24,
                    BookName = "Ezekiel",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 63
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 49
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 49
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 29,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 30,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 31,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 32,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 33,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 34,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 35,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 36,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 37,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 38,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 39,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 40,
                            verseCount = 49
                        },
                        new VersesByChapter
                        {
                            chapter = 41,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 42,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 43,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 44,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 45,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 46,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 47,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 48,
                            verseCount = 35
                        },
                    }
                },

                new Book
                {
                    Book_Id = 25,
                    BookName = "Daniel",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 49
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 45
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 13
                        },
                    }
                },

                new Book
                {
                    Book_Id = 26,
                    BookName = "Hosea",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 5
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 9
                        },
                    }
                },

                new Book
                {
                    Book_Id = 27,
                    BookName = "Joel",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 21
                        },
                    }
                },

                new Book
                {
                    Book_Id = 28,
                    BookName = "Amos",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 15
                        },
                    }
                },

                new Book
                {
                    Book_Id = 29,
                    BookName = "Obadiah",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 21
                        },
                    }
                },

                new Book
                {
                    Book_Id = 30,
                    BookName = "Jonah",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 11
                        },
                    }
                },

                new Book
                {
                    Book_Id = 31,
                    BookName = "Micah",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 20
                        },
                    }
                },

                new Book
                {
                    Book_Id = 32,
                    BookName = "Nahum",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 19
                        },
                    }
                },

                new Book
                {
                    Book_Id = 33,
                    BookName = "Habakkuk",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 19
                        },
                    }
                },

                new Book
                {
                    Book_Id = 34,
                    BookName = "Zephaniah",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 20
                        },
                    }
                },

                new Book
                {
                    Book_Id = 35,
                    BookName = "Haggai",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 23
                        },
                    }
                },

                new Book
                {
                    Book_Id = 36,
                    BookName = "Zechariah",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 9
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 21
                        },
                    }
                },

                new Book
                {
                    Book_Id = 37,
                    BookName = "Malachi",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 6
                        },
                    }
                },

                new Book
                {
                    Book_Id = 38,
                    BookName = "Matthew",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 48
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 42
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 50
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 58
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 39
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 46
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 46
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 39
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 51
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 46
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 75
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 66
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 20
                        },
                    }
                },

                new Book
                {
                    Book_Id = 39,
                    BookName = "Mark",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 45
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 41
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 56
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 50
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 52
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 44
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 72
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 47
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 20
                        },
                    }
                },

                new Book
                {
                    Book_Id = 40,
                    BookName = "Luke",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 80
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 52
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 44
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 39
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 49
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 50
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 56
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 62
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 42
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 54
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 59
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 48
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 47
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 71
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 56
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 53
                        },
                    }
                },

                new Book
                {
                    Book_Id = 41,
                    BookName = "John",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 51
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 54
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 47
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 71
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 53
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 59
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 41
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 42
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 57
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 50
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 42
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 25
                        },
                    }
                },

                new Book
                {
                    Book_Id = 42,
                    BookName = "Acts",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 47
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 37
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 42
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 60
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 43
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 48
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 52
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 41
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 41
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 38
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 23,
                            verseCount = 35
                        },
                        new VersesByChapter
                        {
                            chapter = 24,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 25,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 26,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 27,
                            verseCount = 44
                        },
                        new VersesByChapter
                        {
                            chapter = 28,
                            verseCount = 31
                        },
                    }
                },

                new Book
                {
                    Book_Id = 43,
                    BookName = "Romans",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 39
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 36
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 27
                        },
                    }
                },

                new Book
                {
                    Book_Id = 44,
                    BookName = "1 Corinthians",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 34
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 58
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 24
                        },
                    }
                },

                new Book
                {
                    Book_Id = 45,
                    BookName = "2 Corinthians",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 14
                        },
                    }
                },

                new Book
                {
                    Book_Id = 46,
                    BookName = "Galatians",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 31
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 18
                        },
                    }
                },

                new Book
                {
                    Book_Id = 47,
                    BookName = "Ephesians",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 32
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 33
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 24
                        },
                    }
                },

                new Book
                {
                    Book_Id = 48,
                    BookName = "Philippians",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 30
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 23
                        },
                    }
                },

                new Book
                {
                    Book_Id = 49,
                    BookName = "Colossians",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 23
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 18
                        },
                    }
                },

                new Book
                {
                    Book_Id = 50,
                    BookName = "1 Thessalonians",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 28
                        },
                    }
                },

                new Book
                {
                    Book_Id = 51,
                    BookName = "2 Thessalonians",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 12
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 18
                        },
                    }
                },

                new Book
                {
                    Book_Id = 52,
                    BookName = "1 Timothy",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 21
                        },
                    }
                },

                new Book
                {
                    Book_Id = 53,
                    BookName = "2 Timothy",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 22
                        },
                    }
                },

                new Book
                {
                    Book_Id = 54,
                    BookName = "Titus",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 15
                        },
                    }
                },

                new Book
                {
                    Book_Id = 55,
                    BookName = "Philemon",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 25
                        },
                    }
                },

                new Book
                {
                    Book_Id = 56,
                    BookName = "Hebrews",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 16
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 28
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 39
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 40
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 25
                        },
                    }
                },

                new Book
                {
                    Book_Id = 57,
                    BookName = "James",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 26
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 20
                        },
                    }
                },

                new Book
                {
                    Book_Id = 58,
                    BookName = "1 Peter",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 25
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 14
                        },
                    }
                },

                new Book
                {
                    Book_Id = 59,
                    BookName = "2 Peter",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 18
                        },
                    }
                },

                new Book
                {
                    Book_Id = 60,
                    BookName = "1 John",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 10
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 21
                        },
                    }
                },

                new Book
                {
                    Book_Id = 61,
                    BookName = "2 John",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 13
                        },
                    }
                },

                new Book
                {
                    Book_Id = 62,
                    BookName = "3 John",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 14
                        },
                    }
                },

                new Book
                {
                    Book_Id = 63,
                    BookName = "Jude",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 25
                        },
                    }
                },

                new Book
                {
                    Book_Id = 64,
                    BookName = "Revelation",
                    VersesByChapter = new List<VersesByChapter>
                    {
                        new VersesByChapter
                        {
                            chapter = 1,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 2,
                            verseCount = 29
                        },
                        new VersesByChapter
                        {
                            chapter = 3,
                            verseCount = 22
                        },
                        new VersesByChapter
                        {
                            chapter = 4,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 5,
                            verseCount = 14
                        },
                        new VersesByChapter
                        {
                            chapter = 6,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 7,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 8,
                            verseCount = 13
                        },
                        new VersesByChapter
                        {
                            chapter = 9,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 10,
                            verseCount = 11
                        },
                        new VersesByChapter
                        {
                            chapter = 11,
                            verseCount = 19
                        },
                        new VersesByChapter
                        {
                            chapter = 12,
                            verseCount = 17
                        },
                        new VersesByChapter
                        {
                            chapter = 13,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 14,
                            verseCount = 20
                        },
                        new VersesByChapter
                        {
                            chapter = 15,
                            verseCount = 8
                        },
                        new VersesByChapter
                        {
                            chapter = 16,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 17,
                            verseCount = 18
                        },
                        new VersesByChapter
                        {
                            chapter = 18,
                            verseCount = 24
                        },
                        new VersesByChapter
                        {
                            chapter = 19,
                            verseCount = 21
                        },
                        new VersesByChapter
                        {
                            chapter = 20,
                            verseCount = 15
                        },
                        new VersesByChapter
                        {
                            chapter = 21,
                            verseCount = 27
                        },
                        new VersesByChapter
                        {
                            chapter = 22,
                            verseCount = 21
                        },
                    }
                },

            }
        };
    }
}
