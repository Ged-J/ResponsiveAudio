using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CombatMusicControl : MonoBehaviour
{

    public AudioMixerSnapshot outOfCombat;
    public AudioMixerSnapshot inCombat;

    [SerializeField] private float m_Transition = 1f;

    public AudioClip[] stings;
    public AudioSource stingSource;


    public void OnTriggerEnter(Collider other)
    {
        
        if(other.CompareTag("TriggerZone"))
        {
            inCombat.TransitionTo(m_Transition);
        }

        PlaySting();

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            outOfCombat.TransitionTo(m_Transition);
        }
    }

    void PlaySting()
    {
        int randClip = Random.Range(0, stings.Length);
        stingSource.clip = stings[randClip];
        stingSource.Play();
    }


}
