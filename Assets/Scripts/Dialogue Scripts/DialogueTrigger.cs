using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueTree dialogue;
    public DialogueManager dialogueManager;

    void Start()
    {
        dialogueManager.StartDialogue(dialogue);
    }

    void Update()
    {
        // Player presses X to advance on-screen dialogue
        if(Input.GetKeyDown(KeyCode.X)){
            if(dialogueManager.typing){
                dialogueManager.skip = true;
            }
            if (!dialogueManager.skip || !dialogueManager.typing){
                dialogueManager.dialogueClientText.text = "";
                dialogueManager.AdvanceSentence();
            }
        }
    }
}
