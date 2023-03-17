// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalklink_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public ApplyFollowerAuthInfoResponse applyFollowerAuthInfo(ApplyFollowerAuthInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ApplyFollowerAuthInfoHeaders headers = new ApplyFollowerAuthInfoHeaders();
        return this.applyFollowerAuthInfoWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("ApplyFollowerAuthInfo", "link_1.0", "HTTP", "POST", "AK", "/v1.0/link/followers/authInfos/apply", "json", req, runtime), new ApplyFollowerAuthInfoResponse());
    }

    public CallbackRegiesterResponse callbackRegiester(CallbackRegiesterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CallbackRegiesterHeaders headers = new CallbackRegiesterHeaders();
        return this.callbackRegiesterWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("CallbackRegiester", "link_1.0", "HTTP", "POST", "AK", "/v1.0/link/callbacks/regiester", "json", req, runtime), new CallbackRegiesterResponse());
    }

    public CloseTopBoxInteractiveOTOMessageResponse closeTopBoxInteractiveOTOMessage(CloseTopBoxInteractiveOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CloseTopBoxInteractiveOTOMessageHeaders headers = new CloseTopBoxInteractiveOTOMessageHeaders();
        return this.closeTopBoxInteractiveOTOMessageWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("CloseTopBoxInteractiveOTOMessage", "link_1.0", "HTTP", "POST", "AK", "/v1.0/link/oToMessages/topBoxes/close", "json", req, runtime), new CloseTopBoxInteractiveOTOMessageResponse());
    }

    public GetFollowerAuthInfoResponse getFollowerAuthInfo(GetFollowerAuthInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFollowerAuthInfoHeaders headers = new GetFollowerAuthInfoHeaders();
        return this.getFollowerAuthInfoWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetFollowerAuthInfo", "link_1.0", "HTTP", "GET", "AK", "/v1.0/link/followers/authInfos", "json", req, runtime), new GetFollowerAuthInfoResponse());
    }

    public GetFollowerInfoResponse getFollowerInfo(GetFollowerInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFollowerInfoHeaders headers = new GetFollowerInfoHeaders();
        return this.getFollowerInfoWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetFollowerInfo", "link_1.0", "HTTP", "GET", "AK", "/v1.0/link/followers/infos", "json", req, runtime), new GetFollowerInfoResponse());
    }

    public GetPictureDownloadUrlResponse getPictureDownloadUrl(GetPictureDownloadUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPictureDownloadUrlHeaders headers = new GetPictureDownloadUrlHeaders();
        return this.getPictureDownloadUrlWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetPictureDownloadUrl", "link_1.0", "HTTP", "GET", "AK", "/v1.0/link/oToMessages/pictures/downloadUrls", "json", req, runtime), new GetPictureDownloadUrlResponse());
    }

    public GetUserFollowStatusResponse getUserFollowStatus(GetUserFollowStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserFollowStatusHeaders headers = new GetUserFollowStatusHeaders();
        return this.getUserFollowStatusWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetUserFollowStatus", "link_1.0", "HTTP", "GET", "AK", "/v1.0/link/followers/statuses", "json", req, runtime), new GetUserFollowStatusResponse());
    }

    public ListAccountResponse listAccount() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAccountHeaders headers = new ListAccountHeaders();
        return this.listAccountWithOptions(headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("ListAccount", "link_1.0", "HTTP", "GET", "AK", "/v1.0/link/accounts", "json", req, runtime), new ListAccountResponse());
    }

    public ListAccountInfoResponse listAccountInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAccountInfoHeaders headers = new ListAccountInfoHeaders();
        return this.listAccountInfoWithOptions(headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("ListAccountInfo", "link_1.0", "HTTP", "GET", "AK", "/v1.0/link/isv/accounts", "json", req, runtime), new ListAccountInfoResponse());
    }

    public ListFollowerResponse listFollower(ListFollowerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListFollowerHeaders headers = new ListFollowerHeaders();
        return this.listFollowerWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("ListFollower", "link_1.0", "HTTP", "GET", "AK", "/v1.0/link/followers", "json", req, runtime), new ListFollowerResponse());
    }

    public QueryUserFollowStatusResponse queryUserFollowStatus(QueryUserFollowStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserFollowStatusHeaders headers = new QueryUserFollowStatusHeaders();
        return this.queryUserFollowStatusWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryUserFollowStatus", "link_1.0", "HTTP", "GET", "AK", "/v1.0/link/isv/followers/statuses", "json", req, runtime), new QueryUserFollowStatusResponse());
    }

    public SendAgentOTOMessageResponse sendAgentOTOMessage(SendAgentOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendAgentOTOMessageHeaders headers = new SendAgentOTOMessageHeaders();
        return this.sendAgentOTOMessageWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("SendAgentOTOMessage", "link_1.0", "HTTP", "POST", "AK", "/v1.0/link/oToMessages/agentMessages", "json", req, runtime), new SendAgentOTOMessageResponse());
    }

    public SendInteractiveOTOMessageResponse sendInteractiveOTOMessage(SendInteractiveOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendInteractiveOTOMessageHeaders headers = new SendInteractiveOTOMessageHeaders();
        return this.sendInteractiveOTOMessageWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("SendInteractiveOTOMessage", "link_1.0", "HTTP", "POST", "AK", "/v1.0/link/oToMessages/interactiveMessages", "json", req, runtime), new SendInteractiveOTOMessageResponse());
    }

    public SendTopBoxInteractiveOTOMessageResponse sendTopBoxInteractiveOTOMessage(SendTopBoxInteractiveOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendTopBoxInteractiveOTOMessageHeaders headers = new SendTopBoxInteractiveOTOMessageHeaders();
        return this.sendTopBoxInteractiveOTOMessageWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("SendTopBoxInteractiveOTOMessage", "link_1.0", "HTTP", "POST", "AK", "/v1.0/link/oToMessages/topBoxes/send", "json", req, runtime), new SendTopBoxInteractiveOTOMessageResponse());
    }

    public UpdateInteractiveOTOMessageResponse updateInteractiveOTOMessage(UpdateInteractiveOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInteractiveOTOMessageHeaders headers = new UpdateInteractiveOTOMessageHeaders();
        return this.updateInteractiveOTOMessageWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("UpdateInteractiveOTOMessage", "link_1.0", "HTTP", "PUT", "AK", "/v1.0/link/oToMessages/interactiveMessages", "json", req, runtime), new UpdateInteractiveOTOMessageResponse());
    }

    public UpdateShortcutsResponse updateShortcuts(UpdateShortcutsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateShortcutsHeaders headers = new UpdateShortcutsHeaders();
        return this.updateShortcutsWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("UpdateShortcuts", "link_1.0", "HTTP", "POST", "AK", "/v1.0/link/shortcuts", "json", req, runtime), new UpdateShortcutsResponse());
    }
}
