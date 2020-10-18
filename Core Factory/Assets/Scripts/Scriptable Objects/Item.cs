using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ProjectFactory.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Item", menuName = "Factory/Item")]
    public class Item : ScriptableObject
    {
        public Sprite icon;
        [TextArea]
        public string Description;
        public bool stackable = true;
        public int amnt = 0;
    }
}