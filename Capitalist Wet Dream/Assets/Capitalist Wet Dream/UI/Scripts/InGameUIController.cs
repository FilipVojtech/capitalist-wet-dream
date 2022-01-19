using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InGameUIController : MonoBehaviour
{
    private Controls _controls;

    private bool _isPauseMenuOpen;
    [SerializeField] private GameObject pauseMenu;

    private bool _isSettingsOpen;
    [SerializeField] private GameObject settingsMenu;

    private static string _actionDescription = "";
    [SerializeField] private TMP_Text actionDescription;

    [SerializeField] private InputActionReference interactAction;
    public static string interactionBind;

    private void Awake()
    {
        _controls = new Controls();

        _controls.Ground.Cancel.performed += _ =>
        {
            if (_isSettingsOpen) OnBackPress();
            else if (!_isSettingsOpen && _isPauseMenuOpen) OnContinuePress();
            else OpenPauseMenu();
        };
    }

    private void Start()
    {
        var bindIndex = interactAction.action.GetBindingIndexForControl(interactAction.action.controls[0]);
        
        _isPauseMenuOpen = true;
        _isSettingsOpen = false;
        interactionBind = InputControlPath.ToHumanReadableString(
            interactAction.action.bindings[bindIndex].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice
        );
    }

    private void Update()
    {
        _isSettingsOpen = _isPauseMenuOpen && _isSettingsOpen;
        pauseMenu.SetActive(_isPauseMenuOpen);
        settingsMenu.SetActive(_isSettingsOpen);
        Cursor.lockState = _isPauseMenuOpen ? CursorLockMode.None : CursorLockMode.Locked;
        actionDescription.text = _actionDescription;
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

    public static void SetActionDescription(string description)
    {
        _actionDescription = description;
    }
}