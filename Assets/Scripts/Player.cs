using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
            //transform.position += new Vector3(3, 0, 0); 
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.GetComponent<GameManager>().DecreaseHP();
    }

    // 當玩家按下畫面左按鍵時，貓咪往左移動「3」
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    // 當玩家按下畫面右按鍵時，貓咪往右移動「3」
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }

}
