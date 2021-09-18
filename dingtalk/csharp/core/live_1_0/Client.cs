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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public EditFeedReplayResponse EditFeedReplay(string feedId, EditFeedReplayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditFeedReplayHeaders headers = new EditFeedReplayHeaders();
            return EditFeedReplayWithOptions(feedId, request, headers, runtime);
        }

        public async Task<EditFeedReplayResponse> EditFeedReplayAsync(string feedId, EditFeedReplayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditFeedReplayHeaders headers = new EditFeedReplayHeaders();
            return await EditFeedReplayWithOptionsAsync(feedId, request, headers, runtime);
        }

        public EditFeedReplayResponse EditFeedReplayWithOptions(string feedId, EditFeedReplayRequest request, EditFeedReplayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditStartTime))
            {
                body["editStartTime"] = request.EditStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditEndTime))
            {
                body["editEndTime"] = request.EditEndTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<EditFeedReplayResponse>(DoROARequest("EditFeedReplay", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId + "/cutReplay", "json", req, runtime));
        }

        public async Task<EditFeedReplayResponse> EditFeedReplayWithOptionsAsync(string feedId, EditFeedReplayRequest request, EditFeedReplayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditStartTime))
            {
                body["editStartTime"] = request.EditStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditEndTime))
            {
                body["editEndTime"] = request.EditEndTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<EditFeedReplayResponse>(await DoROARequestAsync("EditFeedReplay", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId + "/cutReplay", "json", req, runtime));
        }

        public QueryFeedWhiteListResponse QueryFeedWhiteList(string feedId, QueryFeedWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFeedWhiteListHeaders headers = new QueryFeedWhiteListHeaders();
            return QueryFeedWhiteListWithOptions(feedId, request, headers, runtime);
        }

        public async Task<QueryFeedWhiteListResponse> QueryFeedWhiteListAsync(string feedId, QueryFeedWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFeedWhiteListHeaders headers = new QueryFeedWhiteListHeaders();
            return await QueryFeedWhiteListWithOptionsAsync(feedId, request, headers, runtime);
        }

        public QueryFeedWhiteListResponse QueryFeedWhiteListWithOptions(string feedId, QueryFeedWhiteListRequest request, QueryFeedWhiteListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryFeedWhiteListResponse>(DoROARequest("QueryFeedWhiteList", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/openFeeds/" + feedId + "/whiteList", "json", req, runtime));
        }

        public async Task<QueryFeedWhiteListResponse> QueryFeedWhiteListWithOptionsAsync(string feedId, QueryFeedWhiteListRequest request, QueryFeedWhiteListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryFeedWhiteListResponse>(await DoROARequestAsync("QueryFeedWhiteList", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/openFeeds/" + feedId + "/whiteList", "json", req, runtime));
        }

        public CreateCloudFeedResponse CreateCloudFeed(CreateCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCloudFeedHeaders headers = new CreateCloudFeedHeaders();
            return CreateCloudFeedWithOptions(request, headers, runtime);
        }

        public async Task<CreateCloudFeedResponse> CreateCloudFeedAsync(CreateCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCloudFeedHeaders headers = new CreateCloudFeedHeaders();
            return await CreateCloudFeedWithOptionsAsync(request, headers, runtime);
        }

        public CreateCloudFeedResponse CreateCloudFeedWithOptions(CreateCloudFeedRequest request, CreateCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateCloudFeedResponse>(DoROARequest("CreateCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds", "json", req, runtime));
        }

        public async Task<CreateCloudFeedResponse> CreateCloudFeedWithOptionsAsync(CreateCloudFeedRequest request, CreateCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateCloudFeedResponse>(await DoROARequestAsync("CreateCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds", "json", req, runtime));
        }

        public DeleteLiveFeedResponse DeleteLiveFeed(string feedId, DeleteLiveFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLiveFeedHeaders headers = new DeleteLiveFeedHeaders();
            return DeleteLiveFeedWithOptions(feedId, request, headers, runtime);
        }

        public async Task<DeleteLiveFeedResponse> DeleteLiveFeedAsync(string feedId, DeleteLiveFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLiveFeedHeaders headers = new DeleteLiveFeedHeaders();
            return await DeleteLiveFeedWithOptionsAsync(feedId, request, headers, runtime);
        }

        public DeleteLiveFeedResponse DeleteLiveFeedWithOptions(string feedId, DeleteLiveFeedRequest request, DeleteLiveFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteLiveFeedResponse>(DoROARequest("DeleteLiveFeed", "live_1.0", "HTTP", "DELETE", "AK", "/v1.0/live/openFeeds/" + feedId, "json", req, runtime));
        }

        public async Task<DeleteLiveFeedResponse> DeleteLiveFeedWithOptionsAsync(string feedId, DeleteLiveFeedRequest request, DeleteLiveFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteLiveFeedResponse>(await DoROARequestAsync("DeleteLiveFeed", "live_1.0", "HTTP", "DELETE", "AK", "/v1.0/live/openFeeds/" + feedId, "json", req, runtime));
        }

        public StartCloudFeedResponse StartCloudFeed(string feedId, StartCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudFeedHeaders headers = new StartCloudFeedHeaders();
            return StartCloudFeedWithOptions(feedId, request, headers, runtime);
        }

        public async Task<StartCloudFeedResponse> StartCloudFeedAsync(string feedId, StartCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudFeedHeaders headers = new StartCloudFeedHeaders();
            return await StartCloudFeedWithOptionsAsync(feedId, request, headers, runtime);
        }

        public StartCloudFeedResponse StartCloudFeedWithOptions(string feedId, StartCloudFeedRequest request, StartCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StartCloudFeedResponse>(DoROARequest("StartCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/start", "json", req, runtime));
        }

        public async Task<StartCloudFeedResponse> StartCloudFeedWithOptionsAsync(string feedId, StartCloudFeedRequest request, StartCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StartCloudFeedResponse>(await DoROARequestAsync("StartCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/start", "json", req, runtime));
        }

        public StopCloudFeedResponse StopCloudFeed(string feedId, StopCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudFeedHeaders headers = new StopCloudFeedHeaders();
            return StopCloudFeedWithOptions(feedId, request, headers, runtime);
        }

        public async Task<StopCloudFeedResponse> StopCloudFeedAsync(string feedId, StopCloudFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudFeedHeaders headers = new StopCloudFeedHeaders();
            return await StopCloudFeedWithOptionsAsync(feedId, request, headers, runtime);
        }

        public StopCloudFeedResponse StopCloudFeedWithOptions(string feedId, StopCloudFeedRequest request, StopCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StopCloudFeedResponse>(DoROARequest("StopCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/stop", "json", req, runtime));
        }

        public async Task<StopCloudFeedResponse> StopCloudFeedWithOptionsAsync(string feedId, StopCloudFeedRequest request, StopCloudFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StopCloudFeedResponse>(await DoROARequestAsync("StopCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/stop", "json", req, runtime));
        }

        public ModifyFeedWhiteListResponse ModifyFeedWhiteList(string feedId, ModifyFeedWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyFeedWhiteListHeaders headers = new ModifyFeedWhiteListHeaders();
            return ModifyFeedWhiteListWithOptions(feedId, request, headers, runtime);
        }

        public async Task<ModifyFeedWhiteListResponse> ModifyFeedWhiteListAsync(string feedId, ModifyFeedWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyFeedWhiteListHeaders headers = new ModifyFeedWhiteListHeaders();
            return await ModifyFeedWhiteListWithOptionsAsync(feedId, request, headers, runtime);
        }

        public ModifyFeedWhiteListResponse ModifyFeedWhiteListWithOptions(string feedId, ModifyFeedWhiteListRequest tmpReq, ModifyFeedWhiteListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
            ModifyFeedWhiteListShrinkRequest request = new ModifyFeedWhiteListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModifyUserList))
            {
                request.ModifyUserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModifyUserList, "modifyUserList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyUserListShrink))
            {
                query["modifyUserList"] = request.ModifyUserListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ModifyFeedWhiteListResponse>(DoROARequest("ModifyFeedWhiteList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId + "/whiteList", "json", req, runtime));
        }

        public async Task<ModifyFeedWhiteListResponse> ModifyFeedWhiteListWithOptionsAsync(string feedId, ModifyFeedWhiteListRequest tmpReq, ModifyFeedWhiteListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
            ModifyFeedWhiteListShrinkRequest request = new ModifyFeedWhiteListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModifyUserList))
            {
                request.ModifyUserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModifyUserList, "modifyUserList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyUserListShrink))
            {
                query["modifyUserList"] = request.ModifyUserListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ModifyFeedWhiteListResponse>(await DoROARequestAsync("ModifyFeedWhiteList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId + "/whiteList", "json", req, runtime));
        }

        public UpdateLiveFeedResponse UpdateLiveFeed(string feedId, UpdateLiveFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveFeedHeaders headers = new UpdateLiveFeedHeaders();
            return UpdateLiveFeedWithOptions(feedId, request, headers, runtime);
        }

        public async Task<UpdateLiveFeedResponse> UpdateLiveFeedAsync(string feedId, UpdateLiveFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveFeedHeaders headers = new UpdateLiveFeedHeaders();
            return await UpdateLiveFeedWithOptionsAsync(feedId, request, headers, runtime);
        }

        public UpdateLiveFeedResponse UpdateLiveFeedWithOptions(string feedId, UpdateLiveFeedRequest request, UpdateLiveFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                query["introduction"] = request.Introduction;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateLiveFeedResponse>(DoROARequest("UpdateLiveFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId, "json", req, runtime));
        }

        public async Task<UpdateLiveFeedResponse> UpdateLiveFeedWithOptionsAsync(string feedId, UpdateLiveFeedRequest request, UpdateLiveFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                query["introduction"] = request.Introduction;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateLiveFeedResponse>(await DoROARequestAsync("UpdateLiveFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId, "json", req, runtime));
        }

        public AddShareCidListResponse AddShareCidList(string feedId, AddShareCidListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddShareCidListHeaders headers = new AddShareCidListHeaders();
            return AddShareCidListWithOptions(feedId, request, headers, runtime);
        }

        public async Task<AddShareCidListResponse> AddShareCidListAsync(string feedId, AddShareCidListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddShareCidListHeaders headers = new AddShareCidListHeaders();
            return await AddShareCidListWithOptionsAsync(feedId, request, headers, runtime);
        }

        public AddShareCidListResponse AddShareCidListWithOptions(string feedId, AddShareCidListRequest request, AddShareCidListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdType))
            {
                body["groupIdType"] = request.GroupIdType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddShareCidListResponse>(DoROARequest("AddShareCidList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/share", "json", req, runtime));
        }

        public async Task<AddShareCidListResponse> AddShareCidListWithOptionsAsync(string feedId, AddShareCidListRequest request, AddShareCidListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdType))
            {
                body["groupIdType"] = request.GroupIdType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddShareCidListResponse>(await DoROARequestAsync("AddShareCidList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/share", "json", req, runtime));
        }

    }
}
