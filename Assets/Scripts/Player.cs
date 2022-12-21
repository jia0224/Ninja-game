using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{
    public GameObject gameManager;
    AudioSource audiosource;
    public AudioClip move;
    public AudioClip gethit;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
            //transform.position += new Vector3(3, 0, 0); 
            audiosource.PlayOneShot(move);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
            audiosource.PlayOneShot(move);
        }
    }


    // ���a���U�e��������ɡA�߫}�������ʡu3�v
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
        audiosource.PlayOneShot(move);
    }

    // ���a���U�e���k����ɡA�߫}���k���ʡu3�v
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
        audiosource.PlayOneShot(move);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.GetComponent<GameManager>().DecreaseHP();
        audiosource.PlayOneShot(gethit);
        if (collision.tag == "Arrow")
        {
            gameManager.GetComponent<GameManager>().DecreaseHP();
            audiosource.PlayOneShot(gethit);
        }
        if (collision.tag == "catfood")
        {
            gameManager.GetComponent<GameManager>().AddHp();
            audiosource.PlayOneShot(gethit);
        }

    }

}
