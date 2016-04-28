using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTeeth : MonoBehaviour {
    Scene pickingTeeth;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadTheScene(){
        SceneManager.LoadScene("Dentist");

    }
}
