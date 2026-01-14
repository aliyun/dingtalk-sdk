// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdvi_1_0.models.*;

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
     * <p>获取音频文件下载地址</p>
     * 
     * @param request GetAudioFileDownloadInfoRequest
     * @param headers GetAudioFileDownloadInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAudioFileDownloadInfoResponse
     */
    public GetAudioFileDownloadInfoResponse getAudioFileDownloadInfoWithOptions(GetAudioFileDownloadInfoRequest request, GetAudioFileDownloadInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceType)) {
            body.put("deviceType", request.deviceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileId)) {
            body.put("fileId", request.fileId);
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
            new TeaPair("action", "GetAudioFileDownloadInfo"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/device/audio/download"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAudioFileDownloadInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取音频文件下载地址</p>
     * 
     * @param request GetAudioFileDownloadInfoRequest
     * @return GetAudioFileDownloadInfoResponse
     */
    public GetAudioFileDownloadInfoResponse getAudioFileDownloadInfo(GetAudioFileDownloadInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAudioFileDownloadInfoHeaders headers = new GetAudioFileDownloadInfoHeaders();
        return this.getAudioFileDownloadInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取音频文件信息</p>
     * 
     * @param request GetAudioFileInfoRequest
     * @param headers GetAudioFileInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAudioFileInfoResponse
     */
    public GetAudioFileInfoResponse getAudioFileInfoWithOptions(GetAudioFileInfoRequest request, GetAudioFileInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceType)) {
            body.put("deviceType", request.deviceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileId)) {
            body.put("fileId", request.fileId);
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
            new TeaPair("action", "GetAudioFileInfo"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/device/audio/get"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAudioFileInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取音频文件信息</p>
     * 
     * @param request GetAudioFileInfoRequest
     * @return GetAudioFileInfoResponse
     */
    public GetAudioFileInfoResponse getAudioFileInfo(GetAudioFileInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAudioFileInfoHeaders headers = new GetAudioFileInfoHeaders();
        return this.getAudioFileInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询客户数据</p>
     * 
     * @param request GetCustomerInfoRequest
     * @param headers GetCustomerInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCustomerInfoResponse
     */
    public GetCustomerInfoResponse getCustomerInfoWithOptions(GetCustomerInfoRequest request, GetCustomerInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customerId)) {
            query.put("customerId", request.customerId);
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
            new TeaPair("action", "GetCustomerInfo"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/customer"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCustomerInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询客户数据</p>
     * 
     * @param request GetCustomerInfoRequest
     * @return GetCustomerInfoResponse
     */
    public GetCustomerInfoResponse getCustomerInfo(GetCustomerInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCustomerInfoHeaders headers = new GetCustomerInfoHeaders();
        return this.getCustomerInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取客户洞察信息</p>
     * 
     * @param request GetCustomerInsightRequest
     * @param headers GetCustomerInsightHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCustomerInsightResponse
     */
    public GetCustomerInsightResponse getCustomerInsightWithOptions(GetCustomerInsightRequest request, GetCustomerInsightHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customerId)) {
            query.put("customerId", request.customerId);
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
            new TeaPair("action", "GetCustomerInsight"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/customers/insights"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCustomerInsightResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取客户洞察信息</p>
     * 
     * @param request GetCustomerInsightRequest
     * @return GetCustomerInsightResponse
     */
    public GetCustomerInsightResponse getCustomerInsight(GetCustomerInsightRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCustomerInsightHeaders headers = new GetCustomerInsightHeaders();
        return this.getCustomerInsightWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取服务章节摘要</p>
     * 
     * @param request GetServiceChapterSummaryRequest
     * @param headers GetServiceChapterSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetServiceChapterSummaryResponse
     */
    public GetServiceChapterSummaryResponse getServiceChapterSummaryWithOptions(GetServiceChapterSummaryRequest request, GetServiceChapterSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recordId)) {
            query.put("recordId", request.recordId);
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
            new TeaPair("action", "GetServiceChapterSummary"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/service/chapters/summary"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetServiceChapterSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取服务章节摘要</p>
     * 
     * @param request GetServiceChapterSummaryRequest
     * @return GetServiceChapterSummaryResponse
     */
    public GetServiceChapterSummaryResponse getServiceChapterSummary(GetServiceChapterSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetServiceChapterSummaryHeaders headers = new GetServiceChapterSummaryHeaders();
        return this.getServiceChapterSummaryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取服务会话总结</p>
     * 
     * @param request GetServiceChatSummaryRequest
     * @param headers GetServiceChatSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetServiceChatSummaryResponse
     */
    public GetServiceChatSummaryResponse getServiceChatSummaryWithOptions(GetServiceChatSummaryRequest request, GetServiceChatSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recordId)) {
            query.put("recordId", request.recordId);
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
            new TeaPair("action", "GetServiceChatSummary"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/service/chats/summary"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetServiceChatSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取服务会话总结</p>
     * 
     * @param request GetServiceChatSummaryRequest
     * @return GetServiceChatSummaryResponse
     */
    public GetServiceChatSummaryResponse getServiceChatSummary(GetServiceChatSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetServiceChatSummaryHeaders headers = new GetServiceChatSummaryHeaders();
        return this.getServiceChatSummaryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询服务质检信息</p>
     * 
     * @param request GetServiceQualityInspectionRequest
     * @param headers GetServiceQualityInspectionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetServiceQualityInspectionResponse
     */
    public GetServiceQualityInspectionResponse getServiceQualityInspectionWithOptions(GetServiceQualityInspectionRequest request, GetServiceQualityInspectionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recordId)) {
            query.put("recordId", request.recordId);
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
            new TeaPair("action", "GetServiceQualityInspection"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/service/quality-inspections"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetServiceQualityInspectionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询服务质检信息</p>
     * 
     * @param request GetServiceQualityInspectionRequest
     * @return GetServiceQualityInspectionResponse
     */
    public GetServiceQualityInspectionResponse getServiceQualityInspection(GetServiceQualityInspectionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetServiceQualityInspectionHeaders headers = new GetServiceQualityInspectionHeaders();
        return this.getServiceQualityInspectionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取服务记录音频转写信息</p>
     * 
     * @param request GetServiceRecordTranscriptRequest
     * @param headers GetServiceRecordTranscriptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetServiceRecordTranscriptResponse
     */
    public GetServiceRecordTranscriptResponse getServiceRecordTranscriptWithOptions(GetServiceRecordTranscriptRequest request, GetServiceRecordTranscriptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            query.put("id", request.id);
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
            new TeaPair("action", "GetServiceRecordTranscript"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/service/transcript"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetServiceRecordTranscriptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取服务记录音频转写信息</p>
     * 
     * @param request GetServiceRecordTranscriptRequest
     * @return GetServiceRecordTranscriptResponse
     */
    public GetServiceRecordTranscriptResponse getServiceRecordTranscript(GetServiceRecordTranscriptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetServiceRecordTranscriptHeaders headers = new GetServiceRecordTranscriptHeaders();
        return this.getServiceRecordTranscriptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件转写的概要信息</p>
     * 
     * @param request GetTranscriptSummaryRequest
     * @param headers GetTranscriptSummaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTranscriptSummaryResponse
     */
    public GetTranscriptSummaryResponse getTranscriptSummaryWithOptions(GetTranscriptSummaryRequest request, GetTranscriptSummaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceType)) {
            query.put("deviceType", request.deviceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileId)) {
            query.put("fileId", request.fileId);
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
            new TeaPair("action", "GetTranscriptSummary"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/transcripts/summary"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTranscriptSummaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件转写的概要信息</p>
     * 
     * @param request GetTranscriptSummaryRequest
     * @return GetTranscriptSummaryResponse
     */
    public GetTranscriptSummaryResponse getTranscriptSummary(GetTranscriptSummaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTranscriptSummaryHeaders headers = new GetTranscriptSummaryHeaders();
        return this.getTranscriptSummaryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询客户列表</p>
     * 
     * @param request ListCustomerRequest
     * @param headers ListCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListCustomerResponse
     */
    public ListCustomerResponse listCustomerWithOptions(ListCustomerRequest request, ListCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.ownerUserId)) {
            query.put("ownerUserId", request.ownerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamCode)) {
            query.put("teamCode", request.teamCode);
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
            new TeaPair("action", "ListCustomer"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/customers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListCustomerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询客户列表</p>
     * 
     * @param request ListCustomerRequest
     * @return ListCustomerResponse
     */
    public ListCustomerResponse listCustomer(ListCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListCustomerHeaders headers = new ListCustomerHeaders();
        return this.listCustomerWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询服务记录</p>
     * 
     * @param request ListServiceRecordRequest
     * @param headers ListServiceRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListServiceRecordResponse
     */
    public ListServiceRecordResponse listServiceRecordWithOptions(ListServiceRecordRequest request, ListServiceRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamCode)) {
            query.put("teamCode", request.teamCode);
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
            new TeaPair("action", "ListServiceRecord"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/service-records"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListServiceRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询服务记录</p>
     * 
     * @param request ListServiceRecordRequest
     * @return ListServiceRecordResponse
     */
    public ListServiceRecordResponse listServiceRecord(ListServiceRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListServiceRecordHeaders headers = new ListServiceRecordHeaders();
        return this.listServiceRecordWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询服务记录待办列表</p>
     * 
     * @param request ListServiceTodoRequest
     * @param headers ListServiceTodoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListServiceTodoResponse
     */
    public ListServiceTodoResponse listServiceTodoWithOptions(ListServiceTodoRequest request, ListServiceTodoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recordId)) {
            query.put("recordId", request.recordId);
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
            new TeaPair("action", "ListServiceTodo"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/service-todos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListServiceTodoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询服务记录待办列表</p>
     * 
     * @param request ListServiceTodoRequest
     * @return ListServiceTodoResponse
     */
    public ListServiceTodoResponse listServiceTodo(ListServiceTodoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListServiceTodoHeaders headers = new ListServiceTodoHeaders();
        return this.listServiceTodoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询团队列表</p>
     * 
     * @param request ListTeamRequest
     * @param headers ListTeamHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListTeamResponse
     */
    public ListTeamResponse listTeamWithOptions(ListTeamRequest request, ListTeamHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "ListTeam"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/teams"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListTeamResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询团队列表</p>
     * 
     * @param request ListTeamRequest
     * @return ListTeamResponse
     */
    public ListTeamResponse listTeam(ListTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListTeamHeaders headers = new ListTeamHeaders();
        return this.listTeamWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询asr结果</p>
     * 
     * @param request QueryAsrTaskRequest
     * @param headers QueryAsrTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAsrTaskResponse
     */
    public QueryAsrTaskResponse queryAsrTaskWithOptions(QueryAsrTaskRequest request, QueryAsrTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            query.put("taskId", request.taskId);
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
            new TeaPair("action", "QueryAsrTask"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/asr/query"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAsrTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询asr结果</p>
     * 
     * @param request QueryAsrTaskRequest
     * @return QueryAsrTaskResponse
     */
    public QueryAsrTaskResponse queryAsrTask(QueryAsrTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAsrTaskHeaders headers = new QueryAsrTaskHeaders();
        return this.queryAsrTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询指定设备的音频文件列表</p>
     * 
     * @param request QueryAudioFileRequest
     * @param headers QueryAudioFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAudioFileResponse
     */
    public QueryAudioFileResponse queryAudioFileWithOptions(QueryAudioFileRequest request, QueryAudioFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceType)) {
            body.put("deviceType", request.deviceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTimestamp)) {
            body.put("endTimestamp", request.endTimestamp);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTimestamp)) {
            body.put("startTimestamp", request.startTimestamp);
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
            new TeaPair("action", "QueryAudioFile"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/device/audio/list"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAudioFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询指定设备的音频文件列表</p>
     * 
     * @param request QueryAudioFileRequest
     * @return QueryAudioFileResponse
     */
    public QueryAudioFileResponse queryAudioFile(QueryAudioFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAudioFileHeaders headers = new QueryAudioFileHeaders();
        return this.queryAudioFileWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取设备列表</p>
     * 
     * @param request QueryDeviceDetailRequest
     * @param headers QueryDeviceDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDeviceDetailResponse
     */
    public QueryDeviceDetailResponse queryDeviceDetailWithOptions(QueryDeviceDetailRequest request, QueryDeviceDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceType)) {
            body.put("deviceType", request.deviceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.snList)) {
            body.put("snList", request.snList);
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
            new TeaPair("action", "QueryDeviceDetail"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/device/list"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDeviceDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取设备列表</p>
     * 
     * @param request QueryDeviceDetailRequest
     * @return QueryDeviceDetailResponse
     */
    public QueryDeviceDetailResponse queryDeviceDetail(QueryDeviceDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDeviceDetailHeaders headers = new QueryDeviceDetailHeaders();
        return this.queryDeviceDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询设备属性</p>
     * 
     * @param request QueryDeviceStatusRequest
     * @param headers QueryDeviceStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDeviceStatusResponse
     */
    public QueryDeviceStatusResponse queryDeviceStatusWithOptions(QueryDeviceStatusRequest request, QueryDeviceStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceType)) {
            body.put("deviceType", request.deviceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.snList)) {
            body.put("snList", request.snList);
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
            new TeaPair("action", "QueryDeviceStatus"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/device/status"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDeviceStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询设备属性</p>
     * 
     * @param request QueryDeviceStatusRequest
     * @return QueryDeviceStatusResponse
     */
    public QueryDeviceStatusResponse queryDeviceStatus(QueryDeviceStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDeviceStatusHeaders headers = new QueryDeviceStatusHeaders();
        return this.queryDeviceStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>asr离线任务</p>
     * 
     * @param request SubmitAsrTaskRequest
     * @param headers SubmitAsrTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SubmitAsrTaskResponse
     */
    public SubmitAsrTaskResponse submitAsrTaskWithOptions(SubmitAsrTaskRequest request, SubmitAsrTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizKey)) {
            body.put("bizKey", request.bizKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dentryId)) {
            body.put("dentryId", request.dentryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.phrases)) {
            body.put("phrases", request.phrases);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceLanguage)) {
            body.put("sourceLanguage", request.sourceLanguage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceId)) {
            body.put("spaceId", request.spaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.transcription)) {
            body.put("transcription", request.transcription);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "SubmitAsrTask"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/asr/create"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SubmitAsrTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>asr离线任务</p>
     * 
     * @param request SubmitAsrTaskRequest
     * @return SubmitAsrTaskResponse
     */
    public SubmitAsrTaskResponse submitAsrTask(SubmitAsrTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SubmitAsrTaskHeaders headers = new SubmitAsrTaskHeaders();
        return this.submitAsrTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>asr离线任务</p>
     * 
     * @param request VideoCustomerSplitRequest
     * @param headers VideoCustomerSplitHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return VideoCustomerSplitResponse
     */
    public VideoCustomerSplitResponse videoCustomerSplitWithOptions(VideoCustomerSplitRequest request, VideoCustomerSplitHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customer)) {
            body.put("customer", request.customer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.segmentId)) {
            body.put("segmentId", request.segmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "VideoCustomerSplit"),
            new TeaPair("version", "dvi_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dvi/service/audiosplit"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new VideoCustomerSplitResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>asr离线任务</p>
     * 
     * @param request VideoCustomerSplitRequest
     * @return VideoCustomerSplitResponse
     */
    public VideoCustomerSplitResponse videoCustomerSplit(VideoCustomerSplitRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        VideoCustomerSplitHeaders headers = new VideoCustomerSplitHeaders();
        return this.videoCustomerSplitWithOptions(request, headers, runtime);
    }
}
