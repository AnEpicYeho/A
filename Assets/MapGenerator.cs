using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
	public GameObject[] terrainChunck;
	public GameObject water;

	public int mapY;
	public int mapX;

	public float waterProbability;


	// Use this for initialization
	void Start () {
		generateMap ();
	}
	private void generateMap(){
		for(int x=0; x<mapX;x++){
			for(int y=0; y<mapY;y++){
				if (waterProbability > Random.Range (0, 100)) {
					Instantiate (water, new Vector3 (x, y, 0), Quaternion.identity);
				} else {
					Instantiate (terrainChunck[Random.Range(0,terrainChunck.Length)],new Vector3(x,y,0),Quaternion.identity);
				}

			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
