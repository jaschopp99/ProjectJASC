namespace ProjectJASC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.ISSLonText = new System.Windows.Forms.TextBox();
            this.ISSLatText = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.yourLocationButton = new System.Windows.Forms.Button();
            this.YourLonText = new System.Windows.Forms.TextBox();
            this.YourLatText = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.DistanceFromISSToYouText = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(335, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Longitude  - ISS    |     Latitude - ISS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ISSLocationButton_Click);
            // 
            // ISSLonText
            // 
            this.ISSLonText.Location = new System.Drawing.Point(335, 39);
            this.ISSLonText.Name = "ISSLonText";
            this.ISSLonText.ReadOnly = true;
            this.ISSLonText.Size = new System.Drawing.Size(100, 20);
            this.ISSLonText.TabIndex = 1;
            // 
            // ISSLatText
            // 
            this.ISSLatText.Location = new System.Drawing.Point(441, 39);
            this.ISSLatText.Name = "ISSLatText";
            this.ISSLatText.ReadOnly = true;
            this.ISSLatText.Size = new System.Drawing.Size(100, 20);
            this.ISSLatText.TabIndex = 2;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(342, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(279, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Click here to view a map with the exact location on a map";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // yourLocationButton
            // 
            this.yourLocationButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yourLocationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yourLocationButton.Location = new System.Drawing.Point(41, 65);
            this.yourLocationButton.Name = "yourLocationButton";
            this.yourLocationButton.Size = new System.Drawing.Size(179, 23);
            this.yourLocationButton.TabIndex = 4;
            this.yourLocationButton.Text = "Your Location (Long.  - Lat.)";
            this.yourLocationButton.UseVisualStyleBackColor = false;
            this.yourLocationButton.Click += new System.EventHandler(this.yourLocationButton_Click);
            // 
            // YourLonText
            // 
            this.YourLonText.Location = new System.Drawing.Point(41, 39);
            this.YourLonText.Name = "YourLonText";
            this.YourLonText.Size = new System.Drawing.Size(88, 20);
            this.YourLonText.TabIndex = 5;
            // 
            // YourLatText
            // 
            this.YourLatText.Location = new System.Drawing.Point(136, 39);
            this.YourLatText.Name = "YourLatText";
            this.YourLatText.Size = new System.Drawing.Size(84, 20);
            this.YourLatText.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(660, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Distance from you to the ISS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.DistanceFromISSToYouButton_Click);
            // 
            // DistanceFromISSToYouText
            // 
            this.DistanceFromISSToYouText.Location = new System.Drawing.Point(692, 39);
            this.DistanceFromISSToYouText.Name = "DistanceFromISSToYouText";
            this.DistanceFromISSToYouText.Size = new System.Drawing.Size(100, 20);
            this.DistanceFromISSToYouText.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(408, 244);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListOfISSLonAndLat_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(136, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 64);
            this.button5.TabIndex = 12;
            this.button5.Text = "Press this to save and display the Longitude,Latitude, and timestamp.";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.DisplayInfoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "*Saves the most recent addition";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(993, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DistanceFromISSToYouText);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.YourLatText);
            this.Controls.Add(this.YourLonText);
            this.Controls.Add(this.yourLocationButton);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.ISSLatText);
            this.Controls.Add(this.ISSLonText);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ISSLonText;
        private System.Windows.Forms.TextBox ISSLatText;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button yourLocationButton;
        private System.Windows.Forms.TextBox YourLonText;
        private System.Windows.Forms.TextBox YourLatText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox DistanceFromISSToYouText;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}

