using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BasicXamarinApp.ViewModels
{
    public class UserListViewModel : Tools
    {
        public ObservableCollection<UserViewModel> User { get; set; }
        
        public ICommand RegistrationCommand { get;  set; }
        
        public ICommand DeleteCommand { get; set; }
        
        public ICommand SaveIssueCommand { get; set; }
        
        public ICommand BackCommand { get; set; }

        private UserViewModel _selectedUser;
        
        public INavigation Navigation { get; set; }

        public UserListViewModel()
        {
            User = new ObservableCollection<UserViewModel>();
        }

    }