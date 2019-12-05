using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    AudioSource m_MyAudioSource;

    void Awake()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        m_MyAudioSource.Play();
    }
}
