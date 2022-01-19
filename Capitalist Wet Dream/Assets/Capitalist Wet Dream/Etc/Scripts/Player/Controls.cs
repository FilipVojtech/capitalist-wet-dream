//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Capitalist Wet Dream/Etc/Scripts/Player/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Ground"",
            ""id"": ""45fd3f16-66a2-43bc-97d1-120b9ae92972"",
            ""actions"": [
                {
                    ""name"": ""Horizontal movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2ae46e3d-0e6a-497e-aa87-5e09ba94947a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""83da58c8-ad8e-41e0-ab0d-e18aa3d7c82c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b72cc9ee-2475-455a-b64d-999b8de12347"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""21c65b82-f857-4cdb-82d7-3174c17f9db1"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d970ea87-a6b4-42c8-a08c-a5e4fcd90527"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""c2fcab8e-9ea7-47c7-b2bb-11d9a6deac63"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InteractMain"",
                    ""type"": ""Button"",
                    ""id"": ""81d37f55-bce1-4616-bd2d-03ab635443ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseTool"",
                    ""type"": ""Button"",
                    ""id"": ""959be44e-d797-4eb6-af4e-12913f835829"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a3b96d2b-3ac5-4360-8d53-caf143d53a85"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d9e7c65f-5d9e-4eea-9dcd-aeb1d41fc47b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Horizontal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fb7b0958-e230-44de-b359-f55f419e4262"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Horizontal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""189e52bd-7962-4712-b72e-7e599d06862f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Horizontal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""29242b6b-6dc6-4df5-a108-ac0db3330a9b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Horizontal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8b079150-3c04-485f-8554-23d53787b1ee"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5f78659-1aca-4488-891e-ace13f560993"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eea2682e-c903-4a00-828a-b2b7830c60be"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6391a3f5-f92d-46f9-b2e6-32c46343ab35"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e67cd0a2-6acd-4832-90ba-dbc8607b37c7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bbaa861-b126-499d-bd30-9fb3417a65fb"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""InteractMain"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03069496-4e23-4faf-8153-a1202650621d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""UseTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""6caf926b-604b-43d5-8899-e975ffc4836c"",
            ""actions"": [],
            ""bindings"": []
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard Mouse"",
            ""bindingGroup"": ""Keyboard Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Ground
        m_Ground = asset.FindActionMap("Ground", throwIfNotFound: true);
        m_Ground_Horizontalmovement = m_Ground.FindAction("Horizontal movement", throwIfNotFound: true);
        m_Ground_Jump = m_Ground.FindAction("Jump", throwIfNotFound: true);
        m_Ground_MouseX = m_Ground.FindAction("MouseX", throwIfNotFound: true);
        m_Ground_MouseY = m_Ground.FindAction("MouseY", throwIfNotFound: true);
        m_Ground_Run = m_Ground.FindAction("Run", throwIfNotFound: true);
        m_Ground_Cancel = m_Ground.FindAction("Cancel", throwIfNotFound: true);
        m_Ground_InteractMain = m_Ground.FindAction("InteractMain", throwIfNotFound: true);
        m_Ground_UseTool = m_Ground.FindAction("UseTool", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Ground
    private readonly InputActionMap m_Ground;
    private IGroundActions m_GroundActionsCallbackInterface;
    private readonly InputAction m_Ground_Horizontalmovement;
    private readonly InputAction m_Ground_Jump;
    private readonly InputAction m_Ground_MouseX;
    private readonly InputAction m_Ground_MouseY;
    private readonly InputAction m_Ground_Run;
    private readonly InputAction m_Ground_Cancel;
    private readonly InputAction m_Ground_InteractMain;
    private readonly InputAction m_Ground_UseTool;
    public struct GroundActions
    {
        private @Controls m_Wrapper;
        public GroundActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontalmovement => m_Wrapper.m_Ground_Horizontalmovement;
        public InputAction @Jump => m_Wrapper.m_Ground_Jump;
        public InputAction @MouseX => m_Wrapper.m_Ground_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Ground_MouseY;
        public InputAction @Run => m_Wrapper.m_Ground_Run;
        public InputAction @Cancel => m_Wrapper.m_Ground_Cancel;
        public InputAction @InteractMain => m_Wrapper.m_Ground_InteractMain;
        public InputAction @UseTool => m_Wrapper.m_Ground_UseTool;
        public InputActionMap Get() { return m_Wrapper.m_Ground; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundActions set) { return set.Get(); }
        public void SetCallbacks(IGroundActions instance)
        {
            if (m_Wrapper.m_GroundActionsCallbackInterface != null)
            {
                @Horizontalmovement.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnHorizontalmovement;
                @Horizontalmovement.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnHorizontalmovement;
                @Horizontalmovement.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnHorizontalmovement;
                @Jump.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnJump;
                @MouseX.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnMouseY;
                @Run.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnRun;
                @Cancel.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnCancel;
                @InteractMain.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnInteractMain;
                @InteractMain.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnInteractMain;
                @InteractMain.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnInteractMain;
                @UseTool.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnUseTool;
                @UseTool.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnUseTool;
                @UseTool.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnUseTool;
            }
            m_Wrapper.m_GroundActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontalmovement.started += instance.OnHorizontalmovement;
                @Horizontalmovement.performed += instance.OnHorizontalmovement;
                @Horizontalmovement.canceled += instance.OnHorizontalmovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @InteractMain.started += instance.OnInteractMain;
                @InteractMain.performed += instance.OnInteractMain;
                @InteractMain.canceled += instance.OnInteractMain;
                @UseTool.started += instance.OnUseTool;
                @UseTool.performed += instance.OnUseTool;
                @UseTool.canceled += instance.OnUseTool;
            }
        }
    }
    public GroundActions @Ground => new GroundActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    public struct MenuActions
    {
        private @Controls m_Wrapper;
        public MenuActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IGroundActions
    {
        void OnHorizontalmovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnInteractMain(InputAction.CallbackContext context);
        void OnUseTool(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
    }
}
