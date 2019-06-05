using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
    public static AudioClip playerhit;
    public static AudioClip playerdies;
    public static AudioClip playerscore;
    public static AudioClip playermovement;
    static AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        playerhit = Resources.Load<AudioClip>("sfx_hit");
        playerdies = Resources.Load<AudioClip>("sfx_die");
        playerscore = Resources.Load<AudioClip>("sfx_point");
        playermovement = Resources.Load<AudioClip>("sfx_wing");

        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    } 

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "sfx_hit":
                src.PlayOneShot(playerhit);
                break;

            case "sfx_die":
                src.PlayOneShot(playerdies);
                break;

            case "sfx_point":
                src.PlayOneShot(playerscore);
                break;

            case "sfx_wing":
                src.PlayOneShot(playermovement);
                break;
        }
    }
}
