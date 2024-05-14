// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkesign_2_0.models.*;

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
     * @summary 获取流程任务用印审批列表
     *
     * @param headers ApprovalListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ApprovalListResponse
     */
    public ApprovalListResponse approvalListWithOptions(String taskId, ApprovalListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ApprovalList"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/approvals/" + taskId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ApprovalListResponse());
    }

    /**
     * @summary 获取流程任务用印审批列表
     *
     * @return ApprovalListResponse
     */
    public ApprovalListResponse approvalList(String taskId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ApprovalListHeaders headers = new ApprovalListHeaders();
        return this.approvalListWithOptions(taskId, headers, runtime);
    }

    /**
     * @summary 取消企业的授权
     *
     * @param request CancelCorpAuthRequest
     * @param headers CancelCorpAuthHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelCorpAuthResponse
     */
    public CancelCorpAuthResponse cancelCorpAuthWithOptions(CancelCorpAuthRequest request, CancelCorpAuthHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CancelCorpAuth"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/auths/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelCorpAuthResponse());
    }

    /**
     * @summary 取消企业的授权
     *
     * @param request CancelCorpAuthRequest
     * @return CancelCorpAuthResponse
     */
    public CancelCorpAuthResponse cancelCorpAuth(CancelCorpAuthRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
        return this.cancelCorpAuthWithOptions(request, headers, runtime);
    }

    /**
     * @summary 套餐转售1（分润模式）
     *
     * @param request ChannelOrdersRequest
     * @param headers ChannelOrdersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChannelOrdersResponse
     */
    public ChannelOrdersResponse channelOrdersWithOptions(ChannelOrdersRequest request, ChannelOrdersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.itemCode)) {
            body.put("itemCode", request.itemCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.itemName)) {
            body.put("itemName", request.itemName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderCreateTime)) {
            body.put("orderCreateTime", request.orderCreateTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payFee)) {
            body.put("payFee", request.payFee);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.quantity)) {
            body.put("quantity", request.quantity);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ChannelOrders"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/orders/channel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChannelOrdersResponse());
    }

    /**
     * @summary 套餐转售1（分润模式）
     *
     * @param request ChannelOrdersRequest
     * @return ChannelOrdersResponse
     */
    public ChannelOrdersResponse channelOrders(ChannelOrdersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChannelOrdersHeaders headers = new ChannelOrdersHeaders();
        return this.channelOrdersWithOptions(request, headers, runtime);
    }

    /**
     * @summary 生成企业实名的跳转地址
     *
     * @param request CorpRealnameRequest
     * @param headers CorpRealnameHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CorpRealnameResponse
     */
    public CorpRealnameResponse corpRealnameWithOptions(CorpRealnameRequest request, CorpRealnameHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CorpRealname"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/corps/realnames"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CorpRealnameResponse());
    }

    /**
     * @summary 生成企业实名的跳转地址
     *
     * @param request CorpRealnameRequest
     * @return CorpRealnameResponse
     */
    public CorpRealnameResponse corpRealname(CorpRealnameRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CorpRealnameHeaders headers = new CorpRealnameHeaders();
        return this.corpRealnameWithOptions(request, headers, runtime);
    }

    /**
     * @summary 钉钉ISV服务商数据初始化
     *
     * @param request CreateDevelopersRequest
     * @param headers CreateDevelopersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateDevelopersResponse
     */
    public CreateDevelopersResponse createDevelopersWithOptions(CreateDevelopersRequest request, CreateDevelopersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.noticeUrl)) {
            body.put("noticeUrl", request.noticeUrl);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateDevelopers"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/developers"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateDevelopersResponse());
    }

    /**
     * @summary 钉钉ISV服务商数据初始化
     *
     * @param request CreateDevelopersRequest
     * @return CreateDevelopersResponse
     */
    public CreateDevelopersResponse createDevelopers(CreateDevelopersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDevelopersHeaders headers = new CreateDevelopersHeaders();
        return this.createDevelopersWithOptions(request, headers, runtime);
    }

    /**
     * @summary 通过API发起签署流程
     *
     * @param request CreateProcessRequest
     * @param headers CreateProcessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateProcessResponse
     */
    public CreateProcessResponse createProcessWithOptions(CreateProcessRequest request, CreateProcessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ccs)) {
            body.put("ccs", request.ccs);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.files)) {
            body.put("files", request.files);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.initiatorUserId)) {
            body.put("initiatorUserId", request.initiatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.participants)) {
            body.put("participants", request.participants);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signEndTime)) {
            body.put("signEndTime", request.signEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceInfo)) {
            body.put("sourceInfo", request.sourceInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskName)) {
            body.put("taskName", request.taskName);
        }

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
            new TeaPair("action", "CreateProcess"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/process/startAtOnce"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateProcessResponse());
    }

    /**
     * @summary 通过API发起签署流程
     *
     * @param request CreateProcessRequest
     * @return CreateProcessResponse
     */
    public CreateProcessResponse createProcess(CreateProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateProcessHeaders headers = new CreateProcessHeaders();
        return this.createProcessWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取钉钉审批实例-电子附件信息
     *
     * @param headers GetAttachsApprovalHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAttachsApprovalResponse
     */
    public GetAttachsApprovalResponse getAttachsApprovalWithOptions(String instanceId, GetAttachsApprovalHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.tsignOpenAppId)) {
            realHeaders.put("tsignOpenAppId", com.aliyun.teautil.Common.toJSONString(headers.tsignOpenAppId));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetAttachsApproval"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/dingInstances/" + instanceId + "/attachments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAttachsApprovalResponse());
    }

    /**
     * @summary 获取钉钉审批实例-电子附件信息
     *
     * @return GetAttachsApprovalResponse
     */
    public GetAttachsApprovalResponse getAttachsApproval(String instanceId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAttachsApprovalHeaders headers = new GetAttachsApprovalHeaders();
        return this.getAttachsApprovalWithOptions(instanceId, headers, runtime);
    }

    /**
     * @summary 生成授权页面地址
     *
     * @param request GetAuthUrlRequest
     * @param headers GetAuthUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAuthUrlResponse
     */
    public GetAuthUrlResponse getAuthUrlWithOptions(GetAuthUrlRequest request, GetAuthUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetAuthUrl"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/auths/urls"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAuthUrlResponse());
    }

    /**
     * @summary 生成授权页面地址
     *
     * @param request GetAuthUrlRequest
     * @return GetAuthUrlResponse
     */
    public GetAuthUrlResponse getAuthUrl(GetAuthUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAuthUrlHeaders headers = new GetAuthUrlHeaders();
        return this.getAuthUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询套餐余量
     *
     * @param headers GetContractMarginHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetContractMarginResponse
     */
    public GetContractMarginResponse getContractMarginWithOptions(GetContractMarginHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetContractMargin"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/margins"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetContractMarginResponse());
    }

    /**
     * @summary 查询套餐余量
     *
     * @return GetContractMarginResponse
     */
    public GetContractMarginResponse getContractMargin() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetContractMarginHeaders headers = new GetContractMarginHeaders();
        return this.getContractMarginWithOptions(headers, runtime);
    }

    /**
     * @summary 获取企业控制台地址
     *
     * @param headers GetCorpConsoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCorpConsoleResponse
     */
    public GetCorpConsoleResponse getCorpConsoleWithOptions(GetCorpConsoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetCorpConsole"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/corps/consoles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCorpConsoleResponse());
    }

    /**
     * @summary 获取企业控制台地址
     *
     * @return GetCorpConsoleResponse
     */
    public GetCorpConsoleResponse getCorpConsole() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCorpConsoleHeaders headers = new GetCorpConsoleHeaders();
        return this.getCorpConsoleWithOptions(headers, runtime);
    }

    /**
     * @summary 查询企业信息
     *
     * @param headers GetCorpInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCorpInfoResponse
     */
    public GetCorpInfoResponse getCorpInfoWithOptions(GetCorpInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetCorpInfo"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/corps/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCorpInfoResponse());
    }

    /**
     * @summary 查询企业信息
     *
     * @return GetCorpInfoResponse
     */
    public GetCorpInfoResponse getCorpInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCorpInfoHeaders headers = new GetCorpInfoHeaders();
        return this.getCorpInfoWithOptions(headers, runtime);
    }

    /**
     * @summary 获取签署人签署地址
     *
     * @param request GetExecuteUrlRequest
     * @param headers GetExecuteUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetExecuteUrlResponse
     */
    public GetExecuteUrlResponse getExecuteUrlWithOptions(GetExecuteUrlRequest request, GetExecuteUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.account)) {
            body.put("account", request.account);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signContainer)) {
            body.put("signContainer", request.signContainer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetExecuteUrl"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/process/executeUrls"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetExecuteUrlResponse());
    }

    /**
     * @summary 获取签署人签署地址
     *
     * @param request GetExecuteUrlRequest
     * @return GetExecuteUrlResponse
     */
    public GetExecuteUrlResponse getExecuteUrl(GetExecuteUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetExecuteUrlHeaders headers = new GetExecuteUrlHeaders();
        return this.getExecuteUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取文件详情
     *
     * @param headers GetFileInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFileInfoResponse
     */
    public GetFileInfoResponse getFileInfoWithOptions(String fileId, GetFileInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetFileInfo"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/files/" + fileId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFileInfoResponse());
    }

    /**
     * @summary 获取文件详情
     *
     * @return GetFileInfoResponse
     */
    public GetFileInfoResponse getFileInfo(String fileId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileInfoHeaders headers = new GetFileInfoHeaders();
        return this.getFileInfoWithOptions(fileId, headers, runtime);
    }

    /**
     * @summary 获取文件上传地址
     *
     * @param request GetFileUploadUrlRequest
     * @param headers GetFileUploadUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFileUploadUrlResponse
     */
    public GetFileUploadUrlResponse getFileUploadUrlWithOptions(GetFileUploadUrlRequest request, GetFileUploadUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.contentMd5)) {
            body.put("contentMd5", request.contentMd5);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentType)) {
            body.put("contentType", request.contentType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.convert2Pdf)) {
            body.put("convert2Pdf", request.convert2Pdf);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            body.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSize)) {
            body.put("fileSize", request.fileSize);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetFileUploadUrl"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/files/uploadUrls"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFileUploadUrlResponse());
    }

    /**
     * @summary 获取文件上传地址
     *
     * @param request GetFileUploadUrlRequest
     * @return GetFileUploadUrlResponse
     */
    public GetFileUploadUrlResponse getFileUploadUrl(GetFileUploadUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileUploadUrlHeaders headers = new GetFileUploadUrlHeaders();
        return this.getFileUploadUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取流程详细信息及操作记录
     *
     * @param headers GetFlowDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFlowDetailResponse
     */
    public GetFlowDetailResponse getFlowDetailWithOptions(String taskId, GetFlowDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetFlowDetail"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/flowTasks/" + taskId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFlowDetailResponse());
    }

    /**
     * @summary 获取流程详细信息及操作记录
     *
     * @return GetFlowDetailResponse
     */
    public GetFlowDetailResponse getFlowDetail(String taskId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
        return this.getFlowDetailWithOptions(taskId, headers, runtime);
    }

    /**
     * @summary 获取流程任务的所有合同列表，收到签署完成消息后查询
     *
     * @param headers GetFlowDocsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFlowDocsResponse
     */
    public GetFlowDocsResponse getFlowDocsWithOptions(String taskId, GetFlowDocsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetFlowDocs"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/flowTasks/" + taskId + "/docs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFlowDocsResponse());
    }

    /**
     * @summary 获取流程任务的所有合同列表，收到签署完成消息后查询
     *
     * @return GetFlowDocsResponse
     */
    public GetFlowDocsResponse getFlowDocs(String taskId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFlowDocsHeaders headers = new GetFlowDocsHeaders();
        return this.getFlowDocsWithOptions(taskId, headers, runtime);
    }

    /**
     * @summary 获取企业的e签宝微应用当前状态
     *
     * @param headers GetIsvStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetIsvStatusResponse
     */
    public GetIsvStatusResponse getIsvStatusWithOptions(GetIsvStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetIsvStatus"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/corps/appStatus"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetIsvStatusResponse());
    }

    /**
     * @summary 获取企业的e签宝微应用当前状态
     *
     * @return GetIsvStatusResponse
     */
    public GetIsvStatusResponse getIsvStatus() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetIsvStatusHeaders headers = new GetIsvStatusHeaders();
        return this.getIsvStatusWithOptions(headers, runtime);
    }

    /**
     * @summary 获取流程签署的详细信息
     *
     * @param headers GetSignDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSignDetailResponse
     */
    public GetSignDetailResponse getSignDetailWithOptions(String taskId, GetSignDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSignDetail"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/signTasks/" + taskId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSignDetailResponse());
    }

    /**
     * @summary 获取流程签署的详细信息
     *
     * @return GetSignDetailResponse
     */
    public GetSignDetailResponse getSignDetail(String taskId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSignDetailHeaders headers = new GetSignDetailHeaders();
        return this.getSignDetailWithOptions(taskId, headers, runtime);
    }

    /**
     * @summary 查询个人信息
     *
     * @param headers GetUserInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserInfoResponse
     */
    public GetUserInfoResponse getUserInfoWithOptions(String userId, GetUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUserInfo"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/users/" + userId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserInfoResponse());
    }

    /**
     * @summary 查询个人信息
     *
     * @return GetUserInfoResponse
     */
    public GetUserInfoResponse getUserInfo(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserInfoHeaders headers = new GetUserInfoHeaders();
        return this.getUserInfoWithOptions(userId, headers, runtime);
    }

    /**
     * @summary 获取发起签署任务的地址
     *
     * @param request ProcessStartRequest
     * @param headers ProcessStartHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ProcessStartResponse
     */
    public ProcessStartResponse processStartWithOptions(ProcessStartRequest request, ProcessStartHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.autoStart)) {
            body.put("autoStart", request.autoStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ccs)) {
            body.put("ccs", request.ccs);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.files)) {
            body.put("files", request.files);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.initiatorUserId)) {
            body.put("initiatorUserId", request.initiatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.participants)) {
            body.put("participants", request.participants);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceInfo)) {
            body.put("sourceInfo", request.sourceInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskName)) {
            body.put("taskName", request.taskName);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ProcessStart"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/processes/startUrls"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ProcessStartResponse());
    }

    /**
     * @summary 获取发起签署任务的地址
     *
     * @param request ProcessStartRequest
     * @return ProcessStartResponse
     */
    public ProcessStartResponse processStart(ProcessStartRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ProcessStartHeaders headers = new ProcessStartHeaders();
        return this.processStartWithOptions(request, headers, runtime);
    }

    /**
     * @summary 套餐转售2（底价结算模式）
     *
     * @param request ResaleOrderRequest
     * @param headers ResaleOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ResaleOrderResponse
     */
    public ResaleOrderResponse resaleOrderWithOptions(ResaleOrderRequest request, ResaleOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orderCreateTime)) {
            body.put("orderCreateTime", request.orderCreateTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.quantity)) {
            body.put("quantity", request.quantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceStartTime)) {
            body.put("serviceStartTime", request.serviceStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceStopTime)) {
            body.put("serviceStopTime", request.serviceStopTime);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ResaleOrder"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/orders/resale"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ResaleOrderResponse());
    }

    /**
     * @summary 套餐转售2（底价结算模式）
     *
     * @param request ResaleOrderRequest
     * @return ResaleOrderResponse
     */
    public ResaleOrderResponse resaleOrder(ResaleOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ResaleOrderHeaders headers = new ResaleOrderHeaders();
        return this.resaleOrderWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取跳转到个人实名的地址
     *
     * @param request UsersRealnameRequest
     * @param headers UsersRealnameHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UsersRealnameResponse
     */
    public UsersRealnameResponse usersRealnameWithOptions(UsersRealnameRequest request, UsersRealnameHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UsersRealname"),
            new TeaPair("version", "esign_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/esign/users/realnames"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UsersRealnameResponse());
    }

    /**
     * @summary 获取跳转到个人实名的地址
     *
     * @param request UsersRealnameRequest
     * @return UsersRealnameResponse
     */
    public UsersRealnameResponse usersRealname(UsersRealnameRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UsersRealnameHeaders headers = new UsersRealnameHeaders();
        return this.usersRealnameWithOptions(request, headers, runtime);
    }
}
