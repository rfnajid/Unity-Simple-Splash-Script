using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	public AnimationClip animation;
	public string nextscene;

	void Start () {
		float time=animation.length;
		StartCoroutine(WaitAndDo(time));
	}

	IEnumerator WaitAndDo(float time){
		yield return new WaitForSeconds(time);
		//do something after wait.
		Do ();
	}

	void Do(){
		Application.LoadLevel(nextscene);
	}
}
