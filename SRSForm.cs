using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10229540_PROG7312_POE
{
    public partial class SRSForm : MaterialForm
    {
        private IssueTracker tracker;
        private readonly Form1 main;

        public SRSForm(IssueTracker tracker, Form1 main)
        {
            this.main = main;
            this.tracker = tracker;
            InitializeComponent();
            LoadIssues();
            materialComboBox1.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            materialComboBox2.SelectedIndexChanged += materialComboBox2_SelectedIndexChanged;
        }

        // Method that loads the issues to the data grid view
        private void LoadIssues()
        {
            var issues = tracker.GetIssues();

            if (issues.Count == 0)
            {
                MessageBox.Show("No issues found. Please log an issue first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = issues;
            }
        }

        // Event handler for ComboBox1 selection change
        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterIssuesByPriority();
        }

        // Method to filter issues by priority and update the DataGridView
        private void FilterIssuesByPriority()
        {
            var priority = materialComboBox1.SelectedItem.ToString();
            var filteredIssues = tracker.GetIssues().Where(issue => issue.Priority == priority).ToList();

            if (filteredIssues.Count == 0)
            {
                MessageBox.Show($"No issues found with priority: {priority}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridView1.DataSource = filteredIssues;
        }

        // Event handler for ComboBox2 selection change
        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterIssuesByStatus();
        }

        // Method to filter issues by status and update the DataGridView
        private void FilterIssuesByStatus()
        {
            var status = materialComboBox2.SelectedItem.ToString();
            var filteredIssues = tracker.GetIssues().Where(issue => issue.Status == status).ToList();

            if (filteredIssues.Count == 0)
            {
                MessageBox.Show($"No issues found with status: {status}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridView1.DataSource = filteredIssues;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Use binary search to find the issue by Priority
            var issues = tracker.GetIssues();
            var priority = materialComboBox1.SelectedItem.ToString();

            // Implementing the Binary Search method
            issues.Sort((x, y) => string.Compare(x.Priority, y.Priority, StringComparison.Ordinal));
            var issue = BinarySearchByPriority(issues, priority);

            if (issue != null)
            {
                MessageBox.Show($"Issue found: ID={issue.Id}, Priority={issue.Priority}", "Issue Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Issue not found.", "Issue Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Issue BinarySearchByPriority(List<Issue> issues, string priority)
        {
            int left = 0;
            int right = issues.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = string.Compare(issues[mid].Priority, priority, StringComparison.Ordinal);

                if (comparison == 0)
                {
                    return issues[mid];
                }
                if (comparison < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return null;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Dispose();
        }
    }


}
