﻿using UnityEngine;
using System.Collections;

public class SocialDialogManager : MonoBehaviour {
    private const string AppReviewUri = "ms-windows-store:REVIEW?PFN=Microsoft.Channel9_8wekyb3d8bbwe"; 
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnRateClicked ()
    {
        
        DismissDialog(); 
    }

    public void OnShareClicked ()
    {
        DismissDialog(); 
    }

    public void OnLaterClicked ()
    {
        DismissDialog(); 
    }

    void DismissDialog ()
    {
        this.gameObject.SetActive(false); 
        Complete.GameManager.Instance.BroadCast("SocialDialogDismissed"); 
    }


    /* 
    public void OnRateClicked()
    {
        //LAB_ANSWER_BEGIN  -- launch Windows store to rate our app. 
        UnityEngine.WSA.Launcher.LaunchUri(AppReviewUri, false);
        //LAB_ANSWER_END 
        DismissDialog();
    }*/ 
}
