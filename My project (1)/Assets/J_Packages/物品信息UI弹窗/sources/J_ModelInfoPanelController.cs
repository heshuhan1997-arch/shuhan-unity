using UnityEngine;
using UnityEngine.UI;

namespace J_Packages
{
    public class J_ModelInfoPanelController : MonoBehaviour
    {
        public static J_ModelInfoPanelController Inst;

        public GameObject m_originalPanel;
        public Text m_modelNameText;
        public Text m_modelDescriptionText;
        public AudioSource m_audioSource;
        public Button m_closeButton;
        // Start is called before the first frame update
        void Awake()
        {
            Inst = this;
            m_originalPanel.SetActive(false);
            m_closeButton.onClick.AddListener(() =>
            {
                m_originalPanel.SetActive(false);
                m_audioSource.Stop();
            });
        }

        public void ShowModelInfo(itemModelInfo modelInfo)
        {
            m_originalPanel.SetActive(true);
            m_modelNameText.text = modelInfo.modelName;
            m_modelDescriptionText.text = modelInfo.modelDescription;
            if (modelInfo.modelAudio != null)
            {
                m_audioSource.clip = modelInfo.modelAudio;
                m_audioSource.Play();
            }
        }
    }
}