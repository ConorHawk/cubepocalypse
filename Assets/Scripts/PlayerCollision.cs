using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public playerMovement movement;
    public AudioSource hit;
    public AudioSource death;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            hit.Play();
            death.Play();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
