// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcalendar_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>新增日程参与人</p>
     * 
     * @param request AddAttendeeRequest
     * @param headers AddAttendeeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddAttendeeResponse
     */
    public AddAttendeeResponse addAttendeeWithOptions(String userId, String calendarId, String eventId, AddAttendeeRequest request, AddAttendeeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendeesToAdd)) {
            body.put("attendeesToAdd", request.attendeesToAdd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chatNotification)) {
            body.put("chatNotification", request.chatNotification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pushNotification)) {
            body.put("pushNotification", request.pushNotification);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddAttendee"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddAttendeeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增日程参与人</p>
     * 
     * @param request AddAttendeeRequest
     * @return AddAttendeeResponse
     */
    public AddAttendeeResponse addAttendee(String userId, String calendarId, String eventId, AddAttendeeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddAttendeeHeaders headers = new AddAttendeeHeaders();
        return this.addAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加会议室</p>
     * 
     * @param request AddMeetingRoomsRequest
     * @param headers AddMeetingRoomsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddMeetingRoomsResponse
     */
    public AddMeetingRoomsResponse addMeetingRoomsWithOptions(String userId, String calendarId, String eventId, AddMeetingRoomsRequest request, AddMeetingRoomsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.meetingRoomsToAdd)) {
            body.put("meetingRoomsToAdd", request.meetingRoomsToAdd);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddMeetingRooms"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/meetingRooms"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddMeetingRoomsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加会议室</p>
     * 
     * @param request AddMeetingRoomsRequest
     * @return AddMeetingRoomsResponse
     */
    public AddMeetingRoomsResponse addMeetingRooms(String userId, String calendarId, String eventId, AddMeetingRoomsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddMeetingRoomsHeaders headers = new AddMeetingRoomsHeaders();
        return this.addMeetingRoomsWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>取消指定日程</p>
     * 
     * @param request CancelEventRequest
     * @param headers CancelEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelEventResponse
     */
    public CancelEventResponse cancelEventWithOptions(String userId, String calendarId, String eventId, CancelEventRequest request, CancelEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            query.put("scope", request.scope);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CancelEvent"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>取消指定日程</p>
     * 
     * @param request CancelEventRequest
     * @return CancelEventResponse
     */
    public CancelEventResponse cancelEvent(String userId, String calendarId, String eventId, CancelEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelEventHeaders headers = new CancelEventHeaders();
        return this.cancelEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>签到</p>
     * 
     * @param headers CheckInHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CheckInResponse
     */
    public CheckInResponse checkInWithOptions(String userId, String calendarId, String eventId, CheckInHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CheckIn"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/checkIn"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CheckInResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>签到</p>
     * @return CheckInResponse
     */
    public CheckInResponse checkIn(String userId, String calendarId, String eventId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckInHeaders headers = new CheckInHeaders();
        return this.checkInWithOptions(userId, calendarId, eventId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>转换老版本的eventId</p>
     * 
     * @param request ConvertLegacyEventIdRequest
     * @param headers ConvertLegacyEventIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConvertLegacyEventIdResponse
     */
    public ConvertLegacyEventIdResponse convertLegacyEventIdWithOptions(String userId, ConvertLegacyEventIdRequest request, ConvertLegacyEventIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ConvertLegacyEventId"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/legacyEventIds/convert"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConvertLegacyEventIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>转换老版本的eventId</p>
     * 
     * @param request ConvertLegacyEventIdRequest
     * @return ConvertLegacyEventIdResponse
     */
    public ConvertLegacyEventIdResponse convertLegacyEventId(String userId, ConvertLegacyEventIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConvertLegacyEventIdHeaders headers = new ConvertLegacyEventIdHeaders();
        return this.convertLegacyEventIdWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建访问控制</p>
     * 
     * @param request CreateAclsRequest
     * @param headers CreateAclsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateAclsResponse
     */
    public CreateAclsResponse createAclsWithOptions(String userId, String calendarId, CreateAclsRequest request, CreateAclsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.privilege)) {
            body.put("privilege", request.privilege);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateAcls"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateAclsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建访问控制</p>
     * 
     * @param request CreateAclsRequest
     * @return CreateAclsResponse
     */
    public CreateAclsResponse createAcls(String userId, String calendarId, CreateAclsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAclsHeaders headers = new CreateAclsHeaders();
        return this.createAclsWithOptions(userId, calendarId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建日程</p>
     * 
     * @param request CreateEventRequest
     * @param headers CreateEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateEventResponse
     */
    public CreateEventResponse createEventWithOptions(String userId, String calendarId, CreateEventRequest request, CreateEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendees)) {
            body.put("attendees", request.attendees);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardInstances)) {
            body.put("cardInstances", request.cardInstances);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.end)) {
            body.put("end", request.end);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extra)) {
            body.put("extra", request.extra);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isAllDay)) {
            body.put("isAllDay", request.isAllDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.location)) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.onlineMeetingInfo)) {
            body.put("onlineMeetingInfo", request.onlineMeetingInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recurrence)) {
            body.put("recurrence", request.recurrence);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reminders)) {
            body.put("reminders", request.reminders);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.richTextDescription)) {
            body.put("richTextDescription", request.richTextDescription);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.start)) {
            body.put("start", request.start);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summary)) {
            body.put("summary", request.summary);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uiConfigs)) {
            body.put("uiConfigs", request.uiConfigs);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateEvent"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建日程</p>
     * 
     * @param request CreateEventRequest
     * @return CreateEventResponse
     */
    public CreateEventResponse createEvent(String userId, String calendarId, CreateEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateEventHeaders headers = new CreateEventHeaders();
        return this.createEventWithOptions(userId, calendarId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建日程(me接口)</p>
     * 
     * @param request CreateEventByMeRequest
     * @param headers CreateEventByMeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateEventByMeResponse
     */
    public CreateEventByMeResponse createEventByMeWithOptions(String calendarId, CreateEventByMeRequest request, CreateEventByMeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendees)) {
            body.put("attendees", request.attendees);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.end)) {
            body.put("end", request.end);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extra)) {
            body.put("extra", request.extra);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isAllDay)) {
            body.put("isAllDay", request.isAllDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.location)) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.onlineMeetingInfo)) {
            body.put("onlineMeetingInfo", request.onlineMeetingInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recurrence)) {
            body.put("recurrence", request.recurrence);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reminders)) {
            body.put("reminders", request.reminders);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.richTextDescription)) {
            body.put("richTextDescription", request.richTextDescription);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.start)) {
            body.put("start", request.start);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summary)) {
            body.put("summary", request.summary);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uiConfigs)) {
            body.put("uiConfigs", request.uiConfigs);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateEventByMe"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/me/calendars/" + calendarId + "/events"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateEventByMeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建日程(me接口)</p>
     * 
     * @param request CreateEventByMeRequest
     * @return CreateEventByMeResponse
     */
    public CreateEventByMeResponse createEventByMe(String calendarId, CreateEventByMeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateEventByMeHeaders headers = new CreateEventByMeHeaders();
        return this.createEventByMeWithOptions(calendarId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>快速创建订阅日历</p>
     * 
     * @param request CreateSubscribedCalendarRequest
     * @param headers CreateSubscribedCalendarHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateSubscribedCalendarResponse
     */
    public CreateSubscribedCalendarResponse createSubscribedCalendarWithOptions(String userId, CreateSubscribedCalendarRequest request, CreateSubscribedCalendarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        if (!com.aliyun.teautil.Common.isUnset(request.subscribeScope)) {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateSubscribedCalendar"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/subscribedCalendars"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateSubscribedCalendarResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>快速创建订阅日历</p>
     * 
     * @param request CreateSubscribedCalendarRequest
     * @return CreateSubscribedCalendarResponse
     */
    public CreateSubscribedCalendarResponse createSubscribedCalendar(String userId, CreateSubscribedCalendarRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSubscribedCalendarHeaders headers = new CreateSubscribedCalendarHeaders();
        return this.createSubscribedCalendarWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除访问控制</p>
     * 
     * @param headers DeleteAclHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteAclResponse
     */
    public DeleteAclResponse deleteAclWithOptions(String userId, String calendarId, String aclId, DeleteAclHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteAcl"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls/" + aclId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteAclResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除访问控制</p>
     * @return DeleteAclResponse
     */
    public DeleteAclResponse deleteAcl(String userId, String calendarId, String aclId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteAclHeaders headers = new DeleteAclHeaders();
        return this.deleteAclWithOptions(userId, calendarId, aclId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除指定日程</p>
     * 
     * @param request DeleteEventRequest
     * @param headers DeleteEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteEventResponse
     */
    public DeleteEventResponse deleteEventWithOptions(String userId, String calendarId, String eventId, DeleteEventRequest request, DeleteEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pushNotification)) {
            query.put("pushNotification", request.pushNotification);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteEvent"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除指定日程</p>
     * 
     * @param request DeleteEventRequest
     * @return DeleteEventResponse
     */
    public DeleteEventResponse deleteEvent(String userId, String calendarId, String eventId, DeleteEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteEventHeaders headers = new DeleteEventHeaders();
        return this.deleteEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除指定订阅日历</p>
     * 
     * @param headers DeleteSubscribedCalendarHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteSubscribedCalendarResponse
     */
    public DeleteSubscribedCalendarResponse deleteSubscribedCalendarWithOptions(String userId, String calendarId, DeleteSubscribedCalendarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteSubscribedCalendar"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteSubscribedCalendarResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除指定订阅日历</p>
     * @return DeleteSubscribedCalendarResponse
     */
    public DeleteSubscribedCalendarResponse deleteSubscribedCalendar(String userId, String calendarId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSubscribedCalendarHeaders headers = new DeleteSubscribedCalendarHeaders();
        return this.deleteSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>生成caldav账户</p>
     * 
     * @param request GenerateCaldavAccountRequest
     * @param headers GenerateCaldavAccountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GenerateCaldavAccountResponse
     */
    public GenerateCaldavAccountResponse generateCaldavAccountWithOptions(String userId, GenerateCaldavAccountRequest request, GenerateCaldavAccountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("dingUid", com.aliyun.teautil.Common.toJSONString(headers.dingUid));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GenerateCaldavAccount"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/caldavAccounts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GenerateCaldavAccountResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>生成caldav账户</p>
     * 
     * @param request GenerateCaldavAccountRequest
     * @return GenerateCaldavAccountResponse
     */
    public GenerateCaldavAccountResponse generateCaldavAccount(String userId, GenerateCaldavAccountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GenerateCaldavAccountHeaders headers = new GenerateCaldavAccountHeaders();
        return this.generateCaldavAccountWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询日程列表</p>
     * 
     * @param request GetEventRequest
     * @param headers GetEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetEventResponse
     */
    public GetEventResponse getEventWithOptions(String userId, String calendarId, String eventId, GetEventRequest request, GetEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetEvent"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询日程列表</p>
     * 
     * @param request GetEventRequest
     * @return GetEventResponse
     */
    public GetEventResponse getEvent(String userId, String calendarId, String eventId, GetEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEventHeaders headers = new GetEventHeaders();
        return this.getEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询会议室忙闲</p>
     * 
     * @param request GetMeetingRoomsScheduleRequest
     * @param headers GetMeetingRoomsScheduleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMeetingRoomsScheduleResponse
     */
    public GetMeetingRoomsScheduleResponse getMeetingRoomsScheduleWithOptions(String userId, GetMeetingRoomsScheduleRequest request, GetMeetingRoomsScheduleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetMeetingRoomsSchedule"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/meetingRooms/schedules/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMeetingRoomsScheduleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询会议室忙闲</p>
     * 
     * @param request GetMeetingRoomsScheduleRequest
     * @return GetMeetingRoomsScheduleResponse
     */
    public GetMeetingRoomsScheduleResponse getMeetingRoomsSchedule(String userId, GetMeetingRoomsScheduleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMeetingRoomsScheduleHeaders headers = new GetMeetingRoomsScheduleHeaders();
        return this.getMeetingRoomsScheduleWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询闲忙</p>
     * 
     * @param request GetScheduleRequest
     * @param headers GetScheduleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetScheduleResponse
     */
    public GetScheduleResponse getScheduleWithOptions(String userId, GetScheduleRequest request, GetScheduleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSchedule"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/querySchedule"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetScheduleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询闲忙</p>
     * 
     * @param request GetScheduleRequest
     * @return GetScheduleResponse
     */
    public GetScheduleResponse getSchedule(String userId, GetScheduleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetScheduleHeaders headers = new GetScheduleHeaders();
        return this.getScheduleWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询闲忙(me接口）</p>
     * 
     * @param request GetScheduleByMeRequest
     * @param headers GetScheduleByMeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetScheduleByMeResponse
     */
    public GetScheduleByMeResponse getScheduleByMeWithOptions(GetScheduleByMeRequest request, GetScheduleByMeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetScheduleByMe"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/me/schedules/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetScheduleByMeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询闲忙(me接口）</p>
     * 
     * @param request GetScheduleByMeRequest
     * @return GetScheduleByMeResponse
     */
    public GetScheduleByMeResponse getScheduleByMe(GetScheduleByMeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetScheduleByMeHeaders headers = new GetScheduleByMeHeaders();
        return this.getScheduleByMeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取签到链接</p>
     * 
     * @param headers GetSignInLinkHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSignInLinkResponse
     */
    public GetSignInLinkResponse getSignInLinkWithOptions(String calendarId, String userId, String eventId, GetSignInLinkHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSignInLink"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signInLinks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSignInLinkResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取签到链接</p>
     * @return GetSignInLinkResponse
     */
    public GetSignInLinkResponse getSignInLink(String calendarId, String userId, String eventId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSignInLinkHeaders headers = new GetSignInLinkHeaders();
        return this.getSignInLinkWithOptions(calendarId, userId, eventId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取签到信息详情</p>
     * 
     * @param request GetSignInListRequest
     * @param headers GetSignInListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSignInListResponse
     */
    public GetSignInListResponse getSignInListWithOptions(String userId, String calendarId, String eventId, GetSignInListRequest request, GetSignInListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSignInList"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signin"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSignInListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取签到信息详情</p>
     * 
     * @param request GetSignInListRequest
     * @return GetSignInListResponse
     */
    public GetSignInListResponse getSignInList(String userId, String calendarId, String eventId, GetSignInListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSignInListHeaders headers = new GetSignInListHeaders();
        return this.getSignInListWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取签退链接</p>
     * 
     * @param headers GetSignOutLinkHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSignOutLinkResponse
     */
    public GetSignOutLinkResponse getSignOutLinkWithOptions(String calendarId, String userId, String eventId, GetSignOutLinkHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSignOutLink"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signOutLinks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSignOutLinkResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取签退链接</p>
     * @return GetSignOutLinkResponse
     */
    public GetSignOutLinkResponse getSignOutLink(String calendarId, String userId, String eventId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSignOutLinkHeaders headers = new GetSignOutLinkHeaders();
        return this.getSignOutLinkWithOptions(calendarId, userId, eventId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取签退信息详情</p>
     * 
     * @param request GetSignOutListRequest
     * @param headers GetSignOutListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSignOutListResponse
     */
    public GetSignOutListResponse getSignOutListWithOptions(String userId, String calendarId, String eventId, GetSignOutListRequest request, GetSignOutListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSignOutList"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signOut"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSignOutListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取签退信息详情</p>
     * 
     * @param request GetSignOutListRequest
     * @return GetSignOutListResponse
     */
    public GetSignOutListResponse getSignOutList(String userId, String calendarId, String eventId, GetSignOutListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSignOutListHeaders headers = new GetSignOutListHeaders();
        return this.getSignOutListWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定订阅日历详情</p>
     * 
     * @param headers GetSubscribedCalendarHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSubscribedCalendarResponse
     */
    public GetSubscribedCalendarResponse getSubscribedCalendarWithOptions(String userId, String calendarId, GetSubscribedCalendarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSubscribedCalendar"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSubscribedCalendarResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定订阅日历详情</p>
     * @return GetSubscribedCalendarResponse
     */
    public GetSubscribedCalendarResponse getSubscribedCalendar(String userId, String calendarId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSubscribedCalendarHeaders headers = new GetSubscribedCalendarHeaders();
        return this.getSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取访问控制列表</p>
     * 
     * @param headers ListAclsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAclsResponse
     */
    public ListAclsResponse listAclsWithOptions(String userId, String calendarId, ListAclsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListAcls"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/acls"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAclsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取访问控制列表</p>
     * @return ListAclsResponse
     */
    public ListAclsResponse listAcls(String userId, String calendarId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAclsHeaders headers = new ListAclsHeaders();
        return this.listAclsWithOptions(userId, calendarId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页获取参与人列表</p>
     * 
     * @param request ListAttendeesRequest
     * @param headers ListAttendeesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAttendeesResponse
     */
    public ListAttendeesResponse listAttendeesWithOptions(String userId, String calendarId, String eventId, ListAttendeesRequest request, ListAttendeesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListAttendees"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAttendeesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页获取参与人列表</p>
     * 
     * @param request ListAttendeesRequest
     * @return ListAttendeesResponse
     */
    public ListAttendeesResponse listAttendees(String userId, String calendarId, String eventId, ListAttendeesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAttendeesHeaders headers = new ListAttendeesHeaders();
        return this.listAttendeesWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>日历本查询</p>
     * 
     * @param headers ListCalendarsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListCalendarsResponse
     */
    public ListCalendarsResponse listCalendarsWithOptions(String userId, ListCalendarsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListCalendars"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListCalendarsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>日历本查询</p>
     * @return ListCalendarsResponse
     */
    public ListCalendarsResponse listCalendars(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListCalendarsHeaders headers = new ListCalendarsHeaders();
        return this.listCalendarsWithOptions(userId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询日程列表</p>
     * 
     * @param request ListEventsRequest
     * @param headers ListEventsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListEventsResponse
     */
    public ListEventsResponse listEventsWithOptions(String userId, String calendarId, ListEventsRequest request, ListEventsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        if (!com.aliyun.teautil.Common.isUnset(request.seriesMasterId)) {
            query.put("seriesMasterId", request.seriesMasterId);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListEvents"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListEventsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询日程列表</p>
     * 
     * @param request ListEventsRequest
     * @return ListEventsResponse
     */
    public ListEventsResponse listEvents(String userId, String calendarId, ListEventsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListEventsHeaders headers = new ListEventsHeaders();
        return this.listEventsWithOptions(userId, calendarId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询同一个循环日程序列下已生成的实例</p>
     * 
     * @param request ListEventsInstancesRequest
     * @param headers ListEventsInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListEventsInstancesResponse
     */
    public ListEventsInstancesResponse listEventsInstancesWithOptions(String userId, String calendarId, ListEventsInstancesRequest request, ListEventsInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListEventsInstances"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/instances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListEventsInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询同一个循环日程序列下已生成的实例</p>
     * 
     * @param request ListEventsInstancesRequest
     * @return ListEventsInstancesResponse
     */
    public ListEventsInstancesResponse listEventsInstances(String userId, String calendarId, ListEventsInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListEventsInstancesHeaders headers = new ListEventsInstancesHeaders();
        return this.listEventsInstancesWithOptions(userId, calendarId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询日程视图列表以查看闲忙，展开循环日程</p>
     * 
     * @param request ListEventsViewRequest
     * @param headers ListEventsViewHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListEventsViewResponse
     */
    public ListEventsViewResponse listEventsViewWithOptions(String userId, String calendarId, ListEventsViewRequest request, ListEventsViewHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListEventsView"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/eventsview"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListEventsViewResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询日程视图列表以查看闲忙，展开循环日程</p>
     * 
     * @param request ListEventsViewRequest
     * @return ListEventsViewResponse
     */
    public ListEventsViewResponse listEventsView(String userId, String calendarId, ListEventsViewRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListEventsViewHeaders headers = new ListEventsViewHeaders();
        return this.listEventsViewWithOptions(userId, calendarId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询日程视图列表以查看闲忙，展开循环日程(me接口）</p>
     * 
     * @param request ListEventsViewByMeRequest
     * @param headers ListEventsViewByMeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListEventsViewByMeResponse
     */
    public ListEventsViewByMeResponse listEventsViewByMeWithOptions(String calendarId, ListEventsViewByMeRequest request, ListEventsViewByMeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListEventsViewByMe"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/me/calendars/" + calendarId + "/eventsview"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListEventsViewByMeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询日程视图列表以查看闲忙，展开循环日程(me接口）</p>
     * 
     * @param request ListEventsViewByMeRequest
     * @return ListEventsViewByMeResponse
     */
    public ListEventsViewByMeResponse listEventsViewByMe(String calendarId, ListEventsViewByMeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListEventsViewByMeHeaders headers = new ListEventsViewByMeHeaders();
        return this.listEventsViewByMeWithOptions(calendarId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询循环日程实例列表</p>
     * 
     * @param request ListInstancesRequest
     * @param headers ListInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListInstancesResponse
     */
    public ListInstancesResponse listInstancesWithOptions(String userId, String calendarId, String eventId, ListInstancesRequest request, ListInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListInstances"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/instances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询循环日程实例列表</p>
     * 
     * @param request ListInstancesRequest
     * @return ListInstancesResponse
     */
    public ListInstancesResponse listInstances(String userId, String calendarId, String eventId, ListInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListInstancesHeaders headers = new ListInstancesHeaders();
        return this.listInstancesWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设置会议室在日程中的响应状态</p>
     * 
     * @param request MeetingRoomRespondRequest
     * @param headers MeetingRoomRespondHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MeetingRoomRespondResponse
     */
    public MeetingRoomRespondResponse meetingRoomRespondWithOptions(String calendarId, String userId, String eventId, String roomId, MeetingRoomRespondRequest request, MeetingRoomRespondHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.responseStatus)) {
            body.put("responseStatus", request.responseStatus);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.userAgent)) {
            realHeaders.put("userAgent", com.aliyun.teautil.Common.toJSONString(headers.userAgent));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "MeetingRoomRespond"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/meetingRooms/" + roomId + "/respond"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MeetingRoomRespondResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设置会议室在日程中的响应状态</p>
     * 
     * @param request MeetingRoomRespondRequest
     * @return MeetingRoomRespondResponse
     */
    public MeetingRoomRespondResponse meetingRoomRespond(String calendarId, String userId, String eventId, String roomId, MeetingRoomRespondRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MeetingRoomRespondHeaders headers = new MeetingRoomRespondHeaders();
        return this.meetingRoomRespondWithOptions(calendarId, userId, eventId, roomId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改日程</p>
     * 
     * @param request PatchEventRequest
     * @param headers PatchEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PatchEventResponse
     */
    public PatchEventResponse patchEventWithOptions(String userId, String calendarId, String eventId, PatchEventRequest request, PatchEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendees)) {
            body.put("attendees", request.attendees);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardInstances)) {
            body.put("cardInstances", request.cardInstances);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.end)) {
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

        if (!com.aliyun.teautil.Common.isUnset(request.location)) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.onlineMeetingInfo)) {
            body.put("onlineMeetingInfo", request.onlineMeetingInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recurrence)) {
            body.put("recurrence", request.recurrence);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reminders)) {
            body.put("reminders", request.reminders);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.richTextDescription)) {
            body.put("richTextDescription", request.richTextDescription);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.start)) {
            body.put("start", request.start);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summary)) {
            body.put("summary", request.summary);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uiConfigs)) {
            body.put("uiConfigs", request.uiConfigs);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PatchEvent"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PatchEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改日程</p>
     * 
     * @param request PatchEventRequest
     * @return PatchEventResponse
     */
    public PatchEventResponse patchEvent(String userId, String calendarId, String eventId, PatchEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PatchEventHeaders headers = new PatchEventHeaders();
        return this.patchEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除日程参与人</p>
     * 
     * @param request RemoveAttendeeRequest
     * @param headers RemoveAttendeeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveAttendeeResponse
     */
    public RemoveAttendeeResponse removeAttendeeWithOptions(String userId, String calendarId, String eventId, RemoveAttendeeRequest request, RemoveAttendeeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendeesToRemove)) {
            body.put("attendeesToRemove", request.attendeesToRemove);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RemoveAttendee"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/attendees/batchRemove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveAttendeeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除日程参与人</p>
     * 
     * @param request RemoveAttendeeRequest
     * @return RemoveAttendeeResponse
     */
    public RemoveAttendeeResponse removeAttendee(String userId, String calendarId, String eventId, RemoveAttendeeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
        return this.removeAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除会议室</p>
     * 
     * @param request RemoveMeetingRoomsRequest
     * @param headers RemoveMeetingRoomsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveMeetingRoomsResponse
     */
    public RemoveMeetingRoomsResponse removeMeetingRoomsWithOptions(String userId, String calendarId, String eventId, RemoveMeetingRoomsRequest request, RemoveMeetingRoomsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.meetingRoomsToRemove)) {
            body.put("meetingRoomsToRemove", request.meetingRoomsToRemove);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RemoveMeetingRooms"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/meetingRooms/batchRemove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveMeetingRoomsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除会议室</p>
     * 
     * @param request RemoveMeetingRoomsRequest
     * @return RemoveMeetingRoomsResponse
     */
    public RemoveMeetingRoomsResponse removeMeetingRooms(String userId, String calendarId, String eventId, RemoveMeetingRoomsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveMeetingRoomsHeaders headers = new RemoveMeetingRoomsHeaders();
        return this.removeMeetingRoomsWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>回复日程邀请</p>
     * 
     * @param request RespondEventRequest
     * @param headers RespondEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RespondEventResponse
     */
    public RespondEventResponse respondEventWithOptions(String userId, String calendarId, String eventId, RespondEventRequest request, RespondEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.responseStatus)) {
            body.put("responseStatus", request.responseStatus);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RespondEvent"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/respond"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RespondEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>回复日程邀请</p>
     * 
     * @param request RespondEventRequest
     * @return RespondEventResponse
     */
    public RespondEventResponse respondEvent(String userId, String calendarId, String eventId, RespondEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RespondEventHeaders headers = new RespondEventHeaders();
        return this.respondEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>签到</p>
     * 
     * @param headers SignInHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SignInResponse
     */
    public SignInResponse signInWithOptions(String userId, String calendarId, String eventId, SignInHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SignIn"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signin"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SignInResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>签到</p>
     * @return SignInResponse
     */
    public SignInResponse signIn(String userId, String calendarId, String eventId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SignInHeaders headers = new SignInHeaders();
        return this.signInWithOptions(userId, calendarId, eventId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>签退</p>
     * 
     * @param headers SignOutHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SignOutResponse
     */
    public SignOutResponse signOutWithOptions(String userId, String calendarId, String eventId, SignOutHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SignOut"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/signOut"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SignOutResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>签退</p>
     * @return SignOutResponse
     */
    public SignOutResponse signOut(String userId, String calendarId, String eventId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SignOutHeaders headers = new SignOutHeaders();
        return this.signOutWithOptions(userId, calendarId, eventId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>订阅公共日历</p>
     * 
     * @param headers SubscribeCalendarHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SubscribeCalendarResponse
     */
    public SubscribeCalendarResponse subscribeCalendarWithOptions(String userId, String calendarId, SubscribeCalendarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SubscribeCalendar"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/subscribe"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SubscribeCalendarResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>订阅公共日历</p>
     * @return SubscribeCalendarResponse
     */
    public SubscribeCalendarResponse subscribeCalendar(String userId, String calendarId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SubscribeCalendarHeaders headers = new SubscribeCalendarHeaders();
        return this.subscribeCalendarWithOptions(userId, calendarId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>日程转让</p>
     * 
     * @param request TransferEventRequest
     * @param headers TransferEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TransferEventResponse
     */
    public TransferEventResponse transferEventWithOptions(String calendarId, String userId, String eventId, TransferEventRequest request, TransferEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isExitCalendar)) {
            body.put("isExitCalendar", request.isExitCalendar);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needNotifyViaO2O)) {
            body.put("needNotifyViaO2O", request.needNotifyViaO2O);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.newOrganizerId)) {
            body.put("newOrganizerId", request.newOrganizerId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xClientToken)) {
            realHeaders.put("x-client-token", com.aliyun.teautil.Common.toJSONString(headers.xClientToken));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "TransferEvent"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/events/" + eventId + "/transfer"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TransferEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>日程转让</p>
     * 
     * @param request TransferEventRequest
     * @return TransferEventResponse
     */
    public TransferEventResponse transferEvent(String calendarId, String userId, String eventId, TransferEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TransferEventHeaders headers = new TransferEventHeaders();
        return this.transferEventWithOptions(calendarId, userId, eventId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>取消订阅公共日历</p>
     * 
     * @param headers UnsubscribeCalendarHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UnsubscribeCalendarResponse
     */
    public UnsubscribeCalendarResponse unsubscribeCalendarWithOptions(String userId, String calendarId, UnsubscribeCalendarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UnsubscribeCalendar"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/calendars/" + calendarId + "/unsubscribe"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UnsubscribeCalendarResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>取消订阅公共日历</p>
     * @return UnsubscribeCalendarResponse
     */
    public UnsubscribeCalendarResponse unsubscribeCalendar(String userId, String calendarId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UnsubscribeCalendarHeaders headers = new UnsubscribeCalendarHeaders();
        return this.unsubscribeCalendarWithOptions(userId, calendarId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新指定订阅日历</p>
     * 
     * @param request UpdateSubscribedCalendarsRequest
     * @param headers UpdateSubscribedCalendarsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateSubscribedCalendarsResponse
     */
    public UpdateSubscribedCalendarsResponse updateSubscribedCalendarsWithOptions(String calendarId, String userId, UpdateSubscribedCalendarsRequest request, UpdateSubscribedCalendarsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        if (!com.aliyun.teautil.Common.isUnset(request.subscribeScope)) {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateSubscribedCalendars"),
            new TeaPair("version", "calendar_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/calendar/users/" + userId + "/subscribedCalendars/" + calendarId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateSubscribedCalendarsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新指定订阅日历</p>
     * 
     * @param request UpdateSubscribedCalendarsRequest
     * @return UpdateSubscribedCalendarsResponse
     */
    public UpdateSubscribedCalendarsResponse updateSubscribedCalendars(String calendarId, String userId, UpdateSubscribedCalendarsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateSubscribedCalendarsHeaders headers = new UpdateSubscribedCalendarsHeaders();
        return this.updateSubscribedCalendarsWithOptions(calendarId, userId, request, headers, runtime);
    }
}
