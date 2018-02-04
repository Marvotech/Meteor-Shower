//using UnityEngine;
//using UnityEngine.Advertisements;
//using System.Collections;

//public class Playad : MonoBehaviour
//{

//    public void Showad()
//    {
//        if (Advertisement.IsReady())
//        {
//            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleAdResult });
//        }

//    }

//    public void HandleAdResult(ShowResult result)
//    {

//        switch (result)
//        {
//            case ShowResult.Finished:
//                Debug.Log("Player gains");
//                break;
//            case ShowResult.Skipped:
//                Debug.Log("Player did not fully watch");
//                break;
//            case ShowResult.Failed:
//                Debug.Log("Player failed to launch");
//                break;

//        }
//    }
//}
