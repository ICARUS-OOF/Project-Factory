using ProjectFactory.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ProjectFactory.Controllers
{
    public class PlayerInteraction : MonoBehaviour
    {
        RaycastHit hitInfo;
        [SerializeField] float range = 5f;
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, range);
        }
        private void Update()
        {
            if (Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo, range))
            {
                if (hitInfo.transform.tag != GameData.PlayerTag)
                {
                    Debug.Log(hitInfo.transform.name);
                }
            }
        }
    }
}