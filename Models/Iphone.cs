namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
            base.Numero = numero;
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine("instalando aplicativo");
        }
    }
}