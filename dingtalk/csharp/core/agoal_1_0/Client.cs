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

    }
}
