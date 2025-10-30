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
}
