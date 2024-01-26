using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SaveData : MonoBehaviour
{
    public static void SetUserID(string userID){
        PlayerPrefs.SetString("userid", userID);
    }
    public static void SetMememon(string mememon){
        PlayerPrefs.SetString("mememon", mememon);
    }

    public static void GetUserID(){
        PlayerPrefs.GetString("userid");
    }
    public static void GetMememon(){
        PlayerPrefs.GetString("mememon");
    }
}
