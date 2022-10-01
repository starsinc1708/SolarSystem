using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _1lab
{
    public partial class ParamsForm : Form
    {
        public int planetCounter = 0;
        public double simulationStep = 0;
        public double simulationTime = 0;
        public int chosenMethod = -1;
        public List<Planet> planets = new List<Planet>();

        public ParamsForm()
        {
            InitializeComponent();
            systemDataGridView.RowHeadersVisible = false;
        }

        private void tableFill()
        {
            systemDataGridView.Columns[0].HeaderCell.Value = planetCounter.ToString();

            for (int i = 0; i < planetCounter; i++)
            {
                systemDataGridView.Rows.Add();
            }
            double prevX = 0;

            for (int i = 0; i < planetCounter; ++i)
            {
                systemDataGridView.Rows[i].Cells[0].Value = i;

                if (i < 3)
                {
                    prevX = i * 149500000000;
                    systemDataGridView.Rows[i].Cells[1].Value = (prevX).ToString();
                }
                else
                {
                    prevX = i * prevX / (i - 1.0);
                    systemDataGridView.Rows[i].Cells[1].Value = (prevX).ToString();
                }

                systemDataGridView.Rows[i].Cells[2].Value = (0).ToString();

                systemDataGridView.Rows[i].Cells[3].Value = (0).ToString();



                if (i != 0)
                {
                    systemDataGridView.Rows[i].Cells[4].Value = (23297.870487037 * Math.Pow(0.78, i - 1)).ToString();
                    systemDataGridView.Rows[i].Cells[5].Value = (i * 6.083e24).ToString();
                }
                else
                {
                    systemDataGridView.Rows[i].Cells[4].Value = (0).ToString();
                    systemDataGridView.Rows[0].Cells[5].Value = (1.2166e30).ToString();
                }
            }
        }

        private void acceptParamsButton_Click(object sender, EventArgs e)
        {
            planets.Clear();
            simulationStep = Double.Parse(simulationStepTimeBox.Text.ToString());
            simulationTime = Double.Parse(modelingTimeBox.Text.ToString());
            if (EulerMethodRadioButton.Checked)
            {
                chosenMethod = 0;
            }
            if (CramerEulerMethodRadioButton.Checked)
            {
                chosenMethod = 1;
            }
            if (VerletMethodRadioButton.Checked)
            {
                chosenMethod = 2;
            }
            if (BeemanMethodRadioButton.Checked)
            {
                chosenMethod = 3;
            }
            for (int i = 0; i < systemDataGridView.Rows.Count; i++)
            {
                // int num, double vx, double vy, double x, double y, double mass, double d
                planets.Add(new Planet(Int32.Parse(systemDataGridView.Rows[i].Cells[0].Value.ToString()),
                    Double.Parse(systemDataGridView.Rows[i].Cells[3].Value.ToString()),
                    Double.Parse(systemDataGridView.Rows[i].Cells[4].Value.ToString()),
                    Double.Parse(systemDataGridView.Rows[i].Cells[1].Value.ToString()),
                    Double.Parse(systemDataGridView.Rows[i].Cells[2].Value.ToString()),
                    Double.Parse(systemDataGridView.Rows[i].Cells[5].Value.ToString()), 10));
            }
            this.Visible = false;
        }

        private void ParamsForm_Load(object sender, EventArgs e)
        {

        }

        private void createSystemButton_Click(object sender, EventArgs e)
        {
            if (planetCounter == 0)
            {
                planetCounter = (int)planetCountNumericUpDown.Value;
                tableFill();
            }
            else
            {
                for (int i = 0; i < planetCounter; i++)
                {
                    systemDataGridView.Rows.Clear();
                }
                planetCounter = (int)planetCountNumericUpDown.Value;
                tableFill();
            }


        }
    }
}
