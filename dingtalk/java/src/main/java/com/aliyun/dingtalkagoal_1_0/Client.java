// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkagoal_1_0.models.*;

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
     * @summary 获取Agoal目标规则下的周期列表
     *
     * @param request AgoalObjectiveRulePeriodListRequest
     * @param headers AgoalObjectiveRulePeriodListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalObjectiveRulePeriodListResponse
     */
    public AgoalObjectiveRulePeriodListResponse agoalObjectiveRulePeriodListWithOptions(AgoalObjectiveRulePeriodListRequest request, AgoalObjectiveRulePeriodListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.objectiveRuleId)) {
            query.put("objectiveRuleId", request.objectiveRuleId);
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
            new TeaPair("action", "AgoalObjectiveRulePeriodList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/objectiveRules/periodLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalObjectiveRulePeriodListResponse());
    }

    /**
     * @summary 获取Agoal目标规则下的周期列表
     *
     * @param request AgoalObjectiveRulePeriodListRequest
     * @return AgoalObjectiveRulePeriodListResponse
     */
    public AgoalObjectiveRulePeriodListResponse agoalObjectiveRulePeriodList(AgoalObjectiveRulePeriodListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalObjectiveRulePeriodListHeaders headers = new AgoalObjectiveRulePeriodListHeaders();
        return this.agoalObjectiveRulePeriodListWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取Agoal目标规则列表
     *
     * @param headers AgoalOrgObjectiveRuleListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalOrgObjectiveRuleListResponse
     */
    public AgoalOrgObjectiveRuleListResponse agoalOrgObjectiveRuleListWithOptions(AgoalOrgObjectiveRuleListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "AgoalOrgObjectiveRuleList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/objectiveRules/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalOrgObjectiveRuleListResponse());
    }

    /**
     * @summary 获取Agoal目标规则列表
     *
     * @return AgoalOrgObjectiveRuleListResponse
     */
    public AgoalOrgObjectiveRuleListResponse agoalOrgObjectiveRuleList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalOrgObjectiveRuleListHeaders headers = new AgoalOrgObjectiveRuleListHeaders();
        return this.agoalOrgObjectiveRuleListWithOptions(headers, runtime);
    }

    /**
     * @summary Agoal消息发送
     *
     * @param request AgoalSendMessageRequest
     * @param headers AgoalSendMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalSendMessageResponse
     */
    public AgoalSendMessageResponse agoalSendMessageWithOptions(AgoalSendMessageRequest request, AgoalSendMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mobileUrl)) {
            body.put("mobileUrl", request.mobileUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.params)) {
            body.put("params", request.params);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcUrl)) {
            body.put("pcUrl", request.pcUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceDingUserId)) {
            body.put("sourceDingUserId", request.sourceDingUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetDingUserIds)) {
            body.put("targetDingUserIds", request.targetDingUserIds);
        }

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
            new TeaPair("action", "AgoalSendMessage"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/messages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalSendMessageResponse());
    }

    /**
     * @summary Agoal消息发送
     *
     * @param request AgoalSendMessageRequest
     * @return AgoalSendMessageResponse
     */
    public AgoalSendMessageResponse agoalSendMessage(AgoalSendMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalSendMessageHeaders headers = new AgoalSendMessageHeaders();
        return this.agoalSendMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取Agoal管理员列表
     *
     * @param headers AgoalUserAdminListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalUserAdminListResponse
     */
    public AgoalUserAdminListResponse agoalUserAdminListWithOptions(AgoalUserAdminListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "AgoalUserAdminList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/administrators/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalUserAdminListResponse());
    }

    /**
     * @summary 获取Agoal管理员列表
     *
     * @return AgoalUserAdminListResponse
     */
    public AgoalUserAdminListResponse agoalUserAdminList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalUserAdminListHeaders headers = new AgoalUserAdminListHeaders();
        return this.agoalUserAdminListWithOptions(headers, runtime);
    }

    /**
     * @summary Agoal用户目标列表
     *
     * @param request AgoalUserObjectiveListRequest
     * @param headers AgoalUserObjectiveListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalUserObjectiveListResponse
     */
    public AgoalUserObjectiveListResponse agoalUserObjectiveListWithOptions(AgoalUserObjectiveListRequest request, AgoalUserObjectiveListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingUserId)) {
            body.put("dingUserId", request.dingUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectiveRuleId)) {
            body.put("objectiveRuleId", request.objectiveRuleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodIds)) {
            body.put("periodIds", request.periodIds);
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
            new TeaPair("action", "AgoalUserObjectiveList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/users/objectiveLists/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalUserObjectiveListResponse());
    }

    /**
     * @summary Agoal用户目标列表
     *
     * @param request AgoalUserObjectiveListRequest
     * @return AgoalUserObjectiveListResponse
     */
    public AgoalUserObjectiveListResponse agoalUserObjectiveList(AgoalUserObjectiveListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalUserObjectiveListHeaders headers = new AgoalUserObjectiveListHeaders();
        return this.agoalUserObjectiveListWithOptions(request, headers, runtime);
    }
}
