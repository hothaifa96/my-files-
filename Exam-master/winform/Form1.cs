using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
	public partial class Form1 : Form
	{
        int sec;
        Random r = new Random();
		int score = 0; int full = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			memorygamesfirstposition();
		}
		private void memorygamesfirstposition()
		{
			label1.Text = $"{r.Next(100)}";
			label2.Text = $"{r.Next(100)}";
			label3.Text = $"{r.Next(100)}";
			label4.Text = $"{r.Next(100)}";
			label5.Text = $"{r.Next(100)}";
			label1.Visible = true;
			label2.Visible = true;
			label3.Visible = true;
			label4.Visible = true;
			label5.Visible = true;
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
            textBox5.Text = "";
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
            textBox3.ForeColor = Color.Black;
            textBox4.ForeColor = Color.Black;
            textBox5.ForeColor = Color.Black;
        }

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				   == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("this game made in a Exam and its not perfect as it should be ");
		}

		private void startBt_Click(object sender, EventArgs e)
		{
            sec = 0;
            timer1.Start();
            
            if (full == 0)
            {
                textBox1.ForeColor = Color.Black;
                textBox2.ForeColor = Color.Black;
                textBox3.ForeColor = Color.Black;
                textBox4.ForeColor = Color.Black;
                textBox5.ForeColor = Color.Black;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                score = 0;
            }
            else MessageBox.Show("please start a new game !!!");
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
            time.Text = "timer";
            timer1.Stop();
            full = 0;
			score = 0;
			memorygamesfirstposition();
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
            if (textBox1.Text != "")
                full++;
            
			if (textBox1.Text == label1.Text)
			{
				
				score++;
				textBox1.ForeColor = Color.Green;
			}
			else
                textBox1.ForeColor = Color.Red;
			if (full == 5)
			{
				callit();

			}
		}

		private void textBox2_Leave(object sender, EventArgs e)
		{
			if (textBox2.Text != "")
				full++;
			if (textBox2.Text == label2.Text )
			{
				score++;
				textBox2.ForeColor = Color.Green;
			}
			else textBox2.ForeColor = Color.Red;
			if (full == 5)
			{
				callit();

			}
		}

		private void textBox3_Leave(object sender, EventArgs e)
		{
			if (textBox3.Text != "")
				full++;
			if (textBox3.Text == label3.Text)
			{
				score++;
				textBox3.ForeColor = Color.Green;
			}
			else textBox3.ForeColor = Color.Red;
			if (full == 5)
			{
				callit();

			}
		}

		private void textBox4_Leave(object sender, EventArgs e)
		{
			if (textBox4.Text != "")
				full++;
			if (textBox4.Text == label4.Text)
			{
				score++;
				textBox4.ForeColor = Color.Green;
			}
			else textBox4.ForeColor = Color.Red;
			if (full == 5)
			{
				callit();

			}
		}

		private void textBox5_Leave(object sender, EventArgs e)
		{
			if (textBox5.Text != "")
				full++;
			if (textBox5.Text == label5.Text)
			{
				score++;
				textBox5.ForeColor = Color.Green;
			}
			else textBox5.ForeColor = Color.Red;
			if (full == 5)
			{
				callit();

			}
		}

		private void callit()
		{
            timer1.Stop();
            if (score == 5 && sec < 10)
            {
                MessageBox.Show("amaizing you got them tight in " + sec);
                listBox1.Items.Add($"score :{score} in {sec} seconds");
            }
            else if (score == 5)
                MessageBox.Show("Yuoooofii you have them all right");
            else
                MessageBox.Show("oops !!you missed some");

			listBox1.Items.Add($"score :{score} within {sec} seconds");
            
            
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            time.Text = sec.ToString();

        }
    }
}
