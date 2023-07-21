using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingUI : MonoBehaviour
{
    public Slider sfxSlider;
    public Slider musicSlider;
    public TMP_Dropdown graphicDropdown;
    public TMP_Dropdown languageDropdown;
    public Setting settingData;

    private void Start()
    {
        LoadSettingData();
    }

    private void LoadSettingData()
    {
        sfxSlider.value = settingData.sfxVolume;
        musicSlider.value = settingData.MusicVolume;
        graphicDropdown.value = settingData.GraphicIndex;
        languageDropdown.value = settingData.LanguageIndex;
    }

    public void OnSfxVolumeChanged(float value) => settingData.sfxVolume = value;
    public void OnMusicVolumeChanged(float value) => settingData.MusicVolume = value;
    public void OnGraphicIndexChanged(int index) => settingData.GraphicIndex = index;
    public void OnLanguageIndexChanged(int index) => settingData.LanguageIndex = index;
    public void SaveSettingData()
    {
        settingData.sfxVolume = sfxSlider.value;
        settingData.MusicVolume = musicSlider.value;
        settingData.GraphicIndex = graphicDropdown.value;
        settingData.LanguageIndex = languageDropdown.value;
    }

    private void OnApplicationQuit()
    {
        SaveSettingData();
    }

}
