using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace J_Packages
{
    public class J_AnimationEventReceiver : MonoBehaviour
    {
        public List<cEventMapper> m_listEvents;
        [System.Serializable]
        public class cEventMapper
        {
            public string eventName;
            public UnityEvent unityEvent;
        }

        public void J_TriggerEvent(string eventName)
        {
            foreach (var obj in m_listEvents)
            {
                if (obj.eventName.Equals(eventName))
                {
                    obj.unityEvent.Invoke();
                }
            }
        }
    }

}