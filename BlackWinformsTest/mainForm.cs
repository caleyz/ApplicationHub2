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
    public partial class mainForm : MetroFramework.Forms.MetroForm
    {
        public string messageBoxVar = "";
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        public static List<Tile> globalTileList = new List<Tile>();
        public static string filePath = @"C:\Users\Zack\Documents\BlackWinformsTest.json";
        public static int maxID = 0;
        public static List<GridLocation> rowColumns = new List<GridLocation>();
        public static List<MetroTile> metroTileList = new List<MetroTile>();
        public static int xOffset = 11;
        public static int yOffset = 91;

        public mainForm()
        {
            InitializeComponent();
            //gridButton.BackColor = Color.FromArgb(100, Color.Transparent);
            GetGridTiles();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        public void GetGridTiles()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }  
            var fileData = File.ReadAllText(filePath);
            var globalTileList = JsonConvert.DeserializeObject<List<Tile>>(fileData) ?? new List<Tile>();
            foreach(var tile in globalTileList)
            {
                maxID = tile.ID > maxID ? tile.ID : maxID;
                rowColumns.Add(new GridLocation()
                {
                    row = tile.GridRowCol.row,
                    column = tile.GridRowCol.column
                });
            }

        }
        
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }
        
        public void fadeOut2()
        {
            for(int i = 0; i < 20; i++)
            {
                if (Opacity <= 0) Application.Exit();
                Opacity -= 0.05;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                t1.Stop();    //if it is, we stop the timer
                Application.Exit(); //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }

        private void AddTileLabel_MouseEnter(object sender, EventArgs e)
        {
            AddTileLabel.BackColor = Color.FromArgb(20, Color.DarkGray);
        }

        private void AddTileLabel_MouseLeave(object sender, EventArgs e)
        {
            AddTileLabel.BackColor = Color.FromArgb(17, 17, 17);
        }

        private void RemoveTileLabel_MouseEnter(object sender, EventArgs e)
        {
            RemoveTileLabel.BackColor = Color.FromArgb(20, Color.DarkGray);
        }

        private void RemoveTileLabel_MouseLeave(object sender, EventArgs e)
        {
            RemoveTileLabel.BackColor = Color.FromArgb(17, 17, 17);
        }

        private void AddTileLabel_Click(object sender, EventArgs e)
        {
            gridImage.Visible = true;            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridImage_Click(object sender, EventArgs e)
        {
            var coordinates = gridImage.PointToClient(Cursor.Position);
            int rowNum = Convert.ToInt32(Math.Floor((decimal)coordinates.Y / 100));
            int colNum = Convert.ToInt32(Math.Floor((decimal)coordinates.X / 100));
            if (rowNum > 3 || colNum > 7)
            {
                gridImage.Visible = false;
                return;
            }
            gridImage.Visible = false;
            boxLabel.Text = String.Format("Row {0}, Column {1}", rowNum, colNum);
            var matches = rowColumns.Where(p => p.row == rowNum).Where(x => x.column == colNum);
            if (globalTileList.Count == 0)
            {
                globalTileList.Add(new Tile()
                {
                    ID = 1,
                    Name = "placeholderName",
                    UseProgramIcon = false,
                    ImageLocation = "",
                    GridRowCol = new GridLocation()
                    {
                        row = rowNum,
                        column = colNum
                    }
                });
                rowColumns.Add(new GridLocation { row = rowNum, column = colNum });
                MetroTile metroTile = new MetroTile();
                metroTile.Location = new Point(((colNum * 100) + xOffset), ((rowNum * 100) + yOffset));
                //metroTile.Top = Top;
                //metroTile.Left = Left;
                metroTile.Size = new Size(70, 70);
                this.Controls.Add(metroTile);
            }
            else if (matches.Count() >= 1)
            {
                GlobalVars.MessageBoxPassedVar = "AlreadyExists";
                messageBoxForm childForm = new messageBoxForm();
                childForm.ShowDialog();
            }
            else
            {
                globalTileList.Add(new Tile()
                {
                    ID = maxID + 1,
                    Name = "placeholderName",
                    UseProgramIcon = false,
                    ImageLocation = "",
                    GridRowCol = new GridLocation()
                    {
                        row = rowNum,
                        column = colNum
                    }
                });
                rowColumns.Add(new GridLocation { row = rowNum, column = colNum });
                MetroTile metroTile = new MetroTile();
                metroTile.Location = new Point(((colNum * 100) + xOffset), ((rowNum * 100) + yOffset));
                //metroTile.Top = Top;
                //metroTile.Left = Left;
                //test
                metroTile.Size = new Size(70, 70);
                this.Controls.Add(metroTile);
            }
        }

        private void RemoveTileLabel_Click(object sender, EventArgs e)
        {
            gridImage.Visible = false;
        }
    }
}
