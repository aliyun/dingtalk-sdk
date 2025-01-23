// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkminutes_1_0.models.*;

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
     * <p>查询闪记媒体播放信息</p>
     * 
     * @param request QueryMinutesPlayInfoRequest
     * @param headers QueryMinutesPlayInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMinutesPlayInfoResponse
     */
    public QueryMinutesPlayInfoResponse queryMinutesPlayInfoWithOptions(String taskUuid, QueryMinutesPlayInfoRequest request, QueryMinutesPlayInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "QueryMinutesPlayInfo"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/playInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMinutesPlayInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记媒体播放信息</p>
     * 
     * @param request QueryMinutesPlayInfoRequest
     * @return QueryMinutesPlayInfoResponse
     */
    public QueryMinutesPlayInfoResponse queryMinutesPlayInfo(String taskUuid, QueryMinutesPlayInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMinutesPlayInfoHeaders headers = new QueryMinutesPlayInfoHeaders();
        return this.queryMinutesPlayInfoWithOptions(taskUuid, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记状态</p>
     * 
     * @param request QueryMinutesStatusRequest
     * @param headers QueryMinutesStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMinutesStatusResponse
     */
    public QueryMinutesStatusResponse queryMinutesStatusWithOptions(String taskUuid, QueryMinutesStatusRequest request, QueryMinutesStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "QueryMinutesStatus"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/" + taskUuid + "/taskStatus"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMinutesStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记状态</p>
     * 
     * @param request QueryMinutesStatusRequest
     * @return QueryMinutesStatusResponse
     */
    public QueryMinutesStatusResponse queryMinutesStatus(String taskUuid, QueryMinutesStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMinutesStatusHeaders headers = new QueryMinutesStatusHeaders();
        return this.queryMinutesStatusWithOptions(taskUuid, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记转写文本内容</p>
     * 
     * @param request QueryMinutesTextRequest
     * @param headers QueryMinutesTextHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMinutesTextResponse
     */
    public QueryMinutesTextResponse queryMinutesTextWithOptions(String taskUuid, QueryMinutesTextRequest request, QueryMinutesTextHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.direction)) {
            query.put("direction", request.direction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "QueryMinutesText"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/" + taskUuid + "/textInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMinutesTextResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记转写文本内容</p>
     * 
     * @param request QueryMinutesTextRequest
     * @return QueryMinutesTextResponse
     */
    public QueryMinutesTextResponse queryMinutesText(String taskUuid, QueryMinutesTextRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMinutesTextHeaders headers = new QueryMinutesTextHeaders();
        return this.queryMinutesTextWithOptions(taskUuid, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询上传视频播放信息</p>
     * 
     * @param request QueryUploadVideoPlayInfoRequest
     * @param headers QueryUploadVideoPlayInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUploadVideoPlayInfoResponse
     */
    public QueryUploadVideoPlayInfoResponse queryUploadVideoPlayInfoWithOptions(String videoId, QueryUploadVideoPlayInfoRequest request, QueryUploadVideoPlayInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "QueryUploadVideoPlayInfo"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/uploadVideos/" + videoId + "/playInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUploadVideoPlayInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询上传视频播放信息</p>
     * 
     * @param request QueryUploadVideoPlayInfoRequest
     * @return QueryUploadVideoPlayInfoResponse
     */
    public QueryUploadVideoPlayInfoResponse queryUploadVideoPlayInfo(String videoId, QueryUploadVideoPlayInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUploadVideoPlayInfoHeaders headers = new QueryUploadVideoPlayInfoHeaders();
        return this.queryUploadVideoPlayInfoWithOptions(videoId, request, headers, runtime);
    }
}
