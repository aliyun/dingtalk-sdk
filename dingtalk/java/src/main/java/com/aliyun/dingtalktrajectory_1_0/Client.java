// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktrajectory_1_0.models.*;

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
     * <p>查询APP当前开启轨迹采集的用户</p>
     * 
     * @param request QueryAppActiveUsersRequest
     * @param headers QueryAppActiveUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAppActiveUsersResponse
     */
    public QueryAppActiveUsersResponse queryAppActiveUsersWithOptions(QueryAppActiveUsersRequest request, QueryAppActiveUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needPositionInfo)) {
            query.put("needPositionInfo", request.needPositionInfo);
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
            new TeaPair("action", "QueryAppActiveUsers"),
            new TeaPair("version", "trajectory_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trajectory/activeUsers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAppActiveUsersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询APP当前开启轨迹采集的用户</p>
     * 
     * @param request QueryAppActiveUsersRequest
     * @return QueryAppActiveUsersResponse
     */
    public QueryAppActiveUsersResponse queryAppActiveUsers(QueryAppActiveUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAppActiveUsersHeaders headers = new QueryAppActiveUsersHeaders();
        return this.queryAppActiveUsersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询应用采集中的轨迹任务</p>
     * 
     * @param request QueryCollectingTraceTaskRequest
     * @param headers QueryCollectingTraceTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCollectingTraceTaskResponse
     */
    public QueryCollectingTraceTaskResponse queryCollectingTraceTaskWithOptions(QueryCollectingTraceTaskRequest request, QueryCollectingTraceTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
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
            new TeaPair("action", "QueryCollectingTraceTask"),
            new TeaPair("version", "trajectory_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trajectory/currentTasks/queryByUserIds"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCollectingTraceTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询应用采集中的轨迹任务</p>
     * 
     * @param request QueryCollectingTraceTaskRequest
     * @return QueryCollectingTraceTaskResponse
     */
    public QueryCollectingTraceTaskResponse queryCollectingTraceTask(QueryCollectingTraceTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCollectingTraceTaskHeaders headers = new QueryCollectingTraceTaskHeaders();
        return this.queryCollectingTraceTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询轨迹数据</p>
     * 
     * @param request QueryPageTraceDataRequest
     * @param headers QueryPageTraceDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPageTraceDataResponse
     */
    public QueryPageTraceDataResponse queryPageTraceDataWithOptions(QueryPageTraceDataRequest request, QueryPageTraceDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.staffId)) {
            query.put("staffId", request.staffId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.traceId)) {
            query.put("traceId", request.traceId);
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
            new TeaPair("action", "QueryPageTraceData"),
            new TeaPair("version", "trajectory_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trajectory/data"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPageTraceDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询轨迹数据</p>
     * 
     * @param request QueryPageTraceDataRequest
     * @return QueryPageTraceDataResponse
     */
    public QueryPageTraceDataResponse queryPageTraceData(QueryPageTraceDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPageTraceDataHeaders headers = new QueryPageTraceDataHeaders();
        return this.queryPageTraceDataWithOptions(request, headers, runtime);
    }
}
