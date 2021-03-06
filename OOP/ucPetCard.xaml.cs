﻿using System;
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

namespace OOP
{
    /// <summary>
    /// Interaction logic for ucPetCard.xaml
    /// </summary>
    public partial class ucPetCard : UserControl
    {
        public ClaPet currentPet;
        public ucPetCard(ClaPet newPet)
        {
            InitializeComponent();

            //save the pass data into the card 
            currentPet = newPet;

            //update the visual display on the card
            lblBreed.Content = currentPet.strBreed;
            lblOwner.Content = currentPet.strOwner;
            lblPetName.Content = currentPet.strPetName;

        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            //load the winPet window
            winPet w1 = new winPet(currentPet);
            w1.Show();
        }
    }
}
