using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class WBSettings
{
    public string DefaultPageText1 { get; set; }
    public string DefaultPageText2 { get; set; }
    public string HeaderText { get; set; }
    public string FooterText { get; set; }
}

    public class Manager
    {
        
        public static WBSettings LoadSettings(string FilePath)
        {
            WBSettings Settings = new WBSettings();
            try
            {
                
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(WBSettings));
                System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
                Settings = (WBSettings)reader.Deserialize(file);

                file.Close();
                return Settings;
            }
            catch(Exception)
            {
                return Settings;
            }
        }
        public static void SaveSettings(string FilePath,WBSettings SettingObj)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(WBSettings));
            System.IO.FileStream file = System.IO.File.Create(FilePath);
            writer.Serialize(file, SettingObj);

            file.Close();
        }
    }
