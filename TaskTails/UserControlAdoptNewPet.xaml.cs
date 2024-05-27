using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TaskTails
{
    /// <summary>
    /// Interaction logic for UserControlAdoptNewPet.xaml
    /// </summary>
    public partial class UserControlAdoptNewPet : UserControl
    {
        public UserControlAdoptNewPet()
        {
            InitializeComponent();
            initializeEggs();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private Pet EggThree;
        private Pet EggTwo;
        private Pet EggOne;
        private Pet SelectedEgg;

        private void initializeEggs()
        {
            EggOne = new Pet();
            EggTwo = new Pet();
            EggThree = new Pet();
        }

        private void EggOne_Loaded(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri(EggOne.Image, UriKind.Absolute));

            FirstEgg.Fill = myBrush;
        }

        private void EggTwo_Loaded(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri(EggTwo.Image, UriKind.Absolute));

            SecondEgg.Fill = myBrush;
        }

        private void EggThree_Loaded(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri(EggThree.Image, UriKind.Absolute));

            ThirdEgg.Fill = myBrush;
        }

        private void EggOne_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            EggOneSelected.Stroke = new SolidColorBrush(Colors.DarkOrchid);
            if (EggOneSelected.Visibility == Visibility.Hidden && EggThreeSelected.Visibility == Visibility.Hidden && EggTwoSelected.Visibility == Visibility.Hidden)
            {
                EggOneSelected.Visibility = Visibility.Visible;
                Adopt.IsEnabled = true;
                SelectedEgg = EggOne;
            }
            else
            {
                EggOneSelected.Visibility = Visibility.Hidden;
                Adopt.IsEnabled = false;
            }
        }

        private void EggTwo_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            EggTwoSelected.Stroke = new SolidColorBrush(Colors.DarkOrchid);
            if (EggOneSelected.Visibility == Visibility.Hidden && EggThreeSelected.Visibility == Visibility.Hidden && EggTwoSelected.Visibility == Visibility.Hidden)
            {
                EggTwoSelected.Visibility = Visibility.Visible;
                Adopt.IsEnabled = true;
                SelectedEgg = EggTwo;
            }
            else
            {
                EggTwoSelected.Visibility = Visibility.Hidden;
                Adopt.IsEnabled = false;
            }
        }

        private void EggThree_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            EggThreeSelected.Stroke = new SolidColorBrush(Colors.DarkOrchid);
            if (EggOneSelected.Visibility == Visibility.Hidden && EggThreeSelected.Visibility == Visibility.Hidden && EggTwoSelected.Visibility == Visibility.Hidden)
            {
                EggThreeSelected.Visibility = Visibility.Visible;
                Adopt.IsEnabled = true;
                SelectedEgg = EggThree;
            }
            else
            {
                EggThreeSelected.Visibility = Visibility.Hidden;
                Adopt.IsEnabled = false;
            }
        }

        private void Adopt_Click(object sender, RoutedEventArgs e)
        {
            if (Adopt.IsEnabled == true)
            {
                Window window = Window.GetWindow(this);
                window.Content = new UserControlMainMenu(SelectedEgg);
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            string E1RF = EggOne.refresh();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri(E1RF, UriKind.Absolute));
            FirstEgg.Fill = myBrush;
            EggOne.Image = E1RF;

            string E2RF = EggTwo.refresh();
            ImageBrush second = new ImageBrush();
            second.ImageSource =
                new BitmapImage(new Uri(E2RF, UriKind.Absolute));
            SecondEgg.Fill = second;
            EggTwo.Image = E2RF;

            string E3RF = EggThree.refresh();
            ImageBrush third = new ImageBrush();
            third.ImageSource =
                new BitmapImage(new Uri(E3RF, UriKind.Absolute));
            ThirdEgg.Fill = third;
            EggThree.Image = E3RF;
        }
    }
}
