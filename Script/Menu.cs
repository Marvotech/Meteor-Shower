using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public GameObject panel;

    public GameObject on;
    public GameObject Off;


    public Text HighText;


    void Start()
    {
        HighText.text = PlayerPrefs.GetInt("", 0).ToString();

    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene("Level1");
        panel.SetActive(false);
    }

    public void Quit()
    {
      SceneManager.LoadScene("LevelSelect");
    }

    public void ToggleSound()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);
        }
        else
        {

            PlayerPrefs.SetInt("Muted", 0);
        }
        SetSoundState();
    }

    private void SetSoundState()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
            on.SetActive(true);
            Off.SetActive(false);
        }
        else
        {
            AudioListener.volume = 0;
            on.SetActive(false);
            Off.SetActive(true);
        }
    }

}
