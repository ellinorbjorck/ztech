using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class product1 : MonoBehaviour
{
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
       // rend = GetComponent<Renderer>();
      //  Debug.Log(rend);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseEnter()
    {
        rend.material.color = Color.red;
    }


    public void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        rend.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
        
    }

}
