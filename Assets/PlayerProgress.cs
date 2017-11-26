using UnityEngine;
using UnityEngine.UI;

public class PlayerProgress : MonoBehaviour
{

    //public Transform player;
    public Text scoreUi;
    public Transform playerPos;

    void Start()
    {
        scoreUi.text = 0.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        scoreUi.text = Mathf.RoundToInt(playerPos.transform.position.z).ToString();
    }
}


