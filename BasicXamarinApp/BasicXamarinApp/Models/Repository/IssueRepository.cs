using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using App1.Model;

namespace BasicXamarinApp.Android.Models.Repository
{
    public class IssueRepository:IRepository<Issue>
    {
        public IssueRepository()
        {
        }

        public List<Issue> GetAllEntries()
        {
            var issues = new List<Issue>();
            using (var appContext = new AppContext())
            {
                issues = appContext.Issues.ToList();
            }
            return issues;
        }

        public Issue GetEntryById(int id)
        {
            
            Expression<Func<Issue, bool>> expression = issue => issue.Id == id;
            var foundedIssue = GetEntitiesByExpression(expression).FirstOrDefault();
            return foundedIssue;
        }


        public List<Issue> GetEntriesByName(string name)
        {
            
            Expression<Func<Issue, bool>> expression = issue => issue.Name == name;
            var foundedIssue = GetEntitiesByExpression(expression);
            return foundedIssue;
       }

        public List<Issue> GetEntitiesByExpression(Expression<Func<Issue, bool>> expression)
        {
            var issues = new List<Issue>();
            using (var appContext = new AppContext())
            {
                issues = appContext.Issues.Where(expression).ToList();
            }

            return issues;
        }

        public Issue EditEntity(Expression<Func<Issue, bool>> expression, Issue editedEntry)
        {
            Issue issue = null;
            using (var appContext = new AppContext())
            {
                issue = appContext.Issues.Where(expression).FirstOrDefault();
                if (issue != null)
                {
                    issue.Name = editedEntry.Name;
                    issue.User = editedEntry.User;
                    issue.Deadline = editedEntry.Deadline;
                    issue.Description = editedEntry.Description;
                    issue.UserId = editedEntry.UserId;
                }

                appContext.SaveChanges();
            }

            return issue;
        }

        public Issue DeleteEntity(Expression<Func<Issue, bool>> expression)
        {
            Issue issue = null;
            using (var appContext = new AppContext())
            {
                issue = appContext.Issues.Where(expression).FirstOrDefault();
                if (issue != null)
                {
                    appContext.Issues.Remove(issue);
                    appContext.SaveChanges();
                }
            }

            return issue;
        }

        public void CreateEntity(Issue newIssue)
        {
            using (var appContext = new AppContext())
            {
                appContext.Issues.Add(newIssue);
                appContext.SaveChanges();
            }
        }
    }
}