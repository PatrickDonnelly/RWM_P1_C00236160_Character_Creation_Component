using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChanger : MonoBehaviour
{
    public Slider red;
    public Slider green;
    public Slider blue;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = new Color(red.value, green.value, blue.value);
    }
}
