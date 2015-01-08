using UnityEngine;
using System.Collections;

public class Wing : MonoBehaviour {
	public int levelCount=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider c) {
		Debug.Log("c.tag");
		if (c.tag == "Player") {
			levelCount++;
			//Application.LoadLevel("Home");
			//c.GetComponent<Entity>().TakeDamage(10);
		}
	}
	void OnGUI(){
		GUI.Box (new Rect (10, 10, 100, 200), "Puan:"+levelCount);

		}
}
