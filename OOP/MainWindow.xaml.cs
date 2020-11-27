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

namespace OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Read from the test file
            string[] arrLines = System.IO.File.ReadAllLines(@"Users.txt");

            //Split each line and create a person object
            foreach (string line in arrLines)
            {
                //Spit the line ito an array of parts
                string[] arrParts = line.Split(',');

                //save the parts into new object
                ClaPerson newPerson = new ClaPerson();

                //call upon the create 
                newPerson.createUser(arrParts[0], arrParts[1], arrParts[2]);

                //set the password
                newPerson.setPassword(arrParts[4]);

                //save into the datastore of people
                claDataStore.lstPeople.Add(newPerson);
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            winCreate w1 = new winCreate();
            w1.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //Check the credentials are correct
            //If true, load new windows
            //If false, give error message

            Boolean booLogin = false;

            foreach(ClaPerson temp in claDataStore.lstPeople)
            {
                if (temp.checkLogin(txtUsername.Text, pasPassword.Password))
                {
                    booLogin = true;
                    break;
                }
            }

            if (booLogin)
            {
                //Load new Window
                winLoggedIn w1 = new winLoggedIn();
                w1.Show();
            }
            else
                MessageBox.Show("No mathching user found");
            

        }

    }
}
