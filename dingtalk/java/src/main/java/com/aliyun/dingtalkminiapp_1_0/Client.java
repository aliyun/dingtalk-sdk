// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkminiapp_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public CreateMiniAppResponse createMiniApp(CreateMiniAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateMiniAppHeaders headers = new CreateMiniAppHeaders();
        return this.createMiniAppWithOptions(request, headers, runtime);
    }

    public CreateMiniAppResponse createMiniAppWithOptions(CreateMiniAppRequest request, CreateMiniAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bundleId)) {
            body.put("bundleId", request.bundleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.desc)) {
            body.put("desc", request.desc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
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
        return TeaModel.toModel(this.doROARequest("CreateMiniApp", "miniapp_1.0", "HTTP", "POST", "AK", "/v1.0/miniapp/apps", "json", req, runtime), new CreateMiniAppResponse());
    }

    public CreateMiniAppPluginResponse createMiniAppPlugin(CreateMiniAppPluginRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateMiniAppPluginHeaders headers = new CreateMiniAppPluginHeaders();
        return this.createMiniAppPluginWithOptions(request, headers, runtime);
    }

    public CreateMiniAppPluginResponse createMiniAppPluginWithOptions(CreateMiniAppPluginRequest request, CreateMiniAppPluginHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bundleId)) {
            body.put("bundleId", request.bundleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.desc)) {
            body.put("desc", request.desc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
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
        return TeaModel.toModel(this.doROARequest("CreateMiniAppPlugin", "miniapp_1.0", "HTTP", "POST", "AK", "/v1.0/miniapp/plugins", "json", req, runtime), new CreateMiniAppPluginResponse());
    }

    public CreateVersionAcrossBundleResponse createVersionAcrossBundle(CreateVersionAcrossBundleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateVersionAcrossBundleHeaders headers = new CreateVersionAcrossBundleHeaders();
        return this.createVersionAcrossBundleWithOptions(request, headers, runtime);
    }

    public CreateVersionAcrossBundleResponse createVersionAcrossBundleWithOptions(CreateVersionAcrossBundleRequest request, CreateVersionAcrossBundleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bundleId)) {
            body.put("bundleId", request.bundleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceBundleId)) {
            body.put("sourceBundleId", request.sourceBundleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceVersion)) {
            body.put("sourceVersion", request.sourceVersion);
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
        return TeaModel.toModel(this.doROARequest("CreateVersionAcrossBundle", "miniapp_1.0", "HTTP", "POST", "AK", "/v1.0/miniapp/versions/createAcrossBundle", "json", req, runtime), new CreateVersionAcrossBundleResponse());
    }

    public GetMaxVersionResponse getMaxVersion(GetMaxVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMaxVersionHeaders headers = new GetMaxVersionHeaders();
        return this.getMaxVersionWithOptions(request, headers, runtime);
    }

    public GetMaxVersionResponse getMaxVersionWithOptions(GetMaxVersionRequest request, GetMaxVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bundleId)) {
            query.put("bundleId", request.bundleId);
        }

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
        return TeaModel.toModel(this.doROARequest("GetMaxVersion", "miniapp_1.0", "HTTP", "GET", "AK", "/v1.0/miniapp/apps/maxVersions", "json", req, runtime), new GetMaxVersionResponse());
    }

    public GetMiniAppMetaDataResponse getMiniAppMetaData(GetMiniAppMetaDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMiniAppMetaDataHeaders headers = new GetMiniAppMetaDataHeaders();
        return this.getMiniAppMetaDataWithOptions(request, headers, runtime);
    }

    public GetMiniAppMetaDataResponse getMiniAppMetaDataWithOptions(GetMiniAppMetaDataRequest request, GetMiniAppMetaDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bundleId)) {
            body.put("bundleId", request.bundleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bundleIdTableGmtModified)) {
            body.put("bundleIdTableGmtModified", request.bundleIdTableGmtModified);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fromAppName)) {
            body.put("fromAppName", request.fromAppName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.miniAppIdTableGmtModified)) {
            body.put("miniAppIdTableGmtModified", request.miniAppIdTableGmtModified);
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
        return TeaModel.toModel(this.doROARequest("GetMiniAppMetaData", "miniapp_1.0", "HTTP", "POST", "AK", "/v1.0/miniapp/apps/metadata", "json", req, runtime), new GetMiniAppMetaDataResponse());
    }

    public GetSettingByMiniAppIdResponse getSettingByMiniAppId(String miniAppId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSettingByMiniAppIdHeaders headers = new GetSettingByMiniAppIdHeaders();
        return this.getSettingByMiniAppIdWithOptions(miniAppId, headers, runtime);
    }

    public GetSettingByMiniAppIdResponse getSettingByMiniAppIdWithOptions(String miniAppId, GetSettingByMiniAppIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        miniAppId = com.aliyun.openapiutil.Client.getEncodeParam(miniAppId);
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
        return TeaModel.toModel(this.doROARequest("GetSettingByMiniAppId", "miniapp_1.0", "HTTP", "GET", "AK", "/v1.0/miniapp/apps/settings", "json", req, runtime), new GetSettingByMiniAppIdResponse());
    }

    public InvokeHtmlBundleBuildResponse invokeHtmlBundleBuild(InvokeHtmlBundleBuildRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InvokeHtmlBundleBuildHeaders headers = new InvokeHtmlBundleBuildHeaders();
        return this.invokeHtmlBundleBuildWithOptions(request, headers, runtime);
    }

    public InvokeHtmlBundleBuildResponse invokeHtmlBundleBuildWithOptions(InvokeHtmlBundleBuildRequest request, InvokeHtmlBundleBuildHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bundleId)) {
            body.put("bundleId", request.bundleId);
        }

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
        return TeaModel.toModel(this.doROARequest("InvokeHtmlBundleBuild", "miniapp_1.0", "HTTP", "POST", "AK", "/v1.0/miniapp/h5Bundles/build", "json", req, runtime), new InvokeHtmlBundleBuildResponse());
    }

    public ListAvaiableVersionResponse listAvaiableVersion(ListAvaiableVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAvaiableVersionHeaders headers = new ListAvaiableVersionHeaders();
        return this.listAvaiableVersionWithOptions(request, headers, runtime);
    }

    public ListAvaiableVersionResponse listAvaiableVersionWithOptions(ListAvaiableVersionRequest request, ListAvaiableVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bundleId)) {
            body.put("bundleId", request.bundleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNum)) {
            body.put("pageNum", request.pageNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.versionTypeSet)) {
            body.put("versionTypeSet", request.versionTypeSet);
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
        return TeaModel.toModel(this.doROARequest("ListAvaiableVersion", "miniapp_1.0", "HTTP", "POST", "AK", "/v1.0/miniapp/apps/versions/query", "json", req, runtime), new ListAvaiableVersionResponse());
    }

    public QueryHtmlBundleBuildResponse queryHtmlBundleBuild(QueryHtmlBundleBuildRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHtmlBundleBuildHeaders headers = new QueryHtmlBundleBuildHeaders();
        return this.queryHtmlBundleBuildWithOptions(request, headers, runtime);
    }

    public QueryHtmlBundleBuildResponse queryHtmlBundleBuildWithOptions(QueryHtmlBundleBuildRequest request, QueryHtmlBundleBuildHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bundleId)) {
            query.put("bundleId", request.bundleId);
        }

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
        return TeaModel.toModel(this.doROARequest("QueryHtmlBundleBuild", "miniapp_1.0", "HTTP", "GET", "AK", "/v1.0/miniapp/h5Bundles/buildResults", "json", req, runtime), new QueryHtmlBundleBuildResponse());
    }

    public SetExtendSettingResponse setExtendSetting(SetExtendSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetExtendSettingHeaders headers = new SetExtendSettingHeaders();
        return this.setExtendSettingWithOptions(request, headers, runtime);
    }

    public SetExtendSettingResponse setExtendSettingWithOptions(SetExtendSettingRequest request, SetExtendSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.buildH5Bundle)) {
            body.put("buildH5Bundle", request.buildH5Bundle);
        }

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
        return TeaModel.toModel(this.doROARequest("SetExtendSetting", "miniapp_1.0", "HTTP", "PUT", "AK", "/v1.0/miniapp/apps/settings", "json", req, runtime), new SetExtendSettingResponse());
    }

    public UpdateVersionStatusResponse updateVersionStatus(UpdateVersionStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateVersionStatusHeaders headers = new UpdateVersionStatusHeaders();
        return this.updateVersionStatusWithOptions(request, headers, runtime);
    }

    public UpdateVersionStatusResponse updateVersionStatusWithOptions(UpdateVersionStatusRequest request, UpdateVersionStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bundleId)) {
            body.put("bundleId", request.bundleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            body.put("version", request.version);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.versionType)) {
            body.put("versionType", request.versionType);
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
        return TeaModel.toModel(this.doROARequest("UpdateVersionStatus", "miniapp_1.0", "HTTP", "POST", "AK", "/v1.0/miniapp/versions/status", "json", req, runtime), new UpdateVersionStatusResponse());
    }
}
