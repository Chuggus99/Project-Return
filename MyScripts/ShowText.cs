using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public AudioClip sound;
    AudioSource Audio;
    public float volume =0.5f;
    public GameObject textObject;
    // Start is called before the first frame update
    void Start()
    {
        textObject.SetActive(false);
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            
            textObject.SetActive(true);
          
       
            StartCoroutine("WaitforSec");
        Audio.PlayOneShot(sound, volume);
        }
       
        
    }
    IEnumerator WaitforSec()
    {
        yield return new WaitForSeconds(5);

        Destroy(gameObject);
        Destroy(textObject);

    }
}
