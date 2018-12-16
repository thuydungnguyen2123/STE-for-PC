using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour {


    public ButtonController.ButtonType bt;
    public ButtonController() { }

    public enum ButtonType { play }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(1.30f, 1.36f);
        if (bt == ButtonController.ButtonType.play)
        {
            Application.LoadLevel("GameSTEF");
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
