using MaterialSkin;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ST10229540_PROG7312_POE
{
    public partial class ReportIssue : MaterialForm
    {
     
        private readonly IssueTracker tracker;
        private readonly Form1 main;
        public ReportIssue(IssueTracker tracker, Form1 main)
        {
            InitializeComponent();
            InitializeProgress();
            this.tracker = tracker;
            this.main = main;
        }


        private void InitializeProgress()
        {
            materialProgressBar1.Minimum = 0;
            materialProgressBar1.Maximum = 3;  // Total fields
            materialProgressBar1.Value = 0;
        }

        private void UpdateProgress()
        {
            int progress = 0;

            // Check if the textbox for the location has text
            if (!string.IsNullOrWhiteSpace(materialTextBox21.Text))
                progress++;

            // Check if the description is not empty
            if (!string.IsNullOrWhiteSpace(materialMultiLineTextBox21.Text))
                progress++;

            // Check if an image path is provided
            if (!string.IsNullOrWhiteSpace(materialTextBox22.Text))
                progress++;


            materialProgressBar1.Value = progress;

            if (materialProgressBar1.Value == materialProgressBar1.Maximum) 
            {
                materialLabel1.ForeColor = Color.Green;
                materialLabel1.Text = "All input fields successfully entered";
                
            }
            else
            {
                materialLabel1.Text = "Please enter all fields";
            }
        }

        private void materialTextBox21_TextChanged(object sender, EventArgs e)
    {
        UpdateProgress();
    }

    private void materialMultiLineTextBox21_TextChanged(object sender, EventArgs e)
    {
        UpdateProgress();
    }

    private void materialTextBox22_TextChanged(object sender, EventArgs e)
    {
        UpdateProgress();
    }


        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Call file dialog
            OpenFileDialog ofd = new OpenFileDialog();

            // Set properties
            ofd.InitialDirectory = "c:\\"; // Starting directory
            ofd.RestoreDirectory = true; // Restore the original directory before closing the dialog
            ofd.Title = "Select an image file";

            // Setting the filter to only allow image files
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";

            // Show the dialog and get the result
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Set the button text to the selected file path
                materialTextBox22.Text = ofd.FileName;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(materialTextBox21.Text))
                {
                    MessageBox.Show("Location cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //If the priority is not selected
                if (materialComboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Please select a priority.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(materialMultiLineTextBox21.Text))
                {
                    MessageBox.Show("Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (materialComboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(materialTextBox22.Text) || !System.IO.File.Exists(materialTextBox22.Text))
                {
                    MessageBox.Show("Invalid image path.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //Save the issue
               
                tracker.AddIssue(
                    materialComboBox2.SelectedItem.ToString(), 
                    "Open", 
                    materialTextBox21.Text, 
                    materialComboBox1.SelectedItem.ToString(), 
                    materialMultiLineTextBox21.Text, 
                    materialTextBox22.Text
                    );


                int issueCount = tracker.GetIssues().Count;
                MessageBox.Show($"Total Issues Logged: {issueCount}", "Issue Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
   
            this.Dispose();
            main.Show();
        }
    }
}
