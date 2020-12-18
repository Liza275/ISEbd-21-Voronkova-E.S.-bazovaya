using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class AirportCollection
    {
        readonly Dictionary<string, Airport<Plane>> parkingStages;
        public List<string> Keys => parkingStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly char separator = ':';
        public AirportCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Airport<Plane>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddAirport(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Airport<Plane>(pictureWidth, pictureHeight));
        }

        public void DelAirport(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public Airport<Plane> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }

        }
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("AirportCollection");
                foreach (var level in parkingStages)
                {
                    sw.WriteLine($"Airport{separator}{level.Key}");
                    foreach (IFlyingTransport plane in level.Value)
                    {
                        if (plane != null)
                        {
                            if (plane.GetType().Name == "WarPlane")
                            {
                                sw.Write($"WarPlane{separator}");
                            }
                            if (plane.GetType().Name == "Fighter")
                            {
                                sw.Write($"Fighter{separator}");
                            }
                            sw.WriteLine(plane);
                        }
                    }
                }
            }
        }
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.UTF8))
            {
                string line = sr.ReadLine();
                if (line.Contains("AirportCollection"))
                {
                    parkingStages.Clear();
                }
                else
                {
                    throw new FormatException();
                }
                Plane plane = null;
                string key = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Airport"))
                    {
                        key = line.Split(separator)[1];
                        parkingStages.Add(key, new Airport<Plane>(pictureWidth,
                        pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(separator)[0] == "WarPlane")
                    {
                        plane = new WarPlane(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "Fighter")
                    {
                        plane = new Fighter(line.Split(separator)[1]);
                    }
                    var result = parkingStages[key] + plane;
                    if (!result)
                    {
                        throw new AirportOverflowException();
                    }
                }
            }
        }
    }
}
