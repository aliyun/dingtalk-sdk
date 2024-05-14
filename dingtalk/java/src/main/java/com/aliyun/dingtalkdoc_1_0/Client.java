// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdoc_1_0.models.*;

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
     * @summary 添加评论
     *
     * @param request AddCommentRequest
     * @param headers AddCommentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCommentResponse
     */
    public AddCommentResponse addCommentWithOptions(String docId, AddCommentRequest request, AddCommentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.commentContent)) {
            body.put("commentContent", request.commentContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.commentType)) {
            body.put("commentType", request.commentType);
        }

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
            new TeaPair("action", "AddComment"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/docs/" + docId + "/comments"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCommentResponse());
    }

    /**
     * @summary 添加评论
     *
     * @param request AddCommentRequest
     * @return AddCommentResponse
     */
    public AddCommentResponse addComment(String docId, AddCommentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCommentHeaders headers = new AddCommentHeaders();
        return this.addCommentWithOptions(docId, request, headers, runtime);
    }

    /**
     * @summary 添加知识库文档成员
     *
     * @param request AddWorkspaceDocMembersRequest
     * @param headers AddWorkspaceDocMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddWorkspaceDocMembersResponse
     */
    public AddWorkspaceDocMembersResponse addWorkspaceDocMembersWithOptions(String workspaceId, String nodeId, AddWorkspaceDocMembersRequest request, AddWorkspaceDocMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
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
            new TeaPair("action", "AddWorkspaceDocMembers"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddWorkspaceDocMembersResponse());
    }

    /**
     * @summary 添加知识库文档成员
     *
     * @param request AddWorkspaceDocMembersRequest
     * @return AddWorkspaceDocMembersResponse
     */
    public AddWorkspaceDocMembersResponse addWorkspaceDocMembers(String workspaceId, String nodeId, AddWorkspaceDocMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddWorkspaceDocMembersHeaders headers = new AddWorkspaceDocMembersHeaders();
        return this.addWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
    }

    /**
     * @summary 添加知识库成员
     *
     * @param request AddWorkspaceMembersRequest
     * @param headers AddWorkspaceMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddWorkspaceMembersResponse
     */
    public AddWorkspaceMembersResponse addWorkspaceMembersWithOptions(String workspaceId, AddWorkspaceMembersRequest request, AddWorkspaceMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
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
            new TeaPair("action", "AddWorkspaceMembers"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/" + workspaceId + "/members"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddWorkspaceMembersResponse());
    }

    /**
     * @summary 添加知识库成员
     *
     * @param request AddWorkspaceMembersRequest
     * @return AddWorkspaceMembersResponse
     */
    public AddWorkspaceMembersResponse addWorkspaceMembers(String workspaceId, AddWorkspaceMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddWorkspaceMembersHeaders headers = new AddWorkspaceMembersHeaders();
        return this.addWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
    }

    /**
     * @summary 追加行
     *
     * @param request AppendRowsRequest
     * @param headers AppendRowsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AppendRowsResponse
     */
    public AppendRowsResponse appendRowsWithOptions(String workbookId, String sheetId, AppendRowsRequest request, AppendRowsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.values)) {
            body.put("values", request.values);
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
            new TeaPair("action", "AppendRows"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/appendRows"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AppendRowsResponse());
    }

    /**
     * @summary 追加行
     *
     * @param request AppendRowsRequest
     * @return AppendRowsResponse
     */
    public AppendRowsResponse appendRows(String workbookId, String sheetId, AppendRowsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AppendRowsHeaders headers = new AppendRowsHeaders();
        return this.appendRowsWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 批量执行表格操作
     *
     * @param request BatchRequest
     * @param headers BatchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchResponse
     */
    public BatchResponse batchWithOptions(String workbookId, BatchRequest request, BatchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.requests)) {
            body.put("requests", request.requests);
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
            new TeaPair("action", "Batch"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchResponse());
    }

    /**
     * @summary 批量执行表格操作
     *
     * @param request BatchRequest
     * @return BatchResponse
     */
    public BatchResponse batch(String workbookId, BatchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchHeaders headers = new BatchHeaders();
        return this.batchWithOptions(workbookId, request, headers, runtime);
    }

    /**
     * @summary 批量查询知识库文档
     *
     * @param request BatchGetWorkspaceDocsRequest
     * @param headers BatchGetWorkspaceDocsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchGetWorkspaceDocsResponse
     */
    public BatchGetWorkspaceDocsResponse batchGetWorkspaceDocsWithOptions(BatchGetWorkspaceDocsRequest request, BatchGetWorkspaceDocsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nodeIds)) {
            body.put("nodeIds", request.nodeIds);
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
            new TeaPair("action", "BatchGetWorkspaceDocs"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/docs/infos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchGetWorkspaceDocsResponse());
    }

    /**
     * @summary 批量查询知识库文档
     *
     * @param request BatchGetWorkspaceDocsRequest
     * @return BatchGetWorkspaceDocsResponse
     */
    public BatchGetWorkspaceDocsResponse batchGetWorkspaceDocs(BatchGetWorkspaceDocsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchGetWorkspaceDocsHeaders headers = new BatchGetWorkspaceDocsHeaders();
        return this.batchGetWorkspaceDocsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 知识库批量查询
     *
     * @param request BatchGetWorkspacesRequest
     * @param headers BatchGetWorkspacesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchGetWorkspacesResponse
     */
    public BatchGetWorkspacesResponse batchGetWorkspacesWithOptions(BatchGetWorkspacesRequest request, BatchGetWorkspacesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.includeRecent)) {
            body.put("includeRecent", request.includeRecent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workspaceIds)) {
            body.put("workspaceIds", request.workspaceIds);
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
            new TeaPair("action", "BatchGetWorkspaces"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/infos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchGetWorkspacesResponse());
    }

    /**
     * @summary 知识库批量查询
     *
     * @param request BatchGetWorkspacesRequest
     * @return BatchGetWorkspacesResponse
     */
    public BatchGetWorkspacesResponse batchGetWorkspaces(BatchGetWorkspacesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchGetWorkspacesHeaders headers = new BatchGetWorkspacesHeaders();
        return this.batchGetWorkspacesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 关联文档酷应用到表格
     *
     * @param request BindCoolAppToSheetRequest
     * @param headers BindCoolAppToSheetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BindCoolAppToSheetResponse
     */
    public BindCoolAppToSheetResponse bindCoolAppToSheetWithOptions(String workbookId, BindCoolAppToSheetRequest request, BindCoolAppToSheetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
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
            new TeaPair("action", "BindCoolAppToSheet"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/coolApps"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BindCoolAppToSheetResponse());
    }

    /**
     * @summary 关联文档酷应用到表格
     *
     * @param request BindCoolAppToSheetRequest
     * @return BindCoolAppToSheetResponse
     */
    public BindCoolAppToSheetResponse bindCoolAppToSheet(String workbookId, BindCoolAppToSheetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BindCoolAppToSheetHeaders headers = new BindCoolAppToSheetHeaders();
        return this.bindCoolAppToSheetWithOptions(workbookId, request, headers, runtime);
    }

    /**
     * @summary 清除单元格区域内所有内容
     *
     * @param request ClearRequest
     * @param headers ClearHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ClearResponse
     */
    public ClearResponse clearWithOptions(String workbookId, String sheetId, String rangeAddress, ClearRequest request, ClearHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "Clear"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/clear"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ClearResponse());
    }

    /**
     * @summary 清除单元格区域内所有内容
     *
     * @param request ClearRequest
     * @return ClearResponse
     */
    public ClearResponse clear(String workbookId, String sheetId, String rangeAddress, ClearRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ClearHeaders headers = new ClearHeaders();
        return this.clearWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
    }

    /**
     * @summary 清除单元格区域内数据
     *
     * @param request ClearDataRequest
     * @param headers ClearDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ClearDataResponse
     */
    public ClearDataResponse clearDataWithOptions(String workbookId, String sheetId, String rangeAddress, ClearDataRequest request, ClearDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ClearData"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/clearData"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ClearDataResponse());
    }

    /**
     * @summary 清除单元格区域内数据
     *
     * @param request ClearDataRequest
     * @return ClearDataResponse
     */
    public ClearDataResponse clearData(String workbookId, String sheetId, String rangeAddress, ClearDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ClearDataHeaders headers = new ClearDataHeaders();
        return this.clearDataWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
    }

    /**
     * @summary 创建条件格式
     *
     * @param request CreateConditionalFormattingRuleRequest
     * @param headers CreateConditionalFormattingRuleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateConditionalFormattingRuleResponse
     */
    public CreateConditionalFormattingRuleResponse createConditionalFormattingRuleWithOptions(String workbookId, String sheetId, CreateConditionalFormattingRuleRequest request, CreateConditionalFormattingRuleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cellStyle)) {
            body.put("cellStyle", request.cellStyle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.duplicateCondition)) {
            body.put("duplicateCondition", request.duplicateCondition);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ranges)) {
            body.put("ranges", request.ranges);
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
            new TeaPair("action", "CreateConditionalFormattingRule"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/conditionalFormattingRules"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateConditionalFormattingRuleResponse());
    }

    /**
     * @summary 创建条件格式
     *
     * @param request CreateConditionalFormattingRuleRequest
     * @return CreateConditionalFormattingRuleResponse
     */
    public CreateConditionalFormattingRuleResponse createConditionalFormattingRule(String workbookId, String sheetId, CreateConditionalFormattingRuleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateConditionalFormattingRuleHeaders headers = new CreateConditionalFormattingRuleHeaders();
        return this.createConditionalFormattingRuleWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 创建开发者元数据
     *
     * @param request CreateDeveloperMetadataRequest
     * @param headers CreateDeveloperMetadataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateDeveloperMetadataResponse
     */
    public CreateDeveloperMetadataResponse createDeveloperMetadataWithOptions(String workbookId, CreateDeveloperMetadataRequest request, CreateDeveloperMetadataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.associatedColumn)) {
            body.put("associatedColumn", request.associatedColumn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.associatedRow)) {
            body.put("associatedRow", request.associatedRow);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.value)) {
            body.put("value", request.value);
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
            new TeaPair("action", "CreateDeveloperMetadata"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/developerMetadatas"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateDeveloperMetadataResponse());
    }

    /**
     * @summary 创建开发者元数据
     *
     * @param request CreateDeveloperMetadataRequest
     * @return CreateDeveloperMetadataResponse
     */
    public CreateDeveloperMetadataResponse createDeveloperMetadata(String workbookId, CreateDeveloperMetadataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDeveloperMetadataHeaders headers = new CreateDeveloperMetadataHeaders();
        return this.createDeveloperMetadataWithOptions(workbookId, request, headers, runtime);
    }

    /**
     * @summary 创建单元格锁定
     *
     * @param request CreateRangeProtectionRequest
     * @param headers CreateRangeProtectionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateRangeProtectionResponse
     */
    public CreateRangeProtectionResponse createRangeProtectionWithOptions(String workbookId, String sheetId, String rangeAddress, CreateRangeProtectionRequest request, CreateRangeProtectionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.editableSetting)) {
            body.put("editableSetting", request.editableSetting);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.otherUserPermission)) {
            body.put("otherUserPermission", request.otherUserPermission);
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
            new TeaPair("action", "CreateRangeProtection"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/protections"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateRangeProtectionResponse());
    }

    /**
     * @summary 创建单元格锁定
     *
     * @param request CreateRangeProtectionRequest
     * @return CreateRangeProtectionResponse
     */
    public CreateRangeProtectionResponse createRangeProtection(String workbookId, String sheetId, String rangeAddress, CreateRangeProtectionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateRangeProtectionHeaders headers = new CreateRangeProtectionHeaders();
        return this.createRangeProtectionWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
    }

    /**
     * @summary 创建工作表
     *
     * @param request CreateSheetRequest
     * @param headers CreateSheetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateSheetResponse
     */
    public CreateSheetResponse createSheetWithOptions(String workbookId, CreateSheetRequest request, CreateSheetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
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
            new TeaPair("action", "CreateSheet"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateSheetResponse());
    }

    /**
     * @summary 创建工作表
     *
     * @param request CreateSheetRequest
     * @return CreateSheetResponse
     */
    public CreateSheetResponse createSheet(String workbookId, CreateSheetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSheetHeaders headers = new CreateSheetHeaders();
        return this.createSheetWithOptions(workbookId, request, headers, runtime);
    }

    /**
     * @summary 新建知识库
     *
     * @param request CreateWorkspaceRequest
     * @param headers CreateWorkspaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateWorkspaceResponse
     */
    public CreateWorkspaceResponse createWorkspaceWithOptions(CreateWorkspaceRequest request, CreateWorkspaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "CreateWorkspace"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateWorkspaceResponse());
    }

    /**
     * @summary 新建知识库
     *
     * @param request CreateWorkspaceRequest
     * @return CreateWorkspaceResponse
     */
    public CreateWorkspaceResponse createWorkspace(CreateWorkspaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateWorkspaceHeaders headers = new CreateWorkspaceHeaders();
        return this.createWorkspaceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建知识库文档
     *
     * @param request CreateWorkspaceDocRequest
     * @param headers CreateWorkspaceDocHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateWorkspaceDocResponse
     */
    public CreateWorkspaceDocResponse createWorkspaceDocWithOptions(String workspaceId, CreateWorkspaceDocRequest request, CreateWorkspaceDocHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.docType)) {
            body.put("docType", request.docType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentNodeId)) {
            body.put("parentNodeId", request.parentNodeId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateType)) {
            body.put("templateType", request.templateType);
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
            new TeaPair("action", "CreateWorkspaceDoc"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/" + workspaceId + "/docs"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateWorkspaceDocResponse());
    }

    /**
     * @summary 创建知识库文档
     *
     * @param request CreateWorkspaceDocRequest
     * @return CreateWorkspaceDocResponse
     */
    public CreateWorkspaceDocResponse createWorkspaceDoc(String workspaceId, CreateWorkspaceDocRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateWorkspaceDocHeaders headers = new CreateWorkspaceDocHeaders();
        return this.createWorkspaceDocWithOptions(workspaceId, request, headers, runtime);
    }

    /**
     * @summary 删除列
     *
     * @param request DeleteColumnsRequest
     * @param headers DeleteColumnsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteColumnsResponse
     */
    public DeleteColumnsResponse deleteColumnsWithOptions(String workbookId, String sheetId, DeleteColumnsRequest request, DeleteColumnsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.column)) {
            body.put("column", request.column);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.columnCount)) {
            body.put("columnCount", request.columnCount);
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
            new TeaPair("action", "DeleteColumns"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/deleteColumns"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteColumnsResponse());
    }

    /**
     * @summary 删除列
     *
     * @param request DeleteColumnsRequest
     * @return DeleteColumnsResponse
     */
    public DeleteColumnsResponse deleteColumns(String workbookId, String sheetId, DeleteColumnsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteColumnsHeaders headers = new DeleteColumnsHeaders();
        return this.deleteColumnsWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 删除下拉列表
     *
     * @param request DeleteDropdownListsRequest
     * @param headers DeleteDropdownListsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteDropdownListsResponse
     */
    public DeleteDropdownListsResponse deleteDropdownListsWithOptions(String workbookId, String sheetId, String rangeAddress, DeleteDropdownListsRequest request, DeleteDropdownListsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteDropdownLists"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/deleteDropdownLists"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteDropdownListsResponse());
    }

    /**
     * @summary 删除下拉列表
     *
     * @param request DeleteDropdownListsRequest
     * @return DeleteDropdownListsResponse
     */
    public DeleteDropdownListsResponse deleteDropdownLists(String workbookId, String sheetId, String rangeAddress, DeleteDropdownListsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteDropdownListsHeaders headers = new DeleteDropdownListsHeaders();
        return this.deleteDropdownListsWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
    }

    /**
     * @summary 删除单元格锁定
     *
     * @param request DeleteRangeProtectionRequest
     * @param headers DeleteRangeProtectionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteRangeProtectionResponse
     */
    public DeleteRangeProtectionResponse deleteRangeProtectionWithOptions(String workbookId, String sheetId, String rangeAddress, String protectionId, DeleteRangeProtectionRequest request, DeleteRangeProtectionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteRangeProtection"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/protections/" + protectionId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteRangeProtectionResponse());
    }

    /**
     * @summary 删除单元格锁定
     *
     * @param request DeleteRangeProtectionRequest
     * @return DeleteRangeProtectionResponse
     */
    public DeleteRangeProtectionResponse deleteRangeProtection(String workbookId, String sheetId, String rangeAddress, String protectionId, DeleteRangeProtectionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteRangeProtectionHeaders headers = new DeleteRangeProtectionHeaders();
        return this.deleteRangeProtectionWithOptions(workbookId, sheetId, rangeAddress, protectionId, request, headers, runtime);
    }

    /**
     * @summary 删除行
     *
     * @param request DeleteRowsRequest
     * @param headers DeleteRowsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteRowsResponse
     */
    public DeleteRowsResponse deleteRowsWithOptions(String workbookId, String sheetId, DeleteRowsRequest request, DeleteRowsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.row)) {
            body.put("row", request.row);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rowCount)) {
            body.put("rowCount", request.rowCount);
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
            new TeaPair("action", "DeleteRows"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/deleteRows"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteRowsResponse());
    }

    /**
     * @summary 删除行
     *
     * @param request DeleteRowsRequest
     * @return DeleteRowsResponse
     */
    public DeleteRowsResponse deleteRows(String workbookId, String sheetId, DeleteRowsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteRowsHeaders headers = new DeleteRowsHeaders();
        return this.deleteRowsWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 删除工作表
     *
     * @param request DeleteSheetRequest
     * @param headers DeleteSheetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteSheetResponse
     */
    public DeleteSheetResponse deleteSheetWithOptions(String workbookId, String sheetId, DeleteSheetRequest request, DeleteSheetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteSheet"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteSheetResponse());
    }

    /**
     * @summary 删除工作表
     *
     * @param request DeleteSheetRequest
     * @return DeleteSheetResponse
     */
    public DeleteSheetResponse deleteSheet(String workbookId, String sheetId, DeleteSheetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSheetHeaders headers = new DeleteSheetHeaders();
        return this.deleteSheetWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 删除知识库文档
     *
     * @param request DeleteWorkspaceDocRequest
     * @param headers DeleteWorkspaceDocHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteWorkspaceDocResponse
     */
    public DeleteWorkspaceDocResponse deleteWorkspaceDocWithOptions(String workspaceId, String nodeId, DeleteWorkspaceDocRequest request, DeleteWorkspaceDocHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteWorkspaceDoc"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteWorkspaceDocResponse());
    }

    /**
     * @summary 删除知识库文档
     *
     * @param request DeleteWorkspaceDocRequest
     * @return DeleteWorkspaceDocResponse
     */
    public DeleteWorkspaceDocResponse deleteWorkspaceDoc(String workspaceId, String nodeId, DeleteWorkspaceDocRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteWorkspaceDocHeaders headers = new DeleteWorkspaceDocHeaders();
        return this.deleteWorkspaceDocWithOptions(workspaceId, nodeId, request, headers, runtime);
    }

    /**
     * @summary 删除知识库文档成员
     *
     * @param request DeleteWorkspaceDocMembersRequest
     * @param headers DeleteWorkspaceDocMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteWorkspaceDocMembersResponse
     */
    public DeleteWorkspaceDocMembersResponse deleteWorkspaceDocMembersWithOptions(String workspaceId, String nodeId, DeleteWorkspaceDocMembersRequest request, DeleteWorkspaceDocMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
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
            new TeaPair("action", "DeleteWorkspaceDocMembers"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteWorkspaceDocMembersResponse());
    }

    /**
     * @summary 删除知识库文档成员
     *
     * @param request DeleteWorkspaceDocMembersRequest
     * @return DeleteWorkspaceDocMembersResponse
     */
    public DeleteWorkspaceDocMembersResponse deleteWorkspaceDocMembers(String workspaceId, String nodeId, DeleteWorkspaceDocMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteWorkspaceDocMembersHeaders headers = new DeleteWorkspaceDocMembersHeaders();
        return this.deleteWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
    }

    /**
     * @summary 删除知识库成员
     *
     * @param request DeleteWorkspaceMembersRequest
     * @param headers DeleteWorkspaceMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteWorkspaceMembersResponse
     */
    public DeleteWorkspaceMembersResponse deleteWorkspaceMembersWithOptions(String workspaceId, DeleteWorkspaceMembersRequest request, DeleteWorkspaceMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
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
            new TeaPair("action", "DeleteWorkspaceMembers"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/" + workspaceId + "/members/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteWorkspaceMembersResponse());
    }

    /**
     * @summary 删除知识库成员
     *
     * @param request DeleteWorkspaceMembersRequest
     * @return DeleteWorkspaceMembersResponse
     */
    public DeleteWorkspaceMembersResponse deleteWorkspaceMembers(String workspaceId, DeleteWorkspaceMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteWorkspaceMembersHeaders headers = new DeleteWorkspaceMembersHeaders();
        return this.deleteWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
    }

    /**
     * @summary 追加指定段落元素
     *
     * @param request DocAppendParagraphRequest
     * @param headers DocAppendParagraphHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DocAppendParagraphResponse
     */
    public DocAppendParagraphResponse docAppendParagraphWithOptions(String docKey, String blockId, DocAppendParagraphRequest request, DocAppendParagraphHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.elementType)) {
            body.put("elementType", request.elementType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.properties)) {
            body.put("properties", request.properties);
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
            new TeaPair("action", "DocAppendParagraph"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/suites/documents/" + docKey + "/blocks/" + blockId + "/paragraph/appendElement"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DocAppendParagraphResponse());
    }

    /**
     * @summary 追加指定段落元素
     *
     * @param request DocAppendParagraphRequest
     * @return DocAppendParagraphResponse
     */
    public DocAppendParagraphResponse docAppendParagraph(String docKey, String blockId, DocAppendParagraphRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DocAppendParagraphHeaders headers = new DocAppendParagraphHeaders();
        return this.docAppendParagraphWithOptions(docKey, blockId, request, headers, runtime);
    }

    /**
     * @summary 在段落后追加文本
     *
     * @param request DocAppendTextRequest
     * @param headers DocAppendTextHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DocAppendTextResponse
     */
    public DocAppendTextResponse docAppendTextWithOptions(String docKey, String blockId, DocAppendTextRequest request, DocAppendTextHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.text)) {
            body.put("text", request.text);
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
            new TeaPair("action", "DocAppendText"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/suites/documents/" + docKey + "/blocks/" + blockId + "/paragraph/appendText"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DocAppendTextResponse());
    }

    /**
     * @summary 在段落后追加文本
     *
     * @param request DocAppendTextRequest
     * @return DocAppendTextResponse
     */
    public DocAppendTextResponse docAppendText(String docKey, String blockId, DocAppendTextRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DocAppendTextHeaders headers = new DocAppendTextHeaders();
        return this.docAppendTextWithOptions(docKey, blockId, request, headers, runtime);
    }

    /**
     * @summary 查询指定Block元素
     *
     * @param request DocBlocksQueryRequest
     * @param headers DocBlocksQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DocBlocksQueryResponse
     */
    public DocBlocksQueryResponse docBlocksQueryWithOptions(String docKey, DocBlocksQueryRequest request, DocBlocksQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.blockType)) {
            query.put("blockType", request.blockType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endIndex)) {
            query.put("endIndex", request.endIndex);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startIndex)) {
            query.put("startIndex", request.startIndex);
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
            new TeaPair("action", "DocBlocksQuery"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/suites/documents/" + docKey + "/blocks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DocBlocksQueryResponse());
    }

    /**
     * @summary 查询指定Block元素
     *
     * @param request DocBlocksQueryRequest
     * @return DocBlocksQueryResponse
     */
    public DocBlocksQueryResponse docBlocksQuery(String docKey, DocBlocksQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DocBlocksQueryHeaders headers = new DocBlocksQueryHeaders();
        return this.docBlocksQueryWithOptions(docKey, request, headers, runtime);
    }

    /**
     * @summary 删除指定位置的 Block
     *
     * @param request DocDeleteBlockRequest
     * @param headers DocDeleteBlockHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DocDeleteBlockResponse
     */
    public DocDeleteBlockResponse docDeleteBlockWithOptions(String docKey, String blockId, DocDeleteBlockRequest request, DocDeleteBlockHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DocDeleteBlock"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/suites/documents/" + docKey + "/blocks/" + blockId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DocDeleteBlockResponse());
    }

    /**
     * @summary 删除指定位置的 Block
     *
     * @param request DocDeleteBlockRequest
     * @return DocDeleteBlockResponse
     */
    public DocDeleteBlockResponse docDeleteBlock(String docKey, String blockId, DocDeleteBlockRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DocDeleteBlockHeaders headers = new DocDeleteBlockHeaders();
        return this.docDeleteBlockWithOptions(docKey, blockId, request, headers, runtime);
    }

    /**
     * @summary 插入指定Block元素
     *
     * @param request DocInsertBlocksRequest
     * @param headers DocInsertBlocksHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DocInsertBlocksResponse
     */
    public DocInsertBlocksResponse docInsertBlocksWithOptions(String docKey, DocInsertBlocksRequest request, DocInsertBlocksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.blockId)) {
            body.put("blockId", request.blockId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.element)) {
            body.put("element", request.element);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.index)) {
            body.put("index", request.index);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.where)) {
            body.put("where", request.where);
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
            new TeaPair("action", "DocInsertBlocks"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/suites/documents/" + docKey + "/blocks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DocInsertBlocksResponse());
    }

    /**
     * @summary 插入指定Block元素
     *
     * @param request DocInsertBlocksRequest
     * @return DocInsertBlocksResponse
     */
    public DocInsertBlocksResponse docInsertBlocks(String docKey, DocInsertBlocksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DocInsertBlocksHeaders headers = new DocInsertBlocksHeaders();
        return this.docInsertBlocksWithOptions(docKey, request, headers, runtime);
    }

    /**
     * @summary 覆写全文
     *
     * @param request DocUpdateContentRequest
     * @param headers DocUpdateContentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DocUpdateContentResponse
     */
    public DocUpdateContentResponse docUpdateContentWithOptions(String docKey, DocUpdateContentRequest request, DocUpdateContentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dataType)) {
            body.put("dataType", request.dataType);
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
            new TeaPair("action", "DocUpdateContent"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/suites/documents/" + docKey + "/overwriteContent"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DocUpdateContentResponse());
    }

    /**
     * @summary 覆写全文
     *
     * @param request DocUpdateContentRequest
     * @return DocUpdateContentResponse
     */
    public DocUpdateContentResponse docUpdateContent(String docKey, DocUpdateContentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DocUpdateContentHeaders headers = new DocUpdateContentHeaders();
        return this.docUpdateContentWithOptions(docKey, request, headers, runtime);
    }

    /**
     * @summary 获取所有工作表
     *
     * @param request GetAllSheetsRequest
     * @param headers GetAllSheetsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAllSheetsResponse
     */
    public GetAllSheetsResponse getAllSheetsWithOptions(String workbookId, GetAllSheetsRequest request, GetAllSheetsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetAllSheets"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAllSheetsResponse());
    }

    /**
     * @summary 获取所有工作表
     *
     * @param request GetAllSheetsRequest
     * @return GetAllSheetsResponse
     */
    public GetAllSheetsResponse getAllSheets(String workbookId, GetAllSheetsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
        return this.getAllSheetsWithOptions(workbookId, request, headers, runtime);
    }

    /**
     * @summary 获取开发者元数据
     *
     * @param request GetDeveloperMetadataRequest
     * @param headers GetDeveloperMetadataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDeveloperMetadataResponse
     */
    public GetDeveloperMetadataResponse getDeveloperMetadataWithOptions(String workbookId, String developerMetadataId, GetDeveloperMetadataRequest request, GetDeveloperMetadataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetDeveloperMetadata"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/developerMetadatas/" + developerMetadataId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDeveloperMetadataResponse());
    }

    /**
     * @summary 获取开发者元数据
     *
     * @param request GetDeveloperMetadataRequest
     * @return GetDeveloperMetadataResponse
     */
    public GetDeveloperMetadataResponse getDeveloperMetadata(String workbookId, String developerMetadataId, GetDeveloperMetadataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDeveloperMetadataHeaders headers = new GetDeveloperMetadataHeaders();
        return this.getDeveloperMetadataWithOptions(workbookId, developerMetadataId, request, headers, runtime);
    }

    /**
     * @summary 获取单元格区域
     *
     * @param request GetRangeRequest
     * @param headers GetRangeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRangeResponse
     */
    public GetRangeResponse getRangeWithOptions(String workbookId, String sheetId, String rangeAddress, GetRangeRequest request, GetRangeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.select)) {
            query.put("select", request.select);
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
            new TeaPair("action", "GetRange"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRangeResponse());
    }

    /**
     * @summary 获取单元格区域
     *
     * @param request GetRangeRequest
     * @return GetRangeResponse
     */
    public GetRangeResponse getRange(String workbookId, String sheetId, String rangeAddress, GetRangeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRangeHeaders headers = new GetRangeHeaders();
        return this.getRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
    }

    /**
     * @summary 获取最近编辑文档
     *
     * @param request GetRecentEditDocsRequest
     * @param headers GetRecentEditDocsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRecentEditDocsResponse
     */
    public GetRecentEditDocsResponse getRecentEditDocsWithOptions(GetRecentEditDocsRequest request, GetRecentEditDocsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetRecentEditDocs"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/docs/recentEditDocs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRecentEditDocsResponse());
    }

    /**
     * @summary 获取最近编辑文档
     *
     * @param request GetRecentEditDocsRequest
     * @return GetRecentEditDocsResponse
     */
    public GetRecentEditDocsResponse getRecentEditDocs(GetRecentEditDocsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRecentEditDocsHeaders headers = new GetRecentEditDocsHeaders();
        return this.getRecentEditDocsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取最近打开文档
     *
     * @param request GetRecentOpenDocsRequest
     * @param headers GetRecentOpenDocsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRecentOpenDocsResponse
     */
    public GetRecentOpenDocsResponse getRecentOpenDocsWithOptions(GetRecentOpenDocsRequest request, GetRecentOpenDocsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetRecentOpenDocs"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/docs/recentOpenDocs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRecentOpenDocsResponse());
    }

    /**
     * @summary 获取最近打开文档
     *
     * @param request GetRecentOpenDocsRequest
     * @return GetRecentOpenDocsResponse
     */
    public GetRecentOpenDocsResponse getRecentOpenDocs(GetRecentOpenDocsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRecentOpenDocsHeaders headers = new GetRecentOpenDocsHeaders();
        return this.getRecentOpenDocsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询用户有权限的知识库
     *
     * @param request GetRelatedWorkspacesRequest
     * @param headers GetRelatedWorkspacesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRelatedWorkspacesResponse
     */
    public GetRelatedWorkspacesResponse getRelatedWorkspacesWithOptions(GetRelatedWorkspacesRequest request, GetRelatedWorkspacesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.includeRecent)) {
            query.put("includeRecent", request.includeRecent);
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
            new TeaPair("action", "GetRelatedWorkspaces"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRelatedWorkspacesResponse());
    }

    /**
     * @summary 查询用户有权限的知识库
     *
     * @param request GetRelatedWorkspacesRequest
     * @return GetRelatedWorkspacesResponse
     */
    public GetRelatedWorkspacesResponse getRelatedWorkspaces(GetRelatedWorkspacesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRelatedWorkspacesHeaders headers = new GetRelatedWorkspacesHeaders();
        return this.getRelatedWorkspacesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取工作表
     *
     * @param request GetSheetRequest
     * @param headers GetSheetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSheetResponse
     */
    public GetSheetResponse getSheetWithOptions(String workbookId, String sheetId, GetSheetRequest request, GetSheetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetSheet"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSheetResponse());
    }

    /**
     * @summary 获取工作表
     *
     * @param request GetSheetRequest
     * @return GetSheetResponse
     */
    public GetSheetResponse getSheet(String workbookId, String sheetId, GetSheetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSheetHeaders headers = new GetSheetHeaders();
        return this.getSheetWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 查询文档模版
     *
     * @param request GetTemplateByIdRequest
     * @param headers GetTemplateByIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTemplateByIdResponse
     */
    public GetTemplateByIdResponse getTemplateByIdWithOptions(String templateId, GetTemplateByIdRequest request, GetTemplateByIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.belong)) {
            query.put("belong", request.belong);
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
            new TeaPair("action", "GetTemplateById"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/templates/" + templateId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTemplateByIdResponse());
    }

    /**
     * @summary 查询文档模版
     *
     * @param request GetTemplateByIdRequest
     * @return GetTemplateByIdResponse
     */
    public GetTemplateByIdResponse getTemplateById(String templateId, GetTemplateByIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTemplateByIdHeaders headers = new GetTemplateByIdHeaders();
        return this.getTemplateByIdWithOptions(templateId, request, headers, runtime);
    }

    /**
     * @summary 查询知识库信息
     *
     * @param headers GetWorkspaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetWorkspaceResponse
     */
    public GetWorkspaceResponse getWorkspaceWithOptions(String workspaceId, GetWorkspaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetWorkspace"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/" + workspaceId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetWorkspaceResponse());
    }

    /**
     * @summary 查询知识库信息
     *
     * @return GetWorkspaceResponse
     */
    public GetWorkspaceResponse getWorkspace(String workspaceId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetWorkspaceHeaders headers = new GetWorkspaceHeaders();
        return this.getWorkspaceWithOptions(workspaceId, headers, runtime);
    }

    /**
     * @summary 查询知识库文档
     *
     * @param request GetWorkspaceNodeRequest
     * @param headers GetWorkspaceNodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetWorkspaceNodeResponse
     */
    public GetWorkspaceNodeResponse getWorkspaceNodeWithOptions(String workspaceId, String nodeId, GetWorkspaceNodeRequest request, GetWorkspaceNodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetWorkspaceNode"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetWorkspaceNodeResponse());
    }

    /**
     * @summary 查询知识库文档
     *
     * @param request GetWorkspaceNodeRequest
     * @return GetWorkspaceNodeResponse
     */
    public GetWorkspaceNodeResponse getWorkspaceNode(String workspaceId, String nodeId, GetWorkspaceNodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetWorkspaceNodeHeaders headers = new GetWorkspaceNodeHeaders();
        return this.getWorkspaceNodeWithOptions(workspaceId, nodeId, request, headers, runtime);
    }

    /**
     * @summary 文档初始化
     *
     * @param request InitDocumentRequest
     * @param headers InitDocumentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InitDocumentResponse
     */
    public InitDocumentResponse initDocumentWithOptions(String docId, InitDocumentRequest request, InitDocumentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attachmentsMap)) {
            body.put("attachmentsMap", request.attachmentsMap);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.importType)) {
            body.put("importType", request.importType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.linksKey)) {
            body.put("linksKey", request.linksKey);
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
            new TeaPair("action", "InitDocument"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/docs/" + docId + "/init"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InitDocumentResponse());
    }

    /**
     * @summary 文档初始化
     *
     * @param request InitDocumentRequest
     * @return InitDocumentResponse
     */
    public InitDocumentResponse initDocument(String docId, InitDocumentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InitDocumentHeaders headers = new InitDocumentHeaders();
        return this.initDocumentWithOptions(docId, request, headers, runtime);
    }

    /**
     * @summary 向文档内插入块级元素
     *
     * @param request InsertBlocksRequest
     * @param headers InsertBlocksHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InsertBlocksResponse
     */
    public InsertBlocksResponse insertBlocksWithOptions(String documentId, InsertBlocksRequest request, InsertBlocksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.blocks)) {
            body.put("blocks", request.blocks);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.location)) {
            body.put("location", request.location);
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
            new TeaPair("action", "InsertBlocks"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/documents/" + documentId + "/blocks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InsertBlocksResponse());
    }

    /**
     * @summary 向文档内插入块级元素
     *
     * @param request InsertBlocksRequest
     * @return InsertBlocksResponse
     */
    public InsertBlocksResponse insertBlocks(String documentId, InsertBlocksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InsertBlocksHeaders headers = new InsertBlocksHeaders();
        return this.insertBlocksWithOptions(documentId, request, headers, runtime);
    }

    /**
     * @summary 指定列左侧插入若干列
     *
     * @param request InsertColumnsBeforeRequest
     * @param headers InsertColumnsBeforeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InsertColumnsBeforeResponse
     */
    public InsertColumnsBeforeResponse insertColumnsBeforeWithOptions(String workbookId, String sheetId, InsertColumnsBeforeRequest request, InsertColumnsBeforeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.column)) {
            body.put("column", request.column);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.columnCount)) {
            body.put("columnCount", request.columnCount);
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
            new TeaPair("action", "InsertColumnsBefore"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/insertColumnsBefore"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InsertColumnsBeforeResponse());
    }

    /**
     * @summary 指定列左侧插入若干列
     *
     * @param request InsertColumnsBeforeRequest
     * @return InsertColumnsBeforeResponse
     */
    public InsertColumnsBeforeResponse insertColumnsBefore(String workbookId, String sheetId, InsertColumnsBeforeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InsertColumnsBeforeHeaders headers = new InsertColumnsBeforeHeaders();
        return this.insertColumnsBeforeWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 插入下拉列表
     *
     * @param request InsertDropdownListsRequest
     * @param headers InsertDropdownListsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InsertDropdownListsResponse
     */
    public InsertDropdownListsResponse insertDropdownListsWithOptions(String workbookId, String sheetId, String rangeAddress, InsertDropdownListsRequest request, InsertDropdownListsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.options)) {
            body.put("options", request.options);
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
            new TeaPair("action", "InsertDropdownLists"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/insertDropdownLists"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InsertDropdownListsResponse());
    }

    /**
     * @summary 插入下拉列表
     *
     * @param request InsertDropdownListsRequest
     * @return InsertDropdownListsResponse
     */
    public InsertDropdownListsResponse insertDropdownLists(String workbookId, String sheetId, String rangeAddress, InsertDropdownListsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InsertDropdownListsHeaders headers = new InsertDropdownListsHeaders();
        return this.insertDropdownListsWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
    }

    /**
     * @summary 指定行上方插入若干行
     *
     * @param request InsertRowsBeforeRequest
     * @param headers InsertRowsBeforeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InsertRowsBeforeResponse
     */
    public InsertRowsBeforeResponse insertRowsBeforeWithOptions(String workbookId, String sheetId, InsertRowsBeforeRequest request, InsertRowsBeforeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.row)) {
            body.put("row", request.row);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rowCount)) {
            body.put("rowCount", request.rowCount);
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
            new TeaPair("action", "InsertRowsBefore"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/insertRowsBefore"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InsertRowsBeforeResponse());
    }

    /**
     * @summary 指定行上方插入若干行
     *
     * @param request InsertRowsBeforeRequest
     * @return InsertRowsBeforeResponse
     */
    public InsertRowsBeforeResponse insertRowsBefore(String workbookId, String sheetId, InsertRowsBeforeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InsertRowsBeforeHeaders headers = new InsertRowsBeforeHeaders();
        return this.insertRowsBeforeWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 查询文档模版
     *
     * @param request ListTemplateRequest
     * @param headers ListTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListTemplateResponse
     */
    public ListTemplateResponse listTemplateWithOptions(ListTemplateRequest request, ListTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.templateType)) {
            query.put("templateType", request.templateType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workspaceId)) {
            query.put("workspaceId", request.workspaceId);
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
            new TeaPair("action", "ListTemplate"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/templates"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListTemplateResponse());
    }

    /**
     * @summary 查询文档模版
     *
     * @param request ListTemplateRequest
     * @return ListTemplateResponse
     */
    public ListTemplateResponse listTemplate(ListTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListTemplateHeaders headers = new ListTemplateHeaders();
        return this.listTemplateWithOptions(request, headers, runtime);
    }

    /**
     * @summary 合并单元格
     *
     * @param request MergeRangeRequest
     * @param headers MergeRangeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MergeRangeResponse
     */
    public MergeRangeResponse mergeRangeWithOptions(String workbookId, String sheetId, String rangeAddress, MergeRangeRequest request, MergeRangeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "MergeRange"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/merge"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MergeRangeResponse());
    }

    /**
     * @summary 合并单元格
     *
     * @param request MergeRangeRequest
     * @return MergeRangeResponse
     */
    public MergeRangeResponse mergeRange(String workbookId, String sheetId, String rangeAddress, MergeRangeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MergeRangeHeaders headers = new MergeRangeHeaders();
        return this.mergeRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
    }

    /**
     * @summary 查找下一个符合条件的单元格
     *
     * @param request RangeFindNextRequest
     * @param headers RangeFindNextHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RangeFindNextResponse
     */
    public RangeFindNextResponse rangeFindNextWithOptions(String workbookId, String sheetId, String rangeAddress, RangeFindNextRequest request, RangeFindNextHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.findOptions)) {
            body.put("findOptions", request.findOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.text)) {
            body.put("text", request.text);
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
            new TeaPair("action", "RangeFindNext"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/findNext"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RangeFindNextResponse());
    }

    /**
     * @summary 查找下一个符合条件的单元格
     *
     * @param request RangeFindNextRequest
     * @return RangeFindNextResponse
     */
    public RangeFindNextResponse rangeFindNext(String workbookId, String sheetId, String rangeAddress, RangeFindNextRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RangeFindNextHeaders headers = new RangeFindNextHeaders();
        return this.rangeFindNextWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
    }

    /**
     * @summary 搜索用户有权限的知识库文档
     *
     * @param request SearchWorkspaceDocsRequest
     * @param headers SearchWorkspaceDocsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchWorkspaceDocsResponse
     */
    public SearchWorkspaceDocsResponse searchWorkspaceDocsWithOptions(SearchWorkspaceDocsRequest request, SearchWorkspaceDocsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            query.put("keyword", request.keyword);
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

        if (!com.aliyun.teautil.Common.isUnset(request.workspaceId)) {
            query.put("workspaceId", request.workspaceId);
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
            new TeaPair("action", "SearchWorkspaceDocs"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/docs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchWorkspaceDocsResponse());
    }

    /**
     * @summary 搜索用户有权限的知识库文档
     *
     * @param request SearchWorkspaceDocsRequest
     * @return SearchWorkspaceDocsResponse
     */
    public SearchWorkspaceDocsResponse searchWorkspaceDocs(SearchWorkspaceDocsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchWorkspaceDocsHeaders headers = new SearchWorkspaceDocsHeaders();
        return this.searchWorkspaceDocsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 设置列宽
     *
     * @param request SetColumnWidthRequest
     * @param headers SetColumnWidthHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetColumnWidthResponse
     */
    public SetColumnWidthResponse setColumnWidthWithOptions(String workbookId, String sheetId, SetColumnWidthRequest request, SetColumnWidthHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.column)) {
            body.put("column", request.column);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.width)) {
            body.put("width", request.width);
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
            new TeaPair("action", "SetColumnWidth"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setColumnWidth"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetColumnWidthResponse());
    }

    /**
     * @summary 设置列宽
     *
     * @param request SetColumnWidthRequest
     * @return SetColumnWidthResponse
     */
    public SetColumnWidthResponse setColumnWidth(String workbookId, String sheetId, SetColumnWidthRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetColumnWidthHeaders headers = new SetColumnWidthHeaders();
        return this.setColumnWidthWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 设置列隐藏或显示
     *
     * @param request SetColumnsVisibilityRequest
     * @param headers SetColumnsVisibilityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetColumnsVisibilityResponse
     */
    public SetColumnsVisibilityResponse setColumnsVisibilityWithOptions(String workbookId, String sheetId, SetColumnsVisibilityRequest request, SetColumnsVisibilityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.column)) {
            body.put("column", request.column);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.columnCount)) {
            body.put("columnCount", request.columnCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.visibility)) {
            body.put("visibility", request.visibility);
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
            new TeaPair("action", "SetColumnsVisibility"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setColumnsVisibility"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetColumnsVisibilityResponse());
    }

    /**
     * @summary 设置列隐藏或显示
     *
     * @param request SetColumnsVisibilityRequest
     * @return SetColumnsVisibilityResponse
     */
    public SetColumnsVisibilityResponse setColumnsVisibility(String workbookId, String sheetId, SetColumnsVisibilityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetColumnsVisibilityHeaders headers = new SetColumnsVisibilityHeaders();
        return this.setColumnsVisibilityWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 设置行高
     *
     * @param request SetRowHeightRequest
     * @param headers SetRowHeightHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetRowHeightResponse
     */
    public SetRowHeightResponse setRowHeightWithOptions(String workbookId, String sheetId, SetRowHeightRequest request, SetRowHeightHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.height)) {
            body.put("height", request.height);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.row)) {
            body.put("row", request.row);
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
            new TeaPair("action", "SetRowHeight"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setRowHeight"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetRowHeightResponse());
    }

    /**
     * @summary 设置行高
     *
     * @param request SetRowHeightRequest
     * @return SetRowHeightResponse
     */
    public SetRowHeightResponse setRowHeight(String workbookId, String sheetId, SetRowHeightRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetRowHeightHeaders headers = new SetRowHeightHeaders();
        return this.setRowHeightWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 设置行隐藏或显示
     *
     * @param request SetRowsVisibilityRequest
     * @param headers SetRowsVisibilityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetRowsVisibilityResponse
     */
    public SetRowsVisibilityResponse setRowsVisibilityWithOptions(String workbookId, String sheetId, SetRowsVisibilityRequest request, SetRowsVisibilityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.row)) {
            body.put("row", request.row);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rowCount)) {
            body.put("rowCount", request.rowCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.visibility)) {
            body.put("visibility", request.visibility);
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
            new TeaPair("action", "SetRowsVisibility"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setRowsVisibility"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetRowsVisibilityResponse());
    }

    /**
     * @summary 设置行隐藏或显示
     *
     * @param request SetRowsVisibilityRequest
     * @return SetRowsVisibilityResponse
     */
    public SetRowsVisibilityResponse setRowsVisibility(String workbookId, String sheetId, SetRowsVisibilityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetRowsVisibilityHeaders headers = new SetRowsVisibilityHeaders();
        return this.setRowsVisibilityWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary SheetAutofitRows
     *
     * @param request SheetAutofitRowsRequest
     * @param headers SheetAutofitRowsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SheetAutofitRowsResponse
     */
    public SheetAutofitRowsResponse sheetAutofitRowsWithOptions(String workbookId, String sheetId, SheetAutofitRowsRequest request, SheetAutofitRowsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fontWidth)) {
            body.put("fontWidth", request.fontWidth);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.row)) {
            body.put("row", request.row);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rowCount)) {
            body.put("rowCount", request.rowCount);
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
            new TeaPair("action", "SheetAutofitRows"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/autofitRows"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SheetAutofitRowsResponse());
    }

    /**
     * @summary SheetAutofitRows
     *
     * @param request SheetAutofitRowsRequest
     * @return SheetAutofitRowsResponse
     */
    public SheetAutofitRowsResponse sheetAutofitRows(String workbookId, String sheetId, SheetAutofitRowsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SheetAutofitRowsHeaders headers = new SheetAutofitRowsHeaders();
        return this.sheetAutofitRowsWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 工作表上查找所有符合条件的单元格
     *
     * @param request SheetFindAllRequest
     * @param headers SheetFindAllHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SheetFindAllResponse
     */
    public SheetFindAllResponse sheetFindAllWithOptions(String workbookId, String sheetId, SheetFindAllRequest request, SheetFindAllHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.select)) {
            query.put("select", request.select);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.findOptions)) {
            body.put("findOptions", request.findOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.text)) {
            body.put("text", request.text);
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
            new TeaPair("action", "SheetFindAll"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/findAll"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SheetFindAllResponse());
    }

    /**
     * @summary 工作表上查找所有符合条件的单元格
     *
     * @param request SheetFindAllRequest
     * @return SheetFindAllResponse
     */
    public SheetFindAllResponse sheetFindAll(String workbookId, String sheetId, SheetFindAllRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SheetFindAllHeaders headers = new SheetFindAllHeaders();
        return this.sheetFindAllWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 取消文档酷应用和表格的关联
     *
     * @param request UnbindCoolAppToSheetRequest
     * @param headers UnbindCoolAppToSheetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UnbindCoolAppToSheetResponse
     */
    public UnbindCoolAppToSheetResponse unbindCoolAppToSheetWithOptions(String workbookId, UnbindCoolAppToSheetRequest request, UnbindCoolAppToSheetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            query.put("coolAppCode", request.coolAppCode);
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
            new TeaPair("action", "UnbindCoolAppToSheet"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/coolApps"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UnbindCoolAppToSheetResponse());
    }

    /**
     * @summary 取消文档酷应用和表格的关联
     *
     * @param request UnbindCoolAppToSheetRequest
     * @return UnbindCoolAppToSheetResponse
     */
    public UnbindCoolAppToSheetResponse unbindCoolAppToSheet(String workbookId, UnbindCoolAppToSheetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UnbindCoolAppToSheetHeaders headers = new UnbindCoolAppToSheetHeaders();
        return this.unbindCoolAppToSheetWithOptions(workbookId, request, headers, runtime);
    }

    /**
     * @summary 更新单元格区域
     *
     * @param request UpdateRangeRequest
     * @param headers UpdateRangeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateRangeResponse
     */
    public UpdateRangeResponse updateRangeWithOptions(String workbookId, String sheetId, String rangeAddress, UpdateRangeRequest request, UpdateRangeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.backgroundColors)) {
            body.put("backgroundColors", request.backgroundColors);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fontSizes)) {
            body.put("fontSizes", request.fontSizes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fontWeights)) {
            body.put("fontWeights", request.fontWeights);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.horizontalAlignments)) {
            body.put("horizontalAlignments", request.horizontalAlignments);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hyperlinks)) {
            body.put("hyperlinks", request.hyperlinks);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.numberFormat)) {
            body.put("numberFormat", request.numberFormat);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.values)) {
            body.put("values", request.values);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.verticalAlignments)) {
            body.put("verticalAlignments", request.verticalAlignments);
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
            new TeaPair("action", "UpdateRange"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateRangeResponse());
    }

    /**
     * @summary 更新单元格区域
     *
     * @param request UpdateRangeRequest
     * @return UpdateRangeResponse
     */
    public UpdateRangeResponse updateRange(String workbookId, String sheetId, String rangeAddress, UpdateRangeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateRangeHeaders headers = new UpdateRangeHeaders();
        return this.updateRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
    }

    /**
     * @summary 更新工作表
     *
     * @param request UpdateSheetRequest
     * @param headers UpdateSheetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateSheetResponse
     */
    public UpdateSheetResponse updateSheetWithOptions(String workbookId, String sheetId, UpdateSheetRequest request, UpdateSheetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.visibility)) {
            body.put("visibility", request.visibility);
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
            new TeaPair("action", "UpdateSheet"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateSheetResponse());
    }

    /**
     * @summary 更新工作表
     *
     * @param request UpdateSheetRequest
     * @return UpdateSheetResponse
     */
    public UpdateSheetResponse updateSheet(String workbookId, String sheetId, UpdateSheetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateSheetHeaders headers = new UpdateSheetHeaders();
        return this.updateSheetWithOptions(workbookId, sheetId, request, headers, runtime);
    }

    /**
     * @summary 修改知识库文档成员
     *
     * @param request UpdateWorkspaceDocMembersRequest
     * @param headers UpdateWorkspaceDocMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateWorkspaceDocMembersResponse
     */
    public UpdateWorkspaceDocMembersResponse updateWorkspaceDocMembersWithOptions(String workspaceId, String nodeId, UpdateWorkspaceDocMembersRequest request, UpdateWorkspaceDocMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
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
            new TeaPair("action", "UpdateWorkspaceDocMembers"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateWorkspaceDocMembersResponse());
    }

    /**
     * @summary 修改知识库文档成员
     *
     * @param request UpdateWorkspaceDocMembersRequest
     * @return UpdateWorkspaceDocMembersResponse
     */
    public UpdateWorkspaceDocMembersResponse updateWorkspaceDocMembers(String workspaceId, String nodeId, UpdateWorkspaceDocMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateWorkspaceDocMembersHeaders headers = new UpdateWorkspaceDocMembersHeaders();
        return this.updateWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
    }

    /**
     * @summary 更新知识库成员
     *
     * @param request UpdateWorkspaceMembersRequest
     * @param headers UpdateWorkspaceMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateWorkspaceMembersResponse
     */
    public UpdateWorkspaceMembersResponse updateWorkspaceMembersWithOptions(String workspaceId, UpdateWorkspaceMembersRequest request, UpdateWorkspaceMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
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
            new TeaPair("action", "UpdateWorkspaceMembers"),
            new TeaPair("version", "doc_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/doc/workspaces/" + workspaceId + "/members"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateWorkspaceMembersResponse());
    }

    /**
     * @summary 更新知识库成员
     *
     * @param request UpdateWorkspaceMembersRequest
     * @return UpdateWorkspaceMembersResponse
     */
    public UpdateWorkspaceMembersResponse updateWorkspaceMembers(String workspaceId, UpdateWorkspaceMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateWorkspaceMembersHeaders headers = new UpdateWorkspaceMembersHeaders();
        return this.updateWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
    }
}
