using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EndSockManager : MonoBehaviour
{
    //public SockManager endSocks;
    public SockManager allSocks;
    public GameObject sockPrefab;
    public Button buttonStart;
    private AudioSource audioClip;
    public TextMeshProUGUI text;
    int count = 0;
    // Start is called before the first frame update
    private void Start()
    {
        audioClip = GetComponent<AudioSource>();
        for(int i = allSocks.pairedSocks.Count -1; i  >= 0; i--)
        {
           count++;
           GameObject curr = Instantiate(sockPrefab, transform);
           curr.name = allSocks.pairedSocks[i].name;
           curr.GetComponent<SetSock>().SetSockParts(allSocks.pairedSocks[i]);
           if (i%2 == 0)
            {
                curr.GetComponent<RectTransform>().localPosition = new Vector3(80 * count, 0, 0);
            }
            else
            {
                curr.GetComponent<RectTransform>().localPosition = new Vector3(80 * -count, 0, 0);
            }
        }
        if (allSocks.AllSocks.Count == 0)
        {
            buttonStart.enabled = false;
            text.text = "All Socks Matched Congrats!";
            audioClip.Play();
        }

    }

}
