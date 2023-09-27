using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    

    public GameObject gameOverUI;

    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    public int currentSprite;

    public float sunChangeTimerReset = 15;
    public float sunChangeTimer;
    public int sunPhase = 0;

    private void Start()
    {
        sunChangeTimer = sunChangeTimerReset;

    }

    void Update()
    {
        sunChangeTimer -= Time.deltaTime;
       
        if (sunChangeTimer <0) //  at specific time milestones, like 105 sec left)
        {
            sunChangeTimer = sunChangeTimerReset;
            sunPhase++;

            ChangeSprite();
        }



    }

    void ChangeSprite()
    {
        if (sunPhase == spriteArray.Length)
        {
            sunPhase = 0; 
        }

        spriteRenderer.sprite = spriteArray[sunPhase];

        if (sunPhase >= 9)
        {
            Debug.Log("Game Over!");
            Time.timeScale = 0f;
            gameOverUI.SetActive(true);
            // turn gameOverUI on;
        }
        // TODO check if sunPhase > 9 , then GameOver
    }

}
