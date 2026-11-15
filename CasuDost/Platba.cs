using System;
using System.Drawing;
using System.Windows.Forms;

namespace CasuDost
{
    public partial class Platba : Form
    {
        Control.ControlCollection specialElements;
        string text;
        platebniMetoda platMet;

        public enum platebniMetoda
        {
            GPAY,
            BTC,
            SMS,
            PSC,
            BANKA,
            PAYPAL
        }

        public Platba(int castka, string jmeno, string cislo, platebniMetoda plMet)
        {
            InitializeComponent();
            platMet = plMet;
            specialElements = new Control.ControlCollection(this)
            {
                pictureBoxSMS,
                pictureBoxBanka,
                pictureBoxBitcoin,
                pictureBoxGooglePay,
                pictureBoxPSC,
                pictureBoxPayPal,
                labelInstrukce,
                labelPSCkod,
                textBoxPSC,
            };

            setToDefault();

            labelCastka.Text = castka.ToString() + " Kč";
            labelOdesilatel.Text = jmeno;

            
            switch(plMet)
            {
                case platebniMetoda.GPAY:
                    pictureBoxGooglePay.Visible = true;
                    break;
                case platebniMetoda.BTC:
                    pictureBoxBitcoin.Visible = true;
                    break;
                case platebniMetoda.SMS:
                    pictureBoxSMS.Visible = true;
                    labelInstrukce.Visible = true;;
                    labelInstrukce.Text = $"Pošlete SMS ve tvaru \"CD JIZPL24\" na číslo 365 24\r\nSMS odesílejte z čísla: {cislo}\r\n\r\nPo odeslání klikněte na tlačítko \"Potvrdit\"\r\n";

                    text = "SMS nebyla zaznamenána. Zkuste to prosím za okamžik.";
                    button1.Text = "Potvrdit";
                    break;
                case platebniMetoda.PSC:
                    pictureBoxPSC.Visible = true;
                    labelPSCkod.Visible = true;
                    textBoxPSC.Visible = true;
                    textBoxPSC.Text = "";
                    text = "Zadaný kód je neplatný nebo nemá dostatečný zůstatek";
                    break;
                case platebniMetoda.PAYPAL:
                    pictureBoxPayPal.Visible = true;
                    break;
                case platebniMetoda.BANKA:
                    pictureBoxBanka.Visible = true;
                    break;
            }
            
        }

        private void setToDefault()
        {
            button1.Text = "Zaplatit";
            text = "Platba zamítnuta z důvodu nedostatku finančích prostředků";
            foreach (Control item in specialElements)
            {
                item.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(platMet.Equals(platebniMetoda.PSC) && textBoxPSC.Text.Length < 1)
            {
                labelPSCkod.ForeColor = Color.Red;
                return;
            }

            MessageBox.Show(text, "Stav platby", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
