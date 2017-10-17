using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject moleContainer;
	public float spawnDuration = 1.5f;
	public float spawnDecrement = 0.1f;
	public float minimumSpawnDuration =  0.5f;

	private Mole[] moles;
	private float spawnTimer = 0f;

	// Use this for initialization
	void Start () {
		moles = moleContainer.GetComponentsInChildren<Mole> ();

		//moles [Random.Range (0, moles.Length)].Rise();
	}
	
	// Update is called once per frame
	void Update () {
		spawnTimer -= Time.deltaTime;
		if(spawnTimer <= 0f) {
			moles [Random.Range (0, moles.Length)].Rise ();

			spawnDuration -= spawnDecrement;
			if(spawnDuration < minimumSpawnDuration){
				spawnDuration = minimumSpawnDuration;
			}

			spawnTimer = spawnDuration;
		}
	}
}
