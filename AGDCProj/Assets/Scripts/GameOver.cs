using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool restart;
    public Text deadTxt;
    // Start is called before the first frame update
    void Start()
    {
        restart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (restart)
        {
            deadTxt.text = "Press Space to Continue";
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("Scene Loading");
                SceneManager.LoadScene("Title");
            }
        }
    }
}
