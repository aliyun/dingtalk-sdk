// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdatacenter_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public GetAbnormalOperationResponse getAbnormalOperation(GetAbnormalOperationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAbnormalOperationHeaders headers = new GetAbnormalOperationHeaders();
        return this.getAbnormalOperationWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetAbnormalOperation", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/companies/abnormalOperations", "json", req, runtime), new GetAbnormalOperationResponse());
    }

    public GetAdministrativePenaltiesResponse getAdministrativePenalties(GetAdministrativePenaltiesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAdministrativePenaltiesHeaders headers = new GetAdministrativePenaltiesHeaders();
        return this.getAdministrativePenaltiesWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetAdministrativePenalties", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/companies/administrativePenalties", "json", req, runtime), new GetAdministrativePenaltiesResponse());
    }

    public GetBasicInfoResponse getBasicInfo(GetBasicInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetBasicInfoHeaders headers = new GetBasicInfoHeaders();
        return this.getBasicInfoWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetBasicInfo", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/companies/businessBasicInfos", "json", req, runtime), new GetBasicInfoResponse());
    }

    public GetEnvironmentalPenaltiesResponse getEnvironmentalPenalties(GetEnvironmentalPenaltiesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEnvironmentalPenaltiesHeaders headers = new GetEnvironmentalPenaltiesHeaders();
        return this.getEnvironmentalPenaltiesWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetEnvironmentalPenalties", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/companies/environmentalPenalties", "json", req, runtime), new GetEnvironmentalPenaltiesResponse());
    }

    public GetHolderInfoResponse getHolderInfo(GetHolderInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetHolderInfoHeaders headers = new GetHolderInfoHeaders();
        return this.getHolderInfoWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetHolderInfo", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/companies/shareholderInfos", "json", req, runtime), new GetHolderInfoResponse());
    }

    public GetQeneralTaxpayerInfoResponse getQeneralTaxpayerInfo(GetQeneralTaxpayerInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetQeneralTaxpayerInfoHeaders headers = new GetQeneralTaxpayerInfoHeaders();
        return this.getQeneralTaxpayerInfoWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetQeneralTaxpayerInfo", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/companies/generalTaxpayerInfos", "json", req, runtime), new GetQeneralTaxpayerInfoResponse());
    }

    public GetSeriousViolationResponse getSeriousViolation(GetSeriousViolationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSeriousViolationHeaders headers = new GetSeriousViolationHeaders();
        return this.getSeriousViolationWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetSeriousViolation", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/companies/seriousViolations", "json", req, runtime), new GetSeriousViolationResponse());
    }

    public PostCorpAuthInfoResponse postCorpAuthInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PostCorpAuthInfoHeaders headers = new PostCorpAuthInfoHeaders();
        return this.postCorpAuthInfoWithOptions(headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("PostCorpAuthInfo", "datacenter_1.0", "HTTP", "POST", "AK", "/v1.0/datacenter/corporations/authorize", "json", req, runtime), new PostCorpAuthInfoResponse());
    }

    public QueryActiveUserStatisticalDataResponse queryActiveUserStatisticalData(QueryActiveUserStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryActiveUserStatisticalDataHeaders headers = new QueryActiveUserStatisticalDataHeaders();
        return this.queryActiveUserStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryActiveUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/activeUserData", "json", req, runtime), new QueryActiveUserStatisticalDataResponse());
    }

    public QueryAnhmdStatisticalDataResponse queryAnhmdStatisticalData(QueryAnhmdStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAnhmdStatisticalDataHeaders headers = new QueryAnhmdStatisticalDataHeaders();
        return this.queryAnhmdStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryAnhmdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/statisticDatas/anHmd", "json", req, runtime), new QueryAnhmdStatisticalDataResponse());
    }

    public QueryApprovalStatisticalDataResponse queryApprovalStatisticalData(QueryApprovalStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryApprovalStatisticalDataHeaders headers = new QueryApprovalStatisticalDataHeaders();
        return this.queryApprovalStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryApprovalStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/approvalData", "json", req, runtime), new QueryApprovalStatisticalDataResponse());
    }

    public QueryAttendanceStatisticalDataResponse queryAttendanceStatisticalData(QueryAttendanceStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAttendanceStatisticalDataHeaders headers = new QueryAttendanceStatisticalDataHeaders();
        return this.queryAttendanceStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryAttendanceStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/attendanceData", "json", req, runtime), new QueryAttendanceStatisticalDataResponse());
    }

    public QueryBlackboardStatisticalDataResponse queryBlackboardStatisticalData(QueryBlackboardStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBlackboardStatisticalDataHeaders headers = new QueryBlackboardStatisticalDataHeaders();
        return this.queryBlackboardStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryBlackboardStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/blackboardData", "json", req, runtime), new QueryBlackboardStatisticalDataResponse());
    }

    public QueryCalendarStatisticalDataResponse queryCalendarStatisticalData(QueryCalendarStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCalendarStatisticalDataHeaders headers = new QueryCalendarStatisticalDataHeaders();
        return this.queryCalendarStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryCalendarStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/calendarData", "json", req, runtime), new QueryCalendarStatisticalDataResponse());
    }

    public QueryCheckinStatisticalDataResponse queryCheckinStatisticalData(QueryCheckinStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCheckinStatisticalDataHeaders headers = new QueryCheckinStatisticalDataHeaders();
        return this.queryCheckinStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryCheckinStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/checkinData", "json", req, runtime), new QueryCheckinStatisticalDataResponse());
    }

    public QueryCircleStatisticalDataResponse queryCircleStatisticalData(QueryCircleStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCircleStatisticalDataHeaders headers = new QueryCircleStatisticalDataHeaders();
        return this.queryCircleStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryCircleStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/circleData", "json", req, runtime), new QueryCircleStatisticalDataResponse());
    }

    public QueryCompanyBasicInfoResponse queryCompanyBasicInfo(QueryCompanyBasicInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCompanyBasicInfoHeaders headers = new QueryCompanyBasicInfoHeaders();
        return this.queryCompanyBasicInfoWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryCompanyBasicInfo", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/companies/basicInfo", "json", req, runtime), new QueryCompanyBasicInfoResponse());
    }

    public QueryDigitalDistrictOrgInfoResponse queryDigitalDistrictOrgInfo(QueryDigitalDistrictOrgInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDigitalDistrictOrgInfoHeaders headers = new QueryDigitalDistrictOrgInfoHeaders();
        return this.queryDigitalDistrictOrgInfoWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryDigitalDistrictOrgInfo", "datacenter_1.0", "HTTP", "POST", "AK", "/v1.0/datacenter/digitalCounty/orgInfos/query", "json", req, runtime), new QueryDigitalDistrictOrgInfoResponse());
    }

    public QueryDingReciveStatisticalDataResponse queryDingReciveStatisticalData(QueryDingReciveStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDingReciveStatisticalDataHeaders headers = new QueryDingReciveStatisticalDataHeaders();
        return this.queryDingReciveStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryDingReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/dingReciveData", "json", req, runtime), new QueryDingReciveStatisticalDataResponse());
    }

    public QueryDingSendStatisticalDataResponse queryDingSendStatisticalData(QueryDingSendStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDingSendStatisticalDataHeaders headers = new QueryDingSendStatisticalDataHeaders();
        return this.queryDingSendStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryDingSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/dingSendData", "json", req, runtime), new QueryDingSendStatisticalDataResponse());
    }

    public QueryDocumentStatisticalDataResponse queryDocumentStatisticalData(QueryDocumentStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDocumentStatisticalDataHeaders headers = new QueryDocumentStatisticalDataHeaders();
        return this.queryDocumentStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryDocumentStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/documentData", "json", req, runtime), new QueryDocumentStatisticalDataResponse());
    }

    public QueryDriveStatisticalDataResponse queryDriveStatisticalData(QueryDriveStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDriveStatisticalDataHeaders headers = new QueryDriveStatisticalDataHeaders();
        return this.queryDriveStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryDriveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/driveData", "json", req, runtime), new QueryDriveStatisticalDataResponse());
    }

    public QueryEmployeeTypeStatisticalDataResponse queryEmployeeTypeStatisticalData(QueryEmployeeTypeStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryEmployeeTypeStatisticalDataHeaders headers = new QueryEmployeeTypeStatisticalDataHeaders();
        return this.queryEmployeeTypeStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryEmployeeTypeStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/employeeTypeData", "json", req, runtime), new QueryEmployeeTypeStatisticalDataResponse());
    }

    public QueryGeneralDataServiceResponse queryGeneralDataService(QueryGeneralDataServiceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGeneralDataServiceHeaders headers = new QueryGeneralDataServiceHeaders();
        return this.queryGeneralDataServiceWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryGeneralDataService", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/generalDataServices", "json", req, runtime), new QueryGeneralDataServiceResponse());
    }

    public QueryGroupLiveStatisticalDataResponse queryGroupLiveStatisticalData(QueryGroupLiveStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupLiveStatisticalDataHeaders headers = new QueryGroupLiveStatisticalDataHeaders();
        return this.queryGroupLiveStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryGroupLiveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/groupLiveData", "json", req, runtime), new QueryGroupLiveStatisticalDataResponse());
    }

    public QueryGroupMessageStatisticalDataResponse queryGroupMessageStatisticalData(QueryGroupMessageStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupMessageStatisticalDataHeaders headers = new QueryGroupMessageStatisticalDataHeaders();
        return this.queryGroupMessageStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryGroupMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/groupMessageData", "json", req, runtime), new QueryGroupMessageStatisticalDataResponse());
    }

    public QueryHealthStatisticalDataResponse queryHealthStatisticalData(QueryHealthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHealthStatisticalDataHeaders headers = new QueryHealthStatisticalDataHeaders();
        return this.queryHealthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryHealthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/healtheUserData", "json", req, runtime), new QueryHealthStatisticalDataResponse());
    }

    public QueryMailStatisticalDataResponse queryMailStatisticalData(QueryMailStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMailStatisticalDataHeaders headers = new QueryMailStatisticalDataHeaders();
        return this.queryMailStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryMailStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/mailData", "json", req, runtime), new QueryMailStatisticalDataResponse());
    }

    public QueryOfficialDataResponse queryOfficialData(QueryOfficialDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOfficialDataHeaders headers = new QueryOfficialDataHeaders();
        return this.queryOfficialDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryOfficialData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/datas", "json", req, runtime), new QueryOfficialDataResponse());
    }

    public QueryOfficialDatasetFieldsResponse queryOfficialDatasetFields(QueryOfficialDatasetFieldsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOfficialDatasetFieldsHeaders headers = new QueryOfficialDatasetFieldsHeaders();
        return this.queryOfficialDatasetFieldsWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryOfficialDatasetFields", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/datasetFields", "json", req, runtime), new QueryOfficialDatasetFieldsResponse());
    }

    public QueryOfficialDatasetListResponse queryOfficialDatasetList(QueryOfficialDatasetListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOfficialDatasetListHeaders headers = new QueryOfficialDatasetListHeaders();
        return this.queryOfficialDatasetListWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryOfficialDatasetList", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/datasetLists", "json", req, runtime), new QueryOfficialDatasetListResponse());
    }

    public QueryOnlineUserStatisticalDataResponse queryOnlineUserStatisticalData(QueryOnlineUserStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOnlineUserStatisticalDataHeaders headers = new QueryOnlineUserStatisticalDataHeaders();
        return this.queryOnlineUserStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryOnlineUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/onlineUserData", "json", req, runtime), new QueryOnlineUserStatisticalDataResponse());
    }

    public QueryRedEnvelopeReciveStatisticalDataResponse queryRedEnvelopeReciveStatisticalData(QueryRedEnvelopeReciveStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRedEnvelopeReciveStatisticalDataHeaders headers = new QueryRedEnvelopeReciveStatisticalDataHeaders();
        return this.queryRedEnvelopeReciveStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryRedEnvelopeReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/redEnvelopeReciveData", "json", req, runtime), new QueryRedEnvelopeReciveStatisticalDataResponse());
    }

    public QueryRedEnvelopeSendStatisticalDataResponse queryRedEnvelopeSendStatisticalData(QueryRedEnvelopeSendStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRedEnvelopeSendStatisticalDataHeaders headers = new QueryRedEnvelopeSendStatisticalDataHeaders();
        return this.queryRedEnvelopeSendStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryRedEnvelopeSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/redEnvelopeSendData", "json", req, runtime), new QueryRedEnvelopeSendStatisticalDataResponse());
    }

    public QueryReportStatisticalDataResponse queryReportStatisticalData(QueryReportStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryReportStatisticalDataHeaders headers = new QueryReportStatisticalDataHeaders();
        return this.queryReportStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryReportStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/reportData", "json", req, runtime), new QueryReportStatisticalDataResponse());
    }

    public QuerySingleMessageStatisticalDataResponse querySingleMessageStatisticalData(QuerySingleMessageStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySingleMessageStatisticalDataHeaders headers = new QuerySingleMessageStatisticalDataHeaders();
        return this.querySingleMessageStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QuerySingleMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/singleMessagerData", "json", req, runtime), new QuerySingleMessageStatisticalDataResponse());
    }

    public QueryTelMeetingStatisticalDataResponse queryTelMeetingStatisticalData(QueryTelMeetingStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTelMeetingStatisticalDataHeaders headers = new QueryTelMeetingStatisticalDataHeaders();
        return this.queryTelMeetingStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryTelMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/telMeetingData", "json", req, runtime), new QueryTelMeetingStatisticalDataResponse());
    }

    public QueryTodoStatisticalDataResponse queryTodoStatisticalData(QueryTodoStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTodoStatisticalDataHeaders headers = new QueryTodoStatisticalDataHeaders();
        return this.queryTodoStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryTodoStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/todoUserData", "json", req, runtime), new QueryTodoStatisticalDataResponse());
    }

    public QueryVedioMeetingStatisticalDataResponse queryVedioMeetingStatisticalData(QueryVedioMeetingStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryVedioMeetingStatisticalDataHeaders headers = new QueryVedioMeetingStatisticalDataHeaders();
        return this.queryVedioMeetingStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryVedioMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/vedioMeetingData", "json", req, runtime), new QueryVedioMeetingStatisticalDataResponse());
    }

    public QueryYydActiveDayStatisticalDataResponse queryYydActiveDayStatisticalData(QueryYydActiveDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydActiveDayStatisticalDataHeaders headers = new QueryYydActiveDayStatisticalDataHeaders();
        return this.queryYydActiveDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydActiveDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveDayDatas", "json", req, runtime), new QueryYydActiveDayStatisticalDataResponse());
    }

    public QueryYydActiveMonthStatisticalDataResponse queryYydActiveMonthStatisticalData(QueryYydActiveMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydActiveMonthStatisticalDataHeaders headers = new QueryYydActiveMonthStatisticalDataHeaders();
        return this.queryYydActiveMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydActiveMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveMonthDatas", "json", req, runtime), new QueryYydActiveMonthStatisticalDataResponse());
    }

    public QueryYydActiveWeekStatisticalDataResponse queryYydActiveWeekStatisticalData(QueryYydActiveWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydActiveWeekStatisticalDataHeaders headers = new QueryYydActiveWeekStatisticalDataHeaders();
        return this.queryYydActiveWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydActiveWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveWeekDatas", "json", req, runtime), new QueryYydActiveWeekStatisticalDataResponse());
    }

    public QueryYydAppDayStatisticalDataResponse queryYydAppDayStatisticalData(QueryYydAppDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydAppDayStatisticalDataHeaders headers = new QueryYydAppDayStatisticalDataHeaders();
        return this.queryYydAppDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydAppDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppDayDatas", "json", req, runtime), new QueryYydAppDayStatisticalDataResponse());
    }

    public QueryYydAppMonthStatisticalDataResponse queryYydAppMonthStatisticalData(QueryYydAppMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydAppMonthStatisticalDataHeaders headers = new QueryYydAppMonthStatisticalDataHeaders();
        return this.queryYydAppMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydAppMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppMonthDatas", "json", req, runtime), new QueryYydAppMonthStatisticalDataResponse());
    }

    public QueryYydAppStdStatisticalDataResponse queryYydAppStdStatisticalData(QueryYydAppStdStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydAppStdStatisticalDataHeaders headers = new QueryYydAppStdStatisticalDataHeaders();
        return this.queryYydAppStdStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydAppStdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppStdDatas", "json", req, runtime), new QueryYydAppStdStatisticalDataResponse());
    }

    public QueryYydAppWeekStatisticalDataResponse queryYydAppWeekStatisticalData(QueryYydAppWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydAppWeekStatisticalDataHeaders headers = new QueryYydAppWeekStatisticalDataHeaders();
        return this.queryYydAppWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydAppWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppWeekDatas", "json", req, runtime), new QueryYydAppWeekStatisticalDataResponse());
    }

    public QueryYydCalendarDayStatisticalDataResponse queryYydCalendarDayStatisticalData(QueryYydCalendarDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydCalendarDayStatisticalDataHeaders headers = new QueryYydCalendarDayStatisticalDataHeaders();
        return this.queryYydCalendarDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydCalendarDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarDayDatas", "json", req, runtime), new QueryYydCalendarDayStatisticalDataResponse());
    }

    public QueryYydCalendarMonthStatisticalDataResponse queryYydCalendarMonthStatisticalData(QueryYydCalendarMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydCalendarMonthStatisticalDataHeaders headers = new QueryYydCalendarMonthStatisticalDataHeaders();
        return this.queryYydCalendarMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydCalendarMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarMonthDatas", "json", req, runtime), new QueryYydCalendarMonthStatisticalDataResponse());
    }

    public QueryYydCalendarWeekStatisticalDataResponse queryYydCalendarWeekStatisticalData(QueryYydCalendarWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydCalendarWeekStatisticalDataHeaders headers = new QueryYydCalendarWeekStatisticalDataHeaders();
        return this.queryYydCalendarWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydCalendarWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarWeekDatas", "json", req, runtime), new QueryYydCalendarWeekStatisticalDataResponse());
    }

    public QueryYydDingMsgDayStatisticalDataResponse queryYydDingMsgDayStatisticalData(QueryYydDingMsgDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydDingMsgDayStatisticalDataHeaders headers = new QueryYydDingMsgDayStatisticalDataHeaders();
        return this.queryYydDingMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydDingMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgDayDatas", "json", req, runtime), new QueryYydDingMsgDayStatisticalDataResponse());
    }

    public QueryYydDingMsgMonthStatisticalDataResponse queryYydDingMsgMonthStatisticalData(QueryYydDingMsgMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydDingMsgMonthStatisticalDataHeaders headers = new QueryYydDingMsgMonthStatisticalDataHeaders();
        return this.queryYydDingMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydDingMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgMonthDatas", "json", req, runtime), new QueryYydDingMsgMonthStatisticalDataResponse());
    }

    public QueryYydDingMsgWeekStatisticalDataResponse queryYydDingMsgWeekStatisticalData(QueryYydDingMsgWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydDingMsgWeekStatisticalDataHeaders headers = new QueryYydDingMsgWeekStatisticalDataHeaders();
        return this.queryYydDingMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydDingMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgWeekDatas", "json", req, runtime), new QueryYydDingMsgWeekStatisticalDataResponse());
    }

    public QueryYydGroupMsgDayStatisticalDataResponse queryYydGroupMsgDayStatisticalData(QueryYydGroupMsgDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydGroupMsgDayStatisticalDataHeaders headers = new QueryYydGroupMsgDayStatisticalDataHeaders();
        return this.queryYydGroupMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydGroupMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgDayDatas", "json", req, runtime), new QueryYydGroupMsgDayStatisticalDataResponse());
    }

    public QueryYydGroupMsgMonthStatisticalDataResponse queryYydGroupMsgMonthStatisticalData(QueryYydGroupMsgMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydGroupMsgMonthStatisticalDataHeaders headers = new QueryYydGroupMsgMonthStatisticalDataHeaders();
        return this.queryYydGroupMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydGroupMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgMonthDatas", "json", req, runtime), new QueryYydGroupMsgMonthStatisticalDataResponse());
    }

    public QueryYydGroupMsgWeekStatisticalDataResponse queryYydGroupMsgWeekStatisticalData(QueryYydGroupMsgWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydGroupMsgWeekStatisticalDataHeaders headers = new QueryYydGroupMsgWeekStatisticalDataHeaders();
        return this.queryYydGroupMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydGroupMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgWeekDatas", "json", req, runtime), new QueryYydGroupMsgWeekStatisticalDataResponse());
    }

    public QueryYydLogDayStatisticalDataResponse queryYydLogDayStatisticalData(QueryYydLogDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydLogDayStatisticalDataHeaders headers = new QueryYydLogDayStatisticalDataHeaders();
        return this.queryYydLogDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydLogDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogDayDatas", "json", req, runtime), new QueryYydLogDayStatisticalDataResponse());
    }

    public QueryYydLogMonthStatisticalDataResponse queryYydLogMonthStatisticalData(QueryYydLogMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydLogMonthStatisticalDataHeaders headers = new QueryYydLogMonthStatisticalDataHeaders();
        return this.queryYydLogMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydLogMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogMonthDatas", "json", req, runtime), new QueryYydLogMonthStatisticalDataResponse());
    }

    public QueryYydLogWeekStatisticalDataResponse queryYydLogWeekStatisticalData(QueryYydLogWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydLogWeekStatisticalDataHeaders headers = new QueryYydLogWeekStatisticalDataHeaders();
        return this.queryYydLogWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydLogWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogWeekDatas", "json", req, runtime), new QueryYydLogWeekStatisticalDataResponse());
    }

    public QueryYydMeetingDayStatisticalDataResponse queryYydMeetingDayStatisticalData(QueryYydMeetingDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydMeetingDayStatisticalDataHeaders headers = new QueryYydMeetingDayStatisticalDataHeaders();
        return this.queryYydMeetingDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydMeetingDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingDayDatas", "json", req, runtime), new QueryYydMeetingDayStatisticalDataResponse());
    }

    public QueryYydMeetingMonthStatisticalDataResponse queryYydMeetingMonthStatisticalData(QueryYydMeetingMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydMeetingMonthStatisticalDataHeaders headers = new QueryYydMeetingMonthStatisticalDataHeaders();
        return this.queryYydMeetingMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydMeetingMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingMonthDatas", "json", req, runtime), new QueryYydMeetingMonthStatisticalDataResponse());
    }

    public QueryYydMeetingWeekStatisticalDataResponse queryYydMeetingWeekStatisticalData(QueryYydMeetingWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydMeetingWeekStatisticalDataHeaders headers = new QueryYydMeetingWeekStatisticalDataHeaders();
        return this.queryYydMeetingWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydMeetingWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingWeekDatas", "json", req, runtime), new QueryYydMeetingWeekStatisticalDataResponse());
    }

    public QueryYydNoticeDayStatisticalDataResponse queryYydNoticeDayStatisticalData(QueryYydNoticeDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydNoticeDayStatisticalDataHeaders headers = new QueryYydNoticeDayStatisticalDataHeaders();
        return this.queryYydNoticeDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydNoticeDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeDayDatas", "json", req, runtime), new QueryYydNoticeDayStatisticalDataResponse());
    }

    public QueryYydNoticeMonthStatisticalDataResponse queryYydNoticeMonthStatisticalData(QueryYydNoticeMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydNoticeMonthStatisticalDataHeaders headers = new QueryYydNoticeMonthStatisticalDataHeaders();
        return this.queryYydNoticeMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydNoticeMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeMonthDatas", "json", req, runtime), new QueryYydNoticeMonthStatisticalDataResponse());
    }

    public QueryYydNoticeWeekStatisticalDataResponse queryYydNoticeWeekStatisticalData(QueryYydNoticeWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydNoticeWeekStatisticalDataHeaders headers = new QueryYydNoticeWeekStatisticalDataHeaders();
        return this.queryYydNoticeWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydNoticeWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeWeekDatas", "json", req, runtime), new QueryYydNoticeWeekStatisticalDataResponse());
    }

    public QueryYydSingleMsgDayStatisticalDataResponse queryYydSingleMsgDayStatisticalData(QueryYydSingleMsgDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydSingleMsgDayStatisticalDataHeaders headers = new QueryYydSingleMsgDayStatisticalDataHeaders();
        return this.queryYydSingleMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydSingleMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgDayDatas", "json", req, runtime), new QueryYydSingleMsgDayStatisticalDataResponse());
    }

    public QueryYydSingleMsgMonthStatisticalDataResponse queryYydSingleMsgMonthStatisticalData(QueryYydSingleMsgMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydSingleMsgMonthStatisticalDataHeaders headers = new QueryYydSingleMsgMonthStatisticalDataHeaders();
        return this.queryYydSingleMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydSingleMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgMonthDatas", "json", req, runtime), new QueryYydSingleMsgMonthStatisticalDataResponse());
    }

    public QueryYydSingleMsgWeekStatisticalDataResponse queryYydSingleMsgWeekStatisticalData(QueryYydSingleMsgWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydSingleMsgWeekStatisticalDataHeaders headers = new QueryYydSingleMsgWeekStatisticalDataHeaders();
        return this.queryYydSingleMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydSingleMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgWeekDatas", "json", req, runtime), new QueryYydSingleMsgWeekStatisticalDataResponse());
    }

    public QueryYydToatlMsgDayStatisticalDataResponse queryYydToatlMsgDayStatisticalData(QueryYydToatlMsgDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydToatlMsgDayStatisticalDataHeaders headers = new QueryYydToatlMsgDayStatisticalDataHeaders();
        return this.queryYydToatlMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydToatlMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgDayDatas", "json", req, runtime), new QueryYydToatlMsgDayStatisticalDataResponse());
    }

    public QueryYydToatlMsgMonthStatisticalDataResponse queryYydToatlMsgMonthStatisticalData(QueryYydToatlMsgMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydToatlMsgMonthStatisticalDataHeaders headers = new QueryYydToatlMsgMonthStatisticalDataHeaders();
        return this.queryYydToatlMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydToatlMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgMonthDatas", "json", req, runtime), new QueryYydToatlMsgMonthStatisticalDataResponse());
    }

    public QueryYydToatlMsgWeekStatisticalDataResponse queryYydToatlMsgWeekStatisticalData(QueryYydToatlMsgWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydToatlMsgWeekStatisticalDataHeaders headers = new QueryYydToatlMsgWeekStatisticalDataHeaders();
        return this.queryYydToatlMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydToatlMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgWeekDatas", "json", req, runtime), new QueryYydToatlMsgWeekStatisticalDataResponse());
    }

    public QueryYydTodoDayStatisticalDataResponse queryYydTodoDayStatisticalData(QueryYydTodoDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTodoDayStatisticalDataHeaders headers = new QueryYydTodoDayStatisticalDataHeaders();
        return this.queryYydTodoDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydTodoDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoDayDatas", "json", req, runtime), new QueryYydTodoDayStatisticalDataResponse());
    }

    public QueryYydTodoMonthStatisticalDataResponse queryYydTodoMonthStatisticalData(QueryYydTodoMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTodoMonthStatisticalDataHeaders headers = new QueryYydTodoMonthStatisticalDataHeaders();
        return this.queryYydTodoMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydTodoMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoMonthDatas", "json", req, runtime), new QueryYydTodoMonthStatisticalDataResponse());
    }

    public QueryYydTodoWeekStatisticalDataResponse queryYydTodoWeekStatisticalData(QueryYydTodoWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTodoWeekStatisticalDataHeaders headers = new QueryYydTodoWeekStatisticalDataHeaders();
        return this.queryYydTodoWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydTodoWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoWeekDatas", "json", req, runtime), new QueryYydTodoWeekStatisticalDataResponse());
    }

    public QueryYydTotalDayStatisticalDataResponse queryYydTotalDayStatisticalData(QueryYydTotalDayStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTotalDayStatisticalDataHeaders headers = new QueryYydTotalDayStatisticalDataHeaders();
        return this.queryYydTotalDayStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydTotalDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalDayDatas", "json", req, runtime), new QueryYydTotalDayStatisticalDataResponse());
    }

    public QueryYydTotalMonthStatisticalDataResponse queryYydTotalMonthStatisticalData(QueryYydTotalMonthStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTotalMonthStatisticalDataHeaders headers = new QueryYydTotalMonthStatisticalDataHeaders();
        return this.queryYydTotalMonthStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydTotalMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalMonthDatas", "json", req, runtime), new QueryYydTotalMonthStatisticalDataResponse());
    }

    public QueryYydTotalStdStatisticalDataResponse queryYydTotalStdStatisticalData(QueryYydTotalStdStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTotalStdStatisticalDataHeaders headers = new QueryYydTotalStdStatisticalDataHeaders();
        return this.queryYydTotalStdStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydTotalStdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalStdDatas", "json", req, runtime), new QueryYydTotalStdStatisticalDataResponse());
    }

    public QueryYydTotalWeekStatisticalDataResponse queryYydTotalWeekStatisticalData(QueryYydTotalWeekStatisticalDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryYydTotalWeekStatisticalDataHeaders headers = new QueryYydTotalWeekStatisticalDataHeaders();
        return this.queryYydTotalWeekStatisticalDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("QueryYydTotalWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalWeekDatas", "json", req, runtime), new QueryYydTotalWeekStatisticalDataResponse());
    }

    public SearchCompanyResponse searchCompany(SearchCompanyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchCompanyHeaders headers = new SearchCompanyHeaders();
        return this.searchCompanyWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("SearchCompany", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/keywords/companies", "json", req, runtime), new SearchCompanyResponse());
    }
}
