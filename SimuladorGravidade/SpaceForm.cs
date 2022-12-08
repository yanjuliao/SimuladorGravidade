using SimuladorGravidade.src;
using SimuladorGravitacional.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SpaceForm : Form
    {
        const string DADOS_ENTRADA_UNIVERSO = "Entrada.txt";
        Graphics graphics;
        Universo universo = new Universo();

        public SpaceForm()
        {
            InitializeComponent();
            this.InicializarEspaco();
        }

        public void InicializarEspaco()
        {
            string[] linhas = File.ReadAllLines(DADOS_ENTRADA_UNIVERSO);
            foreach (string linha in linhas)
            {
                if (linha == linhas[0])
                {
                    string[] universo = linha.Split(';');
                    this.universo.QtdCorpos = Convert.ToInt32(universo[0]);
                    this.universo.QtdIteracoes = Convert.ToInt32(universo[1]);
                    this.universo.Tempo = Convert.ToDouble(universo[2]);
                    if ((this.universo.QtdCorpos > 200) || (linhas.Length > 201))
                    {
                        throw new QtdCorposUltrapassadoException("A quantidade de corpos ultrapassou o limite permitido que é 200 corpos");
                    }
                    continue;
                }

                string[] infoCorpos = linha.Split(';');

                if ((Convert.ToDouble(infoCorpos[1]) > 500) || (Convert.ToDouble(infoCorpos[1]) < 1))
                {
                    throw new MassaUltrapassadaException("A massa é inválida. Somente aceitável entre 1 e 500");
                }

                Corpo corpo = new Corpo();
                corpo.setNome(infoCorpos[0]);
                corpo.setMassa(Convert.ToDouble(infoCorpos[1]));
                corpo.setDensidade(Convert.ToDouble(infoCorpos[2]));
                corpo.setPosicaoX(Convert.ToDouble(infoCorpos[3]));
                corpo.setPosicaoY(Convert.ToDouble(infoCorpos[4]));
                corpo.setVelocidadeX(Convert.ToDouble(infoCorpos[5]));
                corpo.setVelocidadeY(Convert.ToDouble(infoCorpos[6]));
                
                universo.corpos.Add(corpo);

                this.Refresh();
            }
        }

        private void SpaceForm_Paint_1(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics; 
            foreach (Corpo c in universo.corpos)
            {
                if(c.getColor() != Color.SkyBlue)
                {
                    c.setColor(Color.Gold);
                }

                double diametro = c.getRaio() * 2;
                double raio = c.getRaio();
                RectangleF retangulo = new RectangleF((float)(c.getPosicaoX() - raio), (float)(c.getPosicaoY() - raio), (float)diametro, (float)diametro);
                graphics.FillEllipse(new SolidBrush(c.getColor()), retangulo);
                graphics.DrawEllipse(new Pen(c.getColor()), retangulo);
            }
        }

        public void Iniciar()
        {
            for(int i = 0; i < universo.QtdIteracoes; i++)
            {
                lblIteracao.Text = ((i + 1).ToString());
                lblQtdCorpos.Text = (universo.corpos.Count.ToString());
                foreach (Corpo c in universo.corpos.ToList())
                {
                    universo.IteracaoGravitacional(c);
                    universo.VerificaColisao();
                    this.Refresh();
                }
            }
        }

        private void BtnIniciar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Iniciar();
        }
    }
}
