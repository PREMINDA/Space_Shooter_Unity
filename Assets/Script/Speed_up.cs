using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_up : MonoBehaviour
{
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
            Player playerobj = collision.transform.GetComponent<Player>();
            if(playerobj != null)
            {
                StartCoroutine(waitf_for_destroy());
                collision.transform.GetComponent<Player>().speed_max();
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
        
        if(this.gameObject != null) 
        {
            Destroy(this.gameObject);
        }
        
    }
}
