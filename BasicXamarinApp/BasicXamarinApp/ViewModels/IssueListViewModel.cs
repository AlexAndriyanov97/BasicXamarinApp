using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using App1.Views;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class IssueListViewModel : Tools
    {
        public ObservableCollection<IssueViewModel> Issues { get; set; }
        public ICommand CreateIssueCommand { protected set; get; }
        public ICommand DeleteIssueCommand { protected set; get; }
        public ICommand SaveIssueCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }

        IssueViewModel selectedIssue;

        public INavigation Navigation { get; set; }

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
                    var tmpIssue = value;
                    selectedIssue = null;
                    OnPropertyChanged(nameof(SelectedIssue));
                    Navigation.PushAsync(new IssuePage(tmpIssue));
                }
            }
        }

        private void CreateIssue()
        {
            Navigation.PushAsync(new IssuePage(new IssueViewModel() {ListViewModel = this}));
        }

        private void Back()
        {
            Navigation.PopAsync();
        }

        private void SaveIssue(object issueObject)
        {
            var issue = issueObject as IssueViewModel;
            if (issue != null && issue.IsValid)
            {
                Issues.Add(issue);
            }

            Back();
        }

        private void DeleteIssue(object issueObject)
        {
            var issue = issueObject as IssueViewModel;
            if (issue != null)
            {
                Issues.Remove(issue);
            }

            Back();
        }
    }
}