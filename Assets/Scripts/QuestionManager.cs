using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public Button false1;
    public Button false2;
    public GameObject falsetext;

    void Start()
    {
        falsetext.SetActive(false);

        false1.GetComponent<Button>();
        false1.onClick.AddListener(OnClick);

        false2.GetComponent<Button>();
        false2.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        falsetext.SetActive(true);
    }
}