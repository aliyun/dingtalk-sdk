// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkokr_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0
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
        /// <para>增加对齐目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlignObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// AlignObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlignObjectiveResponse
        /// </returns>
        public AlignObjectiveResponse AlignObjectiveWithOptions(string objectiveId, AlignObjectiveRequest request, AlignObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                body["periodId"] = request.PeriodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                body["targetId"] = request.TargetId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlignObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives/" + objectiveId + "/alignments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AlignObjectiveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加对齐目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlignObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// AlignObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlignObjectiveResponse
        /// </returns>
        public async Task<AlignObjectiveResponse> AlignObjectiveWithOptionsAsync(string objectiveId, AlignObjectiveRequest request, AlignObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                body["periodId"] = request.PeriodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                body["targetId"] = request.TargetId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlignObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives/" + objectiveId + "/alignments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AlignObjectiveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加对齐目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlignObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// AlignObjectiveResponse
        /// </returns>
        public AlignObjectiveResponse AlignObjective(string objectiveId, AlignObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AlignObjectiveHeaders headers = new AlignObjectiveHeaders();
            return AlignObjectiveWithOptions(objectiveId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加对齐目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlignObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// AlignObjectiveResponse
        /// </returns>
        public async Task<AlignObjectiveResponse> AlignObjectiveAsync(string objectiveId, AlignObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AlignObjectiveHeaders headers = new AlignObjectiveHeaders();
            return await AlignObjectiveWithOptionsAsync(objectiveId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddPermissionRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddPermissionResponse
        /// </returns>
        public BatchAddPermissionResponse BatchAddPermissionWithOptions(BatchAddPermissionRequest request, BatchAddPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.List))
            {
                body["list"] = request.List;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                body["targetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddPermission",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/permissions/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddPermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddPermissionRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddPermissionResponse
        /// </returns>
        public async Task<BatchAddPermissionResponse> BatchAddPermissionWithOptionsAsync(BatchAddPermissionRequest request, BatchAddPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.List))
            {
                body["list"] = request.List;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                body["targetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddPermission",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/permissions/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddPermissionResponse
        /// </returns>
        public BatchAddPermissionResponse BatchAddPermission(BatchAddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddPermissionHeaders headers = new BatchAddPermissionHeaders();
            return BatchAddPermissionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddPermissionResponse
        /// </returns>
        public async Task<BatchAddPermissionResponse> BatchAddPermissionAsync(BatchAddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddPermissionHeaders headers = new BatchAddPermissionHeaders();
            return await BatchAddPermissionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryObjectiveResponse
        /// </returns>
        public BatchQueryObjectiveResponse BatchQueryObjectiveWithOptions(BatchQueryObjectiveRequest request, BatchQueryObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveIds))
            {
                body["objectiveIds"] = request.ObjectiveIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                body["periodId"] = request.PeriodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAlign))
            {
                body["withAlign"] = request.WithAlign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithKr))
            {
                body["withKr"] = request.WithKr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithProgress))
            {
                body["withProgress"] = request.WithProgress;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryObjectiveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryObjectiveResponse
        /// </returns>
        public async Task<BatchQueryObjectiveResponse> BatchQueryObjectiveWithOptionsAsync(BatchQueryObjectiveRequest request, BatchQueryObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveIds))
            {
                body["objectiveIds"] = request.ObjectiveIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                body["periodId"] = request.PeriodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAlign))
            {
                body["withAlign"] = request.WithAlign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithKr))
            {
                body["withKr"] = request.WithKr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithProgress))
            {
                body["withProgress"] = request.WithProgress;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryObjectiveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryObjectiveResponse
        /// </returns>
        public BatchQueryObjectiveResponse BatchQueryObjective(BatchQueryObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryObjectiveHeaders headers = new BatchQueryObjectiveHeaders();
            return BatchQueryObjectiveWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryObjectiveResponse
        /// </returns>
        public async Task<BatchQueryObjectiveResponse> BatchQueryObjectiveAsync(BatchQueryObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryObjectiveHeaders headers = new BatchQueryObjectiveHeaders();
            return await BatchQueryObjectiveWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryUserRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryUserResponse
        /// </returns>
        public BatchQueryUserResponse BatchQueryUserWithOptions(BatchQueryUserRequest request, BatchQueryUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OkrUserIds))
            {
                body["okrUserIds"] = request.OkrUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "BatchQueryUser",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/users/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryUserResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryUserRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryUserResponse
        /// </returns>
        public async Task<BatchQueryUserResponse> BatchQueryUserWithOptionsAsync(BatchQueryUserRequest request, BatchQueryUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OkrUserIds))
            {
                body["okrUserIds"] = request.OkrUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "BatchQueryUser",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/users/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryUserRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryUserResponse
        /// </returns>
        public BatchQueryUserResponse BatchQueryUser(BatchQueryUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryUserHeaders headers = new BatchQueryUserHeaders();
            return BatchQueryUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryUserRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryUserResponse
        /// </returns>
        public async Task<BatchQueryUserResponse> BatchQueryUserAsync(BatchQueryUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryUserHeaders headers = new BatchQueryUserHeaders();
            return await BatchQueryUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建keyResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKeyResultRequest
        /// </param>
        /// <param name="headers">
        /// CreateKeyResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyResultResponse
        /// </returns>
        public CreateKeyResultResponse CreateKeyResultWithOptions(CreateKeyResultRequest request, CreateKeyResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                body["objectiveId"] = request.ObjectiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                body["periodId"] = request.PeriodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrevPosition))
            {
                body["prevPosition"] = request.PrevPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weight))
            {
                body["weight"] = request.Weight;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKeyResult",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/keyResults",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKeyResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建keyResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKeyResultRequest
        /// </param>
        /// <param name="headers">
        /// CreateKeyResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyResultResponse
        /// </returns>
        public async Task<CreateKeyResultResponse> CreateKeyResultWithOptionsAsync(CreateKeyResultRequest request, CreateKeyResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                body["objectiveId"] = request.ObjectiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                body["periodId"] = request.PeriodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrevPosition))
            {
                body["prevPosition"] = request.PrevPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weight))
            {
                body["weight"] = request.Weight;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKeyResult",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/keyResults",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKeyResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建keyResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKeyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyResultResponse
        /// </returns>
        public CreateKeyResultResponse CreateKeyResult(CreateKeyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateKeyResultHeaders headers = new CreateKeyResultHeaders();
            return CreateKeyResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建keyResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKeyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyResultResponse
        /// </returns>
        public async Task<CreateKeyResultResponse> CreateKeyResultAsync(CreateKeyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateKeyResultHeaders headers = new CreateKeyResultHeaders();
            return await CreateKeyResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// CreateObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateObjectiveResponse
        /// </returns>
        public CreateObjectiveResponse CreateObjectiveWithOptions(CreateObjectiveRequest request, CreateObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                body["periodId"] = request.PeriodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrevPosition))
            {
                body["prevPosition"] = request.PrevPosition;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateObjectiveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// CreateObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateObjectiveResponse
        /// </returns>
        public async Task<CreateObjectiveResponse> CreateObjectiveWithOptionsAsync(CreateObjectiveRequest request, CreateObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                body["periodId"] = request.PeriodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrevPosition))
            {
                body["prevPosition"] = request.PrevPosition;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateObjectiveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateObjectiveResponse
        /// </returns>
        public CreateObjectiveResponse CreateObjective(CreateObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateObjectiveHeaders headers = new CreateObjectiveHeaders();
            return CreateObjectiveWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateObjectiveResponse
        /// </returns>
        public async Task<CreateObjectiveResponse> CreateObjectiveAsync(CreateObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateObjectiveHeaders headers = new CreateObjectiveHeaders();
            return await CreateObjectiveWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除keyresult的方法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKeyResultRequest
        /// </param>
        /// <param name="headers">
        /// DeleteKeyResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyResultResponse
        /// </returns>
        public DeleteKeyResultResponse DeleteKeyResultWithOptions(DeleteKeyResultRequest request, DeleteKeyResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KrId))
            {
                query["krId"] = request.KrId;
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
                Action = "DeleteKeyResult",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/keyResults",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKeyResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除keyresult的方法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKeyResultRequest
        /// </param>
        /// <param name="headers">
        /// DeleteKeyResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyResultResponse
        /// </returns>
        public async Task<DeleteKeyResultResponse> DeleteKeyResultWithOptionsAsync(DeleteKeyResultRequest request, DeleteKeyResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KrId))
            {
                query["krId"] = request.KrId;
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
                Action = "DeleteKeyResult",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/keyResults",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKeyResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除keyresult的方法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKeyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyResultResponse
        /// </returns>
        public DeleteKeyResultResponse DeleteKeyResult(DeleteKeyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteKeyResultHeaders headers = new DeleteKeyResultHeaders();
            return DeleteKeyResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除keyresult的方法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKeyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyResultResponse
        /// </returns>
        public async Task<DeleteKeyResultResponse> DeleteKeyResultAsync(DeleteKeyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteKeyResultHeaders headers = new DeleteKeyResultHeaders();
            return await DeleteKeyResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// DeleteObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteObjectiveResponse
        /// </returns>
        public DeleteObjectiveResponse DeleteObjectiveWithOptions(string objectiveId, DeleteObjectiveRequest request, DeleteObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives/" + objectiveId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteObjectiveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// DeleteObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteObjectiveResponse
        /// </returns>
        public async Task<DeleteObjectiveResponse> DeleteObjectiveWithOptionsAsync(string objectiveId, DeleteObjectiveRequest request, DeleteObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives/" + objectiveId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteObjectiveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteObjectiveResponse
        /// </returns>
        public DeleteObjectiveResponse DeleteObjective(string objectiveId, DeleteObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteObjectiveHeaders headers = new DeleteObjectiveHeaders();
            return DeleteObjectiveWithOptions(objectiveId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteObjectiveResponse
        /// </returns>
        public async Task<DeleteObjectiveResponse> DeleteObjectiveAsync(string objectiveId, DeleteObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteObjectiveHeaders headers = new DeleteObjectiveHeaders();
            return await DeleteObjectiveWithOptionsAsync(objectiveId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePermissionRequest
        /// </param>
        /// <param name="headers">
        /// DeletePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePermissionResponse
        /// </returns>
        public DeletePermissionResponse DeletePermissionWithOptions(DeletePermissionRequest request, DeletePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["policyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["targetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["targetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "DeletePermission",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/permissions/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePermissionRequest
        /// </param>
        /// <param name="headers">
        /// DeletePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePermissionResponse
        /// </returns>
        public async Task<DeletePermissionResponse> DeletePermissionWithOptionsAsync(DeletePermissionRequest request, DeletePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["policyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["targetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["targetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "DeletePermission",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/permissions/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePermissionResponse
        /// </returns>
        public DeletePermissionResponse DeletePermission(DeletePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePermissionHeaders headers = new DeletePermissionHeaders();
            return DeletePermissionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePermissionResponse
        /// </returns>
        public async Task<DeletePermissionResponse> DeletePermissionAsync(DeletePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePermissionHeaders headers = new DeletePermissionHeaders();
            return await DeletePermissionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取周期列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetPeriodListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPeriodListResponse
        /// </returns>
        public GetPeriodListResponse GetPeriodListWithOptions(GetPeriodListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPeriodList",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/periods",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPeriodListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取周期列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetPeriodListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPeriodListResponse
        /// </returns>
        public async Task<GetPeriodListResponse> GetPeriodListWithOptionsAsync(GetPeriodListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPeriodList",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/periods",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPeriodListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取周期列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPeriodListResponse
        /// </returns>
        public GetPeriodListResponse GetPeriodList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPeriodListHeaders headers = new GetPeriodListHeaders();
            return GetPeriodListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取周期列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPeriodListResponse
        /// </returns>
        public async Task<GetPeriodListResponse> GetPeriodListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPeriodListHeaders headers = new GetPeriodListHeaders();
            return await GetPeriodListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPermissionRequest
        /// </param>
        /// <param name="headers">
        /// GetPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
        public GetPermissionResponse GetPermissionWithOptions(GetPermissionRequest request, GetPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["targetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["targetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithKr))
            {
                query["withKr"] = request.WithKr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithObjective))
            {
                query["withObjective"] = request.WithObjective;
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
                Action = "GetPermission",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPermissionRequest
        /// </param>
        /// <param name="headers">
        /// GetPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
        public async Task<GetPermissionResponse> GetPermissionWithOptionsAsync(GetPermissionRequest request, GetPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["targetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["targetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithKr))
            {
                query["withKr"] = request.WithKr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithObjective))
            {
                query["withObjective"] = request.WithObjective;
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
                Action = "GetPermission",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
        public GetPermissionResponse GetPermission(GetPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPermissionHeaders headers = new GetPermissionHeaders();
            return GetPermissionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
        public async Task<GetPermissionResponse> GetPermissionAsync(GetPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPermissionHeaders headers = new GetPermissionHeaders();
            return await GetPermissionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户当前周期下的全部 OKR 内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserOkrRequest
        /// </param>
        /// <param name="headers">
        /// GetUserOkrHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserOkrResponse
        /// </returns>
        public GetUserOkrResponse GetUserOkrWithOptions(GetUserOkrRequest request, GetUserOkrHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                query["periodId"] = request.PeriodId;
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
                Action = "GetUserOkr",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/users/okrs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserOkrResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户当前周期下的全部 OKR 内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserOkrRequest
        /// </param>
        /// <param name="headers">
        /// GetUserOkrHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserOkrResponse
        /// </returns>
        public async Task<GetUserOkrResponse> GetUserOkrWithOptionsAsync(GetUserOkrRequest request, GetUserOkrHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                query["periodId"] = request.PeriodId;
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
                Action = "GetUserOkr",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/users/okrs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserOkrResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户当前周期下的全部 OKR 内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserOkrRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserOkrResponse
        /// </returns>
        public GetUserOkrResponse GetUserOkr(GetUserOkrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserOkrHeaders headers = new GetUserOkrHeaders();
            return GetUserOkrWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户当前周期下的全部 OKR 内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserOkrRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserOkrResponse
        /// </returns>
        public async Task<GetUserOkrResponse> GetUserOkrAsync(GetUserOkrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserOkrHeaders headers = new GetUserOkrHeaders();
            return await GetUserOkrWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrObjectivesBatchRequest
        /// </param>
        /// <param name="headers">
        /// OkrObjectivesBatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OkrObjectivesBatchResponse
        /// </returns>
        public OkrObjectivesBatchResponse OkrObjectivesBatchWithOptions(OkrObjectivesBatchRequest request, OkrObjectivesBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsCode))
            {
                body["goodsCode"] = request.GoodsCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveIds))
            {
                body["objectiveIds"] = request.ObjectiveIds;
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
                Action = "OkrObjectivesBatch",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/pro/objectives/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OkrObjectivesBatchResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrObjectivesBatchRequest
        /// </param>
        /// <param name="headers">
        /// OkrObjectivesBatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OkrObjectivesBatchResponse
        /// </returns>
        public async Task<OkrObjectivesBatchResponse> OkrObjectivesBatchWithOptionsAsync(OkrObjectivesBatchRequest request, OkrObjectivesBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsCode))
            {
                body["goodsCode"] = request.GoodsCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveIds))
            {
                body["objectiveIds"] = request.ObjectiveIds;
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
                Action = "OkrObjectivesBatch",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/pro/objectives/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OkrObjectivesBatchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrObjectivesBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// OkrObjectivesBatchResponse
        /// </returns>
        public OkrObjectivesBatchResponse OkrObjectivesBatch(OkrObjectivesBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OkrObjectivesBatchHeaders headers = new OkrObjectivesBatchHeaders();
            return OkrObjectivesBatchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrObjectivesBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// OkrObjectivesBatchResponse
        /// </returns>
        public async Task<OkrObjectivesBatchResponse> OkrObjectivesBatchAsync(OkrObjectivesBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OkrObjectivesBatchHeaders headers = new OkrObjectivesBatchHeaders();
            return await OkrObjectivesBatchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个用户的OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrObjectivesByUserRequest
        /// </param>
        /// <param name="headers">
        /// OkrObjectivesByUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OkrObjectivesByUserResponse
        /// </returns>
        public OkrObjectivesByUserResponse OkrObjectivesByUserWithOptions(string dingUserId, OkrObjectivesByUserRequest request, OkrObjectivesByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsCode))
            {
                query["goodsCode"] = request.GoodsCode;
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
                Action = "OkrObjectivesByUser",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/pro/users/" + dingUserId + "/objectives",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OkrObjectivesByUserResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个用户的OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrObjectivesByUserRequest
        /// </param>
        /// <param name="headers">
        /// OkrObjectivesByUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OkrObjectivesByUserResponse
        /// </returns>
        public async Task<OkrObjectivesByUserResponse> OkrObjectivesByUserWithOptionsAsync(string dingUserId, OkrObjectivesByUserRequest request, OkrObjectivesByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsCode))
            {
                query["goodsCode"] = request.GoodsCode;
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
                Action = "OkrObjectivesByUser",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/pro/users/" + dingUserId + "/objectives",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OkrObjectivesByUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个用户的OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrObjectivesByUserRequest
        /// </param>
        /// 
        /// <returns>
        /// OkrObjectivesByUserResponse
        /// </returns>
        public OkrObjectivesByUserResponse OkrObjectivesByUser(string dingUserId, OkrObjectivesByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OkrObjectivesByUserHeaders headers = new OkrObjectivesByUserHeaders();
            return OkrObjectivesByUserWithOptions(dingUserId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个用户的OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrObjectivesByUserRequest
        /// </param>
        /// 
        /// <returns>
        /// OkrObjectivesByUserResponse
        /// </returns>
        public async Task<OkrObjectivesByUserResponse> OkrObjectivesByUserAsync(string dingUserId, OkrObjectivesByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OkrObjectivesByUserHeaders headers = new OkrObjectivesByUserHeaders();
            return await OkrObjectivesByUserWithOptionsAsync(dingUserId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 OKR 周期</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrPeriodsRequest
        /// </param>
        /// <param name="headers">
        /// OkrPeriodsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OkrPeriodsResponse
        /// </returns>
        public OkrPeriodsResponse OkrPeriodsWithOptions(OkrPeriodsRequest request, OkrPeriodsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsCode))
            {
                query["goodsCode"] = request.GoodsCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
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
                Action = "OkrPeriods",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/pro/periods",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OkrPeriodsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 OKR 周期</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrPeriodsRequest
        /// </param>
        /// <param name="headers">
        /// OkrPeriodsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OkrPeriodsResponse
        /// </returns>
        public async Task<OkrPeriodsResponse> OkrPeriodsWithOptionsAsync(OkrPeriodsRequest request, OkrPeriodsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsCode))
            {
                query["goodsCode"] = request.GoodsCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
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
                Action = "OkrPeriods",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/pro/periods",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OkrPeriodsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 OKR 周期</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrPeriodsRequest
        /// </param>
        /// 
        /// <returns>
        /// OkrPeriodsResponse
        /// </returns>
        public OkrPeriodsResponse OkrPeriods(OkrPeriodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OkrPeriodsHeaders headers = new OkrPeriodsHeaders();
            return OkrPeriodsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 OKR 周期</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OkrPeriodsRequest
        /// </param>
        /// 
        /// <returns>
        /// OkrPeriodsResponse
        /// </returns>
        public async Task<OkrPeriodsResponse> OkrPeriodsAsync(OkrPeriodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OkrPeriodsHeaders headers = new OkrPeriodsHeaders();
            return await OkrPeriodsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消对齐Objective</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnAlignObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// UnAlignObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnAlignObjectiveResponse
        /// </returns>
        public UnAlignObjectiveResponse UnAlignObjectiveWithOptions(string objectiveId, UnAlignObjectiveRequest request, UnAlignObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                body["periodId"] = request.PeriodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                body["targetId"] = request.TargetId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnAlignObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives/" + objectiveId + "/alignments/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnAlignObjectiveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消对齐Objective</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnAlignObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// UnAlignObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnAlignObjectiveResponse
        /// </returns>
        public async Task<UnAlignObjectiveResponse> UnAlignObjectiveWithOptionsAsync(string objectiveId, UnAlignObjectiveRequest request, UnAlignObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodId))
            {
                body["periodId"] = request.PeriodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                body["targetId"] = request.TargetId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnAlignObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives/" + objectiveId + "/alignments/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnAlignObjectiveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消对齐Objective</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnAlignObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// UnAlignObjectiveResponse
        /// </returns>
        public UnAlignObjectiveResponse UnAlignObjective(string objectiveId, UnAlignObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnAlignObjectiveHeaders headers = new UnAlignObjectiveHeaders();
            return UnAlignObjectiveWithOptions(objectiveId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消对齐Objective</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnAlignObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// UnAlignObjectiveResponse
        /// </returns>
        public async Task<UnAlignObjectiveResponse> UnAlignObjectiveAsync(string objectiveId, UnAlignObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnAlignObjectiveHeaders headers = new UnAlignObjectiveHeaders();
            return await UnAlignObjectiveWithOptionsAsync(objectiveId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改KR内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfContentRequest
        /// </param>
        /// <param name="headers">
        /// UpdateKROfContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfContentResponse
        /// </returns>
        public UpdateKROfContentResponse UpdateKROfContentWithOptions(UpdateKROfContentRequest request, UpdateKROfContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KrId))
            {
                query["krId"] = request.KrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateQuoteList))
            {
                body["updateQuoteList"] = request.UpdateQuoteList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKROfContent",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/keyResults/contents",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKROfContentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改KR内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfContentRequest
        /// </param>
        /// <param name="headers">
        /// UpdateKROfContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfContentResponse
        /// </returns>
        public async Task<UpdateKROfContentResponse> UpdateKROfContentWithOptionsAsync(UpdateKROfContentRequest request, UpdateKROfContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KrId))
            {
                query["krId"] = request.KrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateQuoteList))
            {
                body["updateQuoteList"] = request.UpdateQuoteList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKROfContent",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/keyResults/contents",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKROfContentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改KR内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfContentResponse
        /// </returns>
        public UpdateKROfContentResponse UpdateKROfContent(UpdateKROfContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateKROfContentHeaders headers = new UpdateKROfContentHeaders();
            return UpdateKROfContentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改KR内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfContentResponse
        /// </returns>
        public async Task<UpdateKROfContentResponse> UpdateKROfContentAsync(UpdateKROfContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateKROfContentHeaders headers = new UpdateKROfContentHeaders();
            return await UpdateKROfContentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改KR分数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfScoreRequest
        /// </param>
        /// <param name="headers">
        /// UpdateKROfScoreHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfScoreResponse
        /// </returns>
        public UpdateKROfScoreResponse UpdateKROfScoreWithOptions(UpdateKROfScoreRequest request, UpdateKROfScoreHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KrId))
            {
                query["krId"] = request.KrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Score))
            {
                body["score"] = request.Score;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKROfScore",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/keyResults/scores",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKROfScoreResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改KR分数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfScoreRequest
        /// </param>
        /// <param name="headers">
        /// UpdateKROfScoreHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfScoreResponse
        /// </returns>
        public async Task<UpdateKROfScoreResponse> UpdateKROfScoreWithOptionsAsync(UpdateKROfScoreRequest request, UpdateKROfScoreHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KrId))
            {
                query["krId"] = request.KrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Score))
            {
                body["score"] = request.Score;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKROfScore",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/keyResults/scores",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKROfScoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改KR分数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfScoreRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfScoreResponse
        /// </returns>
        public UpdateKROfScoreResponse UpdateKROfScore(UpdateKROfScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateKROfScoreHeaders headers = new UpdateKROfScoreHeaders();
            return UpdateKROfScoreWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改KR分数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfScoreRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfScoreResponse
        /// </returns>
        public async Task<UpdateKROfScoreResponse> UpdateKROfScoreAsync(UpdateKROfScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateKROfScoreHeaders headers = new UpdateKROfScoreHeaders();
            return await UpdateKROfScoreWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改 KR 权重</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfWeightRequest
        /// </param>
        /// <param name="headers">
        /// UpdateKROfWeightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfWeightResponse
        /// </returns>
        public UpdateKROfWeightResponse UpdateKROfWeightWithOptions(UpdateKROfWeightRequest request, UpdateKROfWeightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KrId))
            {
                query["krId"] = request.KrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weight))
            {
                body["weight"] = request.Weight;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKROfWeight",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/keyResults/weights",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKROfWeightResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改 KR 权重</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfWeightRequest
        /// </param>
        /// <param name="headers">
        /// UpdateKROfWeightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfWeightResponse
        /// </returns>
        public async Task<UpdateKROfWeightResponse> UpdateKROfWeightWithOptionsAsync(UpdateKROfWeightRequest request, UpdateKROfWeightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KrId))
            {
                query["krId"] = request.KrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weight))
            {
                body["weight"] = request.Weight;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKROfWeight",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/keyResults/weights",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKROfWeightResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改 KR 权重</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfWeightRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfWeightResponse
        /// </returns>
        public UpdateKROfWeightResponse UpdateKROfWeight(UpdateKROfWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateKROfWeightHeaders headers = new UpdateKROfWeightHeaders();
            return UpdateKROfWeightWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改 KR 权重</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKROfWeightRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKROfWeightResponse
        /// </returns>
        public async Task<UpdateKROfWeightResponse> UpdateKROfWeightAsync(UpdateKROfWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateKROfWeightHeaders headers = new UpdateKROfWeightHeaders();
            return await UpdateKROfWeightWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// UpdateObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateObjectiveResponse
        /// </returns>
        public UpdateObjectiveResponse UpdateObjectiveWithOptions(string objectiveId, UpdateObjectiveRequest request, UpdateObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives/" + objectiveId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateObjectiveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// UpdateObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateObjectiveResponse
        /// </returns>
        public async Task<UpdateObjectiveResponse> UpdateObjectiveWithOptionsAsync(string objectiveId, UpdateObjectiveRequest request, UpdateObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateObjective",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/objectives/" + objectiveId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateObjectiveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateObjectiveResponse
        /// </returns>
        public UpdateObjectiveResponse UpdateObjective(string objectiveId, UpdateObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateObjectiveHeaders headers = new UpdateObjectiveHeaders();
            return UpdateObjectiveWithOptions(objectiveId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateObjectiveResponse
        /// </returns>
        public async Task<UpdateObjectiveResponse> UpdateObjectiveAsync(string objectiveId, UpdateObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateObjectiveHeaders headers = new UpdateObjectiveHeaders();
            return await UpdateObjectiveWithOptionsAsync(objectiveId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新资源隐私策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivacyRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePrivacyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivacyResponse
        /// </returns>
        public UpdatePrivacyResponse UpdatePrivacyWithOptions(UpdatePrivacyRequest request, UpdatePrivacyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Privacy))
            {
                body["privacy"] = request.Privacy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                body["targetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrivacy",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/permissions/privacies",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrivacyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新资源隐私策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivacyRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePrivacyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivacyResponse
        /// </returns>
        public async Task<UpdatePrivacyResponse> UpdatePrivacyWithOptionsAsync(UpdatePrivacyRequest request, UpdatePrivacyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Privacy))
            {
                body["privacy"] = request.Privacy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                body["targetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrivacy",
                Version = "okr_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/okr/permissions/privacies",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrivacyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新资源隐私策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivacyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivacyResponse
        /// </returns>
        public UpdatePrivacyResponse UpdatePrivacy(UpdatePrivacyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePrivacyHeaders headers = new UpdatePrivacyHeaders();
            return UpdatePrivacyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新资源隐私策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivacyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivacyResponse
        /// </returns>
        public async Task<UpdatePrivacyResponse> UpdatePrivacyAsync(UpdatePrivacyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePrivacyHeaders headers = new UpdatePrivacyHeaders();
            return await UpdatePrivacyWithOptionsAsync(request, headers, runtime);
        }

    }
}
