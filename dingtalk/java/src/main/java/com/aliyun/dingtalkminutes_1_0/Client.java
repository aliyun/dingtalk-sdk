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
     * <p>批量获取闪记详情</p>
     * 
     * @param request BatchGetMinutesDetailsRequest
     * @param headers BatchGetMinutesDetailsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchGetMinutesDetailsResponse
     */
    public BatchGetMinutesDetailsResponse batchGetMinutesDetailsWithOptions(BatchGetMinutesDetailsRequest request, BatchGetMinutesDetailsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskUuids)) {
            body.put("taskUuids", request.taskUuids);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchGetMinutesDetails"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/details/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchGetMinutesDetailsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量获取闪记详情</p>
     * 
     * @param request BatchGetMinutesDetailsRequest
     * @return BatchGetMinutesDetailsResponse
     */
    public BatchGetMinutesDetailsResponse batchGetMinutesDetails(BatchGetMinutesDetailsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchGetMinutesDetailsHeaders headers = new BatchGetMinutesDetailsHeaders();
        return this.batchGetMinutesDetailsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>从上传的媒体文件创建闪记</p>
     * 
     * @param request CreateMinutesByUploadFileRequest
     * @param headers CreateMinutesByUploadFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateMinutesByUploadFileResponse
     */
    public CreateMinutesByUploadFileResponse createMinutesByUploadFileWithOptions(CreateMinutesByUploadFileRequest request, CreateMinutesByUploadFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creatorId)) {
            body.put("creatorId", request.creatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaFileUrl)) {
            body.put("mediaFileUrl", request.mediaFileUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaType)) {
            body.put("mediaType", request.mediaType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateMinutesByUploadFile"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/createMinutesByUploadFile"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateMinutesByUploadFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>从上传的媒体文件创建闪记</p>
     * 
     * @param request CreateMinutesByUploadFileRequest
     * @return CreateMinutesByUploadFileResponse
     */
    public CreateMinutesByUploadFileResponse createMinutesByUploadFile(CreateMinutesByUploadFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateMinutesByUploadFileHeaders headers = new CreateMinutesByUploadFileHeaders();
        return this.createMinutesByUploadFileWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建DingTalkA1小助理分析</p>
     * 
     * @param request CreateSmartDeviceAiSummaryRequest
     * @param headers CreateSmartDeviceAiSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateSmartDeviceAiSummaryResponse
     */
    public CreateSmartDeviceAiSummaryResponse createSmartDeviceAiSummaryWithOptions(CreateSmartDeviceAiSummaryRequest request, CreateSmartDeviceAiSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            body.put("agentId", request.agentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvContext)) {
            body.put("isvContext", request.isvContext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openFileId)) {
            body.put("openFileId", request.openFileId);
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
            new TeaPair("action", "CreateSmartDeviceAiSummary"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/smartdevice/aisummary/create"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateSmartDeviceAiSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建DingTalkA1小助理分析</p>
     * 
     * @param request CreateSmartDeviceAiSummaryRequest
     * @return CreateSmartDeviceAiSummaryResponse
     */
    public CreateSmartDeviceAiSummaryResponse createSmartDeviceAiSummary(CreateSmartDeviceAiSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSmartDeviceAiSummaryHeaders headers = new CreateSmartDeviceAiSummaryHeaders();
        return this.createSmartDeviceAiSummaryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除闪记</p>
     * 
     * @param request DeleteMinutesRequest
     * @param headers DeleteMinutesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteMinutesResponse
     */
    public DeleteMinutesResponse deleteMinutesWithOptions(String taskUuid, DeleteMinutesRequest request, DeleteMinutesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteMinutes"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteMinutesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除闪记</p>
     * 
     * @param request DeleteMinutesRequest
     * @return DeleteMinutesResponse
     */
    public DeleteMinutesResponse deleteMinutes(String taskUuid, DeleteMinutesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteMinutesHeaders headers = new DeleteMinutesHeaders();
        return this.deleteMinutesWithOptions(taskUuid, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>导出闪记任务结果</p>
     * 
     * @param request ExportMinutesTaskResultRequest
     * @param headers ExportMinutesTaskResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ExportMinutesTaskResultResponse
     */
    public ExportMinutesTaskResultResponse exportMinutesTaskResultWithOptions(ExportMinutesTaskResultRequest request, ExportMinutesTaskResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.expireTime)) {
            body.put("expireTime", request.expireTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summaryExportSetting)) {
            body.put("summaryExportSetting", request.summaryExportSetting);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskType)) {
            body.put("taskType", request.taskType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskUuid)) {
            body.put("taskUuid", request.taskUuid);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ExportMinutesTaskResult"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/minutesTask/export"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExportMinutesTaskResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>导出闪记任务结果</p>
     * 
     * @param request ExportMinutesTaskResultRequest
     * @return ExportMinutesTaskResultResponse
     */
    public ExportMinutesTaskResultResponse exportMinutesTaskResult(ExportMinutesTaskResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExportMinutesTaskResultHeaders headers = new ExportMinutesTaskResultHeaders();
        return this.exportMinutesTaskResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>生成摘要</p>
     * 
     * @param request GenerateSummaryRequest
     * @param headers GenerateSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GenerateSummaryResponse
     */
    public GenerateSummaryResponse generateSummaryWithOptions(String taskUuid, GenerateSummaryRequest request, GenerateSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.diyTemplateVersion)) {
            body.put("diyTemplateVersion", request.diyTemplateVersion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summaryTemplateId)) {
            body.put("summaryTemplateId", request.summaryTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summaryTemplateType)) {
            body.put("summaryTemplateType", request.summaryTemplateType);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GenerateSummary"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/summary"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GenerateSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>生成摘要</p>
     * 
     * @param request GenerateSummaryRequest
     * @return GenerateSummaryResponse
     */
    public GenerateSummaryResponse generateSummary(String taskUuid, GenerateSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GenerateSummaryHeaders headers = new GenerateSummaryHeaders();
        return this.generateSummaryWithOptions(taskUuid, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记摘要</p>
     * 
     * @param request OpenQueryMinutesSummaryRequest
     * @param headers OpenQueryMinutesSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OpenQueryMinutesSummaryResponse
     */
    public OpenQueryMinutesSummaryResponse openQueryMinutesSummaryWithOptions(OpenQueryMinutesSummaryRequest request, OpenQueryMinutesSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskUuid)) {
            query.put("taskUuid", request.taskUuid);
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
            new TeaPair("action", "OpenQueryMinutesSummary"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/queryMinutesSummary"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OpenQueryMinutesSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记摘要</p>
     * 
     * @param request OpenQueryMinutesSummaryRequest
     * @return OpenQueryMinutesSummaryResponse
     */
    public OpenQueryMinutesSummaryResponse openQueryMinutesSummary(OpenQueryMinutesSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OpenQueryMinutesSummaryHeaders headers = new OpenQueryMinutesSummaryHeaders();
        return this.openQueryMinutesSummaryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪会、文档等来源的闪记列表</p>
     * 
     * @param request QueryBizMinutesRequest
     * @param headers QueryBizMinutesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryBizMinutesResponse
     */
    public QueryBizMinutesResponse queryBizMinutesWithOptions(QueryBizMinutesRequest request, QueryBizMinutesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            query.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            query.put("bizType", request.bizType);
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
            new TeaPair("action", "QueryBizMinutes"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/queryBizMinutes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryBizMinutesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪会、文档等来源的闪记列表</p>
     * 
     * @param request QueryBizMinutesRequest
     * @return QueryBizMinutesResponse
     */
    public QueryBizMinutesResponse queryBizMinutes(QueryBizMinutesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBizMinutesHeaders headers = new QueryBizMinutesHeaders();
        return this.queryBizMinutesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询自己创建的闪记列表</p>
     * 
     * @param request QueryCreateMinutesListRequest
     * @param headers QueryCreateMinutesListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCreateMinutesListResponse
     */
    public QueryCreateMinutesListResponse queryCreateMinutesListWithOptions(QueryCreateMinutesListRequest request, QueryCreateMinutesListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryCreateMinutesList"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/createLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCreateMinutesListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询自己创建的闪记列表</p>
     * 
     * @param request QueryCreateMinutesListRequest
     * @return QueryCreateMinutesListResponse
     */
    public QueryCreateMinutesListResponse queryCreateMinutesList(QueryCreateMinutesListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCreateMinutesListHeaders headers = new QueryCreateMinutesListHeaders();
        return this.queryCreateMinutesListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记基本信息</p>
     * 
     * @param request QueryMinutesBasicInfoRequest
     * @param headers QueryMinutesBasicInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMinutesBasicInfoResponse
     */
    public QueryMinutesBasicInfoResponse queryMinutesBasicInfoWithOptions(QueryMinutesBasicInfoRequest request, QueryMinutesBasicInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskUuid)) {
            query.put("taskUuid", request.taskUuid);
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
            new TeaPair("action", "QueryMinutesBasicInfo"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/queryMinutesBasicInfo"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMinutesBasicInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记基本信息</p>
     * 
     * @param request QueryMinutesBasicInfoRequest
     * @return QueryMinutesBasicInfoResponse
     */
    public QueryMinutesBasicInfoResponse queryMinutesBasicInfo(QueryMinutesBasicInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMinutesBasicInfoHeaders headers = new QueryMinutesBasicInfoHeaders();
        return this.queryMinutesBasicInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记关键字</p>
     * 
     * @param request QueryMinutesKeywordRequest
     * @param headers QueryMinutesKeywordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMinutesKeywordResponse
     */
    public QueryMinutesKeywordResponse queryMinutesKeywordWithOptions(String taskUuid, QueryMinutesKeywordRequest request, QueryMinutesKeywordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryMinutesKeyword"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/" + taskUuid + "/keywords"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMinutesKeywordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记关键字</p>
     * 
     * @param request QueryMinutesKeywordRequest
     * @return QueryMinutesKeywordResponse
     */
    public QueryMinutesKeywordResponse queryMinutesKeyword(String taskUuid, QueryMinutesKeywordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMinutesKeywordHeaders headers = new QueryMinutesKeywordHeaders();
        return this.queryMinutesKeywordWithOptions(taskUuid, request, headers, runtime);
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
     * <p>获取与我共享闪记列表</p>
     * 
     * @param request QueryMinutesShareListRequest
     * @param headers QueryMinutesShareListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMinutesShareListResponse
     */
    public QueryMinutesShareListResponse queryMinutesShareListWithOptions(QueryMinutesShareListRequest request, QueryMinutesShareListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            query.put("scene", request.scene);
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
            new TeaPair("action", "QueryMinutesShareList"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/shareLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMinutesShareListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取与我共享闪记列表</p>
     * 
     * @param request QueryMinutesShareListRequest
     * @return QueryMinutesShareListResponse
     */
    public QueryMinutesShareListResponse queryMinutesShareList(QueryMinutesShareListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMinutesShareListHeaders headers = new QueryMinutesShareListHeaders();
        return this.queryMinutesShareListWithOptions(request, headers, runtime);
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
     * <p>查询闪记待办</p>
     * 
     * @param request QueryMinutesTodoRequest
     * @param headers QueryMinutesTodoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMinutesTodoResponse
     */
    public QueryMinutesTodoResponse queryMinutesTodoWithOptions(String taskUuid, QueryMinutesTodoRequest request, QueryMinutesTodoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryMinutesTodo"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/" + taskUuid + "/todos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMinutesTodoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询闪记待办</p>
     * 
     * @param request QueryMinutesTodoRequest
     * @return QueryMinutesTodoResponse
     */
    public QueryMinutesTodoResponse queryMinutesTodo(String taskUuid, QueryMinutesTodoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMinutesTodoHeaders headers = new QueryMinutesTodoHeaders();
        return this.queryMinutesTodoWithOptions(taskUuid, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询预约会议闪记列表</p>
     * 
     * @param request QueryScheduleConfMinutesRequest
     * @param headers QueryScheduleConfMinutesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryScheduleConfMinutesResponse
     */
    public QueryScheduleConfMinutesResponse queryScheduleConfMinutesWithOptions(String scheduleConferenceId, QueryScheduleConfMinutesRequest request, QueryScheduleConfMinutesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.eventId)) {
            query.put("eventId", request.eventId);
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
            new TeaPair("action", "QueryScheduleConfMinutes"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/scheduleConference/" + scheduleConferenceId + "/minutes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryScheduleConfMinutesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询预约会议闪记列表</p>
     * 
     * @param request QueryScheduleConfMinutesRequest
     * @return QueryScheduleConfMinutesResponse
     */
    public QueryScheduleConfMinutesResponse queryScheduleConfMinutes(String scheduleConferenceId, QueryScheduleConfMinutesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryScheduleConfMinutesHeaders headers = new QueryScheduleConfMinutesHeaders();
        return this.queryScheduleConfMinutesWithOptions(scheduleConferenceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询DingTalkA1小助理分析</p>
     * 
     * @param request QuerySmartDeviceAiSummaryRequest
     * @param headers QuerySmartDeviceAiSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySmartDeviceAiSummaryResponse
     */
    public QuerySmartDeviceAiSummaryResponse querySmartDeviceAiSummaryWithOptions(QuerySmartDeviceAiSummaryRequest request, QuerySmartDeviceAiSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            body.put("agentId", request.agentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openFileId)) {
            body.put("openFileId", request.openFileId);
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
            new TeaPair("action", "QuerySmartDeviceAiSummary"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/smartdevice/aisummary"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySmartDeviceAiSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询DingTalkA1小助理分析</p>
     * 
     * @param request QuerySmartDeviceAiSummaryRequest
     * @return QuerySmartDeviceAiSummaryResponse
     */
    public QuerySmartDeviceAiSummaryResponse querySmartDeviceAiSummary(QuerySmartDeviceAiSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySmartDeviceAiSummaryHeaders headers = new QuerySmartDeviceAiSummaryHeaders();
        return this.querySmartDeviceAiSummaryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据模板id查询摘要</p>
     * 
     * @param request QuerySummaryWithTemplateRequest
     * @param headers QuerySummaryWithTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySummaryWithTemplateResponse
     */
    public QuerySummaryWithTemplateResponse querySummaryWithTemplateWithOptions(String taskUuid, QuerySummaryWithTemplateRequest request, QuerySummaryWithTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.diyTemplateVersion)) {
            query.put("diyTemplateVersion", request.diyTemplateVersion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summaryTemplateId)) {
            query.put("summaryTemplateId", request.summaryTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summaryTemplateType)) {
            query.put("summaryTemplateType", request.summaryTemplateType);
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
            new TeaPair("action", "QuerySummaryWithTemplate"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/summary/template"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySummaryWithTemplateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据模板id查询摘要</p>
     * 
     * @param request QuerySummaryWithTemplateRequest
     * @return QuerySummaryWithTemplateResponse
     */
    public QuerySummaryWithTemplateResponse querySummaryWithTemplate(String taskUuid, QuerySummaryWithTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySummaryWithTemplateHeaders headers = new QuerySummaryWithTemplateHeaders();
        return this.querySummaryWithTemplateWithOptions(taskUuid, request, headers, runtime);
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

    /**
     * <b>summary</b> : 
     * <p>更新闪记标题</p>
     * 
     * @param request UpdateMinutesTitleRequest
     * @param headers UpdateMinutesTitleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateMinutesTitleResponse
     */
    public UpdateMinutesTitleResponse updateMinutesTitleWithOptions(String taskUuid, UpdateMinutesTitleRequest request, UpdateMinutesTitleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            query.put("title", request.title);
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
            new TeaPair("action", "UpdateMinutesTitle"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/titles"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateMinutesTitleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新闪记标题</p>
     * 
     * @param request UpdateMinutesTitleRequest
     * @return UpdateMinutesTitleResponse
     */
    public UpdateMinutesTitleResponse updateMinutesTitle(String taskUuid, UpdateMinutesTitleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateMinutesTitleHeaders headers = new UpdateMinutesTitleHeaders();
        return this.updateMinutesTitleWithOptions(taskUuid, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新闪记权限</p>
     * 
     * @param request UpdatePermissionRequest
     * @param headers UpdatePermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdatePermissionResponse
     */
    public UpdatePermissionResponse updatePermissionWithOptions(String taskUuid, UpdatePermissionRequest request, UpdatePermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.memberInfoList)) {
            body.put("memberInfoList", request.memberInfoList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opType)) {
            body.put("opType", request.opType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleCode)) {
            body.put("roleCode", request.roleCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleSubResourceIds)) {
            body.put("roleSubResourceIds", request.roleSubResourceIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.shareScope)) {
            body.put("shareScope", request.shareScope);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdatePermission"),
            new TeaPair("version", "minutes_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/minutes/" + taskUuid + "/permission"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdatePermissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新闪记权限</p>
     * 
     * @param request UpdatePermissionRequest
     * @return UpdatePermissionResponse
     */
    public UpdatePermissionResponse updatePermission(String taskUuid, UpdatePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdatePermissionHeaders headers = new UpdatePermissionHeaders();
        return this.updatePermissionWithOptions(taskUuid, request, headers, runtime);
    }
}
