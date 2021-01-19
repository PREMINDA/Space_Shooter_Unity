using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed = 3.5f;
    public GameObject laserPrefab;
    [SerializeField]
    private float _fireRate = 0.5f;
    private float _canFire = -1f;

    
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
            fireLaser();
            dualLacer();
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
    void fireLaser()
    {
        
            _canFire = Time.time + _fireRate;
            Instantiate(laserPrefab, new Vector3(transform.position.x-0.2f, transform.position.y + 0.75f, 0), Quaternion.identity);
        
    }
    void dualLacer()
    {
        _canFire = Time.time + _fireRate;
        Instantiate(laserPrefab, new Vector3(transform.position.x+0.2f, transform.position.y + 0.75f, 0), Quaternion.identity);
    }
}
