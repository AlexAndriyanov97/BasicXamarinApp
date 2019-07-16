using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using App1.Model;
using System.Collections.Generic;

namespace App1.ViewModels
{
    public class IssueViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IssueListViewModel IssueList;

        public Issue Issue { get; private set; }

        public IssueViewModel()
        {
            Issue = new Issue();
        }

        public IssueListViewModel ListViewModel
        {
            get { return IssueList; }
            set
            {
                if (IssueList != value)
                {
                    IssueList = value;
                    OnPropertyChanged(nameof(ListViewModel));
                }
            }
        }

        public string Name
        {
            get { return Issue.Name; }
            set
            {
                if (Issue.Name != value)
                {
                    Issue.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Description
        {
            get { return Issue.Description; }
            set
            {
                if (Issue.Description != value)
                {
                    Issue.Description = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        public DateTime Deadline
        {
            get { return Issue.Deadline; }
            set
            {
                if (Issue.Deadline != value)
                {
                    Issue.Deadline = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsValid
        {
            get { return ((!string.IsNullOrEmpty(Name.Trim()))); }
        }

        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}