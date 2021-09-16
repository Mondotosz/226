using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace SchoolManagement
{
    public class Storage
    {
        private string _path;

        public String Path
        {
            get => _path;
            set
            {
                _path = value;
            }
        }
        public Storage(string path)
        {
            Path = path;
        }

        public List<Object> Load()
        {
            using (var reader = new StreamReader(_path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<dynamic>().Cast<Object>().ToList();
            }
        }
        public void Save(List<Object> content)
        {
            using (var writer = new StreamWriter(_path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(content);
            }
        }
    }
}
