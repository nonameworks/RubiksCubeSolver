using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RubiksCube.Model
{
    public class Row
    {
        public Row(Color color)
        {
            Left = new Face(color);
            Centre = new Face(color);
            Right = new Face(color);
        }

        public Face Left { get; set; }
        public Face Centre { get; set; }
        public Face Right { get; set; }
    }
}
