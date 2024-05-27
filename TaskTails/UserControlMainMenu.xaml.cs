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

namespace TaskTails
{
    /// <summary>
    /// Interaction logic for UserControlMainMenu.xaml
    /// </summary>
    public partial class UserControlMainMenu : UserControl
    {
        private Pet selectedPet;
        private TaskManager taskManager;

        public UserControlMainMenu(Pet selectedEgg)
        {
            InitializeComponent();
            selectedPet = selectedEgg;
            taskManager = new TaskManager();
        }

        // TODO -- hook into egg hatch status until hatched then change to pet
        // TODO -- hook into task object for user to create tasks
        // TODO -- hook into task object for user to update tasks
        // TODO -- hook into task object to track task points (might consider breaking this up) --> will need to trigger Hatch button visibility

        // load in image of pet based on saved data -- egg/pet stage 1/etc.
        private void PetImage_Loaded(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri(selectedPet.Image, UriKind.Absolute));

            PetImage.Fill = myBrush;
        }

        // populate the saved token count from save file
        private void TaskTokenCounter_Loaded(object sender, RoutedEventArgs e)
        {
            TaskTokenCounter.Content = taskManager.TaskTokenCount;
        }

        // interact with pet based on stage -- care interactivity or just animation
        private void PetImage_MouseClick(object sender, MouseButtonEventArgs e)
        {

        }

        // after Hatch button's visbility is enabled, allow user the ability to hatch pet for progression
        private void HatchButton_Click(object sender, RoutedEventArgs e)
        {
            // if visibile, update image and stats to new pet stage 

        }

        
    }
}
