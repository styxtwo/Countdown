using CountDown.Domain;
using CountDown.Domain.Api;
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace XMLPersistence {
    class DateData : IDateData {
        private static readonly string FILE_NAME = "date.xml";
        private static readonly string FILE_PATH = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly string FILE_LOCATION = FILE_PATH + @"\" + FILE_NAME;

        private static readonly DateTime DEFAULT_DATE = DateTime.Today;
        private static readonly String DEFAULT_NAME = "";
        private static readonly Unit DEFAULT_UNIT = Unit.Days;

        private DateTime dateTime;
        private String name;
        private Unit unit;

        public DateData() {
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
                    System.Diagnostics.Debug.WriteLine("Read" + reader.Value);
                    if (reader.IsStartElement()) {
                        switch (reader.Name) {
                            case "DateTime":
                                System.Diagnostics.Debug.WriteLine("DateTime");
                                if (reader.Read()) {
                                    dateTime = DateTime.Parse(reader.Value.Trim());
                                }
                                break;
                            case "Name":
                                System.Diagnostics.Debug.WriteLine("Name");
                                if (reader.Read()) {
                                    name = reader.Value;
                                    System.Diagnostics.Debug.WriteLine("VAL:" + reader.Value);
                                }
                                break;
                            case "Unit":
                                System.Diagnostics.Debug.WriteLine("UNIT");
                                if (reader.Read()) {
                                    bool success = Enum.TryParse(reader.Value, true, out unit);
                                    if (!success) {
                                        System.Diagnostics.Debug.WriteLine("ERROOOOROROORO");
                                        throw (new ArgumentException("Unable to parse: " + reader.Value));
                                    }
                                    System.Diagnostics.Debug.WriteLine("PARSED TO: "+ unit);
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
