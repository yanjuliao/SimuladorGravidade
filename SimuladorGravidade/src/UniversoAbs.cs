namespace SimuladorGravitacional.src
{
    abstract class UniversoAbstrato
    {
        public abstract double CalcularForca(Corpo corpo1, Corpo corpo2);
        public abstract void IteracaoGravitacional(Corpo corpo);
        public abstract double CalcularDistancia(Corpo corpo1, Corpo corpo2);
    }
}
