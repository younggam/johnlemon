using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LobbyNameInput : MonoBehaviour
{
    public TextMeshProUGUI nameInput;

    void OnInputDone()
    {
        PlayerPrefs.SetString("name", nameInput.text.Length <= 1 ? "John Lemon" : nameInput.text);
        SceneManager.LoadSceneAsync(1);
    }
}
