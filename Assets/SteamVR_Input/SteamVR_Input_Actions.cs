//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Actions
    {
        
        private static SteamVR_Action_Boolean p_seeingVR_default_RecognizeCurrentImage;
        
        private static SteamVR_Action_Boolean p_seeingVR_default_MakeLaserThicker;
        
        private static SteamVR_Action_Boolean p_seeingVR_default_StartListening;
        
        public static SteamVR_Action_Boolean seeingVR_default_RecognizeCurrentImage
        {
            get
            {
                return SteamVR_Actions.p_seeingVR_default_RecognizeCurrentImage.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean seeingVR_default_MakeLaserThicker
        {
            get
            {
                return SteamVR_Actions.p_seeingVR_default_MakeLaserThicker.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean seeingVR_default_StartListening
        {
            get
            {
                return SteamVR_Actions.p_seeingVR_default_StartListening.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        private static void InitializeActionArrays()
        {
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[] {
                    SteamVR_Actions.seeingVR_default_RecognizeCurrentImage,
                    SteamVR_Actions.seeingVR_default_MakeLaserThicker,
                    SteamVR_Actions.seeingVR_default_StartListening};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.seeingVR_default_RecognizeCurrentImage,
                    SteamVR_Actions.seeingVR_default_MakeLaserThicker,
                    SteamVR_Actions.seeingVR_default_StartListening};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.ISteamVR_Action_Out[0];
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[0];
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[0];
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[] {
                    SteamVR_Actions.seeingVR_default_RecognizeCurrentImage,
                    SteamVR_Actions.seeingVR_default_MakeLaserThicker,
                    SteamVR_Actions.seeingVR_default_StartListening};
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[0];
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[0];
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[0];
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[0];
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.seeingVR_default_RecognizeCurrentImage,
                    SteamVR_Actions.seeingVR_default_MakeLaserThicker,
                    SteamVR_Actions.seeingVR_default_StartListening};
        }
        
        private static void PreInitActions()
        {
            SteamVR_Actions.p_seeingVR_default_RecognizeCurrentImage = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/SeeingVR_default/in/RecognizeCurrentImage")));
            SteamVR_Actions.p_seeingVR_default_MakeLaserThicker = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/SeeingVR_default/in/MakeLaserThicker")));
            SteamVR_Actions.p_seeingVR_default_StartListening = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/SeeingVR_default/in/StartListening")));
        }
    }
}
