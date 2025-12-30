using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("1191824501", "Iphone 15", "73829", "128");
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Nokia nokia = new Nokia("11974832618", "S25 Ultra", "74819", "256");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");