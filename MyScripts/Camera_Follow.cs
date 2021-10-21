using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public GameObject Player;
    private float camToPlayerDistance;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        camToPlayerDistance = Vector3.Distance(transform.position, Player.transform.position);
        transform.position = Vector3.Lerp(transform.position, Player.transform.position, camToPlayerDistance * Time.deltaTime);
    }
}
