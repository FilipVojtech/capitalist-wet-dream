using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private bool _isSettingsVisible;
    [SerializeField] private GameObject settings;

    private void Awake()
    {
        _isSettingsVisible = false;
    }

    private void Update()
    {
        settings.SetActive(_isSettingsVisible);
    }

    public void OnPlayPress()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnSettingsPress()
    {
        _isSettingsVisible = !_isSettingsVisible;
    }

    public void OnEndPress()
    {
        Application.Quit();
    }

    public void OnBackPress()
    {
        PlayerPrefs.Save();
        _isSettingsVisible = !_isSettingsVisible;
    }
}