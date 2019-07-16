using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BasicXamarinApp.Model;
using System.Collections.Generic;

namespace BasicXamarinApp.ViewModels
{
    public class IssueViewModel : Tools
    {
        private IssueListViewModel _issueList;

        public Issue Issue { get; private set; }

        public IssueViewModel()
        {
            Issue = new Issue();
        }

        public IssueListViewModel ListViewModel
        {
            get { return _issueList; }
            set
            {
                if (_issueList != value)
                {
                    _issueList = value;
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
    }
}