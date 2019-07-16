using App1.ViewModels;

using Xamarin.Forms;

namespace App1.Views
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
