using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EndingScript : MonoBehaviour
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
        if( player.gameObject.tag=="Player" && ScoreSystem.itemValue==7)
        {
            SceneManager.LoadScene("Ending2");
        }
        else if(player.gameObject.tag=="Player" && ScoreSystem.itemValue != 7)
        {
            Text.SetActive(true);
           
        }
      
    }
    private void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Text.SetActive(false);
        }
    }
}
