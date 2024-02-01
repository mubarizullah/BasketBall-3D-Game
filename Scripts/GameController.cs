using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public Player player;
    public float resetTime= 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (player.holdingBall == false)
        {
            resetTime -= Time.deltaTime;
            if (resetTime<= 0 )
            {
                SceneManager.LoadScene("Basketball");
            }
        }
    }
}
