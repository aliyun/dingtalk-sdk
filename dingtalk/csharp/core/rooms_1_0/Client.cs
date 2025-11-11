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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会议室预定黑名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBookingBlacklistRequest
        /// </param>
        /// <param name="headers">
        /// CreateBookingBlacklistHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBookingBlacklistResponse
        /// </returns>
        public CreateBookingBlacklistResponse CreateBookingBlacklistWithOptions(CreateBookingBlacklistRequest request, CreateBookingBlacklistHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlacklistUnionId))
            {
                body["blacklistUnionId"] = request.BlacklistUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "CreateBookingBlacklist",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/bookings/blacklist",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBookingBlacklistResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会议室预定黑名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBookingBlacklistRequest
        /// </param>
        /// <param name="headers">
        /// CreateBookingBlacklistHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBookingBlacklistResponse
        /// </returns>
        public async Task<CreateBookingBlacklistResponse> CreateBookingBlacklistWithOptionsAsync(CreateBookingBlacklistRequest request, CreateBookingBlacklistHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlacklistUnionId))
            {
                body["blacklistUnionId"] = request.BlacklistUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "CreateBookingBlacklist",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/bookings/blacklist",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBookingBlacklistResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会议室预定黑名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBookingBlacklistRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBookingBlacklistResponse
        /// </returns>
        public CreateBookingBlacklistResponse CreateBookingBlacklist(CreateBookingBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBookingBlacklistHeaders headers = new CreateBookingBlacklistHeaders();
            return CreateBookingBlacklistWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会议室预定黑名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBookingBlacklistRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBookingBlacklistResponse
        /// </returns>
        public async Task<CreateBookingBlacklistResponse> CreateBookingBlacklistAsync(CreateBookingBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBookingBlacklistHeaders headers = new CreateBookingBlacklistHeaders();
            return await CreateBookingBlacklistWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义屏幕模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceCustomTemplateRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeviceCustomTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceCustomTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义屏幕模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceCustomTemplateRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeviceCustomTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceCustomTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义屏幕模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceCustomTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceCustomTemplateResponse
        /// </returns>
        public CreateDeviceCustomTemplateResponse CreateDeviceCustomTemplate(CreateDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceCustomTemplateHeaders headers = new CreateDeviceCustomTemplateHeaders();
            return CreateDeviceCustomTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义屏幕模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceCustomTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceCustomTemplateResponse
        /// </returns>
        public async Task<CreateDeviceCustomTemplateResponse> CreateDeviceCustomTemplateAsync(CreateDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceCustomTemplateHeaders headers = new CreateDeviceCustomTemplateHeaders();
            return await CreateDeviceCustomTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// CreateMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenReservation))
            {
                body["openReservation"] = request.OpenReservation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservationAuthority))
            {
                body["reservationAuthority"] = request.ReservationAuthority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomDescription))
            {
                body["roomDescription"] = request.RoomDescription;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// CreateMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenReservation))
            {
                body["openReservation"] = request.OpenReservation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservationAuthority))
            {
                body["reservationAuthority"] = request.ReservationAuthority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomDescription))
            {
                body["roomDescription"] = request.RoomDescription;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomResponse
        /// </returns>
        public CreateMeetingRoomResponse CreateMeetingRoom(CreateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomHeaders headers = new CreateMeetingRoomHeaders();
            return CreateMeetingRoomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomResponse
        /// </returns>
        public async Task<CreateMeetingRoomResponse> CreateMeetingRoomAsync(CreateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomHeaders headers = new CreateMeetingRoomHeaders();
            return await CreateMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能会议室IOT配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomControlPanelRequest
        /// </param>
        /// <param name="headers">
        /// CreateMeetingRoomControlPanelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomControlPanelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能会议室IOT配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomControlPanelRequest
        /// </param>
        /// <param name="headers">
        /// CreateMeetingRoomControlPanelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomControlPanelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能会议室IOT配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomControlPanelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomControlPanelResponse
        /// </returns>
        public CreateMeetingRoomControlPanelResponse CreateMeetingRoomControlPanel(CreateMeetingRoomControlPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomControlPanelHeaders headers = new CreateMeetingRoomControlPanelHeaders();
            return CreateMeetingRoomControlPanelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能会议室IOT配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomControlPanelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomControlPanelResponse
        /// </returns>
        public async Task<CreateMeetingRoomControlPanelResponse> CreateMeetingRoomControlPanelAsync(CreateMeetingRoomControlPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomControlPanelHeaders headers = new CreateMeetingRoomControlPanelHeaders();
            return await CreateMeetingRoomControlPanelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateMeetingRoomGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateMeetingRoomGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomGroupResponse
        /// </returns>
        public CreateMeetingRoomGroupResponse CreateMeetingRoomGroup(CreateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomGroupHeaders headers = new CreateMeetingRoomGroupHeaders();
            return CreateMeetingRoomGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMeetingRoomGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMeetingRoomGroupResponse
        /// </returns>
        public async Task<CreateMeetingRoomGroupResponse> CreateMeetingRoomGroupAsync(CreateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomGroupHeaders headers = new CreateMeetingRoomGroupHeaders();
            return await CreateMeetingRoomGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室预定黑名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBookingBlacklistRequest
        /// </param>
        /// <param name="headers">
        /// DeleteBookingBlacklistHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBookingBlacklistResponse
        /// </returns>
        public DeleteBookingBlacklistResponse DeleteBookingBlacklistWithOptions(DeleteBookingBlacklistRequest request, DeleteBookingBlacklistHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlacklistUnionIds))
            {
                body["blacklistUnionIds"] = request.BlacklistUnionIds;
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
                Action = "DeleteBookingBlacklist",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/bookings/blacklist/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBookingBlacklistResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室预定黑名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBookingBlacklistRequest
        /// </param>
        /// <param name="headers">
        /// DeleteBookingBlacklistHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBookingBlacklistResponse
        /// </returns>
        public async Task<DeleteBookingBlacklistResponse> DeleteBookingBlacklistWithOptionsAsync(DeleteBookingBlacklistRequest request, DeleteBookingBlacklistHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlacklistUnionIds))
            {
                body["blacklistUnionIds"] = request.BlacklistUnionIds;
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
                Action = "DeleteBookingBlacklist",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/bookings/blacklist/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBookingBlacklistResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室预定黑名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBookingBlacklistRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBookingBlacklistResponse
        /// </returns>
        public DeleteBookingBlacklistResponse DeleteBookingBlacklist(DeleteBookingBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteBookingBlacklistHeaders headers = new DeleteBookingBlacklistHeaders();
            return DeleteBookingBlacklistWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室预定黑名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBookingBlacklistRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBookingBlacklistResponse
        /// </returns>
        public async Task<DeleteBookingBlacklistResponse> DeleteBookingBlacklistAsync(DeleteBookingBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteBookingBlacklistHeaders headers = new DeleteBookingBlacklistHeaders();
            return await DeleteBookingBlacklistWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDeviceCustomTemplateRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDeviceCustomTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeviceCustomTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDeviceCustomTemplateRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDeviceCustomTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeviceCustomTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDeviceCustomTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeviceCustomTemplateResponse
        /// </returns>
        public DeleteDeviceCustomTemplateResponse DeleteDeviceCustomTemplate(DeleteDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeviceCustomTemplateHeaders headers = new DeleteDeviceCustomTemplateHeaders();
            return DeleteDeviceCustomTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDeviceCustomTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeviceCustomTemplateResponse
        /// </returns>
        public async Task<DeleteDeviceCustomTemplateResponse> DeleteDeviceCustomTemplateAsync(DeleteDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeviceCustomTemplateHeaders headers = new DeleteDeviceCustomTemplateHeaders();
            return await DeleteDeviceCustomTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomResponse
        /// </returns>
        public DeleteMeetingRoomResponse DeleteMeetingRoom(string roomId, DeleteMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomHeaders headers = new DeleteMeetingRoomHeaders();
            return DeleteMeetingRoomWithOptions(roomId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomResponse
        /// </returns>
        public async Task<DeleteMeetingRoomResponse> DeleteMeetingRoomAsync(string roomId, DeleteMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomHeaders headers = new DeleteMeetingRoomHeaders();
            return await DeleteMeetingRoomWithOptionsAsync(roomId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomControlPanelRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMeetingRoomControlPanelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomControlPanelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomControlPanelRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMeetingRoomControlPanelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomControlPanelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomControlPanelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomControlPanelResponse
        /// </returns>
        public DeleteMeetingRoomControlPanelResponse DeleteMeetingRoomControlPanel(DeleteMeetingRoomControlPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomControlPanelHeaders headers = new DeleteMeetingRoomControlPanelHeaders();
            return DeleteMeetingRoomControlPanelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomControlPanelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomControlPanelResponse
        /// </returns>
        public async Task<DeleteMeetingRoomControlPanelResponse> DeleteMeetingRoomControlPanelAsync(DeleteMeetingRoomControlPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomControlPanelHeaders headers = new DeleteMeetingRoomControlPanelHeaders();
            return await DeleteMeetingRoomControlPanelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomGroupRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMeetingRoomGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomGroupRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMeetingRoomGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomGroupResponse
        /// </returns>
        public DeleteMeetingRoomGroupResponse DeleteMeetingRoomGroup(string groupId, DeleteMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomGroupHeaders headers = new DeleteMeetingRoomGroupHeaders();
            return DeleteMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMeetingRoomGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMeetingRoomGroupResponse
        /// </returns>
        public async Task<DeleteMeetingRoomGroupResponse> DeleteMeetingRoomGroupAsync(string groupId, DeleteMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomGroupHeaders headers = new DeleteMeetingRoomGroupHeaders();
            return await DeleteMeetingRoomGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryDeviceCustomTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceCustomTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryDeviceCustomTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceCustomTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryDeviceCustomTemplateResponse
        /// </returns>
        public QueryDeviceCustomTemplateResponse QueryDeviceCustomTemplate(string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceCustomTemplateHeaders headers = new QueryDeviceCustomTemplateHeaders();
            return QueryDeviceCustomTemplateWithOptions(templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryDeviceCustomTemplateResponse
        /// </returns>
        public async Task<QueryDeviceCustomTemplateResponse> QueryDeviceCustomTemplateAsync(string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceCustomTemplateHeaders headers = new QueryDeviceCustomTemplateHeaders();
            return await QueryDeviceCustomTemplateWithOptionsAsync(templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义屏幕模板列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryDeviceCustomTemplateListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceCustomTemplateListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义屏幕模板列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryDeviceCustomTemplateListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceCustomTemplateListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义屏幕模板列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryDeviceCustomTemplateListResponse
        /// </returns>
        public QueryDeviceCustomTemplateListResponse QueryDeviceCustomTemplateList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceCustomTemplateListHeaders headers = new QueryDeviceCustomTemplateListHeaders();
            return QueryDeviceCustomTemplateListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义屏幕模板列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryDeviceCustomTemplateListResponse
        /// </returns>
        public async Task<QueryDeviceCustomTemplateListResponse> QueryDeviceCustomTemplateListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceCustomTemplateListHeaders headers = new QueryDeviceCustomTemplateListHeaders();
            return await QueryDeviceCustomTemplateListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据设备投屏码查询设备ip</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceIpByCodeRequest
        /// </param>
        /// <param name="headers">
        /// QueryDeviceIpByCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceIpByCodeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据设备投屏码查询设备ip</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceIpByCodeRequest
        /// </param>
        /// <param name="headers">
        /// QueryDeviceIpByCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceIpByCodeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据设备投屏码查询设备ip</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceIpByCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceIpByCodeResponse
        /// </returns>
        public QueryDeviceIpByCodeResponse QueryDeviceIpByCode(string shareCode, QueryDeviceIpByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceIpByCodeHeaders headers = new QueryDeviceIpByCodeHeaders();
            return QueryDeviceIpByCodeWithOptions(shareCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据设备投屏码查询设备ip</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceIpByCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceIpByCodeResponse
        /// </returns>
        public async Task<QueryDeviceIpByCodeResponse> QueryDeviceIpByCodeAsync(string shareCode, QueryDeviceIpByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceIpByCodeHeaders headers = new QueryDeviceIpByCodeHeaders();
            return await QueryDeviceIpByCodeWithOptionsAsync(shareCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicePropertiesRequest
        /// </param>
        /// <param name="headers">
        /// QueryDevicePropertiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicePropertiesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicePropertiesRequest
        /// </param>
        /// <param name="headers">
        /// QueryDevicePropertiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicePropertiesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicePropertiesResponse
        /// </returns>
        public QueryDevicePropertiesResponse QueryDeviceProperties(QueryDevicePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDevicePropertiesHeaders headers = new QueryDevicePropertiesHeaders();
            return QueryDevicePropertiesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicePropertiesResponse
        /// </returns>
        public async Task<QueryDevicePropertiesResponse> QueryDevicePropertiesAsync(QueryDevicePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDevicePropertiesHeaders headers = new QueryDevicePropertiesHeaders();
            return await QueryDevicePropertiesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomResponse
        /// </returns>
        public QueryMeetingRoomResponse QueryMeetingRoom(string roomId, QueryMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomHeaders headers = new QueryMeetingRoomHeaders();
            return QueryMeetingRoomWithOptions(roomId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomResponse
        /// </returns>
        public async Task<QueryMeetingRoomResponse> QueryMeetingRoomAsync(string roomId, QueryMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomHeaders headers = new QueryMeetingRoomHeaders();
            return await QueryMeetingRoomWithOptionsAsync(roomId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会议室IOT配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomControlPanelListRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomControlPanelListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomControlPanelListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会议室IOT配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomControlPanelListRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomControlPanelListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomControlPanelListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会议室IOT配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomControlPanelListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomControlPanelListResponse
        /// </returns>
        public QueryMeetingRoomControlPanelListResponse QueryMeetingRoomControlPanelList(QueryMeetingRoomControlPanelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomControlPanelListHeaders headers = new QueryMeetingRoomControlPanelListHeaders();
            return QueryMeetingRoomControlPanelListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会议室IOT配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomControlPanelListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomControlPanelListResponse
        /// </returns>
        public async Task<QueryMeetingRoomControlPanelListResponse> QueryMeetingRoomControlPanelListAsync(QueryMeetingRoomControlPanelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomControlPanelListHeaders headers = new QueryMeetingRoomControlPanelListHeaders();
            return await QueryMeetingRoomControlPanelListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomDeviceRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomDeviceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomDeviceRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomDeviceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomDeviceResponse
        /// </returns>
        public QueryMeetingRoomDeviceResponse QueryMeetingRoomDevice(QueryMeetingRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomDeviceHeaders headers = new QueryMeetingRoomDeviceHeaders();
            return QueryMeetingRoomDeviceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomDeviceResponse
        /// </returns>
        public async Task<QueryMeetingRoomDeviceResponse> QueryMeetingRoomDeviceAsync(QueryMeetingRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomDeviceHeaders headers = new QueryMeetingRoomDeviceHeaders();
            return await QueryMeetingRoomDeviceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室分组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomGroupRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室分组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomGroupRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室分组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomGroupResponse
        /// </returns>
        public QueryMeetingRoomGroupResponse QueryMeetingRoomGroup(string groupId, QueryMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupHeaders headers = new QueryMeetingRoomGroupHeaders();
            return QueryMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室分组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomGroupResponse
        /// </returns>
        public async Task<QueryMeetingRoomGroupResponse> QueryMeetingRoomGroupAsync(string groupId, QueryMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupHeaders headers = new QueryMeetingRoomGroupHeaders();
            return await QueryMeetingRoomGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomGroupListRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomGroupListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomGroupListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomGroupListRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomGroupListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomGroupListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomGroupListResponse
        /// </returns>
        public QueryMeetingRoomGroupListResponse QueryMeetingRoomGroupList(QueryMeetingRoomGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupListHeaders headers = new QueryMeetingRoomGroupListHeaders();
            return QueryMeetingRoomGroupListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomGroupListResponse
        /// </returns>
        public async Task<QueryMeetingRoomGroupListResponse> QueryMeetingRoomGroupListAsync(QueryMeetingRoomGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupListHeaders headers = new QueryMeetingRoomGroupListHeaders();
            return await QueryMeetingRoomGroupListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomListRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomListRequest
        /// </param>
        /// <param name="headers">
        /// QueryMeetingRoomListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomListResponse
        /// </returns>
        public QueryMeetingRoomListResponse QueryMeetingRoomList(QueryMeetingRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomListHeaders headers = new QueryMeetingRoomListHeaders();
            return QueryMeetingRoomListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMeetingRoomListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMeetingRoomListResponse
        /// </returns>
        public async Task<QueryMeetingRoomListResponse> QueryMeetingRoomListAsync(QueryMeetingRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomListHeaders headers = new QueryMeetingRoomListHeaders();
            return await QueryMeetingRoomListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消会议室高级用户模式。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveSuperUserMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// RemoveSuperUserMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveSuperUserMeetingRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消会议室高级用户模式。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveSuperUserMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// RemoveSuperUserMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveSuperUserMeetingRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消会议室高级用户模式。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveSuperUserMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveSuperUserMeetingRoomResponse
        /// </returns>
        public RemoveSuperUserMeetingRoomResponse RemoveSuperUserMeetingRoom(RemoveSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveSuperUserMeetingRoomHeaders headers = new RemoveSuperUserMeetingRoomHeaders();
            return RemoveSuperUserMeetingRoomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消会议室高级用户模式。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveSuperUserMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveSuperUserMeetingRoomResponse
        /// </returns>
        public async Task<RemoveSuperUserMeetingRoomResponse> RemoveSuperUserMeetingRoomAsync(RemoveSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveSuperUserMeetingRoomHeaders headers = new RemoveSuperUserMeetingRoomHeaders();
            return await RemoveSuperUserMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSuperUserMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// SetSuperUserMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSuperUserMeetingRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSuperUserMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// SetSuperUserMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSuperUserMeetingRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSuperUserMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSuperUserMeetingRoomResponse
        /// </returns>
        public SetSuperUserMeetingRoomResponse SetSuperUserMeetingRoom(SetSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetSuperUserMeetingRoomHeaders headers = new SetSuperUserMeetingRoomHeaders();
            return SetSuperUserMeetingRoomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSuperUserMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSuperUserMeetingRoomResponse
        /// </returns>
        public async Task<SetSuperUserMeetingRoomResponse> SetSuperUserMeetingRoomAsync(SetSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetSuperUserMeetingRoomHeaders headers = new SetSuperUserMeetingRoomHeaders();
            return await SetSuperUserMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeviceCustomTemplateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDeviceCustomTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeviceCustomTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeviceCustomTemplateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDeviceCustomTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeviceCustomTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeviceCustomTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeviceCustomTemplateResponse
        /// </returns>
        public UpdateDeviceCustomTemplateResponse UpdateDeviceCustomTemplate(UpdateDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeviceCustomTemplateHeaders headers = new UpdateDeviceCustomTemplateHeaders();
            return UpdateDeviceCustomTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义屏幕模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeviceCustomTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeviceCustomTemplateResponse
        /// </returns>
        public async Task<UpdateDeviceCustomTemplateResponse> UpdateDeviceCustomTemplateAsync(UpdateDeviceCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeviceCustomTemplateHeaders headers = new UpdateDeviceCustomTemplateHeaders();
            return await UpdateDeviceCustomTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议室信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMeetingRoomResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenReservation))
            {
                body["openReservation"] = request.OpenReservation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservationAuthority))
            {
                body["reservationAuthority"] = request.ReservationAuthority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomDescription))
            {
                body["roomDescription"] = request.RoomDescription;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议室信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMeetingRoomRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMeetingRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMeetingRoomResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenReservation))
            {
                body["openReservation"] = request.OpenReservation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservationAuthority))
            {
                body["reservationAuthority"] = request.ReservationAuthority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomDescription))
            {
                body["roomDescription"] = request.RoomDescription;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议室信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMeetingRoomResponse
        /// </returns>
        public UpdateMeetingRoomResponse UpdateMeetingRoom(UpdateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomHeaders headers = new UpdateMeetingRoomHeaders();
            return UpdateMeetingRoomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议室信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMeetingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMeetingRoomResponse
        /// </returns>
        public async Task<UpdateMeetingRoomResponse> UpdateMeetingRoomAsync(UpdateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomHeaders headers = new UpdateMeetingRoomHeaders();
            return await UpdateMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMeetingRoomGroupRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMeetingRoomGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMeetingRoomGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMeetingRoomGroupRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMeetingRoomGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMeetingRoomGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMeetingRoomGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMeetingRoomGroupResponse
        /// </returns>
        public UpdateMeetingRoomGroupResponse UpdateMeetingRoomGroup(UpdateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomGroupHeaders headers = new UpdateMeetingRoomGroupHeaders();
            return UpdateMeetingRoomGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议室分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMeetingRoomGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMeetingRoomGroupResponse
        /// </returns>
        public async Task<UpdateMeetingRoomGroupResponse> UpdateMeetingRoomGroupAsync(UpdateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomGroupHeaders headers = new UpdateMeetingRoomGroupHeaders();
            return await UpdateMeetingRoomGroupWithOptionsAsync(request, headers, runtime);
        }

    }
}
