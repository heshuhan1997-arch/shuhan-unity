using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace J_Packages
{


    public class NameTagController : MonoBehaviour
    {
        public static NameTagController Inst;
        public GameObject m_originalImg;
        public TextMeshProUGUI textMesh;
        void Awake()
        {
            Inst = this;
            m_originalImg.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (m_originalImg.activeInHierarchy)
            {
                m_originalImg.transform.position = Input.mousePosition;
            }
        }
        public void J_ShowTag(string tagName)
        {
            m_originalImg.gameObject.SetActive(true);
            textMesh.text = tagName;
        }
        public void J_HideTag()
        {
            m_originalImg.gameObject.SetActive(false);

        }
    }
}
