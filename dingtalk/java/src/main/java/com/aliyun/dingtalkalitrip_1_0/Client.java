// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkalitrip_1_0.models.*;
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


    public AddCityCarApplyResponse addCityCarApply(AddCityCarApplyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddCityCarApplyHeaders headers = new AddCityCarApplyHeaders();
        return this.addCityCarApplyWithOptions(request, headers, runtime);
    }

    public AddCityCarApplyResponse addCityCarApplyWithOptions(AddCityCarApplyRequest request, AddCityCarApplyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cause)) {
            body.put("cause", request.cause);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.city)) {
            body.put("city", request.city);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.date)) {
            body.put("date", request.date);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectCode)) {
            body.put("projectCode", request.projectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectName)) {
            body.put("projectName", request.projectName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartApplyId)) {
            body.put("thirdPartApplyId", request.thirdPartApplyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartCostCenterId)) {
            body.put("thirdPartCostCenterId", request.thirdPartCostCenterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartInvoiceId)) {
            body.put("thirdPartInvoiceId", request.thirdPartInvoiceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timesTotal)) {
            body.put("timesTotal", request.timesTotal);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timesType)) {
            body.put("timesType", request.timesType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timesUsed)) {
            body.put("timesUsed", request.timesUsed);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.finishedDate)) {
            body.put("finishedDate", request.finishedDate);
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
        return TeaModel.toModel(this.doROARequest("AddCityCarApply", "alitrip_1.0", "HTTP", "POST", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime), new AddCityCarApplyResponse());
    }

    public ApproveCityCarApplyResponse approveCityCarApply(ApproveCityCarApplyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ApproveCityCarApplyHeaders headers = new ApproveCityCarApplyHeaders();
        return this.approveCityCarApplyWithOptions(request, headers, runtime);
    }

    public ApproveCityCarApplyResponse approveCityCarApplyWithOptions(ApproveCityCarApplyRequest request, ApproveCityCarApplyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateTime)) {
            body.put("operateTime", request.operateTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartApplyId)) {
            body.put("thirdPartApplyId", request.thirdPartApplyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
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
        return TeaModel.toModel(this.doROARequest("ApproveCityCarApply", "alitrip_1.0", "HTTP", "PUT", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime), new ApproveCityCarApplyResponse());
    }

    public QueryCityCarApplyResponse queryCityCarApply(QueryCityCarApplyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCityCarApplyHeaders headers = new QueryCityCarApplyHeaders();
        return this.queryCityCarApplyWithOptions(request, headers, runtime);
    }

    public QueryCityCarApplyResponse queryCityCarApplyWithOptions(QueryCityCarApplyRequest request, QueryCityCarApplyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createdEndAt)) {
            query.put("createdEndAt", request.createdEndAt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createdStartAt)) {
            query.put("createdStartAt", request.createdStartAt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartApplyId)) {
            query.put("thirdPartApplyId", request.thirdPartApplyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("QueryCityCarApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime), new QueryCityCarApplyResponse());
    }
}
