using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace KID
{
    public class MenuManager : MonoBehaviour
    {
        private Button btnReplay;

        private void Awake() 
        {
            btnReplay = GameObject.Find("CUM").GetComponent<Button>();
            btnReplay.onClick.AddListener(StartGame);
        }

        private void StartGame()
        {
            SceneManager.LoadScene("Plane");
        }
    }
}

