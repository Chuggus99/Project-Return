using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ending2Text : MonoBehaviour
{
    public GameObject displayText;
    public AudioSource Audio;
    public AudioClip sound;
    public float volume = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        displayText.SetActive(false);
        Audio.GetComponent<AudioSource>();
    }

    // Update is called once per frame
  
    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            displayText.SetActive(true);
            StartCoroutine("WaitforSec");
            Audio.PlayOneShot(sound, volume);
        } 
    }
    IEnumerator WaitforSec()
    {
        yield return new WaitForSeconds(10);
        Destroy(displayText);
    }
}
