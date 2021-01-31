using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class SetupGame : MonoBehaviour
{
    public SockManager manager;
    public SpriteRenderer baseSock;
    public SpriteRenderer bitsSock;
    public Transform FaceBits;
    public SpriteRenderer Mouth;
    public TextMeshProUGUI bioTxt;
    public TextMeshProUGUI nameTxt;
    public GameEvent notFirstTry;
    private void Start()
    {
        RandomiseSockList(manager.AllSocks);
        Sock starter =  ChooseStartingSock();
        //if (starter != null)
        //{
            SetStartingSock(starter);
        //}
        if (!manager.firstTry)
        {
            notFirstTry.Raise();
        }
    }

    private void RandomiseSockList(List<Sock> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int k = UnityEngine.Random.Range(i, list.Count);
            Sock tmp = list[i];
            list[i] = list[k];
            list[k] = tmp;
        }
    }

    private void SetStartingSock(Sock sock)
    {
        bioTxt.text = sock.bio;
        nameTxt.text = manager.SockToMatch.name;
        bitsSock.color = sock.OtherBitsColor;
        baseSock.color = sock.baseColour;
        Mouth.sprite = sock.Mouth;
        if (manager.SockToMatch.TypeOfSock == Type.left)
        {
            FaceBits.localPosition = new Vector3(80, 0, 0);
            baseSock.flipX = true;
            bitsSock.flipX = true;
        }
        else
        {
            baseSock.flipX = false;
            bitsSock.flipX = false;
            FaceBits.localPosition = new Vector3(0, 0, 0);


        }
    }
    
    private Sock ChooseStartingSock()
    {
        int sockId = UnityEngine.Random.Range(0, manager.AllSocks.Count - 1);
        manager.SockToMatch = manager.AllSocks[sockId];
        //manager.AllSocks.Remove(manager.SockToMatch);
        return manager.SockToMatch;
    }
}
