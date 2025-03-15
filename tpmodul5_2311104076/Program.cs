using System;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Alya"); // Ganti dengan nama panggilanmu

        // Simpan NIM dalam DataGeneric
        DataGeneric<string> dataNIM = new DataGeneric<string>("2311104076");

        // Panggil method PrintData()
        dataNIM.PrintData();
    }
}

