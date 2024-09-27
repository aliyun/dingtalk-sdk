// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalksearch_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalksearch_1_0
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
        /// <para>为指定的数据源批量添加数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchInsertSearchItemRequest
        /// </param>
        /// <param name="headers">
        /// BatchInsertSearchItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchInsertSearchItemResponse
        /// </returns>
        public BatchInsertSearchItemResponse BatchInsertSearchItemWithOptions(string tabId, BatchInsertSearchItemRequest request, BatchInsertSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchItemModels))
            {
                body["searchItemModels"] = request.SearchItemModels;
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
                Action = "BatchInsertSearchItem",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId + "/items/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<BatchInsertSearchItemResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定的数据源批量添加数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchInsertSearchItemRequest
        /// </param>
        /// <param name="headers">
        /// BatchInsertSearchItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchInsertSearchItemResponse
        /// </returns>
        public async Task<BatchInsertSearchItemResponse> BatchInsertSearchItemWithOptionsAsync(string tabId, BatchInsertSearchItemRequest request, BatchInsertSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchItemModels))
            {
                body["searchItemModels"] = request.SearchItemModels;
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
                Action = "BatchInsertSearchItem",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId + "/items/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<BatchInsertSearchItemResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定的数据源批量添加数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchInsertSearchItemRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchInsertSearchItemResponse
        /// </returns>
        public BatchInsertSearchItemResponse BatchInsertSearchItem(string tabId, BatchInsertSearchItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchInsertSearchItemHeaders headers = new BatchInsertSearchItemHeaders();
            return BatchInsertSearchItemWithOptions(tabId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定的数据源批量添加数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchInsertSearchItemRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchInsertSearchItemResponse
        /// </returns>
        public async Task<BatchInsertSearchItemResponse> BatchInsertSearchItemAsync(string tabId, BatchInsertSearchItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchInsertSearchItemHeaders headers = new BatchInsertSearchItemHeaders();
            return await BatchInsertSearchItemWithOptionsAsync(tabId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSearchTabRequest
        /// </param>
        /// <param name="headers">
        /// CreateSearchTabHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSearchTabResponse
        /// </returns>
        public CreateSearchTabResponse CreateSearchTabWithOptions(CreateSearchTabRequest request, CreateSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DarkIcon))
            {
                body["darkIcon"] = request.DarkIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "CreateSearchTab",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSearchTabResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSearchTabRequest
        /// </param>
        /// <param name="headers">
        /// CreateSearchTabHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSearchTabResponse
        /// </returns>
        public async Task<CreateSearchTabResponse> CreateSearchTabWithOptionsAsync(CreateSearchTabRequest request, CreateSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DarkIcon))
            {
                body["darkIcon"] = request.DarkIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "CreateSearchTab",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSearchTabResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSearchTabRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSearchTabResponse
        /// </returns>
        public CreateSearchTabResponse CreateSearchTab(CreateSearchTabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSearchTabHeaders headers = new CreateSearchTabHeaders();
            return CreateSearchTabWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSearchTabRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSearchTabResponse
        /// </returns>
        public async Task<CreateSearchTabResponse> CreateSearchTabAsync(CreateSearchTabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSearchTabHeaders headers = new CreateSearchTabHeaders();
            return await CreateSearchTabWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从指定的数据源中删除一条数据项</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteSearchItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSearchItemResponse
        /// </returns>
        public DeleteSearchItemResponse DeleteSearchItemWithOptions(string tabId, string itemId, DeleteSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSearchItem",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId + "/items/" + itemId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSearchItemResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从指定的数据源中删除一条数据项</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteSearchItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSearchItemResponse
        /// </returns>
        public async Task<DeleteSearchItemResponse> DeleteSearchItemWithOptionsAsync(string tabId, string itemId, DeleteSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSearchItem",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId + "/items/" + itemId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSearchItemResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从指定的数据源中删除一条数据项</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSearchItemResponse
        /// </returns>
        public DeleteSearchItemResponse DeleteSearchItem(string tabId, string itemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSearchItemHeaders headers = new DeleteSearchItemHeaders();
            return DeleteSearchItemWithOptions(tabId, itemId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从指定的数据源中删除一条数据项</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSearchItemResponse
        /// </returns>
        public async Task<DeleteSearchItemResponse> DeleteSearchItemAsync(string tabId, string itemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSearchItemHeaders headers = new DeleteSearchItemHeaders();
            return await DeleteSearchItemWithOptionsAsync(tabId, itemId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteSearchTabHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSearchTabResponse
        /// </returns>
        public DeleteSearchTabResponse DeleteSearchTabWithOptions(string tabId, DeleteSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSearchTab",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSearchTabResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteSearchTabHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSearchTabResponse
        /// </returns>
        public async Task<DeleteSearchTabResponse> DeleteSearchTabWithOptionsAsync(string tabId, DeleteSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSearchTab",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSearchTabResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除搜索数据源</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSearchTabResponse
        /// </returns>
        public DeleteSearchTabResponse DeleteSearchTab(string tabId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSearchTabHeaders headers = new DeleteSearchTabHeaders();
            return DeleteSearchTabWithOptions(tabId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除搜索数据源</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSearchTabResponse
        /// </returns>
        public async Task<DeleteSearchTabResponse> DeleteSearchTabAsync(string tabId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSearchTabHeaders headers = new DeleteSearchTabHeaders();
            return await DeleteSearchTabWithOptionsAsync(tabId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定数据源中的一条数据项</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSearchItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSearchItemResponse
        /// </returns>
        public GetSearchItemResponse GetSearchItemWithOptions(string tabId, string itemId, GetSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSearchItem",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId + "/items/" + itemId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSearchItemResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定数据源中的一条数据项</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSearchItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSearchItemResponse
        /// </returns>
        public async Task<GetSearchItemResponse> GetSearchItemWithOptionsAsync(string tabId, string itemId, GetSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSearchItem",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId + "/items/" + itemId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSearchItemResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定数据源中的一条数据项</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSearchItemResponse
        /// </returns>
        public GetSearchItemResponse GetSearchItem(string tabId, string itemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchItemHeaders headers = new GetSearchItemHeaders();
            return GetSearchItemWithOptions(tabId, itemId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定数据源中的一条数据项</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSearchItemResponse
        /// </returns>
        public async Task<GetSearchItemResponse> GetSearchItemAsync(string tabId, string itemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchItemHeaders headers = new GetSearchItemHeaders();
            return await GetSearchItemWithOptionsAsync(tabId, itemId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据搜索关键词获取相关数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSearchItemsByKeyWordRequest
        /// </param>
        /// <param name="headers">
        /// GetSearchItemsByKeyWordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSearchItemsByKeyWordResponse
        /// </returns>
        public GetSearchItemsByKeyWordResponse GetSearchItemsByKeyWordWithOptions(string tabId, GetSearchItemsByKeyWordRequest request, GetSearchItemsByKeyWordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["keyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "GetSearchItemsByKeyWord",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId + "/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSearchItemsByKeyWordResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据搜索关键词获取相关数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSearchItemsByKeyWordRequest
        /// </param>
        /// <param name="headers">
        /// GetSearchItemsByKeyWordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSearchItemsByKeyWordResponse
        /// </returns>
        public async Task<GetSearchItemsByKeyWordResponse> GetSearchItemsByKeyWordWithOptionsAsync(string tabId, GetSearchItemsByKeyWordRequest request, GetSearchItemsByKeyWordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["keyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "GetSearchItemsByKeyWord",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId + "/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSearchItemsByKeyWordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据搜索关键词获取相关数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSearchItemsByKeyWordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSearchItemsByKeyWordResponse
        /// </returns>
        public GetSearchItemsByKeyWordResponse GetSearchItemsByKeyWord(string tabId, GetSearchItemsByKeyWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchItemsByKeyWordHeaders headers = new GetSearchItemsByKeyWordHeaders();
            return GetSearchItemsByKeyWordWithOptions(tabId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据搜索关键词获取相关数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSearchItemsByKeyWordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSearchItemsByKeyWordResponse
        /// </returns>
        public async Task<GetSearchItemsByKeyWordResponse> GetSearchItemsByKeyWordAsync(string tabId, GetSearchItemsByKeyWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchItemsByKeyWordHeaders headers = new GetSearchItemsByKeyWordHeaders();
            return await GetSearchItemsByKeyWordWithOptionsAsync(tabId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSearchTabHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSearchTabResponse
        /// </returns>
        public GetSearchTabResponse GetSearchTabWithOptions(string tabId, GetSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSearchTab",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSearchTabResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSearchTabHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSearchTabResponse
        /// </returns>
        public async Task<GetSearchTabResponse> GetSearchTabWithOptionsAsync(string tabId, GetSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSearchTab",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSearchTabResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取搜索数据源</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSearchTabResponse
        /// </returns>
        public GetSearchTabResponse GetSearchTab(string tabId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchTabHeaders headers = new GetSearchTabHeaders();
            return GetSearchTabWithOptions(tabId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取搜索数据源</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSearchTabResponse
        /// </returns>
        public async Task<GetSearchTabResponse> GetSearchTabAsync(string tabId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchTabHeaders headers = new GetSearchTabHeaders();
            return await GetSearchTabWithOptionsAsync(tabId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定的数据源添加一条数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertSearchItemRequest
        /// </param>
        /// <param name="headers">
        /// InsertSearchItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertSearchItemResponse
        /// </returns>
        public InsertSearchItemResponse InsertSearchItemWithOptions(string tabId, InsertSearchItemRequest request, InsertSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Footer))
            {
                body["footer"] = request.Footer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["itemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileUrl))
            {
                body["mobileUrl"] = request.MobileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcUrl))
            {
                body["pcUrl"] = request.PcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
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
                Action = "InsertSearchItem",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId + "/items",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<InsertSearchItemResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定的数据源添加一条数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertSearchItemRequest
        /// </param>
        /// <param name="headers">
        /// InsertSearchItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertSearchItemResponse
        /// </returns>
        public async Task<InsertSearchItemResponse> InsertSearchItemWithOptionsAsync(string tabId, InsertSearchItemRequest request, InsertSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Footer))
            {
                body["footer"] = request.Footer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["itemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileUrl))
            {
                body["mobileUrl"] = request.MobileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcUrl))
            {
                body["pcUrl"] = request.PcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
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
                Action = "InsertSearchItem",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId + "/items",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<InsertSearchItemResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定的数据源添加一条数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertSearchItemRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertSearchItemResponse
        /// </returns>
        public InsertSearchItemResponse InsertSearchItem(string tabId, InsertSearchItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertSearchItemHeaders headers = new InsertSearchItemHeaders();
            return InsertSearchItemWithOptions(tabId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定的数据源添加一条数据项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertSearchItemRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertSearchItemResponse
        /// </returns>
        public async Task<InsertSearchItemResponse> InsertSearchItemAsync(string tabId, InsertSearchItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertSearchItemHeaders headers = new InsertSearchItemHeaders();
            return await InsertSearchItemWithOptionsAsync(tabId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出企业所有的搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListSearchTabsByOrgIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTabsByOrgIdResponse
        /// </returns>
        public ListSearchTabsByOrgIdResponse ListSearchTabsByOrgIdWithOptions(ListSearchTabsByOrgIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListSearchTabsByOrgId",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSearchTabsByOrgIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出企业所有的搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListSearchTabsByOrgIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTabsByOrgIdResponse
        /// </returns>
        public async Task<ListSearchTabsByOrgIdResponse> ListSearchTabsByOrgIdWithOptionsAsync(ListSearchTabsByOrgIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListSearchTabsByOrgId",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSearchTabsByOrgIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出企业所有的搜索数据源</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSearchTabsByOrgIdResponse
        /// </returns>
        public ListSearchTabsByOrgIdResponse ListSearchTabsByOrgId()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSearchTabsByOrgIdHeaders headers = new ListSearchTabsByOrgIdHeaders();
            return ListSearchTabsByOrgIdWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出企业所有的搜索数据源</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSearchTabsByOrgIdResponse
        /// </returns>
        public async Task<ListSearchTabsByOrgIdResponse> ListSearchTabsByOrgIdAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSearchTabsByOrgIdHeaders headers = new ListSearchTabsByOrgIdHeaders();
            return await ListSearchTabsByOrgIdWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSearchTabRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSearchTabHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSearchTabResponse
        /// </returns>
        public UpdateSearchTabResponse UpdateSearchTabWithOptions(string tabId, UpdateSearchTabRequest request, UpdateSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DarkIcon))
            {
                body["darkIcon"] = request.DarkIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "UpdateSearchTab",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateSearchTabResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSearchTabRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSearchTabHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSearchTabResponse
        /// </returns>
        public async Task<UpdateSearchTabResponse> UpdateSearchTabWithOptionsAsync(string tabId, UpdateSearchTabRequest request, UpdateSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DarkIcon))
            {
                body["darkIcon"] = request.DarkIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "UpdateSearchTab",
                Version = "search_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/search/tabs/" + tabId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateSearchTabResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSearchTabRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSearchTabResponse
        /// </returns>
        public UpdateSearchTabResponse UpdateSearchTab(string tabId, UpdateSearchTabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSearchTabHeaders headers = new UpdateSearchTabHeaders();
            return UpdateSearchTabWithOptions(tabId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新搜索数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSearchTabRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSearchTabResponse
        /// </returns>
        public async Task<UpdateSearchTabResponse> UpdateSearchTabAsync(string tabId, UpdateSearchTabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSearchTabHeaders headers = new UpdateSearchTabHeaders();
            return await UpdateSearchTabWithOptionsAsync(tabId, request, headers, runtime);
        }

    }
}
