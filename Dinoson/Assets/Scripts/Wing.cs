using UnityEngine;
using System.Collections;

public class Wing : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider c) {
		Debug.Log("c.tag");
		if (c.tag == "Player") {
			GameManager.levelCount++;
			//Application.LoadLevel("Home");
			//c.GetComponent<Entity>().TakeDamage(10);

			Destroy(gameObject);
		}
	}

}
