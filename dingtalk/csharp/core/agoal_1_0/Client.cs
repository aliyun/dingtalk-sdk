// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkagoal_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0
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
        /// <para>创建目标进展</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalCreateProgressRequest
        /// </param>
        /// <param name="headers">
        /// AgoalCreateProgressHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalCreateProgressResponse
        /// </returns>
        public AgoalCreateProgressResponse AgoalCreateProgressWithOptions(AgoalCreateProgressRequest request, AgoalCreateProgressHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KrId))
            {
                body["krId"] = request.KrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeIntoLatestProgress))
            {
                body["mergeIntoLatestProgress"] = request.MergeIntoLatestProgress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                body["objectiveId"] = request.ObjectiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlainText))
            {
                body["plainText"] = request.PlainText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Progress))
            {
                body["progress"] = request.Progress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressMergePeriod))
            {
                body["progressMergePeriod"] = request.ProgressMergePeriod;
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
                Action = "AgoalCreateProgress",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectives/progresses",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalCreateProgressResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建目标进展</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalCreateProgressRequest
        /// </param>
        /// <param name="headers">
        /// AgoalCreateProgressHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalCreateProgressResponse
        /// </returns>
        public async Task<AgoalCreateProgressResponse> AgoalCreateProgressWithOptionsAsync(AgoalCreateProgressRequest request, AgoalCreateProgressHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KrId))
            {
                body["krId"] = request.KrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeIntoLatestProgress))
            {
                body["mergeIntoLatestProgress"] = request.MergeIntoLatestProgress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                body["objectiveId"] = request.ObjectiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlainText))
            {
                body["plainText"] = request.PlainText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Progress))
            {
                body["progress"] = request.Progress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressMergePeriod))
            {
                body["progressMergePeriod"] = request.ProgressMergePeriod;
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
                Action = "AgoalCreateProgress",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectives/progresses",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalCreateProgressResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建目标进展</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalCreateProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalCreateProgressResponse
        /// </returns>
        public AgoalCreateProgressResponse AgoalCreateProgress(AgoalCreateProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalCreateProgressHeaders headers = new AgoalCreateProgressHeaders();
            return AgoalCreateProgressWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建目标进展</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalCreateProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalCreateProgressResponse
        /// </returns>
        public async Task<AgoalCreateProgressResponse> AgoalCreateProgressAsync(AgoalCreateProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalCreateProgressHeaders headers = new AgoalCreateProgressHeaders();
            return await AgoalCreateProgressWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务实体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalEntityCreateRequest
        /// </param>
        /// <param name="headers">
        /// AgoalEntityCreateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalEntityCreateResponse
        /// </returns>
        public AgoalEntityCreateResponse AgoalEntityCreateWithOptions(AgoalEntityCreateRequest request, AgoalEntityCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalEntityCreate",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/entities",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalEntityCreateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务实体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalEntityCreateRequest
        /// </param>
        /// <param name="headers">
        /// AgoalEntityCreateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalEntityCreateResponse
        /// </returns>
        public async Task<AgoalEntityCreateResponse> AgoalEntityCreateWithOptionsAsync(AgoalEntityCreateRequest request, AgoalEntityCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalEntityCreate",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/entities",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalEntityCreateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务实体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalEntityCreateRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalEntityCreateResponse
        /// </returns>
        public AgoalEntityCreateResponse AgoalEntityCreate(AgoalEntityCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalEntityCreateHeaders headers = new AgoalEntityCreateHeaders();
            return AgoalEntityCreateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务实体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalEntityCreateRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalEntityCreateResponse
        /// </returns>
        public async Task<AgoalEntityCreateResponse> AgoalEntityCreateAsync(AgoalEntityCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalEntityCreateHeaders headers = new AgoalEntityCreateHeaders();
            return await AgoalEntityCreateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务实体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalEntityUpdateRequest
        /// </param>
        /// <param name="headers">
        /// AgoalEntityUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalEntityUpdateResponse
        /// </returns>
        public AgoalEntityUpdateResponse AgoalEntityUpdateWithOptions(AgoalEntityUpdateRequest request, AgoalEntityUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalEntityUpdate",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/entities",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalEntityUpdateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务实体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalEntityUpdateRequest
        /// </param>
        /// <param name="headers">
        /// AgoalEntityUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalEntityUpdateResponse
        /// </returns>
        public async Task<AgoalEntityUpdateResponse> AgoalEntityUpdateWithOptionsAsync(AgoalEntityUpdateRequest request, AgoalEntityUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalEntityUpdate",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/entities",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalEntityUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务实体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalEntityUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalEntityUpdateResponse
        /// </returns>
        public AgoalEntityUpdateResponse AgoalEntityUpdate(AgoalEntityUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalEntityUpdateHeaders headers = new AgoalEntityUpdateHeaders();
            return AgoalEntityUpdateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务实体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalEntityUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalEntityUpdateResponse
        /// </returns>
        public async Task<AgoalEntityUpdateResponse> AgoalEntityUpdateAsync(AgoalEntityUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalEntityUpdateHeaders headers = new AgoalEntityUpdateHeaders();
            return await AgoalEntityUpdateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Agoal 字段值</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AgoalFieldUpdateRequest
        /// </param>
        /// <param name="headers">
        /// AgoalFieldUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalFieldUpdateResponse
        /// </returns>
        public AgoalFieldUpdateResponse AgoalFieldUpdateWithOptions(AgoalFieldUpdateRequest tmpReq, AgoalFieldUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AgoalFieldUpdateShrinkRequest request = new AgoalFieldUpdateShrinkRequest();
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
                Action = "AgoalFieldUpdate",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/fields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalFieldUpdateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Agoal 字段值</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AgoalFieldUpdateRequest
        /// </param>
        /// <param name="headers">
        /// AgoalFieldUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalFieldUpdateResponse
        /// </returns>
        public async Task<AgoalFieldUpdateResponse> AgoalFieldUpdateWithOptionsAsync(AgoalFieldUpdateRequest tmpReq, AgoalFieldUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AgoalFieldUpdateShrinkRequest request = new AgoalFieldUpdateShrinkRequest();
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
                Action = "AgoalFieldUpdate",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/fields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalFieldUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Agoal 字段值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalFieldUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalFieldUpdateResponse
        /// </returns>
        public AgoalFieldUpdateResponse AgoalFieldUpdate(AgoalFieldUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalFieldUpdateHeaders headers = new AgoalFieldUpdateHeaders();
            return AgoalFieldUpdateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Agoal 字段值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalFieldUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalFieldUpdateResponse
        /// </returns>
        public async Task<AgoalFieldUpdateResponse> AgoalFieldUpdateAsync(AgoalFieldUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalFieldUpdateHeaders headers = new AgoalFieldUpdateHeaders();
            return await AgoalFieldUpdateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指标编码批量查询指标列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AgoalIndicatorBatchQueryRequest
        /// </param>
        /// <param name="headers">
        /// AgoalIndicatorBatchQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalIndicatorBatchQueryResponse
        /// </returns>
        public AgoalIndicatorBatchQueryResponse AgoalIndicatorBatchQueryWithOptions(AgoalIndicatorBatchQueryRequest tmpReq, AgoalIndicatorBatchQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AgoalIndicatorBatchQueryShrinkRequest request = new AgoalIndicatorBatchQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CodeList))
            {
                request.CodeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CodeList, "codeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeListShrink))
            {
                query["codeList"] = request.CodeListShrink;
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
                Action = "AgoalIndicatorBatchQuery",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/indicator/batch/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalIndicatorBatchQueryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指标编码批量查询指标列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AgoalIndicatorBatchQueryRequest
        /// </param>
        /// <param name="headers">
        /// AgoalIndicatorBatchQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalIndicatorBatchQueryResponse
        /// </returns>
        public async Task<AgoalIndicatorBatchQueryResponse> AgoalIndicatorBatchQueryWithOptionsAsync(AgoalIndicatorBatchQueryRequest tmpReq, AgoalIndicatorBatchQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AgoalIndicatorBatchQueryShrinkRequest request = new AgoalIndicatorBatchQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CodeList))
            {
                request.CodeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CodeList, "codeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeListShrink))
            {
                query["codeList"] = request.CodeListShrink;
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
                Action = "AgoalIndicatorBatchQuery",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/indicator/batch/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalIndicatorBatchQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指标编码批量查询指标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalIndicatorBatchQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalIndicatorBatchQueryResponse
        /// </returns>
        public AgoalIndicatorBatchQueryResponse AgoalIndicatorBatchQuery(AgoalIndicatorBatchQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalIndicatorBatchQueryHeaders headers = new AgoalIndicatorBatchQueryHeaders();
            return AgoalIndicatorBatchQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指标编码批量查询指标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalIndicatorBatchQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalIndicatorBatchQueryResponse
        /// </returns>
        public async Task<AgoalIndicatorBatchQueryResponse> AgoalIndicatorBatchQueryAsync(AgoalIndicatorBatchQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalIndicatorBatchQueryHeaders headers = new AgoalIndicatorBatchQueryHeaders();
            return await AgoalIndicatorBatchQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指标编码推送指标时间维度数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalIndicatorDataPushRequest
        /// </param>
        /// <param name="headers">
        /// AgoalIndicatorDataPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalIndicatorDataPushResponse
        /// </returns>
        public AgoalIndicatorDataPushResponse AgoalIndicatorDataPushWithOptions(AgoalIndicatorDataPushRequest request, AgoalIndicatorDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
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
                Action = "AgoalIndicatorDataPush",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/indicator/data/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalIndicatorDataPushResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指标编码推送指标时间维度数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalIndicatorDataPushRequest
        /// </param>
        /// <param name="headers">
        /// AgoalIndicatorDataPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalIndicatorDataPushResponse
        /// </returns>
        public async Task<AgoalIndicatorDataPushResponse> AgoalIndicatorDataPushWithOptionsAsync(AgoalIndicatorDataPushRequest request, AgoalIndicatorDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
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
                Action = "AgoalIndicatorDataPush",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/indicator/data/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalIndicatorDataPushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指标编码推送指标时间维度数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalIndicatorDataPushRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalIndicatorDataPushResponse
        /// </returns>
        public AgoalIndicatorDataPushResponse AgoalIndicatorDataPush(AgoalIndicatorDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalIndicatorDataPushHeaders headers = new AgoalIndicatorDataPushHeaders();
            return AgoalIndicatorDataPushWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指标编码推送指标时间维度数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalIndicatorDataPushRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalIndicatorDataPushResponse
        /// </returns>
        public async Task<AgoalIndicatorDataPushResponse> AgoalIndicatorDataPushAsync(AgoalIndicatorDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalIndicatorDataPushHeaders headers = new AgoalIndicatorDataPushHeaders();
            return await AgoalIndicatorDataPushWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal指定目标或者关键结果关联的关键行动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveKeyActionListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalObjectiveKeyActionListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveKeyActionListResponse
        /// </returns>
        public AgoalObjectiveKeyActionListResponse AgoalObjectiveKeyActionListWithOptions(AgoalObjectiveKeyActionListRequest request, AgoalObjectiveKeyActionListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                query["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyResultId))
            {
                query["keyResultId"] = request.KeyResultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
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
                Action = "AgoalObjectiveKeyActionList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectives/keyActionLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveKeyActionListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal指定目标或者关键结果关联的关键行动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveKeyActionListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalObjectiveKeyActionListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveKeyActionListResponse
        /// </returns>
        public async Task<AgoalObjectiveKeyActionListResponse> AgoalObjectiveKeyActionListWithOptionsAsync(AgoalObjectiveKeyActionListRequest request, AgoalObjectiveKeyActionListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                query["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyResultId))
            {
                query["keyResultId"] = request.KeyResultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
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
                Action = "AgoalObjectiveKeyActionList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectives/keyActionLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveKeyActionListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal指定目标或者关键结果关联的关键行动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveKeyActionListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveKeyActionListResponse
        /// </returns>
        public AgoalObjectiveKeyActionListResponse AgoalObjectiveKeyActionList(AgoalObjectiveKeyActionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveKeyActionListHeaders headers = new AgoalObjectiveKeyActionListHeaders();
            return AgoalObjectiveKeyActionListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal指定目标或者关键结果关联的关键行动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveKeyActionListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveKeyActionListResponse
        /// </returns>
        public async Task<AgoalObjectiveKeyActionListResponse> AgoalObjectiveKeyActionListAsync(AgoalObjectiveKeyActionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveKeyActionListHeaders headers = new AgoalObjectiveKeyActionListHeaders();
            return await AgoalObjectiveKeyActionListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下指定个人目标的所有进展</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveProgressListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalObjectiveProgressListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveProgressListResponse
        /// </returns>
        public AgoalObjectiveProgressListResponse AgoalObjectiveProgressListWithOptions(AgoalObjectiveProgressListRequest request, AgoalObjectiveProgressListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "AgoalObjectiveProgressList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectives/progresses/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveProgressListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下指定个人目标的所有进展</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveProgressListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalObjectiveProgressListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveProgressListResponse
        /// </returns>
        public async Task<AgoalObjectiveProgressListResponse> AgoalObjectiveProgressListWithOptionsAsync(AgoalObjectiveProgressListRequest request, AgoalObjectiveProgressListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "AgoalObjectiveProgressList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectives/progresses/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveProgressListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下指定个人目标的所有进展</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveProgressListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveProgressListResponse
        /// </returns>
        public AgoalObjectiveProgressListResponse AgoalObjectiveProgressList(AgoalObjectiveProgressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveProgressListHeaders headers = new AgoalObjectiveProgressListHeaders();
            return AgoalObjectiveProgressListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下指定个人目标的所有进展</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveProgressListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveProgressListResponse
        /// </returns>
        public async Task<AgoalObjectiveProgressListResponse> AgoalObjectiveProgressListAsync(AgoalObjectiveProgressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveProgressListHeaders headers = new AgoalObjectiveProgressListHeaders();
            return await AgoalObjectiveProgressListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下目标规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveRuleListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalObjectiveRuleListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveRuleListResponse
        /// </returns>
        public AgoalObjectiveRuleListResponse AgoalObjectiveRuleListWithOptions(AgoalObjectiveRuleListRequest request, AgoalObjectiveRuleListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalObjectiveRuleList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRuleLists/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveRuleListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下目标规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveRuleListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalObjectiveRuleListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveRuleListResponse
        /// </returns>
        public async Task<AgoalObjectiveRuleListResponse> AgoalObjectiveRuleListWithOptionsAsync(AgoalObjectiveRuleListRequest request, AgoalObjectiveRuleListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalObjectiveRuleList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRuleLists/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveRuleListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下目标规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveRuleListResponse
        /// </returns>
        public AgoalObjectiveRuleListResponse AgoalObjectiveRuleList(AgoalObjectiveRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveRuleListHeaders headers = new AgoalObjectiveRuleListHeaders();
            return AgoalObjectiveRuleListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下目标规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveRuleListResponse
        /// </returns>
        public async Task<AgoalObjectiveRuleListResponse> AgoalObjectiveRuleListAsync(AgoalObjectiveRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveRuleListHeaders headers = new AgoalObjectiveRuleListHeaders();
            return await AgoalObjectiveRuleListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal目标规则下的周期列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveRulePeriodListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalObjectiveRulePeriodListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveRulePeriodListResponse
        /// </returns>
        public AgoalObjectiveRulePeriodListResponse AgoalObjectiveRulePeriodListWithOptions(AgoalObjectiveRulePeriodListRequest request, AgoalObjectiveRulePeriodListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveRuleId))
            {
                query["objectiveRuleId"] = request.ObjectiveRuleId;
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
                Action = "AgoalObjectiveRulePeriodList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRules/periodLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveRulePeriodListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal目标规则下的周期列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveRulePeriodListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalObjectiveRulePeriodListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveRulePeriodListResponse
        /// </returns>
        public async Task<AgoalObjectiveRulePeriodListResponse> AgoalObjectiveRulePeriodListWithOptionsAsync(AgoalObjectiveRulePeriodListRequest request, AgoalObjectiveRulePeriodListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveRuleId))
            {
                query["objectiveRuleId"] = request.ObjectiveRuleId;
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
                Action = "AgoalObjectiveRulePeriodList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRules/periodLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveRulePeriodListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal目标规则下的周期列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveRulePeriodListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveRulePeriodListResponse
        /// </returns>
        public AgoalObjectiveRulePeriodListResponse AgoalObjectiveRulePeriodList(AgoalObjectiveRulePeriodListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveRulePeriodListHeaders headers = new AgoalObjectiveRulePeriodListHeaders();
            return AgoalObjectiveRulePeriodListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal目标规则下的周期列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalObjectiveRulePeriodListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalObjectiveRulePeriodListResponse
        /// </returns>
        public async Task<AgoalObjectiveRulePeriodListResponse> AgoalObjectiveRulePeriodListAsync(AgoalObjectiveRulePeriodListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveRulePeriodListHeaders headers = new AgoalObjectiveRulePeriodListHeaders();
            return await AgoalObjectiveRulePeriodListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 Agoal 组织目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgObjectiveListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalOrgObjectiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveListResponse
        /// </returns>
        public AgoalOrgObjectiveListResponse AgoalOrgObjectiveListWithOptions(AgoalOrgObjectiveListRequest request, AgoalOrgObjectiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTeamId))
            {
                query["dingTeamId"] = request.DingTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                query["periodId"] = request.PeriodId;
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
                Action = "AgoalOrgObjectiveList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/orgObjectives/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgObjectiveListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 Agoal 组织目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgObjectiveListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalOrgObjectiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveListResponse
        /// </returns>
        public async Task<AgoalOrgObjectiveListResponse> AgoalOrgObjectiveListWithOptionsAsync(AgoalOrgObjectiveListRequest request, AgoalOrgObjectiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTeamId))
            {
                query["dingTeamId"] = request.DingTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                query["periodId"] = request.PeriodId;
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
                Action = "AgoalOrgObjectiveList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/orgObjectives/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgObjectiveListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 Agoal 组织目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgObjectiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveListResponse
        /// </returns>
        public AgoalOrgObjectiveListResponse AgoalOrgObjectiveList(AgoalOrgObjectiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgObjectiveListHeaders headers = new AgoalOrgObjectiveListHeaders();
            return AgoalOrgObjectiveListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 Agoal 组织目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgObjectiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveListResponse
        /// </returns>
        public async Task<AgoalOrgObjectiveListResponse> AgoalOrgObjectiveListAsync(AgoalOrgObjectiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgObjectiveListHeaders headers = new AgoalOrgObjectiveListHeaders();
            return await AgoalOrgObjectiveListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgObjectiveQueryRequest
        /// </param>
        /// <param name="headers">
        /// AgoalOrgObjectiveQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveQueryResponse
        /// </returns>
        public AgoalOrgObjectiveQueryResponse AgoalOrgObjectiveQueryWithOptions(AgoalOrgObjectiveQueryRequest request, AgoalOrgObjectiveQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
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
                Action = "AgoalOrgObjectiveQuery",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/orgObjectives",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgObjectiveQueryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgObjectiveQueryRequest
        /// </param>
        /// <param name="headers">
        /// AgoalOrgObjectiveQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveQueryResponse
        /// </returns>
        public async Task<AgoalOrgObjectiveQueryResponse> AgoalOrgObjectiveQueryWithOptionsAsync(AgoalOrgObjectiveQueryRequest request, AgoalOrgObjectiveQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
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
                Action = "AgoalOrgObjectiveQuery",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/orgObjectives",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgObjectiveQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgObjectiveQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveQueryResponse
        /// </returns>
        public AgoalOrgObjectiveQueryResponse AgoalOrgObjectiveQuery(AgoalOrgObjectiveQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgObjectiveQueryHeaders headers = new AgoalOrgObjectiveQueryHeaders();
            return AgoalOrgObjectiveQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgObjectiveQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveQueryResponse
        /// </returns>
        public async Task<AgoalOrgObjectiveQueryResponse> AgoalOrgObjectiveQueryAsync(AgoalOrgObjectiveQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgObjectiveQueryHeaders headers = new AgoalOrgObjectiveQueryHeaders();
            return await AgoalOrgObjectiveQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal目标规则列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// AgoalOrgObjectiveRuleListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveRuleListResponse
        /// </returns>
        public AgoalOrgObjectiveRuleListResponse AgoalOrgObjectiveRuleListWithOptions(AgoalOrgObjectiveRuleListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalOrgObjectiveRuleList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRules/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgObjectiveRuleListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal目标规则列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// AgoalOrgObjectiveRuleListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveRuleListResponse
        /// </returns>
        public async Task<AgoalOrgObjectiveRuleListResponse> AgoalOrgObjectiveRuleListWithOptionsAsync(AgoalOrgObjectiveRuleListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalOrgObjectiveRuleList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRules/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgObjectiveRuleListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal目标规则列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveRuleListResponse
        /// </returns>
        public AgoalOrgObjectiveRuleListResponse AgoalOrgObjectiveRuleList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgObjectiveRuleListHeaders headers = new AgoalOrgObjectiveRuleListHeaders();
            return AgoalOrgObjectiveRuleListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal目标规则列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// AgoalOrgObjectiveRuleListResponse
        /// </returns>
        public async Task<AgoalOrgObjectiveRuleListResponse> AgoalOrgObjectiveRuleListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgObjectiveRuleListHeaders headers = new AgoalOrgObjectiveRuleListHeaders();
            return await AgoalOrgObjectiveRuleListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某个考核计划的部门得分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgPerfDocQueryRequest
        /// </param>
        /// <param name="headers">
        /// AgoalOrgPerfDocQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgPerfDocQueryResponse
        /// </returns>
        public AgoalOrgPerfDocQueryResponse AgoalOrgPerfDocQueryWithOptions(AgoalOrgPerfDocQueryRequest request, AgoalOrgPerfDocQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["planId"] = request.PlanId;
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
                Action = "AgoalOrgPerfDocQuery",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/org_perf/documents/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgPerfDocQueryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某个考核计划的部门得分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgPerfDocQueryRequest
        /// </param>
        /// <param name="headers">
        /// AgoalOrgPerfDocQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgPerfDocQueryResponse
        /// </returns>
        public async Task<AgoalOrgPerfDocQueryResponse> AgoalOrgPerfDocQueryWithOptionsAsync(AgoalOrgPerfDocQueryRequest request, AgoalOrgPerfDocQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["planId"] = request.PlanId;
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
                Action = "AgoalOrgPerfDocQuery",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/org_perf/documents/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgPerfDocQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某个考核计划的部门得分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgPerfDocQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgPerfDocQueryResponse
        /// </returns>
        public AgoalOrgPerfDocQueryResponse AgoalOrgPerfDocQuery(AgoalOrgPerfDocQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgPerfDocQueryHeaders headers = new AgoalOrgPerfDocQueryHeaders();
            return AgoalOrgPerfDocQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某个考核计划的部门得分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgPerfDocQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgPerfDocQueryResponse
        /// </returns>
        public async Task<AgoalOrgPerfDocQueryResponse> AgoalOrgPerfDocQueryAsync(AgoalOrgPerfDocQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgPerfDocQueryHeaders headers = new AgoalOrgPerfDocQueryHeaders();
            return await AgoalOrgPerfDocQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下的所有考核计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgPerfPlanQueryRequest
        /// </param>
        /// <param name="headers">
        /// AgoalOrgPerfPlanQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgPerfPlanQueryResponse
        /// </returns>
        public AgoalOrgPerfPlanQueryResponse AgoalOrgPerfPlanQueryWithOptions(AgoalOrgPerfPlanQueryRequest request, AgoalOrgPerfPlanQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalOrgPerfPlanQuery",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/org_perf/plans/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgPerfPlanQueryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下的所有考核计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgPerfPlanQueryRequest
        /// </param>
        /// <param name="headers">
        /// AgoalOrgPerfPlanQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgPerfPlanQueryResponse
        /// </returns>
        public async Task<AgoalOrgPerfPlanQueryResponse> AgoalOrgPerfPlanQueryWithOptionsAsync(AgoalOrgPerfPlanQueryRequest request, AgoalOrgPerfPlanQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalOrgPerfPlanQuery",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/org_perf/plans/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgPerfPlanQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下的所有考核计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgPerfPlanQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgPerfPlanQueryResponse
        /// </returns>
        public AgoalOrgPerfPlanQueryResponse AgoalOrgPerfPlanQuery(AgoalOrgPerfPlanQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgPerfPlanQueryHeaders headers = new AgoalOrgPerfPlanQueryHeaders();
            return AgoalOrgPerfPlanQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下的所有考核计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalOrgPerfPlanQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalOrgPerfPlanQueryResponse
        /// </returns>
        public async Task<AgoalOrgPerfPlanQueryResponse> AgoalOrgPerfPlanQueryAsync(AgoalOrgPerfPlanQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgPerfPlanQueryHeaders headers = new AgoalOrgPerfPlanQueryHeaders();
            return await AgoalOrgPerfPlanQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建考核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalPerfTaskCreateRequest
        /// </param>
        /// <param name="headers">
        /// AgoalPerfTaskCreateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalPerfTaskCreateResponse
        /// </returns>
        public AgoalPerfTaskCreateResponse AgoalPerfTaskCreateWithOptions(AgoalPerfTaskCreateRequest request, AgoalPerfTaskCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalPerfTaskCreate",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/perfTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalPerfTaskCreateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建考核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalPerfTaskCreateRequest
        /// </param>
        /// <param name="headers">
        /// AgoalPerfTaskCreateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalPerfTaskCreateResponse
        /// </returns>
        public async Task<AgoalPerfTaskCreateResponse> AgoalPerfTaskCreateWithOptionsAsync(AgoalPerfTaskCreateRequest request, AgoalPerfTaskCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalPerfTaskCreate",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/perfTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalPerfTaskCreateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建考核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalPerfTaskCreateRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalPerfTaskCreateResponse
        /// </returns>
        public AgoalPerfTaskCreateResponse AgoalPerfTaskCreate(AgoalPerfTaskCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalPerfTaskCreateHeaders headers = new AgoalPerfTaskCreateHeaders();
            return AgoalPerfTaskCreateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建考核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalPerfTaskCreateRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalPerfTaskCreateResponse
        /// </returns>
        public async Task<AgoalPerfTaskCreateResponse> AgoalPerfTaskCreateAsync(AgoalPerfTaskCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalPerfTaskCreateHeaders headers = new AgoalPerfTaskCreateHeaders();
            return await AgoalPerfTaskCreateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新考核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalPerfTaskUpdateRequest
        /// </param>
        /// <param name="headers">
        /// AgoalPerfTaskUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalPerfTaskUpdateResponse
        /// </returns>
        public AgoalPerfTaskUpdateResponse AgoalPerfTaskUpdateWithOptions(AgoalPerfTaskUpdateRequest request, AgoalPerfTaskUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalPerfTaskUpdate",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/perfTasks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalPerfTaskUpdateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新考核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalPerfTaskUpdateRequest
        /// </param>
        /// <param name="headers">
        /// AgoalPerfTaskUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalPerfTaskUpdateResponse
        /// </returns>
        public async Task<AgoalPerfTaskUpdateResponse> AgoalPerfTaskUpdateWithOptionsAsync(AgoalPerfTaskUpdateRequest request, AgoalPerfTaskUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalPerfTaskUpdate",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/perfTasks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalPerfTaskUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新考核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalPerfTaskUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalPerfTaskUpdateResponse
        /// </returns>
        public AgoalPerfTaskUpdateResponse AgoalPerfTaskUpdate(AgoalPerfTaskUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalPerfTaskUpdateHeaders headers = new AgoalPerfTaskUpdateHeaders();
            return AgoalPerfTaskUpdateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新考核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalPerfTaskUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalPerfTaskUpdateResponse
        /// </returns>
        public async Task<AgoalPerfTaskUpdateResponse> AgoalPerfTaskUpdateAsync(AgoalPerfTaskUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalPerfTaskUpdateHeaders headers = new AgoalPerfTaskUpdateHeaders();
            return await AgoalPerfTaskUpdateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 Agoal 周期列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AgoalPeriodListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalPeriodListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalPeriodListResponse
        /// </returns>
        public AgoalPeriodListResponse AgoalPeriodListWithOptions(AgoalPeriodListRequest tmpReq, AgoalPeriodListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AgoalPeriodListShrinkRequest request = new AgoalPeriodListShrinkRequest();
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
                Action = "AgoalPeriodList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/periods/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalPeriodListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 Agoal 周期列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AgoalPeriodListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalPeriodListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalPeriodListResponse
        /// </returns>
        public async Task<AgoalPeriodListResponse> AgoalPeriodListWithOptionsAsync(AgoalPeriodListRequest tmpReq, AgoalPeriodListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AgoalPeriodListShrinkRequest request = new AgoalPeriodListShrinkRequest();
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
                Action = "AgoalPeriodList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/periods/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalPeriodListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 Agoal 周期列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalPeriodListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalPeriodListResponse
        /// </returns>
        public AgoalPeriodListResponse AgoalPeriodList(AgoalPeriodListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalPeriodListHeaders headers = new AgoalPeriodListHeaders();
            return AgoalPeriodListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 Agoal 周期列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalPeriodListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalPeriodListResponse
        /// </returns>
        public async Task<AgoalPeriodListResponse> AgoalPeriodListAsync(AgoalPeriodListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalPeriodListHeaders headers = new AgoalPeriodListHeaders();
            return await AgoalPeriodListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Agoal消息发送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalSendMessageRequest
        /// </param>
        /// <param name="headers">
        /// AgoalSendMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalSendMessageResponse
        /// </returns>
        public AgoalSendMessageResponse AgoalSendMessageWithOptions(AgoalSendMessageRequest request, AgoalSendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileUrl))
            {
                body["mobileUrl"] = request.MobileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcUrl))
            {
                body["pcUrl"] = request.PcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDingUserId))
            {
                body["sourceDingUserId"] = request.SourceDingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDingUserIds))
            {
                body["targetDingUserIds"] = request.TargetDingUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
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
                Action = "AgoalSendMessage",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalSendMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Agoal消息发送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalSendMessageRequest
        /// </param>
        /// <param name="headers">
        /// AgoalSendMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalSendMessageResponse
        /// </returns>
        public async Task<AgoalSendMessageResponse> AgoalSendMessageWithOptionsAsync(AgoalSendMessageRequest request, AgoalSendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileUrl))
            {
                body["mobileUrl"] = request.MobileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcUrl))
            {
                body["pcUrl"] = request.PcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDingUserId))
            {
                body["sourceDingUserId"] = request.SourceDingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDingUserIds))
            {
                body["targetDingUserIds"] = request.TargetDingUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
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
                Action = "AgoalSendMessage",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalSendMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Agoal消息发送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalSendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalSendMessageResponse
        /// </returns>
        public AgoalSendMessageResponse AgoalSendMessage(AgoalSendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalSendMessageHeaders headers = new AgoalSendMessageHeaders();
            return AgoalSendMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Agoal消息发送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalSendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalSendMessageResponse
        /// </returns>
        public async Task<AgoalSendMessageResponse> AgoalSendMessageAsync(AgoalSendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalSendMessageHeaders headers = new AgoalSendMessageHeaders();
            return await AgoalSendMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal管理员列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// AgoalUserAdminListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalUserAdminListResponse
        /// </returns>
        public AgoalUserAdminListResponse AgoalUserAdminListWithOptions(AgoalUserAdminListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalUserAdminList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/administrators/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalUserAdminListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal管理员列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// AgoalUserAdminListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalUserAdminListResponse
        /// </returns>
        public async Task<AgoalUserAdminListResponse> AgoalUserAdminListWithOptionsAsync(AgoalUserAdminListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalUserAdminList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/administrators/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalUserAdminListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal管理员列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// AgoalUserAdminListResponse
        /// </returns>
        public AgoalUserAdminListResponse AgoalUserAdminList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalUserAdminListHeaders headers = new AgoalUserAdminListHeaders();
            return AgoalUserAdminListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal管理员列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// AgoalUserAdminListResponse
        /// </returns>
        public async Task<AgoalUserAdminListResponse> AgoalUserAdminListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalUserAdminListHeaders headers = new AgoalUserAdminListHeaders();
            return await AgoalUserAdminListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Agoal用户目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalUserObjectiveListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalUserObjectiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalUserObjectiveListResponse
        /// </returns>
        public AgoalUserObjectiveListResponse AgoalUserObjectiveListWithOptions(AgoalUserObjectiveListRequest request, AgoalUserObjectiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveRuleId))
            {
                body["objectiveRuleId"] = request.ObjectiveRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodIds))
            {
                body["periodIds"] = request.PeriodIds;
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
                Action = "AgoalUserObjectiveList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/users/objectiveLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalUserObjectiveListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Agoal用户目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalUserObjectiveListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalUserObjectiveListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalUserObjectiveListResponse
        /// </returns>
        public async Task<AgoalUserObjectiveListResponse> AgoalUserObjectiveListWithOptionsAsync(AgoalUserObjectiveListRequest request, AgoalUserObjectiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveRuleId))
            {
                body["objectiveRuleId"] = request.ObjectiveRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodIds))
            {
                body["periodIds"] = request.PeriodIds;
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
                Action = "AgoalUserObjectiveList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/users/objectiveLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalUserObjectiveListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Agoal用户目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalUserObjectiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalUserObjectiveListResponse
        /// </returns>
        public AgoalUserObjectiveListResponse AgoalUserObjectiveList(AgoalUserObjectiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalUserObjectiveListHeaders headers = new AgoalUserObjectiveListHeaders();
            return AgoalUserObjectiveListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Agoal用户目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalUserObjectiveListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalUserObjectiveListResponse
        /// </returns>
        public async Task<AgoalUserObjectiveListResponse> AgoalUserObjectiveListAsync(AgoalUserObjectiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalUserObjectiveListHeaders headers = new AgoalUserObjectiveListHeaders();
            return await AgoalUserObjectiveListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal子管理员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalUserSubAdminListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalUserSubAdminListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalUserSubAdminListResponse
        /// </returns>
        public AgoalUserSubAdminListResponse AgoalUserSubAdminListWithOptions(AgoalUserSubAdminListRequest request, AgoalUserSubAdminListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncPermissionGroup))
            {
                query["funcPermissionGroup"] = request.FuncPermissionGroup;
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
                Action = "AgoalUserSubAdminList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/administrators/sub/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalUserSubAdminListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal子管理员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalUserSubAdminListRequest
        /// </param>
        /// <param name="headers">
        /// AgoalUserSubAdminListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgoalUserSubAdminListResponse
        /// </returns>
        public async Task<AgoalUserSubAdminListResponse> AgoalUserSubAdminListWithOptionsAsync(AgoalUserSubAdminListRequest request, AgoalUserSubAdminListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncPermissionGroup))
            {
                query["funcPermissionGroup"] = request.FuncPermissionGroup;
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
                Action = "AgoalUserSubAdminList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/administrators/sub/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalUserSubAdminListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal子管理员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalUserSubAdminListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalUserSubAdminListResponse
        /// </returns>
        public AgoalUserSubAdminListResponse AgoalUserSubAdminList(AgoalUserSubAdminListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalUserSubAdminListHeaders headers = new AgoalUserSubAdminListHeaders();
            return AgoalUserSubAdminListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agoal子管理员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgoalUserSubAdminListRequest
        /// </param>
        /// 
        /// <returns>
        /// AgoalUserSubAdminListResponse
        /// </returns>
        public async Task<AgoalUserSubAdminListResponse> AgoalUserSubAdminListAsync(AgoalUserSubAdminListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalUserSubAdminListHeaders headers = new AgoalUserSubAdminListHeaders();
            return await AgoalUserSubAdminListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门下的维度和指标id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeptScoreCardIndicatorRequest
        /// </param>
        /// <param name="headers">
        /// GetDeptScoreCardIndicatorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeptScoreCardIndicatorResponse
        /// </returns>
        public GetDeptScoreCardIndicatorResponse GetDeptScoreCardIndicatorWithOptions(GetDeptScoreCardIndicatorRequest request, GetDeptScoreCardIndicatorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTeamId))
            {
                query["dingTeamId"] = request.DingTeamId;
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
                Action = "GetDeptScoreCardIndicator",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/scorecards/departments/indicators",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeptScoreCardIndicatorResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门下的维度和指标id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeptScoreCardIndicatorRequest
        /// </param>
        /// <param name="headers">
        /// GetDeptScoreCardIndicatorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeptScoreCardIndicatorResponse
        /// </returns>
        public async Task<GetDeptScoreCardIndicatorResponse> GetDeptScoreCardIndicatorWithOptionsAsync(GetDeptScoreCardIndicatorRequest request, GetDeptScoreCardIndicatorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTeamId))
            {
                query["dingTeamId"] = request.DingTeamId;
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
                Action = "GetDeptScoreCardIndicator",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/scorecards/departments/indicators",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeptScoreCardIndicatorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门下的维度和指标id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeptScoreCardIndicatorRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeptScoreCardIndicatorResponse
        /// </returns>
        public GetDeptScoreCardIndicatorResponse GetDeptScoreCardIndicator(GetDeptScoreCardIndicatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeptScoreCardIndicatorHeaders headers = new GetDeptScoreCardIndicatorHeaders();
            return GetDeptScoreCardIndicatorWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门下的维度和指标id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeptScoreCardIndicatorRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeptScoreCardIndicatorResponse
        /// </returns>
        public async Task<GetDeptScoreCardIndicatorResponse> GetDeptScoreCardIndicatorAsync(GetDeptScoreCardIndicatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeptScoreCardIndicatorHeaders headers = new GetDeptScoreCardIndicatorHeaders();
            return await GetDeptScoreCardIndicatorWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIndicatorDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetIndicatorDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndicatorDetailResponse
        /// </returns>
        public GetIndicatorDetailResponse GetIndicatorDetailWithOptions(GetIndicatorDetailRequest request, GetIndicatorDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndicatorId))
            {
                query["indicatorId"] = request.IndicatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthNum))
            {
                query["monthNum"] = request.MonthNum;
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
                Action = "GetIndicatorDetail",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/scorecards/indicators/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndicatorDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIndicatorDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetIndicatorDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndicatorDetailResponse
        /// </returns>
        public async Task<GetIndicatorDetailResponse> GetIndicatorDetailWithOptionsAsync(GetIndicatorDetailRequest request, GetIndicatorDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndicatorId))
            {
                query["indicatorId"] = request.IndicatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthNum))
            {
                query["monthNum"] = request.MonthNum;
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
                Action = "GetIndicatorDetail",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/scorecards/indicators/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndicatorDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIndicatorDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIndicatorDetailResponse
        /// </returns>
        public GetIndicatorDetailResponse GetIndicatorDetail(GetIndicatorDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIndicatorDetailHeaders headers = new GetIndicatorDetailHeaders();
            return GetIndicatorDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIndicatorDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIndicatorDetailResponse
        /// </returns>
        public async Task<GetIndicatorDetailResponse> GetIndicatorDetailAsync(GetIndicatorDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIndicatorDetailHeaders headers = new GetIndicatorDetailHeaders();
            return await GetIndicatorDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下个人目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectiveDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetObjectiveDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetObjectiveDetailResponse
        /// </returns>
        public GetObjectiveDetailResponse GetObjectiveDetailWithOptions(GetObjectiveDetailRequest request, GetObjectiveDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
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
                Action = "GetObjectiveDetail",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectives/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetObjectiveDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下个人目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectiveDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetObjectiveDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetObjectiveDetailResponse
        /// </returns>
        public async Task<GetObjectiveDetailResponse> GetObjectiveDetailWithOptionsAsync(GetObjectiveDetailRequest request, GetObjectiveDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
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
                Action = "GetObjectiveDetail",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectives/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetObjectiveDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下个人目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectiveDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetObjectiveDetailResponse
        /// </returns>
        public GetObjectiveDetailResponse GetObjectiveDetail(GetObjectiveDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetObjectiveDetailHeaders headers = new GetObjectiveDetailHeaders();
            return GetObjectiveDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下个人目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectiveDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetObjectiveDetailResponse
        /// </returns>
        public async Task<GetObjectiveDetailResponse> GetObjectiveDetailAsync(GetObjectiveDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetObjectiveDetailHeaders headers = new GetObjectiveDetailHeaders();
            return await GetObjectiveDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下单个目标规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectiveRuleDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetObjectiveRuleDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetObjectiveRuleDetailResponse
        /// </returns>
        public GetObjectiveRuleDetailResponse GetObjectiveRuleDetailWithOptions(GetObjectiveRuleDetailRequest request, GetObjectiveRuleDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveRuleId))
            {
                query["objectiveRuleId"] = request.ObjectiveRuleId;
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
                Action = "GetObjectiveRuleDetail",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRules/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetObjectiveRuleDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下单个目标规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectiveRuleDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetObjectiveRuleDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetObjectiveRuleDetailResponse
        /// </returns>
        public async Task<GetObjectiveRuleDetailResponse> GetObjectiveRuleDetailWithOptionsAsync(GetObjectiveRuleDetailRequest request, GetObjectiveRuleDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveRuleId))
            {
                query["objectiveRuleId"] = request.ObjectiveRuleId;
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
                Action = "GetObjectiveRuleDetail",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRules/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetObjectiveRuleDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下单个目标规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectiveRuleDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetObjectiveRuleDetailResponse
        /// </returns>
        public GetObjectiveRuleDetailResponse GetObjectiveRuleDetail(GetObjectiveRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetObjectiveRuleDetailHeaders headers = new GetObjectiveRuleDetailHeaders();
            return GetObjectiveRuleDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下单个目标规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectiveRuleDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetObjectiveRuleDetailResponse
        /// </returns>
        public async Task<GetObjectiveRuleDetailResponse> GetObjectiveRuleDetailAsync(GetObjectiveRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetObjectiveRuleDetailHeaders headers = new GetObjectiveRuleDetailHeaders();
            return await GetObjectiveRuleDetailWithOptionsAsync(request, headers, runtime);
        }

    }
}
