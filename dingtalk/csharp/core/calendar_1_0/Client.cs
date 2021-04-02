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

        public DeleteEventResponse DeleteEventWithOptions(string userId, string calendarId, string eventId, DeleteEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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

        public async Task<DeleteEventResponse> DeleteEventWithOptionsAsync(string userId, string calendarId, string eventId, DeleteEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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

        public ListEventsResponse ListEventsWithOptions(string userId, string calendarId, ListEventsRequest request, ListEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                query["timeMin"] = request.TimeMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                query["timeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDeleted))
            {
                query["showDeleted"] = request.ShowDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToken))
            {
                query["syncToken"] = request.SyncToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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

        public async Task<ListEventsResponse> ListEventsWithOptionsAsync(string userId, string calendarId, ListEventsRequest request, ListEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                query["timeMin"] = request.TimeMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                query["timeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDeleted))
            {
                query["showDeleted"] = request.ShowDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToken))
            {
                query["syncToken"] = request.SyncToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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
            return TeaModel.ToObject<GetScheduleResponse>(DoROARequest("GetSchedule", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/getSchedule", "json", req, runtime));
        }

        public async Task<GetScheduleResponse> GetScheduleWithOptionsAsync(string userId, GetScheduleRequest request, GetScheduleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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
            return TeaModel.ToObject<GetScheduleResponse>(await DoROARequestAsync("GetSchedule", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/getSchedule", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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

        public GetEventResponse GetEvent(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventHeaders headers = new GetEventHeaders();
            return GetEventWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        public async Task<GetEventResponse> GetEventAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventHeaders headers = new GetEventHeaders();
            return await GetEventWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

        public GetEventResponse GetEventWithOptions(string userId, string calendarId, string eventId, GetEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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

        public async Task<GetEventResponse> GetEventWithOptionsAsync(string userId, string calendarId, string eventId, GetEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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

        public PatchEventResponse PatchEventWithOptions(string userId, string calendarId, string eventId, PatchEventRequest request, PatchEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start.ToMap()))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End.ToMap()))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["isAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence.ToMap()))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location.ToMap()))
            {
                body["location"] = request.Location;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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

        public async Task<PatchEventResponse> PatchEventWithOptionsAsync(string userId, string calendarId, string eventId, PatchEventRequest request, PatchEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start.ToMap()))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End.ToMap()))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["isAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence.ToMap()))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location.ToMap()))
            {
                body["location"] = request.Location;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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

        public CreateEventResponse CreateEventWithOptions(string userId, string calendarId, CreateEventRequest request, CreateEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start.ToMap()))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End.ToMap()))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["isAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence.ToMap()))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location.ToMap()))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfo.ToMap()))
            {
                body["onlineMeetingInfo"] = request.OnlineMeetingInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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

        public async Task<CreateEventResponse> CreateEventWithOptionsAsync(string userId, string calendarId, CreateEventRequest request, CreateEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start.ToMap()))
            {
                body["start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End.ToMap()))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["isAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recurrence.ToMap()))
            {
                body["recurrence"] = request.Recurrence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attendees))
            {
                body["attendees"] = request.Attendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location.ToMap()))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reminders))
            {
                body["reminders"] = request.Reminders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfo.ToMap()))
            {
                body["onlineMeetingInfo"] = request.OnlineMeetingInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingUid))
            {
                realHeaders["dingUid"] = headers.DingUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
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

    }
}
