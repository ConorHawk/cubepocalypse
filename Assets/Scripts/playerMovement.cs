using UnityEngine;

public class playerMovement : MonoBehaviour {

	public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
    public float jumpHeight = 2f;
    public float jumpThreshold = 1f;
    public AudioSource jumpSound;
    public AudioSource fall;
    bool playerHasFallen = false;
    bool inAir = false;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space"))
        {
            if (!inAir)
            {
                jumpSound.Play();
                rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
            }
            
        }

        if (rb.position.y > jumpThreshold)
        {
            inAir = true;
        }
        else
        {
            inAir = false;
        }

        if (rb.position.y < -1)
        {
            if (!playerHasFallen)
            {
                playerHasFallen = true;
                fall.Play();
                FindObjectOfType<GameManager>().EndGame();
            }
            
        }
    }
}
