// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcalendar_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public AddAttendeeResponse addAttendee(String userId, String calendarId, String eventId, AddAttendeeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddAttendeeHeaders headers = new AddAttendeeHeaders();
        return this.addAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public AddAttendeeResponse addAttendeeWithOptions(String userId, String calendarId, String eventId, AddAttendeeRequest request, AddAttendeeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendeesToAdd)) {
            body.put("attendeesToAdd", request.attendeesToAdd);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddAttendee", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees", "none", req, runtime), new AddAttendeeResponse());
    }

    public AddMeetingRoomsResponse addMeetingRooms(String userId, String calendarId, String eventId, AddMeetingRoomsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddMeetingRoomsHeaders headers = new AddMeetingRoomsHeaders();
        return this.addMeetingRoomsWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public AddMeetingRoomsResponse addMeetingRoomsWithOptions(String userId, String calendarId, String eventId, AddMeetingRoomsRequest request, AddMeetingRoomsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.meetingRoomsToAdd)) {
            body.put("meetingRoomsToAdd", request.meetingRoomsToAdd);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddMeetingRooms", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/meetingRooms", "json", req, runtime), new AddMeetingRoomsResponse());
    }

    public CheckInResponse checkIn(String userId, String calendarId, String eventId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckInHeaders headers = new CheckInHeaders();
        return this.checkInWithOptions(userId, calendarId, eventId, headers, runtime);
    }

    public CheckInResponse checkInWithOptions(String userId, String calendarId, String eventId, CheckInHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("CheckIn", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/checkIn", "json", req, runtime), new CheckInResponse());
    }

    public ConvertLegacyEventIdResponse convertLegacyEventId(String userId, ConvertLegacyEventIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConvertLegacyEventIdHeaders headers = new ConvertLegacyEventIdHeaders();
        return this.convertLegacyEventIdWithOptions(userId, request, headers, runtime);
    }

    public ConvertLegacyEventIdResponse convertLegacyEventIdWithOptions(String userId, ConvertLegacyEventIdRequest request, ConvertLegacyEventIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.legacyEventIds)) {
            body.put("legacyEventIds", request.legacyEventIds);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ConvertLegacyEventId", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/legacyEventIds/convert", "json", req, runtime), new ConvertLegacyEventIdResponse());
    }

    public CreateAclsResponse createAcls(String userId, String calendarId, CreateAclsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAclsHeaders headers = new CreateAclsHeaders();
        return this.createAclsWithOptions(userId, calendarId, request, headers, runtime);
    }

    public CreateAclsResponse createAclsWithOptions(String userId, String calendarId, CreateAclsRequest request, CreateAclsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.privilege)) {
            body.put("privilege", request.privilege);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.scope))) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendMsg)) {
            body.put("sendMsg", request.sendMsg);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateAcls", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls", "json", req, runtime), new CreateAclsResponse());
    }

    public CreateEventResponse createEvent(String userId, String calendarId, CreateEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateEventHeaders headers = new CreateEventHeaders();
        return this.createEventWithOptions(userId, calendarId, request, headers, runtime);
    }

    public CreateEventResponse createEventWithOptions(String userId, String calendarId, CreateEventRequest request, CreateEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendees)) {
            body.put("attendees", request.attendees);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.end))) {
            body.put("end", request.end);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extra)) {
            body.put("extra", request.extra);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isAllDay)) {
            body.put("isAllDay", request.isAllDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.location))) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.onlineMeetingInfo))) {
            body.put("onlineMeetingInfo", request.onlineMeetingInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.recurrence))) {
            body.put("recurrence", request.recurrence);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reminders)) {
            body.put("reminders", request.reminders);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.start))) {
            body.put("start", request.start);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summary)) {
            body.put("summary", request.summary);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime), new CreateEventResponse());
    }

    public CreateSubscribedCalendarResponse createSubscribedCalendar(String userId, CreateSubscribedCalendarRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSubscribedCalendarHeaders headers = new CreateSubscribedCalendarHeaders();
        return this.createSubscribedCalendarWithOptions(userId, request, headers, runtime);
    }

    public CreateSubscribedCalendarResponse createSubscribedCalendarWithOptions(String userId, CreateSubscribedCalendarRequest request, CreateSubscribedCalendarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managers)) {
            body.put("managers", request.managers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.subscribeScope))) {
            body.put("subscribeScope", request.subscribeScope);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateSubscribedCalendar", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/subscribedCalendars", "json", req, runtime), new CreateSubscribedCalendarResponse());
    }

    public DeleteAclResponse deleteAcl(String userId, String calendarId, String aclId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteAclHeaders headers = new DeleteAclHeaders();
        return this.deleteAclWithOptions(userId, calendarId, aclId, headers, runtime);
    }

    public DeleteAclResponse deleteAclWithOptions(String userId, String calendarId, String aclId, DeleteAclHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        aclId = com.aliyun.openapiutil.Client.getEncodeParam(aclId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("DeleteAcl", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls/" + aclId + "", "none", req, runtime), new DeleteAclResponse());
    }

    public DeleteEventResponse deleteEvent(String userId, String calendarId, String eventId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteEventHeaders headers = new DeleteEventHeaders();
        return this.deleteEventWithOptions(userId, calendarId, eventId, headers, runtime);
    }

    public DeleteEventResponse deleteEventWithOptions(String userId, String calendarId, String eventId, DeleteEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("DeleteEvent", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "", "none", req, runtime), new DeleteEventResponse());
    }

    public DeleteSubscribedCalendarResponse deleteSubscribedCalendar(String userId, String calendarId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSubscribedCalendarHeaders headers = new DeleteSubscribedCalendarHeaders();
        return this.deleteSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
    }

    public DeleteSubscribedCalendarResponse deleteSubscribedCalendarWithOptions(String userId, String calendarId, DeleteSubscribedCalendarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("DeleteSubscribedCalendar", "calendar_1.0", "HTTP", "DELETE", "AK", "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId + "", "json", req, runtime), new DeleteSubscribedCalendarResponse());
    }

    public GenerateCaldavAccountResponse generateCaldavAccount(String userId, GenerateCaldavAccountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GenerateCaldavAccountHeaders headers = new GenerateCaldavAccountHeaders();
        return this.generateCaldavAccountWithOptions(userId, request, headers, runtime);
    }

    public GenerateCaldavAccountResponse generateCaldavAccountWithOptions(String userId, GenerateCaldavAccountRequest request, GenerateCaldavAccountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.device)) {
            body.put("device", request.device);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingUid)) {
            realHeaders.put("dingUid", com.aliyun.teautil.Common.toJSONString(headers.dingUid));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GenerateCaldavAccount", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/caldavAccounts", "json", req, runtime), new GenerateCaldavAccountResponse());
    }

    public GetEventResponse getEvent(String userId, String calendarId, String eventId, GetEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEventHeaders headers = new GetEventHeaders();
        return this.getEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public GetEventResponse getEventWithOptions(String userId, String calendarId, String eventId, GetEventRequest request, GetEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxAttendees)) {
            query.put("maxAttendees", request.maxAttendees);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetEvent", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "", "json", req, runtime), new GetEventResponse());
    }

    public GetMeetingRoomsScheduleResponse getMeetingRoomsSchedule(String userId, GetMeetingRoomsScheduleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMeetingRoomsScheduleHeaders headers = new GetMeetingRoomsScheduleHeaders();
        return this.getMeetingRoomsScheduleWithOptions(userId, request, headers, runtime);
    }

    public GetMeetingRoomsScheduleResponse getMeetingRoomsScheduleWithOptions(String userId, GetMeetingRoomsScheduleRequest request, GetMeetingRoomsScheduleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomIds)) {
            body.put("roomIds", request.roomIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetMeetingRoomsSchedule", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/meetingRooms/schedules/query", "json", req, runtime), new GetMeetingRoomsScheduleResponse());
    }

    public GetScheduleResponse getSchedule(String userId, GetScheduleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetScheduleHeaders headers = new GetScheduleHeaders();
        return this.getScheduleWithOptions(userId, request, headers, runtime);
    }

    public GetScheduleResponse getScheduleWithOptions(String userId, GetScheduleRequest request, GetScheduleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetSchedule", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/querySchedule", "json", req, runtime), new GetScheduleResponse());
    }

    public GetSignInListResponse getSignInList(String userId, String calendarId, String eventId, GetSignInListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSignInListHeaders headers = new GetSignInListHeaders();
        return this.getSignInListWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public GetSignInListResponse getSignInListWithOptions(String userId, String calendarId, String eventId, GetSignInListRequest request, GetSignInListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetSignInList", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signin", "json", req, runtime), new GetSignInListResponse());
    }

    public GetSignOutListResponse getSignOutList(String userId, String calendarId, String eventId, GetSignOutListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSignOutListHeaders headers = new GetSignOutListHeaders();
        return this.getSignOutListWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public GetSignOutListResponse getSignOutListWithOptions(String userId, String calendarId, String eventId, GetSignOutListRequest request, GetSignOutListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetSignOutList", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signOut", "json", req, runtime), new GetSignOutListResponse());
    }

    public GetSubscribedCalendarResponse getSubscribedCalendar(String userId, String calendarId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSubscribedCalendarHeaders headers = new GetSubscribedCalendarHeaders();
        return this.getSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
    }

    public GetSubscribedCalendarResponse getSubscribedCalendarWithOptions(String userId, String calendarId, GetSubscribedCalendarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetSubscribedCalendar", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId + "", "json", req, runtime), new GetSubscribedCalendarResponse());
    }

    public ListAclsResponse listAcls(String userId, String calendarId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAclsHeaders headers = new ListAclsHeaders();
        return this.listAclsWithOptions(userId, calendarId, headers, runtime);
    }

    public ListAclsResponse listAclsWithOptions(String userId, String calendarId, ListAclsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("ListAcls", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls", "json", req, runtime), new ListAclsResponse());
    }

    public ListAttendeesResponse listAttendees(String userId, String calendarId, String eventId, ListAttendeesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAttendeesHeaders headers = new ListAttendeesHeaders();
        return this.listAttendeesWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public ListAttendeesResponse listAttendeesWithOptions(String userId, String calendarId, String eventId, ListAttendeesRequest request, ListAttendeesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListAttendees", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees", "json", req, runtime), new ListAttendeesResponse());
    }

    public ListCalendarsResponse listCalendars(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListCalendarsHeaders headers = new ListCalendarsHeaders();
        return this.listCalendarsWithOptions(userId, headers, runtime);
    }

    public ListCalendarsResponse listCalendarsWithOptions(String userId, ListCalendarsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("ListCalendars", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars", "json", req, runtime), new ListCalendarsResponse());
    }

    public ListEventsResponse listEvents(String userId, String calendarId, ListEventsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListEventsHeaders headers = new ListEventsHeaders();
        return this.listEventsWithOptions(userId, calendarId, request, headers, runtime);
    }

    public ListEventsResponse listEventsWithOptions(String userId, String calendarId, ListEventsRequest request, ListEventsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxAttendees)) {
            query.put("maxAttendees", request.maxAttendees);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.showDeleted)) {
            query.put("showDeleted", request.showDeleted);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.syncToken)) {
            query.put("syncToken", request.syncToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeMax)) {
            query.put("timeMax", request.timeMax);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeMin)) {
            query.put("timeMin", request.timeMin);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListEvents", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events", "json", req, runtime), new ListEventsResponse());
    }

    public ListEventsInstancesResponse listEventsInstances(String userId, String calendarId, ListEventsInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListEventsInstancesHeaders headers = new ListEventsInstancesHeaders();
        return this.listEventsInstancesWithOptions(userId, calendarId, request, headers, runtime);
    }

    public ListEventsInstancesResponse listEventsInstancesWithOptions(String userId, String calendarId, ListEventsInstancesRequest request, ListEventsInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxAttendees)) {
            query.put("maxAttendees", request.maxAttendees);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.seriesMasterId)) {
            query.put("seriesMasterId", request.seriesMasterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startRecurrenceId)) {
            query.put("startRecurrenceId", request.startRecurrenceId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListEventsInstances", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/instances", "json", req, runtime), new ListEventsInstancesResponse());
    }

    public ListEventsViewResponse listEventsView(String userId, String calendarId, ListEventsViewRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListEventsViewHeaders headers = new ListEventsViewHeaders();
        return this.listEventsViewWithOptions(userId, calendarId, request, headers, runtime);
    }

    public ListEventsViewResponse listEventsViewWithOptions(String userId, String calendarId, ListEventsViewRequest request, ListEventsViewHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxAttendees)) {
            query.put("maxAttendees", request.maxAttendees);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeMax)) {
            query.put("timeMax", request.timeMax);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeMin)) {
            query.put("timeMin", request.timeMin);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListEventsView", "calendar_1.0", "HTTP", "GET", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/eventsview", "json", req, runtime), new ListEventsViewResponse());
    }

    public PatchEventResponse patchEvent(String userId, String calendarId, String eventId, PatchEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PatchEventHeaders headers = new PatchEventHeaders();
        return this.patchEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public PatchEventResponse patchEventWithOptions(String userId, String calendarId, String eventId, PatchEventRequest request, PatchEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendees)) {
            body.put("attendees", request.attendees);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.end))) {
            body.put("end", request.end);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extra)) {
            body.put("extra", request.extra);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isAllDay)) {
            body.put("isAllDay", request.isAllDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.location))) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.recurrence))) {
            body.put("recurrence", request.recurrence);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reminders)) {
            body.put("reminders", request.reminders);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.start))) {
            body.put("start", request.start);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summary)) {
            body.put("summary", request.summary);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("PatchEvent", "calendar_1.0", "HTTP", "PUT", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "", "json", req, runtime), new PatchEventResponse());
    }

    public RemoveAttendeeResponse removeAttendee(String userId, String calendarId, String eventId, RemoveAttendeeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
        return this.removeAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public RemoveAttendeeResponse removeAttendeeWithOptions(String userId, String calendarId, String eventId, RemoveAttendeeRequest request, RemoveAttendeeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendeesToRemove)) {
            body.put("attendeesToRemove", request.attendeesToRemove);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RemoveAttendee", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees/batchRemove", "none", req, runtime), new RemoveAttendeeResponse());
    }

    public RemoveMeetingRoomsResponse removeMeetingRooms(String userId, String calendarId, String eventId, RemoveMeetingRoomsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveMeetingRoomsHeaders headers = new RemoveMeetingRoomsHeaders();
        return this.removeMeetingRoomsWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public RemoveMeetingRoomsResponse removeMeetingRoomsWithOptions(String userId, String calendarId, String eventId, RemoveMeetingRoomsRequest request, RemoveMeetingRoomsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.meetingRoomsToRemove)) {
            body.put("meetingRoomsToRemove", request.meetingRoomsToRemove);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RemoveMeetingRooms", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/meetingRooms/batchRemove", "json", req, runtime), new RemoveMeetingRoomsResponse());
    }

    public RespondEventResponse respondEvent(String userId, String calendarId, String eventId, RespondEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RespondEventHeaders headers = new RespondEventHeaders();
        return this.respondEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    public RespondEventResponse respondEventWithOptions(String userId, String calendarId, String eventId, RespondEventRequest request, RespondEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.responseStatus)) {
            body.put("responseStatus", request.responseStatus);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RespondEvent", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/respond", "none", req, runtime), new RespondEventResponse());
    }

    public SignInResponse signIn(String userId, String calendarId, String eventId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SignInHeaders headers = new SignInHeaders();
        return this.signInWithOptions(userId, calendarId, eventId, headers, runtime);
    }

    public SignInResponse signInWithOptions(String userId, String calendarId, String eventId, SignInHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("SignIn", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signin", "json", req, runtime), new SignInResponse());
    }

    public SignOutResponse signOut(String userId, String calendarId, String eventId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SignOutHeaders headers = new SignOutHeaders();
        return this.signOutWithOptions(userId, calendarId, eventId, headers, runtime);
    }

    public SignOutResponse signOutWithOptions(String userId, String calendarId, String eventId, SignOutHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        eventId = com.aliyun.openapiutil.Client.getEncodeParam(eventId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("SignOut", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signOut", "json", req, runtime), new SignOutResponse());
    }

    public SubscribeCalendarResponse subscribeCalendar(String userId, String calendarId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SubscribeCalendarHeaders headers = new SubscribeCalendarHeaders();
        return this.subscribeCalendarWithOptions(userId, calendarId, headers, runtime);
    }

    public SubscribeCalendarResponse subscribeCalendarWithOptions(String userId, String calendarId, SubscribeCalendarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("SubscribeCalendar", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/subscribe", "none", req, runtime), new SubscribeCalendarResponse());
    }

    public UnsubscribeCalendarResponse unsubscribeCalendar(String userId, String calendarId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UnsubscribeCalendarHeaders headers = new UnsubscribeCalendarHeaders();
        return this.unsubscribeCalendarWithOptions(userId, calendarId, headers, runtime);
    }

    public UnsubscribeCalendarResponse unsubscribeCalendarWithOptions(String userId, String calendarId, UnsubscribeCalendarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("UnsubscribeCalendar", "calendar_1.0", "HTTP", "POST", "AK", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/unsubscribe", "json", req, runtime), new UnsubscribeCalendarResponse());
    }

    public UpdateSubscribedCalendarsResponse updateSubscribedCalendars(String calendarId, String userId, UpdateSubscribedCalendarsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateSubscribedCalendarsHeaders headers = new UpdateSubscribedCalendarsHeaders();
        return this.updateSubscribedCalendarsWithOptions(calendarId, userId, request, headers, runtime);
    }

    public UpdateSubscribedCalendarsResponse updateSubscribedCalendarsWithOptions(String calendarId, String userId, UpdateSubscribedCalendarsRequest request, UpdateSubscribedCalendarsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        calendarId = com.aliyun.openapiutil.Client.getEncodeParam(calendarId);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managers)) {
            body.put("managers", request.managers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.subscribeScope))) {
            body.put("subscribeScope", request.subscribeScope);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateSubscribedCalendars", "calendar_1.0", "HTTP", "PUT", "AK", "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId + "", "json", req, runtime), new UpdateSubscribedCalendarsResponse());
    }
}
