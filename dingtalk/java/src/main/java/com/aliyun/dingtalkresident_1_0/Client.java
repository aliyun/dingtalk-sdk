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


    public UpdateResideceGroupResponse updateResideceGroup(UpdateResideceGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateResideceGroupHeaders headers = new UpdateResideceGroupHeaders();
        return this.updateResideceGroupWithOptions(request, headers, runtime);
    }

    public UpdateResideceGroupResponse updateResideceGroupWithOptions(UpdateResideceGroupRequest request, UpdateResideceGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.managerUserId)) {
            query.put("managerUserId", request.managerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentName)) {
            query.put("departmentName", request.departmentName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
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
        return TeaModel.toModel(this.doROARequest("UpdateResideceGroup", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/departments/updateResideceGroup", "json", req, runtime), new UpdateResideceGroupResponse());
    }

    public AddPointResponse addPoint(AddPointRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddPointHeaders headers = new AddPointHeaders();
        return this.addPointWithOptions(request, headers, runtime);
    }

    public AddPointResponse addPointWithOptions(AddPointRequest request, AddPointHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isCircle)) {
            query.put("isCircle", request.isCircle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            query.put("uuid", request.uuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ruleCode)) {
            query.put("ruleCode", request.ruleCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ruleName)) {
            query.put("ruleName", request.ruleName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.actionTime)) {
            query.put("actionTime", request.actionTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.score)) {
            query.put("score", request.score);
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
        return TeaModel.toModel(this.doROARequest("AddPoint", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/points", "none", req, runtime), new AddPointResponse());
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteResidentDepartment", "resident_1.0", "HTTP", "DELETE", "AK", "/v1.0/resident/departments", "json", req, runtime), new DeleteResidentDepartmentResponse());
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

        if (!com.aliyun.teautil.Common.isUnset(request.isLeaseholder)) {
            query.put("isLeaseholder", request.isLeaseholder);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userName)) {
            query.put("userName", request.userName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extField)) {
            query.put("extField", request.extField);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relateType)) {
            query.put("relateType", request.relateType);
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
        return TeaModel.toModel(this.doROARequest("AddResidentUsers", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/users", "json", req, runtime), new AddResidentUsersResponse());
    }

    public AddResidentDepartmentResponse addResidentDepartment(AddResidentDepartmentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddResidentDepartmentHeaders headers = new AddResidentDepartmentHeaders();
        return this.addResidentDepartmentWithOptions(request, headers, runtime);
    }

    public AddResidentDepartmentResponse addResidentDepartmentWithOptions(AddResidentDepartmentRequest request, AddResidentDepartmentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isResidenceGroup)) {
            query.put("isResidenceGroup", request.isResidenceGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentName)) {
            query.put("departmentName", request.departmentName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentDepartmentId)) {
            query.put("parentDepartmentId", request.parentDepartmentId);
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
        return TeaModel.toModel(this.doROARequest("AddResidentDepartment", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/departments", "json", req, runtime), new AddResidentDepartmentResponse());
    }

    public PagePointHistoryResponse pagePointHistory(PagePointHistoryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PagePointHistoryHeaders headers = new PagePointHistoryHeaders();
        return this.pagePointHistoryWithOptions(request, headers, runtime);
    }

    public PagePointHistoryResponse pagePointHistoryWithOptions(PagePointHistoryRequest request, PagePointHistoryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isCircle)) {
            query.put("isCircle", request.isCircle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("RemoveResidentUser", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/users/remove", "json", req, runtime), new RemoveResidentUserResponse());
    }

    public UpdateResidenceResponse updateResidence(UpdateResidenceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateResidenceHeaders headers = new UpdateResidenceHeaders();
        return this.updateResidenceWithOptions(request, headers, runtime);
    }

    public UpdateResidenceResponse updateResidenceWithOptions(UpdateResidenceRequest request, UpdateResidenceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.managerUserId)) {
            query.put("managerUserId", request.managerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentName)) {
            query.put("departmentName", request.departmentName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.grid)) {
            query.put("grid", request.grid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homeTel)) {
            query.put("homeTel", request.homeTel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.destitute)) {
            query.put("destitute", request.destitute);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentDepartmentId)) {
            query.put("parentDepartmentId", request.parentDepartmentId);
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
        return TeaModel.toModel(this.doROARequest("UpdateResidence", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/departments/updateResidece", "json", req, runtime), new UpdateResidenceResponse());
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListPointRules", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/points/rules", "json", req, runtime), new ListPointRulesResponse());
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

        if (!com.aliyun.teautil.Common.isUnset(request.isRetainOldDept)) {
            query.put("isRetainOldDept", request.isRetainOldDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userName)) {
            query.put("userName", request.userName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extField)) {
            query.put("extField", request.extField);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relateType)) {
            query.put("relateType", request.relateType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.oldDepartmentId)) {
            query.put("oldDepartmentId", request.oldDepartmentId);
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
        return TeaModel.toModel(this.doROARequest("UpdateResidentUser", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/users", "json", req, runtime), new UpdateResidentUserResponse());
    }
}
