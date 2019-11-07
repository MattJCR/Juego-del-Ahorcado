namespace JuegoAhorcado
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelDificultad = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.comboBoxDificultad = new System.Windows.Forms.ComboBox();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.panelJuego = new System.Windows.Forms.Panel();
            this.labelEndGame = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPalabra = new System.Windows.Forms.TextBox();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelLetras = new System.Windows.Forms.Panel();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonÑ = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.labelDiccionario = new System.Windows.Forms.Label();
            this.comboBoxIdiomas = new System.Windows.Forms.ComboBox();
            this.panelLogin.SuspendLayout();
            this.panelJuego.SuspendLayout();
            this.panelDibujo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelLetras.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLogin.Controls.Add(this.comboBoxIdiomas);
            this.panelLogin.Controls.Add(this.labelDificultad);
            this.panelLogin.Controls.Add(this.labelTitulo);
            this.panelLogin.Controls.Add(this.comboBoxDificultad);
            this.panelLogin.Controls.Add(this.buttonJugar);
            this.panelLogin.Controls.Add(this.labelDiccionario);
            this.panelLogin.Location = new System.Drawing.Point(0, -1);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(902, 522);
            this.panelLogin.TabIndex = 0;
            // 
            // labelDificultad
            // 
            this.labelDificultad.AutoSize = true;
            this.labelDificultad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDificultad.Location = new System.Drawing.Point(298, 244);
            this.labelDificultad.Name = "labelDificultad";
            this.labelDificultad.Size = new System.Drawing.Size(113, 27);
            this.labelDificultad.TabIndex = 7;
            this.labelDificultad.Text = "Dificultad: ";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(155, 67);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(553, 58);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "JUEGO DEL AHORCADO";
            // 
            // comboBoxDificultad
            // 
            this.comboBoxDificultad.FormattingEnabled = true;
            this.comboBoxDificultad.Items.AddRange(new object[] {
            "Dificil",
            "Normal",
            "Facil"});
            this.comboBoxDificultad.Location = new System.Drawing.Point(428, 247);
            this.comboBoxDificultad.Name = "comboBoxDificultad";
            this.comboBoxDificultad.Size = new System.Drawing.Size(149, 24);
            this.comboBoxDificultad.TabIndex = 5;
            // 
            // buttonJugar
            // 
            this.buttonJugar.BackColor = System.Drawing.Color.LightCyan;
            this.buttonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJugar.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJugar.Location = new System.Drawing.Point(284, 349);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(305, 80);
            this.buttonJugar.TabIndex = 4;
            this.buttonJugar.Text = "JUGAR";
            this.buttonJugar.UseVisualStyleBackColor = false;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelJuego.Controls.Add(this.labelEndGame);
            this.panelJuego.Controls.Add(this.buttonReset);
            this.panelJuego.Controls.Add(this.label2);
            this.panelJuego.Controls.Add(this.label1);
            this.panelJuego.Controls.Add(this.textBoxPalabra);
            this.panelJuego.Controls.Add(this.panelDibujo);
            this.panelJuego.Controls.Add(this.panelLetras);
            this.panelJuego.Location = new System.Drawing.Point(0, -2);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(902, 522);
            this.panelJuego.TabIndex = 1;
            // 
            // labelEndGame
            // 
            this.labelEndGame.AutoSize = true;
            this.labelEndGame.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndGame.Location = new System.Drawing.Point(593, 54);
            this.labelEndGame.Name = "labelEndGame";
            this.labelEndGame.Size = new System.Drawing.Size(204, 38);
            this.labelEndGame.TabIndex = 30;
            this.labelEndGame.Text = "GAME OVER!";
            this.labelEndGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonReset
            // 
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(358, 447);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(220, 46);
            this.buttonReset.TabIndex = 29;
            this.buttonReset.Text = "REINICIAR";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Pistas: ";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "INTENTOS RESTANTES: 0";
            // 
            // textBoxPalabra
            // 
            this.textBoxPalabra.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPalabra.Location = new System.Drawing.Point(83, 381);
            this.textBoxPalabra.Name = "textBoxPalabra";
            this.textBoxPalabra.ReadOnly = true;
            this.textBoxPalabra.Size = new System.Drawing.Size(247, 28);
            this.textBoxPalabra.TabIndex = 26;
            this.textBoxPalabra.Text = "_ _ _ _ _";
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.Color.White;
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDibujo.Controls.Add(this.pictureBox3);
            this.panelDibujo.Controls.Add(this.pictureBox1);
            this.panelDibujo.Controls.Add(this.pictureBox0);
            this.panelDibujo.Controls.Add(this.pictureBox2);
            this.panelDibujo.Controls.Add(this.pictureBox4);
            this.panelDibujo.Location = new System.Drawing.Point(575, 114);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(244, 290);
            this.panelDibujo.TabIndex = 25;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JuegoAhorcado.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(106, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JuegoAhorcado.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox0
            // 
            this.pictureBox0.Image = global::JuegoAhorcado.Properties.Resources._0;
            this.pictureBox0.Location = new System.Drawing.Point(3, 236);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(238, 50);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox0.TabIndex = 0;
            this.pictureBox0.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JuegoAhorcado.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(83, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::JuegoAhorcado.Properties.Resources._4;
            this.pictureBox4.Location = new System.Drawing.Point(105, 188);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // panelLetras
            // 
            this.panelLetras.Controls.Add(this.buttonW);
            this.panelLetras.Controls.Add(this.buttonV);
            this.panelLetras.Controls.Add(this.buttonS);
            this.panelLetras.Controls.Add(this.buttonU);
            this.panelLetras.Controls.Add(this.buttonT);
            this.panelLetras.Controls.Add(this.buttonR);
            this.panelLetras.Controls.Add(this.buttonA);
            this.panelLetras.Controls.Add(this.buttonF);
            this.panelLetras.Controls.Add(this.buttonC);
            this.panelLetras.Controls.Add(this.buttonY);
            this.panelLetras.Controls.Add(this.buttonD);
            this.panelLetras.Controls.Add(this.buttonL);
            this.panelLetras.Controls.Add(this.buttonB);
            this.panelLetras.Controls.Add(this.buttonQ);
            this.panelLetras.Controls.Add(this.buttonE);
            this.panelLetras.Controls.Add(this.buttonX);
            this.panelLetras.Controls.Add(this.buttonZ);
            this.panelLetras.Controls.Add(this.buttonP);
            this.panelLetras.Controls.Add(this.buttonG);
            this.panelLetras.Controls.Add(this.buttonN);
            this.panelLetras.Controls.Add(this.buttonI);
            this.panelLetras.Controls.Add(this.buttonO);
            this.panelLetras.Controls.Add(this.buttonJ);
            this.panelLetras.Controls.Add(this.buttonÑ);
            this.panelLetras.Controls.Add(this.buttonH);
            this.panelLetras.Controls.Add(this.buttonM);
            this.panelLetras.Controls.Add(this.buttonK);
            this.panelLetras.Location = new System.Drawing.Point(83, 114);
            this.panelLetras.Name = "panelLetras";
            this.panelLetras.Size = new System.Drawing.Size(247, 206);
            this.panelLetras.TabIndex = 24;
            // 
            // buttonW
            // 
            this.buttonW.BackColor = System.Drawing.Color.Snow;
            this.buttonW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonW.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonW.Location = new System.Drawing.Point(208, 126);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(35, 35);
            this.buttonW.TabIndex = 26;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = false;
            this.buttonW.Click += new System.EventHandler(this.buttonW_Click);
            // 
            // buttonV
            // 
            this.buttonV.BackColor = System.Drawing.Color.Snow;
            this.buttonV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonV.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonV.Location = new System.Drawing.Point(167, 126);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(35, 35);
            this.buttonV.TabIndex = 25;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = false;
            this.buttonV.Click += new System.EventHandler(this.buttonV_Click);
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.Snow;
            this.buttonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonS.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS.Location = new System.Drawing.Point(44, 126);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(35, 35);
            this.buttonS.TabIndex = 24;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonU
            // 
            this.buttonU.BackColor = System.Drawing.Color.Snow;
            this.buttonU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonU.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonU.Location = new System.Drawing.Point(126, 126);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(35, 35);
            this.buttonU.TabIndex = 23;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = false;
            this.buttonU.Click += new System.EventHandler(this.buttonU_Click);
            // 
            // buttonT
            // 
            this.buttonT.BackColor = System.Drawing.Color.Snow;
            this.buttonT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonT.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonT.Location = new System.Drawing.Point(85, 126);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(35, 35);
            this.buttonT.TabIndex = 22;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = false;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonR
            // 
            this.buttonR.BackColor = System.Drawing.Color.Snow;
            this.buttonR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonR.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonR.Location = new System.Drawing.Point(3, 126);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(35, 35);
            this.buttonR.TabIndex = 21;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = false;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.Snow;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.Location = new System.Drawing.Point(3, 3);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(35, 35);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonF
            // 
            this.buttonF.BackColor = System.Drawing.Color.Snow;
            this.buttonF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonF.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonF.Location = new System.Drawing.Point(208, 3);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(35, 35);
            this.buttonF.TabIndex = 20;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = false;
            this.buttonF.Click += new System.EventHandler(this.buttonF_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Snow;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(85, 3);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(35, 35);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonY
            // 
            this.buttonY.BackColor = System.Drawing.Color.Snow;
            this.buttonY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonY.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonY.Location = new System.Drawing.Point(105, 167);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(35, 35);
            this.buttonY.TabIndex = 19;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = false;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.Snow;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD.Location = new System.Drawing.Point(126, 3);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(35, 35);
            this.buttonD.TabIndex = 2;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonL
            // 
            this.buttonL.BackColor = System.Drawing.Color.Snow;
            this.buttonL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonL.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL.Location = new System.Drawing.Point(208, 44);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(35, 35);
            this.buttonL.TabIndex = 18;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = false;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.Snow;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.Location = new System.Drawing.Point(44, 3);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(35, 35);
            this.buttonB.TabIndex = 3;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonQ
            // 
            this.buttonQ.BackColor = System.Drawing.Color.Snow;
            this.buttonQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQ.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQ.Location = new System.Drawing.Point(208, 85);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(35, 35);
            this.buttonQ.TabIndex = 17;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = false;
            this.buttonQ.Click += new System.EventHandler(this.buttonQ_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.Snow;
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonE.Location = new System.Drawing.Point(167, 3);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(35, 35);
            this.buttonE.TabIndex = 4;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.Snow;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.Location = new System.Drawing.Point(64, 167);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(35, 35);
            this.buttonX.TabIndex = 16;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonZ
            // 
            this.buttonZ.BackColor = System.Drawing.Color.Snow;
            this.buttonZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ.Location = new System.Drawing.Point(146, 167);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(35, 35);
            this.buttonZ.TabIndex = 5;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = false;
            this.buttonZ.Click += new System.EventHandler(this.buttonZ_Click);
            // 
            // buttonP
            // 
            this.buttonP.BackColor = System.Drawing.Color.Snow;
            this.buttonP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonP.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonP.Location = new System.Drawing.Point(167, 85);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(35, 35);
            this.buttonP.TabIndex = 15;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = false;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonG
            // 
            this.buttonG.BackColor = System.Drawing.Color.Snow;
            this.buttonG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonG.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonG.Location = new System.Drawing.Point(3, 44);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(35, 35);
            this.buttonG.TabIndex = 6;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = false;
            this.buttonG.Click += new System.EventHandler(this.buttonG_Click);
            // 
            // buttonN
            // 
            this.buttonN.BackColor = System.Drawing.Color.Snow;
            this.buttonN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonN.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN.Location = new System.Drawing.Point(44, 85);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(35, 35);
            this.buttonN.TabIndex = 14;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = false;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonI
            // 
            this.buttonI.BackColor = System.Drawing.Color.Snow;
            this.buttonI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonI.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonI.Location = new System.Drawing.Point(85, 44);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(35, 35);
            this.buttonI.TabIndex = 7;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = false;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // buttonO
            // 
            this.buttonO.BackColor = System.Drawing.Color.Snow;
            this.buttonO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonO.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonO.Location = new System.Drawing.Point(126, 85);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(35, 35);
            this.buttonO.TabIndex = 13;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = false;
            this.buttonO.Click += new System.EventHandler(this.buttonO_Click);
            // 
            // buttonJ
            // 
            this.buttonJ.BackColor = System.Drawing.Color.Snow;
            this.buttonJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJ.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJ.Location = new System.Drawing.Point(126, 44);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(35, 35);
            this.buttonJ.TabIndex = 8;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = false;
            this.buttonJ.Click += new System.EventHandler(this.buttonJ_Click);
            // 
            // buttonÑ
            // 
            this.buttonÑ.BackColor = System.Drawing.Color.Snow;
            this.buttonÑ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonÑ.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonÑ.Location = new System.Drawing.Point(85, 85);
            this.buttonÑ.Name = "buttonÑ";
            this.buttonÑ.Size = new System.Drawing.Size(35, 35);
            this.buttonÑ.TabIndex = 12;
            this.buttonÑ.Text = "Ñ";
            this.buttonÑ.UseVisualStyleBackColor = false;
            this.buttonÑ.Click += new System.EventHandler(this.buttonÑ_Click);
            // 
            // buttonH
            // 
            this.buttonH.BackColor = System.Drawing.Color.Snow;
            this.buttonH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonH.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonH.Location = new System.Drawing.Point(44, 44);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(35, 35);
            this.buttonH.TabIndex = 9;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = false;
            this.buttonH.Click += new System.EventHandler(this.buttonH_Click);
            // 
            // buttonM
            // 
            this.buttonM.BackColor = System.Drawing.Color.Snow;
            this.buttonM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonM.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM.Location = new System.Drawing.Point(3, 85);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(35, 35);
            this.buttonM.TabIndex = 11;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = false;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonK
            // 
            this.buttonK.BackColor = System.Drawing.Color.Snow;
            this.buttonK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonK.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonK.Location = new System.Drawing.Point(167, 44);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(35, 35);
            this.buttonK.TabIndex = 10;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = false;
            this.buttonK.Click += new System.EventHandler(this.buttonK_Click);
            // 
            // labelDiccionario
            // 
            this.labelDiccionario.AutoSize = true;
            this.labelDiccionario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiccionario.Location = new System.Drawing.Point(181, 281);
            this.labelDiccionario.Name = "labelDiccionario";
            this.labelDiccionario.Size = new System.Drawing.Size(230, 27);
            this.labelDiccionario.TabIndex = 11;
            this.labelDiccionario.Text = "Idioma del Diccionario: ";
            // 
            // comboBoxIdiomas
            // 
            this.comboBoxIdiomas.Items.AddRange(new object[] {
            "Español",
            "Inglés",
            "Italiano"});
            this.comboBoxIdiomas.Location = new System.Drawing.Point(428, 281);
            this.comboBoxIdiomas.Name = "comboBoxIdiomas";
            this.comboBoxIdiomas.Size = new System.Drawing.Size(149, 24);
            this.comboBoxIdiomas.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelJuego);
            this.Name = "FormPrincipal";
            this.Text = "El Ahorcado";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelJuego.ResumeLayout(false);
            this.panelJuego.PerformLayout();
            this.panelDibujo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelLetras.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Label labelDificultad;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ComboBox comboBoxDificultad;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.TextBox textBoxPalabra;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Panel panelLetras;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonÑ;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelEndGame;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelDiccionario;
        private System.Windows.Forms.ComboBox comboBoxIdiomas;
    }
}

