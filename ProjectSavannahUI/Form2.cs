using ProjectSavannah.simulation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSavannahUI
{
    public partial class Form2 : Form
    {

        private Parameters _parameters = Parameters.GetInstance();

        public Form2()
        {
            InitializeComponent();

            waterUpDown.Value = (decimal)(_parameters.WaterSupplyCoverage * 100);
            plantsUpDown.Value = (decimal)(_parameters.PlantsSupplyCoverage * 100);

            lionRepUpDown.Value = (decimal)(_parameters.LionFertility * 100);
            antelopeRepUpDown.Value = (decimal)(_parameters.AntelopeFertility * 100);
            hyenaRepUpDown.Value = (decimal)(_parameters.HyenaFertility * 100);
            snakeRepUpDown.Value = (decimal)(_parameters.SnakeFertility * 100);
            birdRepUpDown.Value = (decimal)(_parameters.TokobirdFertility * 100);

            lionHuntSuccessUpDown.Value = (decimal)(_parameters.LionHuntSuccessProbability * 100);
            snakeBiteSuccessUpDown.Value = (decimal)(_parameters.SnakeBiteSuccessProbability * 100);
            birdCatchSuccessUpDown.Value = (decimal)(_parameters.TokobirdCatchSuccessProbability * 100);
        }

        private void waterUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.WaterSupplyCoverage = (double)(waterUpDown.Value / 100);
        }

        private void plantsUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.PlantsSupplyCoverage = (double)(plantsUpDown.Value / 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lionRepUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.LionFertility = (double)(lionRepUpDown.Value / 100);
        }

        private void antelopeRepUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.AntelopeFertility = (double)(antelopeRepUpDown.Value / 100);
        }

        private void hyenaRepUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.HyenaFertility = (double)(hyenaRepUpDown.Value / 100);
        }

        private void snakeRepUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.SnakeFertility = (double)(snakeRepUpDown.Value / 100);
        }

        private void birdRepUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.TokobirdFertility = (double)(birdRepUpDown.Value / 100);
        }

        private void lionHuntSuccessUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.LionHuntSuccessProbability = (double)(lionHuntSuccessUpDown.Value / 100);
        }

        private void snakeBiteSuccessUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.SnakeBiteSuccessProbability = (double)(snakeBiteSuccessUpDown.Value / 100);
        }

        private void birdCatchSuccessUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.TokobirdCatchSuccessProbability = (double)(birdCatchSuccessUpDown.Value / 100);
        }
    }
}
