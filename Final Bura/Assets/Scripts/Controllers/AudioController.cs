using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    [SerializeField]
    private AudioMixer _mixer;

    public AudioSource _audioSource;
    //public AudioSource _musicSource;
    //public static AudioController _instance = null;


    // Use this for initialization
    void Awake()
    {
        //if(_instance == null) //TODO: maybe delete this
        //{
        //    _instance = this;
        //} else if (_instance != this)
        //{
        //    Destroy(gameObject);
        //}
        DontDestroyOnLoad(gameObject);
    }

    public void PlayerSingle(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }

    public void SetVolume(float volume)
    {
        _mixer.SetFloat("soundVolume", Mathf.Log10(volume) * 20);
    }
}
