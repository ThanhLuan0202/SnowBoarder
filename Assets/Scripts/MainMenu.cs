using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Scene0");
    }
    public void Instruct()
    {
        SceneManager.LoadSceneAsync("instruct");
    }
    public void Back()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
    public void Quit()
    {
        Debug.Log("Game is quitting..."); // Chỉ hiển thị log khi chạy trong Editor
        Application.Quit(); // Thoát game

        // Chỉ hoạt động khi build game, không hoạt động trong Unity Editor
    }

}
