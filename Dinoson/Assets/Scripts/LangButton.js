﻿var myGuiBlank : GUISkin;

var btnTexture : Texture;

function OnGUI(){
	GUI.skin = myGuiBlank;
	
	if (GUI.Button(Rect(Screen.width/2-200,Screen.height/4+50,200,50),btnTexture))
		Application.LoadLevel("");
}