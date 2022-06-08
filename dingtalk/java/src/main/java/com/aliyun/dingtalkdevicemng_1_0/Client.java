// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdevicemng_1_0.models.*;
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


    public BatchRegisterDeviceResponse batchRegisterDevice(BatchRegisterDeviceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchRegisterDeviceHeaders headers = new BatchRegisterDeviceHeaders();
        return this.batchRegisterDeviceWithOptions(request, headers, runtime);
    }

    public BatchRegisterDeviceResponse batchRegisterDeviceWithOptions(BatchRegisterDeviceRequest request, BatchRegisterDeviceHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchRegisterDevice", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/devices/batch", "json", req, runtime), new BatchRegisterDeviceResponse());
    }

    public CreateChatRoomResponse createChatRoom(CreateChatRoomRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateChatRoomHeaders headers = new CreateChatRoomHeaders();
        return this.createChatRoomWithOptions(request, headers, runtime);
    }

    public CreateChatRoomResponse createChatRoomWithOptions(CreateChatRoomRequest request, CreateChatRoomHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateChatRoom", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/chatRoom", "json", req, runtime), new CreateChatRoomResponse());
    }

    public CreateDepartmentResponse createDepartment(CreateDepartmentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateDepartmentHeaders headers = new CreateDepartmentHeaders();
        return this.createDepartmentWithOptions(request, headers, runtime);
    }

    public CreateDepartmentResponse createDepartmentWithOptions(CreateDepartmentRequest request, CreateDepartmentHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateDepartment", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/departments", "json", req, runtime), new CreateDepartmentResponse());
    }

    public CreateDeviceChatRoomResponse createDeviceChatRoom(CreateDeviceChatRoomRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateDeviceChatRoomHeaders headers = new CreateDeviceChatRoomHeaders();
        return this.createDeviceChatRoomWithOptions(request, headers, runtime);
    }

    public CreateDeviceChatRoomResponse createDeviceChatRoomWithOptions(CreateDeviceChatRoomRequest request, CreateDeviceChatRoomHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateDeviceChatRoom", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/chatRooms/groups", "json", req, runtime), new CreateDeviceChatRoomResponse());
    }

    public DeviceDingResponse deviceDing(DeviceDingRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeviceDingHeaders headers = new DeviceDingHeaders();
        return this.deviceDingWithOptions(request, headers, runtime);
    }

    public DeviceDingResponse deviceDingWithOptions(DeviceDingRequest request, DeviceDingHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DeviceDing", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/ding", "json", req, runtime), new DeviceDingResponse());
    }

    public DissolveGroupResponse dissolveGroup(DissolveGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DissolveGroupHeaders headers = new DissolveGroupHeaders();
        return this.dissolveGroupWithOptions(request, headers, runtime);
    }

    public DissolveGroupResponse dissolveGroupWithOptions(DissolveGroupRequest request, DissolveGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DissolveGroup", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/chatRooms/groups/dissolve", "json", req, runtime), new DissolveGroupResponse());
    }

    public EditDeviceAdminResponse editDeviceAdmin(EditDeviceAdminRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditDeviceAdminHeaders headers = new EditDeviceAdminHeaders();
        return this.editDeviceAdminWithOptions(request, headers, runtime);
    }

    public EditDeviceAdminResponse editDeviceAdminWithOptions(EditDeviceAdminRequest request, EditDeviceAdminHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("EditDeviceAdmin", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/devices/administrators/edit", "json", req, runtime), new EditDeviceAdminResponse());
    }

    public GetDeviceGroupInfoResponse getDeviceGroupInfo(GetDeviceGroupInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDeviceGroupInfoHeaders headers = new GetDeviceGroupInfoHeaders();
        return this.getDeviceGroupInfoWithOptions(request, headers, runtime);
    }

    public GetDeviceGroupInfoResponse getDeviceGroupInfoWithOptions(GetDeviceGroupInfoRequest request, GetDeviceGroupInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetDeviceGroupInfo", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/chatRooms/groupInfos/query", "json", req, runtime), new GetDeviceGroupInfoResponse());
    }

    public GetWholeDeviceGroupResponse getWholeDeviceGroup() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetWholeDeviceGroupHeaders headers = new GetWholeDeviceGroupHeaders();
        return this.getWholeDeviceGroupWithOptions(headers, runtime);
    }

    public GetWholeDeviceGroupResponse getWholeDeviceGroupWithOptions(GetWholeDeviceGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetWholeDeviceGroup", "devicemng_1.0", "HTTP", "GET", "AK", "/v1.0/devicemng/customers/chatRooms/wholeGroupId", "json", req, runtime), new GetWholeDeviceGroupResponse());
    }

    public ListActivateDevicesResponse listActivateDevices(ListActivateDevicesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListActivateDevicesHeaders headers = new ListActivateDevicesHeaders();
        return this.listActivateDevicesWithOptions(request, headers, runtime);
    }

    public ListActivateDevicesResponse listActivateDevicesWithOptions(ListActivateDevicesRequest request, ListActivateDevicesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListActivateDevices", "devicemng_1.0", "HTTP", "GET", "AK", "/v1.0/devicemng/customers/devices/activations/infos", "json", req, runtime), new ListActivateDevicesResponse());
    }

    public PullDeviceToGroupResponse pullDeviceToGroup(PullDeviceToGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PullDeviceToGroupHeaders headers = new PullDeviceToGroupHeaders();
        return this.pullDeviceToGroupWithOptions(request, headers, runtime);
    }

    public PullDeviceToGroupResponse pullDeviceToGroupWithOptions(PullDeviceToGroupRequest request, PullDeviceToGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("PullDeviceToGroup", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/chatRooms/devices", "json", req, runtime), new PullDeviceToGroupResponse());
    }

    public PullUserToGroupResponse pullUserToGroup(PullUserToGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PullUserToGroupHeaders headers = new PullUserToGroupHeaders();
        return this.pullUserToGroupWithOptions(request, headers, runtime);
    }

    public PullUserToGroupResponse pullUserToGroupWithOptions(PullUserToGroupRequest request, PullUserToGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("PullUserToGroup", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/chatRooms/users", "json", req, runtime), new PullUserToGroupResponse());
    }

    public RegisterAndActivateDeviceResponse registerAndActivateDevice(RegisterAndActivateDeviceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RegisterAndActivateDeviceHeaders headers = new RegisterAndActivateDeviceHeaders();
        return this.registerAndActivateDeviceWithOptions(request, headers, runtime);
    }

    public RegisterAndActivateDeviceResponse registerAndActivateDeviceWithOptions(RegisterAndActivateDeviceRequest request, RegisterAndActivateDeviceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceCallbackUrl)) {
            body.put("deviceCallbackUrl", request.deviceCallbackUrl);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RegisterAndActivateDevice", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/devices/registerAndActivate", "json", req, runtime), new RegisterAndActivateDeviceResponse());
    }

    public RegisterAndActivateDeviceBatchResponse registerAndActivateDeviceBatch(RegisterAndActivateDeviceBatchRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RegisterAndActivateDeviceBatchHeaders headers = new RegisterAndActivateDeviceBatchHeaders();
        return this.registerAndActivateDeviceBatchWithOptions(request, headers, runtime);
    }

    public RegisterAndActivateDeviceBatchResponse registerAndActivateDeviceBatchWithOptions(RegisterAndActivateDeviceBatchRequest request, RegisterAndActivateDeviceBatchHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RegisterAndActivateDeviceBatch", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/devices/registrationActivations/batch", "json", req, runtime), new RegisterAndActivateDeviceBatchResponse());
    }

    public RegisterDeviceResponse registerDevice(RegisterDeviceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RegisterDeviceHeaders headers = new RegisterDeviceHeaders();
        return this.registerDeviceWithOptions(request, headers, runtime);
    }

    public RegisterDeviceResponse registerDeviceWithOptions(RegisterDeviceRequest request, RegisterDeviceHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RegisterDevice", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/devices", "json", req, runtime), new RegisterDeviceResponse());
    }

    public RemoveDeviceFromGroupResponse removeDeviceFromGroup(RemoveDeviceFromGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RemoveDeviceFromGroupHeaders headers = new RemoveDeviceFromGroupHeaders();
        return this.removeDeviceFromGroupWithOptions(request, headers, runtime);
    }

    public RemoveDeviceFromGroupResponse removeDeviceFromGroupWithOptions(RemoveDeviceFromGroupRequest request, RemoveDeviceFromGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RemoveDeviceFromGroup", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/chatRooms/devices/remove", "json", req, runtime), new RemoveDeviceFromGroupResponse());
    }

    public RemoveUserFromGroupResponse removeUserFromGroup(RemoveUserFromGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RemoveUserFromGroupHeaders headers = new RemoveUserFromGroupHeaders();
        return this.removeUserFromGroupWithOptions(request, headers, runtime);
    }

    public RemoveUserFromGroupResponse removeUserFromGroupWithOptions(RemoveUserFromGroupRequest request, RemoveUserFromGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RemoveUserFromGroup", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/chatRooms/users/remove", "json", req, runtime), new RemoveUserFromGroupResponse());
    }

    public SendCardResponse sendCard(SendCardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendCardHeaders headers = new SendCardHeaders();
        return this.sendCardWithOptions(request, headers, runtime);
    }

    public SendCardResponse sendCardWithOptions(SendCardRequest request, SendCardHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SendCard", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/cards/send", "json", req, runtime), new SendCardResponse());
    }

    public UninstallDeviceRobotResponse uninstallDeviceRobot(UninstallDeviceRobotRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UninstallDeviceRobotHeaders headers = new UninstallDeviceRobotHeaders();
        return this.uninstallDeviceRobotWithOptions(request, headers, runtime);
    }

    public UninstallDeviceRobotResponse uninstallDeviceRobotWithOptions(UninstallDeviceRobotRequest request, UninstallDeviceRobotHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UninstallDeviceRobot", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/customers/devices/uninstall", "json", req, runtime), new UninstallDeviceRobotResponse());
    }

    public UpdateCardResponse updateCard(UpdateCardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateCardHeaders headers = new UpdateCardHeaders();
        return this.updateCardWithOptions(request, headers, runtime);
    }

    public UpdateCardResponse updateCardWithOptions(UpdateCardRequest request, UpdateCardHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardData)) {
            body.put("cardData", request.cardData);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateCard", "devicemng_1.0", "HTTP", "PUT", "AK", "/v1.0/devicemng/customers/cards", "json", req, runtime), new UpdateCardResponse());
    }

    public UploadEventResponse uploadEvent(UploadEventRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UploadEventHeaders headers = new UploadEventHeaders();
        return this.uploadEventWithOptions(request, headers, runtime);
    }

    public UploadEventResponse uploadEventWithOptions(UploadEventRequest request, UploadEventHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UploadEvent", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/suppliers/events/upload", "json", req, runtime), new UploadEventResponse());
    }
}
