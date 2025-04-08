// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkhrbrain_1_0.models.*;

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
     * <p>删除奖励记录</p>
     * 
     * @param request HrbrainDeleteAwardRecordsRequest
     * @param headers HrbrainDeleteAwardRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteAwardRecordsResponse
     */
    public HrbrainDeleteAwardRecordsResponse hrbrainDeleteAwardRecordsWithOptions(HrbrainDeleteAwardRecordsRequest request, HrbrainDeleteAwardRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteAwardRecords"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/awardRecords/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteAwardRecordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除奖励记录</p>
     * 
     * @param request HrbrainDeleteAwardRecordsRequest
     * @return HrbrainDeleteAwardRecordsResponse
     */
    public HrbrainDeleteAwardRecordsResponse hrbrainDeleteAwardRecords(HrbrainDeleteAwardRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteAwardRecordsHeaders headers = new HrbrainDeleteAwardRecordsHeaders();
        return this.hrbrainDeleteAwardRecordsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除组织架构</p>
     * 
     * @param request HrbrainDeleteDeptInfoRequest
     * @param headers HrbrainDeleteDeptInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteDeptInfoResponse
     */
    public HrbrainDeleteDeptInfoResponse hrbrainDeleteDeptInfoWithOptions(HrbrainDeleteDeptInfoRequest request, HrbrainDeleteDeptInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteDeptInfo"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/deptInfos/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteDeptInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除组织架构</p>
     * 
     * @param request HrbrainDeleteDeptInfoRequest
     * @return HrbrainDeleteDeptInfoResponse
     */
    public HrbrainDeleteDeptInfoResponse hrbrainDeleteDeptInfo(HrbrainDeleteDeptInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteDeptInfoHeaders headers = new HrbrainDeleteDeptInfoHeaders();
        return this.hrbrainDeleteDeptInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除离职记录</p>
     * 
     * @param request HrbrainDeleteDimissionRequest
     * @param headers HrbrainDeleteDimissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteDimissionResponse
     */
    public HrbrainDeleteDimissionResponse hrbrainDeleteDimissionWithOptions(HrbrainDeleteDimissionRequest request, HrbrainDeleteDimissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteDimission"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/dimissionInfos/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteDimissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除离职记录</p>
     * 
     * @param request HrbrainDeleteDimissionRequest
     * @return HrbrainDeleteDimissionResponse
     */
    public HrbrainDeleteDimissionResponse hrbrainDeleteDimission(HrbrainDeleteDimissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteDimissionHeaders headers = new HrbrainDeleteDimissionHeaders();
        return this.hrbrainDeleteDimissionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除教育经历</p>
     * 
     * @param request HrbrainDeleteEduExpRequest
     * @param headers HrbrainDeleteEduExpHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteEduExpResponse
     */
    public HrbrainDeleteEduExpResponse hrbrainDeleteEduExpWithOptions(HrbrainDeleteEduExpRequest request, HrbrainDeleteEduExpHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteEduExp"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/eduExperiences/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteEduExpResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除教育经历</p>
     * 
     * @param request HrbrainDeleteEduExpRequest
     * @return HrbrainDeleteEduExpResponse
     */
    public HrbrainDeleteEduExpResponse hrbrainDeleteEduExp(HrbrainDeleteEduExpRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteEduExpHeaders headers = new HrbrainDeleteEduExpHeaders();
        return this.hrbrainDeleteEduExpWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除人员信息</p>
     * 
     * @param request HrbrainDeleteEmpInfoRequest
     * @param headers HrbrainDeleteEmpInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteEmpInfoResponse
     */
    public HrbrainDeleteEmpInfoResponse hrbrainDeleteEmpInfoWithOptions(HrbrainDeleteEmpInfoRequest request, HrbrainDeleteEmpInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteEmpInfo"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/empInfos/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteEmpInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除人员信息</p>
     * 
     * @param request HrbrainDeleteEmpInfoRequest
     * @return HrbrainDeleteEmpInfoResponse
     */
    public HrbrainDeleteEmpInfoResponse hrbrainDeleteEmpInfo(HrbrainDeleteEmpInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteEmpInfoHeaders headers = new HrbrainDeleteEmpInfoHeaders();
        return this.hrbrainDeleteEmpInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除领域经验</p>
     * 
     * @param request HrbrainDeleteLabelIndustryRequest
     * @param headers HrbrainDeleteLabelIndustryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteLabelIndustryResponse
     */
    public HrbrainDeleteLabelIndustryResponse hrbrainDeleteLabelIndustryWithOptions(HrbrainDeleteLabelIndustryRequest request, HrbrainDeleteLabelIndustryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteLabelIndustry"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/industries/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteLabelIndustryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除领域经验</p>
     * 
     * @param request HrbrainDeleteLabelIndustryRequest
     * @return HrbrainDeleteLabelIndustryResponse
     */
    public HrbrainDeleteLabelIndustryResponse hrbrainDeleteLabelIndustry(HrbrainDeleteLabelIndustryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteLabelIndustryHeaders headers = new HrbrainDeleteLabelIndustryHeaders();
        return this.hrbrainDeleteLabelIndustryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除盘点数据</p>
     * 
     * @param request HrbrainDeleteLabelInventoryRequest
     * @param headers HrbrainDeleteLabelInventoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteLabelInventoryResponse
     */
    public HrbrainDeleteLabelInventoryResponse hrbrainDeleteLabelInventoryWithOptions(HrbrainDeleteLabelInventoryRequest request, HrbrainDeleteLabelInventoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteLabelInventory"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/inventories/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteLabelInventoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除盘点数据</p>
     * 
     * @param request HrbrainDeleteLabelInventoryRequest
     * @return HrbrainDeleteLabelInventoryResponse
     */
    public HrbrainDeleteLabelInventoryResponse hrbrainDeleteLabelInventory(HrbrainDeleteLabelInventoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteLabelInventoryHeaders headers = new HrbrainDeleteLabelInventoryHeaders();
        return this.hrbrainDeleteLabelInventoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除专业技能</p>
     * 
     * @param request HrbrainDeleteLabelProfSkillRequest
     * @param headers HrbrainDeleteLabelProfSkillHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteLabelProfSkillResponse
     */
    public HrbrainDeleteLabelProfSkillResponse hrbrainDeleteLabelProfSkillWithOptions(HrbrainDeleteLabelProfSkillRequest request, HrbrainDeleteLabelProfSkillHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteLabelProfSkill"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/profSkills/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteLabelProfSkillResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除专业技能</p>
     * 
     * @param request HrbrainDeleteLabelProfSkillRequest
     * @return HrbrainDeleteLabelProfSkillResponse
     */
    public HrbrainDeleteLabelProfSkillResponse hrbrainDeleteLabelProfSkill(HrbrainDeleteLabelProfSkillRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteLabelProfSkillHeaders headers = new HrbrainDeleteLabelProfSkillHeaders();
        return this.hrbrainDeleteLabelProfSkillWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除绩效记录</p>
     * 
     * @param request HrbrainDeletePerfEvalRequest
     * @param headers HrbrainDeletePerfEvalHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeletePerfEvalResponse
     */
    public HrbrainDeletePerfEvalResponse hrbrainDeletePerfEvalWithOptions(HrbrainDeletePerfEvalRequest request, HrbrainDeletePerfEvalHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeletePerfEval"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/perfRecords/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeletePerfEvalResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除绩效记录</p>
     * 
     * @param request HrbrainDeletePerfEvalRequest
     * @return HrbrainDeletePerfEvalResponse
     */
    public HrbrainDeletePerfEvalResponse hrbrainDeletePerfEval(HrbrainDeletePerfEvalRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeletePerfEvalHeaders headers = new HrbrainDeletePerfEvalHeaders();
        return this.hrbrainDeletePerfEvalWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>数据集成晋升记录删除</p>
     * 
     * @param request HrbrainDeletePromRecordsRequest
     * @param headers HrbrainDeletePromRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeletePromRecordsResponse
     */
    public HrbrainDeletePromRecordsResponse hrbrainDeletePromRecordsWithOptions(HrbrainDeletePromRecordsRequest request, HrbrainDeletePromRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeletePromRecords"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/promEvals/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeletePromRecordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>数据集成晋升记录删除</p>
     * 
     * @param request HrbrainDeletePromRecordsRequest
     * @return HrbrainDeletePromRecordsResponse
     */
    public HrbrainDeletePromRecordsResponse hrbrainDeletePromRecords(HrbrainDeletePromRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeletePromRecordsHeaders headers = new HrbrainDeletePromRecordsHeaders();
        return this.hrbrainDeletePromRecordsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除处分记录</p>
     * 
     * @param request HrbrainDeletePunDetailRequest
     * @param headers HrbrainDeletePunDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeletePunDetailResponse
     */
    public HrbrainDeletePunDetailResponse hrbrainDeletePunDetailWithOptions(HrbrainDeletePunDetailRequest request, HrbrainDeletePunDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeletePunDetail"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/punDetails/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeletePunDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除处分记录</p>
     * 
     * @param request HrbrainDeletePunDetailRequest
     * @return HrbrainDeletePunDetailResponse
     */
    public HrbrainDeletePunDetailResponse hrbrainDeletePunDetail(HrbrainDeletePunDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeletePunDetailHeaders headers = new HrbrainDeletePunDetailHeaders();
        return this.hrbrainDeletePunDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除入职记录</p>
     * 
     * @param request HrbrainDeleteRegistRequest
     * @param headers HrbrainDeleteRegistHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteRegistResponse
     */
    public HrbrainDeleteRegistResponse hrbrainDeleteRegistWithOptions(HrbrainDeleteRegistRequest request, HrbrainDeleteRegistHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteRegist"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/registerInfos/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteRegistResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除入职记录</p>
     * 
     * @param request HrbrainDeleteRegistRequest
     * @return HrbrainDeleteRegistResponse
     */
    public HrbrainDeleteRegistResponse hrbrainDeleteRegist(HrbrainDeleteRegistRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteRegistHeaders headers = new HrbrainDeleteRegistHeaders();
        return this.hrbrainDeleteRegistWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除转正记录</p>
     * 
     * @param request HrbrainDeleteRegularRequest
     * @param headers HrbrainDeleteRegularHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteRegularResponse
     */
    public HrbrainDeleteRegularResponse hrbrainDeleteRegularWithOptions(HrbrainDeleteRegularRequest request, HrbrainDeleteRegularHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteRegular"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/regulars/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteRegularResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除转正记录</p>
     * 
     * @param request HrbrainDeleteRegularRequest
     * @return HrbrainDeleteRegularResponse
     */
    public HrbrainDeleteRegularResponse hrbrainDeleteRegular(HrbrainDeleteRegularRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteRegularHeaders headers = new HrbrainDeleteRegularHeaders();
        return this.hrbrainDeleteRegularWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除培训学习记录</p>
     * 
     * @param request HrbrainDeleteTrainingRequest
     * @param headers HrbrainDeleteTrainingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteTrainingResponse
     */
    public HrbrainDeleteTrainingResponse hrbrainDeleteTrainingWithOptions(HrbrainDeleteTrainingRequest request, HrbrainDeleteTrainingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteTraining"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/trainings/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteTrainingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除培训学习记录</p>
     * 
     * @param request HrbrainDeleteTrainingRequest
     * @return HrbrainDeleteTrainingResponse
     */
    public HrbrainDeleteTrainingResponse hrbrainDeleteTraining(HrbrainDeleteTrainingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteTrainingHeaders headers = new HrbrainDeleteTrainingHeaders();
        return this.hrbrainDeleteTrainingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除调岗记录</p>
     * 
     * @param request HrbrainDeleteTransferEvalRequest
     * @param headers HrbrainDeleteTransferEvalHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteTransferEvalResponse
     */
    public HrbrainDeleteTransferEvalResponse hrbrainDeleteTransferEvalWithOptions(HrbrainDeleteTransferEvalRequest request, HrbrainDeleteTransferEvalHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteTransferEval"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/changeRecords/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteTransferEvalResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除调岗记录</p>
     * 
     * @param request HrbrainDeleteTransferEvalRequest
     * @return HrbrainDeleteTransferEvalResponse
     */
    public HrbrainDeleteTransferEvalResponse hrbrainDeleteTransferEval(HrbrainDeleteTransferEvalRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteTransferEvalHeaders headers = new HrbrainDeleteTransferEvalHeaders();
        return this.hrbrainDeleteTransferEvalWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除工作经历</p>
     * 
     * @param request HrbrainDeleteWorkExpRequest
     * @param headers HrbrainDeleteWorkExpHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeleteWorkExpResponse
     */
    public HrbrainDeleteWorkExpResponse hrbrainDeleteWorkExpWithOptions(HrbrainDeleteWorkExpRequest request, HrbrainDeleteWorkExpHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeleteWorkExp"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/workExperiences/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeleteWorkExpResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除工作经历</p>
     * 
     * @param request HrbrainDeleteWorkExpRequest
     * @return HrbrainDeleteWorkExpResponse
     */
    public HrbrainDeleteWorkExpResponse hrbrainDeleteWorkExp(HrbrainDeleteWorkExpRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeleteWorkExpHeaders headers = new HrbrainDeleteWorkExpHeaders();
        return this.hrbrainDeleteWorkExpWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除标签数据</p>
     * 
     * @param request HrbrainDeletetLabelBaseRequest
     * @param headers HrbrainDeletetLabelBaseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainDeletetLabelBaseResponse
     */
    public HrbrainDeletetLabelBaseResponse hrbrainDeletetLabelBaseWithOptions(HrbrainDeletetLabelBaseRequest request, HrbrainDeletetLabelBaseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "HrbrainDeletetLabelBase"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/baseLabels/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainDeletetLabelBaseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除标签数据</p>
     * 
     * @param request HrbrainDeletetLabelBaseRequest
     * @return HrbrainDeletetLabelBaseResponse
     */
    public HrbrainDeletetLabelBaseResponse hrbrainDeletetLabelBase(HrbrainDeletetLabelBaseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainDeletetLabelBaseHeaders headers = new HrbrainDeletetLabelBaseHeaders();
        return this.hrbrainDeletetLabelBaseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成奖励记录</p>
     * 
     * @param request HrbrainImportAwardDetailRequest
     * @param headers HrbrainImportAwardDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportAwardDetailResponse
     */
    public HrbrainImportAwardDetailResponse hrbrainImportAwardDetailWithOptions(HrbrainImportAwardDetailRequest request, HrbrainImportAwardDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportAwardDetail"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/awardDetails/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportAwardDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成奖励记录</p>
     * 
     * @param request HrbrainImportAwardDetailRequest
     * @return HrbrainImportAwardDetailResponse
     */
    public HrbrainImportAwardDetailResponse hrbrainImportAwardDetail(HrbrainImportAwardDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportAwardDetailHeaders headers = new HrbrainImportAwardDetailHeaders();
        return this.hrbrainImportAwardDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成组织架构</p>
     * 
     * @param request HrbrainImportDeptInfoRequest
     * @param headers HrbrainImportDeptInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportDeptInfoResponse
     */
    public HrbrainImportDeptInfoResponse hrbrainImportDeptInfoWithOptions(HrbrainImportDeptInfoRequest request, HrbrainImportDeptInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportDeptInfo"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/deptInfos/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportDeptInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成组织架构</p>
     * 
     * @param request HrbrainImportDeptInfoRequest
     * @return HrbrainImportDeptInfoResponse
     */
    public HrbrainImportDeptInfoResponse hrbrainImportDeptInfo(HrbrainImportDeptInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportDeptInfoHeaders headers = new HrbrainImportDeptInfoHeaders();
        return this.hrbrainImportDeptInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成离职信息</p>
     * 
     * @param request HrbrainImportDimissionRequest
     * @param headers HrbrainImportDimissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportDimissionResponse
     */
    public HrbrainImportDimissionResponse hrbrainImportDimissionWithOptions(HrbrainImportDimissionRequest request, HrbrainImportDimissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportDimission"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/dimissionInfos/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportDimissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成离职信息</p>
     * 
     * @param request HrbrainImportDimissionRequest
     * @return HrbrainImportDimissionResponse
     */
    public HrbrainImportDimissionResponse hrbrainImportDimission(HrbrainImportDimissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportDimissionHeaders headers = new HrbrainImportDimissionHeaders();
        return this.hrbrainImportDimissionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成教育经历</p>
     * 
     * @param request HrbrainImportEduExpRequest
     * @param headers HrbrainImportEduExpHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportEduExpResponse
     */
    public HrbrainImportEduExpResponse hrbrainImportEduExpWithOptions(HrbrainImportEduExpRequest request, HrbrainImportEduExpHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportEduExp"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/eduExperiences/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportEduExpResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成教育经历</p>
     * 
     * @param request HrbrainImportEduExpRequest
     * @return HrbrainImportEduExpResponse
     */
    public HrbrainImportEduExpResponse hrbrainImportEduExp(HrbrainImportEduExpRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportEduExpHeaders headers = new HrbrainImportEduExpHeaders();
        return this.hrbrainImportEduExpWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成人员信息</p>
     * 
     * @param request HrbrainImportEmpInfoRequest
     * @param headers HrbrainImportEmpInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportEmpInfoResponse
     */
    public HrbrainImportEmpInfoResponse hrbrainImportEmpInfoWithOptions(HrbrainImportEmpInfoRequest request, HrbrainImportEmpInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportEmpInfo"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/empInfos/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportEmpInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成人员信息</p>
     * 
     * @param request HrbrainImportEmpInfoRequest
     * @return HrbrainImportEmpInfoResponse
     */
    public HrbrainImportEmpInfoResponse hrbrainImportEmpInfo(HrbrainImportEmpInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportEmpInfoHeaders headers = new HrbrainImportEmpInfoHeaders();
        return this.hrbrainImportEmpInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成基础标签</p>
     * 
     * @param request HrbrainImportLabelBaseRequest
     * @param headers HrbrainImportLabelBaseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportLabelBaseResponse
     */
    public HrbrainImportLabelBaseResponse hrbrainImportLabelBaseWithOptions(HrbrainImportLabelBaseRequest request, HrbrainImportLabelBaseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportLabelBase"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/baseLabels/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportLabelBaseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成基础标签</p>
     * 
     * @param request HrbrainImportLabelBaseRequest
     * @return HrbrainImportLabelBaseResponse
     */
    public HrbrainImportLabelBaseResponse hrbrainImportLabelBase(HrbrainImportLabelBaseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportLabelBaseHeaders headers = new HrbrainImportLabelBaseHeaders();
        return this.hrbrainImportLabelBaseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成自定义标签</p>
     * 
     * @param request HrbrainImportLabelCustomRequest
     * @param headers HrbrainImportLabelCustomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportLabelCustomResponse
     */
    public HrbrainImportLabelCustomResponse hrbrainImportLabelCustomWithOptions(HrbrainImportLabelCustomRequest request, HrbrainImportLabelCustomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportLabelCustom"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/customLabels/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportLabelCustomResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成自定义标签</p>
     * 
     * @param request HrbrainImportLabelCustomRequest
     * @return HrbrainImportLabelCustomResponse
     */
    public HrbrainImportLabelCustomResponse hrbrainImportLabelCustom(HrbrainImportLabelCustomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportLabelCustomHeaders headers = new HrbrainImportLabelCustomHeaders();
        return this.hrbrainImportLabelCustomWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成领域经验</p>
     * 
     * @param request HrbrainImportLabelIndustryRequest
     * @param headers HrbrainImportLabelIndustryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportLabelIndustryResponse
     */
    public HrbrainImportLabelIndustryResponse hrbrainImportLabelIndustryWithOptions(HrbrainImportLabelIndustryRequest request, HrbrainImportLabelIndustryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportLabelIndustry"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/industries/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportLabelIndustryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成领域经验</p>
     * 
     * @param request HrbrainImportLabelIndustryRequest
     * @return HrbrainImportLabelIndustryResponse
     */
    public HrbrainImportLabelIndustryResponse hrbrainImportLabelIndustry(HrbrainImportLabelIndustryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportLabelIndustryHeaders headers = new HrbrainImportLabelIndustryHeaders();
        return this.hrbrainImportLabelIndustryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成盘点数据</p>
     * 
     * @param request HrbrainImportLabelInventoryRequest
     * @param headers HrbrainImportLabelInventoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportLabelInventoryResponse
     */
    public HrbrainImportLabelInventoryResponse hrbrainImportLabelInventoryWithOptions(HrbrainImportLabelInventoryRequest request, HrbrainImportLabelInventoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportLabelInventory"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/inventories/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportLabelInventoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成盘点数据</p>
     * 
     * @param request HrbrainImportLabelInventoryRequest
     * @return HrbrainImportLabelInventoryResponse
     */
    public HrbrainImportLabelInventoryResponse hrbrainImportLabelInventory(HrbrainImportLabelInventoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportLabelInventoryHeaders headers = new HrbrainImportLabelInventoryHeaders();
        return this.hrbrainImportLabelInventoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成专业技能</p>
     * 
     * @param request HrbrainImportLabelProfSkillRequest
     * @param headers HrbrainImportLabelProfSkillHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportLabelProfSkillResponse
     */
    public HrbrainImportLabelProfSkillResponse hrbrainImportLabelProfSkillWithOptions(HrbrainImportLabelProfSkillRequest request, HrbrainImportLabelProfSkillHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportLabelProfSkill"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/profSkills/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportLabelProfSkillResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成专业技能</p>
     * 
     * @param request HrbrainImportLabelProfSkillRequest
     * @return HrbrainImportLabelProfSkillResponse
     */
    public HrbrainImportLabelProfSkillResponse hrbrainImportLabelProfSkill(HrbrainImportLabelProfSkillRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportLabelProfSkillHeaders headers = new HrbrainImportLabelProfSkillHeaders();
        return this.hrbrainImportLabelProfSkillWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成绩效记录</p>
     * 
     * @param request HrbrainImportPerfEvalRequest
     * @param headers HrbrainImportPerfEvalHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportPerfEvalResponse
     */
    public HrbrainImportPerfEvalResponse hrbrainImportPerfEvalWithOptions(HrbrainImportPerfEvalRequest request, HrbrainImportPerfEvalHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportPerfEval"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/perfRecords/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportPerfEvalResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成绩效记录</p>
     * 
     * @param request HrbrainImportPerfEvalRequest
     * @return HrbrainImportPerfEvalResponse
     */
    public HrbrainImportPerfEvalResponse hrbrainImportPerfEval(HrbrainImportPerfEvalRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportPerfEvalHeaders headers = new HrbrainImportPerfEvalHeaders();
        return this.hrbrainImportPerfEvalWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成晋升记录</p>
     * 
     * @param request HrbrainImportPromEvalRequest
     * @param headers HrbrainImportPromEvalHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportPromEvalResponse
     */
    public HrbrainImportPromEvalResponse hrbrainImportPromEvalWithOptions(HrbrainImportPromEvalRequest request, HrbrainImportPromEvalHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportPromEval"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/promRecords/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportPromEvalResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成晋升记录</p>
     * 
     * @param request HrbrainImportPromEvalRequest
     * @return HrbrainImportPromEvalResponse
     */
    public HrbrainImportPromEvalResponse hrbrainImportPromEval(HrbrainImportPromEvalRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportPromEvalHeaders headers = new HrbrainImportPromEvalHeaders();
        return this.hrbrainImportPromEvalWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成处分记录</p>
     * 
     * @param request HrbrainImportPunDetailRequest
     * @param headers HrbrainImportPunDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportPunDetailResponse
     */
    public HrbrainImportPunDetailResponse hrbrainImportPunDetailWithOptions(HrbrainImportPunDetailRequest request, HrbrainImportPunDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportPunDetail"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/punDetails/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportPunDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成处分记录</p>
     * 
     * @param request HrbrainImportPunDetailRequest
     * @return HrbrainImportPunDetailResponse
     */
    public HrbrainImportPunDetailResponse hrbrainImportPunDetail(HrbrainImportPunDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportPunDetailHeaders headers = new HrbrainImportPunDetailHeaders();
        return this.hrbrainImportPunDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成入职信息</p>
     * 
     * @param request HrbrainImportRegistRequest
     * @param headers HrbrainImportRegistHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportRegistResponse
     */
    public HrbrainImportRegistResponse hrbrainImportRegistWithOptions(HrbrainImportRegistRequest request, HrbrainImportRegistHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportRegist"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/registerInfos/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportRegistResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成入职信息</p>
     * 
     * @param request HrbrainImportRegistRequest
     * @return HrbrainImportRegistResponse
     */
    public HrbrainImportRegistResponse hrbrainImportRegist(HrbrainImportRegistRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportRegistHeaders headers = new HrbrainImportRegistHeaders();
        return this.hrbrainImportRegistWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成转正记录</p>
     * 
     * @param request HrbrainImportRegularRequest
     * @param headers HrbrainImportRegularHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportRegularResponse
     */
    public HrbrainImportRegularResponse hrbrainImportRegularWithOptions(HrbrainImportRegularRequest request, HrbrainImportRegularHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportRegular"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/regulars/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportRegularResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成转正记录</p>
     * 
     * @param request HrbrainImportRegularRequest
     * @return HrbrainImportRegularResponse
     */
    public HrbrainImportRegularResponse hrbrainImportRegular(HrbrainImportRegularRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportRegularHeaders headers = new HrbrainImportRegularHeaders();
        return this.hrbrainImportRegularWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成培训学习记录</p>
     * 
     * @param request HrbrainImportTrainingRequest
     * @param headers HrbrainImportTrainingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportTrainingResponse
     */
    public HrbrainImportTrainingResponse hrbrainImportTrainingWithOptions(HrbrainImportTrainingRequest request, HrbrainImportTrainingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportTraining"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/trainings/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportTrainingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成培训学习记录</p>
     * 
     * @param request HrbrainImportTrainingRequest
     * @return HrbrainImportTrainingResponse
     */
    public HrbrainImportTrainingResponse hrbrainImportTraining(HrbrainImportTrainingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportTrainingHeaders headers = new HrbrainImportTrainingHeaders();
        return this.hrbrainImportTrainingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成异动记录</p>
     * 
     * @param request HrbrainImportTransferEvalRequest
     * @param headers HrbrainImportTransferEvalHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportTransferEvalResponse
     */
    public HrbrainImportTransferEvalResponse hrbrainImportTransferEvalWithOptions(HrbrainImportTransferEvalRequest request, HrbrainImportTransferEvalHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportTransferEval"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/changeRecords/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportTransferEvalResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成异动记录</p>
     * 
     * @param request HrbrainImportTransferEvalRequest
     * @return HrbrainImportTransferEvalResponse
     */
    public HrbrainImportTransferEvalResponse hrbrainImportTransferEval(HrbrainImportTransferEvalRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportTransferEvalHeaders headers = new HrbrainImportTransferEvalHeaders();
        return this.hrbrainImportTransferEvalWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>集成工作经历</p>
     * 
     * @param request HrbrainImportWorkExpRequest
     * @param headers HrbrainImportWorkExpHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HrbrainImportWorkExpResponse
     */
    public HrbrainImportWorkExpResponse hrbrainImportWorkExpWithOptions(HrbrainImportWorkExpRequest request, HrbrainImportWorkExpHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

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
            new TeaPair("action", "HrbrainImportWorkExp"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/workExperiences/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrbrainImportWorkExpResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>集成工作经历</p>
     * 
     * @param request HrbrainImportWorkExpRequest
     * @return HrbrainImportWorkExpResponse
     */
    public HrbrainImportWorkExpResponse hrbrainImportWorkExp(HrbrainImportWorkExpRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrbrainImportWorkExpHeaders headers = new HrbrainImportWorkExpHeaders();
        return this.hrbrainImportWorkExpWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人员标签查询</p>
     * 
     * @param request StaffLabelRecordsQueryRequest
     * @param headers StaffLabelRecordsQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StaffLabelRecordsQueryResponse
     */
    public StaffLabelRecordsQueryResponse staffLabelRecordsQueryWithOptions(StaffLabelRecordsQueryRequest request, StaffLabelRecordsQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            query.put("dingCorpId", request.dingCorpId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "StaffLabelRecordsQuery"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas/labelRecords/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StaffLabelRecordsQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人员标签查询</p>
     * 
     * @param request StaffLabelRecordsQueryRequest
     * @return StaffLabelRecordsQueryResponse
     */
    public StaffLabelRecordsQueryResponse staffLabelRecordsQuery(StaffLabelRecordsQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StaffLabelRecordsQueryHeaders headers = new StaffLabelRecordsQueryHeaders();
        return this.staffLabelRecordsQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>同步统计基础数据</p>
     * 
     * @param request SyncDataRequest
     * @param headers SyncDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SyncDataResponse
     */
    public SyncDataResponse syncDataWithOptions(SyncDataRequest request, SyncDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dataId)) {
            body.put("dataId", request.dataId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.etlTime)) {
            body.put("etlTime", request.etlTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaId)) {
            body.put("schemaId", request.schemaId);
        }

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
            new TeaPair("action", "SyncData"),
            new TeaPair("version", "hrbrain_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrbrain/datas"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>同步统计基础数据</p>
     * 
     * @param request SyncDataRequest
     * @return SyncDataResponse
     */
    public SyncDataResponse syncData(SyncDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncDataHeaders headers = new SyncDataHeaders();
        return this.syncDataWithOptions(request, headers, runtime);
    }
}
