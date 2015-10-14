using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Champion {

    [XmlElement("ID")]
    public float ID;

    [XmlAttribute("name")]
    public string name;

    [XmlElement("picture")]
    public float picture;

    [XmlElement("attack")]
    public float attack;

    [XmlElement("health")]
    public float health;

    [XmlElement("delay")]
    public float delay;

    [XmlElement("rarity")]
    public float rarity;

    [XmlElement("type")]
    public float type;

    [XmlElement("set")]
    public float set;

    [XmlElement("skill")]
    public float skill;

    [XmlElement("skill2")]
    public float skill2;
}