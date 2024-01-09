namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
            base.Numero = numero;
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine("instalando aplicativo");
        }
    }
}