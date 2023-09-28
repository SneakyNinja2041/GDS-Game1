using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{

    // reference Inventory script
    Inventory inventory;
    [SerializeField] GameObject player;

    void Awake()
    {
        inventory = player.GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (inventory.inventoryFull == false)
            {
                Destroy(this.gameObject);
            }

            if (inventory.inventoryFull == true)
            {
                return;
            }


        }


    }




}
