using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinORLose : MonoBehaviour
{
    public GameObject winnerscreen;
    public GameObject loserscreen;
    public TextMeshProUGUI totalscoredisplay;



    // Start is called before the first frame update
    void Start()
    {
        winnerscreen.SetActive(false);
        loserscreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.winner == true && PlayerMovement.loser == false)

        {

            winnerscreen.SetActive(true);
        }

        if (GameControl.winner == false && PlayerMovement.loser == true)

        {

            loserscreen.SetActive(true);
        }

        totalscoredisplay.text = "Total Enemy Ships Destroyed: " + GameControl.totalscore.ToString("D1");
    }
}
