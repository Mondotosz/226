using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace SchoolManagement
{
    public class Storage<T>
    {
        private string _filePath;

        public String FilePath
        {
            get => _filePath;
            set
            {
                _filePath = value;
            }
        }
        public Storage(string path)
        {
            FilePath = path;
        }

        public List<T> Load()
        {
            List<T> records = new List<T>();
            if (File.Exists(_filePath))
            {
                using (var reader = new StreamReader(_filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<TMap>();
                    records = csv.GetRecords<T>()
                        .Cast<T>()
                        .ToList();
                }
            }
            return records;
        }
        public void Save(List<T> content)
        {
            using (var writer = new StreamWriter(_filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(content);
            }
        }
    }
}
