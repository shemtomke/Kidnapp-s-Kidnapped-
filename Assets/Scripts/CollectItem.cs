using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour
{
    public Text itemUI, pickUpUI;
    public int currentNumberOfItems = 0;

    private void Start()
    {
        pickUpUI.gameObject.SetActive(false);
    }
    private void Update()
    {
        itemUI.text = "" + currentNumberOfItems;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Item")) //Add a Tag for the Item to pickup
        {
            //Show a UI to pick Up something
            pickUpUI.gameObject.SetActive(true);

            //Click a key input to collect/Pickup
            if(Input.GetKeyDown(KeyCode.P))
            {
                currentNumberOfItems++;
                Destroy(other.gameObject);
            }
        }
    }
}
