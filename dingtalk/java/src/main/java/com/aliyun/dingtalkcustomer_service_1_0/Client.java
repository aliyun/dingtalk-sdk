// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcustomer_service_1_0.models.*;

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
     * <p>创建工单</p>
     * 
     * @param request CreateTicketRequest
     * @param headers CreateTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTicketResponse
     */
    public CreateTicketResponse createTicketWithOptions(CreateTicketRequest request, CreateTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateTicket"),
            new TeaPair("version", "customerService_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/customerService/tickets"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTicketResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建工单</p>
     * 
     * @param request CreateTicketRequest
     * @return CreateTicketResponse
     */
    public CreateTicketResponse createTicket(CreateTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTicketHeaders headers = new CreateTicketHeaders();
        return this.createTicketWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>执行工单活动</p>
     * 
     * @param request ExecuteActivityRequest
     * @param headers ExecuteActivityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ExecuteActivityResponse
     */
    public ExecuteActivityResponse executeActivityWithOptions(String ticketId, ExecuteActivityRequest request, ExecuteActivityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ExecuteActivity"),
            new TeaPair("version", "customerService_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/customerService/tickets/" + ticketId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExecuteActivityResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>执行工单活动</p>
     * 
     * @param request ExecuteActivityRequest
     * @return ExecuteActivityResponse
     */
    public ExecuteActivityResponse executeActivity(String ticketId, ExecuteActivityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExecuteActivityHeaders headers = new ExecuteActivityHeaders();
        return this.executeActivityWithOptions(ticketId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取source列表</p>
     * 
     * @param request GetUserSourceListRequest
     * @param headers GetUserSourceListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserSourceListResponse
     */
    public GetUserSourceListResponse getUserSourceListWithOptions(GetUserSourceListRequest request, GetUserSourceListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUserSourceList"),
            new TeaPair("version", "customerService_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/customerService/customers/sources"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserSourceListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取source列表</p>
     * 
     * @param request GetUserSourceListRequest
     * @return GetUserSourceListResponse
     */
    public GetUserSourceListResponse getUserSourceList(GetUserSourceListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserSourceListHeaders headers = new GetUserSourceListHeaders();
        return this.getUserSourceListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询动作记录</p>
     * 
     * @param request PageListActionRequest
     * @param headers PageListActionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PageListActionResponse
     */
    public PageListActionResponse pageListActionWithOptions(String ticketId, PageListActionRequest request, PageListActionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PageListAction"),
            new TeaPair("version", "customerService_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/customerService/tickets/" + ticketId + "/actions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PageListActionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询动作记录</p>
     * 
     * @param request PageListActionRequest
     * @return PageListActionResponse
     */
    public PageListActionResponse pageListAction(String ticketId, PageListActionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PageListActionHeaders headers = new PageListActionHeaders();
        return this.pageListActionWithOptions(ticketId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询机器人信息</p>
     * 
     * @param request PageListRobotRequest
     * @param headers PageListRobotHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PageListRobotResponse
     */
    public PageListRobotResponse pageListRobotWithOptions(PageListRobotRequest request, PageListRobotHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PageListRobot"),
            new TeaPair("version", "customerService_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/customerService/robots"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PageListRobotResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询机器人信息</p>
     * 
     * @param request PageListRobotRequest
     * @return PageListRobotResponse
     */
    public PageListRobotResponse pageListRobot(PageListRobotRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PageListRobotHeaders headers = new PageListRobotHeaders();
        return this.pageListRobotWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询工单</p>
     * 
     * @param request PageListTicketRequest
     * @param headers PageListTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PageListTicketResponse
     */
    public PageListTicketResponse pageListTicketWithOptions(PageListTicketRequest request, PageListTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PageListTicket"),
            new TeaPair("version", "customerService_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/customerService/tickets"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PageListTicketResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询工单</p>
     * 
     * @param request PageListTicketRequest
     * @return PageListTicketResponse
     */
    public PageListTicketResponse pageListTicket(PageListTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PageListTicketHeaders headers = new PageListTicketHeaders();
        return this.pageListTicketWithOptions(request, headers, runtime);
    }
}
