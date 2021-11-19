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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public AddAttendeeResponse AddAttendee(string calendarId, string eventId, string userId, AddAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeHeaders headers = new AddAttendeeHeaders();
            return AddAttendeeWithOptions(calendarId, eventId, userId, request, headers, runtime);
        }

        public async Task<AddAttendeeResponse> AddAttendeeAsync(string calendarId, string eventId, string userId, AddAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeHeaders headers = new AddAttendeeHeaders();
            return await AddAttendeeWithOptionsAsync(calendarId, eventId, userId, request, headers, runtime);
        }

        public AddAttendeeResponse AddAttendeeWithOptions(string calendarId, string eventId, string userId, AddAttendeeRequest request, AddAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddAttendeeResponse>(DoROARequest("AddAttendee", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees", "none", req, runtime));
        }

        public async Task<AddAttendeeResponse> AddAttendeeWithOptionsAsync(string calendarId, string eventId, string userId, AddAttendeeRequest request, AddAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddAttendeeResponse>(await DoROARequestAsync("AddAttendee", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees", "none", req, runtime));
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

        public ConvertLegacyEventIdResponse ConvertLegacyEventIdWithOptions(string userId, ConvertLegacyEventIdRequest request, ConvertLegacyEventIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ConvertLegacyEventIdResponse>(DoROARequest("ConvertLegacyEventId", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/legacyEventIds/convert", "json", req, runtime));
        }

        public async Task<ConvertLegacyEventIdResponse> ConvertLegacyEventIdWithOptionsAsync(string userId, ConvertLegacyEventIdRequest request, ConvertLegacyEventIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ConvertLegacyEventIdResponse>(await DoROARequestAsync("ConvertLegacyEventId", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/legacyEventIds/convert", "json", req, runtime));
        }

        public CreateAclsResponse CreateAcls(string calendarId, string userId, CreateAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAclsHeaders headers = new CreateAclsHeaders();
            return CreateAclsWithOptions(calendarId, userId, request, headers, runtime);
        }

        public async Task<CreateAclsResponse> CreateAclsAsync(string calendarId, string userId, CreateAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAclsHeaders headers = new CreateAclsHeaders();
            return await CreateAclsWithOptionsAsync(calendarId, userId, request, headers, runtime);
        }

        public CreateAclsResponse CreateAclsWithOptions(string calendarId, string userId, CreateAclsRequest request, CreateAclsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Privilege))
            {
                body["privilege"] = request.Privilege;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope.ToMap()))
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateAclsResponse>(DoROARequest("CreateAcls", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls", "json", req, runtime));
        }

        public async Task<CreateAclsResponse> CreateAclsWithOptionsAsync(string calendarId, string userId, CreateAclsRequest request, CreateAclsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Privilege))
            {
                body["privilege"] = request.Privilege;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope.ToMap()))
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateAclsResponse>(await DoROARequestAsync("CreateAcls", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls", "json", req, runtime));
        }

        public CreateEventResponse CreateEvent(string calendarId, string userId, CreateEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventHeaders headers = new CreateEventHeaders();
            return CreateEventWithOptions(calendarId, userId, request, headers, runtime);
        }

        public async Task<CreateEventResponse> CreateEventAsync(string calendarId, string userId, CreateEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventHeaders headers = new CreateEventHeaders();
            return await CreateEventWithOptionsAsync(calendarId, userId, request, headers, runtime);
        }

        public CreateEventResponse CreateEventWithOptions(string calendarId, string userId, CreateEventRequest request, CreateEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location.ToMap()))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfo.ToMap()))
            {
                body["onlineMeetingInfo"] = request.OnlineMeetingInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence.ToMap()))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start.ToMap()))
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateEventResponse>(DoROARequest("CreateEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime));
        }

        public async Task<CreateEventResponse> CreateEventWithOptionsAsync(string calendarId, string userId, CreateEventRequest request, CreateEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location.ToMap()))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfo.ToMap()))
            {
                body["onlineMeetingInfo"] = request.OnlineMeetingInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence.ToMap()))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start.ToMap()))
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateEventResponse>(await DoROARequestAsync("CreateEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime));
        }

        public DeleteAclResponse DeleteAcl(string aclId, string calendarId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAclHeaders headers = new DeleteAclHeaders();
            return DeleteAclWithOptions(aclId, calendarId, userId, headers, runtime);
        }

        public async Task<DeleteAclResponse> DeleteAclAsync(string aclId, string calendarId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAclHeaders headers = new DeleteAclHeaders();
            return await DeleteAclWithOptionsAsync(aclId, calendarId, userId, headers, runtime);
        }

        public DeleteAclResponse DeleteAclWithOptions(string aclId, string calendarId, string userId, DeleteAclHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            aclId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aclId);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteAclResponse>(DoROARequest("DeleteAcl", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls/" + aclId, "none", req, runtime));
        }

        public async Task<DeleteAclResponse> DeleteAclWithOptionsAsync(string aclId, string calendarId, string userId, DeleteAclHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            aclId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aclId);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteAclResponse>(await DoROARequestAsync("DeleteAcl", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls/" + aclId, "none", req, runtime));
        }

        public DeleteEventResponse DeleteEvent(string calendarId, string eventId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEventHeaders headers = new DeleteEventHeaders();
            return DeleteEventWithOptions(calendarId, eventId, userId, headers, runtime);
        }

        public async Task<DeleteEventResponse> DeleteEventAsync(string calendarId, string eventId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEventHeaders headers = new DeleteEventHeaders();
            return await DeleteEventWithOptionsAsync(calendarId, eventId, userId, headers, runtime);
        }

        public DeleteEventResponse DeleteEventWithOptions(string calendarId, string eventId, string userId, DeleteEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteEventResponse>(DoROARequest("DeleteEvent", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId, "none", req, runtime));
        }

        public async Task<DeleteEventResponse> DeleteEventWithOptionsAsync(string calendarId, string eventId, string userId, DeleteEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteEventResponse>(await DoROARequestAsync("DeleteEvent", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId, "none", req, runtime));
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

        public GenerateCaldavAccountResponse GenerateCaldavAccountWithOptions(string userId, GenerateCaldavAccountRequest request, GenerateCaldavAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GenerateCaldavAccountResponse>(DoROARequest("GenerateCaldavAccount", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/caldavAccounts", "json", req, runtime));
        }

        public async Task<GenerateCaldavAccountResponse> GenerateCaldavAccountWithOptionsAsync(string userId, GenerateCaldavAccountRequest request, GenerateCaldavAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GenerateCaldavAccountResponse>(await DoROARequestAsync("GenerateCaldavAccount", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/caldavAccounts", "json", req, runtime));
        }

        public GetEventResponse GetEvent(string calendarId, string eventId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventHeaders headers = new GetEventHeaders();
            return GetEventWithOptions(calendarId, eventId, userId, headers, runtime);
        }

        public async Task<GetEventResponse> GetEventAsync(string calendarId, string eventId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventHeaders headers = new GetEventHeaders();
            return await GetEventWithOptionsAsync(calendarId, eventId, userId, headers, runtime);
        }

        public GetEventResponse GetEventWithOptions(string calendarId, string eventId, string userId, GetEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetEventResponse>(DoROARequest("GetEvent", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId, "json", req, runtime));
        }

        public async Task<GetEventResponse> GetEventWithOptionsAsync(string calendarId, string eventId, string userId, GetEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetEventResponse>(await DoROARequestAsync("GetEvent", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId, "json", req, runtime));
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

        public GetScheduleResponse GetScheduleWithOptions(string userId, GetScheduleRequest request, GetScheduleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetScheduleResponse>(DoROARequest("GetSchedule", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/querySchedule", "json", req, runtime));
        }

        public async Task<GetScheduleResponse> GetScheduleWithOptionsAsync(string userId, GetScheduleRequest request, GetScheduleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetScheduleResponse>(await DoROARequestAsync("GetSchedule", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/querySchedule", "json", req, runtime));
        }

        public GetSignInListResponse GetSignInList(string calendarId, string eventId, string userId, GetSignInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignInListHeaders headers = new GetSignInListHeaders();
            return GetSignInListWithOptions(calendarId, eventId, userId, request, headers, runtime);
        }

        public async Task<GetSignInListResponse> GetSignInListAsync(string calendarId, string eventId, string userId, GetSignInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignInListHeaders headers = new GetSignInListHeaders();
            return await GetSignInListWithOptionsAsync(calendarId, eventId, userId, request, headers, runtime);
        }

        public GetSignInListResponse GetSignInListWithOptions(string calendarId, string eventId, string userId, GetSignInListRequest request, GetSignInListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSignInListResponse>(DoROARequest("GetSignInList", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signin", "json", req, runtime));
        }

        public async Task<GetSignInListResponse> GetSignInListWithOptionsAsync(string calendarId, string eventId, string userId, GetSignInListRequest request, GetSignInListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSignInListResponse>(await DoROARequestAsync("GetSignInList", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signin", "json", req, runtime));
        }

        public ListAclsResponse ListAcls(string calendarId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAclsHeaders headers = new ListAclsHeaders();
            return ListAclsWithOptions(calendarId, userId, headers, runtime);
        }

        public async Task<ListAclsResponse> ListAclsAsync(string calendarId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAclsHeaders headers = new ListAclsHeaders();
            return await ListAclsWithOptionsAsync(calendarId, userId, headers, runtime);
        }

        public ListAclsResponse ListAclsWithOptions(string calendarId, string userId, ListAclsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<ListAclsResponse>(DoROARequest("ListAcls", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls", "json", req, runtime));
        }

        public async Task<ListAclsResponse> ListAclsWithOptionsAsync(string calendarId, string userId, ListAclsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<ListAclsResponse>(await DoROARequestAsync("ListAcls", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls", "json", req, runtime));
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

        public ListCalendarsResponse ListCalendarsWithOptions(string userId, ListCalendarsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<ListCalendarsResponse>(DoROARequest("ListCalendars", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars", "json", req, runtime));
        }

        public async Task<ListCalendarsResponse> ListCalendarsWithOptionsAsync(string userId, ListCalendarsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<ListCalendarsResponse>(await DoROARequestAsync("ListCalendars", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars", "json", req, runtime));
        }

        public ListEventsResponse ListEvents(string calendarId, string userId, ListEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsHeaders headers = new ListEventsHeaders();
            return ListEventsWithOptions(calendarId, userId, request, headers, runtime);
        }

        public async Task<ListEventsResponse> ListEventsAsync(string calendarId, string userId, ListEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsHeaders headers = new ListEventsHeaders();
            return await ListEventsWithOptionsAsync(calendarId, userId, request, headers, runtime);
        }

        public ListEventsResponse ListEventsWithOptions(string calendarId, string userId, ListEventsRequest request, ListEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListEventsResponse>(DoROARequest("ListEvents", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime));
        }

        public async Task<ListEventsResponse> ListEventsWithOptionsAsync(string calendarId, string userId, ListEventsRequest request, ListEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListEventsResponse>(await DoROARequestAsync("ListEvents", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime));
        }

        public ListEventsViewResponse ListEventsView(string calendarId, string userId, ListEventsViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsViewHeaders headers = new ListEventsViewHeaders();
            return ListEventsViewWithOptions(calendarId, userId, request, headers, runtime);
        }

        public async Task<ListEventsViewResponse> ListEventsViewAsync(string calendarId, string userId, ListEventsViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsViewHeaders headers = new ListEventsViewHeaders();
            return await ListEventsViewWithOptionsAsync(calendarId, userId, request, headers, runtime);
        }

        public ListEventsViewResponse ListEventsViewWithOptions(string calendarId, string userId, ListEventsViewRequest request, ListEventsViewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListEventsViewResponse>(DoROARequest("ListEventsView", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/eventsview", "json", req, runtime));
        }

        public async Task<ListEventsViewResponse> ListEventsViewWithOptionsAsync(string calendarId, string userId, ListEventsViewRequest request, ListEventsViewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListEventsViewResponse>(await DoROARequestAsync("ListEventsView", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/eventsview", "json", req, runtime));
        }

        public PatchEventResponse PatchEvent(string calendarId, string eventId, string userId, PatchEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchEventHeaders headers = new PatchEventHeaders();
            return PatchEventWithOptions(calendarId, eventId, userId, request, headers, runtime);
        }

        public async Task<PatchEventResponse> PatchEventAsync(string calendarId, string eventId, string userId, PatchEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchEventHeaders headers = new PatchEventHeaders();
            return await PatchEventWithOptionsAsync(calendarId, eventId, userId, request, headers, runtime);
        }

        public PatchEventResponse PatchEventWithOptions(string calendarId, string eventId, string userId, PatchEventRequest request, PatchEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location.ToMap()))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence.ToMap()))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start.ToMap()))
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PatchEventResponse>(DoROARequest("PatchEvent", "calendar_1.0", "HTTP", "PUT", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId, "json", req, runtime));
        }

        public async Task<PatchEventResponse> PatchEventWithOptionsAsync(string calendarId, string eventId, string userId, PatchEventRequest request, PatchEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location.ToMap()))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence.ToMap()))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start.ToMap()))
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PatchEventResponse>(await DoROARequestAsync("PatchEvent", "calendar_1.0", "HTTP", "PUT", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId, "json", req, runtime));
        }

        public RemoveAttendeeResponse RemoveAttendee(string calendarId, string eventId, string userId, RemoveAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
            return RemoveAttendeeWithOptions(calendarId, eventId, userId, request, headers, runtime);
        }

        public async Task<RemoveAttendeeResponse> RemoveAttendeeAsync(string calendarId, string eventId, string userId, RemoveAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
            return await RemoveAttendeeWithOptionsAsync(calendarId, eventId, userId, request, headers, runtime);
        }

        public RemoveAttendeeResponse RemoveAttendeeWithOptions(string calendarId, string eventId, string userId, RemoveAttendeeRequest request, RemoveAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RemoveAttendeeResponse>(DoROARequest("RemoveAttendee", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees/batchRemove", "none", req, runtime));
        }

        public async Task<RemoveAttendeeResponse> RemoveAttendeeWithOptionsAsync(string calendarId, string eventId, string userId, RemoveAttendeeRequest request, RemoveAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RemoveAttendeeResponse>(await DoROARequestAsync("RemoveAttendee", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees/batchRemove", "none", req, runtime));
        }

        public RespondEventResponse RespondEvent(string calendarId, string eventId, string userId, RespondEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RespondEventHeaders headers = new RespondEventHeaders();
            return RespondEventWithOptions(calendarId, eventId, userId, request, headers, runtime);
        }

        public async Task<RespondEventResponse> RespondEventAsync(string calendarId, string eventId, string userId, RespondEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RespondEventHeaders headers = new RespondEventHeaders();
            return await RespondEventWithOptionsAsync(calendarId, eventId, userId, request, headers, runtime);
        }

        public RespondEventResponse RespondEventWithOptions(string calendarId, string eventId, string userId, RespondEventRequest request, RespondEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RespondEventResponse>(DoROARequest("RespondEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/respond", "none", req, runtime));
        }

        public async Task<RespondEventResponse> RespondEventWithOptionsAsync(string calendarId, string eventId, string userId, RespondEventRequest request, RespondEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            calendarId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(calendarId);
            eventId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(eventId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RespondEventResponse>(await DoROARequestAsync("RespondEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/respond", "none", req, runtime));
        }

    }
}
