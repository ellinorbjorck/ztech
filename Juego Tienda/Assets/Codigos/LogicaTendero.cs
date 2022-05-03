using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaTendero : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;
    bool interact = false;
    public GameObject box;
    GameObject drinks;
    GameObject drinks2;
    GameObject guide;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        drinks = GameObject.Find("group_512_on");
        drinks.SetActive(false);
        guide = GameObject.Find("Guide");
        guide.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0,x*Time.deltaTime*velocidadRotacion, 0);
        transform.Translate(0,0,y*Time.deltaTime*velocidadMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
        
        /*
        if (Input.GetKeyDown(KeyCode.I) && interact) {
            
            anim.SetTrigger("Pick_up");
            box = GameObject.Find("cardboardBox_03");
            MeshRenderer me = box.GetComponent<MeshRenderer>();
            if (drinks.activeInHierarchy)
            {

                drinks.SetActive(false);
                drinks2.SetActive(true);
                drinks2.transform.position = transform.position;
                interact = false;
            }
            else if (me.enabled) { me.enabled = false;
                
                GameObject.Find("Guide_text").GetComponent<TextMeshProUGUI>().text = "PRESS 'I' AGAIN TO PICK UP THE DRINKS.";
            }
            else {
                guide.SetActive(false);
                drinks2 = GameObject.Find("group_512");
                drinks2.SetActive(false);
                drinks.SetActive(true);

            }
            




        }*/
    }

    public void Interaction_enabled()
    {
        interact = true;
        guide.SetActive(true);
    }

    
}
