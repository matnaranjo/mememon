using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Test : MonoBehaviourPunCallbacks
{
    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnPlayerEnteredRoom(Player newPlayer){
        Debug.Log(PhotonNetwork.LocalPlayer.UserId);
        foreach (Player player in PhotonNetwork.PlayerList)
        {
            Debug.Log(player.UserId);
        }
    }
}
