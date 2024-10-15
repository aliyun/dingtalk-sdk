// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkflashmeeting_1_0.models.*;

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
     * <p>创建钉闪会并绑定日程</p>
     * 
     * @param request CreateFlashMeetingRequest
     * @param headers CreateFlashMeetingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateFlashMeetingResponse
     */
    public CreateFlashMeetingResponse createFlashMeetingWithOptions(CreateFlashMeetingRequest request, CreateFlashMeetingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creator)) {
            body.put("creator", request.creator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventId)) {
            body.put("eventId", request.eventId);
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
            new TeaPair("action", "CreateFlashMeeting"),
            new TeaPair("version", "flashmeeting_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/flashmeeting/meetings"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateFlashMeetingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建钉闪会并绑定日程</p>
     * 
     * @param request CreateFlashMeetingRequest
     * @return CreateFlashMeetingResponse
     */
    public CreateFlashMeetingResponse createFlashMeeting(CreateFlashMeetingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateFlashMeetingHeaders headers = new CreateFlashMeetingHeaders();
        return this.createFlashMeetingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据日程获取闪会的信息</p>
     * 
     * @param request GetShanhuiByCalendarRequest
     * @param headers GetShanhuiByCalendarHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetShanhuiByCalendarResponse
     */
    public GetShanhuiByCalendarResponse getShanhuiByCalendarWithOptions(GetShanhuiByCalendarRequest request, GetShanhuiByCalendarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.eventId)) {
            query.put("eventId", request.eventId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "GetShanhuiByCalendar"),
            new TeaPair("version", "flashmeeting_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/flashmeeting/calendars/meeting"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetShanhuiByCalendarResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据日程获取闪会的信息</p>
     * 
     * @param request GetShanhuiByCalendarRequest
     * @return GetShanhuiByCalendarResponse
     */
    public GetShanhuiByCalendarResponse getShanhuiByCalendar(GetShanhuiByCalendarRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetShanhuiByCalendarHeaders headers = new GetShanhuiByCalendarHeaders();
        return this.getShanhuiByCalendarWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等</p>
     * 
     * @param headers GetShanhuiByShanhuiKeyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetShanhuiByShanhuiKeyResponse
     */
    public GetShanhuiByShanhuiKeyResponse getShanhuiByShanhuiKeyWithOptions(String flashmeetingKey, GetShanhuiByShanhuiKeyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetShanhuiByShanhuiKey"),
            new TeaPair("version", "flashmeeting_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/flashmeeting/meetings/keys/" + flashmeetingKey + "/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetShanhuiByShanhuiKeyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等</p>
     * @return GetShanhuiByShanhuiKeyResponse
     */
    public GetShanhuiByShanhuiKeyResponse getShanhuiByShanhuiKey(String flashmeetingKey) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetShanhuiByShanhuiKeyHeaders headers = new GetShanhuiByShanhuiKeyHeaders();
        return this.getShanhuiByShanhuiKeyWithOptions(flashmeetingKey, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据闪会文档id获取待办任务</p>
     * 
     * @param request GetTaskFromShanhuiDocRequest
     * @param headers GetTaskFromShanhuiDocHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTaskFromShanhuiDocResponse
     */
    public GetTaskFromShanhuiDocResponse getTaskFromShanhuiDocWithOptions(GetTaskFromShanhuiDocRequest request, GetTaskFromShanhuiDocHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.docKey)) {
            query.put("docKey", request.docKey);
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
            new TeaPair("action", "GetTaskFromShanhuiDoc"),
            new TeaPair("version", "flashmeeting_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/flashmeeting/meetings/tasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTaskFromShanhuiDocResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据闪会文档id获取待办任务</p>
     * 
     * @param request GetTaskFromShanhuiDocRequest
     * @return GetTaskFromShanhuiDocResponse
     */
    public GetTaskFromShanhuiDocResponse getTaskFromShanhuiDoc(GetTaskFromShanhuiDocRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTaskFromShanhuiDocHeaders headers = new GetTaskFromShanhuiDocHeaders();
        return this.getTaskFromShanhuiDocWithOptions(request, headers, runtime);
    }
}
