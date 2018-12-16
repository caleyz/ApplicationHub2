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
    public partial class messageBoxForm : MetroFramework.Forms.MetroForm
    {
        public messageBoxForm()
        {
            InitializeComponent();
        }

        private void messageBoxForm_Load(object sender, EventArgs e)
        {
            mainForm objForm = new mainForm();
            SetLabelText();
        }      

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetLabelText()
        {
            switch (GlobalVars.MessageBoxPassedVar)
            {
                case "AlreadyExists":
                    messageLabel.Text = "A button already exists in this location";
                    break;
                case "EmptyName":
                    messageLabel.Text = "You cannot submit these properties with an empty name";
                    break;
                case "ChooseImageIfNoChecked":
                    messageLabel.Text = "Because you have chosen not to use the default program icon, you must choose an image location";
                    break;
                case "ImageChosenButYesChecked":
                    messageLabel.Text = "You have chosen an image but have chosen to use the default program icon - please either check 'no' or clear your image location";
                    break;
                default:
                    break;
            }
        }
    }
}
