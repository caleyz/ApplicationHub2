using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using BlackWinformsTest.Models;
using MetroFramework.Controls;
using Newtonsoft.Json;

namespace BlackWinformsTest
{
    public partial class propertiesForm : MetroFramework.Forms.MetroForm
    {
        public propertiesForm()
        {
            InitializeComponent();
        }

        private void messageBoxForm_Load(object sender, EventArgs e)
        {
            mainForm objForm = new mainForm();
            var tileProps = mainForm.globalTileList.Where(x => x.ID == GlobalVars.PropertiesPassedVar).First();
            nameTextbox.Text = tileProps.Name;
            programLocationLabel.Text = tileProps.ProgramLocation;
            yesRadioButton.Checked = tileProps.UseProgramIcon;
            noRadioButton.Checked = !tileProps.UseProgramIcon;
            imageLocationLabel.Text = tileProps.ImageLocation;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void propertiesForm_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void imageChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.Title = "Choose an image";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocationLabel.Text = openFileDialog.FileName;
            }            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            messageBoxForm childForm = new messageBoxForm();
            if (nameTextbox.Text == "")
            {
                GlobalVars.MessageBoxPassedVar = "EmptyName";
                childForm.ShowDialog();
                return;
            }
            else if (noRadioButton.Checked && imageLocationLabel.Text == "")
            {
                GlobalVars.MessageBoxPassedVar = "ChooseImageIfNoChecked";
                childForm.ShowDialog();
                return;
            }
            else if(imageLocationLabel.Text != "" && yesRadioButton.Checked)
            {
                GlobalVars.MessageBoxPassedVar = "ImageChosenButYesChecked";
                childForm.ShowDialog();
                return;
            }
            var tileChosen = mainForm.globalTileList.First(x => x.ID == GlobalVars.PropertiesPassedVar);
            tileChosen.Name = nameTextbox.Text;
            tileChosen.ProgramLocation = programLocationLabel.Text;
            tileChosen.UseProgramIcon = yesRadioButton.Checked;
            tileChosen.ImageLocation = imageLocationLabel.Text;            
            this.Close();
        }

        private void programLocationButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executables (*.exe) | *.exe |All Files(*.*)|*.*";
            openFileDialog.Title = "Choose a program";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                programLocationLabel.Text = openFileDialog.FileName;
            }
        }

        private void imageClearButton_Click(object sender, EventArgs e)
        {
            imageLocationLabel.Text = "";
        }
    }
}
