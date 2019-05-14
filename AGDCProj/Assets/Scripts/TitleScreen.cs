using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Scene Loading");
            SceneManager.LoadScene("Instructions");
        }

        if (Input.GetKeyDown("c"))
        {
            Debug.Log("Scene Loading");
            SceneManager.LoadScene("Credits");
        }


    }
}
