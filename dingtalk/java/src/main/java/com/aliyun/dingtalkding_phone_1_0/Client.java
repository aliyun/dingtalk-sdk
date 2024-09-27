// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_phone_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkding_phone_1_0.models.*;

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
     * <p>添加外呼码号配置</p>
     * 
     * @param request AddCallConfigRequest
     * @param headers AddCallConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCallConfigResponse
     */
    public AddCallConfigResponse addCallConfigWithOptions(AddCallConfigRequest request, AddCallConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvToken)) {
            query.put("isvToken", request.isvToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.phoneNumber)) {
            query.put("phoneNumber", request.phoneNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeType)) {
            query.put("scopeType", request.scopeType);
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
            new TeaPair("action", "AddCallConfig"),
            new TeaPair("version", "dingPhone_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dingPhone/callConfigs"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCallConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加外呼码号配置</p>
     * 
     * @param request AddCallConfigRequest
     * @return AddCallConfigResponse
     */
    public AddCallConfigResponse addCallConfig(AddCallConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCallConfigHeaders headers = new AddCallConfigHeaders();
        return this.addCallConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除码号配置</p>
     * 
     * @param request DelCallConfigRequest
     * @param headers DelCallConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DelCallConfigResponse
     */
    public DelCallConfigResponse delCallConfigWithOptions(DelCallConfigRequest request, DelCallConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvToken)) {
            query.put("isvToken", request.isvToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.phoneNumber)) {
            query.put("phoneNumber", request.phoneNumber);
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
            new TeaPair("action", "DelCallConfig"),
            new TeaPair("version", "dingPhone_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dingPhone/callConfigs"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DelCallConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除码号配置</p>
     * 
     * @param request DelCallConfigRequest
     * @return DelCallConfigResponse
     */
    public DelCallConfigResponse delCallConfig(DelCallConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DelCallConfigHeaders headers = new DelCallConfigHeaders();
        return this.delCallConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询外呼码号配置</p>
     * 
     * @param request QueryCallConfigRequest
     * @param headers QueryCallConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCallConfigResponse
     */
    public QueryCallConfigResponse queryCallConfigWithOptions(QueryCallConfigRequest request, QueryCallConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvToken)) {
            query.put("isvToken", request.isvToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.phoneNumber)) {
            query.put("phoneNumber", request.phoneNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeType)) {
            query.put("scopeType", request.scopeType);
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
            new TeaPair("action", "QueryCallConfig"),
            new TeaPair("version", "dingPhone_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dingPhone/callConfigs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCallConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询外呼码号配置</p>
     * 
     * @param request QueryCallConfigRequest
     * @return QueryCallConfigResponse
     */
    public QueryCallConfigResponse queryCallConfig(QueryCallConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCallConfigHeaders headers = new QueryCallConfigHeaders();
        return this.queryCallConfigWithOptions(request, headers, runtime);
    }
}
