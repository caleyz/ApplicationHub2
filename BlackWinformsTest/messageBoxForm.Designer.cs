namespace BlackWinformsTest
{
    partial class messageBoxForm
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
            this.messageLabel = new System.Windows.Forms.Label();
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
            this.closeButton.Location = new System.Drawing.Point(278, 14);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 33);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Open Sans Light", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.messageLabel.Location = new System.Drawing.Point(59, 94);
            this.messageLabel.MaximumSize = new System.Drawing.Size(200, 200);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 23);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.ControlBox = false;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.closeButton);
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.MaximizeBox = false;
            this.Name = "messageBoxForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Message Box";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.messageBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label messageLabel;
    }
}

