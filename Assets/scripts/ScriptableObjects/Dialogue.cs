using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Dialogue", menuName = "LD-47/Dialogue", order = 0)]
public class Dialogue : ScriptableObject {
    [SerializeField] Question[] questions;
    [TextArea(5,5)] [SerializeField] string story;
    [SerializeField] bool isLast;
}

[System.Serializable]
public struct Question {
    [TextArea(1,1)] public string question;
    public Dialogue followUp;
}