using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Intro_Text : MonoBehaviour
{
    public GameObject IntroText;
    public AudioClip sound;
    public AudioSource Audio;
    public float volume= 0.5f;
  
    // Start is called before the first frame update
    void Start()
    {
        IntroText.SetActive(false);
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            IntroText.SetActive(true);
            StartCoroutine("WaitforSec");
           Audio.PlayOneShot(sound, volume);
        
        }
        
    }
    IEnumerator WaitforSec()
    {
        yield return new WaitForSeconds(6);

        Destroy(gameObject);
        Destroy(IntroText);
    }
}
