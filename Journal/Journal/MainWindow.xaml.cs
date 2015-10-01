using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using MyJournal.Classes;
using System.Windows.Shapes;


namespace MyJournal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Journal currentJournal;

        public MainWindow()
        {
            InitializeComponent();

            currentJournal = new Journal("My Journal");

            dataGrid_JournalEntries.ItemsSource = currentJournal.Entries;
        }

        private void button_Publish_Click(object sender, RoutedEventArgs e)
        {
            string title = textBox_Title.Text;

            string entry = textBox_Entry.Text;

            DateTime currentDate = DateTime.Now;

            JournalEntry newEntry = new JournalEntry();

            newEntry.Id = currentJournal.Entries.Count + 1;

            newEntry.Title = title;

            newEntry.Entry = entry;

            newEntry.EntryDate = currentDate;

            currentJournal.Entries.Add(newEntry);



        }

        public void RefreshGrid()
        {
            dataGrid_JournalEntries.Items.Refresh();
        }
        private void dataGrid_JournalEntries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EditWindow windowEdit = new EditWindow { Owner = this };

            JournalEntry selectedEntry = (JournalEntry)dataGrid_JournalEntries.SelectedItem;

            windowEdit.LoadEntry(selectedEntry);

            windowEdit.Show();
        }

        private void textBox_Title_GotFocus(object sender, RoutedEventArgs e)
        {
            var tbox = sender as TextBox;
            tbox.Text = "";
        }

        private void textBox_Title_LostFocus(object sender, RoutedEventArgs e)
        {
            var tbox = sender as TextBox;
            if (tbox.Text == "")
            {
                tbox.Text = "Write Title Here";

            }
        }

        private void textBox_Entry_GotFocus(object sender, RoutedEventArgs e)
        {
            var tbox = sender as TextBox;
            tbox.Text = "";
        }

        private void textBox_Entry_LostFocus(object sender, RoutedEventArgs e)
        {
            var tbox = sender as TextBox;
            if (tbox.Text == "")
            {
                tbox.Text = "Write Entry Text Here";
            }
        }
    }

}


