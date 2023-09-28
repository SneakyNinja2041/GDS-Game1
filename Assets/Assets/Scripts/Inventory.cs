using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    // reference to pile script
    Pile pile;
    [SerializeField] GameObject pileObject;

    public int maxStones = 6;
    public int inventory = 0;
    public int startInventory = 0;

    public bool inventoryFull = false;

    // changes to the player sprite when collecting stones
    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject block4;
    public GameObject block5;
    public GameObject block6;

    void Awake()
    {
        pile = pileObject.GetComponent<Pile>();
        
    }

    void Start()
    {
        inventory = startInventory;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Stone"))
        {
            if (inventoryFull == false)          
            {
                inventory++;               
            }
        }

        if (other.CompareTag("Pile"))
        {  
            if (inventory > startInventory)
            {
                inventory--;
                pile.PileAdd();
            }
        }
    }
    
    void Update()
    {
        if (inventory == maxStones)
        {          
            inventoryFull = true;
        }
        else
        {
            inventoryFull = false;
        }


        if (inventory == 1)
        {
            block1.SetActive(true);
        }
        else
        {
            block1.SetActive(false);
        }

        if (inventory == 2)
        {
            block2.SetActive(true);
        }
        else
        {
            block2.SetActive(false);
        }

        if (inventory == 3)
        {
            block3.SetActive(true);
        }
        else
        {
            block3.SetActive(false);
        }

        if (inventory == 4)
        {
            block4.SetActive(true);
        }
        else
        {
            block4.SetActive(false);
        }

        if (inventory == 5)
        {
            block5.SetActive(true);
        }
        else
        {
            block5.SetActive(false);
        }

        if (inventory == 6)
        {
            block6.SetActive(true);
        }
        else
        {
            block6.SetActive(false);
        }
    }
}
