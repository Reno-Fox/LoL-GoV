using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Card {

    [XmlAttribute("name")]
    public string name;

    [XmlElement("Attack")]
    public float attack;

    [XmlElement("Health")]
    public float health;



}
