using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toGame : MonoBehaviour
{
    public GameObject gameButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startGame(string SceneToLoad)
    {
        SceneManager.LoadScene(SceneToLoad);

    }
    public void onButtonPushed()
    {
        if (gameButton == true)
        {
            SceneManager.LoadScene("Landscpe");
        }
    }
}
