using ProjectFactory.Handlers;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
namespace ProjectFactory.Controllers
{
    public class PlayerUI : MonoBehaviour
    {
        public bool isPaused = false;
        public GameObject PauseMenuUI;
        public GameObject InventoryUI;
        [Header("Events")]
        public UnityEvent onOpenInventory;
        public UnityEvent onOpenPauseMenuUI;
        public UnityEvent onCloseUI;
        private void Start()
        {
            WorldHandler.Cursor.LockCursor();
            StartCoroutine(LateStart());
        }
        IEnumerator LateStart()
        {
            yield return new WaitForSeconds(0.01f);
            PauseMenuUI.SetActive(false);
            InventoryUI.SetActive(false);
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
            {
                onOpenPauseMenuUI?.Invoke();
            } else if (Input.GetKeyDown(KeyCode.I) && !isPaused)
            {
                onOpenInventory?.Invoke();
            } else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
            {
                onCloseUI?.Invoke();
            }
            if (isPaused)
            {
                WorldHandler.Cursor.FreeCusor();
            } else
            {
                WorldHandler.Cursor.LockCursor();
            }
        }
        public void OnOpenInventory()
        {
            InventoryUI.SetActive(true);
            isPaused = true;
        }
        public void OnOpenPauseMenuUI()
        {
            PauseMenuUI.SetActive(true);
            isPaused = true;
        }
        public void OnCloseUI()
        {
            InventoryUI.SetActive(false);
            PauseMenuUI.SetActive(false);
            isPaused = false;
        }
    }
}