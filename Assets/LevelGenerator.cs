using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public GameObject standardBlock;
	public GameObject tallBlock;

	public int numberOfPlatforms = 200;
	public float startOffset = 50f;
	public float levelWidth = 1.5f;
	public float randX = 1f;
	public float frequency = 2f;
	public float percentOfTall = 0.75f;
	
	// Use this for initialization
	void Start () {
		Vector3 spawnPosition = new Vector3();
		Vector3 tallSpawnPosition = new Vector3();

		for (int i = 0; i < numberOfPlatforms; i++)
		{
			float interval = i / frequency;
			float objSelector = Random.Range(0f,1f);
			spawnPosition.z += Random.Range(interval-randX, interval+randX)*10+startOffset;
			tallSpawnPosition.z += Random.Range(interval-randX, interval+randX)*10+startOffset;
			tallSpawnPosition.x = Random.Range(-levelWidth, levelWidth);

			if (objSelector > percentOfTall){
				Instantiate(tallBlock, tallSpawnPosition, Quaternion.identity);
			} 
			Instantiate(tallBlock, tallSpawnPosition, Quaternion.identity);
			Instantiate(tallBlock, tallSpawnPosition, Quaternion.identity);
			
			spawnBlock(interval, standardBlock);
			
		}
	}

	void spawnBlock (float interval, GameObject objectToSpawn){

		Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
