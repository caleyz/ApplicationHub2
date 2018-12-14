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
            var tileProps = mainForm.globalTileList.Where(x => x.ID == GlobalVars.PropertiesPassedVar);
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

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
