using DesafioPOO.Models;

namespace DesafioPOO
{
    internal static class Program
    {
        static void Main(){
            
           Nokia nokia = new Nokia("8199995557");
           nokia.Ligar();
           nokia.InstalarAplicativo("whatsapp");
           Iphone iphone = new Iphone("8198883874");
           iphone.ReceberLigacao();
           iphone.InstalarAplicativo("Whatsapp");
        }
    }
}


