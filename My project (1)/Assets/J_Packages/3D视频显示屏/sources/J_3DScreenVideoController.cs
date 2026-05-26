using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;
namespace J_Packages
{
    public class J_3DScreenVideoController : MonoBehaviour, IPointerClickHandler
    {
        public VideoPlayer myVideoPlayer;
        public GameObject objPlayTip;

        public void OnPointerClick(PointerEventData eventData)
        {
            if (myVideoPlayer.isPlaying)
            {
                myVideoPlayer.Pause();
            }
            else
            {
                myVideoPlayer.Play();

            }
        }
        void Update()
        {
            objPlayTip.gameObject.SetActive(!myVideoPlayer.isPlaying);
        }
    }
}