// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalklive_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalklive_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加直播间互动插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLiveInteractionPluginRequest
        /// </param>
        /// <param name="headers">
        /// AddLiveInteractionPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddLiveInteractionPluginResponse
        /// </returns>
        public AddLiveInteractionPluginResponse AddLiveInteractionPluginWithOptions(AddLiveInteractionPluginRequest request, AddLiveInteractionPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorJumpUrl))
            {
                body["anchorJumpUrl"] = request.AnchorJumpUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginIconUrl))
            {
                body["pluginIconUrl"] = request.PluginIconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginName))
            {
                body["pluginName"] = request.PluginName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginNameEn))
            {
                body["pluginNameEn"] = request.PluginNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewerJumpUrl))
            {
                body["viewerJumpUrl"] = request.ViewerJumpUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLiveInteractionPlugin",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLiveInteractionPluginResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加直播间互动插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLiveInteractionPluginRequest
        /// </param>
        /// <param name="headers">
        /// AddLiveInteractionPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddLiveInteractionPluginResponse
        /// </returns>
        public async Task<AddLiveInteractionPluginResponse> AddLiveInteractionPluginWithOptionsAsync(AddLiveInteractionPluginRequest request, AddLiveInteractionPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorJumpUrl))
            {
                body["anchorJumpUrl"] = request.AnchorJumpUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginIconUrl))
            {
                body["pluginIconUrl"] = request.PluginIconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginName))
            {
                body["pluginName"] = request.PluginName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginNameEn))
            {
                body["pluginNameEn"] = request.PluginNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewerJumpUrl))
            {
                body["viewerJumpUrl"] = request.ViewerJumpUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLiveInteractionPlugin",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLiveInteractionPluginResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加直播间互动插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLiveInteractionPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// AddLiveInteractionPluginResponse
        /// </returns>
        public AddLiveInteractionPluginResponse AddLiveInteractionPlugin(AddLiveInteractionPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLiveInteractionPluginHeaders headers = new AddLiveInteractionPluginHeaders();
            return AddLiveInteractionPluginWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加直播间互动插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLiveInteractionPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// AddLiveInteractionPluginResponse
        /// </returns>
        public async Task<AddLiveInteractionPluginResponse> AddLiveInteractionPluginAsync(AddLiveInteractionPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLiveInteractionPluginHeaders headers = new AddLiveInteractionPluginHeaders();
            return await AddLiveInteractionPluginWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加直播间的公告槽位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLiveNoticeWidgetRequest
        /// </param>
        /// <param name="headers">
        /// AddLiveNoticeWidgetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddLiveNoticeWidgetResponse
        /// </returns>
        public AddLiveNoticeWidgetResponse AddLiveNoticeWidgetWithOptions(AddLiveNoticeWidgetRequest request, AddLiveNoticeWidgetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                query["iconUrl"] = request.IconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JumpUrl))
            {
                query["jumpUrl"] = request.JumpUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeText))
            {
                query["noticeText"] = request.NoticeText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLiveNoticeWidget",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/noticeWidgets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLiveNoticeWidgetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加直播间的公告槽位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLiveNoticeWidgetRequest
        /// </param>
        /// <param name="headers">
        /// AddLiveNoticeWidgetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddLiveNoticeWidgetResponse
        /// </returns>
        public async Task<AddLiveNoticeWidgetResponse> AddLiveNoticeWidgetWithOptionsAsync(AddLiveNoticeWidgetRequest request, AddLiveNoticeWidgetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                query["iconUrl"] = request.IconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JumpUrl))
            {
                query["jumpUrl"] = request.JumpUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeText))
            {
                query["noticeText"] = request.NoticeText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLiveNoticeWidget",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/noticeWidgets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLiveNoticeWidgetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加直播间的公告槽位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLiveNoticeWidgetRequest
        /// </param>
        /// 
        /// <returns>
        /// AddLiveNoticeWidgetResponse
        /// </returns>
        public AddLiveNoticeWidgetResponse AddLiveNoticeWidget(AddLiveNoticeWidgetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLiveNoticeWidgetHeaders headers = new AddLiveNoticeWidgetHeaders();
            return AddLiveNoticeWidgetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加直播间的公告槽位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLiveNoticeWidgetRequest
        /// </param>
        /// 
        /// <returns>
        /// AddLiveNoticeWidgetResponse
        /// </returns>
        public async Task<AddLiveNoticeWidgetResponse> AddLiveNoticeWidgetAsync(AddLiveNoticeWidgetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLiveNoticeWidgetHeaders headers = new AddLiveNoticeWidgetHeaders();
            return await AddLiveNoticeWidgetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加云导播联播群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddShareCidListRequest
        /// </param>
        /// <param name="headers">
        /// AddShareCidListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddShareCidListResponse
        /// </returns>
        public AddShareCidListResponse AddShareCidListWithOptions(string feedId, AddShareCidListRequest request, AddShareCidListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdType))
            {
                body["groupIdType"] = request.GroupIdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddShareCidList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/cloudFeeds/" + feedId + "/share",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddShareCidListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加云导播联播群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddShareCidListRequest
        /// </param>
        /// <param name="headers">
        /// AddShareCidListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddShareCidListResponse
        /// </returns>
        public async Task<AddShareCidListResponse> AddShareCidListWithOptionsAsync(string feedId, AddShareCidListRequest request, AddShareCidListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdType))
            {
                body["groupIdType"] = request.GroupIdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddShareCidList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/cloudFeeds/" + feedId + "/share",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddShareCidListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加云导播联播群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddShareCidListRequest
        /// </param>
        /// 
        /// <returns>
        /// AddShareCidListResponse
        /// </returns>
        public AddShareCidListResponse AddShareCidList(string feedId, AddShareCidListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddShareCidListHeaders headers = new AddShareCidListHeaders();
            return AddShareCidListWithOptions(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加云导播联播群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddShareCidListRequest
        /// </param>
        /// 
        /// <returns>
        /// AddShareCidListResponse
        /// </returns>
        public async Task<AddShareCidListResponse> AddShareCidListAsync(string feedId, AddShareCidListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddShareCidListHeaders headers = new AddShareCidListHeaders();
            return await AddShareCidListWithOptionsAsync(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云导播课程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCloudFeedRequest
        /// </param>
        /// <param name="headers">
        /// CreateCloudFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudFeedResponse
        /// </returns>
        public CreateCloudFeedResponse CreateCloudFeedWithOptions(CreateCloudFeedRequest request, CreateCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["videoUrl"] = request.VideoUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloudFeed",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/cloudFeeds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloudFeedResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云导播课程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCloudFeedRequest
        /// </param>
        /// <param name="headers">
        /// CreateCloudFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudFeedResponse
        /// </returns>
        public async Task<CreateCloudFeedResponse> CreateCloudFeedWithOptionsAsync(CreateCloudFeedRequest request, CreateCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["videoUrl"] = request.VideoUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloudFeed",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/cloudFeeds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloudFeedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云导播课程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCloudFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudFeedResponse
        /// </returns>
        public CreateCloudFeedResponse CreateCloudFeed(CreateCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCloudFeedHeaders headers = new CreateCloudFeedHeaders();
            return CreateCloudFeedWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云导播课程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCloudFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudFeedResponse
        /// </returns>
        public async Task<CreateCloudFeedResponse> CreateCloudFeedAsync(CreateCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCloudFeedHeaders headers = new CreateCloudFeedHeaders();
            return await CreateCloudFeedWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLiveRequest
        /// </param>
        /// <param name="headers">
        /// CreateLiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLiveResponse
        /// </returns>
        public CreateLiveResponse CreateLiveWithOptions(CreateLiveRequest request, CreateLiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                body["introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEndTime))
            {
                body["preEndTime"] = request.PreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStartTime))
            {
                body["preStartTime"] = request.PreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicType))
            {
                body["publicType"] = request.PublicType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLive",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLiveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLiveRequest
        /// </param>
        /// <param name="headers">
        /// CreateLiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLiveResponse
        /// </returns>
        public async Task<CreateLiveResponse> CreateLiveWithOptionsAsync(CreateLiveRequest request, CreateLiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                body["introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEndTime))
            {
                body["preEndTime"] = request.PreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStartTime))
            {
                body["preStartTime"] = request.PreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicType))
            {
                body["publicType"] = request.PublicType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLive",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLiveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLiveRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLiveResponse
        /// </returns>
        public CreateLiveResponse CreateLive(CreateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateLiveHeaders headers = new CreateLiveHeaders();
            return CreateLiveWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLiveRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLiveResponse
        /// </returns>
        public async Task<CreateLiveResponse> CreateLiveAsync(CreateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateLiveHeaders headers = new CreateLiveHeaders();
            return await CreateLiveWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播间内某一互动插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelLiveInteractionPluginRequest
        /// </param>
        /// <param name="headers">
        /// DelLiveInteractionPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelLiveInteractionPluginResponse
        /// </returns>
        public DelLiveInteractionPluginResponse DelLiveInteractionPluginWithOptions(DelLiveInteractionPluginRequest request, DelLiveInteractionPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelLiveInteractionPlugin",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelLiveInteractionPluginResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播间内某一互动插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelLiveInteractionPluginRequest
        /// </param>
        /// <param name="headers">
        /// DelLiveInteractionPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelLiveInteractionPluginResponse
        /// </returns>
        public async Task<DelLiveInteractionPluginResponse> DelLiveInteractionPluginWithOptionsAsync(DelLiveInteractionPluginRequest request, DelLiveInteractionPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelLiveInteractionPlugin",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelLiveInteractionPluginResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播间内某一互动插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelLiveInteractionPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// DelLiveInteractionPluginResponse
        /// </returns>
        public DelLiveInteractionPluginResponse DelLiveInteractionPlugin(DelLiveInteractionPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelLiveInteractionPluginHeaders headers = new DelLiveInteractionPluginHeaders();
            return DelLiveInteractionPluginWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播间内某一互动插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelLiveInteractionPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// DelLiveInteractionPluginResponse
        /// </returns>
        public async Task<DelLiveInteractionPluginResponse> DelLiveInteractionPluginAsync(DelLiveInteractionPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelLiveInteractionPluginHeaders headers = new DelLiveInteractionPluginHeaders();
            return await DelLiveInteractionPluginWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播间的公告槽位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelLiveNoticeWidgetRequest
        /// </param>
        /// <param name="headers">
        /// DelLiveNoticeWidgetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelLiveNoticeWidgetResponse
        /// </returns>
        public DelLiveNoticeWidgetResponse DelLiveNoticeWidgetWithOptions(DelLiveNoticeWidgetRequest request, DelLiveNoticeWidgetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelLiveNoticeWidget",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/noticeWidgets",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelLiveNoticeWidgetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播间的公告槽位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelLiveNoticeWidgetRequest
        /// </param>
        /// <param name="headers">
        /// DelLiveNoticeWidgetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelLiveNoticeWidgetResponse
        /// </returns>
        public async Task<DelLiveNoticeWidgetResponse> DelLiveNoticeWidgetWithOptionsAsync(DelLiveNoticeWidgetRequest request, DelLiveNoticeWidgetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelLiveNoticeWidget",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/noticeWidgets",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelLiveNoticeWidgetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播间的公告槽位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelLiveNoticeWidgetRequest
        /// </param>
        /// 
        /// <returns>
        /// DelLiveNoticeWidgetResponse
        /// </returns>
        public DelLiveNoticeWidgetResponse DelLiveNoticeWidget(DelLiveNoticeWidgetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelLiveNoticeWidgetHeaders headers = new DelLiveNoticeWidgetHeaders();
            return DelLiveNoticeWidgetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播间的公告槽位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelLiveNoticeWidgetRequest
        /// </param>
        /// 
        /// <returns>
        /// DelLiveNoticeWidgetResponse
        /// </returns>
        public async Task<DelLiveNoticeWidgetResponse> DelLiveNoticeWidgetAsync(DelLiveNoticeWidgetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelLiveNoticeWidgetHeaders headers = new DelLiveNoticeWidgetHeaders();
            return await DelLiveNoticeWidgetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLiveRequest
        /// </param>
        /// <param name="headers">
        /// DeleteLiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLiveResponse
        /// </returns>
        public DeleteLiveResponse DeleteLiveWithOptions(DeleteLiveRequest request, DeleteLiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLive",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLiveRequest
        /// </param>
        /// <param name="headers">
        /// DeleteLiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLiveResponse
        /// </returns>
        public async Task<DeleteLiveResponse> DeleteLiveWithOptionsAsync(DeleteLiveRequest request, DeleteLiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLive",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLiveRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLiveResponse
        /// </returns>
        public DeleteLiveResponse DeleteLive(DeleteLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLiveHeaders headers = new DeleteLiveHeaders();
            return DeleteLiveWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLiveRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLiveResponse
        /// </returns>
        public async Task<DeleteLiveResponse> DeleteLiveAsync(DeleteLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLiveHeaders headers = new DeleteLiveHeaders();
            return await DeleteLiveWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播培训课程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLiveFeedRequest
        /// </param>
        /// <param name="headers">
        /// DeleteLiveFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLiveFeedResponse
        /// </returns>
        public DeleteLiveFeedResponse DeleteLiveFeedWithOptions(string feedId, DeleteLiveFeedRequest request, DeleteLiveFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveFeed",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/openFeeds/" + feedId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveFeedResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播培训课程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLiveFeedRequest
        /// </param>
        /// <param name="headers">
        /// DeleteLiveFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLiveFeedResponse
        /// </returns>
        public async Task<DeleteLiveFeedResponse> DeleteLiveFeedWithOptionsAsync(string feedId, DeleteLiveFeedRequest request, DeleteLiveFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveFeed",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/openFeeds/" + feedId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveFeedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播培训课程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLiveFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLiveFeedResponse
        /// </returns>
        public DeleteLiveFeedResponse DeleteLiveFeed(string feedId, DeleteLiveFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLiveFeedHeaders headers = new DeleteLiveFeedHeaders();
            return DeleteLiveFeedWithOptions(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除直播培训课程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLiveFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLiveFeedResponse
        /// </returns>
        public async Task<DeleteLiveFeedResponse> DeleteLiveFeedAsync(string feedId, DeleteLiveFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLiveFeedHeaders headers = new DeleteLiveFeedHeaders();
            return await DeleteLiveFeedWithOptionsAsync(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剪辑直播课程的回放</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditFeedReplayRequest
        /// </param>
        /// <param name="headers">
        /// EditFeedReplayHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditFeedReplayResponse
        /// </returns>
        public EditFeedReplayResponse EditFeedReplayWithOptions(string feedId, EditFeedReplayRequest request, EditFeedReplayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditEndTime))
            {
                body["editEndTime"] = request.EditEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditStartTime))
            {
                body["editStartTime"] = request.EditStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditFeedReplay",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/openFeeds/" + feedId + "/cutReplay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditFeedReplayResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剪辑直播课程的回放</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditFeedReplayRequest
        /// </param>
        /// <param name="headers">
        /// EditFeedReplayHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditFeedReplayResponse
        /// </returns>
        public async Task<EditFeedReplayResponse> EditFeedReplayWithOptionsAsync(string feedId, EditFeedReplayRequest request, EditFeedReplayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditEndTime))
            {
                body["editEndTime"] = request.EditEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditStartTime))
            {
                body["editStartTime"] = request.EditStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditFeedReplay",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/openFeeds/" + feedId + "/cutReplay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditFeedReplayResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剪辑直播课程的回放</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditFeedReplayRequest
        /// </param>
        /// 
        /// <returns>
        /// EditFeedReplayResponse
        /// </returns>
        public EditFeedReplayResponse EditFeedReplay(string feedId, EditFeedReplayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditFeedReplayHeaders headers = new EditFeedReplayHeaders();
            return EditFeedReplayWithOptions(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剪辑直播课程的回放</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditFeedReplayRequest
        /// </param>
        /// 
        /// <returns>
        /// EditFeedReplayResponse
        /// </returns>
        public async Task<EditFeedReplayResponse> EditFeedReplayAsync(string feedId, EditFeedReplayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditFeedReplayHeaders headers = new EditFeedReplayHeaders();
            return await EditFeedReplayWithOptionsAsync(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群内的直播列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetGroupLiveListRequest
        /// </param>
        /// <param name="headers">
        /// GetGroupLiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupLiveListResponse
        /// </returns>
        public GetGroupLiveListResponse GetGroupLiveListWithOptions(GetGroupLiveListRequest tmpReq, GetGroupLiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetGroupLiveListShrinkRequest request = new GetGroupLiveListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestBody))
            {
                request.RequestBodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestBody, "requestBody", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestBodyShrink))
            {
                query["requestBody"] = request.RequestBodyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroupLiveList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/groupLives",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupLiveListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群内的直播列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetGroupLiveListRequest
        /// </param>
        /// <param name="headers">
        /// GetGroupLiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupLiveListResponse
        /// </returns>
        public async Task<GetGroupLiveListResponse> GetGroupLiveListWithOptionsAsync(GetGroupLiveListRequest tmpReq, GetGroupLiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetGroupLiveListShrinkRequest request = new GetGroupLiveListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestBody))
            {
                request.RequestBodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestBody, "requestBody", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestBodyShrink))
            {
                query["requestBody"] = request.RequestBodyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroupLiveList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/groupLives",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupLiveListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群内的直播列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupLiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupLiveListResponse
        /// </returns>
        public GetGroupLiveListResponse GetGroupLiveList(GetGroupLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupLiveListHeaders headers = new GetGroupLiveListHeaders();
            return GetGroupLiveListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群内的直播列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupLiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupLiveListResponse
        /// </returns>
        public async Task<GetGroupLiveListResponse> GetGroupLiveListAsync(GetGroupLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupLiveListHeaders headers = new GetGroupLiveListHeaders();
            return await GetGroupLiveListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播的可下载回放地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLiveReplayUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetLiveReplayUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLiveReplayUrlResponse
        /// </returns>
        public GetLiveReplayUrlResponse GetLiveReplayUrlWithOptions(GetLiveReplayUrlRequest request, GetLiveReplayUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveReplayUrl",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives/replayUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveReplayUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播的可下载回放地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLiveReplayUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetLiveReplayUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLiveReplayUrlResponse
        /// </returns>
        public async Task<GetLiveReplayUrlResponse> GetLiveReplayUrlWithOptionsAsync(GetLiveReplayUrlRequest request, GetLiveReplayUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveReplayUrl",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives/replayUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveReplayUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播的可下载回放地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLiveReplayUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLiveReplayUrlResponse
        /// </returns>
        public GetLiveReplayUrlResponse GetLiveReplayUrl(GetLiveReplayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLiveReplayUrlHeaders headers = new GetLiveReplayUrlHeaders();
            return GetLiveReplayUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播的可下载回放地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLiveReplayUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLiveReplayUrlResponse
        /// </returns>
        public async Task<GetLiveReplayUrlResponse> GetLiveReplayUrlAsync(GetLiveReplayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLiveReplayUrlHeaders headers = new GetLiveReplayUrlHeaders();
            return await GetLiveReplayUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某组织内的直播列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetOrgLiveListRequest
        /// </param>
        /// <param name="headers">
        /// GetOrgLiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrgLiveListResponse
        /// </returns>
        public GetOrgLiveListResponse GetOrgLiveListWithOptions(GetOrgLiveListRequest tmpReq, GetOrgLiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetOrgLiveListShrinkRequest request = new GetOrgLiveListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestBody))
            {
                request.RequestBodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestBody, "requestBody", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestBodyShrink))
            {
                query["requestBody"] = request.RequestBodyShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgLiveList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/organizations/liveLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgLiveListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某组织内的直播列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetOrgLiveListRequest
        /// </param>
        /// <param name="headers">
        /// GetOrgLiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrgLiveListResponse
        /// </returns>
        public async Task<GetOrgLiveListResponse> GetOrgLiveListWithOptionsAsync(GetOrgLiveListRequest tmpReq, GetOrgLiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetOrgLiveListShrinkRequest request = new GetOrgLiveListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestBody))
            {
                request.RequestBodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestBody, "requestBody", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestBodyShrink))
            {
                query["requestBody"] = request.RequestBodyShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgLiveList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/organizations/liveLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgLiveListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某组织内的直播列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgLiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrgLiveListResponse
        /// </returns>
        public GetOrgLiveListResponse GetOrgLiveList(GetOrgLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgLiveListHeaders headers = new GetOrgLiveListHeaders();
            return GetOrgLiveListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某组织内的直播列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgLiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrgLiveListResponse
        /// </returns>
        public async Task<GetOrgLiveListResponse> GetOrgLiveListAsync(GetOrgLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgLiveListHeaders headers = new GetOrgLiveListHeaders();
            return await GetOrgLiveListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态拉我相关的直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAllLiveListRequest
        /// </param>
        /// <param name="headers">
        /// GetUserAllLiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAllLiveListResponse
        /// </returns>
        public GetUserAllLiveListResponse GetUserAllLiveListWithOptions(GetUserAllLiveListRequest request, GetUserAllLiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                body["statuses"] = request.Statuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserAllLiveList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/users/allLiveInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAllLiveListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态拉我相关的直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAllLiveListRequest
        /// </param>
        /// <param name="headers">
        /// GetUserAllLiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAllLiveListResponse
        /// </returns>
        public async Task<GetUserAllLiveListResponse> GetUserAllLiveListWithOptionsAsync(GetUserAllLiveListRequest request, GetUserAllLiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                body["statuses"] = request.Statuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserAllLiveList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/users/allLiveInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAllLiveListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态拉我相关的直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAllLiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAllLiveListResponse
        /// </returns>
        public GetUserAllLiveListResponse GetUserAllLiveList(GetUserAllLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAllLiveListHeaders headers = new GetUserAllLiveListHeaders();
            return GetUserAllLiveListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态拉我相关的直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAllLiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAllLiveListResponse
        /// </returns>
        public async Task<GetUserAllLiveListResponse> GetUserAllLiveListAsync(GetUserAllLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAllLiveListHeaders headers = new GetUserAllLiveListHeaders();
            return await GetUserAllLiveListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态获取用户创建的直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserCreateLiveListRequest
        /// </param>
        /// <param name="headers">
        /// GetUserCreateLiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserCreateLiveListResponse
        /// </returns>
        public GetUserCreateLiveListResponse GetUserCreateLiveListWithOptions(GetUserCreateLiveListRequest request, GetUserCreateLiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                body["statuses"] = request.Statuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserCreateLiveList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/users/createLiveInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserCreateLiveListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态获取用户创建的直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserCreateLiveListRequest
        /// </param>
        /// <param name="headers">
        /// GetUserCreateLiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserCreateLiveListResponse
        /// </returns>
        public async Task<GetUserCreateLiveListResponse> GetUserCreateLiveListWithOptionsAsync(GetUserCreateLiveListRequest request, GetUserCreateLiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                body["statuses"] = request.Statuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserCreateLiveList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/users/createLiveInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserCreateLiveListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态获取用户创建的直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserCreateLiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserCreateLiveListResponse
        /// </returns>
        public GetUserCreateLiveListResponse GetUserCreateLiveList(GetUserCreateLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserCreateLiveListHeaders headers = new GetUserCreateLiveListHeaders();
            return GetUserCreateLiveListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态获取用户创建的直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserCreateLiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserCreateLiveListResponse
        /// </returns>
        public async Task<GetUserCreateLiveListResponse> GetUserCreateLiveListAsync(GetUserCreateLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserCreateLiveListHeaders headers = new GetUserCreateLiveListHeaders();
            return await GetUserCreateLiveListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户观看直播记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserWatchLiveListRequest
        /// </param>
        /// <param name="headers">
        /// GetUserWatchLiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserWatchLiveListResponse
        /// </returns>
        public GetUserWatchLiveListResponse GetUserWatchLiveListWithOptions(GetUserWatchLiveListRequest request, GetUserWatchLiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterType))
            {
                query["filterType"] = request.FilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserWatchLiveList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/users/watchRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserWatchLiveListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户观看直播记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserWatchLiveListRequest
        /// </param>
        /// <param name="headers">
        /// GetUserWatchLiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserWatchLiveListResponse
        /// </returns>
        public async Task<GetUserWatchLiveListResponse> GetUserWatchLiveListWithOptionsAsync(GetUserWatchLiveListRequest request, GetUserWatchLiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterType))
            {
                query["filterType"] = request.FilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserWatchLiveList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/users/watchRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserWatchLiveListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户观看直播记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserWatchLiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserWatchLiveListResponse
        /// </returns>
        public GetUserWatchLiveListResponse GetUserWatchLiveList(GetUserWatchLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserWatchLiveListHeaders headers = new GetUserWatchLiveListHeaders();
            return GetUserWatchLiveListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户观看直播记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserWatchLiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserWatchLiveListResponse
        /// </returns>
        public async Task<GetUserWatchLiveListResponse> GetUserWatchLiveListAsync(GetUserWatchLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserWatchLiveListHeaders headers = new GetUserWatchLiveListHeaders();
            return await GetUserWatchLiveListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播课程可见白名单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyFeedWhiteListRequest
        /// </param>
        /// <param name="headers">
        /// ModifyFeedWhiteListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFeedWhiteListResponse
        /// </returns>
        public ModifyFeedWhiteListResponse ModifyFeedWhiteListWithOptions(string feedId, ModifyFeedWhiteListRequest tmpReq, ModifyFeedWhiteListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyFeedWhiteListShrinkRequest request = new ModifyFeedWhiteListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModifyUserList))
            {
                request.ModifyUserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModifyUserList, "modifyUserList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyUserListShrink))
            {
                query["modifyUserList"] = request.ModifyUserListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFeedWhiteList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/openFeeds/" + feedId + "/whiteList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFeedWhiteListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播课程可见白名单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyFeedWhiteListRequest
        /// </param>
        /// <param name="headers">
        /// ModifyFeedWhiteListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFeedWhiteListResponse
        /// </returns>
        public async Task<ModifyFeedWhiteListResponse> ModifyFeedWhiteListWithOptionsAsync(string feedId, ModifyFeedWhiteListRequest tmpReq, ModifyFeedWhiteListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyFeedWhiteListShrinkRequest request = new ModifyFeedWhiteListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModifyUserList))
            {
                request.ModifyUserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModifyUserList, "modifyUserList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyUserListShrink))
            {
                query["modifyUserList"] = request.ModifyUserListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFeedWhiteList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/openFeeds/" + feedId + "/whiteList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFeedWhiteListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播课程可见白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFeedWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFeedWhiteListResponse
        /// </returns>
        public ModifyFeedWhiteListResponse ModifyFeedWhiteList(string feedId, ModifyFeedWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyFeedWhiteListHeaders headers = new ModifyFeedWhiteListHeaders();
            return ModifyFeedWhiteListWithOptions(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播课程可见白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFeedWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFeedWhiteListResponse
        /// </returns>
        public async Task<ModifyFeedWhiteListResponse> ModifyFeedWhiteListAsync(string feedId, ModifyFeedWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyFeedWhiteListHeaders headers = new ModifyFeedWhiteListHeaders();
            return await ModifyFeedWhiteListWithOptionsAsync(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播课程的观看白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFeedWhiteListRequest
        /// </param>
        /// <param name="headers">
        /// QueryFeedWhiteListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFeedWhiteListResponse
        /// </returns>
        public QueryFeedWhiteListResponse QueryFeedWhiteListWithOptions(string feedId, QueryFeedWhiteListRequest request, QueryFeedWhiteListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFeedWhiteList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/openFeeds/" + feedId + "/whiteList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFeedWhiteListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播课程的观看白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFeedWhiteListRequest
        /// </param>
        /// <param name="headers">
        /// QueryFeedWhiteListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFeedWhiteListResponse
        /// </returns>
        public async Task<QueryFeedWhiteListResponse> QueryFeedWhiteListWithOptionsAsync(string feedId, QueryFeedWhiteListRequest request, QueryFeedWhiteListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFeedWhiteList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/openFeeds/" + feedId + "/whiteList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFeedWhiteListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播课程的观看白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFeedWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFeedWhiteListResponse
        /// </returns>
        public QueryFeedWhiteListResponse QueryFeedWhiteList(string feedId, QueryFeedWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFeedWhiteListHeaders headers = new QueryFeedWhiteListHeaders();
            return QueryFeedWhiteListWithOptions(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播课程的观看白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFeedWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFeedWhiteListResponse
        /// </returns>
        public async Task<QueryFeedWhiteListResponse> QueryFeedWhiteListAsync(string feedId, QueryFeedWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFeedWhiteListHeaders headers = new QueryFeedWhiteListHeaders();
            return await QueryFeedWhiteListWithOptionsAsync(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryLiveInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveInfoResponse
        /// </returns>
        public QueryLiveInfoResponse QueryLiveInfoWithOptions(QueryLiveInfoRequest request, QueryLiveInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveInfo",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryLiveInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveInfoResponse
        /// </returns>
        public async Task<QueryLiveInfoResponse> QueryLiveInfoWithOptionsAsync(QueryLiveInfoRequest request, QueryLiveInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveInfo",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveInfoResponse
        /// </returns>
        public QueryLiveInfoResponse QueryLiveInfo(QueryLiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveInfoHeaders headers = new QueryLiveInfoHeaders();
            return QueryLiveInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveInfoResponse
        /// </returns>
        public async Task<QueryLiveInfoResponse> QueryLiveInfoAsync(QueryLiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveInfoHeaders headers = new QueryLiveInfoHeaders();
            return await QueryLiveInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播间内某一互动插件的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveInteractionPluginRequest
        /// </param>
        /// <param name="headers">
        /// QueryLiveInteractionPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveInteractionPluginResponse
        /// </returns>
        public QueryLiveInteractionPluginResponse QueryLiveInteractionPluginWithOptions(QueryLiveInteractionPluginRequest request, QueryLiveInteractionPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveInteractionPlugin",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveInteractionPluginResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播间内某一互动插件的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveInteractionPluginRequest
        /// </param>
        /// <param name="headers">
        /// QueryLiveInteractionPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveInteractionPluginResponse
        /// </returns>
        public async Task<QueryLiveInteractionPluginResponse> QueryLiveInteractionPluginWithOptionsAsync(QueryLiveInteractionPluginRequest request, QueryLiveInteractionPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveInteractionPlugin",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveInteractionPluginResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播间内某一互动插件的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveInteractionPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveInteractionPluginResponse
        /// </returns>
        public QueryLiveInteractionPluginResponse QueryLiveInteractionPlugin(QueryLiveInteractionPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveInteractionPluginHeaders headers = new QueryLiveInteractionPluginHeaders();
            return QueryLiveInteractionPluginWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询直播间内某一互动插件的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveInteractionPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveInteractionPluginResponse
        /// </returns>
        public async Task<QueryLiveInteractionPluginResponse> QueryLiveInteractionPluginAsync(QueryLiveInteractionPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveInteractionPluginHeaders headers = new QueryLiveInteractionPluginHeaders();
            return await QueryLiveInteractionPluginWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播的观看数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveWatchDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryLiveWatchDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveWatchDetailResponse
        /// </returns>
        public QueryLiveWatchDetailResponse QueryLiveWatchDetailWithOptions(QueryLiveWatchDetailRequest request, QueryLiveWatchDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveWatchDetail",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives/watchDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveWatchDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播的观看数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveWatchDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryLiveWatchDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveWatchDetailResponse
        /// </returns>
        public async Task<QueryLiveWatchDetailResponse> QueryLiveWatchDetailWithOptionsAsync(QueryLiveWatchDetailRequest request, QueryLiveWatchDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveWatchDetail",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives/watchDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveWatchDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播的观看数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveWatchDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveWatchDetailResponse
        /// </returns>
        public QueryLiveWatchDetailResponse QueryLiveWatchDetail(QueryLiveWatchDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchDetailHeaders headers = new QueryLiveWatchDetailHeaders();
            return QueryLiveWatchDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播的观看数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveWatchDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveWatchDetailResponse
        /// </returns>
        public async Task<QueryLiveWatchDetailResponse> QueryLiveWatchDetailAsync(QueryLiveWatchDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchDetailHeaders headers = new QueryLiveWatchDetailHeaders();
            return await QueryLiveWatchDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播观看用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveWatchUserListRequest
        /// </param>
        /// <param name="headers">
        /// QueryLiveWatchUserListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveWatchUserListResponse
        /// </returns>
        public QueryLiveWatchUserListResponse QueryLiveWatchUserListWithOptions(QueryLiveWatchUserListRequest request, QueryLiveWatchUserListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveWatchUserList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives/watchUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveWatchUserListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播观看用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveWatchUserListRequest
        /// </param>
        /// <param name="headers">
        /// QueryLiveWatchUserListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveWatchUserListResponse
        /// </returns>
        public async Task<QueryLiveWatchUserListResponse> QueryLiveWatchUserListWithOptionsAsync(QueryLiveWatchUserListRequest request, QueryLiveWatchUserListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveWatchUserList",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives/watchUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveWatchUserListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播观看用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveWatchUserListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveWatchUserListResponse
        /// </returns>
        public QueryLiveWatchUserListResponse QueryLiveWatchUserList(QueryLiveWatchUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchUserListHeaders headers = new QueryLiveWatchUserListHeaders();
            return QueryLiveWatchUserListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取直播观看用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLiveWatchUserListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLiveWatchUserListResponse
        /// </returns>
        public async Task<QueryLiveWatchUserListResponse> QueryLiveWatchUserListAsync(QueryLiveWatchUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchUserListHeaders headers = new QueryLiveWatchUserListHeaders();
            return await QueryLiveWatchUserListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询直播是否订阅</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QuerySubscribeStatusRequest
        /// </param>
        /// <param name="headers">
        /// QuerySubscribeStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySubscribeStatusResponse
        /// </returns>
        public QuerySubscribeStatusResponse QuerySubscribeStatusWithOptions(QuerySubscribeStatusRequest tmpReq, QuerySubscribeStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySubscribeStatusShrinkRequest request = new QuerySubscribeStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySubscribeStatus",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/subscribeStatuses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySubscribeStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询直播是否订阅</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QuerySubscribeStatusRequest
        /// </param>
        /// <param name="headers">
        /// QuerySubscribeStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySubscribeStatusResponse
        /// </returns>
        public async Task<QuerySubscribeStatusResponse> QuerySubscribeStatusWithOptionsAsync(QuerySubscribeStatusRequest tmpReq, QuerySubscribeStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySubscribeStatusShrinkRequest request = new QuerySubscribeStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySubscribeStatus",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/subscribeStatuses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySubscribeStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询直播是否订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySubscribeStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySubscribeStatusResponse
        /// </returns>
        public QuerySubscribeStatusResponse QuerySubscribeStatus(QuerySubscribeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySubscribeStatusHeaders headers = new QuerySubscribeStatusHeaders();
            return QuerySubscribeStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询直播是否订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySubscribeStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySubscribeStatusResponse
        /// </returns>
        public async Task<QuerySubscribeStatusResponse> QuerySubscribeStatusAsync(QuerySubscribeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySubscribeStatusHeaders headers = new QuerySubscribeStatusHeaders();
            return await QuerySubscribeStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户推送互动插件特效消息到直播间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLiveInteractionPluginEffectsMsgRequest
        /// </param>
        /// <param name="headers">
        /// SendLiveInteractionPluginEffectsMsgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendLiveInteractionPluginEffectsMsgResponse
        /// </returns>
        public SendLiveInteractionPluginEffectsMsgResponse SendLiveInteractionPluginEffectsMsgWithOptions(SendLiveInteractionPluginEffectsMsgRequest request, SendLiveInteractionPluginEffectsMsgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LottieFileUrl))
            {
                body["lottieFileUrl"] = request.LottieFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgIconUrl))
            {
                body["msgIconUrl"] = request.MsgIconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgText))
            {
                body["msgText"] = request.MsgText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginSubId))
            {
                body["pluginSubId"] = request.PluginSubId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUnionId))
            {
                body["senderUnionId"] = request.SenderUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendLiveInteractionPluginEffectsMsg",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins/effectMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLiveInteractionPluginEffectsMsgResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户推送互动插件特效消息到直播间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLiveInteractionPluginEffectsMsgRequest
        /// </param>
        /// <param name="headers">
        /// SendLiveInteractionPluginEffectsMsgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendLiveInteractionPluginEffectsMsgResponse
        /// </returns>
        public async Task<SendLiveInteractionPluginEffectsMsgResponse> SendLiveInteractionPluginEffectsMsgWithOptionsAsync(SendLiveInteractionPluginEffectsMsgRequest request, SendLiveInteractionPluginEffectsMsgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LottieFileUrl))
            {
                body["lottieFileUrl"] = request.LottieFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgIconUrl))
            {
                body["msgIconUrl"] = request.MsgIconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgText))
            {
                body["msgText"] = request.MsgText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginSubId))
            {
                body["pluginSubId"] = request.PluginSubId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUnionId))
            {
                body["senderUnionId"] = request.SenderUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendLiveInteractionPluginEffectsMsg",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins/effectMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLiveInteractionPluginEffectsMsgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户推送互动插件特效消息到直播间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLiveInteractionPluginEffectsMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// SendLiveInteractionPluginEffectsMsgResponse
        /// </returns>
        public SendLiveInteractionPluginEffectsMsgResponse SendLiveInteractionPluginEffectsMsg(SendLiveInteractionPluginEffectsMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendLiveInteractionPluginEffectsMsgHeaders headers = new SendLiveInteractionPluginEffectsMsgHeaders();
            return SendLiveInteractionPluginEffectsMsgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户推送互动插件特效消息到直播间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLiveInteractionPluginEffectsMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// SendLiveInteractionPluginEffectsMsgResponse
        /// </returns>
        public async Task<SendLiveInteractionPluginEffectsMsgResponse> SendLiveInteractionPluginEffectsMsgAsync(SendLiveInteractionPluginEffectsMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendLiveInteractionPluginEffectsMsgHeaders headers = new SendLiveInteractionPluginEffectsMsgHeaders();
            return await SendLiveInteractionPluginEffectsMsgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户对互动插件进行操作广播到直播间</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendLivePluginUserActionMsgRequest
        /// </param>
        /// <param name="headers">
        /// SendLivePluginUserActionMsgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendLivePluginUserActionMsgResponse
        /// </returns>
        public SendLivePluginUserActionMsgResponse SendLivePluginUserActionMsgWithOptions(SendLivePluginUserActionMsgRequest tmpReq, SendLivePluginUserActionMsgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendLivePluginUserActionMsgShrinkRequest request = new SendLivePluginUserActionMsgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PluginEffectsMessage))
            {
                request.PluginEffectsMessageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PluginEffectsMessage, "pluginEffectsMessage", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginEffectsMessageShrink))
            {
                query["pluginEffectsMessage"] = request.PluginEffectsMessageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendLivePluginUserActionMsg",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins/actionMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLivePluginUserActionMsgResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户对互动插件进行操作广播到直播间</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendLivePluginUserActionMsgRequest
        /// </param>
        /// <param name="headers">
        /// SendLivePluginUserActionMsgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendLivePluginUserActionMsgResponse
        /// </returns>
        public async Task<SendLivePluginUserActionMsgResponse> SendLivePluginUserActionMsgWithOptionsAsync(SendLivePluginUserActionMsgRequest tmpReq, SendLivePluginUserActionMsgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendLivePluginUserActionMsgShrinkRequest request = new SendLivePluginUserActionMsgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PluginEffectsMessage))
            {
                request.PluginEffectsMessageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PluginEffectsMessage, "pluginEffectsMessage", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginEffectsMessageShrink))
            {
                query["pluginEffectsMessage"] = request.PluginEffectsMessageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendLivePluginUserActionMsg",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins/actionMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLivePluginUserActionMsgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户对互动插件进行操作广播到直播间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLivePluginUserActionMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// SendLivePluginUserActionMsgResponse
        /// </returns>
        public SendLivePluginUserActionMsgResponse SendLivePluginUserActionMsg(SendLivePluginUserActionMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendLivePluginUserActionMsgHeaders headers = new SendLivePluginUserActionMsgHeaders();
            return SendLivePluginUserActionMsgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户对互动插件进行操作广播到直播间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLivePluginUserActionMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// SendLivePluginUserActionMsgResponse
        /// </returns>
        public async Task<SendLivePluginUserActionMsgResponse> SendLivePluginUserActionMsgAsync(SendLivePluginUserActionMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendLivePluginUserActionMsgHeaders headers = new SendLivePluginUserActionMsgHeaders();
            return await SendLivePluginUserActionMsgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始一场云导播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudFeedRequest
        /// </param>
        /// <param name="headers">
        /// StartCloudFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCloudFeedResponse
        /// </returns>
        public StartCloudFeedResponse StartCloudFeedWithOptions(string feedId, StartCloudFeedRequest request, StartCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCloudFeed",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/cloudFeeds/" + feedId + "/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudFeedResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始一场云导播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudFeedRequest
        /// </param>
        /// <param name="headers">
        /// StartCloudFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCloudFeedResponse
        /// </returns>
        public async Task<StartCloudFeedResponse> StartCloudFeedWithOptionsAsync(string feedId, StartCloudFeedRequest request, StartCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCloudFeed",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/cloudFeeds/" + feedId + "/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudFeedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始一场云导播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCloudFeedResponse
        /// </returns>
        public StartCloudFeedResponse StartCloudFeed(string feedId, StartCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudFeedHeaders headers = new StartCloudFeedHeaders();
            return StartCloudFeedWithOptions(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始一场云导播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCloudFeedResponse
        /// </returns>
        public async Task<StartCloudFeedResponse> StartCloudFeedAsync(string feedId, StartCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudFeedHeaders headers = new StartCloudFeedHeaders();
            return await StartCloudFeedWithOptionsAsync(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结束一场云导播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudFeedRequest
        /// </param>
        /// <param name="headers">
        /// StopCloudFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCloudFeedResponse
        /// </returns>
        public StopCloudFeedResponse StopCloudFeedWithOptions(string feedId, StopCloudFeedRequest request, StopCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCloudFeed",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/cloudFeeds/" + feedId + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudFeedResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结束一场云导播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudFeedRequest
        /// </param>
        /// <param name="headers">
        /// StopCloudFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCloudFeedResponse
        /// </returns>
        public async Task<StopCloudFeedResponse> StopCloudFeedWithOptionsAsync(string feedId, StopCloudFeedRequest request, StopCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCloudFeed",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/cloudFeeds/" + feedId + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudFeedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结束一场云导播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCloudFeedResponse
        /// </returns>
        public StopCloudFeedResponse StopCloudFeed(string feedId, StopCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudFeedHeaders headers = new StopCloudFeedHeaders();
            return StopCloudFeedWithOptions(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结束一场云导播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCloudFeedResponse
        /// </returns>
        public async Task<StopCloudFeedResponse> StopCloudFeedAsync(string feedId, StopCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudFeedHeaders headers = new StopCloudFeedHeaders();
            return await StopCloudFeedWithOptionsAsync(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预约直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubscribeLiveRequest
        /// </param>
        /// <param name="headers">
        /// SubscribeLiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubscribeLiveResponse
        /// </returns>
        public SubscribeLiveResponse SubscribeLiveWithOptions(SubscribeLiveRequest request, SubscribeLiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subscribe))
            {
                query["subscribe"] = request.Subscribe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubscribeLive",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives/subscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscribeLiveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预约直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubscribeLiveRequest
        /// </param>
        /// <param name="headers">
        /// SubscribeLiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubscribeLiveResponse
        /// </returns>
        public async Task<SubscribeLiveResponse> SubscribeLiveWithOptionsAsync(SubscribeLiveRequest request, SubscribeLiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subscribe))
            {
                query["subscribe"] = request.Subscribe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubscribeLive",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives/subscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscribeLiveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预约直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubscribeLiveRequest
        /// </param>
        /// 
        /// <returns>
        /// SubscribeLiveResponse
        /// </returns>
        public SubscribeLiveResponse SubscribeLive(SubscribeLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeLiveHeaders headers = new SubscribeLiveHeaders();
            return SubscribeLiveWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预约直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubscribeLiveRequest
        /// </param>
        /// 
        /// <returns>
        /// SubscribeLiveResponse
        /// </returns>
        public async Task<SubscribeLiveResponse> SubscribeLiveAsync(SubscribeLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeLiveHeaders headers = new SubscribeLiveHeaders();
            return await SubscribeLiveWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveRequest
        /// </param>
        /// <param name="headers">
        /// UpdateLiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveResponse
        /// </returns>
        public UpdateLiveResponse UpdateLiveWithOptions(UpdateLiveRequest request, UpdateLiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                body["introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEndTime))
            {
                body["preEndTime"] = request.PreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStartTime))
            {
                body["preStartTime"] = request.PreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLive",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveRequest
        /// </param>
        /// <param name="headers">
        /// UpdateLiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveResponse
        /// </returns>
        public async Task<UpdateLiveResponse> UpdateLiveWithOptionsAsync(UpdateLiveRequest request, UpdateLiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                body["introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEndTime))
            {
                body["preEndTime"] = request.PreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStartTime))
            {
                body["preStartTime"] = request.PreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLive",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/lives",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveResponse
        /// </returns>
        public UpdateLiveResponse UpdateLive(UpdateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveHeaders headers = new UpdateLiveHeaders();
            return UpdateLiveWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveResponse
        /// </returns>
        public async Task<UpdateLiveResponse> UpdateLiveAsync(UpdateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveHeaders headers = new UpdateLiveHeaders();
            return await UpdateLiveWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改培训课程信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveFeedRequest
        /// </param>
        /// <param name="headers">
        /// UpdateLiveFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveFeedResponse
        /// </returns>
        public UpdateLiveFeedResponse UpdateLiveFeedWithOptions(string feedId, UpdateLiveFeedRequest request, UpdateLiveFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                query["introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveFeed",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/openFeeds/" + feedId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveFeedResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改培训课程信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveFeedRequest
        /// </param>
        /// <param name="headers">
        /// UpdateLiveFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveFeedResponse
        /// </returns>
        public async Task<UpdateLiveFeedResponse> UpdateLiveFeedWithOptionsAsync(string feedId, UpdateLiveFeedRequest request, UpdateLiveFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                query["introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveFeed",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/openFeeds/" + feedId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveFeedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改培训课程信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveFeedResponse
        /// </returns>
        public UpdateLiveFeedResponse UpdateLiveFeed(string feedId, UpdateLiveFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveFeedHeaders headers = new UpdateLiveFeedHeaders();
            return UpdateLiveFeedWithOptions(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改培训课程信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveFeedResponse
        /// </returns>
        public async Task<UpdateLiveFeedResponse> UpdateLiveFeedAsync(string feedId, UpdateLiveFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveFeedHeaders headers = new UpdateLiveFeedHeaders();
            return await UpdateLiveFeedWithOptionsAsync(feedId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播间内某一互动插件的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveInteractionPluginRequest
        /// </param>
        /// <param name="headers">
        /// UpdateLiveInteractionPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveInteractionPluginResponse
        /// </returns>
        public UpdateLiveInteractionPluginResponse UpdateLiveInteractionPluginWithOptions(UpdateLiveInteractionPluginRequest request, UpdateLiveInteractionPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorJumpUrl))
            {
                body["anchorJumpUrl"] = request.AnchorJumpUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginIconUrl))
            {
                body["pluginIconUrl"] = request.PluginIconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginName))
            {
                body["pluginName"] = request.PluginName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginNameEn))
            {
                body["pluginNameEn"] = request.PluginNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewerJumpUrl))
            {
                body["viewerJumpUrl"] = request.ViewerJumpUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveInteractionPlugin",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveInteractionPluginResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播间内某一互动插件的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveInteractionPluginRequest
        /// </param>
        /// <param name="headers">
        /// UpdateLiveInteractionPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveInteractionPluginResponse
        /// </returns>
        public async Task<UpdateLiveInteractionPluginResponse> UpdateLiveInteractionPluginWithOptionsAsync(UpdateLiveInteractionPluginRequest request, UpdateLiveInteractionPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                query["liveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorJumpUrl))
            {
                body["anchorJumpUrl"] = request.AnchorJumpUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginIconUrl))
            {
                body["pluginIconUrl"] = request.PluginIconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginName))
            {
                body["pluginName"] = request.PluginName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginNameEn))
            {
                body["pluginNameEn"] = request.PluginNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewerJumpUrl))
            {
                body["viewerJumpUrl"] = request.ViewerJumpUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveInteractionPlugin",
                Version = "live_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/live/interactionPlugins",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveInteractionPluginResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播间内某一互动插件的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveInteractionPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveInteractionPluginResponse
        /// </returns>
        public UpdateLiveInteractionPluginResponse UpdateLiveInteractionPlugin(UpdateLiveInteractionPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveInteractionPluginHeaders headers = new UpdateLiveInteractionPluginHeaders();
            return UpdateLiveInteractionPluginWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改直播间内某一互动插件的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLiveInteractionPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLiveInteractionPluginResponse
        /// </returns>
        public async Task<UpdateLiveInteractionPluginResponse> UpdateLiveInteractionPluginAsync(UpdateLiveInteractionPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveInteractionPluginHeaders headers = new UpdateLiveInteractionPluginHeaders();
            return await UpdateLiveInteractionPluginWithOptionsAsync(request, headers, runtime);
        }

    }
}
