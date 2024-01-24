using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;


public class CreateorJoin : MonoBehaviourPunCallbacks
{
    [SerializeField]
    TMP_InputField create;
    [SerializeField]
    TMP_InputField join;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void CreateRoom(){
        PhotonNetwork.CreateRoom(create.text, new RoomOptions { MaxPlayers = 2 }, null);
    }

    public void JoinRoom(){
        StartCoroutine(SceneChangeCR());
    }

    IEnumerator SceneChangeCR(){
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene("SelectionRoom");
    }

}
