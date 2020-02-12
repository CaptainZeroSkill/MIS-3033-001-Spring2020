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
using static JSON_Pokemon.PokemonAPI;

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtbxPokemonInfo.Clear();

            string dataSetURL = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=1000";

            PokemonAPI pokemonAPI;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(dataSetURL).Result;

                pokemonAPI = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }

            foreach (var name in pokemonAPI.results)
            {
                lstbxPokemon.Items.Add(name);
            }

        }

        private void btnMoreInfo_Click(object sender, RoutedEventArgs e)
        {
            var selectedCharacterFromList = (ResultObject)lstbxPokemon.SelectedItem;
            string pokemonURL = selectedCharacterFromList.url;
            PokemonAPI pokemonAPI;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(pokemonURL).Result;

                pokemonAPI = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }
        }
    }
}
