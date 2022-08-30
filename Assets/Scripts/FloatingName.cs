using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloatingName : MonoBehaviour
{
    public Transform player;

    Vector3 offset = new(0, 2.1f, 0);

    void Start()
    {
        var textUI = GetComponent<TextMeshProUGUI>();
        textUI.text = PlayerPrefs.GetString("name");
    }

    void FixedUpdate()
    {
        transform.position = Camera.main.WorldToScreenPoint(player.position + offset);
    }
}
