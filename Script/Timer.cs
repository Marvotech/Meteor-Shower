using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public float time;
    public string lvlNo;

	void Start () {
        PlayerPrefs.SetInt("Level" + lvlNo, 1);
        StartCoroutine(Delay());
	}
	


    IEnumerator Delay()
    {
        yield return new WaitForSeconds(time);
        Application.LoadLevel(4);
        
    }
}
