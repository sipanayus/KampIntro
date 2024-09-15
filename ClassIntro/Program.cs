// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Threading.Channels;

string adi = "sipan";
int yas = 28;

Kurs kurs1 = new Kurs(); //kurs1 tipi Kurs
kurs1.KursAdi = "c#";
kurs1.Egitmen = "sipan";
kurs1.IzlenmeOrani = 100;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "java";
kurs2.Egitmen = "jake";
kurs2.IzlenmeOrani = 78;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "python";
kurs3.Egitmen = "jhonson";
kurs3.IzlenmeOrani = 73;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "html";
kurs4.Egitmen = "anna";
kurs4.IzlenmeOrani = 86;
 

//Console.WriteLine(kurs1.KursAdi +" : "+ kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1 , kurs2, kurs3 , kurs4 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + ":"+ kurs.Egitmen);
}
    
 


class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}
