/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 21/1/2020
 * Description : lab one wpf app code
 * 
 * ############################# */
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

namespace LabOne2020
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> bands = new List<Band>();
        public MainWindow()
        {
           

            InitializeComponent();
            Band band1 = new Band("Catfish and the bottlemen", 2007, "Johnny Bond, Bob Hall, Benji Blakeway, Van McCann");
            Band band2 = new Band("The 1975", 2002, "Matthew Healy, Adam Hann, Ross MacDonald, George Daniel");
            Band band3 = new Band("The Hunna", 2015, "Ryan Potter, Daniel Dorney, Junate Angin, Jack Metcalfe");
            Band band4 = new Band("The Neighbourhood", 2015, "Ryan Potter, Daniel Dorney, Junate Angin, Jack Metcalfe");
            Band band5 = new Band("Waterparks ", 2011, "Awsten Knight, Geoff Wigington, Otto Wood");
            Band band6 = new Band("State Champs ", 2010, "William Goodermote, Dave Fogarty, Matt Croteau");

            bands.Add(band1);
            bands.Add(band2);
            bands.Add(band3);
            bands.Add(band4);
            bands.Add(band5);
            bands.Add(band6);

            lbxBands.ItemsSource = bands;
        }

        private void LbxBands_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TbxFormed_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

//2.	Create a class called Band with Band Name, Year formed and Members.
//3.	Create 6 bands and display in the listbox
//4.	Implement IComparable to enable sorting by Band Name
//5.	Sort the bands
//6.	Make Band an abstract class
//7.	Create sub classes of Rock Band, Pop Band and Indie Band
//8.	Override the ToString() method to display the type of band in the listbox.
//9.	Create an album class, which should have Album Name, Released(a year), Sales.Use random for year of release and sales.
//10.	Clicking on a band name should display the Name, Year Formed and Members along with a list of the Albums
//11.	Add filtering to filter by Genre
//12.	Amend Released to a DateTime object and calculate years since release which should be displayed in the listbox.
//13.	Add functionality to write the band information to file.
