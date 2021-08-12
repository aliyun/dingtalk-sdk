// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkmanufacturing_1_0.models.*;
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


    public IndustrializeManufactureJobBookResponse industrializeManufactureJobBook(String userId, IndustrializeManufactureJobBookRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.industrializeManufactureJobBookWithOptions(userId, request, headers, runtime);
    }

    public IndustrializeManufactureJobBookResponse industrializeManufactureJobBookWithOptions(String userId, IndustrializeManufactureJobBookRequest request, java.util.Map<String, String> headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.scrappedQuantity)) {
            body.put("scrappedQuantity", request.scrappedQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.qualifiedQuantity)) {
            body.put("qualifiedQuantity", request.qualifiedQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reworkableQuantity)) {
            body.put("reworkableQuantity", request.reworkableQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userName)) {
            body.put("userName", request.userName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productEnName)) {
            body.put("productEnName", request.productEnName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processName)) {
            body.put("processName", request.processName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processEnName)) {
            body.put("processEnName", request.processEnName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mesAppKey)) {
            body.put("mesAppKey", request.mesAppKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instNo)) {
            body.put("instNo", request.instNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.manufactureDate)) {
            body.put("manufactureDate", request.manufactureDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("IndustrializeManufactureJobBook", "manufacturing_1.0", "HTTP", "POST", "AK", "/v1.0/manufacturing/users/" + userId + "/jobs", "json", req, runtime), new IndustrializeManufactureJobBookResponse());
    }

    public IndustrializeManufactureQueryJobsResponse industrializeManufactureQueryJobs(IndustrializeManufactureQueryJobsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustrializeManufactureQueryJobsHeaders headers = new IndustrializeManufactureQueryJobsHeaders();
        return this.industrializeManufactureQueryJobsWithOptions(request, headers, runtime);
    }

    public IndustrializeManufactureQueryJobsResponse industrializeManufactureQueryJobsWithOptions(IndustrializeManufactureQueryJobsRequest request, IndustrializeManufactureQueryJobsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.qualifiedQuantity)) {
            body.put("qualifiedQuantity", request.qualifiedQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.manufactureDay)) {
            body.put("manufactureDay", request.manufactureDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instNo)) {
            body.put("instNo", request.instNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userName)) {
            body.put("userName", request.userName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unitPrice)) {
            body.put("unitPrice", request.unitPrice);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.currentPage)) {
            body.put("currentPage", request.currentPage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mesAppKey)) {
            body.put("mesAppKey", request.mesAppKey);
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
        return TeaModel.toModel(this.doROARequest("IndustrializeManufactureQueryJobs", "manufacturing_1.0", "HTTP", "POST", "AK", "/v1.0/manufacturing/users/jobs/query", "json", req, runtime), new IndustrializeManufactureQueryJobsResponse());
    }
}
