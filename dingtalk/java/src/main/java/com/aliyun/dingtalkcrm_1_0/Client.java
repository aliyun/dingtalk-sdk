// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcrm_1_0.models.*;
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


    public AbandonCustomerResponse abandonCustomer(AbandonCustomerRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AbandonCustomerHeaders headers = new AbandonCustomerHeaders();
        return this.abandonCustomerWithOptions(request, headers, runtime);
    }

    public AbandonCustomerResponse abandonCustomerWithOptions(AbandonCustomerRequest request, AbandonCustomerHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customTrackDesc)) {
            body.put("customTrackDesc", request.customTrackDesc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceIdList)) {
            body.put("instanceIdList", request.instanceIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optType)) {
            body.put("optType", request.optType);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AbandonCustomer", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/customers/abandon", "json", req, runtime), new AbandonCustomerResponse());
    }

    public AddCrmPersonalCustomerResponse addCrmPersonalCustomer(AddCrmPersonalCustomerRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddCrmPersonalCustomerHeaders headers = new AddCrmPersonalCustomerHeaders();
        return this.addCrmPersonalCustomerWithOptions(request, headers, runtime);
    }

    public AddCrmPersonalCustomerResponse addCrmPersonalCustomerWithOptions(AddCrmPersonalCustomerRequest request, AddCrmPersonalCustomerHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creatorNick)) {
            body.put("creatorNick", request.creatorNick);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creatorUserId)) {
            body.put("creatorUserId", request.creatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.permission))) {
            body.put("permission", request.permission);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            body.put("relationType", request.relationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.skipDuplicateCheck)) {
            body.put("skipDuplicateCheck", request.skipDuplicateCheck);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddCrmPersonalCustomer", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/personalCustomers", "json", req, runtime), new AddCrmPersonalCustomerResponse());
    }

    public AddCustomerTrackResponse addCustomerTrack(AddCustomerTrackRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddCustomerTrackHeaders headers = new AddCustomerTrackHeaders();
        return this.addCustomerTrackWithOptions(request, headers, runtime);
    }

    public AddCustomerTrackResponse addCustomerTrackWithOptions(AddCustomerTrackRequest request, AddCustomerTrackHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customerId)) {
            body.put("customerId", request.customerId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extraBizInfo)) {
            body.put("extraBizInfo", request.extraBizInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.idempotentKey)) {
            body.put("idempotentKey", request.idempotentKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            body.put("relationType", request.relationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddCustomerTrack", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/customerTracks", "json", req, runtime), new AddCustomerTrackResponse());
    }

    public AddRelationMetaFieldResponse addRelationMetaField(AddRelationMetaFieldRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddRelationMetaFieldHeaders headers = new AddRelationMetaFieldHeaders();
        return this.addRelationMetaFieldWithOptions(request, headers, runtime);
    }

    public AddRelationMetaFieldResponse addRelationMetaFieldWithOptions(AddRelationMetaFieldRequest request, AddRelationMetaFieldHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fieldDTOList)) {
            body.put("fieldDTOList", request.fieldDTOList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            body.put("relationType", request.relationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tenant)) {
            body.put("tenant", request.tenant);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddRelationMetaField", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/relations/metas/fields", "json", req, runtime), new AddRelationMetaFieldResponse());
    }

    public BatchAddRelationDatasResponse batchAddRelationDatas(BatchAddRelationDatasRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchAddRelationDatasHeaders headers = new BatchAddRelationDatasHeaders();
        return this.batchAddRelationDatasWithOptions(request, headers, runtime);
    }

    public BatchAddRelationDatasResponse batchAddRelationDatasWithOptions(BatchAddRelationDatasRequest request, BatchAddRelationDatasHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationList)) {
            body.put("relationList", request.relationList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            body.put("relationType", request.relationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.skipDuplicateCheck)) {
            body.put("skipDuplicateCheck", request.skipDuplicateCheck);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchAddRelationDatas", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/relationDatas/batch", "json", req, runtime), new BatchAddRelationDatasResponse());
    }

    public BatchSendOfficialAccountOTOMessageResponse batchSendOfficialAccountOTOMessage(BatchSendOfficialAccountOTOMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchSendOfficialAccountOTOMessageHeaders headers = new BatchSendOfficialAccountOTOMessageHeaders();
        return this.batchSendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
    }

    public BatchSendOfficialAccountOTOMessageResponse batchSendOfficialAccountOTOMessageWithOptions(BatchSendOfficialAccountOTOMessageRequest request, BatchSendOfficialAccountOTOMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            body.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.detail))) {
            body.put("detail", request.detail);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchSendOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/officialAccounts/oToMessages/batchSend", "json", req, runtime), new BatchSendOfficialAccountOTOMessageResponse());
    }

    public BatchUpdateRelationDatasResponse batchUpdateRelationDatas(BatchUpdateRelationDatasRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchUpdateRelationDatasHeaders headers = new BatchUpdateRelationDatasHeaders();
        return this.batchUpdateRelationDatasWithOptions(request, headers, runtime);
    }

    public BatchUpdateRelationDatasResponse batchUpdateRelationDatasWithOptions(BatchUpdateRelationDatasRequest request, BatchUpdateRelationDatasHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationList)) {
            body.put("relationList", request.relationList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            body.put("relationType", request.relationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.skipDuplicateCheck)) {
            body.put("skipDuplicateCheck", request.skipDuplicateCheck);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchUpdateRelationDatas", "crm_1.0", "HTTP", "PUT", "AK", "/v1.0/crm/relationDatas/batch", "json", req, runtime), new BatchUpdateRelationDatasResponse());
    }

    public CreateCustomerResponse createCustomer(CreateCustomerRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateCustomerHeaders headers = new CreateCustomerHeaders();
        return this.createCustomerWithOptions(request, headers, runtime);
    }

    public CreateCustomerResponse createCustomerWithOptions(CreateCustomerRequest request, CreateCustomerHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.contacts)) {
            body.put("contacts", request.contacts);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creatorUserId)) {
            body.put("creatorUserId", request.creatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectType)) {
            body.put("objectType", request.objectType);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.permission))) {
            body.put("permission", request.permission);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.saveOption))) {
            body.put("saveOption", request.saveOption);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateCustomer", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/customers", "json", req, runtime), new CreateCustomerResponse());
    }

    public CreateGroupResponse createGroup(CreateGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateGroupHeaders headers = new CreateGroupHeaders();
        return this.createGroupWithOptions(request, headers, runtime);
    }

    public CreateGroupResponse createGroupWithOptions(CreateGroupRequest request, CreateGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberUserIds)) {
            body.put("memberUserIds", request.memberUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownerUserId)) {
            body.put("ownerUserId", request.ownerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            body.put("relationType", request.relationType);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateGroup", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/groups", "json", req, runtime), new CreateGroupResponse());
    }

    public CreateGroupSetResponse createGroupSet(CreateGroupSetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateGroupSetHeaders headers = new CreateGroupSetHeaders();
        return this.createGroupSetWithOptions(request, headers, runtime);
    }

    public CreateGroupSetResponse createGroupSetWithOptions(CreateGroupSetRequest request, CreateGroupSetHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorUserId)) {
            body.put("creatorUserId", request.creatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerUserIds)) {
            body.put("managerUserIds", request.managerUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberQuota)) {
            body.put("memberQuota", request.memberQuota);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.notice)) {
            body.put("notice", request.notice);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.noticeToped)) {
            body.put("noticeToped", request.noticeToped);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownerUserId)) {
            body.put("ownerUserId", request.ownerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            body.put("relationType", request.relationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateGroupSet", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/groupSets", "json", req, runtime), new CreateGroupSetResponse());
    }

    public CreateRelationMetaResponse createRelationMeta(CreateRelationMetaRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateRelationMetaHeaders headers = new CreateRelationMetaHeaders();
        return this.createRelationMetaWithOptions(request, headers, runtime);
    }

    public CreateRelationMetaResponse createRelationMetaWithOptions(CreateRelationMetaRequest request, CreateRelationMetaHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.relationMetaDTO))) {
            body.put("relationMetaDTO", request.relationMetaDTO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tenant)) {
            body.put("tenant", request.tenant);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateRelationMeta", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/relations/metas/create", "json", req, runtime), new CreateRelationMetaResponse());
    }

    public DeleteCrmFormInstanceResponse deleteCrmFormInstance(String instanceId, DeleteCrmFormInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteCrmFormInstanceHeaders headers = new DeleteCrmFormInstanceHeaders();
        return this.deleteCrmFormInstanceWithOptions(instanceId, request, headers, runtime);
    }

    public DeleteCrmFormInstanceResponse deleteCrmFormInstanceWithOptions(String instanceId, DeleteCrmFormInstanceRequest request, DeleteCrmFormInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        instanceId = com.aliyun.openapiutil.Client.getEncodeParam(instanceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.currentOperatorUserId)) {
            query.put("currentOperatorUserId", request.currentOperatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            query.put("name", request.name);
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
        return TeaModel.toModel(this.doROARequest("DeleteCrmFormInstance", "crm_1.0", "HTTP", "DELETE", "AK", "/v1.0/crm/formInstances/" + instanceId + "", "json", req, runtime), new DeleteCrmFormInstanceResponse());
    }

    public DeleteCrmPersonalCustomerResponse deleteCrmPersonalCustomer(String dataId, DeleteCrmPersonalCustomerRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteCrmPersonalCustomerHeaders headers = new DeleteCrmPersonalCustomerHeaders();
        return this.deleteCrmPersonalCustomerWithOptions(dataId, request, headers, runtime);
    }

    public DeleteCrmPersonalCustomerResponse deleteCrmPersonalCustomerWithOptions(String dataId, DeleteCrmPersonalCustomerRequest request, DeleteCrmPersonalCustomerHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        dataId = com.aliyun.openapiutil.Client.getEncodeParam(dataId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.currentOperatorUserId)) {
            query.put("currentOperatorUserId", request.currentOperatorUserId);
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
        return TeaModel.toModel(this.doROARequest("DeleteCrmPersonalCustomer", "crm_1.0", "HTTP", "DELETE", "AK", "/v1.0/crm/personalCustomers/" + dataId + "", "json", req, runtime), new DeleteCrmPersonalCustomerResponse());
    }

    public DeleteRelationMetaFieldResponse deleteRelationMetaField(DeleteRelationMetaFieldRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteRelationMetaFieldHeaders headers = new DeleteRelationMetaFieldHeaders();
        return this.deleteRelationMetaFieldWithOptions(request, headers, runtime);
    }

    public DeleteRelationMetaFieldResponse deleteRelationMetaFieldWithOptions(DeleteRelationMetaFieldRequest request, DeleteRelationMetaFieldHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fieldIdList)) {
            body.put("fieldIdList", request.fieldIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            body.put("relationType", request.relationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tenant)) {
            body.put("tenant", request.tenant);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteRelationMetaField", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/relations/metas/fields/remove", "json", req, runtime), new DeleteRelationMetaFieldResponse());
    }

    public DescribeCrmPersonalCustomerObjectMetaResponse describeCrmPersonalCustomerObjectMeta() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DescribeCrmPersonalCustomerObjectMetaHeaders headers = new DescribeCrmPersonalCustomerObjectMetaHeaders();
        return this.describeCrmPersonalCustomerObjectMetaWithOptions(headers, runtime);
    }

    public DescribeCrmPersonalCustomerObjectMetaResponse describeCrmPersonalCustomerObjectMetaWithOptions(DescribeCrmPersonalCustomerObjectMetaHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("DescribeCrmPersonalCustomerObjectMeta", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/personalCustomers/objectMeta", "json", req, runtime), new DescribeCrmPersonalCustomerObjectMetaResponse());
    }

    public DescribeRelationMetaResponse describeRelationMeta(DescribeRelationMetaRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DescribeRelationMetaHeaders headers = new DescribeRelationMetaHeaders();
        return this.describeRelationMetaWithOptions(request, headers, runtime);
    }

    public DescribeRelationMetaResponse describeRelationMetaWithOptions(DescribeRelationMetaRequest request, DescribeRelationMetaHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationTypes)) {
            body.put("relationTypes", request.relationTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tenant)) {
            body.put("tenant", request.tenant);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DescribeRelationMeta", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/relations/metas/query", "json", req, runtime), new DescribeRelationMetaResponse());
    }

    public GetCrmGroupChatResponse getCrmGroupChat(String openConversationId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetCrmGroupChatHeaders headers = new GetCrmGroupChatHeaders();
        return this.getCrmGroupChatWithOptions(openConversationId, headers, runtime);
    }

    public GetCrmGroupChatResponse getCrmGroupChatWithOptions(String openConversationId, GetCrmGroupChatHeaders headers, RuntimeOptions runtime) throws Exception {
        openConversationId = com.aliyun.openapiutil.Client.getEncodeParam(openConversationId);
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
        return TeaModel.toModel(this.doROARequest("GetCrmGroupChat", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/crmGroupChats/" + openConversationId + "", "json", req, runtime), new GetCrmGroupChatResponse());
    }

    public GetCrmGroupChatMultiResponse getCrmGroupChatMulti(GetCrmGroupChatMultiRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetCrmGroupChatMultiHeaders headers = new GetCrmGroupChatMultiHeaders();
        return this.getCrmGroupChatMultiWithOptions(request, headers, runtime);
    }

    public GetCrmGroupChatMultiResponse getCrmGroupChatMultiWithOptions(GetCrmGroupChatMultiRequest request, GetCrmGroupChatMultiHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationIds)) {
            body.put("openConversationIds", request.openConversationIds);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetCrmGroupChatMulti", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/crmGroupChats/batchQuery", "json", req, runtime), new GetCrmGroupChatMultiResponse());
    }

    public GetCrmGroupChatSingleResponse getCrmGroupChatSingle(GetCrmGroupChatSingleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetCrmGroupChatSingleHeaders headers = new GetCrmGroupChatSingleHeaders();
        return this.getCrmGroupChatSingleWithOptions(request, headers, runtime);
    }

    public GetCrmGroupChatSingleResponse getCrmGroupChatSingleWithOptions(GetCrmGroupChatSingleRequest request, GetCrmGroupChatSingleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            query.put("openConversationId", request.openConversationId);
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
        return TeaModel.toModel(this.doROARequest("GetCrmGroupChatSingle", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/crmGroupChats/query", "json", req, runtime), new GetCrmGroupChatSingleResponse());
    }

    public GetCrmRolePermissionResponse getCrmRolePermission(GetCrmRolePermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetCrmRolePermissionHeaders headers = new GetCrmRolePermissionHeaders();
        return this.getCrmRolePermissionWithOptions(request, headers, runtime);
    }

    public GetCrmRolePermissionResponse getCrmRolePermissionWithOptions(GetCrmRolePermissionRequest request, GetCrmRolePermissionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            query.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            query.put("formCode", request.formCode);
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
        return TeaModel.toModel(this.doROARequest("GetCrmRolePermission", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/permissions", "json", req, runtime), new GetCrmRolePermissionResponse());
    }

    public GetCustomerTracksByRelationIdResponse getCustomerTracksByRelationId(GetCustomerTracksByRelationIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetCustomerTracksByRelationIdHeaders headers = new GetCustomerTracksByRelationIdHeaders();
        return this.getCustomerTracksByRelationIdWithOptions(request, headers, runtime);
    }

    public GetCustomerTracksByRelationIdResponse getCustomerTracksByRelationIdWithOptions(GetCustomerTracksByRelationIdRequest request, GetCustomerTracksByRelationIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationId)) {
            query.put("relationId", request.relationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.typeGroup)) {
            query.put("typeGroup", request.typeGroup);
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
        return TeaModel.toModel(this.doROARequest("GetCustomerTracksByRelationId", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/customerTracks", "json", req, runtime), new GetCustomerTracksByRelationIdResponse());
    }

    public GetGroupSetResponse getGroupSet(GetGroupSetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetGroupSetHeaders headers = new GetGroupSetHeaders();
        return this.getGroupSetWithOptions(request, headers, runtime);
    }

    public GetGroupSetResponse getGroupSetWithOptions(GetGroupSetRequest request, GetGroupSetHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            query.put("openGroupSetId", request.openGroupSetId);
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
        return TeaModel.toModel(this.doROARequest("GetGroupSet", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/groupSets", "json", req, runtime), new GetGroupSetResponse());
    }

    public GetOfficialAccountContactInfoResponse getOfficialAccountContactInfo(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOfficialAccountContactInfoHeaders headers = new GetOfficialAccountContactInfoHeaders();
        return this.getOfficialAccountContactInfoWithOptions(userId, headers, runtime);
    }

    public GetOfficialAccountContactInfoResponse getOfficialAccountContactInfoWithOptions(String userId, GetOfficialAccountContactInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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
        return TeaModel.toModel(this.doROARequest("GetOfficialAccountContactInfo", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/officialAccounts/contacts/" + userId + "", "json", req, runtime), new GetOfficialAccountContactInfoResponse());
    }

    public GetOfficialAccountContactsResponse getOfficialAccountContacts(GetOfficialAccountContactsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOfficialAccountContactsHeaders headers = new GetOfficialAccountContactsHeaders();
        return this.getOfficialAccountContactsWithOptions(request, headers, runtime);
    }

    public GetOfficialAccountContactsResponse getOfficialAccountContactsWithOptions(GetOfficialAccountContactsRequest request, GetOfficialAccountContactsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetOfficialAccountContacts", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/officialAccounts/contacts", "json", req, runtime), new GetOfficialAccountContactsResponse());
    }

    public GetOfficialAccountOTOMessageResultResponse getOfficialAccountOTOMessageResult(GetOfficialAccountOTOMessageResultRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOfficialAccountOTOMessageResultHeaders headers = new GetOfficialAccountOTOMessageResultHeaders();
        return this.getOfficialAccountOTOMessageResultWithOptions(request, headers, runtime);
    }

    public GetOfficialAccountOTOMessageResultResponse getOfficialAccountOTOMessageResultWithOptions(GetOfficialAccountOTOMessageResultRequest request, GetOfficialAccountOTOMessageResultHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            query.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openPushId)) {
            query.put("openPushId", request.openPushId);
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
        return TeaModel.toModel(this.doROARequest("GetOfficialAccountOTOMessageResult", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/officialAccounts/oToMessages/sendResults", "json", req, runtime), new GetOfficialAccountOTOMessageResultResponse());
    }

    public GetRelationUkSettingResponse getRelationUkSetting(GetRelationUkSettingRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetRelationUkSettingHeaders headers = new GetRelationUkSettingHeaders();
        return this.getRelationUkSettingWithOptions(request, headers, runtime);
    }

    public GetRelationUkSettingResponse getRelationUkSettingWithOptions(GetRelationUkSettingRequest request, GetRelationUkSettingHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            query.put("relationType", request.relationType);
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
        return TeaModel.toModel(this.doROARequest("GetRelationUkSetting", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/relationUkSettings", "json", req, runtime), new GetRelationUkSettingResponse());
    }

    public JoinGroupSetResponse joinGroupSet(JoinGroupSetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        JoinGroupSetHeaders headers = new JoinGroupSetHeaders();
        return this.joinGroupSetWithOptions(request, headers, runtime);
    }

    public JoinGroupSetResponse joinGroupSetWithOptions(JoinGroupSetRequest request, JoinGroupSetHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizDataList)) {
            body.put("bizDataList", request.bizDataList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("JoinGroupSet", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/groupSets/join", "json", req, runtime), new JoinGroupSetResponse());
    }

    public ListCrmPersonalCustomersResponse listCrmPersonalCustomers(ListCrmPersonalCustomersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListCrmPersonalCustomersHeaders headers = new ListCrmPersonalCustomersHeaders();
        return this.listCrmPersonalCustomersWithOptions(request, headers, runtime);
    }

    public ListCrmPersonalCustomersResponse listCrmPersonalCustomersWithOptions(ListCrmPersonalCustomersRequest request, ListCrmPersonalCustomersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.currentOperatorUserId)) {
            query.put("currentOperatorUserId", request.currentOperatorUserId);
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
            new TeaPair("body", request.body)
        ));
        return TeaModel.toModel(this.doROARequest("ListCrmPersonalCustomers", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/personalCustomers/batchQuery", "json", req, runtime), new ListCrmPersonalCustomersResponse());
    }

    public ListGroupSetResponse listGroupSet(ListGroupSetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListGroupSetHeaders headers = new ListGroupSetHeaders();
        return this.listGroupSetWithOptions(request, headers, runtime);
    }

    public ListGroupSetResponse listGroupSetWithOptions(ListGroupSetRequest request, ListGroupSetHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryDsl)) {
            query.put("queryDsl", request.queryDsl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            query.put("relationType", request.relationType);
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
        return TeaModel.toModel(this.doROARequest("ListGroupSet", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/groupSets/lists", "json", req, runtime), new ListGroupSetResponse());
    }

    public QueryAllCustomerResponse queryAllCustomer(QueryAllCustomerRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllCustomerHeaders headers = new QueryAllCustomerHeaders();
        return this.queryAllCustomerWithOptions(request, headers, runtime);
    }

    public QueryAllCustomerResponse queryAllCustomerWithOptions(QueryAllCustomerRequest request, QueryAllCustomerHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectType)) {
            body.put("objectType", request.objectType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("QueryAllCustomer", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/customerInstances", "json", req, runtime), new QueryAllCustomerResponse());
    }

    public QueryAllTracksResponse queryAllTracks(QueryAllTracksRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllTracksHeaders headers = new QueryAllTracksHeaders();
        return this.queryAllTracksWithOptions(request, headers, runtime);
    }

    public QueryAllTracksResponse queryAllTracksWithOptions(QueryAllTracksRequest request, QueryAllTracksHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            query.put("order", request.order);
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
        return TeaModel.toModel(this.doROARequest("QueryAllTracks", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/customers/tracks", "json", req, runtime), new QueryAllTracksResponse());
    }

    public QueryCrmGroupChatsResponse queryCrmGroupChats(QueryCrmGroupChatsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCrmGroupChatsHeaders headers = new QueryCrmGroupChatsHeaders();
        return this.queryCrmGroupChatsWithOptions(request, headers, runtime);
    }

    public QueryCrmGroupChatsResponse queryCrmGroupChatsWithOptions(QueryCrmGroupChatsRequest request, QueryCrmGroupChatsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryDsl)) {
            query.put("queryDsl", request.queryDsl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            query.put("relationType", request.relationType);
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
        return TeaModel.toModel(this.doROARequest("QueryCrmGroupChats", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/crmGroupChats", "json", req, runtime), new QueryCrmGroupChatsResponse());
    }

    public QueryCrmPersonalCustomerResponse queryCrmPersonalCustomer(QueryCrmPersonalCustomerRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCrmPersonalCustomerHeaders headers = new QueryCrmPersonalCustomerHeaders();
        return this.queryCrmPersonalCustomerWithOptions(request, headers, runtime);
    }

    public QueryCrmPersonalCustomerResponse queryCrmPersonalCustomerWithOptions(QueryCrmPersonalCustomerRequest request, QueryCrmPersonalCustomerHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.currentOperatorUserId)) {
            query.put("currentOperatorUserId", request.currentOperatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryDsl)) {
            query.put("queryDsl", request.queryDsl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            query.put("relationType", request.relationType);
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
        return TeaModel.toModel(this.doROARequest("QueryCrmPersonalCustomer", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/personalCustomers", "json", req, runtime), new QueryCrmPersonalCustomerResponse());
    }

    public QueryOfficialAccountUserBasicInfoResponse queryOfficialAccountUserBasicInfo(QueryOfficialAccountUserBasicInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryOfficialAccountUserBasicInfoHeaders headers = new QueryOfficialAccountUserBasicInfoHeaders();
        return this.queryOfficialAccountUserBasicInfoWithOptions(request, headers, runtime);
    }

    public QueryOfficialAccountUserBasicInfoResponse queryOfficialAccountUserBasicInfoWithOptions(QueryOfficialAccountUserBasicInfoRequest request, QueryOfficialAccountUserBasicInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bindingToken)) {
            query.put("bindingToken", request.bindingToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
        return TeaModel.toModel(this.doROARequest("QueryOfficialAccountUserBasicInfo", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/officialAccounts/basics/users", "json", req, runtime), new QueryOfficialAccountUserBasicInfoResponse());
    }

    public QueryRelationDatasByTargetIdResponse queryRelationDatasByTargetId(String targetId, QueryRelationDatasByTargetIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryRelationDatasByTargetIdHeaders headers = new QueryRelationDatasByTargetIdHeaders();
        return this.queryRelationDatasByTargetIdWithOptions(targetId, request, headers, runtime);
    }

    public QueryRelationDatasByTargetIdResponse queryRelationDatasByTargetIdWithOptions(String targetId, QueryRelationDatasByTargetIdRequest request, QueryRelationDatasByTargetIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        targetId = com.aliyun.openapiutil.Client.getEncodeParam(targetId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            query.put("relationType", request.relationType);
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
        return TeaModel.toModel(this.doROARequest("QueryRelationDatasByTargetId", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/relations/datas/targets/" + targetId + "", "json", req, runtime), new QueryRelationDatasByTargetIdResponse());
    }

    public RecallOfficialAccountOTOMessageResponse recallOfficialAccountOTOMessage(RecallOfficialAccountOTOMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RecallOfficialAccountOTOMessageHeaders headers = new RecallOfficialAccountOTOMessageHeaders();
        return this.recallOfficialAccountOTOMessageWithOptions(request, headers, runtime);
    }

    public RecallOfficialAccountOTOMessageResponse recallOfficialAccountOTOMessageWithOptions(RecallOfficialAccountOTOMessageRequest request, RecallOfficialAccountOTOMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            body.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openPushId)) {
            body.put("openPushId", request.openPushId);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RecallOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/officialAccounts/oToMessages/recall", "json", req, runtime), new RecallOfficialAccountOTOMessageResponse());
    }

    public SendOfficialAccountOTOMessageResponse sendOfficialAccountOTOMessage(SendOfficialAccountOTOMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendOfficialAccountOTOMessageHeaders headers = new SendOfficialAccountOTOMessageHeaders();
        return this.sendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
    }

    public SendOfficialAccountOTOMessageResponse sendOfficialAccountOTOMessageWithOptions(SendOfficialAccountOTOMessageRequest request, SendOfficialAccountOTOMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            body.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.detail))) {
            body.put("detail", request.detail);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SendOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/officialAccounts/oToMessages/send", "json", req, runtime), new SendOfficialAccountOTOMessageResponse());
    }

    public SendOfficialAccountSNSMessageResponse sendOfficialAccountSNSMessage(SendOfficialAccountSNSMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendOfficialAccountSNSMessageHeaders headers = new SendOfficialAccountSNSMessageHeaders();
        return this.sendOfficialAccountSNSMessageWithOptions(request, headers, runtime);
    }

    public SendOfficialAccountSNSMessageResponse sendOfficialAccountSNSMessageWithOptions(SendOfficialAccountSNSMessageRequest request, SendOfficialAccountSNSMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bindingToken)) {
            body.put("bindingToken", request.bindingToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.detail))) {
            body.put("detail", request.detail);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SendOfficialAccountSNSMessage", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/officialAccounts/snsMessages/send", "json", req, runtime), new SendOfficialAccountSNSMessageResponse());
    }

    public ServiceWindowMessageBatchPushResponse serviceWindowMessageBatchPush(ServiceWindowMessageBatchPushRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ServiceWindowMessageBatchPushHeaders headers = new ServiceWindowMessageBatchPushHeaders();
        return this.serviceWindowMessageBatchPushWithOptions(request, headers, runtime);
    }

    public ServiceWindowMessageBatchPushResponse serviceWindowMessageBatchPushWithOptions(ServiceWindowMessageBatchPushRequest request, ServiceWindowMessageBatchPushHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.detail))) {
            body.put("detail", request.detail);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ServiceWindowMessageBatchPush", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/messages/batchSend", "json", req, runtime), new ServiceWindowMessageBatchPushResponse());
    }

    public UpdateCrmPersonalCustomerResponse updateCrmPersonalCustomer(UpdateCrmPersonalCustomerRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateCrmPersonalCustomerHeaders headers = new UpdateCrmPersonalCustomerHeaders();
        return this.updateCrmPersonalCustomerWithOptions(request, headers, runtime);
    }

    public UpdateCrmPersonalCustomerResponse updateCrmPersonalCustomerWithOptions(UpdateCrmPersonalCustomerRequest request, UpdateCrmPersonalCustomerHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifierNick)) {
            body.put("modifierNick", request.modifierNick);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifierUserId)) {
            body.put("modifierUserId", request.modifierUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.permission))) {
            body.put("permission", request.permission);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            body.put("relationType", request.relationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.skipDuplicateCheck)) {
            body.put("skipDuplicateCheck", request.skipDuplicateCheck);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateCrmPersonalCustomer", "crm_1.0", "HTTP", "PUT", "AK", "/v1.0/crm/personalCustomers", "json", req, runtime), new UpdateCrmPersonalCustomerResponse());
    }

    public UpdateGroupSetResponse updateGroupSet(UpdateGroupSetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateGroupSetHeaders headers = new UpdateGroupSetHeaders();
        return this.updateGroupSetWithOptions(request, headers, runtime);
    }

    public UpdateGroupSetResponse updateGroupSetWithOptions(UpdateGroupSetRequest request, UpdateGroupSetHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.managerUserIds)) {
            body.put("managerUserIds", request.managerUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberQuota)) {
            body.put("memberQuota", request.memberQuota);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.notice)) {
            body.put("notice", request.notice);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.noticeToped)) {
            body.put("noticeToped", request.noticeToped);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownerUserId)) {
            body.put("ownerUserId", request.ownerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateGroupSet", "crm_1.0", "HTTP", "PUT", "AK", "/v1.0/crm/groupSets/set", "boolean", req, runtime), new UpdateGroupSetResponse());
    }

    public UpdateRelationMetaFieldResponse updateRelationMetaField(UpdateRelationMetaFieldRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateRelationMetaFieldHeaders headers = new UpdateRelationMetaFieldHeaders();
        return this.updateRelationMetaFieldWithOptions(request, headers, runtime);
    }

    public UpdateRelationMetaFieldResponse updateRelationMetaFieldWithOptions(UpdateRelationMetaFieldRequest request, UpdateRelationMetaFieldHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fieldDTOList)) {
            body.put("fieldDTOList", request.fieldDTOList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationType)) {
            body.put("relationType", request.relationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tenant)) {
            body.put("tenant", request.tenant);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateRelationMetaField", "crm_1.0", "HTTP", "PUT", "AK", "/v1.0/crm/relations/metas/fields", "json", req, runtime), new UpdateRelationMetaFieldResponse());
    }
}
