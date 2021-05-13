// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkedu_1_0.models.*;
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


    public QueryOrgTypeResponse queryOrgType() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryOrgTypeHeaders headers = new QueryOrgTypeHeaders();
        return this.queryOrgTypeWithOptions(headers, runtime);
    }

    public QueryOrgTypeResponse queryOrgTypeWithOptions(QueryOrgTypeHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryOrgType", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/orgTypes", "json", req, runtime), new QueryOrgTypeResponse());
    }

    public BatchCreateResponse batchCreate(BatchCreateRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchCreateHeaders headers = new BatchCreateHeaders();
        return this.batchCreateWithOptions(request, headers, runtime);
    }

    public BatchCreateResponse batchCreateWithOptions(BatchCreateRequest request, BatchCreateHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardBizCode)) {
            body.put("cardBizCode", request.cardBizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifier)) {
            body.put("identifier", request.identifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceType)) {
            body.put("sourceType", request.sourceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jsVersion)) {
            body.put("jsVersion", request.jsVersion);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchCreate", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/cards", "json", req, runtime), new BatchCreateResponse());
    }

    public BatchOrgCreateHWResponse batchOrgCreateHW(BatchOrgCreateHWRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchOrgCreateHWHeaders headers = new BatchOrgCreateHWHeaders();
        return this.batchOrgCreateHWWithOptions(request, headers, runtime);
    }

    public BatchOrgCreateHWResponse batchOrgCreateHWWithOptions(BatchOrgCreateHWRequest request, BatchOrgCreateHWHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.hwMedia)) {
            body.put("hwMedia", request.hwMedia);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwContent)) {
            body.put("hwContent", request.hwContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwTitle)) {
            body.put("hwTitle", request.hwTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseName)) {
            body.put("courseName", request.courseName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwPhoto)) {
            body.put("hwPhoto", request.hwPhoto);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwVideo)) {
            body.put("hwVideo", request.hwVideo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherName)) {
            body.put("teacherName", request.teacherName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserId)) {
            body.put("teacherUserId", request.teacherUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifier)) {
            body.put("identifier", request.identifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.attributes)) {
            body.put("attributes", request.attributes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetRole)) {
            body.put("targetRole", request.targetRole);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduledRelease)) {
            body.put("scheduledRelease", request.scheduledRelease);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduledTime)) {
            body.put("scheduledTime", request.scheduledTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwDeadlineOpen)) {
            body.put("hwDeadlineOpen", request.hwDeadlineOpen);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwDeadline)) {
            body.put("hwDeadline", request.hwDeadline);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwType)) {
            body.put("hwType", request.hwType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openSelectItemList)) {
            body.put("openSelectItemList", request.openSelectItemList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchOrgCreateHW", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/homeworks", "json", req, runtime), new BatchOrgCreateHWResponse());
    }

    public CreateCustomDeptResponse createCustomDept(CreateCustomDeptRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateCustomDeptHeaders headers = new CreateCustomDeptHeaders();
        return this.createCustomDeptWithOptions(request, headers, runtime);
    }

    public CreateCustomDeptResponse createCustomDeptWithOptions(CreateCustomDeptRequest request, CreateCustomDeptHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.customDept))) {
            body.put("customDept", request.customDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superId)) {
            body.put("superId", request.superId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOauthAppId)) {
            body.put("dingOauthAppId", request.dingOauthAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateCustomDept", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/customDepts", "json", req, runtime), new CreateCustomDeptResponse());
    }

    public DeleteDeptResponse deleteDept(String deptId, DeleteDeptRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteDeptHeaders headers = new DeleteDeptHeaders();
        return this.deleteDeptWithOptions(deptId, request, headers, runtime);
    }

    public DeleteDeptResponse deleteDeptWithOptions(String deptId, DeleteDeptRequest request, DeleteDeptHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteDept", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/depts/" + deptId + "", "json", req, runtime), new DeleteDeptResponse());
    }

    public DeleteStudentResponse deleteStudent(String classId, String userId, DeleteStudentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteStudentHeaders headers = new DeleteStudentHeaders();
        return this.deleteStudentWithOptions(classId, userId, request, headers, runtime);
    }

    public DeleteStudentResponse deleteStudentWithOptions(String classId, String userId, DeleteStudentRequest request, DeleteStudentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteStudent", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/classes/" + classId + "/students/" + userId + "", "json", req, runtime), new DeleteStudentResponse());
    }

    public DeleteGuardianResponse deleteGuardian(String classId, String userId, DeleteGuardianRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteGuardianHeaders headers = new DeleteGuardianHeaders();
        return this.deleteGuardianWithOptions(classId, userId, request, headers, runtime);
    }

    public DeleteGuardianResponse deleteGuardianWithOptions(String classId, String userId, DeleteGuardianRequest request, DeleteGuardianHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.stuId)) {
            query.put("stuId", request.stuId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteGuardian", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/classes/" + classId + "/guardians/" + userId + "", "json", req, runtime), new DeleteGuardianResponse());
    }

    public CreateCustomClassResponse createCustomClass(CreateCustomClassRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateCustomClassHeaders headers = new CreateCustomClassHeaders();
        return this.createCustomClassWithOptions(request, headers, runtime);
    }

    public CreateCustomClassResponse createCustomClassWithOptions(CreateCustomClassRequest request, CreateCustomClassHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.customClass))) {
            body.put("customClass", request.customClass);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superId)) {
            body.put("superId", request.superId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOauthAppId)) {
            body.put("dingOauthAppId", request.dingOauthAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateCustomClass", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/customClasses", "json", req, runtime), new CreateCustomClassResponse());
    }

    public DeleteTeacherResponse deleteTeacher(String classId, String userId, DeleteTeacherRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteTeacherHeaders headers = new DeleteTeacherHeaders();
        return this.deleteTeacherWithOptions(classId, userId, request, headers, runtime);
    }

    public DeleteTeacherResponse deleteTeacherWithOptions(String classId, String userId, DeleteTeacherRequest request, DeleteTeacherHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.adviser)) {
            query.put("adviser", request.adviser);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteTeacher", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/classes/" + classId + "/teachers/" + userId + "", "json", req, runtime), new DeleteTeacherResponse());
    }
}
