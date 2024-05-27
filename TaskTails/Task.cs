using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTails
{
    public class Task : INotifyPropertyChanged
    {
        private int taskCount; // will probably pull out and move to a manager object
        private string taskType; // look into this as development progresses

        private int taskPoints;
        private string taskName;
        private string taskDescription;
        private int taskPriority;
        private bool isCompleted;
        

        public Task(string name, string description, int priority) 
        { 
            taskName = name;
            taskDescription = description;
            taskPriority = priority;
            isCompleted = false;
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

        



        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }// end Task class
}// end namespace
