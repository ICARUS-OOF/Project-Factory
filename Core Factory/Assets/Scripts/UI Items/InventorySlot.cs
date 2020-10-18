using ProjectFactory.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;
namespace ProjectFactory.UIItems
{
    public class InventorySlot : MonoBehaviour
    {
        public Item itemData;
        public Image icon;
        public void FillSlot(Item _itemData)
        {
            itemData = _itemData;
            icon.sprite = itemData.icon;
        }
        public void EmptySlot()
        {
            itemData = null;
            icon.sprite = null;
        }
    }
}