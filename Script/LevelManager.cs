using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    [System.Serializable]
    public class Level
    {
        public string levelText;
        public int unLocked;
        public bool isInteractable;

        

    }

    public List<Level> LevelList;
    public Transform spacer;
    public GameObject button;

	void Start () {

        instance = this;
  
        FillList();
	}
	
    void FillList()
    {
        foreach (var level in LevelList)
        {
            GameObject Button = Instantiate(button) as GameObject;
            LevelButton Btn = Button.GetComponent<LevelButton>();
            Btn.levelText.text = level.levelText;

            if(PlayerPrefs.GetInt("Level" + Btn.levelText.text) == 1)
            {
                level.unLocked = 1;
                level.isInteractable = true;
            }

            Btn.unLocked = level.unLocked;
            Btn.GetComponent<Button>().interactable = level.isInteractable;
            Btn.GetComponent<Button>().onClick.AddListener(() => LoadLevels("Level" + Btn.levelText.text));

            Button.transform.SetParent(spacer);
        }
        SaveAll();
    }

    void SaveAll()
    {
       
            GameObject[] allButtons = GameObject.FindGameObjectsWithTag("LevelButton");
            foreach (GameObject buttons in allButtons)
            {
                LevelButton butn = buttons.GetComponent<LevelButton>();
                PlayerPrefs.SetInt("Level" + butn.levelText.text, butn.unLocked);
            }
        }
        
    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }

    void LoadLevels(string value)
    {
        Application.LoadLevel(value);
    }

    }
	

