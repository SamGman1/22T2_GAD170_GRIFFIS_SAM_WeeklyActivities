using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SamGriffis
{

    public class GameMenuManager : MonoBehaviour
    {


        [SerializeField] private GameObject pauseMenu;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (pauseMenu.activeSelf == true)
                {
                    pauseMenu.SetActive(false);
                }
                else if (pauseMenu.activeSelf == false)
                {
                    pauseMenu.SetActive(true);
                }
            }
            
        }


        public void MenuButtonClicked()
        {
            SceneManager.LoadScene(0);
        }


        public void ResumeButtonClicked()
        {

            pauseMenu.SetActive(false);

        }

        public void QuitButtonClicked()
        {

            Debug.Log("Quitting...");

            Application.Quit();

        }
    }
}

