// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalksearch_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public BatchInsertSearchItemResponse batchInsertSearchItem(String tabId, BatchInsertSearchItemRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchInsertSearchItemHeaders headers = new BatchInsertSearchItemHeaders();
        return this.batchInsertSearchItemWithOptions(tabId, request, headers, runtime);
    }

    public BatchInsertSearchItemResponse batchInsertSearchItemWithOptions(String tabId, BatchInsertSearchItemRequest request, BatchInsertSearchItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        tabId = com.aliyun.openapiutil.Client.getEncodeParam(tabId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.searchItemModels)) {
            body.put("searchItemModels", request.searchItemModels);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchInsertSearchItem", "search_1.0", "HTTP", "POST", "AK", "/v1.0/search/tabs/" + tabId + "/items/batch", "none", req, runtime), new BatchInsertSearchItemResponse());
    }

    public CreateSearchTabResponse createSearchTab(CreateSearchTabRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSearchTabHeaders headers = new CreateSearchTabHeaders();
        return this.createSearchTabWithOptions(request, headers, runtime);
    }

    public CreateSearchTabResponse createSearchTabWithOptions(CreateSearchTabRequest request, CreateSearchTabHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateSearchTab", "search_1.0", "HTTP", "POST", "AK", "/v1.0/search/tabs", "json", req, runtime), new CreateSearchTabResponse());
    }

    public DeleteSearchItemResponse deleteSearchItem(String tabId, String itemId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSearchItemHeaders headers = new DeleteSearchItemHeaders();
        return this.deleteSearchItemWithOptions(tabId, itemId, headers, runtime);
    }

    public DeleteSearchItemResponse deleteSearchItemWithOptions(String tabId, String itemId, DeleteSearchItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        tabId = com.aliyun.openapiutil.Client.getEncodeParam(tabId);
        itemId = com.aliyun.openapiutil.Client.getEncodeParam(itemId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("DeleteSearchItem", "search_1.0", "HTTP", "DELETE", "AK", "/v1.0/search/tabs/" + tabId + "/items/" + itemId + "", "none", req, runtime), new DeleteSearchItemResponse());
    }

    public DeleteSearchTabResponse deleteSearchTab(String tabId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSearchTabHeaders headers = new DeleteSearchTabHeaders();
        return this.deleteSearchTabWithOptions(tabId, headers, runtime);
    }

    public DeleteSearchTabResponse deleteSearchTabWithOptions(String tabId, DeleteSearchTabHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        tabId = com.aliyun.openapiutil.Client.getEncodeParam(tabId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("DeleteSearchTab", "search_1.0", "HTTP", "DELETE", "AK", "/v1.0/search/tabs/" + tabId + "", "none", req, runtime), new DeleteSearchTabResponse());
    }

    public GetSearchItemResponse getSearchItem(String tabId, String itemId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSearchItemHeaders headers = new GetSearchItemHeaders();
        return this.getSearchItemWithOptions(tabId, itemId, headers, runtime);
    }

    public GetSearchItemResponse getSearchItemWithOptions(String tabId, String itemId, GetSearchItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        tabId = com.aliyun.openapiutil.Client.getEncodeParam(tabId);
        itemId = com.aliyun.openapiutil.Client.getEncodeParam(itemId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetSearchItem", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs/" + tabId + "/items/" + itemId + "", "json", req, runtime), new GetSearchItemResponse());
    }

    public GetSearchItemsByKeyWordResponse getSearchItemsByKeyWord(String tabId, GetSearchItemsByKeyWordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSearchItemsByKeyWordHeaders headers = new GetSearchItemsByKeyWordHeaders();
        return this.getSearchItemsByKeyWordWithOptions(tabId, request, headers, runtime);
    }

    public GetSearchItemsByKeyWordResponse getSearchItemsByKeyWordWithOptions(String tabId, GetSearchItemsByKeyWordRequest request, GetSearchItemsByKeyWordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        tabId = com.aliyun.openapiutil.Client.getEncodeParam(tabId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.keyWord)) {
            query.put("keyWord", request.keyWord);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetSearchItemsByKeyWord", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs/" + tabId + "/items", "json", req, runtime), new GetSearchItemsByKeyWordResponse());
    }

    public GetSearchTabResponse getSearchTab(String tabId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSearchTabHeaders headers = new GetSearchTabHeaders();
        return this.getSearchTabWithOptions(tabId, headers, runtime);
    }

    public GetSearchTabResponse getSearchTabWithOptions(String tabId, GetSearchTabHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        tabId = com.aliyun.openapiutil.Client.getEncodeParam(tabId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetSearchTab", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs/" + tabId + "", "json", req, runtime), new GetSearchTabResponse());
    }

    public InsertSearchItemResponse insertSearchItem(String tabId, InsertSearchItemRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InsertSearchItemHeaders headers = new InsertSearchItemHeaders();
        return this.insertSearchItemWithOptions(tabId, request, headers, runtime);
    }

    public InsertSearchItemResponse insertSearchItemWithOptions(String tabId, InsertSearchItemRequest request, InsertSearchItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        tabId = com.aliyun.openapiutil.Client.getEncodeParam(tabId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.footer)) {
            body.put("footer", request.footer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.itemId)) {
            body.put("itemId", request.itemId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobileUrl)) {
            body.put("mobileUrl", request.mobileUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcUrl)) {
            body.put("pcUrl", request.pcUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summary)) {
            body.put("summary", request.summary);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.url)) {
            body.put("url", request.url);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("InsertSearchItem", "search_1.0", "HTTP", "POST", "AK", "/v1.0/search/tabs/" + tabId + "/items", "none", req, runtime), new InsertSearchItemResponse());
    }

    public ListSearchTabsByOrgIdResponse listSearchTabsByOrgId() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSearchTabsByOrgIdHeaders headers = new ListSearchTabsByOrgIdHeaders();
        return this.listSearchTabsByOrgIdWithOptions(headers, runtime);
    }

    public ListSearchTabsByOrgIdResponse listSearchTabsByOrgIdWithOptions(ListSearchTabsByOrgIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("ListSearchTabsByOrgId", "search_1.0", "HTTP", "GET", "AK", "/v1.0/search/tabs", "json", req, runtime), new ListSearchTabsByOrgIdResponse());
    }

    public UpdateSearchTabResponse updateSearchTab(String tabId, UpdateSearchTabRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateSearchTabHeaders headers = new UpdateSearchTabHeaders();
        return this.updateSearchTabWithOptions(tabId, request, headers, runtime);
    }

    public UpdateSearchTabResponse updateSearchTabWithOptions(String tabId, UpdateSearchTabRequest request, UpdateSearchTabHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        tabId = com.aliyun.openapiutil.Client.getEncodeParam(tabId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateSearchTab", "search_1.0", "HTTP", "PUT", "AK", "/v1.0/search/tabs/" + tabId + "", "none", req, runtime), new UpdateSearchTabResponse());
    }
}
