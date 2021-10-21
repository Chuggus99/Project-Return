using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager2 : MonoBehaviour
{
    public GameObject playButton;
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
    public void OnButtonPush()
    {
        if (playButton == true)
        {
SceneManager.LoadScene("Other_Scene");
        }
    }
}
