// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkesign_1_0.models.*;

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
     * @summary 获取授权的页面地址
     *
     * @param request AuthUrlRequest
     * @param headers AuthUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AuthUrlResponse
     */
    public AuthUrlResponse authUrlWithOptions(AuthUrlRequest request, AuthUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

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
            new TeaPair("action", "AuthUrl"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/auths/url"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AuthUrlResponse());
    }

    /**
     * @summary 获取授权的页面地址
     *
     * @param request AuthUrlRequest
     * @return AuthUrlResponse
     */
    public AuthUrlResponse authUrl(AuthUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AuthUrlHeaders headers = new AuthUrlHeaders();
        return this.authUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 取消企业的授权
     *
     * @param headers CancelCorpAuthHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelCorpAuthResponse
     */
    public CancelCorpAuthResponse cancelCorpAuthWithOptions(CancelCorpAuthHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "CancelCorpAuth"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/corps/auth/cancel"),
            new TeaPair("method", "GET"),
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
     * @return CancelCorpAuthResponse
     */
    public CancelCorpAuthResponse cancelCorpAuth() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
        return this.cancelCorpAuthWithOptions(headers, runtime);
    }

    /**
     * @summary 套餐转售1（分润模式）
     *
     * @param request ChannelOrderRequest
     * @param headers ChannelOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChannelOrderResponse
     */
    public ChannelOrderResponse channelOrderWithOptions(ChannelOrderRequest request, ChannelOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ChannelOrder"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/orders/channel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChannelOrderResponse());
    }

    /**
     * @summary 套餐转售1（分润模式）
     *
     * @param request ChannelOrderRequest
     * @return ChannelOrderResponse
     */
    public ChannelOrderResponse channelOrder(ChannelOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChannelOrderHeaders headers = new ChannelOrderHeaders();
        return this.channelOrderWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询套餐余量
     *
     * @param headers ContractMarginHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ContractMarginResponse
     */
    public ContractMarginResponse contractMarginWithOptions(ContractMarginHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ContractMargin"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/contracts/margin"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ContractMarginResponse());
    }

    /**
     * @summary 查询套餐余量
     *
     * @return ContractMarginResponse
     */
    public ContractMarginResponse contractMargin() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ContractMarginHeaders headers = new ContractMarginHeaders();
        return this.contractMarginWithOptions(headers, runtime);
    }

    /**
     * @summary 查询个人信息
     *
     * @param headers CorpConsoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CorpConsoleResponse
     */
    public CorpConsoleResponse corpConsoleWithOptions(CorpConsoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "CorpConsole"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/corps/console"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CorpConsoleResponse());
    }

    /**
     * @summary 查询个人信息
     *
     * @return CorpConsoleResponse
     */
    public CorpConsoleResponse corpConsole() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CorpConsoleHeaders headers = new CorpConsoleHeaders();
        return this.corpConsoleWithOptions(headers, runtime);
    }

    /**
     * @summary 查询企业信息
     *
     * @param headers CorpInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CorpInfoResponse
     */
    public CorpInfoResponse corpInfoWithOptions(CorpInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "CorpInfo"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/corps/info"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CorpInfoResponse());
    }

    /**
     * @summary 查询企业信息
     *
     * @return CorpInfoResponse
     */
    public CorpInfoResponse corpInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CorpInfoHeaders headers = new CorpInfoHeaders();
        return this.corpInfoWithOptions(headers, runtime);
    }

    /**
     * @summary 钉钉ISV服务商的数据初始化
     *
     * @param request CreateDeveloperRequest
     * @param headers CreateDeveloperHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateDeveloperResponse
     */
    public CreateDeveloperResponse createDeveloperWithOptions(CreateDeveloperRequest request, CreateDeveloperHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

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
            new TeaPair("action", "CreateDeveloper"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/developers/create"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateDeveloperResponse());
    }

    /**
     * @summary 钉钉ISV服务商的数据初始化
     *
     * @param request CreateDeveloperRequest
     * @return CreateDeveloperResponse
     */
    public CreateDeveloperResponse createDeveloper(CreateDeveloperRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDeveloperHeaders headers = new CreateDeveloperHeaders();
        return this.createDeveloperWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取跳转到个人实名的地址
     *
     * @param request GetCorpRealnameUrlRequest
     * @param headers GetCorpRealnameUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCorpRealnameUrlResponse
     */
    public GetCorpRealnameUrlResponse getCorpRealnameUrlWithOptions(GetCorpRealnameUrlRequest request, GetCorpRealnameUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "GetCorpRealnameUrl"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/corps/realname"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCorpRealnameUrlResponse());
    }

    /**
     * @summary 获取跳转到个人实名的地址
     *
     * @param request GetCorpRealnameUrlRequest
     * @return GetCorpRealnameUrlResponse
     */
    public GetCorpRealnameUrlResponse getCorpRealnameUrl(GetCorpRealnameUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCorpRealnameUrlHeaders headers = new GetCorpRealnameUrlHeaders();
        return this.getCorpRealnameUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业e签宝微应用状态
     *
     * @param headers GetCropStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCropStatusResponse
     */
    public GetCropStatusResponse getCropStatusWithOptions(GetCropStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetCropStatus"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/corps/statuses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCropStatusResponse());
    }

    /**
     * @summary 获取企业e签宝微应用状态
     *
     * @return GetCropStatusResponse
     */
    public GetCropStatusResponse getCropStatus() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCropStatusHeaders headers = new GetCropStatusHeaders();
        return this.getCropStatusWithOptions(headers, runtime);
    }

    /**
     * @summary 查询文件详情/下载文件
     *
     * @param headers GetFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFileResponse
     */
    public GetFileResponse getFileWithOptions(String fileId, GetFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetFile"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/files/" + fileId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFileResponse());
    }

    /**
     * @summary 查询文件详情/下载文件
     *
     * @return GetFileResponse
     */
    public GetFileResponse getFile(String fileId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileHeaders headers = new GetFileHeaders();
        return this.getFileWithOptions(fileId, headers, runtime);
    }

    /**
     * @summary 获取对应流程任务详情
     *
     * @param request GetFlowDetailRequest
     * @param headers GetFlowDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFlowDetailResponse
     */
    public GetFlowDetailResponse getFlowDetailWithOptions(GetFlowDetailRequest request, GetFlowDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetFlowDetail"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/flows/detail"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFlowDetailResponse());
    }

    /**
     * @summary 获取对应流程任务详情
     *
     * @param request GetFlowDetailRequest
     * @return GetFlowDetailResponse
     */
    public GetFlowDetailResponse getFlowDetail(GetFlowDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
        return this.getFlowDetailWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取对应流程任务详情
     *
     * @param request GetFlowSignDetailRequest
     * @param headers GetFlowSignDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFlowSignDetailResponse
     */
    public GetFlowSignDetailResponse getFlowSignDetailWithOptions(GetFlowSignDetailRequest request, GetFlowSignDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetFlowSignDetail"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/flows/sign/detail"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFlowSignDetailResponse());
    }

    /**
     * @summary 获取对应流程任务详情
     *
     * @param request GetFlowSignDetailRequest
     * @return GetFlowSignDetailResponse
     */
    public GetFlowSignDetailResponse getFlowSignDetail(GetFlowSignDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFlowSignDetailHeaders headers = new GetFlowSignDetailHeaders();
        return this.getFlowSignDetailWithOptions(request, headers, runtime);
    }

    /**
     * @summary 发起签署的地址
     *
     * @param request GetProcessStartUrlRequest
     * @param headers GetProcessStartUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProcessStartUrlResponse
     */
    public GetProcessStartUrlResponse getProcessStartUrlWithOptions(GetProcessStartUrlRequest request, GetProcessStartUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetProcessStartUrl"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/process/start"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProcessStartUrlResponse());
    }

    /**
     * @summary 发起签署的地址
     *
     * @param request GetProcessStartUrlRequest
     * @return GetProcessStartUrlResponse
     */
    public GetProcessStartUrlResponse getProcessStartUrl(GetProcessStartUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProcessStartUrlHeaders headers = new GetProcessStartUrlHeaders();
        return this.getProcessStartUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取签署人签署地址
     *
     * @param request GetSignNoticeUrlRequest
     * @param headers GetSignNoticeUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSignNoticeUrlResponse
     */
    public GetSignNoticeUrlResponse getSignNoticeUrlWithOptions(GetSignNoticeUrlRequest request, GetSignNoticeUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetSignNoticeUrl"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/signs/notice/url"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSignNoticeUrlResponse());
    }

    /**
     * @summary 获取签署人签署地址
     *
     * @param request GetSignNoticeUrlRequest
     * @return GetSignNoticeUrlResponse
     */
    public GetSignNoticeUrlResponse getSignNoticeUrl(GetSignNoticeUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSignNoticeUrlHeaders headers = new GetSignNoticeUrlHeaders();
        return this.getSignNoticeUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 通过上传方式创建文件
     *
     * @param request GetUploadUrlRequest
     * @param headers GetUploadUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUploadUrlResponse
     */
    public GetUploadUrlResponse getUploadUrlWithOptions(GetUploadUrlRequest request, GetUploadUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUploadUrl"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/files/getUploadUrl"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUploadUrlResponse());
    }

    /**
     * @summary 通过上传方式创建文件
     *
     * @param request GetUploadUrlRequest
     * @return GetUploadUrlResponse
     */
    public GetUploadUrlResponse getUploadUrl(GetUploadUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUploadUrlHeaders headers = new GetUploadUrlHeaders();
        return this.getUploadUrlWithOptions(request, headers, runtime);
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

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUserInfo"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/users/" + userId + ""),
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
     * @summary 获取跳转到个人实名的地址
     *
     * @param request GetUserRealnameUrlRequest
     * @param headers GetUserRealnameUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserRealnameUrlResponse
     */
    public GetUserRealnameUrlResponse getUserRealnameUrlWithOptions(GetUserRealnameUrlRequest request, GetUserRealnameUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUserRealnameUrl"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/users/realname"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserRealnameUrlResponse());
    }

    /**
     * @summary 获取跳转到个人实名的地址
     *
     * @param request GetUserRealnameUrlRequest
     * @return GetUserRealnameUrlResponse
     */
    public GetUserRealnameUrlResponse getUserRealnameUrl(GetUserRealnameUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserRealnameUrlHeaders headers = new GetUserRealnameUrlHeaders();
        return this.getUserRealnameUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取流程任务合同列表
     *
     * @param request ListFlowDocsRequest
     * @param headers ListFlowDocsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListFlowDocsResponse
     */
    public ListFlowDocsResponse listFlowDocsWithOptions(ListFlowDocsRequest request, ListFlowDocsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListFlowDocs"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/flows/docs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListFlowDocsResponse());
    }

    /**
     * @summary 获取流程任务合同列表
     *
     * @param request ListFlowDocsRequest
     * @return ListFlowDocsResponse
     */
    public ListFlowDocsResponse listFlowDocs(ListFlowDocsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListFlowDocsHeaders headers = new ListFlowDocsHeaders();
        return this.listFlowDocsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取流程任务用印审批列表
     *
     * @param request ListSealApprovalRequest
     * @param headers ListSealApprovalHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListSealApprovalResponse
     */
    public ListSealApprovalResponse listSealApprovalWithOptions(ListSealApprovalRequest request, ListSealApprovalHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListSealApproval"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/seals/approval/list"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListSealApprovalResponse());
    }

    /**
     * @summary 获取流程任务用印审批列表
     *
     * @param request ListSealApprovalRequest
     * @return ListSealApprovalResponse
     */
    public ListSealApprovalResponse listSealApproval(ListSealApprovalRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSealApprovalHeaders headers = new ListSealApprovalHeaders();
        return this.listSealApprovalWithOptions(request, headers, runtime);
    }

    /**
     * @summary 套餐转售2（底价结算模式）
     *
     * @param request OrderResaleRequest
     * @param headers OrderResaleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OrderResaleResponse
     */
    public OrderResaleResponse orderResaleWithOptions(OrderResaleRequest request, OrderResaleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "OrderResale"),
            new TeaPair("version", "esign_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/esign/orders/resale"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OrderResaleResponse());
    }

    /**
     * @summary 套餐转售2（底价结算模式）
     *
     * @param request OrderResaleRequest
     * @return OrderResaleResponse
     */
    public OrderResaleResponse orderResale(OrderResaleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OrderResaleHeaders headers = new OrderResaleHeaders();
        return this.orderResaleWithOptions(request, headers, runtime);
    }
}
