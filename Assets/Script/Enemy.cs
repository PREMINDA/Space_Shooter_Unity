using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private IEnumerator coroutine;
    [SerializeField]
    private float _speed = 6.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    StartCoroutine(WaitAndPrint());

    }

    // Update is called once per frame
    void Update()
    {

        enemyMove();

    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {
            Player playerobj = other.transform.GetComponent<Player>();
            if(playerobj != null)
            {
                Destroy(this.gameObject);
            }
            other.transform.GetComponent<Player>().Damage();
        }
        if (other.tag == "Laser")
        {
            Destroy(this.gameObject);
        }

    }

    private IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(20.0f);
        Destroy(gameObject);
    }

    void enemyMove() {

        Vector3 derection = new Vector3(0, -1, 0);

        transform.Translate(derection * _speed * Time.deltaTime);

        if (transform.position.y < -5.7f)
        {
            transform.position = new Vector3(Random.Range(-8f,8f), 8, 0);
        }
    }

    

}
