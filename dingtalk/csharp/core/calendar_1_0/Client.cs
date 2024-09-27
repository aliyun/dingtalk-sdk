// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
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
        /// <para>新增日程参与人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddAttendeeRequest
        /// </param>
        /// <param name="headers">
        /// AddAttendeeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAttendeeResponse
        /// </returns>
        public AddAttendeeResponse AddAttendeeWithOptions(string userId, string calendarId, string eventId, AddAttendeeRequest request, AddAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesToAdd))
            {
                body["attendeesToAdd"] = request.AttendeesToAdd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatNotification))
            {
                body["chatNotification"] = request.ChatNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushNotification))
            {
                body["pushNotification"] = request.PushNotification;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "AddAttendee",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddAttendeeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增日程参与人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddAttendeeRequest
        /// </param>
        /// <param name="headers">
        /// AddAttendeeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAttendeeResponse
        /// </returns>
        public async Task<AddAttendeeResponse> AddAttendeeWithOptionsAsync(string userId, string calendarId, string eventId, AddAttendeeRequest request, AddAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesToAdd))
            {
                body["attendeesToAdd"] = request.AttendeesToAdd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatNotification))
            {
                body["chatNotification"] = request.ChatNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushNotification))
            {
                body["pushNotification"] = request.PushNotification;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "AddAttendee",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddAttendeeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增日程参与人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddAttendeeRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAttendeeResponse
        /// </returns>
        public AddAttendeeResponse AddAttendee(string userId, string calendarId, string eventId, AddAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeHeaders headers = new AddAttendeeHeaders();
            return AddAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增日程参与人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddAttendeeRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAttendeeResponse
        /// </returns>
        public async Task<AddAttendeeResponse> AddAttendeeAsync(string userId, string calendarId, string eventId, AddAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeHeaders headers = new AddAttendeeHeaders();
            return await AddAttendeeWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMeetingRoomsRequest
        /// </param>
        /// <param name="headers">
        /// AddMeetingRoomsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMeetingRoomsResponse
        /// </returns>
        public AddMeetingRoomsResponse AddMeetingRoomsWithOptions(string userId, string calendarId, string eventId, AddMeetingRoomsRequest request, AddMeetingRoomsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingRoomsToAdd))
            {
                body["meetingRoomsToAdd"] = request.MeetingRoomsToAdd;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "AddMeetingRooms",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/meetingRooms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMeetingRoomsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMeetingRoomsRequest
        /// </param>
        /// <param name="headers">
        /// AddMeetingRoomsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMeetingRoomsResponse
        /// </returns>
        public async Task<AddMeetingRoomsResponse> AddMeetingRoomsWithOptionsAsync(string userId, string calendarId, string eventId, AddMeetingRoomsRequest request, AddMeetingRoomsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingRoomsToAdd))
            {
                body["meetingRoomsToAdd"] = request.MeetingRoomsToAdd;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "AddMeetingRooms",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/meetingRooms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMeetingRoomsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMeetingRoomsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMeetingRoomsResponse
        /// </returns>
        public AddMeetingRoomsResponse AddMeetingRooms(string userId, string calendarId, string eventId, AddMeetingRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMeetingRoomsHeaders headers = new AddMeetingRoomsHeaders();
            return AddMeetingRoomsWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMeetingRoomsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMeetingRoomsResponse
        /// </returns>
        public async Task<AddMeetingRoomsResponse> AddMeetingRoomsAsync(string userId, string calendarId, string eventId, AddMeetingRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMeetingRoomsHeaders headers = new AddMeetingRoomsHeaders();
            return await AddMeetingRoomsWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签到</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CheckInHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckInResponse
        /// </returns>
        public CheckInResponse CheckInWithOptions(string userId, string calendarId, string eventId, CheckInHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CheckIn",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/checkIn",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签到</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CheckInHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckInResponse
        /// </returns>
        public async Task<CheckInResponse> CheckInWithOptionsAsync(string userId, string calendarId, string eventId, CheckInHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CheckIn",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/checkIn",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签到</para>
        /// </summary>
        /// 
        /// <returns>
        /// CheckInResponse
        /// </returns>
        public CheckInResponse CheckIn(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckInHeaders headers = new CheckInHeaders();
            return CheckInWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签到</para>
        /// </summary>
        /// 
        /// <returns>
        /// CheckInResponse
        /// </returns>
        public async Task<CheckInResponse> CheckInAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckInHeaders headers = new CheckInHeaders();
            return await CheckInWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转换老版本的eventId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertLegacyEventIdRequest
        /// </param>
        /// <param name="headers">
        /// ConvertLegacyEventIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertLegacyEventIdResponse
        /// </returns>
        public ConvertLegacyEventIdResponse ConvertLegacyEventIdWithOptions(string userId, ConvertLegacyEventIdRequest request, ConvertLegacyEventIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegacyEventIds))
            {
                body["legacyEventIds"] = request.LegacyEventIds;
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
                Action = "ConvertLegacyEventId",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/legacyEventIds/convert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertLegacyEventIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转换老版本的eventId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertLegacyEventIdRequest
        /// </param>
        /// <param name="headers">
        /// ConvertLegacyEventIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertLegacyEventIdResponse
        /// </returns>
        public async Task<ConvertLegacyEventIdResponse> ConvertLegacyEventIdWithOptionsAsync(string userId, ConvertLegacyEventIdRequest request, ConvertLegacyEventIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegacyEventIds))
            {
                body["legacyEventIds"] = request.LegacyEventIds;
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
                Action = "ConvertLegacyEventId",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/legacyEventIds/convert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertLegacyEventIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转换老版本的eventId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertLegacyEventIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertLegacyEventIdResponse
        /// </returns>
        public ConvertLegacyEventIdResponse ConvertLegacyEventId(string userId, ConvertLegacyEventIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConvertLegacyEventIdHeaders headers = new ConvertLegacyEventIdHeaders();
            return ConvertLegacyEventIdWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转换老版本的eventId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertLegacyEventIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertLegacyEventIdResponse
        /// </returns>
        public async Task<ConvertLegacyEventIdResponse> ConvertLegacyEventIdAsync(string userId, ConvertLegacyEventIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConvertLegacyEventIdHeaders headers = new ConvertLegacyEventIdHeaders();
            return await ConvertLegacyEventIdWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建访问控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAclsRequest
        /// </param>
        /// <param name="headers">
        /// CreateAclsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAclsResponse
        /// </returns>
        public CreateAclsResponse CreateAclsWithOptions(string userId, string calendarId, CreateAclsRequest request, CreateAclsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Privilege))
            {
                body["privilege"] = request.Privilege;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMsg))
            {
                body["sendMsg"] = request.SendMsg;
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
                Action = "CreateAcls",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建访问控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAclsRequest
        /// </param>
        /// <param name="headers">
        /// CreateAclsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAclsResponse
        /// </returns>
        public async Task<CreateAclsResponse> CreateAclsWithOptionsAsync(string userId, string calendarId, CreateAclsRequest request, CreateAclsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Privilege))
            {
                body["privilege"] = request.Privilege;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMsg))
            {
                body["sendMsg"] = request.SendMsg;
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
                Action = "CreateAcls",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建访问控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAclsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAclsResponse
        /// </returns>
        public CreateAclsResponse CreateAcls(string userId, string calendarId, CreateAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAclsHeaders headers = new CreateAclsHeaders();
            return CreateAclsWithOptions(userId, calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建访问控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAclsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAclsResponse
        /// </returns>
        public async Task<CreateAclsResponse> CreateAclsAsync(string userId, string calendarId, CreateAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAclsHeaders headers = new CreateAclsHeaders();
            return await CreateAclsWithOptionsAsync(userId, calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEventRequest
        /// </param>
        /// <param name="headers">
        /// CreateEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventResponse
        /// </returns>
        public CreateEventResponse CreateEventWithOptions(string userId, string calendarId, CreateEventRequest request, CreateEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardInstances))
            {
                body["cardInstances"] = request.CardInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["isAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfo))
            {
                body["onlineMeetingInfo"] = request.OnlineMeetingInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichTextDescription))
            {
                body["richTextDescription"] = request.RichTextDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UiConfigs))
            {
                body["uiConfigs"] = request.UiConfigs;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "CreateEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEventRequest
        /// </param>
        /// <param name="headers">
        /// CreateEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventResponse
        /// </returns>
        public async Task<CreateEventResponse> CreateEventWithOptionsAsync(string userId, string calendarId, CreateEventRequest request, CreateEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardInstances))
            {
                body["cardInstances"] = request.CardInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["isAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfo))
            {
                body["onlineMeetingInfo"] = request.OnlineMeetingInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichTextDescription))
            {
                body["richTextDescription"] = request.RichTextDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UiConfigs))
            {
                body["uiConfigs"] = request.UiConfigs;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "CreateEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEventRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventResponse
        /// </returns>
        public CreateEventResponse CreateEvent(string userId, string calendarId, CreateEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventHeaders headers = new CreateEventHeaders();
            return CreateEventWithOptions(userId, calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEventRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventResponse
        /// </returns>
        public async Task<CreateEventResponse> CreateEventAsync(string userId, string calendarId, CreateEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventHeaders headers = new CreateEventHeaders();
            return await CreateEventWithOptionsAsync(userId, calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建日程(me接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEventByMeRequest
        /// </param>
        /// <param name="headers">
        /// CreateEventByMeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventByMeResponse
        /// </returns>
        public CreateEventByMeResponse CreateEventByMeWithOptions(string calendarId, CreateEventByMeRequest request, CreateEventByMeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["isAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfo))
            {
                body["onlineMeetingInfo"] = request.OnlineMeetingInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichTextDescription))
            {
                body["richTextDescription"] = request.RichTextDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UiConfigs))
            {
                body["uiConfigs"] = request.UiConfigs;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "CreateEventByMe",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/me/calendars/" + calendarId + "/events",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventByMeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建日程(me接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEventByMeRequest
        /// </param>
        /// <param name="headers">
        /// CreateEventByMeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventByMeResponse
        /// </returns>
        public async Task<CreateEventByMeResponse> CreateEventByMeWithOptionsAsync(string calendarId, CreateEventByMeRequest request, CreateEventByMeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["isAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfo))
            {
                body["onlineMeetingInfo"] = request.OnlineMeetingInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichTextDescription))
            {
                body["richTextDescription"] = request.RichTextDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UiConfigs))
            {
                body["uiConfigs"] = request.UiConfigs;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "CreateEventByMe",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/me/calendars/" + calendarId + "/events",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventByMeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建日程(me接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEventByMeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventByMeResponse
        /// </returns>
        public CreateEventByMeResponse CreateEventByMe(string calendarId, CreateEventByMeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventByMeHeaders headers = new CreateEventByMeHeaders();
            return CreateEventByMeWithOptions(calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建日程(me接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEventByMeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventByMeResponse
        /// </returns>
        public async Task<CreateEventByMeResponse> CreateEventByMeAsync(string calendarId, CreateEventByMeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventByMeHeaders headers = new CreateEventByMeHeaders();
            return await CreateEventByMeWithOptionsAsync(calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>快速创建订阅日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSubscribedCalendarRequest
        /// </param>
        /// <param name="headers">
        /// CreateSubscribedCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSubscribedCalendarResponse
        /// </returns>
        public CreateSubscribedCalendarResponse CreateSubscribedCalendarWithOptions(string userId, CreateSubscribedCalendarRequest request, CreateSubscribedCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Managers))
            {
                body["managers"] = request.Managers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeScope))
            {
                body["subscribeScope"] = request.SubscribeScope;
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
                Action = "CreateSubscribedCalendar",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/subscribedCalendars",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubscribedCalendarResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>快速创建订阅日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSubscribedCalendarRequest
        /// </param>
        /// <param name="headers">
        /// CreateSubscribedCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSubscribedCalendarResponse
        /// </returns>
        public async Task<CreateSubscribedCalendarResponse> CreateSubscribedCalendarWithOptionsAsync(string userId, CreateSubscribedCalendarRequest request, CreateSubscribedCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Managers))
            {
                body["managers"] = request.Managers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeScope))
            {
                body["subscribeScope"] = request.SubscribeScope;
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
                Action = "CreateSubscribedCalendar",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/subscribedCalendars",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubscribedCalendarResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>快速创建订阅日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSubscribedCalendarRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSubscribedCalendarResponse
        /// </returns>
        public CreateSubscribedCalendarResponse CreateSubscribedCalendar(string userId, CreateSubscribedCalendarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSubscribedCalendarHeaders headers = new CreateSubscribedCalendarHeaders();
            return CreateSubscribedCalendarWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>快速创建订阅日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSubscribedCalendarRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSubscribedCalendarResponse
        /// </returns>
        public async Task<CreateSubscribedCalendarResponse> CreateSubscribedCalendarAsync(string userId, CreateSubscribedCalendarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSubscribedCalendarHeaders headers = new CreateSubscribedCalendarHeaders();
            return await CreateSubscribedCalendarWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除访问控制</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteAclHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public DeleteAclResponse DeleteAclWithOptions(string userId, string calendarId, string aclId, DeleteAclHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAcl",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls/" + aclId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAclResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除访问控制</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteAclHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public async Task<DeleteAclResponse> DeleteAclWithOptionsAsync(string userId, string calendarId, string aclId, DeleteAclHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAcl",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls/" + aclId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAclResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除访问控制</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public DeleteAclResponse DeleteAcl(string userId, string calendarId, string aclId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAclHeaders headers = new DeleteAclHeaders();
            return DeleteAclWithOptions(userId, calendarId, aclId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除访问控制</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public async Task<DeleteAclResponse> DeleteAclAsync(string userId, string calendarId, string aclId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAclHeaders headers = new DeleteAclHeaders();
            return await DeleteAclWithOptionsAsync(userId, calendarId, aclId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventRequest
        /// </param>
        /// <param name="headers">
        /// DeleteEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventResponse
        /// </returns>
        public DeleteEventResponse DeleteEventWithOptions(string userId, string calendarId, string eventId, DeleteEventRequest request, DeleteEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushNotification))
            {
                query["pushNotification"] = request.PushNotification;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "DeleteEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventRequest
        /// </param>
        /// <param name="headers">
        /// DeleteEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventResponse
        /// </returns>
        public async Task<DeleteEventResponse> DeleteEventWithOptionsAsync(string userId, string calendarId, string eventId, DeleteEventRequest request, DeleteEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushNotification))
            {
                query["pushNotification"] = request.PushNotification;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "DeleteEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventResponse
        /// </returns>
        public DeleteEventResponse DeleteEvent(string userId, string calendarId, string eventId, DeleteEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEventHeaders headers = new DeleteEventHeaders();
            return DeleteEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventResponse
        /// </returns>
        public async Task<DeleteEventResponse> DeleteEventAsync(string userId, string calendarId, string eventId, DeleteEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEventHeaders headers = new DeleteEventHeaders();
            return await DeleteEventWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定订阅日历</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteSubscribedCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubscribedCalendarResponse
        /// </returns>
        public DeleteSubscribedCalendarResponse DeleteSubscribedCalendarWithOptions(string userId, string calendarId, DeleteSubscribedCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSubscribedCalendar",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubscribedCalendarResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定订阅日历</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteSubscribedCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubscribedCalendarResponse
        /// </returns>
        public async Task<DeleteSubscribedCalendarResponse> DeleteSubscribedCalendarWithOptionsAsync(string userId, string calendarId, DeleteSubscribedCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSubscribedCalendar",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubscribedCalendarResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定订阅日历</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSubscribedCalendarResponse
        /// </returns>
        public DeleteSubscribedCalendarResponse DeleteSubscribedCalendar(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSubscribedCalendarHeaders headers = new DeleteSubscribedCalendarHeaders();
            return DeleteSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定订阅日历</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSubscribedCalendarResponse
        /// </returns>
        public async Task<DeleteSubscribedCalendarResponse> DeleteSubscribedCalendarAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSubscribedCalendarHeaders headers = new DeleteSubscribedCalendarHeaders();
            return await DeleteSubscribedCalendarWithOptionsAsync(userId, calendarId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成caldav账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCaldavAccountRequest
        /// </param>
        /// <param name="headers">
        /// GenerateCaldavAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCaldavAccountResponse
        /// </returns>
        public GenerateCaldavAccountResponse GenerateCaldavAccountWithOptions(string userId, GenerateCaldavAccountRequest request, GenerateCaldavAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Device))
            {
                body["device"] = request.Device;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingUid);
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
                Action = "GenerateCaldavAccount",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/caldavAccounts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCaldavAccountResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成caldav账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCaldavAccountRequest
        /// </param>
        /// <param name="headers">
        /// GenerateCaldavAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCaldavAccountResponse
        /// </returns>
        public async Task<GenerateCaldavAccountResponse> GenerateCaldavAccountWithOptionsAsync(string userId, GenerateCaldavAccountRequest request, GenerateCaldavAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Device))
            {
                body["device"] = request.Device;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingUid);
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
                Action = "GenerateCaldavAccount",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/caldavAccounts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCaldavAccountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成caldav账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCaldavAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCaldavAccountResponse
        /// </returns>
        public GenerateCaldavAccountResponse GenerateCaldavAccount(string userId, GenerateCaldavAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateCaldavAccountHeaders headers = new GenerateCaldavAccountHeaders();
            return GenerateCaldavAccountWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成caldav账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCaldavAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCaldavAccountResponse
        /// </returns>
        public async Task<GenerateCaldavAccountResponse> GenerateCaldavAccountAsync(string userId, GenerateCaldavAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateCaldavAccountHeaders headers = new GenerateCaldavAccountHeaders();
            return await GenerateCaldavAccountWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventRequest
        /// </param>
        /// <param name="headers">
        /// GetEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventResponse
        /// </returns>
        public GetEventResponse GetEventWithOptions(string userId, string calendarId, string eventId, GetEventRequest request, GetEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
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
                Action = "GetEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventRequest
        /// </param>
        /// <param name="headers">
        /// GetEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventResponse
        /// </returns>
        public async Task<GetEventResponse> GetEventWithOptionsAsync(string userId, string calendarId, string eventId, GetEventRequest request, GetEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
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
                Action = "GetEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventResponse
        /// </returns>
        public GetEventResponse GetEvent(string userId, string calendarId, string eventId, GetEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventHeaders headers = new GetEventHeaders();
            return GetEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventResponse
        /// </returns>
        public async Task<GetEventResponse> GetEventAsync(string userId, string calendarId, string eventId, GetEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventHeaders headers = new GetEventHeaders();
            return await GetEventWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室忙闲</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMeetingRoomsScheduleRequest
        /// </param>
        /// <param name="headers">
        /// GetMeetingRoomsScheduleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMeetingRoomsScheduleResponse
        /// </returns>
        public GetMeetingRoomsScheduleResponse GetMeetingRoomsScheduleWithOptions(string userId, GetMeetingRoomsScheduleRequest request, GetMeetingRoomsScheduleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomIds))
            {
                body["roomIds"] = request.RoomIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "GetMeetingRoomsSchedule",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/meetingRooms/schedules/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMeetingRoomsScheduleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室忙闲</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMeetingRoomsScheduleRequest
        /// </param>
        /// <param name="headers">
        /// GetMeetingRoomsScheduleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMeetingRoomsScheduleResponse
        /// </returns>
        public async Task<GetMeetingRoomsScheduleResponse> GetMeetingRoomsScheduleWithOptionsAsync(string userId, GetMeetingRoomsScheduleRequest request, GetMeetingRoomsScheduleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomIds))
            {
                body["roomIds"] = request.RoomIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "GetMeetingRoomsSchedule",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/meetingRooms/schedules/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMeetingRoomsScheduleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室忙闲</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMeetingRoomsScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMeetingRoomsScheduleResponse
        /// </returns>
        public GetMeetingRoomsScheduleResponse GetMeetingRoomsSchedule(string userId, GetMeetingRoomsScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMeetingRoomsScheduleHeaders headers = new GetMeetingRoomsScheduleHeaders();
            return GetMeetingRoomsScheduleWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议室忙闲</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMeetingRoomsScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMeetingRoomsScheduleResponse
        /// </returns>
        public async Task<GetMeetingRoomsScheduleResponse> GetMeetingRoomsScheduleAsync(string userId, GetMeetingRoomsScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMeetingRoomsScheduleHeaders headers = new GetMeetingRoomsScheduleHeaders();
            return await GetMeetingRoomsScheduleWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闲忙</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduleRequest
        /// </param>
        /// <param name="headers">
        /// GetScheduleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleResponse
        /// </returns>
        public GetScheduleResponse GetScheduleWithOptions(string userId, GetScheduleRequest request, GetScheduleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "GetSchedule",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/querySchedule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闲忙</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduleRequest
        /// </param>
        /// <param name="headers">
        /// GetScheduleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleResponse
        /// </returns>
        public async Task<GetScheduleResponse> GetScheduleWithOptionsAsync(string userId, GetScheduleRequest request, GetScheduleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "GetSchedule",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/querySchedule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闲忙</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleResponse
        /// </returns>
        public GetScheduleResponse GetSchedule(string userId, GetScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetScheduleHeaders headers = new GetScheduleHeaders();
            return GetScheduleWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闲忙</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleResponse
        /// </returns>
        public async Task<GetScheduleResponse> GetScheduleAsync(string userId, GetScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetScheduleHeaders headers = new GetScheduleHeaders();
            return await GetScheduleWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闲忙(me接口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduleByMeRequest
        /// </param>
        /// <param name="headers">
        /// GetScheduleByMeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleByMeResponse
        /// </returns>
        public GetScheduleByMeResponse GetScheduleByMeWithOptions(GetScheduleByMeRequest request, GetScheduleByMeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "GetScheduleByMe",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/me/schedules/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduleByMeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闲忙(me接口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduleByMeRequest
        /// </param>
        /// <param name="headers">
        /// GetScheduleByMeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleByMeResponse
        /// </returns>
        public async Task<GetScheduleByMeResponse> GetScheduleByMeWithOptionsAsync(GetScheduleByMeRequest request, GetScheduleByMeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "GetScheduleByMe",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/me/schedules/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduleByMeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闲忙(me接口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduleByMeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleByMeResponse
        /// </returns>
        public GetScheduleByMeResponse GetScheduleByMe(GetScheduleByMeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetScheduleByMeHeaders headers = new GetScheduleByMeHeaders();
            return GetScheduleByMeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闲忙(me接口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduleByMeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleByMeResponse
        /// </returns>
        public async Task<GetScheduleByMeResponse> GetScheduleByMeAsync(GetScheduleByMeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetScheduleByMeHeaders headers = new GetScheduleByMeHeaders();
            return await GetScheduleByMeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签到链接</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSignInLinkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignInLinkResponse
        /// </returns>
        public GetSignInLinkResponse GetSignInLinkWithOptions(string calendarId, string userId, string eventId, GetSignInLinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSignInLink",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signInLinks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignInLinkResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签到链接</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSignInLinkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignInLinkResponse
        /// </returns>
        public async Task<GetSignInLinkResponse> GetSignInLinkWithOptionsAsync(string calendarId, string userId, string eventId, GetSignInLinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSignInLink",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signInLinks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignInLinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签到链接</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSignInLinkResponse
        /// </returns>
        public GetSignInLinkResponse GetSignInLink(string calendarId, string userId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignInLinkHeaders headers = new GetSignInLinkHeaders();
            return GetSignInLinkWithOptions(calendarId, userId, eventId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签到链接</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSignInLinkResponse
        /// </returns>
        public async Task<GetSignInLinkResponse> GetSignInLinkAsync(string calendarId, string userId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignInLinkHeaders headers = new GetSignInLinkHeaders();
            return await GetSignInLinkWithOptionsAsync(calendarId, userId, eventId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签到信息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignInListRequest
        /// </param>
        /// <param name="headers">
        /// GetSignInListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignInListResponse
        /// </returns>
        public GetSignInListResponse GetSignInListWithOptions(string userId, string calendarId, string eventId, GetSignInListRequest request, GetSignInListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "GetSignInList",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signin",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignInListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签到信息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignInListRequest
        /// </param>
        /// <param name="headers">
        /// GetSignInListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignInListResponse
        /// </returns>
        public async Task<GetSignInListResponse> GetSignInListWithOptionsAsync(string userId, string calendarId, string eventId, GetSignInListRequest request, GetSignInListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "GetSignInList",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signin",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignInListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签到信息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignInListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSignInListResponse
        /// </returns>
        public GetSignInListResponse GetSignInList(string userId, string calendarId, string eventId, GetSignInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignInListHeaders headers = new GetSignInListHeaders();
            return GetSignInListWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签到信息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignInListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSignInListResponse
        /// </returns>
        public async Task<GetSignInListResponse> GetSignInListAsync(string userId, string calendarId, string eventId, GetSignInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignInListHeaders headers = new GetSignInListHeaders();
            return await GetSignInListWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签退链接</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSignOutLinkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignOutLinkResponse
        /// </returns>
        public GetSignOutLinkResponse GetSignOutLinkWithOptions(string calendarId, string userId, string eventId, GetSignOutLinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSignOutLink",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signOutLinks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignOutLinkResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签退链接</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSignOutLinkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignOutLinkResponse
        /// </returns>
        public async Task<GetSignOutLinkResponse> GetSignOutLinkWithOptionsAsync(string calendarId, string userId, string eventId, GetSignOutLinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSignOutLink",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signOutLinks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignOutLinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签退链接</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSignOutLinkResponse
        /// </returns>
        public GetSignOutLinkResponse GetSignOutLink(string calendarId, string userId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignOutLinkHeaders headers = new GetSignOutLinkHeaders();
            return GetSignOutLinkWithOptions(calendarId, userId, eventId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签退链接</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSignOutLinkResponse
        /// </returns>
        public async Task<GetSignOutLinkResponse> GetSignOutLinkAsync(string calendarId, string userId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignOutLinkHeaders headers = new GetSignOutLinkHeaders();
            return await GetSignOutLinkWithOptionsAsync(calendarId, userId, eventId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签退信息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignOutListRequest
        /// </param>
        /// <param name="headers">
        /// GetSignOutListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignOutListResponse
        /// </returns>
        public GetSignOutListResponse GetSignOutListWithOptions(string userId, string calendarId, string eventId, GetSignOutListRequest request, GetSignOutListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "GetSignOutList",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signOut",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignOutListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签退信息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignOutListRequest
        /// </param>
        /// <param name="headers">
        /// GetSignOutListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignOutListResponse
        /// </returns>
        public async Task<GetSignOutListResponse> GetSignOutListWithOptionsAsync(string userId, string calendarId, string eventId, GetSignOutListRequest request, GetSignOutListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "GetSignOutList",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signOut",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignOutListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签退信息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignOutListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSignOutListResponse
        /// </returns>
        public GetSignOutListResponse GetSignOutList(string userId, string calendarId, string eventId, GetSignOutListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignOutListHeaders headers = new GetSignOutListHeaders();
            return GetSignOutListWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签退信息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignOutListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSignOutListResponse
        /// </returns>
        public async Task<GetSignOutListResponse> GetSignOutListAsync(string userId, string calendarId, string eventId, GetSignOutListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignOutListHeaders headers = new GetSignOutListHeaders();
            return await GetSignOutListWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定订阅日历详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSubscribedCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubscribedCalendarResponse
        /// </returns>
        public GetSubscribedCalendarResponse GetSubscribedCalendarWithOptions(string userId, string calendarId, GetSubscribedCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSubscribedCalendar",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscribedCalendarResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定订阅日历详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSubscribedCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubscribedCalendarResponse
        /// </returns>
        public async Task<GetSubscribedCalendarResponse> GetSubscribedCalendarWithOptionsAsync(string userId, string calendarId, GetSubscribedCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSubscribedCalendar",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscribedCalendarResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定订阅日历详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSubscribedCalendarResponse
        /// </returns>
        public GetSubscribedCalendarResponse GetSubscribedCalendar(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSubscribedCalendarHeaders headers = new GetSubscribedCalendarHeaders();
            return GetSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定订阅日历详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSubscribedCalendarResponse
        /// </returns>
        public async Task<GetSubscribedCalendarResponse> GetSubscribedCalendarAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSubscribedCalendarHeaders headers = new GetSubscribedCalendarHeaders();
            return await GetSubscribedCalendarWithOptionsAsync(userId, calendarId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取访问控制列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListAclsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAclsResponse
        /// </returns>
        public ListAclsResponse ListAclsWithOptions(string userId, string calendarId, ListAclsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAcls",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取访问控制列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListAclsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAclsResponse
        /// </returns>
        public async Task<ListAclsResponse> ListAclsWithOptionsAsync(string userId, string calendarId, ListAclsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAcls",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取访问控制列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAclsResponse
        /// </returns>
        public ListAclsResponse ListAcls(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAclsHeaders headers = new ListAclsHeaders();
            return ListAclsWithOptions(userId, calendarId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取访问控制列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAclsResponse
        /// </returns>
        public async Task<ListAclsResponse> ListAclsAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAclsHeaders headers = new ListAclsHeaders();
            return await ListAclsWithOptionsAsync(userId, calendarId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取参与人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttendeesRequest
        /// </param>
        /// <param name="headers">
        /// ListAttendeesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAttendeesResponse
        /// </returns>
        public ListAttendeesResponse ListAttendeesWithOptions(string userId, string calendarId, string eventId, ListAttendeesRequest request, ListAttendeesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAttendees",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAttendeesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取参与人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttendeesRequest
        /// </param>
        /// <param name="headers">
        /// ListAttendeesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAttendeesResponse
        /// </returns>
        public async Task<ListAttendeesResponse> ListAttendeesWithOptionsAsync(string userId, string calendarId, string eventId, ListAttendeesRequest request, ListAttendeesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAttendees",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAttendeesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取参与人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttendeesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAttendeesResponse
        /// </returns>
        public ListAttendeesResponse ListAttendees(string userId, string calendarId, string eventId, ListAttendeesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAttendeesHeaders headers = new ListAttendeesHeaders();
            return ListAttendeesWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取参与人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttendeesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAttendeesResponse
        /// </returns>
        public async Task<ListAttendeesResponse> ListAttendeesAsync(string userId, string calendarId, string eventId, ListAttendeesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAttendeesHeaders headers = new ListAttendeesHeaders();
            return await ListAttendeesWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日历本查询</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListCalendarsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCalendarsResponse
        /// </returns>
        public ListCalendarsResponse ListCalendarsWithOptions(string userId, ListCalendarsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListCalendars",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCalendarsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日历本查询</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListCalendarsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCalendarsResponse
        /// </returns>
        public async Task<ListCalendarsResponse> ListCalendarsWithOptionsAsync(string userId, ListCalendarsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListCalendars",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCalendarsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日历本查询</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListCalendarsResponse
        /// </returns>
        public ListCalendarsResponse ListCalendars(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCalendarsHeaders headers = new ListCalendarsHeaders();
            return ListCalendarsWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日历本查询</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListCalendarsResponse
        /// </returns>
        public async Task<ListCalendarsResponse> ListCalendarsAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCalendarsHeaders headers = new ListCalendarsHeaders();
            return await ListCalendarsWithOptionsAsync(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsRequest
        /// </param>
        /// <param name="headers">
        /// ListEventsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventsResponse
        /// </returns>
        public ListEventsResponse ListEventsWithOptions(string userId, string calendarId, ListEventsRequest request, ListEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeriesMasterId))
            {
                query["seriesMasterId"] = request.SeriesMasterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDeleted))
            {
                query["showDeleted"] = request.ShowDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToken))
            {
                query["syncToken"] = request.SyncToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                query["timeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                query["timeMin"] = request.TimeMin;
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
                Action = "ListEvents",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsRequest
        /// </param>
        /// <param name="headers">
        /// ListEventsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventsResponse
        /// </returns>
        public async Task<ListEventsResponse> ListEventsWithOptionsAsync(string userId, string calendarId, ListEventsRequest request, ListEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeriesMasterId))
            {
                query["seriesMasterId"] = request.SeriesMasterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDeleted))
            {
                query["showDeleted"] = request.ShowDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToken))
            {
                query["syncToken"] = request.SyncToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                query["timeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                query["timeMin"] = request.TimeMin;
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
                Action = "ListEvents",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventsResponse
        /// </returns>
        public ListEventsResponse ListEvents(string userId, string calendarId, ListEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsHeaders headers = new ListEventsHeaders();
            return ListEventsWithOptions(userId, calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventsResponse
        /// </returns>
        public async Task<ListEventsResponse> ListEventsAsync(string userId, string calendarId, ListEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsHeaders headers = new ListEventsHeaders();
            return await ListEventsWithOptionsAsync(userId, calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同一个循环日程序列下已生成的实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsInstancesRequest
        /// </param>
        /// <param name="headers">
        /// ListEventsInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventsInstancesResponse
        /// </returns>
        public ListEventsInstancesResponse ListEventsInstancesWithOptions(string userId, string calendarId, ListEventsInstancesRequest request, ListEventsInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeriesMasterId))
            {
                query["seriesMasterId"] = request.SeriesMasterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRecurrenceId))
            {
                query["startRecurrenceId"] = request.StartRecurrenceId;
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
                Action = "ListEventsInstances",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventsInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同一个循环日程序列下已生成的实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsInstancesRequest
        /// </param>
        /// <param name="headers">
        /// ListEventsInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventsInstancesResponse
        /// </returns>
        public async Task<ListEventsInstancesResponse> ListEventsInstancesWithOptionsAsync(string userId, string calendarId, ListEventsInstancesRequest request, ListEventsInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeriesMasterId))
            {
                query["seriesMasterId"] = request.SeriesMasterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRecurrenceId))
            {
                query["startRecurrenceId"] = request.StartRecurrenceId;
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
                Action = "ListEventsInstances",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventsInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同一个循环日程序列下已生成的实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventsInstancesResponse
        /// </returns>
        public ListEventsInstancesResponse ListEventsInstances(string userId, string calendarId, ListEventsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsInstancesHeaders headers = new ListEventsInstancesHeaders();
            return ListEventsInstancesWithOptions(userId, calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同一个循环日程序列下已生成的实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventsInstancesResponse
        /// </returns>
        public async Task<ListEventsInstancesResponse> ListEventsInstancesAsync(string userId, string calendarId, ListEventsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsInstancesHeaders headers = new ListEventsInstancesHeaders();
            return await ListEventsInstancesWithOptionsAsync(userId, calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程视图列表以查看闲忙，展开循环日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsViewRequest
        /// </param>
        /// <param name="headers">
        /// ListEventsViewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventsViewResponse
        /// </returns>
        public ListEventsViewResponse ListEventsViewWithOptions(string userId, string calendarId, ListEventsViewRequest request, ListEventsViewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                query["timeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                query["timeMin"] = request.TimeMin;
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
                Action = "ListEventsView",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/eventsview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventsViewResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程视图列表以查看闲忙，展开循环日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsViewRequest
        /// </param>
        /// <param name="headers">
        /// ListEventsViewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventsViewResponse
        /// </returns>
        public async Task<ListEventsViewResponse> ListEventsViewWithOptionsAsync(string userId, string calendarId, ListEventsViewRequest request, ListEventsViewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                query["timeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                query["timeMin"] = request.TimeMin;
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
                Action = "ListEventsView",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/eventsview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventsViewResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程视图列表以查看闲忙，展开循环日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsViewRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventsViewResponse
        /// </returns>
        public ListEventsViewResponse ListEventsView(string userId, string calendarId, ListEventsViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsViewHeaders headers = new ListEventsViewHeaders();
            return ListEventsViewWithOptions(userId, calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程视图列表以查看闲忙，展开循环日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsViewRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventsViewResponse
        /// </returns>
        public async Task<ListEventsViewResponse> ListEventsViewAsync(string userId, string calendarId, ListEventsViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsViewHeaders headers = new ListEventsViewHeaders();
            return await ListEventsViewWithOptionsAsync(userId, calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程视图列表以查看闲忙，展开循环日程(me接口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsViewByMeRequest
        /// </param>
        /// <param name="headers">
        /// ListEventsViewByMeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventsViewByMeResponse
        /// </returns>
        public ListEventsViewByMeResponse ListEventsViewByMeWithOptions(string calendarId, ListEventsViewByMeRequest request, ListEventsViewByMeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                query["timeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                query["timeMin"] = request.TimeMin;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "ListEventsViewByMe",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/me/calendars/" + calendarId + "/eventsview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventsViewByMeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程视图列表以查看闲忙，展开循环日程(me接口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsViewByMeRequest
        /// </param>
        /// <param name="headers">
        /// ListEventsViewByMeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventsViewByMeResponse
        /// </returns>
        public async Task<ListEventsViewByMeResponse> ListEventsViewByMeWithOptionsAsync(string calendarId, ListEventsViewByMeRequest request, ListEventsViewByMeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                query["timeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                query["timeMin"] = request.TimeMin;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "ListEventsViewByMe",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/me/calendars/" + calendarId + "/eventsview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventsViewByMeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程视图列表以查看闲忙，展开循环日程(me接口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsViewByMeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventsViewByMeResponse
        /// </returns>
        public ListEventsViewByMeResponse ListEventsViewByMe(string calendarId, ListEventsViewByMeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsViewByMeHeaders headers = new ListEventsViewByMeHeaders();
            return ListEventsViewByMeWithOptions(calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日程视图列表以查看闲忙，展开循环日程(me接口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventsViewByMeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventsViewByMeResponse
        /// </returns>
        public async Task<ListEventsViewByMeResponse> ListEventsViewByMeAsync(string calendarId, ListEventsViewByMeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsViewByMeHeaders headers = new ListEventsViewByMeHeaders();
            return await ListEventsViewByMeWithOptionsAsync(calendarId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询循环日程实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="headers">
        /// ListInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstancesWithOptions(string userId, string calendarId, string eventId, ListInstancesRequest request, ListInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                query["timeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                query["timeMin"] = request.TimeMin;
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
                Action = "ListInstances",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询循环日程实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="headers">
        /// ListInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(string userId, string calendarId, string eventId, ListInstancesRequest request, ListInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["maxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                query["timeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                query["timeMin"] = request.TimeMin;
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
                Action = "ListInstances",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询循环日程实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstances(string userId, string calendarId, string eventId, ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInstancesHeaders headers = new ListInstancesHeaders();
            return ListInstancesWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询循环日程实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesAsync(string userId, string calendarId, string eventId, ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInstancesHeaders headers = new ListInstancesHeaders();
            return await ListInstancesWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议室在日程中的响应状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MeetingRoomRespondRequest
        /// </param>
        /// <param name="headers">
        /// MeetingRoomRespondHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MeetingRoomRespondResponse
        /// </returns>
        public MeetingRoomRespondResponse MeetingRoomRespondWithOptions(string calendarId, string userId, string eventId, string roomId, MeetingRoomRespondRequest request, MeetingRoomRespondHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseStatus))
            {
                body["responseStatus"] = request.ResponseStatus;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.UserAgent))
            {
                realHeaders["userAgent"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.UserAgent);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "MeetingRoomRespond",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/meetingRooms/" + roomId + "/respond",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MeetingRoomRespondResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议室在日程中的响应状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MeetingRoomRespondRequest
        /// </param>
        /// <param name="headers">
        /// MeetingRoomRespondHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MeetingRoomRespondResponse
        /// </returns>
        public async Task<MeetingRoomRespondResponse> MeetingRoomRespondWithOptionsAsync(string calendarId, string userId, string eventId, string roomId, MeetingRoomRespondRequest request, MeetingRoomRespondHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseStatus))
            {
                body["responseStatus"] = request.ResponseStatus;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.UserAgent))
            {
                realHeaders["userAgent"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.UserAgent);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "MeetingRoomRespond",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/meetingRooms/" + roomId + "/respond",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MeetingRoomRespondResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议室在日程中的响应状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MeetingRoomRespondRequest
        /// </param>
        /// 
        /// <returns>
        /// MeetingRoomRespondResponse
        /// </returns>
        public MeetingRoomRespondResponse MeetingRoomRespond(string calendarId, string userId, string eventId, string roomId, MeetingRoomRespondRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MeetingRoomRespondHeaders headers = new MeetingRoomRespondHeaders();
            return MeetingRoomRespondWithOptions(calendarId, userId, eventId, roomId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议室在日程中的响应状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MeetingRoomRespondRequest
        /// </param>
        /// 
        /// <returns>
        /// MeetingRoomRespondResponse
        /// </returns>
        public async Task<MeetingRoomRespondResponse> MeetingRoomRespondAsync(string calendarId, string userId, string eventId, string roomId, MeetingRoomRespondRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MeetingRoomRespondHeaders headers = new MeetingRoomRespondHeaders();
            return await MeetingRoomRespondWithOptionsAsync(calendarId, userId, eventId, roomId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PatchEventRequest
        /// </param>
        /// <param name="headers">
        /// PatchEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PatchEventResponse
        /// </returns>
        public PatchEventResponse PatchEventWithOptions(string userId, string calendarId, string eventId, PatchEventRequest request, PatchEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardInstances))
            {
                body["cardInstances"] = request.CardInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["isAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfo))
            {
                body["onlineMeetingInfo"] = request.OnlineMeetingInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichTextDescription))
            {
                body["richTextDescription"] = request.RichTextDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UiConfigs))
            {
                body["uiConfigs"] = request.UiConfigs;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "PatchEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PatchEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PatchEventRequest
        /// </param>
        /// <param name="headers">
        /// PatchEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PatchEventResponse
        /// </returns>
        public async Task<PatchEventResponse> PatchEventWithOptionsAsync(string userId, string calendarId, string eventId, PatchEventRequest request, PatchEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardInstances))
            {
                body["cardInstances"] = request.CardInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["isAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfo))
            {
                body["onlineMeetingInfo"] = request.OnlineMeetingInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichTextDescription))
            {
                body["richTextDescription"] = request.RichTextDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UiConfigs))
            {
                body["uiConfigs"] = request.UiConfigs;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "PatchEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PatchEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PatchEventRequest
        /// </param>
        /// 
        /// <returns>
        /// PatchEventResponse
        /// </returns>
        public PatchEventResponse PatchEvent(string userId, string calendarId, string eventId, PatchEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchEventHeaders headers = new PatchEventHeaders();
            return PatchEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PatchEventRequest
        /// </param>
        /// 
        /// <returns>
        /// PatchEventResponse
        /// </returns>
        public async Task<PatchEventResponse> PatchEventAsync(string userId, string calendarId, string eventId, PatchEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchEventHeaders headers = new PatchEventHeaders();
            return await PatchEventWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除日程参与人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveAttendeeRequest
        /// </param>
        /// <param name="headers">
        /// RemoveAttendeeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveAttendeeResponse
        /// </returns>
        public RemoveAttendeeResponse RemoveAttendeeWithOptions(string userId, string calendarId, string eventId, RemoveAttendeeRequest request, RemoveAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesToRemove))
            {
                body["attendeesToRemove"] = request.AttendeesToRemove;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "RemoveAttendee",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveAttendeeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除日程参与人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveAttendeeRequest
        /// </param>
        /// <param name="headers">
        /// RemoveAttendeeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveAttendeeResponse
        /// </returns>
        public async Task<RemoveAttendeeResponse> RemoveAttendeeWithOptionsAsync(string userId, string calendarId, string eventId, RemoveAttendeeRequest request, RemoveAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesToRemove))
            {
                body["attendeesToRemove"] = request.AttendeesToRemove;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "RemoveAttendee",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveAttendeeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除日程参与人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveAttendeeRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveAttendeeResponse
        /// </returns>
        public RemoveAttendeeResponse RemoveAttendee(string userId, string calendarId, string eventId, RemoveAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
            return RemoveAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除日程参与人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveAttendeeRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveAttendeeResponse
        /// </returns>
        public async Task<RemoveAttendeeResponse> RemoveAttendeeAsync(string userId, string calendarId, string eventId, RemoveAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
            return await RemoveAttendeeWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveMeetingRoomsRequest
        /// </param>
        /// <param name="headers">
        /// RemoveMeetingRoomsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveMeetingRoomsResponse
        /// </returns>
        public RemoveMeetingRoomsResponse RemoveMeetingRoomsWithOptions(string userId, string calendarId, string eventId, RemoveMeetingRoomsRequest request, RemoveMeetingRoomsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingRoomsToRemove))
            {
                body["meetingRoomsToRemove"] = request.MeetingRoomsToRemove;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "RemoveMeetingRooms",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/meetingRooms/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMeetingRoomsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveMeetingRoomsRequest
        /// </param>
        /// <param name="headers">
        /// RemoveMeetingRoomsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveMeetingRoomsResponse
        /// </returns>
        public async Task<RemoveMeetingRoomsResponse> RemoveMeetingRoomsWithOptionsAsync(string userId, string calendarId, string eventId, RemoveMeetingRoomsRequest request, RemoveMeetingRoomsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingRoomsToRemove))
            {
                body["meetingRoomsToRemove"] = request.MeetingRoomsToRemove;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "RemoveMeetingRooms",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/meetingRooms/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMeetingRoomsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveMeetingRoomsRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveMeetingRoomsResponse
        /// </returns>
        public RemoveMeetingRoomsResponse RemoveMeetingRooms(string userId, string calendarId, string eventId, RemoveMeetingRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveMeetingRoomsHeaders headers = new RemoveMeetingRoomsHeaders();
            return RemoveMeetingRoomsWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会议室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveMeetingRoomsRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveMeetingRoomsResponse
        /// </returns>
        public async Task<RemoveMeetingRoomsResponse> RemoveMeetingRoomsAsync(string userId, string calendarId, string eventId, RemoveMeetingRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveMeetingRoomsHeaders headers = new RemoveMeetingRoomsHeaders();
            return await RemoveMeetingRoomsWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回复日程邀请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RespondEventRequest
        /// </param>
        /// <param name="headers">
        /// RespondEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RespondEventResponse
        /// </returns>
        public RespondEventResponse RespondEventWithOptions(string userId, string calendarId, string eventId, RespondEventRequest request, RespondEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseStatus))
            {
                body["responseStatus"] = request.ResponseStatus;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "RespondEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/respond",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<RespondEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回复日程邀请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RespondEventRequest
        /// </param>
        /// <param name="headers">
        /// RespondEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RespondEventResponse
        /// </returns>
        public async Task<RespondEventResponse> RespondEventWithOptionsAsync(string userId, string calendarId, string eventId, RespondEventRequest request, RespondEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseStatus))
            {
                body["responseStatus"] = request.ResponseStatus;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "RespondEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/respond",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<RespondEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回复日程邀请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RespondEventRequest
        /// </param>
        /// 
        /// <returns>
        /// RespondEventResponse
        /// </returns>
        public RespondEventResponse RespondEvent(string userId, string calendarId, string eventId, RespondEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RespondEventHeaders headers = new RespondEventHeaders();
            return RespondEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回复日程邀请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RespondEventRequest
        /// </param>
        /// 
        /// <returns>
        /// RespondEventResponse
        /// </returns>
        public async Task<RespondEventResponse> RespondEventAsync(string userId, string calendarId, string eventId, RespondEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RespondEventHeaders headers = new RespondEventHeaders();
            return await RespondEventWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签到</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// SignInHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignInResponse
        /// </returns>
        public SignInResponse SignInWithOptions(string userId, string calendarId, string eventId, SignInHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SignIn",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signin",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignInResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签到</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// SignInHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignInResponse
        /// </returns>
        public async Task<SignInResponse> SignInWithOptionsAsync(string userId, string calendarId, string eventId, SignInHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SignIn",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signin",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignInResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签到</para>
        /// </summary>
        /// 
        /// <returns>
        /// SignInResponse
        /// </returns>
        public SignInResponse SignIn(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignInHeaders headers = new SignInHeaders();
            return SignInWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签到</para>
        /// </summary>
        /// 
        /// <returns>
        /// SignInResponse
        /// </returns>
        public async Task<SignInResponse> SignInAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignInHeaders headers = new SignInHeaders();
            return await SignInWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签退</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// SignOutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignOutResponse
        /// </returns>
        public SignOutResponse SignOutWithOptions(string userId, string calendarId, string eventId, SignOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SignOut",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signOut",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignOutResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签退</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// SignOutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignOutResponse
        /// </returns>
        public async Task<SignOutResponse> SignOutWithOptionsAsync(string userId, string calendarId, string eventId, SignOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SignOut",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signOut",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignOutResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签退</para>
        /// </summary>
        /// 
        /// <returns>
        /// SignOutResponse
        /// </returns>
        public SignOutResponse SignOut(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignOutHeaders headers = new SignOutHeaders();
            return SignOutWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签退</para>
        /// </summary>
        /// 
        /// <returns>
        /// SignOutResponse
        /// </returns>
        public async Task<SignOutResponse> SignOutAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignOutHeaders headers = new SignOutHeaders();
            return await SignOutWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅公共日历</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// SubscribeCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubscribeCalendarResponse
        /// </returns>
        public SubscribeCalendarResponse SubscribeCalendarWithOptions(string userId, string calendarId, SubscribeCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SubscribeCalendar",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/subscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<SubscribeCalendarResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅公共日历</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// SubscribeCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubscribeCalendarResponse
        /// </returns>
        public async Task<SubscribeCalendarResponse> SubscribeCalendarWithOptionsAsync(string userId, string calendarId, SubscribeCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SubscribeCalendar",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/subscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<SubscribeCalendarResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅公共日历</para>
        /// </summary>
        /// 
        /// <returns>
        /// SubscribeCalendarResponse
        /// </returns>
        public SubscribeCalendarResponse SubscribeCalendar(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeCalendarHeaders headers = new SubscribeCalendarHeaders();
            return SubscribeCalendarWithOptions(userId, calendarId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅公共日历</para>
        /// </summary>
        /// 
        /// <returns>
        /// SubscribeCalendarResponse
        /// </returns>
        public async Task<SubscribeCalendarResponse> SubscribeCalendarAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeCalendarHeaders headers = new SubscribeCalendarHeaders();
            return await SubscribeCalendarWithOptionsAsync(userId, calendarId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日程转让</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferEventRequest
        /// </param>
        /// <param name="headers">
        /// TransferEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferEventResponse
        /// </returns>
        public TransferEventResponse TransferEventWithOptions(string calendarId, string userId, string eventId, TransferEventRequest request, TransferEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsExitCalendar))
            {
                body["isExitCalendar"] = request.IsExitCalendar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedNotifyViaO2O))
            {
                body["needNotifyViaO2O"] = request.NeedNotifyViaO2O;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrganizerId))
            {
                body["newOrganizerId"] = request.NewOrganizerId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "TransferEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日程转让</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferEventRequest
        /// </param>
        /// <param name="headers">
        /// TransferEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferEventResponse
        /// </returns>
        public async Task<TransferEventResponse> TransferEventWithOptionsAsync(string calendarId, string userId, string eventId, TransferEventRequest request, TransferEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsExitCalendar))
            {
                body["isExitCalendar"] = request.IsExitCalendar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedNotifyViaO2O))
            {
                body["needNotifyViaO2O"] = request.NeedNotifyViaO2O;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrganizerId))
            {
                body["newOrganizerId"] = request.NewOrganizerId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XClientToken))
            {
                realHeaders["x-client-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XClientToken);
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
                Action = "TransferEvent",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日程转让</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferEventRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferEventResponse
        /// </returns>
        public TransferEventResponse TransferEvent(string calendarId, string userId, string eventId, TransferEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransferEventHeaders headers = new TransferEventHeaders();
            return TransferEventWithOptions(calendarId, userId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日程转让</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferEventRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferEventResponse
        /// </returns>
        public async Task<TransferEventResponse> TransferEventAsync(string calendarId, string userId, string eventId, TransferEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransferEventHeaders headers = new TransferEventHeaders();
            return await TransferEventWithOptionsAsync(calendarId, userId, eventId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订阅公共日历</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// UnsubscribeCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnsubscribeCalendarResponse
        /// </returns>
        public UnsubscribeCalendarResponse UnsubscribeCalendarWithOptions(string userId, string calendarId, UnsubscribeCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UnsubscribeCalendar",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/unsubscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsubscribeCalendarResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订阅公共日历</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// UnsubscribeCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnsubscribeCalendarResponse
        /// </returns>
        public async Task<UnsubscribeCalendarResponse> UnsubscribeCalendarWithOptionsAsync(string userId, string calendarId, UnsubscribeCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UnsubscribeCalendar",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/unsubscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsubscribeCalendarResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订阅公共日历</para>
        /// </summary>
        /// 
        /// <returns>
        /// UnsubscribeCalendarResponse
        /// </returns>
        public UnsubscribeCalendarResponse UnsubscribeCalendar(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsubscribeCalendarHeaders headers = new UnsubscribeCalendarHeaders();
            return UnsubscribeCalendarWithOptions(userId, calendarId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订阅公共日历</para>
        /// </summary>
        /// 
        /// <returns>
        /// UnsubscribeCalendarResponse
        /// </returns>
        public async Task<UnsubscribeCalendarResponse> UnsubscribeCalendarAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsubscribeCalendarHeaders headers = new UnsubscribeCalendarHeaders();
            return await UnsubscribeCalendarWithOptionsAsync(userId, calendarId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定订阅日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubscribedCalendarsRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSubscribedCalendarsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscribedCalendarsResponse
        /// </returns>
        public UpdateSubscribedCalendarsResponse UpdateSubscribedCalendarsWithOptions(string calendarId, string userId, UpdateSubscribedCalendarsRequest request, UpdateSubscribedCalendarsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Managers))
            {
                body["managers"] = request.Managers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeScope))
            {
                body["subscribeScope"] = request.SubscribeScope;
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
                Action = "UpdateSubscribedCalendars",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscribedCalendarsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定订阅日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubscribedCalendarsRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSubscribedCalendarsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscribedCalendarsResponse
        /// </returns>
        public async Task<UpdateSubscribedCalendarsResponse> UpdateSubscribedCalendarsWithOptionsAsync(string calendarId, string userId, UpdateSubscribedCalendarsRequest request, UpdateSubscribedCalendarsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Managers))
            {
                body["managers"] = request.Managers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeScope))
            {
                body["subscribeScope"] = request.SubscribeScope;
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
                Action = "UpdateSubscribedCalendars",
                Version = "calendar_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscribedCalendarsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定订阅日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubscribedCalendarsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscribedCalendarsResponse
        /// </returns>
        public UpdateSubscribedCalendarsResponse UpdateSubscribedCalendars(string calendarId, string userId, UpdateSubscribedCalendarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSubscribedCalendarsHeaders headers = new UpdateSubscribedCalendarsHeaders();
            return UpdateSubscribedCalendarsWithOptions(calendarId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定订阅日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubscribedCalendarsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscribedCalendarsResponse
        /// </returns>
        public async Task<UpdateSubscribedCalendarsResponse> UpdateSubscribedCalendarsAsync(string calendarId, string userId, UpdateSubscribedCalendarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSubscribedCalendarsHeaders headers = new UpdateSubscribedCalendarsHeaders();
            return await UpdateSubscribedCalendarsWithOptionsAsync(calendarId, userId, request, headers, runtime);
        }

    }
}
