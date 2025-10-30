// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkblackboard_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkblackboard_1_0
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
        /// <para>获取公告详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// GetBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBlackboardResponse
        /// </returns>
        public GetBlackboardResponse GetBlackboardWithOptions(GetBlackboardRequest request, GetBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                query["blackboardId"] = request.BlackboardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
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
                Action = "GetBlackboard",
                Version = "blackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/blackboard/get_blackboard",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBlackboardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公告详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// GetBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBlackboardResponse
        /// </returns>
        public async Task<GetBlackboardResponse> GetBlackboardWithOptionsAsync(GetBlackboardRequest request, GetBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                query["blackboardId"] = request.BlackboardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
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
                Action = "GetBlackboard",
                Version = "blackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/blackboard/get_blackboard",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBlackboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公告详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBlackboardResponse
        /// </returns>
        public GetBlackboardResponse GetBlackboard(GetBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBlackboardHeaders headers = new GetBlackboardHeaders();
            return GetBlackboardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公告详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBlackboardResponse
        /// </returns>
        public async Task<GetBlackboardResponse> GetBlackboardAsync(GetBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBlackboardHeaders headers = new GetBlackboardHeaders();
            return await GetBlackboardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询公告已读未读人员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardReadUnReadRequest
        /// </param>
        /// <param name="headers">
        /// QueryBlackboardReadUnReadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardReadUnReadResponse
        /// </returns>
        public QueryBlackboardReadUnReadResponse QueryBlackboardReadUnReadWithOptions(QueryBlackboardReadUnReadRequest request, QueryBlackboardReadUnReadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                query["blackboardId"] = request.BlackboardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
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
                Action = "QueryBlackboardReadUnRead",
                Version = "blackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/blackboard/readers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlackboardReadUnReadResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询公告已读未读人员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardReadUnReadRequest
        /// </param>
        /// <param name="headers">
        /// QueryBlackboardReadUnReadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardReadUnReadResponse
        /// </returns>
        public async Task<QueryBlackboardReadUnReadResponse> QueryBlackboardReadUnReadWithOptionsAsync(QueryBlackboardReadUnReadRequest request, QueryBlackboardReadUnReadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                query["blackboardId"] = request.BlackboardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
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
                Action = "QueryBlackboardReadUnRead",
                Version = "blackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/blackboard/readers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlackboardReadUnReadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询公告已读未读人员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardReadUnReadRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardReadUnReadResponse
        /// </returns>
        public QueryBlackboardReadUnReadResponse QueryBlackboardReadUnRead(QueryBlackboardReadUnReadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardReadUnReadHeaders headers = new QueryBlackboardReadUnReadHeaders();
            return QueryBlackboardReadUnReadWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询公告已读未读人员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardReadUnReadRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardReadUnReadResponse
        /// </returns>
        public async Task<QueryBlackboardReadUnReadResponse> QueryBlackboardReadUnReadAsync(QueryBlackboardReadUnReadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardReadUnReadHeaders headers = new QueryBlackboardReadUnReadHeaders();
            return await QueryBlackboardReadUnReadWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公告钉盘空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardSpaceRequest
        /// </param>
        /// <param name="headers">
        /// QueryBlackboardSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardSpaceResponse
        /// </returns>
        public QueryBlackboardSpaceResponse QueryBlackboardSpaceWithOptions(QueryBlackboardSpaceRequest request, QueryBlackboardSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
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
                Action = "QueryBlackboardSpace",
                Version = "blackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/blackboard/spaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlackboardSpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公告钉盘空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardSpaceRequest
        /// </param>
        /// <param name="headers">
        /// QueryBlackboardSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardSpaceResponse
        /// </returns>
        public async Task<QueryBlackboardSpaceResponse> QueryBlackboardSpaceWithOptionsAsync(QueryBlackboardSpaceRequest request, QueryBlackboardSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
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
                Action = "QueryBlackboardSpace",
                Version = "blackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/blackboard/spaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlackboardSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公告钉盘空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardSpaceResponse
        /// </returns>
        public QueryBlackboardSpaceResponse QueryBlackboardSpace(QueryBlackboardSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardSpaceHeaders headers = new QueryBlackboardSpaceHeaders();
            return QueryBlackboardSpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公告钉盘空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardSpaceResponse
        /// </returns>
        public async Task<QueryBlackboardSpaceResponse> QueryBlackboardSpaceAsync(QueryBlackboardSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardSpaceHeaders headers = new QueryBlackboardSpaceHeaders();
            return await QueryBlackboardSpaceWithOptionsAsync(request, headers, runtime);
        }

    }
}
