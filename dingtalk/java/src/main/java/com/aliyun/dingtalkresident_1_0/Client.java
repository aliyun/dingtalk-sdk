// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkresident_1_0.models.*;

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
     * <p>增加积分</p>
     * 
     * @param request AddPointRequest
     * @param headers AddPointHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddPointResponse
     */
    public AddPointResponse addPointWithOptions(AddPointRequest request, AddPointHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddPoint"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/points"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddPointResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>增加积分</p>
     * 
     * @param request AddPointRequest
     * @return AddPointResponse
     */
    public AddPointResponse addPoint(AddPointRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddPointHeaders headers = new AddPointHeaders();
        return this.addPointWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>增加组户</p>
     * 
     * @param request AddResidentDepartmentRequest
     * @param headers AddResidentDepartmentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddResidentDepartmentResponse
     */
    public AddResidentDepartmentResponse addResidentDepartmentWithOptions(AddResidentDepartmentRequest request, AddResidentDepartmentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddResidentDepartment"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/departments"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddResidentDepartmentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>增加组户</p>
     * 
     * @param request AddResidentDepartmentRequest
     * @return AddResidentDepartmentResponse
     */
    public AddResidentDepartmentResponse addResidentDepartment(AddResidentDepartmentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddResidentDepartmentHeaders headers = new AddResidentDepartmentHeaders();
        return this.addResidentDepartmentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加小区成员</p>
     * 
     * @param request AddResidentMemberRequest
     * @param headers AddResidentMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddResidentMemberResponse
     */
    public AddResidentMemberResponse addResidentMemberWithOptions(AddResidentMemberRequest request, AddResidentMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.residentAddInfo)) {
            body.put("residentAddInfo", request.residentAddInfo);
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
            new TeaPair("action", "AddResidentMember"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/members"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddResidentMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加小区成员</p>
     * 
     * @param request AddResidentMemberRequest
     * @return AddResidentMemberResponse
     */
    public AddResidentMemberResponse addResidentMember(AddResidentMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddResidentMemberHeaders headers = new AddResidentMemberHeaders();
        return this.addResidentMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增居民</p>
     * 
     * @param request AddResidentUsersRequest
     * @param headers AddResidentUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddResidentUsersResponse
     */
    public AddResidentUsersResponse addResidentUsersWithOptions(AddResidentUsersRequest request, AddResidentUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddResidentUsers"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/users"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddResidentUsersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增居民</p>
     * 
     * @param request AddResidentUsersRequest
     * @return AddResidentUsersResponse
     */
    public AddResidentUsersResponse addResidentUsers(AddResidentUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddResidentUsersHeaders headers = new AddResidentUsersHeaders();
        return this.addResidentUsersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建小区公告</p>
     * 
     * @param request CreateResidentBlackBoardRequest
     * @param headers CreateResidentBlackBoardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateResidentBlackBoardResponse
     */
    public CreateResidentBlackBoardResponse createResidentBlackBoardWithOptions(CreateResidentBlackBoardRequest request, CreateResidentBlackBoardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateResidentBlackBoard"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/blackboards"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateResidentBlackBoardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建小区公告</p>
     * 
     * @param request CreateResidentBlackBoardRequest
     * @return CreateResidentBlackBoardResponse
     */
    public CreateResidentBlackBoardResponse createResidentBlackBoard(CreateResidentBlackBoardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateResidentBlackBoardHeaders headers = new CreateResidentBlackBoardHeaders();
        return this.createResidentBlackBoardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建小区空间，含分区，楼栋，单元，房屋等</p>
     * 
     * @param request CreateSpaceRequest
     * @param headers CreateSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateSpaceResponse
     */
    public CreateSpaceResponse createSpaceWithOptions(CreateSpaceRequest request, CreateSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.billingArea)) {
            body.put("billingArea", request.billingArea);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.buildingArea)) {
            body.put("buildingArea", request.buildingArea);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.floor)) {
            body.put("floor", request.floor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.houseState)) {
            body.put("houseState", request.houseState);
        }

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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateSpace"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/spaces"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建小区空间，含分区，楼栋，单元，房屋等</p>
     * 
     * @param request CreateSpaceRequest
     * @return CreateSpaceResponse
     */
    public CreateSpaceResponse createSpace(CreateSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSpaceHeaders headers = new CreateSpaceHeaders();
        return this.createSpaceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除小区公告</p>
     * 
     * @param request DeleteResidentBlackBoardRequest
     * @param headers DeleteResidentBlackBoardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteResidentBlackBoardResponse
     */
    public DeleteResidentBlackBoardResponse deleteResidentBlackBoardWithOptions(DeleteResidentBlackBoardRequest request, DeleteResidentBlackBoardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteResidentBlackBoard"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/blackboards"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteResidentBlackBoardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除小区公告</p>
     * 
     * @param request DeleteResidentBlackBoardRequest
     * @return DeleteResidentBlackBoardResponse
     */
    public DeleteResidentBlackBoardResponse deleteResidentBlackBoard(DeleteResidentBlackBoardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteResidentBlackBoardHeaders headers = new DeleteResidentBlackBoardHeaders();
        return this.deleteResidentBlackBoardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除组户信息</p>
     * 
     * @param request DeleteResidentDepartmentRequest
     * @param headers DeleteResidentDepartmentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteResidentDepartmentResponse
     */
    public DeleteResidentDepartmentResponse deleteResidentDepartmentWithOptions(DeleteResidentDepartmentRequest request, DeleteResidentDepartmentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteResidentDepartment"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/departments"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteResidentDepartmentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除组户信息</p>
     * 
     * @param request DeleteResidentDepartmentRequest
     * @return DeleteResidentDepartmentResponse
     */
    public DeleteResidentDepartmentResponse deleteResidentDepartment(DeleteResidentDepartmentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteResidentDepartmentHeaders headers = new DeleteResidentDepartmentHeaders();
        return this.deleteResidentDepartmentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除小区空间，含分区，楼栋，单元，房屋</p>
     * 
     * @param request DeleteSpaceRequest
     * @param headers DeleteSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteSpaceResponse
     */
    public DeleteSpaceResponse deleteSpaceWithOptions(DeleteSpaceRequest request, DeleteSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteSpace"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/spaces/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除小区空间，含分区，楼栋，单元，房屋</p>
     * 
     * @param request DeleteSpaceRequest
     * @return DeleteSpaceResponse
     */
    public DeleteSpaceResponse deleteSpace(DeleteSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
        return this.deleteSpaceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定群的openConversationId</p>
     * 
     * @param request GetConversationIdRequest
     * @param headers GetConversationIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetConversationIdResponse
     */
    public GetConversationIdResponse getConversationIdWithOptions(GetConversationIdRequest request, GetConversationIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetConversationId"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/conversations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetConversationIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定群的openConversationId</p>
     * 
     * @param request GetConversationIdRequest
     * @return GetConversationIdResponse
     */
    public GetConversationIdResponse getConversationId(GetConversationIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetConversationIdHeaders headers = new GetConversationIdHeaders();
        return this.getConversationIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织的行业类型</p>
     * 
     * @param headers GetIndustryTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetIndustryTypeResponse
     */
    public GetIndustryTypeResponse getIndustryTypeWithOptions(GetIndustryTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetIndustryType"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/organizations/industryTypes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetIndustryTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织的行业类型</p>
     * @return GetIndustryTypeResponse
     */
    public GetIndustryTypeResponse getIndustryType() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetIndustryTypeHeaders headers = new GetIndustryTypeHeaders();
        return this.getIndustryTypeWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取物业公司信息</p>
     * 
     * @param request GetPropertyInfoRequest
     * @param headers GetPropertyInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPropertyInfoResponse
     */
    public GetPropertyInfoResponse getPropertyInfoWithOptions(GetPropertyInfoRequest request, GetPropertyInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetPropertyInfo"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/propertyInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPropertyInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取物业公司信息</p>
     * 
     * @param request GetPropertyInfoRequest
     * @return GetPropertyInfoResponse
     */
    public GetPropertyInfoResponse getPropertyInfo(GetPropertyInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPropertyInfoHeaders headers = new GetPropertyInfoHeaders();
        return this.getPropertyInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取小区信息</p>
     * 
     * @param request GetResidentInfoRequest
     * @param headers GetResidentInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetResidentInfoResponse
     */
    public GetResidentInfoResponse getResidentInfoWithOptions(GetResidentInfoRequest request, GetResidentInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetResidentInfo"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/residentInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetResidentInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取小区信息</p>
     * 
     * @param request GetResidentInfoRequest
     * @return GetResidentInfoResponse
     */
    public GetResidentInfoResponse getResidentInfo(GetResidentInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetResidentInfoHeaders headers = new GetResidentInfoHeaders();
        return this.getResidentInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取小区人员信息，包括居民和物业人员</p>
     * 
     * @param request GetResidentMembersInfoRequest
     * @param headers GetResidentMembersInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetResidentMembersInfoResponse
     */
    public GetResidentMembersInfoResponse getResidentMembersInfoWithOptions(GetResidentMembersInfoRequest request, GetResidentMembersInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetResidentMembersInfo"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/residences/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetResidentMembersInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取小区人员信息，包括居民和物业人员</p>
     * 
     * @param request GetResidentMembersInfoRequest
     * @return GetResidentMembersInfoResponse
     */
    public GetResidentMembersInfoResponse getResidentMembersInfo(GetResidentMembersInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetResidentMembersInfoHeaders headers = new GetResidentMembersInfoHeaders();
        return this.getResidentMembersInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据类型获取部门id</p>
     * 
     * @param request GetSpaceIdByTypeRequest
     * @param headers GetSpaceIdByTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSpaceIdByTypeResponse
     */
    public GetSpaceIdByTypeResponse getSpaceIdByTypeWithOptions(GetSpaceIdByTypeRequest request, GetSpaceIdByTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSpaceIdByType"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/spaces/types"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSpaceIdByTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据类型获取部门id</p>
     * 
     * @param request GetSpaceIdByTypeRequest
     * @return GetSpaceIdByTypeResponse
     */
    public GetSpaceIdByTypeResponse getSpaceIdByType(GetSpaceIdByTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSpaceIdByTypeHeaders headers = new GetSpaceIdByTypeHeaders();
        return this.getSpaceIdByTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取空间信息</p>
     * 
     * @param request GetSpacesInfoRequest
     * @param headers GetSpacesInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSpacesInfoResponse
     */
    public GetSpacesInfoResponse getSpacesInfoWithOptions(GetSpacesInfoRequest request, GetSpacesInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSpacesInfo"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/spaces/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSpacesInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取空间信息</p>
     * 
     * @param request GetSpacesInfoRequest
     * @return GetSpacesInfoResponse
     */
    public GetSpacesInfoResponse getSpacesInfo(GetSpacesInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSpacesInfoHeaders headers = new GetSpacesInfoHeaders();
        return this.getSpacesInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取行业角色下的用户列表</p>
     * 
     * @param request ListIndustryRoleUsersRequest
     * @param headers ListIndustryRoleUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListIndustryRoleUsersResponse
     */
    public ListIndustryRoleUsersResponse listIndustryRoleUsersWithOptions(ListIndustryRoleUsersRequest request, ListIndustryRoleUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tagCode)) {
            query.put("tagCode", request.tagCode);
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
            new TeaPair("action", "ListIndustryRoleUsers"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/industryRoles/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListIndustryRoleUsersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取行业角色下的用户列表</p>
     * 
     * @param request ListIndustryRoleUsersRequest
     * @return ListIndustryRoleUsersResponse
     */
    public ListIndustryRoleUsersResponse listIndustryRoleUsers(ListIndustryRoleUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListIndustryRoleUsersHeaders headers = new ListIndustryRoleUsersHeaders();
        return this.listIndustryRoleUsersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询组织维度配置的的积分规则</p>
     * 
     * @param request ListPointRulesRequest
     * @param headers ListPointRulesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListPointRulesResponse
     */
    public ListPointRulesResponse listPointRulesWithOptions(ListPointRulesRequest request, ListPointRulesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListPointRules"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/points/rules"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListPointRulesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询组织维度配置的的积分规则</p>
     * 
     * @param request ListPointRulesRequest
     * @return ListPointRulesResponse
     */
    public ListPointRulesResponse listPointRules(ListPointRulesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListPointRulesHeaders headers = new ListPointRulesHeaders();
        return this.listPointRulesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取子空间信息</p>
     * 
     * @param request ListSubSpaceRequest
     * @param headers ListSubSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListSubSpaceResponse
     */
    public ListSubSpaceResponse listSubSpaceWithOptions(ListSubSpaceRequest request, ListSubSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListSubSpace"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/spaces/subSpaces"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListSubSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取子空间信息</p>
     * 
     * @param request ListSubSpaceRequest
     * @return ListSubSpaceResponse
     */
    public ListSubSpaceResponse listSubSpace(ListSubSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSubSpaceHeaders headers = new ListSubSpaceHeaders();
        return this.listSubSpaceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取未确认加入组织的用户</p>
     * 
     * @param request ListUncheckUsersRequest
     * @param headers ListUncheckUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListUncheckUsersResponse
     */
    public ListUncheckUsersResponse listUncheckUsersWithOptions(ListUncheckUsersRequest request, ListUncheckUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListUncheckUsers"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/organizations/noJoinUsers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListUncheckUsersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取未确认加入组织的用户</p>
     * 
     * @param request ListUncheckUsersRequest
     * @return ListUncheckUsersResponse
     */
    public ListUncheckUsersResponse listUncheckUsers(ListUncheckUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListUncheckUsersHeaders headers = new ListUncheckUsersHeaders();
        return this.listUncheckUsersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户行业化角色</p>
     * 
     * @param request ListUserIndustryRolesRequest
     * @param headers ListUserIndustryRolesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListUserIndustryRolesResponse
     */
    public ListUserIndustryRolesResponse listUserIndustryRolesWithOptions(ListUserIndustryRolesRequest request, ListUserIndustryRolesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListUserIndustryRoles"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/users/industryRoles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListUserIndustryRolesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户行业化角色</p>
     * 
     * @param request ListUserIndustryRolesRequest
     * @return ListUserIndustryRolesResponse
     */
    public ListUserIndustryRolesResponse listUserIndustryRoles(ListUserIndustryRolesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListUserIndustryRolesHeaders headers = new ListUserIndustryRolesHeaders();
        return this.listUserIndustryRolesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询数字区县居民积分流水</p>
     * 
     * @param request PagePointHistoryRequest
     * @param headers PagePointHistoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PagePointHistoryResponse
     */
    public PagePointHistoryResponse pagePointHistoryWithOptions(PagePointHistoryRequest request, PagePointHistoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PagePointHistory"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/points/records"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PagePointHistoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询数字区县居民积分流水</p>
     * 
     * @param request PagePointHistoryRequest
     * @return PagePointHistoryResponse
     */
    public PagePointHistoryResponse pagePointHistory(PagePointHistoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PagePointHistoryHeaders headers = new PagePointHistoryHeaders();
        return this.pagePointHistoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>从空间中删除人员</p>
     * 
     * @param request RemoveResidentMemberRequest
     * @param headers RemoveResidentMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveResidentMemberResponse
     */
    public RemoveResidentMemberResponse removeResidentMemberWithOptions(RemoveResidentMemberRequest request, RemoveResidentMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "RemoveResidentMember"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/members/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveResidentMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>从空间中删除人员</p>
     * 
     * @param request RemoveResidentMemberRequest
     * @return RemoveResidentMemberResponse
     */
    public RemoveResidentMemberResponse removeResidentMember(RemoveResidentMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveResidentMemberHeaders headers = new RemoveResidentMemberHeaders();
        return this.removeResidentMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>从户内移除居民</p>
     * 
     * @param request RemoveResidentUserRequest
     * @param headers RemoveResidentUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveResidentUserResponse
     */
    public RemoveResidentUserResponse removeResidentUserWithOptions(RemoveResidentUserRequest request, RemoveResidentUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RemoveResidentUser"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/users/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveResidentUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>从户内移除居民</p>
     * 
     * @param request RemoveResidentUserRequest
     * @return RemoveResidentUserResponse
     */
    public RemoveResidentUserResponse removeResidentUser(RemoveResidentUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveResidentUserHeaders headers = new RemoveResidentUserHeaders();
        return this.removeResidentUserWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>搜索指定人员</p>
     * 
     * @param request SearchResidentRequest
     * @param headers SearchResidentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchResidentResponse
     */
    public SearchResidentResponse searchResidentWithOptions(SearchResidentRequest request, SearchResidentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SearchResident"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/residences"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchResidentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>搜索指定人员</p>
     * 
     * @param request SearchResidentRequest
     * @return SearchResidentResponse
     */
    public SearchResidentResponse searchResident(SearchResidentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchResidentHeaders headers = new SearchResidentHeaders();
        return this.searchResidentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新组信息</p>
     * 
     * @param request UpdateResideceGroupRequest
     * @param headers UpdateResideceGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateResideceGroupResponse
     */
    public UpdateResideceGroupResponse updateResideceGroupWithOptions(UpdateResideceGroupRequest request, UpdateResideceGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateResideceGroup"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/departments/updateResideceGroup"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateResideceGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新组信息</p>
     * 
     * @param request UpdateResideceGroupRequest
     * @return UpdateResideceGroupResponse
     */
    public UpdateResideceGroupResponse updateResideceGroup(UpdateResideceGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateResideceGroupHeaders headers = new UpdateResideceGroupHeaders();
        return this.updateResideceGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新户信息</p>
     * 
     * @param request UpdateResidenceRequest
     * @param headers UpdateResidenceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateResidenceResponse
     */
    public UpdateResidenceResponse updateResidenceWithOptions(UpdateResidenceRequest request, UpdateResidenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateResidence"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/departments/updateResidece"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateResidenceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新户信息</p>
     * 
     * @param request UpdateResidenceRequest
     * @return UpdateResidenceResponse
     */
    public UpdateResidenceResponse updateResidence(UpdateResidenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateResidenceHeaders headers = new UpdateResidenceHeaders();
        return this.updateResidenceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新小区公告</p>
     * 
     * @param request UpdateResidentBlackBoardRequest
     * @param headers UpdateResidentBlackBoardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateResidentBlackBoardResponse
     */
    public UpdateResidentBlackBoardResponse updateResidentBlackBoardWithOptions(UpdateResidentBlackBoardRequest request, UpdateResidentBlackBoardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateResidentBlackBoard"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/blackboards"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateResidentBlackBoardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新小区公告</p>
     * 
     * @param request UpdateResidentBlackBoardRequest
     * @return UpdateResidentBlackBoardResponse
     */
    public UpdateResidentBlackBoardResponse updateResidentBlackBoard(UpdateResidentBlackBoardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateResidentBlackBoardHeaders headers = new UpdateResidentBlackBoardHeaders();
        return this.updateResidentBlackBoardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新小区信息</p>
     * 
     * @param request UpdateResidentInfoRequest
     * @param headers UpdateResidentInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateResidentInfoResponse
     */
    public UpdateResidentInfoResponse updateResidentInfoWithOptions(UpdateResidentInfoRequest request, UpdateResidentInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.address)) {
            body.put("address", request.address);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.buildingArea)) {
            body.put("buildingArea", request.buildingArea);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cityName)) {
            body.put("cityName", request.cityName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.communityType)) {
            body.put("communityType", request.communityType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.countyName)) {
            body.put("countyName", request.countyName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.location)) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.provName)) {
            body.put("provName", request.provName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.state)) {
            body.put("state", request.state);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.telephone)) {
            body.put("telephone", request.telephone);
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
            new TeaPair("action", "UpdateResidentInfo"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/residences"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateResidentInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新小区信息</p>
     * 
     * @param request UpdateResidentInfoRequest
     * @return UpdateResidentInfoResponse
     */
    public UpdateResidentInfoResponse updateResidentInfo(UpdateResidentInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateResidentInfoHeaders headers = new UpdateResidentInfoHeaders();
        return this.updateResidentInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新小区成员</p>
     * 
     * @param request UpdateResidentMemberRequest
     * @param headers UpdateResidentMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateResidentMemberResponse
     */
    public UpdateResidentMemberResponse updateResidentMemberWithOptions(UpdateResidentMemberRequest request, UpdateResidentMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.residentUpdateInfo)) {
            body.put("residentUpdateInfo", request.residentUpdateInfo);
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
            new TeaPair("action", "UpdateResidentMember"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/members"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateResidentMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新小区成员</p>
     * 
     * @param request UpdateResidentMemberRequest
     * @return UpdateResidentMemberResponse
     */
    public UpdateResidentMemberResponse updateResidentMember(UpdateResidentMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateResidentMemberHeaders headers = new UpdateResidentMemberHeaders();
        return this.updateResidentMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新居民信息</p>
     * 
     * @param request UpdateResidentUserRequest
     * @param headers UpdateResidentUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateResidentUserResponse
     */
    public UpdateResidentUserResponse updateResidentUserWithOptions(UpdateResidentUserRequest request, UpdateResidentUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateResidentUser"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/users"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateResidentUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新居民信息</p>
     * 
     * @param request UpdateResidentUserRequest
     * @return UpdateResidentUserResponse
     */
    public UpdateResidentUserResponse updateResidentUser(UpdateResidentUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateResidentUserHeaders headers = new UpdateResidentUserHeaders();
        return this.updateResidentUserWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新小区空间，含分区，楼栋，单元，房屋等信息</p>
     * 
     * @param request UpdateSpaceRequest
     * @param headers UpdateSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateSpaceResponse
     */
    public UpdateSpaceResponse updateSpaceWithOptions(UpdateSpaceRequest request, UpdateSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateSpace"),
            new TeaPair("version", "resident_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/resident/spaces"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新小区空间，含分区，楼栋，单元，房屋等信息</p>
     * 
     * @param request UpdateSpaceRequest
     * @return UpdateSpaceResponse
     */
    public UpdateSpaceResponse updateSpace(UpdateSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateSpaceHeaders headers = new UpdateSpaceHeaders();
        return this.updateSpaceWithOptions(request, headers, runtime);
    }
}
