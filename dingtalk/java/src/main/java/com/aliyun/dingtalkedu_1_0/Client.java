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


    public QueryStatisticsDataResponse queryStatisticsData(QueryStatisticsDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryStatisticsDataHeaders headers = new QueryStatisticsDataHeaders();
        return this.queryStatisticsDataWithOptions(request, headers, runtime);
    }

    public QueryStatisticsDataResponse queryStatisticsDataWithOptions(QueryStatisticsDataRequest request, QueryStatisticsDataHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sectionIndexList)) {
            body.put("sectionIndexList", request.sectionIndexList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserIds)) {
            body.put("teacherUserIds", request.teacherUserIds);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("QueryStatisticsData", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/classes/schedules/statisticData/query", "json", req, runtime), new QueryStatisticsDataResponse());
    }

    public QueryClassScheduleConfigResponse queryClassScheduleConfig(QueryClassScheduleConfigRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryClassScheduleConfigHeaders headers = new QueryClassScheduleConfigHeaders();
        return this.queryClassScheduleConfigWithOptions(request, headers, runtime);
    }

    public QueryClassScheduleConfigResponse queryClassScheduleConfigWithOptions(QueryClassScheduleConfigRequest tmpReq, QueryClassScheduleConfigHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        QueryClassScheduleConfigShrinkRequest request = new QueryClassScheduleConfigShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.classIds)) {
            request.classIdsShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.classIds, "classIds", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classIdsShrink)) {
            query.put("classIds", request.classIdsShrink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("QueryClassScheduleConfig", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/schedules/configs", "json", req, runtime), new QueryClassScheduleConfigResponse());
    }

    public GetDefaultChildResponse getDefaultChild() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDefaultChildHeaders headers = new GetDefaultChildHeaders();
        return this.getDefaultChildWithOptions(headers, runtime);
    }

    public GetDefaultChildResponse getDefaultChildWithOptions(GetDefaultChildHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetDefaultChild", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/defaultChildren", "json", req, runtime), new GetDefaultChildResponse());
    }

    public GetOpenCoursesResponse getOpenCourses(GetOpenCoursesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOpenCoursesHeaders headers = new GetOpenCoursesHeaders();
        return this.getOpenCoursesWithOptions(request, headers, runtime);
    }

    public GetOpenCoursesResponse getOpenCoursesWithOptions(GetOpenCoursesRequest request, GetOpenCoursesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetOpenCourses", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/openCourses", "json", req, runtime), new GetOpenCoursesResponse());
    }

    public CreateUniversityStudentResponse createUniversityStudent(CreateUniversityStudentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateUniversityStudentHeaders headers = new CreateUniversityStudentHeaders();
        return this.createUniversityStudentWithOptions(request, headers, runtime);
    }

    public CreateUniversityStudentResponse createUniversityStudentWithOptions(CreateUniversityStudentRequest request, CreateUniversityStudentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.studentNumber)) {
            body.put("studentNumber", request.studentNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gender)) {
            body.put("gender", request.gender);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identityNumber)) {
            body.put("identityNumber", request.identityNumber);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateUniversityStudent", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/students", "json", req, runtime), new CreateUniversityStudentResponse());
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

    public InitCoursesOfClassResponse initCoursesOfClass(String classId, InitCoursesOfClassRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        InitCoursesOfClassHeaders headers = new InitCoursesOfClassHeaders();
        return this.initCoursesOfClassWithOptions(classId, request, headers, runtime);
    }

    public InitCoursesOfClassResponse initCoursesOfClassWithOptions(String classId, InitCoursesOfClassRequest request, InitCoursesOfClassHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courses)) {
            body.put("courses", request.courses);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.sectionConfig))) {
            body.put("sectionConfig", request.sectionConfig);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("InitCoursesOfClass", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/classes/" + classId + "/courses/init", "json", req, runtime), new InitCoursesOfClassResponse());
    }

    public CreateInviteUrlResponse createInviteUrl(CreateInviteUrlRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateInviteUrlHeaders headers = new CreateInviteUrlHeaders();
        return this.createInviteUrlWithOptions(request, headers, runtime);
    }

    public CreateInviteUrlResponse createInviteUrlWithOptions(CreateInviteUrlRequest request, CreateInviteUrlHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOauthAppId)) {
            body.put("dingOauthAppId", request.dingOauthAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            body.put("authCode", request.authCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetOperator)) {
            body.put("targetOperator", request.targetOperator);
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
        return TeaModel.toModel(this.doROARequest("CreateInviteUrl", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/remoteClasses/orgRelations/inviteUrls", "json", req, runtime), new CreateInviteUrlResponse());
    }

    public PollingConfirmStatusResponse pollingConfirmStatus(PollingConfirmStatusRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PollingConfirmStatusHeaders headers = new PollingConfirmStatusHeaders();
        return this.pollingConfirmStatusWithOptions(request, headers, runtime);
    }

    public PollingConfirmStatusResponse pollingConfirmStatusWithOptions(PollingConfirmStatusRequest request, PollingConfirmStatusHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            query.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            query.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseCode)) {
            query.put("courseCode", request.courseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("PollingConfirmStatus", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/universities/courses/pollingConfirmStatus", "json", req, runtime), new PollingConfirmStatusResponse());
    }

    public CreateEduAssetSpaceResponse createEduAssetSpace(CreateEduAssetSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateEduAssetSpaceHeaders headers = new CreateEduAssetSpaceHeaders();
        return this.createEduAssetSpaceWithOptions(request, headers, runtime);
    }

    public CreateEduAssetSpaceResponse createEduAssetSpaceWithOptions(CreateEduAssetSpaceRequest request, CreateEduAssetSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.spaceName)) {
            body.put("spaceName", request.spaceName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceDesc)) {
            body.put("spaceDesc", request.spaceDesc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceIcon)) {
            body.put("spaceIcon", request.spaceIcon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
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
        return TeaModel.toModel(this.doROARequest("CreateEduAssetSpace", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/assets/spaces", "json", req, runtime), new CreateEduAssetSpaceResponse());
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

    public DeleteUniversityTeacherResponse deleteUniversityTeacher(DeleteUniversityTeacherRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteUniversityTeacherHeaders headers = new DeleteUniversityTeacherHeaders();
        return this.deleteUniversityTeacherWithOptions(request, headers, runtime);
    }

    public DeleteUniversityTeacherResponse deleteUniversityTeacherWithOptions(DeleteUniversityTeacherRequest request, DeleteUniversityTeacherHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            query.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            query.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserId)) {
            query.put("teacherUserId", request.teacherUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("DeleteUniversityTeacher", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/universities/teachers", "json", req, runtime), new DeleteUniversityTeacherResponse());
    }

    public QueryPurchaseInfoResponse queryPurchaseInfo(QueryPurchaseInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryPurchaseInfoHeaders headers = new QueryPurchaseInfoHeaders();
        return this.queryPurchaseInfoWithOptions(request, headers, runtime);
    }

    public QueryPurchaseInfoResponse queryPurchaseInfoWithOptions(QueryPurchaseInfoRequest request, QueryPurchaseInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            query.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            query.put("scene", request.scene);
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
        return TeaModel.toModel(this.doROARequest("QueryPurchaseInfo", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/users/purchases", "json", req, runtime), new QueryPurchaseInfoResponse());
    }

    public DeleteDeviceOrgResponse deleteDeviceOrg(DeleteDeviceOrgRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteDeviceOrgHeaders headers = new DeleteDeviceOrgHeaders();
        return this.deleteDeviceOrgWithOptions(request, headers, runtime);
    }

    public DeleteDeviceOrgResponse deleteDeviceOrgWithOptions(DeleteDeviceOrgRequest request, DeleteDeviceOrgHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceCode)) {
            query.put("deviceCode", request.deviceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            query.put("authCode", request.authCode);
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
        return TeaModel.toModel(this.doROARequest("DeleteDeviceOrg", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/remoteClasses/deviceOrgs", "json", req, runtime), new DeleteDeviceOrgResponse());
    }

    public DeleteRemoteClassCourseResponse deleteRemoteClassCourse(String courseCode, DeleteRemoteClassCourseRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteRemoteClassCourseHeaders headers = new DeleteRemoteClassCourseHeaders();
        return this.deleteRemoteClassCourseWithOptions(courseCode, request, headers, runtime);
    }

    public DeleteRemoteClassCourseResponse deleteRemoteClassCourseWithOptions(String courseCode, DeleteRemoteClassCourseRequest request, DeleteRemoteClassCourseHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            query.put("authCode", request.authCode);
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
        return TeaModel.toModel(this.doROARequest("DeleteRemoteClassCourse", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/remoteClasses/courses/" + courseCode + "", "json", req, runtime), new DeleteRemoteClassCourseResponse());
    }

    public GetOpenCourseDetailResponse getOpenCourseDetail(String courseId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOpenCourseDetailHeaders headers = new GetOpenCourseDetailHeaders();
        return this.getOpenCourseDetailWithOptions(courseId, headers, runtime);
    }

    public GetOpenCourseDetailResponse getOpenCourseDetailWithOptions(String courseId, GetOpenCourseDetailHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetOpenCourseDetail", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/openCourse/" + courseId + "", "json", req, runtime), new GetOpenCourseDetailResponse());
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

    public UpdateCoursesOfClassResponse updateCoursesOfClass(String classId, UpdateCoursesOfClassRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateCoursesOfClassHeaders headers = new UpdateCoursesOfClassHeaders();
        return this.updateCoursesOfClassWithOptions(classId, request, headers, runtime);
    }

    public UpdateCoursesOfClassResponse updateCoursesOfClassWithOptions(String classId, UpdateCoursesOfClassRequest request, UpdateCoursesOfClassHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courses)) {
            body.put("courses", request.courses);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.sectionConfig))) {
            body.put("sectionConfig", request.sectionConfig);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateCoursesOfClass", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/classes/" + classId + "/courses/schedules", "json", req, runtime), new UpdateCoursesOfClassResponse());
    }

    public CreateSectionConfigResponse createSectionConfig(CreateSectionConfigRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateSectionConfigHeaders headers = new CreateSectionConfigHeaders();
        return this.createSectionConfigWithOptions(request, headers, runtime);
    }

    public CreateSectionConfigResponse createSectionConfigWithOptions(CreateSectionConfigRequest request, CreateSectionConfigHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sectionConfigs)) {
            body.put("sectionConfigs", request.sectionConfigs);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateSectionConfig", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/sectionConfigs", "json", req, runtime), new CreateSectionConfigResponse());
    }

    public QuerySubjectTeachersResponse querySubjectTeachers(QuerySubjectTeachersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QuerySubjectTeachersHeaders headers = new QuerySubjectTeachersHeaders();
        return this.querySubjectTeachersWithOptions(request, headers, runtime);
    }

    public QuerySubjectTeachersResponse querySubjectTeachersWithOptions(QuerySubjectTeachersRequest request, QuerySubjectTeachersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classIds)) {
            query.put("classIds", request.classIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjectCode)) {
            query.put("subjectCode", request.subjectCode);
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
        return TeaModel.toModel(this.doROARequest("QuerySubjectTeachers", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/subjects/teachers", "json", req, runtime), new QuerySubjectTeachersResponse());
    }

    public QueryRemoteClassCourseResponse queryRemoteClassCourse(QueryRemoteClassCourseRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryRemoteClassCourseHeaders headers = new QueryRemoteClassCourseHeaders();
        return this.queryRemoteClassCourseWithOptions(request, headers, runtime);
    }

    public QueryRemoteClassCourseResponse queryRemoteClassCourseWithOptions(QueryRemoteClassCourseRequest request, QueryRemoteClassCourseHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
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
        return TeaModel.toModel(this.doROARequest("QueryRemoteClassCourse", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/courses", "json", req, runtime), new QueryRemoteClassCourseResponse());
    }

    public CreatePhysicalClassroomResponse createPhysicalClassroom(CreatePhysicalClassroomRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreatePhysicalClassroomHeaders headers = new CreatePhysicalClassroomHeaders();
        return this.createPhysicalClassroomWithOptions(request, headers, runtime);
    }

    public CreatePhysicalClassroomResponse createPhysicalClassroomWithOptions(CreatePhysicalClassroomRequest request, CreatePhysicalClassroomHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classroomFloor)) {
            body.put("classroomFloor", request.classroomFloor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomBuilding)) {
            body.put("classroomBuilding", request.classroomBuilding);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.directBroadcast)) {
            body.put("directBroadcast", request.directBroadcast);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomName)) {
            body.put("classroomName", request.classroomName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomCampus)) {
            body.put("classroomCampus", request.classroomCampus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomNumber)) {
            body.put("classroomNumber", request.classroomNumber);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreatePhysicalClassroom", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime), new CreatePhysicalClassroomResponse());
    }

    public QueryClassScheduleResponse queryClassSchedule(QueryClassScheduleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryClassScheduleHeaders headers = new QueryClassScheduleHeaders();
        return this.queryClassScheduleWithOptions(request, headers, runtime);
    }

    public QueryClassScheduleResponse queryClassScheduleWithOptions(QueryClassScheduleRequest request, QueryClassScheduleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subscriberType)) {
            query.put("subscriberType", request.subscriberType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subscriberIds)) {
            body.put("subscriberIds", request.subscriberIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sectionIndexList)) {
            body.put("sectionIndexList", request.sectionIndexList);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("QueryClassSchedule", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/classes/schedules/query", "json", req, runtime), new QueryClassScheduleResponse());
    }

    public CreateRemoteClassCourseResponse createRemoteClassCourse(CreateRemoteClassCourseRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateRemoteClassCourseHeaders headers = new CreateRemoteClassCourseHeaders();
        return this.createRemoteClassCourseWithOptions(request, headers, runtime);
    }

    public CreateRemoteClassCourseResponse createRemoteClassCourseWithOptions(CreateRemoteClassCourseRequest request, CreateRemoteClassCourseHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseName)) {
            body.put("courseName", request.courseName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.teachingParticipant))) {
            body.put("teachingParticipant", request.teachingParticipant);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.attendParticipants)) {
            body.put("attendParticipants", request.attendParticipants);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            body.put("authCode", request.authCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingClientId)) {
            body.put("dingClientId", request.dingClientId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOauthAppId)) {
            body.put("dingOauthAppId", request.dingOauthAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
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
        return TeaModel.toModel(this.doROARequest("CreateRemoteClassCourse", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/remoteClasses/courses", "json", req, runtime), new CreateRemoteClassCourseResponse());
    }

    public ReportDeviceLogResponse reportDeviceLog(ReportDeviceLogRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ReportDeviceLogHeaders headers = new ReportDeviceLogHeaders();
        return this.reportDeviceLogWithOptions(request, headers, runtime);
    }

    public ReportDeviceLogResponse reportDeviceLogWithOptions(ReportDeviceLogRequest request, ReportDeviceLogHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            query.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
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
        return TeaModel.toModel(this.doROARequest("ReportDeviceLog", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/deviceLogs/report", "json", req, runtime), new ReportDeviceLogResponse());
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

    public UpdatePhysicalClassroomResponse updatePhysicalClassroom(UpdatePhysicalClassroomRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdatePhysicalClassroomHeaders headers = new UpdatePhysicalClassroomHeaders();
        return this.updatePhysicalClassroomWithOptions(request, headers, runtime);
    }

    public UpdatePhysicalClassroomResponse updatePhysicalClassroomWithOptions(UpdatePhysicalClassroomRequest request, UpdatePhysicalClassroomHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classroomFloor)) {
            body.put("classroomFloor", request.classroomFloor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomBuilding)) {
            body.put("classroomBuilding", request.classroomBuilding);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.directBroadcast)) {
            body.put("directBroadcast", request.directBroadcast);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomName)) {
            body.put("classroomName", request.classroomName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomCampus)) {
            body.put("classroomCampus", request.classroomCampus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomNumber)) {
            body.put("classroomNumber", request.classroomNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomId)) {
            body.put("classroomId", request.classroomId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdatePhysicalClassroom", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime), new UpdatePhysicalClassroomResponse());
    }

    public MoveStudentResponse moveStudent(MoveStudentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        MoveStudentHeaders headers = new MoveStudentHeaders();
        return this.moveStudentWithOptions(request, headers, runtime);
    }

    public MoveStudentResponse moveStudentWithOptions(MoveStudentRequest request, MoveStudentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.originClassId)) {
            body.put("originClassId", request.originClassId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetClassId)) {
            body.put("targetClassId", request.targetClassId);
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
        return TeaModel.toModel(this.doROARequest("MoveStudent", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/students/move", "json", req, runtime), new MoveStudentResponse());
    }

    public QueryEduAssetSpacesResponse queryEduAssetSpaces(QueryEduAssetSpacesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryEduAssetSpacesHeaders headers = new QueryEduAssetSpacesHeaders();
        return this.queryEduAssetSpacesWithOptions(request, headers, runtime);
    }

    public QueryEduAssetSpacesResponse queryEduAssetSpacesWithOptions(QueryEduAssetSpacesRequest request, QueryEduAssetSpacesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
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
        return TeaModel.toModel(this.doROARequest("QueryEduAssetSpaces", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/assets/spaces", "json", req, runtime), new QueryEduAssetSpacesResponse());
    }

    public CreateUniversityCourseGroupResponse createUniversityCourseGroup(CreateUniversityCourseGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateUniversityCourseGroupHeaders headers = new CreateUniversityCourseGroupHeaders();
        return this.createUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    public CreateUniversityCourseGroupResponse createUniversityCourseGroupWithOptions(CreateUniversityCourseGroupRequest request, CreateUniversityCourseGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isvCourseGroupCode)) {
            body.put("isvCourseGroupCode", request.isvCourseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupIntroduce)) {
            body.put("courseGroupIntroduce", request.courseGroupIntroduce);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.semester)) {
            body.put("semester", request.semester);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjectName)) {
            body.put("subjectName", request.subjectName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupName)) {
            body.put("courseGroupName", request.courseGroupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schoolYear)) {
            body.put("schoolYear", request.schoolYear);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodCode)) {
            body.put("periodCode", request.periodCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherInfos)) {
            body.put("teacherInfos", request.teacherInfos);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courserGroupItemModels)) {
            body.put("courserGroupItemModels", request.courserGroupItemModels);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime), new CreateUniversityCourseGroupResponse());
    }

    public GetRemoteClassCourseResponse getRemoteClassCourse(String courseCode, GetRemoteClassCourseRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetRemoteClassCourseHeaders headers = new GetRemoteClassCourseHeaders();
        return this.getRemoteClassCourseWithOptions(courseCode, request, headers, runtime);
    }

    public GetRemoteClassCourseResponse getRemoteClassCourseWithOptions(String courseCode, GetRemoteClassCourseRequest request, GetRemoteClassCourseHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetRemoteClassCourse", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/courses/" + courseCode + "", "json", req, runtime), new GetRemoteClassCourseResponse());
    }

    public QueryUniversityCourseGroupResponse queryUniversityCourseGroup(QueryUniversityCourseGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUniversityCourseGroupHeaders headers = new QueryUniversityCourseGroupHeaders();
        return this.queryUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    public QueryUniversityCourseGroupResponse queryUniversityCourseGroupWithOptions(QueryUniversityCourseGroupRequest request, QueryUniversityCourseGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            query.put("courseGroupCode", request.courseGroupCode);
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
        return TeaModel.toModel(this.doROARequest("QueryUniversityCourseGroup", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime), new QueryUniversityCourseGroupResponse());
    }

    public QueryAllSubjectsFromClassScheduleResponse queryAllSubjectsFromClassSchedule(QueryAllSubjectsFromClassScheduleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllSubjectsFromClassScheduleHeaders headers = new QueryAllSubjectsFromClassScheduleHeaders();
        return this.queryAllSubjectsFromClassScheduleWithOptions(request, headers, runtime);
    }

    public QueryAllSubjectsFromClassScheduleResponse queryAllSubjectsFromClassScheduleWithOptions(QueryAllSubjectsFromClassScheduleRequest tmpReq, QueryAllSubjectsFromClassScheduleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        QueryAllSubjectsFromClassScheduleShrinkRequest request = new QueryAllSubjectsFromClassScheduleShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.classIds)) {
            request.classIdsShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.classIds, "classIds", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classIdsShrink)) {
            query.put("classIds", request.classIdsShrink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodCode)) {
            query.put("periodCode", request.periodCode);
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
        return TeaModel.toModel(this.doROARequest("QueryAllSubjectsFromClassSchedule", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/subjects/instances", "json", req, runtime), new QueryAllSubjectsFromClassScheduleResponse());
    }

    public CourseSchedulingComplimentNoticeResponse courseSchedulingComplimentNotice(CourseSchedulingComplimentNoticeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CourseSchedulingComplimentNoticeHeaders headers = new CourseSchedulingComplimentNoticeHeaders();
        return this.courseSchedulingComplimentNoticeWithOptions(request, headers, runtime);
    }

    public CourseSchedulingComplimentNoticeResponse courseSchedulingComplimentNoticeWithOptions(CourseSchedulingComplimentNoticeRequest request, CourseSchedulingComplimentNoticeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("CourseSchedulingComplimentNotice", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/schedules/finishNotify", "json", req, runtime), new CourseSchedulingComplimentNoticeResponse());
    }

    public DeleteUniversityCourseGroupResponse deleteUniversityCourseGroup(DeleteUniversityCourseGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteUniversityCourseGroupHeaders headers = new DeleteUniversityCourseGroupHeaders();
        return this.deleteUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    public DeleteUniversityCourseGroupResponse deleteUniversityCourseGroupWithOptions(DeleteUniversityCourseGroupRequest request, DeleteUniversityCourseGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            query.put("courseGroupCode", request.courseGroupCode);
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
        return TeaModel.toModel(this.doROARequest("DeleteUniversityCourseGroup", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime), new DeleteUniversityCourseGroupResponse());
    }

    public DeviceHeartbeatResponse deviceHeartbeat(DeviceHeartbeatRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeviceHeartbeatHeaders headers = new DeviceHeartbeatHeaders();
        return this.deviceHeartbeatWithOptions(request, headers, runtime);
    }

    public DeviceHeartbeatResponse deviceHeartbeatWithOptions(DeviceHeartbeatRequest request, DeviceHeartbeatHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
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
        return TeaModel.toModel(this.doROARequest("DeviceHeartbeat", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/heartbeats/report", "json", req, runtime), new DeviceHeartbeatResponse());
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

    public InsertSectionConfigResponse insertSectionConfig(InsertSectionConfigRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        InsertSectionConfigHeaders headers = new InsertSectionConfigHeaders();
        return this.insertSectionConfigWithOptions(request, headers, runtime);
    }

    public InsertSectionConfigResponse insertSectionConfigWithOptions(InsertSectionConfigRequest request, InsertSectionConfigHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sectionModels)) {
            body.put("sectionModels", request.sectionModels);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.start))) {
            body.put("start", request.start);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.end))) {
            body.put("end", request.end);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduleName)) {
            body.put("scheduleName", request.scheduleName);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("InsertSectionConfig", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/schedules/configs", "json", req, runtime), new InsertSectionConfigResponse());
    }

    public QueryUserFaceResponse queryUserFace(QueryUserFaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserFaceHeaders headers = new QueryUserFaceHeaders();
        return this.queryUserFaceWithOptions(request, headers, runtime);
    }

    public QueryUserFaceResponse queryUserFaceWithOptions(QueryUserFaceRequest request, QueryUserFaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.faceId)) {
            query.put("faceId", request.faceId);
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
        return TeaModel.toModel(this.doROARequest("QueryUserFace", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/users/faces", "json", req, runtime), new QueryUserFaceResponse());
    }

    public QueryDeviceListByCorpIdResponse queryDeviceListByCorpId(QueryDeviceListByCorpIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryDeviceListByCorpIdHeaders headers = new QueryDeviceListByCorpIdHeaders();
        return this.queryDeviceListByCorpIdWithOptions(request, headers, runtime);
    }

    public QueryDeviceListByCorpIdResponse queryDeviceListByCorpIdWithOptions(QueryDeviceListByCorpIdRequest request, QueryDeviceListByCorpIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryDeviceListByCorpId", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/devices", "json", req, runtime), new QueryDeviceListByCorpIdResponse());
    }

    public UpdateUniversityCourseGroupResponse updateUniversityCourseGroup(UpdateUniversityCourseGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateUniversityCourseGroupHeaders headers = new UpdateUniversityCourseGroupHeaders();
        return this.updateUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    public UpdateUniversityCourseGroupResponse updateUniversityCourseGroupWithOptions(UpdateUniversityCourseGroupRequest request, UpdateUniversityCourseGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            body.put("courseGroupCode", request.courseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupIntroduce)) {
            body.put("courseGroupIntroduce", request.courseGroupIntroduce);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupName)) {
            body.put("courseGroupName", request.courseGroupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courserGroupItemModels)) {
            body.put("courserGroupItemModels", request.courserGroupItemModels);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateUniversityCourseGroup", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime), new UpdateUniversityCourseGroupResponse());
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

    public StartCoursePrepareResponse startCoursePrepare(StartCoursePrepareRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        StartCoursePrepareHeaders headers = new StartCoursePrepareHeaders();
        return this.startCoursePrepareWithOptions(request, headers, runtime);
    }

    public StartCoursePrepareResponse startCoursePrepareWithOptions(StartCoursePrepareRequest request, StartCoursePrepareHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            body.put("courseGroupCode", request.courseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sectionIndex)) {
            body.put("sectionIndex", request.sectionIndex);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceId)) {
            body.put("deviceId", request.deviceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.liveCoverImage)) {
            body.put("liveCoverImage", request.liveCoverImage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseDate)) {
            body.put("courseDate", request.courseDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("StartCoursePrepare", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courses/prepare", "json", req, runtime), new StartCoursePrepareResponse());
    }

    public QueryClassScheduleByTimeSchoolResponse queryClassScheduleByTimeSchool(QueryClassScheduleByTimeSchoolRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryClassScheduleByTimeSchoolHeaders headers = new QueryClassScheduleByTimeSchoolHeaders();
        return this.queryClassScheduleByTimeSchoolWithOptions(request, headers, runtime);
    }

    public QueryClassScheduleByTimeSchoolResponse queryClassScheduleByTimeSchoolWithOptions(QueryClassScheduleByTimeSchoolRequest request, QueryClassScheduleByTimeSchoolHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("QueryClassScheduleByTimeSchool", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/schools/classes/courses ", "json", req, runtime), new QueryClassScheduleByTimeSchoolResponse());
    }

    public QueryTeachSubjectsResponse queryTeachSubjects(QueryTeachSubjectsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryTeachSubjectsHeaders headers = new QueryTeachSubjectsHeaders();
        return this.queryTeachSubjectsWithOptions(request, headers, runtime);
    }

    public QueryTeachSubjectsResponse queryTeachSubjectsWithOptions(QueryTeachSubjectsRequest request, QueryTeachSubjectsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classIds)) {
            query.put("classIds", request.classIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("QueryTeachSubjects", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/teachers/subjects", "json", req, runtime), new QueryTeachSubjectsResponse());
    }

    public GetShareRolesResponse getShareRoles() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetShareRolesHeaders headers = new GetShareRolesHeaders();
        return this.getShareRolesWithOptions(headers, runtime);
    }

    public GetShareRolesResponse getShareRolesWithOptions(GetShareRolesHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetShareRoles", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/shareRoles", "json", req, runtime), new GetShareRolesResponse());
    }

    public QueryGroupIdResponse queryGroupId(QueryGroupIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryGroupIdHeaders headers = new QueryGroupIdHeaders();
        return this.queryGroupIdWithOptions(request, headers, runtime);
    }

    public QueryGroupIdResponse queryGroupIdWithOptions(QueryGroupIdRequest request, QueryGroupIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
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
        return TeaModel.toModel(this.doROARequest("QueryGroupId", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/faces/groups", "json", req, runtime), new QueryGroupIdResponse());
    }

    public SubscribeUniversityCourseGroupResponse subscribeUniversityCourseGroup(SubscribeUniversityCourseGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SubscribeUniversityCourseGroupHeaders headers = new SubscribeUniversityCourseGroupHeaders();
        return this.subscribeUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    public SubscribeUniversityCourseGroupResponse subscribeUniversityCourseGroupWithOptions(SubscribeUniversityCourseGroupRequest request, SubscribeUniversityCourseGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            body.put("courseGroupCode", request.courseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserIds)) {
            body.put("studentUserIds", request.studentUserIds);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SubscribeUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courseGroups/subscribe", "json", req, runtime), new SubscribeUniversityCourseGroupResponse());
    }

    public DeleteOrgRelationResponse deleteOrgRelation(DeleteOrgRelationRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteOrgRelationHeaders headers = new DeleteOrgRelationHeaders();
        return this.deleteOrgRelationWithOptions(request, headers, runtime);
    }

    public DeleteOrgRelationResponse deleteOrgRelationWithOptions(DeleteOrgRelationRequest request, DeleteOrgRelationHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            query.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            query.put("authCode", request.authCode);
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
        return TeaModel.toModel(this.doROARequest("DeleteOrgRelation", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/remoteClasses/orgRelations", "json", req, runtime), new DeleteOrgRelationResponse());
    }

    public StartCourseResponse startCourse(StartCourseRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        StartCourseHeaders headers = new StartCourseHeaders();
        return this.startCourseWithOptions(request, headers, runtime);
    }

    public StartCourseResponse startCourseWithOptions(StartCourseRequest request, StartCourseHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseCode)) {
            body.put("courseCode", request.courseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.livePlayInfoList)) {
            body.put("livePlayInfoList", request.livePlayInfoList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("StartCourse", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courses/start", "json", req, runtime), new StartCourseResponse());
    }

    public QueryPhysicalClassroomResponse queryPhysicalClassroom(QueryPhysicalClassroomRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryPhysicalClassroomHeaders headers = new QueryPhysicalClassroomHeaders();
        return this.queryPhysicalClassroomWithOptions(request, headers, runtime);
    }

    public QueryPhysicalClassroomResponse queryPhysicalClassroomWithOptions(QueryPhysicalClassroomRequest request, QueryPhysicalClassroomHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomId)) {
            query.put("classroomId", request.classroomId);
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
        return TeaModel.toModel(this.doROARequest("QueryPhysicalClassroom", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime), new QueryPhysicalClassroomResponse());
    }

    public UpdateRemoteClassCourseResponse updateRemoteClassCourse(UpdateRemoteClassCourseRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateRemoteClassCourseHeaders headers = new UpdateRemoteClassCourseHeaders();
        return this.updateRemoteClassCourseWithOptions(request, headers, runtime);
    }

    public UpdateRemoteClassCourseResponse updateRemoteClassCourseWithOptions(UpdateRemoteClassCourseRequest request, UpdateRemoteClassCourseHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseName)) {
            body.put("courseName", request.courseName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.teachingParticipant))) {
            body.put("teachingParticipant", request.teachingParticipant);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.attendParticipants)) {
            body.put("attendParticipants", request.attendParticipants);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseCode)) {
            body.put("courseCode", request.courseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingClientId)) {
            body.put("dingClientId", request.dingClientId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
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

        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            body.put("authCode", request.authCode);
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
        return TeaModel.toModel(this.doROARequest("UpdateRemoteClassCourse", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/remoteClasses/courses", "json", req, runtime), new UpdateRemoteClassCourseResponse());
    }

    public UnsubscribeUniversityCourseGroupResponse unsubscribeUniversityCourseGroup(UnsubscribeUniversityCourseGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UnsubscribeUniversityCourseGroupHeaders headers = new UnsubscribeUniversityCourseGroupHeaders();
        return this.unsubscribeUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    public UnsubscribeUniversityCourseGroupResponse unsubscribeUniversityCourseGroupWithOptions(UnsubscribeUniversityCourseGroupRequest request, UnsubscribeUniversityCourseGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            body.put("courseGroupCode", request.courseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserIds)) {
            body.put("studentUserIds", request.studentUserIds);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UnsubscribeUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courseGroups/unsubscribe", "json", req, runtime), new UnsubscribeUniversityCourseGroupResponse());
    }

    public QueryOrgSecretKeyResponse queryOrgSecretKey(QueryOrgSecretKeyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryOrgSecretKeyHeaders headers = new QueryOrgSecretKeyHeaders();
        return this.queryOrgSecretKeyWithOptions(request, headers, runtime);
    }

    public QueryOrgSecretKeyResponse queryOrgSecretKeyWithOptions(QueryOrgSecretKeyRequest request, QueryOrgSecretKeyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            query.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("QueryOrgSecretKey", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/universities/secretKeys", "json", req, runtime), new QueryOrgSecretKeyResponse());
    }

    public SearchTeachersResponse searchTeachers(SearchTeachersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SearchTeachersHeaders headers = new SearchTeachersHeaders();
        return this.searchTeachersWithOptions(request, headers, runtime);
    }

    public SearchTeachersResponse searchTeachersWithOptions(SearchTeachersRequest request, SearchTeachersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nameKeyword)) {
            query.put("nameKeyword", request.nameKeyword);
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
        return TeaModel.toModel(this.doROARequest("SearchTeachers", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/teachers/search", "json", req, runtime), new SearchTeachersResponse());
    }

    public DeletePhysicalClassroomResponse deletePhysicalClassroom(DeletePhysicalClassroomRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeletePhysicalClassroomHeaders headers = new DeletePhysicalClassroomHeaders();
        return this.deletePhysicalClassroomWithOptions(request, headers, runtime);
    }

    public DeletePhysicalClassroomResponse deletePhysicalClassroomWithOptions(DeletePhysicalClassroomRequest request, DeletePhysicalClassroomHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomId)) {
            query.put("classroomId", request.classroomId);
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
        return TeaModel.toModel(this.doROARequest("DeletePhysicalClassroom", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime), new DeletePhysicalClassroomResponse());
    }

    public QueryOrgRelationListResponse queryOrgRelationList(QueryOrgRelationListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryOrgRelationListHeaders headers = new QueryOrgRelationListHeaders();
        return this.queryOrgRelationListWithOptions(request, headers, runtime);
    }

    public QueryOrgRelationListResponse queryOrgRelationListWithOptions(QueryOrgRelationListRequest request, QueryOrgRelationListHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryOrgRelationList", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/orgRelations", "json", req, runtime), new QueryOrgRelationListResponse());
    }

    public QuerySchoolUserFaceResponse querySchoolUserFace(QuerySchoolUserFaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QuerySchoolUserFaceHeaders headers = new QuerySchoolUserFaceHeaders();
        return this.querySchoolUserFaceWithOptions(request, headers, runtime);
    }

    public QuerySchoolUserFaceResponse querySchoolUserFaceWithOptions(QuerySchoolUserFaceRequest request, QuerySchoolUserFaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QuerySchoolUserFace", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/schools/faces", "json", req, runtime), new QuerySchoolUserFaceResponse());
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

    public DeleteUniversityStudentResponse deleteUniversityStudent(DeleteUniversityStudentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteUniversityStudentHeaders headers = new DeleteUniversityStudentHeaders();
        return this.deleteUniversityStudentWithOptions(request, headers, runtime);
    }

    public DeleteUniversityStudentResponse deleteUniversityStudentWithOptions(DeleteUniversityStudentRequest request, DeleteUniversityStudentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            query.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserId)) {
            query.put("studentUserId", request.studentUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("DeleteUniversityStudent", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/universities/students", "json", req, runtime), new DeleteUniversityStudentResponse());
    }

    public EndCourseResponse endCourse(EndCourseRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EndCourseHeaders headers = new EndCourseHeaders();
        return this.endCourseWithOptions(request, headers, runtime);
    }

    public EndCourseResponse endCourseWithOptions(EndCourseRequest request, EndCourseHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseCode)) {
            body.put("courseCode", request.courseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.livePlayInfoList)) {
            body.put("livePlayInfoList", request.livePlayInfoList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("EndCourse", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courses/end", "json", req, runtime), new EndCourseResponse());
    }

    public GetShareRoleMembersResponse getShareRoleMembers(String shareRoleCode) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetShareRoleMembersHeaders headers = new GetShareRoleMembersHeaders();
        return this.getShareRoleMembersWithOptions(shareRoleCode, headers, runtime);
    }

    public GetShareRoleMembersResponse getShareRoleMembersWithOptions(String shareRoleCode, GetShareRoleMembersHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetShareRoleMembers", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/shareRoles/" + shareRoleCode + "/members", "json", req, runtime), new GetShareRoleMembersResponse());
    }

    public CreateUniversityTeacherResponse createUniversityTeacher(CreateUniversityTeacherRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateUniversityTeacherHeaders headers = new CreateUniversityTeacherHeaders();
        return this.createUniversityTeacherWithOptions(request, headers, runtime);
    }

    public CreateUniversityTeacherResponse createUniversityTeacherWithOptions(CreateUniversityTeacherRequest request, CreateUniversityTeacherHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            body.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserId)) {
            body.put("teacherUserId", request.teacherUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("CreateUniversityTeacher", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/teachers", "json", req, runtime), new CreateUniversityTeacherResponse());
    }
}
