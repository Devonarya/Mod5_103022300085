using System;
using System.Collections;
using System.Collections.Generic;


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
        SimpleDataBase<double> simpleDataBase = new SimpleDataBase<double>();
        simpleDataBase.addNewData(1.0);
        simpleDataBase.addNewData(2.0);
        simpleDataBase.addNewData(3.0);

        simpleDataBase.printAllData();
    }
}

