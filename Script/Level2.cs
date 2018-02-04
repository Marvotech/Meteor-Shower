using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour {

    public GameObject lvlText;
    public string levelString;

    private void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        lvlText.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        lvlText.SetActive(false);
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene(levelString);
    }
}
