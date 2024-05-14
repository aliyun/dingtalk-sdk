// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkchengfeng_1_0.models.*;

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
     * @summary 获取组织下的全部职级
     *
     * @param headers GetAllJobLevelHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAllJobLevelResponse
     */
    public GetAllJobLevelResponse getAllJobLevelWithOptions(GetAllJobLevelHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetAllJobLevel"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/jobLevels"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAllJobLevelResponse());
    }

    /**
     * @summary 获取组织下的全部职级
     *
     * @return GetAllJobLevelResponse
     */
    public GetAllJobLevelResponse getAllJobLevel() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAllJobLevelHeaders headers = new GetAllJobLevelHeaders();
        return this.getAllJobLevelWithOptions(headers, runtime);
    }

    /**
     * @summary 获取公司全部职位
     *
     * @param headers GetAllJobPositionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAllJobPositionResponse
     */
    public GetAllJobPositionResponse getAllJobPositionWithOptions(GetAllJobPositionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetAllJobPosition"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/jobPositions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAllJobPositionResponse());
    }

    /**
     * @summary 获取公司全部职位
     *
     * @return GetAllJobPositionResponse
     */
    public GetAllJobPositionResponse getAllJobPosition() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAllJobPositionHeaders headers = new GetAllJobPositionHeaders();
        return this.getAllJobPositionWithOptions(headers, runtime);
    }

    /**
     * @summary 获取组织下的所有职务
     *
     * @param headers GetAllJobPostHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAllJobPostResponse
     */
    public GetAllJobPostResponse getAllJobPostWithOptions(GetAllJobPostHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetAllJobPost"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/jobPosts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAllJobPostResponse());
    }

    /**
     * @summary 获取组织下的所有职务
     *
     * @return GetAllJobPostResponse
     */
    public GetAllJobPostResponse getAllJobPost() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAllJobPostHeaders headers = new GetAllJobPostHeaders();
        return this.getAllJobPostWithOptions(headers, runtime);
    }

    /**
     * @summary 获取分析运营数据
     *
     * @param request GetAnalyzeDataRequest
     * @param headers GetAnalyzeDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAnalyzeDataResponse
     */
    public GetAnalyzeDataResponse getAnalyzeDataWithOptions(GetAnalyzeDataRequest request, GetAnalyzeDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.periodIds)) {
            body.put("periodIds", request.periodIds);
        }

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
            new TeaPair("action", "GetAnalyzeData"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/okr/analyses/datas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAnalyzeDataResponse());
    }

    /**
     * @summary 获取分析运营数据
     *
     * @param request GetAnalyzeDataRequest
     * @return GetAnalyzeDataResponse
     */
    public GetAnalyzeDataResponse getAnalyzeData(GetAnalyzeDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAnalyzeDataHeaders headers = new GetAnalyzeDataHeaders();
        return this.getAnalyzeDataWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据部门编码查询下组织列表
     *
     * @param request GetChildOrgListRequest
     * @param headers GetChildOrgListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetChildOrgListResponse
     */
    public GetChildOrgListResponse getChildOrgListWithOptions(GetChildOrgListRequest request, GetChildOrgListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptCode)) {
            query.put("deptCode", request.deptCode);
        }

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
            new TeaPair("action", "GetChildOrgList"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/organizations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetChildOrgListResponse());
    }

    /**
     * @summary 根据部门编码查询下组织列表
     *
     * @param request GetChildOrgListRequest
     * @return GetChildOrgListResponse
     */
    public GetChildOrgListResponse getChildOrgList(GetChildOrgListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetChildOrgListHeaders headers = new GetChildOrgListHeaders();
        return this.getChildOrgListWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据工号查询员工基础信息
     *
     * @param request GetEmployeeInfoByWorkNoRequest
     * @param headers GetEmployeeInfoByWorkNoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetEmployeeInfoByWorkNoResponse
     */
    public GetEmployeeInfoByWorkNoResponse getEmployeeInfoByWorkNoWithOptions(GetEmployeeInfoByWorkNoRequest request, GetEmployeeInfoByWorkNoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.workNo)) {
            query.put("workNo", request.workNo);
        }

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
            new TeaPair("action", "GetEmployeeInfoByWorkNo"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/workNumbers/employees"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetEmployeeInfoByWorkNoResponse());
    }

    /**
     * @summary 根据工号查询员工基础信息
     *
     * @param request GetEmployeeInfoByWorkNoRequest
     * @return GetEmployeeInfoByWorkNoResponse
     */
    public GetEmployeeInfoByWorkNoResponse getEmployeeInfoByWorkNo(GetEmployeeInfoByWorkNoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEmployeeInfoByWorkNoHeaders headers = new GetEmployeeInfoByWorkNoHeaders();
        return this.getEmployeeInfoByWorkNoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据人员工号查询人员任职记录
     *
     * @param headers GetEmploymentRecordByWorkNoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetEmploymentRecordByWorkNoResponse
     */
    public GetEmploymentRecordByWorkNoResponse getEmploymentRecordByWorkNoWithOptions(String workNumbers, GetEmploymentRecordByWorkNoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetEmploymentRecordByWorkNo"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/users/workNumber/" + workNumbers + "employmentRecords"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetEmploymentRecordByWorkNoResponse());
    }

    /**
     * @summary 根据人员工号查询人员任职记录
     *
     * @return GetEmploymentRecordByWorkNoResponse
     */
    public GetEmploymentRecordByWorkNoResponse getEmploymentRecordByWorkNo(String workNumbers) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEmploymentRecordByWorkNoHeaders headers = new GetEmploymentRecordByWorkNoHeaders();
        return this.getEmploymentRecordByWorkNoWithOptions(workNumbers, headers, runtime);
    }

    /**
     * @summary 获取职位详情
     *
     * @param request GetJobPositionRequest
     * @param headers GetJobPositionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetJobPositionResponse
     */
    public GetJobPositionResponse getJobPositionWithOptions(GetJobPositionRequest request, GetJobPositionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.jobPositionCode)) {
            query.put("jobPositionCode", request.jobPositionCode);
        }

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
            new TeaPair("action", "GetJobPosition"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/jobPositions/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetJobPositionResponse());
    }

    /**
     * @summary 获取职位详情
     *
     * @param request GetJobPositionRequest
     * @return GetJobPositionResponse
     */
    public GetJobPositionResponse getJobPosition(GetJobPositionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetJobPositionHeaders headers = new GetJobPositionHeaders();
        return this.getJobPositionWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据编码获取职位详情
     *
     * @param request GetJobPostRequest
     * @param headers GetJobPostHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetJobPostResponse
     */
    public GetJobPostResponse getJobPostWithOptions(GetJobPostRequest request, GetJobPostHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.jobPostCode)) {
            query.put("jobPostCode", request.jobPostCode);
        }

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
            new TeaPair("action", "GetJobPost"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/jobPosts/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetJobPostResponse());
    }

    /**
     * @summary 根据编码获取职位详情
     *
     * @param request GetJobPostRequest
     * @return GetJobPostResponse
     */
    public GetJobPostResponse getJobPost(GetJobPostRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetJobPostHeaders headers = new GetJobPostHeaders();
        return this.getJobPostWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取组织详情
     *
     * @param request GetOrgInfoRequest
     * @param headers GetOrgInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOrgInfoResponse
     */
    public GetOrgInfoResponse getOrgInfoWithOptions(GetOrgInfoRequest request, GetOrgInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptCode)) {
            query.put("deptCode", request.deptCode);
        }

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
            new TeaPair("action", "GetOrgInfo"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/organizations/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOrgInfoResponse());
    }

    /**
     * @summary 获取组织详情
     *
     * @param request GetOrgInfoRequest
     * @return GetOrgInfoResponse
     */
    public GetOrgInfoResponse getOrgInfo(GetOrgInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOrgInfoHeaders headers = new GetOrgInfoHeaders();
        return this.getOrgInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据员工工号获取员工的基本信息
     *
     * @param request GetStaffInfoByWorkNoRequest
     * @param headers GetStaffInfoByWorkNoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetStaffInfoByWorkNoResponse
     */
    public GetStaffInfoByWorkNoResponse getStaffInfoByWorkNoWithOptions(GetStaffInfoByWorkNoRequest request, GetStaffInfoByWorkNoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.workNumbers)) {
            query.put("workNumbers", request.workNumbers);
        }

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
            new TeaPair("action", "GetStaffInfoByWorkNo"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetStaffInfoByWorkNoResponse());
    }

    /**
     * @summary 根据员工工号获取员工的基本信息
     *
     * @param request GetStaffInfoByWorkNoRequest
     * @return GetStaffInfoByWorkNoResponse
     */
    public GetStaffInfoByWorkNoResponse getStaffInfoByWorkNo(GetStaffInfoByWorkNoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetStaffInfoByWorkNoHeaders headers = new GetStaffInfoByWorkNoHeaders();
        return this.getStaffInfoByWorkNoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 分页查询员工信息
     *
     * @param request GetStaffPageQueryRequest
     * @param headers GetStaffPageQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetStaffPageQueryResponse
     */
    public GetStaffPageQueryResponse getStaffPageQueryWithOptions(GetStaffPageQueryRequest request, GetStaffPageQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptCode)) {
            query.put("deptCode", request.deptCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            query.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workNo)) {
            query.put("workNo", request.workNo);
        }

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
            new TeaPair("action", "GetStaffPageQuery"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/users/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetStaffPageQueryResponse());
    }

    /**
     * @summary 分页查询员工信息
     *
     * @param request GetStaffPageQueryRequest
     * @return GetStaffPageQueryResponse
     */
    public GetStaffPageQueryResponse getStaffPageQuery(GetStaffPageQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetStaffPageQueryHeaders headers = new GetStaffPageQueryHeaders();
        return this.getStaffPageQueryWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取用户信息
     *
     * @param request GetUserRequest
     * @param headers GetUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserResponse
     */
    public GetUserResponse getUserWithOptions(GetUserRequest request, GetUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.okrUserId)) {
            query.put("okrUserId", request.okrUserId);
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
            new TeaPair("action", "GetUser"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/okr/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserResponse());
    }

    /**
     * @summary 获取用户信息
     *
     * @param request GetUserRequest
     * @return GetUserResponse
     */
    public GetUserResponse getUser(GetUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserHeaders headers = new GetUserHeaders();
        return this.getUserWithOptions(request, headers, runtime);
    }

    /**
     * @summary 运营数据分析下的周期列表
     *
     * @param headers ListAnalyzePeriodsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAnalyzePeriodsResponse
     */
    public ListAnalyzePeriodsResponse listAnalyzePeriodsWithOptions(ListAnalyzePeriodsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListAnalyzePeriods"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/okr/analyses/periods"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAnalyzePeriodsResponse());
    }

    /**
     * @summary 运营数据分析下的周期列表
     *
     * @return ListAnalyzePeriodsResponse
     */
    public ListAnalyzePeriodsResponse listAnalyzePeriods() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAnalyzePeriodsHeaders headers = new ListAnalyzePeriodsHeaders();
        return this.listAnalyzePeriodsWithOptions(headers, runtime);
    }

    /**
     * @summary 根据目标id批量获取目标列表
     *
     * @param request ListObjectiveByIdsRequest
     * @param headers ListObjectiveByIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListObjectiveByIdsResponse
     */
    public ListObjectiveByIdsResponse listObjectiveByIdsWithOptions(ListObjectiveByIdsRequest request, ListObjectiveByIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "ListObjectiveByIds"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/okr/objectives/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListObjectiveByIdsResponse());
    }

    /**
     * @summary 根据目标id批量获取目标列表
     *
     * @param request ListObjectiveByIdsRequest
     * @return ListObjectiveByIdsResponse
     */
    public ListObjectiveByIdsResponse listObjectiveByIds(ListObjectiveByIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListObjectiveByIdsHeaders headers = new ListObjectiveByIdsHeaders();
        return this.listObjectiveByIdsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取用户的 OKR 列表
     *
     * @param request ListObjectiveByUserRequest
     * @param headers ListObjectiveByUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListObjectiveByUserResponse
     */
    public ListObjectiveByUserResponse listObjectiveByUserWithOptions(ListObjectiveByUserRequest request, ListObjectiveByUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
            new TeaPair("action", "ListObjectiveByUser"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/okr/users/objectives"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListObjectiveByUserResponse());
    }

    /**
     * @summary 获取用户的 OKR 列表
     *
     * @param request ListObjectiveByUserRequest
     * @return ListObjectiveByUserResponse
     */
    public ListObjectiveByUserResponse listObjectiveByUser(ListObjectiveByUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListObjectiveByUserHeaders headers = new ListObjectiveByUserHeaders();
        return this.listObjectiveByUserWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据进展id获取进展列表
     *
     * @param request ListProgressByIdsRequest
     * @param headers ListProgressByIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListProgressByIdsResponse
     */
    public ListProgressByIdsResponse listProgressByIdsWithOptions(ListProgressByIdsRequest request, ListProgressByIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.progressIds)) {
            body.put("progressIds", request.progressIds);
        }

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
            new TeaPair("action", "ListProgressByIds"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/okr/objectives/progresses/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListProgressByIdsResponse());
    }

    /**
     * @summary 根据进展id获取进展列表
     *
     * @param request ListProgressByIdsRequest
     * @return ListProgressByIdsResponse
     */
    public ListProgressByIdsResponse listProgressByIds(ListProgressByIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListProgressByIdsHeaders headers = new ListProgressByIdsHeaders();
        return this.listProgressByIdsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 分页获取目标进展记录
     *
     * @param request PageListObjectiveProgressRequest
     * @param headers PageListObjectiveProgressHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PageListObjectiveProgressResponse
     */
    public PageListObjectiveProgressResponse pageListObjectiveProgressWithOptions(PageListObjectiveProgressRequest request, PageListObjectiveProgressHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.objectiveId)) {
            query.put("objectiveId", request.objectiveId);
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
            new TeaPair("action", "PageListObjectiveProgress"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/okr/objectives/progresses/records"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PageListObjectiveProgressResponse());
    }

    /**
     * @summary 分页获取目标进展记录
     *
     * @param request PageListObjectiveProgressRequest
     * @return PageListObjectiveProgressResponse
     */
    public PageListObjectiveProgressResponse pageListObjectiveProgress(PageListObjectiveProgressRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PageListObjectiveProgressHeaders headers = new PageListObjectiveProgressHeaders();
        return this.pageListObjectiveProgressWithOptions(request, headers, runtime);
    }

    /**
     * @summary 转交目标OKR
     *
     * @param request TransferUserObjectiveRequest
     * @param headers TransferUserObjectiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TransferUserObjectiveResponse
     */
    public TransferUserObjectiveResponse transferUserObjectiveWithOptions(TransferUserObjectiveRequest request, TransferUserObjectiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.objectiveId)) {
            query.put("objectiveId", request.objectiveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetUserId)) {
            query.put("targetUserId", request.targetUserId);
        }

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
            new TeaPair("action", "TransferUserObjective"),
            new TeaPair("version", "chengfeng_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/chengfeng/okr/objectives/transfer"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TransferUserObjectiveResponse());
    }

    /**
     * @summary 转交目标OKR
     *
     * @param request TransferUserObjectiveRequest
     * @return TransferUserObjectiveResponse
     */
    public TransferUserObjectiveResponse transferUserObjective(TransferUserObjectiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TransferUserObjectiveHeaders headers = new TransferUserObjectiveHeaders();
        return this.transferUserObjectiveWithOptions(request, headers, runtime);
    }
}
