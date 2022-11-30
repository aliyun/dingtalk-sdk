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


    public CloseHPackageResponse closeHPackage(CloseHPackageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CloseHPackageHeaders headers = new CloseHPackageHeaders();
        return this.closeHPackageWithOptions(request, headers, runtime);
    }

    public CloseHPackageResponse closeHPackageWithOptions(CloseHPackageRequest request, CloseHPackageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
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
        return TeaModel.toModel(this.doROARequest("CloseHPackage", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/h5/microApps/close", "json", req, runtime), new CloseHPackageResponse());
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

    public HPackageListGetResponse hPackageListGet(HPackageListGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HPackageListGetHeaders headers = new HPackageListGetHeaders();
        return this.hPackageListGetWithOptions(request, headers, runtime);
    }

    public HPackageListGetResponse hPackageListGetWithOptions(HPackageListGetRequest request, HPackageListGetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            query.put("miniAppId", request.miniAppId);
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
        return TeaModel.toModel(this.doROARequest("HPackageListGet", "package_1.0", "HTTP", "GET", "AK", "/v1.0/package/h5/versions", "json", req, runtime), new HPackageListGetResponse());
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

    public OpenMicroAppPackageResponse openMicroAppPackage(OpenMicroAppPackageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OpenMicroAppPackageHeaders headers = new OpenMicroAppPackageHeaders();
        return this.openMicroAppPackageWithOptions(request, headers, runtime);
    }

    public OpenMicroAppPackageResponse openMicroAppPackageWithOptions(OpenMicroAppPackageRequest request, OpenMicroAppPackageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            body.put("agentId", request.agentId);
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
        return TeaModel.toModel(this.doROARequest("OpenMicroAppPackage", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/h5/microApps/open", "json", req, runtime), new OpenMicroAppPackageResponse());
    }

    public ReleaseGrayDeployResponse releaseGrayDeploy(ReleaseGrayDeployRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayDeployHeaders headers = new ReleaseGrayDeployHeaders();
        return this.releaseGrayDeployWithOptions(request, headers, runtime);
    }

    public ReleaseGrayDeployResponse releaseGrayDeployWithOptions(ReleaseGrayDeployRequest request, ReleaseGrayDeployHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("ReleaseGrayDeploy", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/greys/deploy", "json", req, runtime), new ReleaseGrayDeployResponse());
    }

    public ReleaseGrayExitResponse releaseGrayExit(ReleaseGrayExitRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayExitHeaders headers = new ReleaseGrayExitHeaders();
        return this.releaseGrayExitWithOptions(request, headers, runtime);
    }

    public ReleaseGrayExitResponse releaseGrayExitWithOptions(ReleaseGrayExitRequest request, ReleaseGrayExitHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("ReleaseGrayExit", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/greys/exit", "json", req, runtime), new ReleaseGrayExitResponse());
    }

    public ReleaseGrayOrgGetResponse releaseGrayOrgGet(ReleaseGrayOrgGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayOrgGetHeaders headers = new ReleaseGrayOrgGetHeaders();
        return this.releaseGrayOrgGetWithOptions(request, headers, runtime);
    }

    public ReleaseGrayOrgGetResponse releaseGrayOrgGetWithOptions(ReleaseGrayOrgGetRequest request, ReleaseGrayOrgGetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            query.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            query.put("version", request.version);
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
        return TeaModel.toModel(this.doROARequest("ReleaseGrayOrgGet", "package_1.0", "HTTP", "GET", "AK", "/v1.0/package/greys/organizations", "json", req, runtime), new ReleaseGrayOrgGetResponse());
    }

    public ReleaseGrayOrgSetResponse releaseGrayOrgSet(ReleaseGrayOrgSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayOrgSetHeaders headers = new ReleaseGrayOrgSetHeaders();
        return this.releaseGrayOrgSetWithOptions(request, headers, runtime);
    }

    public ReleaseGrayOrgSetResponse releaseGrayOrgSetWithOptions(ReleaseGrayOrgSetRequest request, ReleaseGrayOrgSetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.value)) {
            body.put("value", request.value);
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
        return TeaModel.toModel(this.doROARequest("ReleaseGrayOrgSet", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/greys/organizations/release", "json", req, runtime), new ReleaseGrayOrgSetResponse());
    }

    public ReleaseGrayPercentGetResponse releaseGrayPercentGet(ReleaseGrayPercentGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayPercentGetHeaders headers = new ReleaseGrayPercentGetHeaders();
        return this.releaseGrayPercentGetWithOptions(request, headers, runtime);
    }

    public ReleaseGrayPercentGetResponse releaseGrayPercentGetWithOptions(ReleaseGrayPercentGetRequest request, ReleaseGrayPercentGetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            query.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            query.put("version", request.version);
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
        return TeaModel.toModel(this.doROARequest("ReleaseGrayPercentGet", "package_1.0", "HTTP", "GET", "AK", "/v1.0/package/greys/users/percents", "json", req, runtime), new ReleaseGrayPercentGetResponse());
    }

    public ReleaseGrayPercentSetResponse releaseGrayPercentSet(ReleaseGrayPercentSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayPercentSetHeaders headers = new ReleaseGrayPercentSetHeaders();
        return this.releaseGrayPercentSetWithOptions(request, headers, runtime);
    }

    public ReleaseGrayPercentSetResponse releaseGrayPercentSetWithOptions(ReleaseGrayPercentSetRequest request, ReleaseGrayPercentSetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.value)) {
            body.put("value", request.value);
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
        return TeaModel.toModel(this.doROARequest("ReleaseGrayPercentSet", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/greys/users/percents/release", "json", req, runtime), new ReleaseGrayPercentSetResponse());
    }

    public ReleaseGrayUserIdGetResponse releaseGrayUserIdGet(ReleaseGrayUserIdGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayUserIdGetHeaders headers = new ReleaseGrayUserIdGetHeaders();
        return this.releaseGrayUserIdGetWithOptions(request, headers, runtime);
    }

    public ReleaseGrayUserIdGetResponse releaseGrayUserIdGetWithOptions(ReleaseGrayUserIdGetRequest request, ReleaseGrayUserIdGetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            query.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            query.put("version", request.version);
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
        return TeaModel.toModel(this.doROARequest("ReleaseGrayUserIdGet", "package_1.0", "HTTP", "GET", "AK", "/v1.0/package/greys/users", "json", req, runtime), new ReleaseGrayUserIdGetResponse());
    }
}
