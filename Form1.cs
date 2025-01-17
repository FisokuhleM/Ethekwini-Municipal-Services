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

namespace ST10229540_PROG7312_POE
{
    public partial class Form1 : MaterialForm
    {
        IssueTracker tracker = new IssueTracker();
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // or DARK if preferred

            materialSkinManager.ColorScheme = new ColorScheme(
                Color.FromArgb(76, 175, 80),   // Primary green color (4CAF50)
                Color.FromArgb(56, 142, 60),   // Darker green for primary dark (388E3C)
                Color.FromArgb(200, 230, 201), // Lighter green for primary light (E8F5E9)
                Color.FromArgb(129, 199, 132),  // Accent green color (81C784)
                TextShade.WHITE);                // Text color shade for contrast
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            ReportIssue ri = new ReportIssue(tracker, this);
            this.Hide();
            ri.ShowDialog();
            this.Show();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            FeedbackPortal fp = new FeedbackPortal();
            this.Hide();
            fp.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            LocalEventsForm lef = new LocalEventsForm();
            this.Hide();
            lef.ShowDialog();
            this.Show();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            // Open the SRS Form
            SRSForm srs = new SRSForm(tracker, this);
            this.Hide();
            srs.ShowDialog();
            this.Show();
        }
    }

}
