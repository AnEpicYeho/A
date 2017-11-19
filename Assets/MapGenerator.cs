using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
	public Chunk[] terrainChuncks;
	public GameObject water;

	public int mapY;
	public int mapX;

	// Use this for initialization
	void Start () {
		generateMap ();
	}
	private void generateMap(){
		GameObject createdChunk = null;
		for(int x=0; x<mapX;x++){
			for(int y=0; y<mapY;y++){
				foreach(Chunk chunk in terrainChuncks){
					createdChunk = null;
					if (chunk.pobability > Random.Range (0, 100)) {
						createdChunk = Instantiate (chunk.terrainchunk, new Vector3 (x, y, 0), Quaternion.identity);
						createdChunk.transform.parent = transform;
						break;
					}
				}
				if(createdChunk == null){
					createdChunk = Instantiate (water, new Vector3 (x, y, 0), Quaternion.identity);
					createdChunk.transform.parent = transform;
					createdChunk = null;
				}
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
