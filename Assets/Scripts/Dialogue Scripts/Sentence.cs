using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewSentence", menuName ="Dialogue/Sentence")]
public class Sentence : ScriptableObject
{
    [TextArea(3, 10)]
    public string text = "text";
    public Sentence nextSentence;
    public string attachedFacePortrait;
}