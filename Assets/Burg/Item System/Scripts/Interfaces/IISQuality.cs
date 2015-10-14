using UnityEngine;
using System.Collections;

namespace Burg.ItemSystem
{
    public interface IISQuality
    {
        string Name { get; set; }
        Sprite Icon { get; set; }
    }
}