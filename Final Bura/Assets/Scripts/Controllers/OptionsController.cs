using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public AudioMixer _mixer;
    private GameObject _musicObject;
    private GameObject _eFXObject;

    [SerializeField]
    private Slider _volumeSlider;
    [SerializeField]
    private Toggle _musicToggle;
    [SerializeField]
    private Toggle _efxSoundsToggle;

    private float _oldSoundVolume;
    private float _curSoundVolume;
    private bool _oldMusicOn;
    private bool _oldEfxSoundsOn;

    private AudioSource _musicSource;
    private AudioSource _efxSource;

    void Awake()
    {
        _musicObject = GameObject.Find("MusicSourceObject");
        _eFXObject = GameObject.Find("EFXSourceObject");

        Debug.Log(_musicObject);

        _mixer.GetFloat("soundVolume", out _oldSoundVolume);
        _musicSource = _musicObject.GetComponent<AudioSource>();
        _efxSource = _eFXObject.GetComponent<AudioSource>();

        _musicToggle.isOn = !_musicSource.mute;
        _efxSoundsToggle.isOn = !_efxSource.mute;
        _volumeSlider.value = _oldSoundVolume;
    }

    void OnEnable()
    {
        _oldMusicOn = !_musicSource.mute;
        _oldEfxSoundsOn = !_efxSource.mute;
    }

    public void SetVolume(float volume)
    {
        _curSoundVolume = volume;
        _mixer.SetFloat("soundVolume", Mathf.Log10(volume) * 20);
    }

    public void ToggleMusic(bool isOn)
    {        
        _musicSource.mute = !isOn;
    }

    public void ToggleSounds(bool isOn)
    {        
        _efxSource.mute = !isOn;
    }

    public void OnSaveClick()
    {
        _oldSoundVolume = _curSoundVolume;
        _oldMusicOn = !_musicSource.mute;
        _oldEfxSoundsOn = !_efxSource.mute;
    }

    public void Quit()
    {
        _musicSource.mute = !_oldMusicOn;
        _musicToggle.isOn = _oldMusicOn;        

        _efxSource.mute = !_oldEfxSoundsOn;
        _efxSoundsToggle.isOn = _oldEfxSoundsOn;

        _mixer.SetFloat("soundVolume", _oldSoundVolume);
        _volumeSlider.value = _oldSoundVolume;
    }
}
