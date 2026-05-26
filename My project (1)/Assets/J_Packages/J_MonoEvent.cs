using UnityEngine;
using UnityEngine.Events;
namespace J_Packages
{

    public class J_MonoEvent : MonoBehaviour
    {
        public UnityEvent onEnable;
        public UnityEvent onDisable;
        void OnEnable()
        {
            onEnable.Invoke();
        }
        private void OnDisable()
        {
            onDisable.Invoke();
        }
    }
}