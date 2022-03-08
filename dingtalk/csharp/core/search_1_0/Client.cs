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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public BatchInsertSearchItemResponse BatchInsertSearchItem(string tabId, BatchInsertSearchItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchInsertSearchItemHeaders headers = new BatchInsertSearchItemHeaders();
            return BatchInsertSearchItemWithOptions(tabId, request, headers, runtime);
        }

        public async Task<BatchInsertSearchItemResponse> BatchInsertSearchItemAsync(string tabId, BatchInsertSearchItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchInsertSearchItemHeaders headers = new BatchInsertSearchItemHeaders();
            return await BatchInsertSearchItemWithOptionsAsync(tabId, request, headers, runtime);
        }

        public BatchInsertSearchItemResponse BatchInsertSearchItemWithOptions(string tabId, BatchInsertSearchItemRequest request, BatchInsertSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
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
            return TeaModel.ToObject<BatchInsertSearchItemResponse>(DoROARequest("BatchInsertSearchItem", "search_1.0", "HTTP", "POST", "AK", "/v1.0/search/tabs/" + tabId + "/items/batch", "none", req, runtime));
        }

        public async Task<BatchInsertSearchItemResponse> BatchInsertSearchItemWithOptionsAsync(string tabId, BatchInsertSearchItemRequest request, BatchInsertSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
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
            return TeaModel.ToObject<BatchInsertSearchItemResponse>(await DoROARequestAsync("BatchInsertSearchItem", "search_1.0", "HTTP", "POST", "AK", "/v1.0/search/tabs/" + tabId + "/items/batch", "none", req, runtime));
        }

        public CreateSearchTabResponse CreateSearchTab(CreateSearchTabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSearchTabHeaders headers = new CreateSearchTabHeaders();
            return CreateSearchTabWithOptions(request, headers, runtime);
        }

        public async Task<CreateSearchTabResponse> CreateSearchTabAsync(CreateSearchTabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSearchTabHeaders headers = new CreateSearchTabHeaders();
            return await CreateSearchTabWithOptionsAsync(request, headers, runtime);
        }

        public CreateSearchTabResponse CreateSearchTabWithOptions(CreateSearchTabRequest request, CreateSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
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
            return TeaModel.ToObject<CreateSearchTabResponse>(DoROARequest("CreateSearchTab", "search_1.0", "HTTP", "POST", "AK", "/v1.0/search/tabs", "json", req, runtime));
        }

        public async Task<CreateSearchTabResponse> CreateSearchTabWithOptionsAsync(CreateSearchTabRequest request, CreateSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
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
            return TeaModel.ToObject<CreateSearchTabResponse>(await DoROARequestAsync("CreateSearchTab", "search_1.0", "HTTP", "POST", "AK", "/v1.0/search/tabs", "json", req, runtime));
        }

        public DeleteSearchItemResponse DeleteSearchItem(string tabId, string itemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSearchItemHeaders headers = new DeleteSearchItemHeaders();
            return DeleteSearchItemWithOptions(tabId, itemId, headers, runtime);
        }

        public async Task<DeleteSearchItemResponse> DeleteSearchItemAsync(string tabId, string itemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSearchItemHeaders headers = new DeleteSearchItemHeaders();
            return await DeleteSearchItemWithOptionsAsync(tabId, itemId, headers, runtime);
        }

        public DeleteSearchItemResponse DeleteSearchItemWithOptions(string tabId, string itemId, DeleteSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
            itemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<DeleteSearchItemResponse>(DoROARequest("DeleteSearchItem", "search_1.0", "HTTP", "DELETE", "AK", "/v1.0/search/tabs/" + tabId + "/items/" + itemId, "none", req, runtime));
        }

        public async Task<DeleteSearchItemResponse> DeleteSearchItemWithOptionsAsync(string tabId, string itemId, DeleteSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
            itemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<DeleteSearchItemResponse>(await DoROARequestAsync("DeleteSearchItem", "search_1.0", "HTTP", "DELETE", "AK", "/v1.0/search/tabs/" + tabId + "/items/" + itemId, "none", req, runtime));
        }

        public DeleteSearchTabResponse DeleteSearchTab(string tabId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSearchTabHeaders headers = new DeleteSearchTabHeaders();
            return DeleteSearchTabWithOptions(tabId, headers, runtime);
        }

        public async Task<DeleteSearchTabResponse> DeleteSearchTabAsync(string tabId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSearchTabHeaders headers = new DeleteSearchTabHeaders();
            return await DeleteSearchTabWithOptionsAsync(tabId, headers, runtime);
        }

        public DeleteSearchTabResponse DeleteSearchTabWithOptions(string tabId, DeleteSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<DeleteSearchTabResponse>(DoROARequest("DeleteSearchTab", "search_1.0", "HTTP", "DELETE", "AK", "/v1.0/search/tabs/" + tabId, "none", req, runtime));
        }

        public async Task<DeleteSearchTabResponse> DeleteSearchTabWithOptionsAsync(string tabId, DeleteSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<DeleteSearchTabResponse>(await DoROARequestAsync("DeleteSearchTab", "search_1.0", "HTTP", "DELETE", "AK", "/v1.0/search/tabs/" + tabId, "none", req, runtime));
        }

        public GetSearchItemResponse GetSearchItem(string tabId, string itemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchItemHeaders headers = new GetSearchItemHeaders();
            return GetSearchItemWithOptions(tabId, itemId, headers, runtime);
        }

        public async Task<GetSearchItemResponse> GetSearchItemAsync(string tabId, string itemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchItemHeaders headers = new GetSearchItemHeaders();
            return await GetSearchItemWithOptionsAsync(tabId, itemId, headers, runtime);
        }

        public GetSearchItemResponse GetSearchItemWithOptions(string tabId, string itemId, GetSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
            itemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<GetSearchItemResponse>(DoROARequest("GetSearchItem", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs/" + tabId + "/items/" + itemId, "json", req, runtime));
        }

        public async Task<GetSearchItemResponse> GetSearchItemWithOptionsAsync(string tabId, string itemId, GetSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
            itemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<GetSearchItemResponse>(await DoROARequestAsync("GetSearchItem", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs/" + tabId + "/items/" + itemId, "json", req, runtime));
        }

        public GetSearchItemsByKeyWordResponse GetSearchItemsByKeyWord(string tabId, GetSearchItemsByKeyWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchItemsByKeyWordHeaders headers = new GetSearchItemsByKeyWordHeaders();
            return GetSearchItemsByKeyWordWithOptions(tabId, request, headers, runtime);
        }

        public async Task<GetSearchItemsByKeyWordResponse> GetSearchItemsByKeyWordAsync(string tabId, GetSearchItemsByKeyWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchItemsByKeyWordHeaders headers = new GetSearchItemsByKeyWordHeaders();
            return await GetSearchItemsByKeyWordWithOptionsAsync(tabId, request, headers, runtime);
        }

        public GetSearchItemsByKeyWordResponse GetSearchItemsByKeyWordWithOptions(string tabId, GetSearchItemsByKeyWordRequest request, GetSearchItemsByKeyWordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
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
            return TeaModel.ToObject<GetSearchItemsByKeyWordResponse>(DoROARequest("GetSearchItemsByKeyWord", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs/" + tabId + "/items", "json", req, runtime));
        }

        public async Task<GetSearchItemsByKeyWordResponse> GetSearchItemsByKeyWordWithOptionsAsync(string tabId, GetSearchItemsByKeyWordRequest request, GetSearchItemsByKeyWordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
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
            return TeaModel.ToObject<GetSearchItemsByKeyWordResponse>(await DoROARequestAsync("GetSearchItemsByKeyWord", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs/" + tabId + "/items", "json", req, runtime));
        }

        public GetSearchTabResponse GetSearchTab(string tabId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchTabHeaders headers = new GetSearchTabHeaders();
            return GetSearchTabWithOptions(tabId, headers, runtime);
        }

        public async Task<GetSearchTabResponse> GetSearchTabAsync(string tabId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSearchTabHeaders headers = new GetSearchTabHeaders();
            return await GetSearchTabWithOptionsAsync(tabId, headers, runtime);
        }

        public GetSearchTabResponse GetSearchTabWithOptions(string tabId, GetSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<GetSearchTabResponse>(DoROARequest("GetSearchTab", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs/" + tabId, "json", req, runtime));
        }

        public async Task<GetSearchTabResponse> GetSearchTabWithOptionsAsync(string tabId, GetSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<GetSearchTabResponse>(await DoROARequestAsync("GetSearchTab", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs/" + tabId, "json", req, runtime));
        }

        public InsertSearchItemResponse InsertSearchItem(string tabId, InsertSearchItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertSearchItemHeaders headers = new InsertSearchItemHeaders();
            return InsertSearchItemWithOptions(tabId, request, headers, runtime);
        }

        public async Task<InsertSearchItemResponse> InsertSearchItemAsync(string tabId, InsertSearchItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertSearchItemHeaders headers = new InsertSearchItemHeaders();
            return await InsertSearchItemWithOptionsAsync(tabId, request, headers, runtime);
        }

        public InsertSearchItemResponse InsertSearchItemWithOptions(string tabId, InsertSearchItemRequest request, InsertSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
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
            return TeaModel.ToObject<InsertSearchItemResponse>(DoROARequest("InsertSearchItem", "search_1.0", "HTTP", "POST", "AK", "/v1.0/search/tabs/" + tabId + "/items", "none", req, runtime));
        }

        public async Task<InsertSearchItemResponse> InsertSearchItemWithOptionsAsync(string tabId, InsertSearchItemRequest request, InsertSearchItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
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
            return TeaModel.ToObject<InsertSearchItemResponse>(await DoROARequestAsync("InsertSearchItem", "search_1.0", "HTTP", "POST", "AK", "/v1.0/search/tabs/" + tabId + "/items", "none", req, runtime));
        }

        public ListSearchTabsByOrgIdResponse ListSearchTabsByOrgId()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSearchTabsByOrgIdHeaders headers = new ListSearchTabsByOrgIdHeaders();
            return ListSearchTabsByOrgIdWithOptions(headers, runtime);
        }

        public async Task<ListSearchTabsByOrgIdResponse> ListSearchTabsByOrgIdAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSearchTabsByOrgIdHeaders headers = new ListSearchTabsByOrgIdHeaders();
            return await ListSearchTabsByOrgIdWithOptionsAsync(headers, runtime);
        }

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
            return TeaModel.ToObject<ListSearchTabsByOrgIdResponse>(DoROARequest("ListSearchTabsByOrgId", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs", "json", req, runtime));
        }

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
            return TeaModel.ToObject<ListSearchTabsByOrgIdResponse>(await DoROARequestAsync("ListSearchTabsByOrgId", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs", "json", req, runtime));
        }

        public UpdateSearchTabResponse UpdateSearchTab(string tabId, UpdateSearchTabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSearchTabHeaders headers = new UpdateSearchTabHeaders();
            return UpdateSearchTabWithOptions(tabId, request, headers, runtime);
        }

        public async Task<UpdateSearchTabResponse> UpdateSearchTabAsync(string tabId, UpdateSearchTabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSearchTabHeaders headers = new UpdateSearchTabHeaders();
            return await UpdateSearchTabWithOptionsAsync(tabId, request, headers, runtime);
        }

        public UpdateSearchTabResponse UpdateSearchTabWithOptions(string tabId, UpdateSearchTabRequest request, UpdateSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
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
            return TeaModel.ToObject<UpdateSearchTabResponse>(DoROARequest("UpdateSearchTab", "search_1.0", "HTTP", "PUT", "AK", "/v1.0/search/tabs/" + tabId, "none", req, runtime));
        }

        public async Task<UpdateSearchTabResponse> UpdateSearchTabWithOptionsAsync(string tabId, UpdateSearchTabRequest request, UpdateSearchTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            tabId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tabId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
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
            return TeaModel.ToObject<UpdateSearchTabResponse>(await DoROARequestAsync("UpdateSearchTab", "search_1.0", "HTTP", "PUT", "AK", "/v1.0/search/tabs/" + tabId, "none", req, runtime));
        }

    }
}
