using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var iphoneDoJose = new Iphone("11999998888", "Iphone X", "111111111111", 8);
var nokiaDaMaria = new Nokia("21988886666", "Nokia X", "222222222222", 16);
var nomeDoApp = "Whatsapp";
    
iphoneDoJose.Ligar();
iphoneDoJose.ReceberLigacao();
iphoneDoJose.InstalarAplicativo(nomeDoApp);
iphoneDoJose.MostraConfiguracao(iphoneDoJose.Modelo, iphoneDoJose.Memoria);

Console.WriteLine("\n");

nokiaDaMaria.Ligar();
nokiaDaMaria.ReceberLigacao();
nokiaDaMaria.InstalarAplicativo(nomeDoApp);
nokiaDaMaria.MostraConfiguracao(nokiaDaMaria.Modelo, nokiaDaMaria.Memoria);