using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Assignment_UI.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {

        
        public StudentsViewModel StudentsViewModel { get; set; }

        public MainWindowViewModel()
        {
            StudentsViewModel = new StudentsViewModel();
       
        
            // set ImageList to a list of image paths
        
        }


    }
}
