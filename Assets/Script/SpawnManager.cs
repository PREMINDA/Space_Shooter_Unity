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



    void Start()
    {

        StartCoroutine(WaitAndPrint()) ;
        StartCoroutine(power());

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
            
            yield return new WaitForSeconds(4.0f);
        }
        
    }
    private IEnumerator power()
    {

        while (true)
        {
            yield return new WaitForSeconds(20.0f);
            Vector3 posEnemy = new Vector3(Random.Range(-8f, 8f), Random.Range(0f, -3f), 0);
            Instantiate(_3laserPrefab, posEnemy, Quaternion.identity);
            
        }

    }

}
