using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for winCreate.xaml
    /// </summary>
    public partial class winCreate : Window
    {
        public winCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            //instantiate a new person 
            ClaPerson newPerson = new ClaPerson();

            //Create person using base values
            newPerson.createUser(txtENumber.Text, txtFName.Text, txtSName.Text);

            //Add person to datastore   
            claDataStore.lstPeople.Add(newPerson);

            //Save to txt file
            System.IO.File.AppendAllText(@"Users.txt", Environment.NewLine + newPerson.saveString());

            //Close the window
            Close();
        }
    }
}
