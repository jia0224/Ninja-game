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

    // ���a���U�e��������ɡA�߫}�������ʡu3�v
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    // ���a���U�e���k����ɡA�߫}���k���ʡu3�v
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }

}
