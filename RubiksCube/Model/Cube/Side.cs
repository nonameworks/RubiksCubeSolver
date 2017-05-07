using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RubiksCube.Model
{
    public class Side
    {

        public Side(Color color, Cube cube)
        {
            TopRow = new Row(color);
            CentreRow = new Row(color);
            BottomRow = new Row(color);
            Cube = cube;
        }

        Cube Cube { get; set; }
        public Row TopRow { get; set; }
        public Row CentreRow { get; set; }
        public Row BottomRow { get; set; }

        public RelayCommand RotateCommand
        {
            get
            {
                return new RelayCommand(() => { Cube.RotateFace(this); });
            }
        }

        public int Score
        {
            get
            {
                var value = 1;
                var color = TopRow.Left.FaceColor;
                if (TopRow.Right.FaceColor == color)
                    value++;

                if (TopRow.Centre.FaceColor == color)
                    value++;

                if (CentreRow.Left.FaceColor == color)
                    value++;

                if (CentreRow.Centre.FaceColor == color)
                    value++;

                if (CentreRow.Right.FaceColor == color)
                    value++;

                if (BottomRow.Left.FaceColor == color)
                    value++;

                if (BottomRow.Centre.FaceColor == color)
                    value++;

                if (BottomRow.Right.FaceColor == color)
                    value++;

                return value;
            }
        }
    }
}
