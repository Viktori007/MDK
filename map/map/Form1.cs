using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class map : Form
    {
        public map()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = " Checkpoint 1";
            LandmarkName.Text = "Новодевичей монастырь";
            DrinksPaint.Visible = false; DrinksText.Visible = false;
            EnergyBarsPaint.Visible = false; EnergyBarsText.Visible = false;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Начало старта";
            LandmarkName.Text = "Часовой чонго марофон";
            Landmark.Visible = false; ServicesProvided.Visible = false;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }

        private void Checkpoint1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void start1_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Гонка началась";
            LandmarkName.Text = "42km полный марафон";
            Landmark.Visible = false; ServicesProvided.Visible = false;
            DrinksPaint.Visible = false; DrinksText.Visible = false;
            EnergyBarsPaint.Visible = false; EnergyBarsText.Visible = false;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }

        private void point2_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 2";
            LandmarkName.Text = "Новодевичей монастырь";
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = true; MedicalText.Visible = true;
        }

        private void point3_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 3";
            LandmarkName.Text = "Метро Киевская";
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }

        private void point4_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 4";
            LandmarkName.Text = "МИД";
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = true; MedicalText.Visible = true;

            MedicalPaint.Location= new Point(16, 292);
        }

        private void point5_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 5";
            LandmarkName.Text = "Парк Горького";
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 6";
            LandmarkName.Text = "Здания РАН";
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 7";
            LandmarkName.Text = "Метро Воробевы горы";
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = true; MedicalText.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Веселый старт";
            LandmarkName.Text = "5 км веселого бега";
            Landmark.Visible = false; ServicesProvided.Visible = false;
            DrinksPaint.Visible = false; DrinksText.Visible = false;
            EnergyBarsPaint.Visible = false; EnergyBarsText.Visible = false;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 8";
            LandmarkName.Text = "шшшшш";
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = true; MedicalText.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InfaText_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }
    }
}