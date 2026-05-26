using UnityEngine;
using UnityEngine.EventSystems;
namespace J_Packages
{
    public class mono_ItemTagName : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public string itemName;
        public void OnPointerEnter(PointerEventData eventData)
        {
            if (NameTagController.Inst)
            {
                NameTagController.Inst.J_ShowTag(itemName);
            }
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (NameTagController.Inst)
            {
                NameTagController.Inst.J_HideTag();
            }
        }

    }
}