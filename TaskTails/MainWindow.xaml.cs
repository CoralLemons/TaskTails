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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string eggPath1;
        public string eggPath2;
        public string eggPath3;

        public MainWindow()
        {
            InitializeComponent();
        }

        private string generateRandomEgg() {
            // 14 total eggs
            Random random = new Random();
            int num = random.Next(0, 13);
            
            // return based on random number generated 
            switch (num)
            {
                case 0: return "";
                case 1: return "";
                case 2: return "";
                case 3: return "";
                case 4: return "";
                case 5: return "";
                case 6: return "";
                case 7: return "";
                case 8: return "";
                case 9: return "";
                case 10: return "";
                case 11: return "";
                case 12: return "";
                case 13: return "";
            }
        
        
        }




    }// end main window




}// end namespace
