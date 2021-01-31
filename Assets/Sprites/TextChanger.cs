using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextChanger : MonoBehaviour
{
    public TextHolder textHolder;
    public GameEvent finishedIntroText;
    private TextMeshPro text;
    int curr = 0;
    private void Start()
    {
        text = GetComponent<TextMeshPro>();
    }
    public void NextText()
    {
        if (curr < textHolder.texts.Length) {
            text.SetText(textHolder.texts[curr]);
            curr++;
        }
        else
        {
            finishedIntroText.Raise();
            text.enabled = false;
        }
    }
}
