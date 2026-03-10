// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkai_search_ask_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkai_search_ask_1_0
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
        /// <para>查询指定用户的全部已登录设备及其状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchLoginStatusDevicesRequest
        /// </param>
        /// <param name="headers">
        /// FetchLoginStatusDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchLoginStatusDevicesResponse
        /// </returns>
        public FetchLoginStatusDevicesResponse FetchLoginStatusDevicesWithOptions(FetchLoginStatusDevicesRequest request, FetchLoginStatusDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
                Action = "FetchLoginStatusDevices",
                Version = "aiSearchAsk_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiSearchAsk/fetchLoginStatusDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchLoginStatusDevicesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定用户的全部已登录设备及其状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchLoginStatusDevicesRequest
        /// </param>
        /// <param name="headers">
        /// FetchLoginStatusDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchLoginStatusDevicesResponse
        /// </returns>
        public async Task<FetchLoginStatusDevicesResponse> FetchLoginStatusDevicesWithOptionsAsync(FetchLoginStatusDevicesRequest request, FetchLoginStatusDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
                Action = "FetchLoginStatusDevices",
                Version = "aiSearchAsk_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiSearchAsk/fetchLoginStatusDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchLoginStatusDevicesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定用户的全部已登录设备及其状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchLoginStatusDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchLoginStatusDevicesResponse
        /// </returns>
        public FetchLoginStatusDevicesResponse FetchLoginStatusDevices(FetchLoginStatusDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FetchLoginStatusDevicesHeaders headers = new FetchLoginStatusDevicesHeaders();
            return FetchLoginStatusDevicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定用户的全部已登录设备及其状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchLoginStatusDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchLoginStatusDevicesResponse
        /// </returns>
        public async Task<FetchLoginStatusDevicesResponse> FetchLoginStatusDevicesAsync(FetchLoginStatusDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FetchLoginStatusDevicesHeaders headers = new FetchLoginStatusDevicesHeaders();
            return await FetchLoginStatusDevicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得ai任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// GetAiTaskResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiTaskResultResponse
        /// </returns>
        public GetAiTaskResultResponse GetAiTaskResultWithOptions(GetAiTaskResultRequest request, GetAiTaskResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
                Action = "GetAiTaskResult",
                Version = "aiSearchAsk_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiSearchAsk/getAiTaskResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiTaskResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得ai任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// GetAiTaskResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiTaskResultResponse
        /// </returns>
        public async Task<GetAiTaskResultResponse> GetAiTaskResultWithOptionsAsync(GetAiTaskResultRequest request, GetAiTaskResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
                Action = "GetAiTaskResult",
                Version = "aiSearchAsk_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiSearchAsk/getAiTaskResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiTaskResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得ai任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiTaskResultResponse
        /// </returns>
        public GetAiTaskResultResponse GetAiTaskResult(GetAiTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAiTaskResultHeaders headers = new GetAiTaskResultHeaders();
            return GetAiTaskResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得ai任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiTaskResultResponse
        /// </returns>
        public async Task<GetAiTaskResultResponse> GetAiTaskResultAsync(GetAiTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAiTaskResultHeaders headers = new GetAiTaskResultHeaders();
            return await GetAiTaskResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多数据源召回接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveRequest
        /// </param>
        /// <param name="headers">
        /// RetrieveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveResponse
        /// </returns>
        public RetrieveResponse RetrieveWithOptions(RetrieveRequest request, RetrieveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Answerer))
            {
                body["answerer"] = request.Answerer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DragRequestContext))
            {
                body["dragRequestContext"] = request.DragRequestContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordList))
            {
                body["keywordList"] = request.KeywordList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Questioner))
            {
                body["questioner"] = request.Questioner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrievalExtendParams))
            {
                body["retrievalExtendParams"] = request.RetrievalExtendParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrieveScoreThreshold))
            {
                body["retrieveScoreThreshold"] = request.RetrieveScoreThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenLimit))
            {
                body["tokenLimit"] = request.TokenLimit;
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
                Action = "Retrieve",
                Version = "aiSearchAsk_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiSearchAsk/retrieve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多数据源召回接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveRequest
        /// </param>
        /// <param name="headers">
        /// RetrieveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveResponse
        /// </returns>
        public async Task<RetrieveResponse> RetrieveWithOptionsAsync(RetrieveRequest request, RetrieveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Answerer))
            {
                body["answerer"] = request.Answerer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DragRequestContext))
            {
                body["dragRequestContext"] = request.DragRequestContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordList))
            {
                body["keywordList"] = request.KeywordList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Questioner))
            {
                body["questioner"] = request.Questioner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrievalExtendParams))
            {
                body["retrievalExtendParams"] = request.RetrievalExtendParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrieveScoreThreshold))
            {
                body["retrieveScoreThreshold"] = request.RetrieveScoreThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenLimit))
            {
                body["tokenLimit"] = request.TokenLimit;
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
                Action = "Retrieve",
                Version = "aiSearchAsk_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiSearchAsk/retrieve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多数据源召回接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveRequest
        /// </param>
        /// 
        /// <returns>
        /// RetrieveResponse
        /// </returns>
        public RetrieveResponse Retrieve(RetrieveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveHeaders headers = new RetrieveHeaders();
            return RetrieveWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多数据源召回接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveRequest
        /// </param>
        /// 
        /// <returns>
        /// RetrieveResponse
        /// </returns>
        public async Task<RetrieveResponse> RetrieveAsync(RetrieveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveHeaders headers = new RetrieveHeaders();
            return await RetrieveWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交ai任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitAiTaskRequest
        /// </param>
        /// <param name="headers">
        /// SubmitAiTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAiTaskResponse
        /// </returns>
        public SubmitAiTaskResponse SubmitAiTaskWithOptions(SubmitAiTaskRequest tmpReq, SubmitAiTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitAiTaskShrinkRequest request = new SubmitAiTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Messages))
            {
                request.MessagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Messages, "messages", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessagesShrink))
            {
                query["messages"] = request.MessagesShrink;
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
                Action = "SubmitAiTask",
                Version = "aiSearchAsk_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiSearchAsk/submitAiTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAiTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交ai任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitAiTaskRequest
        /// </param>
        /// <param name="headers">
        /// SubmitAiTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAiTaskResponse
        /// </returns>
        public async Task<SubmitAiTaskResponse> SubmitAiTaskWithOptionsAsync(SubmitAiTaskRequest tmpReq, SubmitAiTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitAiTaskShrinkRequest request = new SubmitAiTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Messages))
            {
                request.MessagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Messages, "messages", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessagesShrink))
            {
                query["messages"] = request.MessagesShrink;
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
                Action = "SubmitAiTask",
                Version = "aiSearchAsk_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiSearchAsk/submitAiTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAiTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交ai任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAiTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAiTaskResponse
        /// </returns>
        public SubmitAiTaskResponse SubmitAiTask(SubmitAiTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitAiTaskHeaders headers = new SubmitAiTaskHeaders();
            return SubmitAiTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交ai任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAiTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAiTaskResponse
        /// </returns>
        public async Task<SubmitAiTaskResponse> SubmitAiTaskAsync(SubmitAiTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitAiTaskHeaders headers = new SubmitAiTaskHeaders();
            return await SubmitAiTaskWithOptionsAsync(request, headers, runtime);
        }

    }
}
