using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIMainScene : MonoBehaviour
{
    public TextMeshProUGUI displayPlayerName;
    public void Awake()
    {
        displayPlayerName.text ="Name: "+ MainManager.Instance.samerTaqatqa;
    }



    public void ReturnToMain()
    {
        SceneManager.LoadScene(0);
    }
}
