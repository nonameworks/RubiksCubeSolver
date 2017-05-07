using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RubiksCube.Model
{
    public class Cube : ViewModelBase
    {
        public Cube()
        {
            Front = new Side(Colors.Red, this);
            Back = new Side(Colors.White, this);
            Left = new Side(Colors.Green, this);
            Right = new Side(Colors.Orange, this);
            Top = new Side(Colors.Blue, this);
            Bottom = new Side(Colors.Yellow, this);
        }

        public Side Front { get; set; }
        public Side Back { get; set; }
        public Side Left { get; set; }
        public Side Right { get; set; }
        public Side Top { get; set; }
        public Side Bottom { get; set; }

        internal void RotateFace(Side side)
        {
            ReplaceCorners(side);
            ReplaceMiddles(side);

            Color color;
            if (side == Front)
            {
                color = ReplaceColor(Top.BottomRow.Left.FaceColor, Left.BottomRow.Right);
                color = ReplaceColor(color, Bottom.TopRow.Right);
                color = ReplaceColor(color, Right.TopRow.Left);
                color = ReplaceColor(color, Top.BottomRow.Left);
                
                color = ReplaceColor(Top.BottomRow.Centre.FaceColor, Left.CentreRow.Right);
                color = ReplaceColor(color, Bottom.TopRow.Centre);
                color = ReplaceColor(color, Right.CentreRow.Left);
                color = ReplaceColor(color, Top.BottomRow.Centre);

                color = ReplaceColor(Top.BottomRow.Right.FaceColor, Left.TopRow.Right);
                color = ReplaceColor(color, Bottom.TopRow.Left);
                color = ReplaceColor(color, Right.BottomRow.Left);
                color = ReplaceColor(color, Top.BottomRow.Right);
            }
            else if (side == Back)
            {
                color = ReplaceColor(Top.TopRow.Left.FaceColor, Right.BottomRow.Right);
                color = ReplaceColor(color, Bottom.BottomRow.Right);
                color = ReplaceColor(color, Left.TopRow.Left);
                color = ReplaceColor(color, Top.TopRow.Left);

                color = ReplaceColor(Top.TopRow.Centre.FaceColor, Right.CentreRow.Right);
                color = ReplaceColor(color, Bottom.BottomRow.Centre);
                color = ReplaceColor(color, Left.CentreRow.Left);
                color = ReplaceColor(color, Top.TopRow.Centre);

                color = ReplaceColor(Top.TopRow.Right.FaceColor, Right.TopRow.Right);
                color = ReplaceColor(color, Bottom.BottomRow.Left);
                color = ReplaceColor(color, Left.BottomRow.Left);
                color = ReplaceColor(color, Top.TopRow.Right);
            }
            else if (side == Top)
            {
                color = ReplaceColor(Front.TopRow.Left.FaceColor, Right.TopRow.Left);
                color = ReplaceColor(color, Back.TopRow.Left);
                color = ReplaceColor(color, Left.TopRow.Left);
                color = ReplaceColor(color, Front.TopRow.Left);

                color = ReplaceColor(Front.TopRow.Centre.FaceColor, Right.TopRow.Centre);
                color = ReplaceColor(color, Back.TopRow.Centre);
                color = ReplaceColor(color, Left.TopRow.Centre);
                color = ReplaceColor(color, Front.TopRow.Centre);

                color = ReplaceColor(Front.TopRow.Right.FaceColor, Right.TopRow.Right);
                color = ReplaceColor(color, Back.TopRow.Right);
                color = ReplaceColor(color, Left.TopRow.Right);
                color = ReplaceColor(color, Front.TopRow.Right);
            }
            else if (side == Bottom)
            {
                color = ReplaceColor(Front.BottomRow.Left.FaceColor, Left.BottomRow.Left);
                color = ReplaceColor(color, Back.BottomRow.Left);
                color = ReplaceColor(color, Right.BottomRow.Left);
                color = ReplaceColor(color, Front.BottomRow.Left);

                color = ReplaceColor(Front.BottomRow.Centre.FaceColor, Left.BottomRow.Centre);
                color = ReplaceColor(color, Back.BottomRow.Centre);
                color = ReplaceColor(color, Right.BottomRow.Centre);
                color = ReplaceColor(color, Front.BottomRow.Centre);

                color = ReplaceColor(Front.BottomRow.Right.FaceColor, Left.BottomRow.Right);
                color = ReplaceColor(color, Back.BottomRow.Right);
                color = ReplaceColor(color, Right.BottomRow.Right);
                color = ReplaceColor(color, Front.BottomRow.Right);
            }
            else if (side == Left)
            {
                color = ReplaceColor(Front.TopRow.Left.FaceColor, Top.TopRow.Left);
                color = ReplaceColor(color, Back.BottomRow.Right);
                color = ReplaceColor(color, Bottom.TopRow.Left);
                color = ReplaceColor(color, Front.TopRow.Left);

                color = ReplaceColor(Front.CentreRow.Left.FaceColor, Top.CentreRow.Left);
                color = ReplaceColor(color, Back.CentreRow.Right);
                color = ReplaceColor(color, Bottom.CentreRow.Left);
                color = ReplaceColor(color, Front.CentreRow.Left);

                color = ReplaceColor(Front.BottomRow.Left.FaceColor, Top.BottomRow.Left);
                color = ReplaceColor(color, Back.TopRow.Right);
                color = ReplaceColor(color, Bottom.BottomRow.Left);
                color = ReplaceColor(color, Front.BottomRow.Left);
            }
            else if (side == Right)
            {
                color = ReplaceColor(Front.TopRow.Right.FaceColor, Bottom.TopRow.Right);
                color = ReplaceColor(color, Back.BottomRow.Left);
                color = ReplaceColor(color, Top.TopRow.Right);
                color = ReplaceColor(color, Front.TopRow.Right);

                color = ReplaceColor(Front.CentreRow.Right.FaceColor, Bottom.CentreRow.Right);
                color = ReplaceColor(color, Back.CentreRow.Left);
                color = ReplaceColor(color, Top.CentreRow.Right);
                color = ReplaceColor(color, Front.CentreRow.Right);

                color = ReplaceColor(Front.BottomRow.Right.FaceColor, Bottom.BottomRow.Right);
                color = ReplaceColor(color, Back.TopRow.Left);
                color = ReplaceColor(color, Top.BottomRow.Right);
                color = ReplaceColor(color, Front.BottomRow.Right);
            }

            RaisePropertyChanged("Score");
        }

        private void ReplaceMiddles(Side side)
        {
            Color color;
            color = ReplaceColor(side.TopRow.Centre.FaceColor, side.CentreRow.Left);
            color = ReplaceColor(color, side.BottomRow.Centre);
            color = ReplaceColor(color, side.CentreRow.Right);
            color = ReplaceColor(color, side.TopRow.Centre);
        }

        private void ReplaceCorners(Side side)
        {
            Color color;
            color = ReplaceColor(side.TopRow.Right.FaceColor, side.TopRow.Left);
            color = ReplaceColor(color, side.BottomRow.Left);
            color = ReplaceColor(color, side.BottomRow.Right);
            color = ReplaceColor(color, side.TopRow.Right);
        }

        private Color ReplaceColor(Color source, Face destination)
        {
            var original = destination.FaceColor;
            destination.FaceColor = source;
            return original;
        }

        private Side GetSide(int index)
        {
            switch (index)
            {
                case 1: return Front;
                case 2: return Back;
                case 3: return Left;
                case 4: return Right;
                case 5: return Top;
                case 0: return Bottom;
                default: return new Side(Colors.Red, this);
            }
        }

        public RelayCommand ScrambleCommand
        {
            get
            {
                return new RelayCommand(() => 
                {
                    Random r = new Random();
                    for (int i = 0; i < 5; i++)
                    {
                        GetSide(r.Next(0, 6)).RotateCommand.Execute(null);
                    }
                });
            }
        }


        public int Score
        {
            get
            {
                var value = 0;
                for (int i = 0; i < 6; i++)
                {
                    value = value + GetSide(i).Score;                    
                }

                return value;
            }
        }

        public bool IsSolved
        {
            get
            {
                return Score == 9 * 6;
            }
        }
    }
}
