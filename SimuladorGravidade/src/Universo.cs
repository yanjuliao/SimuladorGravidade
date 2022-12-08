using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SimuladorGravitacional.src
{
    internal class Universo : UniversoAbstrato
    {
        private double gravidade = 6.674184 * (Math.Pow(10, -11));
        public int QtdCorpos;
        public int QtdIteracoes;
        public double Tempo;
        public List<Corpo> corpos = new List<Corpo>();

        public override void IteracaoGravitacional(Corpo corpo)
        {
            foreach(Corpo c in this.corpos)
            {
                if (c != corpo)
                {
                    corpo.setForcaX(CalcularForca(corpo, c));
                    corpo.setForcaY(CalcularForca(corpo, c));
                }
            }
            AplicaForca(corpo);
        }

        public override double CalcularForca(Corpo corpo1, Corpo corpo2)
        {
            double distancia = CalcularDistancia(corpo1, corpo2);
            //F = G * M1 * M2 / R²
            double forcaG = (gravidade * corpo1.getMassa() * corpo2.getMassa()) / (distancia * distancia);
            return forcaG;
        }

        public override double CalcularDistancia(Corpo corpo1, Corpo corpo2)
        {
            return Math.Sqrt(Math.Pow((corpo1.getPosicaoX() - corpo2.getPosicaoX()), 2) + Math.Pow((corpo1.getPosicaoY() - corpo2.getPosicaoY()), 2));
        }

        public void AplicaForca(Corpo corpo)
        {
            //A = F / M
            double aceleracaoX = corpo.getForcaX() / corpo.getMassa();
            double aceleracaoY = corpo.getForcaY() / corpo.getMassa();

            //V = V.ini + ▲T
            double velocidadeX = corpo.getVelocidadeX() + (aceleracaoX * Tempo);
            double velocidadeY = corpo.getVelocidadeY() + (aceleracaoY * Tempo);
            corpo.setVelocidadeX(velocidadeX);
            corpo.setVelocidadeY(velocidadeY);

            //S = S.ini + V.ini * t + a/2 * t²
            double posicaoX = corpo.getPosicaoX() + (corpo.getVelocidadeX() * Tempo) + ((aceleracaoX / 2) * (Tempo * Tempo));
            double posicaoY = corpo.getPosicaoY() + (corpo.getVelocidadeY() * Tempo) + ((aceleracaoY / 2 ) * (Tempo * Tempo));
            corpo.setPosicaoX(posicaoX);
            corpo.setPosicaoY(posicaoY);
        }

        public void VerificaColisao()
        {
            for (int i = 0; i < this.corpos.Count; i++)
            {

                foreach (Corpo c in this.corpos.ToList())
                {
                    if (c != this.corpos[i])
                    {
                        double distancia = CalcularDistancia(this.corpos[i], c);                      

                        if (distancia < this.corpos[i].getRaio() + c.getRaio())
                        {
                            Corpo novoCorpo = this.corpos[i] + c;

                            this.corpos.Add(novoCorpo);
                            this.corpos.RemoveAll((x) => x.getNome() == c.getNome());
                            this.corpos.RemoveAll((x) => x.getNome() == this.corpos[i].getNome());
                        }
                    }
                }
            }
        }
    }
}
