namespace Program102
{
    partial class All_Objects
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(All_Objects));
            this.GIF_Planets = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SUN = new System.Windows.Forms.PictureBox();
            this.STAR = new System.Windows.Forms.PictureBox();
            this.Mercury = new System.Windows.Forms.PictureBox();
            this.Venus = new System.Windows.Forms.PictureBox();
            this.Earth = new System.Windows.Forms.PictureBox();
            this.Mars = new System.Windows.Forms.PictureBox();
            this.Jupiter = new System.Windows.Forms.PictureBox();
            this.Saturn = new System.Windows.Forms.PictureBox();
            this.Uranium = new System.Windows.Forms.PictureBox();
            this.Neptune = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GIF_Planets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mercury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Venus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Earth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jupiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uranium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Neptune)).BeginInit();
            this.SuspendLayout();
            // 
            // GIF_Planets
            // 
            this.GIF_Planets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GIF_Planets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GIF_Planets.Image = ((System.Drawing.Image)(resources.GetObject("GIF_Planets.Image")));
            this.GIF_Planets.Location = new System.Drawing.Point(0, 0);
            this.GIF_Planets.Name = "GIF_Planets";
            this.GIF_Planets.Size = new System.Drawing.Size(1201, 461);
            this.GIF_Planets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GIF_Planets.TabIndex = 0;
            this.GIF_Planets.TabStop = false;
            this.GIF_Planets.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GIF_Planets_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SUN
            // 
            this.SUN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SUN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SUN.Image = ((System.Drawing.Image)(resources.GetObject("SUN.Image")));
            this.SUN.Location = new System.Drawing.Point(-66, 148);
            this.SUN.Name = "SUN";
            this.SUN.Size = new System.Drawing.Size(280, 155);
            this.SUN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SUN.TabIndex = 1;
            this.SUN.TabStop = false;
            this.SUN.Click += new System.EventHandler(this.SUN_Click);
            this.SUN.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.SUN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // STAR
            // 
            this.STAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STAR.Image = ((System.Drawing.Image)(resources.GetObject("STAR.Image")));
            this.STAR.Location = new System.Drawing.Point(0, 0);
            this.STAR.Name = "STAR";
            this.STAR.Size = new System.Drawing.Size(1201, 461);
            this.STAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.STAR.TabIndex = 2;
            this.STAR.TabStop = false;
            this.STAR.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.STAR.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.STAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Mercury
            // 
            this.Mercury.BackColor = System.Drawing.Color.Transparent;
            this.Mercury.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Mercury.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mercury.Image = ((System.Drawing.Image)(resources.GetObject("Mercury.Image")));
            this.Mercury.Location = new System.Drawing.Point(166, 196);
            this.Mercury.Name = "Mercury";
            this.Mercury.Size = new System.Drawing.Size(60, 60);
            this.Mercury.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mercury.TabIndex = 3;
            this.Mercury.TabStop = false;
            this.Mercury.Click += new System.EventHandler(this.Mercury_Click);
            this.Mercury.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.Mercury.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Venus
            // 
            this.Venus.BackColor = System.Drawing.Color.Transparent;
            this.Venus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Venus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Venus.Image = ((System.Drawing.Image)(resources.GetObject("Venus.Image")));
            this.Venus.Location = new System.Drawing.Point(234, 186);
            this.Venus.Name = "Venus";
            this.Venus.Size = new System.Drawing.Size(107, 80);
            this.Venus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Venus.TabIndex = 4;
            this.Venus.TabStop = false;
            this.Venus.Click += new System.EventHandler(this.Venus_Click);
            this.Venus.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.Venus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Earth
            // 
            this.Earth.BackColor = System.Drawing.Color.Transparent;
            this.Earth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Earth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Earth.Image = ((System.Drawing.Image)(resources.GetObject("Earth.Image")));
            this.Earth.Location = new System.Drawing.Point(348, 173);
            this.Earth.Name = "Earth";
            this.Earth.Size = new System.Drawing.Size(105, 105);
            this.Earth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Earth.TabIndex = 5;
            this.Earth.TabStop = false;
            this.Earth.Click += new System.EventHandler(this.Earth_Click);
            this.Earth.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.Earth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Mars
            // 
            this.Mars.BackColor = System.Drawing.Color.Transparent;
            this.Mars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Mars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mars.Image = ((System.Drawing.Image)(resources.GetObject("Mars.Image")));
            this.Mars.Location = new System.Drawing.Point(466, 174);
            this.Mars.Name = "Mars";
            this.Mars.Size = new System.Drawing.Size(105, 105);
            this.Mars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mars.TabIndex = 6;
            this.Mars.TabStop = false;
            this.Mars.Click += new System.EventHandler(this.Mars_Click);
            this.Mars.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.Mars.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Jupiter
            // 
            this.Jupiter.BackColor = System.Drawing.Color.Transparent;
            this.Jupiter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Jupiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jupiter.Image = ((System.Drawing.Image)(resources.GetObject("Jupiter.Image")));
            this.Jupiter.Location = new System.Drawing.Point(584, 160);
            this.Jupiter.Name = "Jupiter";
            this.Jupiter.Size = new System.Drawing.Size(130, 130);
            this.Jupiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jupiter.TabIndex = 7;
            this.Jupiter.TabStop = false;
            this.Jupiter.Click += new System.EventHandler(this.Jupiter_Click);
            this.Jupiter.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.Jupiter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Saturn
            // 
            this.Saturn.BackColor = System.Drawing.Color.Transparent;
            this.Saturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Saturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Saturn.Image = ((System.Drawing.Image)(resources.GetObject("Saturn.Image")));
            this.Saturn.Location = new System.Drawing.Point(729, 159);
            this.Saturn.Name = "Saturn";
            this.Saturn.Size = new System.Drawing.Size(190, 130);
            this.Saturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Saturn.TabIndex = 8;
            this.Saturn.TabStop = false;
            this.Saturn.Click += new System.EventHandler(this.Saturn_Click);
            this.Saturn.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.Saturn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Uranium
            // 
            this.Uranium.BackColor = System.Drawing.Color.Transparent;
            this.Uranium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Uranium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Uranium.Image = ((System.Drawing.Image)(resources.GetObject("Uranium.Image")));
            this.Uranium.Location = new System.Drawing.Point(930, 157);
            this.Uranium.Name = "Uranium";
            this.Uranium.Size = new System.Drawing.Size(130, 130);
            this.Uranium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Uranium.TabIndex = 9;
            this.Uranium.TabStop = false;
            this.Uranium.Click += new System.EventHandler(this.Uranium_Click);
            this.Uranium.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.Uranium.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Neptune
            // 
            this.Neptune.BackColor = System.Drawing.Color.Transparent;
            this.Neptune.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Neptune.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Neptune.Image = ((System.Drawing.Image)(resources.GetObject("Neptune.Image")));
            this.Neptune.Location = new System.Drawing.Point(1061, 157);
            this.Neptune.Name = "Neptune";
            this.Neptune.Size = new System.Drawing.Size(130, 130);
            this.Neptune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Neptune.TabIndex = 10;
            this.Neptune.TabStop = false;
            this.Neptune.Click += new System.EventHandler(this.Neptune_Click);
            this.Neptune.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.Neptune.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // All_Objects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1201, 461);
            this.Controls.Add(this.Neptune);
            this.Controls.Add(this.Uranium);
            this.Controls.Add(this.Saturn);
            this.Controls.Add(this.Jupiter);
            this.Controls.Add(this.Mars);
            this.Controls.Add(this.Earth);
            this.Controls.Add(this.Venus);
            this.Controls.Add(this.Mercury);
            this.Controls.Add(this.SUN);
            this.Controls.Add(this.STAR);
            this.Controls.Add(this.GIF_Planets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "All_Objects";
            this.Text = "Модель солнечной системы";
            this.TransparencyKey = System.Drawing.Color.LightCoral;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.GIF_Planets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mercury)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Venus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Earth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jupiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uranium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Neptune)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GIF_Planets;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox SUN;
        private System.Windows.Forms.PictureBox STAR;
        private System.Windows.Forms.PictureBox Mercury;
        private System.Windows.Forms.PictureBox Venus;
        private System.Windows.Forms.PictureBox Earth;
        private System.Windows.Forms.PictureBox Mars;
        private System.Windows.Forms.PictureBox Jupiter;
        private System.Windows.Forms.PictureBox Saturn;
        private System.Windows.Forms.PictureBox Uranium;
        private System.Windows.Forms.PictureBox Neptune;
    }
}

