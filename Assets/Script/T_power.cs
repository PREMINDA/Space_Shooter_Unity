using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_power : MonoBehaviour
{

    [SerializeField]
    private AudioClip aud_clip;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndPrint());
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player playerobj = collision.transform.GetComponent<Player>();
           if(playerobj != null)
            {
                AudioSource.PlayClipAtPoint(aud_clip, transform.position);
                StartCoroutine(destroy());
               collision.transform.GetComponent<Player>().change_gun_state();

            }


        }
    }

    private IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(5.0f);
        Destroy(this.gameObject);
    }

    private IEnumerator destroy()
    {
        yield return new WaitForSeconds(0.1f);
        
        Destroy(this.gameObject);
        
    }
}
