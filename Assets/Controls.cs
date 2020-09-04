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
                    ""path"": ""<Keyboard>/space"",
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
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_JumpLeft = m_Player.FindAction("Jump Left", throwIfNotFound: true);
        m_Player_JumpRight = m_Player.FindAction("Jump Right", throwIfNotFound: true);
        m_Player_JumpUp = m_Player.FindAction("Jump Up", throwIfNotFound: true);
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
    public interface IPlayerActions
    {
        void OnJumpLeft(InputAction.CallbackContext context);
        void OnJumpRight(InputAction.CallbackContext context);
        void OnJumpUp(InputAction.CallbackContext context);
    }
}
