using UnityEngine;
using System.Collections;

public class Changetext : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Aenderetext (string text)
    {
        if (GetComponent<UnityEngine.UI.Text>().text == "Start")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Ende";
        }
        else { 
        GetComponent<UnityEngine.UI.Text>().text = text;
        }
    }
}
