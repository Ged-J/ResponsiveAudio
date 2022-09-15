using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{

    private AudioSource source;


    // Start is called before the first frame update
    void Start()
    {

       source = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        source.Play();

    }

    private void OnTriggerExit(Collider other)
    {
        source.Stop();
    }



}
