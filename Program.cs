// See https://aka.ms/new-console-template for more information
public class PemrosesData { 
    public void DapatkanNilaiTerbesar<T>(T ni,T La,T ai) 
    {
        dynamic E = ni;
        dynamic F = La;
        dynamic G = ai;
        dynamic terbesar = E;

        if (Convert.ToDouble(terbesar) < Convert.ToDouble(F))
        {
             terbesar = F;
        }
         if (Convert.ToDouble(terbesar) < Convert.ToDouble(G))
        {
             terbesar = G;
        }

        Console.WriteLine(terbesar);
    }
}


public class Program {
    public static void Main()
    {
        String a1, a2, a3;
        PemrosesData pemrosesData = new PemrosesData();

        Console.WriteLine("masukan nilai pertama: ");
        a1 = Console.ReadLine();
        Console.WriteLine("masukan nilai kedua: ");
        a2 = Console.ReadLine();
        Console.WriteLine("masukan nilai ketiga: ");
        a3 = Console.ReadLine();

        pemrosesData.DapatkanNilaiTerbesar(a1 ,a2,a3);
    }
}