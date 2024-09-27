using FinalExamPracticalMAUIApp1.ProvidedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPracticalMAUIApp1.Models
{
    public static class FoodWeb
    {

        public static void LoadOrganismsData()
        {
            // Stream provided for you. Note that this method does not use async.
            Stream fileStream = FileSystem.Current.OpenAppPackageFileAsync("OrganismsData.csv").Result;
        }

        public static List<Organism> Organisms { get; private set; } = new List<Organism>();

        public static void LoadOrganismsData(string csvFilePath)
        {
            try
            {
                Organisms.Clear();

                var lines = File.ReadAllLines(csvFilePath);
                foreach (var line in lines.Skip(1))
                {
                    var parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        var name = parts[0];
                        var scientificName = parts[1];
                        var type = parts[2];
                        var imageUrl = parts[3];

                        switch (type.ToLower())
                        {
                            case "herbivore":
                                var herbivore = new Herbivore
                                {
                                    Name = name,
                                    ScientificName = scientificName,

                                };
                                Organisms.Add(herbivore);
                                break;

                            case "omnivore":
                                var omnivore = new Omnivore
                                {
                                    Name = name,
                                    ScientificName = scientificName,

                                };
                                Organisms.Add(omnivore);
                                break;

                            case "carnivore":
                                var carnivore = new Carnivore
                                {
                                    Name = name,
                                    ScientificName = scientificName,

                                };
                                Organisms.Add(carnivore);
                                break;

                            case "producer":
                                var producer = new Producer
                                {
                                    Name = name,
                                    ScientificName = scientificName,

                                };
                                Organisms.Add(producer);
                                break;

                            default:
                                Console.WriteLine($"Unknown organism type:{type}");
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading organisms data: {ex.Message}");
            }
        }
    }
}
