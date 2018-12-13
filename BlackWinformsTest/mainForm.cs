using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        //public static List<MetroTile> metroTileList = new List<MetroTile>();
        public static int xOffset = 26;
        public static int yOffset = 105;
        public static bool addBool = false;
        public static bool removeBool = false;

        public mainForm()
        {
            InitializeComponent();
            this.TopMost = true;            
            GetGridTiles();
            t1.Tick += new EventHandler(fadeIn);
            t1.Interval = 10;
            t1.Start();
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
            globalTileList = JsonConvert.DeserializeObject<List<Tile>>(fileData) ?? new List<Tile>();
            foreach(var tile in globalTileList)
            {
                maxID = tile.ID > maxID ? tile.ID : maxID;
                rowColumns.Add(new GridLocation()
                {
                    row = tile.GridRowCol.row,
                    column = tile.GridRowCol.column
                });
                MetroTile metroTile = new MetroTile();
                metroTile.Location = new Point(((tile.GridRowCol.column * 100) + xOffset), ((tile.GridRowCol.row * 100) + yOffset));
                metroTile.Size = new Size(71, 71);
                this.Controls.Add(metroTile);
            }
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t1.Stop();
                this.TopMost = false;
            }
            else
            {
                Opacity += 0.05;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                t1.Stop();
                Application.Exit();
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
            if (addBool)
            {
                gridImage.Visible = addBool = removeBool = false;
            }
            else if (removeBool)
            {
                gridImage.Image = SetImageOpacity(Properties.Resources.GridLayout4, 0.25F);
                addBool = gridImage.Visible = true;
                removeBool = false;
            }
            else
            {                
                gridImage.Image = SetImageOpacity(Properties.Resources.GridLayout4, 0.25F);
                addBool = gridImage.Visible = true;
            }
        }

        private void RemoveTileLabel_Click(object sender, EventArgs e)
        {
            if (removeBool)
            {
                gridImage.Visible = addBool = removeBool = false;
            }
            else if (addBool)
            {
                gridImage.Image = SetImageOpacity(Properties.Resources.RemoveGridLayout2, 0.25F);
                removeBool = gridImage.Visible = true;
                addBool = false;
            }
            else
            {
                gridImage.Image = SetImageOpacity(Properties.Resources.RemoveGridLayout2, 0.25F);
                removeBool = gridImage.Visible = true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
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
            Tile baseTile = new Tile()
            {
                ID = (maxID + 1),
                Name = "placeholderName",
                UseProgramIcon = false,
                ImageLocation = "",
                GridRowCol = new GridLocation()
                {
                    row = rowNum,
                    column = colNum
                }
            };
            gridImage.Visible = false;
            boxLabel.Text = String.Format("Row {0}, Column {1}", rowNum, colNum);
            var matches = rowColumns.Where(p => p.row == rowNum && p.column == colNum);
            if (addBool)
            {
                if (globalTileList.Count == 0)
                {
                    globalTileList.Add(baseTile);
                    rowColumns.Add(new GridLocation { row = rowNum, column = colNum });
                    MetroTile metroTile = new MetroTile();
                    metroTile.Location = new Point(((colNum * 100) + xOffset), ((rowNum * 100) + yOffset));
                    maxID++;
                    metroTile.Size = new Size(71, 71);
                    this.Controls.Add(metroTile);
                    File.WriteAllText(filePath, JsonConvert.SerializeObject(globalTileList, Formatting.Indented));
                }
                else if (matches.Count() >= 1)
                {
                    GlobalVars.MessageBoxPassedVar = "AlreadyExists";
                    messageBoxForm childForm = new messageBoxForm();
                    childForm.ShowDialog();
                }
                else
                {
                    globalTileList.Add(baseTile);
                    rowColumns.Add(new GridLocation { row = rowNum, column = colNum });
                    MetroTile metroTile = new MetroTile();
                    metroTile.Location = new Point(((colNum * 100) + xOffset), ((rowNum * 100) + yOffset));
                    maxID++;
                    metroTile.Size = new Size(71, 71);
                    this.Controls.Add(metroTile);
                    File.WriteAllText(filePath, JsonConvert.SerializeObject(globalTileList, Formatting.Indented));
                }
            }
            else if (removeBool)
            {
                if (matches.Count() >= 1)
                {
                    rowColumns.RemoveAll(p => p.row == rowNum && p.column == colNum);
                    globalTileList.RemoveAll(p => p.GridRowCol.row == rowNum && p.GridRowCol.column == colNum);
                    File.WriteAllText(filePath, JsonConvert.SerializeObject(globalTileList, Formatting.Indented));
                    foreach (var control in this.Controls.OfType<MetroTile>())
                    {
                        if (control.Location.X == ((colNum * 100) + xOffset) && control.Location.Y == ((rowNum * 100) + yOffset))
                        {
                            this.Controls.Remove(control);
                            break;
                        }
                    }
                }
            }
            addBool = removeBool = false;
        }        
    }
}
