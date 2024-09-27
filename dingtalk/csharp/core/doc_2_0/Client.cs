// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdoc_2_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0
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
        /// <para>批量创建小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateTeamRequest
        /// </param>
        /// <param name="headers">
        /// BatchCreateTeamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateTeamResponse
        /// </returns>
        public BatchCreateTeamResponse BatchCreateTeamWithOptions(BatchCreateTeamRequest request, BatchCreateTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "BatchCreateTeam",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateTeamResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateTeamRequest
        /// </param>
        /// <param name="headers">
        /// BatchCreateTeamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateTeamResponse
        /// </returns>
        public async Task<BatchCreateTeamResponse> BatchCreateTeamWithOptionsAsync(BatchCreateTeamRequest request, BatchCreateTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "BatchCreateTeam",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateTeamResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateTeamResponse
        /// </returns>
        public BatchCreateTeamResponse BatchCreateTeam(BatchCreateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateTeamHeaders headers = new BatchCreateTeamHeaders();
            return BatchCreateTeamWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateTeamResponse
        /// </returns>
        public async Task<BatchCreateTeamResponse> BatchCreateTeamAsync(BatchCreateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateTeamHeaders headers = new BatchCreateTeamHeaders();
            return await BatchCreateTeamWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除文档最近记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteRecentsRequest
        /// </param>
        /// <param name="headers">
        /// BatchDeleteRecentsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteRecentsResponse
        /// </returns>
        public BatchDeleteRecentsResponse BatchDeleteRecentsWithOptions(BatchDeleteRecentsRequest request, BatchDeleteRecentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryUuids))
            {
                body["dentryUuids"] = request.DentryUuids;
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
                Action = "BatchDeleteRecents",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/recentRecords/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteRecentsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除文档最近记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteRecentsRequest
        /// </param>
        /// <param name="headers">
        /// BatchDeleteRecentsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteRecentsResponse
        /// </returns>
        public async Task<BatchDeleteRecentsResponse> BatchDeleteRecentsWithOptionsAsync(BatchDeleteRecentsRequest request, BatchDeleteRecentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryUuids))
            {
                body["dentryUuids"] = request.DentryUuids;
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
                Action = "BatchDeleteRecents",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/recentRecords/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteRecentsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除文档最近记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteRecentsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteRecentsResponse
        /// </returns>
        public BatchDeleteRecentsResponse BatchDeleteRecents(BatchDeleteRecentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteRecentsHeaders headers = new BatchDeleteRecentsHeaders();
            return BatchDeleteRecentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除文档最近记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteRecentsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteRecentsResponse
        /// </returns>
        public async Task<BatchDeleteRecentsResponse> BatchDeleteRecentsAsync(BatchDeleteRecentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteRecentsHeaders headers = new BatchDeleteRecentsHeaders();
            return await BatchDeleteRecentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按分类列表查询模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CategoriesTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// CategoriesTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CategoriesTemplatesResponse
        /// </returns>
        public CategoriesTemplatesResponse CategoriesTemplatesWithOptions(CategoriesTemplatesRequest request, CategoriesTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "CategoriesTemplates",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/categoryLists/templates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CategoriesTemplatesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按分类列表查询模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CategoriesTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// CategoriesTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CategoriesTemplatesResponse
        /// </returns>
        public async Task<CategoriesTemplatesResponse> CategoriesTemplatesWithOptionsAsync(CategoriesTemplatesRequest request, CategoriesTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "CategoriesTemplates",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/categoryLists/templates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CategoriesTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按分类列表查询模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CategoriesTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// CategoriesTemplatesResponse
        /// </returns>
        public CategoriesTemplatesResponse CategoriesTemplates(CategoriesTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CategoriesTemplatesHeaders headers = new CategoriesTemplatesHeaders();
            return CategoriesTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按分类列表查询模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CategoriesTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// CategoriesTemplatesResponse
        /// </returns>
        public async Task<CategoriesTemplatesResponse> CategoriesTemplatesAsync(CategoriesTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CategoriesTemplatesHeaders headers = new CategoriesTemplatesHeaders();
            return await CategoriesTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按分类查询模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CategoryTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// CategoryTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CategoryTemplatesResponse
        /// </returns>
        public CategoryTemplatesResponse CategoryTemplatesWithOptions(CategoryTemplatesRequest request, CategoryTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "CategoryTemplates",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/categories/templates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CategoryTemplatesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按分类查询模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CategoryTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// CategoryTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CategoryTemplatesResponse
        /// </returns>
        public async Task<CategoryTemplatesResponse> CategoryTemplatesWithOptionsAsync(CategoryTemplatesRequest request, CategoryTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "CategoryTemplates",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/categories/templates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CategoryTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按分类查询模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CategoryTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// CategoryTemplatesResponse
        /// </returns>
        public CategoryTemplatesResponse CategoryTemplates(CategoryTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CategoryTemplatesHeaders headers = new CategoryTemplatesHeaders();
            return CategoryTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按分类查询模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CategoryTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// CategoryTemplatesResponse
        /// </returns>
        public async Task<CategoryTemplatesResponse> CategoryTemplatesAsync(CategoryTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CategoryTemplatesHeaders headers = new CategoryTemplatesHeaders();
            return await CategoryTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝知识库节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentryRequest
        /// </param>
        /// <param name="headers">
        /// CopyDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyDentryResponse
        /// </returns>
        public CopyDentryResponse CopyDentryWithOptions(string spaceId, string dentryId, CopyDentryRequest request, CopyDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToNextDentryId))
            {
                body["toNextDentryId"] = request.ToNextDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentDentryId))
            {
                body["toParentDentryId"] = request.ToParentDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToPrevDentryId))
            {
                body["toPrevDentryId"] = request.ToPrevDentryId;
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
                Action = "CopyDentry",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDentryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝知识库节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentryRequest
        /// </param>
        /// <param name="headers">
        /// CopyDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyDentryResponse
        /// </returns>
        public async Task<CopyDentryResponse> CopyDentryWithOptionsAsync(string spaceId, string dentryId, CopyDentryRequest request, CopyDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToNextDentryId))
            {
                body["toNextDentryId"] = request.ToNextDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentDentryId))
            {
                body["toParentDentryId"] = request.ToParentDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToPrevDentryId))
            {
                body["toPrevDentryId"] = request.ToPrevDentryId;
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
                Action = "CopyDentry",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝知识库节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyDentryResponse
        /// </returns>
        public CopyDentryResponse CopyDentry(string spaceId, string dentryId, CopyDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyDentryHeaders headers = new CopyDentryHeaders();
            return CopyDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝知识库节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyDentryResponse
        /// </returns>
        public async Task<CopyDentryResponse> CopyDentryAsync(string spaceId, string dentryId, CopyDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyDentryHeaders headers = new CopyDentryHeaders();
            return await CopyDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库节点（包括文档和文件夹）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDentryRequest
        /// </param>
        /// <param name="headers">
        /// CreateDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDentryResponse
        /// </returns>
        public CreateDentryResponse CreateDentryWithOptions(string spaceId, CreateDentryRequest request, CreateDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryType))
            {
                body["dentryType"] = request.DentryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentType))
            {
                body["documentType"] = request.DocumentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDentryId))
            {
                body["parentDentryId"] = request.ParentDentryId;
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
                Action = "CreateDentry",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/dentries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDentryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库节点（包括文档和文件夹）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDentryRequest
        /// </param>
        /// <param name="headers">
        /// CreateDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDentryResponse
        /// </returns>
        public async Task<CreateDentryResponse> CreateDentryWithOptionsAsync(string spaceId, CreateDentryRequest request, CreateDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryType))
            {
                body["dentryType"] = request.DentryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentType))
            {
                body["documentType"] = request.DocumentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDentryId))
            {
                body["parentDentryId"] = request.ParentDentryId;
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
                Action = "CreateDentry",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/dentries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库节点（包括文档和文件夹）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDentryResponse
        /// </returns>
        public CreateDentryResponse CreateDentry(string spaceId, CreateDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDentryHeaders headers = new CreateDentryHeaders();
            return CreateDentryWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库节点（包括文档和文件夹）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDentryResponse
        /// </returns>
        public async Task<CreateDentryResponse> CreateDentryAsync(string spaceId, CreateDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDentryHeaders headers = new CreateDentryHeaders();
            return await CreateDentryWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSpaceRequest
        /// </param>
        /// <param name="headers">
        /// CreateSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSpaceResponse
        /// </returns>
        public CreateSpaceResponse CreateSpaceWithOptions(CreateSpaceRequest request, CreateSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionId))
            {
                body["sectionId"] = request.SectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareScope))
            {
                body["shareScope"] = request.ShareScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                body["teamId"] = request.TeamId;
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
                Action = "CreateSpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSpaceRequest
        /// </param>
        /// <param name="headers">
        /// CreateSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSpaceResponse
        /// </returns>
        public async Task<CreateSpaceResponse> CreateSpaceWithOptionsAsync(CreateSpaceRequest request, CreateSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionId))
            {
                body["sectionId"] = request.SectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareScope))
            {
                body["shareScope"] = request.ShareScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                body["teamId"] = request.TeamId;
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
                Action = "CreateSpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSpaceResponse
        /// </returns>
        public CreateSpaceResponse CreateSpace(CreateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSpaceHeaders headers = new CreateSpaceHeaders();
            return CreateSpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSpaceResponse
        /// </returns>
        public async Task<CreateSpaceResponse> CreateSpaceAsync(CreateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSpaceHeaders headers = new CreateSpaceHeaders();
            return await CreateSpaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTeamRequest
        /// </param>
        /// <param name="headers">
        /// CreateTeamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public CreateTeamResponse CreateTeamWithOptions(CreateTeamRequest request, CreateTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cover))
            {
                body["cover"] = request.Cover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamType))
            {
                body["teamType"] = request.TeamType;
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
                Action = "CreateTeam",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTeamResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTeamRequest
        /// </param>
        /// <param name="headers">
        /// CreateTeamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public async Task<CreateTeamResponse> CreateTeamWithOptionsAsync(CreateTeamRequest request, CreateTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cover))
            {
                body["cover"] = request.Cover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamType))
            {
                body["teamType"] = request.TeamType;
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
                Action = "CreateTeam",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTeamResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public CreateTeamResponse CreateTeam(CreateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTeamHeaders headers = new CreateTeamHeaders();
            return CreateTeamWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public async Task<CreateTeamResponse> CreateTeamAsync(CreateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTeamHeaders headers = new CreateTeamHeaders();
            return await CreateTeamWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>跨组织迁移知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CrossOrgMigrateRequest
        /// </param>
        /// <param name="headers">
        /// CrossOrgMigrateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CrossOrgMigrateResponse
        /// </returns>
        public CrossOrgMigrateResponse CrossOrgMigrateWithOptions(CrossOrgMigrateRequest request, CrossOrgMigrateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "CrossOrgMigrate",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/crossOrganizations/spaces/migrate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CrossOrgMigrateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>跨组织迁移知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CrossOrgMigrateRequest
        /// </param>
        /// <param name="headers">
        /// CrossOrgMigrateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CrossOrgMigrateResponse
        /// </returns>
        public async Task<CrossOrgMigrateResponse> CrossOrgMigrateWithOptionsAsync(CrossOrgMigrateRequest request, CrossOrgMigrateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "CrossOrgMigrate",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/crossOrganizations/spaces/migrate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CrossOrgMigrateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>跨组织迁移知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CrossOrgMigrateRequest
        /// </param>
        /// 
        /// <returns>
        /// CrossOrgMigrateResponse
        /// </returns>
        public CrossOrgMigrateResponse CrossOrgMigrate(CrossOrgMigrateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CrossOrgMigrateHeaders headers = new CrossOrgMigrateHeaders();
            return CrossOrgMigrateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>跨组织迁移知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CrossOrgMigrateRequest
        /// </param>
        /// 
        /// <returns>
        /// CrossOrgMigrateResponse
        /// </returns>
        public async Task<CrossOrgMigrateResponse> CrossOrgMigrateAsync(CrossOrgMigrateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CrossOrgMigrateHeaders headers = new CrossOrgMigrateHeaders();
            return await CrossOrgMigrateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// <param name="headers">
        /// DeleteTeamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public DeleteTeamResponse DeleteTeamWithOptions(string teamId, DeleteTeamRequest request, DeleteTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "DeleteTeam",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTeamResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// <param name="headers">
        /// DeleteTeamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public async Task<DeleteTeamResponse> DeleteTeamWithOptionsAsync(string teamId, DeleteTeamRequest request, DeleteTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "DeleteTeam",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTeamResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public DeleteTeamResponse DeleteTeam(string teamId, DeleteTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTeamHeaders headers = new DeleteTeamHeaders();
            return DeleteTeamWithOptions(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public async Task<DeleteTeamResponse> DeleteTeamAsync(string teamId, DeleteTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTeamHeaders headers = new DeleteTeamHeaders();
            return await DeleteTeamWithOptionsAsync(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocContentRequest
        /// </param>
        /// <param name="headers">
        /// DocContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocContentResponse
        /// </returns>
        public DocContentResponse DocContentWithOptions(string dentryUuid, DocContentRequest request, DocContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Action = "DocContent",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryUuid + "/contents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocContentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocContentRequest
        /// </param>
        /// <param name="headers">
        /// DocContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocContentResponse
        /// </returns>
        public async Task<DocContentResponse> DocContentWithOptionsAsync(string dentryUuid, DocContentRequest request, DocContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Action = "DocContent",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryUuid + "/contents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocContentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DocContentResponse
        /// </returns>
        public DocContentResponse DocContent(string dentryUuid, DocContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocContentHeaders headers = new DocContentHeaders();
            return DocContentWithOptions(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DocContentResponse
        /// </returns>
        public async Task<DocContentResponse> DocContentAsync(string dentryUuid, DocContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocContentHeaders headers = new DocContentHeaders();
            return await DocContentWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportDocRequest
        /// </param>
        /// <param name="headers">
        /// ExportDocHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportDocResponse
        /// </returns>
        public ExportDocResponse ExportDocWithOptions(ExportDocRequest request, ExportDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "ExportDoc",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportDocResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportDocRequest
        /// </param>
        /// <param name="headers">
        /// ExportDocHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportDocResponse
        /// </returns>
        public async Task<ExportDocResponse> ExportDocWithOptionsAsync(ExportDocRequest request, ExportDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "ExportDoc",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportDocResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportDocRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportDocResponse
        /// </returns>
        public ExportDocResponse ExportDoc(ExportDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExportDocHeaders headers = new ExportDocHeaders();
            return ExportDocWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportDocRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportDocResponse
        /// </returns>
        public async Task<ExportDocResponse> ExportDocAsync(ExportDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExportDocHeaders headers = new ExportDocHeaders();
            return await ExportDocWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文件DentryUuid获取文件DentryId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryIdByUuidRequest
        /// </param>
        /// <param name="headers">
        /// GetDentryIdByUuidHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDentryIdByUuidResponse
        /// </returns>
        public GetDentryIdByUuidResponse GetDentryIdByUuidWithOptions(string dentryUuid, GetDentryIdByUuidRequest request, GetDentryIdByUuidHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetDentryIdByUuid",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryUuid + "/queryDentryId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryIdByUuidResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文件DentryUuid获取文件DentryId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryIdByUuidRequest
        /// </param>
        /// <param name="headers">
        /// GetDentryIdByUuidHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDentryIdByUuidResponse
        /// </returns>
        public async Task<GetDentryIdByUuidResponse> GetDentryIdByUuidWithOptionsAsync(string dentryUuid, GetDentryIdByUuidRequest request, GetDentryIdByUuidHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetDentryIdByUuid",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryUuid + "/queryDentryId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryIdByUuidResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文件DentryUuid获取文件DentryId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryIdByUuidRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDentryIdByUuidResponse
        /// </returns>
        public GetDentryIdByUuidResponse GetDentryIdByUuid(string dentryUuid, GetDentryIdByUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryIdByUuidHeaders headers = new GetDentryIdByUuidHeaders();
            return GetDentryIdByUuidWithOptions(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文件DentryUuid获取文件DentryId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryIdByUuidRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDentryIdByUuidResponse
        /// </returns>
        public async Task<GetDentryIdByUuidResponse> GetDentryIdByUuidAsync(string dentryUuid, GetDentryIdByUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryIdByUuidHeaders headers = new GetDentryIdByUuidHeaders();
            return await GetDentryIdByUuidWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocContentRequest
        /// </param>
        /// <param name="headers">
        /// GetDocContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocContentResponse
        /// </returns>
        public GetDocContentResponse GetDocContentWithOptions(string dentryUuid, GetDocContentRequest request, GetDocContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateCp))
            {
                query["generateCp"] = request.GenerateCp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFormat))
            {
                query["targetFormat"] = request.TargetFormat;
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
                Action = "GetDocContent",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/me/query/" + dentryUuid + "/contents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocContentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocContentRequest
        /// </param>
        /// <param name="headers">
        /// GetDocContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocContentResponse
        /// </returns>
        public async Task<GetDocContentResponse> GetDocContentWithOptionsAsync(string dentryUuid, GetDocContentRequest request, GetDocContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateCp))
            {
                query["generateCp"] = request.GenerateCp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFormat))
            {
                query["targetFormat"] = request.TargetFormat;
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
                Action = "GetDocContent",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/me/query/" + dentryUuid + "/contents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocContentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocContentResponse
        /// </returns>
        public GetDocContentResponse GetDocContent(string dentryUuid, GetDocContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocContentHeaders headers = new GetDocContentHeaders();
            return GetDocContentWithOptions(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocContentResponse
        /// </returns>
        public async Task<GetDocContentResponse> GetDocContentAsync(string dentryUuid, GetDocContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocContentHeaders headers = new GetDocContentHeaders();
            return await GetDocContentWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocContentForELMRequest
        /// </param>
        /// <param name="headers">
        /// GetDocContentForELMHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocContentForELMResponse
        /// </returns>
        public GetDocContentForELMResponse GetDocContentForELMWithOptions(string dentryUuid, GetDocContentForELMRequest request, GetDocContentForELMHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFormat))
            {
                query["targetFormat"] = request.TargetFormat;
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
                Action = "GetDocContentForELM",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/elm/me/dentries/" + dentryUuid + "/contents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocContentForELMResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocContentForELMRequest
        /// </param>
        /// <param name="headers">
        /// GetDocContentForELMHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocContentForELMResponse
        /// </returns>
        public async Task<GetDocContentForELMResponse> GetDocContentForELMWithOptionsAsync(string dentryUuid, GetDocContentForELMRequest request, GetDocContentForELMHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFormat))
            {
                query["targetFormat"] = request.TargetFormat;
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
                Action = "GetDocContentForELM",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/elm/me/dentries/" + dentryUuid + "/contents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocContentForELMResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocContentForELMRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocContentForELMResponse
        /// </returns>
        public GetDocContentForELMResponse GetDocContentForELM(string dentryUuid, GetDocContentForELMRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocContentForELMHeaders headers = new GetDocContentForELMHeaders();
            return GetDocContentForELMWithOptions(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocContentForELMRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocContentForELMResponse
        /// </returns>
        public async Task<GetDocContentForELMResponse> GetDocContentForELMAsync(string dentryUuid, GetDocContentForELMRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocContentForELMHeaders headers = new GetDocContentForELMHeaders();
            return await GetDocContentForELMWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前企业下钉盘目录我的文件对应的空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMySpaceRequest
        /// </param>
        /// <param name="headers">
        /// GetMySpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMySpaceResponse
        /// </returns>
        public GetMySpaceResponse GetMySpaceWithOptions(GetMySpaceRequest request, GetMySpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMySpace))
            {
                query["isMySpace"] = request.IsMySpace;
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
                Action = "GetMySpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/me/mySpace/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMySpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前企业下钉盘目录我的文件对应的空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMySpaceRequest
        /// </param>
        /// <param name="headers">
        /// GetMySpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMySpaceResponse
        /// </returns>
        public async Task<GetMySpaceResponse> GetMySpaceWithOptionsAsync(GetMySpaceRequest request, GetMySpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMySpace))
            {
                query["isMySpace"] = request.IsMySpace;
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
                Action = "GetMySpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/me/mySpace/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMySpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前企业下钉盘目录我的文件对应的空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMySpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMySpaceResponse
        /// </returns>
        public GetMySpaceResponse GetMySpace(GetMySpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMySpaceHeaders headers = new GetMySpaceHeaders();
            return GetMySpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前企业下钉盘目录我的文件对应的空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMySpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMySpaceResponse
        /// </returns>
        public async Task<GetMySpaceResponse> GetMySpaceAsync(GetMySpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMySpaceHeaders headers = new GetMySpaceHeaders();
            return await GetMySpaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组主页schema （包括轮播图、公告、便捷入口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSchemaRequest
        /// </param>
        /// <param name="headers">
        /// GetSchemaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSchemaResponse
        /// </returns>
        public GetSchemaResponse GetSchemaWithOptions(string teamId, GetSchemaRequest request, GetSchemaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetSchema",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/schemas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSchemaResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组主页schema （包括轮播图、公告、便捷入口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSchemaRequest
        /// </param>
        /// <param name="headers">
        /// GetSchemaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSchemaResponse
        /// </returns>
        public async Task<GetSchemaResponse> GetSchemaWithOptionsAsync(string teamId, GetSchemaRequest request, GetSchemaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetSchema",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/schemas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSchemaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组主页schema （包括轮播图、公告、便捷入口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSchemaResponse
        /// </returns>
        public GetSchemaResponse GetSchema(string teamId, GetSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSchemaHeaders headers = new GetSchemaHeaders();
            return GetSchemaWithOptions(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组主页schema （包括轮播图、公告、便捷入口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSchemaResponse
        /// </returns>
        public async Task<GetSchemaResponse> GetSchemaAsync(string teamId, GetSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSchemaHeaders headers = new GetSchemaHeaders();
            return await GetSchemaWithOptionsAsync(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询目录树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceDirectoriesRequest
        /// </param>
        /// <param name="headers">
        /// GetSpaceDirectoriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceDirectoriesResponse
        /// </returns>
        public GetSpaceDirectoriesResponse GetSpaceDirectoriesWithOptions(string spaceId, GetSpaceDirectoriesRequest request, GetSpaceDirectoriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                query["dentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetSpaceDirectories",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/directories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceDirectoriesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询目录树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceDirectoriesRequest
        /// </param>
        /// <param name="headers">
        /// GetSpaceDirectoriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceDirectoriesResponse
        /// </returns>
        public async Task<GetSpaceDirectoriesResponse> GetSpaceDirectoriesWithOptionsAsync(string spaceId, GetSpaceDirectoriesRequest request, GetSpaceDirectoriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                query["dentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetSpaceDirectories",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/directories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceDirectoriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询目录树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceDirectoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceDirectoriesResponse
        /// </returns>
        public GetSpaceDirectoriesResponse GetSpaceDirectories(string spaceId, GetSpaceDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceDirectoriesHeaders headers = new GetSpaceDirectoriesHeaders();
            return GetSpaceDirectoriesWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询目录树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceDirectoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceDirectoriesResponse
        /// </returns>
        public async Task<GetSpaceDirectoriesResponse> GetSpaceDirectoriesAsync(string spaceId, GetSpaceDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceDirectoriesHeaders headers = new GetSpaceDirectoriesHeaders();
            return await GetSpaceDirectoriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取星标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStarInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetStarInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStarInfoResponse
        /// </returns>
        public GetStarInfoResponse GetStarInfoWithOptions(string dentryUuid, GetStarInfoRequest request, GetStarInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetStarInfo",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryUuid + "/starInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStarInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取星标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStarInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetStarInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStarInfoResponse
        /// </returns>
        public async Task<GetStarInfoResponse> GetStarInfoWithOptionsAsync(string dentryUuid, GetStarInfoRequest request, GetStarInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetStarInfo",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryUuid + "/starInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStarInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取星标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStarInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStarInfoResponse
        /// </returns>
        public GetStarInfoResponse GetStarInfo(string dentryUuid, GetStarInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStarInfoHeaders headers = new GetStarInfoHeaders();
            return GetStarInfoWithOptions(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取星标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStarInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStarInfoResponse
        /// </returns>
        public async Task<GetStarInfoResponse> GetStarInfoAsync(string dentryUuid, GetStarInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStarInfoHeaders headers = new GetStarInfoHeaders();
            return await GetStarInfoWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// <param name="headers">
        /// GetTeamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public GetTeamResponse GetTeamWithOptions(string teamId, GetTeamRequest request, GetTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetTeam",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTeamResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// <param name="headers">
        /// GetTeamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public async Task<GetTeamResponse> GetTeamWithOptionsAsync(string teamId, GetTeamRequest request, GetTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetTeam",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTeamResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public GetTeamResponse GetTeam(string teamId, GetTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTeamHeaders headers = new GetTeamHeaders();
            return GetTeamWithOptions(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public async Task<GetTeamResponse> GetTeamAsync(string teamId, GetTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTeamHeaders headers = new GetTeamHeaders();
            return await GetTeamWithOptionsAsync(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库下的总节点数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTotalNumberOfDentriesRequest
        /// </param>
        /// <param name="headers">
        /// GetTotalNumberOfDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTotalNumberOfDentriesResponse
        /// </returns>
        public GetTotalNumberOfDentriesResponse GetTotalNumberOfDentriesWithOptions(GetTotalNumberOfDentriesRequest request, GetTotalNumberOfDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeFolder))
            {
                query["includeFolder"] = request.IncludeFolder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceTypes))
            {
                query["spaceTypes"] = request.SpaceTypes;
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
                Action = "GetTotalNumberOfDentries",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/statistics/dentryCounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTotalNumberOfDentriesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库下的总节点数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTotalNumberOfDentriesRequest
        /// </param>
        /// <param name="headers">
        /// GetTotalNumberOfDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTotalNumberOfDentriesResponse
        /// </returns>
        public async Task<GetTotalNumberOfDentriesResponse> GetTotalNumberOfDentriesWithOptionsAsync(GetTotalNumberOfDentriesRequest request, GetTotalNumberOfDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeFolder))
            {
                query["includeFolder"] = request.IncludeFolder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceTypes))
            {
                query["spaceTypes"] = request.SpaceTypes;
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
                Action = "GetTotalNumberOfDentries",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/statistics/dentryCounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTotalNumberOfDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库下的总节点数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTotalNumberOfDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTotalNumberOfDentriesResponse
        /// </returns>
        public GetTotalNumberOfDentriesResponse GetTotalNumberOfDentries(GetTotalNumberOfDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTotalNumberOfDentriesHeaders headers = new GetTotalNumberOfDentriesHeaders();
            return GetTotalNumberOfDentriesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库下的总节点数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTotalNumberOfDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTotalNumberOfDentriesResponse
        /// </returns>
        public async Task<GetTotalNumberOfDentriesResponse> GetTotalNumberOfDentriesAsync(GetTotalNumberOfDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTotalNumberOfDentriesHeaders headers = new GetTotalNumberOfDentriesHeaders();
            return await GetTotalNumberOfDentriesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库总数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTotalNumberOfSpacesRequest
        /// </param>
        /// <param name="headers">
        /// GetTotalNumberOfSpacesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTotalNumberOfSpacesResponse
        /// </returns>
        public GetTotalNumberOfSpacesResponse GetTotalNumberOfSpacesWithOptions(GetTotalNumberOfSpacesRequest request, GetTotalNumberOfSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetTotalNumberOfSpaces",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/statistics/spaceCounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTotalNumberOfSpacesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库总数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTotalNumberOfSpacesRequest
        /// </param>
        /// <param name="headers">
        /// GetTotalNumberOfSpacesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTotalNumberOfSpacesResponse
        /// </returns>
        public async Task<GetTotalNumberOfSpacesResponse> GetTotalNumberOfSpacesWithOptionsAsync(GetTotalNumberOfSpacesRequest request, GetTotalNumberOfSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetTotalNumberOfSpaces",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/statistics/spaceCounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTotalNumberOfSpacesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库总数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTotalNumberOfSpacesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTotalNumberOfSpacesResponse
        /// </returns>
        public GetTotalNumberOfSpacesResponse GetTotalNumberOfSpaces(GetTotalNumberOfSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTotalNumberOfSpacesHeaders headers = new GetTotalNumberOfSpacesHeaders();
            return GetTotalNumberOfSpacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库总数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTotalNumberOfSpacesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTotalNumberOfSpacesResponse
        /// </returns>
        public async Task<GetTotalNumberOfSpacesResponse> GetTotalNumberOfSpacesAsync(GetTotalNumberOfSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTotalNumberOfSpacesHeaders headers = new GetTotalNumberOfSpacesHeaders();
            return await GetTotalNumberOfSpacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档免登的用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInfoByOpenTokenRequest
        /// </param>
        /// <param name="headers">
        /// GetUserInfoByOpenTokenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoByOpenTokenResponse
        /// </returns>
        public GetUserInfoByOpenTokenResponse GetUserInfoByOpenTokenWithOptions(GetUserInfoByOpenTokenRequest request, GetUserInfoByOpenTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocKey))
            {
                query["docKey"] = request.DocKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenToken))
            {
                query["openToken"] = request.OpenToken;
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
                Action = "GetUserInfoByOpenToken",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/userInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoByOpenTokenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档免登的用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInfoByOpenTokenRequest
        /// </param>
        /// <param name="headers">
        /// GetUserInfoByOpenTokenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoByOpenTokenResponse
        /// </returns>
        public async Task<GetUserInfoByOpenTokenResponse> GetUserInfoByOpenTokenWithOptionsAsync(GetUserInfoByOpenTokenRequest request, GetUserInfoByOpenTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocKey))
            {
                query["docKey"] = request.DocKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenToken))
            {
                query["openToken"] = request.OpenToken;
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
                Action = "GetUserInfoByOpenToken",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/userInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoByOpenTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档免登的用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInfoByOpenTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoByOpenTokenResponse
        /// </returns>
        public GetUserInfoByOpenTokenResponse GetUserInfoByOpenToken(GetUserInfoByOpenTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoByOpenTokenHeaders headers = new GetUserInfoByOpenTokenHeaders();
            return GetUserInfoByOpenTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档免登的用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInfoByOpenTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoByOpenTokenResponse
        /// </returns>
        public async Task<GetUserInfoByOpenTokenResponse> GetUserInfoByOpenTokenAsync(GetUserInfoByOpenTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoByOpenTokenHeaders headers = new GetUserInfoByOpenTokenHeaders();
            return await GetUserInfoByOpenTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文件DentryId获取文件DentryUuid</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUuidByDentryIdRequest
        /// </param>
        /// <param name="headers">
        /// GetUuidByDentryIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUuidByDentryIdResponse
        /// </returns>
        public GetUuidByDentryIdResponse GetUuidByDentryIdWithOptions(string dentryId, GetUuidByDentryIdRequest request, GetUuidByDentryIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                query["spaceId"] = request.SpaceId;
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
                Action = "GetUuidByDentryId",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryId + "/queryDentryUuid",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUuidByDentryIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文件DentryId获取文件DentryUuid</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUuidByDentryIdRequest
        /// </param>
        /// <param name="headers">
        /// GetUuidByDentryIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUuidByDentryIdResponse
        /// </returns>
        public async Task<GetUuidByDentryIdResponse> GetUuidByDentryIdWithOptionsAsync(string dentryId, GetUuidByDentryIdRequest request, GetUuidByDentryIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                query["spaceId"] = request.SpaceId;
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
                Action = "GetUuidByDentryId",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryId + "/queryDentryUuid",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUuidByDentryIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文件DentryId获取文件DentryUuid</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUuidByDentryIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUuidByDentryIdResponse
        /// </returns>
        public GetUuidByDentryIdResponse GetUuidByDentryId(string dentryId, GetUuidByDentryIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUuidByDentryIdHeaders headers = new GetUuidByDentryIdHeaders();
            return GetUuidByDentryIdWithOptions(dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文件DentryId获取文件DentryUuid</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUuidByDentryIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUuidByDentryIdResponse
        /// </returns>
        public async Task<GetUuidByDentryIdResponse> GetUuidByDentryIdAsync(string dentryId, GetUuidByDentryIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUuidByDentryIdHeaders headers = new GetUuidByDentryIdHeaders();
            return await GetUuidByDentryIdWithOptionsAsync(dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以超级管理员身份转交小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandoverTeamWithoutAuthRequest
        /// </param>
        /// <param name="headers">
        /// HandoverTeamWithoutAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HandoverTeamWithoutAuthResponse
        /// </returns>
        public HandoverTeamWithoutAuthResponse HandoverTeamWithoutAuthWithOptions(HandoverTeamWithoutAuthRequest request, HandoverTeamWithoutAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "HandoverTeamWithoutAuth",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/members/handoverWithoutAuth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandoverTeamWithoutAuthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以超级管理员身份转交小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandoverTeamWithoutAuthRequest
        /// </param>
        /// <param name="headers">
        /// HandoverTeamWithoutAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HandoverTeamWithoutAuthResponse
        /// </returns>
        public async Task<HandoverTeamWithoutAuthResponse> HandoverTeamWithoutAuthWithOptionsAsync(HandoverTeamWithoutAuthRequest request, HandoverTeamWithoutAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "HandoverTeamWithoutAuth",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/members/handoverWithoutAuth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandoverTeamWithoutAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以超级管理员身份转交小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandoverTeamWithoutAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// HandoverTeamWithoutAuthResponse
        /// </returns>
        public HandoverTeamWithoutAuthResponse HandoverTeamWithoutAuth(HandoverTeamWithoutAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HandoverTeamWithoutAuthHeaders headers = new HandoverTeamWithoutAuthHeaders();
            return HandoverTeamWithoutAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以超级管理员身份转交小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandoverTeamWithoutAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// HandoverTeamWithoutAuthResponse
        /// </returns>
        public async Task<HandoverTeamWithoutAuthResponse> HandoverTeamWithoutAuthAsync(HandoverTeamWithoutAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HandoverTeamWithoutAuthHeaders headers = new HandoverTeamWithoutAuthHeaders();
            return await HandoverTeamWithoutAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeedsRequest
        /// </param>
        /// <param name="headers">
        /// ListFeedsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeedsResponse
        /// </returns>
        public ListFeedsResponse ListFeedsWithOptions(string teamId, ListFeedsRequest request, ListFeedsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeFile))
            {
                query["excludeFile"] = request.ExcludeFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "ListFeeds",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/feeds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeedsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeedsRequest
        /// </param>
        /// <param name="headers">
        /// ListFeedsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeedsResponse
        /// </returns>
        public async Task<ListFeedsResponse> ListFeedsWithOptionsAsync(string teamId, ListFeedsRequest request, ListFeedsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeFile))
            {
                query["excludeFile"] = request.ExcludeFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "ListFeeds",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/feeds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeedsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeedsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeedsResponse
        /// </returns>
        public ListFeedsResponse ListFeeds(string teamId, ListFeedsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFeedsHeaders headers = new ListFeedsHeaders();
            return ListFeedsWithOptions(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeedsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeedsResponse
        /// </returns>
        public async Task<ListFeedsResponse> ListFeedsAsync(string teamId, ListFeedsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFeedsHeaders headers = new ListFeedsHeaders();
            return await ListFeedsWithOptionsAsync(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组热门文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotDocsRequest
        /// </param>
        /// <param name="headers">
        /// ListHotDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotDocsResponse
        /// </returns>
        public ListHotDocsResponse ListHotDocsWithOptions(string teamId, ListHotDocsRequest request, ListHotDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "ListHotDocs",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/hotDocs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotDocsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组热门文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotDocsRequest
        /// </param>
        /// <param name="headers">
        /// ListHotDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotDocsResponse
        /// </returns>
        public async Task<ListHotDocsResponse> ListHotDocsWithOptionsAsync(string teamId, ListHotDocsRequest request, ListHotDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "ListHotDocs",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/hotDocs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotDocsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组热门文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotDocsResponse
        /// </returns>
        public ListHotDocsResponse ListHotDocs(string teamId, ListHotDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotDocsHeaders headers = new ListHotDocsHeaders();
            return ListHotDocsWithOptions(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组热门文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotDocsResponse
        /// </returns>
        public async Task<ListHotDocsResponse> ListHotDocsAsync(string teamId, ListHotDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotDocsHeaders headers = new ListHotDocsHeaders();
            return await ListHotDocsWithOptionsAsync(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取置顶知识库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPinSpacesRequest
        /// </param>
        /// <param name="headers">
        /// ListPinSpacesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPinSpacesResponse
        /// </returns>
        public ListPinSpacesResponse ListPinSpacesWithOptions(ListPinSpacesRequest request, ListPinSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Action = "ListPinSpaces",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/pinLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPinSpacesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取置顶知识库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPinSpacesRequest
        /// </param>
        /// <param name="headers">
        /// ListPinSpacesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPinSpacesResponse
        /// </returns>
        public async Task<ListPinSpacesResponse> ListPinSpacesWithOptionsAsync(ListPinSpacesRequest request, ListPinSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Action = "ListPinSpaces",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/pinLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPinSpacesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取置顶知识库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPinSpacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPinSpacesResponse
        /// </returns>
        public ListPinSpacesResponse ListPinSpaces(ListPinSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPinSpacesHeaders headers = new ListPinSpacesHeaders();
            return ListPinSpacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取置顶知识库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPinSpacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPinSpacesResponse
        /// </returns>
        public async Task<ListPinSpacesResponse> ListPinSpacesAsync(ListPinSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPinSpacesHeaders headers = new ListPinSpacesHeaders();
            return await ListPinSpacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档最近记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecentsRequest
        /// </param>
        /// <param name="headers">
        /// ListRecentsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecentsResponse
        /// </returns>
        public ListRecentsResponse ListRecentsWithOptions(ListRecentsRequest request, ListRecentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "ListRecents",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/recentRecords/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档最近记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecentsRequest
        /// </param>
        /// <param name="headers">
        /// ListRecentsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecentsResponse
        /// </returns>
        public async Task<ListRecentsResponse> ListRecentsWithOptionsAsync(ListRecentsRequest request, ListRecentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "ListRecents",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/recentRecords/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档最近记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecentsResponse
        /// </returns>
        public ListRecentsResponse ListRecents(ListRecentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecentsHeaders headers = new ListRecentsHeaders();
            return ListRecentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档最近记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecentsResponse
        /// </returns>
        public async Task<ListRecentsResponse> ListRecentsAsync(ListRecentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecentsHeaders headers = new ListRecentsHeaders();
            return await ListRecentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询关联了知识库的团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRelatedSpaceTeamsRequest
        /// </param>
        /// <param name="headers">
        /// ListRelatedSpaceTeamsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRelatedSpaceTeamsResponse
        /// </returns>
        public ListRelatedSpaceTeamsResponse ListRelatedSpaceTeamsWithOptions(ListRelatedSpaceTeamsRequest request, ListRelatedSpaceTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "ListRelatedSpaceTeams",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/relations/spaceTeams",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRelatedSpaceTeamsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询关联了知识库的团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRelatedSpaceTeamsRequest
        /// </param>
        /// <param name="headers">
        /// ListRelatedSpaceTeamsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRelatedSpaceTeamsResponse
        /// </returns>
        public async Task<ListRelatedSpaceTeamsResponse> ListRelatedSpaceTeamsWithOptionsAsync(ListRelatedSpaceTeamsRequest request, ListRelatedSpaceTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "ListRelatedSpaceTeams",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/relations/spaceTeams",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRelatedSpaceTeamsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询关联了知识库的团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRelatedSpaceTeamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRelatedSpaceTeamsResponse
        /// </returns>
        public ListRelatedSpaceTeamsResponse ListRelatedSpaceTeams(ListRelatedSpaceTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRelatedSpaceTeamsHeaders headers = new ListRelatedSpaceTeamsHeaders();
            return ListRelatedSpaceTeamsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询关联了知识库的团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRelatedSpaceTeamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRelatedSpaceTeamsResponse
        /// </returns>
        public async Task<ListRelatedSpaceTeamsResponse> ListRelatedSpaceTeamsAsync(ListRelatedSpaceTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRelatedSpaceTeamsHeaders headers = new ListRelatedSpaceTeamsHeaders();
            return await ListRelatedSpaceTeamsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRelatedTeamsRequest
        /// </param>
        /// <param name="headers">
        /// ListRelatedTeamsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRelatedTeamsResponse
        /// </returns>
        public ListRelatedTeamsResponse ListRelatedTeamsWithOptions(ListRelatedTeamsRequest request, ListRelatedTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "ListRelatedTeams",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRelatedTeamsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRelatedTeamsRequest
        /// </param>
        /// <param name="headers">
        /// ListRelatedTeamsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRelatedTeamsResponse
        /// </returns>
        public async Task<ListRelatedTeamsResponse> ListRelatedTeamsWithOptionsAsync(ListRelatedTeamsRequest request, ListRelatedTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "ListRelatedTeams",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRelatedTeamsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRelatedTeamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRelatedTeamsResponse
        /// </returns>
        public ListRelatedTeamsResponse ListRelatedTeams(ListRelatedTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRelatedTeamsHeaders headers = new ListRelatedTeamsHeaders();
            return ListRelatedTeamsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRelatedTeamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRelatedTeamsResponse
        /// </returns>
        public async Task<ListRelatedTeamsResponse> ListRelatedTeamsAsync(ListRelatedTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRelatedTeamsHeaders headers = new ListRelatedTeamsHeaders();
            return await ListRelatedTeamsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSpaceSectionsRequest
        /// </param>
        /// <param name="headers">
        /// ListSpaceSectionsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSpaceSectionsResponse
        /// </returns>
        public ListSpaceSectionsResponse ListSpaceSectionsWithOptions(string teamId, ListSpaceSectionsRequest request, ListSpaceSectionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "ListSpaceSections",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/spaceSections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSpaceSectionsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSpaceSectionsRequest
        /// </param>
        /// <param name="headers">
        /// ListSpaceSectionsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSpaceSectionsResponse
        /// </returns>
        public async Task<ListSpaceSectionsResponse> ListSpaceSectionsWithOptionsAsync(string teamId, ListSpaceSectionsRequest request, ListSpaceSectionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "ListSpaceSections",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/spaceSections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSpaceSectionsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSpaceSectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSpaceSectionsResponse
        /// </returns>
        public ListSpaceSectionsResponse ListSpaceSections(string teamId, ListSpaceSectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSpaceSectionsHeaders headers = new ListSpaceSectionsHeaders();
            return ListSpaceSectionsWithOptions(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSpaceSectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSpaceSectionsResponse
        /// </returns>
        public async Task<ListSpaceSectionsResponse> ListSpaceSectionsAsync(string teamId, ListSpaceSectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSpaceSectionsHeaders headers = new ListSpaceSectionsHeaders();
            return await ListSpaceSectionsWithOptionsAsync(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取星标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStarsRequest
        /// </param>
        /// <param name="headers">
        /// ListStarsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStarsResponse
        /// </returns>
        public ListStarsResponse ListStarsWithOptions(ListStarsRequest request, ListStarsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Action = "ListStars",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/starLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStarsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取星标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStarsRequest
        /// </param>
        /// <param name="headers">
        /// ListStarsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStarsResponse
        /// </returns>
        public async Task<ListStarsResponse> ListStarsWithOptionsAsync(ListStarsRequest request, ListStarsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Action = "ListStars",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/starLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStarsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取星标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStarsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStarsResponse
        /// </returns>
        public ListStarsResponse ListStars(ListStarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListStarsHeaders headers = new ListStarsHeaders();
            return ListStarsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取星标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStarsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStarsResponse
        /// </returns>
        public async Task<ListStarsResponse> ListStarsAsync(ListStarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListStarsHeaders headers = new ListStarsHeaders();
            return await ListStarsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamMembersRequest
        /// </param>
        /// <param name="headers">
        /// ListTeamMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTeamMembersResponse
        /// </returns>
        public ListTeamMembersResponse ListTeamMembersWithOptions(string teamId, ListTeamMembersRequest request, ListTeamMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "ListTeamMembers",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamMembersRequest
        /// </param>
        /// <param name="headers">
        /// ListTeamMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTeamMembersResponse
        /// </returns>
        public async Task<ListTeamMembersResponse> ListTeamMembersWithOptionsAsync(string teamId, ListTeamMembersRequest request, ListTeamMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "ListTeamMembers",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTeamMembersResponse
        /// </returns>
        public ListTeamMembersResponse ListTeamMembers(string teamId, ListTeamMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTeamMembersHeaders headers = new ListTeamMembersHeaders();
            return ListTeamMembersWithOptions(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小组成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTeamMembersResponse
        /// </returns>
        public async Task<ListTeamMembersResponse> ListTeamMembersAsync(string teamId, ListTeamMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTeamMembersHeaders headers = new ListTeamMembersHeaders();
            return await ListTeamMembersWithOptionsAsync(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>标记星标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MarkStarRequest
        /// </param>
        /// <param name="headers">
        /// MarkStarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MarkStarResponse
        /// </returns>
        public MarkStarResponse MarkStarWithOptions(string dentryUuid, MarkStarRequest request, MarkStarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "MarkStar",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryUuid + "/stars/mark",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MarkStarResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>标记星标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MarkStarRequest
        /// </param>
        /// <param name="headers">
        /// MarkStarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MarkStarResponse
        /// </returns>
        public async Task<MarkStarResponse> MarkStarWithOptionsAsync(string dentryUuid, MarkStarRequest request, MarkStarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "MarkStar",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryUuid + "/stars/mark",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MarkStarResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>标记星标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MarkStarRequest
        /// </param>
        /// 
        /// <returns>
        /// MarkStarResponse
        /// </returns>
        public MarkStarResponse MarkStar(string dentryUuid, MarkStarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MarkStarHeaders headers = new MarkStarHeaders();
            return MarkStarWithOptions(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>标记星标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MarkStarRequest
        /// </param>
        /// 
        /// <returns>
        /// MarkStarResponse
        /// </returns>
        public async Task<MarkStarResponse> MarkStarAsync(string dentryUuid, MarkStarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MarkStarHeaders headers = new MarkStarHeaders();
            return await MarkStarWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动知识库节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentryRequest
        /// </param>
        /// <param name="headers">
        /// MoveDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveDentryResponse
        /// </returns>
        public MoveDentryResponse MoveDentryWithOptions(string spaceId, string dentryId, MoveDentryRequest request, MoveDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToNextDentryId))
            {
                body["toNextDentryId"] = request.ToNextDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentDentryId))
            {
                body["toParentDentryId"] = request.ToParentDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToPrevDentryId))
            {
                body["toPrevDentryId"] = request.ToPrevDentryId;
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
                Action = "MoveDentry",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/move",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveDentryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动知识库节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentryRequest
        /// </param>
        /// <param name="headers">
        /// MoveDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveDentryResponse
        /// </returns>
        public async Task<MoveDentryResponse> MoveDentryWithOptionsAsync(string spaceId, string dentryId, MoveDentryRequest request, MoveDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToNextDentryId))
            {
                body["toNextDentryId"] = request.ToNextDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentDentryId))
            {
                body["toParentDentryId"] = request.ToParentDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToPrevDentryId))
            {
                body["toPrevDentryId"] = request.ToPrevDentryId;
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
                Action = "MoveDentry",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/move",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveDentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动知识库节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveDentryResponse
        /// </returns>
        public MoveDentryResponse MoveDentry(string spaceId, string dentryId, MoveDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveDentryHeaders headers = new MoveDentryHeaders();
            return MoveDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动知识库节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveDentryResponse
        /// </returns>
        public async Task<MoveDentryResponse> MoveDentryAsync(string spaceId, string dentryId, MoveDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveDentryHeaders headers = new MoveDentryHeaders();
            return await MoveDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>置顶知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PinSpaceRequest
        /// </param>
        /// <param name="headers">
        /// PinSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PinSpaceResponse
        /// </returns>
        public PinSpaceResponse PinSpaceWithOptions(string spaceId, PinSpaceRequest request, PinSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "PinSpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/pin",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PinSpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>置顶知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PinSpaceRequest
        /// </param>
        /// <param name="headers">
        /// PinSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PinSpaceResponse
        /// </returns>
        public async Task<PinSpaceResponse> PinSpaceWithOptionsAsync(string spaceId, PinSpaceRequest request, PinSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "PinSpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/pin",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PinSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>置顶知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PinSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// PinSpaceResponse
        /// </returns>
        public PinSpaceResponse PinSpace(string spaceId, PinSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PinSpaceHeaders headers = new PinSpaceHeaders();
            return PinSpaceWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>置顶知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PinSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// PinSpaceResponse
        /// </returns>
        public async Task<PinSpaceResponse> PinSpaceAsync(string spaceId, PinSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PinSpaceHeaders headers = new PinSpaceHeaders();
            return await PinSpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库节点（包括文档和文件夹）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDentryRequest
        /// </param>
        /// <param name="headers">
        /// QueryDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDentryResponse
        /// </returns>
        public QueryDentryResponse QueryDentryWithOptions(string spaceId, string dentryId, QueryDentryRequest request, QueryDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeSpace))
            {
                query["includeSpace"] = request.IncludeSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "QueryDentry",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDentryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库节点（包括文档和文件夹）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDentryRequest
        /// </param>
        /// <param name="headers">
        /// QueryDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDentryResponse
        /// </returns>
        public async Task<QueryDentryResponse> QueryDentryWithOptionsAsync(string spaceId, string dentryId, QueryDentryRequest request, QueryDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeSpace))
            {
                query["includeSpace"] = request.IncludeSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "QueryDentry",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库节点（包括文档和文件夹）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDentryResponse
        /// </returns>
        public QueryDentryResponse QueryDentry(string spaceId, string dentryId, QueryDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDentryHeaders headers = new QueryDentryHeaders();
            return QueryDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库节点（包括文档和文件夹）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDentryResponse
        /// </returns>
        public async Task<QueryDentryResponse> QueryDentryAsync(string spaceId, string dentryId, QueryDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDentryHeaders headers = new QueryDentryHeaders();
            return await QueryDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocContentRequest
        /// </param>
        /// <param name="headers">
        /// QueryDocContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDocContentResponse
        /// </returns>
        public QueryDocContentResponse QueryDocContentWithOptions(string dentryUuid, QueryDocContentRequest request, QueryDocContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFormat))
            {
                query["targetFormat"] = request.TargetFormat;
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
                Action = "QueryDocContent",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/query/" + dentryUuid + "/contents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDocContentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocContentRequest
        /// </param>
        /// <param name="headers">
        /// QueryDocContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDocContentResponse
        /// </returns>
        public async Task<QueryDocContentResponse> QueryDocContentWithOptionsAsync(string dentryUuid, QueryDocContentRequest request, QueryDocContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFormat))
            {
                query["targetFormat"] = request.TargetFormat;
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
                Action = "QueryDocContent",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/query/" + dentryUuid + "/contents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDocContentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocContentRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDocContentResponse
        /// </returns>
        public QueryDocContentResponse QueryDocContent(string dentryUuid, QueryDocContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDocContentHeaders headers = new QueryDocContentHeaders();
            return QueryDocContentWithOptions(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocContentRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDocContentResponse
        /// </returns>
        public async Task<QueryDocContentResponse> QueryDocContentAsync(string dentryUuid, QueryDocContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDocContentHeaders headers = new QueryDocContentHeaders();
            return await QueryDocContentWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据链接查询节点或知识库信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryItemByUrlRequest
        /// </param>
        /// <param name="headers">
        /// QueryItemByUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryItemByUrlResponse
        /// </returns>
        public QueryItemByUrlResponse QueryItemByUrlWithOptions(QueryItemByUrlRequest request, QueryItemByUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatisticalInfo))
            {
                query["withStatisticalInfo"] = request.WithStatisticalInfo;
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
                Action = "QueryItemByUrl",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemByUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据链接查询节点或知识库信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryItemByUrlRequest
        /// </param>
        /// <param name="headers">
        /// QueryItemByUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryItemByUrlResponse
        /// </returns>
        public async Task<QueryItemByUrlResponse> QueryItemByUrlWithOptionsAsync(QueryItemByUrlRequest request, QueryItemByUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatisticalInfo))
            {
                query["withStatisticalInfo"] = request.WithStatisticalInfo;
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
                Action = "QueryItemByUrl",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemByUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据链接查询节点或知识库信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryItemByUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryItemByUrlResponse
        /// </returns>
        public QueryItemByUrlResponse QueryItemByUrl(QueryItemByUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryItemByUrlHeaders headers = new QueryItemByUrlHeaders();
            return QueryItemByUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据链接查询节点或知识库信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryItemByUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryItemByUrlResponse
        /// </returns>
        public async Task<QueryItemByUrlResponse> QueryItemByUrlAsync(QueryItemByUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryItemByUrlHeaders headers = new QueryItemByUrlHeaders();
            return await QueryItemByUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的「我的文档」</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryMineSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMineSpaceResponse
        /// </returns>
        public QueryMineSpaceResponse QueryMineSpaceWithOptions(string unionId, QueryMineSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMineSpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/users/" + unionId + "/mine",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMineSpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的「我的文档」</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryMineSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMineSpaceResponse
        /// </returns>
        public async Task<QueryMineSpaceResponse> QueryMineSpaceWithOptionsAsync(string unionId, QueryMineSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMineSpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/users/" + unionId + "/mine",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMineSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的「我的文档」</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryMineSpaceResponse
        /// </returns>
        public QueryMineSpaceResponse QueryMineSpace(string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMineSpaceHeaders headers = new QueryMineSpaceHeaders();
            return QueryMineSpaceWithOptions(unionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的「我的文档」</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryMineSpaceResponse
        /// </returns>
        public async Task<QueryMineSpaceResponse> QueryMineSpaceAsync(string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMineSpaceHeaders headers = new QueryMineSpaceHeaders();
            return await QueryMineSpaceWithOptionsAsync(unionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecentListRequest
        /// </param>
        /// <param name="headers">
        /// QueryRecentListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRecentListResponse
        /// </returns>
        public QueryRecentListResponse QueryRecentListWithOptions(QueryRecentListRequest request, QueryRecentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorType))
            {
                query["creatorType"] = request.CreatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentType))
            {
                query["recentType"] = request.RecentType;
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
                Action = "QueryRecentList",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/docs/recent",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecentListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecentListRequest
        /// </param>
        /// <param name="headers">
        /// QueryRecentListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRecentListResponse
        /// </returns>
        public async Task<QueryRecentListResponse> QueryRecentListWithOptionsAsync(QueryRecentListRequest request, QueryRecentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorType))
            {
                query["creatorType"] = request.CreatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentType))
            {
                query["recentType"] = request.RecentType;
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
                Action = "QueryRecentList",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/docs/recent",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecentListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecentListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRecentListResponse
        /// </returns>
        public QueryRecentListResponse QueryRecentList(QueryRecentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRecentListHeaders headers = new QueryRecentListHeaders();
            return QueryRecentListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecentListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRecentListResponse
        /// </returns>
        public async Task<QueryRecentListResponse> QueryRecentListAsync(QueryRecentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRecentListHeaders headers = new QueryRecentListHeaders();
            return await QueryRecentListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定知识库信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySpaceRequest
        /// </param>
        /// <param name="headers">
        /// QuerySpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySpaceResponse
        /// </returns>
        public QuerySpaceResponse QuerySpaceWithOptions(string spaceId, QuerySpaceRequest request, QuerySpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "QuerySpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定知识库信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySpaceRequest
        /// </param>
        /// <param name="headers">
        /// QuerySpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySpaceResponse
        /// </returns>
        public async Task<QuerySpaceResponse> QuerySpaceWithOptionsAsync(string spaceId, QuerySpaceRequest request, QuerySpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "QuerySpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定知识库信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySpaceResponse
        /// </returns>
        public QuerySpaceResponse QuerySpace(string spaceId, QuerySpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySpaceHeaders headers = new QuerySpaceHeaders();
            return QuerySpaceWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定知识库信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySpaceResponse
        /// </returns>
        public async Task<QuerySpaceResponse> QuerySpaceAsync(string spaceId, QuerySpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySpaceHeaders headers = new QuerySpaceHeaders();
            return await QuerySpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询与我关联的知识库列表（支持筛选小组）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RelatedSpacesRequest
        /// </param>
        /// <param name="headers">
        /// RelatedSpacesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RelatedSpacesResponse
        /// </returns>
        public RelatedSpacesResponse RelatedSpacesWithOptions(RelatedSpacesRequest request, RelatedSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                query["teamId"] = request.TeamId;
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
                Action = "RelatedSpaces",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/relations/spaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RelatedSpacesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询与我关联的知识库列表（支持筛选小组）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RelatedSpacesRequest
        /// </param>
        /// <param name="headers">
        /// RelatedSpacesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RelatedSpacesResponse
        /// </returns>
        public async Task<RelatedSpacesResponse> RelatedSpacesWithOptionsAsync(RelatedSpacesRequest request, RelatedSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                query["teamId"] = request.TeamId;
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
                Action = "RelatedSpaces",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/relations/spaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RelatedSpacesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询与我关联的知识库列表（支持筛选小组）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RelatedSpacesRequest
        /// </param>
        /// 
        /// <returns>
        /// RelatedSpacesResponse
        /// </returns>
        public RelatedSpacesResponse RelatedSpaces(RelatedSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RelatedSpacesHeaders headers = new RelatedSpacesHeaders();
            return RelatedSpacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询与我关联的知识库列表（支持筛选小组）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RelatedSpacesRequest
        /// </param>
        /// 
        /// <returns>
        /// RelatedSpacesResponse
        /// </returns>
        public async Task<RelatedSpacesResponse> RelatedSpacesAsync(RelatedSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RelatedSpacesHeaders headers = new RelatedSpacesHeaders();
            return await RelatedSpacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除小组成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTeamMembersRequest
        /// </param>
        /// <param name="headers">
        /// RemoveTeamMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTeamMembersResponse
        /// </returns>
        public RemoveTeamMembersResponse RemoveTeamMembersWithOptions(string teamId, RemoveTeamMembersRequest request, RemoveTeamMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
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
                Action = "RemoveTeamMembers",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/members/remove",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTeamMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除小组成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTeamMembersRequest
        /// </param>
        /// <param name="headers">
        /// RemoveTeamMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTeamMembersResponse
        /// </returns>
        public async Task<RemoveTeamMembersResponse> RemoveTeamMembersWithOptionsAsync(string teamId, RemoveTeamMembersRequest request, RemoveTeamMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
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
                Action = "RemoveTeamMembers",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/members/remove",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTeamMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除小组成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTeamMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTeamMembersResponse
        /// </returns>
        public RemoveTeamMembersResponse RemoveTeamMembers(string teamId, RemoveTeamMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveTeamMembersHeaders headers = new RemoveTeamMembersHeaders();
            return RemoveTeamMembersWithOptions(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除小组成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTeamMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTeamMembersResponse
        /// </returns>
        public async Task<RemoveTeamMembersResponse> RemoveTeamMembersAsync(string teamId, RemoveTeamMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveTeamMembersHeaders headers = new RemoveTeamMembersHeaders();
            return await RemoveTeamMembersWithOptionsAsync(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>知识库节点（包括文档和文件夹）重命名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameDentryRequest
        /// </param>
        /// <param name="headers">
        /// RenameDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameDentryResponse
        /// </returns>
        public RenameDentryResponse RenameDentryWithOptions(string spaceId, string dentryId, RenameDentryRequest request, RenameDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "RenameDentry",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/rename",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameDentryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>知识库节点（包括文档和文件夹）重命名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameDentryRequest
        /// </param>
        /// <param name="headers">
        /// RenameDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameDentryResponse
        /// </returns>
        public async Task<RenameDentryResponse> RenameDentryWithOptionsAsync(string spaceId, string dentryId, RenameDentryRequest request, RenameDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "RenameDentry",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/rename",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameDentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>知识库节点（包括文档和文件夹）重命名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameDentryResponse
        /// </returns>
        public RenameDentryResponse RenameDentry(string spaceId, string dentryId, RenameDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameDentryHeaders headers = new RenameDentryHeaders();
            return RenameDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>知识库节点（包括文档和文件夹）重命名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameDentryResponse
        /// </returns>
        public async Task<RenameDentryResponse> RenameDentryAsync(string spaceId, string dentryId, RenameDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameDentryHeaders headers = new RenameDentryHeaders();
            return await RenameDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加或修改小组成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTeamMembersRequest
        /// </param>
        /// <param name="headers">
        /// SaveTeamMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTeamMembersResponse
        /// </returns>
        public SaveTeamMembersResponse SaveTeamMembersWithOptions(string teamId, SaveTeamMembersRequest request, SaveTeamMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
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
                Action = "SaveTeamMembers",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTeamMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加或修改小组成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTeamMembersRequest
        /// </param>
        /// <param name="headers">
        /// SaveTeamMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTeamMembersResponse
        /// </returns>
        public async Task<SaveTeamMembersResponse> SaveTeamMembersWithOptionsAsync(string teamId, SaveTeamMembersRequest request, SaveTeamMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
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
                Action = "SaveTeamMembers",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTeamMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加或修改小组成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTeamMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTeamMembersResponse
        /// </returns>
        public SaveTeamMembersResponse SaveTeamMembers(string teamId, SaveTeamMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveTeamMembersHeaders headers = new SaveTeamMembersHeaders();
            return SaveTeamMembersWithOptions(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加或修改小组成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTeamMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTeamMembersResponse
        /// </returns>
        public async Task<SaveTeamMembersResponse> SaveTeamMembersAsync(string teamId, SaveTeamMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveTeamMembersHeaders headers = new SaveTeamMembersHeaders();
            return await SaveTeamMembersWithOptionsAsync(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索知识库和节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchRequest
        /// </param>
        /// <param name="headers">
        /// SearchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchResponse
        /// </returns>
        public SearchResponse SearchWithOptions(SearchRequest request, SearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryRequest))
            {
                body["dentryRequest"] = request.DentryRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceRequest))
            {
                body["spaceRequest"] = request.SpaceRequest;
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
                Action = "Search",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索知识库和节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchRequest
        /// </param>
        /// <param name="headers">
        /// SearchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchResponse
        /// </returns>
        public async Task<SearchResponse> SearchWithOptionsAsync(SearchRequest request, SearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryRequest))
            {
                body["dentryRequest"] = request.DentryRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceRequest))
            {
                body["spaceRequest"] = request.SpaceRequest;
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
                Action = "Search",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索知识库和节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchResponse
        /// </returns>
        public SearchResponse Search(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchHeaders headers = new SearchHeaders();
            return SearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索知识库和节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchResponse
        /// </returns>
        public async Task<SearchResponse> SearchAsync(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchHeaders headers = new SearchHeaders();
            return await SearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索模板中心模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// SearchTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchTemplatesResponse
        /// </returns>
        public SearchTemplatesResponse SearchTemplatesWithOptions(SearchTemplatesRequest request, SearchTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "SearchTemplates",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/templates/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTemplatesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索模板中心模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// SearchTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchTemplatesResponse
        /// </returns>
        public async Task<SearchTemplatesResponse> SearchTemplatesWithOptionsAsync(SearchTemplatesRequest request, SearchTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "SearchTemplates",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/templates/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索模板中心模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchTemplatesResponse
        /// </returns>
        public SearchTemplatesResponse SearchTemplates(SearchTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTemplatesHeaders headers = new SearchTemplatesHeaders();
            return SearchTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索模板中心模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchTemplatesResponse
        /// </returns>
        public async Task<SearchTemplatesResponse> SearchTemplatesAsync(SearchTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTemplatesHeaders headers = new SearchTemplatesHeaders();
            return await SearchTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件打开链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ShareUrlRequest
        /// </param>
        /// <param name="headers">
        /// ShareUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ShareUrlResponse
        /// </returns>
        public ShareUrlResponse ShareUrlWithOptions(ShareUrlRequest request, ShareUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "ShareUrl",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/shareUrls/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ShareUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件打开链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ShareUrlRequest
        /// </param>
        /// <param name="headers">
        /// ShareUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ShareUrlResponse
        /// </returns>
        public async Task<ShareUrlResponse> ShareUrlWithOptionsAsync(ShareUrlRequest request, ShareUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "ShareUrl",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/shareUrls/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ShareUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件打开链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ShareUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// ShareUrlResponse
        /// </returns>
        public ShareUrlResponse ShareUrl(ShareUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ShareUrlHeaders headers = new ShareUrlHeaders();
            return ShareUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件打开链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ShareUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// ShareUrlResponse
        /// </returns>
        public async Task<ShareUrlResponse> ShareUrlAsync(ShareUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ShareUrlHeaders headers = new ShareUrlHeaders();
            return await ShareUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TeamTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// TeamTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TeamTemplatesResponse
        /// </returns>
        public TeamTemplatesResponse TeamTemplatesWithOptions(TeamTemplatesRequest request, TeamTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Action = "TeamTemplates",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/workspaces/templates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TeamTemplatesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TeamTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// TeamTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TeamTemplatesResponse
        /// </returns>
        public async Task<TeamTemplatesResponse> TeamTemplatesWithOptionsAsync(TeamTemplatesRequest request, TeamTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Action = "TeamTemplates",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/workspaces/templates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TeamTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TeamTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// TeamTemplatesResponse
        /// </returns>
        public TeamTemplatesResponse TeamTemplates(TeamTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TeamTemplatesHeaders headers = new TeamTemplatesHeaders();
            return TeamTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TeamTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// TeamTemplatesResponse
        /// </returns>
        public async Task<TeamTemplatesResponse> TeamTemplatesAsync(TeamTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TeamTemplatesHeaders headers = new TeamTemplatesHeaders();
            return await TeamTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板分类列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TemplateCategoriesRequest
        /// </param>
        /// <param name="headers">
        /// TemplateCategoriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TemplateCategoriesResponse
        /// </returns>
        public TemplateCategoriesResponse TemplateCategoriesWithOptions(TemplateCategoriesRequest request, TemplateCategoriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "TemplateCategories",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/templates/categories/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TemplateCategoriesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板分类列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TemplateCategoriesRequest
        /// </param>
        /// <param name="headers">
        /// TemplateCategoriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TemplateCategoriesResponse
        /// </returns>
        public async Task<TemplateCategoriesResponse> TemplateCategoriesWithOptionsAsync(TemplateCategoriesRequest request, TemplateCategoriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "TemplateCategories",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/templates/categories/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TemplateCategoriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板分类列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TemplateCategoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// TemplateCategoriesResponse
        /// </returns>
        public TemplateCategoriesResponse TemplateCategories(TemplateCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TemplateCategoriesHeaders headers = new TemplateCategoriesHeaders();
            return TemplateCategoriesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板分类列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TemplateCategoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// TemplateCategoriesResponse
        /// </returns>
        public async Task<TemplateCategoriesResponse> TemplateCategoriesAsync(TemplateCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TemplateCategoriesHeaders headers = new TemplateCategoriesHeaders();
            return await TemplateCategoriesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消标记星标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnmarkStarRequest
        /// </param>
        /// <param name="headers">
        /// UnmarkStarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnmarkStarResponse
        /// </returns>
        public UnmarkStarResponse UnmarkStarWithOptions(string dentryUuid, UnmarkStarRequest request, UnmarkStarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "UnmarkStar",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryUuid + "/stars/unmark",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnmarkStarResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消标记星标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnmarkStarRequest
        /// </param>
        /// <param name="headers">
        /// UnmarkStarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnmarkStarResponse
        /// </returns>
        public async Task<UnmarkStarResponse> UnmarkStarWithOptionsAsync(string dentryUuid, UnmarkStarRequest request, UnmarkStarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "UnmarkStar",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/dentries/" + dentryUuid + "/stars/unmark",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnmarkStarResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消标记星标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnmarkStarRequest
        /// </param>
        /// 
        /// <returns>
        /// UnmarkStarResponse
        /// </returns>
        public UnmarkStarResponse UnmarkStar(string dentryUuid, UnmarkStarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnmarkStarHeaders headers = new UnmarkStarHeaders();
            return UnmarkStarWithOptions(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消标记星标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnmarkStarRequest
        /// </param>
        /// 
        /// <returns>
        /// UnmarkStarResponse
        /// </returns>
        public async Task<UnmarkStarResponse> UnmarkStarAsync(string dentryUuid, UnmarkStarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnmarkStarHeaders headers = new UnmarkStarHeaders();
            return await UnmarkStarWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消置顶知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnpinSpaceRequest
        /// </param>
        /// <param name="headers">
        /// UnpinSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnpinSpaceResponse
        /// </returns>
        public UnpinSpaceResponse UnpinSpaceWithOptions(string spaceId, UnpinSpaceRequest request, UnpinSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "UnpinSpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/unpin",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnpinSpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消置顶知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnpinSpaceRequest
        /// </param>
        /// <param name="headers">
        /// UnpinSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnpinSpaceResponse
        /// </returns>
        public async Task<UnpinSpaceResponse> UnpinSpaceWithOptionsAsync(string spaceId, UnpinSpaceRequest request, UnpinSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "UnpinSpace",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/spaces/" + spaceId + "/unpin",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnpinSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消置顶知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnpinSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UnpinSpaceResponse
        /// </returns>
        public UnpinSpaceResponse UnpinSpace(string spaceId, UnpinSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnpinSpaceHeaders headers = new UnpinSpaceHeaders();
            return UnpinSpaceWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消置顶知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnpinSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UnpinSpaceResponse
        /// </returns>
        public async Task<UnpinSpaceResponse> UnpinSpaceAsync(string spaceId, UnpinSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnpinSpaceHeaders headers = new UnpinSpaceHeaders();
            return await UnpinSpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTeamRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTeamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public UpdateTeamResponse UpdateTeamWithOptions(string teamId, UpdateTeamRequest request, UpdateTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
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
                Action = "UpdateTeam",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTeamResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTeamRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTeamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public async Task<UpdateTeamResponse> UpdateTeamWithOptionsAsync(string teamId, UpdateTeamRequest request, UpdateTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
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
                Action = "UpdateTeam",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/teams/" + teamId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTeamResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public UpdateTeamResponse UpdateTeam(string teamId, UpdateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTeamHeaders headers = new UpdateTeamHeaders();
            return UpdateTeamWithOptions(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public async Task<UpdateTeamResponse> UpdateTeamAsync(string teamId, UpdateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTeamHeaders headers = new UpdateTeamHeaders();
            return await UpdateTeamWithOptionsAsync(teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UserTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// UserTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UserTemplatesResponse
        /// </returns>
        public UserTemplatesResponse UserTemplatesWithOptions(UserTemplatesRequest request, UserTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Action = "UserTemplates",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/users/templates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UserTemplatesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UserTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// UserTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UserTemplatesResponse
        /// </returns>
        public async Task<UserTemplatesResponse> UserTemplatesWithOptionsAsync(UserTemplatesRequest request, UserTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Action = "UserTemplates",
                Version = "doc_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/doc/users/templates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UserTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UserTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// UserTemplatesResponse
        /// </returns>
        public UserTemplatesResponse UserTemplates(UserTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserTemplatesHeaders headers = new UserTemplatesHeaders();
            return UserTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UserTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// UserTemplatesResponse
        /// </returns>
        public async Task<UserTemplatesResponse> UserTemplatesAsync(UserTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserTemplatesHeaders headers = new UserTemplatesHeaders();
            return await UserTemplatesWithOptionsAsync(request, headers, runtime);
        }

    }
}
