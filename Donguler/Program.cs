// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


string kurs1 = "yazılım kursu";
string kurs2 = "programlama temel kursu";
string kurs3 = "java";


string[] kurslar = new string[] { "yazılım kursu" , "programlama temel kursu" , "java" , "python" , "C#" };

 for (int i = 0;    i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}


Console.WriteLine("for bitti");

foreach (string kurs in kurslar)  //kursları dolaş demek
{
    Console.WriteLine(kurs );
}

Console.WriteLine(  "sayfa sonu footer");