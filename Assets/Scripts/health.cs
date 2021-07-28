using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Image[] bird_img;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for( int i = 0; i < bird_img.Length ; i++)
        {
            if (i < Bird.Instance.numberOfBirds)
            {
                bird_img[i].enabled = true;
            }
            else
            {
                bird_img[i].enabled = false;
            }
        }
    }
}
