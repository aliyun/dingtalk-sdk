// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkokr_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._productId = "dingtalk";
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>增加对齐目标</p>
     * 
     * @param request AlignObjectiveRequest
     * @param headers AlignObjectiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AlignObjectiveResponse
     */
    public AlignObjectiveResponse alignObjectiveWithOptions(String objectiveId, AlignObjectiveRequest request, AlignObjectiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.periodId)) {
            body.put("periodId", request.periodId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetId)) {
            body.put("targetId", request.targetId);
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
            new TeaPair("action", "AlignObjective"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/objectives/" + objectiveId + "/alignments"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AlignObjectiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>增加对齐目标</p>
     * 
     * @param request AlignObjectiveRequest
     * @return AlignObjectiveResponse
     */
    public AlignObjectiveResponse alignObjective(String objectiveId, AlignObjectiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AlignObjectiveHeaders headers = new AlignObjectiveHeaders();
        return this.alignObjectiveWithOptions(objectiveId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量添加权限信息</p>
     * 
     * @param request BatchAddPermissionRequest
     * @param headers BatchAddPermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchAddPermissionResponse
     */
    public BatchAddPermissionResponse batchAddPermissionWithOptions(BatchAddPermissionRequest request, BatchAddPermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.list)) {
            body.put("list", request.list);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetId)) {
            body.put("targetId", request.targetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetType)) {
            body.put("targetType", request.targetType);
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
            new TeaPair("action", "BatchAddPermission"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/permissions/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchAddPermissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量添加权限信息</p>
     * 
     * @param request BatchAddPermissionRequest
     * @return BatchAddPermissionResponse
     */
    public BatchAddPermissionResponse batchAddPermission(BatchAddPermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchAddPermissionHeaders headers = new BatchAddPermissionHeaders();
        return this.batchAddPermissionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询目标</p>
     * 
     * @param request BatchQueryObjectiveRequest
     * @param headers BatchQueryObjectiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchQueryObjectiveResponse
     */
    public BatchQueryObjectiveResponse batchQueryObjectiveWithOptions(BatchQueryObjectiveRequest request, BatchQueryObjectiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.objectiveIds)) {
            body.put("objectiveIds", request.objectiveIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodId)) {
            body.put("periodId", request.periodId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withAlign)) {
            body.put("withAlign", request.withAlign);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withKr)) {
            body.put("withKr", request.withKr);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withProgress)) {
            body.put("withProgress", request.withProgress);
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
            new TeaPair("action", "BatchQueryObjective"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/objectives/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchQueryObjectiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询目标</p>
     * 
     * @param request BatchQueryObjectiveRequest
     * @return BatchQueryObjectiveResponse
     */
    public BatchQueryObjectiveResponse batchQueryObjective(BatchQueryObjectiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQueryObjectiveHeaders headers = new BatchQueryObjectiveHeaders();
        return this.batchQueryObjectiveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询用户信息</p>
     * 
     * @param request BatchQueryUserRequest
     * @param headers BatchQueryUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchQueryUserResponse
     */
    public BatchQueryUserResponse batchQueryUserWithOptions(BatchQueryUserRequest request, BatchQueryUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.okrUserIds)) {
            body.put("okrUserIds", request.okrUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
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
            new TeaPair("action", "BatchQueryUser"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/users/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchQueryUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询用户信息</p>
     * 
     * @param request BatchQueryUserRequest
     * @return BatchQueryUserResponse
     */
    public BatchQueryUserResponse batchQueryUser(BatchQueryUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQueryUserHeaders headers = new BatchQueryUserHeaders();
        return this.batchQueryUserWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建keyResult</p>
     * 
     * @param request CreateKeyResultRequest
     * @param headers CreateKeyResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateKeyResultResponse
     */
    public CreateKeyResultResponse createKeyResultWithOptions(CreateKeyResultRequest request, CreateKeyResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectiveId)) {
            body.put("objectiveId", request.objectiveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodId)) {
            body.put("periodId", request.periodId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.prevPosition)) {
            body.put("prevPosition", request.prevPosition);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.weight)) {
            body.put("weight", request.weight);
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
            new TeaPair("action", "CreateKeyResult"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/keyResults"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateKeyResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建keyResult</p>
     * 
     * @param request CreateKeyResultRequest
     * @return CreateKeyResultResponse
     */
    public CreateKeyResultResponse createKeyResult(CreateKeyResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateKeyResultHeaders headers = new CreateKeyResultHeaders();
        return this.createKeyResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建目标</p>
     * 
     * @param request CreateObjectiveRequest
     * @param headers CreateObjectiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateObjectiveResponse
     */
    public CreateObjectiveResponse createObjectiveWithOptions(CreateObjectiveRequest request, CreateObjectiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodId)) {
            body.put("periodId", request.periodId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.prevPosition)) {
            body.put("prevPosition", request.prevPosition);
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
            new TeaPair("action", "CreateObjective"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/objectives"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateObjectiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建目标</p>
     * 
     * @param request CreateObjectiveRequest
     * @return CreateObjectiveResponse
     */
    public CreateObjectiveResponse createObjective(CreateObjectiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateObjectiveHeaders headers = new CreateObjectiveHeaders();
        return this.createObjectiveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除keyresult的方法</p>
     * 
     * @param request DeleteKeyResultRequest
     * @param headers DeleteKeyResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteKeyResultResponse
     */
    public DeleteKeyResultResponse deleteKeyResultWithOptions(DeleteKeyResultRequest request, DeleteKeyResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.krId)) {
            query.put("krId", request.krId);
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
            new TeaPair("action", "DeleteKeyResult"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/keyResults"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteKeyResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除keyresult的方法</p>
     * 
     * @param request DeleteKeyResultRequest
     * @return DeleteKeyResultResponse
     */
    public DeleteKeyResultResponse deleteKeyResult(DeleteKeyResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteKeyResultHeaders headers = new DeleteKeyResultHeaders();
        return this.deleteKeyResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除目标</p>
     * 
     * @param request DeleteObjectiveRequest
     * @param headers DeleteObjectiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteObjectiveResponse
     */
    public DeleteObjectiveResponse deleteObjectiveWithOptions(String objectiveId, DeleteObjectiveRequest request, DeleteObjectiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "DeleteObjective"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/objectives/" + objectiveId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteObjectiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除目标</p>
     * 
     * @param request DeleteObjectiveRequest
     * @return DeleteObjectiveResponse
     */
    public DeleteObjectiveResponse deleteObjective(String objectiveId, DeleteObjectiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteObjectiveHeaders headers = new DeleteObjectiveHeaders();
        return this.deleteObjectiveWithOptions(objectiveId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除权限信息</p>
     * 
     * @param request DeletePermissionRequest
     * @param headers DeletePermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeletePermissionResponse
     */
    public DeletePermissionResponse deletePermissionWithOptions(DeletePermissionRequest request, DeletePermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            query.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.policyType)) {
            query.put("policyType", request.policyType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetId)) {
            query.put("targetId", request.targetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetType)) {
            query.put("targetType", request.targetType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
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
            new TeaPair("action", "DeletePermission"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/permissions/delete"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeletePermissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除权限信息</p>
     * 
     * @param request DeletePermissionRequest
     * @return DeletePermissionResponse
     */
    public DeletePermissionResponse deletePermission(DeletePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeletePermissionHeaders headers = new DeletePermissionHeaders();
        return this.deletePermissionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取周期列表</p>
     * 
     * @param headers GetPeriodListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPeriodListResponse
     */
    public GetPeriodListResponse getPeriodListWithOptions(GetPeriodListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetPeriodList"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/periods"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPeriodListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取周期列表</p>
     * @return GetPeriodListResponse
     */
    public GetPeriodListResponse getPeriodList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPeriodListHeaders headers = new GetPeriodListHeaders();
        return this.getPeriodListWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取权限信息</p>
     * 
     * @param request GetPermissionRequest
     * @param headers GetPermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPermissionResponse
     */
    public GetPermissionResponse getPermissionWithOptions(GetPermissionRequest request, GetPermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.targetId)) {
            query.put("targetId", request.targetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetType)) {
            query.put("targetType", request.targetType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withKr)) {
            query.put("withKr", request.withKr);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withObjective)) {
            query.put("withObjective", request.withObjective);
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
            new TeaPair("action", "GetPermission"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/permissions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPermissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取权限信息</p>
     * 
     * @param request GetPermissionRequest
     * @return GetPermissionResponse
     */
    public GetPermissionResponse getPermission(GetPermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPermissionHeaders headers = new GetPermissionHeaders();
        return this.getPermissionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户当前周期下的全部 OKR 内容</p>
     * 
     * @param request GetUserOkrRequest
     * @param headers GetUserOkrHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserOkrResponse
     */
    public GetUserOkrResponse getUserOkrWithOptions(GetUserOkrRequest request, GetUserOkrHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodId)) {
            query.put("periodId", request.periodId);
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
            new TeaPair("action", "GetUserOkr"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/users/okrs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserOkrResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户当前周期下的全部 OKR 内容</p>
     * 
     * @param request GetUserOkrRequest
     * @return GetUserOkrResponse
     */
    public GetUserOkrResponse getUserOkr(GetUserOkrRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserOkrHeaders headers = new GetUserOkrHeaders();
        return this.getUserOkrWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询OKR</p>
     * 
     * @param request OkrObjectivesBatchRequest
     * @param headers OkrObjectivesBatchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OkrObjectivesBatchResponse
     */
    public OkrObjectivesBatchResponse okrObjectivesBatchWithOptions(OkrObjectivesBatchRequest request, OkrObjectivesBatchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.goodsCode)) {
            body.put("goodsCode", request.goodsCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectiveIds)) {
            body.put("objectiveIds", request.objectiveIds);
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
            new TeaPair("action", "OkrObjectivesBatch"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/pro/objectives/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OkrObjectivesBatchResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询OKR</p>
     * 
     * @param request OkrObjectivesBatchRequest
     * @return OkrObjectivesBatchResponse
     */
    public OkrObjectivesBatchResponse okrObjectivesBatch(OkrObjectivesBatchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OkrObjectivesBatchHeaders headers = new OkrObjectivesBatchHeaders();
        return this.okrObjectivesBatchWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询单个用户的OKR</p>
     * 
     * @param request OkrObjectivesByUserRequest
     * @param headers OkrObjectivesByUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OkrObjectivesByUserResponse
     */
    public OkrObjectivesByUserResponse okrObjectivesByUserWithOptions(String dingUserId, OkrObjectivesByUserRequest request, OkrObjectivesByUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.goodsCode)) {
            query.put("goodsCode", request.goodsCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
            new TeaPair("action", "OkrObjectivesByUser"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/pro/users/" + dingUserId + "/objectives"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OkrObjectivesByUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询单个用户的OKR</p>
     * 
     * @param request OkrObjectivesByUserRequest
     * @return OkrObjectivesByUserResponse
     */
    public OkrObjectivesByUserResponse okrObjectivesByUser(String dingUserId, OkrObjectivesByUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OkrObjectivesByUserHeaders headers = new OkrObjectivesByUserHeaders();
        return this.okrObjectivesByUserWithOptions(dingUserId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取 OKR 周期</p>
     * 
     * @param request OkrPeriodsRequest
     * @param headers OkrPeriodsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OkrPeriodsResponse
     */
    public OkrPeriodsResponse okrPeriodsWithOptions(OkrPeriodsRequest request, OkrPeriodsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.goodsCode)) {
            query.put("goodsCode", request.goodsCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            query.put("status", request.status);
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
            new TeaPair("action", "OkrPeriods"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/pro/periods"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OkrPeriodsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取 OKR 周期</p>
     * 
     * @param request OkrPeriodsRequest
     * @return OkrPeriodsResponse
     */
    public OkrPeriodsResponse okrPeriods(OkrPeriodsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OkrPeriodsHeaders headers = new OkrPeriodsHeaders();
        return this.okrPeriodsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>取消对齐Objective</p>
     * 
     * @param request UnAlignObjectiveRequest
     * @param headers UnAlignObjectiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UnAlignObjectiveResponse
     */
    public UnAlignObjectiveResponse unAlignObjectiveWithOptions(String objectiveId, UnAlignObjectiveRequest request, UnAlignObjectiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.periodId)) {
            body.put("periodId", request.periodId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetId)) {
            body.put("targetId", request.targetId);
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
            new TeaPair("action", "UnAlignObjective"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/objectives/" + objectiveId + "/alignments/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UnAlignObjectiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>取消对齐Objective</p>
     * 
     * @param request UnAlignObjectiveRequest
     * @return UnAlignObjectiveResponse
     */
    public UnAlignObjectiveResponse unAlignObjective(String objectiveId, UnAlignObjectiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UnAlignObjectiveHeaders headers = new UnAlignObjectiveHeaders();
        return this.unAlignObjectiveWithOptions(objectiveId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更改KR内容</p>
     * 
     * @param request UpdateKROfContentRequest
     * @param headers UpdateKROfContentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateKROfContentResponse
     */
    public UpdateKROfContentResponse updateKROfContentWithOptions(UpdateKROfContentRequest request, UpdateKROfContentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.krId)) {
            query.put("krId", request.krId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.updateQuoteList)) {
            body.put("updateQuoteList", request.updateQuoteList);
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
            new TeaPair("action", "UpdateKROfContent"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/keyResults/contents"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateKROfContentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更改KR内容</p>
     * 
     * @param request UpdateKROfContentRequest
     * @return UpdateKROfContentResponse
     */
    public UpdateKROfContentResponse updateKROfContent(UpdateKROfContentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateKROfContentHeaders headers = new UpdateKROfContentHeaders();
        return this.updateKROfContentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更改KR分数</p>
     * 
     * @param request UpdateKROfScoreRequest
     * @param headers UpdateKROfScoreHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateKROfScoreResponse
     */
    public UpdateKROfScoreResponse updateKROfScoreWithOptions(UpdateKROfScoreRequest request, UpdateKROfScoreHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.krId)) {
            query.put("krId", request.krId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.score)) {
            body.put("score", request.score);
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
            new TeaPair("action", "UpdateKROfScore"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/keyResults/scores"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateKROfScoreResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更改KR分数</p>
     * 
     * @param request UpdateKROfScoreRequest
     * @return UpdateKROfScoreResponse
     */
    public UpdateKROfScoreResponse updateKROfScore(UpdateKROfScoreRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateKROfScoreHeaders headers = new UpdateKROfScoreHeaders();
        return this.updateKROfScoreWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更改 KR 权重</p>
     * 
     * @param request UpdateKROfWeightRequest
     * @param headers UpdateKROfWeightHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateKROfWeightResponse
     */
    public UpdateKROfWeightResponse updateKROfWeightWithOptions(UpdateKROfWeightRequest request, UpdateKROfWeightHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.krId)) {
            query.put("krId", request.krId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.weight)) {
            body.put("weight", request.weight);
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
            new TeaPair("action", "UpdateKROfWeight"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/keyResults/weights"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateKROfWeightResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更改 KR 权重</p>
     * 
     * @param request UpdateKROfWeightRequest
     * @return UpdateKROfWeightResponse
     */
    public UpdateKROfWeightResponse updateKROfWeight(UpdateKROfWeightRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateKROfWeightHeaders headers = new UpdateKROfWeightHeaders();
        return this.updateKROfWeightWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新目标</p>
     * 
     * @param request UpdateObjectiveRequest
     * @param headers UpdateObjectiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateObjectiveResponse
     */
    public UpdateObjectiveResponse updateObjectiveWithOptions(String objectiveId, UpdateObjectiveRequest request, UpdateObjectiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
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
            new TeaPair("action", "UpdateObjective"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/objectives/" + objectiveId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateObjectiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新目标</p>
     * 
     * @param request UpdateObjectiveRequest
     * @return UpdateObjectiveResponse
     */
    public UpdateObjectiveResponse updateObjective(String objectiveId, UpdateObjectiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateObjectiveHeaders headers = new UpdateObjectiveHeaders();
        return this.updateObjectiveWithOptions(objectiveId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新资源隐私策略</p>
     * 
     * @param request UpdatePrivacyRequest
     * @param headers UpdatePrivacyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdatePrivacyResponse
     */
    public UpdatePrivacyResponse updatePrivacyWithOptions(UpdatePrivacyRequest request, UpdatePrivacyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.privacy)) {
            body.put("privacy", request.privacy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetId)) {
            body.put("targetId", request.targetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetType)) {
            body.put("targetType", request.targetType);
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
            new TeaPair("action", "UpdatePrivacy"),
            new TeaPair("version", "okr_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/okr/permissions/privacies"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdatePrivacyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新资源隐私策略</p>
     * 
     * @param request UpdatePrivacyRequest
     * @return UpdatePrivacyResponse
     */
    public UpdatePrivacyResponse updatePrivacy(UpdatePrivacyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdatePrivacyHeaders headers = new UpdatePrivacyHeaders();
        return this.updatePrivacyWithOptions(request, headers, runtime);
    }
}
