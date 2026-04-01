// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkai_search_ask_1_0.models.*;

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
     * <p>查询指定用户的全部已登录设备及其状态</p>
     * 
     * @param request FetchLoginStatusDevicesRequest
     * @param headers FetchLoginStatusDevicesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FetchLoginStatusDevicesResponse
     */
    public FetchLoginStatusDevicesResponse fetchLoginStatusDevicesWithOptions(FetchLoginStatusDevicesRequest request, FetchLoginStatusDevicesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.domain)) {
            body.put("domain", request.domain);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdList)) {
            body.put("userIdList", request.userIdList);
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
            new TeaPair("action", "FetchLoginStatusDevices"),
            new TeaPair("version", "aiSearchAsk_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiSearchAsk/fetchLoginStatusDevices"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FetchLoginStatusDevicesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询指定用户的全部已登录设备及其状态</p>
     * 
     * @param request FetchLoginStatusDevicesRequest
     * @return FetchLoginStatusDevicesResponse
     */
    public FetchLoginStatusDevicesResponse fetchLoginStatusDevices(FetchLoginStatusDevicesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FetchLoginStatusDevicesHeaders headers = new FetchLoginStatusDevicesHeaders();
        return this.fetchLoginStatusDevicesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获得ai任务结果</p>
     * 
     * @param request GetAiTaskResultRequest
     * @param headers GetAiTaskResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAiTaskResultResponse
     */
    public GetAiTaskResultResponse getAiTaskResultWithOptions(GetAiTaskResultRequest request, GetAiTaskResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            query.put("taskId", request.taskId);
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
            new TeaPair("action", "GetAiTaskResult"),
            new TeaPair("version", "aiSearchAsk_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiSearchAsk/getAiTaskResult"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAiTaskResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获得ai任务结果</p>
     * 
     * @param request GetAiTaskResultRequest
     * @return GetAiTaskResultResponse
     */
    public GetAiTaskResultResponse getAiTaskResult(GetAiTaskResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAiTaskResultHeaders headers = new GetAiTaskResultHeaders();
        return this.getAiTaskResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>多数据源召回接口</p>
     * 
     * @param request RetrieveRequest
     * @param headers RetrieveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RetrieveResponse
     */
    public RetrieveResponse retrieveWithOptions(RetrieveRequest request, RetrieveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.answerer)) {
            body.put("answerer", request.answerer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dragRequestContext)) {
            body.put("dragRequestContext", request.dragRequestContext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keywordList)) {
            body.put("keywordList", request.keywordList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.limit)) {
            body.put("limit", request.limit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.question)) {
            body.put("question", request.question);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.retrievalExtendParams)) {
            body.put("retrievalExtendParams", request.retrievalExtendParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.retrieveScoreThreshold)) {
            body.put("retrieveScoreThreshold", request.retrieveScoreThreshold);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            body.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tenant)) {
            body.put("tenant", request.tenant);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenLimit)) {
            body.put("tokenLimit", request.tokenLimit);
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
            new TeaPair("action", "Retrieve"),
            new TeaPair("version", "aiSearchAsk_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiSearchAsk/retrieve"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RetrieveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>多数据源召回接口</p>
     * 
     * @param request RetrieveRequest
     * @return RetrieveResponse
     */
    public RetrieveResponse retrieve(RetrieveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RetrieveHeaders headers = new RetrieveHeaders();
        return this.retrieveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>提交ai任务</p>
     * 
     * @param tmpReq SubmitAiTaskRequest
     * @param headers SubmitAiTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SubmitAiTaskResponse
     */
    public SubmitAiTaskResponse submitAiTaskWithOptions(SubmitAiTaskRequest tmpReq, SubmitAiTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        SubmitAiTaskShrinkRequest request = new SubmitAiTaskShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.messages)) {
            request.messagesShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.messages, "messages", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.messagesShrink)) {
            query.put("messages", request.messagesShrink);
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
            new TeaPair("action", "SubmitAiTask"),
            new TeaPair("version", "aiSearchAsk_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiSearchAsk/submitAiTask"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SubmitAiTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>提交ai任务</p>
     * 
     * @param request SubmitAiTaskRequest
     * @return SubmitAiTaskResponse
     */
    public SubmitAiTaskResponse submitAiTask(SubmitAiTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SubmitAiTaskHeaders headers = new SubmitAiTaskHeaders();
        return this.submitAiTaskWithOptions(request, headers, runtime);
    }
}
