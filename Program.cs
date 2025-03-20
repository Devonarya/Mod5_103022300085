using System;
using System.Collections;
using System.Collections.Generic;
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


public class SimpleDataBase<T> 
{
    private List<T> StoredData;
    List <DateTime> InputDate;
    public SimpleDataBase()
    {
        StoredData = new List<T>();
        InputDate = new List<DateTime>();
    }

    public void addNewData(T data)
    { 
        StoredData.Add(data);
        InputDate.Add(DateTime.Now);
    }

    public void printAllData() 
    {
        int i = 0;
        foreach (var data in StoredData) 
        {
            Console.WriteLine(StoredData[i]);
            Console.WriteLine(InputDate[i]);
            i++;
        }
    }
}
public class Program
{ 
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

        SimpleDataBase<double> simpleDataBase = new SimpleDataBase<double>();
        simpleDataBase.addNewData(1.0);
        simpleDataBase.addNewData(2.0);
        simpleDataBase.addNewData(3.0);

        simpleDataBase.printAllData();
    }
}

