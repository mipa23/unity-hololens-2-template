// GENERATED AUTOMATICALLY FROM 'Assets/Samples/XR Interaction Toolkit/1.0.0-pre.5/Default Input Actions/XRI Default Input Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @XRIDefaultInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @XRIDefaultInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""XRI Default Input Actions"",
    ""maps"": [
        {
            ""name"": ""XRI HMD"",
            ""id"": ""09ff3ccc-21b4-4346-a3a2-7c978b5af892"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""1a9029f8-7a46-46b9-9eff-e9ae8365f611"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""aed87fe6-2b01-4dd2-a8fa-195578fd8158"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cff1f981-6e1f-4e2c-a90c-715a0ea2e80e"",
                    ""path"": ""<XRHMD>/centerEyePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2017383-a3f6-4c46-acb1-012b8eece9cc"",
                    ""path"": ""<XRHMD>/centerEyeRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""XRI LeftHand"",
            ""id"": ""5fe596f9-1b7b-49b7-80a7-3b5195caf74d"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""83a7af0b-87e3-42c3-a909-95fbf8091e4f"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""cb6b7130-2bac-4ef7-abe4-6991ae7d419d"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""33754c03-48ec-46ef-9bc6-22ed6bfdd8e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Activate"",
                    ""type"": ""Button"",
                    ""id"": ""0c0991c5-d329-4afc-8892-1076b440477c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UI Press"",
                    ""type"": ""Button"",
                    ""id"": ""7e1eced7-c774-4fe5-be8f-d8711f646d9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Haptic Device"",
                    ""type"": ""PassThrough"",
                    ""id"": ""664a62b0-e178-421d-b3f8-014eec01591d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Select"",
                    ""type"": ""Button"",
                    ""id"": ""cbeaf823-3b69-4004-8ec8-13ea2ca3fc31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Mode Activate"",
                    ""type"": ""Button"",
                    ""id"": ""a21db72c-4843-4839-b4d0-3ce8d287cb86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Mode Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""89ce8348-6001-41a3-85b9-f8f2e2dcad7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""9164e093-ebd4-4923-af32-1b52f31c2d66"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9693e25f-8a4f-4aed-842f-3961243c69a1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate Anchor"",
                    ""type"": ""Value"",
                    ""id"": ""21b75b25-12ad-410f-b4f8-a7745b7aca27"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Translate Anchor"",
                    ""type"": ""Value"",
                    ""id"": ""bfa204c7-3c92-4193-bad1-39eb71920042"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b34c79c1-ab5e-4851-87ac-abc43705eae0"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""UI Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Quaternion Fallback"",
                    ""id"": ""61466a56-4ee4-47b1-aa6a-4806de1de5f2"",
                    ""path"": ""QuaternionFallback"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""first"",
                    ""id"": ""afdcfbff-e241-4fdd-a6d1-23b0bf273360"",
                    ""path"": ""<XRController>{LeftHand}/pointerRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""second"",
                    ""id"": ""ed03d944-4c09-4c38-8b68-5c844e18ca7c"",
                    ""path"": ""<XRController>{LeftHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""third"",
                    ""id"": ""c98fc8c8-7fc6-4909-89b6-c5b7568e7275"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8da6ed3a-f621-49fe-8c76-1f6b7d7754d6"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=1)"",
                    ""processors"": """",
                    ""groups"": ""Noncontinuous Move"",
                    ""action"": ""Teleport Mode Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8edee81-6779-4aa8-89cd-29b149a8f55e"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Mode Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8aebee7-fa03-43d4-bfb7-77a3f87452cc"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Mode Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95fa1419-ca7b-4c8a-8d15-7d46e58d82e3"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=-1,sweepBehavior=3)"",
                    ""processors"": """",
                    ""groups"": ""Noncontinuous Move"",
                    ""action"": ""Teleport Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14a27f53-867e-4d15-92d9-3e36deb55b1b"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Vector 3 Fallback"",
                    ""id"": ""14aeff85-d719-43ff-a124-b1cd7ca8686d"",
                    ""path"": ""Vector3Fallback"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""first"",
                    ""id"": ""abf752ec-feee-4d51-b530-f0870f48acc9"",
                    ""path"": ""<XRController>{LeftHand}/pointerPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""second"",
                    ""id"": ""6580b669-0651-401c-9779-85ef22689130"",
                    ""path"": ""<XRController>{LeftHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""third"",
                    ""id"": ""ae101942-9eaa-4c53-a388-cafc3fd89bdf"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""71a4d23f-3e9a-4513-923b-ba388c5e84bf"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""487f4f2e-9e9b-49aa-b0f2-4037a24624f5"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99cb7ad1-51ec-4611-af68-92a85f2c17d6"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=12,sweepBehavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Noncontinuous Move"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""034c3ced-8f2c-44ce-892e-678ca433265b"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=2,sweepBehavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Noncontinuous Move"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e383b1a-270f-4c20-819b-89a59cffb498"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Continuous Move"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acdf9550-5529-4ff7-8558-73ecdf0d75bd"",
                    ""path"": ""<XRController>{LeftHand}/*"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Haptic Device"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""de8136fd-5b07-4794-bb96-63c6027cf1b6"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""529c0dda-d254-4a71-8aa8-7dbdeabbe45d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dad37c56-3fcd-4890-98bf-e06f80ba76ff"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e0dd3431-14bb-4817-ac71-ed700d5af1ca"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis/x"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-1),Invert"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0064f189-a00e-4cf8-9f53-be76a30cb97f"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis/x"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""44d142b3-f6ac-4d08-8bd1-fac53cf9bb9e"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b1dbcb6a-408c-413c-b2d1-7a10fe418324"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis/y"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0e38a62a-8bee-4853-b87a-1af460e3ec33"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis/y"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-1),Invert"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2f25805f-44a3-4716-983c-532473bcc03c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d97ccaa1-79ae-4ca7-b7dd-be5ce92c94a6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""XRI RightHand"",
            ""id"": ""7960f8ef-2bf3-4281-aecc-4c03809d6c8c"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""c4990d70-7b8a-4ce1-b03c-da86716b8352"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""ee6bf5bf-bb0a-4a50-8327-cb654b19e298"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""ac96c10b-c955-4a46-8e67-bf16bc069b53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Activate"",
                    ""type"": ""Button"",
                    ""id"": ""41976d89-60de-4deb-bff9-16b4af96b290"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UI Press"",
                    ""type"": ""PassThrough"",
                    ""id"": ""65174b45-c2ee-4f90-93bb-fb4084eaaab3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Place POI"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1b505da0-0c5f-4792-8c16-b068d6650495"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Place Waypoint"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5c35be48-af1f-4903-ae35-feeed4c3b6e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Place Teleport"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d0e7e0c8-ddfc-4541-81b2-4f5f876dfc2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Haptic Device"",
                    ""type"": ""PassThrough"",
                    ""id"": ""57b2a1b4-3290-46d6-ac07-4854ee8f91b1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Select"",
                    ""type"": ""Button"",
                    ""id"": ""02e43582-8973-4940-af06-dff6158e3df2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Mode Activate"",
                    ""type"": ""Button"",
                    ""id"": ""a6c7231d-c55d-4dd4-9e87-877bb5522ef5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Mode Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""d587b60c-39a0-4365-8075-477ce484ba0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""9fb2eb2b-2fb6-4328-8167-10a1bf11b424"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Forward POI"",
                    ""type"": ""Value"",
                    ""id"": ""00a4dc9f-1ee6-4349-b0e9-72d5dccaadd6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Sector(directions=1)""
                },
                {
                    ""name"": ""Move Forward Waypoint"",
                    ""type"": ""Value"",
                    ""id"": ""7972a581-40a6-47c3-97ee-0ea64c90107b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Sector(directions=1)""
                },
                {
                    ""name"": ""Move Forward Teleport"",
                    ""type"": ""Value"",
                    ""id"": ""f70c1af2-1fb0-41e2-9a99-2c3465c5b4ce"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Sector(directions=1)""
                },
                {
                    ""name"": ""Rotate Anchor"",
                    ""type"": ""Value"",
                    ""id"": ""9b5d8312-f609-4895-b70f-81a722b2ae11"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Translate Anchor"",
                    ""type"": ""Value"",
                    ""id"": ""6f7cf253-7062-443b-b10f-2be48a33f027"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Backward POI"",
                    ""type"": ""Value"",
                    ""id"": ""1c32398d-8193-4bfb-a93d-2f34fd9158ca"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Backward Waypoint"",
                    ""type"": ""Value"",
                    ""id"": ""bfdb09f6-f075-485a-bd8f-db49f613d36b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Backward Teleport"",
                    ""type"": ""Value"",
                    ""id"": ""adb969fb-9eb4-4212-a6c8-626bf059b3d4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Switch Control Mode"",
                    ""type"": ""PassThrough"",
                    ""id"": ""960f042f-77cd-4d35-8ff4-cebec2398953"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fa59aed1-ae0b-4074-a58c-294b85f46228"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Quaternion Fallback"",
                    ""id"": ""84e51e1c-1b95-4f3e-a61f-29da6c1f0816"",
                    ""path"": ""QuaternionFallback"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""first"",
                    ""id"": ""3722d501-eb80-4f61-9361-08a5ea7a1394"",
                    ""path"": ""<XRController>{RightHand}/pointerRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""second"",
                    ""id"": ""2e6ad191-d5aa-4919-aac6-295c83387a72"",
                    ""path"": ""<XRController>{RightHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""third"",
                    ""id"": ""b9ecb60d-341e-47cf-b50a-41d5815af8b0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""62690862-4688-4010-975b-b3d9c6062157"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=1)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Mode Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90efd65e-3290-4798-af15-21ab4d7848b5"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Mode Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de466e6e-12bf-46a1-b0fd-ffbc343f3399"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Mode Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Vector 3 Fallback"",
                    ""id"": ""74e968f1-ad08-4a82-a68d-764517faecef"",
                    ""path"": ""Vector3Fallback"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""first"",
                    ""id"": ""9717e367-64a4-440a-9974-1e641d753eb2"",
                    ""path"": ""<XRController>{RightHand}/pointerPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""second"",
                    ""id"": ""0794a41d-29ef-48ec-a452-6b7de29b52fa"",
                    ""path"": ""<XRController>{RightHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""third"",
                    ""id"": ""3ef0a781-60c5-48bc-a584-f95553f8ae0a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c4c594c6-9e9e-470a-8598-d9ebb1aa0385"",
                    ""path"": ""<HPMixedRealityController>{RightHand}/triggerPressed"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""UI Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6c08c3d-3d41-4695-994d-1ac9016a5a9e"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=12,sweepBehavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70f78baa-0f00-4d32-a2b6-ea9e2090ecc2"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=2,sweepBehavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6011e1e6-b2dd-4cb1-8da5-29b03868f2c5"",
                    ""path"": ""<XRController>{RightHand}/*"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Haptic Device"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""61502e80-1b21-4116-890c-c0bc31c9dffd"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2b466c01-134f-40f2-b376-f7e9684e423b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""79757cb3-5b81-4a3d-bc3c-d2582f85d5db"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""76425f70-54b8-4f8e-ad52-94debc75962c"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis/x"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-1),Invert"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8df952de-cf29-4b5e-9a90-a6b4eee7f52c"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis/x"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a4b1434f-f204-49c4-bcea-c25e321e93eb"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4ced8328-f738-4bbd-937a-c09019acd234"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis/y"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f7e89e7c-f5a9-4f42-914f-945815a49033"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis/y"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-1),Invert"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""df3b3e57-34c6-4200-b00e-6617123a9680"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""54ddc99c-3e9a-4c3a-9fdd-f5fb15952af4"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""df135a56-df33-443a-b789-d583062b4645"",
                    ""path"": ""<HPMixedRealityController>{RightHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Move Forward POI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2b65031-60d5-4a1f-b51f-cefe4e365873"",
                    ""path"": ""<HPMixedRealityController>/thumbstick"",
                    ""interactions"": ""Sector(directions=2)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Move Backward POI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""017952e3-ede3-45b3-b121-c7bb3a156980"",
                    ""path"": ""<HPMixedRealityController>{RightHand}/gripPressed"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Switch Control Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d9d2775-0d56-49ba-b523-461f44255626"",
                    ""path"": ""<HPMixedRealityController>{RightHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Move Forward Waypoint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13aec498-10f8-4794-9e1f-afbf1b058529"",
                    ""path"": ""<HPMixedRealityController>{RightHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Move Forward Teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf40d709-d88d-4071-b682-1ead6ce2819d"",
                    ""path"": ""<HPMixedRealityController>/thumbstick"",
                    ""interactions"": ""Sector(directions=2)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Move Backward Waypoint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f36588b3-981f-4c02-8669-dc062aabcf83"",
                    ""path"": ""<HPMixedRealityController>/thumbstick"",
                    ""interactions"": ""Sector(directions=2)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Move Backward Teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49a05ddc-121b-405c-83f1-d2a2e12a3080"",
                    ""path"": ""<HPMixedRealityController>{RightHand}/triggerPressed"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Place POI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb2e585b-9b7b-425f-a4de-ffc1c85aeec9"",
                    ""path"": ""<HPMixedRealityController>{RightHand}/triggerPressed"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Place Waypoint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e35f7ceb-218d-477e-897b-8d1247cb0e33"",
                    ""path"": ""<HPMixedRealityController>{RightHand}/triggerPressed"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Place Teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4ff11ef-823e-4c2a-a987-8ef11cf9e3d6"",
                    ""path"": ""<HPMixedRealityController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Generic XR Controller"",
            ""bindingGroup"": ""Generic XR Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<WMRHMD>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Continuous Move"",
            ""bindingGroup"": ""Continuous Move"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Noncontinuous Move"",
            ""bindingGroup"": ""Noncontinuous Move"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // XRI HMD
        m_XRIHMD = asset.FindActionMap("XRI HMD", throwIfNotFound: true);
        m_XRIHMD_Position = m_XRIHMD.FindAction("Position", throwIfNotFound: true);
        m_XRIHMD_Rotation = m_XRIHMD.FindAction("Rotation", throwIfNotFound: true);
        // XRI LeftHand
        m_XRILeftHand = asset.FindActionMap("XRI LeftHand", throwIfNotFound: true);
        m_XRILeftHand_Position = m_XRILeftHand.FindAction("Position", throwIfNotFound: true);
        m_XRILeftHand_Rotation = m_XRILeftHand.FindAction("Rotation", throwIfNotFound: true);
        m_XRILeftHand_Select = m_XRILeftHand.FindAction("Select", throwIfNotFound: true);
        m_XRILeftHand_Activate = m_XRILeftHand.FindAction("Activate", throwIfNotFound: true);
        m_XRILeftHand_UIPress = m_XRILeftHand.FindAction("UI Press", throwIfNotFound: true);
        m_XRILeftHand_HapticDevice = m_XRILeftHand.FindAction("Haptic Device", throwIfNotFound: true);
        m_XRILeftHand_TeleportSelect = m_XRILeftHand.FindAction("Teleport Select", throwIfNotFound: true);
        m_XRILeftHand_TeleportModeActivate = m_XRILeftHand.FindAction("Teleport Mode Activate", throwIfNotFound: true);
        m_XRILeftHand_TeleportModeCancel = m_XRILeftHand.FindAction("Teleport Mode Cancel", throwIfNotFound: true);
        m_XRILeftHand_Turn = m_XRILeftHand.FindAction("Turn", throwIfNotFound: true);
        m_XRILeftHand_Move = m_XRILeftHand.FindAction("Move", throwIfNotFound: true);
        m_XRILeftHand_RotateAnchor = m_XRILeftHand.FindAction("Rotate Anchor", throwIfNotFound: true);
        m_XRILeftHand_TranslateAnchor = m_XRILeftHand.FindAction("Translate Anchor", throwIfNotFound: true);
        // XRI RightHand
        m_XRIRightHand = asset.FindActionMap("XRI RightHand", throwIfNotFound: true);
        m_XRIRightHand_Position = m_XRIRightHand.FindAction("Position", throwIfNotFound: true);
        m_XRIRightHand_Rotation = m_XRIRightHand.FindAction("Rotation", throwIfNotFound: true);
        m_XRIRightHand_Select = m_XRIRightHand.FindAction("Select", throwIfNotFound: true);
        m_XRIRightHand_Activate = m_XRIRightHand.FindAction("Activate", throwIfNotFound: true);
        m_XRIRightHand_UIPress = m_XRIRightHand.FindAction("UI Press", throwIfNotFound: true);
        m_XRIRightHand_PlacePOI = m_XRIRightHand.FindAction("Place POI", throwIfNotFound: true);
        m_XRIRightHand_PlaceWaypoint = m_XRIRightHand.FindAction("Place Waypoint", throwIfNotFound: true);
        m_XRIRightHand_PlaceTeleport = m_XRIRightHand.FindAction("Place Teleport", throwIfNotFound: true);
        m_XRIRightHand_HapticDevice = m_XRIRightHand.FindAction("Haptic Device", throwIfNotFound: true);
        m_XRIRightHand_TeleportSelect = m_XRIRightHand.FindAction("Teleport Select", throwIfNotFound: true);
        m_XRIRightHand_TeleportModeActivate = m_XRIRightHand.FindAction("Teleport Mode Activate", throwIfNotFound: true);
        m_XRIRightHand_TeleportModeCancel = m_XRIRightHand.FindAction("Teleport Mode Cancel", throwIfNotFound: true);
        m_XRIRightHand_Turn = m_XRIRightHand.FindAction("Turn", throwIfNotFound: true);
        m_XRIRightHand_MoveForwardPOI = m_XRIRightHand.FindAction("Move Forward POI", throwIfNotFound: true);
        m_XRIRightHand_MoveForwardWaypoint = m_XRIRightHand.FindAction("Move Forward Waypoint", throwIfNotFound: true);
        m_XRIRightHand_MoveForwardTeleport = m_XRIRightHand.FindAction("Move Forward Teleport", throwIfNotFound: true);
        m_XRIRightHand_RotateAnchor = m_XRIRightHand.FindAction("Rotate Anchor", throwIfNotFound: true);
        m_XRIRightHand_TranslateAnchor = m_XRIRightHand.FindAction("Translate Anchor", throwIfNotFound: true);
        m_XRIRightHand_MoveBackwardPOI = m_XRIRightHand.FindAction("Move Backward POI", throwIfNotFound: true);
        m_XRIRightHand_MoveBackwardWaypoint = m_XRIRightHand.FindAction("Move Backward Waypoint", throwIfNotFound: true);
        m_XRIRightHand_MoveBackwardTeleport = m_XRIRightHand.FindAction("Move Backward Teleport", throwIfNotFound: true);
        m_XRIRightHand_SwitchControlMode = m_XRIRightHand.FindAction("Switch Control Mode", throwIfNotFound: true);
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

    // XRI HMD
    private readonly InputActionMap m_XRIHMD;
    private IXRIHMDActions m_XRIHMDActionsCallbackInterface;
    private readonly InputAction m_XRIHMD_Position;
    private readonly InputAction m_XRIHMD_Rotation;
    public struct XRIHMDActions
    {
        private @XRIDefaultInputActions m_Wrapper;
        public XRIHMDActions(@XRIDefaultInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_XRIHMD_Position;
        public InputAction @Rotation => m_Wrapper.m_XRIHMD_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_XRIHMD; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRIHMDActions set) { return set.Get(); }
        public void SetCallbacks(IXRIHMDActions instance)
        {
            if (m_Wrapper.m_XRIHMDActionsCallbackInterface != null)
            {
                @Position.started -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnPosition;
                @Rotation.started -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnRotation;
            }
            m_Wrapper.m_XRIHMDActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
            }
        }
    }
    public XRIHMDActions @XRIHMD => new XRIHMDActions(this);

    // XRI LeftHand
    private readonly InputActionMap m_XRILeftHand;
    private IXRILeftHandActions m_XRILeftHandActionsCallbackInterface;
    private readonly InputAction m_XRILeftHand_Position;
    private readonly InputAction m_XRILeftHand_Rotation;
    private readonly InputAction m_XRILeftHand_Select;
    private readonly InputAction m_XRILeftHand_Activate;
    private readonly InputAction m_XRILeftHand_UIPress;
    private readonly InputAction m_XRILeftHand_HapticDevice;
    private readonly InputAction m_XRILeftHand_TeleportSelect;
    private readonly InputAction m_XRILeftHand_TeleportModeActivate;
    private readonly InputAction m_XRILeftHand_TeleportModeCancel;
    private readonly InputAction m_XRILeftHand_Turn;
    private readonly InputAction m_XRILeftHand_Move;
    private readonly InputAction m_XRILeftHand_RotateAnchor;
    private readonly InputAction m_XRILeftHand_TranslateAnchor;
    public struct XRILeftHandActions
    {
        private @XRIDefaultInputActions m_Wrapper;
        public XRILeftHandActions(@XRIDefaultInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_XRILeftHand_Position;
        public InputAction @Rotation => m_Wrapper.m_XRILeftHand_Rotation;
        public InputAction @Select => m_Wrapper.m_XRILeftHand_Select;
        public InputAction @Activate => m_Wrapper.m_XRILeftHand_Activate;
        public InputAction @UIPress => m_Wrapper.m_XRILeftHand_UIPress;
        public InputAction @HapticDevice => m_Wrapper.m_XRILeftHand_HapticDevice;
        public InputAction @TeleportSelect => m_Wrapper.m_XRILeftHand_TeleportSelect;
        public InputAction @TeleportModeActivate => m_Wrapper.m_XRILeftHand_TeleportModeActivate;
        public InputAction @TeleportModeCancel => m_Wrapper.m_XRILeftHand_TeleportModeCancel;
        public InputAction @Turn => m_Wrapper.m_XRILeftHand_Turn;
        public InputAction @Move => m_Wrapper.m_XRILeftHand_Move;
        public InputAction @RotateAnchor => m_Wrapper.m_XRILeftHand_RotateAnchor;
        public InputAction @TranslateAnchor => m_Wrapper.m_XRILeftHand_TranslateAnchor;
        public InputActionMap Get() { return m_Wrapper.m_XRILeftHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRILeftHandActions set) { return set.Get(); }
        public void SetCallbacks(IXRILeftHandActions instance)
        {
            if (m_Wrapper.m_XRILeftHandActionsCallbackInterface != null)
            {
                @Position.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnPosition;
                @Rotation.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotation;
                @Select.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnSelect;
                @Activate.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnActivate;
                @Activate.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnActivate;
                @Activate.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnActivate;
                @UIPress.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnUIPress;
                @UIPress.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnUIPress;
                @UIPress.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnUIPress;
                @HapticDevice.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnHapticDevice;
                @HapticDevice.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnHapticDevice;
                @HapticDevice.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnHapticDevice;
                @TeleportSelect.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportSelect;
                @TeleportSelect.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportSelect;
                @TeleportSelect.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportSelect;
                @TeleportModeActivate.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeActivate;
                @TeleportModeActivate.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeActivate;
                @TeleportModeActivate.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeActivate;
                @TeleportModeCancel.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeCancel;
                @TeleportModeCancel.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeCancel;
                @TeleportModeCancel.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeCancel;
                @Turn.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTurn;
                @Move.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnMove;
                @RotateAnchor.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotateAnchor;
                @RotateAnchor.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotateAnchor;
                @RotateAnchor.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotateAnchor;
                @TranslateAnchor.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTranslateAnchor;
                @TranslateAnchor.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTranslateAnchor;
                @TranslateAnchor.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTranslateAnchor;
            }
            m_Wrapper.m_XRILeftHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Activate.started += instance.OnActivate;
                @Activate.performed += instance.OnActivate;
                @Activate.canceled += instance.OnActivate;
                @UIPress.started += instance.OnUIPress;
                @UIPress.performed += instance.OnUIPress;
                @UIPress.canceled += instance.OnUIPress;
                @HapticDevice.started += instance.OnHapticDevice;
                @HapticDevice.performed += instance.OnHapticDevice;
                @HapticDevice.canceled += instance.OnHapticDevice;
                @TeleportSelect.started += instance.OnTeleportSelect;
                @TeleportSelect.performed += instance.OnTeleportSelect;
                @TeleportSelect.canceled += instance.OnTeleportSelect;
                @TeleportModeActivate.started += instance.OnTeleportModeActivate;
                @TeleportModeActivate.performed += instance.OnTeleportModeActivate;
                @TeleportModeActivate.canceled += instance.OnTeleportModeActivate;
                @TeleportModeCancel.started += instance.OnTeleportModeCancel;
                @TeleportModeCancel.performed += instance.OnTeleportModeCancel;
                @TeleportModeCancel.canceled += instance.OnTeleportModeCancel;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RotateAnchor.started += instance.OnRotateAnchor;
                @RotateAnchor.performed += instance.OnRotateAnchor;
                @RotateAnchor.canceled += instance.OnRotateAnchor;
                @TranslateAnchor.started += instance.OnTranslateAnchor;
                @TranslateAnchor.performed += instance.OnTranslateAnchor;
                @TranslateAnchor.canceled += instance.OnTranslateAnchor;
            }
        }
    }
    public XRILeftHandActions @XRILeftHand => new XRILeftHandActions(this);

    // XRI RightHand
    private readonly InputActionMap m_XRIRightHand;
    private IXRIRightHandActions m_XRIRightHandActionsCallbackInterface;
    private readonly InputAction m_XRIRightHand_Position;
    private readonly InputAction m_XRIRightHand_Rotation;
    private readonly InputAction m_XRIRightHand_Select;
    private readonly InputAction m_XRIRightHand_Activate;
    private readonly InputAction m_XRIRightHand_UIPress;
    private readonly InputAction m_XRIRightHand_PlacePOI;
    private readonly InputAction m_XRIRightHand_PlaceWaypoint;
    private readonly InputAction m_XRIRightHand_PlaceTeleport;
    private readonly InputAction m_XRIRightHand_HapticDevice;
    private readonly InputAction m_XRIRightHand_TeleportSelect;
    private readonly InputAction m_XRIRightHand_TeleportModeActivate;
    private readonly InputAction m_XRIRightHand_TeleportModeCancel;
    private readonly InputAction m_XRIRightHand_Turn;
    private readonly InputAction m_XRIRightHand_MoveForwardPOI;
    private readonly InputAction m_XRIRightHand_MoveForwardWaypoint;
    private readonly InputAction m_XRIRightHand_MoveForwardTeleport;
    private readonly InputAction m_XRIRightHand_RotateAnchor;
    private readonly InputAction m_XRIRightHand_TranslateAnchor;
    private readonly InputAction m_XRIRightHand_MoveBackwardPOI;
    private readonly InputAction m_XRIRightHand_MoveBackwardWaypoint;
    private readonly InputAction m_XRIRightHand_MoveBackwardTeleport;
    private readonly InputAction m_XRIRightHand_SwitchControlMode;
    public struct XRIRightHandActions
    {
        private @XRIDefaultInputActions m_Wrapper;
        public XRIRightHandActions(@XRIDefaultInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_XRIRightHand_Position;
        public InputAction @Rotation => m_Wrapper.m_XRIRightHand_Rotation;
        public InputAction @Select => m_Wrapper.m_XRIRightHand_Select;
        public InputAction @Activate => m_Wrapper.m_XRIRightHand_Activate;
        public InputAction @UIPress => m_Wrapper.m_XRIRightHand_UIPress;
        public InputAction @PlacePOI => m_Wrapper.m_XRIRightHand_PlacePOI;
        public InputAction @PlaceWaypoint => m_Wrapper.m_XRIRightHand_PlaceWaypoint;
        public InputAction @PlaceTeleport => m_Wrapper.m_XRIRightHand_PlaceTeleport;
        public InputAction @HapticDevice => m_Wrapper.m_XRIRightHand_HapticDevice;
        public InputAction @TeleportSelect => m_Wrapper.m_XRIRightHand_TeleportSelect;
        public InputAction @TeleportModeActivate => m_Wrapper.m_XRIRightHand_TeleportModeActivate;
        public InputAction @TeleportModeCancel => m_Wrapper.m_XRIRightHand_TeleportModeCancel;
        public InputAction @Turn => m_Wrapper.m_XRIRightHand_Turn;
        public InputAction @MoveForwardPOI => m_Wrapper.m_XRIRightHand_MoveForwardPOI;
        public InputAction @MoveForwardWaypoint => m_Wrapper.m_XRIRightHand_MoveForwardWaypoint;
        public InputAction @MoveForwardTeleport => m_Wrapper.m_XRIRightHand_MoveForwardTeleport;
        public InputAction @RotateAnchor => m_Wrapper.m_XRIRightHand_RotateAnchor;
        public InputAction @TranslateAnchor => m_Wrapper.m_XRIRightHand_TranslateAnchor;
        public InputAction @MoveBackwardPOI => m_Wrapper.m_XRIRightHand_MoveBackwardPOI;
        public InputAction @MoveBackwardWaypoint => m_Wrapper.m_XRIRightHand_MoveBackwardWaypoint;
        public InputAction @MoveBackwardTeleport => m_Wrapper.m_XRIRightHand_MoveBackwardTeleport;
        public InputAction @SwitchControlMode => m_Wrapper.m_XRIRightHand_SwitchControlMode;
        public InputActionMap Get() { return m_Wrapper.m_XRIRightHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRIRightHandActions set) { return set.Get(); }
        public void SetCallbacks(IXRIRightHandActions instance)
        {
            if (m_Wrapper.m_XRIRightHandActionsCallbackInterface != null)
            {
                @Position.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPosition;
                @Rotation.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotation;
                @Select.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSelect;
                @Activate.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnActivate;
                @Activate.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnActivate;
                @Activate.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnActivate;
                @UIPress.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnUIPress;
                @UIPress.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnUIPress;
                @UIPress.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnUIPress;
                @PlacePOI.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPlacePOI;
                @PlacePOI.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPlacePOI;
                @PlacePOI.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPlacePOI;
                @PlaceWaypoint.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPlaceWaypoint;
                @PlaceWaypoint.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPlaceWaypoint;
                @PlaceWaypoint.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPlaceWaypoint;
                @PlaceTeleport.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPlaceTeleport;
                @PlaceTeleport.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPlaceTeleport;
                @PlaceTeleport.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPlaceTeleport;
                @HapticDevice.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnHapticDevice;
                @HapticDevice.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnHapticDevice;
                @HapticDevice.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnHapticDevice;
                @TeleportSelect.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportSelect;
                @TeleportSelect.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportSelect;
                @TeleportSelect.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportSelect;
                @TeleportModeActivate.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeActivate;
                @TeleportModeActivate.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeActivate;
                @TeleportModeActivate.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeActivate;
                @TeleportModeCancel.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeCancel;
                @TeleportModeCancel.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeCancel;
                @TeleportModeCancel.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeCancel;
                @Turn.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTurn;
                @MoveForwardPOI.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveForwardPOI;
                @MoveForwardPOI.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveForwardPOI;
                @MoveForwardPOI.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveForwardPOI;
                @MoveForwardWaypoint.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveForwardWaypoint;
                @MoveForwardWaypoint.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveForwardWaypoint;
                @MoveForwardWaypoint.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveForwardWaypoint;
                @MoveForwardTeleport.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveForwardTeleport;
                @MoveForwardTeleport.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveForwardTeleport;
                @MoveForwardTeleport.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveForwardTeleport;
                @RotateAnchor.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotateAnchor;
                @RotateAnchor.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotateAnchor;
                @RotateAnchor.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotateAnchor;
                @TranslateAnchor.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTranslateAnchor;
                @TranslateAnchor.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTranslateAnchor;
                @TranslateAnchor.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTranslateAnchor;
                @MoveBackwardPOI.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveBackwardPOI;
                @MoveBackwardPOI.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveBackwardPOI;
                @MoveBackwardPOI.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveBackwardPOI;
                @MoveBackwardWaypoint.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveBackwardWaypoint;
                @MoveBackwardWaypoint.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveBackwardWaypoint;
                @MoveBackwardWaypoint.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveBackwardWaypoint;
                @MoveBackwardTeleport.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveBackwardTeleport;
                @MoveBackwardTeleport.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveBackwardTeleport;
                @MoveBackwardTeleport.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMoveBackwardTeleport;
                @SwitchControlMode.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSwitchControlMode;
                @SwitchControlMode.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSwitchControlMode;
                @SwitchControlMode.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSwitchControlMode;
            }
            m_Wrapper.m_XRIRightHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Activate.started += instance.OnActivate;
                @Activate.performed += instance.OnActivate;
                @Activate.canceled += instance.OnActivate;
                @UIPress.started += instance.OnUIPress;
                @UIPress.performed += instance.OnUIPress;
                @UIPress.canceled += instance.OnUIPress;
                @PlacePOI.started += instance.OnPlacePOI;
                @PlacePOI.performed += instance.OnPlacePOI;
                @PlacePOI.canceled += instance.OnPlacePOI;
                @PlaceWaypoint.started += instance.OnPlaceWaypoint;
                @PlaceWaypoint.performed += instance.OnPlaceWaypoint;
                @PlaceWaypoint.canceled += instance.OnPlaceWaypoint;
                @PlaceTeleport.started += instance.OnPlaceTeleport;
                @PlaceTeleport.performed += instance.OnPlaceTeleport;
                @PlaceTeleport.canceled += instance.OnPlaceTeleport;
                @HapticDevice.started += instance.OnHapticDevice;
                @HapticDevice.performed += instance.OnHapticDevice;
                @HapticDevice.canceled += instance.OnHapticDevice;
                @TeleportSelect.started += instance.OnTeleportSelect;
                @TeleportSelect.performed += instance.OnTeleportSelect;
                @TeleportSelect.canceled += instance.OnTeleportSelect;
                @TeleportModeActivate.started += instance.OnTeleportModeActivate;
                @TeleportModeActivate.performed += instance.OnTeleportModeActivate;
                @TeleportModeActivate.canceled += instance.OnTeleportModeActivate;
                @TeleportModeCancel.started += instance.OnTeleportModeCancel;
                @TeleportModeCancel.performed += instance.OnTeleportModeCancel;
                @TeleportModeCancel.canceled += instance.OnTeleportModeCancel;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @MoveForwardPOI.started += instance.OnMoveForwardPOI;
                @MoveForwardPOI.performed += instance.OnMoveForwardPOI;
                @MoveForwardPOI.canceled += instance.OnMoveForwardPOI;
                @MoveForwardWaypoint.started += instance.OnMoveForwardWaypoint;
                @MoveForwardWaypoint.performed += instance.OnMoveForwardWaypoint;
                @MoveForwardWaypoint.canceled += instance.OnMoveForwardWaypoint;
                @MoveForwardTeleport.started += instance.OnMoveForwardTeleport;
                @MoveForwardTeleport.performed += instance.OnMoveForwardTeleport;
                @MoveForwardTeleport.canceled += instance.OnMoveForwardTeleport;
                @RotateAnchor.started += instance.OnRotateAnchor;
                @RotateAnchor.performed += instance.OnRotateAnchor;
                @RotateAnchor.canceled += instance.OnRotateAnchor;
                @TranslateAnchor.started += instance.OnTranslateAnchor;
                @TranslateAnchor.performed += instance.OnTranslateAnchor;
                @TranslateAnchor.canceled += instance.OnTranslateAnchor;
                @MoveBackwardPOI.started += instance.OnMoveBackwardPOI;
                @MoveBackwardPOI.performed += instance.OnMoveBackwardPOI;
                @MoveBackwardPOI.canceled += instance.OnMoveBackwardPOI;
                @MoveBackwardWaypoint.started += instance.OnMoveBackwardWaypoint;
                @MoveBackwardWaypoint.performed += instance.OnMoveBackwardWaypoint;
                @MoveBackwardWaypoint.canceled += instance.OnMoveBackwardWaypoint;
                @MoveBackwardTeleport.started += instance.OnMoveBackwardTeleport;
                @MoveBackwardTeleport.performed += instance.OnMoveBackwardTeleport;
                @MoveBackwardTeleport.canceled += instance.OnMoveBackwardTeleport;
                @SwitchControlMode.started += instance.OnSwitchControlMode;
                @SwitchControlMode.performed += instance.OnSwitchControlMode;
                @SwitchControlMode.canceled += instance.OnSwitchControlMode;
            }
        }
    }
    public XRIRightHandActions @XRIRightHand => new XRIRightHandActions(this);
    private int m_GenericXRControllerSchemeIndex = -1;
    public InputControlScheme GenericXRControllerScheme
    {
        get
        {
            if (m_GenericXRControllerSchemeIndex == -1) m_GenericXRControllerSchemeIndex = asset.FindControlSchemeIndex("Generic XR Controller");
            return asset.controlSchemes[m_GenericXRControllerSchemeIndex];
        }
    }
    private int m_ContinuousMoveSchemeIndex = -1;
    public InputControlScheme ContinuousMoveScheme
    {
        get
        {
            if (m_ContinuousMoveSchemeIndex == -1) m_ContinuousMoveSchemeIndex = asset.FindControlSchemeIndex("Continuous Move");
            return asset.controlSchemes[m_ContinuousMoveSchemeIndex];
        }
    }
    private int m_NoncontinuousMoveSchemeIndex = -1;
    public InputControlScheme NoncontinuousMoveScheme
    {
        get
        {
            if (m_NoncontinuousMoveSchemeIndex == -1) m_NoncontinuousMoveSchemeIndex = asset.FindControlSchemeIndex("Noncontinuous Move");
            return asset.controlSchemes[m_NoncontinuousMoveSchemeIndex];
        }
    }
    public interface IXRIHMDActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
    }
    public interface IXRILeftHandActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnActivate(InputAction.CallbackContext context);
        void OnUIPress(InputAction.CallbackContext context);
        void OnHapticDevice(InputAction.CallbackContext context);
        void OnTeleportSelect(InputAction.CallbackContext context);
        void OnTeleportModeActivate(InputAction.CallbackContext context);
        void OnTeleportModeCancel(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotateAnchor(InputAction.CallbackContext context);
        void OnTranslateAnchor(InputAction.CallbackContext context);
    }
    public interface IXRIRightHandActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnActivate(InputAction.CallbackContext context);
        void OnUIPress(InputAction.CallbackContext context);
        void OnPlacePOI(InputAction.CallbackContext context);
        void OnPlaceWaypoint(InputAction.CallbackContext context);
        void OnPlaceTeleport(InputAction.CallbackContext context);
        void OnHapticDevice(InputAction.CallbackContext context);
        void OnTeleportSelect(InputAction.CallbackContext context);
        void OnTeleportModeActivate(InputAction.CallbackContext context);
        void OnTeleportModeCancel(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnMoveForwardPOI(InputAction.CallbackContext context);
        void OnMoveForwardWaypoint(InputAction.CallbackContext context);
        void OnMoveForwardTeleport(InputAction.CallbackContext context);
        void OnRotateAnchor(InputAction.CallbackContext context);
        void OnTranslateAnchor(InputAction.CallbackContext context);
        void OnMoveBackwardPOI(InputAction.CallbackContext context);
        void OnMoveBackwardWaypoint(InputAction.CallbackContext context);
        void OnMoveBackwardTeleport(InputAction.CallbackContext context);
        void OnSwitchControlMode(InputAction.CallbackContext context);
    }
}
