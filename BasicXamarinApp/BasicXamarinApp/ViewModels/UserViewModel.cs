using BasicXamarinApp.Models;

namespace BasicXamarinApp.ViewModels
{
    public class UserViewModel : Tools
    {
        private UserListViewModel _userList;

        public User User { get; set; }

        public UserViewModel()
        {
            User = new User();
        }

        public UserListViewModel UserListViewModel
        {
            get { return _userList; }
            set
            {
                if (_userList != value)
                {
                    _userList = value;
                    OnPropertyChanged();
                }
            }
        }


        public string FirstName
        {
            get { return User.FirstName; }
            set
            {
                if (User.FirstName != value)
                {
                    User.FirstName = value;
                    OnPropertyChanged();
                }
            }
        }
        
        
        public string LastName
        {
            get { return User.LastName; }
            set
            {
                if (User.LastName != value)
                {
                    User.LastName = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            set
            {
                if (User.Password != value)
                {
                    User.Password = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Email
        {
            get { return User.Email; }
            set
            {
                if (User.Email != value)
                {
                    User.Email = value;
                    OnPropertyChanged();
                }
            }
        }
        
        public string PhoneNumber
        {
            get { return User.PhoneNumber; }
            set
            {
                if (User.PhoneNumber != value)
                {
                    User.PhoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        
    }
}