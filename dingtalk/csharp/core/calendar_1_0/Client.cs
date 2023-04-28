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


        public AddAttendeeResponse AddAttendeeWithOptions(string userId, string calendarId, string eventId, AddAttendeeRequest request, AddAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesToAdd))
            {
                body["attendeesToAdd"] = request.AttendeesToAdd;
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

        public async Task<AddAttendeeResponse> AddAttendeeWithOptionsAsync(string userId, string calendarId, string eventId, AddAttendeeRequest request, AddAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesToAdd))
            {
                body["attendeesToAdd"] = request.AttendeesToAdd;
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

        public AddAttendeeResponse AddAttendee(string userId, string calendarId, string eventId, AddAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeHeaders headers = new AddAttendeeHeaders();
            return AddAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        public async Task<AddAttendeeResponse> AddAttendeeAsync(string userId, string calendarId, string eventId, AddAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeHeaders headers = new AddAttendeeHeaders();
            return await AddAttendeeWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

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

        public AddMeetingRoomsResponse AddMeetingRooms(string userId, string calendarId, string eventId, AddMeetingRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMeetingRoomsHeaders headers = new AddMeetingRoomsHeaders();
            return AddMeetingRoomsWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        public async Task<AddMeetingRoomsResponse> AddMeetingRoomsAsync(string userId, string calendarId, string eventId, AddMeetingRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMeetingRoomsHeaders headers = new AddMeetingRoomsHeaders();
            return await AddMeetingRoomsWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

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

        public CheckInResponse CheckIn(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckInHeaders headers = new CheckInHeaders();
            return CheckInWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        public async Task<CheckInResponse> CheckInAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckInHeaders headers = new CheckInHeaders();
            return await CheckInWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

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

        public ConvertLegacyEventIdResponse ConvertLegacyEventId(string userId, ConvertLegacyEventIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConvertLegacyEventIdHeaders headers = new ConvertLegacyEventIdHeaders();
            return ConvertLegacyEventIdWithOptions(userId, request, headers, runtime);
        }

        public async Task<ConvertLegacyEventIdResponse> ConvertLegacyEventIdAsync(string userId, ConvertLegacyEventIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConvertLegacyEventIdHeaders headers = new ConvertLegacyEventIdHeaders();
            return await ConvertLegacyEventIdWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public CreateAclsResponse CreateAcls(string userId, string calendarId, CreateAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAclsHeaders headers = new CreateAclsHeaders();
            return CreateAclsWithOptions(userId, calendarId, request, headers, runtime);
        }

        public async Task<CreateAclsResponse> CreateAclsAsync(string userId, string calendarId, CreateAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAclsHeaders headers = new CreateAclsHeaders();
            return await CreateAclsWithOptionsAsync(userId, calendarId, request, headers, runtime);
        }

        public CreateEventResponse CreateEventWithOptions(string userId, string calendarId, CreateEventRequest request, CreateEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public async Task<CreateEventResponse> CreateEventWithOptionsAsync(string userId, string calendarId, CreateEventRequest request, CreateEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public CreateEventResponse CreateEvent(string userId, string calendarId, CreateEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventHeaders headers = new CreateEventHeaders();
            return CreateEventWithOptions(userId, calendarId, request, headers, runtime);
        }

        public async Task<CreateEventResponse> CreateEventAsync(string userId, string calendarId, CreateEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventHeaders headers = new CreateEventHeaders();
            return await CreateEventWithOptionsAsync(userId, calendarId, request, headers, runtime);
        }

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

        public CreateSubscribedCalendarResponse CreateSubscribedCalendar(string userId, CreateSubscribedCalendarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSubscribedCalendarHeaders headers = new CreateSubscribedCalendarHeaders();
            return CreateSubscribedCalendarWithOptions(userId, request, headers, runtime);
        }

        public async Task<CreateSubscribedCalendarResponse> CreateSubscribedCalendarAsync(string userId, CreateSubscribedCalendarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSubscribedCalendarHeaders headers = new CreateSubscribedCalendarHeaders();
            return await CreateSubscribedCalendarWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public DeleteAclResponse DeleteAcl(string userId, string calendarId, string aclId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAclHeaders headers = new DeleteAclHeaders();
            return DeleteAclWithOptions(userId, calendarId, aclId, headers, runtime);
        }

        public async Task<DeleteAclResponse> DeleteAclAsync(string userId, string calendarId, string aclId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAclHeaders headers = new DeleteAclHeaders();
            return await DeleteAclWithOptionsAsync(userId, calendarId, aclId, headers, runtime);
        }

        public DeleteEventResponse DeleteEventWithOptions(string userId, string calendarId, string eventId, DeleteEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public async Task<DeleteEventResponse> DeleteEventWithOptionsAsync(string userId, string calendarId, string eventId, DeleteEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public DeleteEventResponse DeleteEvent(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEventHeaders headers = new DeleteEventHeaders();
            return DeleteEventWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        public async Task<DeleteEventResponse> DeleteEventAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEventHeaders headers = new DeleteEventHeaders();
            return await DeleteEventWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

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

        public DeleteSubscribedCalendarResponse DeleteSubscribedCalendar(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSubscribedCalendarHeaders headers = new DeleteSubscribedCalendarHeaders();
            return DeleteSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
        }

        public async Task<DeleteSubscribedCalendarResponse> DeleteSubscribedCalendarAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSubscribedCalendarHeaders headers = new DeleteSubscribedCalendarHeaders();
            return await DeleteSubscribedCalendarWithOptionsAsync(userId, calendarId, headers, runtime);
        }

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

        public GenerateCaldavAccountResponse GenerateCaldavAccount(string userId, GenerateCaldavAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateCaldavAccountHeaders headers = new GenerateCaldavAccountHeaders();
            return GenerateCaldavAccountWithOptions(userId, request, headers, runtime);
        }

        public async Task<GenerateCaldavAccountResponse> GenerateCaldavAccountAsync(string userId, GenerateCaldavAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateCaldavAccountHeaders headers = new GenerateCaldavAccountHeaders();
            return await GenerateCaldavAccountWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public GetEventResponse GetEvent(string userId, string calendarId, string eventId, GetEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventHeaders headers = new GetEventHeaders();
            return GetEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        public async Task<GetEventResponse> GetEventAsync(string userId, string calendarId, string eventId, GetEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventHeaders headers = new GetEventHeaders();
            return await GetEventWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

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

        public GetMeetingRoomsScheduleResponse GetMeetingRoomsSchedule(string userId, GetMeetingRoomsScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMeetingRoomsScheduleHeaders headers = new GetMeetingRoomsScheduleHeaders();
            return GetMeetingRoomsScheduleWithOptions(userId, request, headers, runtime);
        }

        public async Task<GetMeetingRoomsScheduleResponse> GetMeetingRoomsScheduleAsync(string userId, GetMeetingRoomsScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMeetingRoomsScheduleHeaders headers = new GetMeetingRoomsScheduleHeaders();
            return await GetMeetingRoomsScheduleWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public GetScheduleResponse GetSchedule(string userId, GetScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetScheduleHeaders headers = new GetScheduleHeaders();
            return GetScheduleWithOptions(userId, request, headers, runtime);
        }

        public async Task<GetScheduleResponse> GetScheduleAsync(string userId, GetScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetScheduleHeaders headers = new GetScheduleHeaders();
            return await GetScheduleWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public GetSignInListResponse GetSignInList(string userId, string calendarId, string eventId, GetSignInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignInListHeaders headers = new GetSignInListHeaders();
            return GetSignInListWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        public async Task<GetSignInListResponse> GetSignInListAsync(string userId, string calendarId, string eventId, GetSignInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignInListHeaders headers = new GetSignInListHeaders();
            return await GetSignInListWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

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

        public GetSignOutListResponse GetSignOutList(string userId, string calendarId, string eventId, GetSignOutListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignOutListHeaders headers = new GetSignOutListHeaders();
            return GetSignOutListWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        public async Task<GetSignOutListResponse> GetSignOutListAsync(string userId, string calendarId, string eventId, GetSignOutListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignOutListHeaders headers = new GetSignOutListHeaders();
            return await GetSignOutListWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

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

        public GetSubscribedCalendarResponse GetSubscribedCalendar(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSubscribedCalendarHeaders headers = new GetSubscribedCalendarHeaders();
            return GetSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
        }

        public async Task<GetSubscribedCalendarResponse> GetSubscribedCalendarAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSubscribedCalendarHeaders headers = new GetSubscribedCalendarHeaders();
            return await GetSubscribedCalendarWithOptionsAsync(userId, calendarId, headers, runtime);
        }

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

        public ListAclsResponse ListAcls(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAclsHeaders headers = new ListAclsHeaders();
            return ListAclsWithOptions(userId, calendarId, headers, runtime);
        }

        public async Task<ListAclsResponse> ListAclsAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAclsHeaders headers = new ListAclsHeaders();
            return await ListAclsWithOptionsAsync(userId, calendarId, headers, runtime);
        }

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

        public ListAttendeesResponse ListAttendees(string userId, string calendarId, string eventId, ListAttendeesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAttendeesHeaders headers = new ListAttendeesHeaders();
            return ListAttendeesWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        public async Task<ListAttendeesResponse> ListAttendeesAsync(string userId, string calendarId, string eventId, ListAttendeesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAttendeesHeaders headers = new ListAttendeesHeaders();
            return await ListAttendeesWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

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

        public ListCalendarsResponse ListCalendars(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCalendarsHeaders headers = new ListCalendarsHeaders();
            return ListCalendarsWithOptions(userId, headers, runtime);
        }

        public async Task<ListCalendarsResponse> ListCalendarsAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCalendarsHeaders headers = new ListCalendarsHeaders();
            return await ListCalendarsWithOptionsAsync(userId, headers, runtime);
        }

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

        public ListEventsResponse ListEvents(string userId, string calendarId, ListEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsHeaders headers = new ListEventsHeaders();
            return ListEventsWithOptions(userId, calendarId, request, headers, runtime);
        }

        public async Task<ListEventsResponse> ListEventsAsync(string userId, string calendarId, ListEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsHeaders headers = new ListEventsHeaders();
            return await ListEventsWithOptionsAsync(userId, calendarId, request, headers, runtime);
        }

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

        public ListEventsInstancesResponse ListEventsInstances(string userId, string calendarId, ListEventsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsInstancesHeaders headers = new ListEventsInstancesHeaders();
            return ListEventsInstancesWithOptions(userId, calendarId, request, headers, runtime);
        }

        public async Task<ListEventsInstancesResponse> ListEventsInstancesAsync(string userId, string calendarId, ListEventsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsInstancesHeaders headers = new ListEventsInstancesHeaders();
            return await ListEventsInstancesWithOptionsAsync(userId, calendarId, request, headers, runtime);
        }

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

        public ListEventsViewResponse ListEventsView(string userId, string calendarId, ListEventsViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsViewHeaders headers = new ListEventsViewHeaders();
            return ListEventsViewWithOptions(userId, calendarId, request, headers, runtime);
        }

        public async Task<ListEventsViewResponse> ListEventsViewAsync(string userId, string calendarId, ListEventsViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsViewHeaders headers = new ListEventsViewHeaders();
            return await ListEventsViewWithOptionsAsync(userId, calendarId, request, headers, runtime);
        }

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

        public ListInstancesResponse ListInstances(string userId, string calendarId, string eventId, ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInstancesHeaders headers = new ListInstancesHeaders();
            return ListInstancesWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        public async Task<ListInstancesResponse> ListInstancesAsync(string userId, string calendarId, string eventId, ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInstancesHeaders headers = new ListInstancesHeaders();
            return await ListInstancesWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

        public PatchEventResponse PatchEventWithOptions(string userId, string calendarId, string eventId, PatchEventRequest request, PatchEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
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

        public async Task<PatchEventResponse> PatchEventWithOptionsAsync(string userId, string calendarId, string eventId, PatchEventRequest request, PatchEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
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

        public PatchEventResponse PatchEvent(string userId, string calendarId, string eventId, PatchEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchEventHeaders headers = new PatchEventHeaders();
            return PatchEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        public async Task<PatchEventResponse> PatchEventAsync(string userId, string calendarId, string eventId, PatchEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchEventHeaders headers = new PatchEventHeaders();
            return await PatchEventWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

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

        public RemoveAttendeeResponse RemoveAttendee(string userId, string calendarId, string eventId, RemoveAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
            return RemoveAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        public async Task<RemoveAttendeeResponse> RemoveAttendeeAsync(string userId, string calendarId, string eventId, RemoveAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
            return await RemoveAttendeeWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

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

        public RemoveMeetingRoomsResponse RemoveMeetingRooms(string userId, string calendarId, string eventId, RemoveMeetingRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveMeetingRoomsHeaders headers = new RemoveMeetingRoomsHeaders();
            return RemoveMeetingRoomsWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        public async Task<RemoveMeetingRoomsResponse> RemoveMeetingRoomsAsync(string userId, string calendarId, string eventId, RemoveMeetingRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveMeetingRoomsHeaders headers = new RemoveMeetingRoomsHeaders();
            return await RemoveMeetingRoomsWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

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

        public RespondEventResponse RespondEvent(string userId, string calendarId, string eventId, RespondEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RespondEventHeaders headers = new RespondEventHeaders();
            return RespondEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
        }

        public async Task<RespondEventResponse> RespondEventAsync(string userId, string calendarId, string eventId, RespondEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RespondEventHeaders headers = new RespondEventHeaders();
            return await RespondEventWithOptionsAsync(userId, calendarId, eventId, request, headers, runtime);
        }

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

        public SignInResponse SignIn(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignInHeaders headers = new SignInHeaders();
            return SignInWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        public async Task<SignInResponse> SignInAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignInHeaders headers = new SignInHeaders();
            return await SignInWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

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

        public SignOutResponse SignOut(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignOutHeaders headers = new SignOutHeaders();
            return SignOutWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        public async Task<SignOutResponse> SignOutAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignOutHeaders headers = new SignOutHeaders();
            return await SignOutWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

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

        public SubscribeCalendarResponse SubscribeCalendar(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeCalendarHeaders headers = new SubscribeCalendarHeaders();
            return SubscribeCalendarWithOptions(userId, calendarId, headers, runtime);
        }

        public async Task<SubscribeCalendarResponse> SubscribeCalendarAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeCalendarHeaders headers = new SubscribeCalendarHeaders();
            return await SubscribeCalendarWithOptionsAsync(userId, calendarId, headers, runtime);
        }

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

        public UnsubscribeCalendarResponse UnsubscribeCalendar(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsubscribeCalendarHeaders headers = new UnsubscribeCalendarHeaders();
            return UnsubscribeCalendarWithOptions(userId, calendarId, headers, runtime);
        }

        public async Task<UnsubscribeCalendarResponse> UnsubscribeCalendarAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsubscribeCalendarHeaders headers = new UnsubscribeCalendarHeaders();
            return await UnsubscribeCalendarWithOptionsAsync(userId, calendarId, headers, runtime);
        }

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

        public UpdateSubscribedCalendarsResponse UpdateSubscribedCalendars(string calendarId, string userId, UpdateSubscribedCalendarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSubscribedCalendarsHeaders headers = new UpdateSubscribedCalendarsHeaders();
            return UpdateSubscribedCalendarsWithOptions(calendarId, userId, request, headers, runtime);
        }

        public async Task<UpdateSubscribedCalendarsResponse> UpdateSubscribedCalendarsAsync(string calendarId, string userId, UpdateSubscribedCalendarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSubscribedCalendarsHeaders headers = new UpdateSubscribedCalendarsHeaders();
            return await UpdateSubscribedCalendarsWithOptionsAsync(calendarId, userId, request, headers, runtime);
        }

    }
}
