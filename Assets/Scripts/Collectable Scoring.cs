using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using WaterSystem;

public class CollectableScoring : MonoBehaviour
{
    public AK.Wwise.Event waterCollect;
    public AK.Wwise.Event dateCollect;
    public AK.Wwise.Event coinCollect;

    public GameObject mainCamera;

    public TMP_Text waterCount;
    public TMP_Text dateCount;
    public TMP_Text coinCount;

    public int waterInt;
    public int dateInt;
    public int coinInt;

    private void Update()
    {
        waterCount.text = waterInt.ToString();
        dateCount.text = dateInt.ToString();
        coinCount.text = coinInt.ToString();
    }

    public void AddToCount(String collectableType)
    {
        switch (collectableType)
        {
            case "Water":
                waterInt += 1;
                waterCollect.Post(mainCamera);
                break;
            case "Date":
                dateInt += 1;
                dateCollect.Post(mainCamera);
                break;
            case "Coin":
                coinInt += 1;
                coinCollect.Post(mainCamera);
                break;
        }
    }
    
}
