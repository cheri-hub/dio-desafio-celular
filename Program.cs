using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11999999999", modelo: "Nokia Tijolão", imei: "111111111111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone(numero: "11988888888", modelo: "iPhone 14", imei: "222222222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");