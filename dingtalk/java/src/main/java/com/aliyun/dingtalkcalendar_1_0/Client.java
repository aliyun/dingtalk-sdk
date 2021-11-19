// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcalendar_1_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;
import com.aliyun.openapiutil.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public CreateAclsResponse createAcls(String userId, String calendarId, CreateAclsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateAclsHeaders headers = new CreateAclsHeaders();
        return this.createAclsWithOptions(userId, calendarId, request, headers, runtime);
    }

    public CreateAclsResponse createAclsWithOptions(String userId, String calendarId, CreateAclsRequest request, CreateAclsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.privilege)) {
            body.put("privilege", request.privilege);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendMsg)) {
            body.put("sendMsg", request.sendMsg);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.scope))) {
            body.put("scope", request.scope);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateAcls", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls", "json", req, runtime), new CreateAclsResponse());
    }

    public ListAclsResponse listAcls(String userId, String calendarId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListAclsHeaders headers = new ListAclsHeaders();
        return this.listAclsWithOptions(userId, calendarId, headers, runtime);
    }

    public ListAclsResponse listAclsWithOptions(String userId, String calendarId, ListAclsHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("ListAcls", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls", "json", req, runtime), new ListAclsResponse());
    }

    public RespondEventResponse respondEvent(String userId, String calendarId, String eventId, RespondEventRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RespondEventHeaders headers = new RespondEventHeaders();
        return this.respondEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public RespondEventResponse respondEventWithOptions(String userId, String calendarId, String eventId, RespondEventRequest request, RespondEventHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.responseStatus)) {
            body.put("responseStatus", request.responseStatus);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RespondEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/respond", "none", req, runtime), new RespondEventResponse());
    }

    public GenerateCaldavAccountResponse generateCaldavAccount(String userId, GenerateCaldavAccountRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GenerateCaldavAccountHeaders headers = new GenerateCaldavAccountHeaders();
        return this.generateCaldavAccountWithOptions(userId, request, headers, runtime);
    }

    public GenerateCaldavAccountResponse generateCaldavAccountWithOptions(String userId, GenerateCaldavAccountRequest request, GenerateCaldavAccountHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.device)) {
            body.put("device", request.device);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingUid)) {
            realHeaders.put("dingUid", headers.dingUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GenerateCaldavAccount", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/caldavAccounts", "json", req, runtime), new GenerateCaldavAccountResponse());
    }

    public GetScheduleResponse getSchedule(String userId, GetScheduleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetScheduleHeaders headers = new GetScheduleHeaders();
        return this.getScheduleWithOptions(userId, request, headers, runtime);
    }

    public GetScheduleResponse getScheduleWithOptions(String userId, GetScheduleRequest request, GetScheduleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetSchedule", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/querySchedule", "json", req, runtime), new GetScheduleResponse());
    }

    public ConvertLegacyEventIdResponse convertLegacyEventId(String userId, ConvertLegacyEventIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ConvertLegacyEventIdHeaders headers = new ConvertLegacyEventIdHeaders();
        return this.convertLegacyEventIdWithOptions(userId, request, headers, runtime);
    }

    public ConvertLegacyEventIdResponse convertLegacyEventIdWithOptions(String userId, ConvertLegacyEventIdRequest request, ConvertLegacyEventIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.legacyEventIds)) {
            body.put("legacyEventIds", request.legacyEventIds);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingOrgId)) {
            realHeaders.put("dingOrgId", headers.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingUid)) {
            realHeaders.put("dingUid", headers.dingUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingAccessTokenType)) {
            realHeaders.put("dingAccessTokenType", headers.dingAccessTokenType);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ConvertLegacyEventId", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/legacyEventIds/convert", "json", req, runtime), new ConvertLegacyEventIdResponse());
    }

    public RemoveAttendeeResponse removeAttendee(String userId, String calendarId, String eventId, RemoveAttendeeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
        return this.removeAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public RemoveAttendeeResponse removeAttendeeWithOptions(String userId, String calendarId, String eventId, RemoveAttendeeRequest request, RemoveAttendeeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendeesToRemove)) {
            body.put("attendeesToRemove", request.attendeesToRemove);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RemoveAttendee", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees/batchRemove", "none", req, runtime), new RemoveAttendeeResponse());
    }

    public AddAttendeeResponse addAttendee(String userId, String calendarId, String eventId, AddAttendeeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddAttendeeHeaders headers = new AddAttendeeHeaders();
        return this.addAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public AddAttendeeResponse addAttendeeWithOptions(String userId, String calendarId, String eventId, AddAttendeeRequest request, AddAttendeeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendeesToAdd)) {
            body.put("attendeesToAdd", request.attendeesToAdd);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddAttendee", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees", "none", req, runtime), new AddAttendeeResponse());
    }

    public CreateEventResponse createEvent(String userId, String calendarId, CreateEventRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateEventHeaders headers = new CreateEventHeaders();
        return this.createEventWithOptions(userId, calendarId, request, headers, runtime);
    }

    public CreateEventResponse createEventWithOptions(String userId, String calendarId, CreateEventRequest request, CreateEventHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.summary)) {
            body.put("summary", request.summary);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.start))) {
            body.put("start", request.start);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.end))) {
            body.put("end", request.end);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isAllDay)) {
            body.put("isAllDay", request.isAllDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.recurrence))) {
            body.put("recurrence", request.recurrence);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.attendees)) {
            body.put("attendees", request.attendees);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.location))) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reminders)) {
            body.put("reminders", request.reminders);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.onlineMeetingInfo))) {
            body.put("onlineMeetingInfo", request.onlineMeetingInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extra)) {
            body.put("extra", request.extra);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime), new CreateEventResponse());
    }

    public ListCalendarsResponse listCalendars(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListCalendarsHeaders headers = new ListCalendarsHeaders();
        return this.listCalendarsWithOptions(userId, headers, runtime);
    }

    public ListCalendarsResponse listCalendarsWithOptions(String userId, ListCalendarsHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("ListCalendars", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars", "json", req, runtime), new ListCalendarsResponse());
    }

    public GetSignInListResponse getSignInList(String userId, String calendarId, String eventId, GetSignInListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetSignInListHeaders headers = new GetSignInListHeaders();
        return this.getSignInListWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public GetSignInListResponse getSignInListWithOptions(String userId, String calendarId, String eventId, GetSignInListRequest request, GetSignInListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetSignInList", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signin", "json", req, runtime), new GetSignInListResponse());
    }

    public DeleteAclResponse deleteAcl(String userId, String calendarId, String aclId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteAclHeaders headers = new DeleteAclHeaders();
        return this.deleteAclWithOptions(userId, calendarId, aclId, headers, runtime);
    }

    public DeleteAclResponse deleteAclWithOptions(String userId, String calendarId, String aclId, DeleteAclHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("DeleteAcl", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls/" + aclId + "", "none", req, runtime), new DeleteAclResponse());
    }

    public DeleteEventResponse deleteEvent(String userId, String calendarId, String eventId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteEventHeaders headers = new DeleteEventHeaders();
        return this.deleteEventWithOptions(userId, calendarId, eventId, headers, runtime);
    }

    public DeleteEventResponse deleteEventWithOptions(String userId, String calendarId, String eventId, DeleteEventHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("DeleteEvent", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "", "none", req, runtime), new DeleteEventResponse());
    }

    public ListEventsResponse listEvents(String userId, String calendarId, ListEventsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListEventsHeaders headers = new ListEventsHeaders();
        return this.listEventsWithOptions(userId, calendarId, request, headers, runtime);
    }

    public ListEventsResponse listEventsWithOptions(String userId, String calendarId, ListEventsRequest request, ListEventsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.timeMin)) {
            query.put("timeMin", request.timeMin);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeMax)) {
            query.put("timeMax", request.timeMax);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.showDeleted)) {
            query.put("showDeleted", request.showDeleted);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.syncToken)) {
            query.put("syncToken", request.syncToken);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListEvents", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime), new ListEventsResponse());
    }

    public ListEventsViewResponse listEventsView(String userId, String calendarId, ListEventsViewRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListEventsViewHeaders headers = new ListEventsViewHeaders();
        return this.listEventsViewWithOptions(userId, calendarId, request, headers, runtime);
    }

    public ListEventsViewResponse listEventsViewWithOptions(String userId, String calendarId, ListEventsViewRequest request, ListEventsViewHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.timeMin)) {
            query.put("timeMin", request.timeMin);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeMax)) {
            query.put("timeMax", request.timeMax);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListEventsView", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/eventsview", "json", req, runtime), new ListEventsViewResponse());
    }

    public GetEventResponse getEvent(String userId, String calendarId, String eventId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetEventHeaders headers = new GetEventHeaders();
        return this.getEventWithOptions(userId, calendarId, eventId, headers, runtime);
    }

    public GetEventResponse getEventWithOptions(String userId, String calendarId, String eventId, GetEventHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetEvent", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "", "json", req, runtime), new GetEventResponse());
    }

    public PatchEventResponse patchEvent(String userId, String calendarId, String eventId, PatchEventRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PatchEventHeaders headers = new PatchEventHeaders();
        return this.patchEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public PatchEventResponse patchEventWithOptions(String userId, String calendarId, String eventId, PatchEventRequest request, PatchEventHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.summary)) {
            body.put("summary", request.summary);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.start))) {
            body.put("start", request.start);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.end))) {
            body.put("end", request.end);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isAllDay)) {
            body.put("isAllDay", request.isAllDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.recurrence))) {
            body.put("recurrence", request.recurrence);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.attendees)) {
            body.put("attendees", request.attendees);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.location))) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extra)) {
            body.put("extra", request.extra);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reminders)) {
            body.put("reminders", request.reminders);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("PatchEvent", "calendar_1.0", "HTTP", "PUT", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "", "json", req, runtime), new PatchEventResponse());
    }
}
