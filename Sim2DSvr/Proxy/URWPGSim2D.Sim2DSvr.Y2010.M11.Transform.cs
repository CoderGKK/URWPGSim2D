//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.8825
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Reflection.AssemblyVersionAttribute("1.2.123.20110")]
[assembly: global::System.Reflection.AssemblyCopyrightAttribute("Copyright © PKUICL 2010")]
[assembly: global::System.Reflection.AssemblyCompanyAttribute("PKUICL")]
[assembly: global::System.Reflection.AssemblyProductAttribute("Sim2DSvr")]
[assembly: global::System.Reflection.AssemblyTitleAttribute("Sim2DSvr")]
[assembly: global::Microsoft.Dss.Core.Attributes.ServiceDeclarationAttribute(global::Microsoft.Dss.Core.Attributes.DssServiceDeclaration.Transform, SourceAssemblyKey="URWPGSim2D.Sim2DSvr.Y2010.M11, Version=1.2.123.20110, Culture=neutral, PublicKeyT" +
    "oken=04f000b8db128100")]
[assembly: global::System.Security.SecurityTransparentAttribute()]
[assembly: global::System.Security.AllowPartiallyTrustedCallersAttribute()]

namespace Dss.Transforms.TransformURWPGSim2D {
    
    
    public class Transforms : global::Microsoft.Dss.Core.Transforms.TransformBase {
        
        static Transforms() {
            Register();
        }
        
        public static void Register() {
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceUriRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceUriRequest_TO_URWPGSim2D_Sim2DSvr_ClientAnnounceUriRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientAnnounceUriRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientAnnounceUriRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceUriRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceUriResponse), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceUriResponse_TO_URWPGSim2D_Sim2DSvr_ClientAnnounceUriResponse));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientAnnounceUriResponse), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientAnnounceUriResponse_TO_URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceUriResponse));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceTeamNameRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceTeamNameRequest_TO_URWPGSim2D_Sim2DSvr_ClientAnnounceTeamNameRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientAnnounceTeamNameRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientAnnounceTeamNameRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceTeamNameRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceReadyRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceReadyRequest_TO_URWPGSim2D_Sim2DSvr_ClientAnnounceReadyRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientAnnounceReadyRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientAnnounceReadyRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceReadyRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.Proxy.CompetitionTypeChangedRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_Proxy_CompetitionTypeChangedRequest_TO_URWPGSim2D_Sim2DSvr_CompetitionTypeChangedRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.CompetitionTypeChangedRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_CompetitionTypeChangedRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_CompetitionTypeChangedRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.Proxy.CompetitionControlButtonRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_Proxy_CompetitionControlButtonRequest_TO_URWPGSim2D_Sim2DSvr_CompetitionControlButtonRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.CompetitionControlButtonRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_CompetitionControlButtonRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_CompetitionControlButtonRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.Proxy.MissionParaRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_Proxy_MissionParaRequest_TO_URWPGSim2D_Sim2DSvr_MissionParaRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.MissionParaRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_MissionParaRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_MissionParaRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.Proxy.Sim2DSvrState), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_Proxy_Sim2DSvrState_TO_URWPGSim2D_Sim2DSvr_Sim2DSvrState));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.Sim2DSvrState), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_Sim2DSvrState_TO_URWPGSim2D_Sim2DSvr_Proxy_Sim2DSvrState));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.HeartBeatRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientBase_Proxy_HeartBeatRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_HeartBeatRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientBase.HeartBeatRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientBase_HeartBeatRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_Proxy_HeartBeatRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.HeartBeatResponse), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientBase_Proxy_HeartBeatResponse_TO_URWPGSim2D_Sim2DSvr_ClientBase_HeartBeatResponse));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientBase.HeartBeatResponse), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientBase_HeartBeatResponse_TO_URWPGSim2D_Sim2DSvr_ClientBase_Proxy_HeartBeatResponse));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.TeamIdChangedRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientBase_Proxy_TeamIdChangedRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_TeamIdChangedRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientBase.TeamIdChangedRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientBase_TeamIdChangedRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_Proxy_TeamIdChangedRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.ClientAnnounceDecisionRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientBase_Proxy_ClientAnnounceDecisionRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_ClientAnnounceDecisionRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientBase.ClientAnnounceDecisionRequest), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientBase_ClientAnnounceDecisionRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_Proxy_ClientAnnounceDecisionRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.ClientBaseState), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientBase_Proxy_ClientBaseState_TO_URWPGSim2D_Sim2DSvr_ClientBase_ClientBaseState));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::URWPGSim2D.Sim2DSvr.ClientBase.ClientBaseState), new global::Microsoft.Dss.Core.Attributes.Transform(URWPGSim2D_Sim2DSvr_ClientBase_ClientBaseState_TO_URWPGSim2D_Sim2DSvr_ClientBase_Proxy_ClientBaseState));
        }
        
        public static object URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceUriRequest_TO_URWPGSim2D_Sim2DSvr_ClientAnnounceUriRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientAnnounceUriRequest target = new global::URWPGSim2D.Sim2DSvr.ClientAnnounceUriRequest();
            global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceUriRequest from = ((global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceUriRequest)(transformFrom));
            target.Service = from.Service;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientAnnounceUriRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceUriRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceUriRequest target = new global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceUriRequest();
            global::URWPGSim2D.Sim2DSvr.ClientAnnounceUriRequest from = ((global::URWPGSim2D.Sim2DSvr.ClientAnnounceUriRequest)(transformFrom));
            target.Service = from.Service;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceUriResponse_TO_URWPGSim2D_Sim2DSvr_ClientAnnounceUriResponse(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientAnnounceUriResponse target = new global::URWPGSim2D.Sim2DSvr.ClientAnnounceUriResponse();
            global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceUriResponse from = ((global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceUriResponse)(transformFrom));
            target.TeamCount = from.TeamCount;
            target.TeamId = from.TeamId;
            target.MissionName = from.MissionName;
            target.AlternateServerPortUri = from.AlternateServerPortUri;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientAnnounceUriResponse_TO_URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceUriResponse(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceUriResponse target = new global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceUriResponse();
            global::URWPGSim2D.Sim2DSvr.ClientAnnounceUriResponse from = ((global::URWPGSim2D.Sim2DSvr.ClientAnnounceUriResponse)(transformFrom));
            target.TeamCount = from.TeamCount;
            target.TeamId = from.TeamId;
            target.MissionName = from.MissionName;
            target.AlternateServerPortUri = from.AlternateServerPortUri;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceTeamNameRequest_TO_URWPGSim2D_Sim2DSvr_ClientAnnounceTeamNameRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientAnnounceTeamNameRequest target = new global::URWPGSim2D.Sim2DSvr.ClientAnnounceTeamNameRequest();
            global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceTeamNameRequest from = ((global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceTeamNameRequest)(transformFrom));
            target.Service = from.Service;
            target.TeamId = from.TeamId;
            target.TeamName = from.TeamName;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientAnnounceTeamNameRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceTeamNameRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceTeamNameRequest target = new global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceTeamNameRequest();
            global::URWPGSim2D.Sim2DSvr.ClientAnnounceTeamNameRequest from = ((global::URWPGSim2D.Sim2DSvr.ClientAnnounceTeamNameRequest)(transformFrom));
            target.Service = from.Service;
            target.TeamId = from.TeamId;
            target.TeamName = from.TeamName;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceReadyRequest_TO_URWPGSim2D_Sim2DSvr_ClientAnnounceReadyRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientAnnounceReadyRequest target = new global::URWPGSim2D.Sim2DSvr.ClientAnnounceReadyRequest();
            global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceReadyRequest from = ((global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceReadyRequest)(transformFrom));
            target.TeamId = from.TeamId;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientAnnounceReadyRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_ClientAnnounceReadyRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceReadyRequest target = new global::URWPGSim2D.Sim2DSvr.Proxy.ClientAnnounceReadyRequest();
            global::URWPGSim2D.Sim2DSvr.ClientAnnounceReadyRequest from = ((global::URWPGSim2D.Sim2DSvr.ClientAnnounceReadyRequest)(transformFrom));
            target.TeamId = from.TeamId;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_Proxy_CompetitionTypeChangedRequest_TO_URWPGSim2D_Sim2DSvr_CompetitionTypeChangedRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.CompetitionTypeChangedRequest target = new global::URWPGSim2D.Sim2DSvr.CompetitionTypeChangedRequest();
            global::URWPGSim2D.Sim2DSvr.Proxy.CompetitionTypeChangedRequest from = ((global::URWPGSim2D.Sim2DSvr.Proxy.CompetitionTypeChangedRequest)(transformFrom));
            target.CompetitionType = from.CompetitionType;
            target.TeamCount = from.TeamCount;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_CompetitionTypeChangedRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_CompetitionTypeChangedRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.Proxy.CompetitionTypeChangedRequest target = new global::URWPGSim2D.Sim2DSvr.Proxy.CompetitionTypeChangedRequest();
            global::URWPGSim2D.Sim2DSvr.CompetitionTypeChangedRequest from = ((global::URWPGSim2D.Sim2DSvr.CompetitionTypeChangedRequest)(transformFrom));
            target.CompetitionType = from.CompetitionType;
            target.TeamCount = from.TeamCount;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_Proxy_CompetitionControlButtonRequest_TO_URWPGSim2D_Sim2DSvr_CompetitionControlButtonRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.CompetitionControlButtonRequest target = new global::URWPGSim2D.Sim2DSvr.CompetitionControlButtonRequest();
            global::URWPGSim2D.Sim2DSvr.Proxy.CompetitionControlButtonRequest from = ((global::URWPGSim2D.Sim2DSvr.Proxy.CompetitionControlButtonRequest)(transformFrom));
            target.ControlButtonMessage = from.ControlButtonMessage;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_CompetitionControlButtonRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_CompetitionControlButtonRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.Proxy.CompetitionControlButtonRequest target = new global::URWPGSim2D.Sim2DSvr.Proxy.CompetitionControlButtonRequest();
            global::URWPGSim2D.Sim2DSvr.CompetitionControlButtonRequest from = ((global::URWPGSim2D.Sim2DSvr.CompetitionControlButtonRequest)(transformFrom));
            target.ControlButtonMessage = from.ControlButtonMessage;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_Proxy_MissionParaRequest_TO_URWPGSim2D_Sim2DSvr_MissionParaRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.MissionParaRequest target = new global::URWPGSim2D.Sim2DSvr.MissionParaRequest();
            global::URWPGSim2D.Sim2DSvr.Proxy.MissionParaRequest from = ((global::URWPGSim2D.Sim2DSvr.Proxy.MissionParaRequest)(transformFrom));
            if ((from.CurMission != null)) {
                global::URWPGSim2D.Common.Mission tmp = new global::URWPGSim2D.Common.Mission();
                ((Microsoft.Dss.Core.IDssSerializable)(from.CurMission)).CopyTo(((Microsoft.Dss.Core.IDssSerializable)(tmp)));
                target.CurMission = tmp;
            }
            else {
                target.CurMission = null;
            }
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_MissionParaRequest_TO_URWPGSim2D_Sim2DSvr_Proxy_MissionParaRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.Proxy.MissionParaRequest target = new global::URWPGSim2D.Sim2DSvr.Proxy.MissionParaRequest();
            global::URWPGSim2D.Sim2DSvr.MissionParaRequest from = ((global::URWPGSim2D.Sim2DSvr.MissionParaRequest)(transformFrom));
            global::URWPGSim2D.Common.Mission tmp = from.CurMission;
            if ((tmp != null)) {
                global::URWPGSim2D.Common.Mission tmp0 = new global::URWPGSim2D.Common.Mission();
                ((Microsoft.Dss.Core.IDssSerializable)(tmp)).CopyTo(((Microsoft.Dss.Core.IDssSerializable)(tmp0)));
                target.CurMission = tmp0;
            }
            return target;
        }
        
        private static global::URWPGSim2D.Sim2DSvr.Proxy.Sim2DSvrState _cachedInstance0 = new global::URWPGSim2D.Sim2DSvr.Proxy.Sim2DSvrState();
        
        private static global::URWPGSim2D.Sim2DSvr.Sim2DSvrState _cachedInstance = new global::URWPGSim2D.Sim2DSvr.Sim2DSvrState();
        
        public static object URWPGSim2D_Sim2DSvr_Proxy_Sim2DSvrState_TO_URWPGSim2D_Sim2DSvr_Sim2DSvrState(object transformFrom) {
            return _cachedInstance;
        }
        
        public static object URWPGSim2D_Sim2DSvr_Sim2DSvrState_TO_URWPGSim2D_Sim2DSvr_Proxy_Sim2DSvrState(object transformFrom) {
            return _cachedInstance0;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientBase_Proxy_HeartBeatRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_HeartBeatRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientBase.HeartBeatRequest target = new global::URWPGSim2D.Sim2DSvr.ClientBase.HeartBeatRequest();
            global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.HeartBeatRequest from = ((global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.HeartBeatRequest)(transformFrom));
            target.HeartBeat = from.HeartBeat;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientBase_HeartBeatRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_Proxy_HeartBeatRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.HeartBeatRequest target = new global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.HeartBeatRequest();
            global::URWPGSim2D.Sim2DSvr.ClientBase.HeartBeatRequest from = ((global::URWPGSim2D.Sim2DSvr.ClientBase.HeartBeatRequest)(transformFrom));
            target.HeartBeat = from.HeartBeat;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientBase_Proxy_HeartBeatResponse_TO_URWPGSim2D_Sim2DSvr_ClientBase_HeartBeatResponse(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientBase.HeartBeatResponse target = new global::URWPGSim2D.Sim2DSvr.ClientBase.HeartBeatResponse();
            global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.HeartBeatResponse from = ((global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.HeartBeatResponse)(transformFrom));
            target.RspHeartBeat = from.RspHeartBeat;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientBase_HeartBeatResponse_TO_URWPGSim2D_Sim2DSvr_ClientBase_Proxy_HeartBeatResponse(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.HeartBeatResponse target = new global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.HeartBeatResponse();
            global::URWPGSim2D.Sim2DSvr.ClientBase.HeartBeatResponse from = ((global::URWPGSim2D.Sim2DSvr.ClientBase.HeartBeatResponse)(transformFrom));
            target.RspHeartBeat = from.RspHeartBeat;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientBase_Proxy_TeamIdChangedRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_TeamIdChangedRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientBase.TeamIdChangedRequest target = new global::URWPGSim2D.Sim2DSvr.ClientBase.TeamIdChangedRequest();
            global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.TeamIdChangedRequest from = ((global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.TeamIdChangedRequest)(transformFrom));
            target.TeamId = from.TeamId;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientBase_TeamIdChangedRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_Proxy_TeamIdChangedRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.TeamIdChangedRequest target = new global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.TeamIdChangedRequest();
            global::URWPGSim2D.Sim2DSvr.ClientBase.TeamIdChangedRequest from = ((global::URWPGSim2D.Sim2DSvr.ClientBase.TeamIdChangedRequest)(transformFrom));
            target.TeamId = from.TeamId;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientBase_Proxy_ClientAnnounceDecisionRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_ClientAnnounceDecisionRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientBase.ClientAnnounceDecisionRequest target = new global::URWPGSim2D.Sim2DSvr.ClientBase.ClientAnnounceDecisionRequest();
            global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.ClientAnnounceDecisionRequest from = ((global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.ClientAnnounceDecisionRequest)(transformFrom));
            if ((from.Decisions != null)) {
                int count = from.Decisions.Length;
                global::URWPGSim2D.Common.Decision[] tmp = new global::URWPGSim2D.Common.Decision[count];
                for (int index = 0; (index < count); index = (index + 1)) {
                    global::URWPGSim2D.Common.Decision tmp0 = default(global::URWPGSim2D.Common.Decision);
                    tmp0 = from.Decisions[index];
                    tmp[index] = tmp0;
                }
                target.Decisions = tmp;
            }
            else {
                target.Decisions = null;
            }
            target.TeamId = from.TeamId;
            return target;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientBase_ClientAnnounceDecisionRequest_TO_URWPGSim2D_Sim2DSvr_ClientBase_Proxy_ClientAnnounceDecisionRequest(object transformFrom) {
            global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.ClientAnnounceDecisionRequest target = new global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.ClientAnnounceDecisionRequest();
            global::URWPGSim2D.Sim2DSvr.ClientBase.ClientAnnounceDecisionRequest from = ((global::URWPGSim2D.Sim2DSvr.ClientBase.ClientAnnounceDecisionRequest)(transformFrom));
            URWPGSim2D.Common.Decision[] tmp = from.Decisions;
            if ((tmp != null)) {
                int count = tmp.Length;
                global::URWPGSim2D.Common.Decision[] tmp0 = new global::URWPGSim2D.Common.Decision[count];
                for (int index = 0; (index < count); index = (index + 1)) {
                    global::URWPGSim2D.Common.Decision tmp1 = default(global::URWPGSim2D.Common.Decision);
                    tmp1 = tmp[index];
                    tmp0[index] = tmp1;
                }
                target.Decisions = tmp0;
            }
            target.TeamId = from.TeamId;
            return target;
        }
        
        private static global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.ClientBaseState _cachedInstance2 = new global::URWPGSim2D.Sim2DSvr.ClientBase.Proxy.ClientBaseState();
        
        private static global::URWPGSim2D.Sim2DSvr.ClientBase.ClientBaseState _cachedInstance1 = new global::URWPGSim2D.Sim2DSvr.ClientBase.ClientBaseState();
        
        public static object URWPGSim2D_Sim2DSvr_ClientBase_Proxy_ClientBaseState_TO_URWPGSim2D_Sim2DSvr_ClientBase_ClientBaseState(object transformFrom) {
            return _cachedInstance1;
        }
        
        public static object URWPGSim2D_Sim2DSvr_ClientBase_ClientBaseState_TO_URWPGSim2D_Sim2DSvr_ClientBase_Proxy_ClientBaseState(object transformFrom) {
            return _cachedInstance2;
        }
    }
}
