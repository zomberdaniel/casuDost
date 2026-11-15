namespace CasuDost
{
    partial class Platba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Platba));
            this.pictureBoxGooglePay = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCastkaPlaceholder = new System.Windows.Forms.Label();
            this.labelCastka = new System.Windows.Forms.Label();
            this.labelPrijemcePH = new System.Windows.Forms.Label();
            this.labelOdesilatelPH = new System.Windows.Forms.Label();
            this.labelOdesilatel = new System.Windows.Forms.Label();
            this.labelPrijemce = new System.Windows.Forms.Label();
            this.pictureBoxBitcoin = new System.Windows.Forms.PictureBox();
            this.pictureBoxSMS = new System.Windows.Forms.PictureBox();
            this.pictureBoxPSC = new System.Windows.Forms.PictureBox();
            this.pictureBoxPayPal = new System.Windows.Forms.PictureBox();
            this.pictureBoxBanka = new System.Windows.Forms.PictureBox();
            this.labelInstrukce = new System.Windows.Forms.Label();
            this.textBoxPSC = new System.Windows.Forms.TextBox();
            this.labelPSCkod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGooglePay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBitcoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPayPal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanka)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGooglePay
            // 
            this.pictureBoxGooglePay.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGooglePay.Image")));
            this.pictureBoxGooglePay.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxGooglePay.Name = "pictureBoxGooglePay";
            this.pictureBoxGooglePay.Size = new System.Drawing.Size(246, 75);
            this.pictureBoxGooglePay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGooglePay.TabIndex = 0;
            this.pictureBoxGooglePay.TabStop = false;
            this.pictureBoxGooglePay.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(35, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zaplatit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCastkaPlaceholder
            // 
            this.labelCastkaPlaceholder.AutoSize = true;
            this.labelCastkaPlaceholder.Location = new System.Drawing.Point(32, 320);
            this.labelCastkaPlaceholder.Name = "labelCastkaPlaceholder";
            this.labelCastkaPlaceholder.Size = new System.Drawing.Size(67, 13);
            this.labelCastkaPlaceholder.TabIndex = 2;
            this.labelCastkaPlaceholder.Text = "K zaplacení:";
            // 
            // labelCastka
            // 
            this.labelCastka.AutoSize = true;
            this.labelCastka.Location = new System.Drawing.Point(105, 320);
            this.labelCastka.Name = "labelCastka";
            this.labelCastka.Size = new System.Drawing.Size(29, 13);
            this.labelCastka.TabIndex = 3;
            this.labelCastka.Text = "0 Kč";
            // 
            // labelPrijemcePH
            // 
            this.labelPrijemcePH.AutoSize = true;
            this.labelPrijemcePH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrijemcePH.Location = new System.Drawing.Point(32, 132);
            this.labelPrijemcePH.Name = "labelPrijemcePH";
            this.labelPrijemcePH.Size = new System.Drawing.Size(62, 13);
            this.labelPrijemcePH.TabIndex = 4;
            this.labelPrijemcePH.Text = "Příjemce:";
            // 
            // labelOdesilatelPH
            // 
            this.labelOdesilatelPH.AutoSize = true;
            this.labelOdesilatelPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdesilatelPH.Location = new System.Drawing.Point(32, 109);
            this.labelOdesilatelPH.Name = "labelOdesilatelPH";
            this.labelOdesilatelPH.Size = new System.Drawing.Size(69, 13);
            this.labelOdesilatelPH.TabIndex = 5;
            this.labelOdesilatelPH.Text = "Odesílatel:";
            // 
            // labelOdesilatel
            // 
            this.labelOdesilatel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelOdesilatel.Location = new System.Drawing.Point(96, 109);
            this.labelOdesilatel.Name = "labelOdesilatel";
            this.labelOdesilatel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelOdesilatel.Size = new System.Drawing.Size(185, 13);
            this.labelOdesilatel.TabIndex = 7;
            this.labelOdesilatel.Text = "Example Examplovsky";
            this.labelOdesilatel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrijemce
            // 
            this.labelPrijemce.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrijemce.Location = new System.Drawing.Point(96, 132);
            this.labelPrijemce.Name = "labelPrijemce";
            this.labelPrijemce.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPrijemce.Size = new System.Drawing.Size(185, 13);
            this.labelPrijemce.TabIndex = 8;
            this.labelPrijemce.Text = "ČasuDost s.r.o.";
            this.labelPrijemce.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxBitcoin
            // 
            this.pictureBoxBitcoin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBitcoin.Image")));
            this.pictureBoxBitcoin.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxBitcoin.Name = "pictureBoxBitcoin";
            this.pictureBoxBitcoin.Size = new System.Drawing.Size(246, 75);
            this.pictureBoxBitcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBitcoin.TabIndex = 9;
            this.pictureBoxBitcoin.TabStop = false;
            this.pictureBoxBitcoin.Visible = false;
            // 
            // pictureBoxSMS
            // 
            this.pictureBoxSMS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxSMS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSMS.Image")));
            this.pictureBoxSMS.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxSMS.Name = "pictureBoxSMS";
            this.pictureBoxSMS.Size = new System.Drawing.Size(246, 75);
            this.pictureBoxSMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSMS.TabIndex = 10;
            this.pictureBoxSMS.TabStop = false;
            this.pictureBoxSMS.Visible = false;
            // 
            // pictureBoxPSC
            // 
            this.pictureBoxPSC.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPSC.Image")));
            this.pictureBoxPSC.Location = new System.Drawing.Point(34, 12);
            this.pictureBoxPSC.Name = "pictureBoxPSC";
            this.pictureBoxPSC.Size = new System.Drawing.Size(246, 75);
            this.pictureBoxPSC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPSC.TabIndex = 11;
            this.pictureBoxPSC.TabStop = false;
            this.pictureBoxPSC.Visible = false;
            // 
            // pictureBoxPayPal
            // 
            this.pictureBoxPayPal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPayPal.Image")));
            this.pictureBoxPayPal.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxPayPal.Name = "pictureBoxPayPal";
            this.pictureBoxPayPal.Size = new System.Drawing.Size(246, 75);
            this.pictureBoxPayPal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPayPal.TabIndex = 12;
            this.pictureBoxPayPal.TabStop = false;
            this.pictureBoxPayPal.Visible = false;
            // 
            // pictureBoxBanka
            // 
            this.pictureBoxBanka.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBanka.Image")));
            this.pictureBoxBanka.Location = new System.Drawing.Point(34, 12);
            this.pictureBoxBanka.Name = "pictureBoxBanka";
            this.pictureBoxBanka.Size = new System.Drawing.Size(246, 75);
            this.pictureBoxBanka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBanka.TabIndex = 13;
            this.pictureBoxBanka.TabStop = false;
            this.pictureBoxBanka.Visible = false;
            // 
            // labelInstrukce
            // 
            this.labelInstrukce.AutoSize = true;
            this.labelInstrukce.Location = new System.Drawing.Point(32, 178);
            this.labelInstrukce.Name = "labelInstrukce";
            this.labelInstrukce.Size = new System.Drawing.Size(258, 52);
            this.labelInstrukce.TabIndex = 14;
            this.labelInstrukce.Text = "Pošlete SMS ve tvaru \"CD JIZPL24\" na číslo 365 24\r\nSMS odesílejte z čísla: {cisli" +
    "cko}\r\n\r\nPo odeslání klikněte na tlačítko \"Potvrdit\"\r\n";
            this.labelInstrukce.Visible = false;
            // 
            // textBoxPSC
            // 
            this.textBoxPSC.Location = new System.Drawing.Point(34, 194);
            this.textBoxPSC.Name = "textBoxPSC";
            this.textBoxPSC.Size = new System.Drawing.Size(256, 20);
            this.textBoxPSC.TabIndex = 15;
            this.textBoxPSC.Visible = false;
            // 
            // labelPSCkod
            // 
            this.labelPSCkod.AutoSize = true;
            this.labelPSCkod.Location = new System.Drawing.Point(32, 178);
            this.labelPSCkod.Name = "labelPSCkod";
            this.labelPSCkod.Size = new System.Drawing.Size(174, 13);
            this.labelPSCkod.TabIndex = 16;
            this.labelPSCkod.Text = "Zde zadejte váš kód z Paysafecard";
            this.labelPSCkod.Visible = false;
            // 
            // Platba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.labelPSCkod);
            this.Controls.Add(this.textBoxPSC);
            this.Controls.Add(this.labelInstrukce);
            this.Controls.Add(this.pictureBoxBanka);
            this.Controls.Add(this.pictureBoxPayPal);
            this.Controls.Add(this.pictureBoxPSC);
            this.Controls.Add(this.pictureBoxSMS);
            this.Controls.Add(this.pictureBoxBitcoin);
            this.Controls.Add(this.labelPrijemce);
            this.Controls.Add(this.labelOdesilatel);
            this.Controls.Add(this.labelOdesilatelPH);
            this.Controls.Add(this.labelPrijemcePH);
            this.Controls.Add(this.labelCastka);
            this.Controls.Add(this.labelCastkaPlaceholder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxGooglePay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(335, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(335, 489);
            this.Name = "Platba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Pay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGooglePay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBitcoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPayPal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGooglePay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCastkaPlaceholder;
        private System.Windows.Forms.Label labelCastka;
        private System.Windows.Forms.Label labelPrijemcePH;
        private System.Windows.Forms.Label labelOdesilatelPH;
        private System.Windows.Forms.Label labelOdesilatel;
        private System.Windows.Forms.Label labelPrijemce;
        private System.Windows.Forms.PictureBox pictureBoxBitcoin;
        private System.Windows.Forms.PictureBox pictureBoxSMS;
        private System.Windows.Forms.PictureBox pictureBoxPSC;
        private System.Windows.Forms.PictureBox pictureBoxPayPal;
        private System.Windows.Forms.PictureBox pictureBoxBanka;
        private System.Windows.Forms.Label labelInstrukce;
        private System.Windows.Forms.TextBox textBoxPSC;
        private System.Windows.Forms.Label labelPSCkod;
    }
}