using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    /// <summary>
    ///  Saves and Loads the player character's position in the game world
    /// </summary>


    /*    - Item ID's -
     *  Wood  000
     *  Stone 002
     *  Glass 003
     *     - Enemies -
     *  Slime  004
     *  Zombie 005
     *  Ghost  006
     */

    GameObject playerCharacter;

    private void Start()
    {
        playerCharacter = GameObject.Find("Player Character"); // Name of your player character
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Save();
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            Load();
        }


    }

    //Call this when we want to store data to playerPrefs
    private void Save()
    {
        // save the transform information of the player character
        // character's Vector3 variables are just 3 floats

        PlayerPrefs.SetFloat("playerXpos", playerCharacter.transform.position.x);
        PlayerPrefs.SetFloat("playerYpos", playerCharacter.transform.position.y);
        PlayerPrefs.SetFloat("playerZpos", playerCharacter.transform.position.z);
        Debug.Log("Saved player position data. ");
    }

    // Call this when we wan to retrieve the stored data
    private void Load()
    {
        Vector3 retrievedVector;

        // Load the player's position

        retrievedVector.x = PlayerPrefs.GetFloat("playerXpos", 0);
        retrievedVector.y = PlayerPrefs.GetFloat("playerYpos", 0); // Set the Y base height higher if your player is spawning in the ground
        retrievedVector.z = PlayerPrefs.GetFloat("playerZpos", 0);

        transform.position = retrievedVector;
    }  
    
        
    

}
