using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControl : MonoBehaviour {

    public float playerSpeed;
    public float maxPfos = 3.2f;
    public GameObject panel;
    public GameObject imageobj;
    public Text Scoretxt;
    public GameObject Text;


    public Text currentscore;

    float startTime;
    float currentScore;
  

    

    Vector3 position;

    private bool _isFacingRight;
    private bool isDead;

    private void Awake()
    {
 
        _isFacingRight = transform.localScale.x > 0;
    }

    void Start () {
         position = transform.position;
        StartCoroutine(SendMessage(2f));
        startTime = 0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (isDead)
            return;
        else
        {
            position.x += CrossPlatformInputManager.GetAxis("Horizontal") * playerSpeed;

            position.x = Mathf.Clamp(position.x, -3.2f, 3.2f);

            transform.position = position;


            startTime += Time.deltaTime * 2;
            Scoretxt.text = ((int)(startTime)).ToString();
        }
        
       
    }

    IEnumerator SendMessage(float wait)
    {
       imageobj.SetActive(true);
        Text.SetActive(true);
        yield return new WaitForSeconds(wait);
        imageobj.SetActive(false);
        Text.SetActive(false);
    }

    private void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        _isFacingRight = transform.localScale.x > 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            Destroy(gameObject);
            panel.SetActive(true);
            //Application.LoadLevel("LevelSelect");

            float highscore = PlayerPrefs.GetInt("", 0);
            currentScore = startTime;

            if (currentScore > highscore)
            {
                PlayerPrefs.SetInt("", (int)currentScore);
            }

            currentscore.text = ((int)currentScore).ToString();
        }
    }

    public void MoveLeft()
    {
        if (_isFacingRight)
            Flip();
   
    }

    public void MoveRight()
    {
        if (!_isFacingRight)
            Flip();
     
    }

   
}
