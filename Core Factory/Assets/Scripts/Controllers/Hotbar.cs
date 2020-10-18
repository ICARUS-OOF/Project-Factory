using ProjectFactory.UIItems;
using ProjectFactory.ScriptableObjects;
using System.Collections.Generic;
using UnityEngine;
namespace ProjectFactory.Controllers
{
    public class Hotbar : MonoBehaviour
    {
        #region Singleton
        public static Hotbar singleton;
        private void Awake()
        {
            if (singleton == null)
            {
                singleton = this;
            }
        }
        #endregion
        public List<Item> InventoryList = new List<Item>();
        public InventorySlot[] slots;
        private void Update()
        {
            slots = transform.GetComponentsInChildren<InventorySlot>();
        }
        public void OnOpenInventory()
        {
            UpdateUI();
        }
        void UpdateUI()
        {
            for (int i = 0; i < slots.Length; i++)
            {
                if (i < InventoryList.Count)
                {
                    slots[i].FillSlot(InventoryList[i]);
                }
                else
                {
                    slots[i].EmptySlot();
                }
            }
        }
        public void AddItem(Item _item)
        {
            InventoryList.Add(_item);
        }
        public void RemoveItem(Item _item)
        {
            InventoryList.Remove(_item);
        }
    }
}