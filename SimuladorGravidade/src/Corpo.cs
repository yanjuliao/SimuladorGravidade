using System.Numerics;
using System.Security.Policy;

namespace SimuladorGravitacional.src
{
    internal class Corpo : CorpoAbstrato
    {
        private string Nome;
        private double Massa;
        private double Densidade;
        private double PosicaoX;
        private double PosicaoY;
        private double VelocidadeX;
        private double VelocidadeY;
        private double ForcaX;
        private double ForcaY;
        private Color color;

        public override string getNome()
        {
            return this.Nome;
        }
        public override double getMassa()
        {
            return this.Massa;
        }

        public override double getVelocidadeX()
        {
            return this.VelocidadeX;
        }

        public override double getVelocidadeY()
        {
            return this.VelocidadeY;
        }

        public override double getPosicaoX()
        {
            return this.PosicaoX;
        }

        public override double getPosicaoY()
        {
            return this.PosicaoY;
        }

        public Color getColor()
        {
            return this.color;
        }

        public override double getDensidade()
        {
            return this.Densidade;
        }

        public override double getRaio()
        {
            //V = M/D
            double V = this.Massa / this.Densidade;

            //raio a partir do volume = ((V/π)(3/4))1/3
            return Math.Pow(V / ((4.0 / 3.0) * Math.PI), 1.0 / 3.0);
        }

        public override double getForcaX()
        {
            return this.ForcaX;
        }

        public override double getForcaY()
        {
            return this.ForcaY;
        }

        public void setMassa(double massa)
        {
            this.Massa = massa;
        }
        public override void setVelocidadeX(double velocidadeX)
        {
            this.VelocidadeX = velocidadeX;
        }

        public override void setVelocidadeY(double velocidadeY)
        {
            this.VelocidadeY = velocidadeY;
        }

        public override void setPosicaoX(double posicaoX)
        {
            this.PosicaoX = posicaoX;
        }

        public override void setPosicaoY(double posicaoY)
        {
            this.PosicaoY = posicaoY;
        }

        public override void setDensidade(double densidade)
        {
            this.Densidade = densidade;
        }

        public override void setForcaX(double forcaX)
        {
            this.ForcaX += forcaX; 
        }

        public override void setForcaY(double forcaY)
        {
            this.ForcaY += forcaY;
        }

        public override void setNome(string nome)
        {
            this.Nome = nome;
        }

        public void setColor(Color color)
        {
            this.color = color;
        }

        public static Corpo operator +(Corpo c1, Corpo c2)
        {
            Corpo novoCorpo = new Corpo();
            novoCorpo.setMassa(c1.getMassa() + c2.getMassa());
            novoCorpo.setDensidade(c1.getDensidade() + c2.getDensidade());
            novoCorpo.setNome(string.Concat(c2.getNome(), c1.getNome()));
            //Posição do centro da Massa -----------(m1*p1)+(m2*p2)/m1+m2 ------------
            novoCorpo.setPosicaoX(((c1.getMassa() * c1.getPosicaoX()) + (c2.getMassa() * c2.getPosicaoX())) / (novoCorpo.getMassa()));
            novoCorpo.setPosicaoY(((c1.getMassa() * c1.getPosicaoY()) + (c2.getMassa() * c2.getPosicaoY())) / (novoCorpo.getMassa()));
            //Quantidade de movimento ----------- Q = (m1*v1)+(m2*v2)/m1+m2 ----------
            novoCorpo.setVelocidadeX(((c1.getMassa() * c1.getVelocidadeX()) + (c2.getMassa() * c2.getVelocidadeX())) / (c1.getMassa() + c2.getMassa()));
            novoCorpo.setVelocidadeY(((c1.getMassa() * c1.getVelocidadeY()) + (c2.getMassa() * c2.getVelocidadeY())) / (c1.getMassa() + c2.getMassa()));
            novoCorpo.setColor(Color.SkyBlue);

            return novoCorpo;
        }
    }
}
