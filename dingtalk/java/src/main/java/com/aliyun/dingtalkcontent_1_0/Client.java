// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcontent_1_0.models.*;
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


    public GetMediaCerficateResponse getMediaCerficate(GetMediaCerficateRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetMediaCerficateHeaders headers = new GetMediaCerficateHeaders();
        return this.getMediaCerficateWithOptions(request, headers, runtime);
    }

    public GetMediaCerficateResponse getMediaCerficateWithOptions(GetMediaCerficateRequest request, GetMediaCerficateHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.thumbUrl)) {
            query.put("thumbUrl", request.thumbUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            query.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            query.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaTitle)) {
            query.put("mediaTitle", request.mediaTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mcnId)) {
            query.put("mcnId", request.mcnId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaIntroduction)) {
            query.put("mediaIntroduction", request.mediaIntroduction);
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
        return TeaModel.toModel(this.doROARequest("GetMediaCerficate", "content_1.0", "HTTP", "GET", "AK", "/v1.0/content/media/cerficates", "json", req, runtime), new GetMediaCerficateResponse());
    }

    public GetFeedResponse getFeed(String feedId, GetFeedRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetFeedHeaders headers = new GetFeedHeaders();
        return this.getFeedWithOptions(feedId, request, headers, runtime);
    }

    public GetFeedResponse getFeedWithOptions(String feedId, GetFeedRequest request, GetFeedHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        feedId = com.aliyun.openapiutil.Client.getEncodeParam(feedId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mcnId)) {
            query.put("mcnId", request.mcnId);
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
        return TeaModel.toModel(this.doROARequest("GetFeed", "content_1.0", "HTTP", "GET", "AK", "/v1.0/content/feeds/" + feedId + "", "json", req, runtime), new GetFeedResponse());
    }

    public PageFeedResponse pageFeed(PageFeedRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PageFeedHeaders headers = new PageFeedHeaders();
        return this.pageFeedWithOptions(request, headers, runtime);
    }

    public PageFeedResponse pageFeedWithOptions(PageFeedRequest request, PageFeedHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mcnId)) {
            query.put("mcnId", request.mcnId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", request.body)
        ));
        return TeaModel.toModel(this.doROARequest("PageFeed", "content_1.0", "HTTP", "POST", "AK", "/v1.0/content/feeds/query", "json", req, runtime), new PageFeedResponse());
    }

    public CreateFeedResponse createFeed(CreateFeedRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateFeedHeaders headers = new CreateFeedHeaders();
        return this.createFeedWithOptions(request, headers, runtime);
    }

    public CreateFeedResponse createFeedWithOptions(CreateFeedRequest request, CreateFeedHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.courseInfo))) {
            body.put("courseInfo", request.courseInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.feedInfo))) {
            body.put("feedInfo", request.feedInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createUserId)) {
            body.put("createUserId", request.createUserId);
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
        return TeaModel.toModel(this.doROARequest("CreateFeed", "content_1.0", "HTTP", "POST", "AK", "/v1.0/content/feeds", "json", req, runtime), new CreateFeedResponse());
    }

    public ListItemUserDataResponse listItemUserData(String itemId, ListItemUserDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListItemUserDataHeaders headers = new ListItemUserDataHeaders();
        return this.listItemUserDataWithOptions(itemId, request, headers, runtime);
    }

    public ListItemUserDataResponse listItemUserDataWithOptions(String itemId, ListItemUserDataRequest request, ListItemUserDataHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        itemId = com.aliyun.openapiutil.Client.getEncodeParam(itemId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", request.body)
        ));
        return TeaModel.toModel(this.doROARequest("ListItemUserData", "content_1.0", "HTTP", "POST", "AK", "/v1.0/content/feeds/items/" + itemId + "/userStatistics/query", "json", req, runtime), new ListItemUserDataResponse());
    }
}
