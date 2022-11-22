using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

namespace KID
{
    public class FinalManager : MonoBehaviour
    {
        public static FinalManager instance;
        private CanvasGroup groupFinal;
        private TextMeshProUGUI textTitle;
        private Button btnReplay;

        private void Awake() 
        {
            instance = this;
            groupFinal = GameObject.Find("EndCanvas").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("EndTitle").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("CumAgain").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        public void GameOver(string title)
        {
            textTitle.text = title;
            StartCoroutine(FadeIn());
        }
        private IEnumerator FadeIn()
        {
            for (int i = 0; i < 10; i++)
            {
               groupFinal.alpha += 0.1f;
               yield return new WaitForSeconds(0.02f);
            }
            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
        }
        private void Replay()
        {
            SceneManager.LoadScene("Start");
        }
    }
}

