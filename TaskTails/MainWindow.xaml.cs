using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TaskTails
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Pet EggThree;
        public Pet EggTwo;
        public Pet EggOne;

        public MainWindow()
        {
            InitializeComponent();
            initializeEggs();
        }

        private void initializeEggs() {
            EggOne = new Pet();
            EggTwo = new Pet();
            EggThree = new Pet();
        }

        public string GetEggOne { get { return EggOne.Image; } }
        public string GetEggTwo { get { return EggTwo.Image; } }
        public string GetEggThree { get { return EggThree.Image; } }

        private void EggOne_Loaded(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri(GetEggOne, UriKind.Relative));

            FirstEgg.Fill = myBrush;
        }

        private void EggTwo_Loaded(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri(GetEggTwo, UriKind.Relative));

            SecondEgg.Fill = myBrush;
        }

        private void EggThree_Loaded(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri(GetEggThree, UriKind.Relative));

            ThirdEgg.Fill = myBrush;
        }

        private void EggOne_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            EggOneSelected.Stroke = new SolidColorBrush(Colors.DarkOrchid);
            if (EggOneSelected.Visibility == Visibility.Hidden && EggThreeSelected.Visibility == Visibility.Hidden && EggTwoSelected.Visibility == Visibility.Hidden)
            {
                EggOneSelected.Visibility = Visibility.Visible;
                Adopt.IsEnabled = true;
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
            }
            else
            {
                EggThreeSelected.Visibility = Visibility.Hidden;
                Adopt.IsEnabled = false;
            }
        }

        private void Adopt_Click(object sender, RoutedEventArgs e)
        {
            if (Adopt.IsEnabled == true) {
                Window window = Window.GetWindow(this);
                window.Content = new UserControlMainMenu();
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri(EggOne.refresh(), UriKind.Relative));
            FirstEgg.Fill = myBrush;

            ImageBrush second = new ImageBrush();
            second.ImageSource =
                new BitmapImage(new Uri(EggTwo.refresh(), UriKind.Relative));
            SecondEgg.Fill = second;

            ImageBrush third = new ImageBrush();
            third.ImageSource =
                new BitmapImage(new Uri(EggThree.refresh(), UriKind.Relative));
            ThirdEgg.Fill = third;
        }
    }// end main window partial class
}// end namespace
