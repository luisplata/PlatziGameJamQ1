using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("Music Tracks")]
    public AudioClip levelMusic1;
    //public AudioClip levelMusic2;
    //public AudioClip levelMusic3;
    [Header("Sounds 3d")]
    public AudioClip[] sounds3D = new AudioClip[3];
   

    [Header("- - - - - - - - - - MC Sounds - - - - - - - - - -")]
    public List<AudioClip> steps;
    public List<AudioClip> mcGrunts;
    public List<AudioClip> playerDeath;


    [Header("- - - - - - - - - - Audiosources - - - - - - - - - - ")]
    public AudioSource musicAudiosource1;
    public AudioSource musicAudiosource2;
    public AudioSource musicAudiosource3;
    [Header("AudioSources3d")]
    public AudioSource sounds3dAudiosource1;
    public AudioSource sounds3dAudiosource2;
    public AudioSource sounds3dAudiosource3;


    public AudioMixerGroup levelMusicOutput;
    public AudioMixerGroup ambient3DOutput;
    public AudioMixerGroup playerSounds;

    public AudioMixerSnapshot levelMusicSnapshot;
    public AudioMixerSnapshot ambient3DSnapshot;

    public AudioMixer audioMixer;

    [Header("- - - - - - - - - - Volume - - - - - - - - - - - ")]
    [Range(0.2f, 1f)]
    public float musicVolume = 0.3f;
  
    public static AudioManager instance;

 
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        MusicChangerLevels();
    }

    public void MusicChangerLevels()
    {

        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            levelMusicSnapshot.TransitionTo(0);
            PlayMusic();
            Debug.Log("Playing Music");
        }
    }

    void PlayMusic(AudioSource audioSource, AudioClip audioClip)
    {
        audioSource.playOnAwake = true;
        audioSource.loop = true;
        audioSource.volume = musicVolume;
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    public void MusicChangerLevels(string scene)
    {
        if (musicAudiosource1.isPlaying)
        {
            musicAudiosource1.Stop();
        }
  
        switch (scene)
        {
            case "Level0":
               // musicAudiosource.clip = lvl1Mx;
                break;
            case "Die":
               // musicAudiosource.clip = deathMx[Random.Range(0, deathMx.Count)];
                musicAudiosource1.loop = false;
                break;
            case "BossFight":
                //musicAudiosource.clip = bossLvl1Mx[Random.Range(0, bossLvl1Mx.Count)];
                break;
        }
        musicAudiosource1.Play();
    }

    public void PlaySound(string audioClip)
    {
        /*
        switch (audioClip)
        {
           
        }
        */
    }

    public void PlayShortSounds(AudioClip audioClip, float volume, float pitch)
    {
        try
        {
            AudioSource aS = gameObject.AddComponent<AudioSource>() as AudioSource;
            aS.pitch = pitch;
            aS.outputAudioMixerGroup = playerSounds;
            aS.PlayOneShot(audioClip, volume);
            Destroy(aS, audioClip.length);
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    public void PlayMusic()
    {
        PlayMusic(musicAudiosource1, levelMusic1);
        //PlayMusic(musicAudiosource2, levelMusic2);
        //PlayMusic(musicAudiosource3, levelMusic3);
    }

    public void TransitionTo2DAudio()
    {
        levelMusicSnapshot.TransitionTo(2f);

        if (musicAudiosource1.isPlaying && musicAudiosource2.isPlaying)
        {
            return;
        }
        else
        {
            PlayMusic();
        }
        
        Debug.Log("2DAudio");
    }
    public void TransitionTo3DAudio()
    {
        ambient3DSnapshot.TransitionTo(2f);
    }
}

