using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public TextMesh uiText;
	public GameObject player;
	public GameObject sawBlade;
	public GameObject ground;
	public GameObject background;
	public GameObject wing;
	private GameObject currentPlayer;
	private GameCamera cam;
	
	void Start ()
	{
		cam = GetComponent<GameCamera> ();
		SpawnPlayer (new Vector3(0,10,0));
		SpawnSawBlade (Vector3.zero);
		
		/*for (int y = 0; y < 5; y++) {
				for (int x = 0; x < 5; x++) {
					GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
					cube.AddComponent<Rigidbody>();
					cube.transform.position = new Vector3(x, y, 0);
				}
			}*/
		
		
		
	}
	
	// Spawn player
	private void SpawnPlayer (Vector3 spawnPos)
	{
		currentPlayer = Instantiate (player, spawnPos, Quaternion.identity) as GameObject;
		cam.SetTarget (currentPlayer.transform);
	}
	
	// Spawn player
	private void SpawnSawBlade (Vector3 spawnPos)
	{
		for (int x = 1; x < 100; x++) {

			GameObject objectw = Instantiate (sawBlade, spawnPos, Quaternion.identity) as GameObject;
			if (x % 2 == 0)
			{
			
				objectw.transform.position = new Vector3 (x * 30, 0, 0);
			}
				
			else
				objectw.transform.position = new Vector3 (x * 30, 0.5f, 0);
			for(int wingC = 0;wingC<4;wingC++)
			{
				GameObject wingObj = Instantiate (wing, spawnPos, Quaternion.identity) as GameObject;
				wingObj.transform.position = new Vector3 (x * 30 -10*wingC, 0+wingC, 0);
			}
			objectw.transform.Rotate (new Vector3 (0, 270, 0));
		}
		
		int yer = 80;
		for (int x = 0; x < 100; x++) {
			GameObject groundObj = Instantiate (ground, spawnPos, Quaternion.identity) as GameObject;
			
			groundObj.transform.position = new Vector3 (yer, -4, 0);
			groundObj.transform.Rotate(new Vector3(0,0,180));
			yer += 200;
			
		}

		int yer2 = 80;
		for (int x = 0; x < 10; x++) {
			GameObject groundObj = Instantiate (background, spawnPos, Quaternion.identity) as GameObject;
			
			groundObj.transform.position = new Vector3 (yer2, 2, 10);
			groundObj.transform.Rotate(new Vector3(0,0,0));
			yer2 += 200;
			
		}

	


		
	}
	public static int levelCount=0;
	void OnGUI(){
		//TextMesh asdd = (TextMesh)uiText;
		uiText.text = levelCount+"";
		//	GUI.Box (new Rect (10, 10, 100, 200), "Puan:"+levelCount);

	}
	private void Update ()
	{
		if (!currentPlayer) {
			if (Input.GetButtonDown ("Respawn")) {
				SpawnPlayer (Vector3.zero);
			}
		}
	}
}
