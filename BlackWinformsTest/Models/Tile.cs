using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackWinformsTest.Models
{
    public class Tile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool UseProgramIcon { get; set; }
        public string ImageLocation { get; set; }
        public GridLocation GridRowCol { get; set; }        
    }
}
