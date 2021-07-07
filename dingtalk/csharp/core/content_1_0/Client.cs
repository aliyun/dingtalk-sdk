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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public GetMediaCerficateResponse GetMediaCerficate(GetMediaCerficateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMediaCerficateHeaders headers = new GetMediaCerficateHeaders();
            return GetMediaCerficateWithOptions(request, headers, runtime);
        }

        public async Task<GetMediaCerficateResponse> GetMediaCerficateAsync(GetMediaCerficateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMediaCerficateHeaders headers = new GetMediaCerficateHeaders();
            return await GetMediaCerficateWithOptionsAsync(request, headers, runtime);
        }

        public GetMediaCerficateResponse GetMediaCerficateWithOptions(GetMediaCerficateRequest request, GetMediaCerficateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbUrl))
            {
                query["thumbUrl"] = request.ThumbUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTitle))
            {
                query["mediaTitle"] = request.MediaTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McnId))
            {
                query["mcnId"] = request.McnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIntroduction))
            {
                query["mediaIntroduction"] = request.MediaIntroduction;
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
            return TeaModel.ToObject<GetMediaCerficateResponse>(DoROARequest("GetMediaCerficate", "content_1.0", "HTTP", "GET", "AK", "/v1.0/content/media/cerficates", "json", req, runtime));
        }

        public async Task<GetMediaCerficateResponse> GetMediaCerficateWithOptionsAsync(GetMediaCerficateRequest request, GetMediaCerficateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbUrl))
            {
                query["thumbUrl"] = request.ThumbUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTitle))
            {
                query["mediaTitle"] = request.MediaTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McnId))
            {
                query["mcnId"] = request.McnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIntroduction))
            {
                query["mediaIntroduction"] = request.MediaIntroduction;
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
            return TeaModel.ToObject<GetMediaCerficateResponse>(await DoROARequestAsync("GetMediaCerficate", "content_1.0", "HTTP", "GET", "AK", "/v1.0/content/media/cerficates", "json", req, runtime));
        }

        public CreateFeedResponse CreateFeed(CreateFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFeedHeaders headers = new CreateFeedHeaders();
            return CreateFeedWithOptions(request, headers, runtime);
        }

        public async Task<CreateFeedResponse> CreateFeedAsync(CreateFeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFeedHeaders headers = new CreateFeedHeaders();
            return await CreateFeedWithOptionsAsync(request, headers, runtime);
        }

        public CreateFeedResponse CreateFeedWithOptions(CreateFeedRequest request, CreateFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseInfo.ToMap()))
            {
                body["courseInfo"] = request.CourseInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedInfo.ToMap()))
            {
                body["feedInfo"] = request.FeedInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["createUserId"] = request.CreateUserId;
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
            return TeaModel.ToObject<CreateFeedResponse>(DoROARequest("CreateFeed", "content_1.0", "HTTP", "POST", "AK", "/v1.0/content/feeds", "json", req, runtime));
        }

        public async Task<CreateFeedResponse> CreateFeedWithOptionsAsync(CreateFeedRequest request, CreateFeedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseInfo.ToMap()))
            {
                body["courseInfo"] = request.CourseInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedInfo.ToMap()))
            {
                body["feedInfo"] = request.FeedInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["createUserId"] = request.CreateUserId;
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
            return TeaModel.ToObject<CreateFeedResponse>(await DoROARequestAsync("CreateFeed", "content_1.0", "HTTP", "POST", "AK", "/v1.0/content/feeds", "json", req, runtime));
        }

    }
}
