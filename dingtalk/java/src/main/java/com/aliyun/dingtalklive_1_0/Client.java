// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalklive_1_0.models.*;
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


    public AddShareCidListResponse addShareCidList(String feedId, AddShareCidListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddShareCidListHeaders headers = new AddShareCidListHeaders();
        return this.addShareCidListWithOptions(feedId, request, headers, runtime);
    }

    public AddShareCidListResponse addShareCidListWithOptions(String feedId, AddShareCidListRequest request, AddShareCidListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        feedId = com.aliyun.openapiutil.Client.getEncodeParam(feedId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupIdType)) {
            body.put("groupIdType", request.groupIdType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupIds)) {
            body.put("groupIds", request.groupIds);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddShareCidList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/share", "json", req, runtime), new AddShareCidListResponse());
    }

    public CreateCloudFeedResponse createCloudFeed(CreateCloudFeedRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateCloudFeedHeaders headers = new CreateCloudFeedHeaders();
        return this.createCloudFeedWithOptions(request, headers, runtime);
    }

    public CreateCloudFeedResponse createCloudFeedWithOptions(CreateCloudFeedRequest request, CreateCloudFeedHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coverUrl)) {
            body.put("coverUrl", request.coverUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.intro)) {
            body.put("intro", request.intro);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.videoUrl)) {
            body.put("videoUrl", request.videoUrl);
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
        return TeaModel.toModel(this.doROARequest("CreateCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds", "json", req, runtime), new CreateCloudFeedResponse());
    }

    public CreateLiveResponse createLive(CreateLiveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateLiveHeaders headers = new CreateLiveHeaders();
        return this.createLiveWithOptions(request, headers, runtime);
    }

    public CreateLiveResponse createLiveWithOptions(CreateLiveRequest request, CreateLiveHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coverUrl)) {
            body.put("coverUrl", request.coverUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.introduction)) {
            body.put("introduction", request.introduction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.preEndTime)) {
            body.put("preEndTime", request.preEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.preStartTime)) {
            body.put("preStartTime", request.preStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateLive", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/lives", "json", req, runtime), new CreateLiveResponse());
    }

    public DeleteLiveResponse deleteLive(DeleteLiveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteLiveHeaders headers = new DeleteLiveHeaders();
        return this.deleteLiveWithOptions(request, headers, runtime);
    }

    public DeleteLiveResponse deleteLiveWithOptions(DeleteLiveRequest request, DeleteLiveHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteLive", "live_1.0", "HTTP", "DELETE", "AK", "/v1.0/live/lives", "json", req, runtime), new DeleteLiveResponse());
    }

    public DeleteLiveFeedResponse deleteLiveFeed(String feedId, DeleteLiveFeedRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteLiveFeedHeaders headers = new DeleteLiveFeedHeaders();
        return this.deleteLiveFeedWithOptions(feedId, request, headers, runtime);
    }

    public DeleteLiveFeedResponse deleteLiveFeedWithOptions(String feedId, DeleteLiveFeedRequest request, DeleteLiveFeedHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        feedId = com.aliyun.openapiutil.Client.getEncodeParam(feedId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteLiveFeed", "live_1.0", "HTTP", "DELETE", "AK", "/v1.0/live/openFeeds/" + feedId + "", "json", req, runtime), new DeleteLiveFeedResponse());
    }

    public EditFeedReplayResponse editFeedReplay(String feedId, EditFeedReplayRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditFeedReplayHeaders headers = new EditFeedReplayHeaders();
        return this.editFeedReplayWithOptions(feedId, request, headers, runtime);
    }

    public EditFeedReplayResponse editFeedReplayWithOptions(String feedId, EditFeedReplayRequest request, EditFeedReplayHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        feedId = com.aliyun.openapiutil.Client.getEncodeParam(feedId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.editEndTime)) {
            body.put("editEndTime", request.editEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.editStartTime)) {
            body.put("editStartTime", request.editStartTime);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("EditFeedReplay", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId + "/cutReplay", "json", req, runtime), new EditFeedReplayResponse());
    }

    public ModifyFeedWhiteListResponse modifyFeedWhiteList(String feedId, ModifyFeedWhiteListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ModifyFeedWhiteListHeaders headers = new ModifyFeedWhiteListHeaders();
        return this.modifyFeedWhiteListWithOptions(feedId, request, headers, runtime);
    }

    public ModifyFeedWhiteListResponse modifyFeedWhiteListWithOptions(String feedId, ModifyFeedWhiteListRequest tmpReq, ModifyFeedWhiteListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        feedId = com.aliyun.openapiutil.Client.getEncodeParam(feedId);
        ModifyFeedWhiteListShrinkRequest request = new ModifyFeedWhiteListShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.modifyUserList)) {
            request.modifyUserListShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.modifyUserList, "modifyUserList", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            query.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifyUserListShrink)) {
            query.put("modifyUserList", request.modifyUserListShrink);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ModifyFeedWhiteList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId + "/whiteList", "json", req, runtime), new ModifyFeedWhiteListResponse());
    }

    public QueryFeedWhiteListResponse queryFeedWhiteList(String feedId, QueryFeedWhiteListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryFeedWhiteListHeaders headers = new QueryFeedWhiteListHeaders();
        return this.queryFeedWhiteListWithOptions(feedId, request, headers, runtime);
    }

    public QueryFeedWhiteListResponse queryFeedWhiteListWithOptions(String feedId, QueryFeedWhiteListRequest request, QueryFeedWhiteListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        feedId = com.aliyun.openapiutil.Client.getEncodeParam(feedId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryFeedWhiteList", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/openFeeds/" + feedId + "/whiteList", "json", req, runtime), new QueryFeedWhiteListResponse());
    }

    public QueryLiveInfoResponse queryLiveInfo(QueryLiveInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryLiveInfoHeaders headers = new QueryLiveInfoHeaders();
        return this.queryLiveInfoWithOptions(request, headers, runtime);
    }

    public QueryLiveInfoResponse queryLiveInfoWithOptions(QueryLiveInfoRequest request, QueryLiveInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryLiveInfo", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/lives", "json", req, runtime), new QueryLiveInfoResponse());
    }

    public QueryLiveWatchDetailResponse queryLiveWatchDetail(QueryLiveWatchDetailRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryLiveWatchDetailHeaders headers = new QueryLiveWatchDetailHeaders();
        return this.queryLiveWatchDetailWithOptions(request, headers, runtime);
    }

    public QueryLiveWatchDetailResponse queryLiveWatchDetailWithOptions(QueryLiveWatchDetailRequest request, QueryLiveWatchDetailHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryLiveWatchDetail", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/lives/watchDetails", "json", req, runtime), new QueryLiveWatchDetailResponse());
    }

    public QueryLiveWatchUserListResponse queryLiveWatchUserList(QueryLiveWatchUserListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryLiveWatchUserListHeaders headers = new QueryLiveWatchUserListHeaders();
        return this.queryLiveWatchUserListWithOptions(request, headers, runtime);
    }

    public QueryLiveWatchUserListResponse queryLiveWatchUserListWithOptions(QueryLiveWatchUserListRequest request, QueryLiveWatchUserListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryLiveWatchUserList", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/lives/watchUsers", "json", req, runtime), new QueryLiveWatchUserListResponse());
    }

    public StartCloudFeedResponse startCloudFeed(String feedId, StartCloudFeedRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        StartCloudFeedHeaders headers = new StartCloudFeedHeaders();
        return this.startCloudFeedWithOptions(feedId, request, headers, runtime);
    }

    public StartCloudFeedResponse startCloudFeedWithOptions(String feedId, StartCloudFeedRequest request, StartCloudFeedHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        feedId = com.aliyun.openapiutil.Client.getEncodeParam(feedId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("StartCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/start", "json", req, runtime), new StartCloudFeedResponse());
    }

    public StopCloudFeedResponse stopCloudFeed(String feedId, StopCloudFeedRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        StopCloudFeedHeaders headers = new StopCloudFeedHeaders();
        return this.stopCloudFeedWithOptions(feedId, request, headers, runtime);
    }

    public StopCloudFeedResponse stopCloudFeedWithOptions(String feedId, StopCloudFeedRequest request, StopCloudFeedHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        feedId = com.aliyun.openapiutil.Client.getEncodeParam(feedId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("StopCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/stop", "json", req, runtime), new StopCloudFeedResponse());
    }

    public UpdateLiveResponse updateLive(UpdateLiveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateLiveHeaders headers = new UpdateLiveHeaders();
        return this.updateLiveWithOptions(request, headers, runtime);
    }

    public UpdateLiveResponse updateLiveWithOptions(UpdateLiveRequest request, UpdateLiveHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coverUrl)) {
            body.put("coverUrl", request.coverUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.introduction)) {
            body.put("introduction", request.introduction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            body.put("liveId", request.liveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.preEndTime)) {
            body.put("preEndTime", request.preEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.preStartTime)) {
            body.put("preStartTime", request.preStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateLive", "live_1.0", "HTTP", "PUT", "AK", "/v1.0/live/lives", "json", req, runtime), new UpdateLiveResponse());
    }

    public UpdateLiveFeedResponse updateLiveFeed(String feedId, UpdateLiveFeedRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateLiveFeedHeaders headers = new UpdateLiveFeedHeaders();
        return this.updateLiveFeedWithOptions(feedId, request, headers, runtime);
    }

    public UpdateLiveFeedResponse updateLiveFeedWithOptions(String feedId, UpdateLiveFeedRequest request, UpdateLiveFeedHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        feedId = com.aliyun.openapiutil.Client.getEncodeParam(feedId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coverUrl)) {
            query.put("coverUrl", request.coverUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.introduction)) {
            query.put("introduction", request.introduction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            query.put("title", request.title);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateLiveFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId + "", "json", req, runtime), new UpdateLiveFeedResponse());
    }
}
