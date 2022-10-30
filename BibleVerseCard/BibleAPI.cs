using System;
using System.Threading.Tasks;
using BibleVerseCard.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using BibleVerseCard.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Automation.Peers;

namespace BibleVerseCard
{
    public class BibleAPI
    {
        public async Task<APIResponse> GetVerse()
        {
            APIResponse data = new APIResponse();
            Bible bible = new Bible();
            string translation = "?translation=kjv";
            string baseUrl = "https://bible-api.com/";
            try
            {
                //Get Book Name
                Random random = new Random();
                int bookId = random.Next(0,65);
                string book = Enum.GetName(typeof(Books), bookId);

                //Get Chapter
                Random random1 = new Random();
                int chapterId = random1.Next(0, 1);
                FieldInfo chapterName = bible.GetType().GetField(book);
                object value = chapterName.GetValue(bible);
                TEST theBible = (TEST)value;
                int counter = 0;


                //Get Verse
                Random random2 = new Random();
                int verseId = random2.Next(0, 1);
                string verse = "16";

                HttpClient httpClient = new HttpClient();
                string response = await httpClient.GetStringAsync(baseUrl + book +  verse + translation);
                data = JsonConvert.DeserializeObject<APIResponse>(response);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return data;
        }

        static string EnumName<T>(T value)
        {
            return Enum.GetName(typeof(T), value);
        }

        private object GetValueByPropertyName<T>(T obj, string propertyName)
        {
            PropertyInfo propInfo = typeof(T).GetProperty(propertyName);

            return propInfo.GetValue(obj);
        }
    }
}
