namespace AnimeKoyomi
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Monday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Tuesday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Wednesday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Thursday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Friday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Saturday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Sunday", System.Windows.Forms.HorizontalAlignment.Left);
            this.button1 = new System.Windows.Forms.Button();
            this.scheduleListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GoogleLoginButton = new System.Windows.Forms.Button();
            this.loggedInLabel = new System.Windows.Forms.Label();
            this.timezoneDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.googleCalendarBox = new System.Windows.Forms.GroupBox();
            this.calendarWarning = new System.Windows.Forms.Label();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.calendarDropdown = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.googleCalendarBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh Simulcast Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DownloadClick);
            // 
            // scheduleListView
            // 
            this.scheduleListView.CheckBoxes = true;
            this.scheduleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Time});
            this.scheduleListView.FullRowSelect = true;
            this.scheduleListView.GridLines = true;
            listViewGroup1.Header = "Monday";
            listViewGroup1.Name = "Mon";
            listViewGroup2.Header = "Tuesday";
            listViewGroup2.Name = "Tue";
            listViewGroup3.Header = "Wednesday";
            listViewGroup3.Name = "Wed";
            listViewGroup4.Header = "Thursday";
            listViewGroup4.Name = "Thu";
            listViewGroup5.Header = "Friday";
            listViewGroup5.Name = "Fri";
            listViewGroup6.Header = "Saturday";
            listViewGroup6.Name = "Sat";
            listViewGroup7.Header = "Sunday";
            listViewGroup7.Name = "Sun";
            this.scheduleListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7});
            this.scheduleListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.scheduleListView.Location = new System.Drawing.Point(12, 13);
            this.scheduleListView.MultiSelect = false;
            this.scheduleListView.Name = "scheduleListView";
            this.scheduleListView.ShowItemToolTips = true;
            this.scheduleListView.Size = new System.Drawing.Size(410, 243);
            this.scheduleListView.TabIndex = 2;
            this.scheduleListView.UseCompatibleStateImageBehavior = false;
            this.scheduleListView.View = System.Windows.Forms.View.Details;
            this.scheduleListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.scheduleListView_ItemSelectionChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 342;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 45;
            // 
            // GoogleLoginButton
            // 
            this.GoogleLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoogleLoginButton.Location = new System.Drawing.Point(15, 291);
            this.GoogleLoginButton.Name = "GoogleLoginButton";
            this.GoogleLoginButton.Size = new System.Drawing.Size(162, 23);
            this.GoogleLoginButton.TabIndex = 3;
            this.GoogleLoginButton.Text = "Google Account Login";
            this.GoogleLoginButton.UseVisualStyleBackColor = true;
            this.GoogleLoginButton.Click += new System.EventHandler(this.GoogleLoginButton_Click);
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.Location = new System.Drawing.Point(15, 317);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(162, 13);
            this.loggedInLabel.TabIndex = 4;
            this.loggedInLabel.Text = "Not logged in.";
            this.loggedInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timezoneDropdown
            // 
            this.timezoneDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timezoneDropdown.FormattingEnabled = true;
            this.timezoneDropdown.Location = new System.Drawing.Point(260, 291);
            this.timezoneDropdown.Name = "timezoneDropdown";
            this.timezoneDropdown.Size = new System.Drawing.Size(162, 21);
            this.timezoneDropdown.TabIndex = 5;
            this.timezoneDropdown.SelectedIndexChanged += new System.EventHandler(this.timezoneDropdown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a timezone";
            // 
            // googleCalendarBox
            // 
            this.googleCalendarBox.Controls.Add(this.submitButton);
            this.googleCalendarBox.Controls.Add(this.calendarWarning);
            this.googleCalendarBox.Controls.Add(this.calendarLabel);
            this.googleCalendarBox.Controls.Add(this.calendarDropdown);
            this.googleCalendarBox.Enabled = false;
            this.googleCalendarBox.Location = new System.Drawing.Point(12, 366);
            this.googleCalendarBox.Name = "googleCalendarBox";
            this.googleCalendarBox.Size = new System.Drawing.Size(410, 83);
            this.googleCalendarBox.TabIndex = 7;
            this.googleCalendarBox.TabStop = false;
            this.googleCalendarBox.Text = "Google Calendar";
            // 
            // calendarWarning
            // 
            this.calendarWarning.Enabled = false;
            this.calendarWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarWarning.Location = new System.Drawing.Point(6, 60);
            this.calendarWarning.Name = "calendarWarning";
            this.calendarWarning.Size = new System.Drawing.Size(195, 20);
            this.calendarWarning.TabIndex = 2;
            this.calendarWarning.Text = "Warning: This calendar will be cleared.";
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Enabled = false;
            this.calendarLabel.Location = new System.Drawing.Point(7, 20);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(84, 13);
            this.calendarLabel.TabIndex = 1;
            this.calendarLabel.Text = "Calendar to use:";
            // 
            // calendarDropdown
            // 
            this.calendarDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calendarDropdown.Enabled = false;
            this.calendarDropdown.FormattingEnabled = true;
            this.calendarDropdown.Location = new System.Drawing.Point(6, 36);
            this.calendarDropdown.Name = "calendarDropdown";
            this.calendarDropdown.Size = new System.Drawing.Size(195, 21);
            this.calendarDropdown.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(271, 15);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(133, 62);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Create Events";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.googleCalendarBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timezoneDropdown);
            this.Controls.Add(this.loggedInLabel);
            this.Controls.Add(this.GoogleLoginButton);
            this.Controls.Add(this.scheduleListView);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Anime Koyomi";
            this.googleCalendarBox.ResumeLayout(false);
            this.googleCalendarBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ListView scheduleListView;
        private System.Windows.Forms.Button GoogleLoginButton;
        private System.Windows.Forms.Label loggedInLabel;
        private System.Windows.Forms.ComboBox timezoneDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox googleCalendarBox;
        private System.Windows.Forms.Label calendarWarning;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.ComboBox calendarDropdown;
        private System.Windows.Forms.Button submitButton;
    }
}

