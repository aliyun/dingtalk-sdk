// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkding_phone_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkding_phone_1_0
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
        /// <para>添加外呼码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCallConfigRequest
        /// </param>
        /// <param name="headers">
        /// AddCallConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCallConfigResponse
        /// </returns>
        public AddCallConfigResponse AddCallConfigWithOptions(AddCallConfigRequest request, AddCallConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvToken))
            {
                query["isvToken"] = request.IsvToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["phoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["scopeType"] = request.ScopeType;
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
                Action = "AddCallConfig",
                Version = "dingPhone_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingPhone/callConfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCallConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加外呼码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCallConfigRequest
        /// </param>
        /// <param name="headers">
        /// AddCallConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCallConfigResponse
        /// </returns>
        public async Task<AddCallConfigResponse> AddCallConfigWithOptionsAsync(AddCallConfigRequest request, AddCallConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvToken))
            {
                query["isvToken"] = request.IsvToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["phoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["scopeType"] = request.ScopeType;
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
                Action = "AddCallConfig",
                Version = "dingPhone_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingPhone/callConfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCallConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加外呼码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCallConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCallConfigResponse
        /// </returns>
        public AddCallConfigResponse AddCallConfig(AddCallConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCallConfigHeaders headers = new AddCallConfigHeaders();
            return AddCallConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加外呼码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCallConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCallConfigResponse
        /// </returns>
        public async Task<AddCallConfigResponse> AddCallConfigAsync(AddCallConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCallConfigHeaders headers = new AddCallConfigHeaders();
            return await AddCallConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelCallConfigRequest
        /// </param>
        /// <param name="headers">
        /// DelCallConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelCallConfigResponse
        /// </returns>
        public DelCallConfigResponse DelCallConfigWithOptions(DelCallConfigRequest request, DelCallConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvToken))
            {
                query["isvToken"] = request.IsvToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["phoneNumber"] = request.PhoneNumber;
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
                Action = "DelCallConfig",
                Version = "dingPhone_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingPhone/callConfigs",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelCallConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelCallConfigRequest
        /// </param>
        /// <param name="headers">
        /// DelCallConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelCallConfigResponse
        /// </returns>
        public async Task<DelCallConfigResponse> DelCallConfigWithOptionsAsync(DelCallConfigRequest request, DelCallConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvToken))
            {
                query["isvToken"] = request.IsvToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["phoneNumber"] = request.PhoneNumber;
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
                Action = "DelCallConfig",
                Version = "dingPhone_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingPhone/callConfigs",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelCallConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelCallConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DelCallConfigResponse
        /// </returns>
        public DelCallConfigResponse DelCallConfig(DelCallConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelCallConfigHeaders headers = new DelCallConfigHeaders();
            return DelCallConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelCallConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DelCallConfigResponse
        /// </returns>
        public async Task<DelCallConfigResponse> DelCallConfigAsync(DelCallConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelCallConfigHeaders headers = new DelCallConfigHeaders();
            return await DelCallConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询外呼码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallConfigRequest
        /// </param>
        /// <param name="headers">
        /// QueryCallConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallConfigResponse
        /// </returns>
        public QueryCallConfigResponse QueryCallConfigWithOptions(QueryCallConfigRequest request, QueryCallConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvToken))
            {
                query["isvToken"] = request.IsvToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["phoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["scopeType"] = request.ScopeType;
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
                Action = "QueryCallConfig",
                Version = "dingPhone_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingPhone/callConfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询外呼码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallConfigRequest
        /// </param>
        /// <param name="headers">
        /// QueryCallConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallConfigResponse
        /// </returns>
        public async Task<QueryCallConfigResponse> QueryCallConfigWithOptionsAsync(QueryCallConfigRequest request, QueryCallConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvToken))
            {
                query["isvToken"] = request.IsvToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["phoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["scopeType"] = request.ScopeType;
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
                Action = "QueryCallConfig",
                Version = "dingPhone_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingPhone/callConfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询外呼码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallConfigResponse
        /// </returns>
        public QueryCallConfigResponse QueryCallConfig(QueryCallConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCallConfigHeaders headers = new QueryCallConfigHeaders();
            return QueryCallConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询外呼码号配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallConfigResponse
        /// </returns>
        public async Task<QueryCallConfigResponse> QueryCallConfigAsync(QueryCallConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCallConfigHeaders headers = new QueryCallConfigHeaders();
            return await QueryCallConfigWithOptionsAsync(request, headers, runtime);
        }

    }
}
