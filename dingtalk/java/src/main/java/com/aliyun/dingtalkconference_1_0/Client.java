// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkconference_1_0.models.*;

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
     * @summary 取消预约会议
     *
     * @param request CancelScheduleConferenceRequest
     * @param headers CancelScheduleConferenceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelScheduleConferenceResponse
     */
    public CancelScheduleConferenceResponse cancelScheduleConferenceWithOptions(CancelScheduleConferenceRequest request, CancelScheduleConferenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduleConferenceId)) {
            body.put("scheduleConferenceId", request.scheduleConferenceId);
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
            new TeaPair("action", "CancelScheduleConference"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/scheduleConferences/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelScheduleConferenceResponse());
    }

    /**
     * @summary 取消预约会议
     *
     * @param request CancelScheduleConferenceRequest
     * @return CancelScheduleConferenceResponse
     */
    public CancelScheduleConferenceResponse cancelScheduleConference(CancelScheduleConferenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelScheduleConferenceHeaders headers = new CancelScheduleConferenceHeaders();
        return this.cancelScheduleConferenceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 关闭视频会议
     *
     * @param request CloseVideoConferenceRequest
     * @param headers CloseVideoConferenceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CloseVideoConferenceResponse
     */
    public CloseVideoConferenceResponse closeVideoConferenceWithOptions(String conferenceId, CloseVideoConferenceRequest request, CloseVideoConferenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "CloseVideoConference"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CloseVideoConferenceResponse());
    }

    /**
     * @summary 关闭视频会议
     *
     * @param request CloseVideoConferenceRequest
     * @return CloseVideoConferenceResponse
     */
    public CloseVideoConferenceResponse closeVideoConference(String conferenceId, CloseVideoConferenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CloseVideoConferenceHeaders headers = new CloseVideoConferenceHeaders();
        return this.closeVideoConferenceWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 设置联席主持人
     *
     * @param request CohostsRequest
     * @param headers CohostsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CohostsResponse
     */
    public CohostsResponse cohostsWithOptions(String conferenceId, CohostsRequest request, CohostsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
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
            new TeaPair("action", "Cohosts"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/coHosts/set"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CohostsResponse());
    }

    /**
     * @summary 设置联席主持人
     *
     * @param request CohostsRequest
     * @return CohostsResponse
     */
    public CohostsResponse cohosts(String conferenceId, CohostsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CohostsHeaders headers = new CohostsHeaders();
        return this.cohostsWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 创建专属短链
     *
     * @param request CreateCustomShortLinkRequest
     * @param headers CreateCustomShortLinkHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCustomShortLinkResponse
     */
    public CreateCustomShortLinkResponse createCustomShortLinkWithOptions(CreateCustomShortLinkRequest request, CreateCustomShortLinkHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extensionAppBizData)) {
            body.put("extensionAppBizData", request.extensionAppBizData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduleConferenceId)) {
            body.put("scheduleConferenceId", request.scheduleConferenceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useExtensionApp)) {
            body.put("useExtensionApp", request.useExtensionApp);
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
            new TeaPair("action", "CreateCustomShortLink"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/customShortLinks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCustomShortLinkResponse());
    }

    /**
     * @summary 创建专属短链
     *
     * @param request CreateCustomShortLinkRequest
     * @return CreateCustomShortLinkResponse
     */
    public CreateCustomShortLinkResponse createCustomShortLink(CreateCustomShortLinkRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCustomShortLinkHeaders headers = new CreateCustomShortLinkHeaders();
        return this.createCustomShortLinkWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建预约会议
     *
     * @param request CreateScheduleConferenceRequest
     * @param headers CreateScheduleConferenceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateScheduleConferenceResponse
     */
    public CreateScheduleConferenceResponse createScheduleConferenceWithOptions(CreateScheduleConferenceRequest request, CreateScheduleConferenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
            new TeaPair("action", "CreateScheduleConference"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/scheduleConferences"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateScheduleConferenceResponse());
    }

    /**
     * @summary 创建预约会议
     *
     * @param request CreateScheduleConferenceRequest
     * @return CreateScheduleConferenceResponse
     */
    public CreateScheduleConferenceResponse createScheduleConference(CreateScheduleConferenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateScheduleConferenceHeaders headers = new CreateScheduleConferenceHeaders();
        return this.createScheduleConferenceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建视频会议
     *
     * @param request CreateVideoConferenceRequest
     * @param headers CreateVideoConferenceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateVideoConferenceResponse
     */
    public CreateVideoConferenceResponse createVideoConferenceWithOptions(CreateVideoConferenceRequest request, CreateVideoConferenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.confTitle)) {
            body.put("confTitle", request.confTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inviteCaller)) {
            body.put("inviteCaller", request.inviteCaller);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inviteUserIds)) {
            body.put("inviteUserIds", request.inviteUserIds);
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
            new TeaPair("action", "CreateVideoConference"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateVideoConferenceResponse());
    }

    /**
     * @summary 创建视频会议
     *
     * @param request CreateVideoConferenceRequest
     * @return CreateVideoConferenceResponse
     */
    public CreateVideoConferenceResponse createVideoConference(CreateVideoConferenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateVideoConferenceHeaders headers = new CreateVideoConferenceHeaders();
        return this.createVideoConferenceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 设置全员看他
     *
     * @param request FocusRequest
     * @param headers FocusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FocusResponse
     */
    public FocusResponse focusWithOptions(String conferenceId, FocusRequest request, FocusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
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
            new TeaPair("action", "Focus"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/focus"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FocusResponse());
    }

    /**
     * @summary 设置全员看他
     *
     * @param request FocusRequest
     * @return FocusResponse
     */
    public FocusResponse focus(String conferenceId, FocusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FocusHeaders headers = new FocusHeaders();
        return this.focusWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 通过conferenceId获取指定音视频会议信息
     *
     * @param request GetConfDataByConferenceIdRequest
     * @param headers GetConfDataByConferenceIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetConfDataByConferenceIdResponse
     */
    public GetConfDataByConferenceIdResponse getConfDataByConferenceIdWithOptions(String conferenceId, GetConfDataByConferenceIdRequest request, GetConfDataByConferenceIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.realData)) {
            query.put("realData", request.realData);
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
            new TeaPair("action", "GetConfDataByConferenceId"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetConfDataByConferenceIdResponse());
    }

    /**
     * @summary 通过conferenceId获取指定音视频会议信息
     *
     * @param request GetConfDataByConferenceIdRequest
     * @return GetConfDataByConferenceIdResponse
     */
    public GetConfDataByConferenceIdResponse getConfDataByConferenceId(String conferenceId, GetConfDataByConferenceIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetConfDataByConferenceIdHeaders headers = new GetConfDataByConferenceIdHeaders();
        return this.getConfDataByConferenceIdWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 通过conferenceId获取指定音视频会议成员信息
     *
     * @param request GetConfDetailDataRequest
     * @param headers GetConfDetailDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetConfDetailDataResponse
     */
    public GetConfDetailDataResponse getConfDetailDataWithOptions(String conferenceId, GetConfDetailDataRequest request, GetConfDetailDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nick)) {
            query.put("nick", request.nick);
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
            new TeaPair("action", "GetConfDetailData"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetConfDetailDataResponse());
    }

    /**
     * @summary 通过conferenceId获取指定音视频会议成员信息
     *
     * @param request GetConfDetailDataRequest
     * @return GetConfDetailDataResponse
     */
    public GetConfDetailDataResponse getConfDetailData(String conferenceId, GetConfDetailDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetConfDetailDataHeaders headers = new GetConfDetailDataHeaders();
        return this.getConfDetailDataWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 获取音视频会议列表数据
     *
     * @param request GetHistoryConfDataListRequest
     * @param headers GetHistoryConfDataListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetHistoryConfDataListResponse
     */
    public GetHistoryConfDataListResponse getHistoryConfDataListWithOptions(GetHistoryConfDataListRequest request, GetHistoryConfDataListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorNike)) {
            query.put("creatorNike", request.creatorNike);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.freeType)) {
            query.put("freeType", request.freeType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.realData)) {
            query.put("realData", request.realData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            query.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            query.put("title", request.title);
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
            new TeaPair("action", "GetHistoryConfDataList"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/histories/dataLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetHistoryConfDataListResponse());
    }

    /**
     * @summary 获取音视频会议列表数据
     *
     * @param request GetHistoryConfDataListRequest
     * @return GetHistoryConfDataListResponse
     */
    public GetHistoryConfDataListResponse getHistoryConfDataList(GetHistoryConfDataListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetHistoryConfDataListHeaders headers = new GetHistoryConfDataListHeaders();
        return this.getHistoryConfDataListWithOptions(request, headers, runtime);
    }

    /**
     * @summary 通过conferenceId和unionId获取最新会议质量数据
     *
     * @param request GetUserLastMetricRequest
     * @param headers GetUserLastMetricHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserLastMetricResponse
     */
    public GetUserLastMetricResponse getUserLastMetricWithOptions(String conferenceId, GetUserLastMetricRequest request, GetUserLastMetricHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionIdList)) {
            body.put("unionIdList", request.unionIdList);
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
            new TeaPair("action", "GetUserLastMetric"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/lastMetricDatas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserLastMetricResponse());
    }

    /**
     * @summary 通过conferenceId和unionId获取最新会议质量数据
     *
     * @param request GetUserLastMetricRequest
     * @return GetUserLastMetricResponse
     */
    public GetUserLastMetricResponse getUserLastMetric(String conferenceId, GetUserLastMetricRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserLastMetricHeaders headers = new GetUserLastMetricHeaders();
        return this.getUserLastMetricWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
     *
     * @param request GetUserMetricDataRequest
     * @param headers GetUserMetricDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserMetricDataResponse
     */
    public GetUserMetricDataResponse getUserMetricDataWithOptions(String conferenceId, GetUserMetricDataRequest request, GetUserMetricDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.beginTime)) {
            query.put("beginTime", request.beginTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
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
            new TeaPair("action", "GetUserMetricData"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/metricDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserMetricDataResponse());
    }

    /**
     * @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
     *
     * @param request GetUserMetricDataRequest
     * @return GetUserMetricDataResponse
     */
    public GetUserMetricDataResponse getUserMetricData(String conferenceId, GetUserMetricDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserMetricDataHeaders headers = new GetUserMetricDataHeaders();
        return this.getUserMetricDataWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 邀请其他人员
     *
     * @param request InviteUsersRequest
     * @param headers InviteUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InviteUsersResponse
     */
    public InviteUsersResponse inviteUsersWithOptions(String conferenceId, InviteUsersRequest request, InviteUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.inviteeList)) {
            body.put("inviteeList", request.inviteeList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.phoneInviteeList)) {
            body.put("phoneInviteeList", request.phoneInviteeList);
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
            new TeaPair("action", "InviteUsers"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/users/invite"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InviteUsersResponse());
    }

    /**
     * @summary 邀请其他人员
     *
     * @param request InviteUsersRequest
     * @return InviteUsersResponse
     */
    public InviteUsersResponse inviteUsers(String conferenceId, InviteUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InviteUsersHeaders headers = new InviteUsersHeaders();
        return this.inviteUsersWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 会议踢出成员
     *
     * @param request KickMembersRequest
     * @param headers KickMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return KickMembersResponse
     */
    public KickMembersResponse kickMembersWithOptions(String conferenceId, KickMembersRequest request, KickMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.forbiddenRejoin)) {
            body.put("forbiddenRejoin", request.forbiddenRejoin);
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
            new TeaPair("action", "KickMembers"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/members/kick"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new KickMembersResponse());
    }

    /**
     * @summary 会议踢出成员
     *
     * @param request KickMembersRequest
     * @return KickMembersResponse
     */
    public KickMembersResponse kickMembers(String conferenceId, KickMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        KickMembersHeaders headers = new KickMembersHeaders();
        return this.kickMembersWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 锁定会议
     *
     * @param request LockConferenceRequest
     * @param headers LockConferenceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return LockConferenceResponse
     */
    public LockConferenceResponse lockConferenceWithOptions(String conferenceId, LockConferenceRequest request, LockConferenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
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
            new TeaPair("action", "LockConference"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/lock"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new LockConferenceResponse());
    }

    /**
     * @summary 锁定会议
     *
     * @param request LockConferenceRequest
     * @return LockConferenceResponse
     */
    public LockConferenceResponse lockConference(String conferenceId, LockConferenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LockConferenceHeaders headers = new LockConferenceHeaders();
        return this.lockConferenceWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 会议全员静音或解除静音
     *
     * @param request MuteAllRequest
     * @param headers MuteAllHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MuteAllResponse
     */
    public MuteAllResponse muteAllWithOptions(String conferenceId, MuteAllRequest request, MuteAllHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.forceMute)) {
            body.put("forceMute", request.forceMute);
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
            new TeaPair("action", "MuteAll"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/allMembers/mute"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MuteAllResponse());
    }

    /**
     * @summary 会议全员静音或解除静音
     *
     * @param request MuteAllRequest
     * @return MuteAllResponse
     */
    public MuteAllResponse muteAll(String conferenceId, MuteAllRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MuteAllHeaders headers = new MuteAllHeaders();
        return this.muteAllWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 指定人员静音或取消静音
     *
     * @param request MuteMembersRequest
     * @param headers MuteMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MuteMembersResponse
     */
    public MuteMembersResponse muteMembersWithOptions(String conferenceId, MuteMembersRequest request, MuteMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
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
            new TeaPair("action", "MuteMembers"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/members/mute"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MuteMembersResponse());
    }

    /**
     * @summary 指定人员静音或取消静音
     *
     * @param request MuteMembersRequest
     * @return MuteMembersResponse
     */
    public MuteMembersResponse muteMembers(String conferenceId, MuteMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MuteMembersHeaders headers = new MuteMembersHeaders();
        return this.muteMembersWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 查询云录制文本信息
     *
     * @param request QueryCloudRecordTextRequest
     * @param headers QueryCloudRecordTextHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCloudRecordTextResponse
     */
    public QueryCloudRecordTextResponse queryCloudRecordTextWithOptions(String conferenceId, QueryCloudRecordTextRequest request, QueryCloudRecordTextHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.direction)) {
            query.put("direction", request.direction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
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
            new TeaPair("action", "QueryCloudRecordText"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getTexts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCloudRecordTextResponse());
    }

    /**
     * @summary 查询云录制文本信息
     *
     * @param request QueryCloudRecordTextRequest
     * @return QueryCloudRecordTextResponse
     */
    public QueryCloudRecordTextResponse queryCloudRecordText(String conferenceId, QueryCloudRecordTextRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCloudRecordTextHeaders headers = new QueryCloudRecordTextHeaders();
        return this.queryCloudRecordTextWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 查询云录制视频
     *
     * @param request QueryCloudRecordVideoRequest
     * @param headers QueryCloudRecordVideoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCloudRecordVideoResponse
     */
    public QueryCloudRecordVideoResponse queryCloudRecordVideoWithOptions(String conferenceId, QueryCloudRecordVideoRequest request, QueryCloudRecordVideoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryCloudRecordVideo"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getVideos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCloudRecordVideoResponse());
    }

    /**
     * @summary 查询云录制视频
     *
     * @param request QueryCloudRecordVideoRequest
     * @return QueryCloudRecordVideoResponse
     */
    public QueryCloudRecordVideoResponse queryCloudRecordVideo(String conferenceId, QueryCloudRecordVideoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCloudRecordVideoHeaders headers = new QueryCloudRecordVideoHeaders();
        return this.queryCloudRecordVideoWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 查询云录制视频播放信息
     *
     * @param request QueryCloudRecordVideoPlayInfoRequest
     * @param headers QueryCloudRecordVideoPlayInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCloudRecordVideoPlayInfoResponse
     */
    public QueryCloudRecordVideoPlayInfoResponse queryCloudRecordVideoPlayInfoWithOptions(String conferenceId, QueryCloudRecordVideoPlayInfoRequest request, QueryCloudRecordVideoPlayInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            query.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.regionId)) {
            query.put("regionId", request.regionId);
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
            new TeaPair("action", "QueryCloudRecordVideoPlayInfo"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/videos/getPlayInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCloudRecordVideoPlayInfoResponse());
    }

    /**
     * @summary 查询云录制视频播放信息
     *
     * @param request QueryCloudRecordVideoPlayInfoRequest
     * @return QueryCloudRecordVideoPlayInfoResponse
     */
    public QueryCloudRecordVideoPlayInfoResponse queryCloudRecordVideoPlayInfo(String conferenceId, QueryCloudRecordVideoPlayInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCloudRecordVideoPlayInfoHeaders headers = new QueryCloudRecordVideoPlayInfoHeaders();
        return this.queryCloudRecordVideoPlayInfoWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 查询视频会议信息
     *
     * @param headers QueryConferenceInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryConferenceInfoResponse
     */
    public QueryConferenceInfoResponse queryConferenceInfoWithOptions(String conferenceId, QueryConferenceInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryConferenceInfo"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryConferenceInfoResponse());
    }

    /**
     * @summary 查询视频会议信息
     *
     * @return QueryConferenceInfoResponse
     */
    public QueryConferenceInfoResponse queryConferenceInfo(String conferenceId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryConferenceInfoHeaders headers = new QueryConferenceInfoHeaders();
        return this.queryConferenceInfoWithOptions(conferenceId, headers, runtime);
    }

    /**
     * @summary 批量查询视频会议信息
     *
     * @param request QueryConferenceInfoBatchRequest
     * @param headers QueryConferenceInfoBatchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryConferenceInfoBatchResponse
     */
    public QueryConferenceInfoBatchResponse queryConferenceInfoBatchWithOptions(QueryConferenceInfoBatchRequest request, QueryConferenceInfoBatchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.conferenceIdList)) {
            body.put("conferenceIdList", request.conferenceIdList);
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
            new TeaPair("action", "QueryConferenceInfoBatch"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryConferenceInfoBatchResponse());
    }

    /**
     * @summary 批量查询视频会议信息
     *
     * @param request QueryConferenceInfoBatchRequest
     * @return QueryConferenceInfoBatchResponse
     */
    public QueryConferenceInfoBatchResponse queryConferenceInfoBatch(QueryConferenceInfoBatchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryConferenceInfoBatchHeaders headers = new QueryConferenceInfoBatchHeaders();
        return this.queryConferenceInfoBatchWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询视频会议成员
     *
     * @param request QueryConferenceMembersRequest
     * @param headers QueryConferenceMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryConferenceMembersResponse
     */
    public QueryConferenceMembersResponse queryConferenceMembersWithOptions(String conferenceId, QueryConferenceMembersRequest request, QueryConferenceMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryConferenceMembers"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/members"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryConferenceMembersResponse());
    }

    /**
     * @summary 查询视频会议成员
     *
     * @param request QueryConferenceMembersRequest
     * @return QueryConferenceMembersResponse
     */
    public QueryConferenceMembersResponse queryConferenceMembers(String conferenceId, QueryConferenceMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryConferenceMembersHeaders headers = new QueryConferenceMembersHeaders();
        return this.queryConferenceMembersWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 查询会议闪记的音频信息
     *
     * @param request QueryMinutesAudioRequest
     * @param headers QueryMinutesAudioHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMinutesAudioResponse
     */
    public QueryMinutesAudioResponse queryMinutesAudioWithOptions(String conferenceId, QueryMinutesAudioRequest request, QueryMinutesAudioHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryMinutesAudio"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/audioInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMinutesAudioResponse());
    }

    /**
     * @summary 查询会议闪记的音频信息
     *
     * @param request QueryMinutesAudioRequest
     * @return QueryMinutesAudioResponse
     */
    public QueryMinutesAudioResponse queryMinutesAudio(String conferenceId, QueryMinutesAudioRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMinutesAudioHeaders headers = new QueryMinutesAudioHeaders();
        return this.queryMinutesAudioWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 查询会议闪记智能纪要
     *
     * @param request QueryMinutesSummaryRequest
     * @param headers QueryMinutesSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMinutesSummaryResponse
     */
    public QueryMinutesSummaryResponse queryMinutesSummaryWithOptions(String conferenceId, QueryMinutesSummaryRequest request, QueryMinutesSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.summaryTypeList)) {
            body.put("summaryTypeList", request.summaryTypeList);
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
            new TeaPair("action", "QueryMinutesSummary"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/summaries/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMinutesSummaryResponse());
    }

    /**
     * @summary 查询会议闪记智能纪要
     *
     * @param request QueryMinutesSummaryRequest
     * @return QueryMinutesSummaryResponse
     */
    public QueryMinutesSummaryResponse queryMinutesSummary(String conferenceId, QueryMinutesSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMinutesSummaryHeaders headers = new QueryMinutesSummaryHeaders();
        return this.queryMinutesSummaryWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 查询会议闪记文本信息
     *
     * @param request QueryMinutesTextRequest
     * @param headers QueryMinutesTextHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMinutesTextResponse
     */
    public QueryMinutesTextResponse queryMinutesTextWithOptions(String conferenceId, QueryMinutesTextRequest request, QueryMinutesTextHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.direction)) {
            query.put("direction", request.direction);
        }

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
            new TeaPair("action", "QueryMinutesText"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/textInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMinutesTextResponse());
    }

    /**
     * @summary 查询会议闪记文本信息
     *
     * @param request QueryMinutesTextRequest
     * @return QueryMinutesTextResponse
     */
    public QueryMinutesTextResponse queryMinutesText(String conferenceId, QueryMinutesTextRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMinutesTextHeaders headers = new QueryMinutesTextHeaders();
        return this.queryMinutesTextWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 查询预约会议设置
     *
     * @param request QueryScheduleConfSettingsRequest
     * @param headers QueryScheduleConfSettingsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryScheduleConfSettingsResponse
     */
    public QueryScheduleConfSettingsResponse queryScheduleConfSettingsWithOptions(QueryScheduleConfSettingsRequest request, QueryScheduleConfSettingsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.scheduleConferenceId)) {
            query.put("scheduleConferenceId", request.scheduleConferenceId);
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
            new TeaPair("action", "QueryScheduleConfSettings"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/scheduleConferences/settings"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryScheduleConfSettingsResponse());
    }

    /**
     * @summary 查询预约会议设置
     *
     * @param request QueryScheduleConfSettingsRequest
     * @return QueryScheduleConfSettingsResponse
     */
    public QueryScheduleConfSettingsResponse queryScheduleConfSettings(QueryScheduleConfSettingsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryScheduleConfSettingsHeaders headers = new QueryScheduleConfSettingsHeaders();
        return this.queryScheduleConfSettingsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询预约会议信息
     *
     * @param request QueryScheduleConferenceRequest
     * @param headers QueryScheduleConferenceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryScheduleConferenceResponse
     */
    public QueryScheduleConferenceResponse queryScheduleConferenceWithOptions(String scheduleConferenceId, QueryScheduleConferenceRequest request, QueryScheduleConferenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.requestUnionId)) {
            query.put("requestUnionId", request.requestUnionId);
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
            new TeaPair("action", "QueryScheduleConference"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/scheduleConferences/" + scheduleConferenceId + "/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryScheduleConferenceResponse());
    }

    /**
     * @summary 查询预约会议信息
     *
     * @param request QueryScheduleConferenceRequest
     * @return QueryScheduleConferenceResponse
     */
    public QueryScheduleConferenceResponse queryScheduleConference(String scheduleConferenceId, QueryScheduleConferenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryScheduleConferenceHeaders headers = new QueryScheduleConferenceHeaders();
        return this.queryScheduleConferenceWithOptions(scheduleConferenceId, request, headers, runtime);
    }

    /**
     * @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
     *
     * @param request QueryScheduleConferenceInfoRequest
     * @param headers QueryScheduleConferenceInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryScheduleConferenceInfoResponse
     */
    public QueryScheduleConferenceInfoResponse queryScheduleConferenceInfoWithOptions(String scheduleConferenceId, QueryScheduleConferenceInfoRequest request, QueryScheduleConferenceInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryScheduleConferenceInfo"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/scheduleConferences/" + scheduleConferenceId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryScheduleConferenceInfoResponse());
    }

    /**
     * @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
     *
     * @param request QueryScheduleConferenceInfoRequest
     * @return QueryScheduleConferenceInfoResponse
     */
    public QueryScheduleConferenceInfoResponse queryScheduleConferenceInfo(String scheduleConferenceId, QueryScheduleConferenceInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryScheduleConferenceInfoHeaders headers = new QueryScheduleConferenceInfoHeaders();
        return this.queryScheduleConferenceInfoWithOptions(scheduleConferenceId, request, headers, runtime);
    }

    /**
     * @summary 查询用户进行中会议
     *
     * @param request QueryUserOnGoingConferenceRequest
     * @param headers QueryUserOnGoingConferenceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserOnGoingConferenceResponse
     */
    public QueryUserOnGoingConferenceResponse queryUserOnGoingConferenceWithOptions(QueryUserOnGoingConferenceRequest request, QueryUserOnGoingConferenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryUserOnGoingConference"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/users/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserOnGoingConferenceResponse());
    }

    /**
     * @summary 查询用户进行中会议
     *
     * @param request QueryUserOnGoingConferenceRequest
     * @return QueryUserOnGoingConferenceResponse
     */
    public QueryUserOnGoingConferenceResponse queryUserOnGoingConference(QueryUserOnGoingConferenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserOnGoingConferenceHeaders headers = new QueryUserOnGoingConferenceHeaders();
        return this.queryUserOnGoingConferenceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 开启云录制
     *
     * @param request StartCloudRecordRequest
     * @param headers StartCloudRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StartCloudRecordResponse
     */
    public StartCloudRecordResponse startCloudRecordWithOptions(String conferenceId, StartCloudRecordRequest request, StartCloudRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mode)) {
            body.put("mode", request.mode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.smallWindowPosition)) {
            body.put("smallWindowPosition", request.smallWindowPosition);
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
            new TeaPair("action", "StartCloudRecord"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/start"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StartCloudRecordResponse());
    }

    /**
     * @summary 开启云录制
     *
     * @param request StartCloudRecordRequest
     * @return StartCloudRecordResponse
     */
    public StartCloudRecordResponse startCloudRecord(String conferenceId, StartCloudRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StartCloudRecordHeaders headers = new StartCloudRecordHeaders();
        return this.startCloudRecordWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 开启会议闪记
     *
     * @param request StartMinutesRequest
     * @param headers StartMinutesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StartMinutesResponse
     */
    public StartMinutesResponse startMinutesWithOptions(String conferenceId, StartMinutesRequest request, StartMinutesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ownerUnionId)) {
            body.put("ownerUnionId", request.ownerUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recordAudio)) {
            body.put("recordAudio", request.recordAudio);
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
            new TeaPair("action", "StartMinutes"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/start"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StartMinutesResponse());
    }

    /**
     * @summary 开启会议闪记
     *
     * @param request StartMinutesRequest
     * @return StartMinutesResponse
     */
    public StartMinutesResponse startMinutes(String conferenceId, StartMinutesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StartMinutesHeaders headers = new StartMinutesHeaders();
        return this.startMinutesWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 会议开始直播推流
     *
     * @param request StartStreamOutRequest
     * @param headers StartStreamOutHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StartStreamOutResponse
     */
    public StartStreamOutResponse startStreamOutWithOptions(String conferenceId, StartStreamOutRequest request, StartStreamOutHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mode)) {
            body.put("mode", request.mode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needHostJoin)) {
            body.put("needHostJoin", request.needHostJoin);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.smallWindowPosition)) {
            body.put("smallWindowPosition", request.smallWindowPosition);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.streamName)) {
            body.put("streamName", request.streamName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.streamUrlList)) {
            body.put("streamUrlList", request.streamUrlList);
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
            new TeaPair("action", "StartStreamOut"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/start"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StartStreamOutResponse());
    }

    /**
     * @summary 会议开始直播推流
     *
     * @param request StartStreamOutRequest
     * @return StartStreamOutResponse
     */
    public StartStreamOutResponse startStreamOut(String conferenceId, StartStreamOutRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StartStreamOutHeaders headers = new StartStreamOutHeaders();
        return this.startStreamOutWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 关闭云录制
     *
     * @param request StopCloudRecordRequest
     * @param headers StopCloudRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StopCloudRecordResponse
     */
    public StopCloudRecordResponse stopCloudRecordWithOptions(String conferenceId, StopCloudRecordRequest request, StopCloudRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "StopCloudRecord"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/stop"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StopCloudRecordResponse());
    }

    /**
     * @summary 关闭云录制
     *
     * @param request StopCloudRecordRequest
     * @return StopCloudRecordResponse
     */
    public StopCloudRecordResponse stopCloudRecord(String conferenceId, StopCloudRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StopCloudRecordHeaders headers = new StopCloudRecordHeaders();
        return this.stopCloudRecordWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 暂停会议闪记
     *
     * @param request StopMinutesRequest
     * @param headers StopMinutesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StopMinutesResponse
     */
    public StopMinutesResponse stopMinutesWithOptions(String conferenceId, StopMinutesRequest request, StopMinutesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "StopMinutes"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/pause"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StopMinutesResponse());
    }

    /**
     * @summary 暂停会议闪记
     *
     * @param request StopMinutesRequest
     * @return StopMinutesResponse
     */
    public StopMinutesResponse stopMinutes(String conferenceId, StopMinutesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StopMinutesHeaders headers = new StopMinutesHeaders();
        return this.stopMinutesWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 会议停止直播推流
     *
     * @param request StopStreamOutRequest
     * @param headers StopStreamOutHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StopStreamOutResponse
     */
    public StopStreamOutResponse stopStreamOutWithOptions(String conferenceId, StopStreamOutRequest request, StopStreamOutHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.stopAllStream)) {
            body.put("stopAllStream", request.stopAllStream);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.streamId)) {
            body.put("streamId", request.streamId);
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
            new TeaPair("action", "StopStreamOut"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/stop"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StopStreamOutResponse());
    }

    /**
     * @summary 会议停止直播推流
     *
     * @param request StopStreamOutRequest
     * @return StopStreamOutResponse
     */
    public StopStreamOutResponse stopStreamOut(String conferenceId, StopStreamOutRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StopStreamOutHeaders headers = new StopStreamOutHeaders();
        return this.stopStreamOutWithOptions(conferenceId, request, headers, runtime);
    }

    /**
     * @summary 更新预约会议设置
     *
     * @param request UpdateScheduleConfSettingsRequest
     * @param headers UpdateScheduleConfSettingsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateScheduleConfSettingsResponse
     */
    public UpdateScheduleConfSettingsResponse updateScheduleConfSettingsWithOptions(UpdateScheduleConfSettingsRequest request, UpdateScheduleConfSettingsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduleConfSettingModel)) {
            body.put("scheduleConfSettingModel", request.scheduleConfSettingModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduleConferenceId)) {
            body.put("scheduleConferenceId", request.scheduleConferenceId);
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
            new TeaPair("action", "UpdateScheduleConfSettings"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/scheduleConferences/settings"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateScheduleConfSettingsResponse());
    }

    /**
     * @summary 更新预约会议设置
     *
     * @param request UpdateScheduleConfSettingsRequest
     * @return UpdateScheduleConfSettingsResponse
     */
    public UpdateScheduleConfSettingsResponse updateScheduleConfSettings(UpdateScheduleConfSettingsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateScheduleConfSettingsHeaders headers = new UpdateScheduleConfSettingsHeaders();
        return this.updateScheduleConfSettingsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新预约会议
     *
     * @param request UpdateScheduleConferenceRequest
     * @param headers UpdateScheduleConferenceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateScheduleConferenceResponse
     */
    public UpdateScheduleConferenceResponse updateScheduleConferenceWithOptions(UpdateScheduleConferenceRequest request, UpdateScheduleConferenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduleConferenceId)) {
            body.put("scheduleConferenceId", request.scheduleConferenceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
            new TeaPair("action", "UpdateScheduleConference"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/scheduleConferences"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateScheduleConferenceResponse());
    }

    /**
     * @summary 更新预约会议
     *
     * @param request UpdateScheduleConferenceRequest
     * @return UpdateScheduleConferenceResponse
     */
    public UpdateScheduleConferenceResponse updateScheduleConference(UpdateScheduleConferenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateScheduleConferenceHeaders headers = new UpdateScheduleConferenceHeaders();
        return this.updateScheduleConferenceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新会议额外信息
     *
     * @param headers UpdateVideoConferenceExtInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateVideoConferenceExtInfoResponse
     */
    public UpdateVideoConferenceExtInfoResponse updateVideoConferenceExtInfoWithOptions(String conferenceId, UpdateVideoConferenceExtInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "UpdateVideoConferenceExtInfo"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + "/extInfo"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateVideoConferenceExtInfoResponse());
    }

    /**
     * @summary 更新会议额外信息
     *
     * @return UpdateVideoConferenceExtInfoResponse
     */
    public UpdateVideoConferenceExtInfoResponse updateVideoConferenceExtInfo(String conferenceId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateVideoConferenceExtInfoHeaders headers = new UpdateVideoConferenceExtInfoHeaders();
        return this.updateVideoConferenceExtInfoWithOptions(conferenceId, headers, runtime);
    }

    /**
     * @summary 设置会议中的会议属性
     *
     * @param request UpdateVideoConferenceSettingRequest
     * @param headers UpdateVideoConferenceSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateVideoConferenceSettingResponse
     */
    public UpdateVideoConferenceSettingResponse updateVideoConferenceSettingWithOptions(String conferenceId, UpdateVideoConferenceSettingRequest request, UpdateVideoConferenceSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.allowUnmuteSelf)) {
            body.put("allowUnmuteSelf", request.allowUnmuteSelf);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.autoTransferHost)) {
            body.put("autoTransferHost", request.autoTransferHost);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.forbiddenShareScreen)) {
            body.put("forbiddenShareScreen", request.forbiddenShareScreen);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.lockConference)) {
            body.put("lockConference", request.lockConference);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.muteAll)) {
            body.put("muteAll", request.muteAll);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.onlyInternalEmployeesJoin)) {
            body.put("onlyInternalEmployeesJoin", request.onlyInternalEmployeesJoin);
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
            new TeaPair("action", "UpdateVideoConferenceSetting"),
            new TeaPair("version", "conference_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/conference/videoConferences/" + conferenceId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateVideoConferenceSettingResponse());
    }

    /**
     * @summary 设置会议中的会议属性
     *
     * @param request UpdateVideoConferenceSettingRequest
     * @return UpdateVideoConferenceSettingResponse
     */
    public UpdateVideoConferenceSettingResponse updateVideoConferenceSetting(String conferenceId, UpdateVideoConferenceSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateVideoConferenceSettingHeaders headers = new UpdateVideoConferenceSettingHeaders();
        return this.updateVideoConferenceSettingWithOptions(conferenceId, request, headers, runtime);
    }
}
