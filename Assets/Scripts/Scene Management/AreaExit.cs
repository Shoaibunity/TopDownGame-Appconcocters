

using UnityEngine;
using UnityEngine.UI;
public class AreaExit : MonoBehaviour
{
    [SerializeField] private Text hintText;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.GetComponent<PlayerController>() && Key.hasKey)
        {

            hintText.GetComponent<Text>().text = " Task completed";
        }
         if (other.gameObject.GetComponent<PlayerController>() && !Key.hasKey) 
        {
            hintText.gameObject.SetActive(true);
            hintText.GetComponent<Text>().text = " Collect the key to unlock the door";
         
        }

        }

    }

  