using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExResultScene : MonoBehaviour
{
    public Text TextUI;                                     //UI ������Ʈ�� �޾ƿͼ�

    public void Start()
    {
        TextUI.text = PlayerPrefs.GetInt("Point").ToString();           //int�� ����� Point�� �����ͼ� toString()�Լ��� ���ڿ��� ��ȯ���ش�.
    }

    public void GoToGame()                  //��ư�� ȣ�� �� �Լ��� ����
    {
        SceneManager.LoadScene("MainScene");        //MainScene �̵�(����)
    }
}
