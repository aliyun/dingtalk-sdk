// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkexclusive_1_0.models.*;

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
     * <p>新增企业</p>
     * 
     * @param request AddOrgRequest
     * @param headers AddOrgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddOrgResponse
     */
    public AddOrgResponse addOrgWithOptions(AddOrgRequest request, AddOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.city)) {
            body.put("city", request.city);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.industry)) {
            body.put("industry", request.industry);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.industryCode)) {
            body.put("industryCode", request.industryCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobileNum)) {
            body.put("mobileNum", request.mobileNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.province)) {
            body.put("province", request.province);
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
            new TeaPair("action", "AddOrg"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/orgnizations"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddOrgResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增企业</p>
     * 
     * @param request AddOrgRequest
     * @return AddOrgResponse
     */
    public AddOrgResponse addOrg(AddOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddOrgHeaders headers = new AddOrgHeaders();
        return this.addOrgWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>专属审批结果回调</p>
     * 
     * @param request ApproveProcessCallbackRequest
     * @param headers ApproveProcessCallbackHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ApproveProcessCallbackResponse
     */
    public ApproveProcessCallbackResponse approveProcessCallbackWithOptions(ApproveProcessCallbackRequest request, ApproveProcessCallbackHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKeyId)) {
            body.put("accessKeyId", request.accessKeyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accessKeySecret)) {
            body.put("accessKeySecret", request.accessKeySecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.request)) {
            body.put("request", request.request);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "ApproveProcessCallback"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/approvalResults/callback"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ApproveProcessCallbackResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>专属审批结果回调</p>
     * 
     * @param request ApproveProcessCallbackRequest
     * @return ApproveProcessCallbackResponse
     */
    public ApproveProcessCallbackResponse approveProcessCallback(ApproveProcessCallbackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ApproveProcessCallbackHeaders headers = new ApproveProcessCallbackHeaders();
        return this.approveProcessCallbackWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>群禁言或解禁</p>
     * 
     * @param request BanOrOpenGroupWordsRequest
     * @param headers BanOrOpenGroupWordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BanOrOpenGroupWordsResponse
     */
    public BanOrOpenGroupWordsResponse banOrOpenGroupWordsWithOptions(BanOrOpenGroupWordsRequest request, BanOrOpenGroupWordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.banWordsType)) {
            body.put("banWordsType", request.banWordsType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConverationId)) {
            body.put("openConverationId", request.openConverationId);
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
            new TeaPair("action", "BanOrOpenGroupWords"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BanOrOpenGroupWordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>群禁言或解禁</p>
     * 
     * @param request BanOrOpenGroupWordsRequest
     * @return BanOrOpenGroupWordsResponse
     */
    public BanOrOpenGroupWordsResponse banOrOpenGroupWords(BanOrOpenGroupWordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BanOrOpenGroupWordsHeaders headers = new BanOrOpenGroupWordsHeaders();
        return this.banOrOpenGroupWordsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建分组并绑定会话</p>
     * 
     * @param request CreateCategoryAndBindingGroupsRequest
     * @param headers CreateCategoryAndBindingGroupsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCategoryAndBindingGroupsResponse
     */
    public CreateCategoryAndBindingGroupsResponse createCategoryAndBindingGroupsWithOptions(CreateCategoryAndBindingGroupsRequest request, CreateCategoryAndBindingGroupsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.categoryName)) {
            body.put("categoryName", request.categoryName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupIds)) {
            body.put("groupIds", request.groupIds);
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
            new TeaPair("action", "CreateCategoryAndBindingGroups"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/messageCategories/categories/createAndBind"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCategoryAndBindingGroupsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建分组并绑定会话</p>
     * 
     * @param request CreateCategoryAndBindingGroupsRequest
     * @return CreateCategoryAndBindingGroupsResponse
     */
    public CreateCategoryAndBindingGroupsResponse createCategoryAndBindingGroups(CreateCategoryAndBindingGroupsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCategoryAndBindingGroupsHeaders headers = new CreateCategoryAndBindingGroupsHeaders();
        return this.createCategoryAndBindingGroupsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建文件检测任务</p>
     * 
     * @param request CreateDlpTaskRequest
     * @param headers CreateDlpTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateDlpTaskResponse
     */
    public CreateDlpTaskResponse createDlpTaskWithOptions(CreateDlpTaskRequest request, CreateDlpTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryId)) {
            body.put("dentryId", request.dentryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceId)) {
            body.put("spaceId", request.spaceId);
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
            new TeaPair("action", "CreateDlpTask"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/dlpTasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateDlpTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建文件检测任务</p>
     * 
     * @param request CreateDlpTaskRequest
     * @return CreateDlpTaskResponse
     */
    public CreateDlpTaskResponse createDlpTask(CreateDlpTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDlpTaskHeaders headers = new CreateDlpTaskHeaders();
        return this.createDlpTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建分组并绑定会话</p>
     * 
     * @param request CreateMessageCategoryRequest
     * @param headers CreateMessageCategoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateMessageCategoryResponse
     */
    public CreateMessageCategoryResponse createMessageCategoryWithOptions(CreateMessageCategoryRequest request, CreateMessageCategoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.categoryName)) {
            body.put("categoryName", request.categoryName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupIds)) {
            body.put("groupIds", request.groupIds);
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
            new TeaPair("action", "CreateMessageCategory"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/messageCategories/categories/create"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateMessageCategoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建分组并绑定会话</p>
     * 
     * @param request CreateMessageCategoryRequest
     * @return CreateMessageCategoryResponse
     */
    public CreateMessageCategoryResponse createMessageCategory(CreateMessageCategoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateMessageCategoryHeaders headers = new CreateMessageCategoryHeaders();
        return this.createMessageCategoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建规则</p>
     * 
     * @param request CreateRuleRequest
     * @param headers CreateRuleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateRuleResponse
     */
    public CreateRuleResponse createRuleWithOptions(CreateRuleRequest request, CreateRuleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customPlan)) {
            body.put("customPlan", request.customPlan);
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
            new TeaPair("action", "CreateRule"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/messageCategories/rules"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateRuleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建规则</p>
     * 
     * @param request CreateRuleRequest
     * @return CreateRuleResponse
     */
    public CreateRuleResponse createRule(CreateRuleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateRuleHeaders headers = new CreateRuleHeaders();
        return this.createRuleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>存入可信设备信息</p>
     * 
     * @param request CreateTrustedDeviceRequest
     * @param headers CreateTrustedDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTrustedDeviceResponse
     */
    public CreateTrustedDeviceResponse createTrustedDeviceWithOptions(CreateTrustedDeviceRequest request, CreateTrustedDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.did)) {
            body.put("did", request.did);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.macAddress)) {
            body.put("macAddress", request.macAddress);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platform)) {
            body.put("platform", request.platform);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
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
            new TeaPair("action", "CreateTrustedDevice"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/trustedDevices"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTrustedDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>存入可信设备信息</p>
     * 
     * @param request CreateTrustedDeviceRequest
     * @return CreateTrustedDeviceResponse
     */
    public CreateTrustedDeviceResponse createTrustedDevice(CreateTrustedDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTrustedDeviceHeaders headers = new CreateTrustedDeviceHeaders();
        return this.createTrustedDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量新增可信设备</p>
     * 
     * @param request CreateTrustedDeviceBatchRequest
     * @param headers CreateTrustedDeviceBatchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTrustedDeviceBatchResponse
     */
    public CreateTrustedDeviceBatchResponse createTrustedDeviceBatchWithOptions(CreateTrustedDeviceBatchRequest request, CreateTrustedDeviceBatchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.macAddressList)) {
            body.put("macAddressList", request.macAddressList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platform)) {
            body.put("platform", request.platform);
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
            new TeaPair("action", "CreateTrustedDeviceBatch"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/trusts/devices"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTrustedDeviceBatchResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量新增可信设备</p>
     * 
     * @param request CreateTrustedDeviceBatchRequest
     * @return CreateTrustedDeviceBatchResponse
     */
    public CreateTrustedDeviceBatchResponse createTrustedDeviceBatch(CreateTrustedDeviceBatchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTrustedDeviceBatchHeaders headers = new CreateTrustedDeviceBatchHeaders();
        return this.createTrustedDeviceBatchWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>触发文件病毒扫描任务</p>
     * 
     * @param request CreateVirusScanTaskRequest
     * @param headers CreateVirusScanTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateVirusScanTaskResponse
     */
    public CreateVirusScanTaskResponse createVirusScanTaskWithOptions(CreateVirusScanTaskRequest request, CreateVirusScanTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryId)) {
            body.put("dentryId", request.dentryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.downloadUrl)) {
            body.put("downloadUrl", request.downloadUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileMd5)) {
            body.put("fileMd5", request.fileMd5);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            body.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSize)) {
            body.put("fileSize", request.fileSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceId)) {
            body.put("spaceId", request.spaceId);
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
            new TeaPair("action", "CreateVirusScanTask"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/virusScanTasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateVirusScanTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>触发文件病毒扫描任务</p>
     * 
     * @param request CreateVirusScanTaskRequest
     * @return CreateVirusScanTaskResponse
     */
    public CreateVirusScanTaskResponse createVirusScanTask(CreateVirusScanTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateVirusScanTaskHeaders headers = new CreateVirusScanTaskHeaders();
        return this.createVirusScanTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>为应用同步数据到专属存储</p>
     * 
     * @param request DataSyncRequest
     * @param headers DataSyncHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DataSyncResponse
     */
    public DataSyncResponse dataSyncWithOptions(DataSyncRequest request, DataSyncHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sql)) {
            body.put("sql", request.sql);
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
            new TeaPair("action", "DataSync"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/datas/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DataSyncResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>为应用同步数据到专属存储</p>
     * 
     * @param request DataSyncRequest
     * @return DataSyncResponse
     */
    public DataSyncResponse dataSync(DataSyncRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DataSyncHeaders headers = new DataSyncHeaders();
        return this.dataSyncWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除跨云存储配置</p>
     * 
     * @param headers DeleteAcrossCloudStroageConfigsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteAcrossCloudStroageConfigsResponse
     */
    public DeleteAcrossCloudStroageConfigsResponse deleteAcrossCloudStroageConfigsWithOptions(String targetCorpId, DeleteAcrossCloudStroageConfigsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteAcrossCloudStroageConfigs"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/fileStorages/acrossClouds/configurations/" + targetCorpId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteAcrossCloudStroageConfigsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除跨云存储配置</p>
     * @return DeleteAcrossCloudStroageConfigsResponse
     */
    public DeleteAcrossCloudStroageConfigsResponse deleteAcrossCloudStroageConfigs(String targetCorpId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteAcrossCloudStroageConfigsHeaders headers = new DeleteAcrossCloudStroageConfigsHeaders();
        return this.deleteAcrossCloudStroageConfigsWithOptions(targetCorpId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除评论</p>
     * 
     * @param headers DeleteCommentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteCommentResponse
     */
    public DeleteCommentResponse deleteCommentWithOptions(String publisherId, String commentId, DeleteCommentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteComment"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/publishers/" + publisherId + "/comments/" + commentId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "boolean")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteCommentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除评论</p>
     * @return DeleteCommentResponse
     */
    public DeleteCommentResponse deleteComment(String publisherId, String commentId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteCommentHeaders headers = new DeleteCommentHeaders();
        return this.deleteCommentWithOptions(publisherId, commentId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除指定可信设备</p>
     * 
     * @param request DeleteTrustedDeviceRequest
     * @param headers DeleteTrustedDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteTrustedDeviceResponse
     */
    public DeleteTrustedDeviceResponse deleteTrustedDeviceWithOptions(DeleteTrustedDeviceRequest request, DeleteTrustedDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.kickOff)) {
            body.put("kickOff", request.kickOff);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.macAddress)) {
            body.put("macAddress", request.macAddress);
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
            new TeaPair("action", "DeleteTrustedDevice"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/trustedDevices/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteTrustedDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除指定可信设备</p>
     * 
     * @param request DeleteTrustedDeviceRequest
     * @return DeleteTrustedDeviceResponse
     */
    public DeleteTrustedDeviceResponse deleteTrustedDevice(DeleteTrustedDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteTrustedDeviceHeaders headers = new DeleteTrustedDeviceHeaders();
        return this.deleteTrustedDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分发伙伴应用</p>
     * 
     * @param request DistributePartnerAppRequest
     * @param headers DistributePartnerAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DistributePartnerAppResponse
     */
    public DistributePartnerAppResponse distributePartnerAppWithOptions(DistributePartnerAppRequest request, DistributePartnerAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            body.put("subCorpId", request.subCorpId);
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
            new TeaPair("action", "DistributePartnerApp"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/partners/applications/distribute"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DistributePartnerAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分发伙伴应用</p>
     * 
     * @param request DistributePartnerAppRequest
     * @return DistributePartnerAppResponse
     */
    public DistributePartnerAppResponse distributePartnerApp(DistributePartnerAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DistributePartnerAppHeaders headers = new DistributePartnerAppHeaders();
        return this.distributePartnerAppWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑安全卡片管控成员</p>
     * 
     * @param request EditSecurityConfigMemberRequest
     * @param headers EditSecurityConfigMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditSecurityConfigMemberResponse
     */
    public EditSecurityConfigMemberResponse editSecurityConfigMemberWithOptions(EditSecurityConfigMemberRequest request, EditSecurityConfigMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.configKey)) {
            body.put("configKey", request.configKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateType)) {
            body.put("operateType", request.operateType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateUserId)) {
            body.put("operateUserId", request.operateUserId);
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
            new TeaPair("action", "EditSecurityConfigMember"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/securities/configs/members"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditSecurityConfigMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑安全卡片管控成员</p>
     * 
     * @param request EditSecurityConfigMemberRequest
     * @return EditSecurityConfigMemberResponse
     */
    public EditSecurityConfigMemberResponse editSecurityConfigMember(EditSecurityConfigMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditSecurityConfigMemberHeaders headers = new EditSecurityConfigMemberHeaders();
        return this.editSecurityConfigMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更换组织主管理员</p>
     * 
     * @param request ExchangeMainAdminRequest
     * @param headers ExchangeMainAdminHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ExchangeMainAdminResponse
     */
    public ExchangeMainAdminResponse exchangeMainAdminWithOptions(ExchangeMainAdminRequest request, ExchangeMainAdminHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.newAdminUserId)) {
            body.put("newAdminUserId", request.newAdminUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.oldAdminUserId)) {
            body.put("oldAdminUserId", request.oldAdminUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "ExchangeMainAdmin"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/orgnizations/mainAdministrators/exchange"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExchangeMainAdminResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更换组织主管理员</p>
     * 
     * @param request ExchangeMainAdminRequest
     * @return ExchangeMainAdminResponse
     */
    public ExchangeMainAdminResponse exchangeMainAdmin(ExchangeMainAdminRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExchangeMainAdminHeaders headers = new ExchangeMainAdminHeaders();
        return this.exchangeMainAdminWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分发工作台模版</p>
     * 
     * @param request ExclusiveCreateDingPortalRequest
     * @param headers ExclusiveCreateDingPortalHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ExclusiveCreateDingPortalResponse
     */
    public ExclusiveCreateDingPortalResponse exclusiveCreateDingPortalWithOptions(ExclusiveCreateDingPortalRequest request, ExclusiveCreateDingPortalHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingPortalName)) {
            body.put("dingPortalName", request.dingPortalName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateAppUuid)) {
            body.put("templateAppUuid", request.templateAppUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateCorpId)) {
            body.put("templateCorpId", request.templateCorpId);
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
            new TeaPair("action", "ExclusiveCreateDingPortal"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/workbenches/templates/spread"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExclusiveCreateDingPortalResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分发工作台模版</p>
     * 
     * @param request ExclusiveCreateDingPortalRequest
     * @return ExclusiveCreateDingPortalResponse
     */
    public ExclusiveCreateDingPortalResponse exclusiveCreateDingPortal(ExclusiveCreateDingPortalRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExclusiveCreateDingPortalHeaders headers = new ExclusiveCreateDingPortalHeaders();
        return this.exclusiveCreateDingPortalWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>专属文件第一次设置，激活配置</p>
     * 
     * @param request FileStorageActiveStorageRequest
     * @param headers FileStorageActiveStorageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FileStorageActiveStorageResponse
     */
    public FileStorageActiveStorageResponse fileStorageActiveStorageWithOptions(FileStorageActiveStorageRequest request, FileStorageActiveStorageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKeyId)) {
            body.put("accessKeyId", request.accessKeyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accessKeySecret)) {
            body.put("accessKeySecret", request.accessKeySecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.oss)) {
            body.put("oss", request.oss);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "FileStorageActiveStorage"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/fileStorages/active"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FileStorageActiveStorageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>专属文件第一次设置，激活配置</p>
     * 
     * @param request FileStorageActiveStorageRequest
     * @return FileStorageActiveStorageResponse
     */
    public FileStorageActiveStorageResponse fileStorageActiveStorage(FileStorageActiveStorageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FileStorageActiveStorageHeaders headers = new FileStorageActiveStorageHeaders();
        return this.fileStorageActiveStorageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>检查专属存储OSS连接</p>
     * 
     * @param request FileStorageCheckConnectionRequest
     * @param headers FileStorageCheckConnectionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FileStorageCheckConnectionResponse
     */
    public FileStorageCheckConnectionResponse fileStorageCheckConnectionWithOptions(FileStorageCheckConnectionRequest request, FileStorageCheckConnectionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKeyId)) {
            body.put("accessKeyId", request.accessKeyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accessKeySecret)) {
            body.put("accessKeySecret", request.accessKeySecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.oss)) {
            body.put("oss", request.oss);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "FileStorageCheckConnection"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/fileStorages/connections/check"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FileStorageCheckConnectionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>检查专属存储OSS连接</p>
     * 
     * @param request FileStorageCheckConnectionRequest
     * @return FileStorageCheckConnectionResponse
     */
    public FileStorageCheckConnectionResponse fileStorageCheckConnection(FileStorageCheckConnectionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FileStorageCheckConnectionHeaders headers = new FileStorageCheckConnectionHeaders();
        return this.fileStorageCheckConnectionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>专属文件存储获取存储情况(按时间区间)</p>
     * 
     * @param request FileStorageGetQuotaDataRequest
     * @param headers FileStorageGetQuotaDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FileStorageGetQuotaDataResponse
     */
    public FileStorageGetQuotaDataResponse fileStorageGetQuotaDataWithOptions(FileStorageGetQuotaDataRequest request, FileStorageGetQuotaDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            query.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
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
            new TeaPair("action", "FileStorageGetQuotaData"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/fileStorages/quotaDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FileStorageGetQuotaDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>专属文件存储获取存储情况(按时间区间)</p>
     * 
     * @param request FileStorageGetQuotaDataRequest
     * @return FileStorageGetQuotaDataResponse
     */
    public FileStorageGetQuotaDataResponse fileStorageGetQuotaData(FileStorageGetQuotaDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FileStorageGetQuotaDataHeaders headers = new FileStorageGetQuotaDataHeaders();
        return this.fileStorageGetQuotaDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>专属文件存储获取存储情况和配置</p>
     * 
     * @param request FileStorageGetStorageStateRequest
     * @param headers FileStorageGetStorageStateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FileStorageGetStorageStateResponse
     */
    public FileStorageGetStorageStateResponse fileStorageGetStorageStateWithOptions(FileStorageGetStorageStateRequest request, FileStorageGetStorageStateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            query.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "FileStorageGetStorageState"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/fileStorages/states"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FileStorageGetStorageStateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>专属文件存储获取存储情况和配置</p>
     * 
     * @param request FileStorageGetStorageStateRequest
     * @return FileStorageGetStorageStateResponse
     */
    public FileStorageGetStorageStateResponse fileStorageGetStorageState(FileStorageGetStorageStateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FileStorageGetStorageStateHeaders headers = new FileStorageGetStorageStateHeaders();
        return this.fileStorageGetStorageStateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新文件专属存储配置</p>
     * 
     * @param request FileStorageUpdateStorageRequest
     * @param headers FileStorageUpdateStorageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FileStorageUpdateStorageResponse
     */
    public FileStorageUpdateStorageResponse fileStorageUpdateStorageWithOptions(FileStorageUpdateStorageRequest request, FileStorageUpdateStorageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKeyId)) {
            body.put("accessKeyId", request.accessKeyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accessKeySecret)) {
            body.put("accessKeySecret", request.accessKeySecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "FileStorageUpdateStorage"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/fileStorages/configurations"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FileStorageUpdateStorageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新文件专属存储配置</p>
     * 
     * @param request FileStorageUpdateStorageRequest
     * @return FileStorageUpdateStorageResponse
     */
    public FileStorageUpdateStorageResponse fileStorageUpdateStorage(FileStorageUpdateStorageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FileStorageUpdateStorageHeaders headers = new FileStorageUpdateStorageHeaders();
        return this.fileStorageUpdateStorageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>生成暗水印</p>
     * 
     * @param request GenerateDarkWaterMarkRequest
     * @param headers GenerateDarkWaterMarkHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GenerateDarkWaterMarkResponse
     */
    public GenerateDarkWaterMarkResponse generateDarkWaterMarkWithOptions(GenerateDarkWaterMarkRequest request, GenerateDarkWaterMarkHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "GenerateDarkWaterMark"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GenerateDarkWaterMarkResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>生成暗水印</p>
     * 
     * @param request GenerateDarkWaterMarkRequest
     * @return GenerateDarkWaterMarkResponse
     */
    public GenerateDarkWaterMarkResponse generateDarkWaterMark(GenerateDarkWaterMarkRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GenerateDarkWaterMarkHeaders headers = new GenerateDarkWaterMarkHeaders();
        return this.generateDarkWaterMarkWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取专属钉钉账号数据迁移结果</p>
     * 
     * @param request GetAccountTransferListRequest
     * @param headers GetAccountTransferListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAccountTransferListResponse
     */
    public GetAccountTransferListResponse getAccountTransferListWithOptions(GetAccountTransferListRequest request, GetAccountTransferListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            query.put("status", request.status);
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
            new TeaPair("action", "GetAccountTransferList"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/dataTransfer/accounts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAccountTransferListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取专属钉钉账号数据迁移结果</p>
     * 
     * @param request GetAccountTransferListRequest
     * @return GetAccountTransferListResponse
     */
    public GetAccountTransferListResponse getAccountTransferList(GetAccountTransferListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAccountTransferListHeaders headers = new GetAccountTransferListHeaders();
        return this.getAccountTransferListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获得组织维度的用户dau</p>
     * 
     * @param headers GetActiveUserSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetActiveUserSummaryResponse
     */
    public GetActiveUserSummaryResponse getActiveUserSummaryWithOptions(String dataId, GetActiveUserSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetActiveUserSummary"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/dau/org/" + dataId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetActiveUserSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获得组织维度的用户dau</p>
     * @return GetActiveUserSummaryResponse
     */
    public GetActiveUserSummaryResponse getActiveUserSummary(String dataId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetActiveUserSummaryHeaders headers = new GetActiveUserSummaryHeaders();
        return this.getActiveUserSummaryWithOptions(dataId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据AppId获取微应用在该组织下的agentId</p>
     * 
     * @param request GetAgentIdByRelatedAppIdRequest
     * @param headers GetAgentIdByRelatedAppIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAgentIdByRelatedAppIdResponse
     */
    public GetAgentIdByRelatedAppIdResponse getAgentIdByRelatedAppIdWithOptions(GetAgentIdByRelatedAppIdRequest request, GetAgentIdByRelatedAppIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            query.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            query.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "GetAgentIdByRelatedAppId"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/exclusiveDesigns/agentId"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAgentIdByRelatedAppIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据AppId获取微应用在该组织下的agentId</p>
     * 
     * @param request GetAgentIdByRelatedAppIdRequest
     * @return GetAgentIdByRelatedAppIdResponse
     */
    public GetAgentIdByRelatedAppIdResponse getAgentIdByRelatedAppId(GetAgentIdByRelatedAppIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAgentIdByRelatedAppIdHeaders headers = new GetAgentIdByRelatedAppIdHeaders();
        return this.getAgentIdByRelatedAppIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>伙伴钉可打标签部门查询</p>
     * 
     * @param headers GetAllLabelableDeptsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAllLabelableDeptsResponse
     */
    public GetAllLabelableDeptsResponse getAllLabelableDeptsWithOptions(GetAllLabelableDeptsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetAllLabelableDepts"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/partnerDepartments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAllLabelableDeptsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>伙伴钉可打标签部门查询</p>
     * @return GetAllLabelableDeptsResponse
     */
    public GetAllLabelableDeptsResponse getAllLabelableDepts() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAllLabelableDeptsHeaders headers = new GetAllLabelableDeptsHeaders();
        return this.getAllLabelableDeptsWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获得app分发信息</p>
     * 
     * @param request GetAppDispatchInfoRequest
     * @param headers GetAppDispatchInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAppDispatchInfoResponse
     */
    public GetAppDispatchInfoResponse getAppDispatchInfoWithOptions(GetAppDispatchInfoRequest request, GetAppDispatchInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
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
            new TeaPair("action", "GetAppDispatchInfo"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/apps/distributionInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAppDispatchInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获得app分发信息</p>
     * 
     * @param request GetAppDispatchInfoRequest
     * @return GetAppDispatchInfoResponse
     */
    public GetAppDispatchInfoResponse getAppDispatchInfo(GetAppDispatchInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAppDispatchInfoHeaders headers = new GetAppDispatchInfoHeaders();
        return this.getAppDispatchInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获得组织维度日程相关信息</p>
     * 
     * @param headers GetCalenderSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCalenderSummaryResponse
     */
    public GetCalenderSummaryResponse getCalenderSummaryWithOptions(String dataId, GetCalenderSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetCalenderSummary"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/calendar/org/" + dataId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCalenderSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获得组织维度日程相关信息</p>
     * @return GetCalenderSummaryResponse
     */
    public GetCalenderSummaryResponse getCalenderSummary(String dataId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCalenderSummaryHeaders headers = new GetCalenderSummaryHeaders();
        return this.getCalenderSummaryWithOptions(dataId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据机器人code获取群openConversationId列表</p>
     * 
     * @param request GetCidsByBotCodeRequest
     * @param headers GetCidsByBotCodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCidsByBotCodeResponse
     */
    public GetCidsByBotCodeResponse getCidsByBotCodeWithOptions(GetCidsByBotCodeRequest request, GetCidsByBotCodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            query.put("robotCode", request.robotCode);
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
            new TeaPair("action", "GetCidsByBotCode"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/groups/openConversationIds"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCidsByBotCodeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据机器人code获取群openConversationId列表</p>
     * 
     * @param request GetCidsByBotCodeRequest
     * @return GetCidsByBotCodeResponse
     */
    public GetCidsByBotCodeResponse getCidsByBotCode(GetCidsByBotCodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCidsByBotCodeHeaders headers = new GetCidsByBotCodeHeaders();
        return this.getCidsByBotCodeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取发布号的评论列表</p>
     * 
     * @param request GetCommentListRequest
     * @param headers GetCommentListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCommentListResponse
     */
    public GetCommentListResponse getCommentListWithOptions(String publisherId, GetCommentListRequest request, GetCommentListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "GetCommentList"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/publishers/" + publisherId + "/comments/list"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCommentListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取发布号的评论列表</p>
     * 
     * @param request GetCommentListRequest
     * @return GetCommentListResponse
     */
    public GetCommentListResponse getCommentList(String publisherId, GetCommentListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCommentListHeaders headers = new GetCommentListHeaders();
        return this.getCommentListWithOptions(publisherId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据逻辑会议id获取会议基本信息</p>
     * 
     * @param request GetConfBaseInfoByLogicalIdRequest
     * @param headers GetConfBaseInfoByLogicalIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetConfBaseInfoByLogicalIdResponse
     */
    public GetConfBaseInfoByLogicalIdResponse getConfBaseInfoByLogicalIdWithOptions(GetConfBaseInfoByLogicalIdRequest request, GetConfBaseInfoByLogicalIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.logicalConferenceId)) {
            query.put("logicalConferenceId", request.logicalConferenceId);
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
            new TeaPair("action", "GetConfBaseInfoByLogicalId"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/conferences"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetConfBaseInfoByLogicalIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据逻辑会议id获取会议基本信息</p>
     * 
     * @param request GetConfBaseInfoByLogicalIdRequest
     * @return GetConfBaseInfoByLogicalIdResponse
     */
    public GetConfBaseInfoByLogicalIdResponse getConfBaseInfoByLogicalId(GetConfBaseInfoByLogicalIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetConfBaseInfoByLogicalIdHeaders headers = new GetConfBaseInfoByLogicalIdHeaders();
        return this.getConfBaseInfoByLogicalIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取视频会议明细</p>
     * 
     * @param headers GetConferenceDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetConferenceDetailResponse
     */
    public GetConferenceDetailResponse getConferenceDetailWithOptions(String conferenceId, GetConferenceDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetConferenceDetail"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/conferences/" + conferenceId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetConferenceDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取视频会议明细</p>
     * @return GetConferenceDetailResponse
     */
    public GetConferenceDetailResponse getConferenceDetail(String conferenceId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetConferenceDetailHeaders headers = new GetConferenceDetailHeaders();
        return this.getConferenceDetailWithOptions(conferenceId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取会话分组数据</p>
     * 
     * @param headers GetConversationCategoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetConversationCategoryResponse
     */
    public GetConversationCategoryResponse getConversationCategoryWithOptions(GetConversationCategoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetConversationCategory"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/conversationCategories"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetConversationCategoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取会话分组数据</p>
     * @return GetConversationCategoryResponse
     */
    public GetConversationCategoryResponse getConversationCategory() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetConversationCategoryHeaders headers = new GetConversationCategoryHeaders();
        return this.getConversationCategoryWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取会话分组详情</p>
     * 
     * @param request GetConversationDetailRequest
     * @param headers GetConversationDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetConversationDetailResponse
     */
    public GetConversationDetailResponse getConversationDetailWithOptions(GetConversationDetailRequest request, GetConversationDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetConversationDetail"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/categories/conversations/details/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetConversationDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取会话分组详情</p>
     * 
     * @param request GetConversationDetailRequest
     * @return GetConversationDetailResponse
     */
    public GetConversationDetailResponse getConversationDetail(GetConversationDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetConversationDetailHeaders headers = new GetConversationDetailHeaders();
        return this.getConversationDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取部门维度发布日志信息</p>
     * 
     * @param request GetDingReportDeptSummaryRequest
     * @param headers GetDingReportDeptSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDingReportDeptSummaryResponse
     */
    public GetDingReportDeptSummaryResponse getDingReportDeptSummaryWithOptions(String dataId, GetDingReportDeptSummaryRequest request, GetDingReportDeptSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetDingReportDeptSummary"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/report/dept/" + dataId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDingReportDeptSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取部门维度发布日志信息</p>
     * 
     * @param request GetDingReportDeptSummaryRequest
     * @return GetDingReportDeptSummaryResponse
     */
    public GetDingReportDeptSummaryResponse getDingReportDeptSummary(String dataId, GetDingReportDeptSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDingReportDeptSummaryHeaders headers = new GetDingReportDeptSummaryHeaders();
        return this.getDingReportDeptSummaryWithOptions(dataId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织维度发布日志信息</p>
     * 
     * @param headers GetDingReportSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDingReportSummaryResponse
     */
    public GetDingReportSummaryResponse getDingReportSummaryWithOptions(String dataId, GetDingReportSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetDingReportSummary"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/datas/" + dataId + "/reports/organizations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDingReportSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织维度发布日志信息</p>
     * @return GetDingReportSummaryResponse
     */
    public GetDingReportSummaryResponse getDingReportSummary(String dataId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDingReportSummaryHeaders headers = new GetDingReportSummaryHeaders();
        return this.getDingReportSummaryWithOptions(dataId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获得部门维度用户创建文档数和创建文档人数</p>
     * 
     * @param request GetDocCreatedDeptSummaryRequest
     * @param headers GetDocCreatedDeptSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDocCreatedDeptSummaryResponse
     */
    public GetDocCreatedDeptSummaryResponse getDocCreatedDeptSummaryWithOptions(String dataId, GetDocCreatedDeptSummaryRequest request, GetDocCreatedDeptSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetDocCreatedDeptSummary"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/doc/dept/" + dataId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDocCreatedDeptSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获得部门维度用户创建文档数和创建文档人数</p>
     * 
     * @param request GetDocCreatedDeptSummaryRequest
     * @return GetDocCreatedDeptSummaryResponse
     */
    public GetDocCreatedDeptSummaryResponse getDocCreatedDeptSummary(String dataId, GetDocCreatedDeptSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDocCreatedDeptSummaryHeaders headers = new GetDocCreatedDeptSummaryHeaders();
        return this.getDocCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织维度用户创建文档数和创建文档人数</p>
     * 
     * @param headers GetDocCreatedSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDocCreatedSummaryResponse
     */
    public GetDocCreatedSummaryResponse getDocCreatedSummaryWithOptions(String dataId, GetDocCreatedSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetDocCreatedSummary"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/doc/org/" + dataId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDocCreatedSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织维度用户创建文档数和创建文档人数</p>
     * @return GetDocCreatedSummaryResponse
     */
    public GetDocCreatedSummaryResponse getDocCreatedSummary(String dataId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDocCreatedSummaryHeaders headers = new GetDocCreatedSummaryHeaders();
        return this.getDocCreatedSummaryWithOptions(dataId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取专属账号所有组织列表</p>
     * 
     * @param request GetExclusiveAccountAllOrgListRequest
     * @param headers GetExclusiveAccountAllOrgListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetExclusiveAccountAllOrgListResponse
     */
    public GetExclusiveAccountAllOrgListResponse getExclusiveAccountAllOrgListWithOptions(GetExclusiveAccountAllOrgListRequest request, GetExclusiveAccountAllOrgListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetExclusiveAccountAllOrgList"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/exclusiveAccounts/organizations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetExclusiveAccountAllOrgListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取专属账号所有组织列表</p>
     * 
     * @param request GetExclusiveAccountAllOrgListRequest
     * @return GetExclusiveAccountAllOrgListResponse
     */
    public GetExclusiveAccountAllOrgListResponse getExclusiveAccountAllOrgList(GetExclusiveAccountAllOrgListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetExclusiveAccountAllOrgListHeaders headers = new GetExclusiveAccountAllOrgListHeaders();
        return this.getExclusiveAccountAllOrgListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取部门维度发布智能填表数量和使用智能填表人数</p>
     * 
     * @param request GetGeneralFormCreatedDeptSummaryRequest
     * @param headers GetGeneralFormCreatedDeptSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetGeneralFormCreatedDeptSummaryResponse
     */
    public GetGeneralFormCreatedDeptSummaryResponse getGeneralFormCreatedDeptSummaryWithOptions(String dataId, GetGeneralFormCreatedDeptSummaryRequest request, GetGeneralFormCreatedDeptSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetGeneralFormCreatedDeptSummary"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/generalForm/dept/" + dataId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetGeneralFormCreatedDeptSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取部门维度发布智能填表数量和使用智能填表人数</p>
     * 
     * @param request GetGeneralFormCreatedDeptSummaryRequest
     * @return GetGeneralFormCreatedDeptSummaryResponse
     */
    public GetGeneralFormCreatedDeptSummaryResponse getGeneralFormCreatedDeptSummary(String dataId, GetGeneralFormCreatedDeptSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetGeneralFormCreatedDeptSummaryHeaders headers = new GetGeneralFormCreatedDeptSummaryHeaders();
        return this.getGeneralFormCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织维度发布智能填表数量和使用智能填表人数</p>
     * 
     * @param headers GetGeneralFormCreatedSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetGeneralFormCreatedSummaryResponse
     */
    public GetGeneralFormCreatedSummaryResponse getGeneralFormCreatedSummaryWithOptions(String dataId, GetGeneralFormCreatedSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetGeneralFormCreatedSummary"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/generalForm/org/" + dataId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetGeneralFormCreatedSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织维度发布智能填表数量和使用智能填表人数</p>
     * @return GetGeneralFormCreatedSummaryResponse
     */
    public GetGeneralFormCreatedSummaryResponse getGeneralFormCreatedSummary(String dataId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetGeneralFormCreatedSummaryHeaders headers = new GetGeneralFormCreatedSummaryHeaders();
        return this.getGeneralFormCreatedSummaryWithOptions(dataId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取群活跃明细</p>
     * 
     * @param request GetGroupActiveInfoRequest
     * @param headers GetGroupActiveInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetGroupActiveInfoResponse
     */
    public GetGroupActiveInfoResponse getGroupActiveInfoWithOptions(GetGroupActiveInfoRequest request, GetGroupActiveInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingGroupId)) {
            query.put("dingGroupId", request.dingGroupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupType)) {
            query.put("groupType", request.groupType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.statDate)) {
            query.put("statDate", request.statDate);
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
            new TeaPair("action", "GetGroupActiveInfo"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/activeGroups"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetGroupActiveInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取群活跃明细</p>
     * 
     * @param request GetGroupActiveInfoRequest
     * @return GetGroupActiveInfoResponse
     */
    public GetGroupActiveInfoResponse getGroupActiveInfo(GetGroupActiveInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetGroupActiveInfoHeaders headers = new GetGroupActiveInfoHeaders();
        return this.getGroupActiveInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据群会话id获取群相关信息</p>
     * 
     * @param request GetGroupInfoByCidRequest
     * @param headers GetGroupInfoByCidHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetGroupInfoByCidResponse
     */
    public GetGroupInfoByCidResponse getGroupInfoByCidWithOptions(GetGroupInfoByCidRequest request, GetGroupInfoByCidHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            query.put("openConversationId", request.openConversationId);
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
            new TeaPair("action", "GetGroupInfoByCid"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/groups/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetGroupInfoByCidResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据群会话id获取群相关信息</p>
     * 
     * @param request GetGroupInfoByCidRequest
     * @return GetGroupInfoByCidResponse
     */
    public GetGroupInfoByCidResponse getGroupInfoByCid(GetGroupInfoByCidRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetGroupInfoByCidHeaders headers = new GetGroupInfoByCidHeaders();
        return this.getGroupInfoByCidWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据群会话id获取组织id</p>
     * 
     * @param request GetGroupOrgByCidRequest
     * @param headers GetGroupOrgByCidHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetGroupOrgByCidResponse
     */
    public GetGroupOrgByCidResponse getGroupOrgByCidWithOptions(GetGroupOrgByCidRequest request, GetGroupOrgByCidHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            query.put("openConversationId", request.openConversationId);
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
            new TeaPair("action", "GetGroupOrgByCid"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/groups/organizations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetGroupOrgByCidResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据群会话id获取组织id</p>
     * 
     * @param request GetGroupOrgByCidRequest
     * @return GetGroupOrgByCidResponse
     */
    public GetGroupOrgByCidResponse getGroupOrgByCid(GetGroupOrgByCidRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetGroupOrgByCidHeaders headers = new GetGroupOrgByCidHeaders();
        return this.getGroupOrgByCidWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取未活跃用户登陆统计明细</p>
     * 
     * @param request GetInActiveUserListRequest
     * @param headers GetInActiveUserListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetInActiveUserListResponse
     */
    public GetInActiveUserListResponse getInActiveUserListWithOptions(GetInActiveUserListRequest request, GetInActiveUserListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIds)) {
            body.put("deptIds", request.deptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.statDate)) {
            body.put("statDate", request.statDate);
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
            new TeaPair("action", "GetInActiveUserList"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/inactives/users/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetInActiveUserListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取未活跃用户登陆统计明细</p>
     * 
     * @param request GetInActiveUserListRequest
     * @return GetInActiveUserListResponse
     */
    public GetInActiveUserListResponse getInActiveUserList(GetInActiveUserListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInActiveUserListHeaders headers = new GetInActiveUserListHeaders();
        return this.getInActiveUserListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取最后一次验证通过的企业认证信息</p>
     * 
     * @param request GetLastOrgAuthDataRequest
     * @param headers GetLastOrgAuthDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetLastOrgAuthDataResponse
     */
    public GetLastOrgAuthDataResponse getLastOrgAuthDataWithOptions(GetLastOrgAuthDataRequest request, GetLastOrgAuthDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            query.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "GetLastOrgAuthData"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/organizations/authInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetLastOrgAuthDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取最后一次验证通过的企业认证信息</p>
     * 
     * @param request GetLastOrgAuthDataRequest
     * @return GetLastOrgAuthDataResponse
     */
    public GetLastOrgAuthDataResponse getLastOrgAuthData(GetLastOrgAuthDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetLastOrgAuthDataHeaders headers = new GetLastOrgAuthDataHeaders();
        return this.getLastOrgAuthDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>消息规则配置和群属性接口</p>
     * 
     * @param request GetMsgConfigRequest
     * @param headers GetMsgConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMsgConfigResponse
     */
    public GetMsgConfigResponse getMsgConfigWithOptions(GetMsgConfigRequest request, GetMsgConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupTopic)) {
            body.put("groupTopic", request.groupTopic);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupType)) {
            body.put("groupType", request.groupType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.listDynamicAttr)) {
            body.put("listDynamicAttr", request.listDynamicAttr);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.listEmployeeCode)) {
            body.put("listEmployeeCode", request.listEmployeeCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.listUnitId)) {
            body.put("listUnitId", request.listUnitId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownerJobNo)) {
            body.put("ownerJobNo", request.ownerJobNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ruleBusinessCode)) {
            body.put("ruleBusinessCode", request.ruleBusinessCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ruleCategory)) {
            body.put("ruleCategory", request.ruleCategory);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ruleCode)) {
            body.put("ruleCode", request.ruleCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretKey)) {
            body.put("secretKey", request.secretKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sysCode)) {
            body.put("sysCode", request.sysCode);
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
            new TeaPair("action", "GetMsgConfig"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/portals/msgConfigs/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMsgConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>消息规则配置和群属性接口</p>
     * 
     * @param request GetMsgConfigRequest
     * @return GetMsgConfigResponse
     */
    public GetMsgConfigResponse getMsgConfig(GetMsgConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMsgConfigHeaders headers = new GetMsgConfigHeaders();
        return this.getMsgConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取消息定位链接</p>
     * 
     * @param request GetMsgLocationRequest
     * @param headers GetMsgLocationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMsgLocationResponse
     */
    public GetMsgLocationResponse getMsgLocationWithOptions(GetMsgLocationRequest request, GetMsgLocationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openMsgId)) {
            body.put("openMsgId", request.openMsgId);
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
            new TeaPair("action", "GetMsgLocation"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/messageLocations/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMsgLocationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取消息定位链接</p>
     * 
     * @param request GetMsgLocationRequest
     * @return GetMsgLocationResponse
     */
    public GetMsgLocationResponse getMsgLocation(GetMsgLocationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMsgLocationHeaders headers = new GetMsgLocationHeaders();
        return this.getMsgLocationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取oa后台操作日志记录</p>
     * 
     * @param request GetOaOperatorLogListRequest
     * @param headers GetOaOperatorLogListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOaOperatorLogListResponse
     */
    public GetOaOperatorLogListResponse getOaOperatorLogListWithOptions(GetOaOperatorLogListRequest request, GetOaOperatorLogListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.categoryList)) {
            body.put("categoryList", request.categoryList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
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
            new TeaPair("action", "GetOaOperatorLogList"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/oaOperatorLogs/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOaOperatorLogListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取oa后台操作日志记录</p>
     * 
     * @param request GetOaOperatorLogListRequest
     * @return GetOaOperatorLogListResponse
     */
    public GetOaOperatorLogListResponse getOaOperatorLogList(GetOaOperatorLogListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOaOperatorLogListHeaders headers = new GetOaOperatorLogListHeaders();
        return this.getOaOperatorLogListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业的外部审计群列表</p>
     * 
     * @param request GetOutGroupsByPageRequest
     * @param headers GetOutGroupsByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOutGroupsByPageResponse
     */
    public GetOutGroupsByPageResponse getOutGroupsByPageWithOptions(GetOutGroupsByPageRequest request, GetOutGroupsByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "GetOutGroupsByPage"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/audits/outsideGroups/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOutGroupsByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业的外部审计群列表</p>
     * 
     * @param request GetOutGroupsByPageRequest
     * @return GetOutGroupsByPageResponse
     */
    public GetOutGroupsByPageResponse getOutGroupsByPage(GetOutGroupsByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOutGroupsByPageHeaders headers = new GetOutGroupsByPageHeaders();
        return this.getOutGroupsByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取外部审计群消息记录</p>
     * 
     * @param request GetOutsideAuditGroupMessageByPageRequest
     * @param headers GetOutsideAuditGroupMessageByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOutsideAuditGroupMessageByPageResponse
     */
    public GetOutsideAuditGroupMessageByPageResponse getOutsideAuditGroupMessageByPageWithOptions(GetOutsideAuditGroupMessageByPageRequest request, GetOutsideAuditGroupMessageByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

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
            new TeaPair("action", "GetOutsideAuditGroupMessageByPage"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/audits/outsideGroups/messages/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOutsideAuditGroupMessageByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取外部审计群消息记录</p>
     * 
     * @param request GetOutsideAuditGroupMessageByPageRequest
     * @return GetOutsideAuditGroupMessageByPageResponse
     */
    public GetOutsideAuditGroupMessageByPageResponse getOutsideAuditGroupMessageByPage(GetOutsideAuditGroupMessageByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOutsideAuditGroupMessageByPageHeaders headers = new GetOutsideAuditGroupMessageByPageHeaders();
        return this.getOutsideAuditGroupMessageByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>伙伴钉根据父标签查询子标签</p>
     * 
     * @param headers GetPartnerTypeByParentIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPartnerTypeByParentIdResponse
     */
    public GetPartnerTypeByParentIdResponse getPartnerTypeByParentIdWithOptions(String parentId, GetPartnerTypeByParentIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetPartnerTypeByParentId"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/partnerLabels/" + parentId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPartnerTypeByParentIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>伙伴钉根据父标签查询子标签</p>
     * @return GetPartnerTypeByParentIdResponse
     */
    public GetPartnerTypeByParentIdResponse getPartnerTypeByParentId(String parentId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPartnerTypeByParentIdHeaders headers = new GetPartnerTypeByParentIdHeaders();
        return this.getPartnerTypeByParentIdWithOptions(parentId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取公共设备列表。</p>
     * 
     * @param request GetPublicDevicesRequest
     * @param headers GetPublicDevicesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPublicDevicesResponse
     */
    public GetPublicDevicesResponse getPublicDevicesWithOptions(GetPublicDevicesRequest request, GetPublicDevicesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.macAddress)) {
            query.put("macAddress", request.macAddress);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platform)) {
            query.put("platform", request.platform);
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
            new TeaPair("action", "GetPublicDevices"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/trusts/publicDevices"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPublicDevicesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取公共设备列表。</p>
     * 
     * @param request GetPublicDevicesRequest
     * @return GetPublicDevicesResponse
     */
    public GetPublicDevicesResponse getPublicDevices(GetPublicDevicesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPublicDevicesHeaders headers = new GetPublicDevicesHeaders();
        return this.getPublicDevicesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取互动服务窗相关数据</p>
     * 
     * @param request GetPublisherSummaryRequest
     * @param headers GetPublisherSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPublisherSummaryResponse
     */
    public GetPublisherSummaryResponse getPublisherSummaryWithOptions(String dataId, GetPublisherSummaryRequest request, GetPublisherSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetPublisherSummary"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/publisher/" + dataId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPublisherSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取互动服务窗相关数据</p>
     * 
     * @param request GetPublisherSummaryRequest
     * @return GetPublisherSummaryResponse
     */
    public GetPublisherSummaryResponse getPublisherSummary(String dataId, GetPublisherSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPublisherSummaryHeaders headers = new GetPublisherSummaryHeaders();
        return this.getPublisherSummaryWithOptions(dataId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取实人认证接口调用记录</p>
     * 
     * @param request GetRealPeopleRecordsRequest
     * @param headers GetRealPeopleRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRealPeopleRecordsResponse
     */
    public GetRealPeopleRecordsResponse getRealPeopleRecordsWithOptions(GetRealPeopleRecordsRequest request, GetRealPeopleRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            body.put("agentId", request.agentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fromTime)) {
            body.put("fromTime", request.fromTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.personIdentification)) {
            body.put("personIdentification", request.personIdentification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            body.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toTime)) {
            body.put("toTime", request.toTime);
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
            new TeaPair("action", "GetRealPeopleRecords"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/persons/identificationRecords/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRealPeopleRecordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取实人认证接口调用记录</p>
     * 
     * @param request GetRealPeopleRecordsRequest
     * @return GetRealPeopleRecordsResponse
     */
    public GetRealPeopleRecordsResponse getRealPeopleRecords(GetRealPeopleRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRealPeopleRecordsHeaders headers = new GetRealPeopleRecordsHeaders();
        return this.getRealPeopleRecordsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取人脸对比接口调用记录</p>
     * 
     * @param request GetRecognizeRecordsRequest
     * @param headers GetRecognizeRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRecognizeRecordsResponse
     */
    public GetRecognizeRecordsResponse getRecognizeRecordsWithOptions(GetRecognizeRecordsRequest request, GetRecognizeRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            body.put("agentId", request.agentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.faceCompareResult)) {
            body.put("faceCompareResult", request.faceCompareResult);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fromTime)) {
            body.put("fromTime", request.fromTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toTime)) {
            body.put("toTime", request.toTime);
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
            new TeaPair("action", "GetRecognizeRecords"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/faces/recognizeRecords/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRecognizeRecordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取人脸对比接口调用记录</p>
     * 
     * @param request GetRecognizeRecordsRequest
     * @return GetRecognizeRecordsResponse
     */
    public GetRecognizeRecordsResponse getRecognizeRecords(GetRecognizeRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRecognizeRecordsHeaders headers = new GetRecognizeRecordsHeaders();
        return this.getRecognizeRecordsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据机器人标识查询机器人信息</p>
     * 
     * @param request GetRobotInfoByCodeRequest
     * @param headers GetRobotInfoByCodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRobotInfoByCodeResponse
     */
    public GetRobotInfoByCodeResponse getRobotInfoByCodeWithOptions(GetRobotInfoByCodeRequest request, GetRobotInfoByCodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            query.put("robotCode", request.robotCode);
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
            new TeaPair("action", "GetRobotInfoByCode"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/robots/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRobotInfoByCodeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据机器人标识查询机器人信息</p>
     * 
     * @param request GetRobotInfoByCodeRequest
     * @return GetRobotInfoByCodeResponse
     */
    public GetRobotInfoByCodeResponse getRobotInfoByCode(GetRobotInfoByCodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRobotInfoByCodeHeaders headers = new GetRobotInfoByCodeHeaders();
        return this.getRobotInfoByCodeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取安全管控卡片成员</p>
     * 
     * @param request GetSecurityConfigMemberRequest
     * @param headers GetSecurityConfigMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSecurityConfigMemberResponse
     */
    public GetSecurityConfigMemberResponse getSecurityConfigMemberWithOptions(GetSecurityConfigMemberRequest request, GetSecurityConfigMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.configKey)) {
            body.put("configKey", request.configKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
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
            new TeaPair("action", "GetSecurityConfigMember"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/securities/configs/members/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSecurityConfigMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取安全管控卡片成员</p>
     * 
     * @param request GetSecurityConfigMemberRequest
     * @return GetSecurityConfigMemberResponse
     */
    public GetSecurityConfigMemberResponse getSecurityConfigMember(GetSecurityConfigMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSecurityConfigMemberHeaders headers = new GetSecurityConfigMemberHeaders();
        return this.getSecurityConfigMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取审计协议签署人员信息</p>
     * 
     * @param request GetSignedDetailByPageRequest
     * @param headers GetSignedDetailByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSignedDetailByPageResponse
     */
    public GetSignedDetailByPageResponse getSignedDetailByPageWithOptions(GetSignedDetailByPageRequest request, GetSignedDetailByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signStatus)) {
            query.put("signStatus", request.signStatus);
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
            new TeaPair("action", "GetSignedDetailByPage"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/audits/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSignedDetailByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取审计协议签署人员信息</p>
     * 
     * @param request GetSignedDetailByPageRequest
     * @return GetSignedDetailByPageResponse
     */
    public GetSignedDetailByPageResponse getSignedDetailByPage(GetSignedDetailByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSignedDetailByPageHeaders headers = new GetSignedDetailByPageHeaders();
        return this.getSignedDetailByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取多个可信设备信息，包括mac地址、staffId、platform</p>
     * 
     * @param request GetTrustDeviceListRequest
     * @param headers GetTrustDeviceListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTrustDeviceListResponse
     */
    public GetTrustDeviceListResponse getTrustDeviceListWithOptions(GetTrustDeviceListRequest request, GetTrustDeviceListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.gmtCreateEnd)) {
            body.put("gmtCreateEnd", request.gmtCreateEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtCreateStart)) {
            body.put("gmtCreateStart", request.gmtCreateStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtModifiedEnd)) {
            body.put("gmtModifiedEnd", request.gmtModifiedEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtModifiedStart)) {
            body.put("gmtModifiedStart", request.gmtModifiedStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.macAddress)) {
            body.put("macAddress", request.macAddress);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platform)) {
            body.put("platform", request.platform);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
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
            new TeaPair("action", "GetTrustDeviceList"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/trustedDevices/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTrustDeviceListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取多个可信设备信息，包括mac地址、staffId、platform</p>
     * 
     * @param request GetTrustDeviceListRequest
     * @return GetTrustDeviceListResponse
     */
    public GetTrustDeviceListResponse getTrustDeviceList(GetTrustDeviceListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTrustDeviceListHeaders headers = new GetTrustDeviceListHeaders();
        return this.getTrustDeviceListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获得组织维度用户版本分布情况</p>
     * 
     * @param request GetUserAppVersionSummaryRequest
     * @param headers GetUserAppVersionSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserAppVersionSummaryResponse
     */
    public GetUserAppVersionSummaryResponse getUserAppVersionSummaryWithOptions(String dataId, GetUserAppVersionSummaryRequest request, GetUserAppVersionSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetUserAppVersionSummary"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/appVersion/org/" + dataId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserAppVersionSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获得组织维度用户版本分布情况</p>
     * 
     * @param request GetUserAppVersionSummaryRequest
     * @return GetUserAppVersionSummaryResponse
     */
    public GetUserAppVersionSummaryResponse getUserAppVersionSummary(String dataId, GetUserAppVersionSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserAppVersionSummaryHeaders headers = new GetUserAppVersionSummaryHeaders();
        return this.getUserAppVersionSummaryWithOptions(dataId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人脸录入状态查询</p>
     * 
     * @param request GetUserFaceStateRequest
     * @param headers GetUserFaceStateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserFaceStateResponse
     */
    public GetUserFaceStateResponse getUserFaceStateWithOptions(GetUserFaceStateRequest request, GetUserFaceStateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetUserFaceState"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/faces/recognizeStates/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserFaceStateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人脸录入状态查询</p>
     * 
     * @param request GetUserFaceStateRequest
     * @return GetUserFaceStateResponse
     */
    public GetUserFaceStateResponse getUserFaceState(GetUserFaceStateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserFaceStateHeaders headers = new GetUserFaceStateHeaders();
        return this.getUserFaceStateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>实人认证状态查询</p>
     * 
     * @param request GetUserRealPeopleStateRequest
     * @param headers GetUserRealPeopleStateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserRealPeopleStateResponse
     */
    public GetUserRealPeopleStateResponse getUserRealPeopleStateWithOptions(GetUserRealPeopleStateRequest request, GetUserRealPeopleStateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetUserRealPeopleState"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/persons/identificationStates/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserRealPeopleStateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>实人认证状态查询</p>
     * 
     * @param request GetUserRealPeopleStateRequest
     * @return GetUserRealPeopleStateResponse
     */
    public GetUserRealPeopleStateResponse getUserRealPeopleState(GetUserRealPeopleStateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserRealPeopleStateHeaders headers = new GetUserRealPeopleStateHeaders();
        return this.getUserRealPeopleStateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户停留时长</p>
     * 
     * @param request GetUserStayLengthRequest
     * @param headers GetUserStayLengthHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserStayLengthResponse
     */
    public GetUserStayLengthResponse getUserStayLengthWithOptions(GetUserStayLengthRequest request, GetUserStayLengthHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.statDate)) {
            query.put("statDate", request.statDate);
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
            new TeaPair("action", "GetUserStayLength"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/data/users/stayTimes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserStayLengthResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户停留时长</p>
     * 
     * @param request GetUserStayLengthRequest
     * @return GetUserStayLengthResponse
     */
    public GetUserStayLengthResponse getUserStayLength(GetUserStayLengthRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserStayLengthHeaders headers = new GetUserStayLengthHeaders();
        return this.getUserStayLengthWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件病毒扫描结果</p>
     * 
     * @param request GetVirusScanResultRequest
     * @param headers GetVirusScanResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetVirusScanResultResponse
     */
    public GetVirusScanResultResponse getVirusScanResultWithOptions(GetVirusScanResultRequest request, GetVirusScanResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
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
            new TeaPair("action", "GetVirusScanResult"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/virusScanTasks/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetVirusScanResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件病毒扫描结果</p>
     * 
     * @param request GetVirusScanResultRequest
     * @return GetVirusScanResultResponse
     */
    public GetVirusScanResultResponse getVirusScanResult(GetVirusScanResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetVirusScanResultHeaders headers = new GetVirusScanResultHeaders();
        return this.getVirusScanResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据群属性查询群ID</p>
     * 
     * @param request GroupQueryByAttrRequest
     * @param headers GroupQueryByAttrHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GroupQueryByAttrResponse
     */
    public GroupQueryByAttrResponse groupQueryByAttrWithOptions(GroupQueryByAttrRequest request, GroupQueryByAttrHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupTopic)) {
            body.put("groupTopic", request.groupTopic);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupType)) {
            body.put("groupType", request.groupType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.listDynamicAttr)) {
            body.put("listDynamicAttr", request.listDynamicAttr);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageIndex)) {
            body.put("pageIndex", request.pageIndex);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretKey)) {
            body.put("secretKey", request.secretKey);
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
            new TeaPair("action", "GroupQueryByAttr"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/portals/groups/queryGroup"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GroupQueryByAttrResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据群属性查询群ID</p>
     * 
     * @param request GroupQueryByAttrRequest
     * @return GroupQueryByAttrResponse
     */
    public GroupQueryByAttrResponse groupQueryByAttr(GroupQueryByAttrRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GroupQueryByAttrHeaders headers = new GroupQueryByAttrHeaders();
        return this.groupQueryByAttrWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据群ID查询群属性</p>
     * 
     * @param request GroupQueryByOpenIdRequest
     * @param headers GroupQueryByOpenIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GroupQueryByOpenIdResponse
     */
    public GroupQueryByOpenIdResponse groupQueryByOpenIdWithOptions(GroupQueryByOpenIdRequest request, GroupQueryByOpenIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretKey)) {
            body.put("secretKey", request.secretKey);
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
            new TeaPair("action", "GroupQueryByOpenId"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/portals/groups/getGroupByOpenConversationId"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GroupQueryByOpenIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据群ID查询群属性</p>
     * 
     * @param request GroupQueryByOpenIdRequest
     * @return GroupQueryByOpenIdResponse
     */
    public GroupQueryByOpenIdResponse groupQueryByOpenId(GroupQueryByOpenIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GroupQueryByOpenIdHeaders headers = new GroupQueryByOpenIdHeaders();
        return this.groupQueryByOpenIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业文件审计日志</p>
     * 
     * @param request ListAuditLogRequest
     * @param headers ListAuditLogHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAuditLogResponse
     */
    public ListAuditLogResponse listAuditLogWithOptions(ListAuditLogRequest request, ListAuditLogHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endDate)) {
            query.put("endDate", request.endDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextBizId)) {
            query.put("nextBizId", request.nextBizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextGmtCreate)) {
            query.put("nextGmtCreate", request.nextGmtCreate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startDate)) {
            query.put("startDate", request.startDate);
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
            new TeaPair("action", "ListAuditLog"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/fileAuditLogs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAuditLogResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业文件审计日志</p>
     * 
     * @param request ListAuditLogRequest
     * @return ListAuditLogResponse
     */
    public ListAuditLogResponse listAuditLog(ListAuditLogRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAuditLogHeaders headers = new ListAuditLogHeaders();
        return this.listAuditLogWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据机器人code列表查询机器人信息</p>
     * 
     * @param request ListByCodesRequest
     * @param headers ListByCodesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListByCodesResponse
     */
    public ListByCodesResponse listByCodesWithOptions(ListByCodesRequest request, ListByCodesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", request.body)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListByCodes"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/sceneGroups/robotInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListByCodesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据机器人code列表查询机器人信息</p>
     * 
     * @param request ListByCodesRequest
     * @return ListByCodesResponse
     */
    public ListByCodesResponse listByCodes(ListByCodesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListByCodesHeaders headers = new ListByCodesHeaders();
        return this.listByCodesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据插件id列表查询插件信息</p>
     * 
     * @param request ListByPluginIdsRequest
     * @param headers ListByPluginIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListByPluginIdsResponse
     */
    public ListByPluginIdsResponse listByPluginIdsWithOptions(ListByPluginIdsRequest request, ListByPluginIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", request.body)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListByPluginIds"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/sceneGroups/pluginInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListByPluginIdsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据插件id列表查询插件信息</p>
     * 
     * @param request ListByPluginIdsRequest
     * @return ListByPluginIdsResponse
     */
    public ListByPluginIdsResponse listByPluginIds(ListByPluginIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListByPluginIdsHeaders headers = new ListByPluginIdsHeaders();
        return this.listByPluginIdsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询分组列表</p>
     * 
     * @param tmpReq ListCategorysRequest
     * @param headers ListCategorysHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListCategorysResponse
     */
    public ListCategorysResponse listCategorysWithOptions(ListCategorysRequest tmpReq, ListCategorysHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        ListCategorysShrinkRequest request = new ListCategorysShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.body)) {
            request.bodyShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bodyShrink)) {
            query.put("body", request.bodyShrink);
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
            new TeaPair("action", "ListCategorys"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/messageCategories/categories/listCategories"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListCategorysResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询分组列表</p>
     * 
     * @param request ListCategorysRequest
     * @return ListCategorysResponse
     */
    public ListCategorysResponse listCategorys(ListCategorysRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListCategorysHeaders headers = new ListCategorysHeaders();
        return this.listCategorysWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通过手机号获取已加入的属于渠道组织的列表信息</p>
     * 
     * @param request ListJoinOrgInfoRequest
     * @param headers ListJoinOrgInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListJoinOrgInfoResponse
     */
    public ListJoinOrgInfoResponse listJoinOrgInfoWithOptions(ListJoinOrgInfoRequest request, ListJoinOrgInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
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
            new TeaPair("action", "ListJoinOrgInfo"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/exclusiveAccounts/organizations/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListJoinOrgInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通过手机号获取已加入的属于渠道组织的列表信息</p>
     * 
     * @param request ListJoinOrgInfoRequest
     * @return ListJoinOrgInfoResponse
     */
    public ListJoinOrgInfoResponse listJoinOrgInfo(ListJoinOrgInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListJoinOrgInfoHeaders headers = new ListJoinOrgInfoHeaders();
        return this.listJoinOrgInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取小程序版本列表</p>
     * 
     * @param request ListMiniAppAvailableVersionRequest
     * @param headers ListMiniAppAvailableVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListMiniAppAvailableVersionResponse
     */
    public ListMiniAppAvailableVersionResponse listMiniAppAvailableVersionWithOptions(ListMiniAppAvailableVersionRequest request, ListMiniAppAvailableVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.versionTypeSet)) {
            body.put("versionTypeSet", request.versionTypeSet);
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
            new TeaPair("action", "ListMiniAppAvailableVersion"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/miniApps/versions/availableLists"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListMiniAppAvailableVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取小程序版本列表</p>
     * 
     * @param request ListMiniAppAvailableVersionRequest
     * @return ListMiniAppAvailableVersionResponse
     */
    public ListMiniAppAvailableVersionResponse listMiniAppAvailableVersion(ListMiniAppAvailableVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListMiniAppAvailableVersionHeaders headers = new ListMiniAppAvailableVersionHeaders();
        return this.listMiniAppAvailableVersionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取小程序历史版本列表</p>
     * 
     * @param request ListMiniAppHistoryVersionRequest
     * @param headers ListMiniAppHistoryVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListMiniAppHistoryVersionResponse
     */
    public ListMiniAppHistoryVersionResponse listMiniAppHistoryVersionWithOptions(ListMiniAppHistoryVersionRequest request, ListMiniAppHistoryVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            query.put("miniAppId", request.miniAppId);
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
            new TeaPair("action", "ListMiniAppHistoryVersion"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/miniApps/versions/historyLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListMiniAppHistoryVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取小程序历史版本列表</p>
     * 
     * @param request ListMiniAppHistoryVersionRequest
     * @return ListMiniAppHistoryVersionResponse
     */
    public ListMiniAppHistoryVersionResponse listMiniAppHistoryVersion(ListMiniAppHistoryVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListMiniAppHistoryVersionHeaders headers = new ListMiniAppHistoryVersionHeaders();
        return this.listMiniAppHistoryVersionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询伙伴角色</p>
     * 
     * @param headers ListPartnerRolesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListPartnerRolesResponse
     */
    public ListPartnerRolesResponse listPartnerRolesWithOptions(String parentId, ListPartnerRolesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListPartnerRoles"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/partners/roles/" + parentId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListPartnerRolesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询伙伴角色</p>
     * @return ListPartnerRolesResponse
     */
    public ListPartnerRolesResponse listPartnerRoles(String parentId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListPartnerRolesHeaders headers = new ListPartnerRolesHeaders();
        return this.listPartnerRolesWithOptions(parentId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取巡点信息列表</p>
     * 
     * @param request ListPunchScheduleByConditionWithPagingRequest
     * @param headers ListPunchScheduleByConditionWithPagingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListPunchScheduleByConditionWithPagingResponse
     */
    public ListPunchScheduleByConditionWithPagingResponse listPunchScheduleByConditionWithPagingWithOptions(ListPunchScheduleByConditionWithPagingRequest request, ListPunchScheduleByConditionWithPagingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizInstanceId)) {
            body.put("bizInstanceId", request.bizInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduleDateEnd)) {
            body.put("scheduleDateEnd", request.scheduleDateEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduleDateStart)) {
            body.put("scheduleDateStart", request.scheduleDateStart);
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
            new TeaPair("action", "ListPunchScheduleByConditionWithPaging"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/punchSchedules/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListPunchScheduleByConditionWithPagingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取巡点信息列表</p>
     * 
     * @param request ListPunchScheduleByConditionWithPagingRequest
     * @return ListPunchScheduleByConditionWithPagingResponse
     */
    public ListPunchScheduleByConditionWithPagingResponse listPunchScheduleByConditionWithPaging(ListPunchScheduleByConditionWithPagingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListPunchScheduleByConditionWithPagingHeaders headers = new ListPunchScheduleByConditionWithPagingHeaders();
        return this.listPunchScheduleByConditionWithPagingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询规则列表</p>
     * 
     * @param tmpReq ListRulesRequest
     * @param headers ListRulesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListRulesResponse
     */
    public ListRulesResponse listRulesWithOptions(ListRulesRequest tmpReq, ListRulesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        ListRulesShrinkRequest request = new ListRulesShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.body)) {
            request.bodyShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bodyShrink)) {
            query.put("body", request.bodyShrink);
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
            new TeaPair("action", "ListRules"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/messageCategories/rules/listRules"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListRulesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询规则列表</p>
     * 
     * @param request ListRulesRequest
     * @return ListRulesResponse
     */
    public ListRulesResponse listRules(ListRulesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListRulesHeaders headers = new ListRulesHeaders();
        return this.listRulesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>指定用户强制下线</p>
     * 
     * @param request LogoutRequest
     * @param headers LogoutHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return LogoutResponse
     */
    public LogoutResponse logoutWithOptions(LogoutRequest request, LogoutHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceType)) {
            body.put("deviceType", request.deviceType);
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
            new TeaPair("action", "Logout"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/users/logout"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new LogoutResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>指定用户强制下线</p>
     * 
     * @param request LogoutRequest
     * @return LogoutResponse
     */
    public LogoutResponse logout(LogoutRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LogoutHeaders headers = new LogoutHeaders();
        return this.logoutWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>购买权益包</p>
     * 
     * @param request OpenBenefitPackageRequest
     * @param headers OpenBenefitPackageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OpenBenefitPackageResponse
     */
    public OpenBenefitPackageResponse openBenefitPackageWithOptions(OpenBenefitPackageRequest request, OpenBenefitPackageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.benefitPackage)) {
            body.put("benefitPackage", request.benefitPackage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endDate)) {
            body.put("endDate", request.endDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startDate)) {
            body.put("startDate", request.startDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "OpenBenefitPackage"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/benefitPackages/purchase"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OpenBenefitPackageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>购买权益包</p>
     * 
     * @param request OpenBenefitPackageRequest
     * @return OpenBenefitPackageResponse
     */
    public OpenBenefitPackageResponse openBenefitPackage(OpenBenefitPackageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OpenBenefitPackageHeaders headers = new OpenBenefitPackageHeaders();
        return this.openBenefitPackageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>商机冲突检测</p>
     * 
     * @param request OpportunitySearchRequest
     * @param headers OpportunitySearchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OpportunitySearchResponse
     */
    public OpportunitySearchResponse opportunitySearchWithOptions(OpportunitySearchRequest request, OpportunitySearchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "OpportunitySearch"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/opportunities/check"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OpportunitySearchResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>商机冲突检测</p>
     * 
     * @param request OpportunitySearchRequest
     * @return OpportunitySearchResponse
     */
    public OpportunitySearchResponse opportunitySearch(OpportunitySearchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OpportunitySearchHeaders headers = new OpportunitySearchHeaders();
        return this.opportunitySearchWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>防作弊风险检测</p>
     * 
     * @param request PreventCheatingCheckRiskRequest
     * @param headers PreventCheatingCheckRiskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PreventCheatingCheckRiskResponse
     */
    public PreventCheatingCheckRiskResponse preventCheatingCheckRiskWithOptions(PreventCheatingCheckRiskRequest request, PreventCheatingCheckRiskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.clientVer)) {
            body.put("clientVer", request.clientVer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platform)) {
            body.put("platform", request.platform);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platformVer)) {
            body.put("platformVer", request.platformVer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sec)) {
            body.put("sec", request.sec);
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
            new TeaPair("action", "PreventCheatingCheckRisk"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/preventCheats/risks/check"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PreventCheatingCheckRiskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>防作弊风险检测</p>
     * 
     * @param request PreventCheatingCheckRiskRequest
     * @return PreventCheatingCheckRiskResponse
     */
    public PreventCheatingCheckRiskResponse preventCheatingCheckRisk(PreventCheatingCheckRiskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PreventCheatingCheckRiskHeaders headers = new PreventCheatingCheckRiskHeaders();
        return this.preventCheatingCheckRiskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发送文件更改的评论</p>
     * 
     * @param request PublishFileChangeNoticeRequest
     * @param headers PublishFileChangeNoticeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PublishFileChangeNoticeResponse
     */
    public PublishFileChangeNoticeResponse publishFileChangeNoticeWithOptions(PublishFileChangeNoticeRequest request, PublishFileChangeNoticeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fileId)) {
            body.put("fileId", request.fileId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateType)) {
            body.put("operateType", request.operateType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            body.put("operatorUnionId", request.operatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceId)) {
            body.put("spaceId", request.spaceId);
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
            new TeaPair("action", "PublishFileChangeNotice"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/comments/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PublishFileChangeNoticeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发送文件更改的评论</p>
     * 
     * @param request PublishFileChangeNoticeRequest
     * @return PublishFileChangeNoticeResponse
     */
    public PublishFileChangeNoticeResponse publishFileChangeNotice(PublishFileChangeNoticeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PublishFileChangeNoticeHeaders headers = new PublishFileChangeNoticeHeaders();
        return this.publishFileChangeNoticeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发布规则</p>
     * 
     * @param request PublishRuleRequest
     * @param headers PublishRuleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PublishRuleResponse
     */
    public PublishRuleResponse publishRuleWithOptions(PublishRuleRequest request, PublishRuleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
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
            new TeaPair("action", "PublishRule"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/messageCategories/rules/publish"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PublishRuleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发布规则</p>
     * 
     * @param request PublishRuleRequest
     * @return PublishRuleResponse
     */
    public PublishRuleResponse publishRule(PublishRuleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PublishRuleHeaders headers = new PublishRuleHeaders();
        return this.publishRuleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>推送专属设计中自建/第三方应用的小红点</p>
     * 
     * @param request PushBadgeRequest
     * @param headers PushBadgeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PushBadgeResponse
     */
    public PushBadgeResponse pushBadgeWithOptions(PushBadgeRequest request, PushBadgeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            body.put("agentId", request.agentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.badgeItems)) {
            body.put("badgeItems", request.badgeItems);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pushType)) {
            body.put("pushType", request.pushType);
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
            new TeaPair("action", "PushBadge"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/exclusiveDesigns/redPoints/push"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PushBadgeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>推送专属设计中自建/第三方应用的小红点</p>
     * 
     * @param request PushBadgeRequest
     * @return PushBadgeResponse
     */
    public PushBadgeResponse pushBadge(PushBadgeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PushBadgeHeaders headers = new PushBadgeHeaders();
        return this.pushBadgeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询跨云存储配置</p>
     * 
     * @param request QueryAcrossCloudStroageConfigsRequest
     * @param headers QueryAcrossCloudStroageConfigsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAcrossCloudStroageConfigsResponse
     */
    public QueryAcrossCloudStroageConfigsResponse queryAcrossCloudStroageConfigsWithOptions(QueryAcrossCloudStroageConfigsRequest request, QueryAcrossCloudStroageConfigsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.targetCloudType)) {
            query.put("targetCloudType", request.targetCloudType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            query.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "QueryAcrossCloudStroageConfigs"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/fileStorages/acrossClouds/configurations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAcrossCloudStroageConfigsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询跨云存储配置</p>
     * 
     * @param request QueryAcrossCloudStroageConfigsRequest
     * @return QueryAcrossCloudStroageConfigsResponse
     */
    public QueryAcrossCloudStroageConfigsResponse queryAcrossCloudStroageConfigs(QueryAcrossCloudStroageConfigsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAcrossCloudStroageConfigsHeaders headers = new QueryAcrossCloudStroageConfigsHeaders();
        return this.queryAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据手机号查询渠道组织中的员工信息</p>
     * 
     * @param request QueryChannelStaffInfoByMobileRequest
     * @param headers QueryChannelStaffInfoByMobileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryChannelStaffInfoByMobileResponse
     */
    public QueryChannelStaffInfoByMobileResponse queryChannelStaffInfoByMobileWithOptions(QueryChannelStaffInfoByMobileRequest request, QueryChannelStaffInfoByMobileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            query.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "QueryChannelStaffInfoByMobile"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/channelOrganizations/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryChannelStaffInfoByMobileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据手机号查询渠道组织中的员工信息</p>
     * 
     * @param request QueryChannelStaffInfoByMobileRequest
     * @return QueryChannelStaffInfoByMobileResponse
     */
    public QueryChannelStaffInfoByMobileResponse queryChannelStaffInfoByMobile(QueryChannelStaffInfoByMobileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryChannelStaffInfoByMobileHeaders headers = new QueryChannelStaffInfoByMobileHeaders();
        return this.queryChannelStaffInfoByMobileWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取分组下会话列表</p>
     * 
     * @param request QueryConversationPageRequest
     * @param headers QueryConversationPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryConversationPageResponse
     */
    public QueryConversationPageResponse queryConversationPageWithOptions(QueryConversationPageRequest request, QueryConversationPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.categoryId)) {
            query.put("categoryId", request.categoryId);
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
            new TeaPair("action", "QueryConversationPage"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/categories/conversations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryConversationPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取分组下会话列表</p>
     * 
     * @param request QueryConversationPageRequest
     * @return QueryConversationPageResponse
     */
    public QueryConversationPageResponse queryConversationPage(QueryConversationPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryConversationPageHeaders headers = new QueryConversationPageHeaders();
        return this.queryConversationPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询专属版权益</p>
     * 
     * @param headers QueryExclusiveBenefitsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryExclusiveBenefitsResponse
     */
    public QueryExclusiveBenefitsResponse queryExclusiveBenefitsWithOptions(QueryExclusiveBenefitsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryExclusiveBenefits"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/benefits"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryExclusiveBenefitsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询专属版权益</p>
     * @return QueryExclusiveBenefitsResponse
     */
    public QueryExclusiveBenefitsResponse queryExclusiveBenefits() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryExclusiveBenefitsHeaders headers = new QueryExclusiveBenefitsHeaders();
        return this.queryExclusiveBenefitsWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>伙伴钉根据uid查询人员的标签信息</p>
     * 
     * @param headers QueryPartnerInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPartnerInfoResponse
     */
    public QueryPartnerInfoResponse queryPartnerInfoWithOptions(String userId, QueryPartnerInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryPartnerInfo"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/partners/users/" + userId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPartnerInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>伙伴钉根据uid查询人员的标签信息</p>
     * @return QueryPartnerInfoResponse
     */
    public QueryPartnerInfoResponse queryPartnerInfo(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPartnerInfoHeaders headers = new QueryPartnerInfoHeaders();
        return this.queryPartnerInfoWithOptions(userId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据templateId查询模版信息</p>
     * 
     * @param headers QueryTemplateInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTemplateInfoResponse
     */
    public QueryTemplateInfoResponse queryTemplateInfoWithOptions(String templateId, QueryTemplateInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryTemplateInfo"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/sceneGroups/templates/" + templateId + "/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTemplateInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据templateId查询模版信息</p>
     * @return QueryTemplateInfoResponse
     */
    public QueryTemplateInfoResponse queryTemplateInfo(String templateId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTemplateInfoHeaders headers = new QueryTemplateInfoHeaders();
        return this.queryTemplateInfoWithOptions(templateId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户截屏操作记录</p>
     * 
     * @param request QueryUserBehaviorRequest
     * @param headers QueryUserBehaviorHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserBehaviorResponse
     */
    public QueryUserBehaviorResponse queryUserBehaviorWithOptions(QueryUserBehaviorRequest request, QueryUserBehaviorHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platform)) {
            body.put("platform", request.platform);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
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
            new TeaPair("action", "QueryUserBehavior"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/enterpriseSecurities/userBehaviors/screenshots/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserBehaviorResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户截屏操作记录</p>
     * 
     * @param request QueryUserBehaviorRequest
     * @return QueryUserBehaviorResponse
     */
    public QueryUserBehaviorResponse queryUserBehavior(QueryUserBehaviorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserBehaviorHeaders headers = new QueryUserBehaviorHeaders();
        return this.queryUserBehaviorWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>小程序版本回滚</p>
     * 
     * @param request RollbackMiniAppVersionRequest
     * @param headers RollbackMiniAppVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RollbackMiniAppVersionResponse
     */
    public RollbackMiniAppVersionResponse rollbackMiniAppVersionWithOptions(RollbackMiniAppVersionRequest request, RollbackMiniAppVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rollbackVersion)) {
            body.put("rollbackVersion", request.rollbackVersion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetVersion)) {
            body.put("targetVersion", request.targetVersion);
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
            new TeaPair("action", "RollbackMiniAppVersion"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/miniApps/versions/rollback"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RollbackMiniAppVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>小程序版本回滚</p>
     * 
     * @param request RollbackMiniAppVersionRequest
     * @return RollbackMiniAppVersionResponse
     */
    public RollbackMiniAppVersionResponse rollbackMiniAppVersion(RollbackMiniAppVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RollbackMiniAppVersionHeaders headers = new RollbackMiniAppVersionHeaders();
        return this.rollbackMiniAppVersionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>按规则批量发消息</p>
     * 
     * @param request RuleBatchReceiverRequest
     * @param headers RuleBatchReceiverHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RuleBatchReceiverResponse
     */
    public RuleBatchReceiverResponse ruleBatchReceiverWithOptions(RuleBatchReceiverRequest request, RuleBatchReceiverHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.batchNo)) {
            body.put("batchNo", request.batchNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardOptions)) {
            body.put("cardOptions", request.cardOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ruleCode)) {
            body.put("ruleCode", request.ruleCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretKey)) {
            body.put("secretKey", request.secretKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.specialStrategy)) {
            body.put("specialStrategy", request.specialStrategy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskBatchNo)) {
            body.put("taskBatchNo", request.taskBatchNo);
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
            new TeaPair("action", "RuleBatchReceiver"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/dmc/rules/messages/batchSend"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RuleBatchReceiverResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>按规则批量发消息</p>
     * 
     * @param request RuleBatchReceiverRequest
     * @return RuleBatchReceiverResponse
     */
    public RuleBatchReceiverResponse ruleBatchReceiver(RuleBatchReceiverRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RuleBatchReceiverHeaders headers = new RuleBatchReceiverHeaders();
        return this.ruleBatchReceiverWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增跨云存储配置</p>
     * 
     * @param request SaveAcrossCloudStroageConfigsRequest
     * @param headers SaveAcrossCloudStroageConfigsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveAcrossCloudStroageConfigsResponse
     */
    public SaveAcrossCloudStroageConfigsResponse saveAcrossCloudStroageConfigsWithOptions(SaveAcrossCloudStroageConfigsRequest request, SaveAcrossCloudStroageConfigsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKeyId)) {
            body.put("accessKeyId", request.accessKeyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accessKeySecret)) {
            body.put("accessKeySecret", request.accessKeySecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bucketName)) {
            body.put("bucketName", request.bucketName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cloudType)) {
            body.put("cloudType", request.cloudType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endpoint)) {
            body.put("endpoint", request.endpoint);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "SaveAcrossCloudStroageConfigs"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/fileStorages/acrossClouds/configurations"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveAcrossCloudStroageConfigsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增跨云存储配置</p>
     * 
     * @param request SaveAcrossCloudStroageConfigsRequest
     * @return SaveAcrossCloudStroageConfigsResponse
     */
    public SaveAcrossCloudStroageConfigsResponse saveAcrossCloudStroageConfigs(SaveAcrossCloudStroageConfigsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveAcrossCloudStroageConfigsHeaders headers = new SaveAcrossCloudStroageConfigsHeaders();
        return this.saveAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>保存并提交认证信息</p>
     * 
     * @param request SaveAndSubmitAuthInfoRequest
     * @param headers SaveAndSubmitAuthInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveAndSubmitAuthInfoResponse
     */
    public SaveAndSubmitAuthInfoResponse saveAndSubmitAuthInfoWithOptions(SaveAndSubmitAuthInfoRequest request, SaveAndSubmitAuthInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.applyRemark)) {
            body.put("applyRemark", request.applyRemark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authorizeMediaId)) {
            body.put("authorizeMediaId", request.authorizeMediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.industry)) {
            body.put("industry", request.industry);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalPerson)) {
            body.put("legalPerson", request.legalPerson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalPersonIdCard)) {
            body.put("legalPersonIdCard", request.legalPersonIdCard);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.licenseMediaId)) {
            body.put("licenseMediaId", request.licenseMediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.locCity)) {
            body.put("locCity", request.locCity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.locCityName)) {
            body.put("locCityName", request.locCityName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.locProvince)) {
            body.put("locProvince", request.locProvince);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.locProvinceName)) {
            body.put("locProvinceName", request.locProvinceName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobileNum)) {
            body.put("mobileNum", request.mobileNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgName)) {
            body.put("orgName", request.orgName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.organizationCode)) {
            body.put("organizationCode", request.organizationCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.organizationCodeMediaId)) {
            body.put("organizationCodeMediaId", request.organizationCodeMediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.registLocation)) {
            body.put("registLocation", request.registLocation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.registNum)) {
            body.put("registNum", request.registNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unifiedSocialCredit)) {
            body.put("unifiedSocialCredit", request.unifiedSocialCredit);
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
            new TeaPair("action", "SaveAndSubmitAuthInfo"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/ognizations/authInfos/saveAndSubmit"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveAndSubmitAuthInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>保存并提交认证信息</p>
     * 
     * @param request SaveAndSubmitAuthInfoRequest
     * @return SaveAndSubmitAuthInfoResponse
     */
    public SaveAndSubmitAuthInfoResponse saveAndSubmitAuthInfo(SaveAndSubmitAuthInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveAndSubmitAuthInfoHeaders headers = new SaveAndSubmitAuthInfoHeaders();
        return this.saveAndSubmitAuthInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>亿格云能力结合</p>
     * 
     * @param request SaveOpenTerminalInfoRequest
     * @param headers SaveOpenTerminalInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveOpenTerminalInfoResponse
     */
    public SaveOpenTerminalInfoResponse saveOpenTerminalInfoWithOptions(SaveOpenTerminalInfoRequest request, SaveOpenTerminalInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.logSource)) {
            body.put("logSource", request.logSource);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.logType)) {
            body.put("logType", request.logType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openExt)) {
            body.put("openExt", request.openExt);
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
            new TeaPair("action", "SaveOpenTerminalInfo"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/externalLogs/terminalInfos/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveOpenTerminalInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>亿格云能力结合</p>
     * 
     * @param request SaveOpenTerminalInfoRequest
     * @return SaveOpenTerminalInfoResponse
     */
    public SaveOpenTerminalInfoResponse saveOpenTerminalInfo(SaveOpenTerminalInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveOpenTerminalInfoHeaders headers = new SaveOpenTerminalInfoHeaders();
        return this.saveOpenTerminalInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>保存专属文件存储的功能项</p>
     * 
     * @param request SaveStorageFunctionSwitchRequest
     * @param headers SaveStorageFunctionSwitchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveStorageFunctionSwitchResponse
     */
    public SaveStorageFunctionSwitchResponse saveStorageFunctionSwitchWithOptions(SaveStorageFunctionSwitchRequest request, SaveStorageFunctionSwitchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.functionList)) {
            body.put("functionList", request.functionList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "SaveStorageFunctionSwitch"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/storages/functions/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveStorageFunctionSwitchResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>保存专属文件存储的功能项</p>
     * 
     * @param request SaveStorageFunctionSwitchRequest
     * @return SaveStorageFunctionSwitchResponse
     */
    public SaveStorageFunctionSwitchResponse saveStorageFunctionSwitch(SaveStorageFunctionSwitchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveStorageFunctionSwitchHeaders headers = new SaveStorageFunctionSwitchHeaders();
        return this.saveStorageFunctionSwitchWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>保存专属文件存储整体开关</p>
     * 
     * @param request SaveStorageSwitchRequest
     * @param headers SaveStorageSwitchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveStorageSwitchResponse
     */
    public SaveStorageSwitchResponse saveStorageSwitchWithOptions(SaveStorageSwitchRequest request, SaveStorageSwitchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openStorage)) {
            body.put("openStorage", request.openStorage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "SaveStorageSwitch"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/storages/switches/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveStorageSwitchResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>保存专属文件存储整体开关</p>
     * 
     * @param request SaveStorageSwitchRequest
     * @return SaveStorageSwitchResponse
     */
    public SaveStorageSwitchResponse saveStorageSwitch(SaveStorageSwitchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveStorageSwitchHeaders headers = new SaveStorageSwitchHeaders();
        return this.saveStorageSwitchWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用于提供mdm微应用白名单配置能力</p>
     * 
     * @param request SaveWhiteAppRequest
     * @param headers SaveWhiteAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveWhiteAppResponse
     */
    public SaveWhiteAppResponse saveWhiteAppWithOptions(SaveWhiteAppRequest request, SaveWhiteAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentIdList)) {
            body.put("agentIdList", request.agentIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.agentIdMap)) {
            body.put("agentIdMap", request.agentIdMap);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operation)) {
            body.put("operation", request.operation);
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
            new TeaPair("action", "SaveWhiteApp"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/miniApps/whiteLists/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveWhiteAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>用于提供mdm微应用白名单配置能力</p>
     * 
     * @param request SaveWhiteAppRequest
     * @return SaveWhiteAppResponse
     */
    public SaveWhiteAppResponse saveWhiteApp(SaveWhiteAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveWhiteAppHeaders headers = new SaveWhiteAppHeaders();
        return this.saveWhiteAppWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业内部群信息</p>
     * 
     * @param request SearchOrgInnerGroupInfoRequest
     * @param headers SearchOrgInnerGroupInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchOrgInnerGroupInfoResponse
     */
    public SearchOrgInnerGroupInfoResponse searchOrgInnerGroupInfoWithOptions(SearchOrgInnerGroupInfoRequest request, SearchOrgInnerGroupInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.createTimeEnd)) {
            query.put("createTimeEnd", request.createTimeEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createTimeStart)) {
            query.put("createTimeStart", request.createTimeStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupMembersCountEnd)) {
            query.put("groupMembersCountEnd", request.groupMembersCountEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupMembersCountStart)) {
            query.put("groupMembersCountStart", request.groupMembersCountStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            query.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupOwner)) {
            query.put("groupOwner", request.groupOwner);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.lastActiveTimeEnd)) {
            query.put("lastActiveTimeEnd", request.lastActiveTimeEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.lastActiveTimeStart)) {
            query.put("lastActiveTimeStart", request.lastActiveTimeStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            query.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageStart)) {
            query.put("pageStart", request.pageStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.syncToDingpan)) {
            query.put("syncToDingpan", request.syncToDingpan);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            query.put("uuid", request.uuid);
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
            new TeaPair("action", "SearchOrgInnerGroupInfo"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/securities/orgGroupInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchOrgInnerGroupInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业内部群信息</p>
     * 
     * @param request SearchOrgInnerGroupInfoRequest
     * @return SearchOrgInnerGroupInfoResponse
     */
    public SearchOrgInnerGroupInfoResponse searchOrgInnerGroupInfo(SearchOrgInnerGroupInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchOrgInnerGroupInfoHeaders headers = new SearchOrgInnerGroupInfoHeaders();
        return this.searchOrgInnerGroupInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通过接口发送应用内DING</p>
     * 
     * @param request SendAppDingRequest
     * @param headers SendAppDingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendAppDingResponse
     */
    public SendAppDingResponse sendAppDingWithOptions(SendAppDingRequest request, SendAppDingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userids)) {
            body.put("userids", request.userids);
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
            new TeaPair("action", "SendAppDing"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/appDings/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendAppDingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通过接口发送应用内DING</p>
     * 
     * @param request SendAppDingRequest
     * @return SendAppDingResponse
     */
    public SendAppDingResponse sendAppDing(SendAppDingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendAppDingHeaders headers = new SendAppDingHeaders();
        return this.sendAppDingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发送邀请函</p>
     * 
     * @param request SendInvitationRequest
     * @param headers SendInvitationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendInvitationResponse
     */
    public SendInvitationResponse sendInvitationWithOptions(SendInvitationRequest request, SendInvitationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgAlias)) {
            body.put("orgAlias", request.orgAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.partnerLabelId)) {
            body.put("partnerLabelId", request.partnerLabelId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.partnerNum)) {
            body.put("partnerNum", request.partnerNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.phone)) {
            body.put("phone", request.phone);
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
            new TeaPair("action", "SendInvitation"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/partnerDepartments/invitations/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendInvitationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发送邀请函</p>
     * 
     * @param request SendInvitationRequest
     * @return SendInvitationResponse
     */
    public SendInvitationResponse sendInvitation(SendInvitationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendInvitationHeaders headers = new SendInvitationHeaders();
        return this.sendInvitationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通过接口发送电话DING</p>
     * 
     * @param request SendPhoneDingRequest
     * @param headers SendPhoneDingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendPhoneDingResponse
     */
    public SendPhoneDingResponse sendPhoneDingWithOptions(SendPhoneDingRequest request, SendPhoneDingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userids)) {
            body.put("userids", request.userids);
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
            new TeaPair("action", "SendPhoneDing"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/phoneDings/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendPhoneDingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通过接口发送电话DING</p>
     * 
     * @param request SendPhoneDingRequest
     * @return SendPhoneDingResponse
     */
    public SendPhoneDingResponse sendPhoneDing(SendPhoneDingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendPhoneDingHeaders headers = new SendPhoneDingHeaders();
        return this.sendPhoneDingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设置会话所属分组</p>
     * 
     * @param request SetConversationCategoryRequest
     * @param headers SetConversationCategoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetConversationCategoryResponse
     */
    public SetConversationCategoryResponse setConversationCategoryWithOptions(SetConversationCategoryRequest request, SetConversationCategoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.categoryId)) {
            body.put("categoryId", request.categoryId);
        }

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
            new TeaPair("action", "SetConversationCategory"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/conversationCategories/set"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetConversationCategoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设置会话所属分组</p>
     * 
     * @param request SetConversationCategoryRequest
     * @return SetConversationCategoryResponse
     */
    public SetConversationCategoryResponse setConversationCategory(SetConversationCategoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetConversationCategoryHeaders headers = new SetConversationCategoryHeaders();
        return this.setConversationCategoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设置会话副标题</p>
     * 
     * @param request SetConversationSubtitleRequest
     * @param headers SetConversationSubtitleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetConversationSubtitleResponse
     */
    public SetConversationSubtitleResponse setConversationSubtitleWithOptions(SetConversationSubtitleRequest request, SetConversationSubtitleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subtitle)) {
            body.put("subtitle", request.subtitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subtitleColor)) {
            body.put("subtitleColor", request.subtitleColor);
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
            new TeaPair("action", "SetConversationSubtitle"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/conversations/subtitles/set"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetConversationSubtitleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设置会话副标题</p>
     * 
     * @param request SetConversationSubtitleRequest
     * @return SetConversationSubtitleResponse
     */
    public SetConversationSubtitleResponse setConversationSubtitle(SetConversationSubtitleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetConversationSubtitleHeaders headers = new SetConversationSubtitleHeaders();
        return this.setConversationSubtitleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设置会话所属顶部分组</p>
     * 
     * @param request SetConversationTopCategoryRequest
     * @param headers SetConversationTopCategoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetConversationTopCategoryResponse
     */
    public SetConversationTopCategoryResponse setConversationTopCategoryWithOptions(SetConversationTopCategoryRequest request, SetConversationTopCategoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.setCategoryList)) {
            body.put("setCategoryList", request.setCategoryList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sign)) {
            body.put("sign", request.sign);
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
            new TeaPair("action", "SetConversationTopCategory"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/conversations/topCategories/set"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetConversationTopCategoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设置会话所属顶部分组</p>
     * 
     * @param request SetConversationTopCategoryRequest
     * @return SetConversationTopCategoryResponse
     */
    public SetConversationTopCategoryResponse setConversationTopCategory(SetConversationTopCategoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetConversationTopCategoryHeaders headers = new SetConversationTopCategoryHeaders();
        return this.setConversationTopCategoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>伙伴钉设置部门伙伴编码和伙伴类型</p>
     * 
     * @param request SetDeptPartnerTypeAndNumRequest
     * @param headers SetDeptPartnerTypeAndNumHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetDeptPartnerTypeAndNumResponse
     */
    public SetDeptPartnerTypeAndNumResponse setDeptPartnerTypeAndNumWithOptions(SetDeptPartnerTypeAndNumRequest request, SetDeptPartnerTypeAndNumHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.labelIds)) {
            body.put("labelIds", request.labelIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.partnerNum)) {
            body.put("partnerNum", request.partnerNum);
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
            new TeaPair("action", "SetDeptPartnerTypeAndNum"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/partnerDepartments"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetDeptPartnerTypeAndNumResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>伙伴钉设置部门伙伴编码和伙伴类型</p>
     * 
     * @param request SetDeptPartnerTypeAndNumRequest
     * @return SetDeptPartnerTypeAndNumResponse
     */
    public SetDeptPartnerTypeAndNumResponse setDeptPartnerTypeAndNum(SetDeptPartnerTypeAndNumRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetDeptPartnerTypeAndNumHeaders headers = new SetDeptPartnerTypeAndNumHeaders();
        return this.setDeptPartnerTypeAndNumWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设置企业全局顶部会话分组</p>
     * 
     * @param request SetOrgTopConversationCategoryRequest
     * @param headers SetOrgTopConversationCategoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetOrgTopConversationCategoryResponse
     */
    public SetOrgTopConversationCategoryResponse setOrgTopConversationCategoryWithOptions(SetOrgTopConversationCategoryRequest request, SetOrgTopConversationCategoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SetOrgTopConversationCategory"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/topConversations/categories/set"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetOrgTopConversationCategoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设置企业全局顶部会话分组</p>
     * 
     * @param request SetOrgTopConversationCategoryRequest
     * @return SetOrgTopConversationCategoryResponse
     */
    public SetOrgTopConversationCategoryResponse setOrgTopConversationCategory(SetOrgTopConversationCategoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetOrgTopConversationCategoryHeaders headers = new SetOrgTopConversationCategoryHeaders();
        return this.setOrgTopConversationCategoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>千人千面按规则批量发消息</p>
     * 
     * @param request SpecialRuleBatchReceiverRequest
     * @param headers SpecialRuleBatchReceiverHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SpecialRuleBatchReceiverResponse
     */
    public SpecialRuleBatchReceiverResponse specialRuleBatchReceiverWithOptions(SpecialRuleBatchReceiverRequest request, SpecialRuleBatchReceiverHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.batchNo)) {
            body.put("batchNo", request.batchNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardOptions)) {
            body.put("cardOptions", request.cardOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ruleCode)) {
            body.put("ruleCode", request.ruleCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretKey)) {
            body.put("secretKey", request.secretKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.specialStrategy)) {
            body.put("specialStrategy", request.specialStrategy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskBatchNo)) {
            body.put("taskBatchNo", request.taskBatchNo);
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
            new TeaPair("action", "SpecialRuleBatchReceiver"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/dmc/rules/specialMessages/batchSend"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SpecialRuleBatchReceiverResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>千人千面按规则批量发消息</p>
     * 
     * @param request SpecialRuleBatchReceiverRequest
     * @return SpecialRuleBatchReceiverResponse
     */
    public SpecialRuleBatchReceiverResponse specialRuleBatchReceiver(SpecialRuleBatchReceiverRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SpecialRuleBatchReceiverHeaders headers = new SpecialRuleBatchReceiverHeaders();
        return this.specialRuleBatchReceiverWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>增加/删除任务人员</p>
     * 
     * @param request TaskInfoAddDelTaskPersonRequest
     * @param headers TaskInfoAddDelTaskPersonHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TaskInfoAddDelTaskPersonResponse
     */
    public TaskInfoAddDelTaskPersonResponse taskInfoAddDelTaskPersonWithOptions(TaskInfoAddDelTaskPersonRequest request, TaskInfoAddDelTaskPersonHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operateType)) {
            body.put("operateType", request.operateType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorAccount)) {
            body.put("operatorAccount", request.operatorAccount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTaskId)) {
            body.put("outTaskId", request.outTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projId)) {
            body.put("projId", request.projId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretKey)) {
            body.put("secretKey", request.secretKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskExecutePersonDTOS)) {
            body.put("taskExecutePersonDTOS", request.taskExecutePersonDTOS);
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
            new TeaPair("action", "TaskInfoAddDelTaskPerson"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/taskCenters/taskInfos/addDelTaskPerson"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TaskInfoAddDelTaskPersonResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>增加/删除任务人员</p>
     * 
     * @param request TaskInfoAddDelTaskPersonRequest
     * @return TaskInfoAddDelTaskPersonResponse
     */
    public TaskInfoAddDelTaskPersonResponse taskInfoAddDelTaskPerson(TaskInfoAddDelTaskPersonRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TaskInfoAddDelTaskPersonHeaders headers = new TaskInfoAddDelTaskPersonHeaders();
        return this.taskInfoAddDelTaskPersonWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除任务</p>
     * 
     * @param request TaskInfoCancelOrDelTaskRequest
     * @param headers TaskInfoCancelOrDelTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TaskInfoCancelOrDelTaskResponse
     */
    public TaskInfoCancelOrDelTaskResponse taskInfoCancelOrDelTaskWithOptions(TaskInfoCancelOrDelTaskRequest request, TaskInfoCancelOrDelTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardDTO)) {
            body.put("cardDTO", request.cardDTO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorAccount)) {
            body.put("operatorAccount", request.operatorAccount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTaskId)) {
            body.put("outTaskId", request.outTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projId)) {
            body.put("projId", request.projId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretKey)) {
            body.put("secretKey", request.secretKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendMsgFlag)) {
            body.put("sendMsgFlag", request.sendMsgFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskExecutePersonDTOS)) {
            body.put("taskExecutePersonDTOS", request.taskExecutePersonDTOS);
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
            new TeaPair("action", "TaskInfoCancelOrDelTask"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/taskCenters/taskInfos/cancelOrDelTask"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TaskInfoCancelOrDelTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除任务</p>
     * 
     * @param request TaskInfoCancelOrDelTaskRequest
     * @return TaskInfoCancelOrDelTaskResponse
     */
    public TaskInfoCancelOrDelTaskResponse taskInfoCancelOrDelTask(TaskInfoCancelOrDelTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TaskInfoCancelOrDelTaskHeaders headers = new TaskInfoCancelOrDelTaskHeaders();
        return this.taskInfoCancelOrDelTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建并启动任务</p>
     * 
     * @param request TaskInfoCreateAndStartTaskRequest
     * @param headers TaskInfoCreateAndStartTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TaskInfoCreateAndStartTaskResponse
     */
    public TaskInfoCreateAndStartTaskResponse taskInfoCreateAndStartTaskWithOptions(TaskInfoCreateAndStartTaskRequest request, TaskInfoCreateAndStartTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attr)) {
            body.put("attr", request.attr);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.backlogDTO)) {
            body.put("backlogDTO", request.backlogDTO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.backlogGenerateFlag)) {
            body.put("backlogGenerateFlag", request.backlogGenerateFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.businessCode)) {
            body.put("businessCode", request.businessCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.canceldelTaskCardId)) {
            body.put("canceldelTaskCardId", request.canceldelTaskCardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardDTO)) {
            body.put("cardDTO", request.cardDTO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customFlag)) {
            body.put("customFlag", request.customFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.detailUrl)) {
            body.put("detailUrl", request.detailUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.finishTaskCardId)) {
            body.put("finishTaskCardId", request.finishTaskCardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorAccount)) {
            body.put("operatorAccount", request.operatorAccount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTaskId)) {
            body.put("outTaskId", request.outTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projId)) {
            body.put("projId", request.projId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretKey)) {
            body.put("secretKey", request.secretKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendMsgFlag)) {
            body.put("sendMsgFlag", request.sendMsgFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sort)) {
            body.put("sort", request.sort);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTaskCardId)) {
            body.put("startTaskCardId", request.startTaskCardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.state)) {
            body.put("state", request.state);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskContent)) {
            body.put("taskContent", request.taskContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskEndTime)) {
            body.put("taskEndTime", request.taskEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskExecutePersonDTOS)) {
            body.put("taskExecutePersonDTOS", request.taskExecutePersonDTOS);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskGroupDTOList)) {
            body.put("taskGroupDTOList", request.taskGroupDTOList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskSystem)) {
            body.put("taskSystem", request.taskSystem);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskTemplCode)) {
            body.put("taskTemplCode", request.taskTemplCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskTitle)) {
            body.put("taskTitle", request.taskTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskType)) {
            body.put("taskType", request.taskType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskUrlMobile)) {
            body.put("taskUrlMobile", request.taskUrlMobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskUrlPc)) {
            body.put("taskUrlPc", request.taskUrlPc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.updateTaskCardId)) {
            body.put("updateTaskCardId", request.updateTaskCardId);
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
            new TeaPair("action", "TaskInfoCreateAndStartTask"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/taskCenters/taskInfos/createAndStart"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TaskInfoCreateAndStartTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建并启动任务</p>
     * 
     * @param request TaskInfoCreateAndStartTaskRequest
     * @return TaskInfoCreateAndStartTaskResponse
     */
    public TaskInfoCreateAndStartTaskResponse taskInfoCreateAndStartTask(TaskInfoCreateAndStartTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TaskInfoCreateAndStartTaskHeaders headers = new TaskInfoCreateAndStartTaskHeaders();
        return this.taskInfoCreateAndStartTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>完成任务</p>
     * 
     * @param request TaskInfoFinishTaskRequest
     * @param headers TaskInfoFinishTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TaskInfoFinishTaskResponse
     */
    public TaskInfoFinishTaskResponse taskInfoFinishTaskWithOptions(TaskInfoFinishTaskRequest request, TaskInfoFinishTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardDTO)) {
            body.put("cardDTO", request.cardDTO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorAccount)) {
            body.put("operatorAccount", request.operatorAccount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTaskId)) {
            body.put("outTaskId", request.outTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projId)) {
            body.put("projId", request.projId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretKey)) {
            body.put("secretKey", request.secretKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendMsgFlag)) {
            body.put("sendMsgFlag", request.sendMsgFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskExecutePersonDTOS)) {
            body.put("taskExecutePersonDTOS", request.taskExecutePersonDTOS);
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
            new TeaPair("action", "TaskInfoFinishTask"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/taskCenters/taskInfos/finishTask"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TaskInfoFinishTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>完成任务</p>
     * 
     * @param request TaskInfoFinishTaskRequest
     * @return TaskInfoFinishTaskResponse
     */
    public TaskInfoFinishTaskResponse taskInfoFinishTask(TaskInfoFinishTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TaskInfoFinishTaskHeaders headers = new TaskInfoFinishTaskHeaders();
        return this.taskInfoFinishTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新任务</p>
     * 
     * @param request TaskInfoUpdateTaskRequest
     * @param headers TaskInfoUpdateTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TaskInfoUpdateTaskResponse
     */
    public TaskInfoUpdateTaskResponse taskInfoUpdateTaskWithOptions(TaskInfoUpdateTaskRequest request, TaskInfoUpdateTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attr)) {
            body.put("attr", request.attr);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.canceldelTaskCardId)) {
            body.put("canceldelTaskCardId", request.canceldelTaskCardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardDTO)) {
            body.put("cardDTO", request.cardDTO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.detailUrl)) {
            body.put("detailUrl", request.detailUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.finishTaskCardId)) {
            body.put("finishTaskCardId", request.finishTaskCardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.listOpenConversationId)) {
            body.put("listOpenConversationId", request.listOpenConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateType)) {
            body.put("operateType", request.operateType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorAccount)) {
            body.put("operatorAccount", request.operatorAccount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTaskId)) {
            body.put("outTaskId", request.outTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projId)) {
            body.put("projId", request.projId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretKey)) {
            body.put("secretKey", request.secretKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendMsgFlag)) {
            body.put("sendMsgFlag", request.sendMsgFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTaskCardId)) {
            body.put("startTaskCardId", request.startTaskCardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskContent)) {
            body.put("taskContent", request.taskContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskEndTime)) {
            body.put("taskEndTime", request.taskEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskExecutePersonDTOS)) {
            body.put("taskExecutePersonDTOS", request.taskExecutePersonDTOS);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskTitle)) {
            body.put("taskTitle", request.taskTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskUrlMobile)) {
            body.put("taskUrlMobile", request.taskUrlMobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskUrlPc)) {
            body.put("taskUrlPc", request.taskUrlPc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.updateTaskCardId)) {
            body.put("updateTaskCardId", request.updateTaskCardId);
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
            new TeaPair("action", "TaskInfoUpdateTask"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/taskCenters/taskInfos/update"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TaskInfoUpdateTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新任务</p>
     * 
     * @param request TaskInfoUpdateTaskRequest
     * @return TaskInfoUpdateTaskResponse
     */
    public TaskInfoUpdateTaskResponse taskInfoUpdateTask(TaskInfoUpdateTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TaskInfoUpdateTaskHeaders headers = new TaskInfoUpdateTaskHeaders();
        return this.taskInfoUpdateTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>切换组织归属</p>
     * 
     * @param request TransferExclusiveAccountOrgRequest
     * @param headers TransferExclusiveAccountOrgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TransferExclusiveAccountOrgResponse
     */
    public TransferExclusiveAccountOrgResponse transferExclusiveAccountOrgWithOptions(TransferExclusiveAccountOrgRequest request, TransferExclusiveAccountOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isSettingMainOrg)) {
            body.put("isSettingMainOrg", request.isSettingMainOrg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "TransferExclusiveAccountOrg"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/organizations/transfer"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TransferExclusiveAccountOrgResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>切换组织归属</p>
     * 
     * @param request TransferExclusiveAccountOrgRequest
     * @return TransferExclusiveAccountOrgResponse
     */
    public TransferExclusiveAccountOrgResponse transferExclusiveAccountOrg(TransferExclusiveAccountOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TransferExclusiveAccountOrgHeaders headers = new TransferExclusiveAccountOrgHeaders();
        return this.transferExclusiveAccountOrgWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更改分组名称</p>
     * 
     * @param request UpdateCategoryNameRequest
     * @param headers UpdateCategoryNameHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCategoryNameResponse
     */
    public UpdateCategoryNameResponse updateCategoryNameWithOptions(UpdateCategoryNameRequest request, UpdateCategoryNameHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.currentCategoryName)) {
            body.put("currentCategoryName", request.currentCategoryName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCategoryName)) {
            body.put("targetCategoryName", request.targetCategoryName);
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
            new TeaPair("action", "UpdateCategoryName"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/messageCategories/categories/names"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCategoryNameResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更改分组名称</p>
     * 
     * @param request UpdateCategoryNameRequest
     * @return UpdateCategoryNameResponse
     */
    public UpdateCategoryNameResponse updateCategoryName(UpdateCategoryNameRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCategoryNameHeaders headers = new UpdateCategoryNameHeaders();
        return this.updateCategoryNameWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>变更群聊类型</p>
     * 
     * @param request UpdateConversationTypeRequest
     * @param headers UpdateConversationTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateConversationTypeResponse
     */
    public UpdateConversationTypeResponse updateConversationTypeWithOptions(UpdateConversationTypeRequest request, UpdateConversationTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.manageSign)) {
            body.put("manageSign", request.manageSign);
        }

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
            new TeaPair("action", "UpdateConversationType"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/conversationTypes"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateConversationTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>变更群聊类型</p>
     * 
     * @param request UpdateConversationTypeRequest
     * @return UpdateConversationTypeResponse
     */
    public UpdateConversationTypeResponse updateConversationType(UpdateConversationTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateConversationTypeHeaders headers = new UpdateConversationTypeHeaders();
        return this.updateConversationTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新发送文件的检测状态</p>
     * 
     * @param request UpdateFileStatusRequest
     * @param headers UpdateFileStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateFileStatusResponse
     */
    public UpdateFileStatusResponse updateFileStatusWithOptions(UpdateFileStatusRequest request, UpdateFileStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.requestIds)) {
            body.put("requestIds", request.requestIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
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
            new TeaPair("action", "UpdateFileStatus"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/sending/files/status"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateFileStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新发送文件的检测状态</p>
     * 
     * @param request UpdateFileStatusRequest
     * @return UpdateFileStatusResponse
     */
    public UpdateFileStatusResponse updateFileStatus(UpdateFileStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateFileStatusHeaders headers = new UpdateFileStatusHeaders();
        return this.updateFileStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发布版本</p>
     * 
     * @param request UpdateMiniAppVersionStatusRequest
     * @param headers UpdateMiniAppVersionStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateMiniAppVersionStatusResponse
     */
    public UpdateMiniAppVersionStatusResponse updateMiniAppVersionStatusWithOptions(UpdateMiniAppVersionStatusRequest request, UpdateMiniAppVersionStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            body.put("version", request.version);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.versionType)) {
            body.put("versionType", request.versionType);
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
            new TeaPair("action", "UpdateMiniAppVersionStatus"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/miniApps/versions/versionStatus"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateMiniAppVersionStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发布版本</p>
     * 
     * @param request UpdateMiniAppVersionStatusRequest
     * @return UpdateMiniAppVersionStatusResponse
     */
    public UpdateMiniAppVersionStatusResponse updateMiniAppVersionStatus(UpdateMiniAppVersionStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateMiniAppVersionStatusHeaders headers = new UpdateMiniAppVersionStatusHeaders();
        return this.updateMiniAppVersionStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改伙伴类型可见性</p>
     * 
     * @param request UpdatePartnerVisibilityRequest
     * @param headers UpdatePartnerVisibilityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdatePartnerVisibilityResponse
     */
    public UpdatePartnerVisibilityResponse updatePartnerVisibilityWithOptions(UpdatePartnerVisibilityRequest request, UpdatePartnerVisibilityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIds)) {
            body.put("deptIds", request.deptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.labelId)) {
            body.put("labelId", request.labelId);
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
            new TeaPair("action", "UpdatePartnerVisibility"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/partnerDepartments/visibilityPartners"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "boolean")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdatePartnerVisibilityResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改伙伴类型可见性</p>
     * 
     * @param request UpdatePartnerVisibilityRequest
     * @return UpdatePartnerVisibilityResponse
     */
    public UpdatePartnerVisibilityResponse updatePartnerVisibility(UpdatePartnerVisibilityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdatePartnerVisibilityHeaders headers = new UpdatePartnerVisibilityHeaders();
        return this.updatePartnerVisibilityWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>专属一线版-企业修改员工license</p>
     * 
     * @param request UpdateRealmLicenseRequest
     * @param headers UpdateRealmLicenseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateRealmLicenseResponse
     */
    public UpdateRealmLicenseResponse updateRealmLicenseWithOptions(UpdateRealmLicenseRequest request, UpdateRealmLicenseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.detailList)) {
            body.put("detailList", request.detailList);
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
            new TeaPair("action", "UpdateRealmLicense"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/frontLines/licenses"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateRealmLicenseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>专属一线版-企业修改员工license</p>
     * 
     * @param request UpdateRealmLicenseRequest
     * @return UpdateRealmLicenseResponse
     */
    public UpdateRealmLicenseResponse updateRealmLicense(UpdateRealmLicenseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateRealmLicenseHeaders headers = new UpdateRealmLicenseHeaders();
        return this.updateRealmLicenseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改角色可见性</p>
     * 
     * @param request UpdateRoleVisibilityRequest
     * @param headers UpdateRoleVisibilityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateRoleVisibilityResponse
     */
    public UpdateRoleVisibilityResponse updateRoleVisibilityWithOptions(UpdateRoleVisibilityRequest request, UpdateRoleVisibilityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIds)) {
            body.put("deptIds", request.deptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.labelId)) {
            body.put("labelId", request.labelId);
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
            new TeaPair("action", "UpdateRoleVisibility"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/partnerDepartments/visibilityRoles"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "boolean")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateRoleVisibilityResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改角色可见性</p>
     * 
     * @param request UpdateRoleVisibilityRequest
     * @return UpdateRoleVisibilityResponse
     */
    public UpdateRoleVisibilityResponse updateRoleVisibility(UpdateRoleVisibilityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateRoleVisibilityHeaders headers = new UpdateRoleVisibilityHeaders();
        return this.updateRoleVisibilityWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新组织专属存储模式</p>
     * 
     * @param request UpdateStorageModeRequest
     * @param headers UpdateStorageModeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateStorageModeResponse
     */
    public UpdateStorageModeResponse updateStorageModeWithOptions(UpdateStorageModeRequest request, UpdateStorageModeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fileStorageMode)) {
            body.put("fileStorageMode", request.fileStorageMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "UpdateStorageMode"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/fileStorages/acrossClouds/storageModes"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateStorageModeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新组织专属存储模式</p>
     * 
     * @param request UpdateStorageModeRequest
     * @return UpdateStorageModeResponse
     */
    public UpdateStorageModeResponse updateStorageMode(UpdateStorageModeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateStorageModeHeaders headers = new UpdateStorageModeHeaders();
        return this.updateStorageModeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>允许三方调用该API，决定对应的语音消息管控状态</p>
     * 
     * @param request UpdateVoiceMsgCtrlStatusRequest
     * @param headers UpdateVoiceMsgCtrlStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateVoiceMsgCtrlStatusResponse
     */
    public UpdateVoiceMsgCtrlStatusResponse updateVoiceMsgCtrlStatusWithOptions(UpdateVoiceMsgCtrlStatusRequest request, UpdateVoiceMsgCtrlStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.voiceMsgCtrlInfo)) {
            body.put("voiceMsgCtrlInfo", request.voiceMsgCtrlInfo);
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
            new TeaPair("action", "UpdateVoiceMsgCtrlStatus"),
            new TeaPair("version", "exclusive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/exclusive/voiceMessages/ctrlStatuses"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateVoiceMsgCtrlStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>允许三方调用该API，决定对应的语音消息管控状态</p>
     * 
     * @param request UpdateVoiceMsgCtrlStatusRequest
     * @return UpdateVoiceMsgCtrlStatusResponse
     */
    public UpdateVoiceMsgCtrlStatusResponse updateVoiceMsgCtrlStatus(UpdateVoiceMsgCtrlStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateVoiceMsgCtrlStatusHeaders headers = new UpdateVoiceMsgCtrlStatusHeaders();
        return this.updateVoiceMsgCtrlStatusWithOptions(request, headers, runtime);
    }
}
