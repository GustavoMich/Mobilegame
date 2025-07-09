using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableBase : MonoBehaviour
{
    public string compareTag = "Player";
    public ParticleSystem myparticleSystem;
    public float timeToHide = 1;
    public GameObject graphicItem;

    [Header("Sounds")]
    public AudioSource audioSource;


    private void Awake()
    {
        if (myparticleSystem != null) myparticleSystem.transform.SetParent(null);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag(compareTag))
        {
            Collect();
        }
    }
    
    protected virtual void Collect()
    {
        if(graphicItem != null) graphicItem.SetActive(false);
        Invoke("HideObject", timeToHide);
        OnCollect();
    }

    public void HideObject()
    {
        gameObject.SetActive(false);

    }


    protected virtual void OnCollect() 
    { 
        if (myparticleSystem != null) myparticleSystem.Play();
        if (audioSource != null) audioSource.Play();
    }



}
