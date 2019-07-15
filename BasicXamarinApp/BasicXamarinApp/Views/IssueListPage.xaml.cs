using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
