// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcontent_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public com.aliyun.gateway.spi.Client _client;
    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._client = new com.aliyun.gateway.dingtalk.Client();
        this._spi = _client;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * @summary 创建内容
     *
     * @param request CreateFeedRequest
     * @param headers CreateFeedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateFeedResponse
     */
    public CreateFeedResponse createFeedWithOptions(CreateFeedRequest request, CreateFeedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseInfo)) {
            body.put("courseInfo", request.courseInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createUserId)) {
            body.put("createUserId", request.createUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.feedInfo)) {
            body.put("feedInfo", request.feedInfo);
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
            new TeaPair("action", "CreateFeed"),
            new TeaPair("version", "content_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/content/feeds"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateFeedResponse());
    }

    /**
     * @summary 创建内容
     *
     * @param request CreateFeedRequest
     * @return CreateFeedResponse
     */
    public CreateFeedResponse createFeed(CreateFeedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateFeedHeaders headers = new CreateFeedHeaders();
        return this.createFeedWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取feed的详细信息，包括子课程的信息
     *
     * @param request GetFeedRequest
     * @param headers GetFeedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFeedResponse
     */
    public GetFeedResponse getFeedWithOptions(String feedId, GetFeedRequest request, GetFeedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mcnId)) {
            query.put("mcnId", request.mcnId);
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
            new TeaPair("action", "GetFeed"),
            new TeaPair("version", "content_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/content/feeds/" + feedId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFeedResponse());
    }

    /**
     * @summary 获取feed的详细信息，包括子课程的信息
     *
     * @param request GetFeedRequest
     * @return GetFeedResponse
     */
    public GetFeedResponse getFeed(String feedId, GetFeedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFeedHeaders headers = new GetFeedHeaders();
        return this.getFeedWithOptions(feedId, request, headers, runtime);
    }

    /**
     * @summary 获取oss上传凭证
     *
     * @param request GetMediaCerficateRequest
     * @param headers GetMediaCerficateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMediaCerficateResponse
     */
    public GetMediaCerficateResponse getMediaCerficateWithOptions(GetMediaCerficateRequest request, GetMediaCerficateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            query.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mcnId)) {
            query.put("mcnId", request.mcnId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            query.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaIntroduction)) {
            query.put("mediaIntroduction", request.mediaIntroduction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaTitle)) {
            query.put("mediaTitle", request.mediaTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thumbUrl)) {
            query.put("thumbUrl", request.thumbUrl);
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
            new TeaPair("action", "GetMediaCerficate"),
            new TeaPair("version", "content_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/content/media/cerficates"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMediaCerficateResponse());
    }

    /**
     * @summary 获取oss上传凭证
     *
     * @param request GetMediaCerficateRequest
     * @return GetMediaCerficateResponse
     */
    public GetMediaCerficateResponse getMediaCerficate(GetMediaCerficateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMediaCerficateHeaders headers = new GetMediaCerficateHeaders();
        return this.getMediaCerficateWithOptions(request, headers, runtime);
    }

    /**
     * @summary 展示机构内观看内容的统计信息
     *
     * @param request ListItemUserDataRequest
     * @param headers ListItemUserDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListItemUserDataResponse
     */
    public ListItemUserDataResponse listItemUserDataWithOptions(String itemId, ListItemUserDataRequest request, ListItemUserDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", request.body)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListItemUserData"),
            new TeaPair("version", "content_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/content/feeds/items/" + itemId + "/userStatistics/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListItemUserDataResponse());
    }

    /**
     * @summary 展示机构内观看内容的统计信息
     *
     * @param request ListItemUserDataRequest
     * @return ListItemUserDataResponse
     */
    public ListItemUserDataResponse listItemUserData(String itemId, ListItemUserDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListItemUserDataHeaders headers = new ListItemUserDataHeaders();
        return this.listItemUserDataWithOptions(itemId, request, headers, runtime);
    }

    /**
     * @summary 获取机构下课程列表
     *
     * @param request PageFeedRequest
     * @param headers PageFeedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PageFeedResponse
     */
    public PageFeedResponse pageFeedWithOptions(PageFeedRequest request, PageFeedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mcnId)) {
            query.put("mcnId", request.mcnId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", request.body)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PageFeed"),
            new TeaPair("version", "content_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/content/feeds/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PageFeedResponse());
    }

    /**
     * @summary 获取机构下课程列表
     *
     * @param request PageFeedRequest
     * @return PageFeedResponse
     */
    public PageFeedResponse pageFeed(PageFeedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PageFeedHeaders headers = new PageFeedHeaders();
        return this.pageFeedWithOptions(request, headers, runtime);
    }
}
