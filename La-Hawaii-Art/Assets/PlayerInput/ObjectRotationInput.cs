// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput/ObjectRotationInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ObjectRotationInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ObjectRotationInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ObjectRotationInput"",
    ""maps"": [
        {
            ""name"": ""Object Rotation"",
            ""id"": ""d7c9d519-7a74-43e3-9af4-d04f25df6385"",
            ""actions"": [
                {
                    ""name"": ""Rotate Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""4a2331fb-4d74-42c7-bed2-fe3159aaa9ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Rotate Verticle"",
                    ""type"": ""Button"",
                    ""id"": ""7630f031-0316-4e05-aad9-2d7b6850233a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""24426b17-a3e1-4d53-829e-d60ddb1a42d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""7cc01eea-009e-44e9-be4a-fa8c260b24cf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""d229e0f4-8f90-45d0-b3a7-e51a50260e6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Journal Pages Controls Left"",
                    ""type"": ""Button"",
                    ""id"": ""3aa56136-677c-4a15-9f61-016a510f7005"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Journal Pages Controls Right"",
                    ""type"": ""Button"",
                    ""id"": ""7eae110c-1c40-47dc-b3e8-750dad0a8299"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0b4ea907-ab93-433b-a9ec-aef0747c5ca9"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e47acaa9-ea89-4d7c-9f6d-7b6a2245ec0d"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate Verticle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""389dac70-3596-4898-b583-faf1228d68f0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""be9e8c21-d11a-4c84-bde9-43f8b8a88c9a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f656183c-4caa-45f1-891d-1c376d8e3b38"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""947cdba1-709d-43da-a59d-e36015d44a3b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f343788f-cf0b-418a-9f9b-cb74a7d429d8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""357ebc88-e516-418a-b23b-e4e8e96cb169"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fd7ecdb-aaea-40b5-b661-ec4aa5efcec5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15d1cfb1-8736-4403-9768-80631c35a1be"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Journal Pages Controls Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef55d2f9-ce8c-4a88-999e-c0f1b7c8ca8e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Journal Pages Controls Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Object Rotation
        m_ObjectRotation = asset.FindActionMap("Object Rotation", throwIfNotFound: true);
        m_ObjectRotation_RotateHorizontal = m_ObjectRotation.FindAction("Rotate Horizontal", throwIfNotFound: true);
        m_ObjectRotation_RotateVerticle = m_ObjectRotation.FindAction("Rotate Verticle", throwIfNotFound: true);
        m_ObjectRotation_Movement = m_ObjectRotation.FindAction("Movement", throwIfNotFound: true);
        m_ObjectRotation_Look = m_ObjectRotation.FindAction("Look", throwIfNotFound: true);
        m_ObjectRotation_Select = m_ObjectRotation.FindAction("Select", throwIfNotFound: true);
        m_ObjectRotation_JournalPagesControlsLeft = m_ObjectRotation.FindAction("Journal Pages Controls Left", throwIfNotFound: true);
        m_ObjectRotation_JournalPagesControlsRight = m_ObjectRotation.FindAction("Journal Pages Controls Right", throwIfNotFound: true);
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

    // Object Rotation
    private readonly InputActionMap m_ObjectRotation;
    private IObjectRotationActions m_ObjectRotationActionsCallbackInterface;
    private readonly InputAction m_ObjectRotation_RotateHorizontal;
    private readonly InputAction m_ObjectRotation_RotateVerticle;
    private readonly InputAction m_ObjectRotation_Movement;
    private readonly InputAction m_ObjectRotation_Look;
    private readonly InputAction m_ObjectRotation_Select;
    private readonly InputAction m_ObjectRotation_JournalPagesControlsLeft;
    private readonly InputAction m_ObjectRotation_JournalPagesControlsRight;
    public struct ObjectRotationActions
    {
        private @ObjectRotationInput m_Wrapper;
        public ObjectRotationActions(@ObjectRotationInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateHorizontal => m_Wrapper.m_ObjectRotation_RotateHorizontal;
        public InputAction @RotateVerticle => m_Wrapper.m_ObjectRotation_RotateVerticle;
        public InputAction @Movement => m_Wrapper.m_ObjectRotation_Movement;
        public InputAction @Look => m_Wrapper.m_ObjectRotation_Look;
        public InputAction @Select => m_Wrapper.m_ObjectRotation_Select;
        public InputAction @JournalPagesControlsLeft => m_Wrapper.m_ObjectRotation_JournalPagesControlsLeft;
        public InputAction @JournalPagesControlsRight => m_Wrapper.m_ObjectRotation_JournalPagesControlsRight;
        public InputActionMap Get() { return m_Wrapper.m_ObjectRotation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ObjectRotationActions set) { return set.Get(); }
        public void SetCallbacks(IObjectRotationActions instance)
        {
            if (m_Wrapper.m_ObjectRotationActionsCallbackInterface != null)
            {
                @RotateHorizontal.started -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnRotateHorizontal;
                @RotateHorizontal.performed -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnRotateHorizontal;
                @RotateHorizontal.canceled -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnRotateHorizontal;
                @RotateVerticle.started -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnRotateVerticle;
                @RotateVerticle.performed -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnRotateVerticle;
                @RotateVerticle.canceled -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnRotateVerticle;
                @Movement.started -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnLook;
                @Select.started -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnSelect;
                @JournalPagesControlsLeft.started -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnJournalPagesControlsLeft;
                @JournalPagesControlsLeft.performed -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnJournalPagesControlsLeft;
                @JournalPagesControlsLeft.canceled -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnJournalPagesControlsLeft;
                @JournalPagesControlsRight.started -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnJournalPagesControlsRight;
                @JournalPagesControlsRight.performed -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnJournalPagesControlsRight;
                @JournalPagesControlsRight.canceled -= m_Wrapper.m_ObjectRotationActionsCallbackInterface.OnJournalPagesControlsRight;
            }
            m_Wrapper.m_ObjectRotationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateHorizontal.started += instance.OnRotateHorizontal;
                @RotateHorizontal.performed += instance.OnRotateHorizontal;
                @RotateHorizontal.canceled += instance.OnRotateHorizontal;
                @RotateVerticle.started += instance.OnRotateVerticle;
                @RotateVerticle.performed += instance.OnRotateVerticle;
                @RotateVerticle.canceled += instance.OnRotateVerticle;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @JournalPagesControlsLeft.started += instance.OnJournalPagesControlsLeft;
                @JournalPagesControlsLeft.performed += instance.OnJournalPagesControlsLeft;
                @JournalPagesControlsLeft.canceled += instance.OnJournalPagesControlsLeft;
                @JournalPagesControlsRight.started += instance.OnJournalPagesControlsRight;
                @JournalPagesControlsRight.performed += instance.OnJournalPagesControlsRight;
                @JournalPagesControlsRight.canceled += instance.OnJournalPagesControlsRight;
            }
        }
    }
    public ObjectRotationActions @ObjectRotation => new ObjectRotationActions(this);
    public interface IObjectRotationActions
    {
        void OnRotateHorizontal(InputAction.CallbackContext context);
        void OnRotateVerticle(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnJournalPagesControlsLeft(InputAction.CallbackContext context);
        void OnJournalPagesControlsRight(InputAction.CallbackContext context);
    }
}
