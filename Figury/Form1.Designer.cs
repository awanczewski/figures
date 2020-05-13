namespace Kulki
{
    partial class Form1
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
            this.panelBoczny = new System.Windows.Forms.Panel();
            this.przyciskWyczysc = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dlugoscInterwalu = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.predkoscDo = new System.Windows.Forms.NumericUpDown();
            this.predkoscOd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.promienDo = new System.Windows.Forms.NumericUpDown();
            this.promienOd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iloscFigur = new System.Windows.Forms.NumericUpDown();
            this.przyciskGenFigury = new System.Windows.Forms.Button();
            this.przyciskStartStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelFigur = new Kulki.MojPanel();
            this.panelBoczny.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlugoscInterwalu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predkoscDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predkoscOd)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promienDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promienOd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iloscFigur)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBoczny
            // 
            this.panelBoczny.BackColor = System.Drawing.Color.DarkSalmon;
            this.panelBoczny.Controls.Add(this.przyciskWyczysc);
            this.panelBoczny.Controls.Add(this.groupBox5);
            this.panelBoczny.Controls.Add(this.groupBox1);
            this.panelBoczny.Controls.Add(this.przyciskStartStop);
            this.panelBoczny.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBoczny.Location = new System.Drawing.Point(923, 0);
            this.panelBoczny.Name = "panelBoczny";
            this.panelBoczny.Size = new System.Drawing.Size(251, 664);
            this.panelBoczny.TabIndex = 0;
            // 
            // przyciskWyczysc
            // 
            this.przyciskWyczysc.Location = new System.Drawing.Point(20, 183);
            this.przyciskWyczysc.Name = "przyciskWyczysc";
            this.przyciskWyczysc.Size = new System.Drawing.Size(213, 77);
            this.przyciskWyczysc.TabIndex = 7;
            this.przyciskWyczysc.Text = "WYCZYSC";
            this.przyciskWyczysc.UseVisualStyleBackColor = true;
            this.przyciskWyczysc.Click += new System.EventHandler(this.przyciskWyczysc_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dlugoscInterwalu);
            this.groupBox5.Location = new System.Drawing.Point(14, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 58);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Długość interwału [ms]";
            // 
            // dlugoscInterwalu
            // 
            this.dlugoscInterwalu.Location = new System.Drawing.Point(39, 19);
            this.dlugoscInterwalu.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.dlugoscInterwalu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dlugoscInterwalu.Name = "dlugoscInterwalu";
            this.dlugoscInterwalu.Size = new System.Drawing.Size(76, 20);
            this.dlugoscInterwalu.TabIndex = 5;
            this.dlugoscInterwalu.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.dlugoscInterwalu.ValueChanged += new System.EventHandler(this.dlugoscInterwalu_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.przyciskGenFigury);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(14, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 353);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Losowanie Figur";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.predkoscDo);
            this.groupBox4.Controls.Add(this.predkoscOd);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(6, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 84);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Przedział prędkości";
            // 
            // predkoscDo
            // 
            this.predkoscDo.Location = new System.Drawing.Point(33, 51);
            this.predkoscDo.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.predkoscDo.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.predkoscDo.Name = "predkoscDo";
            this.predkoscDo.Size = new System.Drawing.Size(76, 20);
            this.predkoscDo.TabIndex = 9;
            this.predkoscDo.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.predkoscDo.ValueChanged += new System.EventHandler(this.predkoscDo_ValueChanged);
            // 
            // predkoscOd
            // 
            this.predkoscOd.Location = new System.Drawing.Point(33, 25);
            this.predkoscOd.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.predkoscOd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.predkoscOd.Name = "predkoscOd";
            this.predkoscOd.Size = new System.Drawing.Size(76, 20);
            this.predkoscOd.TabIndex = 9;
            this.predkoscOd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.predkoscOd.ValueChanged += new System.EventHandler(this.predkoscOd_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Od";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.promienDo);
            this.groupBox3.Controls.Add(this.promienOd);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 84);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Przedział promienia";
            // 
            // promienDo
            // 
            this.promienDo.Location = new System.Drawing.Point(33, 51);
            this.promienDo.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.promienDo.Name = "promienDo";
            this.promienDo.Size = new System.Drawing.Size(76, 20);
            this.promienDo.TabIndex = 8;
            this.promienDo.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.promienDo.ValueChanged += new System.EventHandler(this.promienDo_ValueChanged);
            // 
            // promienOd
            // 
            this.promienOd.Location = new System.Drawing.Point(33, 25);
            this.promienOd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.promienOd.Name = "promienOd";
            this.promienOd.Size = new System.Drawing.Size(76, 20);
            this.promienOd.TabIndex = 5;
            this.promienOd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.promienOd.ValueChanged += new System.EventHandler(this.promienOd_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Od";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iloscFigur);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ilość Figur";
            // 
            // iloscFigur
            // 
            this.iloscFigur.Location = new System.Drawing.Point(33, 19);
            this.iloscFigur.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.iloscFigur.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iloscFigur.Name = "iloscFigur";
            this.iloscFigur.Size = new System.Drawing.Size(76, 20);
            this.iloscFigur.TabIndex = 4;
            this.iloscFigur.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iloscFigur.ValueChanged += new System.EventHandler(this.iloscFigur_ValueChanged);
            // 
            // przyciskGenFigury
            // 
            this.przyciskGenFigury.Location = new System.Drawing.Point(6, 270);
            this.przyciskGenFigury.Name = "przyciskGenFigury";
            this.przyciskGenFigury.Size = new System.Drawing.Size(213, 77);
            this.przyciskGenFigury.TabIndex = 2;
            this.przyciskGenFigury.Text = "GENERUJ FIGURY";
            this.przyciskGenFigury.UseVisualStyleBackColor = true;
            this.przyciskGenFigury.Click += new System.EventHandler(this.przyciskGenFigury_Click);
            // 
            // przyciskStartStop
            // 
            this.przyciskStartStop.Location = new System.Drawing.Point(20, 12);
            this.przyciskStartStop.Name = "przyciskStartStop";
            this.przyciskStartStop.Size = new System.Drawing.Size(213, 77);
            this.przyciskStartStop.TabIndex = 1;
            this.przyciskStartStop.Text = "START";
            this.przyciskStartStop.UseVisualStyleBackColor = true;
            this.przyciskStartStop.Click += new System.EventHandler(this.przyciskStartStop_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelFigur
            // 
            this.panelFigur.BackColor = System.Drawing.Color.Silver;
            this.panelFigur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFigur.Location = new System.Drawing.Point(0, 0);
            this.panelFigur.Name = "panelFigur";
            this.panelFigur.Size = new System.Drawing.Size(923, 664);
            this.panelFigur.TabIndex = 1;
            this.panelFigur.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFigur_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 664);
            this.Controls.Add(this.panelFigur);
            this.Controls.Add(this.panelBoczny);
            this.Name = "Form1";
            this.Text = "Kulki";
            this.panelBoczny.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlugoscInterwalu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predkoscDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predkoscOd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promienDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promienOd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iloscFigur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBoczny;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button przyciskStartStop;
        private System.Windows.Forms.Button przyciskGenFigury;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown predkoscDo;
        private System.Windows.Forms.NumericUpDown predkoscOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown promienDo;
        private System.Windows.Forms.NumericUpDown promienOd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown iloscFigur;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown dlugoscInterwalu;
        private System.Windows.Forms.Button przyciskWyczysc;
        private MojPanel panelFigur;
    }
}

