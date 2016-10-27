using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ProjectModels.Model;

namespace ProjectModels
{
    /// <summary>
    /// Class to handle various utility like things like serializing and deserializing the various model types
    /// </summary>
    public class Support
    {
        public static Project LoadFromDisk(string filename)
        {
            Project result;
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                result = (Project)formatter.Deserialize(stream);
            }
            return result;
        }


        public static void SaveToDisk(string filename, Project project)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, project);
            stream.Close();
        }
    }
}
