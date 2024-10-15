// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalksearch_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>为指定的数据源批量添加数据项</p>
     * 
     * @param request BatchInsertSearchItemRequest
     * @param headers BatchInsertSearchItemHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchInsertSearchItemResponse
     */
    public BatchInsertSearchItemResponse batchInsertSearchItemWithOptions(String tabId, BatchInsertSearchItemRequest request, BatchInsertSearchItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchInsertSearchItem"),
            new TeaPair("version", "search_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/search/tabs/" + tabId + "/items/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchInsertSearchItemResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>为指定的数据源批量添加数据项</p>
     * 
     * @param request BatchInsertSearchItemRequest
     * @return BatchInsertSearchItemResponse
     */
    public BatchInsertSearchItemResponse batchInsertSearchItem(String tabId, BatchInsertSearchItemRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchInsertSearchItemHeaders headers = new BatchInsertSearchItemHeaders();
        return this.batchInsertSearchItemWithOptions(tabId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建搜索数据源</p>
     * 
     * @param request CreateSearchTabRequest
     * @param headers CreateSearchTabHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateSearchTabResponse
     */
    public CreateSearchTabResponse createSearchTabWithOptions(CreateSearchTabRequest request, CreateSearchTabHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.darkIcon)) {
            body.put("darkIcon", request.darkIcon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateSearchTab"),
            new TeaPair("version", "search_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/search/tabs"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateSearchTabResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建搜索数据源</p>
     * 
     * @param request CreateSearchTabRequest
     * @return CreateSearchTabResponse
     */
    public CreateSearchTabResponse createSearchTab(CreateSearchTabRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSearchTabHeaders headers = new CreateSearchTabHeaders();
        return this.createSearchTabWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>从指定的数据源中删除一条数据项</p>
     * 
     * @param headers DeleteSearchItemHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteSearchItemResponse
     */
    public DeleteSearchItemResponse deleteSearchItemWithOptions(String tabId, String itemId, DeleteSearchItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteSearchItem"),
            new TeaPair("version", "search_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/search/tabs/" + tabId + "/items/" + itemId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteSearchItemResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>从指定的数据源中删除一条数据项</p>
     * @return DeleteSearchItemResponse
     */
    public DeleteSearchItemResponse deleteSearchItem(String tabId, String itemId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSearchItemHeaders headers = new DeleteSearchItemHeaders();
        return this.deleteSearchItemWithOptions(tabId, itemId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除搜索数据源</p>
     * 
     * @param headers DeleteSearchTabHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteSearchTabResponse
     */
    public DeleteSearchTabResponse deleteSearchTabWithOptions(String tabId, DeleteSearchTabHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteSearchTab"),
            new TeaPair("version", "search_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/search/tabs/" + tabId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteSearchTabResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除搜索数据源</p>
     * @return DeleteSearchTabResponse
     */
    public DeleteSearchTabResponse deleteSearchTab(String tabId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSearchTabHeaders headers = new DeleteSearchTabHeaders();
        return this.deleteSearchTabWithOptions(tabId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定数据源中的一条数据项</p>
     * 
     * @param headers GetSearchItemHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSearchItemResponse
     */
    public GetSearchItemResponse getSearchItemWithOptions(String tabId, String itemId, GetSearchItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSearchItem"),
            new TeaPair("version", "search_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/search/tabs/" + tabId + "/items/" + itemId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSearchItemResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定数据源中的一条数据项</p>
     * @return GetSearchItemResponse
     */
    public GetSearchItemResponse getSearchItem(String tabId, String itemId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSearchItemHeaders headers = new GetSearchItemHeaders();
        return this.getSearchItemWithOptions(tabId, itemId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据搜索关键词获取相关数据项</p>
     * 
     * @param request GetSearchItemsByKeyWordRequest
     * @param headers GetSearchItemsByKeyWordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSearchItemsByKeyWordResponse
     */
    public GetSearchItemsByKeyWordResponse getSearchItemsByKeyWordWithOptions(String tabId, GetSearchItemsByKeyWordRequest request, GetSearchItemsByKeyWordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSearchItemsByKeyWord"),
            new TeaPair("version", "search_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/search/tabs/" + tabId + "/items"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSearchItemsByKeyWordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据搜索关键词获取相关数据项</p>
     * 
     * @param request GetSearchItemsByKeyWordRequest
     * @return GetSearchItemsByKeyWordResponse
     */
    public GetSearchItemsByKeyWordResponse getSearchItemsByKeyWord(String tabId, GetSearchItemsByKeyWordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSearchItemsByKeyWordHeaders headers = new GetSearchItemsByKeyWordHeaders();
        return this.getSearchItemsByKeyWordWithOptions(tabId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取搜索数据源</p>
     * 
     * @param headers GetSearchTabHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSearchTabResponse
     */
    public GetSearchTabResponse getSearchTabWithOptions(String tabId, GetSearchTabHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSearchTab"),
            new TeaPair("version", "search_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/search/tabs/" + tabId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSearchTabResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取搜索数据源</p>
     * @return GetSearchTabResponse
     */
    public GetSearchTabResponse getSearchTab(String tabId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSearchTabHeaders headers = new GetSearchTabHeaders();
        return this.getSearchTabWithOptions(tabId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>为指定的数据源添加一条数据项</p>
     * 
     * @param request InsertSearchItemRequest
     * @param headers InsertSearchItemHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InsertSearchItemResponse
     */
    public InsertSearchItemResponse insertSearchItemWithOptions(String tabId, InsertSearchItemRequest request, InsertSearchItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "InsertSearchItem"),
            new TeaPair("version", "search_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/search/tabs/" + tabId + "/items"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InsertSearchItemResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>为指定的数据源添加一条数据项</p>
     * 
     * @param request InsertSearchItemRequest
     * @return InsertSearchItemResponse
     */
    public InsertSearchItemResponse insertSearchItem(String tabId, InsertSearchItemRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InsertSearchItemHeaders headers = new InsertSearchItemHeaders();
        return this.insertSearchItemWithOptions(tabId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>列出企业所有的搜索数据源</p>
     * 
     * @param headers ListSearchTabsByOrgIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListSearchTabsByOrgIdResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListSearchTabsByOrgId"),
            new TeaPair("version", "search_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/search/tabs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListSearchTabsByOrgIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>列出企业所有的搜索数据源</p>
     * @return ListSearchTabsByOrgIdResponse
     */
    public ListSearchTabsByOrgIdResponse listSearchTabsByOrgId() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSearchTabsByOrgIdHeaders headers = new ListSearchTabsByOrgIdHeaders();
        return this.listSearchTabsByOrgIdWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新搜索数据源</p>
     * 
     * @param request UpdateSearchTabRequest
     * @param headers UpdateSearchTabHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateSearchTabResponse
     */
    public UpdateSearchTabResponse updateSearchTabWithOptions(String tabId, UpdateSearchTabRequest request, UpdateSearchTabHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.darkIcon)) {
            body.put("darkIcon", request.darkIcon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateSearchTab"),
            new TeaPair("version", "search_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/search/tabs/" + tabId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateSearchTabResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新搜索数据源</p>
     * 
     * @param request UpdateSearchTabRequest
     * @return UpdateSearchTabResponse
     */
    public UpdateSearchTabResponse updateSearchTab(String tabId, UpdateSearchTabRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateSearchTabHeaders headers = new UpdateSearchTabHeaders();
        return this.updateSearchTabWithOptions(tabId, request, headers, runtime);
    }
}
