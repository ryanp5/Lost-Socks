using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type { left, right };
public enum Sex { male, female };
[CreateAssetMenu]
public class Sock : ScriptableObject
{
    public Color baseColour;
    public Color OtherBitsColor;
    public Sprite OtherBits;
    public Sprite Base;
    public Sprite Mouth;
    public new string name;
    public Type TypeOfSock;
    public Sex SexOfSock;
    public Sock partner;
    public Sprite Sprite; 
    public string bio;
}
