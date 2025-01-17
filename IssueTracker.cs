using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10229540_PROG7312_POE
{
    public class IssueTracker
    {

        private IssuesTreeNode<Issue> root = null;

        public int issueId = 0;



        public void AddIssue(string priority, string status, string location, string category, string description, string imagePath)
        {
            var issue = new Issue
            {Id = ++issueId,
                Priority = priority,
                Status = status,
                Location = location,
                Category = category,
                Description = description,
                ImagePath = imagePath
            };

            if (root == null)
            { root = new IssuesTreeNode<Issue>(issue);}
            else
            {AddToIssuesTree(root, issue);}
        }

        //Get all issues
        public List<Issue> GetIssues()
        { List<Issue> issues = new List<Issue>();
            GetTreeIssues(root, issues);
            return issues;
        }

        private void GetTreeIssues(IssuesTreeNode<Issue> node, List<Issue> issues)
        {
          if (node == null){return;}

            GetTreeIssues(node.Left, issues);
            issues.Add(node.Value);
            GetTreeIssues(node.Right, issues);
        }

        private void AddToIssuesTree(IssuesTreeNode<Issue> node, Issue issue)
        {
            if (issue.Id < node.Value.Id)
            {
                if (node.Left == null)
                {
                    node.Left = new IssuesTreeNode<Issue>(issue);
                }
                else
                {
                    AddToIssuesTree(node.Left, issue); // Recursion!
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new IssuesTreeNode<Issue>(issue);
                }
                else
                {
                    AddToIssuesTree(node.Right, issue);
                }
            }
        }

        public Issue SearchForIssue(int id)
        {
            return SearchForTreeIssues(root, id);
        }

        private Issue SearchForTreeIssues(IssuesTreeNode<Issue> node, int id)
        {
            if (node == null){
                return null;
            }

            if (id == node.Value.Id){
                return node.Value;
            }
            else if (id < node.Value.Id){
                return SearchForTreeIssues(node.Left, id);
            }
            else{
                return SearchForTreeIssues(node.Right, id);
            }
        }
    }
}
