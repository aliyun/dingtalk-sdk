// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkyida_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public BatchGetFormDataByIdListResponse batchGetFormDataByIdList(BatchGetFormDataByIdListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchGetFormDataByIdListHeaders headers = new BatchGetFormDataByIdListHeaders();
        return this.batchGetFormDataByIdListWithOptions(request, headers, runtime);
    }

    public BatchGetFormDataByIdListResponse batchGetFormDataByIdListWithOptions(BatchGetFormDataByIdListRequest request, BatchGetFormDataByIdListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formInstanceIdList)) {
            body.put("formInstanceIdList", request.formInstanceIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needFormInstanceValue)) {
            body.put("needFormInstanceValue", request.needFormInstanceValue);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("BatchGetFormDataByIdList", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/instances/ids/query", "json", req, runtime), new BatchGetFormDataByIdListResponse());
    }

    public BatchRemovalByFormInstanceIdListResponse batchRemovalByFormInstanceIdList(BatchRemovalByFormInstanceIdListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchRemovalByFormInstanceIdListHeaders headers = new BatchRemovalByFormInstanceIdListHeaders();
        return this.batchRemovalByFormInstanceIdListWithOptions(request, headers, runtime);
    }

    public BatchRemovalByFormInstanceIdListResponse batchRemovalByFormInstanceIdListWithOptions(BatchRemovalByFormInstanceIdListRequest request, BatchRemovalByFormInstanceIdListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.asynchronousExecution)) {
            body.put("asynchronousExecution", request.asynchronousExecution);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.executeExpression)) {
            body.put("executeExpression", request.executeExpression);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formInstanceIdList)) {
            body.put("formInstanceIdList", request.formInstanceIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("BatchRemovalByFormInstanceIdList", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/instances/batchRemove", "none", req, runtime), new BatchRemovalByFormInstanceIdListResponse());
    }

    public BatchSaveFormDataResponse batchSaveFormData(BatchSaveFormDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchSaveFormDataHeaders headers = new BatchSaveFormDataHeaders();
        return this.batchSaveFormDataWithOptions(request, headers, runtime);
    }

    public BatchSaveFormDataResponse batchSaveFormDataWithOptions(BatchSaveFormDataRequest request, BatchSaveFormDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.asynchronousExecution)) {
            body.put("asynchronousExecution", request.asynchronousExecution);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formDataJsonList)) {
            body.put("formDataJsonList", request.formDataJsonList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keepRunningAfterException)) {
            body.put("keepRunningAfterException", request.keepRunningAfterException);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.noExecuteExpression)) {
            body.put("noExecuteExpression", request.noExecuteExpression);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("BatchSaveFormData", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/instances/batchSave", "json", req, runtime), new BatchSaveFormDataResponse());
    }

    public BatchUpdateFormDataByInstanceIdResponse batchUpdateFormDataByInstanceId(BatchUpdateFormDataByInstanceIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchUpdateFormDataByInstanceIdHeaders headers = new BatchUpdateFormDataByInstanceIdHeaders();
        return this.batchUpdateFormDataByInstanceIdWithOptions(request, headers, runtime);
    }

    public BatchUpdateFormDataByInstanceIdResponse batchUpdateFormDataByInstanceIdWithOptions(BatchUpdateFormDataByInstanceIdRequest request, BatchUpdateFormDataByInstanceIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.asynchronousExecution)) {
            body.put("asynchronousExecution", request.asynchronousExecution);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formInstanceIdList)) {
            body.put("formInstanceIdList", request.formInstanceIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ignoreEmpty)) {
            body.put("ignoreEmpty", request.ignoreEmpty);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.noExecuteExpression)) {
            body.put("noExecuteExpression", request.noExecuteExpression);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.updateFormDataJson)) {
            body.put("updateFormDataJson", request.updateFormDataJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useLatestFormSchemaVersion)) {
            body.put("useLatestFormSchemaVersion", request.useLatestFormSchemaVersion);
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
        return TeaModel.toModel(this.doROARequest("BatchUpdateFormDataByInstanceId", "yida_1.0", "HTTP", "PUT", "AK", "/v1.0/yida/forms/instances/components", "json", req, runtime), new BatchUpdateFormDataByInstanceIdResponse());
    }

    public BatchUpdateFormDataByInstanceMapResponse batchUpdateFormDataByInstanceMap(BatchUpdateFormDataByInstanceMapRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchUpdateFormDataByInstanceMapHeaders headers = new BatchUpdateFormDataByInstanceMapHeaders();
        return this.batchUpdateFormDataByInstanceMapWithOptions(request, headers, runtime);
    }

    public BatchUpdateFormDataByInstanceMapResponse batchUpdateFormDataByInstanceMapWithOptions(BatchUpdateFormDataByInstanceMapRequest request, BatchUpdateFormDataByInstanceMapHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.asynchronousExecution)) {
            body.put("asynchronousExecution", request.asynchronousExecution);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ignoreEmpty)) {
            body.put("ignoreEmpty", request.ignoreEmpty);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.noExecuteExpression)) {
            body.put("noExecuteExpression", request.noExecuteExpression);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.updateFormDataJsonMap)) {
            body.put("updateFormDataJsonMap", request.updateFormDataJsonMap);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.useLatestFormSchemaVersion)) {
            body.put("useLatestFormSchemaVersion", request.useLatestFormSchemaVersion);
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
        return TeaModel.toModel(this.doROARequest("BatchUpdateFormDataByInstanceMap", "yida_1.0", "HTTP", "PUT", "AK", "/v1.0/yida/forms/instances/datas", "json", req, runtime), new BatchUpdateFormDataByInstanceMapResponse());
    }

    public BuyAuthorizationOrderResponse buyAuthorizationOrder(BuyAuthorizationOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BuyAuthorizationOrderHeaders headers = new BuyAuthorizationOrderHeaders();
        return this.buyAuthorizationOrderWithOptions(request, headers, runtime);
    }

    public BuyAuthorizationOrderResponse buyAuthorizationOrderWithOptions(BuyAuthorizationOrderRequest request, BuyAuthorizationOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            body.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountNumber)) {
            body.put("accountNumber", request.accountNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.beginTimeGMT)) {
            body.put("beginTimeGMT", request.beginTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUnionId)) {
            body.put("callerUnionId", request.callerUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chargeType)) {
            body.put("chargeType", request.chargeType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.commerceType)) {
            body.put("commerceType", request.commerceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.commodityType)) {
            body.put("commodityType", request.commodityType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTimeGMT)) {
            body.put("endTimeGMT", request.endTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceName)) {
            body.put("instanceName", request.instanceName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.produceCode)) {
            body.put("produceCode", request.produceCode);
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
        return TeaModel.toModel(this.doROARequest("BuyAuthorizationOrder", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/appAuthorizations/order", "json", req, runtime), new BuyAuthorizationOrderResponse());
    }

    public BuyFreshOrderResponse buyFreshOrder(BuyFreshOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BuyFreshOrderHeaders headers = new BuyFreshOrderHeaders();
        return this.buyFreshOrderWithOptions(request, headers, runtime);
    }

    public BuyFreshOrderResponse buyFreshOrderWithOptions(BuyFreshOrderRequest request, BuyFreshOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            body.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountNumber)) {
            body.put("accountNumber", request.accountNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.beginTimeGMT)) {
            body.put("beginTimeGMT", request.beginTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUnionId)) {
            body.put("callerUnionId", request.callerUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chargeType)) {
            body.put("chargeType", request.chargeType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.commerceType)) {
            body.put("commerceType", request.commerceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.commodityType)) {
            body.put("commodityType", request.commodityType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTimeGMT)) {
            body.put("endTimeGMT", request.endTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceName)) {
            body.put("instanceName", request.instanceName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.produceCode)) {
            body.put("produceCode", request.produceCode);
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
        return TeaModel.toModel(this.doROARequest("BuyFreshOrder", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/apps/freshOrders", "json", req, runtime), new BuyFreshOrderResponse());
    }

    public CheckCloudAccountStatusResponse checkCloudAccountStatus(String callerUid, CheckCloudAccountStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckCloudAccountStatusHeaders headers = new CheckCloudAccountStatusHeaders();
        return this.checkCloudAccountStatusWithOptions(callerUid, request, headers, runtime);
    }

    public CheckCloudAccountStatusResponse checkCloudAccountStatusWithOptions(String callerUid, CheckCloudAccountStatusRequest request, CheckCloudAccountStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        callerUid = com.aliyun.openapiutil.Client.getEncodeParam(callerUid);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
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
        return TeaModel.toModel(this.doROARequest("CheckCloudAccountStatus", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/apps/cloudAccountStatus/" + callerUid + "", "json", req, runtime), new CheckCloudAccountStatusResponse());
    }

    public CreateOrUpdateFormDataResponse createOrUpdateFormData(CreateOrUpdateFormDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateOrUpdateFormDataHeaders headers = new CreateOrUpdateFormDataHeaders();
        return this.createOrUpdateFormDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("CreateOrUpdateFormData", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/instances/insertOrUpdate", "json", req, runtime), new CreateOrUpdateFormDataResponse());
    }

    public DeleteFormDataResponse deleteFormData(DeleteFormDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteFormDataHeaders headers = new DeleteFormDataHeaders();
        return this.deleteFormDataWithOptions(request, headers, runtime);
    }

    public DeleteFormDataResponse deleteFormDataWithOptions(DeleteFormDataRequest request, DeleteFormDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formInstanceId)) {
            query.put("formInstanceId", request.formInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("DeleteFormData", "yida_1.0", "HTTP", "DELETE", "AK", "/v1.0/yida/forms/instances", "none", req, runtime), new DeleteFormDataResponse());
    }

    public DeleteInstanceResponse deleteInstance(DeleteInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteInstanceHeaders headers = new DeleteInstanceHeaders();
        return this.deleteInstanceWithOptions(request, headers, runtime);
    }

    public DeleteInstanceResponse deleteInstanceWithOptions(DeleteInstanceRequest request, DeleteInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            query.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("DeleteInstance", "yida_1.0", "HTTP", "DELETE", "AK", "/v1.0/yida/processes/instances", "none", req, runtime), new DeleteInstanceResponse());
    }

    public DeleteSequenceResponse deleteSequence(DeleteSequenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSequenceHeaders headers = new DeleteSequenceHeaders();
        return this.deleteSequenceWithOptions(request, headers, runtime);
    }

    public DeleteSequenceResponse deleteSequenceWithOptions(DeleteSequenceRequest request, DeleteSequenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sequence)) {
            query.put("sequence", request.sequence);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("DeleteSequence", "yida_1.0", "HTTP", "DELETE", "AK", "/v1.0/yida/forms/deleteSequence", "none", req, runtime), new DeleteSequenceResponse());
    }

    public DeployFunctionCallbackResponse deployFunctionCallback(DeployFunctionCallbackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeployFunctionCallbackHeaders headers = new DeployFunctionCallbackHeaders();
        return this.deployFunctionCallbackWithOptions(request, headers, runtime);
    }

    public DeployFunctionCallbackResponse deployFunctionCallbackWithOptions(DeployFunctionCallbackRequest request, DeployFunctionCallbackHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customDomain)) {
            body.put("customDomain", request.customDomain);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deployStage)) {
            body.put("deployStage", request.deployStage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gateWayAppKey)) {
            body.put("gateWayAppKey", request.gateWayAppKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gateWayAppSecret)) {
            body.put("gateWayAppSecret", request.gateWayAppSecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gateWayDomain)) {
            body.put("gateWayDomain", request.gateWayDomain);
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
        return TeaModel.toModel(this.doROARequest("DeployFunctionCallback", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/functionComputeConnectors/completeDeployments/notify", "json", req, runtime), new DeployFunctionCallbackResponse());
    }

    public ExecuteBatchTaskResponse executeBatchTask(ExecuteBatchTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExecuteBatchTaskHeaders headers = new ExecuteBatchTaskHeaders();
        return this.executeBatchTaskWithOptions(request, headers, runtime);
    }

    public ExecuteBatchTaskResponse executeBatchTaskWithOptions(ExecuteBatchTaskRequest request, ExecuteBatchTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outResult)) {
            body.put("outResult", request.outResult);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskInformationList)) {
            body.put("taskInformationList", request.taskInformationList);
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
        return TeaModel.toModel(this.doROARequest("ExecuteBatchTask", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/tasks/batches/execute", "json", req, runtime), new ExecuteBatchTaskResponse());
    }

    public ExecuteCustomApiResponse executeCustomApi(ExecuteCustomApiRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExecuteCustomApiHeaders headers = new ExecuteCustomApiHeaders();
        return this.executeCustomApiWithOptions(request, headers, runtime);
    }

    public ExecuteCustomApiResponse executeCustomApiWithOptions(ExecuteCustomApiRequest request, ExecuteCustomApiHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
            query.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceId)) {
            query.put("serviceId", request.serviceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("ExecuteCustomApi", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/apps/customApi/execute", "json", req, runtime), new ExecuteCustomApiResponse());
    }

    public ExecutePlatformTaskResponse executePlatformTask(ExecutePlatformTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExecutePlatformTaskHeaders headers = new ExecutePlatformTaskHeaders();
        return this.executePlatformTaskWithOptions(request, headers, runtime);
    }

    public ExecutePlatformTaskResponse executePlatformTaskWithOptions(ExecutePlatformTaskRequest request, ExecutePlatformTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formDataJson)) {
            body.put("formDataJson", request.formDataJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.noExecuteExpressions)) {
            body.put("noExecuteExpressions", request.noExecuteExpressions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outResult)) {
            body.put("outResult", request.outResult);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("ExecutePlatformTask", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/tasks/platformTasks/execute", "none", req, runtime), new ExecutePlatformTaskResponse());
    }

    public ExecuteTaskResponse executeTask(ExecuteTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExecuteTaskHeaders headers = new ExecuteTaskHeaders();
        return this.executeTaskWithOptions(request, headers, runtime);
    }

    public ExecuteTaskResponse executeTaskWithOptions(ExecuteTaskRequest request, ExecuteTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.digitalSignUrl)) {
            body.put("digitalSignUrl", request.digitalSignUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formDataJson)) {
            body.put("formDataJson", request.formDataJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.noExecuteExpressions)) {
            body.put("noExecuteExpressions", request.noExecuteExpressions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outResult)) {
            body.put("outResult", request.outResult);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
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
        return TeaModel.toModel(this.doROARequest("ExecuteTask", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/tasks/execute", "none", req, runtime), new ExecuteTaskResponse());
    }

    public ExpireCommodityResponse expireCommodity(ExpireCommodityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExpireCommodityHeaders headers = new ExpireCommodityHeaders();
        return this.expireCommodityWithOptions(request, headers, runtime);
    }

    public ExpireCommodityResponse expireCommodityWithOptions(ExpireCommodityRequest request, ExpireCommodityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            query.put("instanceId", request.instanceId);
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
        return TeaModel.toModel(this.doROARequest("ExpireCommodity", "yida_1.0", "HTTP", "PUT", "AK", "/v1.0/yida/appAuth/commodities/expire", "json", req, runtime), new ExpireCommodityResponse());
    }

    public GetActivationCodeByCallerUnionIdResponse getActivationCodeByCallerUnionId(String callerUid, GetActivationCodeByCallerUnionIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetActivationCodeByCallerUnionIdHeaders headers = new GetActivationCodeByCallerUnionIdHeaders();
        return this.getActivationCodeByCallerUnionIdWithOptions(callerUid, request, headers, runtime);
    }

    public GetActivationCodeByCallerUnionIdResponse getActivationCodeByCallerUnionIdWithOptions(String callerUid, GetActivationCodeByCallerUnionIdRequest request, GetActivationCodeByCallerUnionIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        callerUid = com.aliyun.openapiutil.Client.getEncodeParam(callerUid);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
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
        return TeaModel.toModel(this.doROARequest("GetActivationCodeByCallerUnionId", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/applications/activationCodes/" + callerUid + "", "json", req, runtime), new GetActivationCodeByCallerUnionIdResponse());
    }

    public GetActivityButtonListResponse getActivityButtonList(String appType, String processCode, String activityId, GetActivityButtonListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetActivityButtonListHeaders headers = new GetActivityButtonListHeaders();
        return this.getActivityButtonListWithOptions(appType, processCode, activityId, request, headers, runtime);
    }

    public GetActivityButtonListResponse getActivityButtonListWithOptions(String appType, String processCode, String activityId, GetActivityButtonListRequest request, GetActivityButtonListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        appType = com.aliyun.openapiutil.Client.getEncodeParam(appType);
        processCode = com.aliyun.openapiutil.Client.getEncodeParam(processCode);
        activityId = com.aliyun.openapiutil.Client.getEncodeParam(activityId);
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
        return TeaModel.toModel(this.doROARequest("GetActivityButtonList", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/processDefinitions/buttons/" + appType + "/" + processCode + "/" + activityId + "", "json", req, runtime), new GetActivityButtonListResponse());
    }

    public GetActivityListResponse getActivityList(GetActivityListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetActivityListHeaders headers = new GetActivityListHeaders();
        return this.getActivityListWithOptions(request, headers, runtime);
    }

    public GetActivityListResponse getActivityListWithOptions(GetActivityListRequest request, GetActivityListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            query.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("GetActivityList", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/processes/activities", "json", req, runtime), new GetActivityListResponse());
    }

    public GetApplicationAuthorizationServicePlatformResourceResponse getApplicationAuthorizationServicePlatformResource(GetApplicationAuthorizationServicePlatformResourceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetApplicationAuthorizationServicePlatformResourceHeaders headers = new GetApplicationAuthorizationServicePlatformResourceHeaders();
        return this.getApplicationAuthorizationServicePlatformResourceWithOptions(request, headers, runtime);
    }

    public GetApplicationAuthorizationServicePlatformResourceResponse getApplicationAuthorizationServicePlatformResourceWithOptions(GetApplicationAuthorizationServicePlatformResourceRequest request, GetApplicationAuthorizationServicePlatformResourceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            query.put("instanceId", request.instanceId);
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
        return TeaModel.toModel(this.doROARequest("GetApplicationAuthorizationServicePlatformResource", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/authorization/platformResources", "json", req, runtime), new GetApplicationAuthorizationServicePlatformResourceResponse());
    }

    public GetCorpAccomplishmentTasksResponse getCorpAccomplishmentTasks(String corpId, String userId, GetCorpAccomplishmentTasksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCorpAccomplishmentTasksHeaders headers = new GetCorpAccomplishmentTasksHeaders();
        return this.getCorpAccomplishmentTasksWithOptions(corpId, userId, request, headers, runtime);
    }

    public GetCorpAccomplishmentTasksResponse getCorpAccomplishmentTasksWithOptions(String corpId, String userId, GetCorpAccomplishmentTasksRequest request, GetCorpAccomplishmentTasksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        corpId = com.aliyun.openapiutil.Client.getEncodeParam(corpId);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appTypes)) {
            query.put("appTypes", request.appTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createFromTimeGMT)) {
            query.put("createFromTimeGMT", request.createFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createToTimeGMT)) {
            query.put("createToTimeGMT", request.createToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            query.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCodes)) {
            query.put("processCodes", request.processCodes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            query.put("token", request.token);
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
        return TeaModel.toModel(this.doROARequest("GetCorpAccomplishmentTasks", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/tasks/completedTasks/" + corpId + "/" + userId + "", "json", req, runtime), new GetCorpAccomplishmentTasksResponse());
    }

    public GetCorpLevelByAccountIdResponse getCorpLevelByAccountId(GetCorpLevelByAccountIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCorpLevelByAccountIdHeaders headers = new GetCorpLevelByAccountIdHeaders();
        return this.getCorpLevelByAccountIdWithOptions(request, headers, runtime);
    }

    public GetCorpLevelByAccountIdResponse getCorpLevelByAccountIdWithOptions(GetCorpLevelByAccountIdRequest request, GetCorpLevelByAccountIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            query.put("accountId", request.accountId);
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
        return TeaModel.toModel(this.doROARequest("GetCorpLevelByAccountId", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/apps/corpLevel", "json", req, runtime), new GetCorpLevelByAccountIdResponse());
    }

    public GetCorpTasksResponse getCorpTasks(GetCorpTasksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCorpTasksHeaders headers = new GetCorpTasksHeaders();
        return this.getCorpTasksWithOptions(request, headers, runtime);
    }

    public GetCorpTasksResponse getCorpTasksWithOptions(GetCorpTasksRequest request, GetCorpTasksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appTypes)) {
            query.put("appTypes", request.appTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createFromTimeGMT)) {
            query.put("createFromTimeGMT", request.createFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createToTimeGMT)) {
            query.put("createToTimeGMT", request.createToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            query.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCodes)) {
            query.put("processCodes", request.processCodes);
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
        return TeaModel.toModel(this.doROARequest("GetCorpTasks", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/corpTasks", "json", req, runtime), new GetCorpTasksResponse());
    }

    public GetFieldDefByUuidResponse getFieldDefByUuid(GetFieldDefByUuidRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFieldDefByUuidHeaders headers = new GetFieldDefByUuidHeaders();
        return this.getFieldDefByUuidWithOptions(request, headers, runtime);
    }

    public GetFieldDefByUuidResponse getFieldDefByUuidWithOptions(GetFieldDefByUuidRequest request, GetFieldDefByUuidHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            query.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("GetFieldDefByUuid", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/forms/formFields", "json", req, runtime), new GetFieldDefByUuidResponse());
    }

    public GetFormComponentDefinitionListResponse getFormComponentDefinitionList(String appType, String formUuid, GetFormComponentDefinitionListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFormComponentDefinitionListHeaders headers = new GetFormComponentDefinitionListHeaders();
        return this.getFormComponentDefinitionListWithOptions(appType, formUuid, request, headers, runtime);
    }

    public GetFormComponentDefinitionListResponse getFormComponentDefinitionListWithOptions(String appType, String formUuid, GetFormComponentDefinitionListRequest request, GetFormComponentDefinitionListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        appType = com.aliyun.openapiutil.Client.getEncodeParam(appType);
        formUuid = com.aliyun.openapiutil.Client.getEncodeParam(formUuid);
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
        return TeaModel.toModel(this.doROARequest("GetFormComponentDefinitionList", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/forms/definitions/" + appType + "/" + formUuid + "", "json", req, runtime), new GetFormComponentDefinitionListResponse());
    }

    public GetFormDataByIDResponse getFormDataByID(String id, GetFormDataByIDRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFormDataByIDHeaders headers = new GetFormDataByIDHeaders();
        return this.getFormDataByIDWithOptions(id, request, headers, runtime);
    }

    public GetFormDataByIDResponse getFormDataByIDWithOptions(String id, GetFormDataByIDRequest request, GetFormDataByIDHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        id = com.aliyun.openapiutil.Client.getEncodeParam(id);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("GetFormDataByID", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/forms/instances/" + id + "", "json", req, runtime), new GetFormDataByIDResponse());
    }

    public GetFormListInAppResponse getFormListInApp(GetFormListInAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFormListInAppHeaders headers = new GetFormListInAppHeaders();
        return this.getFormListInAppWithOptions(request, headers, runtime);
    }

    public GetFormListInAppResponse getFormListInAppWithOptions(GetFormListInAppRequest request, GetFormListInAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formTypes)) {
            query.put("formTypes", request.formTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("GetFormListInApp", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/forms", "json", req, runtime), new GetFormListInAppResponse());
    }

    public GetInstanceByIdResponse getInstanceById(String id, GetInstanceByIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInstanceByIdHeaders headers = new GetInstanceByIdHeaders();
        return this.getInstanceByIdWithOptions(id, request, headers, runtime);
    }

    public GetInstanceByIdResponse getInstanceByIdWithOptions(String id, GetInstanceByIdRequest request, GetInstanceByIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        id = com.aliyun.openapiutil.Client.getEncodeParam(id);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("GetInstanceById", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/processes/instancesInfos/" + id + "", "json", req, runtime), new GetInstanceByIdResponse());
    }

    public GetInstanceIdListResponse getInstanceIdList(GetInstanceIdListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInstanceIdListHeaders headers = new GetInstanceIdListHeaders();
        return this.getInstanceIdListWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetInstanceIdList", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/processes/instanceIds", "json", req, runtime), new GetInstanceIdListResponse());
    }

    public GetInstancesResponse getInstances(GetInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInstancesHeaders headers = new GetInstancesHeaders();
        return this.getInstancesWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("GetInstances", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/processes/instances", "json", req, runtime), new GetInstancesResponse());
    }

    public GetInstancesByIdListResponse getInstancesByIdList(GetInstancesByIdListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInstancesByIdListHeaders headers = new GetInstancesByIdListHeaders();
        return this.getInstancesByIdListWithOptions(request, headers, runtime);
    }

    public GetInstancesByIdListResponse getInstancesByIdListWithOptions(GetInstancesByIdListRequest request, GetInstancesByIdListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceIds)) {
            query.put("processInstanceIds", request.processInstanceIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("GetInstancesByIdList", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/processes/instances/searchWithIds", "json", req, runtime), new GetInstancesByIdListResponse());
    }

    public GetMeCorpSubmissionResponse getMeCorpSubmission(String userId, GetMeCorpSubmissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMeCorpSubmissionHeaders headers = new GetMeCorpSubmissionHeaders();
        return this.getMeCorpSubmissionWithOptions(userId, request, headers, runtime);
    }

    public GetMeCorpSubmissionResponse getMeCorpSubmissionWithOptions(String userId, GetMeCorpSubmissionRequest request, GetMeCorpSubmissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appTypes)) {
            query.put("appTypes", request.appTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createFromTimeGMT)) {
            query.put("createFromTimeGMT", request.createFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createToTimeGMT)) {
            query.put("createToTimeGMT", request.createToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            query.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCodes)) {
            query.put("processCodes", request.processCodes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            query.put("token", request.token);
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
        return TeaModel.toModel(this.doROARequest("GetMeCorpSubmission", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/tasks/myCorpSubmission/" + userId + "", "json", req, runtime), new GetMeCorpSubmissionResponse());
    }

    public GetNotifyMeResponse getNotifyMe(String userId, GetNotifyMeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetNotifyMeHeaders headers = new GetNotifyMeHeaders();
        return this.getNotifyMeWithOptions(userId, request, headers, runtime);
    }

    public GetNotifyMeResponse getNotifyMeWithOptions(String userId, GetNotifyMeRequest request, GetNotifyMeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appTypes)) {
            query.put("appTypes", request.appTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createFromTimeGMT)) {
            query.put("createFromTimeGMT", request.createFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createToTimeGMT)) {
            query.put("createToTimeGMT", request.createToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceCreateFromTimeGMT)) {
            query.put("instanceCreateFromTimeGMT", request.instanceCreateFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceCreateToTimeGMT)) {
            query.put("instanceCreateToTimeGMT", request.instanceCreateToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            query.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCodes)) {
            query.put("processCodes", request.processCodes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            query.put("token", request.token);
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
        return TeaModel.toModel(this.doROARequest("GetNotifyMe", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/corpNotifications/" + userId + "", "json", req, runtime), new GetNotifyMeResponse());
    }

    public GetOpenUrlResponse getOpenUrl(String appType, GetOpenUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOpenUrlHeaders headers = new GetOpenUrlHeaders();
        return this.getOpenUrlWithOptions(appType, request, headers, runtime);
    }

    public GetOpenUrlResponse getOpenUrlWithOptions(String appType, GetOpenUrlRequest request, GetOpenUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        appType = com.aliyun.openapiutil.Client.getEncodeParam(appType);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fileUrl)) {
            query.put("fileUrl", request.fileUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeout)) {
            query.put("timeout", request.timeout);
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
        return TeaModel.toModel(this.doROARequest("GetOpenUrl", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/apps/temporaryUrls/" + appType + "", "json", req, runtime), new GetOpenUrlResponse());
    }

    public GetOperationRecordsResponse getOperationRecords(GetOperationRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOperationRecordsHeaders headers = new GetOperationRecordsHeaders();
        return this.getOperationRecordsWithOptions(request, headers, runtime);
    }

    public GetOperationRecordsResponse getOperationRecordsWithOptions(GetOperationRecordsRequest request, GetOperationRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            query.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("GetOperationRecords", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/processes/operationRecords", "json", req, runtime), new GetOperationRecordsResponse());
    }

    public GetPlatformResourceResponse getPlatformResource(GetPlatformResourceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPlatformResourceHeaders headers = new GetPlatformResourceHeaders();
        return this.getPlatformResourceWithOptions(request, headers, runtime);
    }

    public GetPlatformResourceResponse getPlatformResourceWithOptions(GetPlatformResourceRequest request, GetPlatformResourceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            query.put("instanceId", request.instanceId);
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
        return TeaModel.toModel(this.doROARequest("GetPlatformResource", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/apps/platformResources", "json", req, runtime), new GetPlatformResourceResponse());
    }

    public GetPrintAppInfoResponse getPrintAppInfo(GetPrintAppInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPrintAppInfoHeaders headers = new GetPrintAppInfoHeaders();
        return this.getPrintAppInfoWithOptions(request, headers, runtime);
    }

    public GetPrintAppInfoResponse getPrintAppInfoWithOptions(GetPrintAppInfoRequest request, GetPrintAppInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nameLike)) {
            query.put("nameLike", request.nameLike);
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
        return TeaModel.toModel(this.doROARequest("GetPrintAppInfo", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/printTemplates/printAppInfos", "json", req, runtime), new GetPrintAppInfoResponse());
    }

    public GetPrintDictionaryResponse getPrintDictionary(GetPrintDictionaryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPrintDictionaryHeaders headers = new GetPrintDictionaryHeaders();
        return this.getPrintDictionaryWithOptions(request, headers, runtime);
    }

    public GetPrintDictionaryResponse getPrintDictionaryWithOptions(GetPrintDictionaryRequest request, GetPrintDictionaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            query.put("formUuid", request.formUuid);
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
        return TeaModel.toModel(this.doROARequest("GetPrintDictionary", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/printTemplates/printDictionaries", "json", req, runtime), new GetPrintDictionaryResponse());
    }

    public GetProcessDefinitionResponse getProcessDefinition(String processInstanceId, GetProcessDefinitionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProcessDefinitionHeaders headers = new GetProcessDefinitionHeaders();
        return this.getProcessDefinitionWithOptions(processInstanceId, request, headers, runtime);
    }

    public GetProcessDefinitionResponse getProcessDefinitionWithOptions(String processInstanceId, GetProcessDefinitionRequest request, GetProcessDefinitionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        processInstanceId = com.aliyun.openapiutil.Client.getEncodeParam(processInstanceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            query.put("groupId", request.groupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nameSpace)) {
            query.put("nameSpace", request.nameSpace);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNumber)) {
            query.put("orderNumber", request.orderNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemType)) {
            query.put("systemType", request.systemType);
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
        return TeaModel.toModel(this.doROARequest("GetProcessDefinition", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/processes/definitions/" + processInstanceId + "", "json", req, runtime), new GetProcessDefinitionResponse());
    }

    public GetRunningTaskListResponse getRunningTaskList(GetRunningTaskListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRunningTaskListHeaders headers = new GetRunningTaskListHeaders();
        return this.getRunningTaskListWithOptions(request, headers, runtime);
    }

    public GetRunningTaskListResponse getRunningTaskListWithOptions(GetRunningTaskListRequest request, GetRunningTaskListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceIdList)) {
            body.put("processInstanceIdList", request.processInstanceIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userCorpId)) {
            body.put("userCorpId", request.userCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetRunningTaskList", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/tasks/runningTasks/query", "json", req, runtime), new GetRunningTaskListResponse());
    }

    public GetRunningTasksResponse getRunningTasks(GetRunningTasksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRunningTasksHeaders headers = new GetRunningTasksHeaders();
        return this.getRunningTasksWithOptions(request, headers, runtime);
    }

    public GetRunningTasksResponse getRunningTasksWithOptions(GetRunningTasksRequest request, GetRunningTasksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            query.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("GetRunningTasks", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/processes/tasks/getRunningTasks", "json", req, runtime), new GetRunningTasksResponse());
    }

    public GetSaleUserInfoByUserIdResponse getSaleUserInfoByUserId(GetSaleUserInfoByUserIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSaleUserInfoByUserIdHeaders headers = new GetSaleUserInfoByUserIdHeaders();
        return this.getSaleUserInfoByUserIdWithOptions(request, headers, runtime);
    }

    public GetSaleUserInfoByUserIdResponse getSaleUserInfoByUserIdWithOptions(GetSaleUserInfoByUserIdRequest request, GetSaleUserInfoByUserIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.namespace)) {
            query.put("namespace", request.namespace);
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
        return TeaModel.toModel(this.doROARequest("GetSaleUserInfoByUserId", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/apps/saleUserInfo", "json", req, runtime), new GetSaleUserInfoByUserIdResponse());
    }

    public GetTaskCopiesResponse getTaskCopies(GetTaskCopiesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTaskCopiesHeaders headers = new GetTaskCopiesHeaders();
        return this.getTaskCopiesWithOptions(request, headers, runtime);
    }

    public GetTaskCopiesResponse getTaskCopiesWithOptions(GetTaskCopiesRequest request, GetTaskCopiesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createFromTimeGMT)) {
            query.put("createFromTimeGMT", request.createFromTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createToTimeGMT)) {
            query.put("createToTimeGMT", request.createToTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            query.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCodes)) {
            query.put("processCodes", request.processCodes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("GetTaskCopies", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/tasks/taskCopies", "json", req, runtime), new GetTaskCopiesResponse());
    }

    public ListApplicationResponse listApplication(ListApplicationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListApplicationHeaders headers = new ListApplicationHeaders();
        return this.listApplicationWithOptions(request, headers, runtime);
    }

    public ListApplicationResponse listApplicationWithOptions(ListApplicationRequest request, ListApplicationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appFilter)) {
            query.put("appFilter", request.appFilter);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appNameSearchKeyword)) {
            query.put("appNameSearchKeyword", request.appNameSearchKeyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
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
        return TeaModel.toModel(this.doROARequest("ListApplication", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/organizations/applications", "json", req, runtime), new ListApplicationResponse());
    }

    public ListApplicationAuthorizationServiceApplicationInformationResponse listApplicationAuthorizationServiceApplicationInformation(String instanceId, ListApplicationAuthorizationServiceApplicationInformationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListApplicationAuthorizationServiceApplicationInformationHeaders headers = new ListApplicationAuthorizationServiceApplicationInformationHeaders();
        return this.listApplicationAuthorizationServiceApplicationInformationWithOptions(instanceId, request, headers, runtime);
    }

    public ListApplicationAuthorizationServiceApplicationInformationResponse listApplicationAuthorizationServiceApplicationInformationWithOptions(String instanceId, ListApplicationAuthorizationServiceApplicationInformationRequest request, ListApplicationAuthorizationServiceApplicationInformationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        instanceId = com.aliyun.openapiutil.Client.getEncodeParam(instanceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUnionId)) {
            query.put("callerUnionId", request.callerUnionId);
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
        return TeaModel.toModel(this.doROARequest("ListApplicationAuthorizationServiceApplicationInformation", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/authorizations/applicationInfos/" + instanceId + "", "json", req, runtime), new ListApplicationAuthorizationServiceApplicationInformationResponse());
    }

    public ListApplicationAuthorizationServiceConnectorInformationResponse listApplicationAuthorizationServiceConnectorInformation(String instanceId, ListApplicationAuthorizationServiceConnectorInformationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListApplicationAuthorizationServiceConnectorInformationHeaders headers = new ListApplicationAuthorizationServiceConnectorInformationHeaders();
        return this.listApplicationAuthorizationServiceConnectorInformationWithOptions(instanceId, request, headers, runtime);
    }

    public ListApplicationAuthorizationServiceConnectorInformationResponse listApplicationAuthorizationServiceConnectorInformationWithOptions(String instanceId, ListApplicationAuthorizationServiceConnectorInformationRequest request, ListApplicationAuthorizationServiceConnectorInformationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        instanceId = com.aliyun.openapiutil.Client.getEncodeParam(instanceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
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
        return TeaModel.toModel(this.doROARequest("ListApplicationAuthorizationServiceConnectorInformation", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/applicationAuthorizations/plugs/" + instanceId + "", "json", req, runtime), new ListApplicationAuthorizationServiceConnectorInformationResponse());
    }

    public ListApplicationInformationResponse listApplicationInformation(String instanceId, ListApplicationInformationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListApplicationInformationHeaders headers = new ListApplicationInformationHeaders();
        return this.listApplicationInformationWithOptions(instanceId, request, headers, runtime);
    }

    public ListApplicationInformationResponse listApplicationInformationWithOptions(String instanceId, ListApplicationInformationRequest request, ListApplicationInformationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        instanceId = com.aliyun.openapiutil.Client.getEncodeParam(instanceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
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
        return TeaModel.toModel(this.doROARequest("ListApplicationInformation", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/apps/infos/" + instanceId + "", "json", req, runtime), new ListApplicationInformationResponse());
    }

    public ListCommodityResponse listCommodity(ListCommodityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListCommodityHeaders headers = new ListCommodityHeaders();
        return this.listCommodityWithOptions(request, headers, runtime);
    }

    public ListCommodityResponse listCommodityWithOptions(ListCommodityRequest request, ListCommodityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
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
        return TeaModel.toModel(this.doROARequest("ListCommodity", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/appAuth/commodities", "json", req, runtime), new ListCommodityResponse());
    }

    public ListConnectorInformationResponse listConnectorInformation(String instanceId, ListConnectorInformationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListConnectorInformationHeaders headers = new ListConnectorInformationHeaders();
        return this.listConnectorInformationWithOptions(instanceId, request, headers, runtime);
    }

    public ListConnectorInformationResponse listConnectorInformationWithOptions(String instanceId, ListConnectorInformationRequest request, ListConnectorInformationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        instanceId = com.aliyun.openapiutil.Client.getEncodeParam(instanceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
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
        return TeaModel.toModel(this.doROARequest("ListConnectorInformation", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/plugins/infos/" + instanceId + "", "json", req, runtime), new ListConnectorInformationResponse());
    }

    public ListFormRemarksResponse listFormRemarks(ListFormRemarksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListFormRemarksHeaders headers = new ListFormRemarksHeaders();
        return this.listFormRemarksWithOptions(request, headers, runtime);
    }

    public ListFormRemarksResponse listFormRemarksWithOptions(ListFormRemarksRequest request, ListFormRemarksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formInstanceIdList)) {
            body.put("formInstanceIdList", request.formInstanceIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("ListFormRemarks", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/remarks/query", "json", req, runtime), new ListFormRemarksResponse());
    }

    public ListNavigationByFormTypeResponse listNavigationByFormType(ListNavigationByFormTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListNavigationByFormTypeHeaders headers = new ListNavigationByFormTypeHeaders();
        return this.listNavigationByFormTypeWithOptions(request, headers, runtime);
    }

    public ListNavigationByFormTypeResponse listNavigationByFormTypeWithOptions(ListNavigationByFormTypeRequest request, ListNavigationByFormTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formType)) {
            query.put("formType", request.formType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("ListNavigationByFormType", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/apps/navigations", "json", req, runtime), new ListNavigationByFormTypeResponse());
    }

    public ListOperationLogsResponse listOperationLogs(ListOperationLogsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListOperationLogsHeaders headers = new ListOperationLogsHeaders();
        return this.listOperationLogsWithOptions(request, headers, runtime);
    }

    public ListOperationLogsResponse listOperationLogsWithOptions(ListOperationLogsRequest request, ListOperationLogsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formInstanceIdList)) {
            body.put("formInstanceIdList", request.formInstanceIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("ListOperationLogs", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/operationsLogs/query", "json", req, runtime), new ListOperationLogsResponse());
    }

    public ListTableDataByFormInstanceIdTableIdResponse listTableDataByFormInstanceIdTableId(String formInstanceId, ListTableDataByFormInstanceIdTableIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListTableDataByFormInstanceIdTableIdHeaders headers = new ListTableDataByFormInstanceIdTableIdHeaders();
        return this.listTableDataByFormInstanceIdTableIdWithOptions(formInstanceId, request, headers, runtime);
    }

    public ListTableDataByFormInstanceIdTableIdResponse listTableDataByFormInstanceIdTableIdWithOptions(String formInstanceId, ListTableDataByFormInstanceIdTableIdRequest request, ListTableDataByFormInstanceIdTableIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        formInstanceId = com.aliyun.openapiutil.Client.getEncodeParam(formInstanceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            query.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tableFieldId)) {
            query.put("tableFieldId", request.tableFieldId);
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
        return TeaModel.toModel(this.doROARequest("ListTableDataByFormInstanceIdTableId", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/forms/innerTables/" + formInstanceId + "", "json", req, runtime), new ListTableDataByFormInstanceIdTableIdResponse());
    }

    public LoginCodeGenResponse loginCodeGen(LoginCodeGenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LoginCodeGenHeaders headers = new LoginCodeGenHeaders();
        return this.loginCodeGenWithOptions(request, headers, runtime);
    }

    public LoginCodeGenResponse loginCodeGenWithOptions(LoginCodeGenRequest request, LoginCodeGenHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("LoginCodeGen", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/authorizations/loginCodes", "json", req, runtime), new LoginCodeGenResponse());
    }

    public NotifyAuthorizationResultResponse notifyAuthorizationResult(NotifyAuthorizationResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        NotifyAuthorizationResultHeaders headers = new NotifyAuthorizationResultHeaders();
        return this.notifyAuthorizationResultWithOptions(request, headers, runtime);
    }

    public NotifyAuthorizationResultResponse notifyAuthorizationResultWithOptions(NotifyAuthorizationResultRequest request, NotifyAuthorizationResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            body.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountNumber)) {
            body.put("accountNumber", request.accountNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.beginTimeGMT)) {
            body.put("beginTimeGMT", request.beginTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            body.put("callerUid", request.callerUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chargeType)) {
            body.put("chargeType", request.chargeType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.commerceType)) {
            body.put("commerceType", request.commerceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.commodityType)) {
            body.put("commodityType", request.commodityType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTimeGMT)) {
            body.put("endTimeGMT", request.endTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceName)) {
            body.put("instanceName", request.instanceName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.produceCode)) {
            body.put("produceCode", request.produceCode);
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
        return TeaModel.toModel(this.doROARequest("NotifyAuthorizationResult", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/apps/authorizationResults/notify", "json", req, runtime), new NotifyAuthorizationResultResponse());
    }

    public PageFormBaseInfosResponse pageFormBaseInfos(PageFormBaseInfosRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PageFormBaseInfosHeaders headers = new PageFormBaseInfosHeaders();
        return this.pageFormBaseInfosWithOptions(request, headers, runtime);
    }

    public PageFormBaseInfosResponse pageFormBaseInfosWithOptions(PageFormBaseInfosRequest request, PageFormBaseInfosHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formTypeList)) {
            body.put("formTypeList", request.formTypeList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageIndex)) {
            body.put("pageIndex", request.pageIndex);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("PageFormBaseInfos", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/apps/forms/query", "json", req, runtime), new PageFormBaseInfosResponse());
    }

    public QueryServiceRecordResponse queryServiceRecord(QueryServiceRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryServiceRecordHeaders headers = new QueryServiceRecordHeaders();
        return this.queryServiceRecordWithOptions(request, headers, runtime);
    }

    public QueryServiceRecordResponse queryServiceRecordWithOptions(QueryServiceRecordRequest request, QueryServiceRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            query.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hookType)) {
            query.put("hookType", request.hookType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hookUuid)) {
            query.put("hookUuid", request.hookUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            query.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invokeAfterDateGMT)) {
            query.put("invokeAfterDateGMT", request.invokeAfterDateGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invokeBeforeDateGMT)) {
            query.put("invokeBeforeDateGMT", request.invokeBeforeDateGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invokeStatus)) {
            query.put("invokeStatus", request.invokeStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestUrl)) {
            query.put("requestUrl", request.requestUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceUuid)) {
            query.put("sourceUuid", request.sourceUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.success)) {
            query.put("success", request.success);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("QueryServiceRecord", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/services/invocationRecords", "json", req, runtime), new QueryServiceRecordResponse());
    }

    public RedirectTaskResponse redirectTask(RedirectTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RedirectTaskHeaders headers = new RedirectTaskHeaders();
        return this.redirectTaskWithOptions(request, headers, runtime);
    }

    public RedirectTaskResponse redirectTaskWithOptions(RedirectTaskRequest request, RedirectTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.byManager)) {
            body.put("byManager", request.byManager);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nowActionExecutorId)) {
            body.put("nowActionExecutorId", request.nowActionExecutorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
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
        return TeaModel.toModel(this.doROARequest("RedirectTask", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/tasks/redirect", "none", req, runtime), new RedirectTaskResponse());
    }

    public RefundCommodityResponse refundCommodity(RefundCommodityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RefundCommodityHeaders headers = new RefundCommodityHeaders();
        return this.refundCommodityWithOptions(request, headers, runtime);
    }

    public RefundCommodityResponse refundCommodityWithOptions(RefundCommodityRequest request, RefundCommodityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            query.put("instanceId", request.instanceId);
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
        return TeaModel.toModel(this.doROARequest("RefundCommodity", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/appAuth/commodities/refund", "json", req, runtime), new RefundCommodityResponse());
    }

    public RegisterAccountsResponse registerAccounts(RegisterAccountsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterAccountsHeaders headers = new RegisterAccountsHeaders();
        return this.registerAccountsWithOptions(request, headers, runtime);
    }

    public RegisterAccountsResponse registerAccountsWithOptions(RegisterAccountsRequest request, RegisterAccountsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            body.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.activeCode)) {
            body.put("activeCode", request.activeCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
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
        return TeaModel.toModel(this.doROARequest("RegisterAccounts", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/applicationAuthorizations/accounts/register", "json", req, runtime), new RegisterAccountsResponse());
    }

    public ReleaseCommodityResponse releaseCommodity(ReleaseCommodityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReleaseCommodityHeaders headers = new ReleaseCommodityHeaders();
        return this.releaseCommodityWithOptions(request, headers, runtime);
    }

    public ReleaseCommodityResponse releaseCommodityWithOptions(ReleaseCommodityRequest request, ReleaseCommodityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            query.put("instanceId", request.instanceId);
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
        return TeaModel.toModel(this.doROARequest("ReleaseCommodity", "yida_1.0", "HTTP", "DELETE", "AK", "/v1.0/yida/appAuth/commodities/release", "json", req, runtime), new ReleaseCommodityResponse());
    }

    public RemoveTenantResourceResponse removeTenantResource(String callerUid, RemoveTenantResourceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveTenantResourceHeaders headers = new RemoveTenantResourceHeaders();
        return this.removeTenantResourceWithOptions(callerUid, request, headers, runtime);
    }

    public RemoveTenantResourceResponse removeTenantResourceWithOptions(String callerUid, RemoveTenantResourceRequest request, RemoveTenantResourceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        callerUid = com.aliyun.openapiutil.Client.getEncodeParam(callerUid);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
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
        return TeaModel.toModel(this.doROARequest("RemoveTenantResource", "yida_1.0", "HTTP", "DELETE", "AK", "/v1.0/yida/applications/tenantRelatedResources/" + callerUid + "", "json", req, runtime), new RemoveTenantResourceResponse());
    }

    public RenderBatchCallbackResponse renderBatchCallback(RenderBatchCallbackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RenderBatchCallbackHeaders headers = new RenderBatchCallbackHeaders();
        return this.renderBatchCallbackWithOptions(request, headers, runtime);
    }

    public RenderBatchCallbackResponse renderBatchCallbackWithOptions(RenderBatchCallbackRequest request, RenderBatchCallbackHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSize)) {
            body.put("fileSize", request.fileSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.namespace)) {
            body.put("namespace", request.namespace);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ossUrl)) {
            body.put("ossUrl", request.ossUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sequenceId)) {
            body.put("sequenceId", request.sequenceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeZone)) {
            body.put("timeZone", request.timeZone);
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
        return TeaModel.toModel(this.doROARequest("RenderBatchCallback", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/printings/callbacks/batch", "none", req, runtime), new RenderBatchCallbackResponse());
    }

    public RenewApplicationAuthorizationServiceOrderResponse renewApplicationAuthorizationServiceOrder(RenewApplicationAuthorizationServiceOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RenewApplicationAuthorizationServiceOrderHeaders headers = new RenewApplicationAuthorizationServiceOrderHeaders();
        return this.renewApplicationAuthorizationServiceOrderWithOptions(request, headers, runtime);
    }

    public RenewApplicationAuthorizationServiceOrderResponse renewApplicationAuthorizationServiceOrderWithOptions(RenewApplicationAuthorizationServiceOrderRequest request, RenewApplicationAuthorizationServiceOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            body.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUnionId)) {
            body.put("callerUnionId", request.callerUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTimeGMT)) {
            body.put("endTimeGMT", request.endTimeGMT);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
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
        return TeaModel.toModel(this.doROARequest("RenewApplicationAuthorizationServiceOrder", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/applicationAuthorizations/orders/renew", "json", req, runtime), new RenewApplicationAuthorizationServiceOrderResponse());
    }

    public RenewTenantOrderResponse renewTenantOrder(RenewTenantOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RenewTenantOrderHeaders headers = new RenewTenantOrderHeaders();
        return this.renewTenantOrderWithOptions(request, headers, runtime);
    }

    public RenewTenantOrderResponse renewTenantOrderWithOptions(RenewTenantOrderRequest request, RenewTenantOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            body.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUnionId)) {
            body.put("callerUnionId", request.callerUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTimeGMT)) {
            body.put("endTimeGMT", request.endTimeGMT);
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
        return TeaModel.toModel(this.doROARequest("RenewTenantOrder", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/apps/tenants/reorder", "json", req, runtime), new RenewTenantOrderResponse());
    }

    public SaveFormDataResponse saveFormData(SaveFormDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveFormDataHeaders headers = new SaveFormDataHeaders();
        return this.saveFormDataWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("SaveFormData", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/instances", "json", req, runtime), new SaveFormDataResponse());
    }

    public SaveFormRemarkResponse saveFormRemark(SaveFormRemarkRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveFormRemarkHeaders headers = new SaveFormRemarkHeaders();
        return this.saveFormRemarkWithOptions(request, headers, runtime);
    }

    public SaveFormRemarkResponse saveFormRemarkWithOptions(SaveFormRemarkRequest request, SaveFormRemarkHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.atUserId)) {
            body.put("atUserId", request.atUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formInstanceId)) {
            body.put("formInstanceId", request.formInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.replyId)) {
            body.put("replyId", request.replyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("SaveFormRemark", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/remarks", "json", req, runtime), new SaveFormRemarkResponse());
    }

    public SavePrintTplDetailInfoResponse savePrintTplDetailInfo(SavePrintTplDetailInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SavePrintTplDetailInfoHeaders headers = new SavePrintTplDetailInfoHeaders();
        return this.savePrintTplDetailInfoWithOptions(request, headers, runtime);
    }

    public SavePrintTplDetailInfoResponse savePrintTplDetailInfoWithOptions(SavePrintTplDetailInfoRequest request, SavePrintTplDetailInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileNameConfig)) {
            body.put("fileNameConfig", request.fileNameConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formUuid)) {
            body.put("formUuid", request.formUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formVersion)) {
            body.put("formVersion", request.formVersion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.setting)) {
            body.put("setting", request.setting);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.vm)) {
            body.put("vm", request.vm);
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
        return TeaModel.toModel(this.doROARequest("SavePrintTplDetailInfo", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/printTemplates/printTplDetailInfos", "json", req, runtime), new SavePrintTplDetailInfoResponse());
    }

    public SearchActivationCodeResponse searchActivationCode(SearchActivationCodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchActivationCodeHeaders headers = new SearchActivationCodeHeaders();
        return this.searchActivationCodeWithOptions(request, headers, runtime);
    }

    public SearchActivationCodeResponse searchActivationCodeWithOptions(SearchActivationCodeRequest request, SearchActivationCodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
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
        return TeaModel.toModel(this.doROARequest("SearchActivationCode", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/apps/activationCode/information", "json", req, runtime), new SearchActivationCodeResponse());
    }

    public SearchEmployeeFieldValuesResponse searchEmployeeFieldValues(SearchEmployeeFieldValuesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchEmployeeFieldValuesHeaders headers = new SearchEmployeeFieldValuesHeaders();
        return this.searchEmployeeFieldValuesWithOptions(request, headers, runtime);
    }

    public SearchEmployeeFieldValuesResponse searchEmployeeFieldValuesWithOptions(SearchEmployeeFieldValuesRequest request, SearchEmployeeFieldValuesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.targetFieldJson)) {
            body.put("targetFieldJson", request.targetFieldJson);
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
        return TeaModel.toModel(this.doROARequest("SearchEmployeeFieldValues", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/employeeFields", "json", req, runtime), new SearchEmployeeFieldValuesResponse());
    }

    public SearchFormDataIdListResponse searchFormDataIdList(String appType, String formUuid, SearchFormDataIdListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchFormDataIdListHeaders headers = new SearchFormDataIdListHeaders();
        return this.searchFormDataIdListWithOptions(appType, formUuid, request, headers, runtime);
    }

    public SearchFormDataIdListResponse searchFormDataIdListWithOptions(String appType, String formUuid, SearchFormDataIdListRequest request, SearchFormDataIdListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        appType = com.aliyun.openapiutil.Client.getEncodeParam(appType);
        formUuid = com.aliyun.openapiutil.Client.getEncodeParam(formUuid);
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
        return TeaModel.toModel(this.doROARequest("SearchFormDataIdList", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/instances/ids/" + appType + "/" + formUuid + "", "json", req, runtime), new SearchFormDataIdListResponse());
    }

    public SearchFormDataRemovalTableDataResponse searchFormDataRemovalTableData(SearchFormDataRemovalTableDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchFormDataRemovalTableDataHeaders headers = new SearchFormDataRemovalTableDataHeaders();
        return this.searchFormDataRemovalTableDataWithOptions(request, headers, runtime);
    }

    public SearchFormDataRemovalTableDataResponse searchFormDataRemovalTableDataWithOptions(SearchFormDataRemovalTableDataRequest request, SearchFormDataRemovalTableDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.searchFieldJson)) {
            body.put("searchFieldJson", request.searchFieldJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("SearchFormDataRemovalTableData", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/instances/query", "json", req, runtime), new SearchFormDataRemovalTableDataResponse());
    }

    public SearchFormDataSecondGenerationResponse searchFormDataSecondGeneration(SearchFormDataSecondGenerationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchFormDataSecondGenerationHeaders headers = new SearchFormDataSecondGenerationHeaders();
        return this.searchFormDataSecondGenerationWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("SearchFormDataSecondGeneration", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/instances/advances/queryAll", "json", req, runtime), new SearchFormDataSecondGenerationResponse());
    }

    public SearchFormDataSecondGenerationNoTableFieldResponse searchFormDataSecondGenerationNoTableField(SearchFormDataSecondGenerationNoTableFieldRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchFormDataSecondGenerationNoTableFieldHeaders headers = new SearchFormDataSecondGenerationNoTableFieldHeaders();
        return this.searchFormDataSecondGenerationNoTableFieldWithOptions(request, headers, runtime);
    }

    public SearchFormDataSecondGenerationNoTableFieldResponse searchFormDataSecondGenerationNoTableFieldWithOptions(SearchFormDataSecondGenerationNoTableFieldRequest request, SearchFormDataSecondGenerationNoTableFieldHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("SearchFormDataSecondGenerationNoTableField", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/instances/advances/query", "json", req, runtime), new SearchFormDataSecondGenerationNoTableFieldResponse());
    }

    public SearchFormDatasResponse searchFormDatas(SearchFormDatasRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchFormDatasHeaders headers = new SearchFormDatasHeaders();
        return this.searchFormDatasWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("SearchFormDatas", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/forms/instances/search", "json", req, runtime), new SearchFormDatasResponse());
    }

    public StartInstanceResponse startInstance(StartInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StartInstanceHeaders headers = new StartInstanceHeaders();
        return this.startInstanceWithOptions(request, headers, runtime);
    }

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

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("StartInstance", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/processes/instances/start", "json", req, runtime), new StartInstanceResponse());
    }

    public TerminateCloudAuthorizationResponse terminateCloudAuthorization(TerminateCloudAuthorizationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TerminateCloudAuthorizationHeaders headers = new TerminateCloudAuthorizationHeaders();
        return this.terminateCloudAuthorizationWithOptions(request, headers, runtime);
    }

    public TerminateCloudAuthorizationResponse terminateCloudAuthorizationWithOptions(TerminateCloudAuthorizationRequest request, TerminateCloudAuthorizationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            body.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUnionId)) {
            body.put("callerUnionId", request.callerUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
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
        return TeaModel.toModel(this.doROARequest("TerminateCloudAuthorization", "yida_1.0", "HTTP", "POST", "AK", "/v1.0/yida/apps/cloudAuthorizations/terminate", "json", req, runtime), new TerminateCloudAuthorizationResponse());
    }

    public TerminateInstanceResponse terminateInstance(TerminateInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TerminateInstanceHeaders headers = new TerminateInstanceHeaders();
        return this.terminateInstanceWithOptions(request, headers, runtime);
    }

    public TerminateInstanceResponse terminateInstanceWithOptions(TerminateInstanceRequest request, TerminateInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            query.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            query.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            query.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("TerminateInstance", "yida_1.0", "HTTP", "PUT", "AK", "/v1.0/yida/processes/instances/terminate", "none", req, runtime), new TerminateInstanceResponse());
    }

    public UpdateCloudAccountInformationResponse updateCloudAccountInformation(UpdateCloudAccountInformationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCloudAccountInformationHeaders headers = new UpdateCloudAccountInformationHeaders();
        return this.updateCloudAccountInformationWithOptions(request, headers, runtime);
    }

    public UpdateCloudAccountInformationResponse updateCloudAccountInformationWithOptions(UpdateCloudAccountInformationRequest request, UpdateCloudAccountInformationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            body.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountNumber)) {
            body.put("accountNumber", request.accountNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUnionId)) {
            body.put("callerUnionId", request.callerUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.commodityType)) {
            body.put("commodityType", request.commodityType);
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
        return TeaModel.toModel(this.doROARequest("UpdateCloudAccountInformation", "yida_1.0", "HTTP", "PUT", "AK", "/v1.0/yida/apps/cloudAccountInfos", "json", req, runtime), new UpdateCloudAccountInformationResponse());
    }

    public UpdateFormDataResponse updateFormData(UpdateFormDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateFormDataHeaders headers = new UpdateFormDataHeaders();
        return this.updateFormDataWithOptions(request, headers, runtime);
    }

    public UpdateFormDataResponse updateFormDataWithOptions(UpdateFormDataRequest request, UpdateFormDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formInstanceId)) {
            body.put("formInstanceId", request.formInstanceId);
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
        return TeaModel.toModel(this.doROARequest("UpdateFormData", "yida_1.0", "HTTP", "PUT", "AK", "/v1.0/yida/forms/instances", "none", req, runtime), new UpdateFormDataResponse());
    }

    public UpdateInstanceResponse updateInstance(UpdateInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInstanceHeaders headers = new UpdateInstanceHeaders();
        return this.updateInstanceWithOptions(request, headers, runtime);
    }

    public UpdateInstanceResponse updateInstanceWithOptions(UpdateInstanceRequest request, UpdateInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.updateFormDataJson)) {
            body.put("updateFormDataJson", request.updateFormDataJson);
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
        return TeaModel.toModel(this.doROARequest("UpdateInstance", "yida_1.0", "HTTP", "PUT", "AK", "/v1.0/yida/processes/instances", "none", req, runtime), new UpdateInstanceResponse());
    }

    public UpdateStatusResponse updateStatus(UpdateStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateStatusHeaders headers = new UpdateStatusHeaders();
        return this.updateStatusWithOptions(request, headers, runtime);
    }

    public UpdateStatusResponse updateStatusWithOptions(UpdateStatusRequest request, UpdateStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appType)) {
            body.put("appType", request.appType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.errorLines)) {
            body.put("errorLines", request.errorLines);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.importSequence)) {
            body.put("importSequence", request.importSequence);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemToken)) {
            body.put("systemToken", request.systemToken);
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
        return TeaModel.toModel(this.doROARequest("UpdateStatus", "yida_1.0", "HTTP", "PUT", "AK", "/v1.0/yida/forms/status", "none", req, runtime), new UpdateStatusResponse());
    }

    public UpgradeTenantInformationResponse upgradeTenantInformation(UpgradeTenantInformationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpgradeTenantInformationHeaders headers = new UpgradeTenantInformationHeaders();
        return this.upgradeTenantInformationWithOptions(request, headers, runtime);
    }

    public UpgradeTenantInformationResponse upgradeTenantInformationWithOptions(UpgradeTenantInformationRequest request, UpgradeTenantInformationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            body.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountNumber)) {
            body.put("accountNumber", request.accountNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUnionId)) {
            body.put("callerUnionId", request.callerUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.commodityType)) {
            body.put("commodityType", request.commodityType);
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
        return TeaModel.toModel(this.doROARequest("UpgradeTenantInformation", "yida_1.0", "HTTP", "PUT", "AK", "/v1.0/yida/apps/tenantInfos", "json", req, runtime), new UpgradeTenantInformationResponse());
    }

    public ValidateApplicationAuthorizationOrderResponse validateApplicationAuthorizationOrder(String instanceId, ValidateApplicationAuthorizationOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ValidateApplicationAuthorizationOrderHeaders headers = new ValidateApplicationAuthorizationOrderHeaders();
        return this.validateApplicationAuthorizationOrderWithOptions(instanceId, request, headers, runtime);
    }

    public ValidateApplicationAuthorizationOrderResponse validateApplicationAuthorizationOrderWithOptions(String instanceId, ValidateApplicationAuthorizationOrderRequest request, ValidateApplicationAuthorizationOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        instanceId = com.aliyun.openapiutil.Client.getEncodeParam(instanceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUnionId)) {
            query.put("callerUnionId", request.callerUnionId);
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
        return TeaModel.toModel(this.doROARequest("ValidateApplicationAuthorizationOrder", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/applicationOrderUpdateAuthorizations/" + instanceId + "", "json", req, runtime), new ValidateApplicationAuthorizationOrderResponse());
    }

    public ValidateApplicationAuthorizationServiceOrderResponse validateApplicationAuthorizationServiceOrder(String callerUid, ValidateApplicationAuthorizationServiceOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ValidateApplicationAuthorizationServiceOrderHeaders headers = new ValidateApplicationAuthorizationServiceOrderHeaders();
        return this.validateApplicationAuthorizationServiceOrderWithOptions(callerUid, request, headers, runtime);
    }

    public ValidateApplicationAuthorizationServiceOrderResponse validateApplicationAuthorizationServiceOrderWithOptions(String callerUid, ValidateApplicationAuthorizationServiceOrderRequest request, ValidateApplicationAuthorizationServiceOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        callerUid = com.aliyun.openapiutil.Client.getEncodeParam(callerUid);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
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
        return TeaModel.toModel(this.doROARequest("ValidateApplicationAuthorizationServiceOrder", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/appsAuthorizations/freshOrderInfoReviews/" + callerUid + "", "json", req, runtime), new ValidateApplicationAuthorizationServiceOrderResponse());
    }

    public ValidateApplicationServiceOrderUpgradeResponse validateApplicationServiceOrderUpgrade(String callerUnionid, ValidateApplicationServiceOrderUpgradeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ValidateApplicationServiceOrderUpgradeHeaders headers = new ValidateApplicationServiceOrderUpgradeHeaders();
        return this.validateApplicationServiceOrderUpgradeWithOptions(callerUnionid, request, headers, runtime);
    }

    public ValidateApplicationServiceOrderUpgradeResponse validateApplicationServiceOrderUpgradeWithOptions(String callerUnionid, ValidateApplicationServiceOrderUpgradeRequest request, ValidateApplicationServiceOrderUpgradeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        callerUnionid = com.aliyun.openapiutil.Client.getEncodeParam(callerUnionid);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
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
        return TeaModel.toModel(this.doROARequest("ValidateApplicationServiceOrderUpgrade", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/applications/orderValidations/" + callerUnionid + "", "json", req, runtime), new ValidateApplicationServiceOrderUpgradeResponse());
    }

    public ValidateOrderBuyResponse validateOrderBuy(ValidateOrderBuyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ValidateOrderBuyHeaders headers = new ValidateOrderBuyHeaders();
        return this.validateOrderBuyWithOptions(request, headers, runtime);
    }

    public ValidateOrderBuyResponse validateOrderBuyWithOptions(ValidateOrderBuyRequest request, ValidateOrderBuyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
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
        return TeaModel.toModel(this.doROARequest("ValidateOrderBuy", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/apps/orderBuy/validate", "json", req, runtime), new ValidateOrderBuyResponse());
    }

    public ValidateOrderUpdateResponse validateOrderUpdate(String instanceId, ValidateOrderUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ValidateOrderUpdateHeaders headers = new ValidateOrderUpdateHeaders();
        return this.validateOrderUpdateWithOptions(instanceId, request, headers, runtime);
    }

    public ValidateOrderUpdateResponse validateOrderUpdateWithOptions(String instanceId, ValidateOrderUpdateRequest request, ValidateOrderUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        instanceId = com.aliyun.openapiutil.Client.getEncodeParam(instanceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
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
        return TeaModel.toModel(this.doROARequest("ValidateOrderUpdate", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/orders/renewalReviews/" + instanceId + "", "json", req, runtime), new ValidateOrderUpdateResponse());
    }

    public ValidateOrderUpgradeResponse validateOrderUpgrade(ValidateOrderUpgradeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ValidateOrderUpgradeHeaders headers = new ValidateOrderUpgradeHeaders();
        return this.validateOrderUpgradeWithOptions(request, headers, runtime);
    }

    public ValidateOrderUpgradeResponse validateOrderUpgradeWithOptions(ValidateOrderUpgradeRequest request, ValidateOrderUpgradeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessKey)) {
            query.put("accessKey", request.accessKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerUid)) {
            query.put("callerUid", request.callerUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            query.put("instanceId", request.instanceId);
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
        return TeaModel.toModel(this.doROARequest("ValidateOrderUpgrade", "yida_1.0", "HTTP", "GET", "AK", "/v1.0/yida/apps/orderUpgrade/validate", "json", req, runtime), new ValidateOrderUpgradeResponse());
    }
}
