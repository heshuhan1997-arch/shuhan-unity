using UnityEngine;
using UnityEngine.SceneManagement;
namespace J_Packages
{
    public class J_SceneLoader : MonoBehaviour
    {
        public void J_LoadScene(int iindex)
        {
            SceneManager.LoadScene(iindex);
        }

        public void J_LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void J_QuitGame()
        {
            Application.Quit();
        }
    }
}