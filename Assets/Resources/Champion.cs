using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Champion {

    [XmlAttribute("Name")]
    public string Name;

    [XmlElement("HP")]
    public float HP;

    [XmlElement("HPL")]
    public float HPL;

    [XmlElement("HPR")]
    public float HPR;

    [XmlElement("HPRL")]
    public float HPRL;

    [XmlElement("MP")]
    public float MP;

    [XmlElement("MPL")]
    public float MPL;

    [XmlElement("MPR")]
    public float MPR;

    [XmlElement("MPRL")]
    public float MPRL;

    [XmlElement("AD")]
    public float AD;

    [XmlElement("ADL")]
    public float ADL;

    [XmlElement("AS")]
    public float AS;

    [XmlElement("ASL")]
    public float ASL;

    [XmlElement("AR")]
    public float AR;

    [XmlElement("ARL")]
    public float ARL;

    [XmlElement("MR")]
    public float MR;

    [XmlElement("MRL")]
    public float MRL;

    [XmlElement("MS")]
    public float MS;

    [XmlElement("Range")]
    public float Range;
}