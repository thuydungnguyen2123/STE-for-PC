using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Button2Controller : MonoBehaviour
{
    public Button2Controller.ButtonType bt;
    public Button2Controller() { }

    public enum ButtonType { playagain }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(1.30f, 1.36f);
        if (bt == Button2Controller.ButtonType.playagain)
        {
            Application.LoadLevel("GameSTEF");
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
