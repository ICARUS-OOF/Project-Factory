using ProjectFactory.ScriptableObjects;
using ProjectFactory.UIItems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ProjectFactory.Controllers
{
    public class Inventory : MonoBehaviour
    {
        #region Singleton
        public static Inventory singleton;
        private void Awake()
        {
            if (singleton == null)
            {
                singleton = this;
            }
        }
        #endregion
        private List<Item> InventoryList = new List<Item>();
        private InventorySlot[] slots;
        private void Start()
        {
            slots = transform.GetComponentsInChildren<InventorySlot>();
        }
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
                } else
                {
                    slots[i].EmptySlot();
                }
            }
        }
        public void AddItem(Item _item)
        {
            if (_item.stackable)
            {
                bool inInventory = false;
                foreach (Item i in InventoryList)
                {
                    if (i == _item)
                    {
                        i.amnt += _item.amnt;
                        inInventory = true;
                    }
                }
                if (!inInventory)
                {
                    InventoryList.Add(_item);
                }
            } else
            {
                InventoryList.Add(_item);
            }
        }
        public void RemoveItem(Item _item)
        {
            InventoryList.Remove(_item);
        }
        public List<Item> GetInventoryList()
        {
            return InventoryList;
        }
        public InventorySlot[] GetInventorySlots()
        {
            return slots;
        }
    }
}