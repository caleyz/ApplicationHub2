namespace BlackWinformsTest
{
    partial class mainForm
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
            this.AddTileLabel = new System.Windows.Forms.Label();
            this.RemoveTileLabel = new System.Windows.Forms.Label();
            this.gridButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.boxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddTileLabel
            // 
            this.AddTileLabel.AutoSize = true;
            this.AddTileLabel.Font = new System.Drawing.Font("Open Sans Light", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTileLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddTileLabel.Location = new System.Drawing.Point(402, 5);
            this.AddTileLabel.Name = "AddTileLabel";
            this.AddTileLabel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.AddTileLabel.Size = new System.Drawing.Size(145, 69);
            this.AddTileLabel.TabIndex = 3;
            this.AddTileLabel.Text = "Add Tile";
            this.AddTileLabel.Click += new System.EventHandler(this.AddTileLabel_Click);
            this.AddTileLabel.MouseEnter += new System.EventHandler(this.AddTileLabel_MouseEnter);
            this.AddTileLabel.MouseLeave += new System.EventHandler(this.AddTileLabel_MouseLeave);
            // 
            // RemoveTileLabel
            // 
            this.RemoveTileLabel.AutoSize = true;
            this.RemoveTileLabel.Font = new System.Drawing.Font("Open Sans Light", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveTileLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveTileLabel.Location = new System.Drawing.Point(547, 5);
            this.RemoveTileLabel.Name = "RemoveTileLabel";
            this.RemoveTileLabel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.RemoveTileLabel.Size = new System.Drawing.Size(191, 69);
            this.RemoveTileLabel.TabIndex = 4;
            this.RemoveTileLabel.Text = "Remove Tile";
            this.RemoveTileLabel.Click += new System.EventHandler(this.RemoveTileLabel_Click);
            this.RemoveTileLabel.MouseEnter += new System.EventHandler(this.RemoveTileLabel_MouseEnter);
            this.RemoveTileLabel.MouseLeave += new System.EventHandler(this.RemoveTileLabel_MouseLeave);
            // 
            // gridButton
            // 
            this.gridButton.BackColor = System.Drawing.Color.Transparent;
            this.gridButton.BackgroundImage = global::BlackWinformsTest.Properties.Resources.GridLayout5;
            this.gridButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridButton.FlatAppearance.BorderSize = 0;
            this.gridButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.gridButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.gridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gridButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridButton.Image = global::BlackWinformsTest.Properties.Resources.GridLayout5;
            this.gridButton.Location = new System.Drawing.Point(11, 91);
            this.gridButton.Name = "gridButton";
            this.gridButton.Size = new System.Drawing.Size(800, 400);
            this.gridButton.TabIndex = 5;
            this.gridButton.UseVisualStyleBackColor = true;
            this.gridButton.Visible = false;
            this.gridButton.Click += new System.EventHandler(this.gridButton_Click);
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
            this.closeButton.Location = new System.Drawing.Point(778, 14);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 33);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // boxLabel
            // 
            this.boxLabel.AutoSize = true;
            this.boxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.boxLabel.Location = new System.Drawing.Point(219, 29);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(0, 24);
            this.boxLabel.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 500);
            this.ControlBox = false;
            this.Controls.Add(this.boxLabel);
            this.Controls.Add(this.gridButton);
            this.Controls.Add(this.RemoveTileLabel);
            this.Controls.Add(this.AddTileLabel);
            this.Controls.Add(this.closeButton);
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Application Hub";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label AddTileLabel;
        private System.Windows.Forms.Label RemoveTileLabel;
        private System.Windows.Forms.Button gridButton;
        private System.Windows.Forms.Label boxLabel;
    }
}

