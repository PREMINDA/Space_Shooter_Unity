using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private IEnumerator coroutine;
    [SerializeField]
    private float _speed = 5.0f;
    private Player _player;
    private Animator anim;
    private AudioSource aud;





    // Start is called before the first frame update
    void Start()
    {
        
    StartCoroutine(WaitAndPrint());
        anim = GetComponent<Animator> ();
        aud = GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {

        enemyMove();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            Player playerobj = other.transform.GetComponent<Player>();
            if(playerobj != null)
            {
                anim.SetTrigger("EnemyDeath");
                aud.Play();
                Destroy(this.gameObject, 2.2f);
                _speed = 0;
            }
            other.transform.GetComponent<Player>().Damage();
        }
        if (other.tag == "Laser")
        {
            _player = GameObject.Find("Player").GetComponent<Player>() ? GameObject.Find("Player").GetComponent<Player>() : null;

            if (_player != null)
            {
                anim.SetTrigger("EnemyDeath");
                aud.Play();
                Destroy(this.gameObject, 2.2f);
                _speed = 0;
                _player.increase_score();
               
            }

        }

    }

    private IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(30.0f);
        Destroy(gameObject);
    }

    void enemyMove() {
        Vector3 derection;

       
           derection = new Vector3(0, -1, 0);

            transform.Translate(derection * _speed * Time.deltaTime);

            if (transform.position.y < -5.7f)
            {
                transform.position = new Vector3(Random.Range(-8f, 8f), 8, 0);
            
            }
      
    }
   

    

}
