namespace Vaccination_point_v3_frame
{
    partial class mainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picture_mon = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.number_of_vaccinated_people = new System.Windows.Forms.Label();
            this.number_of_covidPositive_people = new System.Windows.Forms.Label();
            this.moderna_vaccinated = new System.Windows.Forms.Label();
            this.astraZeneca_vaccinated = new System.Windows.Forms.Label();
            this.sputnik_vaccinated = new System.Windows.Forms.Label();
            this.jj_vaccinated = new System.Windows.Forms.Label();
            this.pfizer_vaccinated = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listbox_registration = new System.Windows.Forms.ListBox();
            this.listbox_moderna = new System.Windows.Forms.ListBox();
            this.listbox_astraZeneca = new System.Windows.Forms.ListBox();
            this.listbox_sputnik = new System.Windows.Forms.ListBox();
            this.listbox_jj = new System.Windows.Forms.ListBox();
            this.listbox_pfizer = new System.Windows.Forms.ListBox();
            this.listbox_covidTested = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_mon)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kolejka do testu:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Moderna:";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "AstraZeneca:";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sputnik:";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "J J:";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pfizer:";
            this.label7.UseWaitCursor = true;
            // 
            // picture_mon
            // 
            this.picture_mon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_mon.Image = ((System.Drawing.Image)(resources.GetObject("picture_mon.Image")));
            this.picture_mon.Location = new System.Drawing.Point(311, 204);
            this.picture_mon.Name = "picture_mon";
            this.picture_mon.Size = new System.Drawing.Size(464, 200);
            this.picture_mon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_mon.TabIndex = 14;
            this.picture_mon.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "STATYSTYKI:";
            this.label8.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Zaszczepionych:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(636, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Odrzuconych:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "AstraZeneca:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(636, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Moderna:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(636, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "J J:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(636, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Sputnik:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(636, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Pfizer:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(119, 262);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Testowany";
            this.label17.UseWaitCursor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(119, 275);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "------------>";
            this.label18.UseWaitCursor = true;
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_button.Location = new System.Drawing.Point(12, 410);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(776, 28);
            this.start_button.TabIndex = 27;
            this.start_button.Text = "Start!";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // number_of_vaccinated_people
            // 
            this.number_of_vaccinated_people.AutoSize = true;
            this.number_of_vaccinated_people.Location = new System.Drawing.Point(762, 43);
            this.number_of_vaccinated_people.Name = "number_of_vaccinated_people";
            this.number_of_vaccinated_people.Size = new System.Drawing.Size(13, 13);
            this.number_of_vaccinated_people.TabIndex = 29;
            this.number_of_vaccinated_people.Text = "0";
            // 
            // number_of_covidPositive_people
            // 
            this.number_of_covidPositive_people.AutoSize = true;
            this.number_of_covidPositive_people.Location = new System.Drawing.Point(762, 67);
            this.number_of_covidPositive_people.Name = "number_of_covidPositive_people";
            this.number_of_covidPositive_people.Size = new System.Drawing.Size(13, 13);
            this.number_of_covidPositive_people.TabIndex = 30;
            this.number_of_covidPositive_people.Text = "0";
            // 
            // moderna_vaccinated
            // 
            this.moderna_vaccinated.AutoSize = true;
            this.moderna_vaccinated.Location = new System.Drawing.Point(762, 89);
            this.moderna_vaccinated.Name = "moderna_vaccinated";
            this.moderna_vaccinated.Size = new System.Drawing.Size(13, 13);
            this.moderna_vaccinated.TabIndex = 31;
            this.moderna_vaccinated.Text = "0";
            // 
            // astraZeneca_vaccinated
            // 
            this.astraZeneca_vaccinated.AutoSize = true;
            this.astraZeneca_vaccinated.Location = new System.Drawing.Point(762, 112);
            this.astraZeneca_vaccinated.Name = "astraZeneca_vaccinated";
            this.astraZeneca_vaccinated.Size = new System.Drawing.Size(13, 13);
            this.astraZeneca_vaccinated.TabIndex = 32;
            this.astraZeneca_vaccinated.Text = "0";
            // 
            // sputnik_vaccinated
            // 
            this.sputnik_vaccinated.AutoSize = true;
            this.sputnik_vaccinated.Location = new System.Drawing.Point(762, 134);
            this.sputnik_vaccinated.Name = "sputnik_vaccinated";
            this.sputnik_vaccinated.Size = new System.Drawing.Size(13, 13);
            this.sputnik_vaccinated.TabIndex = 33;
            this.sputnik_vaccinated.Text = "0";
            // 
            // jj_vaccinated
            // 
            this.jj_vaccinated.AutoSize = true;
            this.jj_vaccinated.Location = new System.Drawing.Point(762, 156);
            this.jj_vaccinated.Name = "jj_vaccinated";
            this.jj_vaccinated.Size = new System.Drawing.Size(13, 13);
            this.jj_vaccinated.TabIndex = 34;
            this.jj_vaccinated.Text = "0";
            // 
            // pfizer_vaccinated
            // 
            this.pfizer_vaccinated.AutoSize = true;
            this.pfizer_vaccinated.Location = new System.Drawing.Point(762, 178);
            this.pfizer_vaccinated.Name = "pfizer_vaccinated";
            this.pfizer_vaccinated.Size = new System.Drawing.Size(13, 13);
            this.pfizer_vaccinated.TabIndex = 35;
            this.pfizer_vaccinated.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listbox_registration
            // 
            this.listbox_registration.FormattingEnabled = true;
            this.listbox_registration.Location = new System.Drawing.Point(12, 227);
            this.listbox_registration.Name = "listbox_registration";
            this.listbox_registration.Size = new System.Drawing.Size(101, 160);
            this.listbox_registration.TabIndex = 45;
            // 
            // listbox_moderna
            // 
            this.listbox_moderna.FormattingEnabled = true;
            this.listbox_moderna.Location = new System.Drawing.Point(9, 82);
            this.listbox_moderna.Name = "listbox_moderna";
            this.listbox_moderna.Size = new System.Drawing.Size(114, 43);
            this.listbox_moderna.TabIndex = 47;
            // 
            // listbox_astraZeneca
            // 
            this.listbox_astraZeneca.FormattingEnabled = true;
            this.listbox_astraZeneca.Location = new System.Drawing.Point(129, 82);
            this.listbox_astraZeneca.Name = "listbox_astraZeneca";
            this.listbox_astraZeneca.Size = new System.Drawing.Size(113, 43);
            this.listbox_astraZeneca.TabIndex = 48;
            // 
            // listbox_sputnik
            // 
            this.listbox_sputnik.FormattingEnabled = true;
            this.listbox_sputnik.Location = new System.Drawing.Point(248, 82);
            this.listbox_sputnik.Name = "listbox_sputnik";
            this.listbox_sputnik.Size = new System.Drawing.Size(110, 43);
            this.listbox_sputnik.TabIndex = 49;
            // 
            // listbox_jj
            // 
            this.listbox_jj.FormattingEnabled = true;
            this.listbox_jj.Location = new System.Drawing.Point(364, 82);
            this.listbox_jj.Name = "listbox_jj";
            this.listbox_jj.Size = new System.Drawing.Size(114, 43);
            this.listbox_jj.TabIndex = 50;
            // 
            // listbox_pfizer
            // 
            this.listbox_pfizer.FormattingEnabled = true;
            this.listbox_pfizer.Location = new System.Drawing.Point(484, 82);
            this.listbox_pfizer.Name = "listbox_pfizer";
            this.listbox_pfizer.Size = new System.Drawing.Size(99, 43);
            this.listbox_pfizer.TabIndex = 51;
            // 
            // listbox_covidTested
            // 
            this.listbox_covidTested.FormattingEnabled = true;
            this.listbox_covidTested.Location = new System.Drawing.Point(184, 262);
            this.listbox_covidTested.Name = "listbox_covidTested";
            this.listbox_covidTested.Size = new System.Drawing.Size(100, 30);
            this.listbox_covidTested.TabIndex = 57;
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listbox_covidTested);
            this.Controls.Add(this.listbox_pfizer);
            this.Controls.Add(this.listbox_jj);
            this.Controls.Add(this.listbox_sputnik);
            this.Controls.Add(this.listbox_astraZeneca);
            this.Controls.Add(this.listbox_moderna);
            this.Controls.Add(this.listbox_registration);
            this.Controls.Add(this.pfizer_vaccinated);
            this.Controls.Add(this.jj_vaccinated);
            this.Controls.Add(this.sputnik_vaccinated);
            this.Controls.Add(this.astraZeneca_vaccinated);
            this.Controls.Add(this.moderna_vaccinated);
            this.Controls.Add(this.number_of_covidPositive_people);
            this.Controls.Add(this.number_of_vaccinated_people);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picture_mon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Vaccination point (Walczak Jakub WCY19IX3S0)";
            this.Load += new System.EventHandler(this.Vaccination_point_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_mon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picture_mon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label number_of_vaccinated_people;
        private System.Windows.Forms.Label number_of_covidPositive_people;
        private System.Windows.Forms.Label moderna_vaccinated;
        private System.Windows.Forms.Label astraZeneca_vaccinated;
        private System.Windows.Forms.Label sputnik_vaccinated;
        private System.Windows.Forms.Label jj_vaccinated;
        private System.Windows.Forms.Label pfizer_vaccinated;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listbox_registration;
        private System.Windows.Forms.ListBox listbox_moderna;
        private System.Windows.Forms.ListBox listbox_astraZeneca;
        private System.Windows.Forms.ListBox listbox_sputnik;
        private System.Windows.Forms.ListBox listbox_jj;
        private System.Windows.Forms.ListBox listbox_pfizer;
        private System.Windows.Forms.ListBox listbox_covidTested;
    }
}

