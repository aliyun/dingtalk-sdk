// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkworkflow_1_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;
import com.aliyun.openapiutil.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public QueryFormInstanceResponse queryFormInstance(QueryFormInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryFormInstanceHeaders headers = new QueryFormInstanceHeaders();
        return this.queryFormInstanceWithOptions(request, headers, runtime);
    }

    public QueryFormInstanceResponse queryFormInstanceWithOptions(QueryFormInstanceRequest request, QueryFormInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.formInstanceId)) {
            query.put("formInstanceId", request.formInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            query.put("formCode", request.formCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appUuid)) {
            query.put("appUuid", request.appUuid);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryFormInstance", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/forms/instances", "json", req, runtime), new QueryFormInstanceResponse());
    }

    public ProcessForecastResponse processForecast(ProcessForecastRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ProcessForecastHeaders headers = new ProcessForecastHeaders();
        return this.processForecastWithOptions(request, headers, runtime);
    }

    public ProcessForecastResponse processForecastWithOptions(ProcessForecastRequest request, ProcessForecastHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("RequestId", request.requestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            body.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formComponentValues)) {
            body.put("formComponentValues", request.formComponentValues);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ProcessForecast", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/processes/forecast", "json", req, runtime), new ProcessForecastResponse());
    }

    public QueryAllProcessInstancesResponse queryAllProcessInstances(QueryAllProcessInstancesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllProcessInstancesHeaders headers = new QueryAllProcessInstancesHeaders();
        return this.queryAllProcessInstancesWithOptions(request, headers, runtime);
    }

    public QueryAllProcessInstancesResponse queryAllProcessInstancesWithOptions(QueryAllProcessInstancesRequest request, QueryAllProcessInstancesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTimeInMills)) {
            query.put("startTimeInMills", request.startTimeInMills);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTimeInMills)) {
            query.put("endTimeInMills", request.endTimeInMills);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            query.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appUuid)) {
            query.put("appUuid", request.appUuid);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryAllProcessInstances", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/processes/pages/instances", "json", req, runtime), new QueryAllProcessInstancesResponse());
    }

    public QueryAllFormInstancesResponse queryAllFormInstances(QueryAllFormInstancesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllFormInstancesHeaders headers = new QueryAllFormInstancesHeaders();
        return this.queryAllFormInstancesWithOptions(request, headers, runtime);
    }

    public QueryAllFormInstancesResponse queryAllFormInstancesWithOptions(QueryAllFormInstancesRequest request, QueryAllFormInstancesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appUuid)) {
            query.put("appUuid", request.appUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            query.put("formCode", request.formCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryAllFormInstances", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/forms/pages/instances", "json", req, runtime), new QueryAllFormInstancesResponse());
    }

    public QueryFormByBizTypeResponse queryFormByBizType(QueryFormByBizTypeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryFormByBizTypeHeaders headers = new QueryFormByBizTypeHeaders();
        return this.queryFormByBizTypeWithOptions(request, headers, runtime);
    }

    public QueryFormByBizTypeResponse queryFormByBizTypeWithOptions(QueryFormByBizTypeRequest request, QueryFormByBizTypeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appUuid)) {
            body.put("appUuid", request.appUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizTypes)) {
            body.put("bizTypes", request.bizTypes);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("QueryFormByBizType", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/forms/forminfos/query", "json", req, runtime), new QueryFormByBizTypeResponse());
    }

    public StartProcessInstanceResponse startProcessInstance(StartProcessInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        StartProcessInstanceHeaders headers = new StartProcessInstanceHeaders();
        return this.startProcessInstanceWithOptions(request, headers, runtime);
    }

    public StartProcessInstanceResponse startProcessInstanceWithOptions(StartProcessInstanceRequest request, StartProcessInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.originatorUserId)) {
            body.put("originatorUserId", request.originatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            body.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.approvers)) {
            body.put("approvers", request.approvers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ccList)) {
            body.put("ccList", request.ccList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ccPosition)) {
            body.put("ccPosition", request.ccPosition);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSelectActioners)) {
            body.put("targetSelectActioners", request.targetSelectActioners);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formComponentValues)) {
            body.put("formComponentValues", request.formComponentValues);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("RequestId", request.requestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("StartProcessInstance", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/processInstances", "json", req, runtime), new StartProcessInstanceResponse());
    }
}
