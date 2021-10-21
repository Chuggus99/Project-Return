using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour
{
    public GameObject disText;
    public AudioClip sound;
    public AudioSource Audio;
    public float volume = 0.5f;

    // Start is called before the first frame update
    // When the game starts the text is turned off util the collider is triggered
    void Start()
    {
        disText.SetActive(false);
        Audio=GetComponent<AudioSource>();
    }

    // Update is called once per frame
 // When the player enter the collider it displays the text with audio
    private void OnTriggerEnter(Collider player)
    {
       
        if (player.gameObject.tag == "Player")
        {
            
            disText.SetActive(true);

            StartCoroutine("WaitforSec");
            Audio.PlayOneShot(sound, volume);
        }
    }
    //When the text is done, it is destroyed and it adds a point to counter
    IEnumerator WaitforSec()
    {
        yield return new WaitForSeconds(6);
      
        Destroy(gameObject);
        ScoreSystem.itemValue++;
        Destroy(disText);
    }
    
}
