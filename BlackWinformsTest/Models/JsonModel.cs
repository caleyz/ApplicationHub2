using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackWinformsTest.Models
{
    public class JsonModel
    {
        public IList<Tile> TileList { get; set; } = new List<Tile>();
    }    
}
