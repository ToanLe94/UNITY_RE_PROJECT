using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Container : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onClickBtnPlay()
    {
        //Application.LoadLevel();
        SceneManager.LoadScene("SampleScene");
    }

    public void onClickBtnQuit()
    {
        Application.Quit();
    }
}
