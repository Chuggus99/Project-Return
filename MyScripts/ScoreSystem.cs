using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int itemValue = 0;
   public  Text item;
    // Start is called before the first frame update
    void Start()
    {
        item.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        item.text = "Items Collected: " + itemValue;
    }
}
