using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    private float speedRotate = 30f;// Start is called before the first frame update
    [SerializeField]
    private GameObject explo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 location = transform.position;

        if(collision.tag == "Laser")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Instantiate(explo, location, Quaternion.identity);
           
        }
    }
}
