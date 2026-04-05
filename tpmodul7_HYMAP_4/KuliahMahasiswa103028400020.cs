using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class KuliahMahasiswa103082400020
{
    public List<Course> courses { get; set; }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public void ReadJSON()
    {
        string filePath = "Tp7_2_103082400020.json";
        string jsonString = File.ReadAllText(filePath);

        KuliahMahasiswa103082400020 data = JsonSerializer.Deserialize<KuliahMahasiswa103082400020>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var course in data.courses)
        {
            Console.WriteLine($"MK {i} {course.code} - {course.name}");
            i++;
        }
    }
}