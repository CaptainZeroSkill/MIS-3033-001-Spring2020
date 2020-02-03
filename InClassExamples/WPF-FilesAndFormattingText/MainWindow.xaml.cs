using System;
using System.Collections.Generic;
//Need to use System.IO in order to reach the Files on the computer
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_FilesAndFormattingText
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPopulate_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            //Run is a statement that you want to all be together
            Run text = new Run();

            var book = File.ReadAllText("Pride and Prejudice by Jane Austen.txt");
            text.Text = book;
            text.Foreground = Brushes.White;
            text.Background = Brushes.Black;
            text.FontWeight = FontWeights.Bold;

            p.Inlines.Add(text);
            fd.Blocks.Add(p);
            rtbPride.Document = fd;
        }

        private void btnCSV_Click(object sender, RoutedEventArgs e)
        {

            //One way to read in a file path
            //string path = @"C:\Users\hens0006\Downloads\SalesJan2009.csv";
            //var lines = File.ReadAllLines(path);


            //This is the way/code that will be given on exam when needed to read in a file
            //Learning how to do the environment way is the easier way for exams
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads\SalesJan2009.csv"; //Uses the users username and goes to get it from the downloads folder 
            //string courseFile = $@"{path}\Course.csv";
            //string studentFile = $@"{path}\Student.csv";
            var lines = File.ReadAllLines(path);

            //In order to remove the heading from the file out of the program
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];

                //Could add a class that handles all of the different pieces from the file and adds them to the class to be used as properties
                var pieces = line.Split(',');

                lstbxCSV.Items.Add(pieces[4] + "\t" + pieces[5]);
            }

            /*foreach (var line in lines)
            {
                lstbxCSV.Items.Add(line);
            }*/
        }
    }
}
