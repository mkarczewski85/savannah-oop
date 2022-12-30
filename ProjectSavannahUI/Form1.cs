using ProjectSavannah.domain.animal;
using ProjectSavannah.simulation;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ProjectSavannahUI
{
    public partial class SavannahMain : Form
    {
        private int _cellSize;
        private int _density;
        public Simulation simulation;
        

        public SavannahMain()
        {
            InitializeComponent();
        }

        private void SavannahMain_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / speedValue.Value;
            _cellSize = (int)sizeValue.Value;
            _density = (int)densityValue.Value;
            _initializeSimulation();
            Render();
        }

        private void Reset()
        {
            timer1.Enabled = false;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            _initializeSimulation();
            Render();
        }

        private void _initializeSimulation()
        {
            simulation = new Simulation(pictureBox1.Width / _cellSize, pictureBox1.Height / _cellSize, _density);
            simulation.Initialize();
        }

        private void Render()
        {
            using (var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
            using (var gfx = Graphics.FromImage(bmp))
            {
                gfx.Clear(ColorTranslator.FromHtml("#2f3539"));
                var world = simulation.World;
                var cellSize = new Size(_cellSize, _cellSize);

                for (int col = 0; col < world.xSize; col++)
                {
                    for (int row = 0; row < world.ySize; row++)
                    {
                        var cell = world.GetCell(col, row);
                        if (!cell.IsEmpty())
                        {
                            var cellLocation = new Point(col * _cellSize, row * _cellSize);
                            var cellRect = new Rectangle(cellLocation, cellSize);
                            gfx.FillRectangle(resolveCellBrush(cell), cellRect);
                        }
                    }
                }

                pictureBox1.Image?.Dispose();
                pictureBox1.Image = (Bitmap)bmp.Clone();
            }
        }

        private Brush resolveCellBrush(Cell cell) 
        {
            Color brushColor = resolveCellBrushColor(cell);
            HatchStyle? style = resolveCellBurshStyle(cell);
            if (style == null) return new SolidBrush(brushColor);
            return new HatchBrush((HatchStyle)style, Color.Black, brushColor);
        }

        private Color resolveCellBrushColor(Cell cell)
        {
            switch (cell.Mammal)
            {
                case Lion _:
                    return Color.OrangeRed;
                case Antelope _:
                    return Color.Gold;
                case Hyena _:
                    return Color.Gray;
                default:
                    return Color.White;
            }
        }

        private HatchStyle? resolveCellBurshStyle(Cell cell)
        {
            switch (cell)
            {
                case Cell when cell.Bird != null && cell.Reptile == null:
                    return HatchStyle.Wave;
                case Cell when cell.Bird == null && cell.Reptile != null:
                    return HatchStyle.Shingle;
                case Cell when cell.Bird != null && cell.Reptile != null:
                    return HatchStyle.SmallGrid;
                default:
                    return null;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            simulation.Forward();
            Render();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        { 
        
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnStart.Enabled = false;
            btnPause.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
        }

        private void sizeValue_ValueChanged(object sender, EventArgs e)
        {
            _cellSize = (int)sizeValue.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            _density = (int)densityValue.Value;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / speedValue.Value;
        }
    }
}