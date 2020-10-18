using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ProjectFactory.Handlers
{
    public class WorldHandler : MonoBehaviour
    {
        public static class Cursor
        {
            public static void LockCursor()
            {
                UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                UnityEngine.Cursor.visible = false;
            }
            public static void FreeCusor()
            {
                UnityEngine.Cursor.lockState = CursorLockMode.None;
                UnityEngine.Cursor.visible = true;
            }
        }
        public static class Time
        {
            public static void FreezeTime()
            {
                UnityEngine.Time.timeScale = 0f;
            }
            public static void UnfreezeTime()
            {
                UnityEngine.Time.timeScale = 1f;
            }
        }
    }
}