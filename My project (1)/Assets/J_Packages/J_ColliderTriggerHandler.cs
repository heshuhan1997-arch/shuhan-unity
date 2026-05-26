using UnityEngine;
using UnityEngine.Events;

namespace J_Packages
{
    public class J_ColliderTriggerHandler : MonoBehaviour
    {
        public UnityEvent onTriggerEnterEvent;
        public UnityEvent onTriggerExitEvent;

        private void OnTriggerEnter(Collider other)
        {
            onTriggerEnterEvent.Invoke();
        }

        private void OnTriggerExit(Collider other)
        {
            onTriggerExitEvent.Invoke();
        }
    }
}