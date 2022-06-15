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
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate Verticle"",
                    ""type"": ""Button"",
                    ""id"": ""7630f031-0316-4e05-aad9-2d7b6850233a"",
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
    public struct ObjectRotationActions
    {
        private @ObjectRotationInput m_Wrapper;
        public ObjectRotationActions(@ObjectRotationInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateHorizontal => m_Wrapper.m_ObjectRotation_RotateHorizontal;
        public InputAction @RotateVerticle => m_Wrapper.m_ObjectRotation_RotateVerticle;
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
            }
        }
    }
    public ObjectRotationActions @ObjectRotation => new ObjectRotationActions(this);
    public interface IObjectRotationActions
    {
        void OnRotateHorizontal(InputAction.CallbackContext context);
        void OnRotateVerticle(InputAction.CallbackContext context);
    }
}
