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
using System.Windows.Shapes;

namespace OOP
{
    /// <summary>
    /// Interaction logic for winLoggedIn.xaml
    /// </summary>
    public partial class winLoggedIn : Window
    {
        public winLoggedIn()
        {
            InitializeComponent();

            //create a hashset for the breeds
            HashSet<string> hshBreeds = new HashSet<string>();

            //Read from the pets txt file
            string[] arrLines = System.IO.File.ReadAllLines(@"Pets.txt");

            //Split each line part 
            foreach (string line in arrLines)
            {
                //create parts array
                string[] arrParts = line.Split(',');

                //create
                ClaPet newPet = new ClaPet();

                newPet.strOwner = arrParts[0];
                newPet.strPetName = arrParts[1];
                newPet.strBreed = arrParts[2];
                newPet.strCategory = arrParts[3];
                newPet.datDOB = Convert.ToDateTime(arrParts[4]);

                //add the breed to the hashset
                hshBreeds.Add(newPet.strBreed);

                //create the user control
                ucPetCard newCard = new ucPetCard(newPet);

                //add to list of pets
                claDataStore.lstPets.Add(newCard);
            }

            foreach (string Breed in hshBreeds)
                lsbBreeds.Items.Add(Breed);
        }

        private void btnAllPets_Click(object sender, RoutedEventArgs e)
        {
            //clear the wrap panel
            wraPets.Children.Clear();

            //for each pet create and display a user control in the wrap panel
            foreach(ucPetCard currentPet in claDataStore.lstPets)
            {
                //add new card to wrap panel
                wraPets.Children.Add(currentPet);
            }
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            //clear the wrap panel
            wraPets.Children.Clear();

            //for each pet create and display a user control in the wrap panel
            foreach (ucPetCard currentCard in claDataStore.lstPets)
            {
                //test the breed mathches
                if (currentCard.currentPet.strBreed == lsbBreeds.SelectedItem.ToString())
                {   
                    //add new card to wrap panel
                    wraPets.Children.Add(currentCard);
                }
            }
        }
    }
}