using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject arrowPrefab; //�m��Prefab�����}�ܼ�
    public GameObject catfoodPrefab;//�߫}���Y
    //float span = 1.0f;             //�ɶ����j
    //float delta = 0;               //�{�b�w�g�ֿn���ɶ�
    public GameObject hpGauge;
    public int blood = 10;
    public Text ScoreText;
    public int Score = 0;

    private void Start()
    {
        Score = 0;
        blood = 10;
        ScoreText.text = "����" + Score;
        InvokeRepeating("ArrowShot", 0, 1.0f);
        InvokeRepeating("CatFood", 4.5f, 5.0f);
    }

    void Update()
    {
        /*delta += Time.deltaTime;  // �ֿn�ɶ���delta
        if (delta > span) // �p�Gdelta�ɶ��ֿn�j��span�ɶ����j
        {
            delta = 0; // delta�ɶ��k�s            
            int px = Random.Range(-6, 7); // �H�����ͤ@��-6��6���������
            // ���ͷs�b�Y�A�åB�]�w�s�b�Y����m
            Instantiate(arrowPrefab, new Vector3(px, 7, 0), Quaternion.identity);

        }
        */
    }
    void ArrowShot()//�b�Y�X�{
    {
        Instantiate(arrowPrefab, new Vector3(Random.Range(-6, 7), 7, 0), Quaternion.identity);
    }
    void CatFood()//���Y�X�{
    {
        Instantiate(catfoodPrefab, new Vector3(Random.Range(-6, 7), 7, 0), Quaternion.identity);
    }

    public void DecreaseHP()//�Q�b�Y��������
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        blood -= 1;
        if(blood<=0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void AddHp()//�������Y�[��
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
        ScoreText.text = "���ơG"+Score;
    }
}
