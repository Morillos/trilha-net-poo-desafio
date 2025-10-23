namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor que repassa o número exigido pela classe base
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando {nomeApp} no Nokia.");
        }
    }
}