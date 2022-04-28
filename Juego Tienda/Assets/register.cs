using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class register : MonoBehaviour

{
    public GameObject _exclamation;
    public Text _title;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;
    // Start is called before the first frame update
    void Start()
    {
        _exclamation.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Customer") 
			//Object name is the name of the GameObject you want to check for collisions with.
        {
			_title.text = "Customer is waiting";
            _exclamation.SetActive(true);
            audioSource.PlayOneShot(clip, volume);
        }
        
    }
}
