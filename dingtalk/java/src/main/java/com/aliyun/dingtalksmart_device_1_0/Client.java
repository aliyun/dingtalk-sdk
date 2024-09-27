// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalksmart_device_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._productId = "dingtalk";
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>添加硬件视频会议参会人</p>
     * 
     * @param request AddDeviceVideoConferenceMembersRequest
     * @param headers AddDeviceVideoConferenceMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddDeviceVideoConferenceMembersResponse
     */
    public AddDeviceVideoConferenceMembersResponse addDeviceVideoConferenceMembersWithOptions(String deviceId, String conferenceId, AddDeviceVideoConferenceMembersRequest request, AddDeviceVideoConferenceMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddDeviceVideoConferenceMembers"),
            new TeaPair("version", "smartDevice_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddDeviceVideoConferenceMembersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加硬件视频会议参会人</p>
     * 
     * @param request AddDeviceVideoConferenceMembersRequest
     * @return AddDeviceVideoConferenceMembersResponse
     */
    public AddDeviceVideoConferenceMembersResponse addDeviceVideoConferenceMembers(String deviceId, String conferenceId, AddDeviceVideoConferenceMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddDeviceVideoConferenceMembersHeaders headers = new AddDeviceVideoConferenceMembersHeaders();
        return this.addDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建硬件视频会议</p>
     * 
     * @param request CreateDeviceVideoConferenceRequest
     * @param headers CreateDeviceVideoConferenceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateDeviceVideoConferenceResponse
     */
    public CreateDeviceVideoConferenceResponse createDeviceVideoConferenceWithOptions(String deviceId, CreateDeviceVideoConferenceRequest request, CreateDeviceVideoConferenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateDeviceVideoConference"),
            new TeaPair("version", "smartDevice_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateDeviceVideoConferenceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建硬件视频会议</p>
     * 
     * @param request CreateDeviceVideoConferenceRequest
     * @return CreateDeviceVideoConferenceResponse
     */
    public CreateDeviceVideoConferenceResponse createDeviceVideoConference(String deviceId, CreateDeviceVideoConferenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDeviceVideoConferenceHeaders headers = new CreateDeviceVideoConferenceHeaders();
        return this.createDeviceVideoConferenceWithOptions(deviceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>基于企业员工照片为终端提取人脸识别特征</p>
     * 
     * @param request ExtractFacialFeatureRequest
     * @param headers ExtractFacialFeatureHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ExtractFacialFeatureResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ExtractFacialFeature"),
            new TeaPair("version", "smartDevice_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/smartDevice/faceRecognitions/features/extract"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExtractFacialFeatureResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>基于企业员工照片为终端提取人脸识别特征</p>
     * 
     * @param request ExtractFacialFeatureRequest
     * @return ExtractFacialFeatureResponse
     */
    public ExtractFacialFeatureResponse extractFacialFeature(ExtractFacialFeatureRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExtractFacialFeatureHeaders headers = new ExtractFacialFeatureHeaders();
        return this.extractFacialFeatureWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>踢出硬件视频会议参会人</p>
     * 
     * @param request KickDeviceVideoConferenceMembersRequest
     * @param headers KickDeviceVideoConferenceMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return KickDeviceVideoConferenceMembersResponse
     */
    public KickDeviceVideoConferenceMembersResponse kickDeviceVideoConferenceMembersWithOptions(String deviceId, String conferenceId, KickDeviceVideoConferenceMembersRequest request, KickDeviceVideoConferenceMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "KickDeviceVideoConferenceMembers"),
            new TeaPair("version", "smartDevice_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members/batchDelete"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new KickDeviceVideoConferenceMembersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>踢出硬件视频会议参会人</p>
     * 
     * @param request KickDeviceVideoConferenceMembersRequest
     * @return KickDeviceVideoConferenceMembersResponse
     */
    public KickDeviceVideoConferenceMembersResponse kickDeviceVideoConferenceMembers(String deviceId, String conferenceId, KickDeviceVideoConferenceMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        KickDeviceVideoConferenceMembersHeaders headers = new KickDeviceVideoConferenceMembersHeaders();
        return this.kickDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>变更智能考勤机设备管理员</p>
     * 
     * @param request MachineManagerUpdateRequest
     * @param headers MachineManagerUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MachineManagerUpdateResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "MachineManagerUpdate"),
            new TeaPair("version", "smartDevice_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/smartDevice/atmachines/managers"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MachineManagerUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>变更智能考勤机设备管理员</p>
     * 
     * @param request MachineManagerUpdateRequest
     * @return MachineManagerUpdateResponse
     */
    public MachineManagerUpdateResponse machineManagerUpdate(MachineManagerUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MachineManagerUpdateHeaders headers = new MachineManagerUpdateHeaders();
        return this.machineManagerUpdateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>变更智能考勤机员工</p>
     * 
     * @param request MachineUsersUpdateRequest
     * @param headers MachineUsersUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MachineUsersUpdateResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "MachineUsersUpdate"),
            new TeaPair("version", "smartDevice_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/smartDevice/atmachines/users"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MachineUsersUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>变更智能考勤机员工</p>
     * 
     * @param request MachineUsersUpdateRequest
     * @return MachineUsersUpdateResponse
     */
    public MachineUsersUpdateResponse machineUsersUpdate(MachineUsersUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MachineUsersUpdateHeaders headers = new MachineUsersUpdateHeaders();
        return this.machineUsersUpdateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询硬件视频会议预约信息</p>
     * 
     * @param headers QueryDeviceVideoConferenceBookHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDeviceVideoConferenceBookResponse
     */
    public QueryDeviceVideoConferenceBookResponse queryDeviceVideoConferenceBookWithOptions(String deviceId, String bookId, QueryDeviceVideoConferenceBookHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryDeviceVideoConferenceBook"),
            new TeaPair("version", "smartDevice_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/smartDevice/devices/" + deviceId + "/books/" + bookId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDeviceVideoConferenceBookResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询硬件视频会议预约信息</p>
     * @return QueryDeviceVideoConferenceBookResponse
     */
    public QueryDeviceVideoConferenceBookResponse queryDeviceVideoConferenceBook(String deviceId, String bookId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDeviceVideoConferenceBookHeaders headers = new QueryDeviceVideoConferenceBookHeaders();
        return this.queryDeviceVideoConferenceBookWithOptions(deviceId, bookId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>文生图开放接口</p>
     * 
     * @param request TextToImageRequest
     * @param headers TextToImageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TextToImageResponse
     */
    public TextToImageResponse textToImageWithOptions(TextToImageRequest request, TextToImageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.modelId)) {
            body.put("modelId", request.modelId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pictureNum)) {
            body.put("pictureNum", request.pictureNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pictureSize)) {
            body.put("pictureSize", request.pictureSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.query)) {
            body.put("query", request.query);
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
            new TeaPair("action", "TextToImage"),
            new TeaPair("version", "smartDevice_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/smartDevice/textToImages/generate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TextToImageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>文生图开放接口</p>
     * 
     * @param request TextToImageRequest
     * @return TextToImageResponse
     */
    public TextToImageResponse textToImage(TextToImageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TextToImageHeaders headers = new TextToImageHeaders();
        return this.textToImageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>音频复刻</p>
     * 
     * @param request VoiceCloneRequest
     * @param headers VoiceCloneHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return VoiceCloneResponse
     */
    public VoiceCloneResponse voiceCloneWithOptions(VoiceCloneRequest request, VoiceCloneHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.text)) {
            body.put("text", request.text);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.voiceId)) {
            body.put("voiceId", request.voiceId);
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
            new TeaPair("action", "VoiceClone"),
            new TeaPair("version", "smartDevice_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/smartDevice/voices/clone"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new VoiceCloneResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>音频复刻</p>
     * 
     * @param request VoiceCloneRequest
     * @return VoiceCloneResponse
     */
    public VoiceCloneResponse voiceClone(VoiceCloneRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        VoiceCloneHeaders headers = new VoiceCloneHeaders();
        return this.voiceCloneWithOptions(request, headers, runtime);
    }
}
