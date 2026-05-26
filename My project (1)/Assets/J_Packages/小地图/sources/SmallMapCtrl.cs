using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace J_Packages
{


    public class SmallMapCtrl : MonoBehaviour
    {
        public Camera mainCamera;
        public RectTransform mainArrow;
        void Awake()
        {
            if (mainCamera == null)
                mainCamera = Camera.main;
        }

        // Update is called once per frame
        void Update()
        {
            mainArrow.localEulerAngles = new Vector3(0, 0, -mainCamera.transform.eulerAngles.y);
        }
    }
}
