using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoAhorcado
{
    public partial class FormPrincipal : Form
    {
        private List<String> diccionario;
        private ControladorDeJuego juego;
        private string letrasJugadas;
        internal ControladorDeJuego Juego { get => juego; set => juego = value; }
        private int fallosRestantes = 4;
        private int aciertos = 0;
        private string rutaDiccionario;
        public FormPrincipal()
        {
            InitializeComponent();
            this.comboBoxDificultad.SelectedIndex = 2;
            this.comboBoxIdiomas.SelectedIndex = 0;
            this.juego = new ControladorDeJuego();
            //this.diccionario = juego.getDiccionario(rutaDiccionario);
            this.letrasJugadas = "";
            //Console.WriteLine("Size Diccionario: " + this.diccionario.Count);
            this.panelJuego.Visible = false;
            this.panelLogin.Visible = true;
            this.textBoxPalabra.Text = "";
        }
        private void setDificultad()
        {
            Console.WriteLine("DIICULTAD: " + this.comboBoxDificultad.SelectedIndex);
            Console.WriteLine("PISTAS: " + juego.getPistas(this.comboBoxDificultad.SelectedIndex));
            this.label2.Text = "Pistas: " + juego.getPistas(this.comboBoxDificultad.SelectedIndex);
            if (this.comboBoxDificultad.SelectedIndex != 0)
            {
                this.label2.Visible = true;
            }
        }
        private void setDiccionario()
        {
            if (comboBoxIdiomas.SelectedIndex == 1)
            {
                Console.WriteLine("DICCIONARIO: " + comboBoxIdiomas.SelectedIndex);
                //this.rutaDiccionario = Properties.Resources.English;
                this.rutaDiccionario = @"C:\Users\Matt Workstation\source\repos\JuegoAhorcado\JuegoAhorcado\Resources\English.dic";
            }
            else if (comboBoxIdiomas.SelectedIndex == 2)
            {
                Console.WriteLine("DICCIONARIO: " + comboBoxIdiomas.SelectedIndex);
                this.rutaDiccionario = @"C:\Users\Matt Workstation\source\repos\JuegoAhorcado\JuegoAhorcado\Resources\Italian.dic";
            }
            else if (comboBoxIdiomas.SelectedIndex == 0)
            {
                Console.WriteLine("DICCIONARIO: " + comboBoxIdiomas.SelectedIndex);
                this.rutaDiccionario = @"C:\Users\Matt Workstation\source\repos\JuegoAhorcado\JuegoAhorcado\Resources\Spanish.dic";
            }
            if (this.diccionario != null)
            {
                this.diccionario.Clear();
            }
            this.diccionario = juego.getDiccionario(rutaDiccionario);
            Console.WriteLine("Size Diccionario: " + this.diccionario.Count);
        }
        private void jugar(string letra)
        {
            letrasJugadas += letra;
            string letrasAuxiliar = juego.pintarPalabra(letrasJugadas);
            Console.WriteLine(letrasAuxiliar);
            Console.WriteLine(this.textBoxPalabra.Text);
            if (textBoxPalabra.Text == letrasAuxiliar)
            {
                this.DisableButtom(letra, false);
                Console.WriteLine("FALSE");
                this.fallosRestantes--;
                this.label1.Text = "INTENTOS RESTANTES: " + this.fallosRestantes;
                this.pintarAhorcado();
            }
            else
            {
                this.DisableButtom(letra, true);
                this.textBoxPalabra.Text = letrasAuxiliar;
                this.aciertos += this.contarLetras(letra[0]);
                Console.WriteLine("ACIERTOS = " + this.aciertos);
                Console.WriteLine("TRUE");
            }
            if (this.fallosRestantes <= 0)
            {
                //Game Over
                this.labelEndGame.Visible = true;
                this.labelEndGame.Text = "GAME OVER!";
                this.buttonReset.Visible = true;
                this.panelLetras.Enabled = false;
                this.textBoxPalabra.Text = "";
                foreach (char item in this.juego.Palabra)
                {
                    this.textBoxPalabra.Text += item + " ";
                }
            }
            else if (this.aciertos == this.juego.Palabra.Length)
            {
                //Winner!
                this.labelEndGame.Visible = true;
                this.labelEndGame.Text = "WINNER!";
                this.buttonReset.Visible = true;
                this.panelLetras.Enabled = false;
            }
        }
        private int contarLetras(char letra)
        {
            int x = 0;
            foreach (char item in this.juego.Palabra)
            {
                if (item == letra)
                {
                    x++;
                }
            }
            return x;
        }
        private void pintarAhorcado()
        {
            if (fallosRestantes <= 4)
            {
                pictureBox0.Visible = true;
            }
            if (fallosRestantes <= 3)
            {
                pictureBox1.Visible = true;
            }
            if (fallosRestantes <= 2)
            {
                pictureBox2.Visible = true;
            }
            if (fallosRestantes <= 1)
            {
                pictureBox3.Visible = true;
            }
            if (fallosRestantes == 0)
            {
                pictureBox4.Visible = true;
            }
        }
        private void reiniciarAhorcado()
        {
            this.pictureBox0.Visible = true;
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = false;
            this.pictureBox3.Visible = false;
            this.pictureBox4.Visible = false;
            this.ResetButtoms();
            this.letrasJugadas = "";
        }
        private void DisableButtom(string letra, bool colorButtom)
        {
            switch (letra)
            {
                case "A":
                    if (colorButtom)
                    {
                        this.buttonA.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonA.BackColor = Color.Red;
                    }
                    this.buttonA.Enabled = false;
                    break;
                case "B":
                    if (colorButtom)
                    {
                        this.buttonB.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonB.BackColor = Color.Red;
                    }
                    this.buttonB.Enabled = false;
                    break;
                case "C":
                    if (colorButtom)
                    {
                        this.buttonC.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonC.BackColor = Color.Red;
                    }
                    this.buttonC.Enabled = false;
                    break;
                case "D":
                    if (colorButtom)
                    {
                        this.buttonD.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonD.BackColor = Color.Red;
                    }
                    this.buttonD.Enabled = false;
                    break;
                case "E":
                    if (colorButtom)
                    {
                        this.buttonE.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonE.BackColor = Color.Red;
                    }
                    this.buttonE.Enabled = false;
                    break;
                case "F":
                    if (colorButtom)
                    {
                        this.buttonF.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonF.BackColor = Color.Red;
                    }
                    this.buttonF.Enabled = false;
                    break;
                case "G":
                    if (colorButtom)
                    {
                        this.buttonG.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonG.BackColor = Color.Red;
                    }
                    this.buttonG.Enabled = false;
                    break;
                case "H":
                    if (colorButtom)
                    {
                        this.buttonH.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonH.BackColor = Color.Red;
                    }
                    this.buttonH.Enabled = false;
                    break;
                case "I":
                    if (colorButtom)
                    {
                        this.buttonI.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonI.BackColor = Color.Red;
                    }
                    this.buttonI.Enabled = false;
                    break;
                case "J":
                    if (colorButtom)
                    {
                        this.buttonJ.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonJ.BackColor = Color.Red;
                    }
                    this.buttonJ.Enabled = false;
                    break;
                case "K":
                    if (colorButtom)
                    {
                        this.buttonK.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonK.BackColor = Color.Red;
                    }
                    this.buttonK.Enabled = false;
                    break;
                case "L":
                    if (colorButtom)
                    {
                        this.buttonL.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonL.BackColor = Color.Red;
                    }
                    this.buttonL.Enabled = false;
                    break;
                case "M":
                    if (colorButtom)
                    {
                        this.buttonM.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonM.BackColor = Color.Red;
                    }
                    this.buttonM.Enabled = false;
                    break;
                case "N":
                    if (colorButtom)
                    {
                        this.buttonN.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonN.BackColor = Color.Red;
                    }
                    this.buttonN.Enabled = false;
                    break;
                case "Ñ":
                    if (colorButtom)
                    {
                        this.buttonÑ.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonÑ.BackColor = Color.Red;
                    }
                    this.buttonÑ.Enabled = false;
                    break;
                case "O":
                    if (colorButtom)
                    {
                        this.buttonO.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonO.BackColor = Color.Red;
                    }
                    this.buttonO.Enabled = false;
                    break;
                case "P":
                    if (colorButtom)
                    {
                        this.buttonP.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonP.BackColor = Color.Red;
                    }
                    this.buttonP.Enabled = false;
                    break;
                case "Q":
                    if (colorButtom)
                    {
                        this.buttonQ.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonQ.BackColor = Color.Red;
                    }
                    this.buttonQ.Enabled = false;
                    break;
                case "R":
                    if (colorButtom)
                    {
                        this.buttonR.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonR.BackColor = Color.Red;
                    }
                    this.buttonR.Enabled = false;
                    break;
                case "S":
                    if (colorButtom)
                    {
                        this.buttonS.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonS.BackColor = Color.Red;
                    }
                    this.buttonS.Enabled = false;
                    break;
                case "T":
                    if (colorButtom)
                    {
                        this.buttonT.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonT.BackColor = Color.Red;
                    }
                    this.buttonT.Enabled = false;
                    break;
                case "U":
                    if (colorButtom)
                    {
                        this.buttonU.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonU.BackColor = Color.Red;
                    }
                    this.buttonU.Enabled = false;
                    break;
                case "V":
                    if (colorButtom)
                    {
                        this.buttonV.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonV.BackColor = Color.Red;
                    }
                    this.buttonV.Enabled = false;
                    break;
                case "W":
                    if (colorButtom)
                    {
                        this.buttonW.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonW.BackColor = Color.Red;
                    }
                    this.buttonW.Enabled = false;
                    break;
                case "X":
                    if (colorButtom)
                    {
                        this.buttonX.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonX.BackColor = Color.Red;
                    }
                    this.buttonX.Enabled = false;
                    break;
                case "Y":
                    if (colorButtom)
                    {
                        this.buttonY.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonY.BackColor = Color.Red;
                    }
                    this.buttonY.Enabled = false;
                    break;
                case "Z":
                    if (colorButtom)
                    {
                        this.buttonZ.BackColor = Color.Green;
                    }
                    else
                    {
                        this.buttonZ.BackColor = Color.Red;
                    }
                    this.buttonZ.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        private void ResetButtoms()
        {
            this.buttonA.Enabled = true;
            this.buttonA.BackColor = Color.Snow;
            this.buttonB.Enabled = true;
            this.buttonB.BackColor = Color.Snow;
            this.buttonC.Enabled = true;
            this.buttonC.BackColor = Color.Snow;
            this.buttonD.Enabled = true;
            this.buttonD.BackColor = Color.Snow;
            this.buttonE.Enabled = true;
            this.buttonE.BackColor = Color.Snow;
            this.buttonF.Enabled = true;
            this.buttonF.BackColor = Color.Snow;
            this.buttonG.Enabled = true;
            this.buttonG.BackColor = Color.Snow;
            this.buttonH.Enabled = true;
            this.buttonH.BackColor = Color.Snow;
            this.buttonI.Enabled = true;
            this.buttonI.BackColor = Color.Snow;
            this.buttonJ.Enabled = true;
            this.buttonJ.BackColor = Color.Snow;
            this.buttonK.Enabled = true;
            this.buttonK.BackColor = Color.Snow;
            this.buttonL.Enabled = true;
            this.buttonL.BackColor = Color.Snow;
            this.buttonM.Enabled = true;
            this.buttonM.BackColor = Color.Snow;
            this.buttonN.Enabled = true;
            this.buttonN.BackColor = Color.Snow;
            this.buttonÑ.Enabled = true;
            this.buttonÑ.BackColor = Color.Snow;
            this.buttonO.Enabled = true;
            this.buttonO.BackColor = Color.Snow;
            this.buttonP.Enabled = true;
            this.buttonP.BackColor = Color.Snow;
            this.buttonQ.Enabled = true;
            this.buttonQ.BackColor = Color.Snow;
            this.buttonR.Enabled = true;
            this.buttonR.BackColor = Color.Snow;
            this.buttonS.Enabled = true;
            this.buttonS.BackColor = Color.Snow;
            this.buttonT.Enabled = true;
            this.buttonT.BackColor = Color.Snow;
            this.buttonU.Enabled = true;
            this.buttonU.BackColor = Color.Snow;
            this.buttonV.Enabled = true;
            this.buttonV.BackColor = Color.Snow;
            this.buttonW.Enabled = true;
            this.buttonW.BackColor = Color.Snow;
            this.buttonX.Enabled = true;
            this.buttonX.BackColor = Color.Snow;
            this.buttonY.Enabled = true;
            this.buttonY.BackColor = Color.Snow;
            this.buttonZ.Enabled = true;
            this.buttonZ.BackColor = Color.Snow;
        }
        private void juego1_Load(object sender, EventArgs e)
        {

        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            this.setDiccionario();
            this.juego.Palabra = juego.getPalabra(diccionario).ToUpper();
            this.label2.Visible = false;
            this.setDificultad();
            this.panelLetras.Enabled = true;
            this.panelJuego.Visible = true;
            this.panelLogin.Visible = false;
            this.buttonReset.Visible = false;
            this.fallosRestantes = 4;
            this.label1.Text = "INTENTOS RESTANTES: " + this.fallosRestantes;
            this.aciertos = 0;
            this.labelEndGame.Text = "GAME OVER!";
            this.labelEndGame.Visible = false;
            this.reiniciarAhorcado();
            this.textBoxPalabra.Text = "";
            for (int i = 0; i < this.juego.Palabra.Length; i++)
            {
                this.textBoxPalabra.Text += "_ ";
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            this.jugar(buttonA.Text);
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            this.jugar(buttonH.Text);
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            this.jugar(buttonO.Text);
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            this.jugar(buttonL.Text);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            this.jugar(buttonB.Text);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            this.jugar(buttonC.Text);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            this.jugar(buttonD.Text);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            this.jugar(buttonE.Text);
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            this.jugar(buttonF.Text);
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            this.jugar(buttonG.Text);
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            this.jugar(buttonI.Text);
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            this.jugar(buttonJ.Text);
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            this.jugar(buttonK.Text);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            this.jugar(buttonM.Text);
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            this.jugar(buttonN.Text);
        }

        private void buttonÑ_Click(object sender, EventArgs e)
        {
            this.jugar(buttonÑ.Text);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            this.jugar(buttonP.Text);
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            this.jugar(buttonQ.Text);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            this.jugar(buttonR.Text);
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            this.jugar(buttonS.Text);
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            this.jugar(buttonT.Text);
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            this.jugar(buttonU.Text);
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            this.jugar(buttonV.Text);
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            this.jugar(buttonW.Text);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.jugar(buttonX.Text);
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            this.jugar(buttonY.Text);
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            this.jugar(buttonZ.Text);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.labelEndGame.Visible = false;
            this.labelEndGame.Text = "GAME OVER!";
            this.buttonReset.Visible = false;
            this.panelJuego.Visible = false;
            this.panelLogin.Visible = true;
            this.panelLetras.Enabled = true;
        }
    }
}
