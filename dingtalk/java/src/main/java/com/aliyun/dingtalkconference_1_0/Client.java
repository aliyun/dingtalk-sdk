// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkconference_1_0.models.*;
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


    public QueryCloudRecordTextResponse queryCloudRecordText(String conferenceId, QueryCloudRecordTextRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCloudRecordTextHeaders headers = new QueryCloudRecordTextHeaders();
        return this.queryCloudRecordTextWithOptions(conferenceId, request, headers, runtime);
    }

    public QueryCloudRecordTextResponse queryCloudRecordTextWithOptions(String conferenceId, QueryCloudRecordTextRequest request, QueryCloudRecordTextHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.direction)) {
            query.put("direction", request.direction);
        }

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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryCloudRecordText", "conference_1.0", "HTTP", "GET", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getTexts", "json", req, runtime), new QueryCloudRecordTextResponse());
    }

    public CreateVideoConferenceResponse createVideoConference(CreateVideoConferenceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateVideoConferenceHeaders headers = new CreateVideoConferenceHeaders();
        return this.createVideoConferenceWithOptions(request, headers, runtime);
    }

    public CreateVideoConferenceResponse createVideoConferenceWithOptions(CreateVideoConferenceRequest request, CreateVideoConferenceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.confTitle)) {
            body.put("confTitle", request.confTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inviteUserIds)) {
            body.put("inviteUserIds", request.inviteUserIds);
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
        return TeaModel.toModel(this.doROARequest("CreateVideoConference", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences", "json", req, runtime), new CreateVideoConferenceResponse());
    }

    public QueryCloudRecordVideoPlayInfoResponse queryCloudRecordVideoPlayInfo(String conferenceId, QueryCloudRecordVideoPlayInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCloudRecordVideoPlayInfoHeaders headers = new QueryCloudRecordVideoPlayInfoHeaders();
        return this.queryCloudRecordVideoPlayInfoWithOptions(conferenceId, request, headers, runtime);
    }

    public QueryCloudRecordVideoPlayInfoResponse queryCloudRecordVideoPlayInfoWithOptions(String conferenceId, QueryCloudRecordVideoPlayInfoRequest request, QueryCloudRecordVideoPlayInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            query.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.regionId)) {
            query.put("regionId", request.regionId);
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
        return TeaModel.toModel(this.doROARequest("QueryCloudRecordVideoPlayInfo", "conference_1.0", "HTTP", "GET", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/videos/getPlayInfos", "json", req, runtime), new QueryCloudRecordVideoPlayInfoResponse());
    }

    public QueryConferenceInfoBatchResponse queryConferenceInfoBatch(QueryConferenceInfoBatchRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryConferenceInfoBatchHeaders headers = new QueryConferenceInfoBatchHeaders();
        return this.queryConferenceInfoBatchWithOptions(request, headers, runtime);
    }

    public QueryConferenceInfoBatchResponse queryConferenceInfoBatchWithOptions(QueryConferenceInfoBatchRequest request, QueryConferenceInfoBatchHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.conferenceIdList)) {
            body.put("conferenceIdList", request.conferenceIdList);
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
        return TeaModel.toModel(this.doROARequest("QueryConferenceInfoBatch", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/query", "json", req, runtime), new QueryConferenceInfoBatchResponse());
    }

    public StopCloudRecordResponse stopCloudRecord(String conferenceId, StopCloudRecordRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        StopCloudRecordHeaders headers = new StopCloudRecordHeaders();
        return this.stopCloudRecordWithOptions(conferenceId, request, headers, runtime);
    }

    public StopCloudRecordResponse stopCloudRecordWithOptions(String conferenceId, StopCloudRecordRequest request, StopCloudRecordHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
        return TeaModel.toModel(this.doROARequest("StopCloudRecord", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/stop", "json", req, runtime), new StopCloudRecordResponse());
    }

    public UpdateVideoConferenceExtInfoResponse updateVideoConferenceExtInfo(String conferenceId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateVideoConferenceExtInfoHeaders headers = new UpdateVideoConferenceExtInfoHeaders();
        return this.updateVideoConferenceExtInfoWithOptions(conferenceId, headers, runtime);
    }

    public UpdateVideoConferenceExtInfoResponse updateVideoConferenceExtInfoWithOptions(String conferenceId, UpdateVideoConferenceExtInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("UpdateVideoConferenceExtInfo", "conference_1.0", "HTTP", "PUT", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/extInfo", "json", req, runtime), new UpdateVideoConferenceExtInfoResponse());
    }

    public CloseVideoConferenceResponse closeVideoConference(String conferenceId, CloseVideoConferenceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CloseVideoConferenceHeaders headers = new CloseVideoConferenceHeaders();
        return this.closeVideoConferenceWithOptions(conferenceId, request, headers, runtime);
    }

    public CloseVideoConferenceResponse closeVideoConferenceWithOptions(String conferenceId, CloseVideoConferenceRequest request, CloseVideoConferenceHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("CloseVideoConference", "conference_1.0", "HTTP", "DELETE", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "", "json", req, runtime), new CloseVideoConferenceResponse());
    }

    public StopStreamOutResponse stopStreamOut(String conferenceId, StopStreamOutRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        StopStreamOutHeaders headers = new StopStreamOutHeaders();
        return this.stopStreamOutWithOptions(conferenceId, request, headers, runtime);
    }

    public StopStreamOutResponse stopStreamOutWithOptions(String conferenceId, StopStreamOutRequest request, StopStreamOutHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.streamId)) {
            body.put("streamId", request.streamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stopAllStream)) {
            body.put("stopAllStream", request.stopAllStream);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
        return TeaModel.toModel(this.doROARequest("StopStreamOut", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/stop", "json", req, runtime), new StopStreamOutResponse());
    }

    public StartCloudRecordResponse startCloudRecord(String conferenceId, StartCloudRecordRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        StartCloudRecordHeaders headers = new StartCloudRecordHeaders();
        return this.startCloudRecordWithOptions(conferenceId, request, headers, runtime);
    }

    public StartCloudRecordResponse startCloudRecordWithOptions(String conferenceId, StartCloudRecordRequest request, StartCloudRecordHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.smallWindowPosition)) {
            body.put("smallWindowPosition", request.smallWindowPosition);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mode)) {
            body.put("mode", request.mode);
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
        return TeaModel.toModel(this.doROARequest("StartCloudRecord", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/start", "json", req, runtime), new StartCloudRecordResponse());
    }

    public StartStreamOutResponse startStreamOut(String conferenceId, StartStreamOutRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        StartStreamOutHeaders headers = new StartStreamOutHeaders();
        return this.startStreamOutWithOptions(conferenceId, request, headers, runtime);
    }

    public StartStreamOutResponse startStreamOutWithOptions(String conferenceId, StartStreamOutRequest request, StartStreamOutHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needHostJoin)) {
            body.put("needHostJoin", request.needHostJoin);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.streamUrlList)) {
            body.put("streamUrlList", request.streamUrlList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.streamName)) {
            body.put("streamName", request.streamName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mode)) {
            body.put("mode", request.mode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.smallWindowPosition)) {
            body.put("smallWindowPosition", request.smallWindowPosition);
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
        return TeaModel.toModel(this.doROARequest("StartStreamOut", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/start", "json", req, runtime), new StartStreamOutResponse());
    }

    public QueryCloudRecordVideoResponse queryCloudRecordVideo(String conferenceId, QueryCloudRecordVideoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCloudRecordVideoHeaders headers = new QueryCloudRecordVideoHeaders();
        return this.queryCloudRecordVideoWithOptions(conferenceId, request, headers, runtime);
    }

    public QueryCloudRecordVideoResponse queryCloudRecordVideoWithOptions(String conferenceId, QueryCloudRecordVideoRequest request, QueryCloudRecordVideoHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryCloudRecordVideo", "conference_1.0", "HTTP", "GET", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getVideos", "json", req, runtime), new QueryCloudRecordVideoResponse());
    }
}
