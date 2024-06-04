// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdoc_2_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public com.aliyun.gateway.spi.Client _client;
    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._client = new com.aliyun.gateway.dingtalk.Client();
        this._spi = _client;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * @summary 批量创建小组
     *
     * @param request BatchCreateTeamRequest
     * @param headers BatchCreateTeamHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchCreateTeamResponse
     */
    public BatchCreateTeamResponse batchCreateTeamWithOptions(BatchCreateTeamRequest request, BatchCreateTeamHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchCreateTeam"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchCreateTeamResponse());
    }

    /**
     * @summary 批量创建小组
     *
     * @param request BatchCreateTeamRequest
     * @return BatchCreateTeamResponse
     */
    public BatchCreateTeamResponse batchCreateTeam(BatchCreateTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchCreateTeamHeaders headers = new BatchCreateTeamHeaders();
        return this.batchCreateTeamWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量删除文档最近记录
     *
     * @param request BatchDeleteRecentsRequest
     * @param headers BatchDeleteRecentsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchDeleteRecentsResponse
     */
    public BatchDeleteRecentsResponse batchDeleteRecentsWithOptions(BatchDeleteRecentsRequest request, BatchDeleteRecentsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryUuids)) {
            body.put("dentryUuids", request.dentryUuids);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchDeleteRecents"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/dentries/recentRecords/batchRemove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchDeleteRecentsResponse());
    }

    /**
     * @summary 批量删除文档最近记录
     *
     * @param request BatchDeleteRecentsRequest
     * @return BatchDeleteRecentsResponse
     */
    public BatchDeleteRecentsResponse batchDeleteRecents(BatchDeleteRecentsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchDeleteRecentsHeaders headers = new BatchDeleteRecentsHeaders();
        return this.batchDeleteRecentsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 按分类列表查询模板列表
     *
     * @param request CategoriesTemplatesRequest
     * @param headers CategoriesTemplatesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CategoriesTemplatesResponse
     */
    public CategoriesTemplatesResponse categoriesTemplatesWithOptions(CategoriesTemplatesRequest request, CategoriesTemplatesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CategoriesTemplates"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/categoryLists/templates/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CategoriesTemplatesResponse());
    }

    /**
     * @summary 按分类列表查询模板列表
     *
     * @param request CategoriesTemplatesRequest
     * @return CategoriesTemplatesResponse
     */
    public CategoriesTemplatesResponse categoriesTemplates(CategoriesTemplatesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CategoriesTemplatesHeaders headers = new CategoriesTemplatesHeaders();
        return this.categoriesTemplatesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 按分类查询模板列表
     *
     * @param request CategoryTemplatesRequest
     * @param headers CategoryTemplatesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CategoryTemplatesResponse
     */
    public CategoryTemplatesResponse categoryTemplatesWithOptions(CategoryTemplatesRequest request, CategoryTemplatesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CategoryTemplates"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/categories/templates/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CategoryTemplatesResponse());
    }

    /**
     * @summary 按分类查询模板列表
     *
     * @param request CategoryTemplatesRequest
     * @return CategoryTemplatesResponse
     */
    public CategoryTemplatesResponse categoryTemplates(CategoryTemplatesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CategoryTemplatesHeaders headers = new CategoryTemplatesHeaders();
        return this.categoryTemplatesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 拷贝知识库节点
     *
     * @param request CopyDentryRequest
     * @param headers CopyDentryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CopyDentryResponse
     */
    public CopyDentryResponse copyDentryWithOptions(String spaceId, String dentryId, CopyDentryRequest request, CopyDentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSpaceId)) {
            body.put("targetSpaceId", request.targetSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toNextDentryId)) {
            body.put("toNextDentryId", request.toNextDentryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toParentDentryId)) {
            body.put("toParentDentryId", request.toParentDentryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toPrevDentryId)) {
            body.put("toPrevDentryId", request.toPrevDentryId);
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
            new TeaPair("action", "CopyDentry"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/copy"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CopyDentryResponse());
    }

    /**
     * @summary 拷贝知识库节点
     *
     * @param request CopyDentryRequest
     * @return CopyDentryResponse
     */
    public CopyDentryResponse copyDentry(String spaceId, String dentryId, CopyDentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CopyDentryHeaders headers = new CopyDentryHeaders();
        return this.copyDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 创建知识库节点（包括文档和文件夹）
     *
     * @param request CreateDentryRequest
     * @param headers CreateDentryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateDentryResponse
     */
    public CreateDentryResponse createDentryWithOptions(String spaceId, CreateDentryRequest request, CreateDentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryType)) {
            body.put("dentryType", request.dentryType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.documentType)) {
            body.put("documentType", request.documentType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentDentryId)) {
            body.put("parentDentryId", request.parentDentryId);
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
            new TeaPair("action", "CreateDentry"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/" + spaceId + "/dentries"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateDentryResponse());
    }

    /**
     * @summary 创建知识库节点（包括文档和文件夹）
     *
     * @param request CreateDentryRequest
     * @return CreateDentryResponse
     */
    public CreateDentryResponse createDentry(String spaceId, CreateDentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDentryHeaders headers = new CreateDentryHeaders();
        return this.createDentryWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 创建知识库
     *
     * @param request CreateSpaceRequest
     * @param headers CreateSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateSpaceResponse
     */
    public CreateSpaceResponse createSpaceWithOptions(CreateSpaceRequest request, CreateSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sectionId)) {
            body.put("sectionId", request.sectionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.shareScope)) {
            body.put("shareScope", request.shareScope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamId)) {
            body.put("teamId", request.teamId);
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
            new TeaPair("action", "CreateSpace"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateSpaceResponse());
    }

    /**
     * @summary 创建知识库
     *
     * @param request CreateSpaceRequest
     * @return CreateSpaceResponse
     */
    public CreateSpaceResponse createSpace(CreateSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSpaceHeaders headers = new CreateSpaceHeaders();
        return this.createSpaceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建小组
     *
     * @param request CreateTeamRequest
     * @param headers CreateTeamHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTeamResponse
     */
    public CreateTeamResponse createTeamWithOptions(CreateTeamRequest request, CreateTeamHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cover)) {
            body.put("cover", request.cover);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamType)) {
            body.put("teamType", request.teamType);
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
            new TeaPair("action", "CreateTeam"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTeamResponse());
    }

    /**
     * @summary 创建小组
     *
     * @param request CreateTeamRequest
     * @return CreateTeamResponse
     */
    public CreateTeamResponse createTeam(CreateTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTeamHeaders headers = new CreateTeamHeaders();
        return this.createTeamWithOptions(request, headers, runtime);
    }

    /**
     * @summary 跨组织迁移知识库
     *
     * @param request CrossOrgMigrateRequest
     * @param headers CrossOrgMigrateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CrossOrgMigrateResponse
     */
    public CrossOrgMigrateResponse crossOrgMigrateWithOptions(CrossOrgMigrateRequest request, CrossOrgMigrateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CrossOrgMigrate"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/crossOrganizations/spaces/migrate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CrossOrgMigrateResponse());
    }

    /**
     * @summary 跨组织迁移知识库
     *
     * @param request CrossOrgMigrateRequest
     * @return CrossOrgMigrateResponse
     */
    public CrossOrgMigrateResponse crossOrgMigrate(CrossOrgMigrateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CrossOrgMigrateHeaders headers = new CrossOrgMigrateHeaders();
        return this.crossOrgMigrateWithOptions(request, headers, runtime);
    }

    /**
     * @summary 删除小组
     *
     * @param request DeleteTeamRequest
     * @param headers DeleteTeamHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteTeamResponse
     */
    public DeleteTeamResponse deleteTeamWithOptions(String teamId, DeleteTeamRequest request, DeleteTeamHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "DeleteTeam"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/" + teamId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteTeamResponse());
    }

    /**
     * @summary 删除小组
     *
     * @param request DeleteTeamRequest
     * @return DeleteTeamResponse
     */
    public DeleteTeamResponse deleteTeam(String teamId, DeleteTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteTeamHeaders headers = new DeleteTeamHeaders();
        return this.deleteTeamWithOptions(teamId, request, headers, runtime);
    }

    /**
     * @summary 获取文档内容
     *
     * @param request DocContentRequest
     * @param headers DocContentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DocContentResponse
     */
    public DocContentResponse docContentWithOptions(String dentryUuid, DocContentRequest request, DocContentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DocContent"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/dentries/" + dentryUuid + "/contents"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DocContentResponse());
    }

    /**
     * @summary 获取文档内容
     *
     * @param request DocContentRequest
     * @return DocContentResponse
     */
    public DocContentResponse docContent(String dentryUuid, DocContentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DocContentHeaders headers = new DocContentHeaders();
        return this.docContentWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 根据文件DentryUuid获取文件DentryId
     *
     * @param request GetDentryIdByUuidRequest
     * @param headers GetDentryIdByUuidHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDentryIdByUuidResponse
     */
    public GetDentryIdByUuidResponse getDentryIdByUuidWithOptions(String dentryUuid, GetDentryIdByUuidRequest request, GetDentryIdByUuidHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "GetDentryIdByUuid"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/dentries/" + dentryUuid + "/queryDentryId"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDentryIdByUuidResponse());
    }

    /**
     * @summary 根据文件DentryUuid获取文件DentryId
     *
     * @param request GetDentryIdByUuidRequest
     * @return GetDentryIdByUuidResponse
     */
    public GetDentryIdByUuidResponse getDentryIdByUuid(String dentryUuid, GetDentryIdByUuidRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDentryIdByUuidHeaders headers = new GetDentryIdByUuidHeaders();
        return this.getDentryIdByUuidWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 委托权限获取文档内容
     *
     * @param request GetDocContentRequest
     * @param headers GetDocContentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDocContentResponse
     */
    public GetDocContentResponse getDocContentWithOptions(String dentryUuid, GetDocContentRequest request, GetDocContentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.targetFormat)) {
            query.put("targetFormat", request.targetFormat);
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
            new TeaPair("action", "GetDocContent"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/me/query/" + dentryUuid + "/contents"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDocContentResponse());
    }

    /**
     * @summary 委托权限获取文档内容
     *
     * @param request GetDocContentRequest
     * @return GetDocContentResponse
     */
    public GetDocContentResponse getDocContent(String dentryUuid, GetDocContentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDocContentHeaders headers = new GetDocContentHeaders();
        return this.getDocContentWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 委托权限获取文档内容
     *
     * @param request GetDocContentForELMRequest
     * @param headers GetDocContentForELMHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDocContentForELMResponse
     */
    public GetDocContentForELMResponse getDocContentForELMWithOptions(String dentryUuid, GetDocContentForELMRequest request, GetDocContentForELMHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.targetFormat)) {
            query.put("targetFormat", request.targetFormat);
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
            new TeaPair("action", "GetDocContentForELM"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/elm/me/dentries/" + dentryUuid + "/contents"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDocContentForELMResponse());
    }

    /**
     * @summary 委托权限获取文档内容
     *
     * @param request GetDocContentForELMRequest
     * @return GetDocContentForELMResponse
     */
    public GetDocContentForELMResponse getDocContentForELM(String dentryUuid, GetDocContentForELMRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDocContentForELMHeaders headers = new GetDocContentForELMHeaders();
        return this.getDocContentForELMWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 获取当前企业下钉盘目录我的文件对应的空间信息
     *
     * @param request GetMySpaceRequest
     * @param headers GetMySpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMySpaceResponse
     */
    public GetMySpaceResponse getMySpaceWithOptions(GetMySpaceRequest request, GetMySpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isMySpace)) {
            query.put("isMySpace", request.isMySpace);
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
            new TeaPair("action", "GetMySpace"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/me/mySpace/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMySpaceResponse());
    }

    /**
     * @summary 获取当前企业下钉盘目录我的文件对应的空间信息
     *
     * @param request GetMySpaceRequest
     * @return GetMySpaceResponse
     */
    public GetMySpaceResponse getMySpace(GetMySpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMySpaceHeaders headers = new GetMySpaceHeaders();
        return this.getMySpaceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询小组主页schema （包括轮播图、公告、便捷入口）
     *
     * @param request GetSchemaRequest
     * @param headers GetSchemaHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSchemaResponse
     */
    public GetSchemaResponse getSchemaWithOptions(String teamId, GetSchemaRequest request, GetSchemaHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "GetSchema"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/" + teamId + "/schemas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSchemaResponse());
    }

    /**
     * @summary 查询小组主页schema （包括轮播图、公告、便捷入口）
     *
     * @param request GetSchemaRequest
     * @return GetSchemaResponse
     */
    public GetSchemaResponse getSchema(String teamId, GetSchemaRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSchemaHeaders headers = new GetSchemaHeaders();
        return this.getSchemaWithOptions(teamId, request, headers, runtime);
    }

    /**
     * @summary 查询目录树
     *
     * @param request GetSpaceDirectoriesRequest
     * @param headers GetSpaceDirectoriesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSpaceDirectoriesResponse
     */
    public GetSpaceDirectoriesResponse getSpaceDirectoriesWithOptions(String spaceId, GetSpaceDirectoriesRequest request, GetSpaceDirectoriesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryId)) {
            query.put("dentryId", request.dentryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "GetSpaceDirectories"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/" + spaceId + "/directories"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSpaceDirectoriesResponse());
    }

    /**
     * @summary 查询目录树
     *
     * @param request GetSpaceDirectoriesRequest
     * @return GetSpaceDirectoriesResponse
     */
    public GetSpaceDirectoriesResponse getSpaceDirectories(String spaceId, GetSpaceDirectoriesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSpaceDirectoriesHeaders headers = new GetSpaceDirectoriesHeaders();
        return this.getSpaceDirectoriesWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 获取星标信息
     *
     * @param request GetStarInfoRequest
     * @param headers GetStarInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetStarInfoResponse
     */
    public GetStarInfoResponse getStarInfoWithOptions(String dentryUuid, GetStarInfoRequest request, GetStarInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "GetStarInfo"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/dentries/" + dentryUuid + "/starInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetStarInfoResponse());
    }

    /**
     * @summary 获取星标信息
     *
     * @param request GetStarInfoRequest
     * @return GetStarInfoResponse
     */
    public GetStarInfoResponse getStarInfo(String dentryUuid, GetStarInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetStarInfoHeaders headers = new GetStarInfoHeaders();
        return this.getStarInfoWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 查询小组详情
     *
     * @param request GetTeamRequest
     * @param headers GetTeamHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTeamResponse
     */
    public GetTeamResponse getTeamWithOptions(String teamId, GetTeamRequest request, GetTeamHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "GetTeam"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/" + teamId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTeamResponse());
    }

    /**
     * @summary 查询小组详情
     *
     * @param request GetTeamRequest
     * @return GetTeamResponse
     */
    public GetTeamResponse getTeam(String teamId, GetTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTeamHeaders headers = new GetTeamHeaders();
        return this.getTeamWithOptions(teamId, request, headers, runtime);
    }

    /**
     * @summary 获取知识库下的总节点数
     *
     * @param request GetTotalNumberOfDentriesRequest
     * @param headers GetTotalNumberOfDentriesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTotalNumberOfDentriesResponse
     */
    public GetTotalNumberOfDentriesResponse getTotalNumberOfDentriesWithOptions(GetTotalNumberOfDentriesRequest request, GetTotalNumberOfDentriesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.includeFolder)) {
            query.put("includeFolder", request.includeFolder);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceTypes)) {
            query.put("spaceTypes", request.spaceTypes);
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
            new TeaPair("action", "GetTotalNumberOfDentries"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/statistics/dentryCounts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTotalNumberOfDentriesResponse());
    }

    /**
     * @summary 获取知识库下的总节点数
     *
     * @param request GetTotalNumberOfDentriesRequest
     * @return GetTotalNumberOfDentriesResponse
     */
    public GetTotalNumberOfDentriesResponse getTotalNumberOfDentries(GetTotalNumberOfDentriesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTotalNumberOfDentriesHeaders headers = new GetTotalNumberOfDentriesHeaders();
        return this.getTotalNumberOfDentriesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取知识库总数
     *
     * @param request GetTotalNumberOfSpacesRequest
     * @param headers GetTotalNumberOfSpacesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTotalNumberOfSpacesResponse
     */
    public GetTotalNumberOfSpacesResponse getTotalNumberOfSpacesWithOptions(GetTotalNumberOfSpacesRequest request, GetTotalNumberOfSpacesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "GetTotalNumberOfSpaces"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/statistics/spaceCounts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTotalNumberOfSpacesResponse());
    }

    /**
     * @summary 获取知识库总数
     *
     * @param request GetTotalNumberOfSpacesRequest
     * @return GetTotalNumberOfSpacesResponse
     */
    public GetTotalNumberOfSpacesResponse getTotalNumberOfSpaces(GetTotalNumberOfSpacesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTotalNumberOfSpacesHeaders headers = new GetTotalNumberOfSpacesHeaders();
        return this.getTotalNumberOfSpacesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询文档免登的用户信息
     *
     * @param request GetUserInfoByOpenTokenRequest
     * @param headers GetUserInfoByOpenTokenHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserInfoByOpenTokenResponse
     */
    public GetUserInfoByOpenTokenResponse getUserInfoByOpenTokenWithOptions(GetUserInfoByOpenTokenRequest request, GetUserInfoByOpenTokenHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.docKey)) {
            query.put("docKey", request.docKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openToken)) {
            query.put("openToken", request.openToken);
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
            new TeaPair("action", "GetUserInfoByOpenToken"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/userInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserInfoByOpenTokenResponse());
    }

    /**
     * @summary 查询文档免登的用户信息
     *
     * @param request GetUserInfoByOpenTokenRequest
     * @return GetUserInfoByOpenTokenResponse
     */
    public GetUserInfoByOpenTokenResponse getUserInfoByOpenToken(GetUserInfoByOpenTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserInfoByOpenTokenHeaders headers = new GetUserInfoByOpenTokenHeaders();
        return this.getUserInfoByOpenTokenWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据文件DentryId获取文件DentryUuid
     *
     * @param request GetUuidByDentryIdRequest
     * @param headers GetUuidByDentryIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUuidByDentryIdResponse
     */
    public GetUuidByDentryIdResponse getUuidByDentryIdWithOptions(String dentryId, GetUuidByDentryIdRequest request, GetUuidByDentryIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceId)) {
            query.put("spaceId", request.spaceId);
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
            new TeaPair("action", "GetUuidByDentryId"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/dentries/" + dentryId + "/queryDentryUuid"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUuidByDentryIdResponse());
    }

    /**
     * @summary 根据文件DentryId获取文件DentryUuid
     *
     * @param request GetUuidByDentryIdRequest
     * @return GetUuidByDentryIdResponse
     */
    public GetUuidByDentryIdResponse getUuidByDentryId(String dentryId, GetUuidByDentryIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUuidByDentryIdHeaders headers = new GetUuidByDentryIdHeaders();
        return this.getUuidByDentryIdWithOptions(dentryId, request, headers, runtime);
    }

    /**
     * @summary 查询小组动态
     *
     * @param request ListFeedsRequest
     * @param headers ListFeedsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListFeedsResponse
     */
    public ListFeedsResponse listFeedsWithOptions(String teamId, ListFeedsRequest request, ListFeedsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.excludeFile)) {
            query.put("excludeFile", request.excludeFile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "ListFeeds"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/" + teamId + "/feeds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListFeedsResponse());
    }

    /**
     * @summary 查询小组动态
     *
     * @param request ListFeedsRequest
     * @return ListFeedsResponse
     */
    public ListFeedsResponse listFeeds(String teamId, ListFeedsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListFeedsHeaders headers = new ListFeedsHeaders();
        return this.listFeedsWithOptions(teamId, request, headers, runtime);
    }

    /**
     * @summary 查询小组热门文档
     *
     * @param request ListHotDocsRequest
     * @param headers ListHotDocsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListHotDocsResponse
     */
    public ListHotDocsResponse listHotDocsWithOptions(String teamId, ListHotDocsRequest request, ListHotDocsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "ListHotDocs"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/" + teamId + "/hotDocs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListHotDocsResponse());
    }

    /**
     * @summary 查询小组热门文档
     *
     * @param request ListHotDocsRequest
     * @return ListHotDocsResponse
     */
    public ListHotDocsResponse listHotDocs(String teamId, ListHotDocsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListHotDocsHeaders headers = new ListHotDocsHeaders();
        return this.listHotDocsWithOptions(teamId, request, headers, runtime);
    }

    /**
     * @summary 获取置顶知识库列表
     *
     * @param request ListPinSpacesRequest
     * @param headers ListPinSpacesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListPinSpacesResponse
     */
    public ListPinSpacesResponse listPinSpacesWithOptions(ListPinSpacesRequest request, ListPinSpacesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListPinSpaces"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/pinLists/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListPinSpacesResponse());
    }

    /**
     * @summary 获取置顶知识库列表
     *
     * @param request ListPinSpacesRequest
     * @return ListPinSpacesResponse
     */
    public ListPinSpacesResponse listPinSpaces(ListPinSpacesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListPinSpacesHeaders headers = new ListPinSpacesHeaders();
        return this.listPinSpacesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询文档最近记录列表
     *
     * @param request ListRecentsRequest
     * @param headers ListRecentsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListRecentsResponse
     */
    public ListRecentsResponse listRecentsWithOptions(ListRecentsRequest request, ListRecentsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("action", "ListRecents"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/dentries/recentRecords/lists/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListRecentsResponse());
    }

    /**
     * @summary 查询文档最近记录列表
     *
     * @param request ListRecentsRequest
     * @return ListRecentsResponse
     */
    public ListRecentsResponse listRecents(ListRecentsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListRecentsHeaders headers = new ListRecentsHeaders();
        return this.listRecentsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询关联了知识库的团队列表
     *
     * @param request ListRelatedSpaceTeamsRequest
     * @param headers ListRelatedSpaceTeamsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListRelatedSpaceTeamsResponse
     */
    public ListRelatedSpaceTeamsResponse listRelatedSpaceTeamsWithOptions(ListRelatedSpaceTeamsRequest request, ListRelatedSpaceTeamsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
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
            new TeaPair("action", "ListRelatedSpaceTeams"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/relations/spaceTeams"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListRelatedSpaceTeamsResponse());
    }

    /**
     * @summary 查询关联了知识库的团队列表
     *
     * @param request ListRelatedSpaceTeamsRequest
     * @return ListRelatedSpaceTeamsResponse
     */
    public ListRelatedSpaceTeamsResponse listRelatedSpaceTeams(ListRelatedSpaceTeamsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListRelatedSpaceTeamsHeaders headers = new ListRelatedSpaceTeamsHeaders();
        return this.listRelatedSpaceTeamsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询小组列表
     *
     * @param request ListRelatedTeamsRequest
     * @param headers ListRelatedTeamsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListRelatedTeamsResponse
     */
    public ListRelatedTeamsResponse listRelatedTeamsWithOptions(ListRelatedTeamsRequest request, ListRelatedTeamsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
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
            new TeaPair("action", "ListRelatedTeams"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListRelatedTeamsResponse());
    }

    /**
     * @summary 查询小组列表
     *
     * @param request ListRelatedTeamsRequest
     * @return ListRelatedTeamsResponse
     */
    public ListRelatedTeamsResponse listRelatedTeams(ListRelatedTeamsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListRelatedTeamsHeaders headers = new ListRelatedTeamsHeaders();
        return this.listRelatedTeamsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询知识库分组
     *
     * @param request ListSpaceSectionsRequest
     * @param headers ListSpaceSectionsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListSpaceSectionsResponse
     */
    public ListSpaceSectionsResponse listSpaceSectionsWithOptions(String teamId, ListSpaceSectionsRequest request, ListSpaceSectionsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "ListSpaceSections"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/" + teamId + "/spaceSections"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListSpaceSectionsResponse());
    }

    /**
     * @summary 查询知识库分组
     *
     * @param request ListSpaceSectionsRequest
     * @return ListSpaceSectionsResponse
     */
    public ListSpaceSectionsResponse listSpaceSections(String teamId, ListSpaceSectionsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSpaceSectionsHeaders headers = new ListSpaceSectionsHeaders();
        return this.listSpaceSectionsWithOptions(teamId, request, headers, runtime);
    }

    /**
     * @summary 获取星标列表
     *
     * @param request ListStarsRequest
     * @param headers ListStarsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListStarsResponse
     */
    public ListStarsResponse listStarsWithOptions(ListStarsRequest request, ListStarsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListStars"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/dentries/starLists/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListStarsResponse());
    }

    /**
     * @summary 获取星标列表
     *
     * @param request ListStarsRequest
     * @return ListStarsResponse
     */
    public ListStarsResponse listStars(ListStarsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListStarsHeaders headers = new ListStarsHeaders();
        return this.listStarsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询小组成员列表
     *
     * @param request ListTeamMembersRequest
     * @param headers ListTeamMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListTeamMembersResponse
     */
    public ListTeamMembersResponse listTeamMembersWithOptions(String teamId, ListTeamMembersRequest request, ListTeamMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "ListTeamMembers"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/" + teamId + "/members"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListTeamMembersResponse());
    }

    /**
     * @summary 查询小组成员列表
     *
     * @param request ListTeamMembersRequest
     * @return ListTeamMembersResponse
     */
    public ListTeamMembersResponse listTeamMembers(String teamId, ListTeamMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListTeamMembersHeaders headers = new ListTeamMembersHeaders();
        return this.listTeamMembersWithOptions(teamId, request, headers, runtime);
    }

    /**
     * @summary 标记星标
     *
     * @param request MarkStarRequest
     * @param headers MarkStarHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MarkStarResponse
     */
    public MarkStarResponse markStarWithOptions(String dentryUuid, MarkStarRequest request, MarkStarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "MarkStar"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/dentries/" + dentryUuid + "/stars/mark"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MarkStarResponse());
    }

    /**
     * @summary 标记星标
     *
     * @param request MarkStarRequest
     * @return MarkStarResponse
     */
    public MarkStarResponse markStar(String dentryUuid, MarkStarRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MarkStarHeaders headers = new MarkStarHeaders();
        return this.markStarWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 移动知识库节点
     *
     * @param request MoveDentryRequest
     * @param headers MoveDentryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MoveDentryResponse
     */
    public MoveDentryResponse moveDentryWithOptions(String spaceId, String dentryId, MoveDentryRequest request, MoveDentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSpaceId)) {
            body.put("targetSpaceId", request.targetSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toNextDentryId)) {
            body.put("toNextDentryId", request.toNextDentryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toParentDentryId)) {
            body.put("toParentDentryId", request.toParentDentryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toPrevDentryId)) {
            body.put("toPrevDentryId", request.toPrevDentryId);
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
            new TeaPair("action", "MoveDentry"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/move"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MoveDentryResponse());
    }

    /**
     * @summary 移动知识库节点
     *
     * @param request MoveDentryRequest
     * @return MoveDentryResponse
     */
    public MoveDentryResponse moveDentry(String spaceId, String dentryId, MoveDentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MoveDentryHeaders headers = new MoveDentryHeaders();
        return this.moveDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 置顶知识库
     *
     * @param request PinSpaceRequest
     * @param headers PinSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PinSpaceResponse
     */
    public PinSpaceResponse pinSpaceWithOptions(String spaceId, PinSpaceRequest request, PinSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "PinSpace"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/" + spaceId + "/pin"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PinSpaceResponse());
    }

    /**
     * @summary 置顶知识库
     *
     * @param request PinSpaceRequest
     * @return PinSpaceResponse
     */
    public PinSpaceResponse pinSpace(String spaceId, PinSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PinSpaceHeaders headers = new PinSpaceHeaders();
        return this.pinSpaceWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 查询知识库节点（包括文档和文件夹）
     *
     * @param request QueryDentryRequest
     * @param headers QueryDentryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDentryResponse
     */
    public QueryDentryResponse queryDentryWithOptions(String spaceId, String dentryId, QueryDentryRequest request, QueryDentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.includeSpace)) {
            query.put("includeSpace", request.includeSpace);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "QueryDentry"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDentryResponse());
    }

    /**
     * @summary 查询知识库节点（包括文档和文件夹）
     *
     * @param request QueryDentryRequest
     * @return QueryDentryResponse
     */
    public QueryDentryResponse queryDentry(String spaceId, String dentryId, QueryDentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDentryHeaders headers = new QueryDentryHeaders();
        return this.queryDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 获取文档内容
     *
     * @param request QueryDocContentRequest
     * @param headers QueryDocContentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDocContentResponse
     */
    public QueryDocContentResponse queryDocContentWithOptions(String dentryUuid, QueryDocContentRequest request, QueryDocContentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetFormat)) {
            query.put("targetFormat", request.targetFormat);
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
            new TeaPair("action", "QueryDocContent"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/query/" + dentryUuid + "/contents"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDocContentResponse());
    }

    /**
     * @summary 获取文档内容
     *
     * @param request QueryDocContentRequest
     * @return QueryDocContentResponse
     */
    public QueryDocContentResponse queryDocContent(String dentryUuid, QueryDocContentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDocContentHeaders headers = new QueryDocContentHeaders();
        return this.queryDocContentWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 根据链接查询节点或知识库信息
     *
     * @param request QueryItemByUrlRequest
     * @param headers QueryItemByUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryItemByUrlResponse
     */
    public QueryItemByUrlResponse queryItemByUrlWithOptions(QueryItemByUrlRequest request, QueryItemByUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.url)) {
            query.put("url", request.url);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withStatisticalInfo)) {
            query.put("withStatisticalInfo", request.withStatisticalInfo);
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
            new TeaPair("action", "QueryItemByUrl"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/items"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryItemByUrlResponse());
    }

    /**
     * @summary 根据链接查询节点或知识库信息
     *
     * @param request QueryItemByUrlRequest
     * @return QueryItemByUrlResponse
     */
    public QueryItemByUrlResponse queryItemByUrl(QueryItemByUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryItemByUrlHeaders headers = new QueryItemByUrlHeaders();
        return this.queryItemByUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询用户的「我的文档」
     *
     * @param headers QueryMineSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMineSpaceResponse
     */
    public QueryMineSpaceResponse queryMineSpaceWithOptions(String unionId, QueryMineSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryMineSpace"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/users/" + unionId + "/mine"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMineSpaceResponse());
    }

    /**
     * @summary 查询用户的「我的文档」
     *
     * @return QueryMineSpaceResponse
     */
    public QueryMineSpaceResponse queryMineSpace(String unionId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMineSpaceHeaders headers = new QueryMineSpaceHeaders();
        return this.queryMineSpaceWithOptions(unionId, headers, runtime);
    }

    /**
     * @summary 查询最近列表
     *
     * @param request QueryRecentListRequest
     * @param headers QueryRecentListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryRecentListResponse
     */
    public QueryRecentListResponse queryRecentListWithOptions(QueryRecentListRequest request, QueryRecentListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorType)) {
            query.put("creatorType", request.creatorType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileType)) {
            query.put("fileType", request.fileType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recentType)) {
            query.put("recentType", request.recentType);
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
            new TeaPair("action", "QueryRecentList"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/docs/recent"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryRecentListResponse());
    }

    /**
     * @summary 查询最近列表
     *
     * @param request QueryRecentListRequest
     * @return QueryRecentListResponse
     */
    public QueryRecentListResponse queryRecentList(QueryRecentListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRecentListHeaders headers = new QueryRecentListHeaders();
        return this.queryRecentListWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询指定知识库信息
     *
     * @param request QuerySpaceRequest
     * @param headers QuerySpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySpaceResponse
     */
    public QuerySpaceResponse querySpaceWithOptions(String spaceId, QuerySpaceRequest request, QuerySpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "QuerySpace"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/" + spaceId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySpaceResponse());
    }

    /**
     * @summary 查询指定知识库信息
     *
     * @param request QuerySpaceRequest
     * @return QuerySpaceResponse
     */
    public QuerySpaceResponse querySpace(String spaceId, QuerySpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySpaceHeaders headers = new QuerySpaceHeaders();
        return this.querySpaceWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 查询与我关联的知识库列表（支持筛选小组）
     *
     * @param request RelatedSpacesRequest
     * @param headers RelatedSpacesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RelatedSpacesResponse
     */
    public RelatedSpacesResponse relatedSpacesWithOptions(RelatedSpacesRequest request, RelatedSpacesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamId)) {
            query.put("teamId", request.teamId);
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
            new TeaPair("action", "RelatedSpaces"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/relations/spaces"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RelatedSpacesResponse());
    }

    /**
     * @summary 查询与我关联的知识库列表（支持筛选小组）
     *
     * @param request RelatedSpacesRequest
     * @return RelatedSpacesResponse
     */
    public RelatedSpacesResponse relatedSpaces(RelatedSpacesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RelatedSpacesHeaders headers = new RelatedSpacesHeaders();
        return this.relatedSpacesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 移除小组成员
     *
     * @param request RemoveTeamMembersRequest
     * @param headers RemoveTeamMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveTeamMembersResponse
     */
    public RemoveTeamMembersResponse removeTeamMembersWithOptions(String teamId, RemoveTeamMembersRequest request, RemoveTeamMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.notify)) {
            body.put("notify", request.notify);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
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
            new TeaPair("action", "RemoveTeamMembers"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/" + teamId + "/members/remove"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveTeamMembersResponse());
    }

    /**
     * @summary 移除小组成员
     *
     * @param request RemoveTeamMembersRequest
     * @return RemoveTeamMembersResponse
     */
    public RemoveTeamMembersResponse removeTeamMembers(String teamId, RemoveTeamMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveTeamMembersHeaders headers = new RemoveTeamMembersHeaders();
        return this.removeTeamMembersWithOptions(teamId, request, headers, runtime);
    }

    /**
     * @summary 知识库节点（包括文档和文件夹）重命名
     *
     * @param request RenameDentryRequest
     * @param headers RenameDentryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RenameDentryResponse
     */
    public RenameDentryResponse renameDentryWithOptions(String spaceId, String dentryId, RenameDentryRequest request, RenameDentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            query.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "RenameDentry"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/rename"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RenameDentryResponse());
    }

    /**
     * @summary 知识库节点（包括文档和文件夹）重命名
     *
     * @param request RenameDentryRequest
     * @return RenameDentryResponse
     */
    public RenameDentryResponse renameDentry(String spaceId, String dentryId, RenameDentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RenameDentryHeaders headers = new RenameDentryHeaders();
        return this.renameDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 添加或修改小组成员
     *
     * @param request SaveTeamMembersRequest
     * @param headers SaveTeamMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveTeamMembersResponse
     */
    public SaveTeamMembersResponse saveTeamMembersWithOptions(String teamId, SaveTeamMembersRequest request, SaveTeamMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.notify)) {
            body.put("notify", request.notify);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
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
            new TeaPair("action", "SaveTeamMembers"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/" + teamId + "/members"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveTeamMembersResponse());
    }

    /**
     * @summary 添加或修改小组成员
     *
     * @param request SaveTeamMembersRequest
     * @return SaveTeamMembersResponse
     */
    public SaveTeamMembersResponse saveTeamMembers(String teamId, SaveTeamMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveTeamMembersHeaders headers = new SaveTeamMembersHeaders();
        return this.saveTeamMembersWithOptions(teamId, request, headers, runtime);
    }

    /**
     * @summary 搜索知识库和节点
     *
     * @param request SearchRequest
     * @param headers SearchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchResponse
     */
    public SearchResponse searchWithOptions(SearchRequest request, SearchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryRequest)) {
            body.put("dentryRequest", request.dentryRequest);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            body.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceRequest)) {
            body.put("spaceRequest", request.spaceRequest);
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
            new TeaPair("action", "Search"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchResponse());
    }

    /**
     * @summary 搜索知识库和节点
     *
     * @param request SearchRequest
     * @return SearchResponse
     */
    public SearchResponse search(SearchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchHeaders headers = new SearchHeaders();
        return this.searchWithOptions(request, headers, runtime);
    }

    /**
     * @summary 搜索模板中心模板
     *
     * @param request SearchTemplatesRequest
     * @param headers SearchTemplatesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchTemplatesResponse
     */
    public SearchTemplatesResponse searchTemplatesWithOptions(SearchTemplatesRequest request, SearchTemplatesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SearchTemplates"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/templates/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchTemplatesResponse());
    }

    /**
     * @summary 搜索模板中心模板
     *
     * @param request SearchTemplatesRequest
     * @return SearchTemplatesResponse
     */
    public SearchTemplatesResponse searchTemplates(SearchTemplatesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchTemplatesHeaders headers = new SearchTemplatesHeaders();
        return this.searchTemplatesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取文件打开链接
     *
     * @param request ShareUrlRequest
     * @param headers ShareUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ShareUrlResponse
     */
    public ShareUrlResponse shareUrlWithOptions(ShareUrlRequest request, ShareUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("action", "ShareUrl"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/dentries/shareUrls/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ShareUrlResponse());
    }

    /**
     * @summary 获取文件打开链接
     *
     * @param request ShareUrlRequest
     * @return ShareUrlResponse
     */
    public ShareUrlResponse shareUrl(ShareUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ShareUrlHeaders headers = new ShareUrlHeaders();
        return this.shareUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取知识库模板列表
     *
     * @param request TeamTemplatesRequest
     * @param headers TeamTemplatesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TeamTemplatesResponse
     */
    public TeamTemplatesResponse teamTemplatesWithOptions(TeamTemplatesRequest request, TeamTemplatesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "TeamTemplates"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/workspaces/templates/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TeamTemplatesResponse());
    }

    /**
     * @summary 获取知识库模板列表
     *
     * @param request TeamTemplatesRequest
     * @return TeamTemplatesResponse
     */
    public TeamTemplatesResponse teamTemplates(TeamTemplatesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TeamTemplatesHeaders headers = new TeamTemplatesHeaders();
        return this.teamTemplatesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取模板分类列表
     *
     * @param request TemplateCategoriesRequest
     * @param headers TemplateCategoriesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TemplateCategoriesResponse
     */
    public TemplateCategoriesResponse templateCategoriesWithOptions(TemplateCategoriesRequest request, TemplateCategoriesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "TemplateCategories"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/templates/categories/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TemplateCategoriesResponse());
    }

    /**
     * @summary 获取模板分类列表
     *
     * @param request TemplateCategoriesRequest
     * @return TemplateCategoriesResponse
     */
    public TemplateCategoriesResponse templateCategories(TemplateCategoriesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TemplateCategoriesHeaders headers = new TemplateCategoriesHeaders();
        return this.templateCategoriesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 取消标记星标
     *
     * @param request UnmarkStarRequest
     * @param headers UnmarkStarHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UnmarkStarResponse
     */
    public UnmarkStarResponse unmarkStarWithOptions(String dentryUuid, UnmarkStarRequest request, UnmarkStarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "UnmarkStar"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/dentries/" + dentryUuid + "/stars/unmark"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UnmarkStarResponse());
    }

    /**
     * @summary 取消标记星标
     *
     * @param request UnmarkStarRequest
     * @return UnmarkStarResponse
     */
    public UnmarkStarResponse unmarkStar(String dentryUuid, UnmarkStarRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UnmarkStarHeaders headers = new UnmarkStarHeaders();
        return this.unmarkStarWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 取消置顶知识库
     *
     * @param request UnpinSpaceRequest
     * @param headers UnpinSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UnpinSpaceResponse
     */
    public UnpinSpaceResponse unpinSpaceWithOptions(String spaceId, UnpinSpaceRequest request, UnpinSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "UnpinSpace"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/spaces/" + spaceId + "/unpin"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UnpinSpaceResponse());
    }

    /**
     * @summary 取消置顶知识库
     *
     * @param request UnpinSpaceRequest
     * @return UnpinSpaceResponse
     */
    public UnpinSpaceResponse unpinSpace(String spaceId, UnpinSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UnpinSpaceHeaders headers = new UnpinSpaceHeaders();
        return this.unpinSpaceWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 更新小组
     *
     * @param request UpdateTeamRequest
     * @param headers UpdateTeamHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTeamResponse
     */
    public UpdateTeamResponse updateTeamWithOptions(String teamId, UpdateTeamRequest request, UpdateTeamHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
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
            new TeaPair("action", "UpdateTeam"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/teams/" + teamId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTeamResponse());
    }

    /**
     * @summary 更新小组
     *
     * @param request UpdateTeamRequest
     * @return UpdateTeamResponse
     */
    public UpdateTeamResponse updateTeam(String teamId, UpdateTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTeamHeaders headers = new UpdateTeamHeaders();
        return this.updateTeamWithOptions(teamId, request, headers, runtime);
    }

    /**
     * @summary 用户模板列表
     *
     * @param request UserTemplatesRequest
     * @param headers UserTemplatesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UserTemplatesResponse
     */
    public UserTemplatesResponse userTemplatesWithOptions(UserTemplatesRequest request, UserTemplatesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UserTemplates"),
            new TeaPair("version", "doc_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/doc/users/templates/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UserTemplatesResponse());
    }

    /**
     * @summary 用户模板列表
     *
     * @param request UserTemplatesRequest
     * @return UserTemplatesResponse
     */
    public UserTemplatesResponse userTemplates(UserTemplatesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UserTemplatesHeaders headers = new UserTemplatesHeaders();
        return this.userTemplatesWithOptions(request, headers, runtime);
    }
}
