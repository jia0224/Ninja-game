using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject arrowPrefab; //置放Prefab的公開變數
    public GameObject catfoodPrefab;//貓咪罐頭
    //float span = 1.0f;             //時間間隔
    //float delta = 0;               //現在已經累積的時間
    public GameObject hpGauge;
    public int blood = 10;
    public Text ScoreText;
    public int Score = 0;

    private void Start()
    {
        Score = 0;
        blood = 10;
        ScoreText.text = "分數" + Score;
        InvokeRepeating("ArrowShot", 0, 1.0f);
        InvokeRepeating("CatFood", 4.5f, 5.0f);
    }

    void Update()
    {
        /*delta += Time.deltaTime;  // 累積時間到delta
        if (delta > span) // 如果delta時間累積大於span時間間隔
        {
            delta = 0; // delta時間歸零            
            int px = Random.Range(-6, 7); // 隨機產生一個-6到6之間的整數
            // 產生新箭頭，並且設定新箭頭的位置
            Instantiate(arrowPrefab, new Vector3(px, 7, 0), Quaternion.identity);

        }
        */
    }
    void ArrowShot()//箭頭出現
    {
        Instantiate(arrowPrefab, new Vector3(Random.Range(-6, 7), 7, 0), Quaternion.identity);
    }
    void CatFood()//罐頭出現
    {
        Instantiate(catfoodPrefab, new Vector3(Random.Range(-6, 7), 7, 0), Quaternion.identity);
    }

    public void DecreaseHP()//被箭頭擊中扣血
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        blood -= 1;
        if(blood<=0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void AddHp()//接到罐頭加血
    {
        hpGauge.GetComponent<Image>().fillAmount += 0.1f;
        blood += 1;
        if (blood>10)
        {
            blood = 10;
        }
    }
    public void IncreaseScore()
    {
        Score += 10;
        ScoreText.text = "分數："+Score;
    }
}
