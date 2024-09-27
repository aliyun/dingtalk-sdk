// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkminiapp_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._productId = "dingtalk";
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>创建小程序</p>
     * 
     * @param request CreateMiniAppRequest
     * @param headers CreateMiniAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateMiniAppResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateMiniApp"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/apps"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateMiniAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建小程序</p>
     * 
     * @param request CreateMiniAppRequest
     * @return CreateMiniAppResponse
     */
    public CreateMiniAppResponse createMiniApp(CreateMiniAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateMiniAppHeaders headers = new CreateMiniAppHeaders();
        return this.createMiniAppWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建小程序组件</p>
     * 
     * @param request CreateMiniAppPluginRequest
     * @param headers CreateMiniAppPluginHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateMiniAppPluginResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateMiniAppPlugin"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/plugins"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateMiniAppPluginResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建小程序组件</p>
     * 
     * @param request CreateMiniAppPluginRequest
     * @return CreateMiniAppPluginResponse
     */
    public CreateMiniAppPluginResponse createMiniAppPlugin(CreateMiniAppPluginRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateMiniAppPluginHeaders headers = new CreateMiniAppPluginHeaders();
        return this.createMiniAppPluginWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>小程序多端发布版本</p>
     * 
     * @param request CreateVersionAcrossBundleRequest
     * @param headers CreateVersionAcrossBundleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateVersionAcrossBundleResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateVersionAcrossBundle"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/versions/createAcrossBundle"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateVersionAcrossBundleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>小程序多端发布版本</p>
     * 
     * @param request CreateVersionAcrossBundleRequest
     * @return CreateVersionAcrossBundleResponse
     */
    public CreateVersionAcrossBundleResponse createVersionAcrossBundle(CreateVersionAcrossBundleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateVersionAcrossBundleHeaders headers = new CreateVersionAcrossBundleHeaders();
        return this.createVersionAcrossBundleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取小程序最大的构建版本</p>
     * 
     * @param request GetMaxVersionRequest
     * @param headers GetMaxVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMaxVersionResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetMaxVersion"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/apps/maxVersions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMaxVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取小程序最大的构建版本</p>
     * 
     * @param request GetMaxVersionRequest
     * @return GetMaxVersionResponse
     */
    public GetMaxVersionResponse getMaxVersion(GetMaxVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMaxVersionHeaders headers = new GetMaxVersionHeaders();
        return this.getMaxVersionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>同步小程序元数据</p>
     * 
     * @param request GetMiniAppMetaDataRequest
     * @param headers GetMiniAppMetaDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMiniAppMetaDataResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetMiniAppMetaData"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/apps/metadata"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMiniAppMetaDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>同步小程序元数据</p>
     * 
     * @param request GetMiniAppMetaDataRequest
     * @return GetMiniAppMetaDataResponse
     */
    public GetMiniAppMetaDataResponse getMiniAppMetaData(GetMiniAppMetaDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMiniAppMetaDataHeaders headers = new GetMiniAppMetaDataHeaders();
        return this.getMiniAppMetaDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询小程序配置</p>
     * 
     * @param headers GetSettingByMiniAppIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSettingByMiniAppIdResponse
     */
    public GetSettingByMiniAppIdResponse getSettingByMiniAppIdWithOptions(String miniAppId, GetSettingByMiniAppIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetSettingByMiniAppId"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/apps/settings"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSettingByMiniAppIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询小程序配置</p>
     * @return GetSettingByMiniAppIdResponse
     */
    public GetSettingByMiniAppIdResponse getSettingByMiniAppId(String miniAppId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSettingByMiniAppIdHeaders headers = new GetSettingByMiniAppIdHeaders();
        return this.getSettingByMiniAppIdWithOptions(miniAppId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>构建H5Bundle</p>
     * 
     * @param request InvokeHtmlBundleBuildRequest
     * @param headers InvokeHtmlBundleBuildHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InvokeHtmlBundleBuildResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "InvokeHtmlBundleBuild"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/h5Bundles/build"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InvokeHtmlBundleBuildResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>构建H5Bundle</p>
     * 
     * @param request InvokeHtmlBundleBuildRequest
     * @return InvokeHtmlBundleBuildResponse
     */
    public InvokeHtmlBundleBuildResponse invokeHtmlBundleBuild(InvokeHtmlBundleBuildRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InvokeHtmlBundleBuildHeaders headers = new InvokeHtmlBundleBuildHeaders();
        return this.invokeHtmlBundleBuildWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取小程序版本列表</p>
     * 
     * @param request ListAvaiableVersionRequest
     * @param headers ListAvaiableVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAvaiableVersionResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListAvaiableVersion"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/apps/versions/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAvaiableVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取小程序版本列表</p>
     * 
     * @param request ListAvaiableVersionRequest
     * @return ListAvaiableVersionResponse
     */
    public ListAvaiableVersionResponse listAvaiableVersion(ListAvaiableVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAvaiableVersionHeaders headers = new ListAvaiableVersionHeaders();
        return this.listAvaiableVersionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询H5构建结果</p>
     * 
     * @param request QueryHtmlBundleBuildRequest
     * @param headers QueryHtmlBundleBuildHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryHtmlBundleBuildResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryHtmlBundleBuild"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/h5Bundles/buildResults"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryHtmlBundleBuildResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询H5构建结果</p>
     * 
     * @param request QueryHtmlBundleBuildRequest
     * @return QueryHtmlBundleBuildResponse
     */
    public QueryHtmlBundleBuildResponse queryHtmlBundleBuild(QueryHtmlBundleBuildRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHtmlBundleBuildHeaders headers = new QueryHtmlBundleBuildHeaders();
        return this.queryHtmlBundleBuildWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>回滚版本</p>
     * 
     * @param request RollBackVersionRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return RollBackVersionResponse
     */
    public RollBackVersionResponse rollBackVersionWithOptions(RollBackVersionRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bundleId)) {
            body.put("bundleId", request.bundleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            body.put("miniAppId", request.miniAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rollbackVersion)) {
            body.put("rollbackVersion", request.rollbackVersion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetVersion)) {
            body.put("targetVersion", request.targetVersion);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RollBackVersion"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/versions/rollback"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new RollBackVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>回滚版本</p>
     * 
     * @param request RollBackVersionRequest
     * @return RollBackVersionResponse
     */
    public RollBackVersionResponse rollBackVersion(RollBackVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.rollBackVersionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改小程序配置</p>
     * 
     * @param request SetExtendSettingRequest
     * @param headers SetExtendSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetExtendSettingResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SetExtendSetting"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/apps/settings"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetExtendSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改小程序配置</p>
     * 
     * @param request SetExtendSettingRequest
     * @return SetExtendSettingResponse
     */
    public SetExtendSettingResponse setExtendSetting(SetExtendSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetExtendSettingHeaders headers = new SetExtendSettingHeaders();
        return this.setExtendSettingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发布版本</p>
     * 
     * @param request UpdateVersionStatusRequest
     * @param headers UpdateVersionStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateVersionStatusResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateVersionStatus"),
            new TeaPair("version", "miniapp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/miniapp/versions/status"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateVersionStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发布版本</p>
     * 
     * @param request UpdateVersionStatusRequest
     * @return UpdateVersionStatusResponse
     */
    public UpdateVersionStatusResponse updateVersionStatus(UpdateVersionStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateVersionStatusHeaders headers = new UpdateVersionStatusHeaders();
        return this.updateVersionStatusWithOptions(request, headers, runtime);
    }
}
