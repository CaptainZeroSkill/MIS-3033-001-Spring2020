using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_RickAndMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //@ means treat all characters as literal

            string dataSetUrl = "https://rickandmortyapi.com/api/character/";


            //HTTP Client code will be given on the exams, but need to know how to activate the proper using fuction to use properly


            RickAndMortyAPI rickAndMortyStuff;
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(dataSetUrl);

                //.Result is waiting for the result to happen
                string json = client.GetStringAsync(dataSetUrl).Result;

                //Add using Newtonsoft.Json in order to access the JsonConvert function
                rickAndMortyStuff = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);



            }

            //Need a loop to iterate through all of the results collection
            foreach (var character in rickAndMortyStuff.results)
            {
                lstbxCharacters.Items.Add(character);
            }
        }

        private void lstbxCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Cast to treat as a ResultObject object
            var selectedCharacterFromList = (ResultObject)lstbxCharacters.SelectedItem;

            //JSON allows us to access someones' API without needing access to their database
            imgCharacter.Source = new BitmapImage(new Uri(selectedCharacterFromList.image));
        }
    }
}
