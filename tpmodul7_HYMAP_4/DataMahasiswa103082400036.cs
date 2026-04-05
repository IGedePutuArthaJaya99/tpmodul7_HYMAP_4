using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103082400036
{
    // Properti ini harus sama persis namanya dengan yang ada di file JSON
    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    // Class bersarang karena "nama" di JSON memiliki "depan" dan "belakang"
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    // Method untuk membaca file JSON
    public void ReadJSON()
    {
        // 1. Menentukan nama file yang mau dibaca
        string filePath = "Tp7_103082400036.json";

        // 2. Membaca seluruh teks di dalam file
        string jsonString = File.ReadAllText(filePath);

        // 3. Mengubah teks JSON menjadi object C# (Deserialisasi)
        DataMahasiswa103082400036 data = JsonSerializer.Deserialize<DataMahasiswa103082400036>(jsonString);

        // 4. Mencetak ke layar
        Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
    }
}