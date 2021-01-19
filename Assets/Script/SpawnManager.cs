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
   

    void Start()
    {


        StartCoroutine(WaitAndPrint());


    }

    

    // Update is called once per frame
    void Update()
    {
        

    }

    private IEnumerator WaitAndPrint()
    {
        
        while (true) {
            
            print("Coroutine ended: " + Time.time + " seconds");
            Vector3 posEnemy = new Vector3(Random.Range(-8f, 8f), 6, 0);
            GameObject newEneny =  Instantiate(_enemyPrefab,posEnemy, Quaternion.identity);
            newEneny.transform.parent = _enemyContainer.transform;
            
            yield return new WaitForSeconds(5.0f);
        }
        
    }
   
}
