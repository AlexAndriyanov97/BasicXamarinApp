using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
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
