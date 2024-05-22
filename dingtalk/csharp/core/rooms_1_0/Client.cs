// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkrooms_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 创建自定义屏幕模版
         *
         * @param request CreateDeviceCustomTemplateRequest
         * @param headers CreateDeviceCustomTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeviceCustomTemplateResponse
         */
        public CreateDeviceCustomTemplateResponse CreateDeviceCustomTemplateWithOptions(CreateDeviceCustomTemplateRequest request, CreateDeviceCustomTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgImgList))
            {
                body["bgImgList"] = request.BgImgList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgType))
            {
                body["bgType"] = request.BgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgUrl))
            {
                body["bgUrl"] = request.BgUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDoc))
            {
                body["customDoc"] = request.CustomDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesensitizeUserName))
            {
                body["desensitizeUserName"] = request.DesensitizeUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionIds))
            {
                body["deviceUnionIds"] = request.DeviceUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideServerCodeWhenProjecting))
            {
                body["hideServerCodeWhenProjecting"] = request.HideServerCodeWhenProjecting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPicTop))
            {
                body["isPicTop"] = request.IsPicTop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                body["logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicturePlayInterval))
            {
                body["picturePlayInterval"] = request.PicturePlayInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomIds))
            {
                body["roomIds"] = request.RoomIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCalendarCard))
            {
                body["showCalendarCard"] = request.ShowCalendarCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCalendarTitle))
            {
                body["showCalendarTitle"] = request.ShowCalendarTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowFunctionCard))
            {
                body["showFunctionCard"] = request.ShowFunctionCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeviceCustomTemplate",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/screens/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeviceCustomTemplateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建自定义屏幕模版
         *
         * @param request CreateDeviceCustomTemplateRequest
         * @param headers CreateDeviceCustomTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeviceCustomTemplateResponse
         */
        public async Task<CreateDeviceCustomTemplateResponse> CreateDeviceCustomTemplateWithOptionsAsync(CreateDeviceCustomTemplateRequest request, CreateDeviceCustomTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgImgList))
            {
                body["bgImgList"] = request.BgImgList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgType))
            {
                body["bgType"] = request.BgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgUrl))
            {
                body["bgUrl"] = request.BgUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDoc))
            {
                body["customDoc"] = request.CustomDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesensitizeUserName))
            {
                body["desensitizeUserName"] = request.DesensitizeUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionIds))
            {
                body["deviceUnionIds"] = request.DeviceUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideServerCodeWhenProjecting))
            {
                body["hideServerCodeWhenProjecting"] = request.HideServerCodeWhenProjecting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPicTop))
            {
                body["isPicTop"] = request.IsPicTop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                body["logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicturePlayInterval))
            {
                body["picturePlayInterval"] = request.PicturePlayInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomIds))
            {
                body["roomIds"] = request.RoomIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCalendarCard))
            {
                body["showCalendarCard"] = request.ShowCalendarCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCalendarTitle))
            {
                body["showCalendarTitle"] = request.ShowCalendarTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowFunctionCard))
            {
                body["showFunctionCard"] = request.ShowFunctionCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeviceCustomTemplate",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/screens/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeviceCustomTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建自定义屏幕模版
         *
         * @param request CreateDeviceCustomTemplateRequest
         * @return CreateDeviceCustomTemplateResponse
         */
        public CreateDeviceCustomTemplateResponse CreateDeviceCustomTemplate(CreateDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceCustomTemplateHeaders headers = new CreateDeviceCustomTemplateHeaders();
            return CreateDeviceCustomTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建自定义屏幕模版
         *
         * @param request CreateDeviceCustomTemplateRequest
         * @return CreateDeviceCustomTemplateResponse
         */
        public async Task<CreateDeviceCustomTemplateResponse> CreateDeviceCustomTemplateAsync(CreateDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceCustomTemplateHeaders headers = new CreateDeviceCustomTemplateHeaders();
            return await CreateDeviceCustomTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建智能会议室
         *
         * @param request CreateMeetingRoomRequest
         * @param headers CreateMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMeetingRoomResponse
         */
        public CreateMeetingRoomResponse CreateMeetingRoomWithOptions(CreateMeetingRoomRequest request, CreateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCycleReservation))
            {
                body["enableCycleReservation"] = request.EnableCycleReservation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["isvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservationAuthority))
            {
                body["reservationAuthority"] = request.ReservationAuthority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIds))
            {
                body["roomLabelIds"] = request.RoomLabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocation))
            {
                body["roomLocation"] = request.RoomLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["roomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["roomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["roomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingrooms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建智能会议室
         *
         * @param request CreateMeetingRoomRequest
         * @param headers CreateMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMeetingRoomResponse
         */
        public async Task<CreateMeetingRoomResponse> CreateMeetingRoomWithOptionsAsync(CreateMeetingRoomRequest request, CreateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCycleReservation))
            {
                body["enableCycleReservation"] = request.EnableCycleReservation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["isvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservationAuthority))
            {
                body["reservationAuthority"] = request.ReservationAuthority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIds))
            {
                body["roomLabelIds"] = request.RoomLabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocation))
            {
                body["roomLocation"] = request.RoomLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["roomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["roomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["roomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingrooms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建智能会议室
         *
         * @param request CreateMeetingRoomRequest
         * @return CreateMeetingRoomResponse
         */
        public CreateMeetingRoomResponse CreateMeetingRoom(CreateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomHeaders headers = new CreateMeetingRoomHeaders();
            return CreateMeetingRoomWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建智能会议室
         *
         * @param request CreateMeetingRoomRequest
         * @return CreateMeetingRoomResponse
         */
        public async Task<CreateMeetingRoomResponse> CreateMeetingRoomAsync(CreateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomHeaders headers = new CreateMeetingRoomHeaders();
            return await CreateMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建智能会议室IOT配置
         *
         * @param request CreateMeetingRoomControlPanelRequest
         * @param headers CreateMeetingRoomControlPanelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMeetingRoomControlPanelResponse
         */
        public CreateMeetingRoomControlPanelResponse CreateMeetingRoomControlPanelWithOptions(CreateMeetingRoomControlPanelRequest request, CreateMeetingRoomControlPanelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomConfig))
            {
                body["roomConfig"] = request.RoomConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoomControlPanel",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/panels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomControlPanelResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建智能会议室IOT配置
         *
         * @param request CreateMeetingRoomControlPanelRequest
         * @param headers CreateMeetingRoomControlPanelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMeetingRoomControlPanelResponse
         */
        public async Task<CreateMeetingRoomControlPanelResponse> CreateMeetingRoomControlPanelWithOptionsAsync(CreateMeetingRoomControlPanelRequest request, CreateMeetingRoomControlPanelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomConfig))
            {
                body["roomConfig"] = request.RoomConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoomControlPanel",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/panels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomControlPanelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建智能会议室IOT配置
         *
         * @param request CreateMeetingRoomControlPanelRequest
         * @return CreateMeetingRoomControlPanelResponse
         */
        public CreateMeetingRoomControlPanelResponse CreateMeetingRoomControlPanel(CreateMeetingRoomControlPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomControlPanelHeaders headers = new CreateMeetingRoomControlPanelHeaders();
            return CreateMeetingRoomControlPanelWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建智能会议室IOT配置
         *
         * @param request CreateMeetingRoomControlPanelRequest
         * @return CreateMeetingRoomControlPanelResponse
         */
        public async Task<CreateMeetingRoomControlPanelResponse> CreateMeetingRoomControlPanelAsync(CreateMeetingRoomControlPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomControlPanelHeaders headers = new CreateMeetingRoomControlPanelHeaders();
            return await CreateMeetingRoomControlPanelWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建会议室分组
         *
         * @param request CreateMeetingRoomGroupRequest
         * @param headers CreateMeetingRoomGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMeetingRoomGroupResponse
         */
        public CreateMeetingRoomGroupResponse CreateMeetingRoomGroupWithOptions(CreateMeetingRoomGroupRequest request, CreateMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentGroupId))
            {
                body["parentGroupId"] = request.ParentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建会议室分组
         *
         * @param request CreateMeetingRoomGroupRequest
         * @param headers CreateMeetingRoomGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMeetingRoomGroupResponse
         */
        public async Task<CreateMeetingRoomGroupResponse> CreateMeetingRoomGroupWithOptionsAsync(CreateMeetingRoomGroupRequest request, CreateMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentGroupId))
            {
                body["parentGroupId"] = request.ParentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建会议室分组
         *
         * @param request CreateMeetingRoomGroupRequest
         * @return CreateMeetingRoomGroupResponse
         */
        public CreateMeetingRoomGroupResponse CreateMeetingRoomGroup(CreateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomGroupHeaders headers = new CreateMeetingRoomGroupHeaders();
            return CreateMeetingRoomGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建会议室分组
         *
         * @param request CreateMeetingRoomGroupRequest
         * @return CreateMeetingRoomGroupResponse
         */
        public async Task<CreateMeetingRoomGroupResponse> CreateMeetingRoomGroupAsync(CreateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomGroupHeaders headers = new CreateMeetingRoomGroupHeaders();
            return await CreateMeetingRoomGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除自定义屏幕模板
         *
         * @param request DeleteDeviceCustomTemplateRequest
         * @param headers DeleteDeviceCustomTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeviceCustomTemplateResponse
         */
        public DeleteDeviceCustomTemplateResponse DeleteDeviceCustomTemplateWithOptions(DeleteDeviceCustomTemplateRequest request, DeleteDeviceCustomTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeviceCustomTemplate",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/screens/templates/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeviceCustomTemplateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除自定义屏幕模板
         *
         * @param request DeleteDeviceCustomTemplateRequest
         * @param headers DeleteDeviceCustomTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeviceCustomTemplateResponse
         */
        public async Task<DeleteDeviceCustomTemplateResponse> DeleteDeviceCustomTemplateWithOptionsAsync(DeleteDeviceCustomTemplateRequest request, DeleteDeviceCustomTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeviceCustomTemplate",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/screens/templates/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeviceCustomTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除自定义屏幕模板
         *
         * @param request DeleteDeviceCustomTemplateRequest
         * @return DeleteDeviceCustomTemplateResponse
         */
        public DeleteDeviceCustomTemplateResponse DeleteDeviceCustomTemplate(DeleteDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeviceCustomTemplateHeaders headers = new DeleteDeviceCustomTemplateHeaders();
            return DeleteDeviceCustomTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除自定义屏幕模板
         *
         * @param request DeleteDeviceCustomTemplateRequest
         * @return DeleteDeviceCustomTemplateResponse
         */
        public async Task<DeleteDeviceCustomTemplateResponse> DeleteDeviceCustomTemplateAsync(DeleteDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeviceCustomTemplateHeaders headers = new DeleteDeviceCustomTemplateHeaders();
            return await DeleteDeviceCustomTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除会议室
         *
         * @param request DeleteMeetingRoomRequest
         * @param headers DeleteMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMeetingRoomResponse
         */
        public DeleteMeetingRoomResponse DeleteMeetingRoomWithOptions(string roomId, DeleteMeetingRoomRequest request, DeleteMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/" + roomId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除会议室
         *
         * @param request DeleteMeetingRoomRequest
         * @param headers DeleteMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMeetingRoomResponse
         */
        public async Task<DeleteMeetingRoomResponse> DeleteMeetingRoomWithOptionsAsync(string roomId, DeleteMeetingRoomRequest request, DeleteMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/" + roomId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除会议室
         *
         * @param request DeleteMeetingRoomRequest
         * @return DeleteMeetingRoomResponse
         */
        public DeleteMeetingRoomResponse DeleteMeetingRoom(string roomId, DeleteMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomHeaders headers = new DeleteMeetingRoomHeaders();
            return DeleteMeetingRoomWithOptions(roomId, request, headers, runtime);
        }

        /**
         * @summary 删除会议室
         *
         * @param request DeleteMeetingRoomRequest
         * @return DeleteMeetingRoomResponse
         */
        public async Task<DeleteMeetingRoomResponse> DeleteMeetingRoomAsync(string roomId, DeleteMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomHeaders headers = new DeleteMeetingRoomHeaders();
            return await DeleteMeetingRoomWithOptionsAsync(roomId, request, headers, runtime);
        }

        /**
         * @summary 删除会议室配置
         *
         * @param request DeleteMeetingRoomControlPanelRequest
         * @param headers DeleteMeetingRoomControlPanelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMeetingRoomControlPanelResponse
         */
        public DeleteMeetingRoomControlPanelResponse DeleteMeetingRoomControlPanelWithOptions(DeleteMeetingRoomControlPanelRequest request, DeleteMeetingRoomControlPanelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomIds))
            {
                body["roomIds"] = request.RoomIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoomControlPanel",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/panels/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomControlPanelResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除会议室配置
         *
         * @param request DeleteMeetingRoomControlPanelRequest
         * @param headers DeleteMeetingRoomControlPanelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMeetingRoomControlPanelResponse
         */
        public async Task<DeleteMeetingRoomControlPanelResponse> DeleteMeetingRoomControlPanelWithOptionsAsync(DeleteMeetingRoomControlPanelRequest request, DeleteMeetingRoomControlPanelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomIds))
            {
                body["roomIds"] = request.RoomIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoomControlPanel",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/panels/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomControlPanelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除会议室配置
         *
         * @param request DeleteMeetingRoomControlPanelRequest
         * @return DeleteMeetingRoomControlPanelResponse
         */
        public DeleteMeetingRoomControlPanelResponse DeleteMeetingRoomControlPanel(DeleteMeetingRoomControlPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomControlPanelHeaders headers = new DeleteMeetingRoomControlPanelHeaders();
            return DeleteMeetingRoomControlPanelWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除会议室配置
         *
         * @param request DeleteMeetingRoomControlPanelRequest
         * @return DeleteMeetingRoomControlPanelResponse
         */
        public async Task<DeleteMeetingRoomControlPanelResponse> DeleteMeetingRoomControlPanelAsync(DeleteMeetingRoomControlPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomControlPanelHeaders headers = new DeleteMeetingRoomControlPanelHeaders();
            return await DeleteMeetingRoomControlPanelWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除会议室分组
         *
         * @param request DeleteMeetingRoomGroupRequest
         * @param headers DeleteMeetingRoomGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMeetingRoomGroupResponse
         */
        public DeleteMeetingRoomGroupResponse DeleteMeetingRoomGroupWithOptions(string groupId, DeleteMeetingRoomGroupRequest request, DeleteMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups/" + groupId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除会议室分组
         *
         * @param request DeleteMeetingRoomGroupRequest
         * @param headers DeleteMeetingRoomGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMeetingRoomGroupResponse
         */
        public async Task<DeleteMeetingRoomGroupResponse> DeleteMeetingRoomGroupWithOptionsAsync(string groupId, DeleteMeetingRoomGroupRequest request, DeleteMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups/" + groupId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除会议室分组
         *
         * @param request DeleteMeetingRoomGroupRequest
         * @return DeleteMeetingRoomGroupResponse
         */
        public DeleteMeetingRoomGroupResponse DeleteMeetingRoomGroup(string groupId, DeleteMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomGroupHeaders headers = new DeleteMeetingRoomGroupHeaders();
            return DeleteMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
        }

        /**
         * @summary 删除会议室分组
         *
         * @param request DeleteMeetingRoomGroupRequest
         * @return DeleteMeetingRoomGroupResponse
         */
        public async Task<DeleteMeetingRoomGroupResponse> DeleteMeetingRoomGroupAsync(string groupId, DeleteMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomGroupHeaders headers = new DeleteMeetingRoomGroupHeaders();
            return await DeleteMeetingRoomGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /**
         * @summary 查询自定义屏幕模板
         *
         * @param headers QueryDeviceCustomTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDeviceCustomTemplateResponse
         */
        public QueryDeviceCustomTemplateResponse QueryDeviceCustomTemplateWithOptions(string templateId, QueryDeviceCustomTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceCustomTemplate",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/screens/templates/" + templateId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceCustomTemplateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询自定义屏幕模板
         *
         * @param headers QueryDeviceCustomTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDeviceCustomTemplateResponse
         */
        public async Task<QueryDeviceCustomTemplateResponse> QueryDeviceCustomTemplateWithOptionsAsync(string templateId, QueryDeviceCustomTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceCustomTemplate",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/screens/templates/" + templateId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceCustomTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询自定义屏幕模板
         *
         * @return QueryDeviceCustomTemplateResponse
         */
        public QueryDeviceCustomTemplateResponse QueryDeviceCustomTemplate(string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceCustomTemplateHeaders headers = new QueryDeviceCustomTemplateHeaders();
            return QueryDeviceCustomTemplateWithOptions(templateId, headers, runtime);
        }

        /**
         * @summary 查询自定义屏幕模板
         *
         * @return QueryDeviceCustomTemplateResponse
         */
        public async Task<QueryDeviceCustomTemplateResponse> QueryDeviceCustomTemplateAsync(string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceCustomTemplateHeaders headers = new QueryDeviceCustomTemplateHeaders();
            return await QueryDeviceCustomTemplateWithOptionsAsync(templateId, headers, runtime);
        }

        /**
         * @summary 查询自定义屏幕模板列表
         *
         * @param headers QueryDeviceCustomTemplateListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDeviceCustomTemplateListResponse
         */
        public QueryDeviceCustomTemplateListResponse QueryDeviceCustomTemplateListWithOptions(QueryDeviceCustomTemplateListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceCustomTemplateList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/screens/templateLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceCustomTemplateListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询自定义屏幕模板列表
         *
         * @param headers QueryDeviceCustomTemplateListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDeviceCustomTemplateListResponse
         */
        public async Task<QueryDeviceCustomTemplateListResponse> QueryDeviceCustomTemplateListWithOptionsAsync(QueryDeviceCustomTemplateListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceCustomTemplateList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/screens/templateLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceCustomTemplateListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询自定义屏幕模板列表
         *
         * @return QueryDeviceCustomTemplateListResponse
         */
        public QueryDeviceCustomTemplateListResponse QueryDeviceCustomTemplateList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceCustomTemplateListHeaders headers = new QueryDeviceCustomTemplateListHeaders();
            return QueryDeviceCustomTemplateListWithOptions(headers, runtime);
        }

        /**
         * @summary 查询自定义屏幕模板列表
         *
         * @return QueryDeviceCustomTemplateListResponse
         */
        public async Task<QueryDeviceCustomTemplateListResponse> QueryDeviceCustomTemplateListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceCustomTemplateListHeaders headers = new QueryDeviceCustomTemplateListHeaders();
            return await QueryDeviceCustomTemplateListWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 根据设备投屏码查询设备ip
         *
         * @param request QueryDeviceIpByCodeRequest
         * @param headers QueryDeviceIpByCodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDeviceIpByCodeResponse
         */
        public QueryDeviceIpByCodeResponse QueryDeviceIpByCodeWithOptions(string shareCode, QueryDeviceIpByCodeRequest request, QueryDeviceIpByCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                query["deviceSn"] = request.DeviceSn;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceIpByCode",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/shareCodes/" + shareCode,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceIpByCodeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据设备投屏码查询设备ip
         *
         * @param request QueryDeviceIpByCodeRequest
         * @param headers QueryDeviceIpByCodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDeviceIpByCodeResponse
         */
        public async Task<QueryDeviceIpByCodeResponse> QueryDeviceIpByCodeWithOptionsAsync(string shareCode, QueryDeviceIpByCodeRequest request, QueryDeviceIpByCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                query["deviceSn"] = request.DeviceSn;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceIpByCode",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/shareCodes/" + shareCode,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceIpByCodeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据设备投屏码查询设备ip
         *
         * @param request QueryDeviceIpByCodeRequest
         * @return QueryDeviceIpByCodeResponse
         */
        public QueryDeviceIpByCodeResponse QueryDeviceIpByCode(string shareCode, QueryDeviceIpByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceIpByCodeHeaders headers = new QueryDeviceIpByCodeHeaders();
            return QueryDeviceIpByCodeWithOptions(shareCode, request, headers, runtime);
        }

        /**
         * @summary 根据设备投屏码查询设备ip
         *
         * @param request QueryDeviceIpByCodeRequest
         * @return QueryDeviceIpByCodeResponse
         */
        public async Task<QueryDeviceIpByCodeResponse> QueryDeviceIpByCodeAsync(string shareCode, QueryDeviceIpByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceIpByCodeHeaders headers = new QueryDeviceIpByCodeHeaders();
            return await QueryDeviceIpByCodeWithOptionsAsync(shareCode, request, headers, runtime);
        }

        /**
         * @summary 查询设备属性
         *
         * @param request QueryDevicePropertiesRequest
         * @param headers QueryDevicePropertiesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDevicePropertiesResponse
         */
        public QueryDevicePropertiesResponse QueryDevicePropertiesWithOptions(QueryDevicePropertiesRequest request, QueryDevicePropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionId))
            {
                query["deviceUnionId"] = request.DeviceUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                query["operatorUnionId"] = request.OperatorUnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyNames))
            {
                body["propertyNames"] = request.PropertyNames;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceProperties",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/properties/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePropertiesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询设备属性
         *
         * @param request QueryDevicePropertiesRequest
         * @param headers QueryDevicePropertiesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDevicePropertiesResponse
         */
        public async Task<QueryDevicePropertiesResponse> QueryDevicePropertiesWithOptionsAsync(QueryDevicePropertiesRequest request, QueryDevicePropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionId))
            {
                query["deviceUnionId"] = request.DeviceUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                query["operatorUnionId"] = request.OperatorUnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyNames))
            {
                body["propertyNames"] = request.PropertyNames;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceProperties",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/properties/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePropertiesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询设备属性
         *
         * @param request QueryDevicePropertiesRequest
         * @return QueryDevicePropertiesResponse
         */
        public QueryDevicePropertiesResponse QueryDeviceProperties(QueryDevicePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDevicePropertiesHeaders headers = new QueryDevicePropertiesHeaders();
            return QueryDevicePropertiesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询设备属性
         *
         * @param request QueryDevicePropertiesRequest
         * @return QueryDevicePropertiesResponse
         */
        public async Task<QueryDevicePropertiesResponse> QueryDevicePropertiesAsync(QueryDevicePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDevicePropertiesHeaders headers = new QueryDevicePropertiesHeaders();
            return await QueryDevicePropertiesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询会议室详情
         *
         * @param request QueryMeetingRoomRequest
         * @param headers QueryMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomResponse
         */
        public QueryMeetingRoomResponse QueryMeetingRoomWithOptions(string roomId, QueryMeetingRoomRequest request, QueryMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/" + roomId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询会议室详情
         *
         * @param request QueryMeetingRoomRequest
         * @param headers QueryMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomResponse
         */
        public async Task<QueryMeetingRoomResponse> QueryMeetingRoomWithOptionsAsync(string roomId, QueryMeetingRoomRequest request, QueryMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/" + roomId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询会议室详情
         *
         * @param request QueryMeetingRoomRequest
         * @return QueryMeetingRoomResponse
         */
        public QueryMeetingRoomResponse QueryMeetingRoom(string roomId, QueryMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomHeaders headers = new QueryMeetingRoomHeaders();
            return QueryMeetingRoomWithOptions(roomId, request, headers, runtime);
        }

        /**
         * @summary 查询会议室详情
         *
         * @param request QueryMeetingRoomRequest
         * @return QueryMeetingRoomResponse
         */
        public async Task<QueryMeetingRoomResponse> QueryMeetingRoomAsync(string roomId, QueryMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomHeaders headers = new QueryMeetingRoomHeaders();
            return await QueryMeetingRoomWithOptionsAsync(roomId, request, headers, runtime);
        }

        /**
         * @summary 获取会议室IOT配置列表
         *
         * @param request QueryMeetingRoomControlPanelListRequest
         * @param headers QueryMeetingRoomControlPanelListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomControlPanelListResponse
         */
        public QueryMeetingRoomControlPanelListResponse QueryMeetingRoomControlPanelListWithOptions(QueryMeetingRoomControlPanelListRequest request, QueryMeetingRoomControlPanelListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                query["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomControlPanelList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/panels/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomControlPanelListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取会议室IOT配置列表
         *
         * @param request QueryMeetingRoomControlPanelListRequest
         * @param headers QueryMeetingRoomControlPanelListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomControlPanelListResponse
         */
        public async Task<QueryMeetingRoomControlPanelListResponse> QueryMeetingRoomControlPanelListWithOptionsAsync(QueryMeetingRoomControlPanelListRequest request, QueryMeetingRoomControlPanelListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                query["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomControlPanelList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/panels/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomControlPanelListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取会议室IOT配置列表
         *
         * @param request QueryMeetingRoomControlPanelListRequest
         * @return QueryMeetingRoomControlPanelListResponse
         */
        public QueryMeetingRoomControlPanelListResponse QueryMeetingRoomControlPanelList(QueryMeetingRoomControlPanelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomControlPanelListHeaders headers = new QueryMeetingRoomControlPanelListHeaders();
            return QueryMeetingRoomControlPanelListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取会议室IOT配置列表
         *
         * @param request QueryMeetingRoomControlPanelListRequest
         * @return QueryMeetingRoomControlPanelListResponse
         */
        public async Task<QueryMeetingRoomControlPanelListResponse> QueryMeetingRoomControlPanelListAsync(QueryMeetingRoomControlPanelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomControlPanelListHeaders headers = new QueryMeetingRoomControlPanelListHeaders();
            return await QueryMeetingRoomControlPanelListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询设备信息
         *
         * @param request QueryMeetingRoomDeviceRequest
         * @param headers QueryMeetingRoomDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomDeviceResponse
         */
        public QueryMeetingRoomDeviceResponse QueryMeetingRoomDeviceWithOptions(QueryMeetingRoomDeviceRequest request, QueryMeetingRoomDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionId))
            {
                query["deviceUnionId"] = request.DeviceUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                query["operatorUnionId"] = request.OperatorUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomDevice",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomDeviceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询设备信息
         *
         * @param request QueryMeetingRoomDeviceRequest
         * @param headers QueryMeetingRoomDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomDeviceResponse
         */
        public async Task<QueryMeetingRoomDeviceResponse> QueryMeetingRoomDeviceWithOptionsAsync(QueryMeetingRoomDeviceRequest request, QueryMeetingRoomDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionId))
            {
                query["deviceUnionId"] = request.DeviceUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                query["operatorUnionId"] = request.OperatorUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomDevice",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询设备信息
         *
         * @param request QueryMeetingRoomDeviceRequest
         * @return QueryMeetingRoomDeviceResponse
         */
        public QueryMeetingRoomDeviceResponse QueryMeetingRoomDevice(QueryMeetingRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomDeviceHeaders headers = new QueryMeetingRoomDeviceHeaders();
            return QueryMeetingRoomDeviceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询设备信息
         *
         * @param request QueryMeetingRoomDeviceRequest
         * @return QueryMeetingRoomDeviceResponse
         */
        public async Task<QueryMeetingRoomDeviceResponse> QueryMeetingRoomDeviceAsync(QueryMeetingRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomDeviceHeaders headers = new QueryMeetingRoomDeviceHeaders();
            return await QueryMeetingRoomDeviceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询会议室分组信息
         *
         * @param request QueryMeetingRoomGroupRequest
         * @param headers QueryMeetingRoomGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomGroupResponse
         */
        public QueryMeetingRoomGroupResponse QueryMeetingRoomGroupWithOptions(string groupId, QueryMeetingRoomGroupRequest request, QueryMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups/" + groupId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询会议室分组信息
         *
         * @param request QueryMeetingRoomGroupRequest
         * @param headers QueryMeetingRoomGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomGroupResponse
         */
        public async Task<QueryMeetingRoomGroupResponse> QueryMeetingRoomGroupWithOptionsAsync(string groupId, QueryMeetingRoomGroupRequest request, QueryMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups/" + groupId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询会议室分组信息
         *
         * @param request QueryMeetingRoomGroupRequest
         * @return QueryMeetingRoomGroupResponse
         */
        public QueryMeetingRoomGroupResponse QueryMeetingRoomGroup(string groupId, QueryMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupHeaders headers = new QueryMeetingRoomGroupHeaders();
            return QueryMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
        }

        /**
         * @summary 查询会议室分组信息
         *
         * @param request QueryMeetingRoomGroupRequest
         * @return QueryMeetingRoomGroupResponse
         */
        public async Task<QueryMeetingRoomGroupResponse> QueryMeetingRoomGroupAsync(string groupId, QueryMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupHeaders headers = new QueryMeetingRoomGroupHeaders();
            return await QueryMeetingRoomGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /**
         * @summary 查询会议室分组列表
         *
         * @param request QueryMeetingRoomGroupListRequest
         * @param headers QueryMeetingRoomGroupListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomGroupListResponse
         */
        public QueryMeetingRoomGroupListResponse QueryMeetingRoomGroupListWithOptions(QueryMeetingRoomGroupListRequest request, QueryMeetingRoomGroupListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroupList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groupLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询会议室分组列表
         *
         * @param request QueryMeetingRoomGroupListRequest
         * @param headers QueryMeetingRoomGroupListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomGroupListResponse
         */
        public async Task<QueryMeetingRoomGroupListResponse> QueryMeetingRoomGroupListWithOptionsAsync(QueryMeetingRoomGroupListRequest request, QueryMeetingRoomGroupListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroupList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groupLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询会议室分组列表
         *
         * @param request QueryMeetingRoomGroupListRequest
         * @return QueryMeetingRoomGroupListResponse
         */
        public QueryMeetingRoomGroupListResponse QueryMeetingRoomGroupList(QueryMeetingRoomGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupListHeaders headers = new QueryMeetingRoomGroupListHeaders();
            return QueryMeetingRoomGroupListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询会议室分组列表
         *
         * @param request QueryMeetingRoomGroupListRequest
         * @return QueryMeetingRoomGroupListResponse
         */
        public async Task<QueryMeetingRoomGroupListResponse> QueryMeetingRoomGroupListAsync(QueryMeetingRoomGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupListHeaders headers = new QueryMeetingRoomGroupListHeaders();
            return await QueryMeetingRoomGroupListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询会议室列表
         *
         * @param request QueryMeetingRoomListRequest
         * @param headers QueryMeetingRoomListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomListResponse
         */
        public QueryMeetingRoomListResponse QueryMeetingRoomListWithOptions(QueryMeetingRoomListRequest request, QueryMeetingRoomListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRoomLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询会议室列表
         *
         * @param request QueryMeetingRoomListRequest
         * @param headers QueryMeetingRoomListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMeetingRoomListResponse
         */
        public async Task<QueryMeetingRoomListResponse> QueryMeetingRoomListWithOptionsAsync(QueryMeetingRoomListRequest request, QueryMeetingRoomListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRoomLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询会议室列表
         *
         * @param request QueryMeetingRoomListRequest
         * @return QueryMeetingRoomListResponse
         */
        public QueryMeetingRoomListResponse QueryMeetingRoomList(QueryMeetingRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomListHeaders headers = new QueryMeetingRoomListHeaders();
            return QueryMeetingRoomListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询会议室列表
         *
         * @param request QueryMeetingRoomListRequest
         * @return QueryMeetingRoomListResponse
         */
        public async Task<QueryMeetingRoomListResponse> QueryMeetingRoomListAsync(QueryMeetingRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomListHeaders headers = new QueryMeetingRoomListHeaders();
            return await QueryMeetingRoomListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 取消会议室高级用户模式。
         *
         * @param request RemoveSuperUserMeetingRoomRequest
         * @param headers RemoveSuperUserMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveSuperUserMeetingRoomResponse
         */
        public RemoveSuperUserMeetingRoomResponse RemoveSuperUserMeetingRoomWithOptions(RemoveSuperUserMeetingRoomRequest request, RemoveSuperUserMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                query["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSuperUserMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/superUsers/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSuperUserMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 取消会议室高级用户模式。
         *
         * @param request RemoveSuperUserMeetingRoomRequest
         * @param headers RemoveSuperUserMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveSuperUserMeetingRoomResponse
         */
        public async Task<RemoveSuperUserMeetingRoomResponse> RemoveSuperUserMeetingRoomWithOptionsAsync(RemoveSuperUserMeetingRoomRequest request, RemoveSuperUserMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                query["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSuperUserMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/superUsers/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSuperUserMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 取消会议室高级用户模式。
         *
         * @param request RemoveSuperUserMeetingRoomRequest
         * @return RemoveSuperUserMeetingRoomResponse
         */
        public RemoveSuperUserMeetingRoomResponse RemoveSuperUserMeetingRoom(RemoveSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveSuperUserMeetingRoomHeaders headers = new RemoveSuperUserMeetingRoomHeaders();
            return RemoveSuperUserMeetingRoomWithOptions(request, headers, runtime);
        }

        /**
         * @summary 取消会议室高级用户模式。
         *
         * @param request RemoveSuperUserMeetingRoomRequest
         * @return RemoveSuperUserMeetingRoomResponse
         */
        public async Task<RemoveSuperUserMeetingRoomResponse> RemoveSuperUserMeetingRoomAsync(RemoveSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveSuperUserMeetingRoomHeaders headers = new RemoveSuperUserMeetingRoomHeaders();
            return await RemoveSuperUserMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
         *
         * @param request SetSuperUserMeetingRoomRequest
         * @param headers SetSuperUserMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSuperUserMeetingRoomResponse
         */
        public SetSuperUserMeetingRoomResponse SetSuperUserMeetingRoomWithOptions(SetSuperUserMeetingRoomRequest request, SetSuperUserMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdWhiteList))
            {
                body["deptIdWhiteList"] = request.DeptIdWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdWhiteList))
            {
                body["userIdWhiteList"] = request.UserIdWhiteList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSuperUserMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/superUsers/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSuperUserMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
         *
         * @param request SetSuperUserMeetingRoomRequest
         * @param headers SetSuperUserMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSuperUserMeetingRoomResponse
         */
        public async Task<SetSuperUserMeetingRoomResponse> SetSuperUserMeetingRoomWithOptionsAsync(SetSuperUserMeetingRoomRequest request, SetSuperUserMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdWhiteList))
            {
                body["deptIdWhiteList"] = request.DeptIdWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdWhiteList))
            {
                body["userIdWhiteList"] = request.UserIdWhiteList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSuperUserMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/superUsers/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSuperUserMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
         *
         * @param request SetSuperUserMeetingRoomRequest
         * @return SetSuperUserMeetingRoomResponse
         */
        public SetSuperUserMeetingRoomResponse SetSuperUserMeetingRoom(SetSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetSuperUserMeetingRoomHeaders headers = new SetSuperUserMeetingRoomHeaders();
            return SetSuperUserMeetingRoomWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
         *
         * @param request SetSuperUserMeetingRoomRequest
         * @return SetSuperUserMeetingRoomResponse
         */
        public async Task<SetSuperUserMeetingRoomResponse> SetSuperUserMeetingRoomAsync(SetSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetSuperUserMeetingRoomHeaders headers = new SetSuperUserMeetingRoomHeaders();
            return await SetSuperUserMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新自定义屏幕模板
         *
         * @param request UpdateDeviceCustomTemplateRequest
         * @param headers UpdateDeviceCustomTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeviceCustomTemplateResponse
         */
        public UpdateDeviceCustomTemplateResponse UpdateDeviceCustomTemplateWithOptions(UpdateDeviceCustomTemplateRequest request, UpdateDeviceCustomTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgImgList))
            {
                body["bgImgList"] = request.BgImgList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgType))
            {
                body["bgType"] = request.BgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgUrl))
            {
                body["bgUrl"] = request.BgUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDoc))
            {
                body["customDoc"] = request.CustomDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesensitizeUserName))
            {
                body["desensitizeUserName"] = request.DesensitizeUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionIds))
            {
                body["deviceUnionIds"] = request.DeviceUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideServerCodeWhenProjecting))
            {
                body["hideServerCodeWhenProjecting"] = request.HideServerCodeWhenProjecting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPicTop))
            {
                body["isPicTop"] = request.IsPicTop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                body["logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicturePlayInterval))
            {
                body["picturePlayInterval"] = request.PicturePlayInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomIds))
            {
                body["roomIds"] = request.RoomIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCalendarCard))
            {
                body["showCalendarCard"] = request.ShowCalendarCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCalendarTitle))
            {
                body["showCalendarTitle"] = request.ShowCalendarTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowFunctionCard))
            {
                body["showFunctionCard"] = request.ShowFunctionCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeviceCustomTemplate",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/screens/templates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeviceCustomTemplateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新自定义屏幕模板
         *
         * @param request UpdateDeviceCustomTemplateRequest
         * @param headers UpdateDeviceCustomTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeviceCustomTemplateResponse
         */
        public async Task<UpdateDeviceCustomTemplateResponse> UpdateDeviceCustomTemplateWithOptionsAsync(UpdateDeviceCustomTemplateRequest request, UpdateDeviceCustomTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgImgList))
            {
                body["bgImgList"] = request.BgImgList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgType))
            {
                body["bgType"] = request.BgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgUrl))
            {
                body["bgUrl"] = request.BgUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDoc))
            {
                body["customDoc"] = request.CustomDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesensitizeUserName))
            {
                body["desensitizeUserName"] = request.DesensitizeUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionIds))
            {
                body["deviceUnionIds"] = request.DeviceUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideServerCodeWhenProjecting))
            {
                body["hideServerCodeWhenProjecting"] = request.HideServerCodeWhenProjecting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPicTop))
            {
                body["isPicTop"] = request.IsPicTop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                body["logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicturePlayInterval))
            {
                body["picturePlayInterval"] = request.PicturePlayInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomIds))
            {
                body["roomIds"] = request.RoomIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCalendarCard))
            {
                body["showCalendarCard"] = request.ShowCalendarCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCalendarTitle))
            {
                body["showCalendarTitle"] = request.ShowCalendarTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowFunctionCard))
            {
                body["showFunctionCard"] = request.ShowFunctionCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeviceCustomTemplate",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/screens/templates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeviceCustomTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新自定义屏幕模板
         *
         * @param request UpdateDeviceCustomTemplateRequest
         * @return UpdateDeviceCustomTemplateResponse
         */
        public UpdateDeviceCustomTemplateResponse UpdateDeviceCustomTemplate(UpdateDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeviceCustomTemplateHeaders headers = new UpdateDeviceCustomTemplateHeaders();
            return UpdateDeviceCustomTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新自定义屏幕模板
         *
         * @param request UpdateDeviceCustomTemplateRequest
         * @return UpdateDeviceCustomTemplateResponse
         */
        public async Task<UpdateDeviceCustomTemplateResponse> UpdateDeviceCustomTemplateAsync(UpdateDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeviceCustomTemplateHeaders headers = new UpdateDeviceCustomTemplateHeaders();
            return await UpdateDeviceCustomTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新会议室信息
         *
         * @param request UpdateMeetingRoomRequest
         * @param headers UpdateMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMeetingRoomResponse
         */
        public UpdateMeetingRoomResponse UpdateMeetingRoomWithOptions(UpdateMeetingRoomRequest request, UpdateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCycleReservation))
            {
                body["enableCycleReservation"] = request.EnableCycleReservation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["isvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservationAuthority))
            {
                body["reservationAuthority"] = request.ReservationAuthority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIds))
            {
                body["roomLabelIds"] = request.RoomLabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocation))
            {
                body["roomLocation"] = request.RoomLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["roomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["roomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["roomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新会议室信息
         *
         * @param request UpdateMeetingRoomRequest
         * @param headers UpdateMeetingRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMeetingRoomResponse
         */
        public async Task<UpdateMeetingRoomResponse> UpdateMeetingRoomWithOptionsAsync(UpdateMeetingRoomRequest request, UpdateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCycleReservation))
            {
                body["enableCycleReservation"] = request.EnableCycleReservation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["isvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservationAuthority))
            {
                body["reservationAuthority"] = request.ReservationAuthority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIds))
            {
                body["roomLabelIds"] = request.RoomLabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocation))
            {
                body["roomLocation"] = request.RoomLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["roomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["roomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["roomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新会议室信息
         *
         * @param request UpdateMeetingRoomRequest
         * @return UpdateMeetingRoomResponse
         */
        public UpdateMeetingRoomResponse UpdateMeetingRoom(UpdateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomHeaders headers = new UpdateMeetingRoomHeaders();
            return UpdateMeetingRoomWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新会议室信息
         *
         * @param request UpdateMeetingRoomRequest
         * @return UpdateMeetingRoomResponse
         */
        public async Task<UpdateMeetingRoomResponse> UpdateMeetingRoomAsync(UpdateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomHeaders headers = new UpdateMeetingRoomHeaders();
            return await UpdateMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新会议室分组
         *
         * @param request UpdateMeetingRoomGroupRequest
         * @param headers UpdateMeetingRoomGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMeetingRoomGroupResponse
         */
        public UpdateMeetingRoomGroupResponse UpdateMeetingRoomGroupWithOptions(UpdateMeetingRoomGroupRequest request, UpdateMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新会议室分组
         *
         * @param request UpdateMeetingRoomGroupRequest
         * @param headers UpdateMeetingRoomGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMeetingRoomGroupResponse
         */
        public async Task<UpdateMeetingRoomGroupResponse> UpdateMeetingRoomGroupWithOptionsAsync(UpdateMeetingRoomGroupRequest request, UpdateMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新会议室分组
         *
         * @param request UpdateMeetingRoomGroupRequest
         * @return UpdateMeetingRoomGroupResponse
         */
        public UpdateMeetingRoomGroupResponse UpdateMeetingRoomGroup(UpdateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomGroupHeaders headers = new UpdateMeetingRoomGroupHeaders();
            return UpdateMeetingRoomGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新会议室分组
         *
         * @param request UpdateMeetingRoomGroupRequest
         * @return UpdateMeetingRoomGroupResponse
         */
        public async Task<UpdateMeetingRoomGroupResponse> UpdateMeetingRoomGroupAsync(UpdateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomGroupHeaders headers = new UpdateMeetingRoomGroupHeaders();
            return await UpdateMeetingRoomGroupWithOptionsAsync(request, headers, runtime);
        }

    }
}
