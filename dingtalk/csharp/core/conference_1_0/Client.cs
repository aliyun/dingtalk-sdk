// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkconference_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0
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


        public QueryCloudRecordTextResponse QueryCloudRecordText(string conferenceId, QueryCloudRecordTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordTextHeaders headers = new QueryCloudRecordTextHeaders();
            return QueryCloudRecordTextWithOptions(conferenceId, request, headers, runtime);
        }

        public async Task<QueryCloudRecordTextResponse> QueryCloudRecordTextAsync(string conferenceId, QueryCloudRecordTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordTextHeaders headers = new QueryCloudRecordTextHeaders();
            return await QueryCloudRecordTextWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        public QueryCloudRecordTextResponse QueryCloudRecordTextWithOptions(string conferenceId, QueryCloudRecordTextRequest request, QueryCloudRecordTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCloudRecordTextResponse>(DoROARequest("QueryCloudRecordText", "conference_1.0", "HTTP", "GET", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getTexts", "json", req, runtime));
        }

        public async Task<QueryCloudRecordTextResponse> QueryCloudRecordTextWithOptionsAsync(string conferenceId, QueryCloudRecordTextRequest request, QueryCloudRecordTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCloudRecordTextResponse>(await DoROARequestAsync("QueryCloudRecordText", "conference_1.0", "HTTP", "GET", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getTexts", "json", req, runtime));
        }

        public CreateVideoConferenceResponse CreateVideoConference(CreateVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVideoConferenceHeaders headers = new CreateVideoConferenceHeaders();
            return CreateVideoConferenceWithOptions(request, headers, runtime);
        }

        public async Task<CreateVideoConferenceResponse> CreateVideoConferenceAsync(CreateVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVideoConferenceHeaders headers = new CreateVideoConferenceHeaders();
            return await CreateVideoConferenceWithOptionsAsync(request, headers, runtime);
        }

        public CreateVideoConferenceResponse CreateVideoConferenceWithOptions(CreateVideoConferenceRequest request, CreateVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfTitle))
            {
                body["confTitle"] = request.ConfTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteUserIds))
            {
                body["inviteUserIds"] = request.InviteUserIds;
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
            return TeaModel.ToObject<CreateVideoConferenceResponse>(DoROARequest("CreateVideoConference", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences", "json", req, runtime));
        }

        public async Task<CreateVideoConferenceResponse> CreateVideoConferenceWithOptionsAsync(CreateVideoConferenceRequest request, CreateVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfTitle))
            {
                body["confTitle"] = request.ConfTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteUserIds))
            {
                body["inviteUserIds"] = request.InviteUserIds;
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
            return TeaModel.ToObject<CreateVideoConferenceResponse>(await DoROARequestAsync("CreateVideoConference", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences", "json", req, runtime));
        }

        public QueryCloudRecordVideoPlayInfoResponse QueryCloudRecordVideoPlayInfo(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoPlayInfoHeaders headers = new QueryCloudRecordVideoPlayInfoHeaders();
            return QueryCloudRecordVideoPlayInfoWithOptions(conferenceId, request, headers, runtime);
        }

        public async Task<QueryCloudRecordVideoPlayInfoResponse> QueryCloudRecordVideoPlayInfoAsync(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoPlayInfoHeaders headers = new QueryCloudRecordVideoPlayInfoHeaders();
            return await QueryCloudRecordVideoPlayInfoWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        public QueryCloudRecordVideoPlayInfoResponse QueryCloudRecordVideoPlayInfoWithOptions(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request, QueryCloudRecordVideoPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
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
            return TeaModel.ToObject<QueryCloudRecordVideoPlayInfoResponse>(DoROARequest("QueryCloudRecordVideoPlayInfo", "conference_1.0", "HTTP", "GET", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/videos/getPlayInfos", "json", req, runtime));
        }

        public async Task<QueryCloudRecordVideoPlayInfoResponse> QueryCloudRecordVideoPlayInfoWithOptionsAsync(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request, QueryCloudRecordVideoPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
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
            return TeaModel.ToObject<QueryCloudRecordVideoPlayInfoResponse>(await DoROARequestAsync("QueryCloudRecordVideoPlayInfo", "conference_1.0", "HTTP", "GET", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/videos/getPlayInfos", "json", req, runtime));
        }

        public QueryConferenceInfoBatchResponse QueryConferenceInfoBatch(QueryConferenceInfoBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoBatchHeaders headers = new QueryConferenceInfoBatchHeaders();
            return QueryConferenceInfoBatchWithOptions(request, headers, runtime);
        }

        public async Task<QueryConferenceInfoBatchResponse> QueryConferenceInfoBatchAsync(QueryConferenceInfoBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoBatchHeaders headers = new QueryConferenceInfoBatchHeaders();
            return await QueryConferenceInfoBatchWithOptionsAsync(request, headers, runtime);
        }

        public QueryConferenceInfoBatchResponse QueryConferenceInfoBatchWithOptions(QueryConferenceInfoBatchRequest request, QueryConferenceInfoBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceIdList))
            {
                body["conferenceIdList"] = request.ConferenceIdList;
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
            return TeaModel.ToObject<QueryConferenceInfoBatchResponse>(DoROARequest("QueryConferenceInfoBatch", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/query", "json", req, runtime));
        }

        public async Task<QueryConferenceInfoBatchResponse> QueryConferenceInfoBatchWithOptionsAsync(QueryConferenceInfoBatchRequest request, QueryConferenceInfoBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceIdList))
            {
                body["conferenceIdList"] = request.ConferenceIdList;
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
            return TeaModel.ToObject<QueryConferenceInfoBatchResponse>(await DoROARequestAsync("QueryConferenceInfoBatch", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/query", "json", req, runtime));
        }

        public StopCloudRecordResponse StopCloudRecord(string conferenceId, StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudRecordHeaders headers = new StopCloudRecordHeaders();
            return StopCloudRecordWithOptions(conferenceId, request, headers, runtime);
        }

        public async Task<StopCloudRecordResponse> StopCloudRecordAsync(string conferenceId, StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudRecordHeaders headers = new StopCloudRecordHeaders();
            return await StopCloudRecordWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        public StopCloudRecordResponse StopCloudRecordWithOptions(string conferenceId, StopCloudRecordRequest request, StopCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StopCloudRecordResponse>(DoROARequest("StopCloudRecord", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/stop", "json", req, runtime));
        }

        public async Task<StopCloudRecordResponse> StopCloudRecordWithOptionsAsync(string conferenceId, StopCloudRecordRequest request, StopCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StopCloudRecordResponse>(await DoROARequestAsync("StopCloudRecord", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/stop", "json", req, runtime));
        }

        public UpdateVideoConferenceExtInfoResponse UpdateVideoConferenceExtInfo(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVideoConferenceExtInfoHeaders headers = new UpdateVideoConferenceExtInfoHeaders();
            return UpdateVideoConferenceExtInfoWithOptions(conferenceId, headers, runtime);
        }

        public async Task<UpdateVideoConferenceExtInfoResponse> UpdateVideoConferenceExtInfoAsync(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVideoConferenceExtInfoHeaders headers = new UpdateVideoConferenceExtInfoHeaders();
            return await UpdateVideoConferenceExtInfoWithOptionsAsync(conferenceId, headers, runtime);
        }

        public UpdateVideoConferenceExtInfoResponse UpdateVideoConferenceExtInfoWithOptions(string conferenceId, UpdateVideoConferenceExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
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
            };
            return TeaModel.ToObject<UpdateVideoConferenceExtInfoResponse>(DoROARequest("UpdateVideoConferenceExtInfo", "conference_1.0", "HTTP", "PUT", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/extInfo", "json", req, runtime));
        }

        public async Task<UpdateVideoConferenceExtInfoResponse> UpdateVideoConferenceExtInfoWithOptionsAsync(string conferenceId, UpdateVideoConferenceExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
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
            };
            return TeaModel.ToObject<UpdateVideoConferenceExtInfoResponse>(await DoROARequestAsync("UpdateVideoConferenceExtInfo", "conference_1.0", "HTTP", "PUT", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/extInfo", "json", req, runtime));
        }

        public CloseVideoConferenceResponse CloseVideoConference(string conferenceId, CloseVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseVideoConferenceHeaders headers = new CloseVideoConferenceHeaders();
            return CloseVideoConferenceWithOptions(conferenceId, request, headers, runtime);
        }

        public async Task<CloseVideoConferenceResponse> CloseVideoConferenceAsync(string conferenceId, CloseVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseVideoConferenceHeaders headers = new CloseVideoConferenceHeaders();
            return await CloseVideoConferenceWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        public CloseVideoConferenceResponse CloseVideoConferenceWithOptions(string conferenceId, CloseVideoConferenceRequest request, CloseVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CloseVideoConferenceResponse>(DoROARequest("CloseVideoConference", "conference_1.0", "HTTP", "DELETE", "AK", "/v1.0/conference/videoConferences/" + conferenceId, "json", req, runtime));
        }

        public async Task<CloseVideoConferenceResponse> CloseVideoConferenceWithOptionsAsync(string conferenceId, CloseVideoConferenceRequest request, CloseVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CloseVideoConferenceResponse>(await DoROARequestAsync("CloseVideoConference", "conference_1.0", "HTTP", "DELETE", "AK", "/v1.0/conference/videoConferences/" + conferenceId, "json", req, runtime));
        }

        public StopStreamOutResponse StopStreamOut(string conferenceId, StopStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopStreamOutHeaders headers = new StopStreamOutHeaders();
            return StopStreamOutWithOptions(conferenceId, request, headers, runtime);
        }

        public async Task<StopStreamOutResponse> StopStreamOutAsync(string conferenceId, StopStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopStreamOutHeaders headers = new StopStreamOutHeaders();
            return await StopStreamOutWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        public StopStreamOutResponse StopStreamOutWithOptions(string conferenceId, StopStreamOutRequest request, StopStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamId))
            {
                body["streamId"] = request.StreamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopAllStream))
            {
                body["stopAllStream"] = request.StopAllStream;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StopStreamOutResponse>(DoROARequest("StopStreamOut", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/stop", "json", req, runtime));
        }

        public async Task<StopStreamOutResponse> StopStreamOutWithOptionsAsync(string conferenceId, StopStreamOutRequest request, StopStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamId))
            {
                body["streamId"] = request.StreamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopAllStream))
            {
                body["stopAllStream"] = request.StopAllStream;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StopStreamOutResponse>(await DoROARequestAsync("StopStreamOut", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/stop", "json", req, runtime));
        }

        public StartCloudRecordResponse StartCloudRecord(string conferenceId, StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudRecordHeaders headers = new StartCloudRecordHeaders();
            return StartCloudRecordWithOptions(conferenceId, request, headers, runtime);
        }

        public async Task<StartCloudRecordResponse> StartCloudRecordAsync(string conferenceId, StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudRecordHeaders headers = new StartCloudRecordHeaders();
            return await StartCloudRecordWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        public StartCloudRecordResponse StartCloudRecordWithOptions(string conferenceId, StartCloudRecordRequest request, StartCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
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
            return TeaModel.ToObject<StartCloudRecordResponse>(DoROARequest("StartCloudRecord", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/start", "json", req, runtime));
        }

        public async Task<StartCloudRecordResponse> StartCloudRecordWithOptionsAsync(string conferenceId, StartCloudRecordRequest request, StartCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
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
            return TeaModel.ToObject<StartCloudRecordResponse>(await DoROARequestAsync("StartCloudRecord", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/start", "json", req, runtime));
        }

        public StartStreamOutResponse StartStreamOut(string conferenceId, StartStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartStreamOutHeaders headers = new StartStreamOutHeaders();
            return StartStreamOutWithOptions(conferenceId, request, headers, runtime);
        }

        public async Task<StartStreamOutResponse> StartStreamOutAsync(string conferenceId, StartStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartStreamOutHeaders headers = new StartStreamOutHeaders();
            return await StartStreamOutWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        public StartStreamOutResponse StartStreamOutWithOptions(string conferenceId, StartStreamOutRequest request, StartStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedHostJoin))
            {
                body["needHostJoin"] = request.NeedHostJoin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamUrlList))
            {
                body["streamUrlList"] = request.StreamUrlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamName))
            {
                body["streamName"] = request.StreamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
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
            return TeaModel.ToObject<StartStreamOutResponse>(DoROARequest("StartStreamOut", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/start", "json", req, runtime));
        }

        public async Task<StartStreamOutResponse> StartStreamOutWithOptionsAsync(string conferenceId, StartStreamOutRequest request, StartStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedHostJoin))
            {
                body["needHostJoin"] = request.NeedHostJoin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamUrlList))
            {
                body["streamUrlList"] = request.StreamUrlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamName))
            {
                body["streamName"] = request.StreamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
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
            return TeaModel.ToObject<StartStreamOutResponse>(await DoROARequestAsync("StartStreamOut", "conference_1.0", "HTTP", "POST", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/start", "json", req, runtime));
        }

        public QueryCloudRecordVideoResponse QueryCloudRecordVideo(string conferenceId, QueryCloudRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoHeaders headers = new QueryCloudRecordVideoHeaders();
            return QueryCloudRecordVideoWithOptions(conferenceId, request, headers, runtime);
        }

        public async Task<QueryCloudRecordVideoResponse> QueryCloudRecordVideoAsync(string conferenceId, QueryCloudRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoHeaders headers = new QueryCloudRecordVideoHeaders();
            return await QueryCloudRecordVideoWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        public QueryCloudRecordVideoResponse QueryCloudRecordVideoWithOptions(string conferenceId, QueryCloudRecordVideoRequest request, QueryCloudRecordVideoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCloudRecordVideoResponse>(DoROARequest("QueryCloudRecordVideo", "conference_1.0", "HTTP", "GET", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getVideos", "json", req, runtime));
        }

        public async Task<QueryCloudRecordVideoResponse> QueryCloudRecordVideoWithOptionsAsync(string conferenceId, QueryCloudRecordVideoRequest request, QueryCloudRecordVideoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCloudRecordVideoResponse>(await DoROARequestAsync("QueryCloudRecordVideo", "conference_1.0", "HTTP", "GET", "AK", "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getVideos", "json", req, runtime));
        }

    }
}
