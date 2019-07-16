using BasicXamarinApp.ViewModels;

using Xamarin.Forms;

namespace BasicXamarinApp.Views
{
    public partial class IssuePage : ContentPage
    {
        public IssueViewModel ViewModel { get; private set; }

        public IssuePage(IssueViewModel issueViewModel)
        {
            InitializeComponent();
            ViewModel = issueViewModel;
            this.BindingContext = ViewModel;
        }
    }
}
