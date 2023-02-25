using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour
{
    public Text itemUI;
    public int currentNumberOfItems = 0;

    private void Update()
    {
        itemUI.text = "" + currentNumberOfItems;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Item"))
        {
            currentNumberOfItems++;
        }
    }
}
