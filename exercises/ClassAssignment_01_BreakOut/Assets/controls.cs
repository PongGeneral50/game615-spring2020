// GENERATED AUTOMATICALLY FROM 'Assets/controls.inputactions'

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
    ""name"": ""controls"",
    ""maps"": [
        {
            ""name"": ""paddel"",
            ""id"": ""e9edc61c-deef-463f-a947-cef1c30df9d3"",
            ""actions"": [
                {
                    ""name"": ""paddel_controls"",
                    ""type"": ""Button"",
                    ""id"": ""a356774a-baa3-4a95-8147-9b160392af02"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4cd5f88f-6d7c-4861-861c-bef2bb59ff23"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""paddel_controls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdf469b1-9f0d-46a7-a123-0d112e678302"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""paddel_controls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // paddel
        m_paddel = asset.FindActionMap("paddel", throwIfNotFound: true);
        m_paddel_paddel_controls = m_paddel.FindAction("paddel_controls", throwIfNotFound: true);
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

    // paddel
    private readonly InputActionMap m_paddel;
    private IPaddelActions m_PaddelActionsCallbackInterface;
    private readonly InputAction m_paddel_paddel_controls;
    public struct PaddelActions
    {
        private @Controls m_Wrapper;
        public PaddelActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @paddel_controls => m_Wrapper.m_paddel_paddel_controls;
        public InputActionMap Get() { return m_Wrapper.m_paddel; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PaddelActions set) { return set.Get(); }
        public void SetCallbacks(IPaddelActions instance)
        {
            if (m_Wrapper.m_PaddelActionsCallbackInterface != null)
            {
                @paddel_controls.started -= m_Wrapper.m_PaddelActionsCallbackInterface.OnPaddel_controls;
                @paddel_controls.performed -= m_Wrapper.m_PaddelActionsCallbackInterface.OnPaddel_controls;
                @paddel_controls.canceled -= m_Wrapper.m_PaddelActionsCallbackInterface.OnPaddel_controls;
            }
            m_Wrapper.m_PaddelActionsCallbackInterface = instance;
            if (instance != null)
            {
                @paddel_controls.started += instance.OnPaddel_controls;
                @paddel_controls.performed += instance.OnPaddel_controls;
                @paddel_controls.canceled += instance.OnPaddel_controls;
            }
        }
    }
    public PaddelActions @paddel => new PaddelActions(this);
    public interface IPaddelActions
    {
        void OnPaddel_controls(InputAction.CallbackContext context);
    }
}
