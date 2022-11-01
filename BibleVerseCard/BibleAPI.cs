using System;
using System.Threading.Tasks;
using BibleVerseCard.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;

namespace BibleVerseCard
{
    public class BibleAPI
    {
        //public async Task<ResponseWithVerse> GetVerse()
        //{
        //    const int BooksInBible = 65; 
        //    ResponseWithVerse data = new ResponseWithVerse();
        //    Bible bible = new Bible();
        //    string translation = "?translation=kjv";
        //    string baseUrl = "https://bible-api.com/";
        //    try
        //    {
        //        //Get Book
        //        Random randomBook = new Random();
        //        int bookId = randomBook.Next(0,BooksInBible);
        //        Book book = bible.BookOTBible.Books.Where(x => x.Book_Id == bookId).FirstOrDefault();

        //        //Get Chapter
        //        Random randomChapter = new Random();
        //        int maxChapters = book.VersesByChapter.Count();
        //        int chapter = randomChapter.Next(1, maxChapters);

        //        //Get Verse
        //        Random randomVerse = new Random();
        //        int maxVerses = book.VersesByChapter[chapter].verseCount;
        //        int verse = randomVerse.Next(1, maxVerses);

        //        //Get Reference from API
        //        HttpClient httpClient = new HttpClient();
        //        string response = await httpClient.GetStringAsync(baseUrl + book.BookName + " " + chapter + ":" + verse + translation);
        //        data.Response = JsonConvert.DeserializeObject<APIResponse>(response);
        //        data.Verse = verse;
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //    return data;
        //}

        //static string EnumName<T>(T value)
        //{
        //    return Enum.GetName(typeof(T), value);
        //}
    }
}
