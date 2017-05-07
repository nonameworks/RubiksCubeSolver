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
            this.color = color;
        }

        private Color color;
        Cube Cube { get; set; }
        public Row TopRow { get; set; }
        public Row CentreRow { get; set; }
        public Row BottomRow { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }

        public RelayCommand RotateCommand
        {
            get
            {
                return new RelayCommand(async () => { await Cube.RotateSideAsync(this); });
            }
        }

        public int Score
        {
            get
            {
                var value = 0;
                if (TopRow.Left.FaceColor == color)
                    value++;

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
