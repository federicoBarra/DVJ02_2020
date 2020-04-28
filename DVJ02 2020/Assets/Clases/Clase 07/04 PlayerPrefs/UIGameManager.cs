using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DVJ02.Clase07
{
public class UIGameManager : MonoBehaviour
{
    private GameManager game;
    public Text scoreText;
    // Use this for initialization
    private void Start()
    {
        game = GameManager.Get();
        Refresh();
    }


    public void ScoreChange(int scoreChange)
    {
        game.Score += scoreChange;
        Refresh();
    }

    public void Refresh()
    {
        scoreText.text = "Score: " + game.Score;
    }

    public void EndGame()
    {
        game.EndGame();
    }

    public void LoadGame()
    {
        game.Load();
        Refresh();
    }

    public void SaveGame()
    {
        game.Save();
    }

    public void ClearSaves()
    {
        Persistance.Get().ClearSaves();
    }

}
}
