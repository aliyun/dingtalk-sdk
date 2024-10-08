// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkblackboard_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkblackboard_1_0.models.*;

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
     * <p>查询公告已读未读人员列表</p>
     * 
     * @param request QueryBlackboardReadUnReadRequest
     * @param headers QueryBlackboardReadUnReadHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryBlackboardReadUnReadResponse
     */
    public QueryBlackboardReadUnReadResponse queryBlackboardReadUnReadWithOptions(QueryBlackboardReadUnReadRequest request, QueryBlackboardReadUnReadHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.blackboardId)) {
            query.put("blackboardId", request.blackboardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operationUserId)) {
            query.put("operationUserId", request.operationUserId);
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
            new TeaPair("action", "QueryBlackboardReadUnRead"),
            new TeaPair("version", "blackboard_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/blackboard/readers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryBlackboardReadUnReadResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询公告已读未读人员列表</p>
     * 
     * @param request QueryBlackboardReadUnReadRequest
     * @return QueryBlackboardReadUnReadResponse
     */
    public QueryBlackboardReadUnReadResponse queryBlackboardReadUnRead(QueryBlackboardReadUnReadRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBlackboardReadUnReadHeaders headers = new QueryBlackboardReadUnReadHeaders();
        return this.queryBlackboardReadUnReadWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取公告钉盘空间信息</p>
     * 
     * @param request QueryBlackboardSpaceRequest
     * @param headers QueryBlackboardSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryBlackboardSpaceResponse
     */
    public QueryBlackboardSpaceResponse queryBlackboardSpaceWithOptions(QueryBlackboardSpaceRequest request, QueryBlackboardSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operationUserId)) {
            query.put("operationUserId", request.operationUserId);
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
            new TeaPair("action", "QueryBlackboardSpace"),
            new TeaPair("version", "blackboard_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/blackboard/spaces"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryBlackboardSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取公告钉盘空间信息</p>
     * 
     * @param request QueryBlackboardSpaceRequest
     * @return QueryBlackboardSpaceResponse
     */
    public QueryBlackboardSpaceResponse queryBlackboardSpace(QueryBlackboardSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBlackboardSpaceHeaders headers = new QueryBlackboardSpaceHeaders();
        return this.queryBlackboardSpaceWithOptions(request, headers, runtime);
    }
}
