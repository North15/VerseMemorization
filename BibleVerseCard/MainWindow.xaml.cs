using BibleVerseCard.Models;
using BibleVerseCard;
using System.Windows;
using System.Threading.Tasks;
using System;

namespace BibleVerseCard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetVerseInWindowAsync();
        }

        private void btn_Check_Click(object sender, RoutedEventArgs e)
        {
            bool doMatch = CheckMatch();
            if (doMatch)
            {
                MessageBox.Show("Good Job! \n\n The verses matched. \n\n Goodbye.", "Success");
                System.Windows.Application.Current.Shutdown();
            }
            else
                MessageBox.Show("Oops! \n\n The verses don't match. \n\n Please try again.", "Failed");
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btn_New_Verse_Click(object sender, RoutedEventArgs e)
        {
            SetVerseInWindowAsync();
        }

        private bool CheckMatch()
        {
            bool match = false;

            int CompareBook = string.Compare(V_Book.Text, C_Book.Text.Trim(), comparisonType: StringComparison.OrdinalIgnoreCase);
            int CompareChapter = string.Compare(V_Chapter.Text, C_Chapter.Text.Trim(), comparisonType: StringComparison.OrdinalIgnoreCase);
            int CompareText = string.Compare(V_Text.Text, C_Text.Text.Trim(), comparisonType: StringComparison.OrdinalIgnoreCase);

            if (CompareBook == 0) 
                if(CompareChapter == 0) 
                    if(CompareText == 0)
                        match = true;
            else
                match = false;

            return match;
        }

        public async Task SetVerseInWindowAsync()
        {
            BibleAPI bibleAPI = new BibleAPI();
            Verses verse = new Verses();
            var newReference = await bibleAPI.GetVerse();
            foreach(var v in newReference.Verses) { verse = v; }
            if(newReference != null)
            {
                V_Book.Text = verse.Book_Name.Trim();
                V_Chapter.Text = verse.Chapter.Trim();
                V_Text.Text = verse.Text.Trim();
            }
            else
            {
                V_Book.Text = "Unknown";
                V_Chapter.Text = "Error";
                V_Text.Text = "This Didn't work!";
            }
        }
    }
}
