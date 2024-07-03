// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkhrm_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._signatureAlgorithm = "v2";
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>新增法人公司</p>
     * 
     * @param request AddHrmLegalEntityRequest
     * @param headers AddHrmLegalEntityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddHrmLegalEntityResponse
     */
    public AddHrmLegalEntityResponse addHrmLegalEntityWithOptions(AddHrmLegalEntityRequest request, AddHrmLegalEntityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingTenantId)) {
            query.put("dingTenantId", request.dingTenantId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createUserId)) {
            body.put("createUserId", request.createUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalEntityName)) {
            body.put("legalEntityName", request.legalEntityName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalEntityShortName)) {
            body.put("legalEntityShortName", request.legalEntityShortName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalEntityStatus)) {
            body.put("legalEntityStatus", request.legalEntityStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalPersonName)) {
            body.put("legalPersonName", request.legalPersonName);
        }

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
            new TeaPair("action", "AddHrmLegalEntity"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masters/legalEntities/companies"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddHrmLegalEntityResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增法人公司</p>
     * 
     * @param request AddHrmLegalEntityRequest
     * @return AddHrmLegalEntityResponse
     */
    public AddHrmLegalEntityResponse addHrmLegalEntity(AddHrmLegalEntityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddHrmLegalEntityHeaders headers = new AddHrmLegalEntityHeaders();
        return this.addHrmLegalEntityWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事添加待入职员工信息(支持花名册数据和分组明细更新)</p>
     * 
     * @param request AddHrmPreentryRequest
     * @param headers AddHrmPreentryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddHrmPreentryResponse
     */
    public AddHrmPreentryResponse addHrmPreentryWithOptions(AddHrmPreentryRequest request, AddHrmPreentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            body.put("agentId", request.agentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groups)) {
            body.put("groups", request.groups);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needSendPreEntryMsg)) {
            body.put("needSendPreEntryMsg", request.needSendPreEntryMsg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.preEntryTime)) {
            body.put("preEntryTime", request.preEntryTime);
        }

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
            new TeaPair("action", "AddHrmPreentry"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/preentries"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddHrmPreentryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事添加待入职员工信息(支持花名册数据和分组明细更新)</p>
     * 
     * @param request AddHrmPreentryRequest
     * @return AddHrmPreentryResponse
     */
    public AddHrmPreentryResponse addHrmPreentry(AddHrmPreentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddHrmPreentryHeaders headers = new AddHrmPreentryHeaders();
        return this.addHrmPreentryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事设备市场管理</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeviceMarketManagerResponse
     */
    public DeviceMarketManagerResponse deviceMarketManagerWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeviceMarketManager"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/device/market/manager"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeviceMarketManagerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事设备市场管理</p>
     * @return DeviceMarketManagerResponse
     */
    public DeviceMarketManagerResponse deviceMarketManager() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.deviceMarketManagerWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事设备定向管理接口</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeviceMarketOrderManagerResponse
     */
    public DeviceMarketOrderManagerResponse deviceMarketOrderManagerWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeviceMarketOrderManager"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/device/market/order/manager"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeviceMarketOrderManagerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事设备定向管理接口</p>
     * @return DeviceMarketOrderManagerResponse
     */
    public DeviceMarketOrderManagerResponse deviceMarketOrderManager() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.deviceMarketOrderManagerWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>e签宝专有查询证件接口</p>
     * 
     * @param request ECertQueryRequest
     * @param headers ECertQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ECertQueryResponse
     */
    public ECertQueryResponse eCertQueryWithOptions(ECertQueryRequest request, ECertQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ECertQuery"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/eCerts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ECertQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>e签宝专有查询证件接口</p>
     * 
     * @param request ECertQueryRequest
     * @return ECertQueryResponse
     */
    public ECertQueryResponse eCertQuery(ECertQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ECertQueryHeaders headers = new ECertQueryHeaders();
        return this.eCertQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事员工档案附件更新</p>
     * 
     * @param request EmployeeAttachmentUpdateRequest
     * @param headers EmployeeAttachmentUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EmployeeAttachmentUpdateResponse
     */
    public EmployeeAttachmentUpdateResponse employeeAttachmentUpdateWithOptions(EmployeeAttachmentUpdateRequest request, EmployeeAttachmentUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appAgentId)) {
            query.put("appAgentId", request.appAgentId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fieldCode)) {
            body.put("fieldCode", request.fieldCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSuffix)) {
            body.put("fileSuffix", request.fileSuffix);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
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
            new TeaPair("action", "EmployeeAttachmentUpdate"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/employees/attachments"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EmployeeAttachmentUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事员工档案附件更新</p>
     * 
     * @param request EmployeeAttachmentUpdateRequest
     * @return EmployeeAttachmentUpdateResponse
     */
    public EmployeeAttachmentUpdateResponse employeeAttachmentUpdate(EmployeeAttachmentUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EmployeeAttachmentUpdateHeaders headers = new EmployeeAttachmentUpdateHeaders();
        return this.employeeAttachmentUpdateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人事高级合同管理回退</p>
     * 
     * @param request EsignRollbackRequest
     * @param headers EsignRollbackHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EsignRollbackResponse
     */
    public EsignRollbackResponse esignRollbackWithOptions(EsignRollbackRequest request, EsignRollbackHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            query.put("optUserId", request.optUserId);
        }

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
            new TeaPair("action", "EsignRollback"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/contracts/esign/rollback"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EsignRollbackResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人事高级合同管理回退</p>
     * 
     * @param request EsignRollbackRequest
     * @return EsignRollbackResponse
     */
    public EsignRollbackResponse esignRollback(EsignRollbackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EsignRollbackHeaders headers = new EsignRollbackHeaders();
        return this.esignRollbackWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取员工花名册指定字段的信息，支持明细分组字段</p>
     * 
     * @param request GetEmployeeRosterByFieldRequest
     * @param headers GetEmployeeRosterByFieldHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetEmployeeRosterByFieldResponse
     */
    public GetEmployeeRosterByFieldResponse getEmployeeRosterByFieldWithOptions(GetEmployeeRosterByFieldRequest request, GetEmployeeRosterByFieldHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appAgentId)) {
            body.put("appAgentId", request.appAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fieldFilterList)) {
            body.put("fieldFilterList", request.fieldFilterList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.text2SelectConvert)) {
            body.put("text2SelectConvert", request.text2SelectConvert);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdList)) {
            body.put("userIdList", request.userIdList);
        }

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
            new TeaPair("action", "GetEmployeeRosterByField"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/rosters/lists/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetEmployeeRosterByFieldResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取员工花名册指定字段的信息，支持明细分组字段</p>
     * 
     * @param request GetEmployeeRosterByFieldRequest
     * @return GetEmployeeRosterByFieldResponse
     */
    public GetEmployeeRosterByFieldResponse getEmployeeRosterByField(GetEmployeeRosterByFieldRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEmployeeRosterByFieldHeaders headers = new GetEmployeeRosterByFieldHeaders();
        return this.getEmployeeRosterByFieldWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事权限查询</p>
     * 
     * @param request HrmAuthResourcesQueryRequest
     * @param headers HrmAuthResourcesQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrmAuthResourcesQueryResponse
     */
    public HrmAuthResourcesQueryResponse hrmAuthResourcesQueryWithOptions(HrmAuthResourcesQueryRequest request, HrmAuthResourcesQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authResourceIds)) {
            body.put("authResourceIds", request.authResourceIds);
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
            new TeaPair("action", "HrmAuthResourcesQuery"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/authResources/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmAuthResourcesQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事权限查询</p>
     * 
     * @param request HrmAuthResourcesQueryRequest
     * @return HrmAuthResourcesQueryResponse
     */
    public HrmAuthResourcesQueryResponse hrmAuthResourcesQuery(HrmAuthResourcesQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmAuthResourcesQueryHeaders headers = new HrmAuthResourcesQueryHeaders();
        return this.hrmAuthResourcesQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事权益查询</p>
     * 
     * @param request HrmBenefitQueryRequest
     * @param headers HrmBenefitQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrmBenefitQueryResponse
     */
    public HrmBenefitQueryResponse hrmBenefitQueryWithOptions(HrmBenefitQueryRequest request, HrmBenefitQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.benefitCodes)) {
            body.put("benefitCodes", request.benefitCodes);
        }

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
            new TeaPair("action", "HrmBenefitQuery"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/benefits/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmBenefitQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事权益查询</p>
     * 
     * @param request HrmBenefitQueryRequest
     * @return HrmBenefitQueryResponse
     */
    public HrmBenefitQueryResponse hrmBenefitQuery(HrmBenefitQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmBenefitQueryHeaders headers = new HrmBenefitQueryHeaders();
        return this.hrmBenefitQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事邮件发送</p>
     * 
     * @param request HrmMailSendRequest
     * @param headers HrmMailSendHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrmMailSendResponse
     */
    public HrmMailSendResponse hrmMailSendWithOptions(HrmMailSendRequest request, HrmMailSendHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mail)) {
            body.put("mail", request.mail);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

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
            new TeaPair("action", "HrmMailSend"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/mails/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmMailSendResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事邮件发送</p>
     * 
     * @param request HrmMailSendRequest
     * @return HrmMailSendResponse
     */
    public HrmMailSendResponse hrmMailSend(HrmMailSendRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmMailSendHeaders headers = new HrmMailSendHeaders();
        return this.hrmMailSendWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人事2.0支持Moka事件转发</p>
     * 
     * @param request HrmMokaEventRequest
     * @param headers HrmMokaEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrmMokaEventResponse
     */
    public HrmMokaEventResponse hrmMokaEventWithOptions(HrmMokaEventRequest request, HrmMokaEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "HrmMokaEvent"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/moka/events/forward"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmMokaEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人事2.0支持Moka事件转发</p>
     * 
     * @param request HrmMokaEventRequest
     * @return HrmMokaEventResponse
     */
    public HrmMokaEventResponse hrmMokaEvent(HrmMokaEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmMokaEventHeaders headers = new HrmMokaEventHeaders();
        return this.hrmMokaEventWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人事2.0支持Moka接口转发</p>
     * 
     * @param request HrmMokaOapiRequest
     * @param headers HrmMokaOapiHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrmMokaOapiResponse
     */
    public HrmMokaOapiResponse hrmMokaOapiWithOptions(HrmMokaOapiRequest request, HrmMokaOapiHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.apiCode)) {
            body.put("apiCode", request.apiCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.params)) {
            body.put("params", request.params);
        }

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
            new TeaPair("action", "HrmMokaOapi"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/moka/forward"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmMokaOapiResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人事2.0支持Moka接口转发</p>
     * 
     * @param request HrmMokaOapiRequest
     * @return HrmMokaOapiResponse
     */
    public HrmMokaOapiResponse hrmMokaOapi(HrmMokaOapiRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmMokaOapiHeaders headers = new HrmMokaOapiHeaders();
        return this.hrmMokaOapiWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事转正接口</p>
     * 
     * @param request HrmProcessRegularRequest
     * @param headers HrmProcessRegularHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrmProcessRegularResponse
     */
    public HrmProcessRegularResponse hrmProcessRegularWithOptions(HrmProcessRegularRequest request, HrmProcessRegularHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operationId)) {
            body.put("operationId", request.operationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.regularDate)) {
            body.put("regularDate", request.regularDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
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
            new TeaPair("action", "HrmProcessRegular"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/processes/regulars/become"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmProcessRegularResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事转正接口</p>
     * 
     * @param request HrmProcessRegularRequest
     * @return HrmProcessRegularResponse
     */
    public HrmProcessRegularResponse hrmProcessRegular(HrmProcessRegularRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmProcessRegularHeaders headers = new HrmProcessRegularHeaders();
        return this.hrmProcessRegularWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事离职和交接接口</p>
     * 
     * @param request HrmProcessTerminationAndHandoverRequest
     * @param headers HrmProcessTerminationAndHandoverHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrmProcessTerminationAndHandoverResponse
     */
    public HrmProcessTerminationAndHandoverResponse hrmProcessTerminationAndHandoverWithOptions(HrmProcessTerminationAndHandoverRequest request, HrmProcessTerminationAndHandoverHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.aflowHandOverUserId)) {
            body.put("aflowHandOverUserId", request.aflowHandOverUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingPanHandoverUserId)) {
            body.put("dingPanHandoverUserId", request.dingPanHandoverUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.directSubordinatesHandoverUserId)) {
            body.put("directSubordinatesHandoverUserId", request.directSubordinatesHandoverUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dismissionMemo)) {
            body.put("dismissionMemo", request.dismissionMemo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dismissionReason)) {
            body.put("dismissionReason", request.dismissionReason);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.docNoteHandoverUserId)) {
            body.put("docNoteHandoverUserId", request.docNoteHandoverUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.lastWorkDate)) {
            body.put("lastWorkDate", request.lastWorkDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            body.put("optUserId", request.optUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.permissionHandoverUserId)) {
            body.put("permissionHandoverUserId", request.permissionHandoverUserId);
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
            new TeaPair("action", "HrmProcessTerminationAndHandover"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/processes/terminateAndHandOver"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmProcessTerminationAndHandoverResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事离职和交接接口</p>
     * 
     * @param request HrmProcessTerminationAndHandoverRequest
     * @return HrmProcessTerminationAndHandoverResponse
     */
    public HrmProcessTerminationAndHandoverResponse hrmProcessTerminationAndHandover(HrmProcessTerminationAndHandoverRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmProcessTerminationAndHandoverHeaders headers = new HrmProcessTerminationAndHandoverHeaders();
        return this.hrmProcessTerminationAndHandoverWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事调岗接口</p>
     * 
     * @param request HrmProcessTransferRequest
     * @param headers HrmProcessTransferHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrmProcessTransferResponse
     */
    public HrmProcessTransferResponse hrmProcessTransferWithOptions(HrmProcessTransferRequest request, HrmProcessTransferHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIdsAfterTransfer)) {
            body.put("deptIdsAfterTransfer", request.deptIdsAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobIdAfterTransfer)) {
            body.put("jobIdAfterTransfer", request.jobIdAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mainDeptIdAfterTransfer)) {
            body.put("mainDeptIdAfterTransfer", request.mainDeptIdAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateUserId)) {
            body.put("operateUserId", request.operateUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.positionIdAfterTransfer)) {
            body.put("positionIdAfterTransfer", request.positionIdAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.positionLevelAfterTransfer)) {
            body.put("positionLevelAfterTransfer", request.positionLevelAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.positionNameAfterTransfer)) {
            body.put("positionNameAfterTransfer", request.positionNameAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rankIdAfterTransfer)) {
            body.put("rankIdAfterTransfer", request.rankIdAfterTransfer);
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
            new TeaPair("action", "HrmProcessTransfer"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/processes/transfer"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmProcessTransferResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事调岗接口</p>
     * 
     * @param request HrmProcessTransferRequest
     * @return HrmProcessTransferResponse
     */
    public HrmProcessTransferResponse hrmProcessTransfer(HrmProcessTransferRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmProcessTransferHeaders headers = new HrmProcessTransferHeaders();
        return this.hrmProcessTransferWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改员工最后一次离职信息</p>
     * 
     * @param request HrmProcessUpdateTerminationInfoRequest
     * @param headers HrmProcessUpdateTerminationInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrmProcessUpdateTerminationInfoResponse
     */
    public HrmProcessUpdateTerminationInfoResponse hrmProcessUpdateTerminationInfoWithOptions(HrmProcessUpdateTerminationInfoRequest request, HrmProcessUpdateTerminationInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dismissionMemo)) {
            body.put("dismissionMemo", request.dismissionMemo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.lastWorkDate)) {
            body.put("lastWorkDate", request.lastWorkDate);
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
            new TeaPair("action", "HrmProcessUpdateTerminationInfo"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/processes/employees/terminations"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmProcessUpdateTerminationInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改员工最后一次离职信息</p>
     * 
     * @param request HrmProcessUpdateTerminationInfoRequest
     * @return HrmProcessUpdateTerminationInfoResponse
     */
    public HrmProcessUpdateTerminationInfoResponse hrmProcessUpdateTerminationInfo(HrmProcessUpdateTerminationInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmProcessUpdateTerminationInfoHeaders headers = new HrmProcessUpdateTerminationInfoHeaders();
        return this.hrmProcessUpdateTerminationInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事pts能力调用</p>
     * 
     * @param request HrmPtsServiceRequest
     * @param headers HrmPtsServiceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrmPtsServiceResponse
     */
    public HrmPtsServiceResponse hrmPtsServiceWithOptions(HrmPtsServiceRequest request, HrmPtsServiceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.env)) {
            body.put("env", request.env);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.method)) {
            body.put("method", request.method);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerId)) {
            body.put("outerId", request.outerId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.params)) {
            body.put("params", request.params);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.path)) {
            body.put("path", request.path);
        }

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
            new TeaPair("action", "HrmPtsService"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/pts/request"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmPtsServiceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事pts能力调用</p>
     * 
     * @param request HrmPtsServiceRequest
     * @return HrmPtsServiceResponse
     */
    public HrmPtsServiceResponse hrmPtsService(HrmPtsServiceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmPtsServiceHeaders headers = new HrmPtsServiceHeaders();
        return this.hrmPtsServiceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事主数据删除服务</p>
     * 
     * @param request MasterDataDeleteRequest
     * @param headers MasterDataDeleteHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MasterDataDeleteResponse
     */
    public MasterDataDeleteResponse masterDataDeleteWithOptions(MasterDataDeleteRequest request, MasterDataDeleteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tenantId)) {
            query.put("tenantId", request.tenantId);
        }

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
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "MasterDataDelete"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masters/datas/batchRemove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MasterDataDeleteResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事主数据删除服务</p>
     * 
     * @param request MasterDataDeleteRequest
     * @return MasterDataDeleteResponse
     */
    public MasterDataDeleteResponse masterDataDelete(MasterDataDeleteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MasterDataDeleteHeaders headers = new MasterDataDeleteHeaders();
        return this.masterDataDeleteWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事主数据查询服务</p>
     * 
     * @param request MasterDataQueryRequest
     * @param headers MasterDataQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MasterDataQueryResponse
     */
    public MasterDataQueryResponse masterDataQueryWithOptions(MasterDataQueryRequest request, MasterDataQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizUK)) {
            body.put("bizUK", request.bizUK);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            body.put("optUserId", request.optUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryParams)) {
            body.put("queryParams", request.queryParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationIds)) {
            body.put("relationIds", request.relationIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeCode)) {
            body.put("scopeCode", request.scopeCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tenantId)) {
            body.put("tenantId", request.tenantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.viewEntityCode)) {
            body.put("viewEntityCode", request.viewEntityCode);
        }

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
            new TeaPair("action", "MasterDataQuery"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masters/datas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MasterDataQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事主数据查询服务</p>
     * 
     * @param request MasterDataQueryRequest
     * @return MasterDataQueryResponse
     */
    public MasterDataQueryResponse masterDataQuery(MasterDataQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MasterDataQueryHeaders headers = new MasterDataQueryHeaders();
        return this.masterDataQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事主数据保存服务</p>
     * 
     * @param request MasterDataSaveRequest
     * @param headers MasterDataSaveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MasterDataSaveResponse
     */
    public MasterDataSaveResponse masterDataSaveWithOptions(MasterDataSaveRequest request, MasterDataSaveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tenantId)) {
            query.put("tenantId", request.tenantId);
        }

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
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "MasterDataSave"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masters/datas/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MasterDataSaveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事主数据保存服务</p>
     * 
     * @param request MasterDataSaveRequest
     * @return MasterDataSaveResponse
     */
    public MasterDataSaveResponse masterDataSave(MasterDataSaveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MasterDataSaveHeaders headers = new MasterDataSaveHeaders();
        return this.masterDataSaveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>主数据中拥有某个领域数据的租户信息查询</p>
     * 
     * @param request MasterDataTenantQueyRequest
     * @param headers MasterDataTenantQueyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MasterDataTenantQueyResponse
     */
    public MasterDataTenantQueyResponse masterDataTenantQueyWithOptions(MasterDataTenantQueyRequest request, MasterDataTenantQueyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.entityCode)) {
            query.put("entityCode", request.entityCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeCode)) {
            query.put("scopeCode", request.scopeCode);
        }

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
            new TeaPair("action", "MasterDataTenantQuey"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masters/tenants"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MasterDataTenantQueyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>主数据中拥有某个领域数据的租户信息查询</p>
     * 
     * @param request MasterDataTenantQueyRequest
     * @return MasterDataTenantQueyResponse
     */
    public MasterDataTenantQueyResponse masterDataTenantQuey(MasterDataTenantQueyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MasterDataTenantQueyHeaders headers = new MasterDataTenantQueyHeaders();
        return this.masterDataTenantQueyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事主数据查询服务</p>
     * 
     * @param request MasterDatasQueryRequest
     * @param headers MasterDatasQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MasterDatasQueryResponse
     */
    public MasterDatasQueryResponse masterDatasQueryWithOptions(MasterDatasQueryRequest request, MasterDatasQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizUK)) {
            body.put("bizUK", request.bizUK);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryParams)) {
            body.put("queryParams", request.queryParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationIds)) {
            body.put("relationIds", request.relationIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeCode)) {
            body.put("scopeCode", request.scopeCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tenantId)) {
            body.put("tenantId", request.tenantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.viewEntityCode)) {
            body.put("viewEntityCode", request.viewEntityCode);
        }

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
            new TeaPair("action", "MasterDatasQuery"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masterDatas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MasterDatasQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事主数据查询服务</p>
     * 
     * @param request MasterDatasQueryRequest
     * @return MasterDatasQueryResponse
     */
    public MasterDatasQueryResponse masterDatasQuery(MasterDatasQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MasterDatasQueryHeaders headers = new MasterDatasQueryHeaders();
        return this.masterDatasQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>自定义入职流程数据查询</p>
     * 
     * @param request QueryCustomEntryProcessesRequest
     * @param headers QueryCustomEntryProcessesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCustomEntryProcessesResponse
     */
    public QueryCustomEntryProcessesResponse queryCustomEntryProcessesWithOptions(QueryCustomEntryProcessesRequest request, QueryCustomEntryProcessesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateUserId)) {
            query.put("operateUserId", request.operateUserId);
        }

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
            new TeaPair("action", "QueryCustomEntryProcesses"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/customEntryProcesses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCustomEntryProcessesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>自定义入职流程数据查询</p>
     * 
     * @param request QueryCustomEntryProcessesRequest
     * @return QueryCustomEntryProcessesResponse
     */
    public QueryCustomEntryProcessesResponse queryCustomEntryProcesses(QueryCustomEntryProcessesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCustomEntryProcessesHeaders headers = new QueryCustomEntryProcessesHeaders();
        return this.queryCustomEntryProcessesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业已离职员工列表</p>
     * 
     * @param request QueryDismissionStaffIdListRequest
     * @param headers QueryDismissionStaffIdListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDismissionStaffIdListResponse
     */
    public QueryDismissionStaffIdListResponse queryDismissionStaffIdListWithOptions(QueryDismissionStaffIdListRequest request, QueryDismissionStaffIdListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryDismissionStaffIdList"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/employees/dismissions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDismissionStaffIdListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业已离职员工列表</p>
     * 
     * @param request QueryDismissionStaffIdListRequest
     * @return QueryDismissionStaffIdListResponse
     */
    public QueryDismissionStaffIdListResponse queryDismissionStaffIdList(QueryDismissionStaffIdListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDismissionStaffIdListHeaders headers = new QueryDismissionStaffIdListHeaders();
        return this.queryDismissionStaffIdListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据传入的staffId列表，批量查询员工的离职信息</p>
     * 
     * @param tmpReq QueryHrmEmployeeDismissionInfoRequest
     * @param headers QueryHrmEmployeeDismissionInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryHrmEmployeeDismissionInfoResponse
     */
    public QueryHrmEmployeeDismissionInfoResponse queryHrmEmployeeDismissionInfoWithOptions(QueryHrmEmployeeDismissionInfoRequest tmpReq, QueryHrmEmployeeDismissionInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        QueryHrmEmployeeDismissionInfoShrinkRequest request = new QueryHrmEmployeeDismissionInfoShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.userIdList)) {
            request.userIdListShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.userIdList, "userIdList", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userIdListShrink)) {
            query.put("userIdList", request.userIdListShrink);
        }

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
            new TeaPair("action", "QueryHrmEmployeeDismissionInfo"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/employees/dimissionInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryHrmEmployeeDismissionInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据传入的staffId列表，批量查询员工的离职信息</p>
     * 
     * @param request QueryHrmEmployeeDismissionInfoRequest
     * @return QueryHrmEmployeeDismissionInfoResponse
     */
    public QueryHrmEmployeeDismissionInfoResponse queryHrmEmployeeDismissionInfo(QueryHrmEmployeeDismissionInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHrmEmployeeDismissionInfoHeaders headers = new QueryHrmEmployeeDismissionInfoHeaders();
        return this.queryHrmEmployeeDismissionInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询企业的职级信息</p>
     * 
     * @param request QueryJobRanksRequest
     * @param headers QueryJobRanksHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryJobRanksResponse
     */
    public QueryJobRanksResponse queryJobRanksWithOptions(QueryJobRanksRequest request, QueryJobRanksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rankCategoryId)) {
            query.put("rankCategoryId", request.rankCategoryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rankCode)) {
            query.put("rankCode", request.rankCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rankName)) {
            query.put("rankName", request.rankName);
        }

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
            new TeaPair("action", "QueryJobRanks"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/jobRanks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryJobRanksResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询企业的职级信息</p>
     * 
     * @param request QueryJobRanksRequest
     * @return QueryJobRanksResponse
     */
    public QueryJobRanksResponse queryJobRanks(QueryJobRanksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryJobRanksHeaders headers = new QueryJobRanksHeaders();
        return this.queryJobRanksWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询企业职务信息</p>
     * 
     * @param request QueryJobsRequest
     * @param headers QueryJobsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryJobsResponse
     */
    public QueryJobsResponse queryJobsWithOptions(QueryJobsRequest request, QueryJobsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.jobName)) {
            query.put("jobName", request.jobName);
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
            new TeaPair("action", "QueryJobs"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/jobs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryJobsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询企业职务信息</p>
     * 
     * @param request QueryJobsRequest
     * @return QueryJobsResponse
     */
    public QueryJobsResponse queryJobs(QueryJobsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryJobsHeaders headers = new QueryJobsHeaders();
        return this.queryJobsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询企业职位信息</p>
     * 
     * @param request QueryPositionsRequest
     * @param headers QueryPositionsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPositionsResponse
     */
    public QueryPositionsResponse queryPositionsWithOptions(QueryPositionsRequest request, QueryPositionsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inCategoryIds)) {
            body.put("inCategoryIds", request.inCategoryIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inPositionIds)) {
            body.put("inPositionIds", request.inPositionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.positionName)) {
            body.put("positionName", request.positionName);
        }

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
            new TeaPair("action", "QueryPositions"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/positions/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPositionsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询企业职位信息</p>
     * 
     * @param request QueryPositionsRequest
     * @return QueryPositionsResponse
     */
    public QueryPositionsResponse queryPositions(QueryPositionsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPositionsHeaders headers = new QueryPositionsHeaders();
        return this.queryPositionsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询花名册中有权限的字段列表</p>
     * 
     * @param request RosterMetaAvailableFieldListRequest
     * @param headers RosterMetaAvailableFieldListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RosterMetaAvailableFieldListResponse
     */
    public RosterMetaAvailableFieldListResponse rosterMetaAvailableFieldListWithOptions(RosterMetaAvailableFieldListRequest request, RosterMetaAvailableFieldListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appAgentId)) {
            query.put("appAgentId", request.appAgentId);
        }

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
            new TeaPair("action", "RosterMetaAvailableFieldList"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/rosters/meta/authorities/fields"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RosterMetaAvailableFieldListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询花名册中有权限的字段列表</p>
     * 
     * @param request RosterMetaAvailableFieldListRequest
     * @return RosterMetaAvailableFieldListResponse
     */
    public RosterMetaAvailableFieldListResponse rosterMetaAvailableFieldList(RosterMetaAvailableFieldListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RosterMetaAvailableFieldListHeaders headers = new RosterMetaAvailableFieldListHeaders();
        return this.rosterMetaAvailableFieldListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事花名册字段选项修改</p>
     * 
     * @param request RosterMetaFieldOptionsUpdateRequest
     * @param headers RosterMetaFieldOptionsUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RosterMetaFieldOptionsUpdateResponse
     */
    public RosterMetaFieldOptionsUpdateResponse rosterMetaFieldOptionsUpdateWithOptions(RosterMetaFieldOptionsUpdateRequest request, RosterMetaFieldOptionsUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appAgentId)) {
            query.put("appAgentId", request.appAgentId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fieldCode)) {
            body.put("fieldCode", request.fieldCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            body.put("groupId", request.groupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.labels)) {
            body.put("labels", request.labels);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifyType)) {
            body.put("modifyType", request.modifyType);
        }

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
            new TeaPair("action", "RosterMetaFieldOptionsUpdate"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/rosters/meta/fields/options"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RosterMetaFieldOptionsUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>智能人事花名册字段选项修改</p>
     * 
     * @param request RosterMetaFieldOptionsUpdateRequest
     * @return RosterMetaFieldOptionsUpdateResponse
     */
    public RosterMetaFieldOptionsUpdateResponse rosterMetaFieldOptionsUpdate(RosterMetaFieldOptionsUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RosterMetaFieldOptionsUpdateHeaders headers = new RosterMetaFieldOptionsUpdateHeaders();
        return this.rosterMetaFieldOptionsUpdateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>ISV发送卡片消息</p>
     * 
     * @param request SendIsvCardMessageRequest
     * @param headers SendIsvCardMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendIsvCardMessageResponse
     */
    public SendIsvCardMessageResponse sendIsvCardMessageWithOptions(SendIsvCardMessageRequest request, SendIsvCardMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            query.put("agentId", request.agentId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.messageType)) {
            body.put("messageType", request.messageType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserIds)) {
            body.put("receiverUserIds", request.receiverUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sceneType)) {
            body.put("sceneType", request.sceneType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.senderUserId)) {
            body.put("senderUserId", request.senderUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.valueMap)) {
            body.put("valueMap", request.valueMap);
        }

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
            new TeaPair("action", "SendIsvCardMessage"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/cardMessages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendIsvCardMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>ISV发送卡片消息</p>
     * 
     * @param request SendIsvCardMessageRequest
     * @return SendIsvCardMessageResponse
     */
    public SendIsvCardMessageResponse sendIsvCardMessage(SendIsvCardMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendIsvCardMessageHeaders headers = new SendIsvCardMessageHeaders();
        return this.sendIsvCardMessageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>初始化解决方案任务</p>
     * 
     * @param request SolutionTaskInitRequest
     * @param headers SolutionTaskInitHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SolutionTaskInitResponse
     */
    public SolutionTaskInitResponse solutionTaskInitWithOptions(SolutionTaskInitRequest request, SolutionTaskInitHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.solutionType)) {
            query.put("solutionType", request.solutionType);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            body.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.claimTime)) {
            body.put("claimTime", request.claimTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.finishTime)) {
            body.put("finishTime", request.finishTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerId)) {
            body.put("outerId", request.outerId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
            new TeaPair("action", "SolutionTaskInit"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/solutions/tasks/init"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SolutionTaskInitResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>初始化解决方案任务</p>
     * 
     * @param request SolutionTaskInitRequest
     * @return SolutionTaskInitResponse
     */
    public SolutionTaskInitResponse solutionTaskInit(SolutionTaskInitRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SolutionTaskInitHeaders headers = new SolutionTaskInitHeaders();
        return this.solutionTaskInitWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>保存解决方案任务</p>
     * 
     * @param request SolutionTaskSaveRequest
     * @param headers SolutionTaskSaveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SolutionTaskSaveResponse
     */
    public SolutionTaskSaveResponse solutionTaskSaveWithOptions(SolutionTaskSaveRequest request, SolutionTaskSaveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.solutionType)) {
            query.put("solutionType", request.solutionType);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.claimTime)) {
            body.put("claimTime", request.claimTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.finishTime)) {
            body.put("finishTime", request.finishTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerId)) {
            body.put("outerId", request.outerId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.solutionInstanceId)) {
            body.put("solutionInstanceId", request.solutionInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskType)) {
            body.put("taskType", request.taskType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateOuterId)) {
            body.put("templateOuterId", request.templateOuterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
            new TeaPair("action", "SolutionTaskSave"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/solutions/tasks/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SolutionTaskSaveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>保存解决方案任务</p>
     * 
     * @param request SolutionTaskSaveRequest
     * @return SolutionTaskSaveResponse
     */
    public SolutionTaskSaveResponse solutionTaskSave(SolutionTaskSaveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SolutionTaskSaveHeaders headers = new SolutionTaskSaveHeaders();
        return this.solutionTaskSaveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>同步解决方案任务模版</p>
     * 
     * @param request SyncTaskTemplateRequest
     * @param headers SyncTaskTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SyncTaskTemplateResponse
     */
    public SyncTaskTemplateResponse syncTaskTemplateWithOptions(SyncTaskTemplateRequest request, SyncTaskTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.solutionType)) {
            query.put("solutionType", request.solutionType);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.delete)) {
            body.put("delete", request.delete);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.des)) {
            body.put("des", request.des);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            body.put("optUserId", request.optUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerId)) {
            body.put("outerId", request.outerId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskScopeVO)) {
            body.put("taskScopeVO", request.taskScopeVO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskType)) {
            body.put("taskType", request.taskType);
        }

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
            new TeaPair("action", "SyncTaskTemplate"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/solutions/tasks/templates/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncTaskTemplateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>同步解决方案任务模版</p>
     * 
     * @param request SyncTaskTemplateRequest
     * @return SyncTaskTemplateResponse
     */
    public SyncTaskTemplateResponse syncTaskTemplate(SyncTaskTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncTaskTemplateHeaders headers = new SyncTaskTemplateHeaders();
        return this.syncTaskTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新法人公司名称</p>
     * 
     * @param request UpdateHrmLegalEntityNameRequest
     * @param headers UpdateHrmLegalEntityNameHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateHrmLegalEntityNameResponse
     */
    public UpdateHrmLegalEntityNameResponse updateHrmLegalEntityNameWithOptions(UpdateHrmLegalEntityNameRequest request, UpdateHrmLegalEntityNameHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingTenantId)) {
            query.put("dingTenantId", request.dingTenantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalEntityName)) {
            query.put("legalEntityName", request.legalEntityName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.originLegalEntityName)) {
            query.put("originLegalEntityName", request.originLegalEntityName);
        }

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
            new TeaPair("action", "UpdateHrmLegalEntityName"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masters/legalEntities/companyNames"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateHrmLegalEntityNameResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新法人公司名称</p>
     * 
     * @param request UpdateHrmLegalEntityNameRequest
     * @return UpdateHrmLegalEntityNameResponse
     */
    public UpdateHrmLegalEntityNameResponse updateHrmLegalEntityName(UpdateHrmLegalEntityNameRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateHrmLegalEntityNameHeaders headers = new UpdateHrmLegalEntityNameHeaders();
        return this.updateHrmLegalEntityNameWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新法人公司</p>
     * 
     * @param request UpdateHrmLegalEntityWithoutNameRequest
     * @param headers UpdateHrmLegalEntityWithoutNameHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateHrmLegalEntityWithoutNameResponse
     */
    public UpdateHrmLegalEntityWithoutNameResponse updateHrmLegalEntityWithoutNameWithOptions(UpdateHrmLegalEntityWithoutNameRequest request, UpdateHrmLegalEntityWithoutNameHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingTenantId)) {
            query.put("dingTenantId", request.dingTenantId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createUserId)) {
            body.put("createUserId", request.createUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalEntityName)) {
            body.put("legalEntityName", request.legalEntityName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalEntityShortName)) {
            body.put("legalEntityShortName", request.legalEntityShortName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalEntityStatus)) {
            body.put("legalEntityStatus", request.legalEntityStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalPersonName)) {
            body.put("legalPersonName", request.legalPersonName);
        }

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
            new TeaPair("action", "UpdateHrmLegalEntityWithoutName"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masters/legalEntities/companies"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateHrmLegalEntityWithoutNameResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新法人公司</p>
     * 
     * @param request UpdateHrmLegalEntityWithoutNameRequest
     * @return UpdateHrmLegalEntityWithoutNameResponse
     */
    public UpdateHrmLegalEntityWithoutNameResponse updateHrmLegalEntityWithoutName(UpdateHrmLegalEntityWithoutNameRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateHrmLegalEntityWithoutNameHeaders headers = new UpdateHrmLegalEntityWithoutNameHeaders();
        return this.updateHrmLegalEntityWithoutNameWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>ISV更新卡片消息</p>
     * 
     * @param request UpdateIsvCardMessageRequest
     * @param headers UpdateIsvCardMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateIsvCardMessageResponse
     */
    public UpdateIsvCardMessageResponse updateIsvCardMessageWithOptions(UpdateIsvCardMessageRequest request, UpdateIsvCardMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            query.put("agentId", request.agentId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.messageType)) {
            body.put("messageType", request.messageType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sceneType)) {
            body.put("sceneType", request.sceneType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.valueMap)) {
            body.put("valueMap", request.valueMap);
        }

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
            new TeaPair("action", "UpdateIsvCardMessage"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/cardMessages"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateIsvCardMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>ISV更新卡片消息</p>
     * 
     * @param request UpdateIsvCardMessageRequest
     * @return UpdateIsvCardMessageResponse
     */
    public UpdateIsvCardMessageResponse updateIsvCardMessage(UpdateIsvCardMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateIsvCardMessageHeaders headers = new UpdateIsvCardMessageHeaders();
        return this.updateIsvCardMessageWithOptions(request, headers, runtime);
    }
}
