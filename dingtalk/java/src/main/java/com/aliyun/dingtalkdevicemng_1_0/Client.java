// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdevicemng_1_0.models.*;

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
     * @summary 批量注册设备
     *
     * @param request BatchRegisterDeviceRequest
     * @param headers BatchRegisterDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchRegisterDeviceResponse
     */
    public BatchRegisterDeviceResponse batchRegisterDeviceWithOptions(BatchRegisterDeviceRequest request, BatchRegisterDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceList)) {
            body.put("deviceList", request.deviceList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "BatchRegisterDevice"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/devices/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchRegisterDeviceResponse());
    }

    /**
     * @summary 批量注册设备
     *
     * @param request BatchRegisterDeviceRequest
     * @return BatchRegisterDeviceResponse
     */
    public BatchRegisterDeviceResponse batchRegisterDevice(BatchRegisterDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchRegisterDeviceHeaders headers = new BatchRegisterDeviceHeaders();
        return this.batchRegisterDeviceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 想设备上钉连接器推送设备事件
     *
     * @param request ConnectorEventPushRequest
     * @param headers ConnectorEventPushHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConnectorEventPushResponse
     */
    public ConnectorEventPushResponse connectorEventPushWithOptions(ConnectorEventPushRequest request, ConnectorEventPushHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceTypeUuid)) {
            body.put("deviceTypeUuid", request.deviceTypeUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventName)) {
            body.put("eventName", request.eventName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.input)) {
            body.put("input", request.input);
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
            new TeaPair("action", "ConnectorEventPush"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/connectors/events/push"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConnectorEventPushResponse());
    }

    /**
     * @summary 想设备上钉连接器推送设备事件
     *
     * @param request ConnectorEventPushRequest
     * @return ConnectorEventPushResponse
     */
    public ConnectorEventPushResponse connectorEventPush(ConnectorEventPushRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConnectorEventPushHeaders headers = new ConnectorEventPushHeaders();
        return this.connectorEventPushWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建设备群
     *
     * @param request CreateChatRoomRequest
     * @param headers CreateChatRoomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateChatRoomResponse
     */
    public CreateChatRoomResponse createChatRoomWithOptions(CreateChatRoomRequest request, CreateChatRoomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.chatGroupName)) {
            body.put("chatGroupName", request.chatGroupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceCodes)) {
            body.put("deviceCodes", request.deviceCodes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceTypeId)) {
            body.put("deviceTypeId", request.deviceTypeId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownerUserId)) {
            body.put("ownerUserId", request.ownerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleList)) {
            body.put("roleList", request.roleList);
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
            new TeaPair("action", "CreateChatRoom"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/chatRoom"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateChatRoomResponse());
    }

    /**
     * @summary 创建设备群
     *
     * @param request CreateChatRoomRequest
     * @return CreateChatRoomResponse
     */
    public CreateChatRoomResponse createChatRoom(CreateChatRoomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateChatRoomHeaders headers = new CreateChatRoomHeaders();
        return this.createChatRoomWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建部门
     *
     * @param request CreateDepartmentRequest
     * @param headers CreateDepartmentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateDepartmentResponse
     */
    public CreateDepartmentResponse createDepartmentWithOptions(CreateDepartmentRequest request, CreateDepartmentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authInfo)) {
            body.put("authInfo", request.authInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authType)) {
            body.put("authType", request.authType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizExt)) {
            body.put("bizExt", request.bizExt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentName)) {
            body.put("departmentName", request.departmentName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentType)) {
            body.put("departmentType", request.departmentType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemUrl)) {
            body.put("systemUrl", request.systemUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "CreateDepartment"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/departments"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateDepartmentResponse());
    }

    /**
     * @summary 创建部门
     *
     * @param request CreateDepartmentRequest
     * @return CreateDepartmentResponse
     */
    public CreateDepartmentResponse createDepartment(CreateDepartmentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDepartmentHeaders headers = new CreateDepartmentHeaders();
        return this.createDepartmentWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建设备场景群
     *
     * @param request CreateDeviceChatRoomRequest
     * @param headers CreateDeviceChatRoomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateDeviceChatRoomResponse
     */
    public CreateDeviceChatRoomResponse createDeviceChatRoomWithOptions(CreateDeviceChatRoomRequest request, CreateDeviceChatRoomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.chatType)) {
            body.put("chatType", request.chatType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceCodes)) {
            body.put("deviceCodes", request.deviceCodes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceUuids)) {
            body.put("deviceUuids", request.deviceUuids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownerUserId)) {
            body.put("ownerUserId", request.ownerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
            new TeaPair("action", "CreateDeviceChatRoom"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/chatRooms/groups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateDeviceChatRoomResponse());
    }

    /**
     * @summary 创建设备场景群
     *
     * @param request CreateDeviceChatRoomRequest
     * @return CreateDeviceChatRoomResponse
     */
    public CreateDeviceChatRoomResponse createDeviceChatRoom(CreateDeviceChatRoomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDeviceChatRoomHeaders headers = new CreateDeviceChatRoomHeaders();
        return this.createDeviceChatRoomWithOptions(request, headers, runtime);
    }

    /**
     * @summary 设备账号向目标用户发送ding消息
     *
     * @param request DeviceDingRequest
     * @param headers DeviceDingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeviceDingResponse
     */
    public DeviceDingResponse deviceDingWithOptions(DeviceDingRequest request, DeviceDingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceKey)) {
            body.put("deviceKey", request.deviceKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.paramsJson)) {
            body.put("paramsJson", request.paramsJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserIdList)) {
            body.put("receiverUserIdList", request.receiverUserIdList);
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
            new TeaPair("action", "DeviceDing"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/ding"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeviceDingResponse());
    }

    /**
     * @summary 设备账号向目标用户发送ding消息
     *
     * @param request DeviceDingRequest
     * @return DeviceDingResponse
     */
    public DeviceDingResponse deviceDing(DeviceDingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeviceDingHeaders headers = new DeviceDingHeaders();
        return this.deviceDingWithOptions(request, headers, runtime);
    }

    /**
     * @summary 解散设备群
     *
     * @param request DissolveGroupRequest
     * @param headers DissolveGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DissolveGroupResponse
     */
    public DissolveGroupResponse dissolveGroupWithOptions(DissolveGroupRequest request, DissolveGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
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
            new TeaPair("action", "DissolveGroup"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/chatRooms/groups/dissolve"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DissolveGroupResponse());
    }

    /**
     * @summary 解散设备群
     *
     * @param request DissolveGroupRequest
     * @return DissolveGroupResponse
     */
    public DissolveGroupResponse dissolveGroup(DissolveGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DissolveGroupHeaders headers = new DissolveGroupHeaders();
        return this.dissolveGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 编辑设备管理员
     *
     * @param request EditDeviceAdminRequest
     * @param headers EditDeviceAdminHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditDeviceAdminResponse
     */
    public EditDeviceAdminResponse editDeviceAdminWithOptions(EditDeviceAdminRequest request, EditDeviceAdminHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceCode)) {
            body.put("deviceCode", request.deviceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleUuid)) {
            body.put("roleUuid", request.roleUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
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
            new TeaPair("action", "EditDeviceAdmin"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/devices/administrators/edit"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditDeviceAdminResponse());
    }

    /**
     * @summary 编辑设备管理员
     *
     * @param request EditDeviceAdminRequest
     * @return EditDeviceAdminResponse
     */
    public EditDeviceAdminResponse editDeviceAdmin(EditDeviceAdminRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditDeviceAdminHeaders headers = new EditDeviceAdminHeaders();
        return this.editDeviceAdminWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取设备群信息
     *
     * @param request GetDeviceGroupInfoRequest
     * @param headers GetDeviceGroupInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDeviceGroupInfoResponse
     */
    public GetDeviceGroupInfoResponse getDeviceGroupInfoWithOptions(GetDeviceGroupInfoRequest request, GetDeviceGroupInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
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
            new TeaPair("action", "GetDeviceGroupInfo"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/chatRooms/groupInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDeviceGroupInfoResponse());
    }

    /**
     * @summary 获取设备群信息
     *
     * @param request GetDeviceGroupInfoRequest
     * @return GetDeviceGroupInfoResponse
     */
    public GetDeviceGroupInfoResponse getDeviceGroupInfo(GetDeviceGroupInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDeviceGroupInfoHeaders headers = new GetDeviceGroupInfoHeaders();
        return this.getDeviceGroupInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取设备全员群标识
     *
     * @param headers GetWholeDeviceGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetWholeDeviceGroupResponse
     */
    public GetWholeDeviceGroupResponse getWholeDeviceGroupWithOptions(GetWholeDeviceGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetWholeDeviceGroup"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/chatRooms/wholeGroupId"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetWholeDeviceGroupResponse());
    }

    /**
     * @summary 获取设备全员群标识
     *
     * @return GetWholeDeviceGroupResponse
     */
    public GetWholeDeviceGroupResponse getWholeDeviceGroup() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetWholeDeviceGroupHeaders headers = new GetWholeDeviceGroupHeaders();
        return this.getWholeDeviceGroupWithOptions(headers, runtime);
    }

    /**
     * @summary 查询激活的设备信息
     *
     * @param request ListActivateDevicesRequest
     * @param headers ListActivateDevicesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListActivateDevicesResponse
     */
    public ListActivateDevicesResponse listActivateDevicesWithOptions(ListActivateDevicesRequest request, ListActivateDevicesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceCategory)) {
            query.put("deviceCategory", request.deviceCategory);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceCode)) {
            query.put("deviceCode", request.deviceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceTypeId)) {
            query.put("deviceTypeId", request.deviceTypeId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            query.put("groupId", request.groupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
            new TeaPair("action", "ListActivateDevices"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/devices/activations/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListActivateDevicesResponse());
    }

    /**
     * @summary 查询激活的设备信息
     *
     * @param request ListActivateDevicesRequest
     * @return ListActivateDevicesResponse
     */
    public ListActivateDevicesResponse listActivateDevices(ListActivateDevicesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListActivateDevicesHeaders headers = new ListActivateDevicesHeaders();
        return this.listActivateDevicesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取巡检、保养记录
     *
     * @param request ListInspectInfoRequest
     * @param headers ListInspectInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListInspectInfoResponse
     */
    public ListInspectInfoResponse listInspectInfoWithOptions(ListInspectInfoRequest request, ListInspectInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceUuid)) {
            body.put("deviceUuid", request.deviceUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
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
            new TeaPair("action", "ListInspectInfo"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/devices/inspectInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListInspectInfoResponse());
    }

    /**
     * @summary 获取巡检、保养记录
     *
     * @param request ListInspectInfoRequest
     * @return ListInspectInfoResponse
     */
    public ListInspectInfoResponse listInspectInfo(ListInspectInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListInspectInfoHeaders headers = new ListInspectInfoHeaders();
        return this.listInspectInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取报修信息
     *
     * @param request ListMaintainInfoRequest
     * @param headers ListMaintainInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListMaintainInfoResponse
     */
    public ListMaintainInfoResponse listMaintainInfoWithOptions(ListMaintainInfoRequest request, ListMaintainInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceUuid)) {
            body.put("deviceUuid", request.deviceUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
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
            new TeaPair("action", "ListMaintainInfo"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/devices/maintainInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListMaintainInfoResponse());
    }

    /**
     * @summary 获取报修信息
     *
     * @param request ListMaintainInfoRequest
     * @return ListMaintainInfoResponse
     */
    public ListMaintainInfoResponse listMaintainInfo(ListMaintainInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListMaintainInfoHeaders headers = new ListMaintainInfoHeaders();
        return this.listMaintainInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 拉设备进群
     *
     * @param request PullDeviceToGroupRequest
     * @param headers PullDeviceToGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PullDeviceToGroupResponse
     */
    public PullDeviceToGroupResponse pullDeviceToGroupWithOptions(PullDeviceToGroupRequest request, PullDeviceToGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceCodes)) {
            body.put("deviceCodes", request.deviceCodes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceUuids)) {
            body.put("deviceUuids", request.deviceUuids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
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
            new TeaPair("action", "PullDeviceToGroup"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/chatRooms/devices"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PullDeviceToGroupResponse());
    }

    /**
     * @summary 拉设备进群
     *
     * @param request PullDeviceToGroupRequest
     * @return PullDeviceToGroupResponse
     */
    public PullDeviceToGroupResponse pullDeviceToGroup(PullDeviceToGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PullDeviceToGroupHeaders headers = new PullDeviceToGroupHeaders();
        return this.pullDeviceToGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 拉设用户进群
     *
     * @param request PullUserToGroupRequest
     * @param headers PullUserToGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PullUserToGroupResponse
     */
    public PullUserToGroupResponse pullUserToGroupWithOptions(PullUserToGroupRequest request, PullUserToGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
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
            new TeaPair("action", "PullUserToGroup"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/chatRooms/users"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PullUserToGroupResponse());
    }

    /**
     * @summary 拉设用户进群
     *
     * @param request PullUserToGroupRequest
     * @return PullUserToGroupResponse
     */
    public PullUserToGroupResponse pullUserToGroup(PullUserToGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PullUserToGroupHeaders headers = new PullUserToGroupHeaders();
        return this.pullUserToGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 注册与激活设备
     *
     * @param request RegisterAndActivateDeviceRequest
     * @param headers RegisterAndActivateDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RegisterAndActivateDeviceResponse
     */
    public RegisterAndActivateDeviceResponse registerAndActivateDeviceWithOptions(RegisterAndActivateDeviceRequest request, RegisterAndActivateDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceCallbackUrl)) {
            body.put("deviceCallbackUrl", request.deviceCallbackUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceCategory)) {
            body.put("deviceCategory", request.deviceCategory);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceCode)) {
            body.put("deviceCode", request.deviceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceDetailUrl)) {
            body.put("deviceDetailUrl", request.deviceDetailUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceName)) {
            body.put("deviceName", request.deviceName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.introduction)) {
            body.put("introduction", request.introduction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleUuid)) {
            body.put("roleUuid", request.roleUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.typeUuid)) {
            body.put("typeUuid", request.typeUuid);
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
            new TeaPair("action", "RegisterAndActivateDevice"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/devices/registerAndActivate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RegisterAndActivateDeviceResponse());
    }

    /**
     * @summary 注册与激活设备
     *
     * @param request RegisterAndActivateDeviceRequest
     * @return RegisterAndActivateDeviceResponse
     */
    public RegisterAndActivateDeviceResponse registerAndActivateDevice(RegisterAndActivateDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterAndActivateDeviceHeaders headers = new RegisterAndActivateDeviceHeaders();
        return this.registerAndActivateDeviceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量注册与激活设备
     *
     * @param request RegisterAndActivateDeviceBatchRequest
     * @param headers RegisterAndActivateDeviceBatchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RegisterAndActivateDeviceBatchResponse
     */
    public RegisterAndActivateDeviceBatchResponse registerAndActivateDeviceBatchWithOptions(RegisterAndActivateDeviceBatchRequest request, RegisterAndActivateDeviceBatchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.registerAndActivateVOS)) {
            body.put("registerAndActivateVOS", request.registerAndActivateVOS);
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
            new TeaPair("action", "RegisterAndActivateDeviceBatch"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/devices/registrationActivations/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RegisterAndActivateDeviceBatchResponse());
    }

    /**
     * @summary 批量注册与激活设备
     *
     * @param request RegisterAndActivateDeviceBatchRequest
     * @return RegisterAndActivateDeviceBatchResponse
     */
    public RegisterAndActivateDeviceBatchResponse registerAndActivateDeviceBatch(RegisterAndActivateDeviceBatchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterAndActivateDeviceBatchHeaders headers = new RegisterAndActivateDeviceBatchHeaders();
        return this.registerAndActivateDeviceBatchWithOptions(request, headers, runtime);
    }

    /**
     * @summary 注册设备并为其创建机器人
     *
     * @param request RegisterDeviceRequest
     * @param headers RegisterDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RegisterDeviceResponse
     */
    public RegisterDeviceResponse registerDeviceWithOptions(RegisterDeviceRequest request, RegisterDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.collaborators)) {
            body.put("collaborators", request.collaborators);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            body.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceKey)) {
            body.put("deviceKey", request.deviceKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceName)) {
            body.put("deviceName", request.deviceName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managers)) {
            body.put("managers", request.managers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "RegisterDevice"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/devices"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RegisterDeviceResponse());
    }

    /**
     * @summary 注册设备并为其创建机器人
     *
     * @param request RegisterDeviceRequest
     * @return RegisterDeviceResponse
     */
    public RegisterDeviceResponse registerDevice(RegisterDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterDeviceHeaders headers = new RegisterDeviceHeaders();
        return this.registerDeviceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 移设备出群
     *
     * @param request RemoveDeviceFromGroupRequest
     * @param headers RemoveDeviceFromGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveDeviceFromGroupResponse
     */
    public RemoveDeviceFromGroupResponse removeDeviceFromGroupWithOptions(RemoveDeviceFromGroupRequest request, RemoveDeviceFromGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceCodes)) {
            body.put("deviceCodes", request.deviceCodes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceUuids)) {
            body.put("deviceUuids", request.deviceUuids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
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
            new TeaPair("action", "RemoveDeviceFromGroup"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/chatRooms/devices/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveDeviceFromGroupResponse());
    }

    /**
     * @summary 移设备出群
     *
     * @param request RemoveDeviceFromGroupRequest
     * @return RemoveDeviceFromGroupResponse
     */
    public RemoveDeviceFromGroupResponse removeDeviceFromGroup(RemoveDeviceFromGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveDeviceFromGroupHeaders headers = new RemoveDeviceFromGroupHeaders();
        return this.removeDeviceFromGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 移用户出设备群
     *
     * @param request RemoveUserFromGroupRequest
     * @param headers RemoveUserFromGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveUserFromGroupResponse
     */
    public RemoveUserFromGroupResponse removeUserFromGroupWithOptions(RemoveUserFromGroupRequest request, RemoveUserFromGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
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
            new TeaPair("action", "RemoveUserFromGroup"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/chatRooms/users/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveUserFromGroupResponse());
    }

    /**
     * @summary 移用户出设备群
     *
     * @param request RemoveUserFromGroupRequest
     * @return RemoveUserFromGroupResponse
     */
    public RemoveUserFromGroupResponse removeUserFromGroup(RemoveUserFromGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveUserFromGroupHeaders headers = new RemoveUserFromGroupHeaders();
        return this.removeUserFromGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 发送卡片
     *
     * @param request SendCardRequest
     * @param headers SendCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendCardResponse
     */
    public SendCardResponse sendCardWithOptions(SendCardRequest request, SendCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardData)) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceCode)) {
            body.put("deviceCode", request.deviceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceUuid)) {
            body.put("deviceUuid", request.deviceUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.partVisible)) {
            body.put("partVisible", request.partVisible);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receivers)) {
            body.put("receivers", request.receivers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topbox)) {
            body.put("topbox", request.topbox);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SendCard"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/cards/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendCardResponse());
    }

    /**
     * @summary 发送卡片
     *
     * @param request SendCardRequest
     * @return SendCardResponse
     */
    public SendCardResponse sendCard(SendCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendCardHeaders headers = new SendCardHeaders();
        return this.sendCardWithOptions(request, headers, runtime);
    }

    /**
     * @summary 发送普通消息
     *
     * @param request SendMsgRequest
     * @param headers SendMsgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendMsgResponse
     */
    public SendMsgResponse sendMsgWithOptions(SendMsgRequest request, SendMsgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceCode)) {
            body.put("deviceCode", request.deviceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceUuid)) {
            body.put("deviceUuid", request.deviceUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userList)) {
            body.put("userList", request.userList);
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
            new TeaPair("action", "SendMsg"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/messages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendMsgResponse());
    }

    /**
     * @summary 发送普通消息
     *
     * @param request SendMsgRequest
     * @return SendMsgResponse
     */
    public SendMsgResponse sendMsg(SendMsgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendMsgHeaders headers = new SendMsgHeaders();
        return this.sendMsgWithOptions(request, headers, runtime);
    }

    /**
     * @summary 卸载设备
     *
     * @param request UninstallDeviceRobotRequest
     * @param headers UninstallDeviceRobotHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UninstallDeviceRobotResponse
     */
    public UninstallDeviceRobotResponse uninstallDeviceRobotWithOptions(UninstallDeviceRobotRequest request, UninstallDeviceRobotHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceCode)) {
            body.put("deviceCode", request.deviceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
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
            new TeaPair("action", "UninstallDeviceRobot"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/devices/uninstall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UninstallDeviceRobotResponse());
    }

    /**
     * @summary 卸载设备
     *
     * @param request UninstallDeviceRobotRequest
     * @return UninstallDeviceRobotResponse
     */
    public UninstallDeviceRobotResponse uninstallDeviceRobot(UninstallDeviceRobotRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UninstallDeviceRobotHeaders headers = new UninstallDeviceRobotHeaders();
        return this.uninstallDeviceRobotWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新卡片
     *
     * @param request UpdateCardRequest
     * @param headers UpdateCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCardResponse
     */
    public UpdateCardResponse updateCardWithOptions(UpdateCardRequest request, UpdateCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardData)) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tips)) {
            body.put("tips", request.tips);
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
            new TeaPair("action", "UpdateCard"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/customers/cards"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCardResponse());
    }

    /**
     * @summary 更新卡片
     *
     * @param request UpdateCardRequest
     * @return UpdateCardResponse
     */
    public UpdateCardResponse updateCard(UpdateCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCardHeaders headers = new UpdateCardHeaders();
        return this.updateCardWithOptions(request, headers, runtime);
    }

    /**
     * @summary 设备事件上报
     *
     * @param request UploadEventRequest
     * @param headers UploadEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UploadEventResponse
     */
    public UploadEventResponse uploadEventWithOptions(UploadEventRequest request, UploadEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coverUrl)) {
            body.put("coverUrl", request.coverUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceCode)) {
            body.put("deviceCode", request.deviceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceUuid)) {
            body.put("deviceUuid", request.deviceUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventTime)) {
            body.put("eventTime", request.eventTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventType)) {
            body.put("eventType", request.eventType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.level)) {
            body.put("level", request.level);
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
            new TeaPair("action", "UploadEvent"),
            new TeaPair("version", "devicemng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/devicemng/suppliers/events/upload"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UploadEventResponse());
    }

    /**
     * @summary 设备事件上报
     *
     * @param request UploadEventRequest
     * @return UploadEventResponse
     */
    public UploadEventResponse uploadEvent(UploadEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UploadEventHeaders headers = new UploadEventHeaders();
        return this.uploadEventWithOptions(request, headers, runtime);
    }
}
