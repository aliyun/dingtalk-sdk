// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkresident_1_0.models.*;
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


    public AddPointResponse addPoint(AddPointRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddPointHeaders headers = new AddPointHeaders();
        return this.addPointWithOptions(request, headers, runtime);
    }

    public AddPointResponse addPointWithOptions(AddPointRequest request, AddPointHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionTime)) {
            query.put("actionTime", request.actionTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isCircle)) {
            query.put("isCircle", request.isCircle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ruleCode)) {
            query.put("ruleCode", request.ruleCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ruleName)) {
            query.put("ruleName", request.ruleName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.score)) {
            query.put("score", request.score);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            query.put("uuid", request.uuid);
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
        return TeaModel.toModel(this.doROARequest("AddPoint", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/points", "none", req, runtime), new AddPointResponse());
    }

    public AddResidentDepartmentResponse addResidentDepartment(AddResidentDepartmentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddResidentDepartmentHeaders headers = new AddResidentDepartmentHeaders();
        return this.addResidentDepartmentWithOptions(request, headers, runtime);
    }

    public AddResidentDepartmentResponse addResidentDepartmentWithOptions(AddResidentDepartmentRequest request, AddResidentDepartmentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.departmentName)) {
            query.put("departmentName", request.departmentName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isResidenceGroup)) {
            query.put("isResidenceGroup", request.isResidenceGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentDepartmentId)) {
            query.put("parentDepartmentId", request.parentDepartmentId);
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
        return TeaModel.toModel(this.doROARequest("AddResidentDepartment", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/departments", "json", req, runtime), new AddResidentDepartmentResponse());
    }

    public AddResidentMemberResponse addResidentMember(AddResidentMemberRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddResidentMemberHeaders headers = new AddResidentMemberHeaders();
        return this.addResidentMemberWithOptions(request, headers, runtime);
    }

    public AddResidentMemberResponse addResidentMemberWithOptions(AddResidentMemberRequest request, AddResidentMemberHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.residentAddInfo))) {
            body.put("residentAddInfo", request.residentAddInfo);
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
        return TeaModel.toModel(this.doROARequest("AddResidentMember", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/members", "json", req, runtime), new AddResidentMemberResponse());
    }

    public AddResidentUsersResponse addResidentUsers(AddResidentUsersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddResidentUsersHeaders headers = new AddResidentUsersHeaders();
        return this.addResidentUsersWithOptions(request, headers, runtime);
    }

    public AddResidentUsersResponse addResidentUsersWithOptions(AddResidentUsersRequest request, AddResidentUsersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.address)) {
            query.put("address", request.address);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extField)) {
            query.put("extField", request.extField);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isLeaseholder)) {
            query.put("isLeaseholder", request.isLeaseholder);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relateType)) {
            query.put("relateType", request.relateType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userName)) {
            query.put("userName", request.userName);
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
        return TeaModel.toModel(this.doROARequest("AddResidentUsers", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/users", "json", req, runtime), new AddResidentUsersResponse());
    }

    public CreateResidentBlackBoardResponse createResidentBlackBoard(CreateResidentBlackBoardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateResidentBlackBoardHeaders headers = new CreateResidentBlackBoardHeaders();
        return this.createResidentBlackBoardWithOptions(request, headers, runtime);
    }

    public CreateResidentBlackBoardResponse createResidentBlackBoardWithOptions(CreateResidentBlackBoardRequest request, CreateResidentBlackBoardHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.context)) {
            body.put("context", request.context);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendTime)) {
            body.put("sendTime", request.sendTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
        return TeaModel.toModel(this.doROARequest("CreateResidentBlackBoard", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/blackboards", "json", req, runtime), new CreateResidentBlackBoardResponse());
    }

    public CreateSpaceResponse createSpace(CreateSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateSpaceHeaders headers = new CreateSpaceHeaders();
        return this.createSpaceWithOptions(request, headers, runtime);
    }

    public CreateSpaceResponse createSpaceWithOptions(CreateSpaceRequest request, CreateSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentDeptId)) {
            body.put("parentDeptId", request.parentDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagCode)) {
            body.put("tagCode", request.tagCode);
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
        return TeaModel.toModel(this.doROARequest("CreateSpace", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/spaces", "json", req, runtime), new CreateSpaceResponse());
    }

    public DeleteResidentBlackBoardResponse deleteResidentBlackBoard(DeleteResidentBlackBoardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteResidentBlackBoardHeaders headers = new DeleteResidentBlackBoardHeaders();
        return this.deleteResidentBlackBoardWithOptions(request, headers, runtime);
    }

    public DeleteResidentBlackBoardResponse deleteResidentBlackBoardWithOptions(DeleteResidentBlackBoardRequest request, DeleteResidentBlackBoardHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.blackboardId)) {
            query.put("blackboardId", request.blackboardId);
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
        return TeaModel.toModel(this.doROARequest("DeleteResidentBlackBoard", "resident_1.0", "HTTP", "DELETE", "AK", "/v1.0/resident/blackboards", "json", req, runtime), new DeleteResidentBlackBoardResponse());
    }

    public DeleteResidentDepartmentResponse deleteResidentDepartment(DeleteResidentDepartmentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteResidentDepartmentHeaders headers = new DeleteResidentDepartmentHeaders();
        return this.deleteResidentDepartmentWithOptions(request, headers, runtime);
    }

    public DeleteResidentDepartmentResponse deleteResidentDepartmentWithOptions(DeleteResidentDepartmentRequest request, DeleteResidentDepartmentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
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
        return TeaModel.toModel(this.doROARequest("DeleteResidentDepartment", "resident_1.0", "HTTP", "DELETE", "AK", "/v1.0/resident/departments", "json", req, runtime), new DeleteResidentDepartmentResponse());
    }

    public DeleteSpaceResponse deleteSpace(DeleteSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
        return this.deleteSpaceWithOptions(request, headers, runtime);
    }

    public DeleteSpaceResponse deleteSpaceWithOptions(DeleteSpaceRequest request, DeleteSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIds)) {
            body.put("deptIds", request.deptIds);
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
        return TeaModel.toModel(this.doROARequest("DeleteSpace", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/spaces/remove", "json", req, runtime), new DeleteSpaceResponse());
    }

    public GetConversationIdResponse getConversationId(GetConversationIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetConversationIdHeaders headers = new GetConversationIdHeaders();
        return this.getConversationIdWithOptions(request, headers, runtime);
    }

    public GetConversationIdResponse getConversationIdWithOptions(GetConversationIdRequest request, GetConversationIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.chatId)) {
            query.put("chatId", request.chatId);
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
        return TeaModel.toModel(this.doROARequest("GetConversationId", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/conversations", "json", req, runtime), new GetConversationIdResponse());
    }

    public GetIndustryTypeResponse getIndustryType() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetIndustryTypeHeaders headers = new GetIndustryTypeHeaders();
        return this.getIndustryTypeWithOptions(headers, runtime);
    }

    public GetIndustryTypeResponse getIndustryTypeWithOptions(GetIndustryTypeHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetIndustryType", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/organizations/industryTypes", "json", req, runtime), new GetIndustryTypeResponse());
    }

    public GetPropertyInfoResponse getPropertyInfo(GetPropertyInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetPropertyInfoHeaders headers = new GetPropertyInfoHeaders();
        return this.getPropertyInfoWithOptions(request, headers, runtime);
    }

    public GetPropertyInfoResponse getPropertyInfoWithOptions(GetPropertyInfoRequest request, GetPropertyInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.propertyCorpId)) {
            query.put("propertyCorpId", request.propertyCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetPropertyInfo", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/propertyInfos", "json", req, runtime), new GetPropertyInfoResponse());
    }

    public GetResidentInfoResponse getResidentInfo(GetResidentInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetResidentInfoHeaders headers = new GetResidentInfoHeaders();
        return this.getResidentInfoWithOptions(request, headers, runtime);
    }

    public GetResidentInfoResponse getResidentInfoWithOptions(GetResidentInfoRequest request, GetResidentInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.residentCorpId)) {
            query.put("residentCorpId", request.residentCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetResidentInfo", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/residentInfos", "json", req, runtime), new GetResidentInfoResponse());
    }

    public GetResidentMembersInfoResponse getResidentMembersInfo(GetResidentMembersInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetResidentMembersInfoHeaders headers = new GetResidentMembersInfoHeaders();
        return this.getResidentMembersInfoWithOptions(request, headers, runtime);
    }

    public GetResidentMembersInfoResponse getResidentMembersInfoWithOptions(GetResidentMembersInfoRequest request, GetResidentMembersInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.residentCropId)) {
            body.put("residentCropId", request.residentCropId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetResidentMembersInfo", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/residences/query", "json", req, runtime), new GetResidentMembersInfoResponse());
    }

    public GetSpaceIdByTypeResponse getSpaceIdByType(GetSpaceIdByTypeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetSpaceIdByTypeHeaders headers = new GetSpaceIdByTypeHeaders();
        return this.getSpaceIdByTypeWithOptions(request, headers, runtime);
    }

    public GetSpaceIdByTypeResponse getSpaceIdByTypeWithOptions(GetSpaceIdByTypeRequest request, GetSpaceIdByTypeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.departmentType)) {
            query.put("departmentType", request.departmentType);
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
        return TeaModel.toModel(this.doROARequest("GetSpaceIdByType", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/spaces/types", "json", req, runtime), new GetSpaceIdByTypeResponse());
    }

    public GetSpacesInfoResponse getSpacesInfo(GetSpacesInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetSpacesInfoHeaders headers = new GetSpacesInfoHeaders();
        return this.getSpacesInfoWithOptions(request, headers, runtime);
    }

    public GetSpacesInfoResponse getSpacesInfoWithOptions(GetSpacesInfoRequest request, GetSpacesInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.referIds)) {
            body.put("referIds", request.referIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.residentCorpId)) {
            body.put("residentCorpId", request.residentCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetSpacesInfo", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/spaces/query", "json", req, runtime), new GetSpacesInfoResponse());
    }

    public ListPointRulesResponse listPointRules(ListPointRulesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListPointRulesHeaders headers = new ListPointRulesHeaders();
        return this.listPointRulesWithOptions(request, headers, runtime);
    }

    public ListPointRulesResponse listPointRulesWithOptions(ListPointRulesRequest request, ListPointRulesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isCircle)) {
            query.put("isCircle", request.isCircle);
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
        return TeaModel.toModel(this.doROARequest("ListPointRules", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/points/rules", "json", req, runtime), new ListPointRulesResponse());
    }

    public ListSubSpaceResponse listSubSpace(ListSubSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListSubSpaceHeaders headers = new ListSubSpaceHeaders();
        return this.listSubSpaceWithOptions(request, headers, runtime);
    }

    public ListSubSpaceResponse listSubSpaceWithOptions(ListSubSpaceRequest request, ListSubSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.referId)) {
            query.put("referId", request.referId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.residentCorpId)) {
            query.put("residentCorpId", request.residentCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListSubSpace", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/spaces/subSpaces", "json", req, runtime), new ListSubSpaceResponse());
    }

    public ListUncheckUsersResponse listUncheckUsers(ListUncheckUsersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListUncheckUsersHeaders headers = new ListUncheckUsersHeaders();
        return this.listUncheckUsersWithOptions(request, headers, runtime);
    }

    public ListUncheckUsersResponse listUncheckUsersWithOptions(ListUncheckUsersRequest request, ListUncheckUsersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            query.put("status", request.status);
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
        return TeaModel.toModel(this.doROARequest("ListUncheckUsers", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/organizations/noJoinUsers", "json", req, runtime), new ListUncheckUsersResponse());
    }

    public PagePointHistoryResponse pagePointHistory(PagePointHistoryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PagePointHistoryHeaders headers = new PagePointHistoryHeaders();
        return this.pagePointHistoryWithOptions(request, headers, runtime);
    }

    public PagePointHistoryResponse pagePointHistoryWithOptions(PagePointHistoryRequest request, PagePointHistoryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isCircle)) {
            query.put("isCircle", request.isCircle);
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
        return TeaModel.toModel(this.doROARequest("PagePointHistory", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/points/records", "json", req, runtime), new PagePointHistoryResponse());
    }

    public RemoveResidentUserResponse removeResidentUser(RemoveResidentUserRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RemoveResidentUserHeaders headers = new RemoveResidentUserHeaders();
        return this.removeResidentUserWithOptions(request, headers, runtime);
    }

    public RemoveResidentUserResponse removeResidentUserWithOptions(RemoveResidentUserRequest request, RemoveResidentUserHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
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
        return TeaModel.toModel(this.doROARequest("RemoveResidentUser", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/users/remove", "json", req, runtime), new RemoveResidentUserResponse());
    }

    public SearchResidentResponse searchResident(SearchResidentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SearchResidentHeaders headers = new SearchResidentHeaders();
        return this.searchResidentWithOptions(request, headers, runtime);
    }

    public SearchResidentResponse searchResidentWithOptions(SearchResidentRequest request, SearchResidentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.residentCropId)) {
            query.put("residentCropId", request.residentCropId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchWord)) {
            query.put("searchWord", request.searchWord);
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
        return TeaModel.toModel(this.doROARequest("SearchResident", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/residences", "json", req, runtime), new SearchResidentResponse());
    }

    public UpdateResideceGroupResponse updateResideceGroup(UpdateResideceGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateResideceGroupHeaders headers = new UpdateResideceGroupHeaders();
        return this.updateResideceGroupWithOptions(request, headers, runtime);
    }

    public UpdateResideceGroupResponse updateResideceGroupWithOptions(UpdateResideceGroupRequest request, UpdateResideceGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentName)) {
            query.put("departmentName", request.departmentName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerUserId)) {
            query.put("managerUserId", request.managerUserId);
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
        return TeaModel.toModel(this.doROARequest("UpdateResideceGroup", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/departments/updateResideceGroup", "json", req, runtime), new UpdateResideceGroupResponse());
    }

    public UpdateResidenceResponse updateResidence(UpdateResidenceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateResidenceHeaders headers = new UpdateResidenceHeaders();
        return this.updateResidenceWithOptions(request, headers, runtime);
    }

    public UpdateResidenceResponse updateResidenceWithOptions(UpdateResidenceRequest request, UpdateResidenceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentName)) {
            query.put("departmentName", request.departmentName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.destitute)) {
            query.put("destitute", request.destitute);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.grid)) {
            query.put("grid", request.grid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homeTel)) {
            query.put("homeTel", request.homeTel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerUserId)) {
            query.put("managerUserId", request.managerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentDepartmentId)) {
            query.put("parentDepartmentId", request.parentDepartmentId);
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
        return TeaModel.toModel(this.doROARequest("UpdateResidence", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/departments/updateResidece", "json", req, runtime), new UpdateResidenceResponse());
    }

    public UpdateResidentBlackBoardResponse updateResidentBlackBoard(UpdateResidentBlackBoardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateResidentBlackBoardHeaders headers = new UpdateResidentBlackBoardHeaders();
        return this.updateResidentBlackBoardWithOptions(request, headers, runtime);
    }

    public UpdateResidentBlackBoardResponse updateResidentBlackBoardWithOptions(UpdateResidentBlackBoardRequest request, UpdateResidentBlackBoardHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.blackboardId)) {
            body.put("blackboardId", request.blackboardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.context)) {
            body.put("context", request.context);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
        return TeaModel.toModel(this.doROARequest("UpdateResidentBlackBoard", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/blackboards", "json", req, runtime), new UpdateResidentBlackBoardResponse());
    }

    public UpdateResidentInfoResponse updateResidentInfo(UpdateResidentInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateResidentInfoHeaders headers = new UpdateResidentInfoHeaders();
        return this.updateResidentInfoWithOptions(request, headers, runtime);
    }

    public UpdateResidentInfoResponse updateResidentInfoWithOptions(UpdateResidentInfoRequest request, UpdateResidentInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.address)) {
            body.put("address", request.address);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.communityType)) {
            body.put("communityType", request.communityType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.state)) {
            body.put("state", request.state);
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
        return TeaModel.toModel(this.doROARequest("UpdateResidentInfo", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/residences", "json", req, runtime), new UpdateResidentInfoResponse());
    }

    public UpdateResidentMemberResponse updateResidentMember(UpdateResidentMemberRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateResidentMemberHeaders headers = new UpdateResidentMemberHeaders();
        return this.updateResidentMemberWithOptions(request, headers, runtime);
    }

    public UpdateResidentMemberResponse updateResidentMemberWithOptions(UpdateResidentMemberRequest request, UpdateResidentMemberHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.residentUpdateInfo))) {
            body.put("residentUpdateInfo", request.residentUpdateInfo);
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
        return TeaModel.toModel(this.doROARequest("UpdateResidentMember", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/members", "json", req, runtime), new UpdateResidentMemberResponse());
    }

    public UpdateResidentUserResponse updateResidentUser(UpdateResidentUserRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateResidentUserHeaders headers = new UpdateResidentUserHeaders();
        return this.updateResidentUserWithOptions(request, headers, runtime);
    }

    public UpdateResidentUserResponse updateResidentUserWithOptions(UpdateResidentUserRequest request, UpdateResidentUserHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.address)) {
            query.put("address", request.address);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extField)) {
            query.put("extField", request.extField);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isRetainOldDept)) {
            query.put("isRetainOldDept", request.isRetainOldDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.oldDepartmentId)) {
            query.put("oldDepartmentId", request.oldDepartmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relateType)) {
            query.put("relateType", request.relateType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userName)) {
            query.put("userName", request.userName);
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
        return TeaModel.toModel(this.doROARequest("UpdateResidentUser", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/users", "json", req, runtime), new UpdateResidentUserResponse());
    }

    public UpdateSpaceResponse updateSpace(UpdateSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateSpaceHeaders headers = new UpdateSpaceHeaders();
        return this.updateSpaceWithOptions(request, headers, runtime);
    }

    public UpdateSpaceResponse updateSpaceWithOptions(UpdateSpaceRequest request, UpdateSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.spaceInfoVOList)) {
            body.put("spaceInfoVOList", request.spaceInfoVOList);
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
        return TeaModel.toModel(this.doROARequest("UpdateSpace", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/spaces", "json", req, runtime), new UpdateSpaceResponse());
    }
}
