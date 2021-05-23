using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Text winText;
    void Start()
    {
        winText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Rigidbody>() == null)
        {
            winText.enabled = true;
        }
    }
}
