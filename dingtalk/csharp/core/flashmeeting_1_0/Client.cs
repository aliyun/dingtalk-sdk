// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkflashmeeting_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkflashmeeting_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 创建钉闪会并绑定日程
         *
         * @param request CreateFlashMeetingRequest
         * @param headers CreateFlashMeetingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFlashMeetingResponse
         */
        public CreateFlashMeetingResponse CreateFlashMeetingWithOptions(CreateFlashMeetingRequest request, CreateFlashMeetingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["eventId"] = request.EventId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlashMeeting",
                Version = "flashmeeting_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmeeting/meetings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlashMeetingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建钉闪会并绑定日程
         *
         * @param request CreateFlashMeetingRequest
         * @param headers CreateFlashMeetingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFlashMeetingResponse
         */
        public async Task<CreateFlashMeetingResponse> CreateFlashMeetingWithOptionsAsync(CreateFlashMeetingRequest request, CreateFlashMeetingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["eventId"] = request.EventId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlashMeeting",
                Version = "flashmeeting_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmeeting/meetings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlashMeetingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建钉闪会并绑定日程
         *
         * @param request CreateFlashMeetingRequest
         * @return CreateFlashMeetingResponse
         */
        public CreateFlashMeetingResponse CreateFlashMeeting(CreateFlashMeetingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFlashMeetingHeaders headers = new CreateFlashMeetingHeaders();
            return CreateFlashMeetingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建钉闪会并绑定日程
         *
         * @param request CreateFlashMeetingRequest
         * @return CreateFlashMeetingResponse
         */
        public async Task<CreateFlashMeetingResponse> CreateFlashMeetingAsync(CreateFlashMeetingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFlashMeetingHeaders headers = new CreateFlashMeetingHeaders();
            return await CreateFlashMeetingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据日程获取闪会的信息
         *
         * @param request GetShanhuiByCalendarRequest
         * @param headers GetShanhuiByCalendarHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShanhuiByCalendarResponse
         */
        public GetShanhuiByCalendarResponse GetShanhuiByCalendarWithOptions(GetShanhuiByCalendarRequest request, GetShanhuiByCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["eventId"] = request.EventId;
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
                Action = "GetShanhuiByCalendar",
                Version = "flashmeeting_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmeeting/calendars/meeting",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShanhuiByCalendarResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据日程获取闪会的信息
         *
         * @param request GetShanhuiByCalendarRequest
         * @param headers GetShanhuiByCalendarHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShanhuiByCalendarResponse
         */
        public async Task<GetShanhuiByCalendarResponse> GetShanhuiByCalendarWithOptionsAsync(GetShanhuiByCalendarRequest request, GetShanhuiByCalendarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["eventId"] = request.EventId;
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
                Action = "GetShanhuiByCalendar",
                Version = "flashmeeting_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmeeting/calendars/meeting",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShanhuiByCalendarResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据日程获取闪会的信息
         *
         * @param request GetShanhuiByCalendarRequest
         * @return GetShanhuiByCalendarResponse
         */
        public GetShanhuiByCalendarResponse GetShanhuiByCalendar(GetShanhuiByCalendarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShanhuiByCalendarHeaders headers = new GetShanhuiByCalendarHeaders();
            return GetShanhuiByCalendarWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据日程获取闪会的信息
         *
         * @param request GetShanhuiByCalendarRequest
         * @return GetShanhuiByCalendarResponse
         */
        public async Task<GetShanhuiByCalendarResponse> GetShanhuiByCalendarAsync(GetShanhuiByCalendarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShanhuiByCalendarHeaders headers = new GetShanhuiByCalendarHeaders();
            return await GetShanhuiByCalendarWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
         *
         * @param headers GetShanhuiByShanhuiKeyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShanhuiByShanhuiKeyResponse
         */
        public GetShanhuiByShanhuiKeyResponse GetShanhuiByShanhuiKeyWithOptions(string flashmeetingKey, GetShanhuiByShanhuiKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShanhuiByShanhuiKey",
                Version = "flashmeeting_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmeeting/meetings/keys/" + flashmeetingKey + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShanhuiByShanhuiKeyResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
         *
         * @param headers GetShanhuiByShanhuiKeyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShanhuiByShanhuiKeyResponse
         */
        public async Task<GetShanhuiByShanhuiKeyResponse> GetShanhuiByShanhuiKeyWithOptionsAsync(string flashmeetingKey, GetShanhuiByShanhuiKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShanhuiByShanhuiKey",
                Version = "flashmeeting_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmeeting/meetings/keys/" + flashmeetingKey + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShanhuiByShanhuiKeyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
         *
         * @return GetShanhuiByShanhuiKeyResponse
         */
        public GetShanhuiByShanhuiKeyResponse GetShanhuiByShanhuiKey(string flashmeetingKey)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShanhuiByShanhuiKeyHeaders headers = new GetShanhuiByShanhuiKeyHeaders();
            return GetShanhuiByShanhuiKeyWithOptions(flashmeetingKey, headers, runtime);
        }

        /**
         * @summary 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
         *
         * @return GetShanhuiByShanhuiKeyResponse
         */
        public async Task<GetShanhuiByShanhuiKeyResponse> GetShanhuiByShanhuiKeyAsync(string flashmeetingKey)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShanhuiByShanhuiKeyHeaders headers = new GetShanhuiByShanhuiKeyHeaders();
            return await GetShanhuiByShanhuiKeyWithOptionsAsync(flashmeetingKey, headers, runtime);
        }

        /**
         * @summary 根据闪会文档id获取待办任务
         *
         * @param request GetTaskFromShanhuiDocRequest
         * @param headers GetTaskFromShanhuiDocHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskFromShanhuiDocResponse
         */
        public GetTaskFromShanhuiDocResponse GetTaskFromShanhuiDocWithOptions(GetTaskFromShanhuiDocRequest request, GetTaskFromShanhuiDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocKey))
            {
                query["docKey"] = request.DocKey;
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
                Action = "GetTaskFromShanhuiDoc",
                Version = "flashmeeting_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmeeting/meetings/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskFromShanhuiDocResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据闪会文档id获取待办任务
         *
         * @param request GetTaskFromShanhuiDocRequest
         * @param headers GetTaskFromShanhuiDocHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskFromShanhuiDocResponse
         */
        public async Task<GetTaskFromShanhuiDocResponse> GetTaskFromShanhuiDocWithOptionsAsync(GetTaskFromShanhuiDocRequest request, GetTaskFromShanhuiDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocKey))
            {
                query["docKey"] = request.DocKey;
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
                Action = "GetTaskFromShanhuiDoc",
                Version = "flashmeeting_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmeeting/meetings/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskFromShanhuiDocResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据闪会文档id获取待办任务
         *
         * @param request GetTaskFromShanhuiDocRequest
         * @return GetTaskFromShanhuiDocResponse
         */
        public GetTaskFromShanhuiDocResponse GetTaskFromShanhuiDoc(GetTaskFromShanhuiDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskFromShanhuiDocHeaders headers = new GetTaskFromShanhuiDocHeaders();
            return GetTaskFromShanhuiDocWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据闪会文档id获取待办任务
         *
         * @param request GetTaskFromShanhuiDocRequest
         * @return GetTaskFromShanhuiDocResponse
         */
        public async Task<GetTaskFromShanhuiDocResponse> GetTaskFromShanhuiDocAsync(GetTaskFromShanhuiDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskFromShanhuiDocHeaders headers = new GetTaskFromShanhuiDocHeaders();
            return await GetTaskFromShanhuiDocWithOptionsAsync(request, headers, runtime);
        }

    }
}
