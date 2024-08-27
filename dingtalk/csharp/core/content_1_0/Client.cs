// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcontent_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0
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


        /**
         * @summary 创建内容
         *
         * @param request CreateFeedRequest
         * @param headers CreateFeedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeedResponse
         */
        public CreateFeedResponse CreateFeedWithOptions(CreateFeedRequest request, CreateFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseInfo))
            {
                body["courseInfo"] = request.CourseInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["createUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedInfo))
            {
                body["feedInfo"] = request.FeedInfo;
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
                Action = "CreateFeed",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/feeds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeedResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建内容
         *
         * @param request CreateFeedRequest
         * @param headers CreateFeedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeedResponse
         */
        public async Task<CreateFeedResponse> CreateFeedWithOptionsAsync(CreateFeedRequest request, CreateFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseInfo))
            {
                body["courseInfo"] = request.CourseInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["createUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedInfo))
            {
                body["feedInfo"] = request.FeedInfo;
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
                Action = "CreateFeed",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/feeds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建内容
         *
         * @param request CreateFeedRequest
         * @return CreateFeedResponse
         */
        public CreateFeedResponse CreateFeed(CreateFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFeedHeaders headers = new CreateFeedHeaders();
            return CreateFeedWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建内容
         *
         * @param request CreateFeedRequest
         * @return CreateFeedResponse
         */
        public async Task<CreateFeedResponse> CreateFeedAsync(CreateFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFeedHeaders headers = new CreateFeedHeaders();
            return await CreateFeedWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 点众下架视频接口
         *
         * @param request DeleteVideosRequest
         * @param headers DeleteVideosHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVideosResponse
         */
        public DeleteVideosResponse DeleteVideosWithOptions(DeleteVideosRequest request, DeleteVideosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVideos",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/dian/videos/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideosResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 点众下架视频接口
         *
         * @param request DeleteVideosRequest
         * @param headers DeleteVideosHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVideosResponse
         */
        public async Task<DeleteVideosResponse> DeleteVideosWithOptionsAsync(DeleteVideosRequest request, DeleteVideosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVideos",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/dian/videos/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideosResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 点众下架视频接口
         *
         * @param request DeleteVideosRequest
         * @return DeleteVideosResponse
         */
        public DeleteVideosResponse DeleteVideos(DeleteVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteVideosHeaders headers = new DeleteVideosHeaders();
            return DeleteVideosWithOptions(request, headers, runtime);
        }

        /**
         * @summary 点众下架视频接口
         *
         * @param request DeleteVideosRequest
         * @return DeleteVideosResponse
         */
        public async Task<DeleteVideosResponse> DeleteVideosAsync(DeleteVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteVideosHeaders headers = new DeleteVideosHeaders();
            return await DeleteVideosWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取feed的详细信息，包括子课程的信息
         *
         * @param request GetFeedRequest
         * @param headers GetFeedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeedResponse
         */
        public GetFeedResponse GetFeedWithOptions(string feedId, GetFeedRequest request, GetFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McnId))
            {
                query["mcnId"] = request.McnId;
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
                Action = "GetFeed",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/feeds/" + feedId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeedResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取feed的详细信息，包括子课程的信息
         *
         * @param request GetFeedRequest
         * @param headers GetFeedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeedResponse
         */
        public async Task<GetFeedResponse> GetFeedWithOptionsAsync(string feedId, GetFeedRequest request, GetFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McnId))
            {
                query["mcnId"] = request.McnId;
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
                Action = "GetFeed",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/feeds/" + feedId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取feed的详细信息，包括子课程的信息
         *
         * @param request GetFeedRequest
         * @return GetFeedResponse
         */
        public GetFeedResponse GetFeed(string feedId, GetFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFeedHeaders headers = new GetFeedHeaders();
            return GetFeedWithOptions(feedId, request, headers, runtime);
        }

        /**
         * @summary 获取feed的详细信息，包括子课程的信息
         *
         * @param request GetFeedRequest
         * @return GetFeedResponse
         */
        public async Task<GetFeedResponse> GetFeedAsync(string feedId, GetFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFeedHeaders headers = new GetFeedHeaders();
            return await GetFeedWithOptionsAsync(feedId, request, headers, runtime);
        }

        /**
         * @summary 获取oss上传凭证
         *
         * @param request GetMediaCerficateRequest
         * @param headers GetMediaCerficateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaCerficateResponse
         */
        public GetMediaCerficateResponse GetMediaCerficateWithOptions(GetMediaCerficateRequest request, GetMediaCerficateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McnId))
            {
                query["mcnId"] = request.McnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIntroduction))
            {
                query["mediaIntroduction"] = request.MediaIntroduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTitle))
            {
                query["mediaTitle"] = request.MediaTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbUrl))
            {
                query["thumbUrl"] = request.ThumbUrl;
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
                Action = "GetMediaCerficate",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/media/cerficates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaCerficateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取oss上传凭证
         *
         * @param request GetMediaCerficateRequest
         * @param headers GetMediaCerficateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaCerficateResponse
         */
        public async Task<GetMediaCerficateResponse> GetMediaCerficateWithOptionsAsync(GetMediaCerficateRequest request, GetMediaCerficateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McnId))
            {
                query["mcnId"] = request.McnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIntroduction))
            {
                query["mediaIntroduction"] = request.MediaIntroduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTitle))
            {
                query["mediaTitle"] = request.MediaTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbUrl))
            {
                query["thumbUrl"] = request.ThumbUrl;
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
                Action = "GetMediaCerficate",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/media/cerficates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaCerficateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取oss上传凭证
         *
         * @param request GetMediaCerficateRequest
         * @return GetMediaCerficateResponse
         */
        public GetMediaCerficateResponse GetMediaCerficate(GetMediaCerficateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMediaCerficateHeaders headers = new GetMediaCerficateHeaders();
            return GetMediaCerficateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取oss上传凭证
         *
         * @param request GetMediaCerficateRequest
         * @return GetMediaCerficateResponse
         */
        public async Task<GetMediaCerficateResponse> GetMediaCerficateAsync(GetMediaCerficateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMediaCerficateHeaders headers = new GetMediaCerficateHeaders();
            return await GetMediaCerficateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 展示机构内观看内容的统计信息
         *
         * @param request ListItemUserDataRequest
         * @param headers ListItemUserDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListItemUserDataResponse
         */
        public ListItemUserDataResponse ListItemUserDataWithOptions(string itemId, ListItemUserDataRequest request, ListItemUserDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListItemUserData",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/feeds/items/" + itemId + "/userStatistics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListItemUserDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 展示机构内观看内容的统计信息
         *
         * @param request ListItemUserDataRequest
         * @param headers ListItemUserDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListItemUserDataResponse
         */
        public async Task<ListItemUserDataResponse> ListItemUserDataWithOptionsAsync(string itemId, ListItemUserDataRequest request, ListItemUserDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListItemUserData",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/feeds/items/" + itemId + "/userStatistics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListItemUserDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 展示机构内观看内容的统计信息
         *
         * @param request ListItemUserDataRequest
         * @return ListItemUserDataResponse
         */
        public ListItemUserDataResponse ListItemUserData(string itemId, ListItemUserDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListItemUserDataHeaders headers = new ListItemUserDataHeaders();
            return ListItemUserDataWithOptions(itemId, request, headers, runtime);
        }

        /**
         * @summary 展示机构内观看内容的统计信息
         *
         * @param request ListItemUserDataRequest
         * @return ListItemUserDataResponse
         */
        public async Task<ListItemUserDataResponse> ListItemUserDataAsync(string itemId, ListItemUserDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListItemUserDataHeaders headers = new ListItemUserDataHeaders();
            return await ListItemUserDataWithOptionsAsync(itemId, request, headers, runtime);
        }

        /**
         * @summary 获取机构下课程列表
         *
         * @param request PageFeedRequest
         * @param headers PageFeedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageFeedResponse
         */
        public PageFeedResponse PageFeedWithOptions(PageFeedRequest request, PageFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McnId))
            {
                query["mcnId"] = request.McnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageFeed",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/feeds/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageFeedResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取机构下课程列表
         *
         * @param request PageFeedRequest
         * @param headers PageFeedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageFeedResponse
         */
        public async Task<PageFeedResponse> PageFeedWithOptionsAsync(PageFeedRequest request, PageFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McnId))
            {
                query["mcnId"] = request.McnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageFeed",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/feeds/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageFeedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取机构下课程列表
         *
         * @param request PageFeedRequest
         * @return PageFeedResponse
         */
        public PageFeedResponse PageFeed(PageFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageFeedHeaders headers = new PageFeedHeaders();
            return PageFeedWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取机构下课程列表
         *
         * @param request PageFeedRequest
         * @return PageFeedResponse
         */
        public async Task<PageFeedResponse> PageFeedAsync(PageFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageFeedHeaders headers = new PageFeedHeaders();
            return await PageFeedWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 点众上传视频信息
         *
         * @param request UploadVideosRequest
         * @param headers UploadVideosHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadVideosResponse
         */
        public UploadVideosResponse UploadVideosWithOptions(UploadVideosRequest request, UploadVideosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadVideos",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/dian/videos/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadVideosResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 点众上传视频信息
         *
         * @param request UploadVideosRequest
         * @param headers UploadVideosHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadVideosResponse
         */
        public async Task<UploadVideosResponse> UploadVideosWithOptionsAsync(UploadVideosRequest request, UploadVideosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadVideos",
                Version = "content_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/content/dian/videos/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadVideosResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 点众上传视频信息
         *
         * @param request UploadVideosRequest
         * @return UploadVideosResponse
         */
        public UploadVideosResponse UploadVideos(UploadVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadVideosHeaders headers = new UploadVideosHeaders();
            return UploadVideosWithOptions(request, headers, runtime);
        }

        /**
         * @summary 点众上传视频信息
         *
         * @param request UploadVideosRequest
         * @return UploadVideosResponse
         */
        public async Task<UploadVideosResponse> UploadVideosAsync(UploadVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadVideosHeaders headers = new UploadVideosHeaders();
            return await UploadVideosWithOptionsAsync(request, headers, runtime);
        }

    }
}
