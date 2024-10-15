// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkreport_1_0.models.*;

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
     * <p>创建模板</p>
     * 
     * @param request CreateTemplatesRequest
     * @param headers CreateTemplatesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTemplatesResponse
     */
    public CreateTemplatesResponse createTemplatesWithOptions(CreateTemplatesRequest request, CreateTemplatesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.allowAddReceivers)) {
            body.put("allowAddReceivers", request.allowAddReceivers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.allowEdit)) {
            body.put("allowEdit", request.allowEdit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.allowGetLocation)) {
            body.put("allowGetLocation", request.allowGetLocation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authDeptIds)) {
            body.put("authDeptIds", request.authDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authUserIds)) {
            body.put("authUserIds", request.authUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creator)) {
            body.put("creator", request.creator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defaultReceivedCids)) {
            body.put("defaultReceivedCids", request.defaultReceivedCids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defaultReceivedMasterLevels)) {
            body.put("defaultReceivedMasterLevels", request.defaultReceivedMasterLevels);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defaultReceivers)) {
            body.put("defaultReceivers", request.defaultReceivers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fields)) {
            body.put("fields", request.fields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.logo)) {
            body.put("logo", request.logo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxWordCount)) {
            body.put("maxWordCount", request.maxWordCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minWordCount)) {
            body.put("minWordCount", request.minWordCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateManagers)) {
            body.put("templateManagers", request.templateManagers);
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
            new TeaPair("action", "CreateTemplates"),
            new TeaPair("version", "report_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/report/templates"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTemplatesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建模板</p>
     * 
     * @param request CreateTemplatesRequest
     * @return CreateTemplatesResponse
     */
    public CreateTemplatesResponse createTemplates(CreateTemplatesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTemplatesHeaders headers = new CreateTemplatesHeaders();
        return this.createTemplatesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询员工提交和收到的日志列表</p>
     * 
     * @param request GetSendAndReceiveReportListRequest
     * @param headers GetSendAndReceiveReportListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSendAndReceiveReportListResponse
     */
    public GetSendAndReceiveReportListResponse getSendAndReceiveReportListWithOptions(GetSendAndReceiveReportListRequest request, GetSendAndReceiveReportListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.operationUserId)) {
            query.put("operationUserId", request.operationUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
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
            new TeaPair("action", "GetSendAndReceiveReportList"),
            new TeaPair("version", "report_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/report/users/sendAndReceiveLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSendAndReceiveReportListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询员工提交和收到的日志列表</p>
     * 
     * @param request GetSendAndReceiveReportListRequest
     * @return GetSendAndReceiveReportListResponse
     */
    public GetSendAndReceiveReportListResponse getSendAndReceiveReportList(GetSendAndReceiveReportListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSendAndReceiveReportListHeaders headers = new GetSendAndReceiveReportListHeaders();
        return this.getSendAndReceiveReportListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定周期的提交统计结果</p>
     * 
     * @param request GetSubmitStatisticsRequest
     * @param headers GetSubmitStatisticsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSubmitStatisticsResponse
     */
    public GetSubmitStatisticsResponse getSubmitStatisticsWithOptions(GetSubmitStatisticsRequest request, GetSubmitStatisticsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operationUserId)) {
            query.put("operationUserId", request.operationUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remindId)) {
            query.put("remindId", request.remindId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            query.put("templateId", request.templateId);
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
            new TeaPair("action", "GetSubmitStatistics"),
            new TeaPair("version", "report_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/report/submitStatisticalResults"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSubmitStatisticsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定周期的提交统计结果</p>
     * 
     * @param request GetSubmitStatisticsRequest
     * @return GetSubmitStatisticsResponse
     */
    public GetSubmitStatisticsResponse getSubmitStatistics(GetSubmitStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSubmitStatisticsHeaders headers = new GetSubmitStatisticsHeaders();
        return this.getSubmitStatisticsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取创建的统计规则信息</p>
     * 
     * @param request QueryRemindResultsRequest
     * @param headers QueryRemindResultsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryRemindResultsResponse
     */
    public QueryRemindResultsResponse queryRemindResultsWithOptions(QueryRemindResultsRequest request, QueryRemindResultsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operationUserId)) {
            query.put("operationUserId", request.operationUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            query.put("templateId", request.templateId);
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
            new TeaPair("action", "QueryRemindResults"),
            new TeaPair("version", "report_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/report/statisticalRules/results"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryRemindResultsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取创建的统计规则信息</p>
     * 
     * @param request QueryRemindResultsRequest
     * @return QueryRemindResultsResponse
     */
    public QueryRemindResultsResponse queryRemindResults(QueryRemindResultsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRemindResultsHeaders headers = new QueryRemindResultsHeaders();
        return this.queryRemindResultsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取日志详情</p>
     * 
     * @param request QueryReportDetailRequest
     * @param headers QueryReportDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryReportDetailResponse
     */
    public QueryReportDetailResponse queryReportDetailWithOptions(QueryReportDetailRequest request, QueryReportDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.reportId)) {
            query.put("reportId", request.reportId);
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
            new TeaPair("action", "QueryReportDetail"),
            new TeaPair("version", "report_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/report/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryReportDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取日志详情</p>
     * 
     * @param request QueryReportDetailRequest
     * @return QueryReportDetailResponse
     */
    public QueryReportDetailResponse queryReportDetail(QueryReportDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryReportDetailHeaders headers = new QueryReportDetailHeaders();
        return this.queryReportDetailWithOptions(request, headers, runtime);
    }
}
