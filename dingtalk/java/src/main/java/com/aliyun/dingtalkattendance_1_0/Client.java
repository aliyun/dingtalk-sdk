// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkattendance_1_0.models.*;
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


    public CreateApproveResponse createApprove(CreateApproveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateApproveHeaders headers = new CreateApproveHeaders();
        return this.createApproveWithOptions(request, headers, runtime);
    }

    public CreateApproveResponse createApproveWithOptions(CreateApproveRequest request, CreateApproveHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagName)) {
            body.put("tagName", request.tagName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subType)) {
            body.put("subType", request.subType);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.punchParam))) {
            body.put("punchParam", request.punchParam);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.approveId)) {
            body.put("approveId", request.approveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserid)) {
            body.put("opUserid", request.opUserid);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateApprove", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/approves", "json", req, runtime), new CreateApproveResponse());
    }

    public GetUserHolidaysResponse getUserHolidays(GetUserHolidaysRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUserHolidaysHeaders headers = new GetUserHolidaysHeaders();
        return this.getUserHolidaysWithOptions(request, headers, runtime);
    }

    public GetUserHolidaysResponse getUserHolidaysWithOptions(GetUserHolidaysRequest tmpReq, GetUserHolidaysHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        GetUserHolidaysShrinkRequest request = new GetUserHolidaysShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(tmpReq.topHolidayQueryParam))) {
            request.topHolidayQueryParamShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(TeaModel.buildMap(tmpReq.topHolidayQueryParam), "topHolidayQueryParam", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.topHolidayQueryParamShrink)) {
            query.put("topHolidayQueryParam", request.topHolidayQueryParamShrink);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetUserHolidays", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/holidays", "json", req, runtime), new GetUserHolidaysResponse());
    }
}
