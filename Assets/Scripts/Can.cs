using UnityEngine;

public class Can : MonoBehaviour
{
    GameObject player;
    SanitySystem sanitySystem;
    float sanity;
    public float restorationAmount = 0.5f;
    private void Start()
    {
        player = GameObject.Find("Player FPS"); //Find Player Object
        sanitySystem = player.GetComponent<SanitySystem>(); //Find Script on Player
    }
   
    public void OnMouseDown() //When object is clicked on
    {
        sanity = sanitySystem.sanity; //Grab Sanity float from sanitySystem
        if (sanity < 1) //if Sanity float is less than 1
        {
            restoreSanity(restorationAmount);
            Destroy(gameObject); //Destroy Object
        }
    }
    void restoreSanity(float x) //Restores sanity at X value
    {
        sanity += x; //add X to float
        sanity = Mathf.Clamp(sanity, 0, 1); //Clamp float to not go past 1
        sanitySystem.sanity = sanity; //send float to sanitySystem
    }
}
