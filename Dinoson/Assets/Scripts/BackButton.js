var myGuiBlank : GUISkin;

var btnTexture : Texture;

function OnGUI(){
	GUI.skin = myGuiBlank;
	
	if (GUI.Button(Rect(Screen.width/3-100,Screen.height*4/5-100,200,50),btnTexture))
		Application.LoadLevel("Home");
}