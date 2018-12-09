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
            this.closeButton = new System.Windows.Forms.Button();
            this.AddTileLabel = new System.Windows.Forms.Label();
            this.RemoveTileLabel = new System.Windows.Forms.Label();
            this.boxLabel = new System.Windows.Forms.Label();
            this.gridImage = new BlackWinformsTest.TransparentControl();
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
            this.closeButton.Location = new System.Drawing.Point(778, 14);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 33);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            // gridImage
            // 
            this.gridImage.BackColor = System.Drawing.Color.Transparent;
            this.gridImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridImage.Image = global::BlackWinformsTest.Properties.Resources.GridLayout5;
            this.gridImage.Location = new System.Drawing.Point(11, 91);
            this.gridImage.Name = "gridImage";
            this.gridImage.Size = new System.Drawing.Size(800, 400);
            this.gridImage.TabIndex = 7;
            this.gridImage.Visible = false;
            this.gridImage.Click += new System.EventHandler(this.gridImage_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 500);
            this.ControlBox = false;
            this.Controls.Add(this.gridImage);
            this.Controls.Add(this.boxLabel);
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
        private System.Windows.Forms.Label boxLabel;
        private TransparentControl gridImage;
    }
}

