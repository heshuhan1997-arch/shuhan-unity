using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
namespace J_Packages
{

    public class J_EventTriggerHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        public UnityEvent onPointerEnterEvent;
        public UnityEvent onPointerExitEvent;
        public UnityEvent onPointerClickEvent;

        public void OnPointerClick(PointerEventData eventData)
        {
            onPointerClickEvent?.Invoke();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            onPointerEnterEvent?.Invoke();
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            onPointerExitEvent?.Invoke();
        }
    }
}