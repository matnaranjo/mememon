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

    public override void OnCreatedRoom()
    {
        SceneManager.LoadScene("SelectionRoom");
    }

    public override void OnJoinedRoom()
    {
        StartCoroutine(SceneChangeCR());
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        // notAvailableRoom.SetActive(true);
        Debug.Log(message);
    }




    public void CreateRoom(){
        PhotonNetwork.CreateRoom(create.text, new RoomOptions { MaxPlayers = 10, PublishUserId = true }, null);
    }

    public void JoinRoom(){
        PhotonNetwork.JoinRoom(join.text);
    }

    IEnumerator SceneChangeCR(){
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene("SelectionRoom");
    }

}
