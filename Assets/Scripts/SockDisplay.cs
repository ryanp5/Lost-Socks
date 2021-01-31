using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SockDisplay : MonoBehaviour
{
    public GameEvent MatchFound;
    public GameEvent NotMatch;
    //public Sock sock;
    int curr = 0;
    public SockManager sockManager;
    public SockManager FoundSocks;
    public SpriteRenderer baseSock;
    public SpriteRenderer bitsSock;
    public Transform FaceBits;
    public SpriteRenderer Mouth;
    // Start is called before the first frame update
    public Text bioTxt;
    public Text nameTxt;
    void Start()
    {
        setNewSock();
        //SetSock(sockManager.AllSocks[curr]);
        //SetSock(sockManager.AllSocks[Random.Range(0, sockManager.AllSocks.Count - 1)]);
    }
    public void setNewSock()
    {
        //Debug.Log(sockManager.AllSocks.Count);
        //Debug.Log(curr);
        if (curr <= sockManager.AllSocks.Count - 1)
        {
            curr++;
            if (sockManager.AllSocks[curr - 1] != sockManager.SockToMatch)
            {
                SetSock(sockManager.AllSocks[curr - 1]);
            }
            else
            {
                if (curr == sockManager.AllSocks.Count)
                {
                    NotMatch.Raise();
                    curr = 0;
                    return;
                }
                SetSock(sockManager.AllSocks[curr]);
                curr++;
            }
        }
        else {
            NotMatch.Raise();
        }
    }
    public void SetSock(Sock sock)
    {
        bioTxt.text = sock.bio;
        nameTxt.text = sock.name;
        bitsSock.color = sock.OtherBitsColor;
        baseSock.color = sock.baseColour;
        Mouth.sprite = sock.Mouth;
        if (sock.TypeOfSock == Type.left)
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
    public void checkIfMatch()
    {
        if (sockManager.AllSocks[curr -1] == sockManager.SockToMatch.partner)
        {
            sockManager.pairedSocks.Add(sockManager.SockToMatch.partner);
            sockManager.pairedSocks.Add(sockManager.SockToMatch);
            curr = 0;
            sockManager.AllSocks.Remove(sockManager.SockToMatch);
            sockManager.AllSocks.Remove(sockManager.SockToMatch.partner);
            MatchFound.Raise();
        }
        else
        {
            NotMatch.Raise();
        }
    }
}
