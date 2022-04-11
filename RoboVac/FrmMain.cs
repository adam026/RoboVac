using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboVac
{
    public partial class FrmMain : Form
    {
        public class RoomCell : Button
        {
            public (int x, int y) PositionInMatrix { get; set; }
            public bool Obstacle { get; set; } = false;
            public bool IsClean { get; set; } = false;

        }

        static Random rnd = new Random();
        public RoomCell[,] Matrix { get; set; }

        public int MatrixWidth { get; set; }
        public int MatrixHeight { get; set; }
        public int MatrixScale { get; set; }
        public int NoObs { get; set; }

        public Tuple<int,int,int> ActualRoboVacPosition { get; set; }
        public Dictionary<int, KeyValuePair<int,int>> BackTracked = new Dictionary<int, KeyValuePair<int, int>>();
        public Dictionary<int,KeyValuePair<int,int>> Visited = new Dictionary<int, KeyValuePair<int,int>>();

        public int ClearCounter = 1;

        public FrmMain(int matrixWidth, int matrixHeight, int matrixScale,int noObs)
        {
            MatrixWidth = matrixWidth;
            MatrixHeight = matrixHeight;
            MatrixScale = matrixScale;
            NoObs = noObs;

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetUpMatrix(MatrixHeight, MatrixWidth);
            SetUpObstacles(NoObs);
            PlaceRoboVac();
            this.CenterToScreen();
        }

        private void MoveTheRobot(Tuple<int,int,int> actualRVP)
        {
            if(!Visited.Values.Contains(new KeyValuePair<int, int>(actualRVP.Item1, actualRVP.Item2)))
                Visited.Add(Visited.Count, new KeyValuePair<int, int>(actualRVP.Item1, actualRVP.Item2));


            var actualX = actualRVP.Item1;
            var actualY = actualRVP.Item2;
            var actualDir = actualRVP.Item3;

            int minx = Math.Max(actualX - 1, 0);
            int maxx = Math.Min(actualX + 1, Matrix.GetLength(0) - 1);
            int miny = Math.Max(actualY - 1, 0);
            int maxy = Math.Min(actualY + 1, Matrix.GetLength(1) - 1);

            for (int i = 0; i <= 4; i++)
            {
                int newX = actualX;
                int newY = actualY;
                int newDirection = (actualDir + i) % 4;
                if (newDirection == 0) newX -= 1;
                else if (newDirection == 1) newY += 1;
                else if (newDirection == 2) newX += 1;
                else if (newDirection == 3) newY -= 1;


                if (i == 4)
                {
                    var prevPosition = Visited.Single(x => x.Key == Visited.Count - 2).Value;
                    var backX = prevPosition.Key;
                    var backY = prevPosition.Value;
         
                    ActualRoboVacPosition = Tuple.Create<int, int, int>(backX, backY, newDirection + 1);
                    if (Matrix[backX, backY].BackgroundImage != Properties.Resources.robovac)
                        Matrix[backX, backY].BackgroundImage = Properties.Resources.robovac;
                    Matrix[actualX, actualY].BackgroundImage = null;
                    if (Matrix[backX, backY].IsClean == false)
                    {
                        Matrix[backX, backY].IsClean = true;
                        ClearCounter++;
                    }
                    if (Matrix[backX, backY].BackColor != Color.Green)
                        Matrix[backX, backY].BackColor = Color.Green;
                    var lastelement = Visited.Single(x => x.Key == Visited.Count - 1).Value;
                    BackTracked.Add(BackTracked.Count, new KeyValuePair<int, int>(lastelement.Key, lastelement.Value));
                    Visited.Remove(Visited.Keys.Last());
                    break;
                }

                else if (newX < 0 || newY < 0 || newY > maxy || newX > maxx)
                {
                    newX = actualX;
                    newY = actualY;
                    continue;
                }

                

                else if (BackTracked.Values.Contains(new KeyValuePair<int, int>(newX, newY)) || Visited.Values.Contains(new KeyValuePair<int, int>(newX, newY)))
                {
                    continue;
                }

                else if ((!Matrix[newX, newY].Obstacle) && (!BackTracked.Values.Contains(new KeyValuePair<int, int>(newX, newY))))
                {
                    ActualRoboVacPosition = Tuple.Create(newX, newY, newDirection);
                    if (Matrix[newX, newY].BackgroundImage != Properties.Resources.robovac)
                        Matrix[newX, newY].BackgroundImage = Properties.Resources.robovac;
                    Matrix[newX, newY].IsClean = true;
                    ClearCounter++;
                    Matrix[newX, newY].BackColor = Color.Green;
                    Matrix[actualX, actualY].BackgroundImage = null;
                    break;
                }
            }

            var allCell = MatrixHeight * MatrixWidth;
            if (NoObs + ClearCounter  == allCell)
            {
                if(MessageBox.Show(
                    caption: "All Clear",
                    text: "The room is clear!",
                    buttons: MessageBoxButtons.OK) == DialogResult.OK)
               
                {
                    this.Dispose();
                }
            }

        }

        private Tuple<int,int,int> PlaceRoboVac()
        {
            int x = rnd.Next(Matrix.GetLength(0));
            int y = rnd.Next(Matrix.GetLength(1));
            int dir = 0;

            if (!Matrix[x, y].Obstacle)
            {
                Matrix[x, y].BackgroundImage = Properties.Resources.robovac;
                Matrix[x, y].IsClean = true;
                Matrix[x, y].BackColor = Color.Green;  
            }
            return ActualRoboVacPosition = Tuple.Create<int, int, int>(x, y, dir);

            
        }

        private void SetUpObstacles(int noObs)
        {
            int c = 0;
            while (c < noObs)
            {
                int x = rnd.Next(Matrix.GetLength(0));
                int y = rnd.Next(Matrix.GetLength(1));

                if(!Matrix[x,y].Obstacle)
                {
                    Matrix[x, y].Obstacle = true;
                    
                    c++;
                }
                Matrix[x, y].BackgroundImage = Properties.Resources.obstacle;
            }
        }

        private void SetUpMatrix(int col, int row)
        {
            Matrix = new RoomCell[col, row];

            for (int x = 0; x < Matrix.GetLength(0); x++)
            {
                for (int y = 0; y < Matrix.GetLength(1); y++)
                {
                    Matrix[x, y] = new RoomCell()
                    {
                        Bounds = new Rectangle(
                            x: x * MatrixScale,
                            y: y * MatrixScale,
                            width: MatrixScale,
                            height: MatrixScale
                            ),
                        PositionInMatrix = (x, y),
                        BackgroundImageLayout = ImageLayout.Zoom
                        
                    };

                    Controls.Add(Matrix[x, y]);

                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            btnClean.Visible = false;
            var allCell = MatrixHeight * MatrixWidth;

            while (NoObs + ClearCounter != allCell)
            {
                MoveTheRobot(ActualRoboVacPosition);
                Refresh();
                Thread.Sleep(500);
            }

            //MoveTheRobot(ActualRoboVacPosition);


        }
    }
}
