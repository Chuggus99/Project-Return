using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller : MonoBehaviour
{
   
    public GameObject playButton;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void OnButtonPush()
    {
        if (playButton == true)
        {
            
            SceneManager.LoadScene("Collectable");
        }
      
    }
   

}
