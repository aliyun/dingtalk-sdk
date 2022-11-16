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
            return TeaModel.ToObject<AddShareCidListResponse>(DoROARequest("AddShareCidList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/share", "json", req, runtime));
        }

        public async Task<AddShareCidListResponse> AddShareCidListWithOptionsAsync(string feedId, AddShareCidListRequest request, AddShareCidListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
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
            return TeaModel.ToObject<AddShareCidListResponse>(await DoROARequestAsync("AddShareCidList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/share", "json", req, runtime));
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
            return TeaModel.ToObject<CreateCloudFeedResponse>(DoROARequest("CreateCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreateCloudFeedResponse>(await DoROARequestAsync("CreateCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds", "json", req, runtime));
        }

        public CreateLiveResponse CreateLive(CreateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateLiveHeaders headers = new CreateLiveHeaders();
            return CreateLiveWithOptions(request, headers, runtime);
        }

        public async Task<CreateLiveResponse> CreateLiveAsync(CreateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateLiveHeaders headers = new CreateLiveHeaders();
            return await CreateLiveWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<CreateLiveResponse>(DoROARequest("CreateLive", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/lives", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreateLiveResponse>(await DoROARequestAsync("CreateLive", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/lives", "json", req, runtime));
        }

        public DeleteLiveResponse DeleteLive(DeleteLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLiveHeaders headers = new DeleteLiveHeaders();
            return DeleteLiveWithOptions(request, headers, runtime);
        }

        public async Task<DeleteLiveResponse> DeleteLiveAsync(DeleteLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLiveHeaders headers = new DeleteLiveHeaders();
            return await DeleteLiveWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<DeleteLiveResponse>(DoROARequest("DeleteLive", "live_1.0", "HTTP", "DELETE", "AK", "/v1.0/live/lives", "json", req, runtime));
        }

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
            return TeaModel.ToObject<DeleteLiveResponse>(await DoROARequestAsync("DeleteLive", "live_1.0", "HTTP", "DELETE", "AK", "/v1.0/live/lives", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteLiveFeedResponse>(await DoROARequestAsync("DeleteLiveFeed", "live_1.0", "HTTP", "DELETE", "AK", "/v1.0/live/openFeeds/" + feedId, "json", req, runtime));
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
            return TeaModel.ToObject<EditFeedReplayResponse>(DoROARequest("EditFeedReplay", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId + "/cutReplay", "json", req, runtime));
        }

        public async Task<EditFeedReplayResponse> EditFeedReplayWithOptionsAsync(string feedId, EditFeedReplayRequest request, EditFeedReplayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
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
            return TeaModel.ToObject<EditFeedReplayResponse>(await DoROARequestAsync("EditFeedReplay", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId + "/cutReplay", "json", req, runtime));
        }

        public GetUserAllLiveListResponse GetUserAllLiveList(GetUserAllLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAllLiveListHeaders headers = new GetUserAllLiveListHeaders();
            return GetUserAllLiveListWithOptions(request, headers, runtime);
        }

        public async Task<GetUserAllLiveListResponse> GetUserAllLiveListAsync(GetUserAllLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAllLiveListHeaders headers = new GetUserAllLiveListHeaders();
            return await GetUserAllLiveListWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetUserAllLiveListResponse>(DoROARequest("GetUserAllLiveList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/users/allLiveInfos/query", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetUserAllLiveListResponse>(await DoROARequestAsync("GetUserAllLiveList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/users/allLiveInfos/query", "json", req, runtime));
        }

        public GetUserCreateLiveListResponse GetUserCreateLiveList(GetUserCreateLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserCreateLiveListHeaders headers = new GetUserCreateLiveListHeaders();
            return GetUserCreateLiveListWithOptions(request, headers, runtime);
        }

        public async Task<GetUserCreateLiveListResponse> GetUserCreateLiveListAsync(GetUserCreateLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserCreateLiveListHeaders headers = new GetUserCreateLiveListHeaders();
            return await GetUserCreateLiveListWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetUserCreateLiveListResponse>(DoROARequest("GetUserCreateLiveList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/users/createLiveInfos/query", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetUserCreateLiveListResponse>(await DoROARequestAsync("GetUserCreateLiveList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/users/createLiveInfos/query", "json", req, runtime));
        }

        public GetUserWatchLiveListResponse GetUserWatchLiveList(GetUserWatchLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserWatchLiveListHeaders headers = new GetUserWatchLiveListHeaders();
            return GetUserWatchLiveListWithOptions(request, headers, runtime);
        }

        public async Task<GetUserWatchLiveListResponse> GetUserWatchLiveListAsync(GetUserWatchLiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserWatchLiveListHeaders headers = new GetUserWatchLiveListHeaders();
            return await GetUserWatchLiveListWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetUserWatchLiveListResponse>(DoROARequest("GetUserWatchLiveList", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/users/watchRecords", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetUserWatchLiveListResponse>(await DoROARequestAsync("GetUserWatchLiveList", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/users/watchRecords", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyFeedWhiteListResponse>(await DoROARequestAsync("ModifyFeedWhiteList", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId + "/whiteList", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryFeedWhiteListResponse>(await DoROARequestAsync("QueryFeedWhiteList", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/openFeeds/" + feedId + "/whiteList", "json", req, runtime));
        }

        public QueryLiveInfoResponse QueryLiveInfo(QueryLiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveInfoHeaders headers = new QueryLiveInfoHeaders();
            return QueryLiveInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryLiveInfoResponse> QueryLiveInfoAsync(QueryLiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveInfoHeaders headers = new QueryLiveInfoHeaders();
            return await QueryLiveInfoWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<QueryLiveInfoResponse>(DoROARequest("QueryLiveInfo", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/lives", "json", req, runtime));
        }

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
            return TeaModel.ToObject<QueryLiveInfoResponse>(await DoROARequestAsync("QueryLiveInfo", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/lives", "json", req, runtime));
        }

        public QueryLiveWatchDetailResponse QueryLiveWatchDetail(QueryLiveWatchDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchDetailHeaders headers = new QueryLiveWatchDetailHeaders();
            return QueryLiveWatchDetailWithOptions(request, headers, runtime);
        }

        public async Task<QueryLiveWatchDetailResponse> QueryLiveWatchDetailAsync(QueryLiveWatchDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchDetailHeaders headers = new QueryLiveWatchDetailHeaders();
            return await QueryLiveWatchDetailWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<QueryLiveWatchDetailResponse>(DoROARequest("QueryLiveWatchDetail", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/lives/watchDetails", "json", req, runtime));
        }

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
            return TeaModel.ToObject<QueryLiveWatchDetailResponse>(await DoROARequestAsync("QueryLiveWatchDetail", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/lives/watchDetails", "json", req, runtime));
        }

        public QueryLiveWatchUserListResponse QueryLiveWatchUserList(QueryLiveWatchUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchUserListHeaders headers = new QueryLiveWatchUserListHeaders();
            return QueryLiveWatchUserListWithOptions(request, headers, runtime);
        }

        public async Task<QueryLiveWatchUserListResponse> QueryLiveWatchUserListAsync(QueryLiveWatchUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchUserListHeaders headers = new QueryLiveWatchUserListHeaders();
            return await QueryLiveWatchUserListWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<QueryLiveWatchUserListResponse>(DoROARequest("QueryLiveWatchUserList", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/lives/watchUsers", "json", req, runtime));
        }

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
            return TeaModel.ToObject<QueryLiveWatchUserListResponse>(await DoROARequestAsync("QueryLiveWatchUserList", "live_1.0", "HTTP", "GET", "AK", "/v1.0/live/lives/watchUsers", "json", req, runtime));
        }

        public QuerySubscribeStatusResponse QuerySubscribeStatus(QuerySubscribeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySubscribeStatusHeaders headers = new QuerySubscribeStatusHeaders();
            return QuerySubscribeStatusWithOptions(request, headers, runtime);
        }

        public async Task<QuerySubscribeStatusResponse> QuerySubscribeStatusAsync(QuerySubscribeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySubscribeStatusHeaders headers = new QuerySubscribeStatusHeaders();
            return await QuerySubscribeStatusWithOptionsAsync(request, headers, runtime);
        }

        public QuerySubscribeStatusResponse QuerySubscribeStatusWithOptions(QuerySubscribeStatusRequest tmpReq, QuerySubscribeStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySubscribeStatusShrinkRequest request = new QuerySubscribeStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body.ToMap()))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body.ToMap(), "body", "json");
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
            return TeaModel.ToObject<QuerySubscribeStatusResponse>(DoROARequest("QuerySubscribeStatus", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/subscribeStatuses/query", "json", req, runtime));
        }

        public async Task<QuerySubscribeStatusResponse> QuerySubscribeStatusWithOptionsAsync(QuerySubscribeStatusRequest tmpReq, QuerySubscribeStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySubscribeStatusShrinkRequest request = new QuerySubscribeStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body.ToMap()))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body.ToMap(), "body", "json");
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
            return TeaModel.ToObject<QuerySubscribeStatusResponse>(await DoROARequestAsync("QuerySubscribeStatus", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/subscribeStatuses/query", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StopCloudFeedResponse>(await DoROARequestAsync("StopCloudFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/cloudFeeds/" + feedId + "/stop", "json", req, runtime));
        }

        public SubscribeLiveResponse SubscribeLive(SubscribeLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeLiveHeaders headers = new SubscribeLiveHeaders();
            return SubscribeLiveWithOptions(request, headers, runtime);
        }

        public async Task<SubscribeLiveResponse> SubscribeLiveAsync(SubscribeLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeLiveHeaders headers = new SubscribeLiveHeaders();
            return await SubscribeLiveWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<SubscribeLiveResponse>(DoROARequest("SubscribeLive", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/lives/subscribe", "json", req, runtime));
        }

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
            return TeaModel.ToObject<SubscribeLiveResponse>(await DoROARequestAsync("SubscribeLive", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/lives/subscribe", "json", req, runtime));
        }

        public UpdateLiveResponse UpdateLive(UpdateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveHeaders headers = new UpdateLiveHeaders();
            return UpdateLiveWithOptions(request, headers, runtime);
        }

        public async Task<UpdateLiveResponse> UpdateLiveAsync(UpdateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveHeaders headers = new UpdateLiveHeaders();
            return await UpdateLiveWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UpdateLiveResponse>(DoROARequest("UpdateLive", "live_1.0", "HTTP", "PUT", "AK", "/v1.0/live/lives", "json", req, runtime));
        }

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
            return TeaModel.ToObject<UpdateLiveResponse>(await DoROARequestAsync("UpdateLive", "live_1.0", "HTTP", "PUT", "AK", "/v1.0/live/lives", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateLiveFeedResponse>(DoROARequest("UpdateLiveFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId, "json", req, runtime));
        }

        public async Task<UpdateLiveFeedResponse> UpdateLiveFeedWithOptionsAsync(string feedId, UpdateLiveFeedRequest request, UpdateLiveFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            feedId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(feedId);
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
            return TeaModel.ToObject<UpdateLiveFeedResponse>(await DoROARequestAsync("UpdateLiveFeed", "live_1.0", "HTTP", "POST", "AK", "/v1.0/live/openFeeds/" + feedId, "json", req, runtime));
        }

    }
}
