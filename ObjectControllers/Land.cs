using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS LAND IS "Terrain_0_0-20181102-101609"
public class Land : MonoBehaviour
{

	public int landHealth = 0;
	private int NewHealth = 0;
	private int MaxHealth = 100;
	private int MinHealth = 0;

	void Start ()
	{
		
	}

	void Update ()
	{
		/*FOR TESTING PURPOSES*/
		/*TODO REMOVE BEFORE FINAL BUILD*/
		if (Input.GetKeyDown ("p")) {
			//revert the land to original state
			UpdateTerrainTexture (gameObject.GetComponent<Terrain> ().terrainData, 0, 1);

			for (int i = 0; i < gameObject.GetComponent<Terrain> ().terrainData.detailPrototypes.Length; i++) {
				Debug.Log (gameObject.GetComponent<Terrain> ().terrainData.detailPrototypes [i].healthyColor);
				gameObject.GetComponent<Terrain> ().terrainData.detailPrototypes [i].healthyColor = new Color (0, 0, 0, 255);
				Debug.Log (gameObject.GetComponent<Terrain> ().terrainData.detailPrototypes [i].prototypeTexture);
			}
		
		}

		if (NewHealth >= 0) {
			landHealth = NewHealth; 
		}
	}

	public void Heal ()
	{
		
	}

	//CHANGES TERRAIN COLORS
	static void UpdateTerrainTexture (TerrainData terrainData, int textureNumberFrom, int textureNumberTo)
	{
		//get current paint mask
		float[, ,] alphas = terrainData.GetAlphamaps (0, 0, terrainData.alphamapWidth, terrainData.alphamapHeight);
		// make sure every grid on the terrain is modified
		//Debug.Log ("AlphampaWidth: " + terrainData.alphamapWidth + " " + "AlphamapHeight: " + terrainData.alphamapHeight);
		for (int i = 312; i < 712/*terrainData.alphamapWidth*/; i++) {
			for (int j = 312; j < 712/*terrainData.alphamapHeight*/; j++) {
				//for each point of mask do:
				//paint all from old texture to new texture (saving already painted in new texture)
				alphas [i, j, textureNumberTo] = Mathf.Max (alphas [i, j, textureNumberFrom], alphas [i, j, textureNumberTo]);
				//set old texture mask to zero
				alphas [i, j, textureNumberFrom] = 0f;
			}
		}

		// apply the new alpha
		terrainData.SetAlphamaps (0, 0, alphas);
	}
}


//helpful resource for modifying terrain texture in runtime
//https://answers.unity.com/questions/285816/change-terrain-texture-and-tree-at-runtime.html
//	if (Input.GetKeyDown (KeyCode.Space)) {
//switch all painted in texture 1 to texture 2
//UpdateTerrainTexture (myTerrain.terrainData, 1, 2);
