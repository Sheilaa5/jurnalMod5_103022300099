using System;

public class SimpleDataBase<T>
{
    private List<T> StoredDataBase;
    private List<DateTime> inputDates;

    public void AddNewData(T data)
    {
        StoredDataBase.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < StoredDataBase.Count; i++)
        {
            Console.WriteLine("Data: " + (i + 1) + "berisi " + StoredDataBase[i] + "yang disimpan pada waktu UTC: " + inputDates[i]);
        }

    }
}

public class program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<long> data = new SimpleDataBase<long>();
        data.AddNewData(10);
        data.AddNewData(20);
        data.AddNewData(30);
        data.PrintAllData();
    }
}