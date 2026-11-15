using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasuDost
{

	public partial class Form1 : Form
	{
		public int celkem = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Control.ControlCollection sedadla = groupBoxSedadla.Controls;
			Random rand = new Random();

			int cislo = 1;
			foreach(Control sedadlo in sedadla)
			{
				sedadlo.Text = cislo.ToString();
				cislo++;

				if(rand.Next(1,6) == 1)
				{
					sedadlo.BackColor = Color.Red;
				}
				else
				{
					sedadlo.BackColor = Color.White;
				}
			}
		}

		public void updatePrice()
		{
			int cena = 0;
			if (checkBoxObcerstveni.Checked)
			{
				cena += 169;
			}

			if(checkBoxWifi.Checked)
			{
				cena += 50;
			}

			labelCena.Text = $"{celkem * 200 + cena} Kč";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Control controlka = (Control)sender;
			Console.WriteLine(controlka.BackColor.ToString());
			if(controlka.BackColor != Color.Red ) {
				if (controlka.BackColor == Color.White ) {
					controlka.BackColor = Color.LightBlue;
					celkem++;
				}
				else
				{
					celkem--;
					controlka.BackColor = Color.White;
				}
			}
			updatePrice();
		}

		private void checkBoxWifi_CheckedChanged(object sender, EventArgs e)
		{
			updatePrice();
		}

		private void checkBoxObcerstveni_CheckedChanged(object sender, EventArgs e)
		{
			updatePrice();
		}

		private void buttonObjednat_Click(object sender, EventArgs e)
		{
			bool invalid = false;
			if(textBoxJmeno.Text.Length == 0)
			{
				labelJmeno.ForeColor = Color.Red;
				invalid = true;
			}
			else
			{
				labelJmeno.ForeColor = Color.Black;
			}

			if (textBoxPrijmeni.Text.Length == 0)
			{
				labelPrijmeni.ForeColor = Color.Red;
				invalid = true;
			}
            else
            {
                labelPrijmeni.ForeColor = Color.Black;
            }

            if (textBoxTelefon.Text.Length == 0)
			{
				labelTelefon.ForeColor = Color.Red;
				invalid = true;
			}
            else
            {
                labelTelefon.ForeColor = Color.Black;
            }

            if (textBoxEmail.Text.Length == 0)
			{
				labelEmail.ForeColor = Color.Red;
				invalid = true;
			}
            else
            {
                labelEmail.ForeColor = Color.Black;
            }

            bool enabled = false;
			foreach (RadioButton metoda in groupBoxPlatby.Controls)
			{
                Console.WriteLine(metoda.Enabled);
                if (metoda.Checked)
				{
					enabled = true;
					break;
				}
			}

			if(!enabled) { 
				groupBoxPlatby.ForeColor = Color.Red;
				invalid = true;
			}
            else
            {
                groupBoxPlatby.ForeColor = Color.Black;
            }

            if (celkem == 0)
			{
				groupBoxSedadla.ForeColor = Color.Red;
				invalid = true;
			}
            else
            {
                groupBoxSedadla.ForeColor = Color.Black;
            }

            if (!checkBoxPodminky.Checked)
			{
				checkBoxPodminky.ForeColor = Color.Red;
				invalid = true;
			}
            else
            {
                checkBoxPodminky.ForeColor = Color.Black;
            }


        }
	}
}
