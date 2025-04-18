// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkapaas_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0
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
        /// <para>批量创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// BatchCreateTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateTemplateResponse
        /// </returns>
        public BatchCreateTemplateResponse BatchCreateTemplateWithOptions(BatchCreateTemplateRequest request, BatchCreateTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateList))
            {
                body["templateList"] = request.TemplateList;
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
                Action = "BatchCreateTemplate",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// BatchCreateTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateTemplateResponse
        /// </returns>
        public async Task<BatchCreateTemplateResponse> BatchCreateTemplateWithOptionsAsync(BatchCreateTemplateRequest request, BatchCreateTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateList))
            {
                body["templateList"] = request.TemplateList;
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
                Action = "BatchCreateTemplate",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateTemplateResponse
        /// </returns>
        public BatchCreateTemplateResponse BatchCreateTemplate(BatchCreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateTemplateHeaders headers = new BatchCreateTemplateHeaders();
            return BatchCreateTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateTemplateResponse
        /// </returns>
        public async Task<BatchCreateTemplateResponse> BatchCreateTemplateAsync(BatchCreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateTemplateHeaders headers = new BatchCreateTemplateHeaders();
            return await BatchCreateTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryByTemplateKeyRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryByTemplateKeyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryByTemplateKeyResponse
        /// </returns>
        public BatchQueryByTemplateKeyResponse BatchQueryByTemplateKeyWithOptions(BatchQueryByTemplateKeyRequest request, BatchQueryByTemplateKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeys))
            {
                body["templateKeys"] = request.TemplateKeys;
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
                Action = "BatchQueryByTemplateKey",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryByTemplateKeyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryByTemplateKeyRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryByTemplateKeyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryByTemplateKeyResponse
        /// </returns>
        public async Task<BatchQueryByTemplateKeyResponse> BatchQueryByTemplateKeyWithOptionsAsync(BatchQueryByTemplateKeyRequest request, BatchQueryByTemplateKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeys))
            {
                body["templateKeys"] = request.TemplateKeys;
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
                Action = "BatchQueryByTemplateKey",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryByTemplateKeyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryByTemplateKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryByTemplateKeyResponse
        /// </returns>
        public BatchQueryByTemplateKeyResponse BatchQueryByTemplateKey(BatchQueryByTemplateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryByTemplateKeyHeaders headers = new BatchQueryByTemplateKeyHeaders();
            return BatchQueryByTemplateKeyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryByTemplateKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryByTemplateKeyResponse
        /// </returns>
        public async Task<BatchQueryByTemplateKeyResponse> BatchQueryByTemplateKeyAsync(BatchQueryByTemplateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryByTemplateKeyHeaders headers = new BatchQueryByTemplateKeyHeaders();
            return await BatchQueryByTemplateKeyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateTemplateResponse
        /// </returns>
        public BatchUpdateTemplateResponse BatchUpdateTemplateWithOptions(BatchUpdateTemplateRequest request, BatchUpdateTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateList))
            {
                body["templateList"] = request.TemplateList;
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
                Action = "BatchUpdateTemplate",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateTemplateResponse
        /// </returns>
        public async Task<BatchUpdateTemplateResponse> BatchUpdateTemplateWithOptionsAsync(BatchUpdateTemplateRequest request, BatchUpdateTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateList))
            {
                body["templateList"] = request.TemplateList;
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
                Action = "BatchUpdateTemplate",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateTemplateResponse
        /// </returns>
        public BatchUpdateTemplateResponse BatchUpdateTemplate(BatchUpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateTemplateHeaders headers = new BatchUpdateTemplateHeaders();
            return BatchUpdateTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateTemplateResponse
        /// </returns>
        public async Task<BatchUpdateTemplateResponse> BatchUpdateTemplateAsync(BatchUpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateTemplateHeaders headers = new BatchUpdateTemplateHeaders();
            return await BatchUpdateTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询行业标签</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryIndustryTagListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryTagListResponse
        /// </returns>
        public QueryIndustryTagListResponse QueryIndustryTagListWithOptions(QueryIndustryTagListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryIndustryTagList",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates/industries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIndustryTagListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询行业标签</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryIndustryTagListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryTagListResponse
        /// </returns>
        public async Task<QueryIndustryTagListResponse> QueryIndustryTagListWithOptionsAsync(QueryIndustryTagListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryIndustryTagList",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates/industries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIndustryTagListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询行业标签</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryIndustryTagListResponse
        /// </returns>
        public QueryIndustryTagListResponse QueryIndustryTagList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryIndustryTagListHeaders headers = new QueryIndustryTagListHeaders();
            return QueryIndustryTagListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询行业标签</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryIndustryTagListResponse
        /// </returns>
        public async Task<QueryIndustryTagListResponse> QueryIndustryTagListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryIndustryTagListHeaders headers = new QueryIndustryTagListHeaders();
            return await QueryIndustryTagListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询角色</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryRoleTagListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRoleTagListResponse
        /// </returns>
        public QueryRoleTagListResponse QueryRoleTagListWithOptions(QueryRoleTagListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryRoleTagList",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRoleTagListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询角色</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryRoleTagListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRoleTagListResponse
        /// </returns>
        public async Task<QueryRoleTagListResponse> QueryRoleTagListWithOptionsAsync(QueryRoleTagListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryRoleTagList",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRoleTagListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询角色</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryRoleTagListResponse
        /// </returns>
        public QueryRoleTagListResponse QueryRoleTagList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoleTagListHeaders headers = new QueryRoleTagListHeaders();
            return QueryRoleTagListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询角色</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryRoleTagListResponse
        /// </returns>
        public async Task<QueryRoleTagListResponse> QueryRoleTagListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoleTagListHeaders headers = new QueryRoleTagListHeaders();
            return await QueryRoleTagListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板分类</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryTemplateCategorysHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTemplateCategorysResponse
        /// </returns>
        public QueryTemplateCategorysResponse QueryTemplateCategorysWithOptions(QueryTemplateCategorysHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryTemplateCategorys",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates/categories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTemplateCategorysResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板分类</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryTemplateCategorysHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTemplateCategorysResponse
        /// </returns>
        public async Task<QueryTemplateCategorysResponse> QueryTemplateCategorysWithOptionsAsync(QueryTemplateCategorysHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryTemplateCategorys",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates/categories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTemplateCategorysResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板分类</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryTemplateCategorysResponse
        /// </returns>
        public QueryTemplateCategorysResponse QueryTemplateCategorys()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTemplateCategorysHeaders headers = new QueryTemplateCategorysHeaders();
            return QueryTemplateCategorysWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板分类</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryTemplateCategorysResponse
        /// </returns>
        public async Task<QueryTemplateCategorysResponse> QueryTemplateCategorysAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTemplateCategorysHeaders headers = new QueryTemplateCategorysHeaders();
            return await QueryTemplateCategorysWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤回模板审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallAuditTemplateRequest
        /// </param>
        /// <param name="headers">
        /// RecallAuditTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecallAuditTemplateResponse
        /// </returns>
        public RecallAuditTemplateResponse RecallAuditTemplateWithOptions(RecallAuditTemplateRequest request, RecallAuditTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeys))
            {
                body["templateKeys"] = request.TemplateKeys;
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
                Action = "RecallAuditTemplate",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates/audits/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallAuditTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤回模板审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallAuditTemplateRequest
        /// </param>
        /// <param name="headers">
        /// RecallAuditTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecallAuditTemplateResponse
        /// </returns>
        public async Task<RecallAuditTemplateResponse> RecallAuditTemplateWithOptionsAsync(RecallAuditTemplateRequest request, RecallAuditTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeys))
            {
                body["templateKeys"] = request.TemplateKeys;
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
                Action = "RecallAuditTemplate",
                Version = "apaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/apaas/templates/audits/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallAuditTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤回模板审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallAuditTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// RecallAuditTemplateResponse
        /// </returns>
        public RecallAuditTemplateResponse RecallAuditTemplate(RecallAuditTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallAuditTemplateHeaders headers = new RecallAuditTemplateHeaders();
            return RecallAuditTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤回模板审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallAuditTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// RecallAuditTemplateResponse
        /// </returns>
        public async Task<RecallAuditTemplateResponse> RecallAuditTemplateAsync(RecallAuditTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallAuditTemplateHeaders headers = new RecallAuditTemplateHeaders();
            return await RecallAuditTemplateWithOptionsAsync(request, headers, runtime);
        }

    }
}
