var myGuiBlank : GUISkin;

var btnTexture : Texture;

function OnGUI(){
	GUI.skin = myGuiBlank;
	
	if (GUI.Button(Rect(Screen.width/2+80,Screen.height/5-100,200,50),btnTexture))
		Application.LoadLevel("");
}