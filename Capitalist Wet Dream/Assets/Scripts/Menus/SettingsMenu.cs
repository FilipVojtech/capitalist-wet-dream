using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    // Note: Preferences are saved in MainMenu.cs in OnBackPress

    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private TMP_Dropdown resolutionDropdown;
    [SerializeField] private Toggle fullscreenToggle;
    [SerializeField] private TMP_Dropdown qualityDropdown;
    [SerializeField] private Slider volumeSlider;

    private void Start()
    {
        // Set data from PlayerPrefs to UI
        fullscreenToggle.isOn = IntToBool(PlayerPrefs.GetInt("isFullscreen", 1));
        qualityDropdown.value = PlayerPrefs.GetInt("quality", 0);
        qualityDropdown.RefreshShownValue();
        volumeSlider.value = PlayerPrefs.GetFloat("volume", -20f);

        Screen.SetResolution(
            PlayerPrefs.GetInt("width", 800),
            PlayerPrefs.GetInt("height", 600),
            fullscreenToggle.isOn
        );
        resolutionDropdown.ClearOptions();
        var resolutions = Screen.resolutions;
        var currentResolutionIndex = 0;
        var resolutionOptions = new List<string>();

        for (var i = 0; i < resolutions.Length; i++)
        {
            resolutionOptions.Add($"{resolutions[i].height} x {resolutions[i].width}");

            if (resolutions[i].ToString() == Screen.currentResolution.ToString())
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(resolutionOptions);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void OnVolumeChange(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
    }

    public void OnFullscreenChange(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        PlayerPrefs.SetInt("isFullscreen", BoolToInt(fullscreenToggle.isOn));
    }

    public void OnQualityChange(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
        PlayerPrefs.SetInt("quality", qualityDropdown.value);
    }

    public void OnResolutionChange(int resolutionIndex)
    {
        var resolution = Screen.resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        PlayerPrefs.SetInt("width", resolution.width);
        PlayerPrefs.SetInt("height", resolution.height);
    }

    private static bool IntToBool(int integer)
    {
        return integer == 1;
    }

    private static int BoolToInt(bool boolean)
    {
        return boolean ? 1 : 0;
    }
}