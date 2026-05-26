using UnityEngine;
using UnityEngine.EventSystems;

namespace J_Packages
{
    public class itemModelInfo : MonoBehaviour, IPointerClickHandler
    {
        [Header("物品名称")]
        public string modelName;
        [Header("物品描述")]
        [TextArea]
        public string modelDescription;
        [Header("物品语音")]
        public AudioClip modelAudio;

        public void OnPointerClick(PointerEventData eventData)
        {
            if (J_ModelInfoPanelController.Inst)
                J_ModelInfoPanelController.Inst.ShowModelInfo(this);
        }

        
    }
}