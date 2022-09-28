using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text ZahlText;
    private int score;

    void Start()
    {
        ZahlText.text = "";
    }

    void Update()
    {
        ZahlText.text = "" + score;
    }

    public void Plus()
    {
        score = score + 1;
    }

    public void Minus()
    {
        score = score - 1;
    }

    public void Plus10()
    {
        score = score + 10;
    }

    public void Minus10()
    {
        score = score - 10;
    }

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void Multiply()
    {
        score = score * 2;
    }

    public void Divide()
    {
        score = score / 2;
    }

    public void Reset()
    {
        score = 0;
    }


}
