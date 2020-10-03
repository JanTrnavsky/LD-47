using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Interactable Character", menuName = "LD-47/Character", order = 0)]
public class Character : ScriptableObject {

    public enum Sex {Male, Female};
    public string characterName;
    public Sex sex;
    public Sprite dialogImage;
    public bool isIntoPlayerSex;
}