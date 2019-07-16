using BasicXamarinApp.ViewModels;

using Xamarin.Forms;

namespace BasicXamarinApp.Views
{
    public partial class IssueListPage : ContentPage
    {
        public IssueListPage()
        {
            InitializeComponent();
            BindingContext = new IssueListViewModel() { Navigation = this.Navigation };
        }
    }
}
