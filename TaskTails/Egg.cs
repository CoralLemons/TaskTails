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
            // 14 total eggs & 1 default
            // return based on random number generated 
            switch (num1)
            {
                case 0: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs01.png";
                case 1: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs02.png";
                case 2: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs03.png";
                case 3: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs04.png";
                case 4: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs05.png";
                case 5: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs06.png";
                case 6: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs07.png";
                case 7: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs08.png";
                case 8: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs11.png";
                case 9: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs12.png";
                case 10: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs14.png";
                case 11: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs15.png";
                case 12: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs16.png";
                case 13: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs18.png";
                default: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\fieldEggs01.png";
            }
        }// end egg generator 

        private string generateRandomEgg(int num)
        {
            if (num == 0)
                num = random.Next();
            int num1 = random.Next() % num * (random.Next(1, 3));
            // 14 total eggs & 1 default
            // return based on random number generated 
            switch (num1)
            {
                case 0: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs01.png";
                case 1: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs02.png";
                case 2: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs03.png";
                case 3: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs04.png";
                case 4: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs05.png";
                case 5: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs06.png";
                case 6: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs07.png";
                case 7: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs08.png";
                case 8: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs11.png";
                case 9: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs12.png";
                case 10: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs14.png";
                case 11: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs15.png";
                case 12: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs16.png";
                case 13: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\monsterEggs18.png";
                case 14: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-1.png";
                case 16: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-2.png";
                case 17: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-3.png";
                case 15: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-4.png";
                case 18: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-5.png";
                case 19: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-6.png";
                case 20: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-7.png";
                case 21: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-8.png";
                case 22: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-9.png";
                case 23: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-10.png";
                case 24: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-11.png";
                case 25: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-12.png";
                case 26: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-13.png";
                case 27: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-14.png";
                case 28: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-15.png";
                case 29: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\egg-16.png";
                default: return @"C:\Users\gothi\OneDrive\Desktop\Repos\TaskTails\TaskTails\Eggs\fieldEggs01.png";
            }
        }// end egg generator


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
