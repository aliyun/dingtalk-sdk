// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdatacenter_1_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;
import com.aliyun.openapiutil.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public QueryActiveUserStatisticalDataResponse queryActiveUserStatisticalData(QueryActiveUserStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryActiveUserStatisticalDataHeaders headers = new QueryActiveUserStatisticalDataHeaders();
        return this.queryActiveUserStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryActiveUserStatisticalDataResponse queryActiveUserStatisticalDataWithOptions(QueryActiveUserStatisticalDataRequest request, QueryActiveUserStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryActiveUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/activeUserData", "json", req, runtime), new QueryActiveUserStatisticalDataResponse());
    }

    public QueryApprovalStatisticalDataResponse queryApprovalStatisticalData(QueryApprovalStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryApprovalStatisticalDataHeaders headers = new QueryApprovalStatisticalDataHeaders();
        return this.queryApprovalStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryApprovalStatisticalDataResponse queryApprovalStatisticalDataWithOptions(QueryApprovalStatisticalDataRequest request, QueryApprovalStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryApprovalStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/approvalData", "json", req, runtime), new QueryApprovalStatisticalDataResponse());
    }

    public QueryAttendanceStatisticalDataResponse queryAttendanceStatisticalData(QueryAttendanceStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAttendanceStatisticalDataHeaders headers = new QueryAttendanceStatisticalDataHeaders();
        return this.queryAttendanceStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryAttendanceStatisticalDataResponse queryAttendanceStatisticalDataWithOptions(QueryAttendanceStatisticalDataRequest request, QueryAttendanceStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryAttendanceStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/attendanceData", "json", req, runtime), new QueryAttendanceStatisticalDataResponse());
    }

    public QueryBlackboardStatisticalDataResponse queryBlackboardStatisticalData(QueryBlackboardStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryBlackboardStatisticalDataHeaders headers = new QueryBlackboardStatisticalDataHeaders();
        return this.queryBlackboardStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryBlackboardStatisticalDataResponse queryBlackboardStatisticalDataWithOptions(QueryBlackboardStatisticalDataRequest request, QueryBlackboardStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryBlackboardStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/blackboardData", "json", req, runtime), new QueryBlackboardStatisticalDataResponse());
    }

    public QueryCalendarStatisticalDataResponse queryCalendarStatisticalData(QueryCalendarStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCalendarStatisticalDataHeaders headers = new QueryCalendarStatisticalDataHeaders();
        return this.queryCalendarStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryCalendarStatisticalDataResponse queryCalendarStatisticalDataWithOptions(QueryCalendarStatisticalDataRequest request, QueryCalendarStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryCalendarStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/calendarData", "json", req, runtime), new QueryCalendarStatisticalDataResponse());
    }

    public QueryCheckinStatisticalDataResponse queryCheckinStatisticalData(QueryCheckinStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCheckinStatisticalDataHeaders headers = new QueryCheckinStatisticalDataHeaders();
        return this.queryCheckinStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryCheckinStatisticalDataResponse queryCheckinStatisticalDataWithOptions(QueryCheckinStatisticalDataRequest request, QueryCheckinStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryCheckinStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/checkinData", "json", req, runtime), new QueryCheckinStatisticalDataResponse());
    }

    public QueryCircleStatisticalDataResponse queryCircleStatisticalData(QueryCircleStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCircleStatisticalDataHeaders headers = new QueryCircleStatisticalDataHeaders();
        return this.queryCircleStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryCircleStatisticalDataResponse queryCircleStatisticalDataWithOptions(QueryCircleStatisticalDataRequest request, QueryCircleStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryCircleStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/circleData", "json", req, runtime), new QueryCircleStatisticalDataResponse());
    }

    public QueryCompanyBasicInfoResponse queryCompanyBasicInfo(QueryCompanyBasicInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCompanyBasicInfoHeaders headers = new QueryCompanyBasicInfoHeaders();
        return this.queryCompanyBasicInfoWithOptions(request, headers, runtime);
    }

    public QueryCompanyBasicInfoResponse queryCompanyBasicInfoWithOptions(QueryCompanyBasicInfoRequest request, QueryCompanyBasicInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryCompanyBasicInfo", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/companies/basicInfo", "json", req, runtime), new QueryCompanyBasicInfoResponse());
    }

    public QueryDigitalDistrictOrgInfoResponse queryDigitalDistrictOrgInfo(QueryDigitalDistrictOrgInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryDigitalDistrictOrgInfoHeaders headers = new QueryDigitalDistrictOrgInfoHeaders();
        return this.queryDigitalDistrictOrgInfoWithOptions(request, headers, runtime);
    }

    public QueryDigitalDistrictOrgInfoResponse queryDigitalDistrictOrgInfoWithOptions(QueryDigitalDistrictOrgInfoRequest request, QueryDigitalDistrictOrgInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("QueryDigitalDistrictOrgInfo", "datacenter_1.0", "HTTP", "POST", "AK", "/v1.0/datacenter/digitalCounty/orgInfos/query", "json", req, runtime), new QueryDigitalDistrictOrgInfoResponse());
    }

    public QueryDingReciveStatisticalDataResponse queryDingReciveStatisticalData(QueryDingReciveStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryDingReciveStatisticalDataHeaders headers = new QueryDingReciveStatisticalDataHeaders();
        return this.queryDingReciveStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryDingReciveStatisticalDataResponse queryDingReciveStatisticalDataWithOptions(QueryDingReciveStatisticalDataRequest request, QueryDingReciveStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryDingReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/dingReciveData", "json", req, runtime), new QueryDingReciveStatisticalDataResponse());
    }

    public QueryDingSendStatisticalDataResponse queryDingSendStatisticalData(QueryDingSendStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryDingSendStatisticalDataHeaders headers = new QueryDingSendStatisticalDataHeaders();
        return this.queryDingSendStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryDingSendStatisticalDataResponse queryDingSendStatisticalDataWithOptions(QueryDingSendStatisticalDataRequest request, QueryDingSendStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryDingSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/dingSendData", "json", req, runtime), new QueryDingSendStatisticalDataResponse());
    }

    public QueryDocumentStatisticalDataResponse queryDocumentStatisticalData(QueryDocumentStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryDocumentStatisticalDataHeaders headers = new QueryDocumentStatisticalDataHeaders();
        return this.queryDocumentStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryDocumentStatisticalDataResponse queryDocumentStatisticalDataWithOptions(QueryDocumentStatisticalDataRequest request, QueryDocumentStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryDocumentStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/documentData", "json", req, runtime), new QueryDocumentStatisticalDataResponse());
    }

    public QueryDriveStatisticalDataResponse queryDriveStatisticalData(QueryDriveStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryDriveStatisticalDataHeaders headers = new QueryDriveStatisticalDataHeaders();
        return this.queryDriveStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryDriveStatisticalDataResponse queryDriveStatisticalDataWithOptions(QueryDriveStatisticalDataRequest request, QueryDriveStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryDriveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/driveData", "json", req, runtime), new QueryDriveStatisticalDataResponse());
    }

    public QueryEmployeeTypeStatisticalDataResponse queryEmployeeTypeStatisticalData(QueryEmployeeTypeStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryEmployeeTypeStatisticalDataHeaders headers = new QueryEmployeeTypeStatisticalDataHeaders();
        return this.queryEmployeeTypeStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryEmployeeTypeStatisticalDataResponse queryEmployeeTypeStatisticalDataWithOptions(QueryEmployeeTypeStatisticalDataRequest request, QueryEmployeeTypeStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryEmployeeTypeStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/employeeTypeData", "json", req, runtime), new QueryEmployeeTypeStatisticalDataResponse());
    }

    public QueryGroupLiveStatisticalDataResponse queryGroupLiveStatisticalData(QueryGroupLiveStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryGroupLiveStatisticalDataHeaders headers = new QueryGroupLiveStatisticalDataHeaders();
        return this.queryGroupLiveStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryGroupLiveStatisticalDataResponse queryGroupLiveStatisticalDataWithOptions(QueryGroupLiveStatisticalDataRequest request, QueryGroupLiveStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryGroupLiveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/groupLiveData", "json", req, runtime), new QueryGroupLiveStatisticalDataResponse());
    }

    public QueryGroupMessageStatisticalDataResponse queryGroupMessageStatisticalData(QueryGroupMessageStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryGroupMessageStatisticalDataHeaders headers = new QueryGroupMessageStatisticalDataHeaders();
        return this.queryGroupMessageStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryGroupMessageStatisticalDataResponse queryGroupMessageStatisticalDataWithOptions(QueryGroupMessageStatisticalDataRequest request, QueryGroupMessageStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryGroupMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/groupMessageData", "json", req, runtime), new QueryGroupMessageStatisticalDataResponse());
    }

    public QueryHealthStatisticalDataResponse queryHealthStatisticalData(QueryHealthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryHealthStatisticalDataHeaders headers = new QueryHealthStatisticalDataHeaders();
        return this.queryHealthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryHealthStatisticalDataResponse queryHealthStatisticalDataWithOptions(QueryHealthStatisticalDataRequest request, QueryHealthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryHealthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/healtheUserData", "json", req, runtime), new QueryHealthStatisticalDataResponse());
    }

    public QueryMailStatisticalDataResponse queryMailStatisticalData(QueryMailStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryMailStatisticalDataHeaders headers = new QueryMailStatisticalDataHeaders();
        return this.queryMailStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryMailStatisticalDataResponse queryMailStatisticalDataWithOptions(QueryMailStatisticalDataRequest request, QueryMailStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryMailStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/mailData", "json", req, runtime), new QueryMailStatisticalDataResponse());
    }

    public QueryOnlineUserStatisticalDataResponse queryOnlineUserStatisticalData(QueryOnlineUserStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryOnlineUserStatisticalDataHeaders headers = new QueryOnlineUserStatisticalDataHeaders();
        return this.queryOnlineUserStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryOnlineUserStatisticalDataResponse queryOnlineUserStatisticalDataWithOptions(QueryOnlineUserStatisticalDataRequest request, QueryOnlineUserStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryOnlineUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/onlineUserData", "json", req, runtime), new QueryOnlineUserStatisticalDataResponse());
    }

    public QueryRedEnvelopeReciveStatisticalDataResponse queryRedEnvelopeReciveStatisticalData(QueryRedEnvelopeReciveStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryRedEnvelopeReciveStatisticalDataHeaders headers = new QueryRedEnvelopeReciveStatisticalDataHeaders();
        return this.queryRedEnvelopeReciveStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryRedEnvelopeReciveStatisticalDataResponse queryRedEnvelopeReciveStatisticalDataWithOptions(QueryRedEnvelopeReciveStatisticalDataRequest request, QueryRedEnvelopeReciveStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryRedEnvelopeReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/redEnvelopeReciveData", "json", req, runtime), new QueryRedEnvelopeReciveStatisticalDataResponse());
    }

    public QueryRedEnvelopeSendStatisticalDataResponse queryRedEnvelopeSendStatisticalData(QueryRedEnvelopeSendStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryRedEnvelopeSendStatisticalDataHeaders headers = new QueryRedEnvelopeSendStatisticalDataHeaders();
        return this.queryRedEnvelopeSendStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryRedEnvelopeSendStatisticalDataResponse queryRedEnvelopeSendStatisticalDataWithOptions(QueryRedEnvelopeSendStatisticalDataRequest request, QueryRedEnvelopeSendStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryRedEnvelopeSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/redEnvelopeSendData", "json", req, runtime), new QueryRedEnvelopeSendStatisticalDataResponse());
    }

    public QueryReportStatisticalDataResponse queryReportStatisticalData(QueryReportStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryReportStatisticalDataHeaders headers = new QueryReportStatisticalDataHeaders();
        return this.queryReportStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryReportStatisticalDataResponse queryReportStatisticalDataWithOptions(QueryReportStatisticalDataRequest request, QueryReportStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryReportStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/reportData", "json", req, runtime), new QueryReportStatisticalDataResponse());
    }

    public QuerySingleMessageStatisticalDataResponse querySingleMessageStatisticalData(QuerySingleMessageStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QuerySingleMessageStatisticalDataHeaders headers = new QuerySingleMessageStatisticalDataHeaders();
        return this.querySingleMessageStatisticalDataWithOptions(request, headers, runtime);
    }

    public QuerySingleMessageStatisticalDataResponse querySingleMessageStatisticalDataWithOptions(QuerySingleMessageStatisticalDataRequest request, QuerySingleMessageStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QuerySingleMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/singleMessagerData", "json", req, runtime), new QuerySingleMessageStatisticalDataResponse());
    }

    public QueryTelMeetingStatisticalDataResponse queryTelMeetingStatisticalData(QueryTelMeetingStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryTelMeetingStatisticalDataHeaders headers = new QueryTelMeetingStatisticalDataHeaders();
        return this.queryTelMeetingStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryTelMeetingStatisticalDataResponse queryTelMeetingStatisticalDataWithOptions(QueryTelMeetingStatisticalDataRequest request, QueryTelMeetingStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryTelMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/telMeetingData", "json", req, runtime), new QueryTelMeetingStatisticalDataResponse());
    }

    public QueryTodoStatisticalDataResponse queryTodoStatisticalData(QueryTodoStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryTodoStatisticalDataHeaders headers = new QueryTodoStatisticalDataHeaders();
        return this.queryTodoStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryTodoStatisticalDataResponse queryTodoStatisticalDataWithOptions(QueryTodoStatisticalDataRequest request, QueryTodoStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryTodoStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/todoUserData", "json", req, runtime), new QueryTodoStatisticalDataResponse());
    }

    public QueryVedioMeetingStatisticalDataResponse queryVedioMeetingStatisticalData(QueryVedioMeetingStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryVedioMeetingStatisticalDataHeaders headers = new QueryVedioMeetingStatisticalDataHeaders();
        return this.queryVedioMeetingStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryVedioMeetingStatisticalDataResponse queryVedioMeetingStatisticalDataWithOptions(QueryVedioMeetingStatisticalDataRequest request, QueryVedioMeetingStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryVedioMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/vedioMeetingData", "json", req, runtime), new QueryVedioMeetingStatisticalDataResponse());
    }

    public QueryYydActiveDayStatisticalDataResponse queryYydActiveDayStatisticalData(QueryYydActiveDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydActiveDayStatisticalDataHeaders headers = new QueryYydActiveDayStatisticalDataHeaders();
        return this.queryYydActiveDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydActiveDayStatisticalDataResponse queryYydActiveDayStatisticalDataWithOptions(QueryYydActiveDayStatisticalDataRequest request, QueryYydActiveDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydActiveDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveDayDatas", "json", req, runtime), new QueryYydActiveDayStatisticalDataResponse());
    }

    public QueryYydActiveMonthStatisticalDataResponse queryYydActiveMonthStatisticalData(QueryYydActiveMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydActiveMonthStatisticalDataHeaders headers = new QueryYydActiveMonthStatisticalDataHeaders();
        return this.queryYydActiveMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydActiveMonthStatisticalDataResponse queryYydActiveMonthStatisticalDataWithOptions(QueryYydActiveMonthStatisticalDataRequest request, QueryYydActiveMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydActiveMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveMonthDatas", "json", req, runtime), new QueryYydActiveMonthStatisticalDataResponse());
    }

    public QueryYydActiveWeekStatisticalDataResponse queryYydActiveWeekStatisticalData(QueryYydActiveWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydActiveWeekStatisticalDataHeaders headers = new QueryYydActiveWeekStatisticalDataHeaders();
        return this.queryYydActiveWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydActiveWeekStatisticalDataResponse queryYydActiveWeekStatisticalDataWithOptions(QueryYydActiveWeekStatisticalDataRequest request, QueryYydActiveWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydActiveWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveWeekDatas", "json", req, runtime), new QueryYydActiveWeekStatisticalDataResponse());
    }

    public QueryYydAppDayStatisticalDataResponse queryYydAppDayStatisticalData(QueryYydAppDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydAppDayStatisticalDataHeaders headers = new QueryYydAppDayStatisticalDataHeaders();
        return this.queryYydAppDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydAppDayStatisticalDataResponse queryYydAppDayStatisticalDataWithOptions(QueryYydAppDayStatisticalDataRequest request, QueryYydAppDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydAppDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppDayDatas", "json", req, runtime), new QueryYydAppDayStatisticalDataResponse());
    }

    public QueryYydAppMonthStatisticalDataResponse queryYydAppMonthStatisticalData(QueryYydAppMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydAppMonthStatisticalDataHeaders headers = new QueryYydAppMonthStatisticalDataHeaders();
        return this.queryYydAppMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydAppMonthStatisticalDataResponse queryYydAppMonthStatisticalDataWithOptions(QueryYydAppMonthStatisticalDataRequest request, QueryYydAppMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydAppMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppMonthDatas", "json", req, runtime), new QueryYydAppMonthStatisticalDataResponse());
    }

    public QueryYydAppStdStatisticalDataResponse queryYydAppStdStatisticalData(QueryYydAppStdStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydAppStdStatisticalDataHeaders headers = new QueryYydAppStdStatisticalDataHeaders();
        return this.queryYydAppStdStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydAppStdStatisticalDataResponse queryYydAppStdStatisticalDataWithOptions(QueryYydAppStdStatisticalDataRequest request, QueryYydAppStdStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydAppStdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppStdDatas", "json", req, runtime), new QueryYydAppStdStatisticalDataResponse());
    }

    public QueryYydAppWeekStatisticalDataResponse queryYydAppWeekStatisticalData(QueryYydAppWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydAppWeekStatisticalDataHeaders headers = new QueryYydAppWeekStatisticalDataHeaders();
        return this.queryYydAppWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydAppWeekStatisticalDataResponse queryYydAppWeekStatisticalDataWithOptions(QueryYydAppWeekStatisticalDataRequest request, QueryYydAppWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydAppWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppWeekDatas", "json", req, runtime), new QueryYydAppWeekStatisticalDataResponse());
    }

    public QueryYydCalendarDayStatisticalDataResponse queryYydCalendarDayStatisticalData(QueryYydCalendarDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydCalendarDayStatisticalDataHeaders headers = new QueryYydCalendarDayStatisticalDataHeaders();
        return this.queryYydCalendarDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydCalendarDayStatisticalDataResponse queryYydCalendarDayStatisticalDataWithOptions(QueryYydCalendarDayStatisticalDataRequest request, QueryYydCalendarDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydCalendarDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarDayDatas", "json", req, runtime), new QueryYydCalendarDayStatisticalDataResponse());
    }

    public QueryYydCalendarMonthStatisticalDataResponse queryYydCalendarMonthStatisticalData(QueryYydCalendarMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydCalendarMonthStatisticalDataHeaders headers = new QueryYydCalendarMonthStatisticalDataHeaders();
        return this.queryYydCalendarMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydCalendarMonthStatisticalDataResponse queryYydCalendarMonthStatisticalDataWithOptions(QueryYydCalendarMonthStatisticalDataRequest request, QueryYydCalendarMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydCalendarMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarMonthDatas", "json", req, runtime), new QueryYydCalendarMonthStatisticalDataResponse());
    }

    public QueryYydCalendarWeekStatisticalDataResponse queryYydCalendarWeekStatisticalData(QueryYydCalendarWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydCalendarWeekStatisticalDataHeaders headers = new QueryYydCalendarWeekStatisticalDataHeaders();
        return this.queryYydCalendarWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydCalendarWeekStatisticalDataResponse queryYydCalendarWeekStatisticalDataWithOptions(QueryYydCalendarWeekStatisticalDataRequest request, QueryYydCalendarWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydCalendarWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarWeekDatas", "json", req, runtime), new QueryYydCalendarWeekStatisticalDataResponse());
    }

    public QueryYydDingMsgDayStatisticalDataResponse queryYydDingMsgDayStatisticalData(QueryYydDingMsgDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydDingMsgDayStatisticalDataHeaders headers = new QueryYydDingMsgDayStatisticalDataHeaders();
        return this.queryYydDingMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydDingMsgDayStatisticalDataResponse queryYydDingMsgDayStatisticalDataWithOptions(QueryYydDingMsgDayStatisticalDataRequest request, QueryYydDingMsgDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydDingMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgDayDatas", "json", req, runtime), new QueryYydDingMsgDayStatisticalDataResponse());
    }

    public QueryYydDingMsgMonthStatisticalDataResponse queryYydDingMsgMonthStatisticalData(QueryYydDingMsgMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydDingMsgMonthStatisticalDataHeaders headers = new QueryYydDingMsgMonthStatisticalDataHeaders();
        return this.queryYydDingMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydDingMsgMonthStatisticalDataResponse queryYydDingMsgMonthStatisticalDataWithOptions(QueryYydDingMsgMonthStatisticalDataRequest request, QueryYydDingMsgMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydDingMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgMonthDatas", "json", req, runtime), new QueryYydDingMsgMonthStatisticalDataResponse());
    }

    public QueryYydDingMsgWeekStatisticalDataResponse queryYydDingMsgWeekStatisticalData(QueryYydDingMsgWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydDingMsgWeekStatisticalDataHeaders headers = new QueryYydDingMsgWeekStatisticalDataHeaders();
        return this.queryYydDingMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydDingMsgWeekStatisticalDataResponse queryYydDingMsgWeekStatisticalDataWithOptions(QueryYydDingMsgWeekStatisticalDataRequest request, QueryYydDingMsgWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydDingMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgWeekDatas", "json", req, runtime), new QueryYydDingMsgWeekStatisticalDataResponse());
    }

    public QueryYydGroupMsgDayStatisticalDataResponse queryYydGroupMsgDayStatisticalData(QueryYydGroupMsgDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydGroupMsgDayStatisticalDataHeaders headers = new QueryYydGroupMsgDayStatisticalDataHeaders();
        return this.queryYydGroupMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydGroupMsgDayStatisticalDataResponse queryYydGroupMsgDayStatisticalDataWithOptions(QueryYydGroupMsgDayStatisticalDataRequest request, QueryYydGroupMsgDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydGroupMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgDayDatas", "json", req, runtime), new QueryYydGroupMsgDayStatisticalDataResponse());
    }

    public QueryYydGroupMsgMonthStatisticalDataResponse queryYydGroupMsgMonthStatisticalData(QueryYydGroupMsgMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydGroupMsgMonthStatisticalDataHeaders headers = new QueryYydGroupMsgMonthStatisticalDataHeaders();
        return this.queryYydGroupMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydGroupMsgMonthStatisticalDataResponse queryYydGroupMsgMonthStatisticalDataWithOptions(QueryYydGroupMsgMonthStatisticalDataRequest request, QueryYydGroupMsgMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydGroupMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgMonthDatas", "json", req, runtime), new QueryYydGroupMsgMonthStatisticalDataResponse());
    }

    public QueryYydGroupMsgWeekStatisticalDataResponse queryYydGroupMsgWeekStatisticalData(QueryYydGroupMsgWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydGroupMsgWeekStatisticalDataHeaders headers = new QueryYydGroupMsgWeekStatisticalDataHeaders();
        return this.queryYydGroupMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydGroupMsgWeekStatisticalDataResponse queryYydGroupMsgWeekStatisticalDataWithOptions(QueryYydGroupMsgWeekStatisticalDataRequest request, QueryYydGroupMsgWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydGroupMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgWeekDatas", "json", req, runtime), new QueryYydGroupMsgWeekStatisticalDataResponse());
    }

    public QueryYydLogDayStatisticalDataResponse queryYydLogDayStatisticalData(QueryYydLogDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydLogDayStatisticalDataHeaders headers = new QueryYydLogDayStatisticalDataHeaders();
        return this.queryYydLogDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydLogDayStatisticalDataResponse queryYydLogDayStatisticalDataWithOptions(QueryYydLogDayStatisticalDataRequest request, QueryYydLogDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydLogDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogDayDatas", "json", req, runtime), new QueryYydLogDayStatisticalDataResponse());
    }

    public QueryYydLogMonthStatisticalDataResponse queryYydLogMonthStatisticalData(QueryYydLogMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydLogMonthStatisticalDataHeaders headers = new QueryYydLogMonthStatisticalDataHeaders();
        return this.queryYydLogMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydLogMonthStatisticalDataResponse queryYydLogMonthStatisticalDataWithOptions(QueryYydLogMonthStatisticalDataRequest request, QueryYydLogMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydLogMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogMonthDatas", "json", req, runtime), new QueryYydLogMonthStatisticalDataResponse());
    }

    public QueryYydLogWeekStatisticalDataResponse queryYydLogWeekStatisticalData(QueryYydLogWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydLogWeekStatisticalDataHeaders headers = new QueryYydLogWeekStatisticalDataHeaders();
        return this.queryYydLogWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydLogWeekStatisticalDataResponse queryYydLogWeekStatisticalDataWithOptions(QueryYydLogWeekStatisticalDataRequest request, QueryYydLogWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydLogWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogWeekDatas", "json", req, runtime), new QueryYydLogWeekStatisticalDataResponse());
    }

    public QueryYydMeetingDayStatisticalDataResponse queryYydMeetingDayStatisticalData(QueryYydMeetingDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydMeetingDayStatisticalDataHeaders headers = new QueryYydMeetingDayStatisticalDataHeaders();
        return this.queryYydMeetingDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydMeetingDayStatisticalDataResponse queryYydMeetingDayStatisticalDataWithOptions(QueryYydMeetingDayStatisticalDataRequest request, QueryYydMeetingDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydMeetingDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingDayDatas", "json", req, runtime), new QueryYydMeetingDayStatisticalDataResponse());
    }

    public QueryYydMeetingMonthStatisticalDataResponse queryYydMeetingMonthStatisticalData(QueryYydMeetingMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydMeetingMonthStatisticalDataHeaders headers = new QueryYydMeetingMonthStatisticalDataHeaders();
        return this.queryYydMeetingMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydMeetingMonthStatisticalDataResponse queryYydMeetingMonthStatisticalDataWithOptions(QueryYydMeetingMonthStatisticalDataRequest request, QueryYydMeetingMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydMeetingMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingMonthDatas", "json", req, runtime), new QueryYydMeetingMonthStatisticalDataResponse());
    }

    public QueryYydMeetingWeekStatisticalDataResponse queryYydMeetingWeekStatisticalData(QueryYydMeetingWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydMeetingWeekStatisticalDataHeaders headers = new QueryYydMeetingWeekStatisticalDataHeaders();
        return this.queryYydMeetingWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydMeetingWeekStatisticalDataResponse queryYydMeetingWeekStatisticalDataWithOptions(QueryYydMeetingWeekStatisticalDataRequest request, QueryYydMeetingWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydMeetingWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingWeekDatas", "json", req, runtime), new QueryYydMeetingWeekStatisticalDataResponse());
    }

    public QueryYydNoticeDayStatisticalDataResponse queryYydNoticeDayStatisticalData(QueryYydNoticeDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydNoticeDayStatisticalDataHeaders headers = new QueryYydNoticeDayStatisticalDataHeaders();
        return this.queryYydNoticeDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydNoticeDayStatisticalDataResponse queryYydNoticeDayStatisticalDataWithOptions(QueryYydNoticeDayStatisticalDataRequest request, QueryYydNoticeDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydNoticeDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeDayDatas", "json", req, runtime), new QueryYydNoticeDayStatisticalDataResponse());
    }

    public QueryYydNoticeMonthStatisticalDataResponse queryYydNoticeMonthStatisticalData(QueryYydNoticeMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydNoticeMonthStatisticalDataHeaders headers = new QueryYydNoticeMonthStatisticalDataHeaders();
        return this.queryYydNoticeMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydNoticeMonthStatisticalDataResponse queryYydNoticeMonthStatisticalDataWithOptions(QueryYydNoticeMonthStatisticalDataRequest request, QueryYydNoticeMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydNoticeMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeMonthDatas", "json", req, runtime), new QueryYydNoticeMonthStatisticalDataResponse());
    }

    public QueryYydNoticeWeekStatisticalDataResponse queryYydNoticeWeekStatisticalData(QueryYydNoticeWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydNoticeWeekStatisticalDataHeaders headers = new QueryYydNoticeWeekStatisticalDataHeaders();
        return this.queryYydNoticeWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydNoticeWeekStatisticalDataResponse queryYydNoticeWeekStatisticalDataWithOptions(QueryYydNoticeWeekStatisticalDataRequest request, QueryYydNoticeWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydNoticeWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeWeekDatas", "json", req, runtime), new QueryYydNoticeWeekStatisticalDataResponse());
    }

    public QueryYydSingleMsgDayStatisticalDataResponse queryYydSingleMsgDayStatisticalData(QueryYydSingleMsgDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydSingleMsgDayStatisticalDataHeaders headers = new QueryYydSingleMsgDayStatisticalDataHeaders();
        return this.queryYydSingleMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydSingleMsgDayStatisticalDataResponse queryYydSingleMsgDayStatisticalDataWithOptions(QueryYydSingleMsgDayStatisticalDataRequest request, QueryYydSingleMsgDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydSingleMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgDayDatas", "json", req, runtime), new QueryYydSingleMsgDayStatisticalDataResponse());
    }

    public QueryYydSingleMsgMonthStatisticalDataResponse queryYydSingleMsgMonthStatisticalData(QueryYydSingleMsgMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydSingleMsgMonthStatisticalDataHeaders headers = new QueryYydSingleMsgMonthStatisticalDataHeaders();
        return this.queryYydSingleMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydSingleMsgMonthStatisticalDataResponse queryYydSingleMsgMonthStatisticalDataWithOptions(QueryYydSingleMsgMonthStatisticalDataRequest request, QueryYydSingleMsgMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydSingleMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgMonthDatas", "json", req, runtime), new QueryYydSingleMsgMonthStatisticalDataResponse());
    }

    public QueryYydSingleMsgWeekStatisticalDataResponse queryYydSingleMsgWeekStatisticalData(QueryYydSingleMsgWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydSingleMsgWeekStatisticalDataHeaders headers = new QueryYydSingleMsgWeekStatisticalDataHeaders();
        return this.queryYydSingleMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydSingleMsgWeekStatisticalDataResponse queryYydSingleMsgWeekStatisticalDataWithOptions(QueryYydSingleMsgWeekStatisticalDataRequest request, QueryYydSingleMsgWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydSingleMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgWeekDatas", "json", req, runtime), new QueryYydSingleMsgWeekStatisticalDataResponse());
    }

    public QueryYydToatlMsgDayStatisticalDataResponse queryYydToatlMsgDayStatisticalData(QueryYydToatlMsgDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydToatlMsgDayStatisticalDataHeaders headers = new QueryYydToatlMsgDayStatisticalDataHeaders();
        return this.queryYydToatlMsgDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydToatlMsgDayStatisticalDataResponse queryYydToatlMsgDayStatisticalDataWithOptions(QueryYydToatlMsgDayStatisticalDataRequest request, QueryYydToatlMsgDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydToatlMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgDayDatas", "json", req, runtime), new QueryYydToatlMsgDayStatisticalDataResponse());
    }

    public QueryYydToatlMsgMonthStatisticalDataResponse queryYydToatlMsgMonthStatisticalData(QueryYydToatlMsgMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydToatlMsgMonthStatisticalDataHeaders headers = new QueryYydToatlMsgMonthStatisticalDataHeaders();
        return this.queryYydToatlMsgMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydToatlMsgMonthStatisticalDataResponse queryYydToatlMsgMonthStatisticalDataWithOptions(QueryYydToatlMsgMonthStatisticalDataRequest request, QueryYydToatlMsgMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydToatlMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgMonthDatas", "json", req, runtime), new QueryYydToatlMsgMonthStatisticalDataResponse());
    }

    public QueryYydToatlMsgWeekStatisticalDataResponse queryYydToatlMsgWeekStatisticalData(QueryYydToatlMsgWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydToatlMsgWeekStatisticalDataHeaders headers = new QueryYydToatlMsgWeekStatisticalDataHeaders();
        return this.queryYydToatlMsgWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydToatlMsgWeekStatisticalDataResponse queryYydToatlMsgWeekStatisticalDataWithOptions(QueryYydToatlMsgWeekStatisticalDataRequest request, QueryYydToatlMsgWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydToatlMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgWeekDatas", "json", req, runtime), new QueryYydToatlMsgWeekStatisticalDataResponse());
    }

    public QueryYydTodoDayStatisticalDataResponse queryYydTodoDayStatisticalData(QueryYydTodoDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydTodoDayStatisticalDataHeaders headers = new QueryYydTodoDayStatisticalDataHeaders();
        return this.queryYydTodoDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydTodoDayStatisticalDataResponse queryYydTodoDayStatisticalDataWithOptions(QueryYydTodoDayStatisticalDataRequest request, QueryYydTodoDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydTodoDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoDayDatas", "json", req, runtime), new QueryYydTodoDayStatisticalDataResponse());
    }

    public QueryYydTodoMonthStatisticalDataResponse queryYydTodoMonthStatisticalData(QueryYydTodoMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydTodoMonthStatisticalDataHeaders headers = new QueryYydTodoMonthStatisticalDataHeaders();
        return this.queryYydTodoMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydTodoMonthStatisticalDataResponse queryYydTodoMonthStatisticalDataWithOptions(QueryYydTodoMonthStatisticalDataRequest request, QueryYydTodoMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydTodoMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoMonthDatas", "json", req, runtime), new QueryYydTodoMonthStatisticalDataResponse());
    }

    public QueryYydTodoWeekStatisticalDataResponse queryYydTodoWeekStatisticalData(QueryYydTodoWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydTodoWeekStatisticalDataHeaders headers = new QueryYydTodoWeekStatisticalDataHeaders();
        return this.queryYydTodoWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydTodoWeekStatisticalDataResponse queryYydTodoWeekStatisticalDataWithOptions(QueryYydTodoWeekStatisticalDataRequest request, QueryYydTodoWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydTodoWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoWeekDatas", "json", req, runtime), new QueryYydTodoWeekStatisticalDataResponse());
    }

    public QueryYydTotalDayStatisticalDataResponse queryYydTotalDayStatisticalData(QueryYydTotalDayStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydTotalDayStatisticalDataHeaders headers = new QueryYydTotalDayStatisticalDataHeaders();
        return this.queryYydTotalDayStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydTotalDayStatisticalDataResponse queryYydTotalDayStatisticalDataWithOptions(QueryYydTotalDayStatisticalDataRequest request, QueryYydTotalDayStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydTotalDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalDayDatas", "json", req, runtime), new QueryYydTotalDayStatisticalDataResponse());
    }

    public QueryYydTotalMonthStatisticalDataResponse queryYydTotalMonthStatisticalData(QueryYydTotalMonthStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydTotalMonthStatisticalDataHeaders headers = new QueryYydTotalMonthStatisticalDataHeaders();
        return this.queryYydTotalMonthStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydTotalMonthStatisticalDataResponse queryYydTotalMonthStatisticalDataWithOptions(QueryYydTotalMonthStatisticalDataRequest request, QueryYydTotalMonthStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydTotalMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalMonthDatas", "json", req, runtime), new QueryYydTotalMonthStatisticalDataResponse());
    }

    public QueryYydTotalStdStatisticalDataResponse queryYydTotalStdStatisticalData(QueryYydTotalStdStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydTotalStdStatisticalDataHeaders headers = new QueryYydTotalStdStatisticalDataHeaders();
        return this.queryYydTotalStdStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydTotalStdStatisticalDataResponse queryYydTotalStdStatisticalDataWithOptions(QueryYydTotalStdStatisticalDataRequest request, QueryYydTotalStdStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydTotalStdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalStdDatas", "json", req, runtime), new QueryYydTotalStdStatisticalDataResponse());
    }

    public QueryYydTotalWeekStatisticalDataResponse queryYydTotalWeekStatisticalData(QueryYydTotalWeekStatisticalDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryYydTotalWeekStatisticalDataHeaders headers = new QueryYydTotalWeekStatisticalDataHeaders();
        return this.queryYydTotalWeekStatisticalDataWithOptions(request, headers, runtime);
    }

    public QueryYydTotalWeekStatisticalDataResponse queryYydTotalWeekStatisticalDataWithOptions(QueryYydTotalWeekStatisticalDataRequest request, QueryYydTotalWeekStatisticalDataHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryYydTotalWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalWeekDatas", "json", req, runtime), new QueryYydTotalWeekStatisticalDataResponse());
    }
}
