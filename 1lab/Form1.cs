using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _1lab
{
    public partial class Form1 : Form
    {
        Graphics g;
        public double simulation_step;
        public double allForce = 0;
        public double massCenterX = 0;
        public double massCenterY = 0;
        public double allMass = 0;
        public double simulation_len;
        private List<Planet> planets = new List<Planet>();
        Rectangle background;
        private const double AE = 149.5e9;
        private double SCALE = 1 / AE;
        private const double SpeedConst = 23297.8705;
        private const double G = 6.67430e-11;
        private bool isStopped = false;
        public bool isCreated = false;
        private int chosenMethod = -1;

        private ParamsForm paramsForm { get; set; }

        public Form1()
        {
            paramsForm = new ParamsForm(this);
            InitializeComponent();
            g = CreateGraphics();
            background = new Rectangle(270, 40, Width - 316, Height - 100);
            stopPlaySimulationButton.Available = false;
            startModelToolStripMenuItem.Available = false;
            var myCulture = new CultureInfo("ru-RU");
            myCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = myCulture;
            paramsForm.systemDataGridView.DefaultCellStyle.FormatProvider = myCulture;
        }

        // Начать Симуляцию
        private void startModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            planets.Clear();
            allForce = 0;
            massCenterX = 0;
            massCenterY = 0;
            allMass = 0;
            simulation_step = paramsForm.simulationStep;
            simulation_len = paramsForm.simulationTime;
            chosenMethod = paramsForm.chosenMethod;
            for (int i = 0; i < paramsForm.planets.Count; i++)
            {
                planets.Add(new Planet(paramsForm.planets[i].num,
                    paramsForm.planets[i].Vx,
                    paramsForm.planets[i].Vy,
                    paramsForm.planets[i].x,
                    paramsForm.planets[i].y,
                    paramsForm.planets[i].mass,
                    paramsForm.planets[i].D));
            }

            Rectangle background = new Rectangle(270, 40, Width - 316, Height - 100);
            g.FillRectangle(Brushes.Black, background);
            stopPlaySimulationButton.Available = true;
            isStopped = false;
            stopPlaySimulationButton.Text = "■";
            timer1.Start();

        }

        // Создать Систему / Изменить Параметры
        private void createSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startModelToolStripMenuItem.Available = true;
            planets.Clear();
            timer1.Stop();
            paramsForm.Visible = true;
        }


        // Тик Таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Black, 10);
            g.DrawLine(pen, 185, 0, 185, Height - 345);
            g.DrawLine(pen, 190, Height - 345, 0, Height - 345);

            switch (chosenMethod)
            {
                case 0:
                    // метод Эйлера
                    eulerMethod();
                    label5.Text = "метод Эйлера";
                    break;
                case 1:
                    // метод Эйлера-Крамера
                    cramerEulerMethod();
                    label5.Text = "метод Эйлера-Крамера";
                    break;
                case 2:
                    // метод Верле
                    verletMethod();
                    label5.Text = "метод Верле";
                    break;
                case 3:
                    // метод Бимана
                    beemanMethod();
                    label5.Text = "метод Бимана";
                    break;
            }

            simulation_len -= simulation_step;

            // Оставшееся время симуляции
            if (simulation_len < 0) currTimeTextBox.Text = (0).ToString();
            else currTimeTextBox.Text = simulation_len.ToString();

            // Общая Энергия
            foreach (Planet planet in planets)
            {
                allForce = (planet.mass * (Math.Pow(planet.Vy, 2) + Math.Pow(planet.Vx, 2))) / 2;
            }
            allForceTextBox.Text = allForce.ToString();

            // Центр масс Vx
            foreach (Planet planet in planets)
            {
                massCenterX += planet.mass * planet.x;
                allMass += planet.mass;
            }
            massCenterX /= allMass * 1e9;
            massCenterXTextBox.Text = massCenterX.ToString();
            massCenterX = 0;

            // Центр масс Vy
            foreach (Planet planet in planets)
            {
                massCenterY += planet.mass * planet.y;
            }
            massCenterY /= allMass * 1e9;
            massCenterYTextBox.Text = massCenterY.ToString();
            massCenterY = 0;

            if (simulation_len <= 0)
            {
                stopPlaySimulationButton.Available = false;
                isStopped = false;
                timer1.Stop();
            }
        }

        // todo
        private void beemanMethod()
        {
            int cirlceOldX = 0;
            int cirlceOldY = 0;

            for (int i = 0; i < planets.Count; i++)
            {
                cirlceOldX = (int)(planets[i].x * SCALE * (260 / planets.Count) + background.X + (background.Width - planets[i].D) / 2);
                cirlceOldY = (int)(planets[i].y * SCALE * (260 / planets.Count) + background.Y + (background.Height - planets[i].D) / 2);

                planets[i].picX = cirlceOldX;
                planets[i].picY = cirlceOldY;

                g.FillEllipse(Brushes.White,
                    cirlceOldX,
                    cirlceOldY,
                    planets[i].D, planets[i].D);

                calculateV(planets[i]);

                planets[i].x += planets[i].Vx * simulation_step;
                planets[i].y += planets[i].Vy * simulation_step;

                g.FillEllipse(Brushes.Red,
                    (int)(planets[i].x * SCALE * (260 / planets.Count) + background.X + (background.Width - planets[i].D * 0.8f) / 2),
                    (int)(planets[i].y * SCALE * (260 / planets.Count) + background.Y + (background.Height - planets[i].D * 0.8f) / 2),
                    planets[i].D * 0.8f, planets[i].D * 0.8f);

                Thread.Sleep(2);
            }
        }

        // todo
        private void verletMethod()
        {
            int cirlceOldX = 0;
            int cirlceOldY = 0;

            for (int i = 0; i < planets.Count; i++)
            {
                cirlceOldX = (int)(planets[i].x * SCALE * (260 / planets.Count) + background.X + (background.Width - planets[i].D) / 2);
                cirlceOldY = (int)(planets[i].y * SCALE * (260 / planets.Count) + background.Y + (background.Height - planets[i].D) / 2);

                planets[i].picX = cirlceOldX;
                planets[i].picY = cirlceOldY;

                g.FillEllipse(Brushes.White,
                    cirlceOldX,
                    cirlceOldY,
                    planets[i].D, planets[i].D);

                calculateV(planets[i]);

                planets[i].x += planets[i].Vx * simulation_step;
                planets[i].y += planets[i].Vy * simulation_step;

                g.FillEllipse(Brushes.Red,
                    (int)(planets[i].x * SCALE * (260 / planets.Count) + background.X + (background.Width - planets[i].D * 0.8f) / 2),
                    (int)(planets[i].y * SCALE * (260 / planets.Count) + background.Y + (background.Height - planets[i].D * 0.8f) / 2),
                    planets[i].D * 0.8f, planets[i].D * 0.8f);

                Thread.Sleep(2);
            }
        }

        // Метод Эйлера-Крамера
        private void cramerEulerMethod()
        {
            int cirlceOldX = 0;
            int cirlceOldY = 0;

            for (int i = 0; i < planets.Count; i++)
            {
                cirlceOldX = (int)(planets[i].x * SCALE * (260 / planets.Count) + background.X + (background.Width - planets[i].D) / 2);
                cirlceOldY = (int)(planets[i].y * SCALE * (260 / planets.Count) + background.Y + (background.Height - planets[i].D) / 2);

                planets[i].picX = cirlceOldX;
                planets[i].picY = cirlceOldY;

                calculateV(planets[i]);

                planets[i].x += planets[i].Vx * simulation_step;
                planets[i].y += planets[i].Vy * simulation_step;

                g.FillEllipse(Brushes.White,
                    cirlceOldX,
                    cirlceOldY,
                    planets[i].D, planets[i].D);

                if (!(cirlceOldX >= (background.X + background.Width - planets[i].D / 4) ||
                    cirlceOldX <= background.X + planets[i].D / 4 ||
                    cirlceOldY >= (background.Y + background.Height - planets[i].D / 4) ||
                    cirlceOldY <= background.Y + planets[i].D / 4))
                {

                    g.FillEllipse(Brushes.Red,
                    (int)(planets[i].x * SCALE * (260 / planets.Count) + background.X + (background.Width - planets[i].D * 0.8f) / 2),
                    (int)(planets[i].y * SCALE * (260 / planets.Count) + background.Y + (background.Height - planets[i].D * 0.8f) / 2),
                    planets[i].D * 0.8f, planets[i].D * 0.8f);
                }

                Thread.Sleep(2);
            }

        }

        // Метод Эйлера
        private void eulerMethod()
        {
            int cirlceOldX = 0;
            int cirlceOldY = 0;

            for (int i = 0; i < planets.Count; i++)
            {
                cirlceOldX = (int)(planets[i].x * SCALE * (260 / planets.Count) + background.X + (background.Width - planets[i].D) / 2);
                cirlceOldY = (int)(planets[i].y * SCALE * (260 / planets.Count) + background.Y + (background.Height - planets[i].D) / 2);

                planets[i].picX = cirlceOldX;
                planets[i].picY = cirlceOldY;

                g.FillEllipse(Brushes.White,
                    cirlceOldX,
                    cirlceOldY,
                    planets[i].D, planets[i].D);

                planets[i].x += planets[i].Vx * simulation_step;
                planets[i].y += planets[i].Vy * simulation_step;

                calculateV(planets[i]);
                if (!(cirlceOldX >= (background.X + background.Width - planets[i].D / 4) ||
                    cirlceOldX <= background.X + planets[i].D / 4 ||
                    cirlceOldY >= (background.Y + background.Height - planets[i].D / 4) ||
                    cirlceOldY <= background.Y + planets[i].D / 4))
                {
                    g.FillEllipse(Brushes.Red,
                    (int)(planets[i].x * SCALE * (260 / planets.Count) + background.X + (background.Width - planets[i].D * 0.8f) / 2),
                    (int)(planets[i].y * SCALE * (260 / planets.Count) + background.Y + (background.Height - planets[i].D * 0.8f) / 2),
                    planets[i].D * 0.8f, planets[i].D * 0.8f);
                }
                Thread.Sleep(2);
            }
        }


        // Расчёт ускорения
        private void calculateV(Planet planet)
        {
            double FsumX = 0;
            double FsumY = 0;
            double F = 0;
            double dis_x = 0;
            double dis_y = 0;
            double dis = 0;

            for (int i = 0; i < planets.Count(); i++)
            {
                if (planet.num == i) continue;

                dis_x = planets[i].x - planet.x;
                dis_y = planets[i].y - planet.y;
                dis = Math.Sqrt(Math.Pow(dis_x, 2) + Math.Pow(dis_y, 2));

                F = G * planets[i].mass / Math.Pow(dis, 2);

                FsumX = F * dis_x / dis;
                FsumY = F * dis_y / dis;

                planet.Vx += FsumX * simulation_step;
                planet.Vy += FsumY * simulation_step;
            }
        }

        // Пауза
        private void stopPlaySimulationButton_Click(object sender, EventArgs e)
        {
            if (isStopped)
            {
                stopPlaySimulationButton.Text = "■";
                timer1.Start();
                isStopped = false;
            }
            else
            {
                stopPlaySimulationButton.Text = "▶";
                timer1.Stop();
                isStopped = true;

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 10);
            g.DrawLine(pen, 185, 0, 185, Height - 345);
            g.DrawLine(pen, 190, Height - 345, 0, Height - 345);
        }

        // Сохранить Систему
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (paramsForm.systemDataGridView.Rows.Count > 0)
            {

                saveFileDialog1.Filter = "CSV (*.csv)|*.csv";
                saveFileDialog1.FileName = "Output.csv";
                bool fileError = false;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        try
                        {
                            File.Delete(saveFileDialog1.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Диск недоступен." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = paramsForm.systemDataGridView.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[paramsForm.systemDataGridView.Rows.Count + 2];
                            for (int i = 0; i < columnCount; i++)
                            {
                                if (i == columnCount - 1)
                                {
                                    columnNames += paramsForm.systemDataGridView.Columns[i].HeaderText.ToString();
                                }
                                else
                                {
                                    columnNames += paramsForm.systemDataGridView.Columns[i].HeaderText.ToString() + ",";
                                }
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < paramsForm.systemDataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    if (j == columnCount - 1)
                                    {
                                        outputCsv[i] += paramsForm.systemDataGridView.Rows[i - 1].Cells[j].Value.ToString();
                                    }
                                    else
                                    {
                                        outputCsv[i] += paramsForm.systemDataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }
                            }
                            outputCsv[paramsForm.systemDataGridView.Rows.Count + 1] += paramsForm.simulationStep + ",";
                            outputCsv[paramsForm.systemDataGridView.Rows.Count + 1] += paramsForm.simulationTime;
                            File.WriteAllLines(saveFileDialog1.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Сохранение успешно!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка:" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Нечего сохранять!", "Info");
            }
        }

        // Открыть Систему
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV (*.csv)|*.csv";

            bool fileError = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!fileError)
                {
                    String[] str = File.ReadAllLines(openFileDialog1.FileName, Encoding.UTF8);
                    List<String[]> table_values = new List<String[]>();

                    for (int i = 0; i < str.Length; i++)
                    {
                        table_values.Add(str[i].Split(','));
                    }

                    int planetsCount = Int32.Parse(table_values[0][0]);

                    for (int i = 0; i < planetsCount; i++)
                    {
                        paramsForm.systemDataGridView.Rows.Clear();
                    }


                    paramsForm.systemDataGridView.Columns[0].HeaderCell.Value = planetsCount.ToString();

                    for (int i = 0; i < planetsCount; i++)
                    {
                        paramsForm.systemDataGridView.Rows.Add();
                    }

                    for (int i = 0; i < planetsCount; ++i)
                    {
                        paramsForm.systemDataGridView.Rows[i].Cells[0].Value = i;

                        paramsForm.systemDataGridView.Rows[i].Cells[1].Value = (Double.Parse(table_values[i + 1][1])).ToString();

                        paramsForm.systemDataGridView.Rows[i].Cells[2].Value = (Double.Parse(table_values[i + 1][2])).ToString();

                        paramsForm.systemDataGridView.Rows[i].Cells[3].Value = (Double.Parse(table_values[i + 1][3])).ToString();

                        paramsForm.systemDataGridView.Rows[i].Cells[4].Value = (Double.Parse(table_values[i + 1][4])).ToString();

                        paramsForm.systemDataGridView.Rows[i].Cells[5].Value = (Double.Parse(table_values[i + 1][5])).ToString();
                    }
                    paramsForm.simulationStep = Int32.Parse(table_values[table_values.Count - 1][0]);
                    paramsForm.simulationTime = Int32.Parse(table_values[table_values.Count - 1][1]);
                    paramsForm.acceptParamsButton_Click(this, e);
                }
            }
        }
    }

}
