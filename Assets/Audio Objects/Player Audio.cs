using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public GameObject player;
    //Add AKGameObject To Player Object

    public AK.Wwise.Event playerGrunt;
    public void PlayGrunt() {
        playerGrunt.Post(player);
    }

    public AK.Wwise.Event playerFootsteps;
    public void PlayFootStep() {
        playerFootsteps.Post(player);
    }

    public AK.Wwise.Event pickupWater;
    public void PlayCollectWater() {
        pickupWater.Post(player);
    }   

//Add Different Pickup types.
    // public AK.Wwise.Event pickupWater;
    // public void PlayCollectWater() {
    //     pickupWater.Post(player);
    // }   
    // public AK.Wwise.Event pickupWater;
    // public void PlayCollectWater() {
    //     pickupWater.Post(player);
    // }   
}
