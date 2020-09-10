// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""2be6e110-4aa5-4e0d-8180-dd699033b601"",
            ""actions"": [
                {
                    ""name"": ""Jump Left"",
                    ""type"": ""Button"",
                    ""id"": ""e9590d56-f0fc-4fc0-9adc-1555afdc6544"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump Right"",
                    ""type"": ""Button"",
                    ""id"": ""2af56de3-53f1-44e6-831f-5e45c915910a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump Up"",
                    ""type"": ""Button"",
                    ""id"": ""5511fba9-65b1-4d5f-9d33-af8d893b9553"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f455dd33-1252-47ab-a340-019d8b8795f5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0009fb51-7c89-4a16-8b5a-1dfa7faa3958"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5db70ff5-b97c-4572-9768-a5d7b080ca5a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7177d0ef-206f-495a-9b87-753a76d79f0b"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6de29cb-e611-4bdc-ae4e-bd9808ba6e96"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""444e0de3-2e15-488e-937d-5c4b03c2b28a"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""cff92e81-8c84-4c4a-8822-b3d7f69f934b"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""5a8202a3-d207-4426-8266-412a00a156b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""149bdc87-4cec-44f0-9751-5dab79e87b94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""2afd113e-320c-4449-8d88-1f763141af07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""6e3dea50-2bba-4478-8b46-e2f294c3404f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4fd107ae-864a-44e6-a0ca-b878b5a3a880"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17f745f0-535c-4ba8-a42e-3a4cc01f5217"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5e159ed-8484-468e-adb1-69a126e33523"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee5e4889-4053-461e-81e5-f8acf0acfd95"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_JumpLeft = m_Player.FindAction("Jump Left", throwIfNotFound: true);
        m_Player_JumpRight = m_Player.FindAction("Jump Right", throwIfNotFound: true);
        m_Player_JumpUp = m_Player.FindAction("Jump Up", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_A = m_Menu.FindAction("A", throwIfNotFound: true);
        m_Menu_B = m_Menu.FindAction("B", throwIfNotFound: true);
        m_Menu_X = m_Menu.FindAction("X", throwIfNotFound: true);
        m_Menu_Y = m_Menu.FindAction("Y", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_JumpLeft;
    private readonly InputAction m_Player_JumpRight;
    private readonly InputAction m_Player_JumpUp;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @JumpLeft => m_Wrapper.m_Player_JumpLeft;
        public InputAction @JumpRight => m_Wrapper.m_Player_JumpRight;
        public InputAction @JumpUp => m_Wrapper.m_Player_JumpUp;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @JumpLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpLeft;
                @JumpLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpLeft;
                @JumpLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpLeft;
                @JumpRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpRight;
                @JumpRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpRight;
                @JumpRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpRight;
                @JumpUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpUp;
                @JumpUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpUp;
                @JumpUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpUp;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @JumpLeft.started += instance.OnJumpLeft;
                @JumpLeft.performed += instance.OnJumpLeft;
                @JumpLeft.canceled += instance.OnJumpLeft;
                @JumpRight.started += instance.OnJumpRight;
                @JumpRight.performed += instance.OnJumpRight;
                @JumpRight.canceled += instance.OnJumpRight;
                @JumpUp.started += instance.OnJumpUp;
                @JumpUp.performed += instance.OnJumpUp;
                @JumpUp.canceled += instance.OnJumpUp;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_A;
    private readonly InputAction m_Menu_B;
    private readonly InputAction m_Menu_X;
    private readonly InputAction m_Menu_Y;
    public struct MenuActions
    {
        private @Controls m_Wrapper;
        public MenuActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_Menu_A;
        public InputAction @B => m_Wrapper.m_Menu_B;
        public InputAction @X => m_Wrapper.m_Menu_X;
        public InputAction @Y => m_Wrapper.m_Menu_Y;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnB;
                @X.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnY;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IPlayerActions
    {
        void OnJumpLeft(InputAction.CallbackContext context);
        void OnJumpRight(InputAction.CallbackContext context);
        void OnJumpUp(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
    }
}
