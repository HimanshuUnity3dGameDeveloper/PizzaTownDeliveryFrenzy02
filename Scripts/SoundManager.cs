using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public static SoundManager sMInstance;
    public AudioSource[] allSongs;
    public int currentIndex = 0;
    BeatsPerMin bd;


    private void Awake()
    {
        if (sMInstance != null && sMInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            sMInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    
    public void PlaySong01()
    {
        allSongs[currentIndex].Play();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();

    }

    public void PlayRapture()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Play();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }

    public void PlaySummerLilac()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Play();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }
    
    public void Atascado_Timothy_Infinite()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Play();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }

    public void Atmosfera_Bonsaye()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Play();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }

    public void Calentar_Timothy_Infinite()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Play();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }

    public void Calling_Lenzer()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Play();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }

    public void DoIt_El_Neon()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Play();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }

    public void Extasis_El_Neon()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Play();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }

    public void FarAway_Slushii()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Play();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }

    public void Findersfree_MartinKlem()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Play();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }

    public void Idontneedyou_Slushii()   
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Play();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }

    public void Iknowwecould_Killrude()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Play();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }

    public void Imcrazyforlove_CraigReever()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Play();
        allSongs[currentIndex + 14].Stop();
    }

    public void Leaving_Harvio()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Play();
    }

    public void StopAll()
    {
        allSongs[currentIndex].Stop();
        allSongs[currentIndex + 1].Stop();
        allSongs[currentIndex + 2].Stop();
        allSongs[currentIndex + 3].Stop();
        allSongs[currentIndex + 4].Stop();
        allSongs[currentIndex + 5].Stop();
        allSongs[currentIndex + 6].Stop();
        allSongs[currentIndex + 7].Stop();
        allSongs[currentIndex + 8].Stop();
        allSongs[currentIndex + 9].Stop();
        allSongs[currentIndex + 10].Stop();
        allSongs[currentIndex + 11].Stop();
        allSongs[currentIndex + 12].Stop();
        allSongs[currentIndex + 13].Stop();
        allSongs[currentIndex + 14].Stop();
    }
}
