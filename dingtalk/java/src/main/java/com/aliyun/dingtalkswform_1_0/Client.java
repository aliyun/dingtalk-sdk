// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkswform_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>获取单个填表实例详情接口</p>
     * 
     * @param request GetFormInstanceRequest
     * @param headers GetFormInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFormInstanceResponse
     */
    public GetFormInstanceResponse getFormInstanceWithOptions(String formInstanceId, GetFormInstanceRequest request, GetFormInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            query.put("bizType", request.bizType);
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
            new TeaPair("action", "GetFormInstance"),
            new TeaPair("version", "swform_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/swform/instances/" + formInstanceId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFormInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取单个填表实例详情接口</p>
     * 
     * @param request GetFormInstanceRequest
     * @return GetFormInstanceResponse
     */
    public GetFormInstanceResponse getFormInstance(String formInstanceId, GetFormInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFormInstanceHeaders headers = new GetFormInstanceHeaders();
        return this.getFormInstanceWithOptions(formInstanceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取填表模版下的填表实例列表接口</p>
     * 
     * @param request ListFormInstancesRequest
     * @param headers ListFormInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListFormInstancesResponse
     */
    public ListFormInstancesResponse listFormInstancesWithOptions(String formCode, ListFormInstancesRequest request, ListFormInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionDate)) {
            query.put("actionDate", request.actionDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            query.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
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
            new TeaPair("action", "ListFormInstances"),
            new TeaPair("version", "swform_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/swform/forms/" + formCode + "/instances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListFormInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取填表模版下的填表实例列表接口</p>
     * 
     * @param request ListFormInstancesRequest
     * @return ListFormInstancesResponse
     */
    public ListFormInstancesResponse listFormInstances(String formCode, ListFormInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListFormInstancesHeaders headers = new ListFormInstancesHeaders();
        return this.listFormInstancesWithOptions(formCode, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户创建的填表模板列表接口</p>
     * 
     * @param request ListFormSchemasByCreatorRequest
     * @param headers ListFormSchemasByCreatorHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListFormSchemasByCreatorResponse
     */
    public ListFormSchemasByCreatorResponse listFormSchemasByCreatorWithOptions(ListFormSchemasByCreatorRequest request, ListFormSchemasByCreatorHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            query.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creator)) {
            query.put("creator", request.creator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
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
            new TeaPair("action", "ListFormSchemasByCreator"),
            new TeaPair("version", "swform_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/swform/users/forms"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListFormSchemasByCreatorResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户创建的填表模板列表接口</p>
     * 
     * @param request ListFormSchemasByCreatorRequest
     * @return ListFormSchemasByCreatorResponse
     */
    public ListFormSchemasByCreatorResponse listFormSchemasByCreator(ListFormSchemasByCreatorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListFormSchemasByCreatorHeaders headers = new ListFormSchemasByCreatorHeaders();
        return this.listFormSchemasByCreatorWithOptions(request, headers, runtime);
    }
}
