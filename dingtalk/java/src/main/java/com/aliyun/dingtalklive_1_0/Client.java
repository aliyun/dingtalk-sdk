// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalklive_1_0.models.*;

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
     * <p>增加直播间互动插件</p>
     * 
     * @param request AddLiveInteractionPluginRequest
     * @param headers AddLiveInteractionPluginHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddLiveInteractionPluginResponse
     */
    public AddLiveInteractionPluginResponse addLiveInteractionPluginWithOptions(AddLiveInteractionPluginRequest request, AddLiveInteractionPluginHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.anchorJumpUrl)) {
            body.put("anchorJumpUrl", request.anchorJumpUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginIconUrl)) {
            body.put("pluginIconUrl", request.pluginIconUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginName)) {
            body.put("pluginName", request.pluginName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginNameEn)) {
            body.put("pluginNameEn", request.pluginNameEn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.viewerJumpUrl)) {
            body.put("viewerJumpUrl", request.viewerJumpUrl);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddLiveInteractionPlugin"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/interactionPlugins"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddLiveInteractionPluginResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>增加直播间互动插件</p>
     * 
     * @param request AddLiveInteractionPluginRequest
     * @return AddLiveInteractionPluginResponse
     */
    public AddLiveInteractionPluginResponse addLiveInteractionPlugin(AddLiveInteractionPluginRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddLiveInteractionPluginHeaders headers = new AddLiveInteractionPluginHeaders();
        return this.addLiveInteractionPluginWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>增加直播间的公告槽位信息</p>
     * 
     * @param request AddLiveNoticeWidgetRequest
     * @param headers AddLiveNoticeWidgetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddLiveNoticeWidgetResponse
     */
    public AddLiveNoticeWidgetResponse addLiveNoticeWidgetWithOptions(AddLiveNoticeWidgetRequest request, AddLiveNoticeWidgetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.iconUrl)) {
            query.put("iconUrl", request.iconUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jumpUrl)) {
            query.put("jumpUrl", request.jumpUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.noticeText)) {
            query.put("noticeText", request.noticeText);
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
            new TeaPair("action", "AddLiveNoticeWidget"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/noticeWidgets"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddLiveNoticeWidgetResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>增加直播间的公告槽位信息</p>
     * 
     * @param request AddLiveNoticeWidgetRequest
     * @return AddLiveNoticeWidgetResponse
     */
    public AddLiveNoticeWidgetResponse addLiveNoticeWidget(AddLiveNoticeWidgetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddLiveNoticeWidgetHeaders headers = new AddLiveNoticeWidgetHeaders();
        return this.addLiveNoticeWidgetWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加云导播联播群列表</p>
     * 
     * @param request AddShareCidListRequest
     * @param headers AddShareCidListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddShareCidListResponse
     */
    public AddShareCidListResponse addShareCidListWithOptions(String feedId, AddShareCidListRequest request, AddShareCidListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddShareCidList"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/cloudFeeds/" + feedId + "/share"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddShareCidListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加云导播联播群列表</p>
     * 
     * @param request AddShareCidListRequest
     * @return AddShareCidListResponse
     */
    public AddShareCidListResponse addShareCidList(String feedId, AddShareCidListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddShareCidListHeaders headers = new AddShareCidListHeaders();
        return this.addShareCidListWithOptions(feedId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建云导播课程</p>
     * 
     * @param request CreateCloudFeedRequest
     * @param headers CreateCloudFeedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCloudFeedResponse
     */
    public CreateCloudFeedResponse createCloudFeedWithOptions(CreateCloudFeedRequest request, CreateCloudFeedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateCloudFeed"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/cloudFeeds"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCloudFeedResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建云导播课程</p>
     * 
     * @param request CreateCloudFeedRequest
     * @return CreateCloudFeedResponse
     */
    public CreateCloudFeedResponse createCloudFeed(CreateCloudFeedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCloudFeedHeaders headers = new CreateCloudFeedHeaders();
        return this.createCloudFeedWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建直播</p>
     * 
     * @param request CreateLiveRequest
     * @param headers CreateLiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateLiveResponse
     */
    public CreateLiveResponse createLiveWithOptions(CreateLiveRequest request, CreateLiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.publicType)) {
            body.put("publicType", request.publicType);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateLive"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/lives"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateLiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建直播</p>
     * 
     * @param request CreateLiveRequest
     * @return CreateLiveResponse
     */
    public CreateLiveResponse createLive(CreateLiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateLiveHeaders headers = new CreateLiveHeaders();
        return this.createLiveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除直播间内某一互动插件</p>
     * 
     * @param request DelLiveInteractionPluginRequest
     * @param headers DelLiveInteractionPluginHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DelLiveInteractionPluginResponse
     */
    public DelLiveInteractionPluginResponse delLiveInteractionPluginWithOptions(DelLiveInteractionPluginRequest request, DelLiveInteractionPluginHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginId)) {
            query.put("pluginId", request.pluginId);
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
            new TeaPair("action", "DelLiveInteractionPlugin"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/interactionPlugins"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DelLiveInteractionPluginResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除直播间内某一互动插件</p>
     * 
     * @param request DelLiveInteractionPluginRequest
     * @return DelLiveInteractionPluginResponse
     */
    public DelLiveInteractionPluginResponse delLiveInteractionPlugin(DelLiveInteractionPluginRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DelLiveInteractionPluginHeaders headers = new DelLiveInteractionPluginHeaders();
        return this.delLiveInteractionPluginWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除直播间的公告槽位信息</p>
     * 
     * @param request DelLiveNoticeWidgetRequest
     * @param headers DelLiveNoticeWidgetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DelLiveNoticeWidgetResponse
     */
    public DelLiveNoticeWidgetResponse delLiveNoticeWidgetWithOptions(DelLiveNoticeWidgetRequest request, DelLiveNoticeWidgetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DelLiveNoticeWidget"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/noticeWidgets"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DelLiveNoticeWidgetResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除直播间的公告槽位信息</p>
     * 
     * @param request DelLiveNoticeWidgetRequest
     * @return DelLiveNoticeWidgetResponse
     */
    public DelLiveNoticeWidgetResponse delLiveNoticeWidget(DelLiveNoticeWidgetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DelLiveNoticeWidgetHeaders headers = new DelLiveNoticeWidgetHeaders();
        return this.delLiveNoticeWidgetWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除直播</p>
     * 
     * @param request DeleteLiveRequest
     * @param headers DeleteLiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteLiveResponse
     */
    public DeleteLiveResponse deleteLiveWithOptions(DeleteLiveRequest request, DeleteLiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteLive"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/lives"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteLiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除直播</p>
     * 
     * @param request DeleteLiveRequest
     * @return DeleteLiveResponse
     */
    public DeleteLiveResponse deleteLive(DeleteLiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteLiveHeaders headers = new DeleteLiveHeaders();
        return this.deleteLiveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除直播培训课程</p>
     * 
     * @param request DeleteLiveFeedRequest
     * @param headers DeleteLiveFeedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteLiveFeedResponse
     */
    public DeleteLiveFeedResponse deleteLiveFeedWithOptions(String feedId, DeleteLiveFeedRequest request, DeleteLiveFeedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteLiveFeed"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/openFeeds/" + feedId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteLiveFeedResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除直播培训课程</p>
     * 
     * @param request DeleteLiveFeedRequest
     * @return DeleteLiveFeedResponse
     */
    public DeleteLiveFeedResponse deleteLiveFeed(String feedId, DeleteLiveFeedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteLiveFeedHeaders headers = new DeleteLiveFeedHeaders();
        return this.deleteLiveFeedWithOptions(feedId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>剪辑直播课程的回放</p>
     * 
     * @param request EditFeedReplayRequest
     * @param headers EditFeedReplayHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditFeedReplayResponse
     */
    public EditFeedReplayResponse editFeedReplayWithOptions(String feedId, EditFeedReplayRequest request, EditFeedReplayHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditFeedReplay"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/openFeeds/" + feedId + "/cutReplay"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditFeedReplayResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>剪辑直播课程的回放</p>
     * 
     * @param request EditFeedReplayRequest
     * @return EditFeedReplayResponse
     */
    public EditFeedReplayResponse editFeedReplay(String feedId, EditFeedReplayRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditFeedReplayHeaders headers = new EditFeedReplayHeaders();
        return this.editFeedReplayWithOptions(feedId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取群内的直播列表</p>
     * 
     * @param tmpReq GetGroupLiveListRequest
     * @param headers GetGroupLiveListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetGroupLiveListResponse
     */
    public GetGroupLiveListResponse getGroupLiveListWithOptions(GetGroupLiveListRequest tmpReq, GetGroupLiveListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        GetGroupLiveListShrinkRequest request = new GetGroupLiveListShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.requestBody)) {
            request.requestBodyShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.requestBody, "requestBody", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.requestBodyShrink)) {
            query.put("requestBody", request.requestBodyShrink);
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
            new TeaPair("action", "GetGroupLiveList"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/groupLives"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetGroupLiveListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取群内的直播列表</p>
     * 
     * @param request GetGroupLiveListRequest
     * @return GetGroupLiveListResponse
     */
    public GetGroupLiveListResponse getGroupLiveList(GetGroupLiveListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetGroupLiveListHeaders headers = new GetGroupLiveListHeaders();
        return this.getGroupLiveListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取直播的可下载回放地址</p>
     * 
     * @param request GetLiveReplayUrlRequest
     * @param headers GetLiveReplayUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetLiveReplayUrlResponse
     */
    public GetLiveReplayUrlResponse getLiveReplayUrlWithOptions(GetLiveReplayUrlRequest request, GetLiveReplayUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetLiveReplayUrl"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/lives/replayUrls"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetLiveReplayUrlResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取直播的可下载回放地址</p>
     * 
     * @param request GetLiveReplayUrlRequest
     * @return GetLiveReplayUrlResponse
     */
    public GetLiveReplayUrlResponse getLiveReplayUrl(GetLiveReplayUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetLiveReplayUrlHeaders headers = new GetLiveReplayUrlHeaders();
        return this.getLiveReplayUrlWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取某组织内的直播列表</p>
     * 
     * @param tmpReq GetOrgLiveListRequest
     * @param headers GetOrgLiveListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOrgLiveListResponse
     */
    public GetOrgLiveListResponse getOrgLiveListWithOptions(GetOrgLiveListRequest tmpReq, GetOrgLiveListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        GetOrgLiveListShrinkRequest request = new GetOrgLiveListShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.requestBody)) {
            request.requestBodyShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.requestBody, "requestBody", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestBodyShrink)) {
            query.put("requestBody", request.requestBodyShrink);
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
            new TeaPair("action", "GetOrgLiveList"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/organizations/liveLists/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOrgLiveListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取某组织内的直播列表</p>
     * 
     * @param request GetOrgLiveListRequest
     * @return GetOrgLiveListResponse
     */
    public GetOrgLiveListResponse getOrgLiveList(GetOrgLiveListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOrgLiveListHeaders headers = new GetOrgLiveListHeaders();
        return this.getOrgLiveListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据状态拉我相关的直播</p>
     * 
     * @param request GetUserAllLiveListRequest
     * @param headers GetUserAllLiveListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserAllLiveListResponse
     */
    public GetUserAllLiveListResponse getUserAllLiveListWithOptions(GetUserAllLiveListRequest request, GetUserAllLiveListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.statuses)) {
            body.put("statuses", request.statuses);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUserAllLiveList"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/users/allLiveInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserAllLiveListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据状态拉我相关的直播</p>
     * 
     * @param request GetUserAllLiveListRequest
     * @return GetUserAllLiveListResponse
     */
    public GetUserAllLiveListResponse getUserAllLiveList(GetUserAllLiveListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserAllLiveListHeaders headers = new GetUserAllLiveListHeaders();
        return this.getUserAllLiveListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据状态获取用户创建的直播</p>
     * 
     * @param request GetUserCreateLiveListRequest
     * @param headers GetUserCreateLiveListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserCreateLiveListResponse
     */
    public GetUserCreateLiveListResponse getUserCreateLiveListWithOptions(GetUserCreateLiveListRequest request, GetUserCreateLiveListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.statuses)) {
            body.put("statuses", request.statuses);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUserCreateLiveList"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/users/createLiveInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserCreateLiveListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据状态获取用户创建的直播</p>
     * 
     * @param request GetUserCreateLiveListRequest
     * @return GetUserCreateLiveListResponse
     */
    public GetUserCreateLiveListResponse getUserCreateLiveList(GetUserCreateLiveListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserCreateLiveListHeaders headers = new GetUserCreateLiveListHeaders();
        return this.getUserCreateLiveListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户观看直播记录</p>
     * 
     * @param request GetUserWatchLiveListRequest
     * @param headers GetUserWatchLiveListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserWatchLiveListResponse
     */
    public GetUserWatchLiveListResponse getUserWatchLiveListWithOptions(GetUserWatchLiveListRequest request, GetUserWatchLiveListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.filterType)) {
            query.put("filterType", request.filterType);
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
            new TeaPair("action", "GetUserWatchLiveList"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/users/watchRecords"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserWatchLiveListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户观看直播记录</p>
     * 
     * @param request GetUserWatchLiveListRequest
     * @return GetUserWatchLiveListResponse
     */
    public GetUserWatchLiveListResponse getUserWatchLiveList(GetUserWatchLiveListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserWatchLiveListHeaders headers = new GetUserWatchLiveListHeaders();
        return this.getUserWatchLiveListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改直播课程可见白名单</p>
     * 
     * @param tmpReq ModifyFeedWhiteListRequest
     * @param headers ModifyFeedWhiteListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ModifyFeedWhiteListResponse
     */
    public ModifyFeedWhiteListResponse modifyFeedWhiteListWithOptions(String feedId, ModifyFeedWhiteListRequest tmpReq, ModifyFeedWhiteListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ModifyFeedWhiteList"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/openFeeds/" + feedId + "/whiteList"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ModifyFeedWhiteListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改直播课程可见白名单</p>
     * 
     * @param request ModifyFeedWhiteListRequest
     * @return ModifyFeedWhiteListResponse
     */
    public ModifyFeedWhiteListResponse modifyFeedWhiteList(String feedId, ModifyFeedWhiteListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ModifyFeedWhiteListHeaders headers = new ModifyFeedWhiteListHeaders();
        return this.modifyFeedWhiteListWithOptions(feedId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询直播课程的观看白名单</p>
     * 
     * @param request QueryFeedWhiteListRequest
     * @param headers QueryFeedWhiteListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryFeedWhiteListResponse
     */
    public QueryFeedWhiteListResponse queryFeedWhiteListWithOptions(String feedId, QueryFeedWhiteListRequest request, QueryFeedWhiteListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryFeedWhiteList"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/openFeeds/" + feedId + "/whiteList"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryFeedWhiteListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询直播课程的观看白名单</p>
     * 
     * @param request QueryFeedWhiteListRequest
     * @return QueryFeedWhiteListResponse
     */
    public QueryFeedWhiteListResponse queryFeedWhiteList(String feedId, QueryFeedWhiteListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryFeedWhiteListHeaders headers = new QueryFeedWhiteListHeaders();
        return this.queryFeedWhiteListWithOptions(feedId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询直播详情</p>
     * 
     * @param request QueryLiveInfoRequest
     * @param headers QueryLiveInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryLiveInfoResponse
     */
    public QueryLiveInfoResponse queryLiveInfoWithOptions(QueryLiveInfoRequest request, QueryLiveInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryLiveInfo"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/lives"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryLiveInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询直播详情</p>
     * 
     * @param request QueryLiveInfoRequest
     * @return QueryLiveInfoResponse
     */
    public QueryLiveInfoResponse queryLiveInfo(QueryLiveInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryLiveInfoHeaders headers = new QueryLiveInfoHeaders();
        return this.queryLiveInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询直播间内某一互动插件的信息</p>
     * 
     * @param request QueryLiveInteractionPluginRequest
     * @param headers QueryLiveInteractionPluginHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryLiveInteractionPluginResponse
     */
    public QueryLiveInteractionPluginResponse queryLiveInteractionPluginWithOptions(QueryLiveInteractionPluginRequest request, QueryLiveInteractionPluginHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginId)) {
            query.put("pluginId", request.pluginId);
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
            new TeaPair("action", "QueryLiveInteractionPlugin"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/interactionPlugins"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryLiveInteractionPluginResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询直播间内某一互动插件的信息</p>
     * 
     * @param request QueryLiveInteractionPluginRequest
     * @return QueryLiveInteractionPluginResponse
     */
    public QueryLiveInteractionPluginResponse queryLiveInteractionPlugin(QueryLiveInteractionPluginRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryLiveInteractionPluginHeaders headers = new QueryLiveInteractionPluginHeaders();
        return this.queryLiveInteractionPluginWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取直播的观看数据</p>
     * 
     * @param request QueryLiveWatchDetailRequest
     * @param headers QueryLiveWatchDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryLiveWatchDetailResponse
     */
    public QueryLiveWatchDetailResponse queryLiveWatchDetailWithOptions(QueryLiveWatchDetailRequest request, QueryLiveWatchDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryLiveWatchDetail"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/lives/watchDetails"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryLiveWatchDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取直播的观看数据</p>
     * 
     * @param request QueryLiveWatchDetailRequest
     * @return QueryLiveWatchDetailResponse
     */
    public QueryLiveWatchDetailResponse queryLiveWatchDetail(QueryLiveWatchDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryLiveWatchDetailHeaders headers = new QueryLiveWatchDetailHeaders();
        return this.queryLiveWatchDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取直播观看用户列表</p>
     * 
     * @param request QueryLiveWatchUserListRequest
     * @param headers QueryLiveWatchUserListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryLiveWatchUserListResponse
     */
    public QueryLiveWatchUserListResponse queryLiveWatchUserListWithOptions(QueryLiveWatchUserListRequest request, QueryLiveWatchUserListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryLiveWatchUserList"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/lives/watchUsers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryLiveWatchUserListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取直播观看用户列表</p>
     * 
     * @param request QueryLiveWatchUserListRequest
     * @return QueryLiveWatchUserListResponse
     */
    public QueryLiveWatchUserListResponse queryLiveWatchUserList(QueryLiveWatchUserListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryLiveWatchUserListHeaders headers = new QueryLiveWatchUserListHeaders();
        return this.queryLiveWatchUserListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询直播是否订阅</p>
     * 
     * @param tmpReq QuerySubscribeStatusRequest
     * @param headers QuerySubscribeStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySubscribeStatusResponse
     */
    public QuerySubscribeStatusResponse querySubscribeStatusWithOptions(QuerySubscribeStatusRequest tmpReq, QuerySubscribeStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        QuerySubscribeStatusShrinkRequest request = new QuerySubscribeStatusShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.body)) {
            request.bodyShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bodyShrink)) {
            query.put("body", request.bodyShrink);
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
            new TeaPair("action", "QuerySubscribeStatus"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/subscribeStatuses/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySubscribeStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询直播是否订阅</p>
     * 
     * @param request QuerySubscribeStatusRequest
     * @return QuerySubscribeStatusResponse
     */
    public QuerySubscribeStatusResponse querySubscribeStatus(QuerySubscribeStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySubscribeStatusHeaders headers = new QuerySubscribeStatusHeaders();
        return this.querySubscribeStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用户推送互动插件特效消息到直播间</p>
     * 
     * @param request SendLiveInteractionPluginEffectsMsgRequest
     * @param headers SendLiveInteractionPluginEffectsMsgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendLiveInteractionPluginEffectsMsgResponse
     */
    public SendLiveInteractionPluginEffectsMsgResponse sendLiveInteractionPluginEffectsMsgWithOptions(SendLiveInteractionPluginEffectsMsgRequest request, SendLiveInteractionPluginEffectsMsgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginId)) {
            query.put("pluginId", request.pluginId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.count)) {
            body.put("count", request.count);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.lottieFileUrl)) {
            body.put("lottieFileUrl", request.lottieFileUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgIconUrl)) {
            body.put("msgIconUrl", request.msgIconUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgText)) {
            body.put("msgText", request.msgText);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginSubId)) {
            body.put("pluginSubId", request.pluginSubId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.senderUnionId)) {
            body.put("senderUnionId", request.senderUnionId);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SendLiveInteractionPluginEffectsMsg"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/interactionPlugins/effectMessages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendLiveInteractionPluginEffectsMsgResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>用户推送互动插件特效消息到直播间</p>
     * 
     * @param request SendLiveInteractionPluginEffectsMsgRequest
     * @return SendLiveInteractionPluginEffectsMsgResponse
     */
    public SendLiveInteractionPluginEffectsMsgResponse sendLiveInteractionPluginEffectsMsg(SendLiveInteractionPluginEffectsMsgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendLiveInteractionPluginEffectsMsgHeaders headers = new SendLiveInteractionPluginEffectsMsgHeaders();
        return this.sendLiveInteractionPluginEffectsMsgWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用户对互动插件进行操作广播到直播间</p>
     * 
     * @param tmpReq SendLivePluginUserActionMsgRequest
     * @param headers SendLivePluginUserActionMsgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendLivePluginUserActionMsgResponse
     */
    public SendLivePluginUserActionMsgResponse sendLivePluginUserActionMsgWithOptions(SendLivePluginUserActionMsgRequest tmpReq, SendLivePluginUserActionMsgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        SendLivePluginUserActionMsgShrinkRequest request = new SendLivePluginUserActionMsgShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.pluginEffectsMessage)) {
            request.pluginEffectsMessageShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.pluginEffectsMessage, "pluginEffectsMessage", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginEffectsMessageShrink)) {
            query.put("pluginEffectsMessage", request.pluginEffectsMessageShrink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginId)) {
            query.put("pluginId", request.pluginId);
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
            new TeaPair("action", "SendLivePluginUserActionMsg"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/interactionPlugins/actionMessages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendLivePluginUserActionMsgResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>用户对互动插件进行操作广播到直播间</p>
     * 
     * @param request SendLivePluginUserActionMsgRequest
     * @return SendLivePluginUserActionMsgResponse
     */
    public SendLivePluginUserActionMsgResponse sendLivePluginUserActionMsg(SendLivePluginUserActionMsgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendLivePluginUserActionMsgHeaders headers = new SendLivePluginUserActionMsgHeaders();
        return this.sendLivePluginUserActionMsgWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>开始一场云导播</p>
     * 
     * @param request StartCloudFeedRequest
     * @param headers StartCloudFeedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StartCloudFeedResponse
     */
    public StartCloudFeedResponse startCloudFeedWithOptions(String feedId, StartCloudFeedRequest request, StartCloudFeedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "StartCloudFeed"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/cloudFeeds/" + feedId + "/start"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StartCloudFeedResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>开始一场云导播</p>
     * 
     * @param request StartCloudFeedRequest
     * @return StartCloudFeedResponse
     */
    public StartCloudFeedResponse startCloudFeed(String feedId, StartCloudFeedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StartCloudFeedHeaders headers = new StartCloudFeedHeaders();
        return this.startCloudFeedWithOptions(feedId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>结束一场云导播</p>
     * 
     * @param request StopCloudFeedRequest
     * @param headers StopCloudFeedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StopCloudFeedResponse
     */
    public StopCloudFeedResponse stopCloudFeedWithOptions(String feedId, StopCloudFeedRequest request, StopCloudFeedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "StopCloudFeed"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/cloudFeeds/" + feedId + "/stop"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StopCloudFeedResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>结束一场云导播</p>
     * 
     * @param request StopCloudFeedRequest
     * @return StopCloudFeedResponse
     */
    public StopCloudFeedResponse stopCloudFeed(String feedId, StopCloudFeedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StopCloudFeedHeaders headers = new StopCloudFeedHeaders();
        return this.stopCloudFeedWithOptions(feedId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>预约直播</p>
     * 
     * @param request SubscribeLiveRequest
     * @param headers SubscribeLiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SubscribeLiveResponse
     */
    public SubscribeLiveResponse subscribeLiveWithOptions(SubscribeLiveRequest request, SubscribeLiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subscribe)) {
            query.put("subscribe", request.subscribe);
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
            new TeaPair("action", "SubscribeLive"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/lives/subscribe"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SubscribeLiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>预约直播</p>
     * 
     * @param request SubscribeLiveRequest
     * @return SubscribeLiveResponse
     */
    public SubscribeLiveResponse subscribeLive(SubscribeLiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SubscribeLiveHeaders headers = new SubscribeLiveHeaders();
        return this.subscribeLiveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改直播</p>
     * 
     * @param request UpdateLiveRequest
     * @param headers UpdateLiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateLiveResponse
     */
    public UpdateLiveResponse updateLiveWithOptions(UpdateLiveRequest request, UpdateLiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateLive"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/lives"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateLiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改直播</p>
     * 
     * @param request UpdateLiveRequest
     * @return UpdateLiveResponse
     */
    public UpdateLiveResponse updateLive(UpdateLiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateLiveHeaders headers = new UpdateLiveHeaders();
        return this.updateLiveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改培训课程信息</p>
     * 
     * @param request UpdateLiveFeedRequest
     * @param headers UpdateLiveFeedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateLiveFeedResponse
     */
    public UpdateLiveFeedResponse updateLiveFeedWithOptions(String feedId, UpdateLiveFeedRequest request, UpdateLiveFeedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateLiveFeed"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/openFeeds/" + feedId + ""),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateLiveFeedResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改培训课程信息</p>
     * 
     * @param request UpdateLiveFeedRequest
     * @return UpdateLiveFeedResponse
     */
    public UpdateLiveFeedResponse updateLiveFeed(String feedId, UpdateLiveFeedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateLiveFeedHeaders headers = new UpdateLiveFeedHeaders();
        return this.updateLiveFeedWithOptions(feedId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改直播间内某一互动插件的信息</p>
     * 
     * @param request UpdateLiveInteractionPluginRequest
     * @param headers UpdateLiveInteractionPluginHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateLiveInteractionPluginResponse
     */
    public UpdateLiveInteractionPluginResponse updateLiveInteractionPluginWithOptions(UpdateLiveInteractionPluginRequest request, UpdateLiveInteractionPluginHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.liveId)) {
            query.put("liveId", request.liveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginId)) {
            query.put("pluginId", request.pluginId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.anchorJumpUrl)) {
            body.put("anchorJumpUrl", request.anchorJumpUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginIconUrl)) {
            body.put("pluginIconUrl", request.pluginIconUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginName)) {
            body.put("pluginName", request.pluginName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pluginNameEn)) {
            body.put("pluginNameEn", request.pluginNameEn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.viewerJumpUrl)) {
            body.put("viewerJumpUrl", request.viewerJumpUrl);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateLiveInteractionPlugin"),
            new TeaPair("version", "live_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/live/interactionPlugins"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateLiveInteractionPluginResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改直播间内某一互动插件的信息</p>
     * 
     * @param request UpdateLiveInteractionPluginRequest
     * @return UpdateLiveInteractionPluginResponse
     */
    public UpdateLiveInteractionPluginResponse updateLiveInteractionPlugin(UpdateLiveInteractionPluginRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateLiveInteractionPluginHeaders headers = new UpdateLiveInteractionPluginHeaders();
        return this.updateLiveInteractionPluginWithOptions(request, headers, runtime);
    }
}
