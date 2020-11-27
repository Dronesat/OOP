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
    /// Interaction logic for winPet.xaml
    /// </summary>
    public partial class winPet : Window
    {
        ClaPet currentPet;
        public winPet(ClaPet newPet)
        {
            InitializeComponent();

            currentPet = newPet;

            //update the visual display with the current pet detail
            lblOwner.Content = currentPet.strOwner;
            lblPetName.Content = currentPet.strPetName;
            lblBreed.Content = currentPet.strBreed;
            lblCategory.Content = currentPet.strCategory;
            lblDOB.Content = currentPet.datDOB.ToString("dddd, dd MMMM yyyy");

            //update the image
            string source = @"Pictures\" + currentPet.strBreed + @"\" + currentPet.strPetName + currentPet.strOwner + @".jfif";
            imgPicture.Source = new BitmapImage(new Uri(source, UriKind.Relative));

        }
    }
}
