using ProjetoPOOSmartPhone.Models;

Nokia nPhone = new Nokia("2799981-2530", "Nokia 5.3", "357278086773968", 128 );

nPhone.Ligar();
nPhone.ReceberLigacao();
nPhone.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone("2799981-2530", "Iphone X", "357278086773500", 128 );

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
