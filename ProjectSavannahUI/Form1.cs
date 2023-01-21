using ProjectSavannah.domain.animal;
using ProjectSavannah.simulation;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProjectSavannahUI
{
    public partial class SavannahMain : Form
    {
        private int _cellSize;
        private int _density;
        public Simulation simulation;

        private Action<string> _listViewEventCallback;

        public SavannahMain()
        {
            InitializeComponent();
        }

        private void SavannahMain_Load(object sender, EventArgs e)
        {
            _renderLegendSection();
            timer1.Interval = 1000 / speedValue.Value;
            _cellSize = (int)sizeValue.Value;
            _density = (int)densityValue.Value;
            _initializeSimulation();
            Render();
        }

        private void Reset()
        {
            timer1.Enabled = false;
            eventsList.Items.Clear();
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            _initializeSimulation();
            Render();
        }

        private void _initializeSimulation()
        {
            _listViewEventCallback = str => { 
                eventsList.Items.Add(str); 
                eventsList.SelectedIndex = eventsList.Items.Count - 1;
            };
            simulation = new Simulation(pictureBox1.Width / _cellSize, pictureBox1.Height / _cellSize, _density, _listViewEventCallback);
            simulation.Initialize();
        }

        private void _renderLegendSection()
        { 
            lionLegendBox.BackColor = Color.OrangeRed;
            antelopeLegendBox.BackColor = Color.Gold;
            hyenaLegendBox.BackColor = Color.Gray;
            _renderBirdLegendBox();
            _renderSnakeLegendBox();
            _renderSnakeBirdLegendBox();
        }

        private void _renderSnakeBirdLegendBox()
        {
            using (var bmp = new Bitmap(snakeBirdLegendBox.Width, snakeBirdLegendBox.Height))
            using (var gfx = Graphics.FromImage(bmp))
            using (var snakeBirdBrush = new HatchBrush(HatchStyle.SmallGrid, Color.Black, Color.White))
            {
                gfx.FillRectangle(snakeBirdBrush, new Rectangle(0, 0, snakeBirdLegendBox.Width, snakeBirdLegendBox.Height));
                snakeBirdLegendBox.Image = (Bitmap)bmp.Clone();
            }
        }

        private void _renderSnakeLegendBox()
        {
            using (var bmp = new Bitmap(snakeLegendBox.Width, snakeLegendBox.Height))
            using (var gfx = Graphics.FromImage(bmp))
            using (var snakeBrush = new HatchBrush(HatchStyle.Shingle, Color.Black, Color.White))
            {
                gfx.FillRectangle(snakeBrush, new Rectangle(0, 0, snakeLegendBox.Width, snakeLegendBox.Height));
                snakeLegendBox.Image = (Bitmap)bmp.Clone();
            }
        }

        private void _renderBirdLegendBox()
        {
            using (var bmp = new Bitmap(birdLegendBox.Width, birdLegendBox.Height))
            using (var gfx = Graphics.FromImage(bmp))
            using (var birdBrush = new HatchBrush(HatchStyle.DashedDownwardDiagonal, Color.Black, Color.White))
            {
                gfx.FillRectangle(birdBrush, new Rectangle(0, 0, birdLegendBox.Width, birdLegendBox.Height));
                birdLegendBox.Image = (Bitmap)bmp.Clone();
            }
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
                            var brush = resolveCellBrush(cell);
                            gfx.FillRectangle(brush, cellRect);
                        }
                    }
                }
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();
                pictureBox1.Image = (Bitmap)bmp.Clone();
            }
        }

        private Brush resolveCellBrush(Cell cell) 
        {
            Color brushColor = resolveCellBrushColor(cell);
            HatchStyle? style = resolveCellPatternStyle(cell);
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

        private HatchStyle? resolveCellPatternStyle(Cell cell)
        {
            switch (cell)
            {
                case Cell when cell.Bird != null && cell.Reptile == null:
                    return HatchStyle.DashedDownwardDiagonal;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}