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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteEventResponse>(DoROARequest("DeleteEvent", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId, "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteEventResponse>(await DoROARequestAsync("DeleteEvent", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId, "json", req, runtime));
        }

        public RespondEventResponse RespondEvent(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RespondEventHeaders headers = new RespondEventHeaders();
            return RespondEventWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        public async Task<RespondEventResponse> RespondEventAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RespondEventHeaders headers = new RespondEventHeaders();
            return await RespondEventWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

        public RespondEventResponse RespondEventWithOptions(string userId, string calendarId, string eventId, RespondEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<RespondEventResponse>(DoROARequest("RespondEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/respond", "json", req, runtime));
        }

        public async Task<RespondEventResponse> RespondEventWithOptionsAsync(string userId, string calendarId, string eventId, RespondEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<RespondEventResponse>(await DoROARequestAsync("RespondEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/respond", "json", req, runtime));
        }

        public ListEventsResponse ListEvents(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsHeaders headers = new ListEventsHeaders();
            return ListEventsWithOptions(userId, calendarId, headers, runtime);
        }

        public async Task<ListEventsResponse> ListEventsAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsHeaders headers = new ListEventsHeaders();
            return await ListEventsWithOptionsAsync(userId, calendarId, headers, runtime);
        }

        public ListEventsResponse ListEventsWithOptions(string userId, string calendarId, ListEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<ListEventsResponse>(DoROARequest("ListEvents", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime));
        }

        public async Task<ListEventsResponse> ListEventsWithOptionsAsync(string userId, string calendarId, ListEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<ListEventsResponse>(await DoROARequestAsync("ListEvents", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime));
        }

        public RemoveAttendeeResponse RemoveAttendee(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
            return RemoveAttendeeWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        public async Task<RemoveAttendeeResponse> RemoveAttendeeAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
            return await RemoveAttendeeWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

        public RemoveAttendeeResponse RemoveAttendeeWithOptions(string userId, string calendarId, string eventId, RemoveAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<RemoveAttendeeResponse>(DoROARequest("RemoveAttendee", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees", "json", req, runtime));
        }

        public async Task<RemoveAttendeeResponse> RemoveAttendeeWithOptionsAsync(string userId, string calendarId, string eventId, RemoveAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<RemoveAttendeeResponse>(await DoROARequestAsync("RemoveAttendee", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees", "json", req, runtime));
        }

        public AddAttendeeResponse AddAttendee(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeHeaders headers = new AddAttendeeHeaders();
            return AddAttendeeWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        public async Task<AddAttendeeResponse> AddAttendeeAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeHeaders headers = new AddAttendeeHeaders();
            return await AddAttendeeWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

        public AddAttendeeResponse AddAttendeeWithOptions(string userId, string calendarId, string eventId, AddAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<AddAttendeeResponse>(DoROARequest("AddAttendee", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees", "json", req, runtime));
        }

        public async Task<AddAttendeeResponse> AddAttendeeWithOptionsAsync(string userId, string calendarId, string eventId, AddAttendeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<AddAttendeeResponse>(await DoROARequestAsync("AddAttendee", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees", "json", req, runtime));
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

        public PatchEventResponse PatchEvent(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchEventHeaders headers = new PatchEventHeaders();
            return PatchEventWithOptions(userId, calendarId, eventId, headers, runtime);
        }

        public async Task<PatchEventResponse> PatchEventAsync(string userId, string calendarId, string eventId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchEventHeaders headers = new PatchEventHeaders();
            return await PatchEventWithOptionsAsync(userId, calendarId, eventId, headers, runtime);
        }

        public PatchEventResponse PatchEventWithOptions(string userId, string calendarId, string eventId, PatchEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<PatchEventResponse>(DoROARequest("PatchEvent", "calendar_1.0", "HTTP", "PUT", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId, "json", req, runtime));
        }

        public async Task<PatchEventResponse> PatchEventWithOptionsAsync(string userId, string calendarId, string eventId, PatchEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<PatchEventResponse>(await DoROARequestAsync("PatchEvent", "calendar_1.0", "HTTP", "PUT", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId, "json", req, runtime));
        }

        public CreateEventResponse CreateEvent(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventHeaders headers = new CreateEventHeaders();
            return CreateEventWithOptions(userId, calendarId, headers, runtime);
        }

        public async Task<CreateEventResponse> CreateEventAsync(string userId, string calendarId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventHeaders headers = new CreateEventHeaders();
            return await CreateEventWithOptionsAsync(userId, calendarId, headers, runtime);
        }

        public CreateEventResponse CreateEventWithOptions(string userId, string calendarId, CreateEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<CreateEventResponse>(DoROARequest("CreateEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime));
        }

        public async Task<CreateEventResponse> CreateEventWithOptionsAsync(string userId, string calendarId, CreateEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<CreateEventResponse>(await DoROARequestAsync("CreateEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime));
        }

    }
}
