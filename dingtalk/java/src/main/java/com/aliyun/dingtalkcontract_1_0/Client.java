// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcontract_1_0.models.*;

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
     * <p>取消审查工单接口</p>
     * 
     * @param request CancelReviewOrderRequest
     * @param headers CancelReviewOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelReviewOrderResponse
     */
    public CancelReviewOrderResponse cancelReviewOrderWithOptions(CancelReviewOrderRequest request, CancelReviewOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endFiles)) {
            body.put("endFiles", request.endFiles);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

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
            new TeaPair("action", "CancelReviewOrder"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/reviews/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelReviewOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>取消审查工单接口</p>
     * 
     * @param request CancelReviewOrderRequest
     * @return CancelReviewOrderResponse
     */
    public CancelReviewOrderResponse cancelReviewOrder(CancelReviewOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelReviewOrderHeaders headers = new CancelReviewOrderHeaders();
        return this.cancelReviewOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>合同权益核销</p>
     * 
     * @param request ContractBenefitConsumeRequest
     * @param headers ContractBenefitConsumeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ContractBenefitConsumeResponse
     */
    public ContractBenefitConsumeResponse contractBenefitConsumeWithOptions(ContractBenefitConsumeRequest request, ContractBenefitConsumeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.benefitPoint)) {
            body.put("benefitPoint", request.benefitPoint);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizRequestId)) {
            body.put("bizRequestId", request.bizRequestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.consumeQuota)) {
            body.put("consumeQuota", request.consumeQuota);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extParams)) {
            body.put("extParams", request.extParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCorpId)) {
            body.put("isvCorpId", request.isvCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUnionId)) {
            body.put("optUnionId", request.optUnionId);
        }

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
            new TeaPair("action", "ContractBenefitConsume"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/benefits/consume"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ContractBenefitConsumeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>合同权益核销</p>
     * 
     * @param request ContractBenefitConsumeRequest
     * @return ContractBenefitConsumeResponse
     */
    public ContractBenefitConsumeResponse contractBenefitConsume(ContractBenefitConsumeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ContractBenefitConsumeHeaders headers = new ContractBenefitConsumeHeaders();
        return this.contractBenefitConsumeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建合同比对任务</p>
     * 
     * @param request CreateContractCompareTaskRequest
     * @param headers CreateContractCompareTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateContractCompareTaskResponse
     */
    public CreateContractCompareTaskResponse createContractCompareTaskWithOptions(CreateContractCompareTaskRequest request, CreateContractCompareTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.comparativeFile)) {
            body.put("comparativeFile", request.comparativeFile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.comparativeFileDownloadUrl)) {
            body.put("comparativeFileDownloadUrl", request.comparativeFileDownloadUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.comparativeFileName)) {
            body.put("comparativeFileName", request.comparativeFileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSource)) {
            body.put("fileSource", request.fileSource);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("requestId", request.requestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.standardFile)) {
            body.put("standardFile", request.standardFile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.standardFileDownloadUrl)) {
            body.put("standardFileDownloadUrl", request.standardFileDownloadUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.standardFileName)) {
            body.put("standardFileName", request.standardFileName);
        }

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
            new TeaPair("action", "CreateContractCompareTask"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/comparisonTasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateContractCompareTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建合同比对任务</p>
     * 
     * @param request CreateContractCompareTaskRequest
     * @return CreateContractCompareTaskResponse
     */
    public CreateContractCompareTaskResponse createContractCompareTask(CreateContractCompareTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateContractCompareTaskHeaders headers = new CreateContractCompareTaskHeaders();
        return this.createContractCompareTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建合同提取任务</p>
     * 
     * @param request CreateContractExtractTaskRequest
     * @param headers CreateContractExtractTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateContractExtractTaskResponse
     */
    public CreateContractExtractTaskResponse createContractExtractTaskWithOptions(CreateContractExtractTaskRequest request, CreateContractExtractTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.contractFile)) {
            body.put("contractFile", request.contractFile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contractFileDownloadUrl)) {
            body.put("contractFileDownloadUrl", request.contractFileDownloadUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contractFileName)) {
            body.put("contractFileName", request.contractFileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extractKeys)) {
            body.put("extractKeys", request.extractKeys);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSource)) {
            body.put("fileSource", request.fileSource);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("requestId", request.requestId);
        }

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
            new TeaPair("action", "CreateContractExtractTask"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/extractTasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateContractExtractTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建合同提取任务</p>
     * 
     * @param request CreateContractExtractTaskRequest
     * @return CreateContractExtractTaskResponse
     */
    public CreateContractExtractTaskResponse createContractExtractTask(CreateContractExtractTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateContractExtractTaskHeaders headers = new CreateContractExtractTaskHeaders();
        return this.createContractExtractTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建合同审查任务</p>
     * 
     * @param request CreateContractReviewTaskRequest
     * @param headers CreateContractReviewTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateContractReviewTaskResponse
     */
    public CreateContractReviewTaskResponse createContractReviewTaskWithOptions(CreateContractReviewTaskRequest request, CreateContractReviewTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.contractFile)) {
            body.put("contractFile", request.contractFile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contractFileDownloadUrl)) {
            body.put("contractFileDownloadUrl", request.contractFileDownloadUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contractFileName)) {
            body.put("contractFileName", request.contractFileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSource)) {
            body.put("fileSource", request.fileSource);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("requestId", request.requestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reviewCustomRules)) {
            body.put("reviewCustomRules", request.reviewCustomRules);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ruleType)) {
            body.put("ruleType", request.ruleType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.standpoint)) {
            body.put("standpoint", request.standpoint);
        }

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
            new TeaPair("action", "CreateContractReviewTask"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/reviewTasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateContractReviewTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建合同审查任务</p>
     * 
     * @param request CreateContractReviewTaskRequest
     * @return CreateContractReviewTaskResponse
     */
    public CreateContractReviewTaskResponse createContractReviewTask(CreateContractReviewTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateContractReviewTaskHeaders headers = new CreateContractReviewTaskHeaders();
        return this.createContractReviewTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>天谷侧查询审批单</p>
     * 
     * @param request EsignQueryApprovalInfoRequest
     * @param headers EsignQueryApprovalInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EsignQueryApprovalInfoResponse
     */
    public EsignQueryApprovalInfoResponse esignQueryApprovalInfoWithOptions(EsignQueryApprovalInfoRequest request, EsignQueryApprovalInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.esignFlowId)) {
            body.put("esignFlowId", request.esignFlowId);
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
            new TeaPair("action", "EsignQueryApprovalInfo"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/esign/approvalInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EsignQueryApprovalInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>天谷侧查询审批单</p>
     * 
     * @param request EsignQueryApprovalInfoRequest
     * @return EsignQueryApprovalInfoResponse
     */
    public EsignQueryApprovalInfoResponse esignQueryApprovalInfo(EsignQueryApprovalInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EsignQueryApprovalInfoHeaders headers = new EsignQueryApprovalInfoHeaders();
        return this.esignQueryApprovalInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>天谷侧查询授权信息接口</p>
     * 
     * @param request EsignQueryGrantInfoRequest
     * @param headers EsignQueryGrantInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EsignQueryGrantInfoResponse
     */
    public EsignQueryGrantInfoResponse esignQueryGrantInfoWithOptions(EsignQueryGrantInfoRequest request, EsignQueryGrantInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
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
            new TeaPair("action", "EsignQueryGrantInfo"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/esign/anthInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EsignQueryGrantInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>天谷侧查询授权信息接口</p>
     * 
     * @param request EsignQueryGrantInfoRequest
     * @return EsignQueryGrantInfoResponse
     */
    public EsignQueryGrantInfoResponse esignQueryGrantInfo(EsignQueryGrantInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EsignQueryGrantInfoHeaders headers = new EsignQueryGrantInfoHeaders();
        return this.esignQueryGrantInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>天谷侧查询获取免登信息</p>
     * 
     * @param request EsignQueryIdentityByTicketRequest
     * @param headers EsignQueryIdentityByTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EsignQueryIdentityByTicketResponse
     */
    public EsignQueryIdentityByTicketResponse esignQueryIdentityByTicketWithOptions(EsignQueryIdentityByTicketRequest request, EsignQueryIdentityByTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ticket)) {
            body.put("ticket", request.ticket);
        }

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
            new TeaPair("action", "EsignQueryIdentityByTicket"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/esign/tickets/identities/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EsignQueryIdentityByTicketResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>天谷侧查询获取免登信息</p>
     * 
     * @param request EsignQueryIdentityByTicketRequest
     * @return EsignQueryIdentityByTicketResponse
     */
    public EsignQueryIdentityByTicketResponse esignQueryIdentityByTicket(EsignQueryIdentityByTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EsignQueryIdentityByTicketHeaders headers = new EsignQueryIdentityByTicketHeaders();
        return this.esignQueryIdentityByTicketWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>e签宝电子签事件同步回传接口</p>
     * 
     * @param request EsignSyncEventRequest
     * @param headers EsignSyncEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EsignSyncEventResponse
     */
    public EsignSyncEventResponse esignSyncEventWithOptions(EsignSyncEventRequest request, EsignSyncEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.esignData)) {
            body.put("esignData", request.esignData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
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
            new TeaPair("action", "EsignSyncEvent"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/esign/events/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EsignSyncEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>e签宝电子签事件同步回传接口</p>
     * 
     * @param request EsignSyncEventRequest
     * @return EsignSyncEventResponse
     */
    public EsignSyncEventResponse esignSyncEvent(EsignSyncEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EsignSyncEventHeaders headers = new EsignSyncEventHeaders();
        return this.esignSyncEventWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>校验钉钉用户能否访问e签宝页面接口</p>
     * 
     * @param request EsignUserVerifyRequest
     * @param headers EsignUserVerifyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EsignUserVerifyResponse
     */
    public EsignUserVerifyResponse esignUserVerifyWithOptions(EsignUserVerifyRequest request, EsignUserVerifyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
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
            new TeaPair("action", "EsignUserVerify"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/esign/user/verify"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EsignUserVerifyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>校验钉钉用户能否访问e签宝页面接口</p>
     * 
     * @param request EsignUserVerifyRequest
     * @return EsignUserVerifyResponse
     */
    public EsignUserVerifyResponse esignUserVerify(EsignUserVerifyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EsignUserVerifyHeaders headers = new EsignUserVerifyHeaders();
        return this.esignUserVerifyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>完成工单审查接口</p>
     * 
     * @param request FinishReviewOrderRequest
     * @param headers FinishReviewOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FinishReviewOrderResponse
     */
    public FinishReviewOrderResponse finishReviewOrderWithOptions(FinishReviewOrderRequest request, FinishReviewOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endFiles)) {
            body.put("endFiles", request.endFiles);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

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
            new TeaPair("action", "FinishReviewOrder"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/reviews/finish"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FinishReviewOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>完成工单审查接口</p>
     * 
     * @param request FinishReviewOrderRequest
     * @return FinishReviewOrderResponse
     */
    public FinishReviewOrderResponse finishReviewOrder(FinishReviewOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FinishReviewOrderHeaders headers = new FinishReviewOrderHeaders();
        return this.finishReviewOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>e签宝查询智能合同版本接口</p>
     * 
     * @param request QueryAdvancedContractVersionRequest
     * @param headers QueryAdvancedContractVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAdvancedContractVersionResponse
     */
    public QueryAdvancedContractVersionResponse queryAdvancedContractVersionWithOptions(QueryAdvancedContractVersionRequest request, QueryAdvancedContractVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

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
            new TeaPair("action", "QueryAdvancedContractVersion"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/versions/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAdvancedContractVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>e签宝查询智能合同版本接口</p>
     * 
     * @param request QueryAdvancedContractVersionRequest
     * @return QueryAdvancedContractVersionResponse
     */
    public QueryAdvancedContractVersionResponse queryAdvancedContractVersion(QueryAdvancedContractVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAdvancedContractVersionHeaders headers = new QueryAdvancedContractVersionHeaders();
        return this.queryAdvancedContractVersionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询合同比对结果</p>
     * 
     * @param request QueryContractCompareResultRequest
     * @param headers QueryContractCompareResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryContractCompareResultResponse
     */
    public QueryContractCompareResultResponse queryContractCompareResultWithOptions(QueryContractCompareResultRequest request, QueryContractCompareResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.compareTaskId)) {
            body.put("compareTaskId", request.compareTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("requestId", request.requestId);
        }

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
            new TeaPair("action", "QueryContractCompareResult"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/comparisonResults/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryContractCompareResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询合同比对结果</p>
     * 
     * @param request QueryContractCompareResultRequest
     * @return QueryContractCompareResultResponse
     */
    public QueryContractCompareResultResponse queryContractCompareResult(QueryContractCompareResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryContractCompareResultHeaders headers = new QueryContractCompareResultHeaders();
        return this.queryContractCompareResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询合同提取结果</p>
     * 
     * @param request QueryContractExtractResultRequest
     * @param headers QueryContractExtractResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryContractExtractResultResponse
     */
    public QueryContractExtractResultResponse queryContractExtractResultWithOptions(QueryContractExtractResultRequest request, QueryContractExtractResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.extractTaskId)) {
            body.put("extractTaskId", request.extractTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("requestId", request.requestId);
        }

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
            new TeaPair("action", "QueryContractExtractResult"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/extractResults/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryContractExtractResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询合同提取结果</p>
     * 
     * @param request QueryContractExtractResultRequest
     * @return QueryContractExtractResultResponse
     */
    public QueryContractExtractResultResponse queryContractExtractResult(QueryContractExtractResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryContractExtractResultHeaders headers = new QueryContractExtractResultHeaders();
        return this.queryContractExtractResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询合同审查结果</p>
     * 
     * @param request QueryContractReviewResultRequest
     * @param headers QueryContractReviewResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryContractReviewResultResponse
     */
    public QueryContractReviewResultResponse queryContractReviewResultWithOptions(QueryContractReviewResultRequest request, QueryContractReviewResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("requestId", request.requestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reviewTaskId)) {
            body.put("reviewTaskId", request.reviewTaskId);
        }

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
            new TeaPair("action", "QueryContractReviewResult"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/reviewResults/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryContractReviewResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询合同审查结果</p>
     * 
     * @param request QueryContractReviewResultRequest
     * @return QueryContractReviewResultResponse
     */
    public QueryContractReviewResultResponse queryContractReviewResult(QueryContractReviewResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryContractReviewResultHeaders headers = new QueryContractReviewResultHeaders();
        return this.queryContractReviewResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发送合同相关卡片</p>
     * 
     * @param request SendContractCardRequest
     * @param headers SendContractCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendContractCardResponse
     */
    public SendContractCardResponse sendContractCardWithOptions(SendContractCardRequest request, SendContractCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardType)) {
            body.put("cardType", request.cardType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contractInfo)) {
            body.put("contractInfo", request.contractInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiveGroups)) {
            body.put("receiveGroups", request.receiveGroups);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receivers)) {
            body.put("receivers", request.receivers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sender)) {
            body.put("sender", request.sender);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.syncSingleChat)) {
            body.put("syncSingleChat", request.syncSingleChat);
        }

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
            new TeaPair("action", "SendContractCard"),
            new TeaPair("version", "contract_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contract/cards/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendContractCardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发送合同相关卡片</p>
     * 
     * @param request SendContractCardRequest
     * @return SendContractCardResponse
     */
    public SendContractCardResponse sendContractCard(SendContractCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendContractCardHeaders headers = new SendContractCardHeaders();
        return this.sendContractCardWithOptions(request, headers, runtime);
    }
}
