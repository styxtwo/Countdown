using CountDown.Domain;
using CountDown.Domain.Api;
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace XMLPersistence {
    class DateData : IDateData {
        private static readonly string FILE_NAME = "date.xml";
        private static readonly string FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CountDown";
        private static readonly string FILE_LOCATION = FOLDER + @"\" + FILE_NAME;

        private static readonly DateTime DEFAULT_DATE = DateTime.Today;
        private static readonly String DEFAULT_NAME = "";
        private static readonly Unit DEFAULT_UNIT = Unit.Days;

        private DateTime dateTime;
        private String name;
        private Unit unit;

        public DateData() {
            System.Diagnostics.Debug.WriteLine(FOLDER);
            if (!Directory.Exists(FOLDER)) {
                System.Diagnostics.Debug.WriteLine(FOLDER);
                Directory.CreateDirectory(FOLDER);
            }
            if (File.Exists(FILE_LOCATION)) {
                ReadValues();
                return;
            }
            CreateNewFile();
        }

        private void CreateNewFile() {
            dateTime = DEFAULT_DATE;
            name = DEFAULT_NAME;
            unit = DEFAULT_UNIT;
            Save();
        }

        private void ReadValues() {
            using (XmlReader reader = XmlReader.Create(FILE_LOCATION)) {
                while (reader.Read()) {
                    if (reader.IsStartElement()) {
                        switch (reader.Name) {
                            case "DateTime":
                                if (reader.Read()) {
                                    dateTime = DateTime.Parse(reader.Value.Trim());
                                }
                                break;
                            case "Name":
                                if (reader.Read()) {
                                    name = reader.Value;
                                }
                                break;
                            case "Unit":
                                if (reader.Read()) {
                                    bool success = Enum.TryParse(reader.Value, true, out unit);
                                    if (!success) {
                                        throw (new ArgumentException("Unable to parse: " + reader.Value));
                                    }
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void Save() {
            using (XmlWriter writer = XmlWriter.Create(FILE_LOCATION)) {
                writer.WriteStartDocument();
                writer.WriteStartElement("Date");

                writer.WriteElementString("DateTime", dateTime.ToString());
                writer.WriteElementString("Unit", unit.ToString());
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

        public Unit MainUnit {
            get {
                return unit;
            }
            set {
                unit = value;
                Save();
            }
        }
    }
}
