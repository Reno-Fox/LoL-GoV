using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

[XmlRoot("ChampionCollection")]
public class ChampionContainer {

    [XmlArray("Champions")]
    [XmlArrayItem("Champion")]
    public List<Champion> champions = new List<Champion>();

    public static ChampionContainer Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlSerializer serializer = new XmlSerializer(typeof(ChampionContainer));

        StringReader reader = new StringReader(_xml.text);

        ChampionContainer champions = serializer.Deserialize(reader) as ChampionContainer;

        reader.Close();

        return champions;
    }
}
