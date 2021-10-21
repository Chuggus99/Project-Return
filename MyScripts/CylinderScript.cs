using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CylinderScript : MonoBehaviour
{
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        Text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Text.SetActive(true);
            StartCoroutine("WaitforSec");
        }
    }
    IEnumerator WaitforSec()
    {
        yield return new WaitForSeconds(6);
        Destroy(Text);
        Destroy(gameObject);
    }
}
