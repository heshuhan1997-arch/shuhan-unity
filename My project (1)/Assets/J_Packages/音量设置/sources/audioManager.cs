using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace J_Packages
{
    public class audioManager : MonoBehaviour
    {
        public GameObject m_originalPanel;
        public AudioMixer m_audioMixer;
        public Slider sliderMainVolume;
        public Slider sliderBGMusicVolume;
        public Slider sliderYinXiaoVolume;


        private void Start()
        {
            m_originalPanel.gameObject.SetActive(false);


            m_audioMixer.SetFloat("总音量", PlayerPrefs.GetFloat("总音量"));
            m_audioMixer.SetFloat("背景音乐音量", PlayerPrefs.GetFloat("背景音乐音量"));
            m_audioMixer.SetFloat("音效音量", PlayerPrefs.GetFloat("音效音量"));
            sliderMainVolume.value = PlayerPrefs.GetFloat("总音量");
            sliderBGMusicVolume.value = PlayerPrefs.GetFloat("背景音乐音量");
            sliderYinXiaoVolume.value = PlayerPrefs.GetFloat("音效音量");

            sliderMainVolume.onValueChanged.AddListener(J_SetMainVolume);
            sliderBGMusicVolume.onValueChanged.AddListener(J_SetBGVolume);
            sliderYinXiaoVolume.onValueChanged.AddListener(J_SetYinXiaoVolume);
        }
        /// <summary>
        /// 设置总音量
        /// </summary>
        public void J_SetMainVolume(float fvalue)
        {
            m_audioMixer.SetFloat("总音量", fvalue);
            PlayerPrefs.SetFloat("总音量", fvalue);
        }
        public void J_SetBGVolume(float fvalue)
        {
            m_audioMixer.SetFloat("背景音乐音量", fvalue);
            PlayerPrefs.SetFloat("背景音乐音量", fvalue);

        }
        public void J_SetYinXiaoVolume(float fvalue)
        {
            m_audioMixer.SetFloat("音效音量", fvalue);
            PlayerPrefs.SetFloat("音效音量", fvalue);

        }
    }
}