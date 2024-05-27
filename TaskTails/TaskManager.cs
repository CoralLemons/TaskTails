using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTails
{
    public class TaskManager : INotifyPropertyChanged
    {
        private int taskTokens;

        public event PropertyChangedEventHandler PropertyChanged;

        // TODO -- implement Task Manager to keep track of new tasks then delete them once marked finished
        public TaskManager() 
        {
            this.taskTokens = 0; // placeholder 
            

        }

        // when isComplete triggers, update token count based off priority of task (create sliding scale at some point)
        public int TaskTokenCount
        {
            get { return taskTokens; }
            set
            {
                taskTokens = value;
                
                NotifyPropertyChanged("TaskTokenCount");
            }
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }// end class TaskManager
}// end namespace
