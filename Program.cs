using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Teste do Iphone:
Iphone iphone = new Iphone(numero: "11122233", modelo: "Modelo 1", imei: "789456", memoria: 128);
Console.WriteLine($"Iphone criado com sucesso!");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");


//Teste do Nokia:
Nokia nokia = new Nokia(numero: "11122233", modelo: "Modelo 1", imei: "789456", memoria: 128);
Console.WriteLine("---------");
Console.WriteLine($"Nokia criado com sucesso!");
nokia.Ligar();
nokia.InstalarAplicativo("Netflix");
nokia.ReceberLigacao();