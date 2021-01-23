using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    private IEnumerator coroutine;
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private GameObject _enemyContainer;
    [SerializeField]
    private GameObject _3laserPrefab;
    [SerializeField]
    private GameObject _sppedup;
    [SerializeField]
    private GameObject _shild_up;



    void Start()
    {

        StartCoroutine(WaitAndPrint()) ;
        StartCoroutine(power());
        StartCoroutine(sppedup_taker());
        StartCoroutine(shild_up());

    }

    

    // Update is called once per frame
    void Update()
    {
        

    }

    private IEnumerator WaitAndPrint()
    {
        
        while (true) {
            
            
            Vector3 posEnemy = new Vector3(Random.Range(-8f, 8f), 6, 0);
            GameObject newEneny =  Instantiate(_enemyPrefab,posEnemy, Quaternion.identity);
            newEneny.transform.parent = _enemyContainer.transform;
            
            yield return new WaitForSeconds(2.0f);
        }
        
    }
    private IEnumerator power()
    {

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(15f,25f));
            Vector3 postlaser = new Vector3(Random.Range(-8f, 8f), Random.Range(0f, -3f), 0);
            Instantiate(_3laserPrefab, postlaser, Quaternion.identity);
            
        }

    }
    private IEnumerator sppedup_taker()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(15f,25f));
            Vector3 pos_speeduper = new Vector3(Random.Range(-8f, 8f), Random.Range(0f, -3f), 0);
            Instantiate(_sppedup, pos_speeduper, Quaternion.identity);

        }
    }
    private IEnumerator shild_up()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(15f, 25f));
            Vector3 pos_shild = new Vector3(Random.Range(-8f, 8f), Random.Range(0f, -3f), 0);
            Instantiate(_shild_up, pos_shild, Quaternion.identity);
        }
    }

}
