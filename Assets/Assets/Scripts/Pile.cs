using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pile : MonoBehaviour
{
    public int health = 13;
    public GameObject base1; //The different sprites to show the pile being built
    public GameObject base2;
    public GameObject complete;

    public GameObject gameWinUI;


    public void PileAdd()
    {
        health --;
        
        if (health <= 10)
        {
            base1.SetActive(true);
        }
        if (health <= 4)
        {
            base2.SetActive(true);
        }
        if (health == 0)
        {
            complete.SetActive(true);
            Time.timeScale = 0f;
            gameWinUI.SetActive(true);
        }

    }

    void Update()
    {
        if (gameWinUI.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }

}
