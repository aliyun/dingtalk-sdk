// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcontact_1_0.models.*;

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
     * <p>创建账号映射</p>
     * 
     * @param request AddAccountMappingRequest
     * @param headers AddAccountMappingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddAccountMappingResponse
     */
    public AddAccountMappingResponse addAccountMappingWithOptions(AddAccountMappingRequest request, AddAccountMappingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.domain)) {
            body.put("domain", request.domain);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outId)) {
            body.put("outId", request.outId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTenantId)) {
            body.put("outTenantId", request.outTenantId);
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
            new TeaPair("action", "AddAccountMapping"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/accountMappings"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddAccountMappingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建账号映射</p>
     * 
     * @param request AddAccountMappingRequest
     * @return AddAccountMappingResponse
     */
    public AddAccountMappingResponse addAccountMapping(AddAccountMappingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddAccountMappingHeaders headers = new AddAccountMappingHeaders();
        return this.addAccountMappingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加通讯录组织架构分场景隐藏设置</p>
     * 
     * @param request AddContactHideBySceneSettingRequest
     * @param headers AddContactHideBySceneSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddContactHideBySceneSettingResponse
     */
    public AddContactHideBySceneSettingResponse addContactHideBySceneSettingWithOptions(AddContactHideBySceneSettingRequest request, AddContactHideBySceneSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeDeptIds)) {
            body.put("excludeDeptIds", request.excludeDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeTagIds)) {
            body.put("excludeTagIds", request.excludeTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeUserIds)) {
            body.put("excludeUserIds", request.excludeUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nodeListSceneConfig)) {
            body.put("nodeListSceneConfig", request.nodeListSceneConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectDeptIds)) {
            body.put("objectDeptIds", request.objectDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectTagIds)) {
            body.put("objectTagIds", request.objectTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectUserIds)) {
            body.put("objectUserIds", request.objectUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.profileSceneConfig)) {
            body.put("profileSceneConfig", request.profileSceneConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchSceneConfig)) {
            body.put("searchSceneConfig", request.searchSceneConfig);
        }

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
            new TeaPair("action", "AddContactHideBySceneSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/organizations/hides/settings"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddContactHideBySceneSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加通讯录组织架构分场景隐藏设置</p>
     * 
     * @param request AddContactHideBySceneSettingRequest
     * @return AddContactHideBySceneSettingResponse
     */
    public AddContactHideBySceneSettingResponse addContactHideBySceneSetting(AddContactHideBySceneSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddContactHideBySceneSettingHeaders headers = new AddContactHideBySceneSettingHeaders();
        return this.addContactHideBySceneSettingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加员工属性分场景隐藏设置</p>
     * 
     * @param request AddEmpAttributeHideBySceneSettingRequest
     * @param headers AddEmpAttributeHideBySceneSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddEmpAttributeHideBySceneSettingResponse
     */
    public AddEmpAttributeHideBySceneSettingResponse addEmpAttributeHideBySceneSettingWithOptions(AddEmpAttributeHideBySceneSettingRequest request, AddEmpAttributeHideBySceneSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.chatSubtitleConfig)) {
            body.put("chatSubtitleConfig", request.chatSubtitleConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeDeptIds)) {
            body.put("excludeDeptIds", request.excludeDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeTagIds)) {
            body.put("excludeTagIds", request.excludeTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeUserIds)) {
            body.put("excludeUserIds", request.excludeUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideFields)) {
            body.put("hideFields", request.hideFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectDeptIds)) {
            body.put("objectDeptIds", request.objectDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectTagIds)) {
            body.put("objectTagIds", request.objectTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectUserIds)) {
            body.put("objectUserIds", request.objectUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.profileSceneConfig)) {
            body.put("profileSceneConfig", request.profileSceneConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchSceneConfig)) {
            body.put("searchSceneConfig", request.searchSceneConfig);
        }

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
            new TeaPair("action", "AddEmpAttributeHideBySceneSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/empAttributes/hides/settings"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddEmpAttributeHideBySceneSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加员工属性分场景隐藏设置</p>
     * 
     * @param request AddEmpAttributeHideBySceneSettingRequest
     * @return AddEmpAttributeHideBySceneSettingResponse
     */
    public AddEmpAttributeHideBySceneSettingResponse addEmpAttributeHideBySceneSetting(AddEmpAttributeHideBySceneSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddEmpAttributeHideBySceneSettingHeaders headers = new AddEmpAttributeHideBySceneSettingHeaders();
        return this.addEmpAttributeHideBySceneSettingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增企业账号工作状态</p>
     * 
     * @param request AddOrgAccountOwnnessRequest
     * @param headers AddOrgAccountOwnnessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddOrgAccountOwnnessResponse
     */
    public AddOrgAccountOwnnessResponse addOrgAccountOwnnessWithOptions(AddOrgAccountOwnnessRequest request, AddOrgAccountOwnnessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownenssType)) {
            body.put("ownenssType", request.ownenssType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownnessId)) {
            body.put("ownnessId", request.ownnessId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
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
            new TeaPair("action", "AddOrgAccountOwnness"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/owness"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddOrgAccountOwnnessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增企业账号工作状态</p>
     * 
     * @param request AddOrgAccountOwnnessRequest
     * @return AddOrgAccountOwnnessResponse
     */
    public AddOrgAccountOwnnessResponse addOrgAccountOwnness(AddOrgAccountOwnnessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddOrgAccountOwnnessHeaders headers = new AddOrgAccountOwnnessHeaders();
        return this.addOrgAccountOwnnessWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>年检认证审核</p>
     * 
     * @param request AnnualCertificationAuditRequest
     * @param headers AnnualCertificationAuditHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AnnualCertificationAuditResponse
     */
    public AnnualCertificationAuditResponse annualCertificationAuditWithOptions(AnnualCertificationAuditRequest request, AnnualCertificationAuditHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.applicantMobile)) {
            body.put("applicantMobile", request.applicantMobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.applicantName)) {
            body.put("applicantName", request.applicantName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.applicationLetter)) {
            body.put("applicationLetter", request.applicationLetter);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authStatus)) {
            body.put("authStatus", request.authStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.certificateType)) {
            body.put("certificateType", request.certificateType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpName)) {
            body.put("corpName", request.corpName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.depositaryBank)) {
            body.put("depositaryBank", request.depositaryBank);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalPerson)) {
            body.put("legalPerson", request.legalPerson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.licenseNumber)) {
            body.put("licenseNumber", request.licenseNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.licenseUrl)) {
            body.put("licenseUrl", request.licenseUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.publicAccount)) {
            body.put("publicAccount", request.publicAccount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reasonCode)) {
            body.put("reasonCode", request.reasonCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reasonMsg)) {
            body.put("reasonMsg", request.reasonMsg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tag)) {
            body.put("tag", request.tag);
        }

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
            new TeaPair("action", "AnnualCertificationAudit"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/organizations/authorities/audit"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AnnualCertificationAuditResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>年检认证审核</p>
     * 
     * @param request AnnualCertificationAuditRequest
     * @return AnnualCertificationAuditResponse
     */
    public AnnualCertificationAuditResponse annualCertificationAudit(AnnualCertificationAuditRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AnnualCertificationAuditHeaders headers = new AnnualCertificationAuditHeaders();
        return this.annualCertificationAuditWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量同意(合作空间/集团)的关联申请</p>
     * 
     * @param request BatchApproveUnionApplyRequest
     * @param headers BatchApproveUnionApplyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchApproveUnionApplyResponse
     */
    public BatchApproveUnionApplyResponse batchApproveUnionApplyWithOptions(BatchApproveUnionApplyRequest request, BatchApproveUnionApplyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchApproveUnionApply"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cooperateCorps/unionApplications/approve"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchApproveUnionApplyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量同意(合作空间/集团)的关联申请</p>
     * 
     * @param request BatchApproveUnionApplyRequest
     * @return BatchApproveUnionApplyResponse
     */
    public BatchApproveUnionApplyResponse batchApproveUnionApply(BatchApproveUnionApplyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchApproveUnionApplyHeaders headers = new BatchApproveUnionApplyHeaders();
        return this.batchApproveUnionApplyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量修改企业员工对外职位信息</p>
     * 
     * @param request BatchUpdateExternalTitleRequest
     * @param headers BatchUpdateExternalTitleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchUpdateExternalTitleResponse
     */
    public BatchUpdateExternalTitleResponse batchUpdateExternalTitleWithOptions(BatchUpdateExternalTitleRequest request, BatchUpdateExternalTitleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.updateTitleModelList)) {
            body.put("updateTitleModelList", request.updateTitleModelList);
        }

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
            new TeaPair("action", "BatchUpdateExternalTitle"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/externalTitles"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchUpdateExternalTitleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量修改企业员工对外职位信息</p>
     * 
     * @param request BatchUpdateExternalTitleRequest
     * @return BatchUpdateExternalTitleResponse
     */
    public BatchUpdateExternalTitleResponse batchUpdateExternalTitle(BatchUpdateExternalTitleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchUpdateExternalTitleHeaders headers = new BatchUpdateExternalTitleHeaders();
        return this.batchUpdateExternalTitleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改钉钉号</p>
     * 
     * @param request ChangeDingTalkIdRequest
     * @param headers ChangeDingTalkIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChangeDingTalkIdResponse
     */
    public ChangeDingTalkIdResponse changeDingTalkIdWithOptions(ChangeDingTalkIdRequest request, ChangeDingTalkIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingTalkId)) {
            body.put("dingTalkId", request.dingTalkId);
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
            new TeaPair("action", "ChangeDingTalkId"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/dingTalkIds/change"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChangeDingTalkIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改钉钉号</p>
     * 
     * @param request ChangeDingTalkIdRequest
     * @return ChangeDingTalkIdResponse
     */
    public ChangeDingTalkIdResponse changeDingTalkId(ChangeDingTalkIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChangeDingTalkIdHeaders headers = new ChangeDingTalkIdHeaders();
        return this.changeDingTalkIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>专属帐号转交主管理员(创建者)</p>
     * 
     * @param request ChangeMainAdminRequest
     * @param headers ChangeMainAdminHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChangeMainAdminResponse
     */
    public ChangeMainAdminResponse changeMainAdminWithOptions(ChangeMainAdminRequest request, ChangeMainAdminHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.effectCorpId)) {
            body.put("effectCorpId", request.effectCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceUserId)) {
            body.put("sourceUserId", request.sourceUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetUserId)) {
            body.put("targetUserId", request.targetUserId);
        }

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
            new TeaPair("action", "ChangeMainAdmin"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/mainAdministrators/change"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChangeMainAdminResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>专属帐号转交主管理员(创建者)</p>
     * 
     * @param request ChangeMainAdminRequest
     * @return ChangeMainAdminResponse
     */
    public ChangeMainAdminResponse changeMainAdmin(ChangeMainAdminRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChangeMainAdminHeaders headers = new ChangeMainAdminHeaders();
        return this.changeMainAdminWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>考证上钉-isv-证书颁发接口</p>
     * 
     * @param request CourseFinishCourseRequest
     * @param headers CourseFinishCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CourseFinishCourseResponse
     */
    public CourseFinishCourseResponse courseFinishCourseWithOptions(CourseFinishCourseRequest request, CourseFinishCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.certId)) {
            body.put("certId", request.certId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.certMediaBase64)) {
            body.put("certMediaBase64", request.certMediaBase64);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseId)) {
            body.put("courseId", request.courseId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
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
            new TeaPair("action", "CourseFinishCourse"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/course/finishCourse"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CourseFinishCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>考证上钉-isv-证书颁发接口</p>
     * 
     * @param request CourseFinishCourseRequest
     * @return CourseFinishCourseResponse
     */
    public CourseFinishCourseResponse courseFinishCourse(CourseFinishCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CourseFinishCourseHeaders headers = new CourseFinishCourseHeaders();
        return this.courseFinishCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建合作空间</p>
     * 
     * @param request CreateCooperateOrgRequest
     * @param headers CreateCooperateOrgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCooperateOrgResponse
     */
    public CreateCooperateOrgResponse createCooperateOrgWithOptions(CreateCooperateOrgRequest request, CreateCooperateOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.industryCode)) {
            body.put("industryCode", request.industryCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.logoMediaId)) {
            body.put("logoMediaId", request.logoMediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgName)) {
            body.put("orgName", request.orgName);
        }

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
            new TeaPair("action", "CreateCooperateOrg"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cooperateCorps"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCooperateOrgResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建合作空间</p>
     * 
     * @param request CreateCooperateOrgRequest
     * @return CreateCooperateOrgResponse
     */
    public CreateCooperateOrgResponse createCooperateOrg(CreateCooperateOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCooperateOrgHeaders headers = new CreateCooperateOrgHeaders();
        return this.createCooperateOrgWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建管理组</p>
     * 
     * @param request CreateManagementGroupRequest
     * @param headers CreateManagementGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateManagementGroupResponse
     */
    public CreateManagementGroupResponse createManagementGroupWithOptions(CreateManagementGroupRequest request, CreateManagementGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resourceIds)) {
            body.put("resourceIds", request.resourceIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

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
            new TeaPair("action", "CreateManagementGroup"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/managementGroups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateManagementGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建管理组</p>
     * 
     * @param request CreateManagementGroupRequest
     * @return CreateManagementGroupResponse
     */
    public CreateManagementGroupResponse createManagementGroup(CreateManagementGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateManagementGroupHeaders headers = new CreateManagementGroupHeaders();
        return this.createManagementGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>子管理员创建管理组</p>
     * 
     * @param request CreateSecondaryManagementGroupRequest
     * @param headers CreateSecondaryManagementGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateSecondaryManagementGroupResponse
     */
    public CreateSecondaryManagementGroupResponse createSecondaryManagementGroupWithOptions(CreateSecondaryManagementGroupRequest request, CreateSecondaryManagementGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resourceIds)) {
            body.put("resourceIds", request.resourceIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

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
            new TeaPair("action", "CreateSecondaryManagementGroup"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/secondaryAdministrators/managementGroups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateSecondaryManagementGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>子管理员创建管理组</p>
     * 
     * @param request CreateSecondaryManagementGroupRequest
     * @return CreateSecondaryManagementGroupResponse
     */
    public CreateSecondaryManagementGroupResponse createSecondaryManagementGroup(CreateSecondaryManagementGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSecondaryManagementGroupHeaders headers = new CreateSecondaryManagementGroupHeaders();
        return this.createSecondaryManagementGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除账号映射</p>
     * 
     * @param request DelAccountMappingRequest
     * @param headers DelAccountMappingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DelAccountMappingResponse
     */
    public DelAccountMappingResponse delAccountMappingWithOptions(DelAccountMappingRequest request, DelAccountMappingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.domain)) {
            query.put("domain", request.domain);
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
            new TeaPair("action", "DelAccountMapping"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/accountMappings"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DelAccountMappingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除账号映射</p>
     * 
     * @param request DelAccountMappingRequest
     * @return DelAccountMappingResponse
     */
    public DelAccountMappingResponse delAccountMapping(DelAccountMappingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DelAccountMappingHeaders headers = new DelAccountMappingHeaders();
        return this.delAccountMappingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除企业账号工作状态</p>
     * 
     * @param request DelOrgAccUserOwnnessRequest
     * @param headers DelOrgAccUserOwnnessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DelOrgAccUserOwnnessResponse
     */
    public DelOrgAccUserOwnnessResponse delOrgAccUserOwnnessWithOptions(DelOrgAccUserOwnnessRequest request, DelOrgAccUserOwnnessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ownenssType)) {
            query.put("ownenssType", request.ownenssType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownnessId)) {
            query.put("ownnessId", request.ownnessId);
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
            new TeaPair("action", "DelOrgAccUserOwnness"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/ownness"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DelOrgAccUserOwnnessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除企业账号工作状态</p>
     * 
     * @param request DelOrgAccUserOwnnessRequest
     * @return DelOrgAccUserOwnnessResponse
     */
    public DelOrgAccUserOwnnessResponse delOrgAccUserOwnness(DelOrgAccUserOwnnessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DelOrgAccUserOwnnessHeaders headers = new DelOrgAccUserOwnnessHeaders();
        return this.delOrgAccUserOwnnessWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除通讯录组织架构分场景隐藏设置</p>
     * 
     * @param headers DeleteContactHideBySceneSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteContactHideBySceneSettingResponse
     */
    public DeleteContactHideBySceneSettingResponse deleteContactHideBySceneSettingWithOptions(String settingId, DeleteContactHideBySceneSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteContactHideBySceneSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/organizations/hides/settings/" + settingId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteContactHideBySceneSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除通讯录组织架构分场景隐藏设置</p>
     * @return DeleteContactHideBySceneSettingResponse
     */
    public DeleteContactHideBySceneSettingResponse deleteContactHideBySceneSetting(String settingId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteContactHideBySceneSettingHeaders headers = new DeleteContactHideBySceneSettingHeaders();
        return this.deleteContactHideBySceneSettingWithOptions(settingId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除通讯录隐藏设置</p>
     * 
     * @param headers DeleteContactHideSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteContactHideSettingResponse
     */
    public DeleteContactHideSettingResponse deleteContactHideSettingWithOptions(String settingId, DeleteContactHideSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteContactHideSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/contactHideSettings/" + settingId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteContactHideSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除通讯录隐藏设置</p>
     * @return DeleteContactHideSettingResponse
     */
    public DeleteContactHideSettingResponse deleteContactHideSetting(String settingId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteContactHideSettingHeaders headers = new DeleteContactHideSettingHeaders();
        return this.deleteContactHideSettingWithOptions(settingId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除限制查看通讯录设置</p>
     * 
     * @param headers DeleteContactRestrictSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteContactRestrictSettingResponse
     */
    public DeleteContactRestrictSettingResponse deleteContactRestrictSettingWithOptions(String settingId, DeleteContactRestrictSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteContactRestrictSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/restrictions/settings/" + settingId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteContactRestrictSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除限制查看通讯录设置</p>
     * @return DeleteContactRestrictSettingResponse
     */
    public DeleteContactRestrictSettingResponse deleteContactRestrictSetting(String settingId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteContactRestrictSettingHeaders headers = new DeleteContactRestrictSettingHeaders();
        return this.deleteContactRestrictSettingWithOptions(settingId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除员工属性分场景隐藏设置</p>
     * 
     * @param headers DeleteEmpAttributeHideBySceneSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteEmpAttributeHideBySceneSettingResponse
     */
    public DeleteEmpAttributeHideBySceneSettingResponse deleteEmpAttributeHideBySceneSettingWithOptions(String settingId, DeleteEmpAttributeHideBySceneSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteEmpAttributeHideBySceneSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/empAttributes/hides/settings/" + settingId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteEmpAttributeHideBySceneSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除员工属性分场景隐藏设置</p>
     * @return DeleteEmpAttributeHideBySceneSettingResponse
     */
    public DeleteEmpAttributeHideBySceneSettingResponse deleteEmpAttributeHideBySceneSetting(String settingId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteEmpAttributeHideBySceneSettingHeaders headers = new DeleteEmpAttributeHideBySceneSettingHeaders();
        return this.deleteEmpAttributeHideBySceneSettingWithOptions(settingId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除员工字段可见性设置</p>
     * 
     * @param headers DeleteEmpAttributeVisibilityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteEmpAttributeVisibilityResponse
     */
    public DeleteEmpAttributeVisibilityResponse deleteEmpAttributeVisibilityWithOptions(String settingId, DeleteEmpAttributeVisibilityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteEmpAttributeVisibility"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/staffAttributes/visibilitySettings/" + settingId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteEmpAttributeVisibilityResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除员工字段可见性设置</p>
     * @return DeleteEmpAttributeVisibilityResponse
     */
    public DeleteEmpAttributeVisibilityResponse deleteEmpAttributeVisibility(String settingId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteEmpAttributeVisibilityHeaders headers = new DeleteEmpAttributeVisibilityHeaders();
        return this.deleteEmpAttributeVisibilityWithOptions(settingId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除管理组</p>
     * 
     * @param headers DeleteManagementGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteManagementGroupResponse
     */
    public DeleteManagementGroupResponse deleteManagementGroupWithOptions(String groupId, DeleteManagementGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteManagementGroup"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/managementGroups/" + groupId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteManagementGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除管理组</p>
     * @return DeleteManagementGroupResponse
     */
    public DeleteManagementGroupResponse deleteManagementGroup(String groupId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteManagementGroupHeaders headers = new DeleteManagementGroupHeaders();
        return this.deleteManagementGroupWithOptions(groupId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取账号映射</p>
     * 
     * @param request GetAccountMappingRequest
     * @param headers GetAccountMappingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAccountMappingResponse
     */
    public GetAccountMappingResponse getAccountMappingWithOptions(GetAccountMappingRequest request, GetAccountMappingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.domain)) {
            query.put("domain", request.domain);
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
            new TeaPair("action", "GetAccountMapping"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/accountMappings"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAccountMappingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取账号映射</p>
     * 
     * @param request GetAccountMappingRequest
     * @return GetAccountMappingResponse
     */
    public GetAccountMappingResponse getAccountMapping(GetAccountMappingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAccountMappingHeaders headers = new GetAccountMappingHeaders();
        return this.getAccountMappingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业的邀请信息，如果传部门ID则邀请链接为邀请加入部门，否则加入根部门；如果企业未开启邀请或者链接申请加入邀请链接为null</p>
     * 
     * @param request GetApplyInviteInfoRequest
     * @param headers GetApplyInviteInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetApplyInviteInfoResponse
     */
    public GetApplyInviteInfoResponse getApplyInviteInfoWithOptions(GetApplyInviteInfoRequest request, GetApplyInviteInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inviterUserId)) {
            query.put("inviterUserId", request.inviterUserId);
        }

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
            new TeaPair("action", "GetApplyInviteInfo"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/invites/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetApplyInviteInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业的邀请信息，如果传部门ID则邀请链接为邀请加入部门，否则加入根部门；如果企业未开启邀请或者链接申请加入邀请链接为null</p>
     * 
     * @param request GetApplyInviteInfoRequest
     * @return GetApplyInviteInfoResponse
     */
    public GetApplyInviteInfoResponse getApplyInviteInfo(GetApplyInviteInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetApplyInviteInfoHeaders headers = new GetApplyInviteInfoHeaders();
        return this.getApplyInviteInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分支授权主干的行业数据</p>
     * 
     * @param request GetBranchAuthDataRequest
     * @param headers GetBranchAuthDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetBranchAuthDataResponse
     */
    public GetBranchAuthDataResponse getBranchAuthDataWithOptions(GetBranchAuthDataRequest request, GetBranchAuthDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.branchCorpId)) {
            query.put("branchCorpId", request.branchCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.body)) {
            body.put("body", request.body);
        }

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
            new TeaPair("action", "GetBranchAuthData"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/branchAuthDatas/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetBranchAuthDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分支授权主干的行业数据</p>
     * 
     * @param request GetBranchAuthDataRequest
     * @return GetBranchAuthDataResponse
     */
    public GetBranchAuthDataResponse getBranchAuthData(GetBranchAuthDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetBranchAuthDataHeaders headers = new GetBranchAuthDataHeaders();
        return this.getBranchAuthDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户名片夹中的某张名片信息</p>
     * 
     * @param headers GetCardInUserHolderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCardInUserHolderResponse
     */
    public GetCardInUserHolderResponse getCardInUserHolderWithOptions(String cardId, GetCardInUserHolderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetCardInUserHolder"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cards/holders/infos/" + cardId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCardInUserHolderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户名片夹中的某张名片信息</p>
     * @return GetCardInUserHolderResponse
     */
    public GetCardInUserHolderResponse getCardInUserHolder(String cardId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCardInUserHolderHeaders headers = new GetCardInUserHolderHeaders();
        return this.getCardInUserHolderWithOptions(cardId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户名片信息</p>
     * 
     * @param headers GetCardInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCardInfoResponse
     */
    public GetCardInfoResponse getCardInfoWithOptions(String cardId, GetCardInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetCardInfo"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cards/infos/" + cardId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCardInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户名片信息</p>
     * @return GetCardInfoResponse
     */
    public GetCardInfoResponse getCardInfo(String cardId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCardInfoHeaders headers = new GetCardInfoHeaders();
        return this.getCardInfoWithOptions(cardId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取通讯录组织架构分场景隐藏设置</p>
     * 
     * @param headers GetContactHideBySceneSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetContactHideBySceneSettingResponse
     */
    public GetContactHideBySceneSettingResponse getContactHideBySceneSettingWithOptions(String settingId, GetContactHideBySceneSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetContactHideBySceneSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/organizations/hides/settings/" + settingId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetContactHideBySceneSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取通讯录组织架构分场景隐藏设置</p>
     * @return GetContactHideBySceneSettingResponse
     */
    public GetContactHideBySceneSettingResponse getContactHideBySceneSetting(String settingId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetContactHideBySceneSettingHeaders headers = new GetContactHideBySceneSettingHeaders();
        return this.getContactHideBySceneSettingWithOptions(settingId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取邀请加入合作空间链接，分享链接之后企业可以申请加入</p>
     * 
     * @param headers GetCooperateOrgInviteInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCooperateOrgInviteInfoResponse
     */
    public GetCooperateOrgInviteInfoResponse getCooperateOrgInviteInfoWithOptions(String cooperateCorpId, GetCooperateOrgInviteInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetCooperateOrgInviteInfo"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cooperateCorps/" + cooperateCorpId + "/inviteInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCooperateOrgInviteInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取邀请加入合作空间链接，分享链接之后企业可以申请加入</p>
     * @return GetCooperateOrgInviteInfoResponse
     */
    public GetCooperateOrgInviteInfoResponse getCooperateOrgInviteInfo(String cooperateCorpId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCooperateOrgInviteInfoHeaders headers = new GetCooperateOrgInviteInfoHeaders();
        return this.getCooperateOrgInviteInfoWithOptions(cooperateCorpId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业模板列表</p>
     * 
     * @param headers GetCorpCardStyleListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCorpCardStyleListResponse
     */
    public GetCorpCardStyleListResponse getCorpCardStyleListWithOptions(GetCorpCardStyleListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetCorpCardStyleList"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cards/styles/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCorpCardStyleListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业模板列表</p>
     * @return GetCorpCardStyleListResponse
     */
    public GetCorpCardStyleListResponse getCorpCardStyleList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCorpCardStyleListHeaders headers = new GetCorpCardStyleListHeaders();
        return this.getCorpCardStyleListWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>普通帐号迁移为专属帐号后，根据迁移后的dingId查询原dingId</p>
     * 
     * @param request GetDingIdByMigrationDingIdRequest
     * @param headers GetDingIdByMigrationDingIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDingIdByMigrationDingIdResponse
     */
    public GetDingIdByMigrationDingIdResponse getDingIdByMigrationDingIdWithOptions(GetDingIdByMigrationDingIdRequest request, GetDingIdByMigrationDingIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.migrationDingId)) {
            query.put("migrationDingId", request.migrationDingId);
        }

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
            new TeaPair("action", "GetDingIdByMigrationDingId"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccount/getDingIdByMigrationDingIds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDingIdByMigrationDingIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>普通帐号迁移为专属帐号后，根据迁移后的dingId查询原dingId</p>
     * 
     * @param request GetDingIdByMigrationDingIdRequest
     * @return GetDingIdByMigrationDingIdResponse
     */
    public GetDingIdByMigrationDingIdResponse getDingIdByMigrationDingId(GetDingIdByMigrationDingIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDingIdByMigrationDingIdHeaders headers = new GetDingIdByMigrationDingIdHeaders();
        return this.getDingIdByMigrationDingIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取员工属性分场景隐藏设置</p>
     * 
     * @param headers GetEmpAttributeHideBySceneSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetEmpAttributeHideBySceneSettingResponse
     */
    public GetEmpAttributeHideBySceneSettingResponse getEmpAttributeHideBySceneSettingWithOptions(String settingId, GetEmpAttributeHideBySceneSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetEmpAttributeHideBySceneSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/empAttributes/hides/settings/" + settingId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetEmpAttributeHideBySceneSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取员工属性分场景隐藏设置</p>
     * @return GetEmpAttributeHideBySceneSettingResponse
     */
    public GetEmpAttributeHideBySceneSettingResponse getEmpAttributeHideBySceneSetting(String settingId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEmpAttributeHideBySceneSettingHeaders headers = new GetEmpAttributeHideBySceneSettingHeaders();
        return this.getEmpAttributeHideBySceneSettingWithOptions(settingId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业最新的钉钉指数</p>
     * 
     * @param headers GetLatestDingIndexHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetLatestDingIndexResponse
     */
    public GetLatestDingIndexResponse getLatestDingIndexWithOptions(GetLatestDingIndexHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetLatestDingIndex"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/dingIndexs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetLatestDingIndexResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业最新的钉钉指数</p>
     * @return GetLatestDingIndexResponse
     */
    public GetLatestDingIndexResponse getLatestDingIndex() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetLatestDingIndexHeaders headers = new GetLatestDingIndexHeaders();
        return this.getLatestDingIndexWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>普通帐号迁移为专属帐号后，根据原dingId查询迁移后的dingId</p>
     * 
     * @param request GetMigrationDingIdByDingIdRequest
     * @param headers GetMigrationDingIdByDingIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMigrationDingIdByDingIdResponse
     */
    public GetMigrationDingIdByDingIdResponse getMigrationDingIdByDingIdWithOptions(GetMigrationDingIdByDingIdRequest request, GetMigrationDingIdByDingIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingId)) {
            query.put("dingId", request.dingId);
        }

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
            new TeaPair("action", "GetMigrationDingIdByDingId"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccount/getMigrationDingIdByDingIds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMigrationDingIdByDingIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>普通帐号迁移为专属帐号后，根据原dingId查询迁移后的dingId</p>
     * 
     * @param request GetMigrationDingIdByDingIdRequest
     * @return GetMigrationDingIdByDingIdResponse
     */
    public GetMigrationDingIdByDingIdResponse getMigrationDingIdByDingId(GetMigrationDingIdByDingIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMigrationDingIdByDingIdHeaders headers = new GetMigrationDingIdByDingIdHeaders();
        return this.getMigrationDingIdByDingIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>普通帐号迁移为专属帐号后，根据原unionId查询迁移后的unionId</p>
     * 
     * @param request GetMigrationUnionIdByUnionIdRequest
     * @param headers GetMigrationUnionIdByUnionIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMigrationUnionIdByUnionIdResponse
     */
    public GetMigrationUnionIdByUnionIdResponse getMigrationUnionIdByUnionIdWithOptions(GetMigrationUnionIdByUnionIdRequest request, GetMigrationUnionIdByUnionIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "GetMigrationUnionIdByUnionId"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMigrationUnionIdByUnionIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>普通帐号迁移为专属帐号后，根据原unionId查询迁移后的unionId</p>
     * 
     * @param request GetMigrationUnionIdByUnionIdRequest
     * @return GetMigrationUnionIdByUnionIdResponse
     */
    public GetMigrationUnionIdByUnionIdResponse getMigrationUnionIdByUnionId(GetMigrationUnionIdByUnionIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMigrationUnionIdByUnionIdHeaders headers = new GetMigrationUnionIdByUnionIdHeaders();
        return this.getMigrationUnionIdByUnionIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业认证信息</p>
     * 
     * @param request GetOrgAuthInfoRequest
     * @param headers GetOrgAuthInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOrgAuthInfoResponse
     */
    public GetOrgAuthInfoResponse getOrgAuthInfoWithOptions(GetOrgAuthInfoRequest request, GetOrgAuthInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            query.put("targetCorpId", request.targetCorpId);
        }

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
            new TeaPair("action", "GetOrgAuthInfo"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/organizations/authInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOrgAuthInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业认证信息</p>
     * 
     * @param request GetOrgAuthInfoRequest
     * @return GetOrgAuthInfoResponse
     */
    public GetOrgAuthInfoResponse getOrgAuthInfo(GetOrgAuthInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOrgAuthInfoHeaders headers = new GetOrgAuthInfoHeaders();
        return this.getOrgAuthInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取异步文件内容转译结果</p>
     * 
     * @param request GetTranslateFileJobResultRequest
     * @param headers GetTranslateFileJobResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTranslateFileJobResultResponse
     */
    public GetTranslateFileJobResultResponse getTranslateFileJobResultWithOptions(GetTranslateFileJobResultRequest request, GetTranslateFileJobResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.jobId)) {
            query.put("jobId", request.jobId);
        }

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
            new TeaPair("action", "GetTranslateFileJobResult"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/files/translateResults"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTranslateFileJobResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取异步文件内容转译结果</p>
     * 
     * @param request GetTranslateFileJobResultRequest
     * @return GetTranslateFileJobResultResponse
     */
    public GetTranslateFileJobResultResponse getTranslateFileJobResult(GetTranslateFileJobResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTranslateFileJobResultHeaders headers = new GetTranslateFileJobResultHeaders();
        return this.getTranslateFileJobResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>普通帐号迁移为专属帐号后，根据迁移后的unionId查询原unionId</p>
     * 
     * @param request GetUnionIdByMigrationUnionIdRequest
     * @param headers GetUnionIdByMigrationUnionIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUnionIdByMigrationUnionIdResponse
     */
    public GetUnionIdByMigrationUnionIdResponse getUnionIdByMigrationUnionIdWithOptions(GetUnionIdByMigrationUnionIdRequest request, GetUnionIdByMigrationUnionIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.migrationUnionId)) {
            query.put("migrationUnionId", request.migrationUnionId);
        }

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
            new TeaPair("action", "GetUnionIdByMigrationUnionId"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUnionIdByMigrationUnionIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>普通帐号迁移为专属帐号后，根据迁移后的unionId查询原unionId</p>
     * 
     * @param request GetUnionIdByMigrationUnionIdRequest
     * @return GetUnionIdByMigrationUnionIdResponse
     */
    public GetUnionIdByMigrationUnionIdResponse getUnionIdByMigrationUnionId(GetUnionIdByMigrationUnionIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUnionIdByMigrationUnionIdHeaders headers = new GetUnionIdByMigrationUnionIdHeaders();
        return this.getUnionIdByMigrationUnionIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户个人信息</p>
     * 
     * @param headers GetUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserResponse
     */
    public GetUserResponse getUserWithOptions(String unionId, GetUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetUser"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/users/" + unionId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户个人信息</p>
     * @return GetUserResponse
     */
    public GetUserResponse getUser(String unionId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserHeaders headers = new GetUserHeaders();
        return this.getUserWithOptions(unionId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户名片夹信息</p>
     * 
     * @param request GetUserCardHolderListRequest
     * @param headers GetUserCardHolderListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserCardHolderListResponse
     */
    public GetUserCardHolderListResponse getUserCardHolderListWithOptions(GetUserCardHolderListRequest request, GetUserCardHolderListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetUserCardHolderList"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cards/holders/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserCardHolderListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户名片夹信息</p>
     * 
     * @param request GetUserCardHolderListRequest
     * @return GetUserCardHolderListResponse
     */
    public GetUserCardHolderListResponse getUserCardHolderList(GetUserCardHolderListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserCardHolderListHeaders headers = new GetUserCardHolderListHeaders();
        return this.getUserCardHolderListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>初始化核身事件</p>
     * 
     * @param request InitVerifyEventRequest
     * @param headers InitVerifyEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InitVerifyEventResponse
     */
    public InitVerifyEventResponse initVerifyEventWithOptions(InitVerifyEventRequest request, InitVerifyEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callerDeviceId)) {
            body.put("callerDeviceId", request.callerDeviceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.factorCodeList)) {
            body.put("factorCodeList", request.factorCodeList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.state)) {
            body.put("state", request.state);
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
            new TeaPair("action", "InitVerifyEvent"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/verifyIdentities/verifyEvents/init"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InitVerifyEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>初始化核身事件</p>
     * 
     * @param request InitVerifyEventRequest
     * @return InitVerifyEventResponse
     */
    public InitVerifyEventResponse initVerifyEvent(InitVerifyEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InitVerifyEventHeaders headers = new InitVerifyEventHeaders();
        return this.initVerifyEventWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>判断某用户跟给定专属账号是否存在好友关系</p>
     * 
     * @param request IsFriendRequest
     * @param headers IsFriendHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IsFriendResponse
     */
    public IsFriendResponse isFriendWithOptions(IsFriendRequest request, IsFriendHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mobileNo)) {
            body.put("mobileNo", request.mobileNo);
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
            new TeaPair("action", "IsFriend"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/relationships/friends/judge"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IsFriendResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>判断某用户跟给定专属账号是否存在好友关系</p>
     * 
     * @param request IsFriendRequest
     * @return IsFriendResponse
     */
    public IsFriendResponse isFriend(IsFriendRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IsFriendHeaders headers = new IsFriendHeaders();
        return this.isFriendWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>名片事件推送</p>
     * 
     * @param request IsvCardEventPushRequest
     * @param headers IsvCardEventPushHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IsvCardEventPushResponse
     */
    public IsvCardEventPushResponse isvCardEventPushWithOptions(IsvCardEventPushRequest request, IsvCardEventPushHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isvCardId)) {
            query.put("isvCardId", request.isvCardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvToken)) {
            query.put("isvToken", request.isvToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvUid)) {
            query.put("isvUid", request.isvUid);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.eventParams)) {
            body.put("eventParams", request.eventParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventType)) {
            body.put("eventType", request.eventType);
        }

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
            new TeaPair("action", "IsvCardEventPush"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cards/events/push"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IsvCardEventPushResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>名片事件推送</p>
     * 
     * @param request IsvCardEventPushRequest
     * @return IsvCardEventPushResponse
     */
    public IsvCardEventPushResponse isvCardEventPush(IsvCardEventPushRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IsvCardEventPushHeaders headers = new IsvCardEventPushHeaders();
        return this.isvCardEventPushWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>拉取管理组基本信息列表分页接口</p>
     * 
     * @param request ListBasicRoleInPageRequest
     * @param headers ListBasicRoleInPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListBasicRoleInPageResponse
     */
    public ListBasicRoleInPageResponse listBasicRoleInPageWithOptions(ListBasicRoleInPageRequest request, ListBasicRoleInPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            query.put("agentId", request.agentId);
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
            new TeaPair("action", "ListBasicRoleInPage"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/rbac/administrativeGroups/baseInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListBasicRoleInPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>拉取管理组基本信息列表分页接口</p>
     * 
     * @param request ListBasicRoleInPageRequest
     * @return ListBasicRoleInPageResponse
     */
    public ListBasicRoleInPageResponse listBasicRoleInPage(ListBasicRoleInPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListBasicRoleInPageHeaders headers = new ListBasicRoleInPageHeaders();
        return this.listBasicRoleInPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取通讯录隐藏设置</p>
     * 
     * @param request ListContactHideSettingsRequest
     * @param headers ListContactHideSettingsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListContactHideSettingsResponse
     */
    public ListContactHideSettingsResponse listContactHideSettingsWithOptions(ListContactHideSettingsRequest request, ListContactHideSettingsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListContactHideSettings"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/contactHideSettings"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListContactHideSettingsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取通讯录隐藏设置</p>
     * 
     * @param request ListContactHideSettingsRequest
     * @return ListContactHideSettingsResponse
     */
    public ListContactHideSettingsResponse listContactHideSettings(ListContactHideSettingsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListContactHideSettingsHeaders headers = new ListContactHideSettingsHeaders();
        return this.listContactHideSettingsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取限制查看通讯录设置列表</p>
     * 
     * @param request ListContactRestrictSettingRequest
     * @param headers ListContactRestrictSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListContactRestrictSettingResponse
     */
    public ListContactRestrictSettingResponse listContactRestrictSettingWithOptions(ListContactRestrictSettingRequest request, ListContactRestrictSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListContactRestrictSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/restrictions/settings"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListContactRestrictSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取限制查看通讯录设置列表</p>
     * 
     * @param request ListContactRestrictSettingRequest
     * @return ListContactRestrictSettingResponse
     */
    public ListContactRestrictSettingResponse listContactRestrictSetting(ListContactRestrictSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListContactRestrictSettingHeaders headers = new ListContactRestrictSettingHeaders();
        return this.listContactRestrictSettingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取员工字段可见性设置</p>
     * 
     * @param request ListEmpAttributeVisibilityRequest
     * @param headers ListEmpAttributeVisibilityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListEmpAttributeVisibilityResponse
     */
    public ListEmpAttributeVisibilityResponse listEmpAttributeVisibilityWithOptions(ListEmpAttributeVisibilityRequest request, ListEmpAttributeVisibilityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListEmpAttributeVisibility"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/staffAttributes/visibilitySettings"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListEmpAttributeVisibilityResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取员工字段可见性设置</p>
     * 
     * @param request ListEmpAttributeVisibilityRequest
     * @return ListEmpAttributeVisibilityResponse
     */
    public ListEmpAttributeVisibilityResponse listEmpAttributeVisibility(ListEmpAttributeVisibilityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListEmpAttributeVisibilityHeaders headers = new ListEmpAttributeVisibilityHeaders();
        return this.listEmpAttributeVisibilityWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询离职记录</p>
     * 
     * @param request ListEmpLeaveRecordsRequest
     * @param headers ListEmpLeaveRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListEmpLeaveRecordsResponse
     */
    public ListEmpLeaveRecordsResponse listEmpLeaveRecordsWithOptions(ListEmpLeaveRecordsRequest request, ListEmpLeaveRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

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
            new TeaPair("action", "ListEmpLeaveRecords"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/empLeaveRecords"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListEmpLeaveRecordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询离职记录</p>
     * 
     * @param request ListEmpLeaveRecordsRequest
     * @return ListEmpLeaveRecordsResponse
     */
    public ListEmpLeaveRecordsResponse listEmpLeaveRecords(ListEmpLeaveRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListEmpLeaveRecordsHeaders headers = new ListEmpLeaveRecordsHeaders();
        return this.listEmpLeaveRecordsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询管理组</p>
     * 
     * @param request ListManagementGroupsRequest
     * @param headers ListManagementGroupsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListManagementGroupsResponse
     */
    public ListManagementGroupsResponse listManagementGroupsWithOptions(ListManagementGroupsRequest request, ListManagementGroupsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListManagementGroups"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/managementGroups"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListManagementGroupsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询管理组</p>
     * 
     * @param request ListManagementGroupsRequest
     * @return ListManagementGroupsResponse
     */
    public ListManagementGroupsResponse listManagementGroups(ListManagementGroupsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListManagementGroupsHeaders headers = new ListManagementGroupsHeaders();
        return this.listManagementGroupsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询专属帐号拥有的组织(作为创建者的组织)</p>
     * 
     * @param request ListOwnedOrgByStaffIdRequest
     * @param headers ListOwnedOrgByStaffIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListOwnedOrgByStaffIdResponse
     */
    public ListOwnedOrgByStaffIdResponse listOwnedOrgByStaffIdWithOptions(ListOwnedOrgByStaffIdRequest request, ListOwnedOrgByStaffIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListOwnedOrgByStaffId"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/ownedOrganizations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListOwnedOrgByStaffIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询专属帐号拥有的组织(作为创建者的组织)</p>
     * 
     * @param request ListOwnedOrgByStaffIdRequest
     * @return ListOwnedOrgByStaffIdResponse
     */
    public ListOwnedOrgByStaffIdResponse listOwnedOrgByStaffId(ListOwnedOrgByStaffIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListOwnedOrgByStaffIdHeaders headers = new ListOwnedOrgByStaffIdHeaders();
        return this.listOwnedOrgByStaffIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取员工高管设置</p>
     * 
     * @param request ListSeniorSettingsRequest
     * @param headers ListSeniorSettingsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListSeniorSettingsResponse
     */
    public ListSeniorSettingsResponse listSeniorSettingsWithOptions(ListSeniorSettingsRequest request, ListSeniorSettingsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.seniorStaffId)) {
            query.put("seniorStaffId", request.seniorStaffId);
        }

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
            new TeaPair("action", "ListSeniorSettings"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/seniorSettings"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListSeniorSettingsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取员工高管设置</p>
     * 
     * @param request ListSeniorSettingsRequest
     * @return ListSeniorSettingsResponse
     */
    public ListSeniorSettingsResponse listSeniorSettings(ListSeniorSettingsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSeniorSettingsHeaders headers = new ListSeniorSettingsHeaders();
        return this.listSeniorSettingsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新企业账号工作状态</p>
     * 
     * @param request ModifyOrgAccUserOwnnessRequest
     * @param headers ModifyOrgAccUserOwnnessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ModifyOrgAccUserOwnnessResponse
     */
    public ModifyOrgAccUserOwnnessResponse modifyOrgAccUserOwnnessWithOptions(ModifyOrgAccUserOwnnessRequest request, ModifyOrgAccUserOwnnessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownenssType)) {
            body.put("ownenssType", request.ownenssType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownnessId)) {
            body.put("ownnessId", request.ownnessId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
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
            new TeaPair("action", "ModifyOrgAccUserOwnness"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/owness"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ModifyOrgAccUserOwnnessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新企业账号工作状态</p>
     * 
     * @param request ModifyOrgAccUserOwnnessRequest
     * @return ModifyOrgAccUserOwnnessResponse
     */
    public ModifyOrgAccUserOwnnessResponse modifyOrgAccUserOwnness(ModifyOrgAccUserOwnnessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ModifyOrgAccUserOwnnessHeaders headers = new ModifyOrgAccUserOwnnessHeaders();
        return this.modifyOrgAccUserOwnnessWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>授权专属帐号可加入多组织</p>
     * 
     * @param request MultiOrgPermissionGrantRequest
     * @param headers MultiOrgPermissionGrantHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MultiOrgPermissionGrantResponse
     */
    public MultiOrgPermissionGrantResponse multiOrgPermissionGrantWithOptions(MultiOrgPermissionGrantRequest request, MultiOrgPermissionGrantHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.grantDeptIdList)) {
            body.put("grantDeptIdList", request.grantDeptIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.joinCorpId)) {
            body.put("joinCorpId", request.joinCorpId);
        }

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
            new TeaPair("action", "MultiOrgPermissionGrant"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/multiOrgPermissions/auth"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MultiOrgPermissionGrantResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>授权专属帐号可加入多组织</p>
     * 
     * @param request MultiOrgPermissionGrantRequest
     * @return MultiOrgPermissionGrantResponse
     */
    public MultiOrgPermissionGrantResponse multiOrgPermissionGrant(MultiOrgPermissionGrantRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MultiOrgPermissionGrantHeaders headers = new MultiOrgPermissionGrantHeaders();
        return this.multiOrgPermissionGrantWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>授权其他组织查看本组织的企业账号信息</p>
     * 
     * @param request OrgAccountMobileVisibleInOtherOrgRequest
     * @param headers OrgAccountMobileVisibleInOtherOrgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OrgAccountMobileVisibleInOtherOrgResponse
     */
    public OrgAccountMobileVisibleInOtherOrgResponse orgAccountMobileVisibleInOtherOrgWithOptions(OrgAccountMobileVisibleInOtherOrgRequest request, OrgAccountMobileVisibleInOtherOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fields)) {
            body.put("fields", request.fields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            body.put("optUserId", request.optUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toCorpIds)) {
            body.put("toCorpIds", request.toCorpIds);
        }

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
            new TeaPair("action", "OrgAccountMobileVisibleInOtherOrg"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/mobiles/visibleInOtherOrg"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OrgAccountMobileVisibleInOtherOrgResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>授权其他组织查看本组织的企业账号信息</p>
     * 
     * @param request OrgAccountMobileVisibleInOtherOrgRequest
     * @return OrgAccountMobileVisibleInOtherOrgResponse
     */
    public OrgAccountMobileVisibleInOtherOrgResponse orgAccountMobileVisibleInOtherOrg(OrgAccountMobileVisibleInOtherOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OrgAccountMobileVisibleInOtherOrgHeaders headers = new OrgAccountMobileVisibleInOtherOrgHeaders();
        return this.orgAccountMobileVisibleInOtherOrgWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新企业账号电话可见性</p>
     * 
     * @param request OrgAccountMobileVisiblePermissonRequest
     * @param headers OrgAccountMobileVisiblePermissonHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OrgAccountMobileVisiblePermissonResponse
     */
    public OrgAccountMobileVisiblePermissonResponse orgAccountMobileVisiblePermissonWithOptions(OrgAccountMobileVisiblePermissonRequest request, OrgAccountMobileVisiblePermissonHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", request.body)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "OrgAccountMobileVisiblePermisson"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/mobiles/visiblePermissions"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OrgAccountMobileVisiblePermissonResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新企业账号电话可见性</p>
     * 
     * @param request OrgAccountMobileVisiblePermissonRequest
     * @return OrgAccountMobileVisiblePermissonResponse
     */
    public OrgAccountMobileVisiblePermissonResponse orgAccountMobileVisiblePermisson(OrgAccountMobileVisiblePermissonRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OrgAccountMobileVisiblePermissonHeaders headers = new OrgAccountMobileVisiblePermissonHeaders();
        return this.orgAccountMobileVisiblePermissonWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据orgId获取企业信息</p>
     * 
     * @param tmpReq OrgInfoRequest
     * @param headers OrgInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OrgInfoResponse
     */
    public OrgInfoResponse orgInfoWithOptions(OrgInfoRequest tmpReq, OrgInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        OrgInfoShrinkRequest request = new OrgInfoShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.orgIds)) {
            request.orgIdsShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.orgIds, "orgIds", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orgIdsShrink)) {
            query.put("orgIds", request.orgIdsShrink);
        }

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
            new TeaPair("action", "OrgInfo"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/org/info"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OrgInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据orgId获取企业信息</p>
     * 
     * @param request OrgInfoRequest
     * @return OrgInfoResponse
     */
    public OrgInfoResponse orgInfo(OrgInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OrgInfoHeaders headers = new OrgInfoHeaders();
        return this.orgInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>给员工推送事件唤起核身组件</p>
     * 
     * @param request PushVerifyEventRequest
     * @param headers PushVerifyEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PushVerifyEventResponse
     */
    public PushVerifyEventResponse pushVerifyEventWithOptions(PushVerifyEventRequest request, PushVerifyEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callerDeviceId)) {
            body.put("callerDeviceId", request.callerDeviceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.factorCodeList)) {
            body.put("factorCodeList", request.factorCodeList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.state)) {
            body.put("state", request.state);
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
            new TeaPair("action", "PushVerifyEvent"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/verifyIdentities/verifyEvents/push"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PushVerifyEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>给员工推送事件唤起核身组件</p>
     * 
     * @param request PushVerifyEventRequest
     * @return PushVerifyEventResponse
     */
    public PushVerifyEventResponse pushVerifyEvent(PushVerifyEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PushVerifyEventHeaders headers = new PushVerifyEventHeaders();
        return this.pushVerifyEventWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询访客统计信息信息</p>
     * 
     * @param request QueryCardVisitorStatisticDataRequest
     * @param headers QueryCardVisitorStatisticDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCardVisitorStatisticDataResponse
     */
    public QueryCardVisitorStatisticDataResponse queryCardVisitorStatisticDataWithOptions(QueryCardVisitorStatisticDataRequest request, QueryCardVisitorStatisticDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryCardVisitorStatisticData"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cards/visitors/statistics"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCardVisitorStatisticDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询访客统计信息信息</p>
     * 
     * @param request QueryCardVisitorStatisticDataRequest
     * @return QueryCardVisitorStatisticDataResponse
     */
    public QueryCardVisitorStatisticDataResponse queryCardVisitorStatisticData(QueryCardVisitorStatisticDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCardVisitorStatisticDataHeaders headers = new QueryCardVisitorStatisticDataHeaders();
        return this.queryCardVisitorStatisticDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业模版的统计数据</p>
     * 
     * @param request QueryCorpStatisticDataRequest
     * @param headers QueryCorpStatisticDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCorpStatisticDataResponse
     */
    public QueryCorpStatisticDataResponse queryCorpStatisticDataWithOptions(QueryCorpStatisticDataRequest request, QueryCorpStatisticDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateIds)) {
            body.put("templateIds", request.templateIds);
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
            new TeaPair("action", "QueryCorpStatisticData"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cards/templates/statistics/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCorpStatisticDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业模版的统计数据</p>
     * 
     * @param request QueryCorpStatisticDataRequest
     * @return QueryCorpStatisticDataResponse
     */
    public QueryCorpStatisticDataResponse queryCorpStatisticData(QueryCorpStatisticDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCorpStatisticDataHeaders headers = new QueryCorpStatisticDataHeaders();
        return this.queryCorpStatisticDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业用户名片统计数据</p>
     * 
     * @param request QueryCorpUserStatisticRequest
     * @param headers QueryCorpUserStatisticHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCorpUserStatisticResponse
     */
    public QueryCorpUserStatisticResponse queryCorpUserStatisticWithOptions(QueryCorpUserStatisticRequest request, QueryCorpUserStatisticHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateIds)) {
            body.put("templateIds", request.templateIds);
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
            new TeaPair("action", "QueryCorpUserStatistic"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cards/users/statistics/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCorpUserStatisticResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业用户名片统计数据</p>
     * 
     * @param request QueryCorpUserStatisticRequest
     * @return QueryCorpUserStatisticResponse
     */
    public QueryCorpUserStatisticResponse queryCorpUserStatistic(QueryCorpUserStatisticRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCorpUserStatisticHeaders headers = new QueryCorpUserStatisticHeaders();
        return this.queryCorpUserStatisticWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询可管理资源的成员</p>
     * 
     * @param headers QueryResourceManagementMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryResourceManagementMembersResponse
     */
    public QueryResourceManagementMembersResponse queryResourceManagementMembersWithOptions(String resourceId, QueryResourceManagementMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryResourceManagementMembers"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/resources/" + resourceId + "/managementMembers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryResourceManagementMembersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询可管理资源的成员</p>
     * @return QueryResourceManagementMembersResponse
     */
    public QueryResourceManagementMembersResponse queryResourceManagementMembers(String resourceId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryResourceManagementMembersHeaders headers = new QueryResourceManagementMembersHeaders();
        return this.queryResourceManagementMembersWithOptions(resourceId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询专属帐号状态</p>
     * 
     * @param request QueryStatusRequest
     * @param headers QueryStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryStatusResponse
     */
    public QueryStatusResponse queryStatusWithOptions(QueryStatusRequest request, QueryStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryStatus"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/status"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询专属帐号状态</p>
     * 
     * @param request QueryStatusRequest
     * @return QueryStatusResponse
     */
    public QueryStatusResponse queryStatus(QueryStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryStatusHeaders headers = new QueryStatusHeaders();
        return this.queryStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户可以管理的资源</p>
     * 
     * @param headers QueryUserManagementResourcesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserManagementResourcesResponse
     */
    public QueryUserManagementResourcesResponse queryUserManagementResourcesWithOptions(String userId, QueryUserManagementResourcesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryUserManagementResources"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/users/" + userId + "/managemementResources"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserManagementResourcesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户可以管理的资源</p>
     * @return QueryUserManagementResourcesResponse
     */
    public QueryUserManagementResourcesResponse queryUserManagementResources(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserManagementResourcesHeaders headers = new QueryUserManagementResourcesHeaders();
        return this.queryUserManagementResourcesWithOptions(userId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>读取员工核身结果</p>
     * 
     * @param request QueryVerifyResultRequest
     * @param headers QueryVerifyResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryVerifyResultResponse
     */
    public QueryVerifyResultResponse queryVerifyResultWithOptions(QueryVerifyResultRequest request, QueryVerifyResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.verifyId)) {
            query.put("verifyId", request.verifyId);
        }

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
            new TeaPair("action", "QueryVerifyResult"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/verifyIdentities/verifyResults"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryVerifyResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>读取员工核身结果</p>
     * 
     * @param request QueryVerifyResultRequest
     * @return QueryVerifyResultResponse
     */
    public QueryVerifyResultResponse queryVerifyResult(QueryVerifyResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryVerifyResultHeaders headers = new QueryVerifyResultHeaders();
        return this.queryVerifyResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>撤回已经发出的团队邀请</p>
     * 
     * @param request RecallTeamInviteRequest
     * @param headers RecallTeamInviteHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RecallTeamInviteResponse
     */
    public RecallTeamInviteResponse recallTeamInviteWithOptions(RecallTeamInviteRequest request, RecallTeamInviteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
        }

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
            new TeaPair("action", "RecallTeamInvite"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/invites/recall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RecallTeamInviteResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>撤回已经发出的团队邀请</p>
     * 
     * @param request RecallTeamInviteRequest
     * @return RecallTeamInviteResponse
     */
    public RecallTeamInviteResponse recallTeamInvite(RecallTeamInviteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RecallTeamInviteHeaders headers = new RecallTeamInviteHeaders();
        return this.recallTeamInviteWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>搜索部门</p>
     * 
     * @param request SearchDepartmentRequest
     * @param headers SearchDepartmentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchDepartmentResponse
     */
    public SearchDepartmentResponse searchDepartmentWithOptions(SearchDepartmentRequest request, SearchDepartmentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.offset)) {
            body.put("offset", request.offset);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryWord)) {
            body.put("queryWord", request.queryWord);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            body.put("size", request.size);
        }

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
            new TeaPair("action", "SearchDepartment"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/departments/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchDepartmentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>搜索部门</p>
     * 
     * @param request SearchDepartmentRequest
     * @return SearchDepartmentResponse
     */
    public SearchDepartmentResponse searchDepartment(SearchDepartmentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchDepartmentHeaders headers = new SearchDepartmentHeaders();
        return this.searchDepartmentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>搜索用户</p>
     * 
     * @param request SearchUserRequest
     * @param headers SearchUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchUserResponse
     */
    public SearchUserResponse searchUserWithOptions(SearchUserRequest request, SearchUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fullMatchField)) {
            body.put("fullMatchField", request.fullMatchField);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.offset)) {
            body.put("offset", request.offset);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryWord)) {
            body.put("queryWord", request.queryWord);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            body.put("size", request.size);
        }

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
            new TeaPair("action", "SearchUser"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/users/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>搜索用户</p>
     * 
     * @param request SearchUserRequest
     * @return SearchUserResponse
     */
    public SearchUserResponse searchUser(SearchUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchUserHeaders headers = new SearchUserHeaders();
        return this.searchUserWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>解除关联组织</p>
     * 
     * @param request SeparateBranchOrgRequest
     * @param headers SeparateBranchOrgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SeparateBranchOrgResponse
     */
    public SeparateBranchOrgResponse separateBranchOrgWithOptions(SeparateBranchOrgRequest request, SeparateBranchOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attachDeptId)) {
            body.put("attachDeptId", request.attachDeptId);
        }

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
            new TeaPair("action", "SeparateBranchOrg"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cooperateCorps/separate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SeparateBranchOrgResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>解除关联组织</p>
     * 
     * @param request SeparateBranchOrgRequest
     * @return SeparateBranchOrgResponse
     */
    public SeparateBranchOrgResponse separateBranchOrg(SeparateBranchOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SeparateBranchOrgHeaders headers = new SeparateBranchOrgHeaders();
        return this.separateBranchOrgWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>停用专属帐号</p>
     * 
     * @param request SetDisableRequest
     * @param headers SetDisableHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetDisableResponse
     */
    public SetDisableResponse setDisableWithOptions(SetDisableRequest request, SetDisableHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.reason)) {
            body.put("reason", request.reason);
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
            new TeaPair("action", "SetDisable"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/disable"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetDisableResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>停用专属帐号</p>
     * 
     * @param request SetDisableRequest
     * @return SetDisableResponse
     */
    public SetDisableResponse setDisable(SetDisableRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetDisableHeaders headers = new SetDisableHeaders();
        return this.setDisableWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>启用专属帐号</p>
     * 
     * @param request SetEnableRequest
     * @param headers SetEnableHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetEnableResponse
     */
    public SetEnableResponse setEnableWithOptions(SetEnableRequest request, SetEnableHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "SetEnable"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/enable"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetEnableResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>启用专属帐号</p>
     * 
     * @param request SetEnableRequest
     * @return SetEnableResponse
     */
    public SetEnableResponse setEnable(SetEnableRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetEnableHeaders headers = new SetEnableHeaders();
        return this.setEnableWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>强制登出专属帐号</p>
     * 
     * @param request SignOutRequest
     * @param headers SignOutHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SignOutResponse
     */
    public SignOutResponse signOutWithOptions(SignOutRequest request, SignOutHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.reason)) {
            body.put("reason", request.reason);
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
            new TeaPair("action", "SignOut"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccounts/signOut"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SignOutResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>强制登出专属帐号</p>
     * 
     * @param request SignOutRequest
     * @return SignOutResponse
     */
    public SignOutResponse signOut(SignOutRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SignOutHeaders headers = new SignOutHeaders();
        return this.signOutWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据用户名排序</p>
     * 
     * @param request SortUserRequest
     * @param headers SortUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SortUserResponse
     */
    public SortUserResponse sortUserWithOptions(SortUserRequest request, SortUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sortType)) {
            body.put("sortType", request.sortType);
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
            new TeaPair("action", "SortUser"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/users/sort"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SortUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据用户名排序</p>
     * 
     * @param request SortUserRequest
     * @return SortUserResponse
     */
    public SortUserResponse sortUser(SortUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SortUserHeaders headers = new SortUserHeaders();
        return this.sortUserWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>普通帐号转换为专属帐号</p>
     * 
     * @param request TransformToExclusiveAccountRequest
     * @param headers TransformToExclusiveAccountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TransformToExclusiveAccountResponse
     */
    public TransformToExclusiveAccountResponse transformToExclusiveAccountWithOptions(TransformToExclusiveAccountRequest request, TransformToExclusiveAccountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.idpDingTalk)) {
            body.put("idpDingTalk", request.idpDingTalk);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.initPassword)) {
            body.put("initPassword", request.initPassword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.loginId)) {
            body.put("loginId", request.loginId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.transformType)) {
            body.put("transformType", request.transformType);
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
            new TeaPair("action", "TransformToExclusiveAccount"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/orgAccount/transformToExclusiveAccounts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TransformToExclusiveAccountResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>普通帐号转换为专属帐号</p>
     * 
     * @param request TransformToExclusiveAccountRequest
     * @return TransformToExclusiveAccountResponse
     */
    public TransformToExclusiveAccountResponse transformToExclusiveAccount(TransformToExclusiveAccountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TransformToExclusiveAccountHeaders headers = new TransformToExclusiveAccountHeaders();
        return this.transformToExclusiveAccountWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>异步文件内容转译</p>
     * 
     * @param request TranslateFileRequest
     * @param headers TranslateFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TranslateFileResponse
     */
    public TranslateFileResponse translateFileWithOptions(TranslateFileRequest request, TranslateFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.medias)) {
            body.put("medias", request.medias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outputFileName)) {
            body.put("outputFileName", request.outputFileName);
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
            new TeaPair("action", "TranslateFile"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/files/translate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TranslateFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>异步文件内容转译</p>
     * 
     * @param request TranslateFileRequest
     * @return TranslateFileResponse
     */
    public TranslateFileResponse translateFile(TranslateFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TranslateFileHeaders headers = new TranslateFileHeaders();
        return this.translateFileWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>唯一查询用户名片</p>
     * 
     * @param request UniqueQueryUserCardRequest
     * @param headers UniqueQueryUserCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UniqueQueryUserCardResponse
     */
    public UniqueQueryUserCardResponse uniqueQueryUserCardWithOptions(UniqueQueryUserCardRequest request, UniqueQueryUserCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            query.put("templateId", request.templateId);
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
            new TeaPair("action", "UniqueQueryUserCard"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/uniques/cards"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UniqueQueryUserCardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>唯一查询用户名片</p>
     * 
     * @param request UniqueQueryUserCardRequest
     * @return UniqueQueryUserCardResponse
     */
    public UniqueQueryUserCardResponse uniqueQueryUserCard(UniqueQueryUserCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UniqueQueryUserCardHeaders headers = new UniqueQueryUserCardHeaders();
        return this.uniqueQueryUserCardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新(分支/伙伴)在(集团/合作空间)的属性信息</p>
     * 
     * @param request UpdateBranchAttributesInCooperateRequest
     * @param headers UpdateBranchAttributesInCooperateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateBranchAttributesInCooperateResponse
     */
    public UpdateBranchAttributesInCooperateResponse updateBranchAttributesInCooperateWithOptions(UpdateBranchAttributesInCooperateRequest request, UpdateBranchAttributesInCooperateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateBranchAttributesInCooperate"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cooperateCorps/branchAttributes"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateBranchAttributesInCooperateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新(分支/伙伴)在(集团/合作空间)的属性信息</p>
     * 
     * @param request UpdateBranchAttributesInCooperateRequest
     * @return UpdateBranchAttributesInCooperateResponse
     */
    public UpdateBranchAttributesInCooperateResponse updateBranchAttributesInCooperate(UpdateBranchAttributesInCooperateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateBranchAttributesInCooperateHeaders headers = new UpdateBranchAttributesInCooperateHeaders();
        return this.updateBranchAttributesInCooperateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设置(分支/伙伴)在(集团/合作空间)的可见范围</p>
     * 
     * @param request UpdateBranchVisibleSettingInCooperateRequest
     * @param headers UpdateBranchVisibleSettingInCooperateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateBranchVisibleSettingInCooperateResponse
     */
    public UpdateBranchVisibleSettingInCooperateResponse updateBranchVisibleSettingInCooperateWithOptions(UpdateBranchVisibleSettingInCooperateRequest request, UpdateBranchVisibleSettingInCooperateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateBranchVisibleSettingInCooperate"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/cooperateCorps/branchVisibleSettings"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateBranchVisibleSettingInCooperateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设置(分支/伙伴)在(集团/合作空间)的可见范围</p>
     * 
     * @param request UpdateBranchVisibleSettingInCooperateRequest
     * @return UpdateBranchVisibleSettingInCooperateResponse
     */
    public UpdateBranchVisibleSettingInCooperateResponse updateBranchVisibleSettingInCooperate(UpdateBranchVisibleSettingInCooperateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateBranchVisibleSettingInCooperateHeaders headers = new UpdateBranchVisibleSettingInCooperateHeaders();
        return this.updateBranchVisibleSettingInCooperateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新通讯录组织架构隐藏设置</p>
     * 
     * @param request UpdateContactHideBySceneSettingRequest
     * @param headers UpdateContactHideBySceneSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateContactHideBySceneSettingResponse
     */
    public UpdateContactHideBySceneSettingResponse updateContactHideBySceneSettingWithOptions(String settingId, UpdateContactHideBySceneSettingRequest request, UpdateContactHideBySceneSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeDeptIds)) {
            body.put("excludeDeptIds", request.excludeDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeTagIds)) {
            body.put("excludeTagIds", request.excludeTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeUserIds)) {
            body.put("excludeUserIds", request.excludeUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nodeListSceneConfig)) {
            body.put("nodeListSceneConfig", request.nodeListSceneConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectDeptIds)) {
            body.put("objectDeptIds", request.objectDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectTagIds)) {
            body.put("objectTagIds", request.objectTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectUserIds)) {
            body.put("objectUserIds", request.objectUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.profileSceneConfig)) {
            body.put("profileSceneConfig", request.profileSceneConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchSceneConfig)) {
            body.put("searchSceneConfig", request.searchSceneConfig);
        }

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
            new TeaPair("action", "UpdateContactHideBySceneSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/organizations/hides/settings/" + settingId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateContactHideBySceneSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新通讯录组织架构隐藏设置</p>
     * 
     * @param request UpdateContactHideBySceneSettingRequest
     * @return UpdateContactHideBySceneSettingResponse
     */
    public UpdateContactHideBySceneSettingResponse updateContactHideBySceneSetting(String settingId, UpdateContactHideBySceneSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateContactHideBySceneSettingHeaders headers = new UpdateContactHideBySceneSettingHeaders();
        return this.updateContactHideBySceneSettingWithOptions(settingId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新通讯录隐藏设置</p>
     * 
     * @param request UpdateContactHideSettingRequest
     * @param headers UpdateContactHideSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateContactHideSettingResponse
     */
    public UpdateContactHideSettingResponse updateContactHideSettingWithOptions(UpdateContactHideSettingRequest request, UpdateContactHideSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.active)) {
            body.put("active", request.active);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeDeptIds)) {
            body.put("excludeDeptIds", request.excludeDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeStaffIds)) {
            body.put("excludeStaffIds", request.excludeStaffIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeTagIds)) {
            body.put("excludeTagIds", request.excludeTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideInSearch)) {
            body.put("hideInSearch", request.hideInSearch);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideInUserProfile)) {
            body.put("hideInUserProfile", request.hideInUserProfile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectDeptIds)) {
            body.put("objectDeptIds", request.objectDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectStaffIds)) {
            body.put("objectStaffIds", request.objectStaffIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectTagIds)) {
            body.put("objectTagIds", request.objectTagIds);
        }

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
            new TeaPair("action", "UpdateContactHideSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/contactHideSettings"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateContactHideSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新通讯录隐藏设置</p>
     * 
     * @param request UpdateContactHideSettingRequest
     * @return UpdateContactHideSettingResponse
     */
    public UpdateContactHideSettingResponse updateContactHideSetting(UpdateContactHideSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateContactHideSettingHeaders headers = new UpdateContactHideSettingHeaders();
        return this.updateContactHideSettingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增或修改限制查看通讯录设置</p>
     * 
     * @param request UpdateContactRestrictSettingRequest
     * @param headers UpdateContactRestrictSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateContactRestrictSettingResponse
     */
    public UpdateContactRestrictSettingResponse updateContactRestrictSettingWithOptions(UpdateContactRestrictSettingRequest request, UpdateContactRestrictSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.active)) {
            body.put("active", request.active);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeDeptIds)) {
            body.put("excludeDeptIds", request.excludeDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeTagIds)) {
            body.put("excludeTagIds", request.excludeTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeUserIds)) {
            body.put("excludeUserIds", request.excludeUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.restrictInSearch)) {
            body.put("restrictInSearch", request.restrictInSearch);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.restrictInUserProfile)) {
            body.put("restrictInUserProfile", request.restrictInUserProfile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjectDeptIds)) {
            body.put("subjectDeptIds", request.subjectDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjectTagIds)) {
            body.put("subjectTagIds", request.subjectTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjectUserIds)) {
            body.put("subjectUserIds", request.subjectUserIds);
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
            new TeaPair("action", "UpdateContactRestrictSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/restrictions/settings"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateContactRestrictSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增或修改限制查看通讯录设置</p>
     * 
     * @param request UpdateContactRestrictSettingRequest
     * @return UpdateContactRestrictSettingResponse
     */
    public UpdateContactRestrictSettingResponse updateContactRestrictSetting(UpdateContactRestrictSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateContactRestrictSettingHeaders headers = new UpdateContactRestrictSettingHeaders();
        return this.updateContactRestrictSettingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通讯录可见性部门设置子部门设置优先</p>
     * 
     * @param request UpdateDeptSettngTailFirstRequest
     * @param headers UpdateDeptSettngTailFirstHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateDeptSettngTailFirstResponse
     */
    public UpdateDeptSettngTailFirstResponse updateDeptSettngTailFirstWithOptions(UpdateDeptSettngTailFirstRequest request, UpdateDeptSettngTailFirstHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.enable)) {
            body.put("enable", request.enable);
        }

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
            new TeaPair("action", "UpdateDeptSettngTailFirst"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/depts/settings/priorities"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "formData"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateDeptSettngTailFirstResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通讯录可见性部门设置子部门设置优先</p>
     * 
     * @param request UpdateDeptSettngTailFirstRequest
     * @return UpdateDeptSettngTailFirstResponse
     */
    public UpdateDeptSettngTailFirstResponse updateDeptSettngTailFirst(UpdateDeptSettngTailFirstRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateDeptSettngTailFirstHeaders headers = new UpdateDeptSettngTailFirstHeaders();
        return this.updateDeptSettngTailFirstWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新企业员工属性字段可见性设置</p>
     * 
     * @param request UpdateEmpAttrbuteVisibilitySettingRequest
     * @param headers UpdateEmpAttrbuteVisibilitySettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateEmpAttrbuteVisibilitySettingResponse
     */
    public UpdateEmpAttrbuteVisibilitySettingResponse updateEmpAttrbuteVisibilitySettingWithOptions(UpdateEmpAttrbuteVisibilitySettingRequest request, UpdateEmpAttrbuteVisibilitySettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.active)) {
            body.put("active", request.active);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeDeptIds)) {
            body.put("excludeDeptIds", request.excludeDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeStaffIds)) {
            body.put("excludeStaffIds", request.excludeStaffIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeTagIds)) {
            body.put("excludeTagIds", request.excludeTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideFields)) {
            body.put("hideFields", request.hideFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectDeptIds)) {
            body.put("objectDeptIds", request.objectDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectStaffIds)) {
            body.put("objectStaffIds", request.objectStaffIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectTagIds)) {
            body.put("objectTagIds", request.objectTagIds);
        }

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
            new TeaPair("action", "UpdateEmpAttrbuteVisibilitySetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/staffAttributes/visibilitySettings"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateEmpAttrbuteVisibilitySettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新企业员工属性字段可见性设置</p>
     * 
     * @param request UpdateEmpAttrbuteVisibilitySettingRequest
     * @return UpdateEmpAttrbuteVisibilitySettingResponse
     */
    public UpdateEmpAttrbuteVisibilitySettingResponse updateEmpAttrbuteVisibilitySetting(UpdateEmpAttrbuteVisibilitySettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateEmpAttrbuteVisibilitySettingHeaders headers = new UpdateEmpAttrbuteVisibilitySettingHeaders();
        return this.updateEmpAttrbuteVisibilitySettingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新员工属性分场景隐藏设置</p>
     * 
     * @param request UpdateEmpAttributeHideBySceneSettingRequest
     * @param headers UpdateEmpAttributeHideBySceneSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateEmpAttributeHideBySceneSettingResponse
     */
    public UpdateEmpAttributeHideBySceneSettingResponse updateEmpAttributeHideBySceneSettingWithOptions(String settingId, UpdateEmpAttributeHideBySceneSettingRequest request, UpdateEmpAttributeHideBySceneSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.chatSubtitleConfig)) {
            body.put("chatSubtitleConfig", request.chatSubtitleConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeDeptIds)) {
            body.put("excludeDeptIds", request.excludeDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeTagIds)) {
            body.put("excludeTagIds", request.excludeTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeUserIds)) {
            body.put("excludeUserIds", request.excludeUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideFields)) {
            body.put("hideFields", request.hideFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectDeptIds)) {
            body.put("objectDeptIds", request.objectDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectTagIds)) {
            body.put("objectTagIds", request.objectTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectUserIds)) {
            body.put("objectUserIds", request.objectUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.profileSceneConfig)) {
            body.put("profileSceneConfig", request.profileSceneConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchSceneConfig)) {
            body.put("searchSceneConfig", request.searchSceneConfig);
        }

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
            new TeaPair("action", "UpdateEmpAttributeHideBySceneSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/empAttributes/hides/settings/" + settingId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateEmpAttributeHideBySceneSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新员工属性分场景隐藏设置</p>
     * 
     * @param request UpdateEmpAttributeHideBySceneSettingRequest
     * @return UpdateEmpAttributeHideBySceneSettingResponse
     */
    public UpdateEmpAttributeHideBySceneSettingResponse updateEmpAttributeHideBySceneSetting(String settingId, UpdateEmpAttributeHideBySceneSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateEmpAttributeHideBySceneSettingHeaders headers = new UpdateEmpAttributeHideBySceneSettingHeaders();
        return this.updateEmpAttributeHideBySceneSettingWithOptions(settingId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新管理组</p>
     * 
     * @param request UpdateManagementGroupRequest
     * @param headers UpdateManagementGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateManagementGroupResponse
     */
    public UpdateManagementGroupResponse updateManagementGroupWithOptions(String groupId, UpdateManagementGroupRequest request, UpdateManagementGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resourceIds)) {
            body.put("resourceIds", request.resourceIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

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
            new TeaPair("action", "UpdateManagementGroup"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/managementGroups/" + groupId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateManagementGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新管理组</p>
     * 
     * @param request UpdateManagementGroupRequest
     * @return UpdateManagementGroupResponse
     */
    public UpdateManagementGroupResponse updateManagementGroup(String groupId, UpdateManagementGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateManagementGroupHeaders headers = new UpdateManagementGroupHeaders();
        return this.updateManagementGroupWithOptions(groupId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设置高管模式</p>
     * 
     * @param request UpdateSeniorSettingRequest
     * @param headers UpdateSeniorSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateSeniorSettingResponse
     */
    public UpdateSeniorSettingResponse updateSeniorSettingWithOptions(UpdateSeniorSettingRequest request, UpdateSeniorSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.open)) {
            body.put("open", request.open);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.permitDeptIds)) {
            body.put("permitDeptIds", request.permitDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.permitStaffIds)) {
            body.put("permitStaffIds", request.permitStaffIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.permitTagIds)) {
            body.put("permitTagIds", request.permitTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.protectScenes)) {
            body.put("protectScenes", request.protectScenes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.seniorStaffId)) {
            body.put("seniorStaffId", request.seniorStaffId);
        }

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
            new TeaPair("action", "UpdateSeniorSetting"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/seniorSettings"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateSeniorSettingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设置高管模式</p>
     * 
     * @param request UpdateSeniorSettingRequest
     * @return UpdateSeniorSettingResponse
     */
    public UpdateSeniorSettingResponse updateSeniorSetting(UpdateSeniorSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateSeniorSettingHeaders headers = new UpdateSeniorSettingHeaders();
        return this.updateSeniorSettingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>三方通过该接口更新个人履历的审核状态</p>
     * 
     * @param request UpdateTitleAuditStatusRequest
     * @param headers UpdateTitleAuditStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTitleAuditStatusResponse
     */
    public UpdateTitleAuditStatusResponse updateTitleAuditStatusWithOptions(UpdateTitleAuditStatusRequest request, UpdateTitleAuditStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authStatus)) {
            body.put("authStatus", request.authStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.educationLevel)) {
            body.put("educationLevel", request.educationLevel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.major)) {
            body.put("major", request.major);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.position)) {
            body.put("position", request.position);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reasonCode)) {
            body.put("reasonCode", request.reasonCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reasonMsg)) {
            body.put("reasonMsg", request.reasonMsg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.school)) {
            body.put("school", request.school);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
        }

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
            new TeaPair("action", "UpdateTitleAuditStatus"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/userTitles/auditStatuses"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTitleAuditStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>三方通过该接口更新个人履历的审核状态</p>
     * 
     * @param request UpdateTitleAuditStatusRequest
     * @return UpdateTitleAuditStatusResponse
     */
    public UpdateTitleAuditStatusResponse updateTitleAuditStatus(UpdateTitleAuditStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTitleAuditStatusHeaders headers = new UpdateTitleAuditStatusHeaders();
        return this.updateTitleAuditStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新用户个人状态</p>
     * 
     * @param request UpdateUserOwnnessRequest
     * @param headers UpdateUserOwnnessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateUserOwnnessResponse
     */
    public UpdateUserOwnnessResponse updateUserOwnnessWithOptions(String userId, UpdateUserOwnnessRequest request, UpdateUserOwnnessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deletedFlag)) {
            body.put("deletedFlag", request.deletedFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownenssType)) {
            body.put("ownenssType", request.ownenssType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

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
            new TeaPair("action", "UpdateUserOwnness"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/user/" + userId + "/ownness"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateUserOwnnessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新用户个人状态</p>
     * 
     * @param request UpdateUserOwnnessRequest
     * @return UpdateUserOwnnessResponse
     */
    public UpdateUserOwnnessResponse updateUserOwnness(String userId, UpdateUserOwnnessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateUserOwnnessHeaders headers = new UpdateUserOwnnessHeaders();
        return this.updateUserOwnnessWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用户个人信息接口</p>
     * 
     * @param tmpReq UserProfileRequest
     * @param headers UserProfileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UserProfileResponse
     */
    public UserProfileResponse userProfileWithOptions(UserProfileRequest tmpReq, UserProfileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        UserProfileShrinkRequest request = new UserProfileShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.uids)) {
            request.uidsShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.uids, "uids", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.uidsShrink)) {
            query.put("uids", request.uidsShrink);
        }

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
            new TeaPair("action", "UserProfile"),
            new TeaPair("version", "contact_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/contact/user/profile"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UserProfileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>用户个人信息接口</p>
     * 
     * @param request UserProfileRequest
     * @return UserProfileResponse
     */
    public UserProfileResponse userProfile(UserProfileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UserProfileHeaders headers = new UserProfileHeaders();
        return this.userProfileWithOptions(request, headers, runtime);
    }
}
