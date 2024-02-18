using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueUIText;
    public Canvas dialogueCanvas;
    //public GameObject dialogueBorder;
    public bool endedDialogue;
    public bool skip;
    public bool typing;

    private DialogueTree dialogue;
    private Sentence currentSentence = null;

    // Disables player movement when starting dialogue
    public void StartDialogue(DialogueTree dialogueTree)
    {
        dialogue = dialogueTree;
        endedDialogue = false;
        skip = false;
        typing = false;
        currentSentence = dialogue.startingSentence;
        dialogueCanvas.enabled = true;
        //dialogueBorder.SetActive(true);
        DisplaySentence();
    }

    public void AdvanceSentence(){
        currentSentence = currentSentence.nextSentence;
        skip = false;
        typing = false;
        DisplaySentence();
    }

    public void DisplaySentence(){
        if (currentSentence == null){
            EndDialogue();
            return;
        }
        string sentence = currentSentence.text;

        StopAllCoroutines();
        if(!skip){
            StartCoroutine(TypeSentence(sentence));
        }
        else if(skip){
            dialogueUIText.text = sentence;
        }
    }

    IEnumerator TypeSentence(string sentence){
        typing = true;
        dialogueUIText.text = "";
        foreach(char letter in sentence.ToCharArray()){
            dialogueUIText.text += letter;
            if (!skip){
                yield return new WaitForSeconds(0.05f);
            }
        }
        typing = false;
    }

    void EndDialogue()
    {
        dialogueUIText.text = "";
        endedDialogue = true;
        //dialogueBorder.SetActive(false);
    }
}   
