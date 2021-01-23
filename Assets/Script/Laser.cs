using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed = 15f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * _speed * Time.deltaTime);

        if (transform.position.y > 8f)
        {

            OnBecameInvisible();

            if (transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }

        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
