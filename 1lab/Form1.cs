using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace _1lab
{
    public partial class Form1 : Form
    {
        Graphics g;
        public double simulation_step;
        public double simulation_len;
        private List<Planet> planets = new List<Planet>();
        Rectangle background;
        private const double AE = 149.5e6 * 1000;
        private double SCALE = 1 / AE;
        private const double SpeedConst = 23297.8705;
        private const double G = 6.67430e-11;
        private bool isStopped = false;
        private int chosenMethod = -1;

        private ParamsForm paramsForm { get; set; }

        public Form1()
        {
            paramsForm = new ParamsForm();
            InitializeComponent();
            g = CreateGraphics();
            background = new Rectangle(270, 40, Width - 316, Height - 100);
            paramsToolStripMenuItem.Available = false;
            stopPlaySimulationButton.Available = false;
            startModelToolStripMenuItem.Available = false;
        }

        private void startModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            planets.Clear();
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
            paramsToolStripMenuItem.Available = true;
            stopPlaySimulationButton.Available = true;
            isStopped = false;
            stopPlaySimulationButton.Text = "■";
            timer1.Start();

        }

        private void paramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            planets.Clear();
            paramsForm.Visible = true;
        }

        private void createSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startModelToolStripMenuItem.Available = true;
            timer1.Stop();
            paramsForm.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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

            if (simulation_len < 0) currTimeTextBox.Text = (0).ToString();
            else currTimeTextBox.Text = simulation_len.ToString();

            if (simulation_len <= 0)
            {
                stopPlaySimulationButton.Available = false;
                isStopped = false;
                timer1.Stop();
            }
        }

        private void beemanMethod()
        {

        }

        private void verletMethod()
        {

        }

        private void cramerEulerMethod()
        {
            int cirlceOldX = 0;
            int cirlceOldY = 0;

            for (int i = 0; i < planets.Count; i++)
            {
                cirlceOldX = (int)(planets[i].x * SCALE * (260 / planets.Count) + background.X + (background.Width - planets[i].D) / 2);
                cirlceOldY = (int)(planets[i].y * SCALE * (260 / planets.Count) + background.Y + (background.Height - planets[i].D) / 2);

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

        private void eulerMethod()
        {
            
        }

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

    }
}
