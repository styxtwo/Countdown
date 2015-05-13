using CountDown.Domain.Api;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLPersistence {
    class DateData : IDateData {
        private static readonly string FILE_NAME = "date.xml";
        private static readonly DateTime DEFAULT_DATE = DateTime.Today;
        private static readonly String DEFAULT_NAME = "";
        private DateTime dateTime;
        private String name;

        public DateData() {
            if (File.Exists(FILE_NAME)) {
                ReadValues();
                return;
            }
            DateTime = DEFAULT_DATE;
            Name = DEFAULT_NAME;
        }

        private void ReadValues() {
            using (XmlReader reader = XmlReader.Create(FILE_NAME)) {
                while (reader.Read()) {
                    if (reader.IsStartElement()) {
                        switch (reader.Name) {
                            case "DateTime":
                                System.Diagnostics.Debug.WriteLine("Val: "+reader.Value.Trim());
                                if (reader.Read()) {
                                    dateTime = DateTime.Parse(reader.Value.Trim());
                                }
                                break;
                            case "Name":
                                if (reader.Read()) {
                                    name = reader.Value;
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void Save() {
            using (XmlWriter writer = XmlWriter.Create(FILE_NAME)) {
                writer.WriteStartDocument();
                writer.WriteStartElement("Date");

                writer.WriteElementString("DateTime", dateTime.ToString());
                writer.WriteElementString("Name", name);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public DateTime DateTime {
            get {
                return dateTime;
            }
            set {
                dateTime = value;
                Save();
            }
        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
                Save();
            }
        }
    }
}
