using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour {

    //khai bao ham diem so
    private int score = 0;
    private bool gameOver = false;
    // them diem
    public void AddScore(int sc)
    {
        score += sc;
    }

    public float secondsLeft = 20f;
    //ham dem nguoc thoi gian 
    private void OnGUI()
    {
        if (secondsLeft > 0)
        {
            GUILayout.Label("   Time: " + (int)secondsLeft);
            GUILayout.Label(" Score: " + score); //layout hien diem so
        }
        else
        {
            GUILayout.Label("It's Over");
            SceneManager.LoadScene("EndSTEF");
            
        }
    }
    //ham dung tro choi
   
    public void GameOver()
    {
        gameOver = true;
      
        Debug.Log("End Game");
    }

    // Use this for initialization
    void Start() {
            gameOver = false;
     }

     // Update is called once per frame
     void Update() {
          secondsLeft -= Time.deltaTime;

     }
}