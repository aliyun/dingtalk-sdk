// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkpackage_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public GetUploadTokenResponse getUploadToken(GetUploadTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUploadTokenHeaders headers = new GetUploadTokenHeaders();
        return this.getUploadTokenWithOptions(request, headers, runtime);
    }

    public GetUploadTokenResponse getUploadTokenWithOptions(GetUploadTokenRequest request, GetUploadTokenHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            query.put("miniAppId", request.miniAppId);
        }

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
        return TeaModel.toModel(this.doROARequest("GetUploadToken", "package_1.0", "HTTP", "GET", "AK", "/v1.0/package/uploadTokens", "json", req, runtime), new GetUploadTokenResponse());
    }

    public HPublishPackageResponse hPublishPackage(HPublishPackageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HPublishPackageHeaders headers = new HPublishPackageHeaders();
        return this.hPublishPackageWithOptions(request, headers, runtime);
    }

    public HPublishPackageResponse hPublishPackageWithOptions(HPublishPackageRequest request, HPublishPackageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            body.put("version", request.version);
        }

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
        return TeaModel.toModel(this.doROARequest("HPublishPackage", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/h5/publish", "json", req, runtime), new HPublishPackageResponse());
    }

    public HUploadPackageResponse hUploadPackage(HUploadPackageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HUploadPackageHeaders headers = new HUploadPackageHeaders();
        return this.hUploadPackageWithOptions(request, headers, runtime);
    }

    public HUploadPackageResponse hUploadPackageWithOptions(HUploadPackageRequest request, HUploadPackageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ossObjectKey)) {
            body.put("ossObjectKey", request.ossObjectKey);
        }

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
        return TeaModel.toModel(this.doROARequest("HUploadPackage", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/h5/asyncUpload", "json", req, runtime), new HUploadPackageResponse());
    }

    public HUploadPackageStatusResponse hUploadPackageStatus(HUploadPackageStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HUploadPackageStatusHeaders headers = new HUploadPackageStatusHeaders();
        return this.hUploadPackageStatusWithOptions(request, headers, runtime);
    }

    public HUploadPackageStatusResponse hUploadPackageStatusWithOptions(HUploadPackageStatusRequest request, HUploadPackageStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            query.put("miniAppId", request.miniAppId);
        }

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
        return TeaModel.toModel(this.doROARequest("HUploadPackageStatus", "package_1.0", "HTTP", "GET", "AK", "/v1.0/package/h5/uploadStatus", "json", req, runtime), new HUploadPackageStatusResponse());
    }
}
