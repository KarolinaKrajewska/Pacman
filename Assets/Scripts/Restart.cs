using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown("r"))
        { //If you press R
            ScoreShowing.scoreValue = 0;
            SceneManager.LoadScene("SampleScene"); //Load scene called Game
        }
    }
}
