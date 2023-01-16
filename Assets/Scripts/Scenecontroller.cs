using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenecontroller : MonoBehaviour
{
    public void LoadScene(string scenename)

    {
        SceneManager.LoadScene(scenename);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // if this condtion is met when the player presses the escape key then do this below
        {
            Application.Quit(); // if the player presses the esc key then the game will exit completely
        }
    }
}
