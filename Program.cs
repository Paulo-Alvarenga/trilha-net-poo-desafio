using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//IMPLEMENTADO
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "332213", modelo: "Modelo 1", imei: "11111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Ifood");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "937128", modelo: "Modelo 2", imei: "22222222", memoria: 264);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube music");