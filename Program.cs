using DesafioPOO.Models;

Console.WriteLine("Smartphone NOKIA:");
Smartphone nokia = new Nokia(numero: "(11)99999-8888" , modelo: "M1" , imei: "123456789" , memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPHONE:");
Smartphone iphone = new Iphone(numero: "(11)99999-7777" , modelo: "15" , imei: "542352253" , memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
