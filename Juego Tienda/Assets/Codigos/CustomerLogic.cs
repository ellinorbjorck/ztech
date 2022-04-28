using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerLogic : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        x = 0;
        y = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(x * Time.deltaTime * velocidadMovimiento, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("VelX", -x);
        anim.SetFloat("VelY", y);

        if(transform.position.x > 3.5 && transform.position.z > 2.33 )
        {
            y = 0;
            x = 1;
            
        }

        else if (transform.position.z < 2.33 && transform.position.x < 4.65)
        {
            x = 0;
            y = 1;
        }
        
        else if (transform.position.x > 4.7){
            y = 0;
            x = 0;
        }
    }
}
