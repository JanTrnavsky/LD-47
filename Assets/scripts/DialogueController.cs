using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{  
    [SerializeField]
    GameObject dialogueSystem;
    private bool isActive = false;
    private bool actualDialog;

    // Start is called before the first frame update
    void Start()
    {
        HandleActivityChange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDialogue(Dialogue dialogue) {
        actualDialog = dialogue;
        isActive = true;
        HandleActivityChange();
    }

    private void HandleActivityChange() {
        dialogueSystem.active = isActive;
    }
}
