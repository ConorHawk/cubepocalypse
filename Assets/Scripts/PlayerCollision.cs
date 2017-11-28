using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public GameObject level;
    public playerMovement movement;
    public float spawnDistance = 50f;
    public float spawnMin = 0.8f;
    public float spawnMax = 1.2f;
    public AudioSource hit;
    public AudioSource death;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //hit.Play();
            //death.Play();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }

    private void OnTriggerEnter(Collider triggerObj)
    {
        Vector3 PlayerLocation = new Vector3(0,0,transform.position.z);
        float spawnVariation = spawnDistance * Random.Range(spawnMin, spawnMax);
        triggerObj.gameObject.transform.parent.gameObject.transform.position = PlayerLocation + Vector3.forward * spawnVariation;
        level.transform.position = PlayerLocation + Vector3.back * 2;
    }
}
