// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkding_one_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkding_one_1_0
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
        /// <para>删除Feed</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFeedRequest
        /// </param>
        /// <param name="headers">
        /// DeleteFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFeedResponse
        /// </returns>
        public DeleteFeedResponse DeleteFeedWithOptions(DeleteFeedRequest request, DeleteFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedId))
            {
                body["feedId"] = request.FeedId;
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
                Action = "DeleteFeed",
                Version = "dingOne_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingOne/frame/feeds/deleteFeed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFeedResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Feed</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFeedRequest
        /// </param>
        /// <param name="headers">
        /// DeleteFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFeedResponse
        /// </returns>
        public async Task<DeleteFeedResponse> DeleteFeedWithOptionsAsync(DeleteFeedRequest request, DeleteFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedId))
            {
                body["feedId"] = request.FeedId;
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
                Action = "DeleteFeed",
                Version = "dingOne_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingOne/frame/feeds/deleteFeed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFeedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Feed</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFeedResponse
        /// </returns>
        public DeleteFeedResponse DeleteFeed(DeleteFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFeedHeaders headers = new DeleteFeedHeaders();
            return DeleteFeedWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Feed</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFeedResponse
        /// </returns>
        public async Task<DeleteFeedResponse> DeleteFeedAsync(DeleteFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFeedHeaders headers = new DeleteFeedHeaders();
            return await DeleteFeedWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放钉钉one中feed流资讯内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverOneFeedRequest
        /// </param>
        /// <param name="headers">
        /// DeliverOneFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeliverOneFeedResponse
        /// </returns>
        public DeliverOneFeedResponse DeliverOneFeedWithOptions(DeliverOneFeedRequest request, DeliverOneFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverMediaId))
            {
                body["coverMediaId"] = request.CoverMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoMediaId))
            {
                body["videoMediaId"] = request.VideoMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoTags))
            {
                body["videoTags"] = request.VideoTags;
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
                Action = "DeliverOneFeed",
                Version = "dingOne_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingOne/feed/deliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliverOneFeedResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放钉钉one中feed流资讯内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverOneFeedRequest
        /// </param>
        /// <param name="headers">
        /// DeliverOneFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeliverOneFeedResponse
        /// </returns>
        public async Task<DeliverOneFeedResponse> DeliverOneFeedWithOptionsAsync(DeliverOneFeedRequest request, DeliverOneFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverMediaId))
            {
                body["coverMediaId"] = request.CoverMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoMediaId))
            {
                body["videoMediaId"] = request.VideoMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoTags))
            {
                body["videoTags"] = request.VideoTags;
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
                Action = "DeliverOneFeed",
                Version = "dingOne_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingOne/feed/deliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliverOneFeedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放钉钉one中feed流资讯内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverOneFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// DeliverOneFeedResponse
        /// </returns>
        public DeliverOneFeedResponse DeliverOneFeed(DeliverOneFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverOneFeedHeaders headers = new DeliverOneFeedHeaders();
            return DeliverOneFeedWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放钉钉one中feed流资讯内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverOneFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// DeliverOneFeedResponse
        /// </returns>
        public async Task<DeliverOneFeedResponse> DeliverOneFeedAsync(DeliverOneFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverOneFeedHeaders headers = new DeliverOneFeedHeaders();
            return await DeliverOneFeedWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Feed推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushFeedRequest
        /// </param>
        /// <param name="headers">
        /// PushFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushFeedResponse
        /// </returns>
        public PushFeedResponse PushFeedWithOptions(PushFeedRequest request, PushFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedFeature))
            {
                body["feedFeature"] = request.FeedFeature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentKey))
            {
                body["idempotentKey"] = request.IdempotentKey;
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
                Action = "PushFeed",
                Version = "dingOne_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingOne/frame/feeds/pushFeed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushFeedResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Feed推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushFeedRequest
        /// </param>
        /// <param name="headers">
        /// PushFeedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushFeedResponse
        /// </returns>
        public async Task<PushFeedResponse> PushFeedWithOptionsAsync(PushFeedRequest request, PushFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedFeature))
            {
                body["feedFeature"] = request.FeedFeature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentKey))
            {
                body["idempotentKey"] = request.IdempotentKey;
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
                Action = "PushFeed",
                Version = "dingOne_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingOne/frame/feeds/pushFeed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushFeedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Feed推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// PushFeedResponse
        /// </returns>
        public PushFeedResponse PushFeed(PushFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushFeedHeaders headers = new PushFeedHeaders();
            return PushFeedWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Feed推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushFeedRequest
        /// </param>
        /// 
        /// <returns>
        /// PushFeedResponse
        /// </returns>
        public async Task<PushFeedResponse> PushFeedAsync(PushFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushFeedHeaders headers = new PushFeedHeaders();
            return await PushFeedWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新feed内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeedContentRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFeedContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeedContentResponse
        /// </returns>
        public UpdateFeedContentResponse UpdateFeedContentWithOptions(UpdateFeedContentRequest request, UpdateFeedContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedId))
            {
                body["feedId"] = request.FeedId;
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
                Action = "UpdateFeedContent",
                Version = "dingOne_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingOne/frame/feeds/updateFeedContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFeedContentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新feed内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeedContentRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFeedContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeedContentResponse
        /// </returns>
        public async Task<UpdateFeedContentResponse> UpdateFeedContentWithOptionsAsync(UpdateFeedContentRequest request, UpdateFeedContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedId))
            {
                body["feedId"] = request.FeedId;
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
                Action = "UpdateFeedContent",
                Version = "dingOne_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingOne/frame/feeds/updateFeedContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFeedContentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新feed内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeedContentResponse
        /// </returns>
        public UpdateFeedContentResponse UpdateFeedContent(UpdateFeedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFeedContentHeaders headers = new UpdateFeedContentHeaders();
            return UpdateFeedContentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新feed内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeedContentResponse
        /// </returns>
        public async Task<UpdateFeedContentResponse> UpdateFeedContentAsync(UpdateFeedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFeedContentHeaders headers = new UpdateFeedContentHeaders();
            return await UpdateFeedContentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新feed过期时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeedExpireTimeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFeedExpireTimeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeedExpireTimeResponse
        /// </returns>
        public UpdateFeedExpireTimeResponse UpdateFeedExpireTimeWithOptions(UpdateFeedExpireTimeRequest request, UpdateFeedExpireTimeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedId))
            {
                body["feedId"] = request.FeedId;
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
                Action = "UpdateFeedExpireTime",
                Version = "dingOne_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingOne/frame/feeds/updateFeedExpireTime",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFeedExpireTimeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新feed过期时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeedExpireTimeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFeedExpireTimeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeedExpireTimeResponse
        /// </returns>
        public async Task<UpdateFeedExpireTimeResponse> UpdateFeedExpireTimeWithOptionsAsync(UpdateFeedExpireTimeRequest request, UpdateFeedExpireTimeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedId))
            {
                body["feedId"] = request.FeedId;
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
                Action = "UpdateFeedExpireTime",
                Version = "dingOne_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingOne/frame/feeds/updateFeedExpireTime",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFeedExpireTimeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新feed过期时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeedExpireTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeedExpireTimeResponse
        /// </returns>
        public UpdateFeedExpireTimeResponse UpdateFeedExpireTime(UpdateFeedExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFeedExpireTimeHeaders headers = new UpdateFeedExpireTimeHeaders();
            return UpdateFeedExpireTimeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新feed过期时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeedExpireTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeedExpireTimeResponse
        /// </returns>
        public async Task<UpdateFeedExpireTimeResponse> UpdateFeedExpireTimeAsync(UpdateFeedExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFeedExpireTimeHeaders headers = new UpdateFeedExpireTimeHeaders();
            return await UpdateFeedExpireTimeWithOptionsAsync(request, headers, runtime);
        }

    }
}
