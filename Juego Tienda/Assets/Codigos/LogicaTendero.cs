using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaTendero : MonoBehaviour
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
        if (name == "Tendero")
        {
            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");

            transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

            anim.SetFloat("VelX", x);
            anim.SetFloat("VelY", y);
        }
        else
        {
            

           // transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
            transform.Translate(x * Time.deltaTime * velocidadMovimiento, 0, y * Time.deltaTime * velocidadMovimiento);

            anim.SetFloat("VelX", -x);
            anim.SetFloat("VelY", y);

            if(transform.position.x > 3.7)
            {
                y = 0;
                x = 1;
                
            }

            if (transform.position.z < 2.33)
            {
                x = 0;
            }
        }
    }
}
