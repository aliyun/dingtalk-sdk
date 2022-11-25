// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalksmart_device_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public AddDeviceVideoConferenceMembersResponse addDeviceVideoConferenceMembers(String deviceId, String conferenceId, AddDeviceVideoConferenceMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddDeviceVideoConferenceMembersHeaders headers = new AddDeviceVideoConferenceMembersHeaders();
        return this.addDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
    }

    public AddDeviceVideoConferenceMembersResponse addDeviceVideoConferenceMembersWithOptions(String deviceId, String conferenceId, AddDeviceVideoConferenceMembersRequest request, AddDeviceVideoConferenceMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        deviceId = com.aliyun.openapiutil.Client.getEncodeParam(deviceId);
        conferenceId = com.aliyun.openapiutil.Client.getEncodeParam(conferenceId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("AddDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members", "none", req, runtime), new AddDeviceVideoConferenceMembersResponse());
    }

    public CreateDeviceVideoConferenceResponse createDeviceVideoConference(String deviceId, CreateDeviceVideoConferenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDeviceVideoConferenceHeaders headers = new CreateDeviceVideoConferenceHeaders();
        return this.createDeviceVideoConferenceWithOptions(deviceId, request, headers, runtime);
    }

    public CreateDeviceVideoConferenceResponse createDeviceVideoConferenceWithOptions(String deviceId, CreateDeviceVideoConferenceRequest request, CreateDeviceVideoConferenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        deviceId = com.aliyun.openapiutil.Client.getEncodeParam(deviceId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("CreateDeviceVideoConference", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences", "json", req, runtime), new CreateDeviceVideoConferenceResponse());
    }

    public ExtractFacialFeatureResponse extractFacialFeature(ExtractFacialFeatureRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExtractFacialFeatureHeaders headers = new ExtractFacialFeatureHeaders();
        return this.extractFacialFeatureWithOptions(request, headers, runtime);
    }

    public ExtractFacialFeatureResponse extractFacialFeatureWithOptions(ExtractFacialFeatureRequest request, ExtractFacialFeatureHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
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
        return TeaModel.toModel(this.doROARequest("ExtractFacialFeature", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/faceRecognitions/features/extract", "json", req, runtime), new ExtractFacialFeatureResponse());
    }

    public KickDeviceVideoConferenceMembersResponse kickDeviceVideoConferenceMembers(String deviceId, String conferenceId, KickDeviceVideoConferenceMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        KickDeviceVideoConferenceMembersHeaders headers = new KickDeviceVideoConferenceMembersHeaders();
        return this.kickDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
    }

    public KickDeviceVideoConferenceMembersResponse kickDeviceVideoConferenceMembersWithOptions(String deviceId, String conferenceId, KickDeviceVideoConferenceMembersRequest request, KickDeviceVideoConferenceMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        deviceId = com.aliyun.openapiutil.Client.getEncodeParam(deviceId);
        conferenceId = com.aliyun.openapiutil.Client.getEncodeParam(conferenceId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("KickDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members/batchDelete", "none", req, runtime), new KickDeviceVideoConferenceMembersResponse());
    }

    public MachineManagerUpdateResponse machineManagerUpdate(MachineManagerUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MachineManagerUpdateHeaders headers = new MachineManagerUpdateHeaders();
        return this.machineManagerUpdateWithOptions(request, headers, runtime);
    }

    public MachineManagerUpdateResponse machineManagerUpdateWithOptions(MachineManagerUpdateRequest request, MachineManagerUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.atmManagerRightMap)) {
            body.put("atmManagerRightMap", request.atmManagerRightMap);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceId)) {
            body.put("deviceId", request.deviceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeDeptIds)) {
            body.put("scopeDeptIds", request.scopeDeptIds);
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
        return TeaModel.toModel(this.doROARequest("MachineManagerUpdate", "smartDevice_1.0", "HTTP", "PUT", "AK", "/v1.0/smartDevice/atmachines/managers", "none", req, runtime), new MachineManagerUpdateResponse());
    }

    public MachineUsersUpdateResponse machineUsersUpdate(MachineUsersUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MachineUsersUpdateHeaders headers = new MachineUsersUpdateHeaders();
        return this.machineUsersUpdateWithOptions(request, headers, runtime);
    }

    public MachineUsersUpdateResponse machineUsersUpdateWithOptions(MachineUsersUpdateRequest request, MachineUsersUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.addDeptIds)) {
            body.put("addDeptIds", request.addDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.addUserIds)) {
            body.put("addUserIds", request.addUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.delDeptIds)) {
            body.put("delDeptIds", request.delDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.delUserIds)) {
            body.put("delUserIds", request.delUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.devIds)) {
            body.put("devIds", request.devIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceIds)) {
            body.put("deviceIds", request.deviceIds);
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
        return TeaModel.toModel(this.doROARequest("MachineUsersUpdate", "smartDevice_1.0", "HTTP", "PUT", "AK", "/v1.0/smartDevice/atmachines/users", "none", req, runtime), new MachineUsersUpdateResponse());
    }

    public QueryDeviceVideoConferenceBookResponse queryDeviceVideoConferenceBook(String deviceId, String bookId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDeviceVideoConferenceBookHeaders headers = new QueryDeviceVideoConferenceBookHeaders();
        return this.queryDeviceVideoConferenceBookWithOptions(deviceId, bookId, headers, runtime);
    }

    public QueryDeviceVideoConferenceBookResponse queryDeviceVideoConferenceBookWithOptions(String deviceId, String bookId, QueryDeviceVideoConferenceBookHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        deviceId = com.aliyun.openapiutil.Client.getEncodeParam(deviceId);
        bookId = com.aliyun.openapiutil.Client.getEncodeParam(bookId);
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
        return TeaModel.toModel(this.doROARequest("QueryDeviceVideoConferenceBook", "smartDevice_1.0", "HTTP", "GET", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/books/" + bookId + "", "json", req, runtime), new QueryDeviceVideoConferenceBookResponse());
    }
}
