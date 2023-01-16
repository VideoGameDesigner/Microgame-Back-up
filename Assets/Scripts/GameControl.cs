using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    
    public static int playerscore;
    public TextMeshProUGUI scoredisplay;
    public static int enemyspeedplus;

    public static float timecheck; // creating the variable for the time that has decimal places
    public static bool timeStarted = false; // making a variable that is always false
    public TextMeshProUGUI timeDisplay; // making the variable for timer text font
    public static bool winner;
    public static int totalscore;

  
    // Start is called before the first frame update
    void Start()
    {
        enemyspeedplus = 1;
        playerscore = 0;
        timecheck = Random.Range(10f,19f); // the time at the start of the game is set to about 20 seconds
        timeStarted = true; // as soon as the game starts the variable is true
            
    }

    // Update is called once per frame
    void Update()
    {
        scoredisplay.text = "enemy ships Destroyed: " + (playerscore.ToString("D1"));

        if (timeStarted == true) // a condition that can only activate if the variable is equal to true not if the variable IS true
        {
            timecheck -= Time.deltaTime; // if the condition is met then the timer will go down every second
        }

        if (timecheck <= 0) // a condition that can only activate if the timer at 0 or under 0;
        {
            timeDisplay.text = "Times Up! "; // if the condition above is activated then the words Times Up will replace the timer
            winner = true;
            PlayerMovement.loser = false;
            totalscore = playerscore;
            Enemygone.enemyspeed = 7f; 
            SceneManager.LoadScene("GameOver");
            

        }
        else // this means that if the previous if statements aren't met then activate this code below.
        {
            int minutes = Mathf.FloorToInt(timecheck / 60f); // round the decimal places down instead of up to whole numbers then divide by 60 in decimals
            int seconds = Mathf.FloorToInt(timecheck - minutes * 60); //  round the decimals down to whole numbers then minus the minutes and times by 60
            string formattedTime = string.Format("{0:0}:{1:00}", minutes, seconds); // turn the numbers into reable text BUT put them into 2 values
            timeDisplay.text = "Timer: " + formattedTime; // display the timer going down in minutes and seconds

        }




        

        if(enemyspeedplus == 0)

        {
            enemyspeedplus = 1;
            Enemygone.enemyspeed += 1;
            

        }


        if (Input.GetKeyDown(KeyCode.Escape)) // if this condtion is met when the player presses the escape key then do this below
        {
            Application.Quit(); // if the player presses the esc key then the game will exit completely
        }

        if (GameControl.playerscore == 0 && timecheck <= 0)
        {
            PlayerMovement.loser = true;
            GameControl.winner = false;
            totalscore = playerscore;
            Enemygone.enemyspeed = 7f;
            SceneManager.LoadScene("GameOver");

        }

    }

    
}
