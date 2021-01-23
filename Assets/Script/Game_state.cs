using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_state : MonoBehaviour
{

    private bool _isgameover = false;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && _isgameover)
        {
            SceneManager.LoadScene(0);
        }
       
    }
    public void Gameover()
    {
        _isgameover = true;
    }
}
