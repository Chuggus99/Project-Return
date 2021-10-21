using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlanePickup : MonoBehaviour
{
    public GameObject Text_Display;
    // Start is called before the first frame update
    void Start()
    {
        Text_Display.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
           Text_Display.SetActive(true);
            StartCoroutine("WaitforSec");
        }
    }
    IEnumerator WaitforSec()
    {
        yield return new WaitForSeconds(5);

        Destroy(gameObject);
        Destroy(Text_Display);
    }
}
