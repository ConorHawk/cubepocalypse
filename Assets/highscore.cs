using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour {
	public Text highscoreUi;
    public Transform playerPos;

	public static int highscoreNumber = 0;

	void Start()
    {
        // scoreUi.text = 0.ToString();
    }
    // Update is called once per frame
    void Update()
    {
		if(highscoreNumber < Mathf.RoundToInt(playerPos.transform.position.z)){
			highscoreNumber = Mathf.RoundToInt(playerPos.transform.position.z);
		}
        highscoreUi.text = highscoreNumber.ToString();
    }
}
