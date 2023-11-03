using UnityEngine.Audio;
using UnityEngine;

//Allow other scripts to access this class
[System.Serializable]

public class Sound //Characteristics of SFX or Music
{
    //Name of SFX or Music
    public string name;

    //The Actual Sound bit
    public AudioClip clip;

    //The Mix it belongs to (Music,SFX, Ambieance)
    public AudioMixerGroup mix;

    //Volume w/ range
    [Range(0f,1f)]
    public float volume;

    //Pitch for Distortion
    [Range(.1f, 3f)]
    public float pitch;

    //Toggle if loop
    public bool loop;

    //Used for spawning on object
    [HideInInspector]
    public AudioSource source;

}
