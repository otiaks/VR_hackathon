using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnClick(){
		SceneManager.LoadScene("Main");
	}
}
