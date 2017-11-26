using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public GameObject standardBlock;
	public GameObject tallBlock;
	public GameObject level;

	public int numberOfPlatforms = 200;
	public float startOffset = 50f;
	public float randX = 1f;
	public float frequency = 2f;
	public float percentOfTall = 0.75f;

	private float levelWidth;
	
	// Use this for initialization
	void Start () {
		//Vector3 spawnPosition = new Vector3();
		//Vector3 tallSpawnPosition = new Vector3();
        //float levelWidth = level.GetComponent<Renderer>().bounds.size.x;
        //float levelWidth = 7;

        //for (int i = 0; i < numberOfPlatforms; i++)
        //{
        //    float interval = i / frequency;
        //    float objSelector = Random.Range(0f, 1f);
        //    spawnPosition.z += Random.Range(interval - randX, interval + randX) * 10 + startOffset;
        //    tallSpawnPosition.z += Random.Range(interval - randX, interval + randX) * 10 + startOffset;
        //    tallSpawnPosition.x = Random.Range(-levelWidth, levelWidth);

        //    if (objSelector > percentOfTall)
        //    {
        //        spawnBlock(tallSpawnPosition, tallBlock);
        //    }
        //    // Instantiate(tallBlock, tallSpawnPosition, Quaternion.identity);
        //    // Instantiate(tallBlock, tallSpawnPosition, Quaternion.identity);

        //    spawnBlock(spawnPosition, standardBlock);
        //}
    }

	//void spawnBlock (Vector3 spawnPosition, GameObject objectToSpawn){
	//	Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
	//}
	
	// Update is called once per frame
	void Update () {
		
	}
}
