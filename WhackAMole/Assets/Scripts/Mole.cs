using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour {

	public float visibleHeight = 0.2f;
	public float hiddenHeight = -0.3f;
	public float speed = 4f;

	private Vector3 targetPosition;


	// Use this for initialization
	void Awake () {
		targetPosition = new Vector3(
			transform.localPosition.x,
			hiddenHeight,
			transform.localPosition.z
		);
		transform.localPosition = targetPosition;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = Vector3.Lerp (transform.localPosition, targetPosition, Time.deltaTime*speed);
	}

	public void Rise(){
		targetPosition = new Vector3 (
			transform.position.x,
			visibleHeight,
			transform.position.z
		);
	}

	public void OnHit(){
		targetPosition = new Vector3 (
			transform.position.x,
			hiddenHeight,
			transform.position.z
		);
	}
}
