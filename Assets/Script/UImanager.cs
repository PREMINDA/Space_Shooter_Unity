using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField]
    private Text _scortext;
    [SerializeField]
    private Sprite[] _livesimage;
    [SerializeField]
    private Image _Liveimge;
    [SerializeField]
    private Text _Gameover;
    private Game_state _Gamestate;
 

    void Start()
    {


        _Liveimge.sprite = _livesimage[3];
        _Gameover.gameObject.SetActive(false);
        _Gamestate = GameObject.Find("Game_state").GetComponent<Game_state>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void updatescore(int score)
    {
        _scortext.text = score.ToString();
        
    }
    public void updatelives(int lives)
    {
        _Liveimge.sprite = _livesimage[lives];
    }
    public void gameover()
    {
        _Gameover.gameObject.SetActive(true);
        _Gamestate.Gameover();
        StartCoroutine(blink());
        
    }
    private IEnumerator blink()
    {
        while (true)
        {
            _Gameover.text = "GAME OVER";
            yield return new WaitForSeconds(0.5f);
            _Gameover.text = "";
            yield return new WaitForSeconds(0.5f);
        }
    }
}
