using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Display2 : MonoBehaviour
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
            Text_Display.GetComponent<Text>().text = "Who was that?";
            StartCoroutine("waitForSec");
        }
    }
    IEnumerator WaitforSec()
    {
        yield return new WaitForSeconds(5);

        Destroy(gameObject);
        Destroy(Text_Display);
    }
}
