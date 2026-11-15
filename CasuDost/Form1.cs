using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CasuDost
{

	public partial class Form1 : Form
	{
		public int celkem = 0;
		public int sleva = 0;

		public Dictionary<DateTime, List<int>> zabrane = new Dictionary<DateTime, List<int>>();
		public Dictionary<string, int> slevy = new Dictionary<String, int>();

		public Form1()
		{
			InitializeComponent();
			slevy.Add("darkeszyLEC", 99);
			slevy.Add("supersleva", 10);
			slevy.Add("maturita", 15);
			slevy.Add("cd2024", 5);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dateTimePicker.Value = DateTime.Today;
			dateTimePicker.MinDate = DateTime.Today;
		}

		public int updatePrice()
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

			int final = (celkem * 200 + cena) - (celkem * 200 + cena) / 100 * sleva;

			labelCena.Text = $"{final} Kč";
			return final;
		}

		// SEDADLA BUTTONI
		private void button1_Click(object sender, EventArgs e)
		{
			Control controlka = (Control)sender;
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
			string metoda = ""; 
			foreach (RadioButton m in groupBoxPlatby.Controls)
			{
				if (m.Checked)
				{
					metoda = m.Text;
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

			if (!invalid)
			{
				Platba.platebniMetoda plMet = Platba.platebniMetoda.GPAY;
				switch (metoda)
				{
					case "Bankovní převod":
						plMet = Platba.platebniMetoda.BANKA; break;
					case "PayPal":
                        plMet = Platba.platebniMetoda.PAYPAL; break;
					case "Paysafecard":
                        plMet = Platba.platebniMetoda.PSC; break;
					case "SMS":
                        plMet = Platba.platebniMetoda.SMS; break;
					case "Bitcoin":
                        plMet = Platba.platebniMetoda.BTC; break;
					case "Google Pay":
                        plMet = Platba.platebniMetoda.GPAY; break;

                }

				Platba platba = new Platba(updatePrice(), $"{textBoxJmeno.Text} {textBoxPrijmeni.Text}", textBoxTelefon.Text, plMet);
				platba.ShowDialog();
			}
		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			celkem = 0;
			updatePrice();
			if(zabrane.Keys.Contains(dateTimePicker.Value))
			{
				Control.ControlCollection sedadla = groupBoxSedadla.Controls;
				Random rand = new Random();

				List<int> list = zabrane[dateTimePicker.Value];

				int cislo = 1;
				foreach (Control sedadlo in sedadla)
				{
					sedadlo.Text = cislo.ToString();

					if (list.Contains(cislo))
					{
						sedadlo.BackColor = Color.Red;
					}
					else
					{
						sedadlo.BackColor = Color.White;
					}
					cislo++;
				}
			}
			else
			{
				Control.ControlCollection sedadla = groupBoxSedadla.Controls;
				Random rand = new Random();

				List<int> list = new List<int>();

				int cislo = 1;
				foreach (Control sedadlo in sedadla)
				{
					sedadlo.Text = cislo.ToString();
					cislo++;

					if (rand.Next(1, 6) == 1)
					{
						list.Add(int.Parse(sedadlo.Text));
						sedadlo.BackColor = Color.Red;
					}
					else
					{
						sedadlo.BackColor = Color.White;
					}
				}
				zabrane.Add(dateTimePicker.Value, list);
			}
		}

		private void textBoxSleva_TextChanged(object sender, EventArgs e)
		{
			if(slevy.ContainsKey(textBoxSleva.Text)) {
				sleva = slevy[textBoxSleva.Text];
				labelSleva.Text = $"Sleva {sleva}% uplatněna!";
			}
			else
			{
				labelSleva.Text = "Neplatný kód";
				sleva = 0;
			}
			updatePrice();
		}
	}
}
