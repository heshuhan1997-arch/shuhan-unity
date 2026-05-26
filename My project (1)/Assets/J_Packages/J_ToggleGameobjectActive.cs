using UnityEngine;

namespace J_Packages
{
    public class J_ToggleGameobjectActive : MonoBehaviour
    {
        public GameObject target;
        public void J_ToggleActive()
        {
            if (target != null)
            {
                target.SetActive(!target.activeSelf);
            }
        }
    }
}