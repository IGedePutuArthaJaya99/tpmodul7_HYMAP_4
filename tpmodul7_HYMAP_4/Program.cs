class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103082400036 dataMahasiswa = new DataMahasiswa103082400036();
        dataMahasiswa.ReadJSON();

        Console.WriteLine();

        KuliahMahasiswa103082400036 kuliahMahasiswa = new KuliahMahasiswa103082400036();
        kuliahMahasiswa.ReadJSON();
    }
}