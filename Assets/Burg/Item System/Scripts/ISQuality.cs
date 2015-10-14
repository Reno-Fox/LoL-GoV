using System;
using System.Collections;
using UnityEngine;

namespace Burg.ItemSystem
{
    [Serializable]
    public class ISQuality : IISQuality
    {
        [SerializeField]
        string _name;
        [SerializeField]
        Sprite _icon;

        public ISQuality()
        {
            _name = "";
            _icon = new Sprite();
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Sprite Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }
    }
}