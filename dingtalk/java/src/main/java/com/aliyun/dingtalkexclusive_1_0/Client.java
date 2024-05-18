// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkexclusive_1_0.models.*;

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
     * @summary 新增企业
     *
     * @param request AddOrgRequest
     * @param headers AddOrgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddOrgResponse
     */
    public AddOrgResponse addOrgWithOptions(AddOrgRequest request, AddOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mobileNum)) {
            body.put("mobileNum", request.mobileNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
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
     * @summary 新增企业
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
     * @summary 专属审批结果回调
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
     * @summary 专属审批结果回调
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
     * @summary 群禁言或解禁
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
     * @summary 群禁言或解禁
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
     * @summary 创建分组并绑定会话
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
     * @summary 创建分组并绑定会话
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
     * @summary 创建分组并绑定会话
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
     * @summary 创建分组并绑定会话
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
     * @summary 创建规则
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
     * @summary 创建规则
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
     * @summary 存入可信设备信息
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
     * @summary 存入可信设备信息
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
     * @summary 批量新增可信设备
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
     * @summary 批量新增可信设备
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
     * @summary 删除跨云存储配置
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
     * @summary 删除跨云存储配置
     *
     * @return DeleteAcrossCloudStroageConfigsResponse
     */
    public DeleteAcrossCloudStroageConfigsResponse deleteAcrossCloudStroageConfigs(String targetCorpId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteAcrossCloudStroageConfigsHeaders headers = new DeleteAcrossCloudStroageConfigsHeaders();
        return this.deleteAcrossCloudStroageConfigsWithOptions(targetCorpId, headers, runtime);
    }

    /**
     * @summary 删除评论
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
     * @summary 删除评论
     *
     * @return DeleteCommentResponse
     */
    public DeleteCommentResponse deleteComment(String publisherId, String commentId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteCommentHeaders headers = new DeleteCommentHeaders();
        return this.deleteCommentWithOptions(publisherId, commentId, headers, runtime);
    }

    /**
     * @summary 删除指定可信设备
     *
     * @param request DeleteTrustedDeviceRequest
     * @param headers DeleteTrustedDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteTrustedDeviceResponse
     */
    public DeleteTrustedDeviceResponse deleteTrustedDeviceWithOptions(DeleteTrustedDeviceRequest request, DeleteTrustedDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
     * @summary 删除指定可信设备
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
     * @summary 分发伙伴应用
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
     * @summary 分发伙伴应用
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
     * @summary 更换组织主管理员
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
     * @summary 更换组织主管理员
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
     * @summary 分发工作台模版
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
     * @summary 分发工作台模版
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
     * @summary 专属文件第一次设置，激活配置
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
     * @summary 专属文件第一次设置，激活配置
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
     * @summary 检查专属存储OSS连接
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
     * @summary 检查专属存储OSS连接
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
     * @summary 专属文件存储获取存储情况(按时间区间)
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
     * @summary 专属文件存储获取存储情况(按时间区间)
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
     * @summary 专属文件存储获取存储情况和配置
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
     * @summary 专属文件存储获取存储情况和配置
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
     * @summary 更新文件专属存储配置
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
     * @summary 更新文件专属存储配置
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
     * @summary 生成暗水印
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
     * @summary 生成暗水印
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
     * @summary 获取专属钉钉账号数据迁移结果
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
     * @summary 获取专属钉钉账号数据迁移结果
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
     * @summary 获得组织维度的用户dau
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
     * @summary 获得组织维度的用户dau
     *
     * @return GetActiveUserSummaryResponse
     */
    public GetActiveUserSummaryResponse getActiveUserSummary(String dataId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetActiveUserSummaryHeaders headers = new GetActiveUserSummaryHeaders();
        return this.getActiveUserSummaryWithOptions(dataId, headers, runtime);
    }

    /**
     * @summary 根据AppId获取微应用在该组织下的agentId
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
     * @summary 根据AppId获取微应用在该组织下的agentId
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
     * @summary 伙伴钉可打标签部门查询
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
     * @summary 伙伴钉可打标签部门查询
     *
     * @return GetAllLabelableDeptsResponse
     */
    public GetAllLabelableDeptsResponse getAllLabelableDepts() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAllLabelableDeptsHeaders headers = new GetAllLabelableDeptsHeaders();
        return this.getAllLabelableDeptsWithOptions(headers, runtime);
    }

    /**
     * @summary 获得app分发信息
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
     * @summary 获得app分发信息
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
     * @summary 获得组织维度日程相关信息
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
     * @summary 获得组织维度日程相关信息
     *
     * @return GetCalenderSummaryResponse
     */
    public GetCalenderSummaryResponse getCalenderSummary(String dataId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCalenderSummaryHeaders headers = new GetCalenderSummaryHeaders();
        return this.getCalenderSummaryWithOptions(dataId, headers, runtime);
    }

    /**
     * @summary 获取发布号的评论列表
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
     * @summary 获取发布号的评论列表
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
     * @summary 根据逻辑会议id获取会议基本信息
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
     * @summary 根据逻辑会议id获取会议基本信息
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
     * @summary 获取视频会议明细
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
     * @summary 获取视频会议明细
     *
     * @return GetConferenceDetailResponse
     */
    public GetConferenceDetailResponse getConferenceDetail(String conferenceId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetConferenceDetailHeaders headers = new GetConferenceDetailHeaders();
        return this.getConferenceDetailWithOptions(conferenceId, headers, runtime);
    }

    /**
     * @summary 获取部门维度发布日志信息
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
     * @summary 获取部门维度发布日志信息
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
     * @summary 获取组织维度发布日志信息
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
     * @summary 获取组织维度发布日志信息
     *
     * @return GetDingReportSummaryResponse
     */
    public GetDingReportSummaryResponse getDingReportSummary(String dataId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDingReportSummaryHeaders headers = new GetDingReportSummaryHeaders();
        return this.getDingReportSummaryWithOptions(dataId, headers, runtime);
    }

    /**
     * @summary 获得部门维度用户创建文档数和创建文档人数
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
     * @summary 获得部门维度用户创建文档数和创建文档人数
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
     * @summary 获取组织维度用户创建文档数和创建文档人数
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
     * @summary 获取组织维度用户创建文档数和创建文档人数
     *
     * @return GetDocCreatedSummaryResponse
     */
    public GetDocCreatedSummaryResponse getDocCreatedSummary(String dataId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDocCreatedSummaryHeaders headers = new GetDocCreatedSummaryHeaders();
        return this.getDocCreatedSummaryWithOptions(dataId, headers, runtime);
    }

    /**
     * @summary 获取专属账号所有组织列表
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
     * @summary 获取专属账号所有组织列表
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
     * @summary 获取部门维度发布智能填表数量和使用智能填表人数
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
     * @summary 获取部门维度发布智能填表数量和使用智能填表人数
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
     * @summary 获取组织维度发布智能填表数量和使用智能填表人数
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
     * @summary 获取组织维度发布智能填表数量和使用智能填表人数
     *
     * @return GetGeneralFormCreatedSummaryResponse
     */
    public GetGeneralFormCreatedSummaryResponse getGeneralFormCreatedSummary(String dataId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetGeneralFormCreatedSummaryHeaders headers = new GetGeneralFormCreatedSummaryHeaders();
        return this.getGeneralFormCreatedSummaryWithOptions(dataId, headers, runtime);
    }

    /**
     * @summary 获取群活跃明细
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
     * @summary 获取群活跃明细
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
     * @summary 获取未活跃用户登陆统计明细
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
     * @summary 获取未活跃用户登陆统计明细
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
     * @summary 获取最后一次验证通过的企业认证信息
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
     * @summary 获取最后一次验证通过的企业认证信息
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
     * @summary 消息规则配置和群属性接口
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
     * @summary 消息规则配置和群属性接口
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
     * @summary 获取oa后台操作日志记录
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
     * @summary 获取oa后台操作日志记录
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
     * @summary 获取企业的外部审计群列表
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
     * @summary 获取企业的外部审计群列表
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
     * @summary 获取外部审计群消息记录
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
     * @summary 获取外部审计群消息记录
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
     * @summary 伙伴钉根据父标签查询子标签
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
     * @summary 伙伴钉根据父标签查询子标签
     *
     * @return GetPartnerTypeByParentIdResponse
     */
    public GetPartnerTypeByParentIdResponse getPartnerTypeByParentId(String parentId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPartnerTypeByParentIdHeaders headers = new GetPartnerTypeByParentIdHeaders();
        return this.getPartnerTypeByParentIdWithOptions(parentId, headers, runtime);
    }

    /**
     * @summary 获取公共设备列表。
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
     * @summary 获取公共设备列表。
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
     * @summary 获取互动服务窗相关数据
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
     * @summary 获取互动服务窗相关数据
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
     * @summary 获取实人认证接口调用记录
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
     * @summary 获取实人认证接口调用记录
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
     * @summary 获取人脸对比接口调用记录
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
     * @summary 获取人脸对比接口调用记录
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
     * @summary 获取审计协议签署人员信息
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
     * @summary 获取审计协议签署人员信息
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
     * @summary 获取多个可信设备信息，包括mac地址、staffId、platform
     *
     * @param request GetTrustDeviceListRequest
     * @param headers GetTrustDeviceListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTrustDeviceListResponse
     */
    public GetTrustDeviceListResponse getTrustDeviceListWithOptions(GetTrustDeviceListRequest request, GetTrustDeviceListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
     * @summary 获取多个可信设备信息，包括mac地址、staffId、platform
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
     * @summary 获得组织维度用户版本分布情况
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
     * @summary 获得组织维度用户版本分布情况
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
     * @summary 人脸录入状态查询
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
     * @summary 人脸录入状态查询
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
     * @summary 实人认证状态查询
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
     * @summary 实人认证状态查询
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
     * @summary 获取用户停留时长
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
     * @summary 获取用户停留时长
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
     * @summary 获取企业文件审计日志
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
     * @summary 获取企业文件审计日志
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
     * @summary 查询分组列表
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
     * @summary 查询分组列表
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
     * @summary 通过手机号获取已加入的属于渠道组织的列表信息
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
     * @summary 通过手机号获取已加入的属于渠道组织的列表信息
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
     * @summary 获取小程序版本列表
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
     * @summary 获取小程序版本列表
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
     * @summary 获取小程序历史版本列表
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
     * @summary 获取小程序历史版本列表
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
     * @summary 查询伙伴角色
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
     * @summary 查询伙伴角色
     *
     * @return ListPartnerRolesResponse
     */
    public ListPartnerRolesResponse listPartnerRoles(String parentId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListPartnerRolesHeaders headers = new ListPartnerRolesHeaders();
        return this.listPartnerRolesWithOptions(parentId, headers, runtime);
    }

    /**
     * @summary 获取巡点信息列表
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
     * @summary 获取巡点信息列表
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
     * @summary 查询规则列表
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
     * @summary 查询规则列表
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
     * @summary 指定用户强制下线
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
     * @summary 指定用户强制下线
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
     * @summary 购买权益包
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
     * @summary 购买权益包
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
     * @summary 防作弊风险检测
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
     * @summary 防作弊风险检测
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
     * @summary 发送文件更改的评论
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
     * @summary 发送文件更改的评论
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
     * @summary 发布规则
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
     * @summary 发布规则
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
     * @summary 推送专属设计中自建/第三方应用的小红点
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
     * @summary 推送专属设计中自建/第三方应用的小红点
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
     * @summary 查询跨云存储配置
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
     * @summary 查询跨云存储配置
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
     * @summary 伙伴钉根据uid查询人员的标签信息
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
     * @summary 伙伴钉根据uid查询人员的标签信息
     *
     * @return QueryPartnerInfoResponse
     */
    public QueryPartnerInfoResponse queryPartnerInfo(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPartnerInfoHeaders headers = new QueryPartnerInfoHeaders();
        return this.queryPartnerInfoWithOptions(userId, headers, runtime);
    }

    /**
     * @summary 获取用户截屏操作记录
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
     * @summary 获取用户截屏操作记录
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
     * @summary 小程序版本回滚
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
     * @summary 小程序版本回滚
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
     * @summary 按规则批量发消息
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
     * @summary 按规则批量发消息
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
     * @summary 新增跨云存储配置
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
     * @summary 新增跨云存储配置
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
     * @summary 保存并提交认证信息
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
     * @summary 保存并提交认证信息
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
     * @summary 亿格云能力结合
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
     * @summary 亿格云能力结合
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
     * @summary 用于提供mdm微应用白名单配置能力
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
     * @summary 用于提供mdm微应用白名单配置能力
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
     * @summary 查询企业内部群信息
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
     * @summary 查询企业内部群信息
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
     * @summary 通过接口发送应用内DING
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
     * @summary 通过接口发送应用内DING
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
     * @summary 发送邀请函
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
     * @summary 发送邀请函
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
     * @summary 通过接口发送电话DING
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
     * @summary 通过接口发送电话DING
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
     * @summary 伙伴钉设置部门伙伴编码和伙伴类型
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
     * @summary 伙伴钉设置部门伙伴编码和伙伴类型
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
     * @summary 千人千面按规则批量发消息
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
     * @summary 千人千面按规则批量发消息
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
     * @summary 更改分组名称
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
     * @summary 更改分组名称
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
     * @summary 更新发送文件的检测状态
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
     * @summary 更新发送文件的检测状态
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
     * @summary 发布版本
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
     * @summary 发布版本
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
     * @summary 修改伙伴类型可见性
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
     * @summary 修改伙伴类型可见性
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
     * @summary 专属一线版-企业修改员工license
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
     * @summary 专属一线版-企业修改员工license
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
     * @summary 修改角色可见性
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
     * @summary 修改角色可见性
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
     * @summary 更新组织专属存储模式
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
     * @summary 更新组织专属存储模式
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
     * @summary 允许三方调用该API，决定对应的语音消息管控状态
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
     * @summary 允许三方调用该API，决定对应的语音消息管控状态
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
