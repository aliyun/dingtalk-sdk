// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkrooms_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public com.aliyun.gateway.spi.Client _client;
    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._client = new com.aliyun.gateway.dingtalk.Client();
        this._spi = _client;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
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
    public CreateDeviceCustomTemplateResponse createDeviceCustomTemplateWithOptions(CreateDeviceCustomTemplateRequest request, CreateDeviceCustomTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bgImgList)) {
            body.put("bgImgList", request.bgImgList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bgType)) {
            body.put("bgType", request.bgType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bgUrl)) {
            body.put("bgUrl", request.bgUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customDoc)) {
            body.put("customDoc", request.customDoc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.desensitizeUserName)) {
            body.put("desensitizeUserName", request.desensitizeUserName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceUnionIds)) {
            body.put("deviceUnionIds", request.deviceUnionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupIds)) {
            body.put("groupIds", request.groupIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideServerCodeWhenProjecting)) {
            body.put("hideServerCodeWhenProjecting", request.hideServerCodeWhenProjecting);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instruction)) {
            body.put("instruction", request.instruction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isPicTop)) {
            body.put("isPicTop", request.isPicTop);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.logo)) {
            body.put("logo", request.logo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgName)) {
            body.put("orgName", request.orgName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.picturePlayInterval)) {
            body.put("picturePlayInterval", request.picturePlayInterval);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomIds)) {
            body.put("roomIds", request.roomIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.showCalendarCard)) {
            body.put("showCalendarCard", request.showCalendarCard);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.showCalendarTitle)) {
            body.put("showCalendarTitle", request.showCalendarTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.showFunctionCard)) {
            body.put("showFunctionCard", request.showFunctionCard);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateName)) {
            body.put("templateName", request.templateName);
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
            new TeaPair("action", "CreateDeviceCustomTemplate"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/devices/screens/templates"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateDeviceCustomTemplateResponse());
    }

    /**
     * @summary 创建自定义屏幕模版
     *
     * @param request CreateDeviceCustomTemplateRequest
     * @return CreateDeviceCustomTemplateResponse
     */
    public CreateDeviceCustomTemplateResponse createDeviceCustomTemplate(CreateDeviceCustomTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDeviceCustomTemplateHeaders headers = new CreateDeviceCustomTemplateHeaders();
        return this.createDeviceCustomTemplateWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建智能会议室
     *
     * @param request CreateMeetingRoomRequest
     * @param headers CreateMeetingRoomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateMeetingRoomResponse
     */
    public CreateMeetingRoomResponse createMeetingRoomWithOptions(CreateMeetingRoomRequest request, CreateMeetingRoomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.enableCycleReservation)) {
            body.put("enableCycleReservation", request.enableCycleReservation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            body.put("groupId", request.groupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvRoomId)) {
            body.put("isvRoomId", request.isvRoomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reservationAuthority)) {
            body.put("reservationAuthority", request.reservationAuthority);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomCapacity)) {
            body.put("roomCapacity", request.roomCapacity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomLabelIds)) {
            body.put("roomLabelIds", request.roomLabelIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomLocation)) {
            body.put("roomLocation", request.roomLocation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomName)) {
            body.put("roomName", request.roomName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomPicture)) {
            body.put("roomPicture", request.roomPicture);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomStatus)) {
            body.put("roomStatus", request.roomStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "CreateMeetingRoom"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/meetingrooms"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateMeetingRoomResponse());
    }

    /**
     * @summary 创建智能会议室
     *
     * @param request CreateMeetingRoomRequest
     * @return CreateMeetingRoomResponse
     */
    public CreateMeetingRoomResponse createMeetingRoom(CreateMeetingRoomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateMeetingRoomHeaders headers = new CreateMeetingRoomHeaders();
        return this.createMeetingRoomWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建智能会议室IOT配置
     *
     * @param request CreateMeetingRoomControlPanelRequest
     * @param headers CreateMeetingRoomControlPanelHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateMeetingRoomControlPanelResponse
     */
    public CreateMeetingRoomControlPanelResponse createMeetingRoomControlPanelWithOptions(CreateMeetingRoomControlPanelRequest request, CreateMeetingRoomControlPanelHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.extra)) {
            body.put("extra", request.extra);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomConfig)) {
            body.put("roomConfig", request.roomConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomId)) {
            body.put("roomId", request.roomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "CreateMeetingRoomControlPanel"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/panels"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateMeetingRoomControlPanelResponse());
    }

    /**
     * @summary 创建智能会议室IOT配置
     *
     * @param request CreateMeetingRoomControlPanelRequest
     * @return CreateMeetingRoomControlPanelResponse
     */
    public CreateMeetingRoomControlPanelResponse createMeetingRoomControlPanel(CreateMeetingRoomControlPanelRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateMeetingRoomControlPanelHeaders headers = new CreateMeetingRoomControlPanelHeaders();
        return this.createMeetingRoomControlPanelWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建会议室分组
     *
     * @param request CreateMeetingRoomGroupRequest
     * @param headers CreateMeetingRoomGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateMeetingRoomGroupResponse
     */
    public CreateMeetingRoomGroupResponse createMeetingRoomGroupWithOptions(CreateMeetingRoomGroupRequest request, CreateMeetingRoomGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentGroupId)) {
            body.put("parentGroupId", request.parentGroupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "CreateMeetingRoomGroup"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/groups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateMeetingRoomGroupResponse());
    }

    /**
     * @summary 创建会议室分组
     *
     * @param request CreateMeetingRoomGroupRequest
     * @return CreateMeetingRoomGroupResponse
     */
    public CreateMeetingRoomGroupResponse createMeetingRoomGroup(CreateMeetingRoomGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateMeetingRoomGroupHeaders headers = new CreateMeetingRoomGroupHeaders();
        return this.createMeetingRoomGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 删除自定义屏幕模板
     *
     * @param request DeleteDeviceCustomTemplateRequest
     * @param headers DeleteDeviceCustomTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteDeviceCustomTemplateResponse
     */
    public DeleteDeviceCustomTemplateResponse deleteDeviceCustomTemplateWithOptions(DeleteDeviceCustomTemplateRequest request, DeleteDeviceCustomTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
            new TeaPair("action", "DeleteDeviceCustomTemplate"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/devices/screens/templates/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteDeviceCustomTemplateResponse());
    }

    /**
     * @summary 删除自定义屏幕模板
     *
     * @param request DeleteDeviceCustomTemplateRequest
     * @return DeleteDeviceCustomTemplateResponse
     */
    public DeleteDeviceCustomTemplateResponse deleteDeviceCustomTemplate(DeleteDeviceCustomTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteDeviceCustomTemplateHeaders headers = new DeleteDeviceCustomTemplateHeaders();
        return this.deleteDeviceCustomTemplateWithOptions(request, headers, runtime);
    }

    /**
     * @summary 删除会议室
     *
     * @param request DeleteMeetingRoomRequest
     * @param headers DeleteMeetingRoomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteMeetingRoomResponse
     */
    public DeleteMeetingRoomResponse deleteMeetingRoomWithOptions(String roomId, DeleteMeetingRoomRequest request, DeleteMeetingRoomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "DeleteMeetingRoom"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/meetingRooms/" + roomId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteMeetingRoomResponse());
    }

    /**
     * @summary 删除会议室
     *
     * @param request DeleteMeetingRoomRequest
     * @return DeleteMeetingRoomResponse
     */
    public DeleteMeetingRoomResponse deleteMeetingRoom(String roomId, DeleteMeetingRoomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteMeetingRoomHeaders headers = new DeleteMeetingRoomHeaders();
        return this.deleteMeetingRoomWithOptions(roomId, request, headers, runtime);
    }

    /**
     * @summary 删除会议室配置
     *
     * @param tmpReq DeleteMeetingRoomControlPanelRequest
     * @param headers DeleteMeetingRoomControlPanelHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteMeetingRoomControlPanelResponse
     */
    public DeleteMeetingRoomControlPanelResponse deleteMeetingRoomControlPanelWithOptions(DeleteMeetingRoomControlPanelRequest tmpReq, DeleteMeetingRoomControlPanelHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        DeleteMeetingRoomControlPanelShrinkRequest request = new DeleteMeetingRoomControlPanelShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.body)) {
            request.bodyShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bodyShrink)) {
            query.put("body", request.bodyShrink);
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
            new TeaPair("action", "DeleteMeetingRoomControlPanel"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/panels/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteMeetingRoomControlPanelResponse());
    }

    /**
     * @summary 删除会议室配置
     *
     * @param request DeleteMeetingRoomControlPanelRequest
     * @return DeleteMeetingRoomControlPanelResponse
     */
    public DeleteMeetingRoomControlPanelResponse deleteMeetingRoomControlPanel(DeleteMeetingRoomControlPanelRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteMeetingRoomControlPanelHeaders headers = new DeleteMeetingRoomControlPanelHeaders();
        return this.deleteMeetingRoomControlPanelWithOptions(request, headers, runtime);
    }

    /**
     * @summary 删除会议室分组
     *
     * @param request DeleteMeetingRoomGroupRequest
     * @param headers DeleteMeetingRoomGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteMeetingRoomGroupResponse
     */
    public DeleteMeetingRoomGroupResponse deleteMeetingRoomGroupWithOptions(String groupId, DeleteMeetingRoomGroupRequest request, DeleteMeetingRoomGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "DeleteMeetingRoomGroup"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/groups/" + groupId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteMeetingRoomGroupResponse());
    }

    /**
     * @summary 删除会议室分组
     *
     * @param request DeleteMeetingRoomGroupRequest
     * @return DeleteMeetingRoomGroupResponse
     */
    public DeleteMeetingRoomGroupResponse deleteMeetingRoomGroup(String groupId, DeleteMeetingRoomGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteMeetingRoomGroupHeaders headers = new DeleteMeetingRoomGroupHeaders();
        return this.deleteMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
    }

    /**
     * @summary 查询自定义屏幕模板
     *
     * @param headers QueryDeviceCustomTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDeviceCustomTemplateResponse
     */
    public QueryDeviceCustomTemplateResponse queryDeviceCustomTemplateWithOptions(String templateId, QueryDeviceCustomTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryDeviceCustomTemplate"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/devices/screens/templates/" + templateId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDeviceCustomTemplateResponse());
    }

    /**
     * @summary 查询自定义屏幕模板
     *
     * @return QueryDeviceCustomTemplateResponse
     */
    public QueryDeviceCustomTemplateResponse queryDeviceCustomTemplate(String templateId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDeviceCustomTemplateHeaders headers = new QueryDeviceCustomTemplateHeaders();
        return this.queryDeviceCustomTemplateWithOptions(templateId, headers, runtime);
    }

    /**
     * @summary 查询自定义屏幕模板列表
     *
     * @param headers QueryDeviceCustomTemplateListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDeviceCustomTemplateListResponse
     */
    public QueryDeviceCustomTemplateListResponse queryDeviceCustomTemplateListWithOptions(QueryDeviceCustomTemplateListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryDeviceCustomTemplateList"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/devices/screens/templateLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDeviceCustomTemplateListResponse());
    }

    /**
     * @summary 查询自定义屏幕模板列表
     *
     * @return QueryDeviceCustomTemplateListResponse
     */
    public QueryDeviceCustomTemplateListResponse queryDeviceCustomTemplateList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDeviceCustomTemplateListHeaders headers = new QueryDeviceCustomTemplateListHeaders();
        return this.queryDeviceCustomTemplateListWithOptions(headers, runtime);
    }

    /**
     * @summary 根据设备投屏码查询设备ip
     *
     * @param request QueryDeviceIpByCodeRequest
     * @param headers QueryDeviceIpByCodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDeviceIpByCodeResponse
     */
    public QueryDeviceIpByCodeResponse queryDeviceIpByCodeWithOptions(String shareCode, QueryDeviceIpByCodeRequest request, QueryDeviceIpByCodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceSn)) {
            query.put("deviceSn", request.deviceSn);
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
            new TeaPair("action", "QueryDeviceIpByCode"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/devices/shareCodes/" + shareCode + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDeviceIpByCodeResponse());
    }

    /**
     * @summary 根据设备投屏码查询设备ip
     *
     * @param request QueryDeviceIpByCodeRequest
     * @return QueryDeviceIpByCodeResponse
     */
    public QueryDeviceIpByCodeResponse queryDeviceIpByCode(String shareCode, QueryDeviceIpByCodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDeviceIpByCodeHeaders headers = new QueryDeviceIpByCodeHeaders();
        return this.queryDeviceIpByCodeWithOptions(shareCode, request, headers, runtime);
    }

    /**
     * @summary 查询设备属性
     *
     * @param request QueryDevicePropertiesRequest
     * @param headers QueryDevicePropertiesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDevicePropertiesResponse
     */
    public QueryDevicePropertiesResponse queryDevicePropertiesWithOptions(QueryDevicePropertiesRequest request, QueryDevicePropertiesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceId)) {
            query.put("deviceId", request.deviceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceUnionId)) {
            query.put("deviceUnionId", request.deviceUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            query.put("operatorUnionId", request.operatorUnionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.propertyNames)) {
            body.put("propertyNames", request.propertyNames);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryDeviceProperties"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/devices/properties/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDevicePropertiesResponse());
    }

    /**
     * @summary 查询设备属性
     *
     * @param request QueryDevicePropertiesRequest
     * @return QueryDevicePropertiesResponse
     */
    public QueryDevicePropertiesResponse queryDeviceProperties(QueryDevicePropertiesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDevicePropertiesHeaders headers = new QueryDevicePropertiesHeaders();
        return this.queryDevicePropertiesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询会议室详情
     *
     * @param request QueryMeetingRoomRequest
     * @param headers QueryMeetingRoomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMeetingRoomResponse
     */
    public QueryMeetingRoomResponse queryMeetingRoomWithOptions(String roomId, QueryMeetingRoomRequest request, QueryMeetingRoomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "QueryMeetingRoom"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/meetingRooms/" + roomId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMeetingRoomResponse());
    }

    /**
     * @summary 查询会议室详情
     *
     * @param request QueryMeetingRoomRequest
     * @return QueryMeetingRoomResponse
     */
    public QueryMeetingRoomResponse queryMeetingRoom(String roomId, QueryMeetingRoomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMeetingRoomHeaders headers = new QueryMeetingRoomHeaders();
        return this.queryMeetingRoomWithOptions(roomId, request, headers, runtime);
    }

    /**
     * @summary 获取会议室IOT配置列表
     *
     * @param request QueryMeetingRoomControlPanelListRequest
     * @param headers QueryMeetingRoomControlPanelListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMeetingRoomControlPanelListResponse
     */
    public QueryMeetingRoomControlPanelListResponse queryMeetingRoomControlPanelListWithOptions(QueryMeetingRoomControlPanelListRequest request, QueryMeetingRoomControlPanelListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomId)) {
            query.put("roomId", request.roomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "QueryMeetingRoomControlPanelList"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/panels/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMeetingRoomControlPanelListResponse());
    }

    /**
     * @summary 获取会议室IOT配置列表
     *
     * @param request QueryMeetingRoomControlPanelListRequest
     * @return QueryMeetingRoomControlPanelListResponse
     */
    public QueryMeetingRoomControlPanelListResponse queryMeetingRoomControlPanelList(QueryMeetingRoomControlPanelListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMeetingRoomControlPanelListHeaders headers = new QueryMeetingRoomControlPanelListHeaders();
        return this.queryMeetingRoomControlPanelListWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询设备信息
     *
     * @param request QueryMeetingRoomDeviceRequest
     * @param headers QueryMeetingRoomDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMeetingRoomDeviceResponse
     */
    public QueryMeetingRoomDeviceResponse queryMeetingRoomDeviceWithOptions(QueryMeetingRoomDeviceRequest request, QueryMeetingRoomDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceId)) {
            query.put("deviceId", request.deviceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceUnionId)) {
            query.put("deviceUnionId", request.deviceUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            query.put("operatorUnionId", request.operatorUnionId);
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
            new TeaPair("action", "QueryMeetingRoomDevice"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/devices"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMeetingRoomDeviceResponse());
    }

    /**
     * @summary 查询设备信息
     *
     * @param request QueryMeetingRoomDeviceRequest
     * @return QueryMeetingRoomDeviceResponse
     */
    public QueryMeetingRoomDeviceResponse queryMeetingRoomDevice(QueryMeetingRoomDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMeetingRoomDeviceHeaders headers = new QueryMeetingRoomDeviceHeaders();
        return this.queryMeetingRoomDeviceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询会议室分组信息
     *
     * @param request QueryMeetingRoomGroupRequest
     * @param headers QueryMeetingRoomGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMeetingRoomGroupResponse
     */
    public QueryMeetingRoomGroupResponse queryMeetingRoomGroupWithOptions(String groupId, QueryMeetingRoomGroupRequest request, QueryMeetingRoomGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "QueryMeetingRoomGroup"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/groups/" + groupId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMeetingRoomGroupResponse());
    }

    /**
     * @summary 查询会议室分组信息
     *
     * @param request QueryMeetingRoomGroupRequest
     * @return QueryMeetingRoomGroupResponse
     */
    public QueryMeetingRoomGroupResponse queryMeetingRoomGroup(String groupId, QueryMeetingRoomGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMeetingRoomGroupHeaders headers = new QueryMeetingRoomGroupHeaders();
        return this.queryMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
    }

    /**
     * @summary 查询会议室分组列表
     *
     * @param request QueryMeetingRoomGroupListRequest
     * @param headers QueryMeetingRoomGroupListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMeetingRoomGroupListResponse
     */
    public QueryMeetingRoomGroupListResponse queryMeetingRoomGroupListWithOptions(QueryMeetingRoomGroupListRequest request, QueryMeetingRoomGroupListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "QueryMeetingRoomGroupList"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/groupLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMeetingRoomGroupListResponse());
    }

    /**
     * @summary 查询会议室分组列表
     *
     * @param request QueryMeetingRoomGroupListRequest
     * @return QueryMeetingRoomGroupListResponse
     */
    public QueryMeetingRoomGroupListResponse queryMeetingRoomGroupList(QueryMeetingRoomGroupListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMeetingRoomGroupListHeaders headers = new QueryMeetingRoomGroupListHeaders();
        return this.queryMeetingRoomGroupListWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询会议室列表
     *
     * @param request QueryMeetingRoomListRequest
     * @param headers QueryMeetingRoomListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMeetingRoomListResponse
     */
    public QueryMeetingRoomListResponse queryMeetingRoomListWithOptions(QueryMeetingRoomListRequest request, QueryMeetingRoomListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "QueryMeetingRoomList"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/meetingRoomLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMeetingRoomListResponse());
    }

    /**
     * @summary 查询会议室列表
     *
     * @param request QueryMeetingRoomListRequest
     * @return QueryMeetingRoomListResponse
     */
    public QueryMeetingRoomListResponse queryMeetingRoomList(QueryMeetingRoomListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMeetingRoomListHeaders headers = new QueryMeetingRoomListHeaders();
        return this.queryMeetingRoomListWithOptions(request, headers, runtime);
    }

    /**
     * @summary 取消会议室高级用户模式。
     *
     * @param request RemoveSuperUserMeetingRoomRequest
     * @param headers RemoveSuperUserMeetingRoomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveSuperUserMeetingRoomResponse
     */
    public RemoveSuperUserMeetingRoomResponse removeSuperUserMeetingRoomWithOptions(RemoveSuperUserMeetingRoomRequest request, RemoveSuperUserMeetingRoomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.roomId)) {
            query.put("roomId", request.roomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "RemoveSuperUserMeetingRoom"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/meetingRooms/superUsers/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveSuperUserMeetingRoomResponse());
    }

    /**
     * @summary 取消会议室高级用户模式。
     *
     * @param request RemoveSuperUserMeetingRoomRequest
     * @return RemoveSuperUserMeetingRoomResponse
     */
    public RemoveSuperUserMeetingRoomResponse removeSuperUserMeetingRoom(RemoveSuperUserMeetingRoomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveSuperUserMeetingRoomHeaders headers = new RemoveSuperUserMeetingRoomHeaders();
        return this.removeSuperUserMeetingRoomWithOptions(request, headers, runtime);
    }

    /**
     * @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
     *
     * @param request SetSuperUserMeetingRoomRequest
     * @param headers SetSuperUserMeetingRoomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetSuperUserMeetingRoomResponse
     */
    public SetSuperUserMeetingRoomResponse setSuperUserMeetingRoomWithOptions(SetSuperUserMeetingRoomRequest request, SetSuperUserMeetingRoomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIdWhiteList)) {
            body.put("deptIdWhiteList", request.deptIdWhiteList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomId)) {
            body.put("roomId", request.roomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdWhiteList)) {
            body.put("userIdWhiteList", request.userIdWhiteList);
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
            new TeaPair("action", "SetSuperUserMeetingRoom"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/meetingRooms/superUsers/set"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetSuperUserMeetingRoomResponse());
    }

    /**
     * @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
     *
     * @param request SetSuperUserMeetingRoomRequest
     * @return SetSuperUserMeetingRoomResponse
     */
    public SetSuperUserMeetingRoomResponse setSuperUserMeetingRoom(SetSuperUserMeetingRoomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetSuperUserMeetingRoomHeaders headers = new SetSuperUserMeetingRoomHeaders();
        return this.setSuperUserMeetingRoomWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新自定义屏幕模板
     *
     * @param request UpdateDeviceCustomTemplateRequest
     * @param headers UpdateDeviceCustomTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateDeviceCustomTemplateResponse
     */
    public UpdateDeviceCustomTemplateResponse updateDeviceCustomTemplateWithOptions(UpdateDeviceCustomTemplateRequest request, UpdateDeviceCustomTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bgImgList)) {
            body.put("bgImgList", request.bgImgList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bgType)) {
            body.put("bgType", request.bgType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bgUrl)) {
            body.put("bgUrl", request.bgUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customDoc)) {
            body.put("customDoc", request.customDoc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.desensitizeUserName)) {
            body.put("desensitizeUserName", request.desensitizeUserName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceUnionIds)) {
            body.put("deviceUnionIds", request.deviceUnionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupIds)) {
            body.put("groupIds", request.groupIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideServerCodeWhenProjecting)) {
            body.put("hideServerCodeWhenProjecting", request.hideServerCodeWhenProjecting);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instruction)) {
            body.put("instruction", request.instruction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isPicTop)) {
            body.put("isPicTop", request.isPicTop);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.logo)) {
            body.put("logo", request.logo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgName)) {
            body.put("orgName", request.orgName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.picturePlayInterval)) {
            body.put("picturePlayInterval", request.picturePlayInterval);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomIds)) {
            body.put("roomIds", request.roomIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.showCalendarCard)) {
            body.put("showCalendarCard", request.showCalendarCard);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.showCalendarTitle)) {
            body.put("showCalendarTitle", request.showCalendarTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.showFunctionCard)) {
            body.put("showFunctionCard", request.showFunctionCard);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateName)) {
            body.put("templateName", request.templateName);
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
            new TeaPair("action", "UpdateDeviceCustomTemplate"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/devices/screens/templates"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateDeviceCustomTemplateResponse());
    }

    /**
     * @summary 更新自定义屏幕模板
     *
     * @param request UpdateDeviceCustomTemplateRequest
     * @return UpdateDeviceCustomTemplateResponse
     */
    public UpdateDeviceCustomTemplateResponse updateDeviceCustomTemplate(UpdateDeviceCustomTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateDeviceCustomTemplateHeaders headers = new UpdateDeviceCustomTemplateHeaders();
        return this.updateDeviceCustomTemplateWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新会议室信息
     *
     * @param request UpdateMeetingRoomRequest
     * @param headers UpdateMeetingRoomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateMeetingRoomResponse
     */
    public UpdateMeetingRoomResponse updateMeetingRoomWithOptions(UpdateMeetingRoomRequest request, UpdateMeetingRoomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.enableCycleReservation)) {
            body.put("enableCycleReservation", request.enableCycleReservation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            body.put("groupId", request.groupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvRoomId)) {
            body.put("isvRoomId", request.isvRoomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reservationAuthority)) {
            body.put("reservationAuthority", request.reservationAuthority);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomCapacity)) {
            body.put("roomCapacity", request.roomCapacity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomId)) {
            body.put("roomId", request.roomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomLabelIds)) {
            body.put("roomLabelIds", request.roomLabelIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomLocation)) {
            body.put("roomLocation", request.roomLocation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomName)) {
            body.put("roomName", request.roomName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomPicture)) {
            body.put("roomPicture", request.roomPicture);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roomStatus)) {
            body.put("roomStatus", request.roomStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "UpdateMeetingRoom"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/meetingRooms"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateMeetingRoomResponse());
    }

    /**
     * @summary 更新会议室信息
     *
     * @param request UpdateMeetingRoomRequest
     * @return UpdateMeetingRoomResponse
     */
    public UpdateMeetingRoomResponse updateMeetingRoom(UpdateMeetingRoomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateMeetingRoomHeaders headers = new UpdateMeetingRoomHeaders();
        return this.updateMeetingRoomWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新会议室分组
     *
     * @param request UpdateMeetingRoomGroupRequest
     * @param headers UpdateMeetingRoomGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateMeetingRoomGroupResponse
     */
    public UpdateMeetingRoomGroupResponse updateMeetingRoomGroupWithOptions(UpdateMeetingRoomGroupRequest request, UpdateMeetingRoomGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            body.put("groupId", request.groupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "UpdateMeetingRoomGroup"),
            new TeaPair("version", "rooms_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rooms/groups"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateMeetingRoomGroupResponse());
    }

    /**
     * @summary 更新会议室分组
     *
     * @param request UpdateMeetingRoomGroupRequest
     * @return UpdateMeetingRoomGroupResponse
     */
    public UpdateMeetingRoomGroupResponse updateMeetingRoomGroup(UpdateMeetingRoomGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateMeetingRoomGroupHeaders headers = new UpdateMeetingRoomGroupHeaders();
        return this.updateMeetingRoomGroupWithOptions(request, headers, runtime);
    }
}
