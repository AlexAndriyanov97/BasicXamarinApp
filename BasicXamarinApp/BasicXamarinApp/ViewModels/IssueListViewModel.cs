using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using App1.Views;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class IssueListViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<IssueViewModel> Issues { get; set; }
 
        public event PropertyChangedEventHandler PropertyChanged;
 
        public ICommand CreateIssueCommand { protected set; get; }
        public ICommand DeleteIssueCommand { protected set; get; }
        public ICommand SaveIssueCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        
        IssueViewModel selectedIssue;
 
        public INavigation Navigation { get; set;}
 
        public IssueListViewModel()
        {
            Issues = new ObservableCollection<IssueViewModel>();
            CreateIssueCommand = new Command(CreateIssue);
            DeleteIssueCommand = new Command(DeleteIssue);
            SaveIssueCommand = new Command(SaveIssue);
            BackCommand = new Command(Back);
        }
 
        public IssueViewModel SelectedIssue
        {
            get { return selectedIssue; }
            set
            {
                if (selectedIssue != value)
                {
                    IssueViewModel tmpIssue = value;
                    selectedIssue = null;
                    OnPropertyChanged("SelectedIssue");
                    Navigation.PushAsync(new IssuePage(tmpIssue));
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
 
        private void CreateIssue()
        {
            Navigation.PushAsync(new IssuePage(new IssueViewModel() { ListViewModel = this }));
        }
        
        private void Back()
        {
            Navigation.PopAsync();
        }
        
        private void SaveIssue(object issueObject)
        {
            IssueViewModel issue = issueObject as IssueViewModel;
            if (issue != null && issue.IsValid)
            {
                Issues.Add(issue);
            }
            Back();
        }
        
        private void DeleteIssue(object issueObject)
        {
            IssueViewModel issue = issueObject as IssueViewModel;
            if (issue != null)
            {
                Issues.Remove(issue);
            }
            Back();
        }
    }
}