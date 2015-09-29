using UnityEngine;
using System.Collections;

public class asdf : MonoBehaviour {

	public Transform goalObject;
	public Transform playerObject;

	public Texture uiText;

	bool won = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if ( (playerObject.position - goalObject.position).magnitude > 50f) {
			
		}
		if (Vector2.Distance(goalObject.position, playerObject.position) > 20f) {
			
		}
		if (Vector3.Distance(goalObject.position, playerObject.position) < 5f) {
			//uiText.text = "";
			if (Input.GetKeyDown(KeyCode.Space) ) {
				won = true;
			}
		}

		if (won) {
			//uiText.text = "gz";
		}
	}
}
