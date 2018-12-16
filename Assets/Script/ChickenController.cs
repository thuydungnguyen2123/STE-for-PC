using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{

    // khai bao ham
    public GameObject trung;
    public float minTrungTime = 1;
    public float maxTrungTime = 3;
    private float lastTrungTime = 0;
    private float TrungTime = 0;

    // Use this for initialization
    void Start()
    {
        lastTrungTime = Time.time;
        TrungTime = Random.Range(minTrungTime, maxTrungTime); // random trung
        trung = GameObject.FindWithTag("Egg");

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= lastTrungTime + TrungTime)
        {
            RotTrung(); //goi ham tha trung
        }
    }
    //ham update lai thoi gian
    void UpdateTrungTime()
    {
        lastTrungTime = Time.time;
        TrungTime = Random.Range(minTrungTime, maxTrungTime + 2);

    }
    //ham thar trung roi
    void RotTrung()
    {
        GameObject quatrung = Instantiate(trung, transform.position, Quaternion.identity) as GameObject;
        UpdateTrungTime();
        Destroy(quatrung, 2f);

    }
}
