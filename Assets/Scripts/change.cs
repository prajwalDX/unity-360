using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class change : MonoBehaviour {

	public Material[] Skybox;
	public static int i = 0;
	public void BtnNext () {
		if(i+1< Skybox.Length){
			i++;
		}
	}

	public void BtnPrev () {
		if(i > 0){
			i--;
		}
	}

	void Update () {
		RenderSettings.skybox = Skybox[i]; 
	}
}




































