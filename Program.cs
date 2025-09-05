// See https://aka.ms/new-console-template for more information
using SISTEMA_SMARTPHONE.Models;

Console.WriteLine("Instanciando o IPHONE");
Iphone iphone = new Iphone(numero: "123654", modelo: "IPHONE 15", imei: "1245", memoria: 225);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine();
Console.WriteLine("Instanciando o NOKIA");
Nokia nokia = new Nokia(numero : "987456", modelo: "NO24", imei: "4567", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");