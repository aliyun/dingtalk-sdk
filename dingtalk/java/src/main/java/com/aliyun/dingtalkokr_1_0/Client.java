// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkokr_1_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;
import com.aliyun.openapiutil.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public AlignObjectiveResponse alignObjective(String objectiveId, AlignObjectiveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AlignObjectiveHeaders headers = new AlignObjectiveHeaders();
        return this.alignObjectiveWithOptions(objectiveId, request, headers, runtime);
    }

    public AlignObjectiveResponse alignObjectiveWithOptions(String objectiveId, AlignObjectiveRequest request, AlignObjectiveHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        objectiveId = com.aliyun.openapiutil.Client.getEncodeParam(objectiveId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AlignObjective", "okr_1.0", "HTTP", "POST", "AK", "/v1.0/okr/objectives/" + objectiveId + "/alignments", "json", req, runtime), new AlignObjectiveResponse());
    }

    public BatchAddPermissionResponse batchAddPermission(BatchAddPermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchAddPermissionHeaders headers = new BatchAddPermissionHeaders();
        return this.batchAddPermissionWithOptions(request, headers, runtime);
    }

    public BatchAddPermissionResponse batchAddPermissionWithOptions(BatchAddPermissionRequest request, BatchAddPermissionHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchAddPermission", "okr_1.0", "HTTP", "POST", "AK", "/v1.0/okr/permissions/batch", "json", req, runtime), new BatchAddPermissionResponse());
    }

    public BatchQueryObjectiveResponse batchQueryObjective(BatchQueryObjectiveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchQueryObjectiveHeaders headers = new BatchQueryObjectiveHeaders();
        return this.batchQueryObjectiveWithOptions(request, headers, runtime);
    }

    public BatchQueryObjectiveResponse batchQueryObjectiveWithOptions(BatchQueryObjectiveRequest request, BatchQueryObjectiveHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchQueryObjective", "okr_1.0", "HTTP", "POST", "AK", "/v1.0/okr/objectives/query", "json", req, runtime), new BatchQueryObjectiveResponse());
    }

    public CreateKeyResultResponse createKeyResult(CreateKeyResultRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateKeyResultHeaders headers = new CreateKeyResultHeaders();
        return this.createKeyResultWithOptions(request, headers, runtime);
    }

    public CreateKeyResultResponse createKeyResultWithOptions(CreateKeyResultRequest request, CreateKeyResultHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateKeyResult", "okr_1.0", "HTTP", "POST", "AK", "/v1.0/okr/keyResults", "json", req, runtime), new CreateKeyResultResponse());
    }

    public CreateObjectiveResponse createObjective(CreateObjectiveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateObjectiveHeaders headers = new CreateObjectiveHeaders();
        return this.createObjectiveWithOptions(request, headers, runtime);
    }

    public CreateObjectiveResponse createObjectiveWithOptions(CreateObjectiveRequest request, CreateObjectiveHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateObjective", "okr_1.0", "HTTP", "POST", "AK", "/v1.0/okr/objectives", "json", req, runtime), new CreateObjectiveResponse());
    }

    public DeleteKeyResultResponse deleteKeyResult(DeleteKeyResultRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteKeyResultHeaders headers = new DeleteKeyResultHeaders();
        return this.deleteKeyResultWithOptions(request, headers, runtime);
    }

    public DeleteKeyResultResponse deleteKeyResultWithOptions(DeleteKeyResultRequest request, DeleteKeyResultHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteKeyResult", "okr_1.0", "HTTP", "DELETE", "AK", "/v1.0/okr/keyResults", "json", req, runtime), new DeleteKeyResultResponse());
    }

    public DeleteObjectiveResponse deleteObjective(String objectiveId, DeleteObjectiveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteObjectiveHeaders headers = new DeleteObjectiveHeaders();
        return this.deleteObjectiveWithOptions(objectiveId, request, headers, runtime);
    }

    public DeleteObjectiveResponse deleteObjectiveWithOptions(String objectiveId, DeleteObjectiveRequest request, DeleteObjectiveHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        objectiveId = com.aliyun.openapiutil.Client.getEncodeParam(objectiveId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteObjective", "okr_1.0", "HTTP", "DELETE", "AK", "/v1.0/okr/objectives/" + objectiveId + "", "json", req, runtime), new DeleteObjectiveResponse());
    }

    public DeletePermissionResponse deletePermission(DeletePermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeletePermissionHeaders headers = new DeletePermissionHeaders();
        return this.deletePermissionWithOptions(request, headers, runtime);
    }

    public DeletePermissionResponse deletePermissionWithOptions(DeletePermissionRequest request, DeletePermissionHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeletePermission", "okr_1.0", "HTTP", "DELETE", "AK", "/v1.0/okr/permissions/delete", "json", req, runtime), new DeletePermissionResponse());
    }

    public GetPeriodListResponse getPeriodList() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetPeriodListHeaders headers = new GetPeriodListHeaders();
        return this.getPeriodListWithOptions(headers, runtime);
    }

    public GetPeriodListResponse getPeriodListWithOptions(GetPeriodListHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetPeriodList", "okr_1.0", "HTTP", "GET", "AK", "/v1.0/okr/periods", "json", req, runtime), new GetPeriodListResponse());
    }

    public GetPermissionResponse getPermission(GetPermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetPermissionHeaders headers = new GetPermissionHeaders();
        return this.getPermissionWithOptions(request, headers, runtime);
    }

    public GetPermissionResponse getPermissionWithOptions(GetPermissionRequest request, GetPermissionHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetPermission", "okr_1.0", "HTTP", "GET", "AK", "/v1.0/okr/permissions", "json", req, runtime), new GetPermissionResponse());
    }

    public GetUserOkrResponse getUserOkr(GetUserOkrRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUserOkrHeaders headers = new GetUserOkrHeaders();
        return this.getUserOkrWithOptions(request, headers, runtime);
    }

    public GetUserOkrResponse getUserOkrWithOptions(GetUserOkrRequest request, GetUserOkrHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetUserOkr", "okr_1.0", "HTTP", "GET", "AK", "/v1.0/okr/users/okrs", "json", req, runtime), new GetUserOkrResponse());
    }

    public UnAlignObjectiveResponse unAlignObjective(String objectiveId, UnAlignObjectiveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UnAlignObjectiveHeaders headers = new UnAlignObjectiveHeaders();
        return this.unAlignObjectiveWithOptions(objectiveId, request, headers, runtime);
    }

    public UnAlignObjectiveResponse unAlignObjectiveWithOptions(String objectiveId, UnAlignObjectiveRequest request, UnAlignObjectiveHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        objectiveId = com.aliyun.openapiutil.Client.getEncodeParam(objectiveId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UnAlignObjective", "okr_1.0", "HTTP", "POST", "AK", "/v1.0/okr/objectives/" + objectiveId + "/alignments/cancel", "json", req, runtime), new UnAlignObjectiveResponse());
    }

    public UpdateKROfContentResponse updateKROfContent(UpdateKROfContentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateKROfContentHeaders headers = new UpdateKROfContentHeaders();
        return this.updateKROfContentWithOptions(request, headers, runtime);
    }

    public UpdateKROfContentResponse updateKROfContentWithOptions(UpdateKROfContentRequest request, UpdateKROfContentHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateKROfContent", "okr_1.0", "HTTP", "PUT", "AK", "/v1.0/okr/keyResults/contents", "json", req, runtime), new UpdateKROfContentResponse());
    }

    public UpdateKROfScoreResponse updateKROfScore(UpdateKROfScoreRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateKROfScoreHeaders headers = new UpdateKROfScoreHeaders();
        return this.updateKROfScoreWithOptions(request, headers, runtime);
    }

    public UpdateKROfScoreResponse updateKROfScoreWithOptions(UpdateKROfScoreRequest request, UpdateKROfScoreHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateKROfScore", "okr_1.0", "HTTP", "PUT", "AK", "/v1.0/okr/keyResults/scores", "json", req, runtime), new UpdateKROfScoreResponse());
    }

    public UpdateKROfWeightResponse updateKROfWeight(UpdateKROfWeightRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateKROfWeightHeaders headers = new UpdateKROfWeightHeaders();
        return this.updateKROfWeightWithOptions(request, headers, runtime);
    }

    public UpdateKROfWeightResponse updateKROfWeightWithOptions(UpdateKROfWeightRequest request, UpdateKROfWeightHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateKROfWeight", "okr_1.0", "HTTP", "PUT", "AK", "/v1.0/okr/keyResults/weights", "json", req, runtime), new UpdateKROfWeightResponse());
    }

    public UpdateObjectiveResponse updateObjective(String objectiveId, UpdateObjectiveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateObjectiveHeaders headers = new UpdateObjectiveHeaders();
        return this.updateObjectiveWithOptions(objectiveId, request, headers, runtime);
    }

    public UpdateObjectiveResponse updateObjectiveWithOptions(String objectiveId, UpdateObjectiveRequest request, UpdateObjectiveHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        objectiveId = com.aliyun.openapiutil.Client.getEncodeParam(objectiveId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateObjective", "okr_1.0", "HTTP", "PUT", "AK", "/v1.0/okr/objectives/" + objectiveId + "", "json", req, runtime), new UpdateObjectiveResponse());
    }

    public UpdatePrivacyResponse updatePrivacy(UpdatePrivacyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdatePrivacyHeaders headers = new UpdatePrivacyHeaders();
        return this.updatePrivacyWithOptions(request, headers, runtime);
    }

    public UpdatePrivacyResponse updatePrivacyWithOptions(UpdatePrivacyRequest request, UpdatePrivacyHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdatePrivacy", "okr_1.0", "HTTP", "PUT", "AK", "/v1.0/okr/permissions/privacies", "json", req, runtime), new UpdatePrivacyResponse());
    }
}
