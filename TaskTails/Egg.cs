using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTails
{
    public class Pet : INotifyPropertyChanged
    {
        private bool canEvolve;
        private int evolveThreshold;
        private int taskPoints;
        private string name;
        private string image;
        private static Random random = new Random();


        public event PropertyChangedEventHandler PropertyChanged;

        public Pet() {
            image = generateRandomEgg();
            canEvolve = false;
            evolveThreshold = 15;
            taskPoints = 0; // will need to get the Task object points when completed to update
            name = "";
        }

        public string Name {
            get { return name; } 
            set {  
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                NotifyPropertyChanged("Image");
            }
        }

        public int TaskPoints
        {
            get { return taskPoints; }
            set
            {
                taskPoints = value;
                NotifyPropertyChanged("TaskPoints");
            }
        }

        public int EvolveThreshold
        {
            get { return evolveThreshold; }
            set
            {
                evolveThreshold = value;
                NotifyPropertyChanged("EvolveThreshold");
            }
        }

        public bool CanEvolve
        {
            get { return canEvolve; }
            set
            {
                canEvolve = value;
                NotifyPropertyChanged("CanEnvolve");
            }
        }

        private string generateRandomEgg()
        {
            int num = random.Next(1, 14);
            int num1 = random.Next() % num * (random.Next(1, 3));
            // 7 total eggs & 1 default -- replace images with custom eggs!
            // return based on random number generated 
            switch (num1)
            {
                case 0: return @"pack://application:,,,/Eggs/monsterEggs01.png";
                case 1: return @"pack://application:,,,/Eggs/monsterEggs02.png";
                case 2: return @"pack://application:,,,/Eggs/monsterEggs03.png";
                case 3: return @"pack://application:,,,/Eggs/monsterEggs04.png";
                case 4: return @"pack://application:,,,/Eggs/monsterEggs05.png";
                case 5: return @"pack://application:,,,/Eggs/monsterEggs06.png";
                case 6: return @"pack://application:,,,/Eggs/monsterEggs07.png";
                default: return @"pack://application:,,,/Eggs/fieldEggs01.png";
            }
        }// end egg generator 

        private string generateRandomEgg(int num)
        {
            if (num == 0)
                num = random.Next();
            int num1 = random.Next() % num * (random.Next(1, 3));
            // 7 total eggs & 1 default -- replace images with custom eggs!
            // return based on random number generated 
            switch (num1)
            {
                case 0: return @"pack://application:,,,/Eggs/monsterEggs01.png";
                case 1: return @"pack://application:,,,/Eggs/monsterEggs02.png";
                case 2: return @"pack://application:,,,/Eggs/monsterEggs03.png";
                case 3: return @"pack://application:,,,/Eggs/monsterEggs04.png";
                case 4: return @"pack://application:,,,/Eggs/monsterEggs05.png";
                case 5: return @"pack://application:,,,/Eggs/monsterEggs06.png";
                case 6: return @"pack://application:,,,/Eggs/monsterEggs07.png";
                default: return @"pack://application:,,,/Eggs/fieldEggs01.png";
            }
        }// end egg generator

        // TODO -- add measures of priority to tasks, restrict to 2 of highest importance in an allotted time frame (24 hours?) to prevent spamming points
        public int completeTask() {
            return 3;
        }

        public bool checkHatchStatus() {
            if (taskPoints >= evolveThreshold)
                return true;
            else return false;
        }

        public string refresh() {
            int num = random.Next(1, 14);
            int num1 = random.Next() % num * (random.Next(1, 3));

            return generateRandomEgg(num1);
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }// end egg class
}// end namespace
