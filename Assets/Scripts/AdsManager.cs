﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour {

    string gameID;
    public bool testEnabled;
    void Start()
    {

#if UNITY_IOS
        gameID = "1248266";
#elif UNITY_ANDROID
        gameID = "1248057";
#else
        gameID = "1248057";
#endif

		DontDestroyOnLoad(transform.gameObject);
		Advertisement.Initialize(gameID, testEnabled);
	}

	public static void ShowAdvertisement()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();

        }
    }
}
