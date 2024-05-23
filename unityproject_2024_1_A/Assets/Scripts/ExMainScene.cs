using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExMainScene : MonoBehaviour
{
    public void GoToShootGame()                  //��ư�� ȣ�� �� �Լ��� ����
    {
        SceneManager.LoadScene("GameScene_Gun");        //GameScene_Gun �̵�
    }

    public void GoToJumpGame()                  //��ư�� ȣ�� �� �Լ��� ����
    {
        SceneManager.LoadScene("GameScene_Jump");        //GameScene_Jump �̵�
    }

    public void GoExit()                  //��ư�� ȣ�� �� �Լ��� ����
    {
        Application.Quit();                         //���� ����
    }
}
