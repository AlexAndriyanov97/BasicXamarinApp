using System.Collections.Generic;
using System.Linq;
using App1.Model;

namespace BasicXamarinApp.Android.Models.Repository
{
    public class IssueRepository
    {
        public IssueRepository()
        {
        }

        public List<Issue> GetAllIssues()
        {
            var issues = new List<Issue>();
            using (var appContext = new AppContext())
            {
                issues = appContext.Issues.ToList();
            }
            return issues;
        }

        public Issue GetIssueById(int id)
        {
            Issue issue = null;
            using (var appContext = new AppContext())
            {
                issue = appContext.Issues.FirstOrDefault(x=>x.Id==id);
            }
            return issue;
        }


        public Issue GetIssueByName(string name)
        {
            Issue issue = null;
            using (var appContext = new AppContext())
            {
                issue = appContext.Issues.FirstOrDefault(x => x.Name == name);
            }

            return issue;
        }
    }
}