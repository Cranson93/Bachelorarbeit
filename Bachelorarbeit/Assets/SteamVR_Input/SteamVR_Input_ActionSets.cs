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
        
        private static SteamVR_Input_ActionSet_default p__default;
        
        private static SteamVR_Input_ActionSet_main p_main;
        
        private static SteamVR_Input_ActionSet_driving p_driving;
        
        public static SteamVR_Input_ActionSet_default _default
        {
            get
            {
                return SteamVR_Actions.p__default.GetCopy<SteamVR_Input_ActionSet_default>();
            }
        }
        
        public static SteamVR_Input_ActionSet_main main
        {
            get
            {
                return SteamVR_Actions.p_main.GetCopy<SteamVR_Input_ActionSet_main>();
            }
        }
        
        public static SteamVR_Input_ActionSet_driving driving
        {
            get
            {
                return SteamVR_Actions.p_driving.GetCopy<SteamVR_Input_ActionSet_driving>();
            }
        }
        
        private static void StartPreInitActionSets()
        {
            SteamVR_Actions.p__default = ((SteamVR_Input_ActionSet_default)(SteamVR_ActionSet.Create<SteamVR_Input_ActionSet_default>("/actions/default")));
            SteamVR_Actions.p_main = ((SteamVR_Input_ActionSet_main)(SteamVR_ActionSet.Create<SteamVR_Input_ActionSet_main>("/actions/main")));
            SteamVR_Actions.p_driving = ((SteamVR_Input_ActionSet_driving)(SteamVR_ActionSet.Create<SteamVR_Input_ActionSet_driving>("/actions/driving")));
            Valve.VR.SteamVR_Input.actionSets = new Valve.VR.SteamVR_ActionSet[] {
                    SteamVR_Actions._default,
                    SteamVR_Actions.main,
                    SteamVR_Actions.driving};
        }
    }
}
