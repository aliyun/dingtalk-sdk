// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkevent_1_0.models.*;

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
     * <p>调用本获取推送失败的变更事件。</p>
     * 
     * @param request GetCallBackFaileResultRequest
     * @param headers GetCallBackFaileResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCallBackFaileResultResponse
     */
    public GetCallBackFaileResultResponse getCallBackFaileResultWithOptions(GetCallBackFaileResultRequest request, GetCallBackFaileResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.beginTime)) {
            query.put("beginTime", request.beginTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
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
            new TeaPair("action", "GetCallBackFaileResult"),
            new TeaPair("version", "event_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/event/callbacks/failedResults"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCallBackFaileResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>调用本获取推送失败的变更事件。</p>
     * 
     * @param request GetCallBackFaileResultRequest
     * @return GetCallBackFaileResultResponse
     */
    public GetCallBackFaileResultResponse getCallBackFaileResult(GetCallBackFaileResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCallBackFaileResultHeaders headers = new GetCallBackFaileResultHeaders();
        return this.getCallBackFaileResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>安装一方应用</p>
     * 
     * @param request InstallAppRequest
     * @param headers InstallAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InstallAppResponse
     */
    public InstallAppResponse installAppWithOptions(InstallAppRequest request, InstallAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            query.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingUserId)) {
            query.put("dingUserId", request.dingUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteId)) {
            query.put("suiteId", request.suiteId);
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
            new TeaPair("action", "InstallApp"),
            new TeaPair("version", "event_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/event/elm/apps/install"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InstallAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>安装一方应用</p>
     * 
     * @param request InstallAppRequest
     * @return InstallAppResponse
     */
    public InstallAppResponse installApp(InstallAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InstallAppHeaders headers = new InstallAppHeaders();
        return this.installAppWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>安装酷应用</p>
     * 
     * @param tmpReq InstallCoolAppRequest
     * @param headers InstallCoolAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InstallCoolAppResponse
     */
    public InstallCoolAppResponse installCoolAppWithOptions(InstallCoolAppRequest tmpReq, InstallCoolAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        InstallCoolAppShrinkRequest request = new InstallCoolAppShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.feature)) {
            request.featureShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.feature, "feature", "json");
        }

        if (!com.aliyun.teautil.Common.isUnset(tmpReq.options)) {
            request.optionsShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.options, "options", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            query.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            query.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.featureShrink)) {
            query.put("feature", request.featureShrink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.installUid)) {
            query.put("installUid", request.installUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            query.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optionsShrink)) {
            query.put("options", request.optionsShrink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteId)) {
            query.put("suiteId", request.suiteId);
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
            new TeaPair("action", "InstallCoolApp"),
            new TeaPair("version", "event_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/event/elm/coolApps/install"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InstallCoolAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>安装酷应用</p>
     * 
     * @param request InstallCoolAppRequest
     * @return InstallCoolAppResponse
     */
    public InstallCoolAppResponse installCoolApp(InstallCoolAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InstallCoolAppHeaders headers = new InstallCoolAppHeaders();
        return this.installCoolAppWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>重新获取suiteTicket</p>
     * 
     * @param request RePushSuiteTicketRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return RePushSuiteTicketResponse
     */
    public RePushSuiteTicketResponse rePushSuiteTicketWithOptions(RePushSuiteTicketRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.suiteId)) {
            query.put("suiteId", request.suiteId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteSecret)) {
            query.put("suiteSecret", request.suiteSecret);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RePushSuiteTicket"),
            new TeaPair("version", "event_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/event/suiteTicket/rePush"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new RePushSuiteTicketResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>重新获取suiteTicket</p>
     * 
     * @param request RePushSuiteTicketRequest
     * @return RePushSuiteTicketResponse
     */
    public RePushSuiteTicketResponse rePushSuiteTicket(RePushSuiteTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.rePushSuiteTicketWithOptions(request, headers, runtime);
    }
}
