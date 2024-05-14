// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkpackage_1_0.models.*;

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
     * @summary 关闭企业自建应用H5离线包
     *
     * @param request CloseHPackageRequest
     * @param headers CloseHPackageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CloseHPackageResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CloseHPackage"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/h5/microApps/close"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CloseHPackageResponse());
    }

    /**
     * @summary 关闭企业自建应用H5离线包
     *
     * @param request CloseHPackageRequest
     * @return CloseHPackageResponse
     */
    public CloseHPackageResponse closeHPackage(CloseHPackageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CloseHPackageHeaders headers = new CloseHPackageHeaders();
        return this.closeHPackageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取离线包上传凭证
     *
     * @param request GetUploadTokenRequest
     * @param headers GetUploadTokenHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUploadTokenResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUploadToken"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/uploadTokens"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUploadTokenResponse());
    }

    /**
     * @summary 获取离线包上传凭证
     *
     * @param request GetUploadTokenRequest
     * @return GetUploadTokenResponse
     */
    public GetUploadTokenResponse getUploadToken(GetUploadTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUploadTokenHeaders headers = new GetUploadTokenHeaders();
        return this.getUploadTokenWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取H5离线包版本列表
     *
     * @param request HPackageListGetRequest
     * @param headers HPackageListGetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HPackageListGetResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "HPackageListGet"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/h5/versions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HPackageListGetResponse());
    }

    /**
     * @summary 获取H5离线包版本列表
     *
     * @param request HPackageListGetRequest
     * @return HPackageListGetResponse
     */
    public HPackageListGetResponse hPackageListGet(HPackageListGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HPackageListGetHeaders headers = new HPackageListGetHeaders();
        return this.hPackageListGetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 发布离线包
     *
     * @param request HPublishPackageRequest
     * @param headers HPublishPackageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HPublishPackageResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "HPublishPackage"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/h5/publish"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HPublishPackageResponse());
    }

    /**
     * @summary 发布离线包
     *
     * @param request HPublishPackageRequest
     * @return HPublishPackageResponse
     */
    public HPublishPackageResponse hPublishPackage(HPublishPackageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HPublishPackageHeaders headers = new HPublishPackageHeaders();
        return this.hPublishPackageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 上传H5离线包
     *
     * @param request HUploadPackageRequest
     * @param headers HUploadPackageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HUploadPackageResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "HUploadPackage"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/h5/asyncUpload"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HUploadPackageResponse());
    }

    /**
     * @summary 上传H5离线包
     *
     * @param request HUploadPackageRequest
     * @return HUploadPackageResponse
     */
    public HUploadPackageResponse hUploadPackage(HUploadPackageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HUploadPackageHeaders headers = new HUploadPackageHeaders();
        return this.hUploadPackageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 上传H5离线包进度
     *
     * @param request HUploadPackageStatusRequest
     * @param headers HUploadPackageStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HUploadPackageStatusResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "HUploadPackageStatus"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/h5/uploadStatus"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HUploadPackageStatusResponse());
    }

    /**
     * @summary 上传H5离线包进度
     *
     * @param request HUploadPackageStatusRequest
     * @return HUploadPackageStatusResponse
     */
    public HUploadPackageStatusResponse hUploadPackageStatus(HUploadPackageStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HUploadPackageStatusHeaders headers = new HUploadPackageStatusHeaders();
        return this.hUploadPackageStatusWithOptions(request, headers, runtime);
    }

    /**
     * @summary 开启企业自建应用H5离线包
     *
     * @param request OpenMicroAppPackageRequest
     * @param headers OpenMicroAppPackageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OpenMicroAppPackageResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "OpenMicroAppPackage"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/h5/microApps/open"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OpenMicroAppPackageResponse());
    }

    /**
     * @summary 开启企业自建应用H5离线包
     *
     * @param request OpenMicroAppPackageRequest
     * @return OpenMicroAppPackageResponse
     */
    public OpenMicroAppPackageResponse openMicroAppPackage(OpenMicroAppPackageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OpenMicroAppPackageHeaders headers = new OpenMicroAppPackageHeaders();
        return this.openMicroAppPackageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 发布离线包到灰度
     *
     * @param request ReleaseGrayDeployRequest
     * @param headers ReleaseGrayDeployHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReleaseGrayDeployResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ReleaseGrayDeploy"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/greys/deploy"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReleaseGrayDeployResponse());
    }

    /**
     * @summary 发布离线包到灰度
     *
     * @param request ReleaseGrayDeployRequest
     * @return ReleaseGrayDeployResponse
     */
    public ReleaseGrayDeployResponse releaseGrayDeploy(ReleaseGrayDeployRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayDeployHeaders headers = new ReleaseGrayDeployHeaders();
        return this.releaseGrayDeployWithOptions(request, headers, runtime);
    }

    /**
     * @summary 退出灰度
     *
     * @param request ReleaseGrayExitRequest
     * @param headers ReleaseGrayExitHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReleaseGrayExitResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ReleaseGrayExit"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/greys/exit"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReleaseGrayExitResponse());
    }

    /**
     * @summary 退出灰度
     *
     * @param request ReleaseGrayExitRequest
     * @return ReleaseGrayExitResponse
     */
    public ReleaseGrayExitResponse releaseGrayExit(ReleaseGrayExitRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayExitHeaders headers = new ReleaseGrayExitHeaders();
        return this.releaseGrayExitWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业灰度白名单
     *
     * @param request ReleaseGrayOrgGetRequest
     * @param headers ReleaseGrayOrgGetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReleaseGrayOrgGetResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ReleaseGrayOrgGet"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/greys/organizations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReleaseGrayOrgGetResponse());
    }

    /**
     * @summary 获取企业灰度白名单
     *
     * @param request ReleaseGrayOrgGetRequest
     * @return ReleaseGrayOrgGetResponse
     */
    public ReleaseGrayOrgGetResponse releaseGrayOrgGet(ReleaseGrayOrgGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayOrgGetHeaders headers = new ReleaseGrayOrgGetHeaders();
        return this.releaseGrayOrgGetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 设置企业灰度白名单
     *
     * @param request ReleaseGrayOrgSetRequest
     * @param headers ReleaseGrayOrgSetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReleaseGrayOrgSetResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ReleaseGrayOrgSet"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/greys/organizations/release"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReleaseGrayOrgSetResponse());
    }

    /**
     * @summary 设置企业灰度白名单
     *
     * @param request ReleaseGrayOrgSetRequest
     * @return ReleaseGrayOrgSetResponse
     */
    public ReleaseGrayOrgSetResponse releaseGrayOrgSet(ReleaseGrayOrgSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayOrgSetHeaders headers = new ReleaseGrayOrgSetHeaders();
        return this.releaseGrayOrgSetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取灰度离线包百分比值
     *
     * @param request ReleaseGrayPercentGetRequest
     * @param headers ReleaseGrayPercentGetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReleaseGrayPercentGetResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ReleaseGrayPercentGet"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/greys/users/percents"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReleaseGrayPercentGetResponse());
    }

    /**
     * @summary 获取灰度离线包百分比值
     *
     * @param request ReleaseGrayPercentGetRequest
     * @return ReleaseGrayPercentGetResponse
     */
    public ReleaseGrayPercentGetResponse releaseGrayPercentGet(ReleaseGrayPercentGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayPercentGetHeaders headers = new ReleaseGrayPercentGetHeaders();
        return this.releaseGrayPercentGetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 设置灰度离线包百分比值
     *
     * @param request ReleaseGrayPercentSetRequest
     * @param headers ReleaseGrayPercentSetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReleaseGrayPercentSetResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ReleaseGrayPercentSet"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/greys/users/percents/release"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReleaseGrayPercentSetResponse());
    }

    /**
     * @summary 设置灰度离线包百分比值
     *
     * @param request ReleaseGrayPercentSetRequest
     * @return ReleaseGrayPercentSetResponse
     */
    public ReleaseGrayPercentSetResponse releaseGrayPercentSet(ReleaseGrayPercentSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayPercentSetHeaders headers = new ReleaseGrayPercentSetHeaders();
        return this.releaseGrayPercentSetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取用户灰度名单
     *
     * @param request ReleaseGrayUserIdGetRequest
     * @param headers ReleaseGrayUserIdGetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReleaseGrayUserIdGetResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ReleaseGrayUserIdGet"),
            new TeaPair("version", "package_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/package/greys/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReleaseGrayUserIdGetResponse());
    }

    /**
     * @summary 获取用户灰度名单
     *
     * @param request ReleaseGrayUserIdGetRequest
     * @return ReleaseGrayUserIdGetResponse
     */
    public ReleaseGrayUserIdGetResponse releaseGrayUserIdGet(ReleaseGrayUserIdGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseGrayUserIdGetHeaders headers = new ReleaseGrayUserIdGetHeaders();
        return this.releaseGrayUserIdGetWithOptions(request, headers, runtime);
    }
}
