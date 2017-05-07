using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RubiksCube.Model
{
    public class Face : ViewModelBase
    {
        public Face(Color color)
        {
            FaceColor = color;
        }

        private Color _FaceColor;
        public Color FaceColor
        {
            get { return _FaceColor; }
            set { Set(ref _FaceColor, value); }
        }
    }
}
