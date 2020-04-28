using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DVJ02.Clase07
{
public class UIEndScreen : MonoBehaviour
{
    public Text finalScore;
    // Use this for initialization
    private void Start()
    {
        finalScore.text = "Final Score: " + GameManager.Get().Score;
    }

    // Update is called once per frame
    private void Update()
    {

    }

    public void GotoMainMenu()
    {
        SceneManager.LoadScene("DontDestroy 01 Start");
    }

    public void Replay()
    {
        GameManager.Get().StartGame();
    }
}
}
