// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcustomer_service_1_0.models.*;
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


    public CreateTicketResponse createTicket(CreateTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateTicketHeaders headers = new CreateTicketHeaders();
        return this.createTicketWithOptions(request, headers, runtime);
    }

    public CreateTicketResponse createTicketWithOptions(CreateTicketRequest request, CreateTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.foreignId)) {
            body.put("foreignId", request.foreignId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.foreignName)) {
            body.put("foreignName", request.foreignName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openInstanceId)) {
            body.put("openInstanceId", request.openInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productionType)) {
            body.put("productionType", request.productionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.properties)) {
            body.put("properties", request.properties);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceId)) {
            body.put("sourceId", request.sourceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateTicket", "customerService_1.0", "HTTP", "POST", "AK", "/v1.0/customerService/tickets", "json", req, runtime), new CreateTicketResponse());
    }

    public ExecuteActivityResponse executeActivity(String ticketId, ExecuteActivityRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ExecuteActivityHeaders headers = new ExecuteActivityHeaders();
        return this.executeActivityWithOptions(ticketId, request, headers, runtime);
    }

    public ExecuteActivityResponse executeActivityWithOptions(String ticketId, ExecuteActivityRequest request, ExecuteActivityHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        ticketId = com.aliyun.openapiutil.Client.getEncodeParam(ticketId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.activityCode)) {
            body.put("activityCode", request.activityCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.foreignId)) {
            body.put("foreignId", request.foreignId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.foreignName)) {
            body.put("foreignName", request.foreignName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openInstanceId)) {
            body.put("openInstanceId", request.openInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productionType)) {
            body.put("productionType", request.productionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.properties)) {
            body.put("properties", request.properties);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceId)) {
            body.put("sourceId", request.sourceId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ExecuteActivity", "customerService_1.0", "HTTP", "PUT", "AK", "/v1.0/customerService/tickets/" + ticketId + "", "json", req, runtime), new ExecuteActivityResponse());
    }

    public GetUserSourceListResponse getUserSourceList(GetUserSourceListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUserSourceListHeaders headers = new GetUserSourceListHeaders();
        return this.getUserSourceListWithOptions(request, headers, runtime);
    }

    public GetUserSourceListResponse getUserSourceListWithOptions(GetUserSourceListRequest request, GetUserSourceListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            query.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openInstanceId)) {
            query.put("openInstanceId", request.openInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            query.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgName)) {
            query.put("orgName", request.orgName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productionType)) {
            query.put("productionType", request.productionType);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetUserSourceList", "customerService_1.0", "HTTP", "GET", "AK", "/v1.0/customerService/customers/sources", "json", req, runtime), new GetUserSourceListResponse());
    }

    public PageListActionResponse pageListAction(String ticketId, PageListActionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PageListActionHeaders headers = new PageListActionHeaders();
        return this.pageListActionWithOptions(ticketId, request, headers, runtime);
    }

    public PageListActionResponse pageListActionWithOptions(String ticketId, PageListActionRequest request, PageListActionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        ticketId = com.aliyun.openapiutil.Client.getEncodeParam(ticketId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openInstanceId)) {
            query.put("openInstanceId", request.openInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productionType)) {
            query.put("productionType", request.productionType);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("PageListAction", "customerService_1.0", "HTTP", "GET", "AK", "/v1.0/customerService/tickets/" + ticketId + "/actions", "json", req, runtime), new PageListActionResponse());
    }

    public PageListRobotResponse pageListRobot(PageListRobotRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PageListRobotHeaders headers = new PageListRobotHeaders();
        return this.pageListRobotWithOptions(request, headers, runtime);
    }

    public PageListRobotResponse pageListRobotWithOptions(PageListRobotRequest request, PageListRobotHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openInstanceId)) {
            query.put("openInstanceId", request.openInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productionType)) {
            query.put("productionType", request.productionType);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("PageListRobot", "customerService_1.0", "HTTP", "GET", "AK", "/v1.0/customerService/robots", "json", req, runtime), new PageListRobotResponse());
    }

    public PageListTicketResponse pageListTicket(PageListTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PageListTicketHeaders headers = new PageListTicketHeaders();
        return this.pageListTicketWithOptions(request, headers, runtime);
    }

    public PageListTicketResponse pageListTicketWithOptions(PageListTicketRequest request, PageListTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.foreignId)) {
            query.put("foreignId", request.foreignId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openInstanceId)) {
            query.put("openInstanceId", request.openInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productionType)) {
            query.put("productionType", request.productionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceId)) {
            query.put("sourceId", request.sourceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            query.put("templateId", request.templateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ticketId)) {
            query.put("ticketId", request.ticketId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ticketStatus)) {
            query.put("ticketStatus", request.ticketStatus);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("PageListTicket", "customerService_1.0", "HTTP", "GET", "AK", "/v1.0/customerService/tickets", "json", req, runtime), new PageListTicketResponse());
    }
}
