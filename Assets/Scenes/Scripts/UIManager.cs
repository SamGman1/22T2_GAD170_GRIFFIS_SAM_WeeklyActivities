using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SamGriffis
{
    public class UIManager : MonoBehaviour
    {

        [SerializeField] private GameObject mainMenu;
        [SerializeField] private GameObject creditMenu;


        public void StartButtonClicked()
        {

            Debug.Log("Starting...");

            SceneManager.LoadScene(1);

        }

        public void QuitButtonClicked()
        {

            Debug.Log("Quitting...");

            Application.Quit();

        }


        public void BackButtonClick()
        {

            Debug.Log("Back Button Pressed");

            mainMenu.SetActive(true);
            creditMenu.SetActive(false);

        }

        public void CreditButtonClick()
        {
            mainMenu.SetActive(false);
            creditMenu.SetActive(true);


        }
    }
}
