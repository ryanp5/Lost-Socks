using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SockManager : ScriptableObject
{
    public List<Sock> AllSocks = new List<Sock>();
    public List<Sock> pairedSocks = new List<Sock>();
    public Sock currentSock;
    public Sock SockToMatch;
    public bool firstTry;
    public void moveSock(Sock sock)
    {
        AllSocks.Remove(sock);
        pairedSocks.Add(sock);
    }
}
