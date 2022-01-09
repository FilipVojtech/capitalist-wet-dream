using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUIController : MonoBehaviour
{
    private Controls _controls;

    private bool _isPauseMenuOpen;
    [SerializeField] private GameObject pauseMenu;

    private bool _isSettingsOpen;
    [SerializeField] private GameObject settingsMenu;

    private void Awake()
    {
        _controls = new Controls();

        _controls.GroundMovement.Cancel.performed += _ =>
        {
            if (_isSettingsOpen) OnBackPress();
            else if (!_isSettingsOpen && _isPauseMenuOpen) OnContinuePress();
            else OpenPauseMenu();
        };
    }

    private void Start()
    {
        _isPauseMenuOpen = true;
        _isSettingsOpen = false;
    }

    private void Update()
    {
        _isSettingsOpen = _isPauseMenuOpen && _isSettingsOpen;
        pauseMenu.SetActive(_isPauseMenuOpen);
        settingsMenu.SetActive(_isSettingsOpen);
    }

    private void OpenPauseMenu()
    {
        _isPauseMenuOpen = true;
    }

    public void OnContinuePress()
    {
        _isPauseMenuOpen = false;
    }

    public void OnSettingsPress()
    {
        _isSettingsOpen = true;
    }

    public void OnBackPress()
    {
        PlayerPrefs.Save();
        _isSettingsOpen = false;
    }

    public void OnExitPress()
    {
        SceneManager.LoadScene("Main menu");
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }
}