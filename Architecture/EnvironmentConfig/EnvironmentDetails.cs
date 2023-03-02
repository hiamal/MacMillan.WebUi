using System.IO;
using Newtonsoft.Json;
using System.Reflection;
using System.Collections.Generic;
using System;

namespace Architecture.EnvironmentConfig
{

// define a class to represent the configuration object
    public static class EnvironmentDetails
    {
        private static string EnvironmentName = "prod";
        // Get the directory of the current file
        private static string currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        // Navigate to the TestData folder relative to the current file
        private static string testDataDirectory = Path.Combine(currentDirectory, "..", "..", "..", "..", "Architecture", "EnvironmentConfig");

        // Get the full path to the test file in TestData folder under Architecture
        private static string filePath = Path.GetFullPath(Path.Combine(testDataDirectory, "config.json"));
        
        // read the configuration file into a string
        private static string ConfigFile = File.ReadAllText(filePath);

        // deserialize the JSON into an EnvironmentConfig object
        private static EnvironmentConfig config = JsonConvert.DeserializeObject<EnvironmentConfig>(ConfigFile);

        private static Environment EnvironmentData {
            get{
                foreach (Environment env in config.Environments)
                    if (env.Name.Equals(EnvironmentName, StringComparison.OrdinalIgnoreCase))
                        return env;
                return null;
            }
        }

        // use the configuration values in your code
        public static string Environment => EnvironmentData.Name;
        public static string BaseUrl => EnvironmentData.BaseUrl;
        public static string Username => EnvironmentData.Username;
        public static string Password => EnvironmentData.Password;

    }

    public class Environment
    {
        public string Name { get; set; }
        public string BaseUrl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class EnvironmentConfig{
        public List<Environment> Environments { get; set; }

    }
}