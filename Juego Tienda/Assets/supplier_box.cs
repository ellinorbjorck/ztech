using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class supplier_box : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown() {
        MeshRenderer me = gameObject.GetComponent<MeshRenderer>();
        me.enabled = false;

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            other.GetComponent<LogicaTendero>().Interaction_enabled();
            
        }
    }
}
 