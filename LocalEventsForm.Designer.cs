namespace ST10229540_PROG7312_POE
{
    partial class LocalEventsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReturnBtn = new MaterialSkin.Controls.MaterialButton();
            this.listBoxRecommendations = new System.Windows.Forms.ListBox();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.CategoriesComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.AutoSize = false;
            this.ReturnBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReturnBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ReturnBtn.Depth = 0;
            this.ReturnBtn.HighEmphasis = true;
            this.ReturnBtn.Icon = null;
            this.ReturnBtn.Location = new System.Drawing.Point(296, 689);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ReturnBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ReturnBtn.Size = new System.Drawing.Size(158, 39);
            this.ReturnBtn.TabIndex = 20;
            this.ReturnBtn.Text = "Return to Menu";
            this.ReturnBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ReturnBtn.UseAccentColor = false;
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // listBoxRecommendations
            // 
            this.listBoxRecommendations.FormattingEnabled = true;
            this.listBoxRecommendations.ItemHeight = 16;
            this.listBoxRecommendations.Location = new System.Drawing.Point(116, 451);
            this.listBoxRecommendations.Name = "listBoxRecommendations";
            this.listBoxRecommendations.Size = new System.Drawing.Size(511, 196);
            this.listBoxRecommendations.TabIndex = 19;
            // 
            // EventsListBox
            // 
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.ItemHeight = 16;
            this.EventsListBox.Location = new System.Drawing.Point(116, 217);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(511, 180);
            this.EventsListBox.TabIndex = 18;
            // 
            // CategoriesComboBox
            // 
            this.CategoriesComboBox.AutoResize = false;
            this.CategoriesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CategoriesComboBox.Depth = 0;
            this.CategoriesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CategoriesComboBox.DropDownHeight = 174;
            this.CategoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesComboBox.DropDownWidth = 121;
            this.CategoriesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CategoriesComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CategoriesComboBox.FormattingEnabled = true;
            this.CategoriesComboBox.IntegralHeight = false;
            this.CategoriesComboBox.ItemHeight = 43;
            this.CategoriesComboBox.Location = new System.Drawing.Point(116, 99);
            this.CategoriesComboBox.MaxDropDownItems = 4;
            this.CategoriesComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CategoriesComboBox.Name = "CategoriesComboBox";
            this.CategoriesComboBox.Size = new System.Drawing.Size(305, 49);
            this.CategoriesComboBox.StartIndex = 0;
            this.CategoriesComboBox.TabIndex = 17;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = false;
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SearchButton.Depth = 0;
            this.SearchButton.HighEmphasis = true;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(469, 125);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SearchButton.Size = new System.Drawing.Size(158, 39);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SearchButton.UseAccentColor = false;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_2);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // LocalEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 776);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.listBoxRecommendations);
            this.Controls.Add(this.EventsListBox);
            this.Controls.Add(this.CategoriesComboBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "LocalEventsForm";
            this.Text = "LocalEventsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ReturnBtn;
        private System.Windows.Forms.ListBox listBoxRecommendations;
        private System.Windows.Forms.ListBox EventsListBox;
        private MaterialSkin.Controls.MaterialComboBox CategoriesComboBox;
        private MaterialSkin.Controls.MaterialButton SearchButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}