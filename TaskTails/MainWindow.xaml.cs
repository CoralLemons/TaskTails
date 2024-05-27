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
        public MainWindow()
        {
            InitializeComponent();
        }

        // TODO -- implement start up file explorer or "Most Recent" save file for quick resume
        // TODO -- create a simple save file then flush out for pet and item data

        private void LoadRecent_Click(object sender, RoutedEventArgs e)
        {
            // placeholder to test window transitions
            Window window = Window.GetWindow(this);
            window.Content = new UserControlAdoptNewPet();
        }

        private void LoadSelected_Click(object sender, RoutedEventArgs e)
        {

        }

        // automatically save file before close
        private void Window_Closing(object sender, CancelEventArgs e)
        {

        }

    }// end main window partial class
}// end namespace
