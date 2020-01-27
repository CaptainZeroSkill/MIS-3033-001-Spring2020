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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Controls_DateTime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtbxFirstName.Text = String.Empty;
            txtbxLastName.Text = String.Empty;
            txtbxBirthdate.Text = String.Empty;

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            lstLetters.Items.Clear();
            string firstName, lastName, birthDate;
            firstName = txtbxFirstName.Text;
            lastName = txtbxLastName.Text;
            birthDate = txtbxBirthdate.Text;

            DateTime bday = DateTime.Now; //sets it to the current date and time at this exact moment of execution
            bday = Convert.ToDateTime(birthDate); //sets the DateTime variable to the value that the user passed in through the textbox

            string fullName = $"{firstName} {lastName}";

            foreach (var letter in fullName)
            {
                lstLetters.Items.Add(letter);
            }

            string message = $"{fullName} born on {bday.ToLongDateString()} \nThank you for submitting =)!";

            MessageBox.Show(message);
        }

        private void txtbxLastName_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Uh oh, you entered me =O");
        }
    }
}
