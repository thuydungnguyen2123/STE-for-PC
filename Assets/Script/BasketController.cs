using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour {
    //khai bao ham di chuyen
    public float xMin = -6f; //gioi han khung chay cua Ro - ban trai 
    public float xMax = 7f;//gioi han khung chay cua Ro - ban phai
    public float speed = 7;

    //tao vecto moi
    Vector3 mouse;

    // Use this for initialization
    void Start () {
        mouse = transform.position;

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButton(0))
        {

            mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition); // lay vi tri tu camera chinh
            mouse = new Vector3(Mathf.Clamp(mouse.x, xMin, xMax), -4f, 0); //gioi han vung chay cua ro
        }
        transform.position = Vector3.Lerp(transform.position, mouse, speed * Time.deltaTime); // toc do di chuyen cua ro
    }
    private void OnCollisionEnter2D(Collision2D collider) // xu li va cham
    {
        if (collider.gameObject.tag == "Egg")
        {
            int diem = 10;
            FindObjectOfType<ScoreController>().AddScore(diem);
            Destroy(collider.gameObject); // cong diem xong xoa trung
            
        }

    }


}
