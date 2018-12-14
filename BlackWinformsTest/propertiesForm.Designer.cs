namespace BlackWinformsTest
{
    partial class propertiesForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.imageChooseButton = new MetroFramework.Controls.MetroButton();
            this.imageLocationLabel = new System.Windows.Forms.Label();
            this.submitButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = global::BlackWinformsTest.Properties.Resources.DarkClose32;
            this.closeButton.Location = new System.Drawing.Point(358, 14);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 33);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Open Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLabel.Location = new System.Drawing.Point(122, 95);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(2);
            this.nameLabel.Size = new System.Drawing.Size(67, 30);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameTextbox.Location = new System.Drawing.Point(195, 96);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(127, 29);
            this.nameTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 129);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Use Program Icon";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Font = new System.Drawing.Font("Open Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.imageLabel.Location = new System.Drawing.Point(122, 165);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Padding = new System.Windows.Forms.Padding(2);
            this.imageLabel.Size = new System.Drawing.Size(68, 30);
            this.imageLabel.TabIndex = 8;
            this.imageLabel.Text = "Image";
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(195, 137);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(40, 15);
            this.metroRadioButton1.TabIndex = 10;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "Yes";
            this.metroRadioButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton1.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(241, 137);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(39, 15);
            this.metroRadioButton2.TabIndex = 11;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "No";
            this.metroRadioButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton2.UseVisualStyleBackColor = true;
            // 
            // imageChooseButton
            // 
            this.imageChooseButton.Location = new System.Drawing.Point(194, 169);
            this.imageChooseButton.Name = "imageChooseButton";
            this.imageChooseButton.Size = new System.Drawing.Size(85, 23);
            this.imageChooseButton.TabIndex = 12;
            this.imageChooseButton.Text = "Choose Image";
            this.imageChooseButton.Click += new System.EventHandler(this.imageChooseButton_Click);
            // 
            // imageLocationLabel
            // 
            this.imageLocationLabel.AutoSize = true;
            this.imageLocationLabel.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLocationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.imageLocationLabel.Location = new System.Drawing.Point(285, 159);
            this.imageLocationLabel.Name = "imageLocationLabel";
            this.imageLocationLabel.Padding = new System.Windows.Forms.Padding(1);
            this.imageLocationLabel.Size = new System.Drawing.Size(2, 17);
            this.imageLocationLabel.TabIndex = 13;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(164, 227);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(71, 23);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // propertiesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.ControlBox = false;
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.imageLocationLabel);
            this.Controls.Add(this.imageChooseButton);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.closeButton);
            this.DoubleBuffered = false;
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.MaximizeBox = false;
            this.Name = "propertiesForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Properties";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.messageBoxForm_Load);
            this.Shown += new System.EventHandler(this.propertiesForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label nameLabel;
        private MetroFramework.Controls.MetroTextBox nameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label imageLabel;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroButton imageChooseButton;
        private System.Windows.Forms.Label imageLocationLabel;
        private MetroFramework.Controls.MetroButton submitButton;
    }
}

