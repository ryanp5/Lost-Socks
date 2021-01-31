using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSock : MonoBehaviour
{
    public SpriteRenderer bitssock;
    public SpriteRenderer basesock;
    public SpriteRenderer mouth;
    public Transform facebits;
    public void SetSockParts(Sock sock)
    {
        bitssock.color = sock.OtherBitsColor;
        basesock.color = sock.baseColour;
        mouth.sprite = sock.Mouth;
        if (sock.TypeOfSock == Type.left)
        {
            facebits.localPosition = new Vector3(80, 0, 0);
            basesock.flipX = true;
            bitssock.flipX = true;
        }
        else
        {
            basesock.flipX = false;
            bitssock.flipX = false;
            facebits.localPosition = new Vector3(0, 0, 0);


        }
    }
}
