using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103082400020
{
    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public void ReadJSON()
    {
        string filePath = "Tp7_103082400020.json";

        string jsonString = File.ReadAllText(filePath);

        DataMahasiswa103082400020 data = JsonSerializer.Deserialize<DataMahasiswa103082400020>(jsonString);

        // 4. Mencetak ke layar
        Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
    }
}
