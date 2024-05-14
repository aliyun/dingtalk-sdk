// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalklink_1_0.models.*;

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
     * @summary 发送用户授权信息申请
     *
     * @param request ApplyFollowerAuthInfoRequest
     * @param headers ApplyFollowerAuthInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ApplyFollowerAuthInfoResponse
     */
    public ApplyFollowerAuthInfoResponse applyFollowerAuthInfoWithOptions(ApplyFollowerAuthInfoRequest request, ApplyFollowerAuthInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appAuthKey)) {
            body.put("appAuthKey", request.appAuthKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fieldScope)) {
            body.put("fieldScope", request.fieldScope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sessionId)) {
            body.put("sessionId", request.sessionId);
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
            new TeaPair("action", "ApplyFollowerAuthInfo"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/followers/authInfos/apply"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ApplyFollowerAuthInfoResponse());
    }

    /**
     * @summary 发送用户授权信息申请
     *
     * @param request ApplyFollowerAuthInfoRequest
     * @return ApplyFollowerAuthInfoResponse
     */
    public ApplyFollowerAuthInfoResponse applyFollowerAuthInfo(ApplyFollowerAuthInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ApplyFollowerAuthInfoHeaders headers = new ApplyFollowerAuthInfoHeaders();
        return this.applyFollowerAuthInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 注册服务窗消息回调服务
     *
     * @param request CallbackRegiesterRequest
     * @param headers CallbackRegiesterHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CallbackRegiesterResponse
     */
    public CallbackRegiesterResponse callbackRegiesterWithOptions(CallbackRegiesterRequest request, CallbackRegiesterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.apiSecret)) {
            body.put("apiSecret", request.apiSecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callbackKey)) {
            body.put("callbackKey", request.callbackKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callbackUrl)) {
            body.put("callbackUrl", request.callbackUrl);
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
            new TeaPair("action", "CallbackRegiester"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/callbacks/regiester"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CallbackRegiesterResponse());
    }

    /**
     * @summary 注册服务窗消息回调服务
     *
     * @param request CallbackRegiesterRequest
     * @return CallbackRegiesterResponse
     */
    public CallbackRegiesterResponse callbackRegiester(CallbackRegiesterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CallbackRegiesterHeaders headers = new CallbackRegiesterHeaders();
        return this.callbackRegiesterWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务窗吊顶卡片关闭接口
     *
     * @param request CloseTopBoxInteractiveOTOMessageRequest
     * @param headers CloseTopBoxInteractiveOTOMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CloseTopBoxInteractiveOTOMessageResponse
     */
    public CloseTopBoxInteractiveOTOMessageResponse closeTopBoxInteractiveOTOMessageWithOptions(CloseTopBoxInteractiveOTOMessageRequest request, CloseTopBoxInteractiveOTOMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.detail)) {
            body.put("detail", request.detail);
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
            new TeaPair("action", "CloseTopBoxInteractiveOTOMessage"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/oToMessages/topBoxes/close"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CloseTopBoxInteractiveOTOMessageResponse());
    }

    /**
     * @summary 服务窗吊顶卡片关闭接口
     *
     * @param request CloseTopBoxInteractiveOTOMessageRequest
     * @return CloseTopBoxInteractiveOTOMessageResponse
     */
    public CloseTopBoxInteractiveOTOMessageResponse closeTopBoxInteractiveOTOMessage(CloseTopBoxInteractiveOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CloseTopBoxInteractiveOTOMessageHeaders headers = new CloseTopBoxInteractiveOTOMessageHeaders();
        return this.closeTopBoxInteractiveOTOMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取用户授权信息
     *
     * @param request GetFollowerAuthInfoRequest
     * @param headers GetFollowerAuthInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFollowerAuthInfoResponse
     */
    public GetFollowerAuthInfoResponse getFollowerAuthInfoWithOptions(GetFollowerAuthInfoRequest request, GetFollowerAuthInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            query.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "GetFollowerAuthInfo"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/followers/authInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFollowerAuthInfoResponse());
    }

    /**
     * @summary 获取用户授权信息
     *
     * @param request GetFollowerAuthInfoRequest
     * @return GetFollowerAuthInfoResponse
     */
    public GetFollowerAuthInfoResponse getFollowerAuthInfo(GetFollowerAuthInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFollowerAuthInfoHeaders headers = new GetFollowerAuthInfoHeaders();
        return this.getFollowerAuthInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取服务窗关注人信息
     *
     * @param request GetFollowerInfoRequest
     * @param headers GetFollowerInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFollowerInfoResponse
     */
    public GetFollowerInfoResponse getFollowerInfoWithOptions(GetFollowerInfoRequest request, GetFollowerInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            query.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "GetFollowerInfo"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/followers/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFollowerInfoResponse());
    }

    /**
     * @summary 获取服务窗关注人信息
     *
     * @param request GetFollowerInfoRequest
     * @return GetFollowerInfoResponse
     */
    public GetFollowerInfoResponse getFollowerInfo(GetFollowerInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFollowerInfoHeaders headers = new GetFollowerInfoHeaders();
        return this.getFollowerInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务窗图片消息下载地址获取接口
     *
     * @param request GetPictureDownloadUrlRequest
     * @param headers GetPictureDownloadUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPictureDownloadUrlResponse
     */
    public GetPictureDownloadUrlResponse getPictureDownloadUrlWithOptions(GetPictureDownloadUrlRequest request, GetPictureDownloadUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.downloadCode)) {
            query.put("downloadCode", request.downloadCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sessionId)) {
            query.put("sessionId", request.sessionId);
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
            new TeaPair("action", "GetPictureDownloadUrl"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/oToMessages/pictures/downloadUrls"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPictureDownloadUrlResponse());
    }

    /**
     * @summary 服务窗图片消息下载地址获取接口
     *
     * @param request GetPictureDownloadUrlRequest
     * @return GetPictureDownloadUrlResponse
     */
    public GetPictureDownloadUrlResponse getPictureDownloadUrl(GetPictureDownloadUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPictureDownloadUrlHeaders headers = new GetPictureDownloadUrlHeaders();
        return this.getPictureDownloadUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取用户关注状态
     *
     * @param request GetUserFollowStatusRequest
     * @param headers GetUserFollowStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserFollowStatusResponse
     */
    public GetUserFollowStatusResponse getUserFollowStatusWithOptions(GetUserFollowStatusRequest request, GetUserFollowStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            query.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "GetUserFollowStatus"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/followers/statuses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserFollowStatusResponse());
    }

    /**
     * @summary 获取用户关注状态
     *
     * @param request GetUserFollowStatusRequest
     * @return GetUserFollowStatusResponse
     */
    public GetUserFollowStatusResponse getUserFollowStatus(GetUserFollowStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserFollowStatusHeaders headers = new GetUserFollowStatusHeaders();
        return this.getUserFollowStatusWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业下服务窗帐号列表
     *
     * @param headers ListAccountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAccountResponse
     */
    public ListAccountResponse listAccountWithOptions(ListAccountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListAccount"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/accounts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAccountResponse());
    }

    /**
     * @summary 获取企业下服务窗帐号列表
     *
     * @return ListAccountResponse
     */
    public ListAccountResponse listAccount() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAccountHeaders headers = new ListAccountHeaders();
        return this.listAccountWithOptions(headers, runtime);
    }

    /**
     * @summary 第三方企业应用查询服务窗帐号列表
     *
     * @param headers ListAccountInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAccountInfoResponse
     */
    public ListAccountInfoResponse listAccountInfoWithOptions(ListAccountInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListAccountInfo"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/isv/accounts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAccountInfoResponse());
    }

    /**
     * @summary 第三方企业应用查询服务窗帐号列表
     *
     * @return ListAccountInfoResponse
     */
    public ListAccountInfoResponse listAccountInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAccountInfoHeaders headers = new ListAccountInfoHeaders();
        return this.listAccountInfoWithOptions(headers, runtime);
    }

    /**
     * @summary 批量获取服务窗关注人列表
     *
     * @param request ListFollowerRequest
     * @param headers ListFollowerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListFollowerResponse
     */
    public ListFollowerResponse listFollowerWithOptions(ListFollowerRequest request, ListFollowerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            query.put("accountId", request.accountId);
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListFollower"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/followers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListFollowerResponse());
    }

    /**
     * @summary 批量获取服务窗关注人列表
     *
     * @param request ListFollowerRequest
     * @return ListFollowerResponse
     */
    public ListFollowerResponse listFollower(ListFollowerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListFollowerHeaders headers = new ListFollowerHeaders();
        return this.listFollowerWithOptions(request, headers, runtime);
    }

    /**
     * @summary 第三方企业应用查询用户是否关注服务窗
     *
     * @param request QueryUserFollowStatusRequest
     * @param headers QueryUserFollowStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserFollowStatusResponse
     */
    public QueryUserFollowStatusResponse queryUserFollowStatusWithOptions(QueryUserFollowStatusRequest request, QueryUserFollowStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            query.put("accountId", request.accountId);
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
            new TeaPair("action", "QueryUserFollowStatus"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/isv/followers/statuses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserFollowStatusResponse());
    }

    /**
     * @summary 第三方企业应用查询用户是否关注服务窗
     *
     * @param request QueryUserFollowStatusRequest
     * @return QueryUserFollowStatusResponse
     */
    public QueryUserFollowStatusResponse queryUserFollowStatus(QueryUserFollowStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserFollowStatusHeaders headers = new QueryUserFollowStatusHeaders();
        return this.queryUserFollowStatusWithOptions(request, headers, runtime);
    }

    /**
     * @summary 发送服务窗客服消息
     *
     * @param request SendAgentOTOMessageRequest
     * @param headers SendAgentOTOMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendAgentOTOMessageResponse
     */
    public SendAgentOTOMessageResponse sendAgentOTOMessageWithOptions(SendAgentOTOMessageRequest request, SendAgentOTOMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.detail)) {
            body.put("detail", request.detail);
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
            new TeaPair("action", "SendAgentOTOMessage"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/oToMessages/agentMessages"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendAgentOTOMessageResponse());
    }

    /**
     * @summary 发送服务窗客服消息
     *
     * @param request SendAgentOTOMessageRequest
     * @return SendAgentOTOMessageResponse
     */
    public SendAgentOTOMessageResponse sendAgentOTOMessage(SendAgentOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendAgentOTOMessageHeaders headers = new SendAgentOTOMessageHeaders();
        return this.sendAgentOTOMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务窗互动卡片单发接口
     *
     * @param request SendInteractiveOTOMessageRequest
     * @param headers SendInteractiveOTOMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendInteractiveOTOMessageResponse
     */
    public SendInteractiveOTOMessageResponse sendInteractiveOTOMessageWithOptions(SendInteractiveOTOMessageRequest request, SendInteractiveOTOMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.detail)) {
            body.put("detail", request.detail);
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
            new TeaPair("action", "SendInteractiveOTOMessage"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/oToMessages/interactiveMessages"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendInteractiveOTOMessageResponse());
    }

    /**
     * @summary 服务窗互动卡片单发接口
     *
     * @param request SendInteractiveOTOMessageRequest
     * @return SendInteractiveOTOMessageResponse
     */
    public SendInteractiveOTOMessageResponse sendInteractiveOTOMessage(SendInteractiveOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendInteractiveOTOMessageHeaders headers = new SendInteractiveOTOMessageHeaders();
        return this.sendInteractiveOTOMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务窗吊顶卡片发送接口
     *
     * @param request SendTopBoxInteractiveOTOMessageRequest
     * @param headers SendTopBoxInteractiveOTOMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendTopBoxInteractiveOTOMessageResponse
     */
    public SendTopBoxInteractiveOTOMessageResponse sendTopBoxInteractiveOTOMessageWithOptions(SendTopBoxInteractiveOTOMessageRequest request, SendTopBoxInteractiveOTOMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.detail)) {
            body.put("detail", request.detail);
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
            new TeaPair("action", "SendTopBoxInteractiveOTOMessage"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/oToMessages/topBoxes/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendTopBoxInteractiveOTOMessageResponse());
    }

    /**
     * @summary 服务窗吊顶卡片发送接口
     *
     * @param request SendTopBoxInteractiveOTOMessageRequest
     * @return SendTopBoxInteractiveOTOMessageResponse
     */
    public SendTopBoxInteractiveOTOMessageResponse sendTopBoxInteractiveOTOMessage(SendTopBoxInteractiveOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendTopBoxInteractiveOTOMessageHeaders headers = new SendTopBoxInteractiveOTOMessageHeaders();
        return this.sendTopBoxInteractiveOTOMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务窗互动卡片修改接口
     *
     * @param request UpdateInteractiveOTOMessageRequest
     * @param headers UpdateInteractiveOTOMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInteractiveOTOMessageResponse
     */
    public UpdateInteractiveOTOMessageResponse updateInteractiveOTOMessageWithOptions(UpdateInteractiveOTOMessageRequest request, UpdateInteractiveOTOMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.detail)) {
            body.put("detail", request.detail);
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
            new TeaPair("action", "UpdateInteractiveOTOMessage"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/oToMessages/interactiveMessages"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInteractiveOTOMessageResponse());
    }

    /**
     * @summary 服务窗互动卡片修改接口
     *
     * @param request UpdateInteractiveOTOMessageRequest
     * @return UpdateInteractiveOTOMessageResponse
     */
    public UpdateInteractiveOTOMessageResponse updateInteractiveOTOMessage(UpdateInteractiveOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInteractiveOTOMessageHeaders headers = new UpdateInteractiveOTOMessageHeaders();
        return this.updateInteractiveOTOMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务窗会话窗口快捷栏配置接口
     *
     * @param request UpdateShortcutsRequest
     * @param headers UpdateShortcutsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateShortcutsResponse
     */
    public UpdateShortcutsResponse updateShortcutsWithOptions(UpdateShortcutsRequest request, UpdateShortcutsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.details)) {
            body.put("details", request.details);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sessionId)) {
            body.put("sessionId", request.sessionId);
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
            new TeaPair("action", "UpdateShortcuts"),
            new TeaPair("version", "link_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/link/shortcuts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateShortcutsResponse());
    }

    /**
     * @summary 服务窗会话窗口快捷栏配置接口
     *
     * @param request UpdateShortcutsRequest
     * @return UpdateShortcutsResponse
     */
    public UpdateShortcutsResponse updateShortcuts(UpdateShortcutsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateShortcutsHeaders headers = new UpdateShortcutsHeaders();
        return this.updateShortcutsWithOptions(request, headers, runtime);
    }
}
