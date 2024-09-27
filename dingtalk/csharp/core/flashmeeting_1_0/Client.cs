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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
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
        /// <para>创建钉闪会并绑定日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlashMeetingRequest
        /// </param>
        /// <param name="headers">
        /// CreateFlashMeetingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlashMeetingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉闪会并绑定日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlashMeetingRequest
        /// </param>
        /// <param name="headers">
        /// CreateFlashMeetingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlashMeetingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉闪会并绑定日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlashMeetingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlashMeetingResponse
        /// </returns>
        public CreateFlashMeetingResponse CreateFlashMeeting(CreateFlashMeetingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFlashMeetingHeaders headers = new CreateFlashMeetingHeaders();
            return CreateFlashMeetingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉闪会并绑定日程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlashMeetingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlashMeetingResponse
        /// </returns>
        public async Task<CreateFlashMeetingResponse> CreateFlashMeetingAsync(CreateFlashMeetingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFlashMeetingHeaders headers = new CreateFlashMeetingHeaders();
            return await CreateFlashMeetingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据日程获取闪会的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetShanhuiByCalendarRequest
        /// </param>
        /// <param name="headers">
        /// GetShanhuiByCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetShanhuiByCalendarResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据日程获取闪会的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetShanhuiByCalendarRequest
        /// </param>
        /// <param name="headers">
        /// GetShanhuiByCalendarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetShanhuiByCalendarResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据日程获取闪会的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetShanhuiByCalendarRequest
        /// </param>
        /// 
        /// <returns>
        /// GetShanhuiByCalendarResponse
        /// </returns>
        public GetShanhuiByCalendarResponse GetShanhuiByCalendar(GetShanhuiByCalendarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShanhuiByCalendarHeaders headers = new GetShanhuiByCalendarHeaders();
            return GetShanhuiByCalendarWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据日程获取闪会的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetShanhuiByCalendarRequest
        /// </param>
        /// 
        /// <returns>
        /// GetShanhuiByCalendarResponse
        /// </returns>
        public async Task<GetShanhuiByCalendarResponse> GetShanhuiByCalendarAsync(GetShanhuiByCalendarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShanhuiByCalendarHeaders headers = new GetShanhuiByCalendarHeaders();
            return await GetShanhuiByCalendarWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetShanhuiByShanhuiKeyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetShanhuiByShanhuiKeyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetShanhuiByShanhuiKeyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetShanhuiByShanhuiKeyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetShanhuiByShanhuiKeyResponse
        /// </returns>
        public GetShanhuiByShanhuiKeyResponse GetShanhuiByShanhuiKey(string flashmeetingKey)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShanhuiByShanhuiKeyHeaders headers = new GetShanhuiByShanhuiKeyHeaders();
            return GetShanhuiByShanhuiKeyWithOptions(flashmeetingKey, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetShanhuiByShanhuiKeyResponse
        /// </returns>
        public async Task<GetShanhuiByShanhuiKeyResponse> GetShanhuiByShanhuiKeyAsync(string flashmeetingKey)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShanhuiByShanhuiKeyHeaders headers = new GetShanhuiByShanhuiKeyHeaders();
            return await GetShanhuiByShanhuiKeyWithOptionsAsync(flashmeetingKey, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据闪会文档id获取待办任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskFromShanhuiDocRequest
        /// </param>
        /// <param name="headers">
        /// GetTaskFromShanhuiDocHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskFromShanhuiDocResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据闪会文档id获取待办任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskFromShanhuiDocRequest
        /// </param>
        /// <param name="headers">
        /// GetTaskFromShanhuiDocHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskFromShanhuiDocResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据闪会文档id获取待办任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskFromShanhuiDocRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskFromShanhuiDocResponse
        /// </returns>
        public GetTaskFromShanhuiDocResponse GetTaskFromShanhuiDoc(GetTaskFromShanhuiDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskFromShanhuiDocHeaders headers = new GetTaskFromShanhuiDocHeaders();
            return GetTaskFromShanhuiDocWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据闪会文档id获取待办任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskFromShanhuiDocRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskFromShanhuiDocResponse
        /// </returns>
        public async Task<GetTaskFromShanhuiDocResponse> GetTaskFromShanhuiDocAsync(GetTaskFromShanhuiDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskFromShanhuiDocHeaders headers = new GetTaskFromShanhuiDocHeaders();
            return await GetTaskFromShanhuiDocWithOptionsAsync(request, headers, runtime);
        }

    }
}
