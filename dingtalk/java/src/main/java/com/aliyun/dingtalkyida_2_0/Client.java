// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkyida_2_0.models.*;

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
     * <p>批量新增/更新角色成员</p>
     * 
     * @param request BatchAddOrUpdateRoleMembersRequest
     * @param headers BatchAddOrUpdateRoleMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchAddOrUpdateRoleMembersResponse
     */
    public BatchAddOrUpdateRoleMembersResponse batchAddOrUpdateRoleMembersWithOptions(BatchAddOrUpdateRoleMembersRequest request, BatchAddOrUpdateRoleMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.membersInfo)) {
            body.put("membersInfo", request.membersInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleUuid)) {
            body.put("roleUuid", request.roleUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            body.put("token", request.token);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "BatchAddOrUpdateRoleMembers"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/resources/roles/upsert"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchAddOrUpdateRoleMembersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量新增/更新角色成员</p>
     * 
     * @param request BatchAddOrUpdateRoleMembersRequest
     * @return BatchAddOrUpdateRoleMembersResponse
     */
    public BatchAddOrUpdateRoleMembersResponse batchAddOrUpdateRoleMembers(BatchAddOrUpdateRoleMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchAddOrUpdateRoleMembersHeaders headers = new BatchAddOrUpdateRoleMembersHeaders();
        return this.batchAddOrUpdateRoleMembersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量删除角色成员</p>
     * 
     * @param request BatchDeleteRoleMembersRequest
     * @param headers BatchDeleteRoleMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchDeleteRoleMembersResponse
     */
    public BatchDeleteRoleMembersResponse batchDeleteRoleMembersWithOptions(BatchDeleteRoleMembersRequest request, BatchDeleteRoleMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberIds)) {
            body.put("memberIds", request.memberIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleUuid)) {
            body.put("roleUuid", request.roleUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            body.put("token", request.token);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "BatchDeleteRoleMembers"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/resources/roles/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchDeleteRoleMembersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量删除角色成员</p>
     * 
     * @param request BatchDeleteRoleMembersRequest
     * @return BatchDeleteRoleMembersResponse
     */
    public BatchDeleteRoleMembersResponse batchDeleteRoleMembers(BatchDeleteRoleMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchDeleteRoleMembersHeaders headers = new BatchDeleteRoleMembersHeaders();
        return this.batchDeleteRoleMembersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增或更新表单实例</p>
     * 
     * @param request CreateOrUpdateFormDataRequest
     * @param headers CreateOrUpdateFormDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateOrUpdateFormDataResponse
     */
    public CreateOrUpdateFormDataResponse createOrUpdateFormDataWithOptions(CreateOrUpdateFormDataRequest request, CreateOrUpdateFormDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formDataJson)) {
            body.put("formDataJson", request.formDataJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.noExecuteExpression)) {
            body.put("noExecuteExpression", request.noExecuteExpression);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchCondition)) {
            body.put("searchCondition", request.searchCondition);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useAlias)) {
            body.put("useAlias", request.useAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "CreateOrUpdateFormData"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/instances/insertOrUpdate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateOrUpdateFormDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增或更新表单实例</p>
     * 
     * @param request CreateOrUpdateFormDataRequest
     * @return CreateOrUpdateFormDataResponse
     */
    public CreateOrUpdateFormDataResponse createOrUpdateFormData(CreateOrUpdateFormDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateOrUpdateFormDataHeaders headers = new CreateOrUpdateFormDataHeaders();
        return this.createOrUpdateFormDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量删除矩阵明细数据</p>
     * 
     * @param request DeleteMatrixDataByRowIdsRequest
     * @param headers DeleteMatrixDataByRowIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteMatrixDataByRowIdsResponse
     */
    public DeleteMatrixDataByRowIdsResponse deleteMatrixDataByRowIdsWithOptions(DeleteMatrixDataByRowIdsRequest request, DeleteMatrixDataByRowIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.matrixId)) {
            body.put("matrixId", request.matrixId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rowIds)) {
            body.put("rowIds", request.rowIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            body.put("token", request.token);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "DeleteMatrixDataByRowIds"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/resources/matrices/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteMatrixDataByRowIdsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量删除矩阵明细数据</p>
     * 
     * @param request DeleteMatrixDataByRowIdsRequest
     * @return DeleteMatrixDataByRowIdsResponse
     */
    public DeleteMatrixDataByRowIdsResponse deleteMatrixDataByRowIds(DeleteMatrixDataByRowIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteMatrixDataByRowIdsHeaders headers = new DeleteMatrixDataByRowIdsHeaders();
        return this.deleteMatrixDataByRowIdsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取表单组件别名列表</p>
     * 
     * @param request GetFormComponentAliasListRequest
     * @param headers GetFormComponentAliasListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFormComponentAliasListResponse
     */
    public GetFormComponentAliasListResponse getFormComponentAliasListWithOptions(String appType, String formUuid, GetFormComponentAliasListRequest request, GetFormComponentAliasListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            query.put("version", request.version);
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
            new TeaPair("action", "GetFormComponentAliasList"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/component/alias/" + appType + "/" + formUuid + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFormComponentAliasListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取表单组件别名列表</p>
     * 
     * @param request GetFormComponentAliasListRequest
     * @return GetFormComponentAliasListResponse
     */
    public GetFormComponentAliasListResponse getFormComponentAliasList(String appType, String formUuid, GetFormComponentAliasListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFormComponentAliasListHeaders headers = new GetFormComponentAliasListHeaders();
        return this.getFormComponentAliasListWithOptions(appType, formUuid, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据表单 ID 查询实例详情</p>
     * 
     * @param request GetFormDataByIDRequest
     * @param headers GetFormDataByIDHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFormDataByIDResponse
     */
    public GetFormDataByIDResponse getFormDataByIDWithOptions(String id, GetFormDataByIDRequest request, GetFormDataByIDHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            query.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useAlias)) {
            query.put("useAlias", request.useAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "GetFormDataByID"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/instances/" + id + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFormDataByIDResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据表单 ID 查询实例详情</p>
     * 
     * @param request GetFormDataByIDRequest
     * @return GetFormDataByIDResponse
     */
    public GetFormDataByIDResponse getFormDataByID(String id, GetFormDataByIDRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFormDataByIDHeaders headers = new GetFormDataByIDHeaders();
        return this.getFormDataByIDWithOptions(id, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据实例 ID 获取流程实例详情</p>
     * 
     * @param request GetInstanceByIdRequest
     * @param headers GetInstanceByIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetInstanceByIdResponse
     */
    public GetInstanceByIdResponse getInstanceByIdWithOptions(String id, GetInstanceByIdRequest request, GetInstanceByIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            query.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useAlias)) {
            query.put("useAlias", request.useAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "GetInstanceById"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/processes/instancesInfos/" + id + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetInstanceByIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据实例 ID 获取流程实例详情</p>
     * 
     * @param request GetInstanceByIdRequest
     * @return GetInstanceByIdResponse
     */
    public GetInstanceByIdResponse getInstanceById(String id, GetInstanceByIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInstanceByIdHeaders headers = new GetInstanceByIdHeaders();
        return this.getInstanceByIdWithOptions(id, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据条件搜索流程实例 ID</p>
     * 
     * @param request GetInstanceIdListRequest
     * @param headers GetInstanceIdListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetInstanceIdListResponse
     */
    public GetInstanceIdListResponse getInstanceIdListWithOptions(GetInstanceIdListRequest request, GetInstanceIdListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.approvedResult)) {
            body.put("approvedResult", request.approvedResult);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createFromTimeGMT)) {
            body.put("createFromTimeGMT", request.createFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createToTimeGMT)) {
            body.put("createToTimeGMT", request.createToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceStatus)) {
            body.put("instanceStatus", request.instanceStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifiedFromTimeGMT)) {
            body.put("modifiedFromTimeGMT", request.modifiedFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifiedToTimeGMT)) {
            body.put("modifiedToTimeGMT", request.modifiedToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.originatorId)) {
            body.put("originatorId", request.originatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchFieldJson)) {
            body.put("searchFieldJson", request.searchFieldJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useAlias)) {
            body.put("useAlias", request.useAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "GetInstanceIdList"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/processes/instanceIds"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetInstanceIdListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据条件搜索流程实例 ID</p>
     * 
     * @param request GetInstanceIdListRequest
     * @return GetInstanceIdListResponse
     */
    public GetInstanceIdListResponse getInstanceIdList(GetInstanceIdListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInstanceIdListHeaders headers = new GetInstanceIdListHeaders();
        return this.getInstanceIdListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据搜索条件获取流程表单实例详情</p>
     * 
     * @param request GetInstancesRequest
     * @param headers GetInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetInstancesResponse
     */
    public GetInstancesResponse getInstancesWithOptions(GetInstancesRequest request, GetInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.approvedResult)) {
            body.put("approvedResult", request.approvedResult);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createFromTimeGMT)) {
            body.put("createFromTimeGMT", request.createFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createToTimeGMT)) {
            body.put("createToTimeGMT", request.createToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceStatus)) {
            body.put("instanceStatus", request.instanceStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifiedFromTimeGMT)) {
            body.put("modifiedFromTimeGMT", request.modifiedFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifiedToTimeGMT)) {
            body.put("modifiedToTimeGMT", request.modifiedToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderConfigJson)) {
            body.put("orderConfigJson", request.orderConfigJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.originatorId)) {
            body.put("originatorId", request.originatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchFieldJson)) {
            body.put("searchFieldJson", request.searchFieldJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useAlias)) {
            body.put("useAlias", request.useAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "GetInstances"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/processes/instances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据搜索条件获取流程表单实例详情</p>
     * 
     * @param request GetInstancesRequest
     * @return GetInstancesResponse
     */
    public GetInstancesResponse getInstances(GetInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInstancesHeaders headers = new GetInstancesHeaders();
        return this.getInstancesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取权限矩阵数据详情</p>
     * 
     * @param request GetMatrixDetailByIdRequest
     * @param headers GetMatrixDetailByIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMatrixDetailByIdResponse
     */
    public GetMatrixDetailByIdResponse getMatrixDetailByIdWithOptions(GetMatrixDetailByIdRequest request, GetMatrixDetailByIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.matrixId)) {
            query.put("matrixId", request.matrixId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            query.put("token", request.token);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "GetMatrixDetailById"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/resources/matrices"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMatrixDetailByIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取权限矩阵数据详情</p>
     * 
     * @param request GetMatrixDetailByIdRequest
     * @return GetMatrixDetailByIdResponse
     */
    public GetMatrixDetailByIdResponse getMatrixDetailById(GetMatrixDetailByIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMatrixDetailByIdHeaders headers = new GetMatrixDetailByIdHeaders();
        return this.getMatrixDetailByIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取角色详情和成员列表</p>
     * 
     * @param request GetRoleDetailByIdRequest
     * @param headers GetRoleDetailByIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRoleDetailByIdResponse
     */
    public GetRoleDetailByIdResponse getRoleDetailByIdWithOptions(GetRoleDetailByIdRequest request, GetRoleDetailByIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleUuid)) {
            query.put("roleUuid", request.roleUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            query.put("token", request.token);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "GetRoleDetailById"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/resources/roles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRoleDetailByIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取角色详情和成员列表</p>
     * 
     * @param request GetRoleDetailByIdRequest
     * @return GetRoleDetailByIdResponse
     */
    public GetRoleDetailByIdResponse getRoleDetailById(GetRoleDetailByIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRoleDetailByIdHeaders headers = new GetRoleDetailByIdHeaders();
        return this.getRoleDetailByIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改/新增矩阵明细数据</p>
     * 
     * @param request SaveAndUpdateMatrixDataRequest
     * @param headers SaveAndUpdateMatrixDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveAndUpdateMatrixDataResponse
     */
    public SaveAndUpdateMatrixDataResponse saveAndUpdateMatrixDataWithOptions(SaveAndUpdateMatrixDataRequest request, SaveAndUpdateMatrixDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dataJson)) {
            body.put("dataJson", request.dataJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.matrixId)) {
            body.put("matrixId", request.matrixId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            body.put("token", request.token);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SaveAndUpdateMatrixData"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/resources/matrices/upsert"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveAndUpdateMatrixDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改/新增矩阵明细数据</p>
     * 
     * @param request SaveAndUpdateMatrixDataRequest
     * @return SaveAndUpdateMatrixDataResponse
     */
    public SaveAndUpdateMatrixDataResponse saveAndUpdateMatrixData(SaveAndUpdateMatrixDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveAndUpdateMatrixDataHeaders headers = new SaveAndUpdateMatrixDataHeaders();
        return this.saveAndUpdateMatrixDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增表单实例</p>
     * 
     * @param request SaveFormDataRequest
     * @param headers SaveFormDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveFormDataResponse
     */
    public SaveFormDataResponse saveFormDataWithOptions(SaveFormDataRequest request, SaveFormDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formDataJson)) {
            body.put("formDataJson", request.formDataJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useAlias)) {
            body.put("useAlias", request.useAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SaveFormData"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/instances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveFormDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增表单实例</p>
     * 
     * @param request SaveFormDataRequest
     * @return SaveFormDataResponse
     */
    public SaveFormDataResponse saveFormData(SaveFormDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveFormDataHeaders headers = new SaveFormDataHeaders();
        return this.saveFormDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据条件搜索表单实例 ID 列表</p>
     * 
     * @param request SearchFormDataIdListRequest
     * @param headers SearchFormDataIdListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchFormDataIdListResponse
     */
    public SearchFormDataIdListResponse searchFormDataIdListWithOptions(String appType, String formUuid, SearchFormDataIdListRequest request, SearchFormDataIdListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.createFromTimeGMT)) {
            body.put("createFromTimeGMT", request.createFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createToTimeGMT)) {
            body.put("createToTimeGMT", request.createToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifiedFromTimeGMT)) {
            body.put("modifiedFromTimeGMT", request.modifiedFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifiedToTimeGMT)) {
            body.put("modifiedToTimeGMT", request.modifiedToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.originatorId)) {
            body.put("originatorId", request.originatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchFieldJson)) {
            body.put("searchFieldJson", request.searchFieldJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useAlias)) {
            body.put("useAlias", request.useAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SearchFormDataIdList"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/instances/ids/" + appType + "/" + formUuid + ""),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchFormDataIdListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据条件搜索表单实例 ID 列表</p>
     * 
     * @param request SearchFormDataIdListRequest
     * @return SearchFormDataIdListResponse
     */
    public SearchFormDataIdListResponse searchFormDataIdList(String appType, String formUuid, SearchFormDataIdListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchFormDataIdListHeaders headers = new SearchFormDataIdListHeaders();
        return this.searchFormDataIdListWithOptions(appType, formUuid, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通过高级检索条件查询表单实例</p>
     * 
     * @param request SearchFormDataSecondGenerationRequest
     * @param headers SearchFormDataSecondGenerationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchFormDataSecondGenerationResponse
     */
    public SearchFormDataSecondGenerationResponse searchFormDataSecondGenerationWithOptions(SearchFormDataSecondGenerationRequest request, SearchFormDataSecondGenerationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createFromTimeGMT)) {
            body.put("createFromTimeGMT", request.createFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createToTimeGMT)) {
            body.put("createToTimeGMT", request.createToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifiedFromTimeGMT)) {
            body.put("modifiedFromTimeGMT", request.modifiedFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifiedToTimeGMT)) {
            body.put("modifiedToTimeGMT", request.modifiedToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderConfigJson)) {
            body.put("orderConfigJson", request.orderConfigJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.originatorId)) {
            body.put("originatorId", request.originatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchCondition)) {
            body.put("searchCondition", request.searchCondition);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useAlias)) {
            body.put("useAlias", request.useAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SearchFormDataSecondGeneration"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/instances/advances/queryAll"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchFormDataSecondGenerationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通过高级检索条件查询表单实例</p>
     * 
     * @param request SearchFormDataSecondGenerationRequest
     * @return SearchFormDataSecondGenerationResponse
     */
    public SearchFormDataSecondGenerationResponse searchFormDataSecondGeneration(SearchFormDataSecondGenerationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchFormDataSecondGenerationHeaders headers = new SearchFormDataSecondGenerationHeaders();
        return this.searchFormDataSecondGenerationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据条件搜索表单实例详情列表</p>
     * 
     * @param request SearchFormDatasRequest
     * @param headers SearchFormDatasHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchFormDatasResponse
     */
    public SearchFormDatasResponse searchFormDatasWithOptions(SearchFormDatasRequest request, SearchFormDatasHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createFromTimeGMT)) {
            body.put("createFromTimeGMT", request.createFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createToTimeGMT)) {
            body.put("createToTimeGMT", request.createToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.currentPage)) {
            body.put("currentPage", request.currentPage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dynamicOrder)) {
            body.put("dynamicOrder", request.dynamicOrder);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifiedFromTimeGMT)) {
            body.put("modifiedFromTimeGMT", request.modifiedFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifiedToTimeGMT)) {
            body.put("modifiedToTimeGMT", request.modifiedToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.originatorId)) {
            body.put("originatorId", request.originatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchFieldJson)) {
            body.put("searchFieldJson", request.searchFieldJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useAlias)) {
            body.put("useAlias", request.useAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SearchFormDatas"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/instances/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchFormDatasResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据条件搜索表单实例详情列表</p>
     * 
     * @param request SearchFormDatasRequest
     * @return SearchFormDatasResponse
     */
    public SearchFormDatasResponse searchFormDatas(SearchFormDatasRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchFormDatasHeaders headers = new SearchFormDatasHeaders();
        return this.searchFormDatasWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发起新的流程实例</p>
     * 
     * @param request StartInstanceRequest
     * @param headers StartInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StartInstanceResponse
     */
    public StartInstanceResponse startInstanceWithOptions(StartInstanceRequest request, StartInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            body.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formDataJson)) {
            body.put("formDataJson", request.formDataJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            body.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processData)) {
            body.put("processData", request.processData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useAlias)) {
            body.put("useAlias", request.useAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "StartInstance"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/processes/instances/start"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StartInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发起新的流程实例</p>
     * 
     * @param request StartInstanceRequest
     * @return StartInstanceResponse
     */
    public StartInstanceResponse startInstance(StartInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StartInstanceHeaders headers = new StartInstanceHeaders();
        return this.startInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新表单实例</p>
     * 
     * @param request UpdateFormDataRequest
     * @param headers UpdateFormDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateFormDataResponse
     */
    public UpdateFormDataResponse updateFormDataWithOptions(UpdateFormDataRequest request, UpdateFormDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formInstanceId)) {
            body.put("formInstanceId", request.formInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.updateFormDataJson)) {
            body.put("updateFormDataJson", request.updateFormDataJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useAlias)) {
            body.put("useAlias", request.useAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useLatestVersion)) {
            body.put("useLatestVersion", request.useLatestVersion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "UpdateFormData"),
            new TeaPair("version", "yida_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/yida/forms/instances"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateFormDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新表单实例</p>
     * 
     * @param request UpdateFormDataRequest
     * @return UpdateFormDataResponse
     */
    public UpdateFormDataResponse updateFormData(UpdateFormDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateFormDataHeaders headers = new UpdateFormDataHeaders();
        return this.updateFormDataWithOptions(request, headers, runtime);
    }
}
