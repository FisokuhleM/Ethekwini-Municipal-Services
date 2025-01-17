using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ST10229540_PROG7312_POE
{
    public partial class FeedbackPortal : MaterialForm
    {
        // Instance of the Feedback Tracker
        private FeedbackTracker ft;

        public FeedbackPortal()
        {
            InitializeComponent();
            // Initialize the FeedbackTracker and its feedbacks list
            ft = new FeedbackTracker();
            ft.feedbacks = new List<Feedback>(); 
        
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Ensuring that controls are not null
            if (materialMultiLineTextBox21 == null || 
                materialRadioButton1 == null || 
                materialRadioButton2 == null || 
                materialRadioButton3 == null || 
                materialRadioButton4 == null || 
                materialRadioButton5 == null)
            {
                MessageBox.Show("One or more controls are not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rating = "";
            // Check if any of the radio buttons were checked
            RadioButton[] radioButtons = { materialRadioButton1, materialRadioButton2, materialRadioButton3, materialRadioButton4, materialRadioButton5 };
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    rating = radioButton.Text;
                    break;
                }
            }

            bool isRatingEmpty = string.IsNullOrEmpty(rating);
            bool isDescriptionEmpty = string.IsNullOrEmpty(materialMultiLineTextBox21.Text);
            //Check if rating was selected & check if feedback body was entered
            if (isRatingEmpty && isDescriptionEmpty)
            {
                MessageBox.Show("Please rate our service and enter the body of your feedback", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isRatingEmpty)//Check if rating was selected
            {
                MessageBox.Show("No rating selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isDescriptionEmpty) //Check if feedback body was entered
            {
                MessageBox.Show("Please enter the description to your feedback", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Add feedback to the list
                ft.feedbacks.Add(
                    new Feedback { 
                        Id = ft.feedbacks.Count + 1, 
                        Rating = rating, 
                        Body = materialMultiLineTextBox21.Text 
                    });

                MessageBox.Show("Your Feedback was submitted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Thank you for your feedback");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Close();
            main.Show();
        }
    }
}
