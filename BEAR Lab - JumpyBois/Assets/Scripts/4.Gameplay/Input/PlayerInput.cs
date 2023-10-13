//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/4.Gameplay/Input - To Fix/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""KeyboardInput_Universal"",
            ""id"": ""d6ebff3c-49e3-4a4d-b843-22a88f0a1d3a"",
            ""actions"": [
                {
                    ""name"": ""Skip"",
                    ""type"": ""Button"",
                    ""id"": ""ec6bd7ce-3318-4938-8024-9f2bb57ea6f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""9cb2e880-4d09-4455-8fde-6387bb499e13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f7e677cd-dd44-45f3-9931-6d2878eca174"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Delsys"",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4c5957a-eb80-4f5d-a41f-3f2e71b2a263"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Delsys"",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""KeyboardInput_Grasps"",
            ""id"": ""b7c4bc5f-0fe7-4a74-8b9b-e834a084c51b"",
            ""actions"": [
                {
                    ""name"": ""GraspInput_Key0"",
                    ""type"": ""Button"",
                    ""id"": ""dab76d12-5f76-471a-9d4b-ddd9fe8cf501"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GraspInput_Key1"",
                    ""type"": ""Button"",
                    ""id"": ""43ef2dc4-98b1-440d-a96f-f52ba46f0a23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GraspInput_Key2"",
                    ""type"": ""Button"",
                    ""id"": ""1b5e126e-7ccc-4077-9519-bc48bc60fc9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GraspInput_Key3"",
                    ""type"": ""Button"",
                    ""id"": ""8d4c6ce4-0f0d-4691-8727-94fb19416714"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GraspInput_Key4"",
                    ""type"": ""Button"",
                    ""id"": ""060bc61e-a4f5-4863-ab70-944301404be7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GraspInput_Key5"",
                    ""type"": ""Button"",
                    ""id"": ""bade6c75-938c-4a26-ace2-6b5563a4d0f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GraspInput_Key6"",
                    ""type"": ""Button"",
                    ""id"": ""9528b38d-6b38-4e21-bda6-5e68284bd7fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GraspInput_Key7"",
                    ""type"": ""Button"",
                    ""id"": ""deceeafc-4623-4d8f-819e-2cdb49c50234"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GraspInput_Key8"",
                    ""type"": ""Button"",
                    ""id"": ""38d65e05-0a9b-4d92-a525-e6b2733ebb97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GraspInput_Key9"",
                    ""type"": ""Button"",
                    ""id"": ""a00af69d-30c3-4455-a89d-ac365fee6a23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""32d615f8-7dad-40b3-82c4-0d387a2bf05a"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GraspInput_Key0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fb3c11a-87ad-47bc-b84e-0f77780f6b12"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GraspInput_Key1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35852ae0-a400-4936-a865-39a4ea414575"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GraspInput_Key2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6023f3f7-3349-4c3f-ba38-4fcd91062122"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GraspInput_Key3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a3e9953-5e47-4e40-87d0-212f5f7ab34c"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GraspInput_Key4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39e35619-7d67-40f5-8301-54423c540904"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GraspInput_Key5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7c53ed0-8c03-42cb-a562-a39ca4cb8fd3"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GraspInput_Key6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a84439d3-1507-4e07-b136-ab2e9901ab09"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GraspInput_Key7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c68cbda6-7f9e-42e9-9da8-fe242e72e059"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GraspInput_Key8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7982cbe3-c3d0-44c5-95ca-88b87a943fcc"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GraspInput_Key9"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Delsys"",
            ""bindingGroup"": ""Delsys"",
            ""devices"": [
                {
                    ""devicePath"": ""<HID>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // KeyboardInput_Universal
        m_KeyboardInput_Universal = asset.FindActionMap("KeyboardInput_Universal", throwIfNotFound: true);
        m_KeyboardInput_Universal_Skip = m_KeyboardInput_Universal.FindAction("Skip", throwIfNotFound: true);
        m_KeyboardInput_Universal_PauseGame = m_KeyboardInput_Universal.FindAction("PauseGame", throwIfNotFound: true);
        // KeyboardInput_Grasps
        m_KeyboardInput_Grasps = asset.FindActionMap("KeyboardInput_Grasps", throwIfNotFound: true);
        m_KeyboardInput_Grasps_GraspInput_Key0 = m_KeyboardInput_Grasps.FindAction("GraspInput_Key0", throwIfNotFound: true);
        m_KeyboardInput_Grasps_GraspInput_Key1 = m_KeyboardInput_Grasps.FindAction("GraspInput_Key1", throwIfNotFound: true);
        m_KeyboardInput_Grasps_GraspInput_Key2 = m_KeyboardInput_Grasps.FindAction("GraspInput_Key2", throwIfNotFound: true);
        m_KeyboardInput_Grasps_GraspInput_Key3 = m_KeyboardInput_Grasps.FindAction("GraspInput_Key3", throwIfNotFound: true);
        m_KeyboardInput_Grasps_GraspInput_Key4 = m_KeyboardInput_Grasps.FindAction("GraspInput_Key4", throwIfNotFound: true);
        m_KeyboardInput_Grasps_GraspInput_Key5 = m_KeyboardInput_Grasps.FindAction("GraspInput_Key5", throwIfNotFound: true);
        m_KeyboardInput_Grasps_GraspInput_Key6 = m_KeyboardInput_Grasps.FindAction("GraspInput_Key6", throwIfNotFound: true);
        m_KeyboardInput_Grasps_GraspInput_Key7 = m_KeyboardInput_Grasps.FindAction("GraspInput_Key7", throwIfNotFound: true);
        m_KeyboardInput_Grasps_GraspInput_Key8 = m_KeyboardInput_Grasps.FindAction("GraspInput_Key8", throwIfNotFound: true);
        m_KeyboardInput_Grasps_GraspInput_Key9 = m_KeyboardInput_Grasps.FindAction("GraspInput_Key9", throwIfNotFound: true);
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

    // KeyboardInput_Universal
    private readonly InputActionMap m_KeyboardInput_Universal;
    private IKeyboardInput_UniversalActions m_KeyboardInput_UniversalActionsCallbackInterface;
    private readonly InputAction m_KeyboardInput_Universal_Skip;
    private readonly InputAction m_KeyboardInput_Universal_PauseGame;
    public struct KeyboardInput_UniversalActions
    {
        private @PlayerInput m_Wrapper;
        public KeyboardInput_UniversalActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Skip => m_Wrapper.m_KeyboardInput_Universal_Skip;
        public InputAction @PauseGame => m_Wrapper.m_KeyboardInput_Universal_PauseGame;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardInput_Universal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardInput_UniversalActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardInput_UniversalActions instance)
        {
            if (m_Wrapper.m_KeyboardInput_UniversalActionsCallbackInterface != null)
            {
                @Skip.started -= m_Wrapper.m_KeyboardInput_UniversalActionsCallbackInterface.OnSkip;
                @Skip.performed -= m_Wrapper.m_KeyboardInput_UniversalActionsCallbackInterface.OnSkip;
                @Skip.canceled -= m_Wrapper.m_KeyboardInput_UniversalActionsCallbackInterface.OnSkip;
                @PauseGame.started -= m_Wrapper.m_KeyboardInput_UniversalActionsCallbackInterface.OnPauseGame;
                @PauseGame.performed -= m_Wrapper.m_KeyboardInput_UniversalActionsCallbackInterface.OnPauseGame;
                @PauseGame.canceled -= m_Wrapper.m_KeyboardInput_UniversalActionsCallbackInterface.OnPauseGame;
            }
            m_Wrapper.m_KeyboardInput_UniversalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Skip.started += instance.OnSkip;
                @Skip.performed += instance.OnSkip;
                @Skip.canceled += instance.OnSkip;
                @PauseGame.started += instance.OnPauseGame;
                @PauseGame.performed += instance.OnPauseGame;
                @PauseGame.canceled += instance.OnPauseGame;
            }
        }
    }
    public KeyboardInput_UniversalActions @KeyboardInput_Universal => new KeyboardInput_UniversalActions(this);

    // KeyboardInput_Grasps
    private readonly InputActionMap m_KeyboardInput_Grasps;
    private IKeyboardInput_GraspsActions m_KeyboardInput_GraspsActionsCallbackInterface;
    private readonly InputAction m_KeyboardInput_Grasps_GraspInput_Key0;
    private readonly InputAction m_KeyboardInput_Grasps_GraspInput_Key1;
    private readonly InputAction m_KeyboardInput_Grasps_GraspInput_Key2;
    private readonly InputAction m_KeyboardInput_Grasps_GraspInput_Key3;
    private readonly InputAction m_KeyboardInput_Grasps_GraspInput_Key4;
    private readonly InputAction m_KeyboardInput_Grasps_GraspInput_Key5;
    private readonly InputAction m_KeyboardInput_Grasps_GraspInput_Key6;
    private readonly InputAction m_KeyboardInput_Grasps_GraspInput_Key7;
    private readonly InputAction m_KeyboardInput_Grasps_GraspInput_Key8;
    private readonly InputAction m_KeyboardInput_Grasps_GraspInput_Key9;
    public struct KeyboardInput_GraspsActions
    {
        private @PlayerInput m_Wrapper;
        public KeyboardInput_GraspsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @GraspInput_Key0 => m_Wrapper.m_KeyboardInput_Grasps_GraspInput_Key0;
        public InputAction @GraspInput_Key1 => m_Wrapper.m_KeyboardInput_Grasps_GraspInput_Key1;
        public InputAction @GraspInput_Key2 => m_Wrapper.m_KeyboardInput_Grasps_GraspInput_Key2;
        public InputAction @GraspInput_Key3 => m_Wrapper.m_KeyboardInput_Grasps_GraspInput_Key3;
        public InputAction @GraspInput_Key4 => m_Wrapper.m_KeyboardInput_Grasps_GraspInput_Key4;
        public InputAction @GraspInput_Key5 => m_Wrapper.m_KeyboardInput_Grasps_GraspInput_Key5;
        public InputAction @GraspInput_Key6 => m_Wrapper.m_KeyboardInput_Grasps_GraspInput_Key6;
        public InputAction @GraspInput_Key7 => m_Wrapper.m_KeyboardInput_Grasps_GraspInput_Key7;
        public InputAction @GraspInput_Key8 => m_Wrapper.m_KeyboardInput_Grasps_GraspInput_Key8;
        public InputAction @GraspInput_Key9 => m_Wrapper.m_KeyboardInput_Grasps_GraspInput_Key9;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardInput_Grasps; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardInput_GraspsActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardInput_GraspsActions instance)
        {
            if (m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface != null)
            {
                @GraspInput_Key0.started -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key0;
                @GraspInput_Key0.performed -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key0;
                @GraspInput_Key0.canceled -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key0;
                @GraspInput_Key1.started -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key1;
                @GraspInput_Key1.performed -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key1;
                @GraspInput_Key1.canceled -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key1;
                @GraspInput_Key2.started -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key2;
                @GraspInput_Key2.performed -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key2;
                @GraspInput_Key2.canceled -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key2;
                @GraspInput_Key3.started -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key3;
                @GraspInput_Key3.performed -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key3;
                @GraspInput_Key3.canceled -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key3;
                @GraspInput_Key4.started -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key4;
                @GraspInput_Key4.performed -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key4;
                @GraspInput_Key4.canceled -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key4;
                @GraspInput_Key5.started -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key5;
                @GraspInput_Key5.performed -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key5;
                @GraspInput_Key5.canceled -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key5;
                @GraspInput_Key6.started -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key6;
                @GraspInput_Key6.performed -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key6;
                @GraspInput_Key6.canceled -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key6;
                @GraspInput_Key7.started -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key7;
                @GraspInput_Key7.performed -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key7;
                @GraspInput_Key7.canceled -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key7;
                @GraspInput_Key8.started -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key8;
                @GraspInput_Key8.performed -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key8;
                @GraspInput_Key8.canceled -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key8;
                @GraspInput_Key9.started -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key9;
                @GraspInput_Key9.performed -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key9;
                @GraspInput_Key9.canceled -= m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface.OnGraspInput_Key9;
            }
            m_Wrapper.m_KeyboardInput_GraspsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GraspInput_Key0.started += instance.OnGraspInput_Key0;
                @GraspInput_Key0.performed += instance.OnGraspInput_Key0;
                @GraspInput_Key0.canceled += instance.OnGraspInput_Key0;
                @GraspInput_Key1.started += instance.OnGraspInput_Key1;
                @GraspInput_Key1.performed += instance.OnGraspInput_Key1;
                @GraspInput_Key1.canceled += instance.OnGraspInput_Key1;
                @GraspInput_Key2.started += instance.OnGraspInput_Key2;
                @GraspInput_Key2.performed += instance.OnGraspInput_Key2;
                @GraspInput_Key2.canceled += instance.OnGraspInput_Key2;
                @GraspInput_Key3.started += instance.OnGraspInput_Key3;
                @GraspInput_Key3.performed += instance.OnGraspInput_Key3;
                @GraspInput_Key3.canceled += instance.OnGraspInput_Key3;
                @GraspInput_Key4.started += instance.OnGraspInput_Key4;
                @GraspInput_Key4.performed += instance.OnGraspInput_Key4;
                @GraspInput_Key4.canceled += instance.OnGraspInput_Key4;
                @GraspInput_Key5.started += instance.OnGraspInput_Key5;
                @GraspInput_Key5.performed += instance.OnGraspInput_Key5;
                @GraspInput_Key5.canceled += instance.OnGraspInput_Key5;
                @GraspInput_Key6.started += instance.OnGraspInput_Key6;
                @GraspInput_Key6.performed += instance.OnGraspInput_Key6;
                @GraspInput_Key6.canceled += instance.OnGraspInput_Key6;
                @GraspInput_Key7.started += instance.OnGraspInput_Key7;
                @GraspInput_Key7.performed += instance.OnGraspInput_Key7;
                @GraspInput_Key7.canceled += instance.OnGraspInput_Key7;
                @GraspInput_Key8.started += instance.OnGraspInput_Key8;
                @GraspInput_Key8.performed += instance.OnGraspInput_Key8;
                @GraspInput_Key8.canceled += instance.OnGraspInput_Key8;
                @GraspInput_Key9.started += instance.OnGraspInput_Key9;
                @GraspInput_Key9.performed += instance.OnGraspInput_Key9;
                @GraspInput_Key9.canceled += instance.OnGraspInput_Key9;
            }
        }
    }
    public KeyboardInput_GraspsActions @KeyboardInput_Grasps => new KeyboardInput_GraspsActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_DelsysSchemeIndex = -1;
    public InputControlScheme DelsysScheme
    {
        get
        {
            if (m_DelsysSchemeIndex == -1) m_DelsysSchemeIndex = asset.FindControlSchemeIndex("Delsys");
            return asset.controlSchemes[m_DelsysSchemeIndex];
        }
    }
    public interface IKeyboardInput_UniversalActions
    {
        void OnSkip(InputAction.CallbackContext context);
        void OnPauseGame(InputAction.CallbackContext context);
    }
    public interface IKeyboardInput_GraspsActions
    {
        void OnGraspInput_Key0(InputAction.CallbackContext context);
        void OnGraspInput_Key1(InputAction.CallbackContext context);
        void OnGraspInput_Key2(InputAction.CallbackContext context);
        void OnGraspInput_Key3(InputAction.CallbackContext context);
        void OnGraspInput_Key4(InputAction.CallbackContext context);
        void OnGraspInput_Key5(InputAction.CallbackContext context);
        void OnGraspInput_Key6(InputAction.CallbackContext context);
        void OnGraspInput_Key7(InputAction.CallbackContext context);
        void OnGraspInput_Key8(InputAction.CallbackContext context);
        void OnGraspInput_Key9(InputAction.CallbackContext context);
    }
}