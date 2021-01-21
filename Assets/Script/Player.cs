using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed = 8f;
    public GameObject laserPrefab;
    [SerializeField]
    private float _fireRate = 0.5f;
    private float _trple_fireRate = 0.2f;
    private float _canFire = -1f;
    private int lives = 0;
    public GameObject triple_laser;
    private bool ispowerUp = false;
    
    


    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame11.24
    void Update()
    {

        calculateMove();
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _canFire)
        {
            if (ispowerUp)
            {
                
                triplelaser();
            }
            else
            {
                fireLaser();

            }

        }

    }
    

    void calculateMove()
    {
        float horizon = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 derection = new Vector3(horizon, vertical, 0);

        transform.Translate(derection * _speed * Time.deltaTime);

        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y <= -3)
        {
            transform.position = new Vector3(transform.position.x, -3, 0);
        }

        //transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 2, -2), 0);

        if (transform.position.x >= 11.24)
        {
            transform.position = new Vector3(-11.24f, transform.position.y, 0);
        }
        else if (transform.position.x <= -11.28)
        {
            transform.position = new Vector3(11.24f, transform.position.y, 0);
        }
    }

    private void fireLaser()
    {
        
            _canFire = Time.time + _fireRate;
            Instantiate(laserPrefab, new Vector3(transform.position.x-0.2f, transform.position.y + 0.75f, 0), Quaternion.identity);
        
    }
    private void triplelaser()
    {
        _canFire = Time.time + _trple_fireRate;
        Instantiate(triple_laser, transform.position, Quaternion.identity);
    }

    public void Damage()
    {
        lives++;
        if(lives == 3)
        {
            Destroy(this.gameObject);
        }
        
    }
    public void change_gun_state()
    {
        ispowerUp = true;
        StartCoroutine(WaitAndPrint());
    }
    private IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(10.0f);
        ispowerUp = false;
    }
}
