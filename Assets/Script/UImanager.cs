using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField]
    private Text _scortext;

    void Start()
    {

    

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void updatescore(int score)
    {
        _scortext.text = score.ToString();
    }
}
