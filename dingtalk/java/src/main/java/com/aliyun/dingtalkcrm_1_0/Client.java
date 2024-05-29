// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcrm_1_0.models.*;

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
     * @summary 从私海放弃客户（退回公海）
     *
     * @param request AbandonCustomerRequest
     * @param headers AbandonCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AbandonCustomerResponse
     */
    public AbandonCustomerResponse abandonCustomerWithOptions(AbandonCustomerRequest request, AbandonCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AbandonCustomer"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/customers/abandon"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AbandonCustomerResponse());
    }

    /**
     * @summary 从私海放弃客户（退回公海）
     *
     * @param request AbandonCustomerRequest
     * @return AbandonCustomerResponse
     */
    public AbandonCustomerResponse abandonCustomer(AbandonCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AbandonCustomerHeaders headers = new AbandonCustomerHeaders();
        return this.abandonCustomerWithOptions(request, headers, runtime);
    }

    /**
     * @summary 添加crm个人客户（或企业客户）
     *
     * @param request AddCrmPersonalCustomerRequest
     * @param headers AddCrmPersonalCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCrmPersonalCustomerResponse
     */
    public AddCrmPersonalCustomerResponse addCrmPersonalCustomerWithOptions(AddCrmPersonalCustomerRequest request, AddCrmPersonalCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.permission)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddCrmPersonalCustomer"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/personalCustomers"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCrmPersonalCustomerResponse());
    }

    /**
     * @summary 添加crm个人客户（或企业客户）
     *
     * @param request AddCrmPersonalCustomerRequest
     * @return AddCrmPersonalCustomerResponse
     */
    public AddCrmPersonalCustomerResponse addCrmPersonalCustomer(AddCrmPersonalCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCrmPersonalCustomerHeaders headers = new AddCrmPersonalCustomerHeaders();
        return this.addCrmPersonalCustomerWithOptions(request, headers, runtime);
    }

    /**
     * @summary 新增动态
     *
     * @param request AddCustomerTrackRequest
     * @param headers AddCustomerTrackHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCustomerTrackResponse
     */
    public AddCustomerTrackResponse addCustomerTrackWithOptions(AddCustomerTrackRequest request, AddCustomerTrackHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.maskedContent)) {
            body.put("maskedContent", request.maskedContent);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddCustomerTrack"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/customerTracks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCustomerTrackResponse());
    }

    /**
     * @summary 新增动态
     *
     * @param request AddCustomerTrackRequest
     * @return AddCustomerTrackResponse
     */
    public AddCustomerTrackResponse addCustomerTrack(AddCustomerTrackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCustomerTrackHeaders headers = new AddCustomerTrackHeaders();
        return this.addCustomerTrackWithOptions(request, headers, runtime);
    }

    /**
     * @summary 添加线索
     *
     * @param request AddLeadsRequest
     * @param headers AddLeadsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddLeadsResponse
     */
    public AddLeadsResponse addLeadsWithOptions(AddLeadsRequest request, AddLeadsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assignTimestamp)) {
            body.put("assignTimestamp", request.assignTimestamp);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.assignUserId)) {
            body.put("assignUserId", request.assignUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.assignedUserId)) {
            body.put("assignedUserId", request.assignedUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leads)) {
            body.put("leads", request.leads);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTaskId)) {
            body.put("outTaskId", request.outTaskId);
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
            new TeaPair("action", "AddLeads"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/leads"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddLeadsResponse());
    }

    /**
     * @summary 添加线索
     *
     * @param request AddLeadsRequest
     * @return AddLeadsResponse
     */
    public AddLeadsResponse addLeads(AddLeadsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddLeadsHeaders headers = new AddLeadsHeaders();
        return this.addLeadsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 关系模型表结构增加字段
     *
     * @param request AddRelationMetaFieldRequest
     * @param headers AddRelationMetaFieldHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddRelationMetaFieldResponse
     */
    public AddRelationMetaFieldResponse addRelationMetaFieldWithOptions(AddRelationMetaFieldRequest request, AddRelationMetaFieldHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddRelationMetaField"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/relations/metas/fields"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddRelationMetaFieldResponse());
    }

    /**
     * @summary 关系模型表结构增加字段
     *
     * @param request AddRelationMetaFieldRequest
     * @return AddRelationMetaFieldResponse
     */
    public AddRelationMetaFieldResponse addRelationMetaField(AddRelationMetaFieldRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddRelationMetaFieldHeaders headers = new AddRelationMetaFieldHeaders();
        return this.addRelationMetaFieldWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量新增联系人
     *
     * @param request BatchAddContactsRequest
     * @param headers BatchAddContactsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchAddContactsResponse
     */
    public BatchAddContactsResponse batchAddContactsWithOptions(BatchAddContactsRequest request, BatchAddContactsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationList)) {
            body.put("relationList", request.relationList);
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
            new TeaPair("action", "BatchAddContacts"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/contacts/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchAddContactsResponse());
    }

    /**
     * @summary 批量新增联系人
     *
     * @param request BatchAddContactsRequest
     * @return BatchAddContactsResponse
     */
    public BatchAddContactsResponse batchAddContacts(BatchAddContactsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchAddContactsHeaders headers = new BatchAddContactsHeaders();
        return this.batchAddContactsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量新增跟进记录
     *
     * @param request BatchAddFollowRecordsRequest
     * @param headers BatchAddFollowRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchAddFollowRecordsResponse
     */
    public BatchAddFollowRecordsResponse batchAddFollowRecordsWithOptions(BatchAddFollowRecordsRequest request, BatchAddFollowRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instanceList)) {
            body.put("instanceList", request.instanceList);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchAddFollowRecords"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/followRecords/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchAddFollowRecordsResponse());
    }

    /**
     * @summary 批量新增跟进记录
     *
     * @param request BatchAddFollowRecordsRequest
     * @return BatchAddFollowRecordsResponse
     */
    public BatchAddFollowRecordsResponse batchAddFollowRecords(BatchAddFollowRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchAddFollowRecordsHeaders headers = new BatchAddFollowRecordsHeaders();
        return this.batchAddFollowRecordsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量新增关系数据
     *
     * @param request BatchAddRelationDatasRequest
     * @param headers BatchAddRelationDatasHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchAddRelationDatasResponse
     */
    public BatchAddRelationDatasResponse batchAddRelationDatasWithOptions(BatchAddRelationDatasRequest request, BatchAddRelationDatasHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchAddRelationDatas"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/relationDatas/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchAddRelationDatasResponse());
    }

    /**
     * @summary 批量新增关系数据
     *
     * @param request BatchAddRelationDatasRequest
     * @return BatchAddRelationDatasResponse
     */
    public BatchAddRelationDatasResponse batchAddRelationDatas(BatchAddRelationDatasRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchAddRelationDatasHeaders headers = new BatchAddRelationDatasHeaders();
        return this.batchAddRelationDatasWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量创建线索数据
     *
     * @param request BatchCreateClueDataRequest
     * @param headers BatchCreateClueDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchCreateClueDataResponse
     */
    public BatchCreateClueDataResponse batchCreateClueDataWithOptions(BatchCreateClueDataRequest request, BatchCreateClueDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dataList)) {
            body.put("dataList", request.dataList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateSeas)) {
            body.put("privateSeas", request.privateSeas);
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
            new TeaPair("action", "BatchCreateClueData"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/clues/datas/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchCreateClueDataResponse());
    }

    /**
     * @summary 批量创建线索数据
     *
     * @param request BatchCreateClueDataRequest
     * @return BatchCreateClueDataResponse
     */
    public BatchCreateClueDataResponse batchCreateClueData(BatchCreateClueDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchCreateClueDataHeaders headers = new BatchCreateClueDataHeaders();
        return this.batchCreateClueDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量删除跟进记录
     *
     * @param request BatchRemoveFollowRecordsRequest
     * @param headers BatchRemoveFollowRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchRemoveFollowRecordsResponse
     */
    public BatchRemoveFollowRecordsResponse batchRemoveFollowRecordsWithOptions(BatchRemoveFollowRecordsRequest request, BatchRemoveFollowRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instanceIds)) {
            body.put("instanceIds", request.instanceIds);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchRemoveFollowRecords"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/followRecords/batchRemove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchRemoveFollowRecordsResponse());
    }

    /**
     * @summary 批量删除跟进记录
     *
     * @param request BatchRemoveFollowRecordsRequest
     * @return BatchRemoveFollowRecordsResponse
     */
    public BatchRemoveFollowRecordsResponse batchRemoveFollowRecords(BatchRemoveFollowRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchRemoveFollowRecordsHeaders headers = new BatchRemoveFollowRecordsHeaders();
        return this.batchRemoveFollowRecordsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务窗消息群发
     *
     * @param request BatchSendOfficialAccountOTOMessageRequest
     * @param headers BatchSendOfficialAccountOTOMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchSendOfficialAccountOTOMessageResponse
     */
    public BatchSendOfficialAccountOTOMessageResponse batchSendOfficialAccountOTOMessageWithOptions(BatchSendOfficialAccountOTOMessageRequest request, BatchSendOfficialAccountOTOMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            body.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.detail)) {
            body.put("detail", request.detail);
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
            new TeaPair("action", "BatchSendOfficialAccountOTOMessage"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/officialAccounts/oToMessages/batchSend"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchSendOfficialAccountOTOMessageResponse());
    }

    /**
     * @summary 服务窗消息群发
     *
     * @param request BatchSendOfficialAccountOTOMessageRequest
     * @return BatchSendOfficialAccountOTOMessageResponse
     */
    public BatchSendOfficialAccountOTOMessageResponse batchSendOfficialAccountOTOMessage(BatchSendOfficialAccountOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchSendOfficialAccountOTOMessageHeaders headers = new BatchSendOfficialAccountOTOMessageHeaders();
        return this.batchSendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量修改联系人
     *
     * @param request BatchUpdateContactsRequest
     * @param headers BatchUpdateContactsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchUpdateContactsResponse
     */
    public BatchUpdateContactsResponse batchUpdateContactsWithOptions(BatchUpdateContactsRequest request, BatchUpdateContactsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationList)) {
            body.put("relationList", request.relationList);
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
            new TeaPair("action", "BatchUpdateContacts"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/contacts/batch"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchUpdateContactsResponse());
    }

    /**
     * @summary 批量修改联系人
     *
     * @param request BatchUpdateContactsRequest
     * @return BatchUpdateContactsResponse
     */
    public BatchUpdateContactsResponse batchUpdateContacts(BatchUpdateContactsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchUpdateContactsHeaders headers = new BatchUpdateContactsHeaders();
        return this.batchUpdateContactsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量修改跟进记录
     *
     * @param request BatchUpdateFollowRecordsRequest
     * @param headers BatchUpdateFollowRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchUpdateFollowRecordsResponse
     */
    public BatchUpdateFollowRecordsResponse batchUpdateFollowRecordsWithOptions(BatchUpdateFollowRecordsRequest request, BatchUpdateFollowRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instanceList)) {
            body.put("instanceList", request.instanceList);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchUpdateFollowRecords"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/followRecords/batch"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchUpdateFollowRecordsResponse());
    }

    /**
     * @summary 批量修改跟进记录
     *
     * @param request BatchUpdateFollowRecordsRequest
     * @return BatchUpdateFollowRecordsResponse
     */
    public BatchUpdateFollowRecordsResponse batchUpdateFollowRecords(BatchUpdateFollowRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchUpdateFollowRecordsHeaders headers = new BatchUpdateFollowRecordsHeaders();
        return this.batchUpdateFollowRecordsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量修改关系数据
     *
     * @param request BatchUpdateRelationDatasRequest
     * @param headers BatchUpdateRelationDatasHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchUpdateRelationDatasResponse
     */
    public BatchUpdateRelationDatasResponse batchUpdateRelationDatasWithOptions(BatchUpdateRelationDatasRequest request, BatchUpdateRelationDatasHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchUpdateRelationDatas"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/relationDatas/batch"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchUpdateRelationDatasResponse());
    }

    /**
     * @summary 批量修改关系数据
     *
     * @param request BatchUpdateRelationDatasRequest
     * @return BatchUpdateRelationDatasResponse
     */
    public BatchUpdateRelationDatasResponse batchUpdateRelationDatas(BatchUpdateRelationDatasRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchUpdateRelationDatasHeaders headers = new BatchUpdateRelationDatasHeaders();
        return this.batchUpdateRelationDatasWithOptions(request, headers, runtime);
    }

    /**
     * @summary CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
     *
     * @param request CreateCustomerRequest
     * @param headers CreateCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCustomerResponse
     */
    public CreateCustomerResponse createCustomerWithOptions(CreateCustomerRequest request, CreateCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.permission)) {
            body.put("permission", request.permission);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.saveOption)) {
            body.put("saveOption", request.saveOption);
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
            new TeaPair("action", "CreateCustomer"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/customers"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCustomerResponse());
    }

    /**
     * @summary CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
     *
     * @param request CreateCustomerRequest
     * @return CreateCustomerResponse
     */
    public CreateCustomerResponse createCustomer(CreateCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCustomerHeaders headers = new CreateCustomerHeaders();
        return this.createCustomerWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建客户群
     *
     * @param request CreateGroupRequest
     * @param headers CreateGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateGroupResponse
     */
    public CreateGroupResponse createGroupWithOptions(CreateGroupRequest request, CreateGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateGroup"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/groups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateGroupResponse());
    }

    /**
     * @summary 创建客户群
     *
     * @param request CreateGroupRequest
     * @return CreateGroupResponse
     */
    public CreateGroupResponse createGroup(CreateGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateGroupHeaders headers = new CreateGroupHeaders();
        return this.createGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建群组
     *
     * @param request CreateGroupSetRequest
     * @param headers CreateGroupSetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateGroupSetResponse
     */
    public CreateGroupSetResponse createGroupSetWithOptions(CreateGroupSetRequest request, CreateGroupSetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.welcome)) {
            body.put("welcome", request.welcome);
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
            new TeaPair("action", "CreateGroupSet"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/groupSets"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateGroupSetResponse());
    }

    /**
     * @summary 创建群组
     *
     * @param request CreateGroupSetRequest
     * @return CreateGroupSetResponse
     */
    public CreateGroupSetResponse createGroupSet(CreateGroupSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateGroupSetHeaders headers = new CreateGroupSetHeaders();
        return this.createGroupSetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建关系模型表结构
     *
     * @param request CreateRelationMetaRequest
     * @param headers CreateRelationMetaHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateRelationMetaResponse
     */
    public CreateRelationMetaResponse createRelationMetaWithOptions(CreateRelationMetaRequest request, CreateRelationMetaHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationMetaDTO)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateRelationMeta"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/relations/metas/create"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateRelationMetaResponse());
    }

    /**
     * @summary 创建关系模型表结构
     *
     * @param request CreateRelationMetaRequest
     * @return CreateRelationMetaResponse
     */
    public CreateRelationMetaResponse createRelationMeta(CreateRelationMetaRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateRelationMetaHeaders headers = new CreateRelationMetaHeaders();
        return this.createRelationMetaWithOptions(request, headers, runtime);
    }

    /**
     * @summary 删除CRM自定义对象数据
     *
     * @param request DeleteCrmCustomObjectDataRequest
     * @param headers DeleteCrmCustomObjectDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteCrmCustomObjectDataResponse
     */
    public DeleteCrmCustomObjectDataResponse deleteCrmCustomObjectDataWithOptions(String instanceId, DeleteCrmCustomObjectDataRequest request, DeleteCrmCustomObjectDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteCrmCustomObjectData"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/customObjectDatas/instances/" + instanceId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteCrmCustomObjectDataResponse());
    }

    /**
     * @summary 删除CRM自定义对象数据
     *
     * @param request DeleteCrmCustomObjectDataRequest
     * @return DeleteCrmCustomObjectDataResponse
     */
    public DeleteCrmCustomObjectDataResponse deleteCrmCustomObjectData(String instanceId, DeleteCrmCustomObjectDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteCrmCustomObjectDataHeaders headers = new DeleteCrmCustomObjectDataHeaders();
        return this.deleteCrmCustomObjectDataWithOptions(instanceId, request, headers, runtime);
    }

    /**
     * @summary crm自定义表单数据删除接口
     *
     * @param request DeleteCrmFormInstanceRequest
     * @param headers DeleteCrmFormInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteCrmFormInstanceResponse
     */
    public DeleteCrmFormInstanceResponse deleteCrmFormInstanceWithOptions(String instanceId, DeleteCrmFormInstanceRequest request, DeleteCrmFormInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteCrmFormInstance"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/formInstances/" + instanceId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteCrmFormInstanceResponse());
    }

    /**
     * @summary crm自定义表单数据删除接口
     *
     * @param request DeleteCrmFormInstanceRequest
     * @return DeleteCrmFormInstanceResponse
     */
    public DeleteCrmFormInstanceResponse deleteCrmFormInstance(String instanceId, DeleteCrmFormInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteCrmFormInstanceHeaders headers = new DeleteCrmFormInstanceHeaders();
        return this.deleteCrmFormInstanceWithOptions(instanceId, request, headers, runtime);
    }

    /**
     * @summary 删除crm个人客户（或企业客户）
     *
     * @param request DeleteCrmPersonalCustomerRequest
     * @param headers DeleteCrmPersonalCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteCrmPersonalCustomerResponse
     */
    public DeleteCrmPersonalCustomerResponse deleteCrmPersonalCustomerWithOptions(String dataId, DeleteCrmPersonalCustomerRequest request, DeleteCrmPersonalCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.currentOperatorUserId)) {
            query.put("currentOperatorUserId", request.currentOperatorUserId);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteCrmPersonalCustomer"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/personalCustomers/" + dataId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteCrmPersonalCustomerResponse());
    }

    /**
     * @summary 删除crm个人客户（或企业客户）
     *
     * @param request DeleteCrmPersonalCustomerRequest
     * @return DeleteCrmPersonalCustomerResponse
     */
    public DeleteCrmPersonalCustomerResponse deleteCrmPersonalCustomer(String dataId, DeleteCrmPersonalCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteCrmPersonalCustomerHeaders headers = new DeleteCrmPersonalCustomerHeaders();
        return this.deleteCrmPersonalCustomerWithOptions(dataId, request, headers, runtime);
    }

    /**
     * @summary 删除线索
     *
     * @param request DeleteLeadsRequest
     * @param headers DeleteLeadsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteLeadsResponse
     */
    public DeleteLeadsResponse deleteLeadsWithOptions(DeleteLeadsRequest request, DeleteLeadsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.outLeadsIds)) {
            body.put("outLeadsIds", request.outLeadsIds);
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
            new TeaPair("action", "DeleteLeads"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/leads/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteLeadsResponse());
    }

    /**
     * @summary 删除线索
     *
     * @param request DeleteLeadsRequest
     * @return DeleteLeadsResponse
     */
    public DeleteLeadsResponse deleteLeads(DeleteLeadsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteLeadsHeaders headers = new DeleteLeadsHeaders();
        return this.deleteLeadsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 关系模型表结构删除字段
     *
     * @param request DeleteRelationMetaFieldRequest
     * @param headers DeleteRelationMetaFieldHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteRelationMetaFieldResponse
     */
    public DeleteRelationMetaFieldResponse deleteRelationMetaFieldWithOptions(DeleteRelationMetaFieldRequest request, DeleteRelationMetaFieldHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteRelationMetaField"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/relations/metas/fields/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteRelationMetaFieldResponse());
    }

    /**
     * @summary 关系模型表结构删除字段
     *
     * @param request DeleteRelationMetaFieldRequest
     * @return DeleteRelationMetaFieldResponse
     */
    public DeleteRelationMetaFieldResponse deleteRelationMetaField(DeleteRelationMetaFieldRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteRelationMetaFieldHeaders headers = new DeleteRelationMetaFieldHeaders();
        return this.deleteRelationMetaFieldWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取CRM客户对象的元数据描述
     *
     * @param request DescribeCrmPersonalCustomerObjectMetaRequest
     * @param headers DescribeCrmPersonalCustomerObjectMetaHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DescribeCrmPersonalCustomerObjectMetaResponse
     */
    public DescribeCrmPersonalCustomerObjectMetaResponse describeCrmPersonalCustomerObjectMetaWithOptions(DescribeCrmPersonalCustomerObjectMetaRequest request, DescribeCrmPersonalCustomerObjectMetaHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DescribeCrmPersonalCustomerObjectMeta"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/personalCustomers/objectMeta"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DescribeCrmPersonalCustomerObjectMetaResponse());
    }

    /**
     * @summary 获取CRM客户对象的元数据描述
     *
     * @param request DescribeCrmPersonalCustomerObjectMetaRequest
     * @return DescribeCrmPersonalCustomerObjectMetaResponse
     */
    public DescribeCrmPersonalCustomerObjectMetaResponse describeCrmPersonalCustomerObjectMeta(DescribeCrmPersonalCustomerObjectMetaRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DescribeCrmPersonalCustomerObjectMetaHeaders headers = new DescribeCrmPersonalCustomerObjectMetaHeaders();
        return this.describeCrmPersonalCustomerObjectMetaWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询关系模型表结构
     *
     * @param request DescribeRelationMetaRequest
     * @param headers DescribeRelationMetaHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DescribeRelationMetaResponse
     */
    public DescribeRelationMetaResponse describeRelationMetaWithOptions(DescribeRelationMetaRequest request, DescribeRelationMetaHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DescribeRelationMeta"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/relations/metas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DescribeRelationMetaResponse());
    }

    /**
     * @summary 查询关系模型表结构
     *
     * @param request DescribeRelationMetaRequest
     * @return DescribeRelationMetaResponse
     */
    public DescribeRelationMetaResponse describeRelationMeta(DescribeRelationMetaRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DescribeRelationMetaHeaders headers = new DescribeRelationMetaHeaders();
        return this.describeRelationMetaWithOptions(request, headers, runtime);
    }

    /**
     * @summary 分页获取关联对象的跟进记录列表
     *
     * @param request FindTargetRelatedFollowRecordsRequest
     * @param headers FindTargetRelatedFollowRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FindTargetRelatedFollowRecordsResponse
     */
    public FindTargetRelatedFollowRecordsResponse findTargetRelatedFollowRecordsWithOptions(FindTargetRelatedFollowRecordsRequest request, FindTargetRelatedFollowRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.followTargetDataId)) {
            body.put("followTargetDataId", request.followTargetDataId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.followTargetType)) {
            body.put("followTargetType", request.followTargetType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
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
            new TeaPair("action", "FindTargetRelatedFollowRecords"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/targetFollowRecords/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FindTargetRelatedFollowRecordsResponse());
    }

    /**
     * @summary 分页获取关联对象的跟进记录列表
     *
     * @param request FindTargetRelatedFollowRecordsRequest
     * @return FindTargetRelatedFollowRecordsResponse
     */
    public FindTargetRelatedFollowRecordsResponse findTargetRelatedFollowRecords(FindTargetRelatedFollowRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FindTargetRelatedFollowRecordsHeaders headers = new FindTargetRelatedFollowRecordsHeaders();
        return this.findTargetRelatedFollowRecordsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 分页获取所有客户的掉保时间数据
     *
     * @param request GetAllCustomerRecyclesRequest
     * @param headers GetAllCustomerRecyclesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAllCustomerRecyclesResponse
     */
    public GetAllCustomerRecyclesResponse getAllCustomerRecyclesWithOptions(GetAllCustomerRecyclesRequest request, GetAllCustomerRecyclesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetAllCustomerRecycles"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/customerRecycles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAllCustomerRecyclesResponse());
    }

    /**
     * @summary 分页获取所有客户的掉保时间数据
     *
     * @param request GetAllCustomerRecyclesRequest
     * @return GetAllCustomerRecyclesResponse
     */
    public GetAllCustomerRecyclesResponse getAllCustomerRecycles(GetAllCustomerRecyclesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAllCustomerRecyclesHeaders headers = new GetAllCustomerRecyclesHeaders();
        return this.getAllCustomerRecyclesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据指定条件查询联系人数据
     *
     * @param request GetContactsRequest
     * @param headers GetContactsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetContactsResponse
     */
    public GetContactsResponse getContactsWithOptions(GetContactsRequest request, GetContactsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.currentOperatorUserId)) {
            body.put("currentOperatorUserId", request.currentOperatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectType)) {
            body.put("objectType", request.objectType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.providerCorpId)) {
            body.put("providerCorpId", request.providerCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryDsl)) {
            body.put("queryDsl", request.queryDsl);
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
            new TeaPair("action", "GetContacts"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/customObjects/contacts/datas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetContactsResponse());
    }

    /**
     * @summary 根据指定条件查询联系人数据
     *
     * @param request GetContactsRequest
     * @return GetContactsResponse
     */
    public GetContactsResponse getContacts(GetContactsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetContactsHeaders headers = new GetContactsHeaders();
        return this.getContactsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取单个客户群
     *
     * @param headers GetCrmGroupChatHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCrmGroupChatResponse
     */
    public GetCrmGroupChatResponse getCrmGroupChatWithOptions(String openConversationId, GetCrmGroupChatHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetCrmGroupChat"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/crmGroupChats/" + openConversationId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCrmGroupChatResponse());
    }

    /**
     * @summary 获取单个客户群
     *
     * @return GetCrmGroupChatResponse
     */
    public GetCrmGroupChatResponse getCrmGroupChat(String openConversationId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCrmGroupChatHeaders headers = new GetCrmGroupChatHeaders();
        return this.getCrmGroupChatWithOptions(openConversationId, headers, runtime);
    }

    /**
     * @summary 批量获取多个客户群
     *
     * @param request GetCrmGroupChatMultiRequest
     * @param headers GetCrmGroupChatMultiHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCrmGroupChatMultiResponse
     */
    public GetCrmGroupChatMultiResponse getCrmGroupChatMultiWithOptions(GetCrmGroupChatMultiRequest request, GetCrmGroupChatMultiHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetCrmGroupChatMulti"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/crmGroupChats/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCrmGroupChatMultiResponse());
    }

    /**
     * @summary 批量获取多个客户群
     *
     * @param request GetCrmGroupChatMultiRequest
     * @return GetCrmGroupChatMultiResponse
     */
    public GetCrmGroupChatMultiResponse getCrmGroupChatMulti(GetCrmGroupChatMultiRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCrmGroupChatMultiHeaders headers = new GetCrmGroupChatMultiHeaders();
        return this.getCrmGroupChatMultiWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取单个客户群
     *
     * @param request GetCrmGroupChatSingleRequest
     * @param headers GetCrmGroupChatSingleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCrmGroupChatSingleResponse
     */
    public GetCrmGroupChatSingleResponse getCrmGroupChatSingleWithOptions(GetCrmGroupChatSingleRequest request, GetCrmGroupChatSingleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetCrmGroupChatSingle"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/crmGroupChats/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCrmGroupChatSingleResponse());
    }

    /**
     * @summary 获取单个客户群
     *
     * @param request GetCrmGroupChatSingleRequest
     * @return GetCrmGroupChatSingleResponse
     */
    public GetCrmGroupChatSingleResponse getCrmGroupChatSingle(GetCrmGroupChatSingleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCrmGroupChatSingleHeaders headers = new GetCrmGroupChatSingleHeaders();
        return this.getCrmGroupChatSingleWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取CRM表单权限配置
     *
     * @param request GetCrmRolePermissionRequest
     * @param headers GetCrmRolePermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCrmRolePermissionResponse
     */
    public GetCrmRolePermissionResponse getCrmRolePermissionWithOptions(GetCrmRolePermissionRequest request, GetCrmRolePermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            query.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resourceId)) {
            query.put("resourceId", request.resourceId);
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
            new TeaPair("action", "GetCrmRolePermission"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/permissions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCrmRolePermissionResponse());
    }

    /**
     * @summary 获取CRM表单权限配置
     *
     * @param request GetCrmRolePermissionRequest
     * @return GetCrmRolePermissionResponse
     */
    public GetCrmRolePermissionResponse getCrmRolePermission(GetCrmRolePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCrmRolePermissionHeaders headers = new GetCrmRolePermissionHeaders();
        return this.getCrmRolePermissionWithOptions(request, headers, runtime);
    }

    /**
     * @summary 分页获取某个客户的客户动态
     *
     * @param request GetCustomerTracksByRelationIdRequest
     * @param headers GetCustomerTracksByRelationIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCustomerTracksByRelationIdResponse
     */
    public GetCustomerTracksByRelationIdResponse getCustomerTracksByRelationIdWithOptions(GetCustomerTracksByRelationIdRequest request, GetCustomerTracksByRelationIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetCustomerTracksByRelationId"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/customerTracks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCustomerTracksByRelationIdResponse());
    }

    /**
     * @summary 分页获取某个客户的客户动态
     *
     * @param request GetCustomerTracksByRelationIdRequest
     * @return GetCustomerTracksByRelationIdResponse
     */
    public GetCustomerTracksByRelationIdResponse getCustomerTracksByRelationId(GetCustomerTracksByRelationIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCustomerTracksByRelationIdHeaders headers = new GetCustomerTracksByRelationIdHeaders();
        return this.getCustomerTracksByRelationIdWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询群组
     *
     * @param request GetGroupSetRequest
     * @param headers GetGroupSetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetGroupSetResponse
     */
    public GetGroupSetResponse getGroupSetWithOptions(GetGroupSetRequest request, GetGroupSetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetGroupSet"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/groupSets"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetGroupSetResponse());
    }

    /**
     * @summary 查询群组
     *
     * @param request GetGroupSetRequest
     * @return GetGroupSetResponse
     */
    public GetGroupSetResponse getGroupSet(GetGroupSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetGroupSetHeaders headers = new GetGroupSetHeaders();
        return this.getGroupSetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取自定义导航挂靠节点结构
     *
     * @param request GetNavigationCatalogRequest
     * @param headers GetNavigationCatalogHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetNavigationCatalogResponse
     */
    public GetNavigationCatalogResponse getNavigationCatalogWithOptions(GetNavigationCatalogRequest request, GetNavigationCatalogHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizTraceId)) {
            query.put("bizTraceId", request.bizTraceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.module)) {
            query.put("module", request.module);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            query.put("operatorUserId", request.operatorUserId);
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
            new TeaPair("action", "GetNavigationCatalog"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/navigations/catalogs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetNavigationCatalogResponse());
    }

    /**
     * @summary 获取自定义导航挂靠节点结构
     *
     * @param request GetNavigationCatalogRequest
     * @return GetNavigationCatalogResponse
     */
    public GetNavigationCatalogResponse getNavigationCatalog(GetNavigationCatalogRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetNavigationCatalogHeaders headers = new GetNavigationCatalogHeaders();
        return this.getNavigationCatalogWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据指定条件查询自定义对象数据
     *
     * @param request GetObjectDataRequest
     * @param headers GetObjectDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetObjectDataResponse
     */
    public GetObjectDataResponse getObjectDataWithOptions(GetObjectDataRequest request, GetObjectDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.currentOperatorUserId)) {
            body.put("currentOperatorUserId", request.currentOperatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryDsl)) {
            body.put("queryDsl", request.queryDsl);
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
            new TeaPair("action", "GetObjectData"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/customObjects/datas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetObjectDataResponse());
    }

    /**
     * @summary 根据指定条件查询自定义对象数据
     *
     * @param request GetObjectDataRequest
     * @return GetObjectDataResponse
     */
    public GetObjectDataResponse getObjectData(GetObjectDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetObjectDataHeaders headers = new GetObjectDataHeaders();
        return this.getObjectDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
     *
     * @param headers GetOfficialAccountContactInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOfficialAccountContactInfoResponse
     */
    public GetOfficialAccountContactInfoResponse getOfficialAccountContactInfoWithOptions(String userId, GetOfficialAccountContactInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetOfficialAccountContactInfo"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/officialAccounts/contacts/" + userId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOfficialAccountContactInfoResponse());
    }

    /**
     * @summary 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
     *
     * @return GetOfficialAccountContactInfoResponse
     */
    public GetOfficialAccountContactInfoResponse getOfficialAccountContactInfo(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOfficialAccountContactInfoHeaders headers = new GetOfficialAccountContactInfoHeaders();
        return this.getOfficialAccountContactInfoWithOptions(userId, headers, runtime);
    }

    /**
     * @summary 分页获取服务窗联系人信息
     *
     * @param request GetOfficialAccountContactsRequest
     * @param headers GetOfficialAccountContactsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOfficialAccountContactsResponse
     */
    public GetOfficialAccountContactsResponse getOfficialAccountContactsWithOptions(GetOfficialAccountContactsRequest request, GetOfficialAccountContactsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetOfficialAccountContacts"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/officialAccounts/contacts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOfficialAccountContactsResponse());
    }

    /**
     * @summary 分页获取服务窗联系人信息
     *
     * @param request GetOfficialAccountContactsRequest
     * @return GetOfficialAccountContactsResponse
     */
    public GetOfficialAccountContactsResponse getOfficialAccountContacts(GetOfficialAccountContactsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOfficialAccountContactsHeaders headers = new GetOfficialAccountContactsHeaders();
        return this.getOfficialAccountContactsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取服务窗消息发送的结果
     *
     * @param request GetOfficialAccountOTOMessageResultRequest
     * @param headers GetOfficialAccountOTOMessageResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOfficialAccountOTOMessageResultResponse
     */
    public GetOfficialAccountOTOMessageResultResponse getOfficialAccountOTOMessageResultWithOptions(GetOfficialAccountOTOMessageResultRequest request, GetOfficialAccountOTOMessageResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetOfficialAccountOTOMessageResult"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/officialAccounts/oToMessages/sendResults"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOfficialAccountOTOMessageResultResponse());
    }

    /**
     * @summary 获取服务窗消息发送的结果
     *
     * @param request GetOfficialAccountOTOMessageResultRequest
     * @return GetOfficialAccountOTOMessageResultResponse
     */
    public GetOfficialAccountOTOMessageResultResponse getOfficialAccountOTOMessageResult(GetOfficialAccountOTOMessageResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOfficialAccountOTOMessageResultHeaders headers = new GetOfficialAccountOTOMessageResultHeaders();
        return this.getOfficialAccountOTOMessageResultWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取关系数据查重规则
     *
     * @param request GetRelationUkSettingRequest
     * @param headers GetRelationUkSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRelationUkSettingResponse
     */
    public GetRelationUkSettingResponse getRelationUkSettingWithOptions(GetRelationUkSettingRequest request, GetRelationUkSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetRelationUkSetting"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/relationUkSettings"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRelationUkSettingResponse());
    }

    /**
     * @summary 获取关系数据查重规则
     *
     * @param request GetRelationUkSettingRequest
     * @return GetRelationUkSettingResponse
     */
    public GetRelationUkSettingResponse getRelationUkSetting(GetRelationUkSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRelationUkSettingHeaders headers = new GetRelationUkSettingHeaders();
        return this.getRelationUkSettingWithOptions(request, headers, runtime);
    }

    /**
     * @summary 加入群组
     *
     * @param request JoinGroupSetRequest
     * @param headers JoinGroupSetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return JoinGroupSetResponse
     */
    public JoinGroupSetResponse joinGroupSetWithOptions(JoinGroupSetRequest request, JoinGroupSetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "JoinGroupSet"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/groupSets/join"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new JoinGroupSetResponse());
    }

    /**
     * @summary 加入群组
     *
     * @param request JoinGroupSetRequest
     * @return JoinGroupSetResponse
     */
    public JoinGroupSetResponse joinGroupSet(JoinGroupSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        JoinGroupSetHeaders headers = new JoinGroupSetHeaders();
        return this.joinGroupSetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取线索标签列表
     *
     * @param headers ListClueTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListClueTagResponse
     */
    public ListClueTagResponse listClueTagWithOptions(ListClueTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListClueTag"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/clues/tags"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListClueTagResponse());
    }

    /**
     * @summary 获取线索标签列表
     *
     * @return ListClueTagResponse
     */
    public ListClueTagResponse listClueTag() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListClueTagHeaders headers = new ListClueTagHeaders();
        return this.listClueTagWithOptions(headers, runtime);
    }

    /**
     * @summary 批量获取crm个人客户
     *
     * @param request ListCrmPersonalCustomersRequest
     * @param headers ListCrmPersonalCustomersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListCrmPersonalCustomersResponse
     */
    public ListCrmPersonalCustomersResponse listCrmPersonalCustomersWithOptions(ListCrmPersonalCustomersRequest request, ListCrmPersonalCustomersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.currentOperatorUserId)) {
            query.put("currentOperatorUserId", request.currentOperatorUserId);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", request.body)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListCrmPersonalCustomers"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/personalCustomers/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListCrmPersonalCustomersResponse());
    }

    /**
     * @summary 批量获取crm个人客户
     *
     * @param request ListCrmPersonalCustomersRequest
     * @return ListCrmPersonalCustomersResponse
     */
    public ListCrmPersonalCustomersResponse listCrmPersonalCustomers(ListCrmPersonalCustomersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListCrmPersonalCustomersHeaders headers = new ListCrmPersonalCustomersHeaders();
        return this.listCrmPersonalCustomersWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询群组列表
     *
     * @param request ListGroupSetRequest
     * @param headers ListGroupSetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListGroupSetResponse
     */
    public ListGroupSetResponse listGroupSetWithOptions(ListGroupSetRequest request, ListGroupSetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListGroupSet"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/groupSets/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListGroupSetResponse());
    }

    /**
     * @summary 查询群组列表
     *
     * @param request ListGroupSetRequest
     * @return ListGroupSetResponse
     */
    public ListGroupSetResponse listGroupSet(ListGroupSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListGroupSetHeaders headers = new ListGroupSetHeaders();
        return this.listGroupSetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
     *
     * @param request QueryAllCustomerRequest
     * @param headers QueryAllCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllCustomerResponse
     */
    public QueryAllCustomerResponse queryAllCustomerWithOptions(QueryAllCustomerRequest request, QueryAllCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryAllCustomer"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/customerInstances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllCustomerResponse());
    }

    /**
     * @summary 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
     *
     * @param request QueryAllCustomerRequest
     * @return QueryAllCustomerResponse
     */
    public QueryAllCustomerResponse queryAllCustomer(QueryAllCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllCustomerHeaders headers = new QueryAllCustomerHeaders();
        return this.queryAllCustomerWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量查询企业客户动态
     *
     * @param request QueryAllTracksRequest
     * @param headers QueryAllTracksHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllTracksResponse
     */
    public QueryAllTracksResponse queryAllTracksWithOptions(QueryAllTracksRequest request, QueryAllTracksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryAllTracks"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/customers/tracks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllTracksResponse());
    }

    /**
     * @summary 批量查询企业客户动态
     *
     * @param request QueryAllTracksRequest
     * @return QueryAllTracksResponse
     */
    public QueryAllTracksResponse queryAllTracks(QueryAllTracksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllTracksHeaders headers = new QueryAllTracksHeaders();
        return this.queryAllTracksWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询线索跟进状态
     *
     * @param request QueryClueFollowStatusRequest
     * @param headers QueryClueFollowStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryClueFollowStatusResponse
     */
    public QueryClueFollowStatusResponse queryClueFollowStatusWithOptions(QueryClueFollowStatusRequest request, QueryClueFollowStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.clueId)) {
            query.put("clueId", request.clueId);
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
            new TeaPair("action", "QueryClueFollowStatus"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/clues/followStatuses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryClueFollowStatusResponse());
    }

    /**
     * @summary 查询线索跟进状态
     *
     * @param request QueryClueFollowStatusRequest
     * @return QueryClueFollowStatusResponse
     */
    public QueryClueFollowStatusResponse queryClueFollowStatus(QueryClueFollowStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryClueFollowStatusHeaders headers = new QueryClueFollowStatusHeaders();
        return this.queryClueFollowStatusWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询客户群
     *
     * @param request QueryCrmGroupChatsRequest
     * @param headers QueryCrmGroupChatsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCrmGroupChatsResponse
     */
    public QueryCrmGroupChatsResponse queryCrmGroupChatsWithOptions(QueryCrmGroupChatsRequest request, QueryCrmGroupChatsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryCrmGroupChats"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/crmGroupChats"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCrmGroupChatsResponse());
    }

    /**
     * @summary 查询客户群
     *
     * @param request QueryCrmGroupChatsRequest
     * @return QueryCrmGroupChatsResponse
     */
    public QueryCrmGroupChatsResponse queryCrmGroupChats(QueryCrmGroupChatsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCrmGroupChatsHeaders headers = new QueryCrmGroupChatsHeaders();
        return this.queryCrmGroupChatsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据指定查询条件批量获取客户数据
     *
     * @param request QueryCrmPersonalCustomerRequest
     * @param headers QueryCrmPersonalCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCrmPersonalCustomerResponse
     */
    public QueryCrmPersonalCustomerResponse queryCrmPersonalCustomerWithOptions(QueryCrmPersonalCustomerRequest request, QueryCrmPersonalCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryCrmPersonalCustomer"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/personalCustomers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCrmPersonalCustomerResponse());
    }

    /**
     * @summary 根据指定查询条件批量获取客户数据
     *
     * @param request QueryCrmPersonalCustomerRequest
     * @return QueryCrmPersonalCustomerResponse
     */
    public QueryCrmPersonalCustomerResponse queryCrmPersonalCustomer(QueryCrmPersonalCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCrmPersonalCustomerHeaders headers = new QueryCrmPersonalCustomerHeaders();
        return this.queryCrmPersonalCustomerWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询客户模板启用类型
     *
     * @param headers QueryCustomerBizTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCustomerBizTypeResponse
     */
    public QueryCustomerBizTypeResponse queryCustomerBizTypeWithOptions(QueryCustomerBizTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryCustomerBizType"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/orgSettings/templates/customerBizTypes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCustomerBizTypeResponse());
    }

    /**
     * @summary 查询客户模板启用类型
     *
     * @return QueryCustomerBizTypeResponse
     */
    public QueryCustomerBizTypeResponse queryCustomerBizType() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCustomerBizTypeHeaders headers = new QueryCustomerBizTypeHeaders();
        return this.queryCustomerBizTypeWithOptions(headers, runtime);
    }

    /**
     * @summary 营销服融合三方全局信息
     *
     * @param request QueryGlobalInfoRequest
     * @param headers QueryGlobalInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryGlobalInfoResponse
     */
    public QueryGlobalInfoResponse queryGlobalInfoWithOptions(QueryGlobalInfoRequest request, QueryGlobalInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryGlobalInfo"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/globalInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryGlobalInfoResponse());
    }

    /**
     * @summary 营销服融合三方全局信息
     *
     * @param request QueryGlobalInfoRequest
     * @return QueryGlobalInfoResponse
     */
    public QueryGlobalInfoResponse queryGlobalInfo(QueryGlobalInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGlobalInfoHeaders headers = new QueryGlobalInfoHeaders();
        return this.queryGlobalInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询服务窗用户基础信息
     *
     * @param request QueryOfficialAccountUserBasicInfoRequest
     * @param headers QueryOfficialAccountUserBasicInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOfficialAccountUserBasicInfoResponse
     */
    public QueryOfficialAccountUserBasicInfoResponse queryOfficialAccountUserBasicInfoWithOptions(QueryOfficialAccountUserBasicInfoRequest request, QueryOfficialAccountUserBasicInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryOfficialAccountUserBasicInfo"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/officialAccounts/basics/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOfficialAccountUserBasicInfoResponse());
    }

    /**
     * @summary 查询服务窗用户基础信息
     *
     * @param request QueryOfficialAccountUserBasicInfoRequest
     * @return QueryOfficialAccountUserBasicInfoResponse
     */
    public QueryOfficialAccountUserBasicInfoResponse queryOfficialAccountUserBasicInfo(QueryOfficialAccountUserBasicInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOfficialAccountUserBasicInfoHeaders headers = new QueryOfficialAccountUserBasicInfoHeaders();
        return this.queryOfficialAccountUserBasicInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据targetId查询关系数据
     *
     * @param request QueryRelationDatasByTargetIdRequest
     * @param headers QueryRelationDatasByTargetIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryRelationDatasByTargetIdResponse
     */
    public QueryRelationDatasByTargetIdResponse queryRelationDatasByTargetIdWithOptions(String targetId, QueryRelationDatasByTargetIdRequest request, QueryRelationDatasByTargetIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryRelationDatasByTargetId"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/relations/datas/targets/" + targetId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryRelationDatasByTargetIdResponse());
    }

    /**
     * @summary 根据targetId查询关系数据
     *
     * @param request QueryRelationDatasByTargetIdRequest
     * @return QueryRelationDatasByTargetIdResponse
     */
    public QueryRelationDatasByTargetIdResponse queryRelationDatasByTargetId(String targetId, QueryRelationDatasByTargetIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRelationDatasByTargetIdHeaders headers = new QueryRelationDatasByTargetIdHeaders();
        return this.queryRelationDatasByTargetIdWithOptions(targetId, request, headers, runtime);
    }

    /**
     * @summary 服务窗消息撤回
     *
     * @param request RecallOfficialAccountOTOMessageRequest
     * @param headers RecallOfficialAccountOTOMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RecallOfficialAccountOTOMessageResponse
     */
    public RecallOfficialAccountOTOMessageResponse recallOfficialAccountOTOMessageWithOptions(RecallOfficialAccountOTOMessageRequest request, RecallOfficialAccountOTOMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RecallOfficialAccountOTOMessage"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/officialAccounts/oToMessages/recall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RecallOfficialAccountOTOMessageResponse());
    }

    /**
     * @summary 服务窗消息撤回
     *
     * @param request RecallOfficialAccountOTOMessageRequest
     * @return RecallOfficialAccountOTOMessageResponse
     */
    public RecallOfficialAccountOTOMessageResponse recallOfficialAccountOTOMessage(RecallOfficialAccountOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RecallOfficialAccountOTOMessageHeaders headers = new RecallOfficialAccountOTOMessageHeaders();
        return this.recallOfficialAccountOTOMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务窗单发接口，指定消息接收人发送
     *
     * @param request SendOfficialAccountOTOMessageRequest
     * @param headers SendOfficialAccountOTOMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendOfficialAccountOTOMessageResponse
     */
    public SendOfficialAccountOTOMessageResponse sendOfficialAccountOTOMessageWithOptions(SendOfficialAccountOTOMessageRequest request, SendOfficialAccountOTOMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            body.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.detail)) {
            body.put("detail", request.detail);
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
            new TeaPair("action", "SendOfficialAccountOTOMessage"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/officialAccounts/oToMessages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendOfficialAccountOTOMessageResponse());
    }

    /**
     * @summary 服务窗单发接口，指定消息接收人发送
     *
     * @param request SendOfficialAccountOTOMessageRequest
     * @return SendOfficialAccountOTOMessageResponse
     */
    public SendOfficialAccountOTOMessageResponse sendOfficialAccountOTOMessage(SendOfficialAccountOTOMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendOfficialAccountOTOMessageHeaders headers = new SendOfficialAccountOTOMessageHeaders();
        return this.sendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 个人应用发送服务窗消息
     *
     * @param request SendOfficialAccountSNSMessageRequest
     * @param headers SendOfficialAccountSNSMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendOfficialAccountSNSMessageResponse
     */
    public SendOfficialAccountSNSMessageResponse sendOfficialAccountSNSMessageWithOptions(SendOfficialAccountSNSMessageRequest request, SendOfficialAccountSNSMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bindingToken)) {
            body.put("bindingToken", request.bindingToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.detail)) {
            body.put("detail", request.detail);
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
            new TeaPair("action", "SendOfficialAccountSNSMessage"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/officialAccounts/snsMessages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendOfficialAccountSNSMessageResponse());
    }

    /**
     * @summary 个人应用发送服务窗消息
     *
     * @param request SendOfficialAccountSNSMessageRequest
     * @return SendOfficialAccountSNSMessageResponse
     */
    public SendOfficialAccountSNSMessageResponse sendOfficialAccountSNSMessage(SendOfficialAccountSNSMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendOfficialAccountSNSMessageHeaders headers = new SendOfficialAccountSNSMessageHeaders();
        return this.sendOfficialAccountSNSMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务窗消息群发
     *
     * @param request ServiceWindowMessageBatchPushRequest
     * @param headers ServiceWindowMessageBatchPushHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ServiceWindowMessageBatchPushResponse
     */
    public ServiceWindowMessageBatchPushResponse serviceWindowMessageBatchPushWithOptions(ServiceWindowMessageBatchPushRequest request, ServiceWindowMessageBatchPushHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.detail)) {
            body.put("detail", request.detail);
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
            new TeaPair("action", "ServiceWindowMessageBatchPush"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/messages/batchSend"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ServiceWindowMessageBatchPushResponse());
    }

    /**
     * @summary 服务窗消息群发
     *
     * @param request ServiceWindowMessageBatchPushRequest
     * @return ServiceWindowMessageBatchPushResponse
     */
    public ServiceWindowMessageBatchPushResponse serviceWindowMessageBatchPush(ServiceWindowMessageBatchPushRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ServiceWindowMessageBatchPushHeaders headers = new ServiceWindowMessageBatchPushHeaders();
        return this.serviceWindowMessageBatchPushWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新crm个人客户（或企业客户）
     *
     * @param request UpdateCrmPersonalCustomerRequest
     * @param headers UpdateCrmPersonalCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCrmPersonalCustomerResponse
     */
    public UpdateCrmPersonalCustomerResponse updateCrmPersonalCustomerWithOptions(UpdateCrmPersonalCustomerRequest request, UpdateCrmPersonalCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.permission)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateCrmPersonalCustomer"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/personalCustomers"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCrmPersonalCustomerResponse());
    }

    /**
     * @summary 更新crm个人客户（或企业客户）
     *
     * @param request UpdateCrmPersonalCustomerRequest
     * @return UpdateCrmPersonalCustomerResponse
     */
    public UpdateCrmPersonalCustomerResponse updateCrmPersonalCustomer(UpdateCrmPersonalCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCrmPersonalCustomerHeaders headers = new UpdateCrmPersonalCustomerHeaders();
        return this.updateCrmPersonalCustomerWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新客户模板类型
     *
     * @param request UpdateCustomerBizTypeRequest
     * @param headers UpdateCustomerBizTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCustomerBizTypeResponse
     */
    public UpdateCustomerBizTypeResponse updateCustomerBizTypeWithOptions(UpdateCustomerBizTypeRequest request, UpdateCustomerBizTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customerBizType)) {
            body.put("customerBizType", request.customerBizType);
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
            new TeaPair("action", "UpdateCustomerBizType"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/orgSettings/templates/customerBizTypes"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCustomerBizTypeResponse());
    }

    /**
     * @summary 更新客户模板类型
     *
     * @param request UpdateCustomerBizTypeRequest
     * @return UpdateCustomerBizTypeResponse
     */
    public UpdateCustomerBizTypeResponse updateCustomerBizType(UpdateCustomerBizTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCustomerBizTypeHeaders headers = new UpdateCustomerBizTypeHeaders();
        return this.updateCustomerBizTypeWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新群组
     *
     * @param request UpdateGroupSetRequest
     * @param headers UpdateGroupSetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateGroupSetResponse
     */
    public UpdateGroupSetResponse updateGroupSetWithOptions(UpdateGroupSetRequest request, UpdateGroupSetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.welcome)) {
            body.put("welcome", request.welcome);
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
            new TeaPair("action", "UpdateGroupSet"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/groupSets/set"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "boolean")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateGroupSetResponse());
    }

    /**
     * @summary 更新群组
     *
     * @param request UpdateGroupSetRequest
     * @return UpdateGroupSetResponse
     */
    public UpdateGroupSetResponse updateGroupSet(UpdateGroupSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateGroupSetHeaders headers = new UpdateGroupSetHeaders();
        return this.updateGroupSetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 增量同步导航数据
     *
     * @param request UpdateMenuDataRequest
     * @param headers UpdateMenuDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateMenuDataResponse
     */
    public UpdateMenuDataResponse updateMenuDataWithOptions(UpdateMenuDataRequest request, UpdateMenuDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attr)) {
            body.put("attr", request.attr);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizTraceId)) {
            body.put("bizTraceId", request.bizTraceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.module)) {
            body.put("module", request.module);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.navData)) {
            body.put("navData", request.navData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateType)) {
            body.put("operateType", request.operateType);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateMenuData"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/navigations/menus/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateMenuDataResponse());
    }

    /**
     * @summary 增量同步导航数据
     *
     * @param request UpdateMenuDataRequest
     * @return UpdateMenuDataResponse
     */
    public UpdateMenuDataResponse updateMenuData(UpdateMenuDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateMenuDataHeaders headers = new UpdateMenuDataHeaders();
        return this.updateMenuDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 关系模型表结构更新字段
     *
     * @param request UpdateRelationMetaFieldRequest
     * @param headers UpdateRelationMetaFieldHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateRelationMetaFieldResponse
     */
    public UpdateRelationMetaFieldResponse updateRelationMetaFieldWithOptions(UpdateRelationMetaFieldRequest request, UpdateRelationMetaFieldHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateRelationMetaField"),
            new TeaPair("version", "crm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/crm/relations/metas/fields"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateRelationMetaFieldResponse());
    }

    /**
     * @summary 关系模型表结构更新字段
     *
     * @param request UpdateRelationMetaFieldRequest
     * @return UpdateRelationMetaFieldResponse
     */
    public UpdateRelationMetaFieldResponse updateRelationMetaField(UpdateRelationMetaFieldRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateRelationMetaFieldHeaders headers = new UpdateRelationMetaFieldHeaders();
        return this.updateRelationMetaFieldWithOptions(request, headers, runtime);
    }
}
