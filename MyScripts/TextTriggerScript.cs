using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTriggerScript : MonoBehaviour
{
    public GameObject TextTigger;
    public AudioClip sound;
    public AudioSource audioSource;
    public float volume = 0.5f;
    // Start is called before the first frame update
    // When the game starts the text is turned off util the collider is triggered
    void Start()
    {
        TextTigger.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    // When the player enter the collider it displays the text with audio
    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            
            TextTigger.SetActive(true);
               StartCoroutine("WaitforSec");
            audioSource.PlayOneShot(sound, volume);
            
        }
    }
    //When the text is done, it is destroyed and it adds a point to counter
    IEnumerator WaitforSec()
        {
            yield return new WaitForSeconds(6);
            Destroy(gameObject);
            Destroy(TextTigger);
        }
}
