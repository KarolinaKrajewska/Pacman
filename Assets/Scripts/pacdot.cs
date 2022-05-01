using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pacdot : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman")
        {
            Destroy(gameObject);
            ScoreShowing.scoreValue += 1;
            Debug.Log(ScoreShowing.scoreValue);
        }
    }
    void Update()
    {
        if (ScoreShowing.scoreValue == 334)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
