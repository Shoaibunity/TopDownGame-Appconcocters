using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static bool hasKey = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
             Debug.Log("Key collected");
            hasKey = true; 
            Destroy(this.gameObject);
        }
    }
}
