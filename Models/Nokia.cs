namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //IMPLEMENTADO
    public class Nokia(string numero, string modelo, string imei, int memoria) : Smartphone(numero, modelo, imei, memoria)
    {

        // TODO: Sobrescrever o método "InstalarAplicativo"
        //IMPLEMENTADO
        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia.");
        }
    }
}