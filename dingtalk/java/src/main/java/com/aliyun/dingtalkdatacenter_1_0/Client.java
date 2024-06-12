// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdatacenter_1_0.models.*;

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
     * @summary 创建数据投递
     *
     * @param request CreateDataDeliverRequest
     * @param headers CreateDataDeliverHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateDataDeliverResponse
     */
    public CreateDataDeliverResponse createDataDeliverWithOptions(CreateDataDeliverRequest request, CreateDataDeliverHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizcode)) {
            query.put("bizcode", request.bizcode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dispatchingCycle)) {
            query.put("dispatchingCycle", request.dispatchingCycle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dispatchingItemType)) {
            query.put("dispatchingItemType", request.dispatchingItemType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dispatchingStartDate)) {
            query.put("dispatchingStartDate", request.dispatchingStartDate);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateDataDeliver"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/dataDeliveries"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateDataDeliverResponse());
    }

    /**
     * @summary 创建数据投递
     *
     * @param request CreateDataDeliverRequest
     * @return CreateDataDeliverResponse
     */
    public CreateDataDeliverResponse createDataDeliver(CreateDataDeliverRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDataDeliverHeaders headers = new CreateDataDeliverHeaders();
        return this.createDataDeliverWithOptions(request, headers, runtime);
    }

    /**
     * @summary 工商-经营异常
     *
     * @param request GetAbnormalOperationRequest
     * @param headers GetAbnormalOperationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAbnormalOperationResponse
     */
    public GetAbnormalOperationResponse getAbnormalOperationWithOptions(GetAbnormalOperationRequest request, GetAbnormalOperationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetAbnormalOperation"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/abnormalOperations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAbnormalOperationResponse());
    }

    /**
     * @summary 工商-经营异常
     *
     * @param request GetAbnormalOperationRequest
     * @return GetAbnormalOperationResponse
     */
    public GetAbnormalOperationResponse getAbnormalOperation(GetAbnormalOperationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAbnormalOperationHeaders headers = new GetAbnormalOperationHeaders();
        return this.getAbnormalOperationWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取工商-行政许可
     *
     * @param request GetAdministrativeLicensingRequest
     * @param headers GetAdministrativeLicensingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAdministrativeLicensingResponse
     */
    public GetAdministrativeLicensingResponse getAdministrativeLicensingWithOptions(GetAdministrativeLicensingRequest request, GetAdministrativeLicensingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetAdministrativeLicensing"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/administrativeLicenses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAdministrativeLicensingResponse());
    }

    /**
     * @summary 获取工商-行政许可
     *
     * @param request GetAdministrativeLicensingRequest
     * @return GetAdministrativeLicensingResponse
     */
    public GetAdministrativeLicensingResponse getAdministrativeLicensing(GetAdministrativeLicensingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAdministrativeLicensingHeaders headers = new GetAdministrativeLicensingHeaders();
        return this.getAdministrativeLicensingWithOptions(request, headers, runtime);
    }

    /**
     * @summary 负面-行政处罚
     *
     * @param request GetAdministrativePenaltiesRequest
     * @param headers GetAdministrativePenaltiesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAdministrativePenaltiesResponse
     */
    public GetAdministrativePenaltiesResponse getAdministrativePenaltiesWithOptions(GetAdministrativePenaltiesRequest request, GetAdministrativePenaltiesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetAdministrativePenalties"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/administrativePenalties"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAdministrativePenaltiesResponse());
    }

    /**
     * @summary 负面-行政处罚
     *
     * @param request GetAdministrativePenaltiesRequest
     * @return GetAdministrativePenaltiesResponse
     */
    public GetAdministrativePenaltiesResponse getAdministrativePenalties(GetAdministrativePenaltiesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAdministrativePenaltiesHeaders headers = new GetAdministrativePenaltiesHeaders();
        return this.getAdministrativePenaltiesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 工商-基础信息
     *
     * @param request GetBasicInfoRequest
     * @param headers GetBasicInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetBasicInfoResponse
     */
    public GetBasicInfoResponse getBasicInfoWithOptions(GetBasicInfoRequest request, GetBasicInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetBasicInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/businessBasicInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetBasicInfoResponse());
    }

    /**
     * @summary 工商-基础信息
     *
     * @param request GetBasicInfoRequest
     * @return GetBasicInfoResponse
     */
    public GetBasicInfoResponse getBasicInfo(GetBasicInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetBasicInfoHeaders headers = new GetBasicInfoHeaders();
        return this.getBasicInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取经营-招投标信息
     *
     * @param request GetBiddingInfoRequest
     * @param headers GetBiddingInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetBiddingInfoResponse
     */
    public GetBiddingInfoResponse getBiddingInfoWithOptions(GetBiddingInfoRequest request, GetBiddingInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetBiddingInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/biddingInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetBiddingInfoResponse());
    }

    /**
     * @summary 获取经营-招投标信息
     *
     * @param request GetBiddingInfoRequest
     * @return GetBiddingInfoResponse
     */
    public GetBiddingInfoResponse getBiddingInfo(GetBiddingInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetBiddingInfoHeaders headers = new GetBiddingInfoHeaders();
        return this.getBiddingInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取工商-分支机构
     *
     * @param request GetBranchInfoRequest
     * @param headers GetBranchInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetBranchInfoResponse
     */
    public GetBranchInfoResponse getBranchInfoWithOptions(GetBranchInfoRequest request, GetBranchInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetBranchInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/branchInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetBranchInfoResponse());
    }

    /**
     * @summary 获取工商-分支机构
     *
     * @param request GetBranchInfoRequest
     * @return GetBranchInfoResponse
     */
    public GetBranchInfoResponse getBranchInfo(GetBranchInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetBranchInfoHeaders headers = new GetBranchInfoHeaders();
        return this.getBranchInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取工商-变更记录
     *
     * @param request GetChangeRecordRequest
     * @param headers GetChangeRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetChangeRecordResponse
     */
    public GetChangeRecordResponse getChangeRecordWithOptions(GetChangeRecordRequest request, GetChangeRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetChangeRecord"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/changeRecords"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetChangeRecordResponse());
    }

    /**
     * @summary 获取工商-变更记录
     *
     * @param request GetChangeRecordRequest
     * @return GetChangeRecordResponse
     */
    public GetChangeRecordResponse getChangeRecord(GetChangeRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetChangeRecordHeaders headers = new GetChangeRecordHeaders();
        return this.getChangeRecordWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取知识产权-域名信息
     *
     * @param request GetDomainInfoRequest
     * @param headers GetDomainInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDomainInfoResponse
     */
    public GetDomainInfoResponse getDomainInfoWithOptions(GetDomainInfoRequest request, GetDomainInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetDomainInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/domainInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDomainInfoResponse());
    }

    /**
     * @summary 获取知识产权-域名信息
     *
     * @param request GetDomainInfoRequest
     * @return GetDomainInfoResponse
     */
    public GetDomainInfoResponse getDomainInfo(GetDomainInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDomainInfoHeaders headers = new GetDomainInfoHeaders();
        return this.getDomainInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取工商-双随机抽查结果
     *
     * @param request GetDoubleRandomRequest
     * @param headers GetDoubleRandomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDoubleRandomResponse
     */
    public GetDoubleRandomResponse getDoubleRandomWithOptions(GetDoubleRandomRequest request, GetDoubleRandomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetDoubleRandom"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/doubleRandomness"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDoubleRandomResponse());
    }

    /**
     * @summary 获取工商-双随机抽查结果
     *
     * @param request GetDoubleRandomRequest
     * @return GetDoubleRandomResponse
     */
    public GetDoubleRandomResponse getDoubleRandom(GetDoubleRandomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDoubleRandomHeaders headers = new GetDoubleRandomHeaders();
        return this.getDoubleRandomWithOptions(request, headers, runtime);
    }

    /**
     * @summary 负面-环保处罚
     *
     * @param request GetEnvironmentalPenaltiesRequest
     * @param headers GetEnvironmentalPenaltiesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetEnvironmentalPenaltiesResponse
     */
    public GetEnvironmentalPenaltiesResponse getEnvironmentalPenaltiesWithOptions(GetEnvironmentalPenaltiesRequest request, GetEnvironmentalPenaltiesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetEnvironmentalPenalties"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/environmentalPenalties"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetEnvironmentalPenaltiesResponse());
    }

    /**
     * @summary 负面-环保处罚
     *
     * @param request GetEnvironmentalPenaltiesRequest
     * @return GetEnvironmentalPenaltiesResponse
     */
    public GetEnvironmentalPenaltiesResponse getEnvironmentalPenalties(GetEnvironmentalPenaltiesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEnvironmentalPenaltiesHeaders headers = new GetEnvironmentalPenaltiesHeaders();
        return this.getEnvironmentalPenaltiesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取事件订阅的数据
     *
     * @param request GetEventDataRequest
     * @param headers GetEventDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetEventDataResponse
     */
    public GetEventDataResponse getEventDataWithOptions(GetEventDataRequest request, GetEventDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventUid)) {
            body.put("eventUid", request.eventUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subId)) {
            body.put("subId", request.subId);
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
            new TeaPair("action", "GetEventData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/eventDatas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetEventDataResponse());
    }

    /**
     * @summary 获取事件订阅的数据
     *
     * @param request GetEventDataRequest
     * @return GetEventDataResponse
     */
    public GetEventDataResponse getEventData(GetEventDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEventDataHeaders headers = new GetEventDataHeaders();
        return this.getEventDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 工商-股东信息
     *
     * @param request GetHolderInfoRequest
     * @param headers GetHolderInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetHolderInfoResponse
     */
    public GetHolderInfoResponse getHolderInfoWithOptions(GetHolderInfoRequest request, GetHolderInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetHolderInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/shareholderInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetHolderInfoResponse());
    }

    /**
     * @summary 工商-股东信息
     *
     * @param request GetHolderInfoRequest
     * @return GetHolderInfoResponse
     */
    public GetHolderInfoResponse getHolderInfo(GetHolderInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetHolderInfoHeaders headers = new GetHolderInfoHeaders();
        return this.getHolderInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取工商-知识产权出质
     *
     * @param request GetIntellectualPropertyRequest
     * @param headers GetIntellectualPropertyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetIntellectualPropertyResponse
     */
    public GetIntellectualPropertyResponse getIntellectualPropertyWithOptions(GetIntellectualPropertyRequest request, GetIntellectualPropertyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetIntellectualProperty"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/intellectualProperties"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetIntellectualPropertyResponse());
    }

    /**
     * @summary 获取工商-知识产权出质
     *
     * @param request GetIntellectualPropertyRequest
     * @return GetIntellectualPropertyResponse
     */
    public GetIntellectualPropertyResponse getIntellectualProperty(GetIntellectualPropertyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetIntellectualPropertyHeaders headers = new GetIntellectualPropertyHeaders();
        return this.getIntellectualPropertyWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取工商-对外投资
     *
     * @param request GetInvestmentAbroadRequest
     * @param headers GetInvestmentAbroadHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetInvestmentAbroadResponse
     */
    public GetInvestmentAbroadResponse getInvestmentAbroadWithOptions(GetInvestmentAbroadRequest request, GetInvestmentAbroadHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetInvestmentAbroad"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/abroadInvestments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetInvestmentAbroadResponse());
    }

    /**
     * @summary 获取工商-对外投资
     *
     * @param request GetInvestmentAbroadRequest
     * @return GetInvestmentAbroadResponse
     */
    public GetInvestmentAbroadResponse getInvestmentAbroad(GetInvestmentAbroadRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInvestmentAbroadHeaders headers = new GetInvestmentAbroadHeaders();
        return this.getInvestmentAbroadWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取经营-招聘信息
     *
     * @param request GetJobInfoRequest
     * @param headers GetJobInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetJobInfoResponse
     */
    public GetJobInfoResponse getJobInfoWithOptions(GetJobInfoRequest request, GetJobInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetJobInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/jobInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetJobInfoResponse());
    }

    /**
     * @summary 获取经营-招聘信息
     *
     * @param request GetJobInfoRequest
     * @return GetJobInfoResponse
     */
    public GetJobInfoResponse getJobInfo(GetJobInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetJobInfoHeaders headers = new GetJobInfoHeaders();
        return this.getJobInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取知识产权-专利信息
     *
     * @param request GetPatentInfoRequest
     * @param headers GetPatentInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPatentInfoResponse
     */
    public GetPatentInfoResponse getPatentInfoWithOptions(GetPatentInfoRequest request, GetPatentInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetPatentInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/patentInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPatentInfoResponse());
    }

    /**
     * @summary 获取知识产权-专利信息
     *
     * @param request GetPatentInfoRequest
     * @return GetPatentInfoResponse
     */
    public GetPatentInfoResponse getPatentInfo(GetPatentInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPatentInfoHeaders headers = new GetPatentInfoHeaders();
        return this.getPatentInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取工商-主要人员
     *
     * @param request GetPrincipalEmployeeRequest
     * @param headers GetPrincipalEmployeeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPrincipalEmployeeResponse
     */
    public GetPrincipalEmployeeResponse getPrincipalEmployeeWithOptions(GetPrincipalEmployeeRequest request, GetPrincipalEmployeeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetPrincipalEmployee"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/principalEmployees"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPrincipalEmployeeResponse());
    }

    /**
     * @summary 获取工商-主要人员
     *
     * @param request GetPrincipalEmployeeRequest
     * @return GetPrincipalEmployeeResponse
     */
    public GetPrincipalEmployeeResponse getPrincipalEmployee(GetPrincipalEmployeeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPrincipalEmployeeHeaders headers = new GetPrincipalEmployeeHeaders();
        return this.getPrincipalEmployeeWithOptions(request, headers, runtime);
    }

    /**
     * @summary 经营-一般纳税人
     *
     * @param request GetQeneralTaxpayerInfoRequest
     * @param headers GetQeneralTaxpayerInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetQeneralTaxpayerInfoResponse
     */
    public GetQeneralTaxpayerInfoResponse getQeneralTaxpayerInfoWithOptions(GetQeneralTaxpayerInfoRequest request, GetQeneralTaxpayerInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetQeneralTaxpayerInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/generalTaxpayerInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetQeneralTaxpayerInfoResponse());
    }

    /**
     * @summary 经营-一般纳税人
     *
     * @param request GetQeneralTaxpayerInfoRequest
     * @return GetQeneralTaxpayerInfoResponse
     */
    public GetQeneralTaxpayerInfoResponse getQeneralTaxpayerInfo(GetQeneralTaxpayerInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetQeneralTaxpayerInfoHeaders headers = new GetQeneralTaxpayerInfoHeaders();
        return this.getQeneralTaxpayerInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取知识产权-资质证书
     *
     * @param request GetQualificationCertRequest
     * @param headers GetQualificationCertHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetQualificationCertResponse
     */
    public GetQualificationCertResponse getQualificationCertWithOptions(GetQualificationCertRequest request, GetQualificationCertHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetQualificationCert"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/qualificationCerts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetQualificationCertResponse());
    }

    /**
     * @summary 获取知识产权-资质证书
     *
     * @param request GetQualificationCertRequest
     * @return GetQualificationCertResponse
     */
    public GetQualificationCertResponse getQualificationCert(GetQualificationCertRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetQualificationCertHeaders headers = new GetQualificationCertHeaders();
        return this.getQualificationCertWithOptions(request, headers, runtime);
    }

    /**
     * @summary 负面-严重违法
     *
     * @param request GetSeriousViolationRequest
     * @param headers GetSeriousViolationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSeriousViolationResponse
     */
    public GetSeriousViolationResponse getSeriousViolationWithOptions(GetSeriousViolationRequest request, GetSeriousViolationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetSeriousViolation"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/seriousViolations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSeriousViolationResponse());
    }

    /**
     * @summary 负面-严重违法
     *
     * @param request GetSeriousViolationRequest
     * @return GetSeriousViolationResponse
     */
    public GetSeriousViolationResponse getSeriousViolation(GetSeriousViolationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSeriousViolationHeaders headers = new GetSeriousViolationHeaders();
        return this.getSeriousViolationWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取知识产权-软件著作权
     *
     * @param request GetSoftwareCopyrightRequest
     * @param headers GetSoftwareCopyrightHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSoftwareCopyrightResponse
     */
    public GetSoftwareCopyrightResponse getSoftwareCopyrightWithOptions(GetSoftwareCopyrightRequest request, GetSoftwareCopyrightHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetSoftwareCopyright"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/softwareCopyrights"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSoftwareCopyrightResponse());
    }

    /**
     * @summary 获取知识产权-软件著作权
     *
     * @param request GetSoftwareCopyrightRequest
     * @return GetSoftwareCopyrightResponse
     */
    public GetSoftwareCopyrightResponse getSoftwareCopyright(GetSoftwareCopyrightRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSoftwareCopyrightHeaders headers = new GetSoftwareCopyrightHeaders();
        return this.getSoftwareCopyrightWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取知识产权-商标信息
     *
     * @param request GetTrademarkInfoRequest
     * @param headers GetTrademarkInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTrademarkInfoResponse
     */
    public GetTrademarkInfoResponse getTrademarkInfoWithOptions(GetTrademarkInfoRequest request, GetTrademarkInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetTrademarkInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/trademarkInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTrademarkInfoResponse());
    }

    /**
     * @summary 获取知识产权-商标信息
     *
     * @param request GetTrademarkInfoRequest
     * @return GetTrademarkInfoResponse
     */
    public GetTrademarkInfoResponse getTrademarkInfo(GetTrademarkInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTrademarkInfoHeaders headers = new GetTrademarkInfoHeaders();
        return this.getTrademarkInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取知识产权-作品著作权
     *
     * @param request GetWorkCopyrightRequest
     * @param headers GetWorkCopyrightHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetWorkCopyrightResponse
     */
    public GetWorkCopyrightResponse getWorkCopyrightWithOptions(GetWorkCopyrightRequest request, GetWorkCopyrightHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "GetWorkCopyright"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/workCopyrights"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetWorkCopyrightResponse());
    }

    /**
     * @summary 获取知识产权-作品著作权
     *
     * @param request GetWorkCopyrightRequest
     * @return GetWorkCopyrightResponse
     */
    public GetWorkCopyrightResponse getWorkCopyright(GetWorkCopyrightRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetWorkCopyrightHeaders headers = new GetWorkCopyrightHeaders();
        return this.getWorkCopyrightWithOptions(request, headers, runtime);
    }

    /**
     * @summary 企业授权信息
     *
     * @param headers PostCorpAuthInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PostCorpAuthInfoResponse
     */
    public PostCorpAuthInfoResponse postCorpAuthInfoWithOptions(PostCorpAuthInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "PostCorpAuthInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/corporations/authorize"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PostCorpAuthInfoResponse());
    }

    /**
     * @summary 企业授权信息
     *
     * @return PostCorpAuthInfoResponse
     */
    public PostCorpAuthInfoResponse postCorpAuthInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PostCorpAuthInfoHeaders headers = new PostCorpAuthInfoHeaders();
        return this.postCorpAuthInfoWithOptions(headers, runtime);
    }

    /**
     * @summary 获取企业用户激活状态统计数据
     *
     * @param request QueryActiveUserStatisticalDataRequest
     * @param headers QueryActiveUserStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryActiveUserStatisticalDataResponse
     */
    public QueryActiveUserStatisticalDataResponse queryActiveUserStatisticalDataWithOptions(QueryActiveUserStatisticalDataRequest request, QueryActiveUserStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryActiveUserStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/activeUserData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryActiveUserStatisticalDataResponse());
    }

    /**
     * @summary 获取企业用户激活状态统计数据
     *
     * @param request QueryActiveUserStatisticalDataRequest
     * @return QueryActiveUserStatisticalDataResponse
     */
    public QueryActiveUserStatisticalDataResponse queryActiveUserStatisticalData(QueryActiveUserStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryActiveUserStatisticalDataHeaders headers = new QueryActiveUserStatisticalDataHeaders();
        return this.queryActiveUserStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取安恒密盾统计数据
     *
     * @param request QueryAnhmdStatisticalDataRequest
     * @param headers QueryAnhmdStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAnhmdStatisticalDataResponse
     */
    public QueryAnhmdStatisticalDataResponse queryAnhmdStatisticalDataWithOptions(QueryAnhmdStatisticalDataRequest request, QueryAnhmdStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryAnhmdStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/statisticDatas/anHmd"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAnhmdStatisticalDataResponse());
    }

    /**
     * @summary 获取安恒密盾统计数据
     *
     * @param request QueryAnhmdStatisticalDataRequest
     * @return QueryAnhmdStatisticalDataResponse
     */
    public QueryAnhmdStatisticalDataResponse queryAnhmdStatisticalData(QueryAnhmdStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAnhmdStatisticalDataHeaders headers = new QueryAnhmdStatisticalDataHeaders();
        return this.queryAnhmdStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业审批统计数据
     *
     * @param request QueryApprovalStatisticalDataRequest
     * @param headers QueryApprovalStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryApprovalStatisticalDataResponse
     */
    public QueryApprovalStatisticalDataResponse queryApprovalStatisticalDataWithOptions(QueryApprovalStatisticalDataRequest request, QueryApprovalStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryApprovalStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/approvalData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryApprovalStatisticalDataResponse());
    }

    /**
     * @summary 获取企业审批统计数据
     *
     * @param request QueryApprovalStatisticalDataRequest
     * @return QueryApprovalStatisticalDataResponse
     */
    public QueryApprovalStatisticalDataResponse queryApprovalStatisticalData(QueryApprovalStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryApprovalStatisticalDataHeaders headers = new QueryApprovalStatisticalDataHeaders();
        return this.queryApprovalStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业考勤统计数据
     *
     * @param request QueryAttendanceStatisticalDataRequest
     * @param headers QueryAttendanceStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAttendanceStatisticalDataResponse
     */
    public QueryAttendanceStatisticalDataResponse queryAttendanceStatisticalDataWithOptions(QueryAttendanceStatisticalDataRequest request, QueryAttendanceStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryAttendanceStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/attendanceData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAttendanceStatisticalDataResponse());
    }

    /**
     * @summary 获取企业考勤统计数据
     *
     * @param request QueryAttendanceStatisticalDataRequest
     * @return QueryAttendanceStatisticalDataResponse
     */
    public QueryAttendanceStatisticalDataResponse queryAttendanceStatisticalData(QueryAttendanceStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAttendanceStatisticalDataHeaders headers = new QueryAttendanceStatisticalDataHeaders();
        return this.queryAttendanceStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业公告统计数据
     *
     * @param request QueryBlackboardStatisticalDataRequest
     * @param headers QueryBlackboardStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryBlackboardStatisticalDataResponse
     */
    public QueryBlackboardStatisticalDataResponse queryBlackboardStatisticalDataWithOptions(QueryBlackboardStatisticalDataRequest request, QueryBlackboardStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryBlackboardStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/blackboardData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryBlackboardStatisticalDataResponse());
    }

    /**
     * @summary 获取企业公告统计数据
     *
     * @param request QueryBlackboardStatisticalDataRequest
     * @return QueryBlackboardStatisticalDataResponse
     */
    public QueryBlackboardStatisticalDataResponse queryBlackboardStatisticalData(QueryBlackboardStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBlackboardStatisticalDataHeaders headers = new QueryBlackboardStatisticalDataHeaders();
        return this.queryBlackboardStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业日程统计数据
     *
     * @param request QueryCalendarStatisticalDataRequest
     * @param headers QueryCalendarStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCalendarStatisticalDataResponse
     */
    public QueryCalendarStatisticalDataResponse queryCalendarStatisticalDataWithOptions(QueryCalendarStatisticalDataRequest request, QueryCalendarStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryCalendarStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/calendarData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCalendarStatisticalDataResponse());
    }

    /**
     * @summary 获取企业日程统计数据
     *
     * @param request QueryCalendarStatisticalDataRequest
     * @return QueryCalendarStatisticalDataResponse
     */
    public QueryCalendarStatisticalDataResponse queryCalendarStatisticalData(QueryCalendarStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCalendarStatisticalDataHeaders headers = new QueryCalendarStatisticalDataHeaders();
        return this.queryCalendarStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业签到统计数据
     *
     * @param request QueryCheckinStatisticalDataRequest
     * @param headers QueryCheckinStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCheckinStatisticalDataResponse
     */
    public QueryCheckinStatisticalDataResponse queryCheckinStatisticalDataWithOptions(QueryCheckinStatisticalDataRequest request, QueryCheckinStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryCheckinStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/checkinData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCheckinStatisticalDataResponse());
    }

    /**
     * @summary 获取企业签到统计数据
     *
     * @param request QueryCheckinStatisticalDataRequest
     * @return QueryCheckinStatisticalDataResponse
     */
    public QueryCheckinStatisticalDataResponse queryCheckinStatisticalData(QueryCheckinStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCheckinStatisticalDataHeaders headers = new QueryCheckinStatisticalDataHeaders();
        return this.queryCheckinStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业全员圈统计数据
     *
     * @param request QueryCircleStatisticalDataRequest
     * @param headers QueryCircleStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCircleStatisticalDataResponse
     */
    public QueryCircleStatisticalDataResponse queryCircleStatisticalDataWithOptions(QueryCircleStatisticalDataRequest request, QueryCircleStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryCircleStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/circleData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCircleStatisticalDataResponse());
    }

    /**
     * @summary 获取企业全员圈统计数据
     *
     * @param request QueryCircleStatisticalDataRequest
     * @return QueryCircleStatisticalDataResponse
     */
    public QueryCircleStatisticalDataResponse queryCircleStatisticalData(QueryCircleStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCircleStatisticalDataHeaders headers = new QueryCircleStatisticalDataHeaders();
        return this.queryCircleStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
     *
     * @param request QueryCompanyBasicInfoRequest
     * @param headers QueryCompanyBasicInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCompanyBasicInfoResponse
     */
    public QueryCompanyBasicInfoResponse queryCompanyBasicInfoWithOptions(QueryCompanyBasicInfoRequest request, QueryCompanyBasicInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            query.put("keyword", request.keyword);
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
            new TeaPair("action", "QueryCompanyBasicInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/companies/basicInfo"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCompanyBasicInfoResponse());
    }

    /**
     * @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
     *
     * @param request QueryCompanyBasicInfoRequest
     * @return QueryCompanyBasicInfoResponse
     */
    public QueryCompanyBasicInfoResponse queryCompanyBasicInfo(QueryCompanyBasicInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCompanyBasicInfoHeaders headers = new QueryCompanyBasicInfoHeaders();
        return this.queryCompanyBasicInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取数字区县组织信息
     *
     * @param request QueryDigitalDistrictOrgInfoRequest
     * @param headers QueryDigitalDistrictOrgInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDigitalDistrictOrgInfoResponse
     */
    public QueryDigitalDistrictOrgInfoResponse queryDigitalDistrictOrgInfoWithOptions(QueryDigitalDistrictOrgInfoRequest request, QueryDigitalDistrictOrgInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpIds)) {
            body.put("corpIds", request.corpIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.statDates)) {
            body.put("statDates", request.statDates);
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
            new TeaPair("action", "QueryDigitalDistrictOrgInfo"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/digitalCounty/orgInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDigitalDistrictOrgInfoResponse());
    }

    /**
     * @summary 获取数字区县组织信息
     *
     * @param request QueryDigitalDistrictOrgInfoRequest
     * @return QueryDigitalDistrictOrgInfoResponse
     */
    public QueryDigitalDistrictOrgInfoResponse queryDigitalDistrictOrgInfo(QueryDigitalDistrictOrgInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDigitalDistrictOrgInfoHeaders headers = new QueryDigitalDistrictOrgInfoHeaders();
        return this.queryDigitalDistrictOrgInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业DING接收及评论统计数据
     *
     * @param request QueryDingReciveStatisticalDataRequest
     * @param headers QueryDingReciveStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDingReciveStatisticalDataResponse
     */
    public QueryDingReciveStatisticalDataResponse queryDingReciveStatisticalDataWithOptions(QueryDingReciveStatisticalDataRequest request, QueryDingReciveStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryDingReciveStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/dingReciveData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDingReciveStatisticalDataResponse());
    }

    /**
     * @summary 获取企业DING接收及评论统计数据
     *
     * @param request QueryDingReciveStatisticalDataRequest
     * @return QueryDingReciveStatisticalDataResponse
     */
    public QueryDingReciveStatisticalDataResponse queryDingReciveStatisticalData(QueryDingReciveStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDingReciveStatisticalDataHeaders headers = new QueryDingReciveStatisticalDataHeaders();
        return this.queryDingReciveStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业DING发送统计数据
     *
     * @param request QueryDingSendStatisticalDataRequest
     * @param headers QueryDingSendStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDingSendStatisticalDataResponse
     */
    public QueryDingSendStatisticalDataResponse queryDingSendStatisticalDataWithOptions(QueryDingSendStatisticalDataRequest request, QueryDingSendStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryDingSendStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/dingSendData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDingSendStatisticalDataResponse());
    }

    /**
     * @summary 获取企业DING发送统计数据
     *
     * @param request QueryDingSendStatisticalDataRequest
     * @return QueryDingSendStatisticalDataResponse
     */
    public QueryDingSendStatisticalDataResponse queryDingSendStatisticalData(QueryDingSendStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDingSendStatisticalDataHeaders headers = new QueryDingSendStatisticalDataHeaders();
        return this.queryDingSendStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业文档统计数据
     *
     * @param request QueryDocumentStatisticalDataRequest
     * @param headers QueryDocumentStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDocumentStatisticalDataResponse
     */
    public QueryDocumentStatisticalDataResponse queryDocumentStatisticalDataWithOptions(QueryDocumentStatisticalDataRequest request, QueryDocumentStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryDocumentStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/documentData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDocumentStatisticalDataResponse());
    }

    /**
     * @summary 获取企业文档统计数据
     *
     * @param request QueryDocumentStatisticalDataRequest
     * @return QueryDocumentStatisticalDataResponse
     */
    public QueryDocumentStatisticalDataResponse queryDocumentStatisticalData(QueryDocumentStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDocumentStatisticalDataHeaders headers = new QueryDocumentStatisticalDataHeaders();
        return this.queryDocumentStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业钉盘统计数据
     *
     * @param request QueryDriveStatisticalDataRequest
     * @param headers QueryDriveStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDriveStatisticalDataResponse
     */
    public QueryDriveStatisticalDataResponse queryDriveStatisticalDataWithOptions(QueryDriveStatisticalDataRequest request, QueryDriveStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryDriveStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/driveData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDriveStatisticalDataResponse());
    }

    /**
     * @summary 获取企业钉盘统计数据
     *
     * @param request QueryDriveStatisticalDataRequest
     * @return QueryDriveStatisticalDataResponse
     */
    public QueryDriveStatisticalDataResponse queryDriveStatisticalData(QueryDriveStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDriveStatisticalDataHeaders headers = new QueryDriveStatisticalDataHeaders();
        return this.queryDriveStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业员工类型统计数据
     *
     * @param request QueryEmployeeTypeStatisticalDataRequest
     * @param headers QueryEmployeeTypeStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryEmployeeTypeStatisticalDataResponse
     */
    public QueryEmployeeTypeStatisticalDataResponse queryEmployeeTypeStatisticalDataWithOptions(QueryEmployeeTypeStatisticalDataRequest request, QueryEmployeeTypeStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryEmployeeTypeStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/employeeTypeData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryEmployeeTypeStatisticalDataResponse());
    }

    /**
     * @summary 获取企业员工类型统计数据
     *
     * @param request QueryEmployeeTypeStatisticalDataRequest
     * @return QueryEmployeeTypeStatisticalDataResponse
     */
    public QueryEmployeeTypeStatisticalDataResponse queryEmployeeTypeStatisticalData(QueryEmployeeTypeStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryEmployeeTypeStatisticalDataHeaders headers = new QueryEmployeeTypeStatisticalDataHeaders();
        return this.queryEmployeeTypeStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 数据资产平台数据服务接口
     *
     * @param request QueryGeneralDataServiceRequest
     * @param headers QueryGeneralDataServiceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryGeneralDataServiceResponse
     */
    public QueryGeneralDataServiceResponse queryGeneralDataServiceWithOptions(QueryGeneralDataServiceRequest request, QueryGeneralDataServiceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endDate)) {
            query.put("endDate", request.endDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceId)) {
            query.put("serviceId", request.serviceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startDate)) {
            query.put("startDate", request.startDate);
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
            new TeaPair("action", "QueryGeneralDataService"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/generalDataServices"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryGeneralDataServiceResponse());
    }

    /**
     * @summary 数据资产平台数据服务接口
     *
     * @param request QueryGeneralDataServiceRequest
     * @return QueryGeneralDataServiceResponse
     */
    public QueryGeneralDataServiceResponse queryGeneralDataService(QueryGeneralDataServiceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGeneralDataServiceHeaders headers = new QueryGeneralDataServiceHeaders();
        return this.queryGeneralDataServiceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业群直播统计数据
     *
     * @param request QueryGroupLiveStatisticalDataRequest
     * @param headers QueryGroupLiveStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryGroupLiveStatisticalDataResponse
     */
    public QueryGroupLiveStatisticalDataResponse queryGroupLiveStatisticalDataWithOptions(QueryGroupLiveStatisticalDataRequest request, QueryGroupLiveStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryGroupLiveStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/groupLiveData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryGroupLiveStatisticalDataResponse());
    }

    /**
     * @summary 获取企业群直播统计数据
     *
     * @param request QueryGroupLiveStatisticalDataRequest
     * @return QueryGroupLiveStatisticalDataResponse
     */
    public QueryGroupLiveStatisticalDataResponse queryGroupLiveStatisticalData(QueryGroupLiveStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupLiveStatisticalDataHeaders headers = new QueryGroupLiveStatisticalDataHeaders();
        return this.queryGroupLiveStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业群聊统计数据
     *
     * @param request QueryGroupMessageStatisticalDataRequest
     * @param headers QueryGroupMessageStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryGroupMessageStatisticalDataResponse
     */
    public QueryGroupMessageStatisticalDataResponse queryGroupMessageStatisticalDataWithOptions(QueryGroupMessageStatisticalDataRequest request, QueryGroupMessageStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryGroupMessageStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/groupMessageData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryGroupMessageStatisticalDataResponse());
    }

    /**
     * @summary 获取企业群聊统计数据
     *
     * @param request QueryGroupMessageStatisticalDataRequest
     * @return QueryGroupMessageStatisticalDataResponse
     */
    public QueryGroupMessageStatisticalDataResponse queryGroupMessageStatisticalData(QueryGroupMessageStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupMessageStatisticalDataHeaders headers = new QueryGroupMessageStatisticalDataHeaders();
        return this.queryGroupMessageStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业钉钉运动统计数据
     *
     * @param request QueryHealthStatisticalDataRequest
     * @param headers QueryHealthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryHealthStatisticalDataResponse
     */
    public QueryHealthStatisticalDataResponse queryHealthStatisticalDataWithOptions(QueryHealthStatisticalDataRequest request, QueryHealthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryHealthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/healtheUserData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryHealthStatisticalDataResponse());
    }

    /**
     * @summary 获取企业钉钉运动统计数据
     *
     * @param request QueryHealthStatisticalDataRequest
     * @return QueryHealthStatisticalDataResponse
     */
    public QueryHealthStatisticalDataResponse queryHealthStatisticalData(QueryHealthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHealthStatisticalDataHeaders headers = new QueryHealthStatisticalDataHeaders();
        return this.queryHealthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业邮箱统计数据
     *
     * @param request QueryMailStatisticalDataRequest
     * @param headers QueryMailStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMailStatisticalDataResponse
     */
    public QueryMailStatisticalDataResponse queryMailStatisticalDataWithOptions(QueryMailStatisticalDataRequest request, QueryMailStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryMailStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/mailData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMailStatisticalDataResponse());
    }

    /**
     * @summary 获取企业邮箱统计数据
     *
     * @param request QueryMailStatisticalDataRequest
     * @return QueryMailStatisticalDataResponse
     */
    public QueryMailStatisticalDataResponse queryMailStatisticalData(QueryMailStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMailStatisticalDataHeaders headers = new QueryMailStatisticalDataHeaders();
        return this.queryMailStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取官方数据集数据
     *
     * @param request QueryOfficialDataRequest
     * @param headers QueryOfficialDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOfficialDataResponse
     */
    public QueryOfficialDataResponse queryOfficialDataWithOptions(QueryOfficialDataRequest request, QueryOfficialDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            query.put("param", request.param);
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
            new TeaPair("action", "QueryOfficialData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/datas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOfficialDataResponse());
    }

    /**
     * @summary 获取官方数据集数据
     *
     * @param request QueryOfficialDataRequest
     * @return QueryOfficialDataResponse
     */
    public QueryOfficialDataResponse queryOfficialData(QueryOfficialDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOfficialDataHeaders headers = new QueryOfficialDataHeaders();
        return this.queryOfficialDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary ISV获取官方数据集字段信息
     *
     * @param request QueryOfficialDatasetFieldsRequest
     * @param headers QueryOfficialDatasetFieldsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOfficialDatasetFieldsResponse
     */
    public QueryOfficialDatasetFieldsResponse queryOfficialDatasetFieldsWithOptions(QueryOfficialDatasetFieldsRequest request, QueryOfficialDatasetFieldsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dsId)) {
            query.put("dsId", request.dsId);
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
            new TeaPair("action", "QueryOfficialDatasetFields"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/datasetFields"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOfficialDatasetFieldsResponse());
    }

    /**
     * @summary ISV获取官方数据集字段信息
     *
     * @param request QueryOfficialDatasetFieldsRequest
     * @return QueryOfficialDatasetFieldsResponse
     */
    public QueryOfficialDatasetFieldsResponse queryOfficialDatasetFields(QueryOfficialDatasetFieldsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOfficialDatasetFieldsHeaders headers = new QueryOfficialDatasetFieldsHeaders();
        return this.queryOfficialDatasetFieldsWithOptions(request, headers, runtime);
    }

    /**
     * @summary ISV获取官方数据集列表
     *
     * @param request QueryOfficialDatasetListRequest
     * @param headers QueryOfficialDatasetListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOfficialDatasetListResponse
     */
    public QueryOfficialDatasetListResponse queryOfficialDatasetListWithOptions(QueryOfficialDatasetListRequest request, QueryOfficialDatasetListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            query.put("keyword", request.keyword);
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
            new TeaPair("action", "QueryOfficialDatasetList"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/datasetLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOfficialDatasetListResponse());
    }

    /**
     * @summary ISV获取官方数据集列表
     *
     * @param request QueryOfficialDatasetListRequest
     * @return QueryOfficialDatasetListResponse
     */
    public QueryOfficialDatasetListResponse queryOfficialDatasetList(QueryOfficialDatasetListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOfficialDatasetListHeaders headers = new QueryOfficialDatasetListHeaders();
        return this.queryOfficialDatasetListWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取官方数据集数据
     *
     * @param request QueryOfficialFormDataRequest
     * @param headers QueryOfficialFormDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOfficialFormDataResponse
     */
    public QueryOfficialFormDataResponse queryOfficialFormDataWithOptions(QueryOfficialFormDataRequest request, QueryOfficialFormDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("action", "QueryOfficialFormData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/datas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOfficialFormDataResponse());
    }

    /**
     * @summary 获取官方数据集数据
     *
     * @param request QueryOfficialFormDataRequest
     * @return QueryOfficialFormDataResponse
     */
    public QueryOfficialFormDataResponse queryOfficialFormData(QueryOfficialFormDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOfficialFormDataHeaders headers = new QueryOfficialFormDataHeaders();
        return this.queryOfficialFormDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业用户在线统计数据
     *
     * @param request QueryOnlineUserStatisticalDataRequest
     * @param headers QueryOnlineUserStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOnlineUserStatisticalDataResponse
     */
    public QueryOnlineUserStatisticalDataResponse queryOnlineUserStatisticalDataWithOptions(QueryOnlineUserStatisticalDataRequest request, QueryOnlineUserStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryOnlineUserStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/onlineUserData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOnlineUserStatisticalDataResponse());
    }

    /**
     * @summary 获取企业用户在线统计数据
     *
     * @param request QueryOnlineUserStatisticalDataRequest
     * @return QueryOnlineUserStatisticalDataResponse
     */
    public QueryOnlineUserStatisticalDataResponse queryOnlineUserStatisticalData(QueryOnlineUserStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOnlineUserStatisticalDataHeaders headers = new QueryOnlineUserStatisticalDataHeaders();
        return this.queryOnlineUserStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业接收红包统计数据
     *
     * @param request QueryRedEnvelopeReciveStatisticalDataRequest
     * @param headers QueryRedEnvelopeReciveStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryRedEnvelopeReciveStatisticalDataResponse
     */
    public QueryRedEnvelopeReciveStatisticalDataResponse queryRedEnvelopeReciveStatisticalDataWithOptions(QueryRedEnvelopeReciveStatisticalDataRequest request, QueryRedEnvelopeReciveStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryRedEnvelopeReciveStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/redEnvelopeReciveData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryRedEnvelopeReciveStatisticalDataResponse());
    }

    /**
     * @summary 获取企业接收红包统计数据
     *
     * @param request QueryRedEnvelopeReciveStatisticalDataRequest
     * @return QueryRedEnvelopeReciveStatisticalDataResponse
     */
    public QueryRedEnvelopeReciveStatisticalDataResponse queryRedEnvelopeReciveStatisticalData(QueryRedEnvelopeReciveStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRedEnvelopeReciveStatisticalDataHeaders headers = new QueryRedEnvelopeReciveStatisticalDataHeaders();
        return this.queryRedEnvelopeReciveStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业发送红包统计数据
     *
     * @param request QueryRedEnvelopeSendStatisticalDataRequest
     * @param headers QueryRedEnvelopeSendStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryRedEnvelopeSendStatisticalDataResponse
     */
    public QueryRedEnvelopeSendStatisticalDataResponse queryRedEnvelopeSendStatisticalDataWithOptions(QueryRedEnvelopeSendStatisticalDataRequest request, QueryRedEnvelopeSendStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryRedEnvelopeSendStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/redEnvelopeSendData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryRedEnvelopeSendStatisticalDataResponse());
    }

    /**
     * @summary 获取企业发送红包统计数据
     *
     * @param request QueryRedEnvelopeSendStatisticalDataRequest
     * @return QueryRedEnvelopeSendStatisticalDataResponse
     */
    public QueryRedEnvelopeSendStatisticalDataResponse queryRedEnvelopeSendStatisticalData(QueryRedEnvelopeSendStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRedEnvelopeSendStatisticalDataHeaders headers = new QueryRedEnvelopeSendStatisticalDataHeaders();
        return this.queryRedEnvelopeSendStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业日志统计数据
     *
     * @param request QueryReportStatisticalDataRequest
     * @param headers QueryReportStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryReportStatisticalDataResponse
     */
    public QueryReportStatisticalDataResponse queryReportStatisticalDataWithOptions(QueryReportStatisticalDataRequest request, QueryReportStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryReportStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/reportData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryReportStatisticalDataResponse());
    }

    /**
     * @summary 获取企业日志统计数据
     *
     * @param request QueryReportStatisticalDataRequest
     * @return QueryReportStatisticalDataResponse
     */
    public QueryReportStatisticalDataResponse queryReportStatisticalData(QueryReportStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryReportStatisticalDataHeaders headers = new QueryReportStatisticalDataHeaders();
        return this.queryReportStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业单聊统计数据
     *
     * @param request QuerySingleMessageStatisticalDataRequest
     * @param headers QuerySingleMessageStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySingleMessageStatisticalDataResponse
     */
    public QuerySingleMessageStatisticalDataResponse querySingleMessageStatisticalDataWithOptions(QuerySingleMessageStatisticalDataRequest request, QuerySingleMessageStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QuerySingleMessageStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/singleMessagerData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySingleMessageStatisticalDataResponse());
    }

    /**
     * @summary 获取企业单聊统计数据
     *
     * @param request QuerySingleMessageStatisticalDataRequest
     * @return QuerySingleMessageStatisticalDataResponse
     */
    public QuerySingleMessageStatisticalDataResponse querySingleMessageStatisticalData(QuerySingleMessageStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySingleMessageStatisticalDataHeaders headers = new QuerySingleMessageStatisticalDataHeaders();
        return this.querySingleMessageStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业电话会议统计数据
     *
     * @param request QueryTelMeetingStatisticalDataRequest
     * @param headers QueryTelMeetingStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTelMeetingStatisticalDataResponse
     */
    public QueryTelMeetingStatisticalDataResponse queryTelMeetingStatisticalDataWithOptions(QueryTelMeetingStatisticalDataRequest request, QueryTelMeetingStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryTelMeetingStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/telMeetingData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTelMeetingStatisticalDataResponse());
    }

    /**
     * @summary 获取企业电话会议统计数据
     *
     * @param request QueryTelMeetingStatisticalDataRequest
     * @return QueryTelMeetingStatisticalDataResponse
     */
    public QueryTelMeetingStatisticalDataResponse queryTelMeetingStatisticalData(QueryTelMeetingStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTelMeetingStatisticalDataHeaders headers = new QueryTelMeetingStatisticalDataHeaders();
        return this.queryTelMeetingStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业待办统计数据
     *
     * @param request QueryTodoStatisticalDataRequest
     * @param headers QueryTodoStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTodoStatisticalDataResponse
     */
    public QueryTodoStatisticalDataResponse queryTodoStatisticalDataWithOptions(QueryTodoStatisticalDataRequest request, QueryTodoStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryTodoStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/todoUserData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTodoStatisticalDataResponse());
    }

    /**
     * @summary 获取企业待办统计数据
     *
     * @param request QueryTodoStatisticalDataRequest
     * @return QueryTodoStatisticalDataResponse
     */
    public QueryTodoStatisticalDataResponse queryTodoStatisticalData(QueryTodoStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTodoStatisticalDataHeaders headers = new QueryTodoStatisticalDataHeaders();
        return this.queryTodoStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业视频会议统计数据
     *
     * @param request QueryVedioMeetingStatisticalDataRequest
     * @param headers QueryVedioMeetingStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryVedioMeetingStatisticalDataResponse
     */
    public QueryVedioMeetingStatisticalDataResponse queryVedioMeetingStatisticalDataWithOptions(QueryVedioMeetingStatisticalDataRequest request, QueryVedioMeetingStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryVedioMeetingStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/vedioMeetingData"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryVedioMeetingStatisticalDataResponse());
    }

    /**
     * @summary 获取企业视频会议统计数据
     *
     * @param request QueryVedioMeetingStatisticalDataRequest
     * @return QueryVedioMeetingStatisticalDataResponse
     */
    public QueryVedioMeetingStatisticalDataResponse queryVedioMeetingStatisticalData(QueryVedioMeetingStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryVedioMeetingStatisticalDataHeaders headers = new QueryVedioMeetingStatisticalDataHeaders();
        return this.queryVedioMeetingStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉参谋活跃分析（按日统计）指标接口
     *
     * @param request QueryYydActiveDayStatisticalDataRequest
     * @param headers QueryYydActiveDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydActiveDayStatisticalDataResponse
     */
    public QueryYydActiveDayStatisticalDataResponse queryYydActiveDayStatisticalDataWithOptions(QueryYydActiveDayStatisticalDataRequest request, QueryYydActiveDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydActiveDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydActiveDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydActiveDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉参谋活跃分析（按日统计）指标接口
     *
     * @param request QueryYydActiveDayStatisticalDataRequest
     * @return QueryYydActiveDayStatisticalDataResponse
     */
    public QueryYydActiveDayStatisticalDataResponse queryYydActiveDayStatisticalData(QueryYydActiveDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydActiveDayStatisticalDataHeaders headers = new QueryYydActiveDayStatisticalDataHeaders();
        return this.queryYydActiveDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉参谋活跃分析（按月统计）指标接口
     *
     * @param request QueryYydActiveMonthStatisticalDataRequest
     * @param headers QueryYydActiveMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydActiveMonthStatisticalDataResponse
     */
    public QueryYydActiveMonthStatisticalDataResponse queryYydActiveMonthStatisticalDataWithOptions(QueryYydActiveMonthStatisticalDataRequest request, QueryYydActiveMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydActiveMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydActiveMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydActiveMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉参谋活跃分析（按月统计）指标接口
     *
     * @param request QueryYydActiveMonthStatisticalDataRequest
     * @return QueryYydActiveMonthStatisticalDataResponse
     */
    public QueryYydActiveMonthStatisticalDataResponse queryYydActiveMonthStatisticalData(QueryYydActiveMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydActiveMonthStatisticalDataHeaders headers = new QueryYydActiveMonthStatisticalDataHeaders();
        return this.queryYydActiveMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉参谋活跃分析（按周统计）指标接口
     *
     * @param request QueryYydActiveWeekStatisticalDataRequest
     * @param headers QueryYydActiveWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydActiveWeekStatisticalDataResponse
     */
    public QueryYydActiveWeekStatisticalDataResponse queryYydActiveWeekStatisticalDataWithOptions(QueryYydActiveWeekStatisticalDataRequest request, QueryYydActiveWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydActiveWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydActiveWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydActiveWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉参谋活跃分析（按周统计）指标接口
     *
     * @param request QueryYydActiveWeekStatisticalDataRequest
     * @return QueryYydActiveWeekStatisticalDataResponse
     */
    public QueryYydActiveWeekStatisticalDataResponse queryYydActiveWeekStatisticalData(QueryYydActiveWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydActiveWeekStatisticalDataHeaders headers = new QueryYydActiveWeekStatisticalDataHeaders();
        return this.queryYydActiveWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋应用概况（按日统计）指标接口
     *
     * @param request QueryYydAppDayStatisticalDataRequest
     * @param headers QueryYydAppDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydAppDayStatisticalDataResponse
     */
    public QueryYydAppDayStatisticalDataResponse queryYydAppDayStatisticalDataWithOptions(QueryYydAppDayStatisticalDataRequest request, QueryYydAppDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydAppDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydAppDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydAppDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋应用概况（按日统计）指标接口
     *
     * @param request QueryYydAppDayStatisticalDataRequest
     * @return QueryYydAppDayStatisticalDataResponse
     */
    public QueryYydAppDayStatisticalDataResponse queryYydAppDayStatisticalData(QueryYydAppDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydAppDayStatisticalDataHeaders headers = new QueryYydAppDayStatisticalDataHeaders();
        return this.queryYydAppDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋应用概况（按月统计）指标接口
     *
     * @param request QueryYydAppMonthStatisticalDataRequest
     * @param headers QueryYydAppMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydAppMonthStatisticalDataResponse
     */
    public QueryYydAppMonthStatisticalDataResponse queryYydAppMonthStatisticalDataWithOptions(QueryYydAppMonthStatisticalDataRequest request, QueryYydAppMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydAppMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydAppMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydAppMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋应用概况（按月统计）指标接口
     *
     * @param request QueryYydAppMonthStatisticalDataRequest
     * @return QueryYydAppMonthStatisticalDataResponse
     */
    public QueryYydAppMonthStatisticalDataResponse queryYydAppMonthStatisticalData(QueryYydAppMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydAppMonthStatisticalDataHeaders headers = new QueryYydAppMonthStatisticalDataHeaders();
        return this.queryYydAppMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋应用概况（累计）指标接口
     *
     * @param request QueryYydAppStdStatisticalDataRequest
     * @param headers QueryYydAppStdStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydAppStdStatisticalDataResponse
     */
    public QueryYydAppStdStatisticalDataResponse queryYydAppStdStatisticalDataWithOptions(QueryYydAppStdStatisticalDataRequest request, QueryYydAppStdStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydAppStdStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydAppStdDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydAppStdStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋应用概况（累计）指标接口
     *
     * @param request QueryYydAppStdStatisticalDataRequest
     * @return QueryYydAppStdStatisticalDataResponse
     */
    public QueryYydAppStdStatisticalDataResponse queryYydAppStdStatisticalData(QueryYydAppStdStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydAppStdStatisticalDataHeaders headers = new QueryYydAppStdStatisticalDataHeaders();
        return this.queryYydAppStdStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋应用概况（按周统计）指标接口
     *
     * @param request QueryYydAppWeekStatisticalDataRequest
     * @param headers QueryYydAppWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydAppWeekStatisticalDataResponse
     */
    public QueryYydAppWeekStatisticalDataResponse queryYydAppWeekStatisticalDataWithOptions(QueryYydAppWeekStatisticalDataRequest request, QueryYydAppWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydAppWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydAppWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydAppWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋应用概况（按周统计）指标接口
     *
     * @param request QueryYydAppWeekStatisticalDataRequest
     * @return QueryYydAppWeekStatisticalDataResponse
     */
    public QueryYydAppWeekStatisticalDataResponse queryYydAppWeekStatisticalData(QueryYydAppWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydAppWeekStatisticalDataHeaders headers = new QueryYydAppWeekStatisticalDataHeaders();
        return this.queryYydAppWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
     *
     * @param request QueryYydCalendarDayStatisticalDataRequest
     * @param headers QueryYydCalendarDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydCalendarDayStatisticalDataResponse
     */
    public QueryYydCalendarDayStatisticalDataResponse queryYydCalendarDayStatisticalDataWithOptions(QueryYydCalendarDayStatisticalDataRequest request, QueryYydCalendarDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydCalendarDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydCalendarDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydCalendarDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
     *
     * @param request QueryYydCalendarDayStatisticalDataRequest
     * @return QueryYydCalendarDayStatisticalDataResponse
     */
    public QueryYydCalendarDayStatisticalDataResponse queryYydCalendarDayStatisticalData(QueryYydCalendarDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydCalendarDayStatisticalDataHeaders headers = new QueryYydCalendarDayStatisticalDataHeaders();
        return this.queryYydCalendarDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
     *
     * @param request QueryYydCalendarMonthStatisticalDataRequest
     * @param headers QueryYydCalendarMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydCalendarMonthStatisticalDataResponse
     */
    public QueryYydCalendarMonthStatisticalDataResponse queryYydCalendarMonthStatisticalDataWithOptions(QueryYydCalendarMonthStatisticalDataRequest request, QueryYydCalendarMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydCalendarMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydCalendarMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydCalendarMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
     *
     * @param request QueryYydCalendarMonthStatisticalDataRequest
     * @return QueryYydCalendarMonthStatisticalDataResponse
     */
    public QueryYydCalendarMonthStatisticalDataResponse queryYydCalendarMonthStatisticalData(QueryYydCalendarMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydCalendarMonthStatisticalDataHeaders headers = new QueryYydCalendarMonthStatisticalDataHeaders();
        return this.queryYydCalendarMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
     *
     * @param request QueryYydCalendarWeekStatisticalDataRequest
     * @param headers QueryYydCalendarWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydCalendarWeekStatisticalDataResponse
     */
    public QueryYydCalendarWeekStatisticalDataResponse queryYydCalendarWeekStatisticalDataWithOptions(QueryYydCalendarWeekStatisticalDataRequest request, QueryYydCalendarWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydCalendarWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydCalendarWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydCalendarWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
     *
     * @param request QueryYydCalendarWeekStatisticalDataRequest
     * @return QueryYydCalendarWeekStatisticalDataResponse
     */
    public QueryYydCalendarWeekStatisticalDataResponse queryYydCalendarWeekStatisticalData(QueryYydCalendarWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydCalendarWeekStatisticalDataHeaders headers = new QueryYydCalendarWeekStatisticalDataHeaders();
        return this.queryYydCalendarWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
     *
     * @param request QueryYydDingMsgDayStatisticalDataRequest
     * @param headers QueryYydDingMsgDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydDingMsgDayStatisticalDataResponse
     */
    public QueryYydDingMsgDayStatisticalDataResponse queryYydDingMsgDayStatisticalDataWithOptions(QueryYydDingMsgDayStatisticalDataRequest request, QueryYydDingMsgDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydDingMsgDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydDingMsgDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydDingMsgDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
     *
     * @param request QueryYydDingMsgDayStatisticalDataRequest
     * @return QueryYydDingMsgDayStatisticalDataResponse
     */
    public QueryYydDingMsgDayStatisticalDataResponse queryYydDingMsgDayStatisticalData(QueryYydDingMsgDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydDingMsgDayStatisticalDataHeaders headers = new QueryYydDingMsgDayStatisticalDataHeaders();
        return this.queryYydDingMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
     *
     * @param request QueryYydDingMsgMonthStatisticalDataRequest
     * @param headers QueryYydDingMsgMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydDingMsgMonthStatisticalDataResponse
     */
    public QueryYydDingMsgMonthStatisticalDataResponse queryYydDingMsgMonthStatisticalDataWithOptions(QueryYydDingMsgMonthStatisticalDataRequest request, QueryYydDingMsgMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydDingMsgMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydDingMsgMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydDingMsgMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
     *
     * @param request QueryYydDingMsgMonthStatisticalDataRequest
     * @return QueryYydDingMsgMonthStatisticalDataResponse
     */
    public QueryYydDingMsgMonthStatisticalDataResponse queryYydDingMsgMonthStatisticalData(QueryYydDingMsgMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydDingMsgMonthStatisticalDataHeaders headers = new QueryYydDingMsgMonthStatisticalDataHeaders();
        return this.queryYydDingMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
     *
     * @param request QueryYydDingMsgWeekStatisticalDataRequest
     * @param headers QueryYydDingMsgWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydDingMsgWeekStatisticalDataResponse
     */
    public QueryYydDingMsgWeekStatisticalDataResponse queryYydDingMsgWeekStatisticalDataWithOptions(QueryYydDingMsgWeekStatisticalDataRequest request, QueryYydDingMsgWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydDingMsgWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydDingMsgWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydDingMsgWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
     *
     * @param request QueryYydDingMsgWeekStatisticalDataRequest
     * @return QueryYydDingMsgWeekStatisticalDataResponse
     */
    public QueryYydDingMsgWeekStatisticalDataResponse queryYydDingMsgWeekStatisticalData(QueryYydDingMsgWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydDingMsgWeekStatisticalDataHeaders headers = new QueryYydDingMsgWeekStatisticalDataHeaders();
        return this.queryYydDingMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
     *
     * @param request QueryYydGroupMsgDayStatisticalDataRequest
     * @param headers QueryYydGroupMsgDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydGroupMsgDayStatisticalDataResponse
     */
    public QueryYydGroupMsgDayStatisticalDataResponse queryYydGroupMsgDayStatisticalDataWithOptions(QueryYydGroupMsgDayStatisticalDataRequest request, QueryYydGroupMsgDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydGroupMsgDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydGroupMsgDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydGroupMsgDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
     *
     * @param request QueryYydGroupMsgDayStatisticalDataRequest
     * @return QueryYydGroupMsgDayStatisticalDataResponse
     */
    public QueryYydGroupMsgDayStatisticalDataResponse queryYydGroupMsgDayStatisticalData(QueryYydGroupMsgDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydGroupMsgDayStatisticalDataHeaders headers = new QueryYydGroupMsgDayStatisticalDataHeaders();
        return this.queryYydGroupMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
     *
     * @param request QueryYydGroupMsgMonthStatisticalDataRequest
     * @param headers QueryYydGroupMsgMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydGroupMsgMonthStatisticalDataResponse
     */
    public QueryYydGroupMsgMonthStatisticalDataResponse queryYydGroupMsgMonthStatisticalDataWithOptions(QueryYydGroupMsgMonthStatisticalDataRequest request, QueryYydGroupMsgMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydGroupMsgMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydGroupMsgMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydGroupMsgMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
     *
     * @param request QueryYydGroupMsgMonthStatisticalDataRequest
     * @return QueryYydGroupMsgMonthStatisticalDataResponse
     */
    public QueryYydGroupMsgMonthStatisticalDataResponse queryYydGroupMsgMonthStatisticalData(QueryYydGroupMsgMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydGroupMsgMonthStatisticalDataHeaders headers = new QueryYydGroupMsgMonthStatisticalDataHeaders();
        return this.queryYydGroupMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
     *
     * @param request QueryYydGroupMsgWeekStatisticalDataRequest
     * @param headers QueryYydGroupMsgWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydGroupMsgWeekStatisticalDataResponse
     */
    public QueryYydGroupMsgWeekStatisticalDataResponse queryYydGroupMsgWeekStatisticalDataWithOptions(QueryYydGroupMsgWeekStatisticalDataRequest request, QueryYydGroupMsgWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydGroupMsgWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydGroupMsgWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydGroupMsgWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
     *
     * @param request QueryYydGroupMsgWeekStatisticalDataRequest
     * @return QueryYydGroupMsgWeekStatisticalDataResponse
     */
    public QueryYydGroupMsgWeekStatisticalDataResponse queryYydGroupMsgWeekStatisticalData(QueryYydGroupMsgWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydGroupMsgWeekStatisticalDataHeaders headers = new QueryYydGroupMsgWeekStatisticalDataHeaders();
        return this.queryYydGroupMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋日志分析（按日统计）指标接口
     *
     * @param request QueryYydLogDayStatisticalDataRequest
     * @param headers QueryYydLogDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydLogDayStatisticalDataResponse
     */
    public QueryYydLogDayStatisticalDataResponse queryYydLogDayStatisticalDataWithOptions(QueryYydLogDayStatisticalDataRequest request, QueryYydLogDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydLogDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydLogDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydLogDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋日志分析（按日统计）指标接口
     *
     * @param request QueryYydLogDayStatisticalDataRequest
     * @return QueryYydLogDayStatisticalDataResponse
     */
    public QueryYydLogDayStatisticalDataResponse queryYydLogDayStatisticalData(QueryYydLogDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydLogDayStatisticalDataHeaders headers = new QueryYydLogDayStatisticalDataHeaders();
        return this.queryYydLogDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋日志分析（按月统计）指标接口
     *
     * @param request QueryYydLogMonthStatisticalDataRequest
     * @param headers QueryYydLogMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydLogMonthStatisticalDataResponse
     */
    public QueryYydLogMonthStatisticalDataResponse queryYydLogMonthStatisticalDataWithOptions(QueryYydLogMonthStatisticalDataRequest request, QueryYydLogMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydLogMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydLogMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydLogMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋日志分析（按月统计）指标接口
     *
     * @param request QueryYydLogMonthStatisticalDataRequest
     * @return QueryYydLogMonthStatisticalDataResponse
     */
    public QueryYydLogMonthStatisticalDataResponse queryYydLogMonthStatisticalData(QueryYydLogMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydLogMonthStatisticalDataHeaders headers = new QueryYydLogMonthStatisticalDataHeaders();
        return this.queryYydLogMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋日志分析（按周统计）指标接口
     *
     * @param request QueryYydLogWeekStatisticalDataRequest
     * @param headers QueryYydLogWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydLogWeekStatisticalDataResponse
     */
    public QueryYydLogWeekStatisticalDataResponse queryYydLogWeekStatisticalDataWithOptions(QueryYydLogWeekStatisticalDataRequest request, QueryYydLogWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydLogWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydLogWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydLogWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋日志分析（按周统计）指标接口
     *
     * @param request QueryYydLogWeekStatisticalDataRequest
     * @return QueryYydLogWeekStatisticalDataResponse
     */
    public QueryYydLogWeekStatisticalDataResponse queryYydLogWeekStatisticalData(QueryYydLogWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydLogWeekStatisticalDataHeaders headers = new QueryYydLogWeekStatisticalDataHeaders();
        return this.queryYydLogWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
     *
     * @param request QueryYydMeetingDayStatisticalDataRequest
     * @param headers QueryYydMeetingDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydMeetingDayStatisticalDataResponse
     */
    public QueryYydMeetingDayStatisticalDataResponse queryYydMeetingDayStatisticalDataWithOptions(QueryYydMeetingDayStatisticalDataRequest request, QueryYydMeetingDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydMeetingDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydMeetingDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydMeetingDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
     *
     * @param request QueryYydMeetingDayStatisticalDataRequest
     * @return QueryYydMeetingDayStatisticalDataResponse
     */
    public QueryYydMeetingDayStatisticalDataResponse queryYydMeetingDayStatisticalData(QueryYydMeetingDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydMeetingDayStatisticalDataHeaders headers = new QueryYydMeetingDayStatisticalDataHeaders();
        return this.queryYydMeetingDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
     *
     * @param request QueryYydMeetingMonthStatisticalDataRequest
     * @param headers QueryYydMeetingMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydMeetingMonthStatisticalDataResponse
     */
    public QueryYydMeetingMonthStatisticalDataResponse queryYydMeetingMonthStatisticalDataWithOptions(QueryYydMeetingMonthStatisticalDataRequest request, QueryYydMeetingMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydMeetingMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydMeetingMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydMeetingMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
     *
     * @param request QueryYydMeetingMonthStatisticalDataRequest
     * @return QueryYydMeetingMonthStatisticalDataResponse
     */
    public QueryYydMeetingMonthStatisticalDataResponse queryYydMeetingMonthStatisticalData(QueryYydMeetingMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydMeetingMonthStatisticalDataHeaders headers = new QueryYydMeetingMonthStatisticalDataHeaders();
        return this.queryYydMeetingMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
     *
     * @param request QueryYydMeetingWeekStatisticalDataRequest
     * @param headers QueryYydMeetingWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydMeetingWeekStatisticalDataResponse
     */
    public QueryYydMeetingWeekStatisticalDataResponse queryYydMeetingWeekStatisticalDataWithOptions(QueryYydMeetingWeekStatisticalDataRequest request, QueryYydMeetingWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydMeetingWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydMeetingWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydMeetingWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
     *
     * @param request QueryYydMeetingWeekStatisticalDataRequest
     * @return QueryYydMeetingWeekStatisticalDataResponse
     */
    public QueryYydMeetingWeekStatisticalDataResponse queryYydMeetingWeekStatisticalData(QueryYydMeetingWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydMeetingWeekStatisticalDataHeaders headers = new QueryYydMeetingWeekStatisticalDataHeaders();
        return this.queryYydMeetingWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋通知分析（按日统计）指标接口
     *
     * @param request QueryYydNoticeDayStatisticalDataRequest
     * @param headers QueryYydNoticeDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydNoticeDayStatisticalDataResponse
     */
    public QueryYydNoticeDayStatisticalDataResponse queryYydNoticeDayStatisticalDataWithOptions(QueryYydNoticeDayStatisticalDataRequest request, QueryYydNoticeDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydNoticeDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydNoticeDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydNoticeDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋通知分析（按日统计）指标接口
     *
     * @param request QueryYydNoticeDayStatisticalDataRequest
     * @return QueryYydNoticeDayStatisticalDataResponse
     */
    public QueryYydNoticeDayStatisticalDataResponse queryYydNoticeDayStatisticalData(QueryYydNoticeDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydNoticeDayStatisticalDataHeaders headers = new QueryYydNoticeDayStatisticalDataHeaders();
        return this.queryYydNoticeDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋通知分析（按月统计）指标接口
     *
     * @param request QueryYydNoticeMonthStatisticalDataRequest
     * @param headers QueryYydNoticeMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydNoticeMonthStatisticalDataResponse
     */
    public QueryYydNoticeMonthStatisticalDataResponse queryYydNoticeMonthStatisticalDataWithOptions(QueryYydNoticeMonthStatisticalDataRequest request, QueryYydNoticeMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydNoticeMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydNoticeMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydNoticeMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋通知分析（按月统计）指标接口
     *
     * @param request QueryYydNoticeMonthStatisticalDataRequest
     * @return QueryYydNoticeMonthStatisticalDataResponse
     */
    public QueryYydNoticeMonthStatisticalDataResponse queryYydNoticeMonthStatisticalData(QueryYydNoticeMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydNoticeMonthStatisticalDataHeaders headers = new QueryYydNoticeMonthStatisticalDataHeaders();
        return this.queryYydNoticeMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋通知分析（按周统计）指标接口
     *
     * @param request QueryYydNoticeWeekStatisticalDataRequest
     * @param headers QueryYydNoticeWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydNoticeWeekStatisticalDataResponse
     */
    public QueryYydNoticeWeekStatisticalDataResponse queryYydNoticeWeekStatisticalDataWithOptions(QueryYydNoticeWeekStatisticalDataRequest request, QueryYydNoticeWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydNoticeWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydNoticeWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydNoticeWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋通知分析（按周统计）指标接口
     *
     * @param request QueryYydNoticeWeekStatisticalDataRequest
     * @return QueryYydNoticeWeekStatisticalDataResponse
     */
    public QueryYydNoticeWeekStatisticalDataResponse queryYydNoticeWeekStatisticalData(QueryYydNoticeWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydNoticeWeekStatisticalDataHeaders headers = new QueryYydNoticeWeekStatisticalDataHeaders();
        return this.queryYydNoticeWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
     *
     * @param request QueryYydSingleMsgDayStatisticalDataRequest
     * @param headers QueryYydSingleMsgDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydSingleMsgDayStatisticalDataResponse
     */
    public QueryYydSingleMsgDayStatisticalDataResponse queryYydSingleMsgDayStatisticalDataWithOptions(QueryYydSingleMsgDayStatisticalDataRequest request, QueryYydSingleMsgDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydSingleMsgDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydSingleMsgDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydSingleMsgDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
     *
     * @param request QueryYydSingleMsgDayStatisticalDataRequest
     * @return QueryYydSingleMsgDayStatisticalDataResponse
     */
    public QueryYydSingleMsgDayStatisticalDataResponse queryYydSingleMsgDayStatisticalData(QueryYydSingleMsgDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydSingleMsgDayStatisticalDataHeaders headers = new QueryYydSingleMsgDayStatisticalDataHeaders();
        return this.queryYydSingleMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
     *
     * @param request QueryYydSingleMsgMonthStatisticalDataRequest
     * @param headers QueryYydSingleMsgMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydSingleMsgMonthStatisticalDataResponse
     */
    public QueryYydSingleMsgMonthStatisticalDataResponse queryYydSingleMsgMonthStatisticalDataWithOptions(QueryYydSingleMsgMonthStatisticalDataRequest request, QueryYydSingleMsgMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydSingleMsgMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydSingleMsgMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydSingleMsgMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
     *
     * @param request QueryYydSingleMsgMonthStatisticalDataRequest
     * @return QueryYydSingleMsgMonthStatisticalDataResponse
     */
    public QueryYydSingleMsgMonthStatisticalDataResponse queryYydSingleMsgMonthStatisticalData(QueryYydSingleMsgMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydSingleMsgMonthStatisticalDataHeaders headers = new QueryYydSingleMsgMonthStatisticalDataHeaders();
        return this.queryYydSingleMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
     *
     * @param request QueryYydSingleMsgWeekStatisticalDataRequest
     * @param headers QueryYydSingleMsgWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydSingleMsgWeekStatisticalDataResponse
     */
    public QueryYydSingleMsgWeekStatisticalDataResponse queryYydSingleMsgWeekStatisticalDataWithOptions(QueryYydSingleMsgWeekStatisticalDataRequest request, QueryYydSingleMsgWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydSingleMsgWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydSingleMsgWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydSingleMsgWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
     *
     * @param request QueryYydSingleMsgWeekStatisticalDataRequest
     * @return QueryYydSingleMsgWeekStatisticalDataResponse
     */
    public QueryYydSingleMsgWeekStatisticalDataResponse queryYydSingleMsgWeekStatisticalData(QueryYydSingleMsgWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydSingleMsgWeekStatisticalDataHeaders headers = new QueryYydSingleMsgWeekStatisticalDataHeaders();
        return this.queryYydSingleMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋消息概览（按日统计）指标接口
     *
     * @param request QueryYydToatlMsgDayStatisticalDataRequest
     * @param headers QueryYydToatlMsgDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydToatlMsgDayStatisticalDataResponse
     */
    public QueryYydToatlMsgDayStatisticalDataResponse queryYydToatlMsgDayStatisticalDataWithOptions(QueryYydToatlMsgDayStatisticalDataRequest request, QueryYydToatlMsgDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydToatlMsgDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydToatlMsgDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydToatlMsgDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋消息概览（按日统计）指标接口
     *
     * @param request QueryYydToatlMsgDayStatisticalDataRequest
     * @return QueryYydToatlMsgDayStatisticalDataResponse
     */
    public QueryYydToatlMsgDayStatisticalDataResponse queryYydToatlMsgDayStatisticalData(QueryYydToatlMsgDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydToatlMsgDayStatisticalDataHeaders headers = new QueryYydToatlMsgDayStatisticalDataHeaders();
        return this.queryYydToatlMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋消息概览（按月统计）指标接口
     *
     * @param request QueryYydToatlMsgMonthStatisticalDataRequest
     * @param headers QueryYydToatlMsgMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydToatlMsgMonthStatisticalDataResponse
     */
    public QueryYydToatlMsgMonthStatisticalDataResponse queryYydToatlMsgMonthStatisticalDataWithOptions(QueryYydToatlMsgMonthStatisticalDataRequest request, QueryYydToatlMsgMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydToatlMsgMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydToatlMsgMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydToatlMsgMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋消息概览（按月统计）指标接口
     *
     * @param request QueryYydToatlMsgMonthStatisticalDataRequest
     * @return QueryYydToatlMsgMonthStatisticalDataResponse
     */
    public QueryYydToatlMsgMonthStatisticalDataResponse queryYydToatlMsgMonthStatisticalData(QueryYydToatlMsgMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydToatlMsgMonthStatisticalDataHeaders headers = new QueryYydToatlMsgMonthStatisticalDataHeaders();
        return this.queryYydToatlMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋消息概览（按周统计）指标接口
     *
     * @param request QueryYydToatlMsgWeekStatisticalDataRequest
     * @param headers QueryYydToatlMsgWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydToatlMsgWeekStatisticalDataResponse
     */
    public QueryYydToatlMsgWeekStatisticalDataResponse queryYydToatlMsgWeekStatisticalDataWithOptions(QueryYydToatlMsgWeekStatisticalDataRequest request, QueryYydToatlMsgWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydToatlMsgWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydToatlMsgWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydToatlMsgWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋消息概览（按周统计）指标接口
     *
     * @param request QueryYydToatlMsgWeekStatisticalDataRequest
     * @return QueryYydToatlMsgWeekStatisticalDataResponse
     */
    public QueryYydToatlMsgWeekStatisticalDataResponse queryYydToatlMsgWeekStatisticalData(QueryYydToatlMsgWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydToatlMsgWeekStatisticalDataHeaders headers = new QueryYydToatlMsgWeekStatisticalDataHeaders();
        return this.queryYydToatlMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋待办分析（按日统计）指标接口
     *
     * @param request QueryYydTodoDayStatisticalDataRequest
     * @param headers QueryYydTodoDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydTodoDayStatisticalDataResponse
     */
    public QueryYydTodoDayStatisticalDataResponse queryYydTodoDayStatisticalDataWithOptions(QueryYydTodoDayStatisticalDataRequest request, QueryYydTodoDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydTodoDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydTodoDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydTodoDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋待办分析（按日统计）指标接口
     *
     * @param request QueryYydTodoDayStatisticalDataRequest
     * @return QueryYydTodoDayStatisticalDataResponse
     */
    public QueryYydTodoDayStatisticalDataResponse queryYydTodoDayStatisticalData(QueryYydTodoDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTodoDayStatisticalDataHeaders headers = new QueryYydTodoDayStatisticalDataHeaders();
        return this.queryYydTodoDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋待办分析（按月统计）指标接口
     *
     * @param request QueryYydTodoMonthStatisticalDataRequest
     * @param headers QueryYydTodoMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydTodoMonthStatisticalDataResponse
     */
    public QueryYydTodoMonthStatisticalDataResponse queryYydTodoMonthStatisticalDataWithOptions(QueryYydTodoMonthStatisticalDataRequest request, QueryYydTodoMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydTodoMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydTodoMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydTodoMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋待办分析（按月统计）指标接口
     *
     * @param request QueryYydTodoMonthStatisticalDataRequest
     * @return QueryYydTodoMonthStatisticalDataResponse
     */
    public QueryYydTodoMonthStatisticalDataResponse queryYydTodoMonthStatisticalData(QueryYydTodoMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTodoMonthStatisticalDataHeaders headers = new QueryYydTodoMonthStatisticalDataHeaders();
        return this.queryYydTodoMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉数字参谋待办分析（按周统计）指标接口
     *
     * @param request QueryYydTodoWeekStatisticalDataRequest
     * @param headers QueryYydTodoWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydTodoWeekStatisticalDataResponse
     */
    public QueryYydTodoWeekStatisticalDataResponse queryYydTodoWeekStatisticalDataWithOptions(QueryYydTodoWeekStatisticalDataRequest request, QueryYydTodoWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydTodoWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydTodoWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydTodoWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉数字参谋待办分析（按周统计）指标接口
     *
     * @param request QueryYydTodoWeekStatisticalDataRequest
     * @return QueryYydTodoWeekStatisticalDataResponse
     */
    public QueryYydTodoWeekStatisticalDataResponse queryYydTodoWeekStatisticalData(QueryYydTodoWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTodoWeekStatisticalDataHeaders headers = new QueryYydTodoWeekStatisticalDataHeaders();
        return this.queryYydTodoWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉参谋全局概览（按日统计）指标接口
     *
     * @param request QueryYydTotalDayStatisticalDataRequest
     * @param headers QueryYydTotalDayStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydTotalDayStatisticalDataResponse
     */
    public QueryYydTotalDayStatisticalDataResponse queryYydTotalDayStatisticalDataWithOptions(QueryYydTotalDayStatisticalDataRequest request, QueryYydTotalDayStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydTotalDayStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydTotalDayDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydTotalDayStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉参谋全局概览（按日统计）指标接口
     *
     * @param request QueryYydTotalDayStatisticalDataRequest
     * @return QueryYydTotalDayStatisticalDataResponse
     */
    public QueryYydTotalDayStatisticalDataResponse queryYydTotalDayStatisticalData(QueryYydTotalDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTotalDayStatisticalDataHeaders headers = new QueryYydTotalDayStatisticalDataHeaders();
        return this.queryYydTotalDayStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉参谋全局概览（按月统计）指标接口
     *
     * @param request QueryYydTotalMonthStatisticalDataRequest
     * @param headers QueryYydTotalMonthStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydTotalMonthStatisticalDataResponse
     */
    public QueryYydTotalMonthStatisticalDataResponse queryYydTotalMonthStatisticalDataWithOptions(QueryYydTotalMonthStatisticalDataRequest request, QueryYydTotalMonthStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydTotalMonthStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydTotalMonthDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydTotalMonthStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉参谋全局概览（按月统计）指标接口
     *
     * @param request QueryYydTotalMonthStatisticalDataRequest
     * @return QueryYydTotalMonthStatisticalDataResponse
     */
    public QueryYydTotalMonthStatisticalDataResponse queryYydTotalMonthStatisticalData(QueryYydTotalMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTotalMonthStatisticalDataHeaders headers = new QueryYydTotalMonthStatisticalDataHeaders();
        return this.queryYydTotalMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉参谋全局概览（累计）指标接口
     *
     * @param request QueryYydTotalStdStatisticalDataRequest
     * @param headers QueryYydTotalStdStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydTotalStdStatisticalDataResponse
     */
    public QueryYydTotalStdStatisticalDataResponse queryYydTotalStdStatisticalDataWithOptions(QueryYydTotalStdStatisticalDataRequest request, QueryYydTotalStdStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydTotalStdStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydTotalStdDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydTotalStdStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉参谋全局概览（累计）指标接口
     *
     * @param request QueryYydTotalStdStatisticalDataRequest
     * @return QueryYydTotalStdStatisticalDataResponse
     */
    public QueryYydTotalStdStatisticalDataResponse queryYydTotalStdStatisticalData(QueryYydTotalStdStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTotalStdStatisticalDataHeaders headers = new QueryYydTotalStdStatisticalDataHeaders();
        return this.queryYydTotalStdStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 亚运钉参谋全局概览（按周统计）指标接口
     *
     * @param request QueryYydTotalWeekStatisticalDataRequest
     * @param headers QueryYydTotalWeekStatisticalDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryYydTotalWeekStatisticalDataResponse
     */
    public QueryYydTotalWeekStatisticalDataResponse queryYydTotalWeekStatisticalDataWithOptions(QueryYydTotalWeekStatisticalDataRequest request, QueryYydTotalWeekStatisticalDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryYydTotalWeekStatisticalData"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/yydTotalWeekDatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryYydTotalWeekStatisticalDataResponse());
    }

    /**
     * @summary 亚运钉参谋全局概览（按周统计）指标接口
     *
     * @param request QueryYydTotalWeekStatisticalDataRequest
     * @return QueryYydTotalWeekStatisticalDataResponse
     */
    public QueryYydTotalWeekStatisticalDataResponse queryYydTotalWeekStatisticalData(QueryYydTotalWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTotalWeekStatisticalDataHeaders headers = new QueryYydTotalWeekStatisticalDataHeaders();
        return this.queryYydTotalWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 通过关键词搜索企业
     *
     * @param request SearchCompanyRequest
     * @param headers SearchCompanyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchCompanyResponse
     */
    public SearchCompanyResponse searchCompanyWithOptions(SearchCompanyRequest request, SearchCompanyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchKey)) {
            query.put("searchKey", request.searchKey);
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
            new TeaPair("action", "SearchCompany"),
            new TeaPair("version", "datacenter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/datacenter/keywords/companies"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchCompanyResponse());
    }

    /**
     * @summary 通过关键词搜索企业
     *
     * @param request SearchCompanyRequest
     * @return SearchCompanyResponse
     */
    public SearchCompanyResponse searchCompany(SearchCompanyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchCompanyHeaders headers = new SearchCompanyHeaders();
        return this.searchCompanyWithOptions(request, headers, runtime);
    }
}
