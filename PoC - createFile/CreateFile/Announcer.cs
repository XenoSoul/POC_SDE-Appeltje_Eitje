using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace CreateFile
{
    public class People
    {
        public string Fn { get; set; }
        public string Ln { get; set; }
    }
    public static class Announcer
    {
        public static void Announcers()
        {
            var jsonString = File.ReadAllText(@"D:\School\High School\Year 2\SDE - Software & Development\PoC\PoC - createFile\CreateFile\Hellya.json");
            var weatherForecast = JsonSerializer.Deserialize<People>(jsonString);
            Console.WriteLine(weatherForecast);

            var fileData = new List<Person>();
            fileData.Add(new Person(1, "Josh", "Hasselaar"));
            fileData.Add(new Person(2, "Yoeri", "Sanz Walter"));

            string json = JsonConvert.SerializeObject(fileData.ToArray());

            //write string to file
            System.IO.File.WriteAllText(@"D:\School\High School\Year 2\SDE - Software & Development\PoC\PoC - createFile\CreateFolder_Test\personTest.json", json);

            Process pdfProcess = new Process();
            pdfProcess.StartInfo.FileName = @"C:\Program Files (x86)\Foxit Software\Foxit Reader\Foxit Reader.exe";
            pdfProcess.StartInfo.Arguments = string.Format(@"-p {0}", @"D:\D&D\Files\Project Players Handbook V1.1/Players Handbook 1.1 Back Cover - No Art");
            pdfProcess.Start();

            /*File.WriteAllText(@"D:\School\High School\Year 2\SDE - Software & Development\PoC\PoC - createFile\CreateFolder_Test\personTest.json", JsonConverter.SerializeObject(fileData));

            using (var file = File.CreateText(@"D:\School\High School\Year 2\SDE - Software & Development\PoC\PoC - createFile\CreateFolder_Test\personTest.json"))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, fileData);
            }*/

        }
    }
}
