﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shild_Up : MonoBehaviour
{

    [SerializeField]
    private AudioClip aud_clip;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wait_for_get());
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Player obj = collision.transform.GetComponent<Player>();
            if (obj != null)
            {
                AudioSource.PlayClipAtPoint(aud_clip, transform.position);
                StartCoroutine(waitf_for_destroy());
                collision.transform.GetComponent<Player>().shildup();
            }
        }
    }
    private IEnumerator waitf_for_destroy()
    {
        yield return new WaitForSeconds(0.2f);
       
        Destroy(this.gameObject);
    }

    private IEnumerator wait_for_get()
    {
        yield return new WaitForSeconds(5.0f);

        if (this.gameObject != null)
        {
            Destroy(this.gameObject);
        }

    }
}
